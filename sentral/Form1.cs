using System.Net.Sockets;
using System.Net;
using System.Text;

namespace sentral
{
    using Npgsql;
    using System.Net.Sockets;
    using System.Net;
    using System.Windows.Forms;
    using System.Text;
    using System.Globalization;

    public partial class Sentral : Form
    {
        bool ferdig;
        Socket sokkel;
        string dataFraKortleser;
        bool aktiv = false;

        public Sentral()
        {
            InitializeComponent();
            CreateTable();
            DisplayUserlist();

            ferdig = false;
            sokkel = null;
            dataFraKortleser = "";
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void leggTilBrukerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void avsluttToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnVisBrukera_Click(object sender, EventArgs e)
        {
            dgwBrukere.Rows.Clear();
            DisplayUserlist();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CreateTable()
        {
            var cs = "Host=20.56.240.122;Username=h116036;Password=p0stgr3s!;Database=h116036";

            using var con = new NpgsqlConnection(cs);
            con.Open();

            using var cmd = new NpgsqlCommand();
            cmd.Connection = con;

            // oppretter tabell med brukarar
            //cmd.CommandText = "DROP TABLE IF EXISTS brukar;";
            //cmd.ExecuteNonQuery();

            cmd.CommandText = "CREATE TABLE IF NOT EXISTS brukar (kortid INT PRIMARY KEY, fornavn VARCHAR(30), etternavn VARCHAR(30)," +
                " epost VARCHAR(50), pin INT, gyldighet DATE);";
            cmd.ExecuteNonQuery();

            // oppretter kort tabell
            cmd.CommandText = "DROP TABLE IF EXISTS kort;";
            cmd.ExecuteNonQuery();

            cmd.CommandText = "CREATE TABLE kort (kortid INT PRIMARY KEY, romnr INT);";
            cmd.ExecuteNonQuery();

            // oppretter tabell til log
            cmd.CommandText = "DROP TABLE IF EXISTS log";
            cmd.ExecuteNonQuery();

            cmd.CommandText = "CREATE TABLE log (kortid INT PRIMARY KEY, access BOOL, tidspunkt TIMESTAMP);";
            cmd.ExecuteNonQuery();

            con.Close();
        }

        public async void DisplayUserlist()
        {
            var connection = "Host=20.56.240.122;Username=h116036;Password=p0stgr3s!;Database=h116036";
            using (var con = new NpgsqlConnection(connection))
            {
                await con.OpenAsync();

                try
                {
                    await using (var cmd = new NpgsqlCommand($"SELECT * FROM brukar ORDER BY kortid ASC", con))
                    await using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            DataGridViewRow newRow = new DataGridViewRow();

                            newRow.CreateCells(dgwBrukere);
                            newRow.Cells[0].Value = reader.GetInt32(0);
                            newRow.Cells[1].Value = reader.GetString(1);
                            newRow.Cells[2].Value = reader.GetString(2);
                            newRow.Cells[3].Value = reader.GetString(3);
                            newRow.Cells[4].Value = reader.GetInt32(4);
                            newRow.Cells[5].Value = reader.GetDate(5);
                            dgwBrukere.Rows.Add(newRow);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error:\n\n{ex.Message}");
                }
            }
        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LeggTilBruker f2 = new LeggTilBruker();
            f2.Show();
        }

        private void deleteUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SlettBruker f3 = new SlettBruker();
            f3.Show();
        }

        private void bwHjelpetraad_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            if (!ferdig) Server();
        }

        private void bwHjelpetraad_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {

        }

        private void btnStartSentral_Click(object sender, EventArgs e)
        {
            btnStartSentral.Enabled = false;
            bwHjelpetraad.RunWorkerAsync();
        }

        private void txtServerStatus_TextChanged(object sender, EventArgs e)
        {

        }

        private void Server()
        {
            // Server settings
            Socket lytteSokkel = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint serverEP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9050);
            lytteSokkel.Bind(serverEP);
            lytteSokkel.Listen(10);

            // Server activity
            while (true)
            {
                // Waiting on clients
                txtServerStatus.Invoke(() => txtServerStatus.Text = "waiting for clients...");
                Socket kommSokkel = lytteSokkel.Accept();

                VisKommunikasjonsinfo(kommSokkel);

                ThreadPool.QueueUserWorkItem(KommunikasjonMedEnKlient, kommSokkel);
            }
            // lytteSokkel.Close();
        }

        public async void KommunikasjonMedEnKlient(object arg)
        {
            Socket kommSokkel = arg as Socket;

            string mottattTekst = "";
            bool tekstSomSkalSendes;

            bool ferdig = false;

            string hilsen = "Tilkobla sentral";
            SendTekst(kommSokkel, hilsen, out ferdig);

            while (!ferdig)
            {
                // Motta data fra en klient 
                mottattTekst = MottaTekst(kommSokkel, out ferdig);
                txtServerStatus.Invoke(() => txtServerStatus.Text = mottattTekst);
                string[] verdi = mottattTekst.Split('$');
                if (!ferdig)
                {
                    // reverserer tekst som er mottatt
                    tekstSomSkalSendes = await VerifiserKort(Convert.ToInt32(verdi[0]), Convert.ToInt32(verdi[1]));
                    

                    // Sende svar til klient
                    SendTekst(kommSokkel, Convert.ToString(tekstSomSkalSendes), out ferdig);
                }
            }
            // Lukker kommunikasjonssokkel og viser info
            IPEndPoint klientEP = kommSokkel.RemoteEndPoint as IPEndPoint;
            txtServerStatus.Invoke(() => txtServerStatus.Text = string.Format("Forbindelsen med {0}:{1} er brutt", klientEP.Address, klientEP.Port));
            kommSokkel.Close();
        }

        public string MottaTekst(Socket kommSokkel, out bool feilHarOppstått)
        {
            string svar = "";
            feilHarOppstått = false;

            try
            {
                byte[] data = new byte[1024];
                int antallBytesMottatt = kommSokkel.Receive(data);

                if (antallBytesMottatt > 0) svar = Encoding.ASCII.GetString(data, 0, antallBytesMottatt);
                else feilHarOppstått = true;
            }
            catch (Exception unntak)
            {
                MessageBox.Show("Feil: " + unntak.Message);
                feilHarOppstått = true;
            }
            return svar;
        }

        public void SendTekst(Socket kommSokkel, string tekstSomSkalSendes, out bool feilHarOppstått)
        {
            feilHarOppstått = false;

            try
            {
                byte[] data = Encoding.ASCII.GetBytes(tekstSomSkalSendes);
                kommSokkel.Send(data, data.Length, SocketFlags.None);
            }
            catch (Exception unntak)
            {
                Console.WriteLine("Feil: " + unntak.Message);
                feilHarOppstått = true;
            }
        }

        public string ReverserTekst(string tekst)
        {
            string svar = "";
            Console.WriteLine(tekst);
            Char[] mottattArray = tekst.ToCharArray();
            Array.Reverse(mottattArray);
            StringBuilder sb = new StringBuilder();
            foreach (char ch in mottattArray)
                sb.Append(ch);
            svar = sb.ToString();
            return svar;
        }

        public void VisKommunikasjonsinfo(Socket s)
        {
            IPEndPoint klientEP = s.RemoteEndPoint as IPEndPoint;
            IPEndPoint serverEP = s.LocalEndPoint as IPEndPoint;
            Console.WriteLine("Kommunikasjon med klient: {0}:{1}", klientEP.Address, klientEP.Port);
            Console.WriteLine("Server bruker {0}:{1}", serverEP.Address, serverEP.Port);
        }

        public static async Task<bool> VerifiserKort(int kortid, int pin)
        {
            bool svar = false;
            var tid = DateTime.Today;
            var connection = "Host=20.56.240.122;Username=h116036;Password=p0stgr3s!;Database=h116036";
            using (var con = new NpgsqlConnection(connection))
            {
                await con.OpenAsync();
                try
                {
                    await using (var cmd = new NpgsqlCommand($"SELECT gyldighet > '{tid}' FROM brukar WHERE kortid = {kortid} AND pin = {pin}", con))
                    await using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            svar = reader.GetBoolean(0);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error:\n\n{ex.Message}");
                }
            }
            return svar;
        }
    }
}