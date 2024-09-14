using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLibrarySystemTrial1
{
    public class TypeofTicket : Ticket
    {
        public int Age { get; set; }
        public string Type { get; set; }
        public DateTime date { get; set; }
        public int SeatNumber { get; set; }

        public TypeofTicket(string Title, string ID, int Age, string Type, DateTime date) : base(Title)
        {
            this.Age = Age;
            this.Type = Type;
            this.date = date;
            this.SeatNumber = -1;
        }
    }
}
