namespace MovieLibrarySystemTrial1
{
    partial class HomePage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            label1 = new Label();
            label2 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            moviePanel4 = new MoviePanel();
            moviePanel2 = new MoviePanel();
            moviePanel1 = new MoviePanel();
            moviePanel3 = new MoviePanel();
            moviePanel6 = new MoviePanel();
            moviePanel5 = new MoviePanel();
            button1 = new Button();
            button2 = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sylfaen", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(794, 24);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(617, 70);
            label1.TabIndex = 1;
            label1.Text = "Welcome to the Cinema!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.GhostWhite;
            label2.Font = new Font("Arial Rounded MT Bold", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.InfoText;
            label2.Location = new Point(962, 116);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(230, 44);
            label2.TabIndex = 2;
            label2.Text = "Top Movies";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoScroll = true;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 51.28205F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 48.71795F));
            tableLayoutPanel1.Controls.Add(moviePanel4, 1, 1);
            tableLayoutPanel1.Controls.Add(moviePanel2, 1, 0);
            tableLayoutPanel1.Controls.Add(moviePanel1, 0, 0);
            tableLayoutPanel1.Controls.Add(moviePanel3, 0, 1);
            tableLayoutPanel1.Controls.Add(moviePanel6, 1, 2);
            tableLayoutPanel1.Controls.Add(moviePanel5, 0, 2);
            tableLayoutPanel1.Location = new Point(17, 178);
            tableLayoutPanel1.Margin = new Padding(4, 4, 4, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50.46729F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 49.53271F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 422F));
            tableLayoutPanel1.Size = new Size(2060, 1344);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // moviePanel4
            // 
            moviePanel4._Directors = "Anthony Russo";
            moviePanel4._Poster = (Image)resources.GetObject("moviePanel4._Poster");
            moviePanel4._Stars = "Robert Downey Jr., Chris Evans";
            moviePanel4._Time = "2019 - PG-13 - 3h 1m";
            moviePanel4._Writers = "Christopher Msrcos";
            moviePanel4.Location = new Point(1061, 470);
            moviePanel4.Margin = new Padding(5, 5, 5, 5);
            moviePanel4.MovieTitle = "Avengers: Endgame";
            moviePanel4.Name = "moviePanel4";
            moviePanel4.Size = new Size(994, 439);
            moviePanel4.TabIndex = 3;
            // 
            // moviePanel2
            // 
            moviePanel2._Directors = "Daniel Kwan";
            moviePanel2._Poster = (Image)resources.GetObject("moviePanel2._Poster");
            moviePanel2._Stars = "Michelle Yeoh, Stephanie Hsu";
            moviePanel2._Time = "2022 - R - 2h 19m";
            moviePanel2._Writers = "Daniel Kwan";
            moviePanel2.Location = new Point(1061, 5);
            moviePanel2.Margin = new Padding(5, 5, 5, 5);
            moviePanel2.MovieTitle = "Everything, Everywhere, All At once";
            moviePanel2.Name = "moviePanel2";
            moviePanel2.Size = new Size(994, 454);
            moviePanel2.TabIndex = 1;
            // 
            // moviePanel1
            // 
            moviePanel1._Directors = "Marc Webb";
            moviePanel1._Poster = (Image)resources.GetObject("moviePanel1._Poster");
            moviePanel1._Stars = "Andrew Garfield, Emma Stone";
            moviePanel1._Time = "2012 - PG-13 - 2h 16m";
            moviePanel1._Writers = "James Vanderbit ";
            moviePanel1.Location = new Point(5, 5);
            moviePanel1.Margin = new Padding(5, 5, 5, 5);
            moviePanel1.MovieTitle = "The Amazing Spiderman";
            moviePanel1.Name = "moviePanel1";
            moviePanel1.Size = new Size(1018, 454);
            moviePanel1.TabIndex = 0;
            // 
            // moviePanel3
            // 
            moviePanel3._Directors = "Christopher Nolan";
            moviePanel3._Poster = (Image)resources.GetObject("moviePanel3._Poster");
            moviePanel3._Stars = "Cillian Murphy";
            moviePanel3._Time = "2023 - R - 3h";
            moviePanel3._Writers = "Christopher Nolan";
            moviePanel3.Location = new Point(5, 470);
            moviePanel3.Margin = new Padding(5, 5, 5, 5);
            moviePanel3.MovieTitle = "Oppenheimer";
            moviePanel3.Name = "moviePanel3";
            moviePanel3.Size = new Size(1045, 445);
            moviePanel3.TabIndex = 2;
            moviePanel3.Load += moviePanel3_Load;
            // 
            // moviePanel6
            // 
            moviePanel6._Directors = "Makoto Shinkai";
            moviePanel6._Poster = (Image)resources.GetObject("moviePanel6._Poster");
            moviePanel6._Stars = "Ryunosuke Kamiki";
            moviePanel6._Time = "2016 - 1h 46m";
            moviePanel6._Writers = "Makoto Shinkai";
            moviePanel6.Location = new Point(1061, 926);
            moviePanel6.Margin = new Padding(5, 5, 5, 5);
            moviePanel6.MovieTitle = "Your Name.";
            moviePanel6.Name = "moviePanel6";
            moviePanel6.Size = new Size(994, 413);
            moviePanel6.TabIndex = 5;
            // 
            // moviePanel5
            // 
            moviePanel5._Directors = "Kyle Balda";
            moviePanel5._Poster = (Image)resources.GetObject("moviePanel5._Poster");
            moviePanel5._Stars = "Steve Carell";
            moviePanel5._Time = "2022 - PG-13 - 1h 27m";
            moviePanel5._Writers = "Mathew Fogell";
            moviePanel5.Location = new Point(5, 926);
            moviePanel5.Margin = new Padding(5, 5, 5, 5);
            moviePanel5.MovieTitle = "Minions: The Rise Of Gru";
            moviePanel5.Name = "moviePanel5";
            moviePanel5.Size = new Size(1045, 413);
            moviePanel5.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = Color.LavenderBlush;
            button1.Font = new Font("Verdana", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Pink;
            button1.Location = new Point(1717, 36);
            button1.Margin = new Padding(4, 4, 4, 4);
            button1.Name = "button1";
            button1.Size = new Size(322, 93);
            button1.TabIndex = 4;
            button1.Text = "BOOKING";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Lavender;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ControlDarkDark;
            button2.Location = new Point(47, 43);
            button2.Name = "button2";
            button2.Size = new Size(410, 75);
            button2.TabIndex = 5;
            button2.Text = "Back to Login ";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.Lavender;
            ClientSize = new Size(2128, 1551);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = SystemColors.ControlDarkDark;
            Margin = new Padding(4, 4, 4, 4);
            Name = "HomePage";
            Text = "Home Page";
            Load += Form1_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel1;
        private MoviePanel moviePanel3;
        private MoviePanel moviePanel2;
        private MoviePanel moviePanel1;
        private MoviePanel moviePanel6;
        private MoviePanel moviePanel5;
        private MoviePanel moviePanel4;
        private Button button1;
        private Button button2;
    }
}
