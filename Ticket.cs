using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLibrarySystemTrial1
{
    public class Ticket
    {
        private static Random random = new Random();
        private static string GenerateID()
        {
            return "#" + random.Next(1000, 10000);
        }
        public string Title { get; set; }
        public string ID { set; get; }

        public Ticket(string Title) 
        {
            this.ID = GenerateID();
            this.Title = Title;
        }
    }
}
