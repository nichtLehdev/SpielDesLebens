using System;
using System.Drawing;
using System.Windows.Forms;

namespace SpielDesLebens
{
    internal partial class UiGame : Form
    {
        private Form activeForm;
        private readonly UiInterface uiInterface;
        private readonly bool newGame = false;

        private Data.Path training;
        private Data.Profession profession;

        private readonly string abschluss;
        private string refrenceTraining;
        private string refrenceProfession;

        private readonly int slot;


        public UiGame(UiInterface uiInterface)
        {
            InitializeComponent();
            this.uiInterface = uiInterface;
        }

        private void FormGameUiLoad(object sender, EventArgs e)
        {
            lblPlayerAge.Text = Convert.ToString(uiInterface.GetPlayerAge());
            lblPlayerName.Text = uiInterface.GetPlayerName();
            lblPlayerPath.Text = uiInterface.GetPlayerProfessionName();
            avatarPic.Image = SetAvatar();
            BtnLoadEventClick();
            UpdateActionpoints();
            if (newGame == true)
            {
                AllOptionsDisable();
                tutorialAskPanel.Visible = true;
            }
            GetNewActions();
        }
        private Image SetAvatar()
        {
            switch (uiInterface.GetAvatar())
            {
                case 0: return SpielDesLebens.Properties.Resources.avatarBoy0;
                case 1: return SpielDesLebens.Properties.Resources.avatarBoy1;
                case 2: return SpielDesLebens.Properties.Resources.avatarBoy2;
                case 3: return SpielDesLebens.Properties.Resources.avatarGirl0;
                case 4: return SpielDesLebens.Properties.Resources.avatarGirl1;
                case 5: return SpielDesLebens.Properties.Resources.avatarGirl2;
                default: throw new Error("There has to be an avatar");
            }
        }
        public void OpenChildForm(Form childForm, object btnSender)
        {
            if (btnSender is null)
            {
                throw new ArgumentNullException(nameof(btnSender));
            }

            activeForm?.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelActiveChild.Controls.Add(childForm);
            this.panelActiveChild.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void ShowInfo(object sender, EventArgs e)
        {
            infoPanel.Visible = true;
            infoCloseButton.Visible = true;
            infoText.Visible = true;
            AllOptionsDisable();
        }

        private void InfoClose(object sender, EventArgs e)
        {
            infoPanel.Visible = false;
            infoCloseButton.Visible = false;
            infoText.Visible = false;
            AllOptionsEnable();
        }

        private void Action0Click(object sender, EventArgs e)
        {
            actionText.Text = uiInterface.GetActionOptionText(0);
            actionTitle.Text = uiInterface.GetActionTitle(0);
            ActionTextShow();
        }

        private void Action1Click(object sender, EventArgs e)
        {
            actionText.Text = uiInterface.GetActionOptionText(1);
            actionTitle.Text = uiInterface.GetActionTitle(1);
            ActionTextShow();
        }

        private void Action2Click(object sender, EventArgs e)
        {
            actionText.Text = uiInterface.GetActionOptionText(2);
            actionTitle.Text = uiInterface.GetActionTitle(2);
            ActionTextShow();
        }

        private void Action3Click(object sender, EventArgs e)
        {
            actionText.Text = uiInterface.GetActionOptionText(3);
            actionTitle.Text = uiInterface.GetActionTitle(3);
            ActionTextShow();
        }
        private void ActionTextShow()
        {
            actionPanel.Visible = true;
            AllOptionsDisable();
            if ("Derzeitige Phase: " + uiInterface.GetCurrentPhase() != currentPhaseTxt.Text)
            {
                BtnLoadEventClick();
            }
            else
            {
                UpdateActionpoints();
            }
        }

        private void BtnLoadEventClick()
        {
            UpdateActionpoints();
            uiInterface.NextEvent();
            eventTitle.Text = uiInterface.GetEventTitle();
            eventTxtBox.Text = uiInterface.GetEventText();
            if (uiInterface.GetEventInfo() != "")
            {
                showInfoBtn.Visible = true;
                infoText.Text = uiInterface.GetEventInfo();
            }
            option1Btn.Visible = true;
            option2Btn.Visible = true;
            option1Btn.Text = uiInterface.GetEventOptionTitle(0);
            option2Btn.Text = uiInterface.GetEventOptionTitle(1);
            if (uiInterface.GetEventOptionTitle(2) != "")
            {
                option3Btn.Visible = true;
                option3Btn.Text = uiInterface.GetEventOptionTitle(2);
                option4Btn.Visible = false;
                if (uiInterface.GetEventOptionTitle(3) != "")
                {
                    option4Btn.Visible = true;
                    option4Btn.Text = uiInterface.GetEventOptionTitle(3);
                }
                else
                {
                    option4Btn.Visible = false;
                }
            }
            else
            {
                option3Btn.Visible = false;
                option4Btn.Visible = false;
            }
        }
        private void AllOptionsDisable()
        {
            option1Btn.Enabled = false;
            option2Btn.Enabled = false;
            option3Btn.Enabled = false;
            option4Btn.Enabled = false;
            showInfoBtn.Enabled = false;
            action0Btn.Enabled = false;
            action1Btn.Enabled = false;
            action2Btn.Enabled = false;
            action3Btn.Enabled = false;
        }
        private void AllOptionsEnable()
        {
            option1Btn.Enabled = true;
            option2Btn.Enabled = true;
            option3Btn.Enabled = true;
            option4Btn.Enabled = true;
            showInfoBtn.Enabled = true;
            action0Btn.Enabled = true;
            action1Btn.Enabled = true;
            action2Btn.Enabled = true;
            action3Btn.Enabled = true;

        }
        private void AllOptionsHide()
        {
            option1Btn.Visible = false;
            option2Btn.Visible = false;
            option3Btn.Visible = false;
            option4Btn.Visible = false;
        }
        private void Option1Click(object sender, EventArgs e)
        {
            eventTxtBox.Text = uiInterface.GetEventOptionText(0);
            showInfoBtn.Visible = false;
            closeOptEndTxt.Visible = true;
            AllOptionsHide();
        }
        private void Option2Click(object sender, EventArgs e)
        {
            eventTxtBox.Text = uiInterface.GetEventOptionText(1);
            showInfoBtn.Visible = false;
            closeOptEndTxt.Visible = true;
            AllOptionsHide();
        }
        private void Option3Click(object sender, EventArgs e)
        {
            eventTxtBox.Text = uiInterface.GetEventOptionText(2);
            showInfoBtn.Visible = false;
            closeOptEndTxt.Visible = true;
            AllOptionsHide();
        }

        private void Option4Click(object sender, EventArgs e)
        {
            eventTxtBox.Text = uiInterface.GetEventOptionText(3);
            showInfoBtn.Visible = false;
            closeOptEndTxt.Visible = true;
            AllOptionsHide();
        }

        private void UpdateActionpoints()
        {
            if (uiInterface.IsInSchool() == true)
            {
                panelActiveChild.BackgroundImage = SpielDesLebens.Properties.Resources.uniTable;
            }
            else
            {
                panelActiveChild.BackgroundImage = SpielDesLebens.Properties.Resources.coworking;
            }
            int actionPoints = uiInterface.GetActionPoints();
            int curPhase = uiInterface.GetCurrentPhase();
            _ = uiInterface.GetMaxPhaseLength();
            lblPlayerAge.Text = Convert.ToString(uiInterface.GetPlayerAge());
            currentPhaseTxt.Text = "Derzeitige Phase: " + curPhase;
            actionPointsTxt.Text = "Benutzte Aktionspunkte:" + (uiInterface.GetMaxActionPoints() - actionPoints);
            leftPhaseTxt.Text = "Verbleibene Länge der Phase: " + actionPoints;
            progressProgBar.Value = ((100 * uiInterface.GetMaxActionPoints() * curPhase + 100 * actionPoints) / (uiInterface.GetMaxPhaseNumber() * uiInterface.GetMaxActionPoints()));
            moneyProgBar.Text = uiInterface.GetPlayerMoney().ToString() + "€";
            learnProgBar.Value = uiInterface.GetPlayerSuccess();
            motivationProgBar.Value = uiInterface.GetPlayerMotivation();
            mentalProgBar.Value = uiInterface.GetPlayerMentalHealth();
            if (actionPoints == 1)
            {
                option1Btn.Enabled = false;
                option2Btn.Enabled = false;
                option3Btn.Enabled = false;
                option4Btn.Enabled = false;
                showInfoBtn.Enabled = false;
            }
            if (actionPoints == 14 && option1Btn.Enabled == false)
            {
                option1Btn.Enabled = true;
                option2Btn.Enabled = true;
                option3Btn.Enabled = true;
                option4Btn.Enabled = true;
                showInfoBtn.Enabled = true;
            }
            string warningCheck = uiInterface.GetStatWarning();
            if (warningCheck != "")
            {
                tutorialPanel2.Visible = true;
                tutorialTxt2.Text = warningCheck;
                tutorialBtn2.Text = "Schließen";
            }
            GameOverCheck();
        }
        private void GetNewActions()
        {
            action0Btn.Text = uiInterface.GetActionTitle(0);
            action1Btn.Text = uiInterface.GetActionTitle(1);
            action2Btn.Text = uiInterface.GetActionTitle(2);
            action3Btn.Text = uiInterface.GetActionTitle(3);

            action0Btn.Image = GetActionIcon(uiInterface.GetActionOptionMainStat(0));
            action1Btn.Image = GetActionIcon(uiInterface.GetActionOptionMainStat(1));
            action2Btn.Image = GetActionIcon(uiInterface.GetActionOptionMainStat(2));
            action3Btn.Image = GetActionIcon(uiInterface.GetActionOptionMainStat(3));

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
            closeOptEndTxt.Visible = false;
            BtnLoadEventClick();
        }
        private void GameOverCheck()
        {
            if (uiInterface.GetGameEnd() != "")
            {
                gameOverPanel.Visible = true;
                AllOptionsDisable();
                gameOverTxt.Text = uiInterface.GetGameEnd();
            }
        }

        private void GameOverBtnClick(object sender, EventArgs e)
        {
            ToMenu();
        }
        private void ToMenu()
        {
            UiMenu t = new UiMenu();
            t.Show();
            Hide();
        }
        private void EndTutorial(object sender, EventArgs e)
        {
            tutorialAskPanel.Visible = false;
            AllOptionsEnable();
        }

        private void StartTutorial(object sender, EventArgs e)
        {
            tutorialAskPanel.Visible = false;
            tutorialPanel1.Visible = true;
        }

        private void ContinueTutorial1(object sender, EventArgs e)
        {
            if (tutorialTxt1.Text == "Links wird dein Charakter angezeigt")
            {
                tutorialTxt1.Text = "Auf der Rechten Seite siehtstd deien Fortschritt im Spiel.";
            }
            else
            {
                tutorialPanel2.Visible = true;
                tutorialPanel1.Visible = false;
            }
        }
        private void ContinueTutorial2(object sender, EventArgs e)
        {
            if (tutorialBtn2.Text == "Weiter")
            {
                tutorialPanel3.Visible = true;
            }
            tutorialPanel2.Visible = false;
        }
        private void ContinueTutorial3(object sender, EventArgs e)
        {
            tutorialPanel4.Visible = true;
            tutorialPanel3.Visible = false;
        }
        private void ContinueTutorial4(object sender, EventArgs e)
        {
            tutorialPanel5.Visible = true;
            tutorialPanel4.Visible = false;
            if (showInfoBtn.Visible == false)
            {
                showInfoBtn.Visible = true;
                showInfoBtn.Visible = false;
            }
        }
        private void ContinueTutorial5(object sender, EventArgs e)
        {
            if (showInfoBtn.Visible == false)
            {
                showInfoBtn.Visible = false;
            }
            tutorialPanel6.Visible = true;
            tutorialPanel5.Visible = false;
        }
        private void ContinueTutorial6(object sender, EventArgs e)
        {
            if (tutorialTxt6.Text == "Rechts kannst du erkennen in welcher Phase du dich befindest. Eine Phase gibt eine Semesterlänge an.")
            {
                tutorialTxt6.Text = "Eine Aktion erhöht die Anzahl der Aktionspunktebei einem. Ein Event erhöht die Anzahl der Aktionspnkte bei zwei.";
            }
            else
            {
                tutorialPanel6.Visible = false;
                AllOptionsEnable();
            }
        }

        private void ActionClose(object sender, EventArgs e)
        {
            actionPanel.Visible = false;
            AllOptionsEnable();
            if (uiInterface.GetActionPoints() == 1)
            {
                option1Btn.Enabled = false;
                option2Btn.Enabled = false;
                option3Btn.Enabled = false;
                option4Btn.Enabled = false;
                showInfoBtn.Enabled = false;
            }
        }

        private void HoverActionTxtShow0(object sender, EventArgs e)
        {
            infoActionPanel0.Visible = true;
            infoActionTxt0.Text = uiInterface.GetActionInfo(0);
        }
        private void HoverActionTxtShow1(object sender, EventArgs e)
        {
            infoActionPanel1.Visible = true;
            infoActionTxt1.Text = uiInterface.GetActionInfo(1);
        }
        private void HoverActionTxtShow2(object sender, EventArgs e)
        {
            infoActionPanel2.Visible = true;
            infoActionTxt2.Text = uiInterface.GetActionInfo(2);
        }
        private void HoverActionTxtShow3(object sender, EventArgs e)
        {
            infoActionPanel3.Visible = true;
            infoActionTxt3.Text = uiInterface.GetActionInfo(3);
        }

        private void CloseHoverAction(object sender, EventArgs e)
        {
            infoActionPanel0.Visible = false;
            infoActionPanel1.Visible = false;
            infoActionPanel2.Visible = false;
            infoActionPanel3.Visible = false;
        }

        private void NewProfessionNoBtnClick(object sender, EventArgs e)
        {
            if (newProfessionNoBtn.Text == "Weiter")
            {
                lblPlayerPath.Text = newProfessionProfessionComboBox.Text;
                PathSet(refrenceTraining);
                ProfessionSet(refrenceProfession);
                uiInterface.ResetPath(training, profession);
            }
            newProfessionPanel.Visible = false;
            AllOptionsEnable();
        }

        private void NewProfessionOptOpen(object sender, EventArgs e)
        {
            AllOptionsDisable();
            newProfessionPanel.Visible = true;
            newProfessionNoBtn.Text = "Nein";
            newProfessionYesBtn.Visible = true;
        }

        private void NewProfessionYesOpt(object sender, EventArgs e)
        {
            newProfessionProfessionComboBox.Visible = true;
            newProfessionYesBtn.Visible = false;
            newProfessionNoBtn.Text = "Weiter";
            newProfessionYesBtn.Visible = false;
            newProfessionProfessionLable.Visible = true;
            newProfessionPathLable.Visible = true;
            newProfessionPathComboBox.Visible = true;
            newProfessionNoBtn.Enabled = false;
            if (abschluss == "Hauptschulabschluss")
            {
                newProfessionPathComboBox.Items.AddRange(new object[] { "Ausbildung" });
            }
            else if (abschluss == "Realschulabschluss")
            {
                newProfessionPathComboBox.Items.AddRange(new object[] { "Ausbildung", "Duales Studium" });
            }
            else
            {
                newProfessionPathComboBox.Items.AddRange(new object[] { "Ausbildung", "Duales Studium", "Studium" });
            }
            newProfessionProfessionComboBox.Enabled = false;
        }

        private void NewProfessionTxtChange(object sender, EventArgs e)
        {
            newProfessionNoBtn.Enabled = true;
            if (newProfessionProfessionComboBox.Text == "Krankenpflege" || newProfessionProfessionComboBox.Text == "Angewandte Gesundheits- und Pflegewissenschaften" || newProfessionProfessionComboBox.Text == "Medizinstudium")
            {
                refrenceProfession = "Social";
            }
            if (newProfessionProfessionComboBox.Text == "BWL" || newProfessionProfessionComboBox.Text == "Industriekaufmann")
            {
                refrenceProfession = "Buisness";
            }
            if (newProfessionProfessionComboBox.Text == "Pharmazeutisch Technische Assistenz" || newProfessionProfessionComboBox.Text == "Angewandte Physik" || newProfessionProfessionComboBox.Text == "Physikstudium")
            {
                refrenceProfession = "Science";
            }
            if (newProfessionProfessionComboBox.Text == "Fachinformatiker" || newProfessionProfessionComboBox.Text == "Angewandtes Informatikstudium" || newProfessionProfessionComboBox.Text == "Informatikstudium")
            {
                refrenceProfession = "Stem";
            }
            if (newProfessionProfessionComboBox.Text == "Jurastudium" || newProfessionProfessionComboBox.Text == "Steuerwesen" || newProfessionProfessionComboBox.Text == "Rechtanwaltsfachangestellter")
            {
                refrenceProfession = "Civil";
            }
        }

        private void NewProfessionPathComboBoxTextChanged(object sender, EventArgs e)
        {
            newProfessionProfessionComboBox.Items.Clear();
            newProfessionProfessionComboBox.Text = null;
            if (newProfessionPathComboBox.Text == "Ausbildung")
            {
                refrenceTraining = "Training";
                newProfessionProfessionComboBox.Items.AddRange(new object[] { "Krankenpflege", "Industriekaufmann", "Pharmazeutisch Technische Assistenz", "Fachinformatiker", "Rechtanwaltsfachangestellter" });
            }
            else if (newProfessionPathComboBox.Text == "Duales Studium")
            {
                refrenceTraining = "Duales Studium";
                newProfessionProfessionComboBox.Items.AddRange(new object[] { "Angewandte Gesundheits- und Pflegewissenschaften", "BWL", "Angewandte Physik", "Angewandtes Informatikstudium", "Steuerwesen" });
            }
            else if (newProfessionPathComboBox.Text == "Studium")
            {
                refrenceTraining = "Studium";
                newProfessionProfessionComboBox.Items.AddRange(new object[] { "Medizinstudium", "BWL", "Physikstudium", "Informatikstudium", "Jurastudium" });
            }
            newProfessionProfessionComboBox.Enabled = true;
        }
        private void ProfessionSet(string givenProfession)
        {
            if (givenProfession == "Social")
            {
                profession = Data.Profession.Social;
            }
            else if (givenProfession == "Buisness")
            {
                profession = Data.Profession.Business;
            }
            else if (givenProfession == "Stem")
            {
                profession = Data.Profession.Stem;
            }
            else if (givenProfession == "Science")
            {
                profession = Data.Profession.Science;
            }
            else if (givenProfession == "Civil")
            {
                profession = Data.Profession.Civil;
            }
        }
        private void PathSet(string givenPath)
        {
            if (givenPath == "Training")
            {
                training = Data.Path.Training;
            }
            else if (givenPath == "DualStudy")
            {
                training = Data.Path.DualStudy;
            }
            else if (givenPath == "Study")
            {
                training = Data.Path.Study;
            }
        }

        private void NextPhase(object sender, EventArgs e)
        {
            uiInterface.NextPhase();
            BtnLoadEventClick();
            GetNewActions();
        }

        private void SaveBtnClick(object sender, EventArgs e)
        {
            uiInterface.SaveGame(slot);
        }

        private void BackToMenuBtnClick(object sender, EventArgs e)
        {
            ToMenu();
        }
    }
}