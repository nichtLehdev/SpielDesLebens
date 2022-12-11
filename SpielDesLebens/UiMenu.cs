// @author: Joel Dag, Liz Wellhausen

using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace SpielDesLebens
{
    internal partial class UiMenu : Form
    {
        private int _slot;
        private int _avatar;
        private int _path;
        private int _profession;
        private int _graduation;
        private string _graduationString;
        private readonly UiInterfaceMenu _uiMenu = new UiInterfaceMenu();
        private UiInterface _uiInterface;

        public UiMenu()
        {
            InitializeComponent();
        }


        public UiGame CreateFormUiGame(bool newGame)
        {
            return new UiGame(_uiInterface, newGame, this);
        }

        public void ShowFormUiGame(UiGame uiGame)
        {
            uiGame.TopLevel = false;
            uiGame.FormBorderStyle = FormBorderStyle.None;
            uiGame.Dock = DockStyle.Fill;
            Controls.Add(uiGame);
            Tag = uiGame;
            uiGame.BringToFront();
            uiGame.Show();
        }

        private void OpenNewGame(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                UiGame uiGame = CreateFormUiGame(true);
                ShowFormUiGame(uiGame);
            }
        }

        private void LoadSaveGame(Object sender, EventArgs e)
        {
            _uiMenu.LoadGame(_slot);
            _uiInterface = _uiMenu.CreateUiInterface(_slot);
            UiGame uiGame = CreateFormUiGame(false);
            _panel2.Visible = false;
            ShowFormUiGame(uiGame);

        }


        private void NoBorder()
        {
            _avatarBox1.BorderStyle = BorderStyle.None;
            _avatarBox2.BorderStyle = BorderStyle.None;
            _avatarBox3.BorderStyle = BorderStyle.None;
            _avatarBox4.BorderStyle = BorderStyle.None;
            _avatarBox5.BorderStyle = BorderStyle.None;
            _avatarBox6.BorderStyle = BorderStyle.None;
            _avatarBox1.BackColor = Color.Transparent;
            _avatarBox2.BackColor = Color.Transparent;
            _avatarBox3.BackColor = Color.Transparent;
            _avatarBox4.BackColor = Color.Transparent;
            _avatarBox5.BackColor = Color.Transparent;
            _avatarBox6.BackColor = Color.Transparent;
        }
        private void ChangeAvatar(object sender, EventArgs e)
        {
            NoBorder();
            if (sender == _avatarBox1)
            {
                _avatarBox1.BorderStyle = BorderStyle.FixedSingle;
                _avatarBox1.BackColor = Color.RosyBrown;
                _avatar = 1;
            }
            else if (sender == _avatarBox2)
            {
                _avatarBox2.BorderStyle = BorderStyle.FixedSingle;
                _avatarBox2.BackColor = Color.RosyBrown;
                _avatar = 2;
            }
            else if (sender == _avatarBox3)
            {
                _avatarBox3.BorderStyle = BorderStyle.FixedSingle;
                _avatarBox3.BackColor = Color.RosyBrown;
                _avatar = 3;
            }
            else if (sender == _avatarBox4)
            {
                _avatarBox4.BorderStyle = BorderStyle.FixedSingle;
                _avatarBox4.BackColor = Color.RosyBrown;
                _avatar = 4;
            }
            else if (sender == _avatarBox5)
            {
                _avatarBox5.BorderStyle = BorderStyle.FixedSingle;
                _avatarBox5.BackColor = Color.RosyBrown;
                _avatar = 5;
            }
            else if (sender == _avatarBox6)
            {
                _avatarBox6.BackColor = Color.RosyBrown;
                _avatarBox6.BorderStyle = BorderStyle.FixedSingle;
                _avatar = 6;
            }
        }

        private void ChangePath(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            _btnAbi.FlatStyle = FlatStyle.System;
            _btnHauptschule.FlatStyle = FlatStyle.System;
            _btnRealschule.FlatStyle = FlatStyle.System;
            _btnFachAbi.FlatStyle = FlatStyle.System;
            _graduationString = btn.Text;
            _dropDownProfession.Items.Clear();
            _dropDownProfession.Text = null;
            _dropDownPath.Text = null;
            if (_graduationString == "Hauptschulabschluss")
            {
                _graduation = 0;
                _btnHauptschule.FlatStyle = FlatStyle.Popup;
                _dropDownProfession.Items.AddRange(new object[] { "Ausbildung" });
            }
            else if (_graduationString == "Realschulabschluss")
            {
                _graduation = 1;
                _btnRealschule.FlatStyle = FlatStyle.Popup;
                _dropDownProfession.Items.AddRange(new object[] { "Ausbildung", "Duales Studium" });
            }
            else
            {
                if (_graduationString == "Fachhochschulreife")
                {
                    _graduation = 2;
                    _btnFachAbi.FlatStyle = FlatStyle.Popup;
                }
                else
                {
                    _graduation = 3;
                    _btnAbi.FlatStyle = FlatStyle.Popup;
                }
                _dropDownProfession.Items.AddRange(new object[] { "Ausbildung", "Duales Studium", "Studium" });
            }
        }

        private void NewGameOpen(Object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (sender == _slotBtn1)
            {
                _slot = 1;
            }
            else if (sender == _slotBtn2)
            {
                _slot = 2;
            }
            else if (sender == _slotBtn3)
            {
                _slot = 3;
            }
            if (btn.Text == "Neues Spiel")
            {
                _layouNewGame.Visible = true;
                _panel1.Visible = false;
            }
            else
            {
                _panel2.Visible = true;
                _buttonMini1.Visible = true;
                _buttonMini2.Visible = true;
                _buttonMini3.Visible = true;
            }

        }
        private void OpenMainMenu(object sender, EventArgs e)
        {
            _panel1.Visible = true;
            _layouNewGame.Visible = false;
        }

        private void TxtOldKeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void CloseOptionSpielStart(object sender, EventArgs e)
        {
            _panel2.Visible = false;
            _buttonMini1.Visible = false;
            _buttonMini2.Visible = false;
            _buttonMini3.Visible = false;
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

            // Create a Blend object and assign it to linGrBrush.
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
            _fictionPanel.Visible = false;
            LoadSaves();

        }
        public void LoadSaves()
        {
            if (UiInterfaceMenu.HasValidData(1))
            {
                _slotBtn1.Text = "Spielstand 1";
            }
            else
            {
                _slotBtn1.Text = "Neues Spiel";
            }

            if (UiInterfaceMenu.HasValidData(2))
            {
                _slotBtn2.Text = "Spielstand 2";
            }
            else
            {
                _slotBtn2.Text = "Neues Spiel";
            }

            if (UiInterfaceMenu.HasValidData(3))
            {
                _slotBtn3.Text = "Spielstand 3";
            }
            else
            {
                _slotBtn3.Text = "Neues Spiel";
            }
        }




        private void EducationPathTextChanged(object sender, EventArgs e)
        {
            _dropDownPath.Text = null;
            _dropDownPath.Items.Clear();
            if (_dropDownProfession.Text == "Ausbildung")
            {

                _path = 0;
                _dropDownPath.Items.AddRange(new object[] { "Krankenpflege", "Industriekaufmann", "Pharmazeutisch Technische Assistenz", "Fachinformatiker", "Rechtanwaltsfachangestellter" });
            }
            else if (_dropDownProfession.Text == "Duales Studium")
            {
                _path = 1;
                _dropDownPath.Items.AddRange(new object[] { "Angewandte Gesundheits- und Pflegewissenschaften", "BWL", "Angewandte Physik", "Angewandtes Informatikstudium", "Steuerwesen" });
            }
            else if (_dropDownProfession.Text == "Studium")
            {
                _path = 2;
                _dropDownPath.Items.AddRange(new object[] { "Medizinstudium", "BWL", "Physikstudium", "Informatikstudium", "Jurastudium" });
            }
        }

        private void ProfessionPathTextChanged(object sender, EventArgs e)
        {
            if (_dropDownProfession.Text == "Ausbildung")
            {
                if (_dropDownPath.Text == "Krankenpflege")
                {
                    _profession = 0;
                }
                else if (_dropDownPath.Text == "Industriekaufmann")
                {
                    _profession = 1;
                }
                else if (_dropDownPath.Text == "Pharmazeutisch Technische Assistenz")
                {
                    _profession = 2;
                }
                else if (_dropDownPath.Text == "Fachinformatiker")
                {
                    _profession = 3;
                }
                else if (_dropDownPath.Text == "Rechtanwaltsfachangestellter")
                {
                    _profession = 4;
                }
            }
            else if (_dropDownProfession.Text == "Duales Studium")
            {
                if (_dropDownPath.Text == "Angewandte Gesundheits- und Pflegewissenschaften")
                {
                    _profession = 0;
                }
                else if (_dropDownPath.Text == "BWL")
                {
                    _profession = 1;
                }
                else if (_dropDownPath.Text == "Angewandte Physik")
                {
                    _profession = 2;
                }
                else if (_dropDownPath.Text == "Angewandtes Informatikstudium")
                {
                    _profession = 3;
                }
                else if (_dropDownPath.Text == "Steuerwesen")
                {
                    _profession = 4;
                }
            }
            else if (_dropDownProfession.Text == "Studium")
            {
                if (_dropDownPath.Text == "Medizinstudium")
                {
                    _profession = 0;
                }
                else if (_dropDownPath.Text == "BWL")
                {
                    _profession = 1;
                }
                else if (_dropDownPath.Text == "Physikstudium")
                {
                    _profession = 2;
                }
                else if (_dropDownPath.Text == "Informatikstudium")
                {
                    _profession = 3;
                }
                else if (_dropDownPath.Text == "Jurastudium")
                {
                    _profession = 4;
                }
            }
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrEmpty(_txtName.Text))
            {
                _lblUserInfo.Text = "!!! Wähle einen Namen !!!";
                return false;

            }
            else if (string.IsNullOrEmpty(_txtAge.Text) || Convert.ToInt16(_txtAge.Text) > 60 || Convert.ToInt16(_txtAge.Text) < 15)
            {
                _lblUserInfo.Text = "!!! Wähle ein Alter zwischen 15 und 60!!!";
                return false;
            }
            else if (string.IsNullOrEmpty(_graduationString))
            {
                _lblUserInfo.Text = "!!! Wähle einen Schulabschluss !!!";
                return false;

            }
            else if (_dropDownPath.Text == "")
            {
                _lblUserInfo.Text = "!!! Wähle Bilundgs- und Karriereweg!!!";
                return false;
            }
            else if (_dropDownProfession.Text == "")
            {
                _lblUserInfo.Text = "!!! Wähle Bilundgs- und Karriereweg!!!";
                return false;
            }
            else if (_avatar < 1 || _avatar > 6)
            {
                _lblUserInfo.Text = "!!! Wähle einen Avatar !!!";
                return false;
            }
            _uiMenu.CreatePlayer(_avatar, Convert.ToInt16(_txtAge.Text), _txtName.Text, (Data.Path)_path, (Data.Profession)_profession, (Data.Graduation)_graduation);
            _uiInterface = _uiMenu.CreateUiInterface(_slot);
            return true;
        }

        private void ButtonMini2Click(object sender, EventArgs e)
        {
            _uiMenu.DeleteSaveGame(_slot);
            _panel2.Visible = false;
            LoadSaves();
        }

        public void ResetForm()
        {
            _txtAge.Clear();
            _txtName.Clear();
            Console.WriteLine(_txtAge.Text);
            _path = 10;
            _profession = 10;
            _graduation = 10;
            _btnAbi.FlatStyle = FlatStyle.System;
            _btnHauptschule.FlatStyle = FlatStyle.System;
            _btnRealschule.FlatStyle = FlatStyle.System;
            _btnFachAbi.FlatStyle = FlatStyle.System;
            _graduationString = "";
            _avatar = 10;

            _avatarBox1.BackColor = Color.Transparent;
            _avatarBox2.BackColor = Color.Transparent;
            _avatarBox3.BackColor = Color.Transparent;
            _avatarBox4.BackColor = Color.Transparent;
            _avatarBox5.BackColor = Color.Transparent;
            _avatarBox6.BackColor = Color.Transparent;
            _avatarBox1.BorderStyle = BorderStyle.None;
            _avatarBox2.BorderStyle = BorderStyle.None;
            _avatarBox3.BorderStyle = BorderStyle.None;
            _avatarBox4.BorderStyle = BorderStyle.None;
            _avatarBox5.BorderStyle = BorderStyle.None;
            _avatarBox6.BorderStyle = BorderStyle.None;

            _dropDownPath.Items.Clear();
            _dropDownProfession.Items.Clear();
            _panel1.Visible = true;
            _panel1.BringToFront();
        }
    }
}