using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLibrarySystemTrial1
{
    public class VIPSeat : Seat
    {
        public VIPSeat(int seatNumber) : base(seatNumber) { }

        public override string GetSeatType()
        {
            return "VIP Seat";
        }
    }
}
