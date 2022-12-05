using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Spiel_Des_Lebens
{
    internal partial class Form1 : Form
    {
        private String profession = null;
        private String training = null;
        private int slot;
        private UiInterfaceMenu uiMenu = new UiInterfaceMenu();
        private UiInterface ui_interface;
        public Form1()
        {
            InitializeComponent();
        }

        private void open_next(object sender, EventArgs e)
        {

            if (validateInputs())
            {
                Form2 mainForm = createForm2();
                mainForm.TopLevel = false;
                mainForm.FormBorderStyle = FormBorderStyle.None;
                mainForm.Dock = DockStyle.Fill;
                this.Controls.Add(mainForm);
                this.Tag = mainForm;
                mainForm.BringToFront();
                mainForm.Show();
            }

        }


        public Form2 createForm2()
        {
            return new Form2(ui_interface);
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

        private void loadSaveGame(Object sender, EventArgs e)
        {
            uiMenu.loadGame(slot);
            ui_interface = uiMenu.createUiInterface();
            Form2 t = createForm2();
            t.Show();
            this.Hide();
        }


        private string abschluss;
        private void changePath(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btnAbi.FlatStyle = FlatStyle.System;
            btnHauptschule.FlatStyle = FlatStyle.System;
            btnRealschule.FlatStyle = FlatStyle.System;
            btnFachabi.FlatStyle = FlatStyle.System;
            abschluss = btn.Text;
            dropDown_profession.Items.Clear();
            dropDown_profession.Text = null;
            dropDown_path.Text = null;
            if (abschluss == "Hauptschulabschluss")
            {
                btnHauptschule.FlatStyle = FlatStyle.Popup;
                dropDown_profession.Items.AddRange(new object[] { "Ausbildung" });
            }
            else if (abschluss == "Realschulabschluss")
            {
                btnRealschule.FlatStyle = FlatStyle.Popup;
                btnHauptschule.BackColor = Color.Gray;
                dropDown_profession.Items.AddRange(new object[] { "Ausbildung", "Duales Studium" });
            }
            else
            {
                if(abschluss == "Fachhochschulreife")
                {
                    btnFachabi.FlatStyle = FlatStyle.Popup;
                }
                else
                {
                    btnAbi.FlatStyle = FlatStyle.Popup;
                }
                dropDown_profession.Items.AddRange(new object[] { "Ausbildung", "Duales Studium", "Studium" });
            }
        }

        private void neues_Spiel_open(Object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (sender == slot_btn_1)
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
            dropDown_path.Text = null;
            dropDown_path.Items.Clear();
            if (dropDown_profession.Text == "Ausbildung")
            {

                training = "Training";
                dropDown_path.Items.AddRange(new object[] { "Krankenpflege", "Industriekaufmann", "Pharmazeutisch Technische Assistenz", "Fachinformatiker", "Rechtanwaltsfachangestellter" });
            }
            else if (dropDown_profession.Text == "Duales Studium")
            {
                training = "DualStudy";
                dropDown_path.Items.AddRange(new object[] { "Angewandte Gesundheits- und Pflegewissenschaften", "BWL", "Angewandte Physik", "Angewandtes Informatikstudium", "Steuerwesen" });
            }
            else if (dropDown_profession.Text == "Studium")
            {
                training = "Study";
                dropDown_path.Items.AddRange(new object[] { "Medizinstudium", "BWL", "Physikstudium", "Informatikstudium", "Jurastudium" });
            }
        }

        private void profession_path_TextChanged(object sender, EventArgs e)
        {
            if (dropDown_profession.Text == "Ausbildung")
            {
                if (dropDown_path.Text == "Krankenpflege")
                {
                    profession = "Social";
                }
                else if (dropDown_path.Text == "Industriekaufmann")
                {
                    profession = "Business";
                }
                else if (dropDown_path.Text == "Pharmazeutisch Technische Assistenz")
                {
                    profession = "Science";
                }
                else if (dropDown_path.Text == "Fachinformatiker")
                {
                    profession = "Stem";
                }
                else if (dropDown_path.Text == "Rechtanwaltsfachangestellter")
                {
                    profession = "Civil";
                }
            }
            else if (dropDown_profession.Text == "Duales Studium")
            {
                if (dropDown_path.Text == "Angewandte Gesundheits- und Pflegewissenschaften")
                {
                    profession = "Social";
                }
                else if (dropDown_path.Text == "BWL")
                {
                    profession = "Business";
                }
                else if (dropDown_path.Text == "Angewandte Physik")
                {
                    profession = "Science";
                }
                else if (dropDown_path.Text == "Angewandtes Informatikstudium")
                {
                    profession = "Stem";
                }
                else if (dropDown_path.Text == "Steuerwesen")
                {
                    profession = "Civil";
                }
            }
            else if (dropDown_profession.Text == "Studium")
            {
                if (dropDown_path.Text == "Medizinstudium")
                {
                    profession = "Social";
                }
                else if (dropDown_path.Text == "BWL")
                {
                    profession = "Business";
                }
                else if (dropDown_path.Text == "Physikstudium")
                {
                    profession = "Science";
                }
                else if (dropDown_path.Text == "Informatikstudium")
                {
                    profession = "Stem";
                }
                else if (dropDown_path.Text == "Jurastudium")
                {
                    profession = "Civil";
                }
            }
        }

        private Boolean validateInputs()
        {

            if (string.IsNullOrEmpty(txt_name.Text))
            {
                lbl_userInfo.Text = "!!! Wähle einen Namen !!!";
                return false;

            }
            else if (string.IsNullOrEmpty(txt_age.Text) || Convert.ToInt16(txt_age.Text) > 60 || Convert.ToInt16(txt_age.Text) < 15)
            {
                lbl_userInfo.Text = "!!! Wähle ein Alter zwischen 15 und 60!!!";
                return false;
            }
            else if (string.IsNullOrEmpty(abschluss))
            {
                lbl_userInfo.Text = "!!! Wähle einen Schulabschluss !!!";
                return false;

            }
            else if (string.IsNullOrEmpty(training))
            {
                lbl_userInfo.Text = "!!! Wähle einen Bildungsweg !!!";
                return false;
            }
            else if (string.IsNullOrEmpty(profession))
            {
                lbl_userInfo.Text = "!!! Wähle einen Karriereweg !!!";
                return false;
            }
            else if(avatar == null)
            {
                lbl_userInfo.Text = "!!! Wähle einen Avatar !!!";
                return false;
            }
            return true;
        }

        private void button_mini_2_Click(object sender, EventArgs e)
        {
            uiMenu.deleteSaveGame(slot);
            panel2.Visible = false;
            load_saves();
        }
    }
}