using Microsoft.VisualBasic;
using System.IO.Ports;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace KORTLESERgui
{
    delegate void OppdaterGUIDelegatType(string s);

    public partial class Form1 : Form
    {
        /*Variabler for simsom*/
        bool kommuniser;
        Thread hjelpetråd;

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

        /*******SIMSIM*******************************/
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
            SerialPort sp = new SerialPort(comPort, 9600);

            string data = "";

            try
            {
                sp.Open();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

            if (sp.IsOpen)
            {

                string enMelding = "";

                while (kommuniser)
                {
                    data = data + MottaData(sp);


                    if (DataInneholderEnHelMelding(data))
                    {

                        data = HenteUtEnMelding(data, ref enMelding);

                        // Oppretter en delegat som skal representere OppdaterGUI
                        OppdaterGUIDelegatType oGUI = new OppdaterGUIDelegatType(OppdaterGUI);
                        this.Invoke(oGUI, enMelding);
                    }
                    Thread.Sleep(100);
                }
                sp.Close();
            }
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

            // Klipper vekk eventuelle tegn før $
            if (posStart > 0) data = data.Substring(posStart);
            // Bevarer til senere bruk eventuelle tegn etter #
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
                MessageBox.Show(err.Message);
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
                MessageBox.Show(err.Message);
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

                ParameterizedThreadStart pts = new ParameterizedThreadStart(SeriellPortKommunikasjon);
                hjelpetråd = new Thread(pts);
                hjelpetråd.Start(comPort);
            }
        }

        private void btnAvbryt_Click(object sender, EventArgs e)
        {
            btnAvbryt.Enabled = false;
            kommuniser = false;
            hjelpetråd.Join();
            btnAvbryt.Enabled = true;
        }

        /***********Klient*************************/
        //
        static Socket KobleTilServer(out bool ferdig)
        {
            ferdig = false;
            Socket klientSokkel = new Socket(AddressFamily.InterNetwork,
             SocketType.Stream,
             ProtocolType.Tcp);
            IPEndPoint serverEP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9600);
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
                MessageBox.Show(err.ToString());
                feilHarOppstått = false;
            }
            return svar;
        }

    }
}