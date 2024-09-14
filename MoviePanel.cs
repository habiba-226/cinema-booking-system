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
    public partial class MoviePanel : UserControl
    {
        public MoviePanel()
        {
            InitializeComponent();
        }
        private string _title;
        private string _time;
        private string _directors;
        private string _writers;
        private string _stars;
        private Image _poster;

        private void MoviePanel_Load(object sender, EventArgs e)
        {

        }

        public string MovieTitle
        {
            get { return _title; }
            set { _title = value; Title.Text = value; }
        }

        public string _Time
        {
            get { return _time; }
            set { _time = value; Time.Text = value; }
        }
        public string _Directors
        {
            get { return _directors; }
            set { _directors = value; Directors.Text = $"Directors: {value}"; }
        }

        public string _Writers
        {
            get { return _writers; }
            set { _writers = value; Writers.Text = $"Writers: {value}"; }
        }
        public string _Stars
        {
            get { return _stars; }
            set { _stars = value; Stars.Text = $"Stars: {value}"; }
        }

        public Image _Poster
        {
            get { return _poster; }
            set { _poster = value; pictureBox1.Image = value; }
        }
        private void frm_menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

    }
}


