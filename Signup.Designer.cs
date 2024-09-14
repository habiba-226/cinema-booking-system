namespace MovieLibrarySystemTrial1
{
    partial class Signup
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
            Backtologin = new Button();
            Signupbutton = new Button();
            Password = new TextBox();
            label2 = new Label();
            Username = new TextBox();
            label1 = new Label();
            ConfirmPassword = new TextBox();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // Backtologin
            // 
            Backtologin.BackColor = Color.SteelBlue;
            Backtologin.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Backtologin.ForeColor = Color.DarkBlue;
            Backtologin.Location = new Point(350, 644);
            Backtologin.Name = "Backtologin";
            Backtologin.Size = new Size(341, 76);
            Backtologin.TabIndex = 11;
            Backtologin.Text = "Back To Login";
            Backtologin.UseVisualStyleBackColor = false;
            Backtologin.Click += Backtologin_Click;
            // 
            // Signupbutton
            // 
            Signupbutton.BackColor = Color.DarkCyan;
            Signupbutton.Font = new Font("Showcard Gothic", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Signupbutton.ForeColor = Color.MidnightBlue;
            Signupbutton.Location = new Point(415, 535);
            Signupbutton.Name = "Signupbutton";
            Signupbutton.Size = new Size(211, 75);
            Signupbutton.TabIndex = 10;
            Signupbutton.Text = "Sign up";
            Signupbutton.UseVisualStyleBackColor = false;
            Signupbutton.Click += Signupbutton_Click;
            // 
            // Password
            // 
            Password.Location = new Point(350, 321);
            Password.Name = "Password";
            Password.Size = new Size(341, 39);
            Password.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Showcard Gothic", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(432, 270);
            label2.Name = "label2";
            label2.Size = new Size(176, 36);
            label2.TabIndex = 8;
            label2.Text = "Password";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // Username
            // 
            Username.Location = new Point(350, 197);
            Username.Name = "Username";
            Username.Size = new Size(341, 39);
            Username.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Showcard Gothic", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(438, 158);
            label1.Name = "label1";
            label1.Size = new Size(165, 36);
            label1.TabIndex = 6;
            label1.Text = "Username";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // ConfirmPassword
            // 
            ConfirmPassword.Location = new Point(350, 447);
            ConfirmPassword.Name = "ConfirmPassword";
            ConfirmPassword.Size = new Size(341, 39);
            ConfirmPassword.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Showcard Gothic", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(366, 394);
            label3.Name = "label3";
            label3.Size = new Size(312, 36);
            label3.TabIndex = 12;
            label3.Text = "Confirm Password";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.HotTrack;
            label4.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Navy;
            label4.Location = new Point(336, 42);
            label4.Name = "label4";
            label4.Size = new Size(342, 60);
            label4.TabIndex = 14;
            label4.Text = "Get Started";
            // 
            // Signup
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(1027, 806);
            Controls.Add(label4);
            Controls.Add(ConfirmPassword);
            Controls.Add(label3);
            Controls.Add(Backtologin);
            Controls.Add(Signupbutton);
            Controls.Add(Password);
            Controls.Add(label2);
            Controls.Add(Username);
            Controls.Add(label1);
            Name = "Signup";
            Text = "Signup";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Backtologin;
        private Button Signupbutton;
        private TextBox Password;
        private Label label2;
        private TextBox Username;
        private Label label1;
        private TextBox ConfirmPassword;
        private Label label3;
        private Label label4;
    }
}