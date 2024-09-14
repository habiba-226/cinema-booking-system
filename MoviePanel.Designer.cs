namespace MovieLibrarySystemTrial1
{
    partial class MoviePanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            Title = new Label();
            Time = new Label();
            Directors = new Label();
            Writers = new Label();
            Stars = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(16, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(210, 291);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Times New Roman", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Title.Location = new Point(238, 20);
            Title.Name = "Title";
            Title.Size = new Size(97, 36);
            Title.TabIndex = 1;
            Title.Text = "label1";
            // 
            // Time
            // 
            Time.AutoSize = true;
            Time.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Time.Location = new Point(379, 90);
            Time.Name = "Time";
            Time.Size = new Size(59, 25);
            Time.TabIndex = 1;
            Time.Text = "label1";
            // 
            // Directors
            // 
            Directors.AutoSize = true;
            Directors.Font = new Font("Sylfaen", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Directors.Location = new Point(265, 144);
            Directors.Name = "Directors";
            Directors.Size = new Size(70, 26);
            Directors.TabIndex = 2;
            Directors.Text = "label1";
            // 
            // Writers
            // 
            Writers.AutoSize = true;
            Writers.Font = new Font("Sylfaen", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Writers.Location = new Point(265, 209);
            Writers.Name = "Writers";
            Writers.Size = new Size(70, 26);
            Writers.TabIndex = 3;
            Writers.Text = "label1";
            // 
            // Stars
            // 
            Stars.AutoSize = true;
            Stars.Font = new Font("Sylfaen", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Stars.Location = new Point(265, 273);
            Stars.Name = "Stars";
            Stars.Size = new Size(70, 26);
            Stars.TabIndex = 4;
            Stars.Text = "label1";
            // 
            // MoviePanel
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Stars);
            Controls.Add(Writers);
            Controls.Add(Directors);
            Controls.Add(Time);
            Controls.Add(Title);
            Controls.Add(pictureBox1);
            Name = "MoviePanel";
            Size = new Size(608, 332);
            Load += MoviePanel_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label Title;
        private Label Time;
        private Label Directors;
        private Label Writers;
        private Label Stars;
    }
}
