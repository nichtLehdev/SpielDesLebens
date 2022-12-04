using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Spiel_Des_Lebens
{
    public partial class Form1 : Form
    {
        private String profession = null;
        private String training = null;
        private int slot;
        private UiInterfaceMenu uiMenu = new UiInterfaceMenu();
        public Form1()
        {
            InitializeComponent();
        }

        private void open_next(object sender, EventArgs e)
        {

            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                Form2 mainForm = new Form2(txt_name.Text, txt_alter.Text, avatar, abschluss, true, training, profession, profession_path.Text, slot);
                mainForm.TopLevel = false;
                mainForm.FormBorderStyle = FormBorderStyle.None;
                mainForm.Dock = DockStyle.Fill;
                this.Controls.Add(mainForm);
                this.Tag = mainForm;
                mainForm.BringToFront();
                mainForm.Show();
            }

        }
        private void no_border()
        {
            avatarBox1.BorderStyle = BorderStyle.None;
            avatarBox2.BorderStyle = BorderStyle.None;
            avatarBox3.BorderStyle = BorderStyle.None;
            avatarBox4.BorderStyle = BorderStyle.None;
            avatarBox5.BorderStyle = BorderStyle.None;
            avatarBox6.BorderStyle = BorderStyle.None;
        }
        private Image avatar;
        private void changeAvatar(object sender, EventArgs e)
        {
            no_border();
            if (sender == avatarBox1)
            {
                avatarBox1.BorderStyle = BorderStyle.FixedSingle;
            }
            else if (sender == avatarBox2)
            {
                avatarBox2.BorderStyle = BorderStyle.FixedSingle;
            }
            else if (sender == avatarBox3)
            {
                avatarBox3.BorderStyle = BorderStyle.FixedSingle;
            }
            else if (sender == avatarBox4)
            {
                avatarBox4.BorderStyle = BorderStyle.FixedSingle;
            }
            else if (sender == avatarBox5)
            {
                avatarBox5.BorderStyle = BorderStyle.FixedSingle;
            }
            else if (sender == avatarBox6)
            {
                avatarBox6.BorderStyle = BorderStyle.FixedSingle;
            }
            PictureBox img = (PictureBox)sender;
            avatar = img.Image;
        }

        private void load_test(object sender, EventArgs e)
        {
            //für das Bsp werden sie vorher gestzt
            Form2 t = new Form2("Mia Münstermann", "20", avatarBox1.Image, "Testabschluss", false, "Training", "Stem", "Pharmazeutisch Technische Assistenz", 1);
            t.Show();
            this.Hide();
        }


        private string abschluss;
        private void changePath(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            abschluss = btn.Text;
            education_path.Items.Clear();
            education_path.Text = null;
            profession_path.Text = null;
            if (abschluss == "Hauptschulabschluss")
            {
                education_path.Items.AddRange(new object[] { "Ausbildung" });
            }
            else if (abschluss == "Realschulabschluss")
            {
                education_path.Items.AddRange(new object[] { "Ausbildung", "Duales Studium" });
            }
            else
            {
                education_path.Items.AddRange(new object[] { "Ausbildung", "Duales Studium", "Studium" });
            }
        }

        private void neues_Spiel_open(Object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if(sender == slot_btn_1)
            {
                slot = 1;
            }
            else if (sender == slot_btn_2)
            {
                slot = 2;
            }
            else if (sender == slot_btn_3)
            {
                slot = 3;
            }
            if (btn.Text == "Neues Spiel")
            {
                Layout_neues_Spiel.Visible = true;
                panel1.Visible = false;
            }
            else
            {
                panel2.Visible = true;
                button_mini_1.Visible = true;
                button_mini_2.Visible = true;
                button_mini_3.Visible = true;
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
        }
        public void CustomizeLinearGradients(PaintEventArgs e)
        {
            LinearGradientBrush linGrBrush = new LinearGradientBrush(
               new Point(0, 10),
               new Point(200, 10),
               Color.FromArgb(255, 0, 0, 0),     // Opaque black
               Color.FromArgb(255, 255, 0, 0));  // Opaque red

            float[] relativeIntensities = { 0.0f, 0.5f, 1.0f };
            float[] relativePositions = { 0.0f, 0.2f, 1.0f };

            //Create a Blend object and assign it to linGrBrush.
            Blend blend = new Blend();
            blend.Factors = relativeIntensities;
            blend.Positions = relativePositions;
            linGrBrush.Blend = blend;

            e.Graphics.FillEllipse(linGrBrush, 0, 30, 200, 100);
            e.Graphics.FillRectangle(linGrBrush, 0, 155, 500, 30);
        }
        private void accept_fict_btn_Click(object sender, EventArgs e)
        {
            fiction_panel.Visible = false;
            load_saves();

        }
        private void load_saves()
        {
            if (this.uiMenu.hasValidData(1))
            {
                slot_btn_1.Text = "Spielstand 1";
            }
            else
            {
                slot_btn_1.Text = "Neues Spiel";
            }

            if (this.uiMenu.hasValidData(2))
            {
                slot_btn_2.Text = "Spielstand 2";
            }
            else
            {
                slot_btn_2.Text = "Neues Spiel";
            }

            if (this.uiMenu.hasValidData(3))
            {
                slot_btn_3.Text = "Spielstand 3";
            }
            else
            {
                slot_btn_3.Text = "Neues Spiel";
            }
        }




        private void education_path_TextChanged(object sender, EventArgs e)
        {
            profession_path.Text = null;
            profession_path.Items.Clear();
            if (education_path.Text == "Ausbildung")
            {

                training = "Training";
                profession_path.Items.AddRange(new object[] { "Krankenpflege", "Industriekaufmann", "Pharmazeutisch Technische Assistenz", "Fachinformatiker", "Rechtanwaltsfachangestellter" });
            }
            else if (education_path.Text == "Duales Studium")
            {
                training = "DualStudy";
                profession_path.Items.AddRange(new object[] { "Angewandte Gesundheits- und Pflegewissenschaften", "BWL", "Angewandte Physik", "Angewandtes Informatikstudium", "Steuerwesen" });
            }
            else if (education_path.Text == "Studium")
            {
                training = "Study";
                profession_path.Items.AddRange(new object[] { "Medizinstudium", "BWL", "Physikstudium", "Informatikstudium", "Jurastudium" });
            }
        }

        private void profession_path_TextChanged(object sender, EventArgs e)
        {
            if (education_path.Text == "Ausbildung")
            {
                if (profession_path.Text == "Krankenpflege")
                {
                    profession = "Social";
                }
                else if (profession_path.Text == "Industriekaufmann")
                {
                    profession = "Business";
                }
                else if (profession_path.Text == "Pharmazeutisch Technische Assistenz")
                {
                    profession = "Science";
                }
                else if (profession_path.Text == "Fachinformatiker")
                {
                    profession = "Stem";
                }
                else if (profession_path.Text == "Rechtanwaltsfachangestellter")
                {
                    profession = "Civil";
                }
            }
            else if (education_path.Text == "Duales Studium")
            {
                if (profession_path.Text == "Angewandte Gesundheits- und Pflegewissenschaften")
                {
                    profession = "Social";
                }
                else if (profession_path.Text == "BWL")
                {
                    profession = "Business";
                }
                else if (profession_path.Text == "Angewandte Physik")
                {
                    profession = "Science";
                }
                else if (profession_path.Text == "Angewandtes Informatikstudium")
                {
                    profession = "Stem";
                }
                else if (profession_path.Text == "Steuerwesen")
                {
                    profession = "Civil";
                }
            }
            else if (education_path.Text == "Studium")
            {
                if (profession_path.Text == "Medizinstudium")
                {
                    profession = "Social";
                }
                else if (profession_path.Text == "BWL")
                {
                    profession = "Business";
                }
                else if (profession_path.Text == "Physikstudium")
                {
                    profession = "Science";
                }
                else if (profession_path.Text == "Informatikstudium")
                {
                    profession = "Stem";
                }
                else if (profession_path.Text == "Jurastudium")
                {
                    profession = "Civil";
                }
            }
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
            else if (string.IsNullOrEmpty(training))
            {
                e.Cancel = true;
                errorProvider1.SetError(weiter_button, "Wähle einen Bildungsweg");
            }
            else if (string.IsNullOrEmpty(profession))
            {
                e.Cancel = true;
                errorProvider1.SetError(weiter_button, "Wähle einen Karriereweg");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(weiter_button, null);
            }
        }

        private void button_mini_2_Click(object sender, EventArgs e)
        {
            uiMenu.deleteSaveGame(slot);
            panel2.Visible = false;
            load_saves();
        }
    }
}
