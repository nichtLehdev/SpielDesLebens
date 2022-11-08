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
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                Form2 t = new Form2(txt_name.Text, txt_alter.Text, avatar, abschluss);
                t.Show();
            }
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

        private void neues_Spiel_open(Object sender, EventArgs e)
        {
           Button btn = sender as Button;
           if (btn.Text == "Neues Spiel")
                {
                    Layout_neues_Spiel.Visible = true;
                    panel1.Visible = false;
                }
             else
                {
                textBox_mini_field.Text = btn.Text;
                panel2.Visible = true;
                button_mini_1.Visible = true;
                button_mini_2.Visible = true;
                button_mini_3.Visible = true;
                textBox_mini_field.Visible = true;
            }
            
        }

        private void open_main_menu(object sender, EventArgs e)
        {
            panel1.Visible = true;
            Layout_neues_Spiel.Visible = false;
        }

        private void txt_name_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_name.Text))
            {
                e.Cancel = true;
                txt_name.Focus();
                errorProvider1.SetError(txt_name, "Bitte gebe deinen Namen ein");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txt_name, null);
            }
        }

        private void txt_alter_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txt_alter_Validating(object sender, CancelEventArgs e)
        {
            if( string.IsNullOrEmpty(txt_alter.Text) || Convert.ToInt16(txt_alter.Text) > 60 || Convert.ToInt16(txt_alter.Text) < 15)
            {
                e.Cancel = true;
                txt_alter.Focus();
                errorProvider1.SetError(txt_alter, "Wähle ein Alter zwischen 15 und 60");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txt_alter, null);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Close_option_spiel_start(object sender, EventArgs e)
        {
            panel2.Visible = false;
            button_mini_1.Visible = false;
            button_mini_2.Visible = false;
            button_mini_3.Visible = false;
            textBox_mini_field.Visible = false;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
