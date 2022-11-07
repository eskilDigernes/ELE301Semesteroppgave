using System.IO.Ports;

namespace KORTLESER
{
    internal class Program
    {

        static void Main(string[] args)
        {
            // Oppretter kontakt med simsim           
            SerialPort sp = new SerialPort("COM4", 9600);
            string data = "";

            try
            {
                sp.Open();
            }
            catch (Exception err)
            {
                Console.WriteLine("Feil: " + err.Message);
            }


            if (sp.IsOpen)
            {
                //MeldingTilSimSim(sp, "$S002");
                //MeldingTilSimSim(sp, "$O91");
                string enMelding = "";

                while (true)
                {
                    data = data + MottaData(sp);


                    if (InneholderEnHelMelding(data))
                    {

                        data = HentUtEnMelding(data, ref enMelding);
                        Console.WriteLine(enMelding);
                    }
                }
            }

            Console.ReadKey();
        }

        //Henter data fra simsim
        static string MottaData(SerialPort sp)
        {
            string svar = "";

            try
            {
                svar = sp.ReadExisting();
            }
            catch (Exception err)
            {

                Console.WriteLine("Feil: " + err.Message);
            }
            return svar;
        }

        //Henter ut meldinger fra simsim data
        static string HentUtEnMelding(string data, ref string enMelding)
        {
            int startPos = data.IndexOf('$');
            int sluttPos = data.IndexOf('#');

            enMelding = data.Substring(startPos, (sluttPos - startPos) + 1);

            if (startPos > 0) data = data.Substring(startPos);                         //Klipper vekk tegn før '$'
            if (enMelding.Length < data.Length) data = data.Substring(sluttPos + 1); //Klipper vekk tegn etter '#'
            else data = "";
            return data;
        }

        //Sjekker om innholder er en hel melding 
        static bool InneholderEnHelMelding(string data)
        {
            bool svar = false;

            int startPos = data.IndexOf('$');
            int sluttPos = data.IndexOf('#');
            if (startPos != -1 && sluttPos != -1)
            {
                if (startPos < sluttPos) svar = true;
            }
            return svar;
        }

        //Kommunikasjon med simsim
        static void MeldingTilSimSim(SerialPort s, string melding)
        {
            try
            {
                s.Write(melding);
            }
            catch (Exception err)
            {

                Console.WriteLine("Feil: " + err.Message);
            }
        }
    }
}
