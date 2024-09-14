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
    public partial class TicketDetails : Form
    {
        private BookingMovie bookingMovie;
        private TypeofTicket ticket;
        public TicketDetails()
        {
            InitializeComponent();
        }

        public TicketDetails(BookingMovie bk, TypeofTicket t)
        {
            InitializeComponent();
            bookingMovie = bk;
            ticket = t;
        }
        private void TicketDetails_Load(object sender, EventArgs e)
        {
            label1.Text = $"Ticket ID: {ticket.ID}";
            label2.Text = $"Movie Title: {ticket.Title}";
            label3.Text = ticket.Type;
            label4.Text = $"Age: {ticket.Age}";
            label5.Text = $"Date: {ticket.date.ToShortDateString()}";
            label6.Text = $"Seat: {ticket.SeatNumber}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            bookingMovie.Show();
        }
    }
}
