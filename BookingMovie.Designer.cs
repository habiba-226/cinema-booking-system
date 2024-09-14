namespace MovieLibrarySystemTrial1
{
    partial class BookingMovie
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookingMovie));
            AddButton = new Button();
            movieTitles = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            AgetextBox = new TextBox();
            label3 = new Label();
            label5 = new Label();
            AdultButton = new RadioButton();
            ChildButton = new RadioButton();
            Tickets = new ListBox();
            Removebutton = new Button();
            Clearbutton = new Button();
            Existbutton = new Button();
            button2 = new Button();
            Returnbutton = new Button();
            Detailsbutton = new Button();
            ticketCountlabel = new Label();
            BookSeats = new Button();
            SuspendLayout();
            // 
            // AddButton
            // 
            AddButton.BackColor = Color.Chartreuse;
            AddButton.Location = new Point(1294, 472);
            AddButton.Margin = new Padding(4);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(146, 44);
            AddButton.TabIndex = 0;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = false;
            AddButton.Click += AddButton_Click;
            // 
            // movieTitles
            // 
            movieTitles.FormattingEnabled = true;
            movieTitles.Items.AddRange(new object[] { "The Amazing Spiderman", "Everything, Everywhere, All At Once", "Oppenheimer", "Avengers: Endgame", "Minions: The Rise Of Gru", "Your Name." });
            movieTitles.Location = new Point(660, 168);
            movieTitles.Margin = new Padding(4);
            movieTitles.Name = "movieTitles";
            movieTitles.Size = new Size(235, 40);
            movieTitles.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(660, 132);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(91, 32);
            label1.TabIndex = 3;
            label1.Text = "Movies";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1070, 142);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(56, 32);
            label2.TabIndex = 4;
            label2.Text = "Age";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(660, 314);
            dateTimePicker1.Margin = new Padding(4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(239, 39);
            dateTimePicker1.TabIndex = 5;
            // 
            // AgetextBox
            // 
            AgetextBox.Location = new Point(1070, 178);
            AgetextBox.Margin = new Padding(4);
            AgetextBox.Name = "AgetextBox";
            AgetextBox.Size = new Size(194, 39);
            AgetextBox.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(660, 278);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(64, 32);
            label3.TabIndex = 7;
            label3.Text = "Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(1070, 278);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(168, 32);
            label5.TabIndex = 9;
            label5.Text = "Type Of Ticket";
            // 
            // AdultButton
            // 
            AdultButton.AutoSize = true;
            AdultButton.Location = new Point(1070, 337);
            AdultButton.Margin = new Padding(4);
            AdultButton.Name = "AdultButton";
            AdultButton.Size = new Size(102, 36);
            AdultButton.TabIndex = 10;
            AdultButton.TabStop = true;
            AdultButton.Text = "Adult";
            AdultButton.UseVisualStyleBackColor = true;
            // 
            // ChildButton
            // 
            ChildButton.AutoSize = true;
            ChildButton.Location = new Point(1070, 394);
            ChildButton.Margin = new Padding(4);
            ChildButton.Name = "ChildButton";
            ChildButton.Size = new Size(100, 36);
            ChildButton.TabIndex = 11;
            ChildButton.TabStop = true;
            ChildButton.Text = "Child";
            ChildButton.UseVisualStyleBackColor = true;
            // 
            // Tickets
            // 
            Tickets.BackColor = Color.LightSalmon;
            Tickets.FormattingEnabled = true;
            Tickets.Location = new Point(16, 46);
            Tickets.Margin = new Padding(4);
            Tickets.Name = "Tickets";
            Tickets.Size = new Size(515, 484);
            Tickets.TabIndex = 12;
            // 
            // Removebutton
            // 
            Removebutton.BackColor = Color.OrangeRed;
            Removebutton.Location = new Point(1294, 545);
            Removebutton.Margin = new Padding(4);
            Removebutton.Name = "Removebutton";
            Removebutton.Size = new Size(146, 44);
            Removebutton.TabIndex = 13;
            Removebutton.Text = "Remove";
            Removebutton.UseVisualStyleBackColor = false;
            Removebutton.Click += Removebutton_Click;
            // 
            // Clearbutton
            // 
            Clearbutton.Location = new Point(1294, 625);
            Clearbutton.Margin = new Padding(4);
            Clearbutton.Name = "Clearbutton";
            Clearbutton.Size = new Size(146, 44);
            Clearbutton.TabIndex = 14;
            Clearbutton.Text = "Clear";
            Clearbutton.UseVisualStyleBackColor = true;
            Clearbutton.Click += Clearbutton_Click;
            // 
            // Existbutton
            // 
            Existbutton.Location = new Point(1294, 46);
            Existbutton.Margin = new Padding(4);
            Existbutton.Name = "Existbutton";
            Existbutton.Size = new Size(146, 44);
            Existbutton.TabIndex = 15;
            Existbutton.Text = "Exit";
            Existbutton.UseVisualStyleBackColor = true;
            Existbutton.Click += Existbutton_Click;
            // 
            // button2
            // 
            button2.Location = new Point(1166, 799);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(10, 10);
            button2.TabIndex = 16;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // Returnbutton
            // 
            Returnbutton.Location = new Point(1154, 703);
            Returnbutton.Margin = new Padding(4);
            Returnbutton.Name = "Returnbutton";
            Returnbutton.Size = new Size(285, 67);
            Returnbutton.TabIndex = 17;
            Returnbutton.Text = "Return To Home Page";
            Returnbutton.UseVisualStyleBackColor = true;
            Returnbutton.Click += Returnbutton_Click;
            // 
            // Detailsbutton
            // 
            Detailsbutton.BackColor = Color.ForestGreen;
            Detailsbutton.Location = new Point(16, 643);
            Detailsbutton.Margin = new Padding(4);
            Detailsbutton.Name = "Detailsbutton";
            Detailsbutton.Size = new Size(237, 44);
            Detailsbutton.TabIndex = 18;
            Detailsbutton.Text = "Show Details";
            Detailsbutton.UseVisualStyleBackColor = false;
            Detailsbutton.Click += Detailsbutton_Click;
            // 
            // ticketCountlabel
            // 
            ticketCountlabel.AutoSize = true;
            ticketCountlabel.Location = new Point(16, 568);
            ticketCountlabel.Margin = new Padding(4, 0, 4, 0);
            ticketCountlabel.Name = "ticketCountlabel";
            ticketCountlabel.Size = new Size(223, 32);
            ticketCountlabel.TabIndex = 19;
            ticketCountlabel.Text = "Number of Tickets: ";
            // 
            // BookSeats
            // 
            BookSeats.Location = new Point(50, 716);
            BookSeats.Name = "BookSeats";
            BookSeats.Size = new Size(160, 46);
            BookSeats.TabIndex = 20;
            BookSeats.Text = "Book Seats";
            BookSeats.UseVisualStyleBackColor = true;
            BookSeats.Click += BookSeats_Click;
            // 
            // BookingMovie
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1485, 1006);
            Controls.Add(BookSeats);
            Controls.Add(ticketCountlabel);
            Controls.Add(Detailsbutton);
            Controls.Add(Returnbutton);
            Controls.Add(button2);
            Controls.Add(Existbutton);
            Controls.Add(Clearbutton);
            Controls.Add(Removebutton);
            Controls.Add(Tickets);
            Controls.Add(ChildButton);
            Controls.Add(AdultButton);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(AgetextBox);
            Controls.Add(dateTimePicker1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(movieTitles);
            Controls.Add(AddButton);
            Margin = new Padding(4);
            Name = "BookingMovie";
            Text = "Booking Movie";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AddButton;
        private ComboBox movieTitles;
        private Label label1;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private TextBox AgetextBox;
        private Label label3;
        private Label label5;
        private RadioButton AdultButton;
        private RadioButton ChildButton;
        private ListBox Tickets;
        private Button Removebutton;
        private Button Clearbutton;
        private Button Existbutton;
        private Button button2;
        private Button Returnbutton;
        private Button Detailsbutton;
        private Label ticketCountlabel;
        private Button BookSeats;
    }
}