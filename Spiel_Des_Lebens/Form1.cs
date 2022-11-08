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
                this.Hide();
            }
        }

        private Image avatar;
        private void change_Avatar(object sender, EventArgs e)
        {
            PictureBox img = (PictureBox)sender;
            avatar = img.Image;
        }

        private void laden_test(object sender, EventArgs e)
        {
            //für das Bsp werden sie vorher gestzt
            Form2 t = new Form2("Mia Münstermann", "20", pictureBox1.Image, "Testaschlusss");
            t.Show();
            this.Hide();
        }


        private string abschluss;
        private void change_Abschluss(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            abschluss = btn.Text;
            Console.WriteLine(abschluss);
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

        private void txt_alter_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void Close_option_spiel_start(object sender, EventArgs e)
        {
            panel2.Visible = false;
            button_mini_1.Visible = false;
            button_mini_2.Visible = false;
            button_mini_3.Visible = false;
            textBox_mini_field.Visible = false;
        }

        private void button2_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(abschluss))
            {
                e.Cancel = true;
                errorProvider1.SetError(weiter_button, "Wähle einen Schulabschluss");
            }
            else if (string.IsNullOrEmpty(txt_name.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(weiter_button, "Bitte gebe einen namen ein");
            }
            else if (string.IsNullOrEmpty(txt_alter.Text) || Convert.ToInt16(txt_alter.Text) > 60 || Convert.ToInt16(txt_alter.Text) < 15)
            {
                e.Cancel = true;
                errorProvider1.SetError(weiter_button, "Wähle ein Alter zwischen 15 und 60");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(weiter_button, null);
            }
        }
    }
}
