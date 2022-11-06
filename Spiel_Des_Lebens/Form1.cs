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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void open_next(object sender, EventArgs e)
        {
            Form2 t = new Form2(txt_name.Text, txt_alter.Text, avatar, abschluss);
            t.Show();
        }
        private Image avatar;
        private void change_Avatar(object sender, EventArgs e)
        {
            if (pictureBox1 == sender)
            {
                avatar = pictureBox1.Image;
            }
            else if (pictureBox2 == sender)
            {
                avatar = pictureBox2.Image;
            }
            else if (pictureBox3 == sender)
            {
                avatar = pictureBox3.Image;
            }
            else if (pictureBox4 == sender)
            {
                avatar = pictureBox4.Image;
            }
            else if (pictureBox5 == sender)
            {
                avatar = pictureBox5.Image;
            }
            else if (pictureBox6 == sender)
            {
                avatar = pictureBox6.Image;
            }
        }
        private string abschluss;
        private void change_Abschluss(object sender, EventArgs e)
        {
            if (sender == button1)
            {
                abschluss = button1.Text;
            }
            else if (sender == button2)
            {
                abschluss = button2.Text;
            }
            else if (sender == button3)
            {
                abschluss = button3.Text;
            }
            else if (sender == button4)
            {
                abschluss = button4.Text;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
