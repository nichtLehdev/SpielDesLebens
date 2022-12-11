// @author: Joel Dag, Liz Wellhausen

using System;
using System.Drawing;
using System.Windows.Forms;

namespace SpielDesLebens
{
    internal partial class UiGame : Form
    {
        private Form _activeForm;
        private readonly UiInterface _uiInterface;
        private readonly bool _newGame;
        private int _actionChosen;

        private Data.Path _training;
        private Data.Profession _profession;
        private string _refrenceTraining;
        private string _refrenceProfession;
        private readonly UiMenu _uiMenu;


        public UiGame(UiInterface uiInterface, bool newGame, UiMenu uiMenu)
        {
            InitializeComponent();
            _uiInterface = uiInterface;
            _newGame = newGame;
            _uiMenu = uiMenu;
        }

        private void FormGameUiLoad(object sender, EventArgs e)
        {
            _lblPlayerAge.Text = Convert.ToString(_uiInterface.GetPlayerAge());
            _lblPlayerName.Text = _uiInterface.GetPlayerName();
            _lblPlayerPath.Text = _uiInterface.GetPlayerProfessionName();
            _avatarPic.Image = SetAvatar();
            BtnLoadEventClick();
            UpdateActionpoints();
            if (_newGame == true)
            {
                AllOptionsDisable();
                _tutorialAskPanel.Visible = true;
                _tutorialAskPanel.BringToFront();
            }
            GetNewActions();
        }
        private Image SetAvatar()
        {
            switch (_uiInterface.GetAvatar())
            {
                case 1: return SpielDesLebens.Properties.Resources.avatarBoy0;
                case 2: return SpielDesLebens.Properties.Resources.avatarBoy1;
                case 3: return SpielDesLebens.Properties.Resources.avatarBoy2;
                case 4: return SpielDesLebens.Properties.Resources.avatarGirl0;
                case 5: return SpielDesLebens.Properties.Resources.avatarGirl1;
                case 6: return SpielDesLebens.Properties.Resources.avatarGirl2;
                default: throw new Error("There has to be an avatar");
            }
        }
        public void OpenChildForm(Form childForm, object btnSender)
        {
            if (btnSender is null)
            {
                throw new ArgumentNullException(nameof(btnSender));
            }

            _activeForm?.Close();
            _activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            _panelActiveChild.Controls.Add(childForm);
            _panelActiveChild.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void ShowInfo(object sender, EventArgs e)
        {
            _infoText.Text = _uiInterface.GetEventInfo();
            _infoPanel.Visible = true;
            _infoCloseButton.Visible = true;
            _infoText.Visible = true;
            AllOptionsDisable();
        }

        private void InfoClose(object sender, EventArgs e)
        {
            _infoPanel.Visible = false;
            _infoCloseButton.Visible = false;
            _infoText.Visible = false;
            AllOptionsEnable();
        }

        private void Action0Click(object sender, EventArgs e)
        {
            _actionChosen = 0;
            _actionText.Text = _uiInterface.GetActionOptionText(0);
            _actionTitle.Text = _uiInterface.GetActionTitle(0);
            ActionTextShow();
        }

        private void Action1Click(object sender, EventArgs e)
        {
            _actionChosen = 1;
            _actionText.Text = _uiInterface.GetActionOptionText(1);
            _actionTitle.Text = _uiInterface.GetActionTitle(1);
            ActionTextShow();
        }

        private void Action2Click(object sender, EventArgs e)
        {
            _actionChosen = 2;
            _actionText.Text = _uiInterface.GetActionOptionText(2);
            _actionTitle.Text = _uiInterface.GetActionTitle(2);
            ActionTextShow();
        }

        private void Action3Click(object sender, EventArgs e)
        {
            _actionChosen = 3;
            _actionText.Text = _uiInterface.GetActionOptionText(3);
            _actionTitle.Text = _uiInterface.GetActionTitle(3);
            ActionTextShow();
        }
        private void ActionTextShow()
        {
            _actionPanel.Visible = true;
            AllOptionsDisable();
        }

        private void BtnLoadEventClick()
        {
            UpdateActionpoints();
            _uiInterface.NextEvent();
            _eventTitle.Text = _uiInterface.GetEventTitle();
            _eventTxtBox.Text = _uiInterface.GetEventText();
            if (_uiInterface.GetEventInfo() != "")
            {
                _showInfoBtn.Visible = true;
                _infoText.Text = _uiInterface.GetEventInfo();
            }
            _option1Btn.Visible = true;
            _option2Btn.Visible = true;
            _option1Btn.Text = _uiInterface.GetEventOptionTitle(0);
            _option2Btn.Text = _uiInterface.GetEventOptionTitle(1);
            if (_uiInterface.GetEventOptionTitle(2) != "")
            {
                _option3Btn.Visible = true;
                _option3Btn.Text = _uiInterface.GetEventOptionTitle(2);
                _option4Btn.Visible = false;
                if (_uiInterface.GetEventOptionTitle(3) != "")
                {
                    _option4Btn.Visible = true;
                    _option4Btn.Text = _uiInterface.GetEventOptionTitle(3);
                }
                else
                {
                    _option4Btn.Visible = false;
                }
            }
            else
            {
                _option3Btn.Visible = false;
                _option4Btn.Visible = false;
            }
        }
        private void AllOptionsDisable()
        {
            _option1Btn.Enabled = false;
            _option2Btn.Enabled = false;
            _option3Btn.Enabled = false;
            _option4Btn.Enabled = false;
            _showInfoBtn.Enabled = false;
            _action0Btn.Enabled = false;
            _action1Btn.Enabled = false;
            _action2Btn.Enabled = false;
            _action3Btn.Enabled = false;
            _saveBtn.Enabled = false;
            _backToMenuBtn.Enabled = false;
            _nextPhaseBtn.Enabled = false;
        }
        private void AllOptionsEnable()
        {
            _option1Btn.Enabled = true;
            _option2Btn.Enabled = true;
            _option3Btn.Enabled = true;
            _option4Btn.Enabled = true;
            _showInfoBtn.Enabled = true;
            _action0Btn.Enabled = true;
            _action1Btn.Enabled = true;
            _action2Btn.Enabled = true;
            _action3Btn.Enabled = true;
            _saveBtn.Enabled = true;
            _backToMenuBtn.Enabled = true;
            _nextPhaseBtn.Enabled = true;

        }
        private void AllOptionsHide()
        {
            _option1Btn.Visible = false;
            _option2Btn.Visible = false;
            _option3Btn.Visible = false;
            _option4Btn.Visible = false;
        }
        private void Option1Click(object sender, EventArgs e)
        {
            _eventTxtBox.Text = _uiInterface.GetEventOptionText(0);
            _showInfoBtn.Visible = false;
            _closeOptEndTxt.Visible = true;
            AllOptionsHide();
            WarningCheck();
        }
        private void Option2Click(object sender, EventArgs e)
        {
            _eventTxtBox.Text = _uiInterface.GetEventOptionText(1);
            _showInfoBtn.Visible = false;
            _closeOptEndTxt.Visible = true;
            AllOptionsHide();
            WarningCheck();

        }
        private void Option3Click(object sender, EventArgs e)
        {
            _eventTxtBox.Text = _uiInterface.GetEventOptionText(2);
            _showInfoBtn.Visible = false;
            _closeOptEndTxt.Visible = true;
            AllOptionsHide();
            WarningCheck();
        }

        private void Option4Click(object sender, EventArgs e)
        {
            _eventTxtBox.Text = _uiInterface.GetEventOptionText(3);
            _showInfoBtn.Visible = false;
            _closeOptEndTxt.Visible = true;
            AllOptionsHide();
            WarningCheck();
        }

        private void UpdateActionpoints()
        {
            if (_uiInterface.IsInSchool() == true)
            {
                _panelActiveChild.BackgroundImage = SpielDesLebens.Properties.Resources.uniTable;
            }
            else
            {
                _panelActiveChild.BackgroundImage = SpielDesLebens.Properties.Resources.coworking;
            }
            double actionPoints = _uiInterface.GetActionPoints();
            double curPhase = _uiInterface.GetCurrentPhase();
            double maxPhaseLength = _uiInterface.GetMaxPhaseNumber();
            double maxActionPoints = _uiInterface.GetMaxActionPoints();
            double progBarValue = 100 * ((maxActionPoints * curPhase + maxActionPoints - actionPoints) / (maxActionPoints * maxPhaseLength)); ;
            _lblPlayerAge.Text = Convert.ToString(_uiInterface.GetPlayerAge());
            _currentPhaseTxt.Text = "Derzeitige Phase: " + curPhase;
            _actionPointsTxt.Text = "Benutzte Aktionspunkte:" + (_uiInterface.GetMaxActionPoints() - actionPoints);
            _leftPhaseTxt.Text = "Verbleibene Aktionspunkte: " + actionPoints;
            _progressProgBar.Value = (int)progBarValue;
            _moneyProgBar.Text = _uiInterface.GetPlayerMoney().ToString() + "€";
            _learnProgBar.Value = _uiInterface.GetPlayerSuccess();
            _motivationProgBar.Value = _uiInterface.GetPlayerMotivation();
            _mentalProgBar.Value = _uiInterface.GetPlayerMentalHealth();
            if (actionPoints == 1)
            {
                _option1Btn.Enabled = false;
                _option2Btn.Enabled = false;
                _option3Btn.Enabled = false;
                _option4Btn.Enabled = false;
                _showInfoBtn.Enabled = false;
            }
            if (actionPoints == 14 && _option1Btn.Enabled == false)
            {
                _option1Btn.Enabled = true;
                _option2Btn.Enabled = true;
                _option3Btn.Enabled = true;
                _option4Btn.Enabled = true;
                _showInfoBtn.Enabled = true;
            }
            WarningCheck();
            GameOverCheck();
            GetNewActions();
        }
        private void GetNewActions()
        {
            _action0Btn.Text = "     " + _uiInterface.GetActionTitle(0);
            _action1Btn.Text = "     " + _uiInterface.GetActionTitle(1);
            _action2Btn.Text = "     " + _uiInterface.GetActionTitle(2);
            _action3Btn.Text = "     " + _uiInterface.GetActionTitle(3);

            _action0Btn.Image = GetActionIcon(_uiInterface.GetActionOptionMainStat(0));
            _action1Btn.Image = GetActionIcon(_uiInterface.GetActionOptionMainStat(1));
            _action2Btn.Image = GetActionIcon(_uiInterface.GetActionOptionMainStat(2));
            _action3Btn.Image = GetActionIcon(_uiInterface.GetActionOptionMainStat(3));

        }
        private Image GetActionIcon(int r)
        {
            switch (r)
            {
                case -1: return SpielDesLebens.Properties.Resources.criminal48Px;
                case 0: return SpielDesLebens.Properties.Resources.mentalHealth48Px;
                case 1: return SpielDesLebens.Properties.Resources.money48Px;
                case 2: return SpielDesLebens.Properties.Resources.motivation48Px;
                case 3: return SpielDesLebens.Properties.Resources.homeworkIconSmall;
                default: throw new Error("There has to be an icon for actions");
            }
        }
        private void CloseOptTxt(object sender, EventArgs e)
        {
            _closeOptEndTxt.Visible = false;
            BtnLoadEventClick();
        }
        private void GameOverCheck()
        {
            if (_uiInterface.GetGameEnd() != "")
            {
                _gameOverPanel.Visible = true;
                _nextPhaseBtn.Enabled = false;
                _saveBtn.Enabled = false;
                _backToMenuBtn.Enabled = false;
                _tutorialBtn2.Enabled = false;
                AllOptionsDisable();
                _gameOverTxt.Text = _uiInterface.GetGameEnd();
            }
        }

        private void GameOverBtnClick(object sender, EventArgs e)
        {
            ToMenu();
        }
        private void ToMenu()
        {
            _uiMenu.ResetForm();
            _uiMenu.LoadSaves();
            _uiMenu.Show();
            _uiMenu.BringToFront();
            Hide();
        }
        private void EndTutorial(object sender, EventArgs e)
        {
            _tutorialAskPanel.Visible = false;
            AllOptionsEnable();
        }

        private void StartTutorial(object sender, EventArgs e)
        {
            _tutorialAskPanel.Visible = false;
            _tutorialPanel1.Visible = true;
        }

        private void ContinueTutorial1(object sender, EventArgs e)
        {
            if (_tutorialTxt1.Text == "Links wird dein Charakter angezeigt. Wenn du auf das Bild deines Charakters klickst, hast du die Möglichkeit deinen Karriereweg zu wechseln.")
            {
                _tutorialTxt1.Text = "Auf der rechten Seite siehtst du deinen Fortschritt im Spiel.";
            }
            else
            {
                _tutorialPanel2.Visible = true;
                _tutorialPanel1.Visible = false;
            }
        }
        private void ContinueTutorial2(object sender, EventArgs e)
        {
            if (_tutorialBtn2.Text == "Weiter")
            {
                _tutorialPanel3.Visible = true;
            }
            _tutorialPanel2.Visible = false;
        }
        private void ContinueTutorial3(object sender, EventArgs e)
        {
            _tutorialPanel4.Visible = true;
            _tutorialPanel3.Visible = false;
        }
        private void ContinueTutorial4(object sender, EventArgs e)
        {
            _tutorialPanel5.Visible = true;
            _tutorialPanel4.Visible = false;
            if (_showInfoBtn.Visible == false)
            {
                _showInfoBtn.Visible = true;
                _showInfoBtn.Visible = false;
            }
        }
        private void ContinueTutorial5(object sender, EventArgs e)
        {
            if (_showInfoBtn.Visible == false)
            {
                _showInfoBtn.Visible = false;
            }
            _tutorialPanel6.Visible = true;
            _tutorialPanel5.Visible = false;
        }
        private void ContinueTutorial6(object sender, EventArgs e)
        {
            if (_tutorialTxt6.Text == "Rechts kannst du erkennen in welcher, Phase du dich befindest. Eine Phase ist ein Ausbildungsabschnitt.")
            {
                _tutorialTxt6.Text = "Eine Aktion erhöht die Anzahl der Aktionspunktebei einem. Ein Event erhöht die Anzahl der Aktionspnkte bei zwei.";
            }
            _tutorialPanel6.Visible = false;
            _tutorialPanel7.Visible = true;
        }

        private void ContinueTutorial7(object sender, EventArgs e)
        {
            if (_tutorialTxt6.Text == "Rechts kannst du erkennen in welcher, Phase du dich befindest. Eine Phase ist ein Ausbildungsabschnitt.")
            {
                _tutorialTxt6.Text = "Eine Aktion erhöht die Anzahl der Aktionspunktebei einem. Ein Event erhöht die Anzahl der Aktionspnkte bei zwei.";
            }
            else
            {
                _tutorialPanel7.Visible = false;
                AllOptionsEnable();
            }
        }

        private void ActionClose(object sender, EventArgs e)
        {
            _actionPanel.Visible = false;
            AllOptionsEnable();
            _uiInterface.AfterActionTextRecieved(_actionChosen);
            if ("Derzeitige Phase: " + _uiInterface.GetCurrentPhase() != _currentPhaseTxt.Text)
            {
                BtnLoadEventClick();
            }
            else
            {
                UpdateActionpoints();
            }
            if (_uiInterface.GetActionPoints() == 1)
            {
                _option1Btn.Enabled = false;
                _option2Btn.Enabled = false;
                _option3Btn.Enabled = false;
                _option4Btn.Enabled = false;
                _showInfoBtn.Enabled = false;
            }
        }

        private void HoverActionTxtShow0(object sender, EventArgs e)
        {
            _infoActionPanel0.Visible = true;
            _infoActionTxt0.Text = _uiInterface.GetActionInfo(0);
        }
        private void HoverActionTxtShow1(object sender, EventArgs e)
        {
            _infoActionPanel1.Visible = true;
            _infoActionTxt1.Text = _uiInterface.GetActionInfo(1);
        }
        private void HoverActionTxtShow2(object sender, EventArgs e)
        {
            _infoActionPanel2.Visible = true;
            _infoActionTxt2.Text = _uiInterface.GetActionInfo(2);
        }
        private void HoverActionTxtShow3(object sender, EventArgs e)
        {
            _infoActionPanel3.Visible = true;
            _infoActionTxt3.Text = _uiInterface.GetActionInfo(3);
        }

        private void CloseHoverAction(object sender, EventArgs e)
        {
            _infoActionPanel0.Visible = false;
            _infoActionPanel1.Visible = false;
            _infoActionPanel2.Visible = false;
            _infoActionPanel3.Visible = false;
        }

        private void NewProfessionNoBtnClick(object sender, EventArgs e)
        {
            if (_newProfessionNoBtn.Text == "Weiter" && _newProfessionPathComboBox.Text != "" && _newProfessionProfessionComboBox.Text != "")
            {
                _lblPlayerPath.Text = _newProfessionProfessionComboBox.Text;
                PathSet(_refrenceTraining);
                ProfessionSet(_refrenceProfession);
                _uiInterface.ResetPath(_training, _profession);
                _uiInterface.SetCurrentPhase(0);
                _newProfessionYesBtn.Text = "Ja";
                _newProfessionNoBtn.Text = "Nein";
                BtnLoadEventClick();
            }
            if (_newProfessionNoBtn.Text != "Weiter")
            {
                _newProfessionPanel.Visible = false;
                _newProfessionPathLable.Visible = false;
                _newProfessionPathComboBox.Visible = false;
                _newProfessionPathComboBox.Text = "";
                _newProfessionProfessionComboBox.Text = "";
                _newProfessionProfessionComboBox.Items.Clear();
                _newProfessionPathComboBox.Items.Clear();
                _newProfessionProfessionLable.Visible = false;
                _newProfessionProfessionComboBox.Visible = false;
                AllOptionsEnable();
                UpdateActionpoints();
            }
        }

        private void NewProfessionOptOpen(object sender, EventArgs e)
        {
            AllOptionsDisable();
            _nextPhaseBtn.Enabled = false;
            _newProfessionPanel.Visible = true;
            _newProfessionNoBtn.Text = "Nein";
            _newProfessionNoBtn.Enabled = true;
            _newProfessionYesBtn.Visible = true;
        }

        private void NewProfessionYesOpt(object sender, EventArgs e)
        {
            if (_newProfessionYesBtn.Text == "Abbrechen")
            {
                _newProfessionPathLable.Visible = false;
                _newProfessionPathComboBox.Visible = false;
                _newProfessionProfessionLable.Visible = false;
                _newProfessionProfessionComboBox.Visible = false;
                _newProfessionPanel.Visible = false;
                AllOptionsEnable();
                _newProfessionYesBtn.Text = "Ja";
            }
            else
            {
                _newProfessionProfessionComboBox.Visible = true;
                _newProfessionNoBtn.Text = "Weiter";
                _newProfessionYesBtn.Text = "Abbrechen";
                _newProfessionProfessionLable.Visible = true;
                _newProfessionPathLable.Visible = true;
                _newProfessionPathComboBox.Visible = true;
                _newProfessionNoBtn.Enabled = false;
            }
            Data.Graduation currentGraduation = _uiInterface.GetGraduation();
            if (currentGraduation.Equals(Data.Graduation.Hauptschulabschluss))
            {
                _newProfessionPathComboBox.Items.AddRange(new object[] { "Ausbildung" });
            }
            else if (currentGraduation.Equals(Data.Graduation.Realschulabschluss))
            {
                _newProfessionPathComboBox.Items.AddRange(new object[] { "Ausbildung", "Duales Studium" });
            }
            else
            {
                _newProfessionPathComboBox.Items.AddRange(new object[] { "Ausbildung", "Duales Studium", "Studium" });
            }
            _newProfessionProfessionComboBox.Enabled = false;
        }

        private void NewProfessionTxtChange(object sender, EventArgs e)
        {
            _newProfessionNoBtn.Enabled = true;
            if (_newProfessionProfessionComboBox.Text == "Krankenpflege" || _newProfessionProfessionComboBox.Text == "Angewandte Gesundheits- und Pflegewissenschaften" || _newProfessionProfessionComboBox.Text == "Medizinstudium")
            {
                _refrenceProfession = "Social";
            }
            if (_newProfessionProfessionComboBox.Text == "BWL" || _newProfessionProfessionComboBox.Text == "Industriekaufmann")
            {
                _refrenceProfession = "Buisness";
            }
            if (_newProfessionProfessionComboBox.Text == "Pharmazeutisch Technische Assistenz" || _newProfessionProfessionComboBox.Text == "Angewandte Physik" || _newProfessionProfessionComboBox.Text == "Physikstudium")
            {
                _refrenceProfession = "Science";
            }
            if (_newProfessionProfessionComboBox.Text == "Fachinformatiker" || _newProfessionProfessionComboBox.Text == "Angewandtes Informatikstudium" || _newProfessionProfessionComboBox.Text == "Informatikstudium")
            {
                _refrenceProfession = "Stem";
            }
            if (_newProfessionProfessionComboBox.Text == "Jurastudium" || _newProfessionProfessionComboBox.Text == "Steuerwesen" || _newProfessionProfessionComboBox.Text == "Rechtanwaltsfachangestellter")
            {
                _refrenceProfession = "Civil";
            }
        }

        private void NewProfessionPathComboBoxTextChanged(object sender, EventArgs e)
        {
            _newProfessionProfessionComboBox.Items.Clear();
            _newProfessionProfessionComboBox.Text = null;
            if (_newProfessionPathComboBox.Text == "Ausbildung")
            {
                _refrenceTraining = "Training";
                _newProfessionProfessionComboBox.Items.AddRange(new object[] { "Krankenpflege", "Industriekaufmann", "Pharmazeutisch Technische Assistenz", "Fachinformatiker", "Rechtanwaltsfachangestellter" });
            }
            else if (_newProfessionPathComboBox.Text == "Duales Studium")
            {
                _refrenceTraining = "Duales Studium";
                _newProfessionProfessionComboBox.Items.AddRange(new object[] { "Angewandte Gesundheits- und Pflegewissenschaften", "BWL", "Angewandte Physik", "Angewandtes Informatikstudium", "Steuerwesen" });
            }
            else if (_newProfessionPathComboBox.Text == "Studium")
            {
                _refrenceTraining = "Studium";
                _newProfessionProfessionComboBox.Items.AddRange(new object[] { "Medizinstudium", "BWL", "Physikstudium", "Informatikstudium", "Jurastudium" });
            }
            _newProfessionProfessionComboBox.Enabled = true;
        }
        private void ProfessionSet(string givenProfession)
        {
            if (givenProfession == "Social")
            {
                _profession = Data.Profession.Social;
            }
            else if (givenProfession == "Buisness")
            {
                _profession = Data.Profession.Business;
            }
            else if (givenProfession == "Stem")
            {
                _profession = Data.Profession.Stem;
            }
            else if (givenProfession == "Science")
            {
                _profession = Data.Profession.Science;
            }
            else if (givenProfession == "Civil")
            {
                _profession = Data.Profession.Civil;
            }
        }
        private void PathSet(string givenPath)
        {
            if (givenPath == "Training")
            {
                _training = Data.Path.Training;
            }
            else if (givenPath == "DualStudy")
            {
                _training = Data.Path.DualStudy;
            }
            else if (givenPath == "Study")
            {
                _training = Data.Path.Study;
            }
        }

        private void NextPhase(object sender, EventArgs e)
        {
            _uiInterface.NextPhase();
            BtnLoadEventClick();
            AllOptionsEnable();
        }

        private void SaveBtnClick(object sender, EventArgs e)
        {
            _uiInterface.SaveGame();
            if (_uiInterface.HasValidData())
            {
                _infoPanel.Visible = true;
                _infoCloseButton.Visible = true;
                _infoText.Visible = true;
                _infoText.Text = "Dein Spielstand wurde erfolgreich gespeichert.";
                AllOptionsDisable();
            }
        }

        private void BackToMenuBtnClick(object sender, EventArgs e)
        {
            ToMenu();
        }

        private void UiGameFormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void WarningCheck()
        {
            string warningCheck = _uiInterface.GetStatWarning();
            if (warningCheck != "")
            {
                _tutorialPanel2.Visible = true;
                _tutorialTxt2.Text = warningCheck;
                _tutorialBtn2.Text = "Schließen";
            }
            else
            {
                _tutorialPanel2.Visible = false;
            }
        }
    }
}