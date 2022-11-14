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
        SerialPort sp;
        string enMelding;
        string data;
        string termist;

        /*Variabler for sentral*/
        Socket klientSokkel;
        List<string> Llogg = new List<string>();
        string pin = "";
        float time = 45;
        float dørÅpen = 15;
        bool DørÅpnet = false;


        public Form1()
        {
            InitializeComponent();
            OppdaterSeriellePorter();
        }

        /************KONTAKT MED SIMSIM*****************************************/
        void OppdaterSeriellePorter()
        {
            string[] allePorter = SerialPort.GetPortNames();

            for (int i = 0; i < allePorter.Length; i++) cbAlleSeriellePorter.Items.Add(allePorter[i]);
            if (cbAlleSeriellePorter.Items.Count > 0) cbAlleSeriellePorter.SelectedIndex = 1;
        }
        //Sender data til simsim
        public void SendData(SerialPort sp, String data)
        {
            try
            {
                sp.Write(data);
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
        }
        //Mottar data fra simsim
        static string MottaData(SerialPort sp)
        {
            string data = "";
            try
            {
                data = sp.ReadExisting();
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
            return data;
        }

        //Lagrer relevant data i en variabel slik at man kan få ut informasjonen
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

        //Passer på at vi får en hel melding før man stenger for mottak
        static bool DataInneholderEnHelMelding(string data)
        {
            bool svar = false;

            int posStart = data.IndexOf('$');
            int posSlutt = data.IndexOf('#');
            if (posStart != -1 && posSlutt != -1) if (posStart < posSlutt) svar = true;

            return svar;
        }
        //Analyserer kode fra simsim og sjekker for kode som skal brukes til å logge inn
        public void analyserKode(string kode)
        {
            int indexE = kode.IndexOf('E');

            if (kode[indexE + 1] == '1') pin += '0';
            else if (kode[indexE + 2] == '1') pin += '1';
            else if (kode[indexE + 3] == '1') pin += '2';
            else if (kode[indexE + 4] == '1') pin += '3';

            //Hvilken textbox info fra simsim skal til og legge til infoen
            if (pin.Length <= 4) txtKortID.Text = pin;
            else if (txtPIN.Text.Length < 4) txtPIN.Text += pin[pin.Length - 1].ToString();

            //Skrur av utgangsboks som er sendt fra simsim
            if (pin.Length > 0) SendData(sp, $"$O{pin[pin.Length - 1]}0");
        }
        //Analyserer kode fra simsim og sjekker for kode fra termistator
        public void analyserTermist(string kode)
        {
            termist = kode.Substring(kode.IndexOf('F') + 1, 4);

            if(Convert.ToInt32(termist) > 500)
            {
                txtDørÅpenLukket.Text = "Åpen";

                if (!lbAlarm.Items.Contains("Dør brutt opp")) lbAlarm.Items.Add("Dør brutt opp");

                SendData(sp, "$O71");
                SendTekst(klientSokkel, $"A{Llogg[0]}$0001");
            }
        }

        private void bwSeriellKommunikasjon_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            // Utføres av en hjelpetråd når RunWorkerAsync-brukes
            bool enHelMeldingMotatt = false;
            enMelding = "";

            while (!enHelMeldingMotatt)
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

            //Kjører metode for å sjekke hva data fra simsim inneholder
            analyserKode(enMelding);
            analyserTermist(enMelding);
            bwSeriellKommunikasjon.RunWorkerAsync();
        }

        /****************Klient*************************/
        private void Klient_Load(object sender, EventArgs e)
        {
            //Kobler til server
            klientSokkel = KobleTilServer();
            //Starter timer 
            timerTick.Start();
            Llogg.Add("0000$0000");

            if (cbAlleSeriellePorter.SelectedIndex >= 0)
            {
                string comPort = cbAlleSeriellePorter.SelectedItem.ToString();
                sp = new SerialPort(comPort, 9600);
                sp.Open();

                //Skrur på boks 4 i simsim
                SendData(sp, "$O41");
                bwSeriellKommunikasjon.RunWorkerAsync();
            }
            //Skrur på boks 5 i simsim
            SendData(sp, "$O51");
            label5.Text = MottaTekst(klientSokkel);
        }

        static Socket KobleTilServer()
        {
            Socket klientSokkel = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint serverEP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9050);
            try
            {
                klientSokkel.Connect(serverEP);
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
            return klientSokkel;
        }
        //Sender data til sentral
        static void SendTekst(Socket kommSokkel, string tekstSomSkalSendes)
        {
            try
            {
                byte[] data = Encoding.ASCII.GetBytes(tekstSomSkalSendes);
                kommSokkel.Send(data, data.Length, SocketFlags.None);
            }
            catch (Exception unntak)
            {
                MessageBox.Show("Feil: " + unntak.ToString());
            }
        }
        //Mottar data fra sentral
        static string MottaTekst(Socket kommSokkel)
        {
            string svar = "";
            try
            {
                byte[] data = new byte[1024];
                int antallBytesMottatt = kommSokkel.Receive(data);

                if (antallBytesMottatt > 0) svar = Encoding.ASCII.GetString(data, 0, antallBytesMottatt);
            }
            catch (Exception err)
            {
                MessageBox.Show("Feil:"+err.ToString());
            }
            return svar;
        }
        
        private void timerTick_Tick(object sender, EventArgs e)
        {
            //Enkel timer som reseter alle input hvis tid går ut
            if (time > 0) txtTid.Text = time--.ToString();
            else
            {
                if (time == 0)
                {
                    SendData(sp, "$O40");
                    txtKortlesernr.Text = "";
                    txtKortID.Text = "";
                    txtPIN.Text = "";
                    pin = "";
                    txtTid.Text = "0";
                    time = -1;
                }
                if((txtKortlesernr.Text.Length > 0 || txtKortID.Text.Length > 0 || txtPIN.Text.Length > 0) && time == -1)
                {
                    SendData(sp, "$O41");
                    time = 45;
                }  
            }
            //Sjekker om input er gyldig eller ikke og gir tilbakemelding
            if (txtKortlesernr.Text.Length == 4 && txtKortID.Text.Length == 4 && txtPIN.Text.Length == 4)
            {
                string sentralPin = $"{txtKortlesernr.Text}${txtKortID.Text}${txtPIN.Text}";
                Llogg.Add($"{txtKortlesernr.Text}${ txtKortID.Text}");
                if (Llogg.Count == 2) Llogg.RemoveAt(0);

                SendTekst(klientSokkel, "B" + sentralPin);
                string ValidKode = MottaTekst(klientSokkel);

                if (ValidKode == "True")
                {
                    SendData(sp, "$O50");
                    label6.Text = "Riktig";
                    txtDørLåstUlåst.Text = "Ulåst";
                }
                else if (ValidKode == "False") label6.Text = "Feil";
                txtSisteID.Text = $"{txtKortID.Text} {label6.Text}";
                txtKortlesernr.Text = "";
                txtKortID.Text = "";
                txtPIN.Text = "";
                pin = "";
            }
            //Skrur av alarm hvis ingen alarm er gyldig
            if (txtDørÅpenLukket.Text == "Åpen" && Convert.ToInt32(termist) < 500)
            {
                lbAlarm.Items.Clear();
                SendData(sp, "$O70");
            }
            //Sjekker om dør er åpen og starter en timer så alarm aktiveres hvis dør er åpen i mer enn 15 sekunder
            if (txtDørÅpenLukket.Text == "Åpen")
            {
                DørÅpnet = true;
                if (dørÅpen > 0) dørÅpen--;
                else
                {
                    if (!lbAlarm.Items.Contains("Dør åpen for lenge")) lbAlarm.Items.Add("Dør åpen for lenge");

                    SendData(sp, "$O71");
                    SendTekst(klientSokkel, $"A{Llogg[0]}$0002");
                }
            }
            //Sjekker om dør er lukket etter å ha vært åpen og reseter timer for dør alarm og låser dør
            if (txtDørÅpenLukket.Text == "Lukket" && DørÅpnet == true)
            {
                txtDørLåstUlåst.Text = "Låst";
                DørÅpnet = false;
                dørÅpen = 15;
            }
        }
    }
}