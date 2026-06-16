using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.AxHost;

namespace MargaretConcertApp
{
    public class MargaretConcert
    {
        private string artist;
        private string title;
        private string venue;
        private DateTime startDate;
        private DateTime endDate;

        public MargaretConcert(string artist, string title, string venue, DateTime startDate, DateTime endDate)
        {
            this.Artist = artist;
            this.Title = title;
            this.Venue = venue;
            this.StartDate = startDate;
            this.EndDate = endDate;
        }

        public string Artist {
            get => artist;
            set
            {
                if(value != "")
                {
                    artist = value;
                }
                else
                {
                    throw new Exception("Artist Should Not be Empty!");
                }
            }
        }
        public string Title {
            get => title;
            set
            {
                if (value != "")
                {
                    title = value;
                }
                else
                {
                    throw new Exception("Title Should Not be Empty!");
                }
            }
        }
        public string Venue
        {
            get => venue;
            set
            {
                if (value != "")
                {
                    venue = value;
                }
                else
                {
                    throw new Exception("Venue Should Not be Empty!");
                }
            }
        }
        public DateTime StartDate {
            get => startDate;
            set => startDate = value;
        }
        public DateTime EndDate {
            get => endDate;
            set
            {
                if(value >= this.StartDate)
                {
                    endDate = value;
                }
                else
                {
                    throw new Exception("End Date Should be Greater than Start Date!");
                }
            }
        }

        public int CountDaysOfTheConcert()
        {
            return (this.EndDate - this.StartDate).Days;
        }

        public int CountDaysBeforeConcert()
        {
            return (this.StartDate - DateTime.Now).Days;
        }
        public bool ThisMonth()
        {
            bool result = false;
            if(this.StartDate.Month == DateTime.Now.Month && this.StartDate.Year == DateTime.Now.Year)
            {
                if (this.EndDate > DateTime.Now)
                { 
                    result = true;
                }
            }
            return result;
        }
        public bool IsOver()
        {
            bool result = false;
            if(this.EndDate < DateTime.Now)
            {
                result = true;
            }
            return result;
        }
        public string DisplayData()
        {
            bool over = IsOver();
            string status = "";
            if (over == true)
            {
                status = "\nConcert is Over!\n";
            }
            else
            {
                status = "\nDays of Concert - " + CountDaysOfTheConcert() + 
                         "\nConcert will be started in " + CountDaysBeforeConcert() + " Days\n";
            }
            string data = "Title - " + this.Title +
                              "\nArtist - " + this.Artist +
                              "\nVenue - " + this.Venue +
                              "\nStart Date - " + this.StartDate.ToShortDateString() +
                              status;
            return data;
        }
    }
}
