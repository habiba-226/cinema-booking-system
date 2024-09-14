using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using MovieLibrarySystemTrial1;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace MovieLibrarySystemTrial1
{
    public partial class BookingMovie : Form
    {

        private LinkedList<TypeofTicket> listOftickets = new LinkedList<TypeofTicket>();
        private string title;
        private int age;
        private string type;
        private DateTime date;
        private int noOfTickets = 0;
        private string id;
        public BookingMovie()
        {
            InitializeComponent();
            UpdateTicketCountDisplay();

        }

        private void BookingMovie_Load(object sender, EventArgs e)
        {

        }
        public void getInfo()
        {
            title = movieTitles.Text;
            age = int.Parse(AgetextBox.Text);
            date = dateTimePicker1.Value;
            if (AdultButton.Checked)
            {
                type = "Adult";
                if (age < 18)
                {
                    MessageBox.Show("Age does not qualify for an adult ticket.", "Booking Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else if (ChildButton.Checked)
            {
                type = "Child";
                if (age >= 18)
                {
                    MessageBox.Show("Age does not qualify for a child ticket.", "Booking Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(movieTitles.Text))
            {
                getInfo();

                if ((type == "Adult" && age >= 18) || (type == "Child" && age < 18))
                {

                    noOfTickets++;
                    UpdateTicketCountDisplay();
                    listOftickets.AddLast(new TypeofTicket(title, id, age, type, date));
                    Tickets.Items.Add($"{title} - {type}");


                    AgetextBox.Clear();
                    movieTitles.Text = string.Empty;
                    dateTimePicker1.Value = DateTime.Now;
                }
            }
            else
            {
                MessageBox.Show("Please Select A movie", "Warning", MessageBoxButtons.OKCancel);
            }
        }

        private void Removebutton_Click(object sender, EventArgs e)
        {
            if (Tickets.SelectedIndex != -1)
            {
                noOfTickets--;
                UpdateTicketCountDisplay();
                listOftickets.Remove(listOftickets.ElementAt(Tickets.SelectedIndex));
                Tickets.Items.RemoveAt(Tickets.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Please select an item to remove.", "Remove Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Clearbutton_Click(object sender, EventArgs e)
        {
            noOfTickets = 0;
            UpdateTicketCountDisplay();
            listOftickets.Clear();
            Tickets.Items.Clear();

        }
        private void UpdateTicketCountDisplay()
        {
            ticketCountlabel.Text = $"Number of Tickets: {noOfTickets}";
        }
        private void Returnbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var homepage = new HomePage();
            homepage.Show();
        }

        private void Existbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Detailsbutton_Click(object sender, EventArgs e)
        {
            if (Tickets.SelectedIndex != -1)
            {
                TicketDetails t2 = new TicketDetails(this, listOftickets.ElementAt(Tickets.SelectedIndex));
                t2.Show();
                this.Hide();
            }
        }

        private void BookSeats_Click(object sender, EventArgs e)
        {
            BookingSeats b = new BookingSeats(this, listOftickets.ElementAt(Tickets.SelectedIndex));
            b.Show();
            this.Hide();
        }
    }
} 



 
