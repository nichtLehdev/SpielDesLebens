// @author: Joel Dag, Liz Wellhausen

using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;

namespace SpielDesLebens
{
    internal partial class UiMenu : Form
    {
        private int profession;
        private int path;
        private int graduation;
        private int avatar;
        private int slot;
        private readonly UiInterfaceMenu uiMenu = new UiInterfaceMenu();
        private UiInterface uiInterface;
        public UiMenu()
        {
            InitializeComponent();
        }

        private void OpenNext(object sender, EventArgs e)
        {

            if (ValidateInputs())
            {
                UiGame mainForm = CreateFormUiGame();
                mainForm.TopLevel = false;
                mainForm.FormBorderStyle = FormBorderStyle.None;
                mainForm.Dock = DockStyle.Fill;
                this.Controls.Add(mainForm);
                this.Tag = mainForm;
                mainForm.BringToFront();
                mainForm.Show();
            }

        }


        public UiGame CreateFormUiGame()
        {
            return new UiGame(uiInterface);
        }


        private void NoBorder()
        {
            avatarBox1.BorderStyle = BorderStyle.None;
            avatarBox2.BorderStyle = BorderStyle.None;
            avatarBox3.BorderStyle = BorderStyle.None;
            avatarBox4.BorderStyle = BorderStyle.None;
            avatarBox5.BorderStyle = BorderStyle.None;
            avatarBox6.BorderStyle = BorderStyle.None;
            avatarBox1.BackColor = Color.Transparent;
            avatarBox2.BackColor = Color.Transparent;
            avatarBox3.BackColor = Color.Transparent;
            avatarBox4.BackColor = Color.Transparent;
            avatarBox5.BackColor = Color.Transparent;
            avatarBox6.BackColor = Color.Transparent;
        }
        private void ChangeAvatar(object sender, EventArgs e)
        {
            NoBorder();
            if (sender == avatarBox1)
            {
                avatarBox1.BorderStyle = BorderStyle.FixedSingle;
                avatarBox1.BackColor = Color.RosyBrown;
                avatar = 0;
            }
            else if (sender == avatarBox2)
            {
                avatarBox2.BorderStyle = BorderStyle.FixedSingle;
                avatarBox2.BackColor = Color.RosyBrown;
                avatar = 1;
            }
            else if (sender == avatarBox3)
            {
                avatarBox3.BorderStyle = BorderStyle.FixedSingle;
                avatarBox3.BackColor = Color.RosyBrown;
                avatar = 2;
            }
            else if (sender == avatarBox4)
            {
                avatarBox4.BorderStyle = BorderStyle.FixedSingle;
                avatarBox4.BackColor = Color.RosyBrown;
                avatar = 3;
            }
            else if (sender == avatarBox5)
            {
                avatarBox5.BorderStyle = BorderStyle.FixedSingle;
                avatarBox5.BackColor = Color.RosyBrown;
                avatar = 4;
            }
            else if (sender == avatarBox6)
            {
                avatarBox6.BackColor = Color.RosyBrown;
                avatarBox6.BorderStyle = BorderStyle.FixedSingle;
                avatar = 5;
            }
        }

        private void LoadSaveGame(Object sender, EventArgs e)
        {
            uiMenu.LoadGame(slot);
            uiInterface = uiMenu.CreateUiInterface(slot);
            UiGame t = CreateFormUiGame();
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
            btnFachAbi.FlatStyle = FlatStyle.System;
            abschluss = btn.Text;
            dropDownProfession.Items.Clear();
            dropDownProfession.Text = null;
            dropDownPath.Text = null;
            if (abschluss == "Hauptschulabschluss")
            {
                graduation = 0;
                btnHauptschule.FlatStyle = FlatStyle.Popup;
                dropDownProfession.Items.AddRange(new object[] { "Ausbildung" });
            }
            else if (abschluss == "Realschulabschluss")
            {
                graduation = 1;
                btnRealschule.FlatStyle = FlatStyle.Popup;
                btnHauptschule.BackColor = Color.Gray;
                dropDownProfession.Items.AddRange(new object[] { "Ausbildung", "Duales Studium" });
            }
            else
            {
                if (abschluss == "Fachhochschulreife")
                {
                    graduation = 2;
                    btnFachAbi.FlatStyle = FlatStyle.Popup;
                }
                else
                {
                    graduation = 3;
                    btnAbi.FlatStyle = FlatStyle.Popup;
                }
                dropDownProfession.Items.AddRange(new object[] { "Ausbildung", "Duales Studium", "Studium" });
            }
        }

        private void NewGameOpen(Object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (sender == slotBtn1)
            {
                slot = 1;
            }
            else if (sender == slotBtn2)
            {
                slot = 2;
            }
            else if (sender == SlotBtn3)
            {
                slot = 3;
            }
            if (btn.Text == "Neues Spiel")
            {
                layouNewGame.Visible = true;
                panel1.Visible = false;
            }
            else
            {
                panel2.Visible = true;
                buttonMini1.Visible = true;
                buttonMini2.Visible = true;
                buttonMini3.Visible = true;
            }

        }
        private void OpenMainMenu(object sender, EventArgs e)
        {
            panel1.Visible = true;
            layouNewGame.Visible = false;
        }

        private void TxtOldKeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void CloseOptionSpielStart(object sender, EventArgs e)
        {
            panel2.Visible = false;
            buttonMini1.Visible = false;
            buttonMini2.Visible = false;
            buttonMini3.Visible = false;
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
            fictionPanel.Visible = false;
            LoadSaves();

        }
        private void LoadSaves()
        {
            if (this.uiMenu.HasValidData(1))
            {
                slotBtn1.Text = "Spielstand 1";
            }
            else
            {
                slotBtn1.Text = "Neues Spiel";
            }

            if (this.uiMenu.HasValidData(2))
            {
                slotBtn2.Text = "Spielstand 2";
            }
            else
            {
                slotBtn2.Text = "Neues Spiel";
            }

            if (this.uiMenu.HasValidData(3))
            {
                SlotBtn3.Text = "Spielstand 3";
            }
            else
            {
                SlotBtn3.Text = "Neues Spiel";
            }
        }




        private void EducationPathTextChanged(object sender, EventArgs e)
        {
            dropDownPath.Text = null;
            dropDownPath.Items.Clear();
            if (dropDownProfession.Text == "Ausbildung")
            {

                path = 0;
                dropDownPath.Items.AddRange(new object[] { "Krankenpflege", "Industriekaufmann", "Pharmazeutisch Technische Assistenz", "Fachinformatiker", "Rechtanwaltsfachangestellter" });
            }
            else if (dropDownProfession.Text == "Duales Studium")
            {
                path = 1;
                dropDownPath.Items.AddRange(new object[] { "Angewandte Gesundheits- und Pflegewissenschaften", "BWL", "Angewandte Physik", "Angewandtes Informatikstudium", "Steuerwesen" });
            }
            else if (dropDownProfession.Text == "Studium")
            {
                path = 2;
                dropDownPath.Items.AddRange(new object[] { "Medizinstudium", "BWL", "Physikstudium", "Informatikstudium", "Jurastudium" });
            }
        }

        private void ProfessionPathTextChanged(object sender, EventArgs e)
        {
            if (dropDownProfession.Text == "Ausbildung")
            {
                if (dropDownPath.Text == "Krankenpflege")
                {
                    profession = 0;
                }
                else if (dropDownPath.Text == "Industriekaufmann")
                {
                    profession = 1;
                }
                else if (dropDownPath.Text == "Pharmazeutisch Technische Assistenz")
                {
                    profession = 2;
                }
                else if (dropDownPath.Text == "Fachinformatiker")
                {
                    profession = 3;
                }
                else if (dropDownPath.Text == "Rechtanwaltsfachangestellter")
                {
                    profession = 4;
                }
            }
            else if (dropDownProfession.Text == "Duales Studium")
            {
                if (dropDownPath.Text == "Angewandte Gesundheits- und Pflegewissenschaften")
                {
                    profession = 0;
                }
                else if (dropDownPath.Text == "BWL")
                {
                    profession = 1;
                }
                else if (dropDownPath.Text == "Angewandte Physik")
                {
                    profession = 2;
                }
                else if (dropDownPath.Text == "Angewandtes Informatikstudium")
                {
                    profession = 3;
                }
                else if (dropDownPath.Text == "Steuerwesen")
                {
                    profession = 4;
                }
            }
            else if (dropDownProfession.Text == "Studium")
            {
                if (dropDownPath.Text == "Medizinstudium")
                {
                    profession = 0;
                }
                else if (dropDownPath.Text == "BWL")
                {
                    profession = 1;
                }
                else if (dropDownPath.Text == "Physikstudium")
                {
                    profession = 2;
                }
                else if (dropDownPath.Text == "Informatikstudium")
                {
                    profession = 3;
                }
                else if (dropDownPath.Text == "Jurastudium")
                {
                    profession = 4;
                }
            }
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                lblUserInfo.Text = "!!! Wähle einen Namen !!!";
                return false;

            }
            else if (string.IsNullOrEmpty(txtAge.Text) || Convert.ToInt16(txtAge.Text) > 60 || Convert.ToInt16(txtAge.Text) < 15)
            {
                lblUserInfo.Text = "!!! Wähle ein Alter zwischen 15 und 60!!!";
                return false;
            }
            else if (string.IsNullOrEmpty(abschluss))
            {
                lblUserInfo.Text = "!!! Wähle einen Schulabschluss !!!";
                return false;

            }
            else if (path.Equals(null))
            {
                lblUserInfo.Text = "!!! Wähle einen Bildungsweg !!!";
                return false;
            }
            else if (profession.Equals(null))
            {
                lblUserInfo.Text = "!!! Wähle einen Karriereweg !!!";
                return false;
            }
            else if (avatar < 0 || avatar > 5)
            {
                lblUserInfo.Text = "!!! Wähle einen Avatar !!!";
                return false;
            }
            uiMenu.CreatePlayer(avatar, Convert.ToInt16(txtAge.Text), txtName.Text, (Data.Path)path, (Data.Profession)profession, (Data.Graduation)graduation);
            uiInterface = uiMenu.CreateUiInterface(slot);
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