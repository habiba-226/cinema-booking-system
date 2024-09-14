using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieLibrarySystemTrial1
{
    public partial class BookingSeats : Form
    {
        private List<Seat> frontSeats;
        private List<Seat> backSeats;
        private BookingMovie bookingMovie;
        private TypeofTicket ticket;
        public BookingSeats()
        {
            InitializeComponent();
            InitializeSeats();
        }
        public BookingSeats(BookingMovie bk, TypeofTicket t)
        {
            InitializeComponent();
            this.bookingMovie = bk;
            this.ticket = t;
            InitializeSeats();
        }

        private void InitializeSeats()
        {
            frontSeats = new List<Seat>
        {
            new StandardSeat(1),
            new StandardSeat(2),
            new StandardSeat(3),
            new StandardSeat(4)
        };

            backSeats = new List<Seat>
        {
            new VIPSeat(5),
            new VIPSeat(6),
            new VIPSeat(7),
            new VIPSeat(8)
        };
            button1.Click += new EventHandler(SeatButton_Click);
            button2.Click += new EventHandler(SeatButton_Click);
            button3.Click += new EventHandler(SeatButton_Click);
            button4.Click += new EventHandler(SeatButton_Click);

            button5.Click += new EventHandler(SeatButton_Click);
            button6.Click += new EventHandler(SeatButton_Click);
            button7.Click += new EventHandler(SeatButton_Click);
            button8.Click += new EventHandler(SeatButton_Click);
        }

        private void SeatButton_Click(object sender, EventArgs e)
        {
            Button? clickedButton = sender as Button;
            int seatNumber = int.Parse(clickedButton.Tag.ToString());
            Seat seat;

            if (seatNumber <= 4)
            {
                seat = frontSeats[seatNumber - 1];
            }
            else
            {
                seat = backSeats[seatNumber - 5];
            }

            MessageBox.Show($"Seat Type: {seat.GetSeatType()}", "Seat Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            seat.BookSeat(clickedButton);
            ticket.SeatNumber = seatNumber;
        }

        private void BookingSeats_Load(object sender, EventArgs e)
        {
            label1.Text = ticket.Title;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            bookingMovie.Show();
        }
    }
}
