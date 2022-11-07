using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spiel_Des_Lebens
{
    public partial class Form2 : Form
    {
        private int alter;
        private string name;
        public Form2(string name, string alter, Image avatar, string abschluss)
        {
            InitializeComponent();
            pictureBox1.Image = avatar;
            this.name = name;
            this.alter = Convert.ToInt16(alter);
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            lblPlayerAge.Text = Convert.ToString(alter);
            lblPlayerName.Text = name;

        }

        private void show_info(object sender, EventArgs e)
        {
            info_panel.Visible = true;
            info_close_button.Visible = true;
            info_text.Visible = true;
        }

        private void info_close(object sender, EventArgs e)
        {
            info_panel.Visible = false;
            info_close_button.Visible = false;
            info_text.Visible = false;
        }
    }
}
