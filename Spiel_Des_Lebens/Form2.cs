using System;
using System.Drawing;
using System.Windows.Forms;

namespace Spiel_Des_Lebens
{
    internal partial class Form2 : Form
    {
        private Form activeForm;
        private readonly UiInterface uiInterface;
        private readonly Boolean new_game = false;

        private Data.Path training;
        private Data.Profession profession;

        private readonly string abschluss;
        private string refrence_training;
        private string refrence_profession;
        private readonly int slot;

        public Form2(UiInterface uiInterface)
        {
            InitializeComponent();
            this.uiInterface = uiInterface;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lblPlayerAge.Text = Convert.ToString(uiInterface.GetPlayerAge());
            lblPlayerName.Text = uiInterface.GetPlayerName();
            lblPlayerPath.Text = uiInterface.RetPlayerCareer();
            avatar_pic.Image = SetAvatar();
            BtnLoadEventClick();
            UpdateActionpoints();
            if (new_game == true)
            {
                AllOptionsDisable();
                tutorial_ask_panel.Visible = true;
            }
            GetNewActions();
        }
        private Image SetAvatar()
        {
            switch (uiInterface.GetAvatar())
            {
                case 0: return Spiel_Des_Lebens.Properties.Resources.avatare_boy_0;
                case 1: return Spiel_Des_Lebens.Properties.Resources.avatare_boy_1;
                case 2: return Spiel_Des_Lebens.Properties.Resources.avatare_boy_2;
                case 3: return Spiel_Des_Lebens.Properties.Resources.avatare_girl_0;
                case 4: return Spiel_Des_Lebens.Properties.Resources.avatare_girl_1;
                case 5: return Spiel_Des_Lebens.Properties.Resources.avatare_girl_2;
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
            info_panel.Visible = true;
            info_close_button.Visible = true;
            info_text.Visible = true;
            AllOptionsDisable();
        }

        private void InfoClose(object sender, EventArgs e)
        {
            info_panel.Visible = false;
            info_close_button.Visible = false;
            info_text.Visible = false;
            AllOptionsEnable();
        }

        private void Action0Click(object sender, EventArgs e)
        {
            action_text.Text = uiInterface.GetActionOptionText(0);
            action_title.Text = uiInterface.GetActionTitle(0);
            ActionTextShow();
        }

        private void Action1Click(object sender, EventArgs e)
        {
            action_text.Text = uiInterface.GetActionOptionText(1);
            action_title.Text = uiInterface.GetActionTitle(1);
            ActionTextShow();
        }

        private void Action2Click(object sender, EventArgs e)
        {
            action_text.Text = uiInterface.GetActionOptionText(2);
            action_title.Text = uiInterface.GetActionTitle(2);
            ActionTextShow();
        }

        private void Action3Click(object sender, EventArgs e)
        {
            action_text.Text = uiInterface.GetActionOptionText(3);
            action_title.Text = uiInterface.GetActionTitle(3);
            ActionTextShow();
        }
        private void ActionTextShow()
        {
            action_panel.Visible = true;
            AllOptionsDisable();
            if ("Derzeitige Phase: " + uiInterface.GetCurrentPhase() != current_phase_txt.Text)
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
            event_title.Text = uiInterface.GetEventTitle();
            event_txt_box.Text = uiInterface.GetEventText();
            if (uiInterface.GetEventInfo() != "")
            {
                show_info_btn.Visible = true;
                info_text.Text = uiInterface.GetEventInfo();
            }
            option_1_btn.Visible = true;
            option_2_btn.Visible = true;
            option_1_btn.Text = uiInterface.GetEventOptionTitle(0);
            option_2_btn.Text = uiInterface.GetEventOptionTitle(1);
            if (uiInterface.GetEventOptionTitle(2) != "")
            {
                option_3_btn.Visible = true;
                option_3_btn.Text = uiInterface.GetEventOptionTitle(2);
                option_4_btn.Visible = false;
                if (uiInterface.GetEventOptionTitle(3) != "")
                {
                    option_4_btn.Visible = true;
                    option_4_btn.Text = uiInterface.GetEventOptionTitle(3);
                }
                else
                {
                    option_4_btn.Visible = false;
                }
            }
            else
            {
                option_3_btn.Visible = false;
                option_4_btn.Visible = false;
            }
        }
        private void AllOptionsDisable()
        {
            option_1_btn.Enabled = false;
            option_2_btn.Enabled = false;
            option_3_btn.Enabled = false;
            option_4_btn.Enabled = false;
            show_info_btn.Enabled = false;
            action_0_btn.Enabled = false;
            action_1_btn.Enabled = false;
            action_2_btn.Enabled = false;
            action_3_btn.Enabled = false;
        }
        private void AllOptionsEnable()
        {
            option_1_btn.Enabled = true;
            option_2_btn.Enabled = true;
            option_3_btn.Enabled = true;
            option_4_btn.Enabled = true;
            show_info_btn.Enabled = true;
            action_0_btn.Enabled = true;
            action_1_btn.Enabled = true;
            action_2_btn.Enabled = true;
            action_3_btn.Enabled = true;

        }
        private void AllOptionsHide()
        {
            option_1_btn.Visible = false;
            option_2_btn.Visible = false;
            option_3_btn.Visible = false;
            option_4_btn.Visible = false;
        }
        private void Option1Click(object sender, EventArgs e)
        {
            event_txt_box.Text = uiInterface.GetEventOptionText(0);
            show_info_btn.Visible = false;
            close_opt_end_txt.Visible = true;
            AllOptionsHide();
        }
        private void Option2Click(object sender, EventArgs e)
        {
            event_txt_box.Text = uiInterface.GetEventOptionText(1);
            show_info_btn.Visible = false;
            close_opt_end_txt.Visible = true;
            AllOptionsHide();
        }
        private void Option3Click(object sender, EventArgs e)
        {
            event_txt_box.Text = uiInterface.GetEventOptionText(2);
            show_info_btn.Visible = false;
            close_opt_end_txt.Visible = true;
            AllOptionsHide();
        }

        private void Option4Click(object sender, EventArgs e)
        {
            event_txt_box.Text = uiInterface.GetEventOptionText(3);
            show_info_btn.Visible = false;
            close_opt_end_txt.Visible = true;
            AllOptionsHide();
        }

        private void UpdateActionpoints()
        {
            if (uiInterface.IsInSchool() == true)
            {
                panelActiveChild.BackgroundImage = Spiel_Des_Lebens.Properties.Resources.uni_table;
            }
            else
            {
                panelActiveChild.BackgroundImage = Spiel_Des_Lebens.Properties.Resources.coworking;
            }
            int action_points = uiInterface.GetActionPoints();
            int cur_phase = uiInterface.GetCurrentPhase();
            _ = uiInterface.GetMaxPhaseLength();
            lblPlayerAge.Text = Convert.ToString(uiInterface.GetPlayerAge());
            current_phase_txt.Text = "Derzeitige Phase: " + cur_phase;
            action_points_txt.Text = "Benutzte Aktionspunkte:" + (uiInterface.GetMaxActionPoints() - action_points);
            left_phase_txt.Text = "Verbleibene Länge der Phase: " + action_points;
            progress_prog_bar.Value = ((100 * uiInterface.GetMaxActionPoints() * cur_phase + 100 * action_points) / (uiInterface.GetMaxPhaseNumber() * uiInterface.GetMaxActionPoints()));
            money_prog_bar.Text = uiInterface.GetPlayerMoney().ToString() + "€";
            learn_prog_bar.Value = uiInterface.GetPlayerSuccess();
            motivation_prog_bar.Value = uiInterface.GetPlayerMotivation();
            mental_prog_bar.Value = uiInterface.GetPlayerMentalHealth();
            if (action_points == 1)
            {
                option_1_btn.Enabled = false;
                option_2_btn.Enabled = false;
                option_3_btn.Enabled = false;
                option_4_btn.Enabled = false;
                show_info_btn.Enabled = false;
            }
            if (action_points == 14 && option_1_btn.Enabled == false)
            {
                option_1_btn.Enabled = true;
                option_2_btn.Enabled = true;
                option_3_btn.Enabled = true;
                option_4_btn.Enabled = true;
                show_info_btn.Enabled = true;
            }
            string warning_check = uiInterface.GetStatWarning();
            if (warning_check != "")
            {
                tutorial_panel_2.Visible = true;
                tutorial_txt_2.Text = warning_check;
                tutorial_btn_2.Text = "Schließen";
            }
            GameOverCheck();
        }
        private void GetNewActions()
        {
            action_0_btn.Text = uiInterface.GetActionTitle(0);
            action_1_btn.Text = uiInterface.GetActionTitle(1);
            action_2_btn.Text = uiInterface.GetActionTitle(2);
            action_3_btn.Text = uiInterface.GetActionTitle(3);

            action_0_btn.Image = GetActionIcon(uiInterface.GetActionOptionMainStat(0));
            action_1_btn.Image = GetActionIcon(uiInterface.GetActionOptionMainStat(1));
            action_2_btn.Image = GetActionIcon(uiInterface.GetActionOptionMainStat(2));
            action_3_btn.Image = GetActionIcon(uiInterface.GetActionOptionMainStat(3));

        }
        private Image GetActionIcon(int r)
        {
            switch (r)
            {
                case -1: return Spiel_Des_Lebens.Properties.Resources.criminal_48px;
                case 0: return Spiel_Des_Lebens.Properties.Resources.mentalhealth_48px;
                case 1: return Spiel_Des_Lebens.Properties.Resources.money_48px;
                case 2: return Spiel_Des_Lebens.Properties.Resources.motivation_48px;
                case 3: return Spiel_Des_Lebens.Properties.Resources.Homework_Icon_small3;
                default: throw new Error("There has to be an icon for actions");
            }
        }
        private void CloseOptTxt(object sender, EventArgs e)
        {
            close_opt_end_txt.Visible = false;
            BtnLoadEventClick();
        }
        private void GameOverCheck()
        {
            if (uiInterface.GetGameEnd() != "")
            {
                game_over_panel.Visible = true;
                AllOptionsDisable();
                game_over_txt.Text = uiInterface.GetGameEnd();
            }
        }

        private void GameOverBtnClick(object sender, EventArgs e)
        {
            ToMenu();
        }
        private void ToMenu()
        {
            Form1 t = new Form1();
            t.Show();
            Hide();
        }
        private void EndTutorial(object sender, EventArgs e)
        {
            tutorial_ask_panel.Visible = false;
            AllOptionsEnable();
        }

        private void StartTutorial(object sender, EventArgs e)
        {
            tutorial_ask_panel.Visible = false;
            tutorial_panel_1.Visible = true;
        }

        private void ContinueTutorial1(object sender, EventArgs e)
        {
            if (tutorial_txt_1.Text == "Links wird dein Charakter angezeigt")
            {
                tutorial_txt_1.Text = "Auf der Rechten Seite siehtstd deien Fortschritt im Spiel.";
            }
            else
            {
                tutorial_panel_2.Visible = true;
                tutorial_panel_1.Visible = false;
            }
        }
        private void ContinueTutorial2(object sender, EventArgs e)
        {
            if (tutorial_btn_2.Text == "Weiter")
            {
                tutorial_panel_3.Visible = true;
            }
            tutorial_panel_2.Visible = false;
        }
        private void ContinueTutorial3(object sender, EventArgs e)
        {
            tutorial_panel_4.Visible = true;
            tutorial_panel_3.Visible = false;
        }
        private void ContinueTutorial4(object sender, EventArgs e)
        {
            tutorial_panel_5.Visible = true;
            tutorial_panel_4.Visible = false;
            if (show_info_btn.Visible == false)
            {
                show_info_btn.Visible = true;
                show_info_btn.Visible = false;
            }
        }
        private void ContinueTutorial5(object sender, EventArgs e)
        {
            if (show_info_btn.Visible == false)
            {
                show_info_btn.Visible = false;
            }
            tutorial_panel_6.Visible = true;
            tutorial_panel_5.Visible = false;
        }
        private void ContinueTutorial6(object sender, EventArgs e)
        {
            if (tutorial_txt_6.Text == "Rechts kannst du erkennen in welcher Phase du dich befindest. Eine Phase gibt eine Semesterlänge an.")
            {
                tutorial_txt_6.Text = "Eine Aktion erhöht die Anzahl der Aktionspunktebei einem. Ein Event erhöht die Anzahl der Aktionspnkte bei zwei.";
            }
            else
            {
                tutorial_panel_6.Visible = false;
                AllOptionsEnable();
            }
        }

        private void ActionClose(object sender, EventArgs e)
        {
            action_panel.Visible = false;
            AllOptionsEnable();
            if (uiInterface.GetActionPoints() == 1)
            {
                option_1_btn.Enabled = false;
                option_2_btn.Enabled = false;
                option_3_btn.Enabled = false;
                option_4_btn.Enabled = false;
                show_info_btn.Enabled = false;
            }
        }

        private void HoverActionTxtShow0(object sender, EventArgs e)
        {
            info_action_panel_0.Visible = true;
            info_action_txt_0.Text = uiInterface.GetActionInfo(0);
        }
        private void HoverActionTxtShow1(object sender, EventArgs e)
        {
            info_action_panel_1.Visible = true;
            info_action_txt_1.Text = uiInterface.GetActionInfo(1);
        }
        private void HoverActionTxtShow2(object sender, EventArgs e)
        {
            info_action_panel_2.Visible = true;
            info_action_txt_2.Text = uiInterface.GetActionInfo(2);
        }
        private void HoverActionTxtShow3(object sender, EventArgs e)
        {
            info_action_panel_3.Visible = true;
            info_action_txt_3.Text = uiInterface.GetActionInfo(3);
        }

        private void CloseHoverAction(object sender, EventArgs e)
        {
            info_action_panel_0.Visible = false;
            info_action_panel_1.Visible = false;
            info_action_panel_2.Visible = false;
            info_action_panel_3.Visible = false;
        }

        private void NewProfessionNoBtnClick(object sender, EventArgs e)
        {
            if (new_profession_no_btn.Text == "Weiter")
            {
                lblPlayerPath.Text = new_profession_profession_combo_box.Text;
                PathSet(refrence_training);
                ProfessionSet(refrence_profession);
                uiInterface.ResetPath(training, profession);
            }
            new_profession_panel.Visible = false;
            AllOptionsEnable();
        }

        private void NewProfessionOptOpen(object sender, EventArgs e)
        {
            AllOptionsDisable();
            new_profession_panel.Visible = true;
            new_profession_no_btn.Text = "Nein";
            new_profession_yes_btn.Visible = true;
        }

        private void NewProfessionYesOpt(object sender, EventArgs e)
        {
            new_profession_profession_combo_box.Visible = true;
            new_profession_yes_btn.Visible = false;
            new_profession_no_btn.Text = "Weiter";
            new_profession_yes_btn.Visible = false;
            new_profession_profession_lable.Visible = true;
            new_profession_path_lable.Visible = true;
            new_profession_path_combo_box.Visible = true;
            new_profession_no_btn.Enabled = false;
            if (abschluss == "Hauptschulabschluss")
            {
                new_profession_path_combo_box.Items.AddRange(new object[] { "Ausbildung" });
            }
            else if (abschluss == "Realschulabschluss")
            {
                new_profession_path_combo_box.Items.AddRange(new object[] { "Ausbildung", "Duales Studium" });
            }
            else
            {
                new_profession_path_combo_box.Items.AddRange(new object[] { "Ausbildung", "Duales Studium", "Studium" });
            }
            new_profession_profession_combo_box.Enabled = false;
        }

        private void NewProfessionTxtChange(object sender, EventArgs e)
        {
            new_profession_no_btn.Enabled = true;
            if (new_profession_profession_combo_box.Text == "Krankenpflege" || new_profession_profession_combo_box.Text == "Angewandte Gesundheits- und Pflegewissenschaften" || new_profession_profession_combo_box.Text == "Medizinstudium")
            {
                refrence_profession = "Social";
            }
            if (new_profession_profession_combo_box.Text == "BWL" || new_profession_profession_combo_box.Text == "Industriekaufmann")
            {
                refrence_profession = "Buisness";
            }
            if (new_profession_profession_combo_box.Text == "Pharmazeutisch Technische Assistenz" || new_profession_profession_combo_box.Text == "Angewandte Physik" || new_profession_profession_combo_box.Text == "Physikstudium")
            {
                refrence_profession = "Science";
            }
            if (new_profession_profession_combo_box.Text == "Fachinformatiker" || new_profession_profession_combo_box.Text == "Angewandtes Informatikstudium" || new_profession_profession_combo_box.Text == "Informatikstudium")
            {
                refrence_profession = "Stem";
            }
            if (new_profession_profession_combo_box.Text == "Jurastudium" || new_profession_profession_combo_box.Text == "Steuerwesen" || new_profession_profession_combo_box.Text == "Rechtanwaltsfachangestellter")
            {
                refrence_profession = "Civil";
            }
        }

        private void NewProfessionPathComboBoxTextChanged(object sender, EventArgs e)
        {
            new_profession_profession_combo_box.Items.Clear();
            new_profession_profession_combo_box.Text = null;
            if (new_profession_path_combo_box.Text == "Ausbildung")
            {
                refrence_training = "Training";
                new_profession_profession_combo_box.Items.AddRange(new object[] { "Krankenpflege", "Industriekaufmann", "Pharmazeutisch Technische Assistenz", "Fachinformatiker", "Rechtanwaltsfachangestellter" });
            }
            else if (new_profession_path_combo_box.Text == "Duales Studium")
            {
                refrence_training = "Duales Studium";
                new_profession_profession_combo_box.Items.AddRange(new object[] { "Angewandte Gesundheits- und Pflegewissenschaften", "BWL", "Angewandte Physik", "Angewandtes Informatikstudium", "Steuerwesen" });
            }
            else if (new_profession_path_combo_box.Text == "Studium")
            {
                refrence_training = "Studium";
                new_profession_profession_combo_box.Items.AddRange(new object[] { "Medizinstudium", "BWL", "Physikstudium", "Informatikstudium", "Jurastudium" });
            }
            new_profession_profession_combo_box.Enabled = true;
        }
        private void ProfessionSet(string given_profession)
        {
            if (given_profession == "Social")
            {
                profession = Data.Profession.Social;
            }
            else if (given_profession == "Buisness")
            {
                profession = Data.Profession.Business;
            }
            else if (given_profession == "Stem")
            {
                profession = Data.Profession.Stem;
            }
            else if (given_profession == "Science")
            {
                profession = Data.Profession.Science;
            }
            else if (given_profession == "Civil")
            {
                profession = Data.Profession.Civil;
            }
        }
        private void PathSet(string given_path)
        {
            if (given_path == "Training")
            {
                training = Data.Path.Training;
            }
            else if (given_path == "DualStudy")
            {
                training = Data.Path.DualStudy;
            }
            else if (given_path == "Study")
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