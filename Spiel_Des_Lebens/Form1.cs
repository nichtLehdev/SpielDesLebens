using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Spiel_Des_Lebens
{
    internal partial class Form1 : Form
    {
        //private String profession = null;
        //private String training = null;
        private int profession;
        private int path;
        private int graduation;
        private int slot;
        private readonly UiInterfaceMenu uiMenu = new UiInterfaceMenu();
        private UiInterface uiInterface;
        public Form1()
        {
            InitializeComponent();
        }

        private void OpenNext(object sender, EventArgs e)
        {

            if (ValidateInputs())
            {
                Form2 mainForm = CreateForm2();
                mainForm.TopLevel = false;
                mainForm.FormBorderStyle = FormBorderStyle.None;
                mainForm.Dock = DockStyle.Fill;
                this.Controls.Add(mainForm);
                this.Tag = mainForm;
                mainForm.BringToFront();
                mainForm.Show();
            }

        }


        public Form2 CreateForm2()
        {
            return new Form2(uiInterface);
        }


        private void NoBorder()
        {
            avatarBox1.BorderStyle = BorderStyle.None;
            avatarBox2.BorderStyle = BorderStyle.None;
            avatarBox3.BorderStyle = BorderStyle.None;
            avatarBox4.BorderStyle = BorderStyle.None;
            avatarBox5.BorderStyle = BorderStyle.None;
            avatarBox6.BorderStyle = BorderStyle.None;
        }
        private Image avatar;
        private void ChangeAvatar(object sender, EventArgs e)
        {
            NoBorder();
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

        private void LoadSaveGame(Object sender, EventArgs e)
        {
            uiMenu.LoadGame(slot);
            uiInterface = uiMenu.CreateUiInterface();
            Form2 t = CreateForm2();
            t.Show();
            this.Hide();
        }


        private string abschluss;
        private void ChangePath(object sender, EventArgs e)
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
                graduation = 0;
                btnHauptschule.FlatStyle = FlatStyle.Popup;
                dropDown_profession.Items.AddRange(new object[] { "Ausbildung" });
            }
            else if (abschluss == "Realschulabschluss")
            {
                graduation = 1;
                btnRealschule.FlatStyle = FlatStyle.Popup;
                btnHauptschule.BackColor = Color.Gray;
                dropDown_profession.Items.AddRange(new object[] { "Ausbildung", "Duales Studium" });
            }
            else
            {
                if (abschluss == "Fachhochschulreife")
                {
                    graduation = 2;
                    btnFachabi.FlatStyle = FlatStyle.Popup;
                }
                else
                {
                    graduation = 3;
                    btnAbi.FlatStyle = FlatStyle.Popup;
                }
                dropDown_profession.Items.AddRange(new object[] { "Ausbildung", "Duales Studium", "Studium" });
            }
        }

        private void NewGameOpen(Object sender, EventArgs e)
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
        private void OpenMainMenu(object sender, EventArgs e)
        {
            panel1.Visible = true;
            Layout_neues_Spiel.Visible = false;
        }

        private void TxtOldKeyPress(object sender, KeyPressEventArgs e)
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
            Blend blend = new Blend
            {
                Factors = relativeIntensities,
                Positions = relativePositions
            };
            linGrBrush.Blend = blend;

            e.Graphics.FillEllipse(linGrBrush, 0, 30, 200, 100);
            e.Graphics.FillRectangle(linGrBrush, 0, 155, 500, 30);
        }
        private void AcceptFictBtnClick(object sender, EventArgs e)
        {
            fiction_panel.Visible = false;
            LoadSaves();

        }
        private void LoadSaves()
        {
            if (this.uiMenu.HasValidData(1))
            {
                slot_btn_1.Text = "Spielstand 1";
            }
            else
            {
                slot_btn_1.Text = "Neues Spiel";
            }

            if (this.uiMenu.HasValidData(2))
            {
                slot_btn_2.Text = "Spielstand 2";
            }
            else
            {
                slot_btn_2.Text = "Neues Spiel";
            }

            if (this.uiMenu.HasValidData(3))
            {
                slot_btn_3.Text = "Spielstand 3";
            }
            else
            {
                slot_btn_3.Text = "Neues Spiel";
            }
        }




        private void EducationPathTextChanged(object sender, EventArgs e)
        {
            dropDown_path.Text = null;
            dropDown_path.Items.Clear();
            if (dropDown_profession.Text == "Ausbildung")
            {

                path = 0;
                dropDown_path.Items.AddRange(new object[] { "Krankenpflege", "Industriekaufmann", "Pharmazeutisch Technische Assistenz", "Fachinformatiker", "Rechtanwaltsfachangestellter" });
            }
            else if (dropDown_profession.Text == "Duales Studium")
            {
                path = 1;
                dropDown_path.Items.AddRange(new object[] { "Angewandte Gesundheits- und Pflegewissenschaften", "BWL", "Angewandte Physik", "Angewandtes Informatikstudium", "Steuerwesen" });
            }
            else if (dropDown_profession.Text == "Studium")
            {
                path = 2;
                dropDown_path.Items.AddRange(new object[] { "Medizinstudium", "BWL", "Physikstudium", "Informatikstudium", "Jurastudium" });
            }
        }

        private void ProfessionPathTextChanged(object sender, EventArgs e)
        {
            if (dropDown_profession.Text == "Ausbildung")
            {
                if (dropDown_path.Text == "Krankenpflege")
                {
                    profession = 0;
                }
                else if (dropDown_path.Text == "Industriekaufmann")
                {
                    profession = 1;
                }
                else if (dropDown_path.Text == "Pharmazeutisch Technische Assistenz")
                {
                    profession = 2;
                }
                else if (dropDown_path.Text == "Fachinformatiker")
                {
                    profession = 3;
                }
                else if (dropDown_path.Text == "Rechtanwaltsfachangestellter")
                {
                    profession = 4;
                }
            }
            else if (dropDown_profession.Text == "Duales Studium")
            {
                if (dropDown_path.Text == "Angewandte Gesundheits- und Pflegewissenschaften")
                {
                    profession = 0;
                }
                else if (dropDown_path.Text == "BWL")
                {
                    profession = 1;
                }
                else if (dropDown_path.Text == "Angewandte Physik")
                {
                    profession = 2;
                }
                else if (dropDown_path.Text == "Angewandtes Informatikstudium")
                {
                    profession = 3;
                }
                else if (dropDown_path.Text == "Steuerwesen")
                {
                    profession = 4;
                }
            }
            else if (dropDown_profession.Text == "Studium")
            {
                if (dropDown_path.Text == "Medizinstudium")
                {
                    profession = 0;
                }
                else if (dropDown_path.Text == "BWL")
                {
                    profession = 1;
                }
                else if (dropDown_path.Text == "Physikstudium")
                {
                    profession = 2;
                }
                else if (dropDown_path.Text == "Informatikstudium")
                {
                    profession = 3;
                }
                else if (dropDown_path.Text == "Jurastudium")
                {
                    profession = 4;
                }
            }
        }

        private Boolean ValidateInputs()
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
            else if (path.Equals(null))
            {
                lbl_userInfo.Text = "!!! Wähle einen Bildungsweg !!!";
                return false;
            }
            else if (profession.Equals(null))
            {
                lbl_userInfo.Text = "!!! Wähle einen Karriereweg !!!";
                return false;
            }
            else if (avatar == null)
            {
                lbl_userInfo.Text = "!!! Wähle einen Avatar !!!";
                return false;
            }
            uiMenu.CreatePlayer(1, Convert.ToInt16(txt_age.Text), txt_name.Text, (Data.Path)path, (Data.Profession)profession, (Data.Graduation)graduation);
            return true;
        }

        private void ButtonMini2Click(object sender, EventArgs e)
        {
            uiMenu.DeleteSaveGame(slot);
            panel2.Visible = false;
            LoadSaves();
        }
    }
}