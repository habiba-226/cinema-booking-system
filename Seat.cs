using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLibrarySystemTrial1
{
    public class Seat
    {
        public int SeatNumber { get; set; }
        public bool IsAvailable { get; set; }

        public Seat(int seatNumber)
        {
            SeatNumber = seatNumber;
            IsAvailable = true;
        }

        public virtual string GetSeatType()
        {
            return "";
        }

        public virtual void BookSeat(Button seatButton)
        {
            if (IsAvailable)
            {
                IsAvailable = false; 
                seatButton.BackColor = Color.Green;
                MessageBox.Show("Successful booking", "Booking Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                seatButton.BackColor = Color.Red;
                MessageBox.Show("Seat unavailable", "Booking Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
