using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLibrarySystemTrial1
{
    public class StandardSeat : Seat
    {
        public StandardSeat(int seatNumber) : base(seatNumber) { }

        public override string GetSeatType()
        {
            return "Standard Seat";
        }
    }
}
