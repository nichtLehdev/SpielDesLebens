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
        private string abschluss;
        private Image avatar;
        private Form activeForm;
        public Form2(string name, string alter, Image avatar, string abschluss)
        {
            InitializeComponent();
            pictureBox1.Image = avatar;
            this.name = name;
            this.alter = Convert.ToInt16(alter);
            this.abschluss = abschluss;
            this.avatar = avatar;
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            lblPlayerAge.Text = Convert.ToString(this.alter);
            lblPlayerName.Text = this.name;
            btnAktion_Click(sender, e);

        }

        public void OpenChildForm(Form childForm, object btnSender)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelActiveChild.Controls.Add(childForm);
            this.panelActiveChild.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

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

        private void btnAktion_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormActions(), sender);
        }

        private void btnSport_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormFreetime(), sender);

        }

        private void btnHausis_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormSchool(), sender);

        }

        private void btnMusik_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormFreetime(), sender);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormFreetime(), sender);

        }
    }
}
