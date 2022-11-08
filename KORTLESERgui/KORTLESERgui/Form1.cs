using Microsoft.VisualBasic;
using System.IO.Ports;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace KORTLESERgui
{
    public partial class Form1 : Form
    {
        /*Variabler for simsom*/
        bool kommuniser;
        Thread hjelpetråd;
        SerialPort sp;
        string enMelding;
        string data;

        /*Variabler for sentral*/
        bool ferdig;
        Socket klientSokkel;
        string dataFraServer;

        public Form1()
        {
            InitializeComponent();
            OppdaterSeriellePorter();
            kommuniser = false;
        }

        /************KONTAKT MED SIMSIM*****************************************/
        void OppdaterSeriellePorter()
        {
            string[] allePorter = SerialPort.GetPortNames();
            for (int i = 0; i < allePorter.Length; i++)
            {
                cbAlleSeriellePorter.Items.Add(allePorter[i]);
            }
            if (cbAlleSeriellePorter.Items.Count > 0)
            {
                cbAlleSeriellePorter.SelectedIndex = 0;
            }
        }

        void SeriellPortKommunikasjon(object o)
        {
            string comPort = o as string;
        }

        void OppdaterGUI(string enMelding)
        {
            lbLogg.Items.Insert(0, enMelding);
        }

        static string HenteUtEnMelding(string data, ref string enMelding)
        {
            int posStart = data.IndexOf('$');
            int posSlutt = data.IndexOf('#');

            enMelding = data.Substring(posStart, (posSlutt - posStart) + 1);

            if (posStart > 0) data = data.Substring(posStart);
            if (enMelding.Length < data.Length) data = data.Substring(posSlutt + 1);
            else data = "";
            return data;
        }

        static bool DataInneholderEnHelMelding(string data)
        {
            bool svar = false;

            int posStart = data.IndexOf('$');
            int posSlutt = data.IndexOf('#');
            if (posStart != -1 && posSlutt != -1)
            {
                if (posStart < posSlutt)
                {
                    svar = true;
                }
            }
            return svar;
        }

        static string MottaData(SerialPort sp)
        {
            string svar = "";
            try
            {
                svar = sp.ReadExisting();
            }
            catch (Exception err)
            {
                MessageBox.Show("Feil: " + err.ToString());
            }
            return svar;
        }

        static void SendEnMelding(SerialPort s, string melding)
        {
            try
            {
                s.Write(melding);
            }
            catch (Exception err)
            {
                MessageBox.Show("Feil: " + err.ToString());
            }
        }

        private void btnLoggInn_Click(object sender, EventArgs e)
        {
            if (cbAlleSeriellePorter.SelectedIndex >= 0)
            {
                string comPort = cbAlleSeriellePorter.SelectedItem.ToString();
                btnLoggInn.Enabled = false;
                btnAvbryt.Enabled = true;
                kommuniser = true;

                sp = new SerialPort(comPort, 9600);

                try
                {
                    sp.Open();
                }
                catch (Exception err)
                {
                    MessageBox.Show("Feil: " + err.ToString());
                    btnLoggInn.Enabled = true;
                    btnAvbryt.Enabled = false;
                }

                if (sp.IsOpen)
                {
                    SendEnMelding(sp, "$S002");
                    bwSeriellKommunikasjon.RunWorkerAsync();
                }
            }
        }
        private void bwSeriellKommunikasjon_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            // Utføres av en hjelpetråd når RunWorkerAsync-brukes
            bool enHelMeldingMotatt = false;
            enMelding = "";

            while (kommuniser && !enHelMeldingMotatt)
            {
                data = data + MottaData(sp);


                if (DataInneholderEnHelMelding(data))
                {

                    data = HenteUtEnMelding(data, ref enMelding);

                    enHelMeldingMotatt = true;
                }
            }
        }
        private void bwSeriellKommunikasjon_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            // Utføres av gui-tråden når bw-hjelpetrådien har avsluttet
            if (kommuniser)
            {
                OppdaterGUI(enMelding);
                bwSeriellKommunikasjon.RunWorkerAsync();
            }
        }

        private void btnAvbryt_Click(object sender, EventArgs e)
        {
            btnAvbryt.Enabled = false;
            kommuniser = false;
            hjelpetråd.Join();
            btnAvbryt.Enabled = true;
        }

        /****************Klient*************************/
        static Socket KobleTilServer(out bool ferdig)
        {
            ferdig = false;
            Socket klientSokkel = new Socket(AddressFamily.InterNetwork,
            SocketType.Stream,
            ProtocolType.Tcp);
            IPEndPoint serverEP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9050);
            try
            {
                klientSokkel.Connect(serverEP);
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
                ferdig = true;
            }
            return klientSokkel;
        }
        static string MottaTekst(Socket kommSokkel, out bool feilHarOppstått)
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
            catch (Exception err)
            {
                MessageBox.Show("Feil:"+err.ToString());
                feilHarOppstått = false;
            }
            return svar;
        }
        static void SendTekst(Socket kommSokkel, string tekstSomSkalSendes, out bool feilHarOppstått)
        {
            feilHarOppstått = false;

            try
            {
                byte[] data = new byte[1024];
                int antallBytesMottatt = kommSokkel.Receive(data);
            }
            catch (Exception err)
            {
                MessageBox.Show("Feil: " + err.ToString());
                feilHarOppstått = true;
            }
        }

        private void btnSendMelding_Click(object sender, EventArgs e)
        {
            btnSendMelding.Enabled = false;
            bwHjelpetråd.RunWorkerAsync();
        }
        private void Klient_Load(object sender, EventArgs e)
        {
            klientSokkel = KobleTilServer(out ferdig);
            if (ferdig) Application.Exit();
            else
            {
                string velkomstmelding = MottaTekst(klientSokkel, out ferdig);
                if (ferdig) Application.Exit();
                else txtMottattTekst.Text = velkomstmelding;
            }
        }


        private void bwHjelpetråd_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            // Arbeid som utføres i en hjelpetråd
            if (!ferdig) SendTekst(klientSokkel, txtTekstSomSkalSendes.Text, out ferdig);
            if (!ferdig)
            {
                dataFraServer = MottaTekst(klientSokkel, out ferdig);
            }
        }

        private void bwHjelpetråd_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            // Arbeid som utføres av GUI-tråden når bwHjelpetråd_DoWork har avsluttet
            if (!ferdig) txtMottattTekst.Text = dataFraServer;
            btnSendMelding.Enabled = true;
        }
    }
}