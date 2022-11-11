using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sentral
{
    internal class Users
    {
        private int cardid, pin;
        private string firstname, lastename, email;
        private DateTime date;

        public Users()
        {
            Cardid = 0;
            Firstname = "N/A";
            Lastename = "N/A";
            Email = "N/A";
            Pin = 0;
            Date = new (1999, 12, 31);
        }

        public Users(int cardid, string firstname, string lastename, string email, int pin, DateTime date)
        {
            Cardid = cardid;
            Firstname = firstname;
            Lastename = lastename;
            Email = email;
            Pin = pin;
            Date = date;
        }

        public int Cardid
        {
            get { return cardid; }
            set { cardid = value; }
        }
        public string Firstname
        {
            get { return firstname; }
            set { firstname = value; }
        }
        public string Lastename
        {
            get { return lastename; }
            set { lastename = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public int Pin
        {
            get { return pin; }
            set { pin = value; }
        }
        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }
    }
}
