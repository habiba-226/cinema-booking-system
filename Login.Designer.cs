namespace MovieLibrarySystemTrial1
{
    partial class Login
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
            label1 = new Label();
            Username = new TextBox();
            Password = new TextBox();
            label2 = new Label();
            LoginButton = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            CreateAccount = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Showcard Gothic", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(426, 100);
            label1.Name = "label1";
            label1.Size = new Size(165, 36);
            label1.TabIndex = 0;
            label1.Text = "Username";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // Username
            // 
            Username.Location = new Point(338, 150);
            Username.Name = "Username";
            Username.Size = new Size(341, 39);
            Username.TabIndex = 1;
            Username.TextChanged += textBox1_TextChanged;
            // 
            // Password
            // 
            Password.Location = new Point(338, 263);
            Password.Name = "Password";
            Password.Size = new Size(341, 39);
            Password.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Showcard Gothic", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(420, 212);
            label2.Name = "label2";
            label2.Size = new Size(176, 36);
            label2.TabIndex = 2;
            label2.Text = "Password";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // LoginButton
            // 
            LoginButton.BackColor = Color.DarkCyan;
            LoginButton.Font = new Font("Showcard Gothic", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LoginButton.ForeColor = Color.MidnightBlue;
            LoginButton.Location = new Point(403, 347);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(211, 75);
            LoginButton.TabIndex = 4;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = false;
            LoginButton.Click += LoginButton_Click;
            // 
            // CreateAccount
            // 
            CreateAccount.BackColor = Color.SteelBlue;
            CreateAccount.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CreateAccount.ForeColor = Color.DarkBlue;
            CreateAccount.Location = new Point(338, 456);
            CreateAccount.Name = "CreateAccount";
            CreateAccount.Size = new Size(340, 54);
            CreateAccount.TabIndex = 5;
            CreateAccount.Text = "Create Account";
            CreateAccount.UseVisualStyleBackColor = false;
            CreateAccount.Click += CreateAccount_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(1018, 611);
            Controls.Add(CreateAccount);
            Controls.Add(LoginButton);
            Controls.Add(Password);
            Controls.Add(label2);
            Controls.Add(Username);
            Controls.Add(label1);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox Username;
        private TextBox Password;
        private Label label2;
        private Button LoginButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button CreateAccount;
    }
}
