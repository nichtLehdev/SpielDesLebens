using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace Spiel_Des_Lebens
{
    public partial class Form2 : Form
    {
        private int alter;
        private string name;
        private string abschluss;
        private Image avatar;
        private Form activeForm;
        private UI_Interface ui_interface;
        private Boolean new_game = false;
        private String[] option = new String[4];
        private Data.Profession profession;
        private Data.Path training;
        private string job;
        private string refrence_training;
        public Form2(string name, string alter, Image avatar, string abschluss, bool new_game, String path, String profession, String job)
        {
            InitializeComponent();
            avatar_pic.Image = avatar;
            this.name = name;
            this.alter = Convert.ToInt16(alter);
            this.abschluss = abschluss;
            this.avatar = avatar;
            this.new_game = new_game;
            this.job = job;
            this.refrence_training = path;
            if (profession == "Social")
            {
                this.profession = Data.Profession.Social;
            }
            else if (profession == "Buisness")
            {
                this.profession = Data.Profession.Business;
            }
            else if (profession == "Stem")
            {
                this.profession = Data.Profession.Stem;
            }
            else if (profession == "Science")
            {
               this.profession = Data.Profession.Science;
            }
            else if (profession == "Civil")
            {
                this.profession = Data.Profession.Civil;
            }
            if (path == "Training")
            {
                this.training = Data.Path.Training;
            }
            else if (path == "DualStudy")
            {
                this.training = Data.Path.DualStudy;
            }
            else if (path == "Study")
            {
                this.training = Data.Path.Study;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ui_interface = new UI_Interface(true, alter, name, training, profession);
            lblPlayerAge.Text = Convert.ToString(this.alter);
            lblPlayerName.Text = this.name;
            lblPlayerPath.Text = this.job;
            btnLoadEvent_Click();
            update_aktionpoints();
            if (new_game == true)
            {
                all_options_disable();
                tutorial_ask_panel.Visible = true;
            }
            get_new_actions();
        }

        public void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelActiveChild.Controls.Add(childForm);
            this.panelActiveChild.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void show_info(object sender, EventArgs e)
        {
            info_panel.Visible = true;
            info_close_button.Visible = true;
            info_text.Visible = true;
            all_options_disable();
        }

        private void info_close(object sender, EventArgs e)
        {
            info_panel.Visible = false;
            info_close_button.Visible = false;
            info_text.Visible = false;
            all_options_enable();
        }

        private void action_0_click(object sender, EventArgs e)
        {
            action_text.Text = ui_interface.getActionOptionText(0);
            action_title.Text = ui_interface.getActionTitle(0);
            action_text_show();
        }

        private void action_1_click(object sender, EventArgs e)
        {
            action_text.Text = ui_interface.getActionOptionText(1);
            action_title.Text = ui_interface.getActionTitle(1);
            action_text_show();
        }

        private void action_2_click(object sender, EventArgs e)
        {
            action_text.Text = ui_interface.getActionOptionText(2);
            action_title.Text = ui_interface.getActionTitle(2);
            action_text_show();
        }

        private void action_3_click(object sender, EventArgs e)
        {
            action_text.Text = ui_interface.getActionOptionText(3);
            action_title.Text = ui_interface.getActionTitle(3);
            action_text_show();
        }
        private void action_text_show()
        {
            action_panel.Visible = true;
            all_options_disable();
            update_aktionpoints();
        }

        private void btnLoadEvent_Click()
        {
            update_aktionpoints();
            ui_interface.nextEvent();
            event_title.Text = ui_interface.getEventTitle();
            event_txt_box.Text = ui_interface.getEventText();
            if (ui_interface.getEventInfo() != "")
            {
                show_info_btn.Visible = true;
                info_text.Text = ui_interface.getEventInfo();
            }
            option_1_btn.Visible = true;
            option_2_btn.Visible = true;
            option_1_btn.Text = ui_interface.getEventOptionTitle(0);
            option_2_btn.Text = ui_interface.getEventOptionTitle(1);
            if (ui_interface.getEventOptionTitle(2) != "")
            {
                option_3_btn.Visible = true;
                option_3_btn.Text = ui_interface.getEventOptionTitle(2);
                option_4_btn.Visible = false;
                if (ui_interface.getEventOptionTitle(3) != "")
                {
                    option_4_btn.Visible = true;
                    option_4_btn.Text = ui_interface.getEventOptionTitle(3);
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
        private void all_options_disable()
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
        private void all_options_enable()
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
        private void all_options_hide()
        {
            option_1_btn.Visible = false;
            option_2_btn.Visible = false;
            option_3_btn.Visible = false;
            option_4_btn.Visible = false;
        }
        private void option_1_click(object sender, EventArgs e)
        {
            event_txt_box.Text = ui_interface.getEventOptionText(0);
            show_info_btn.Visible = false;
            close_opt_end_txt.Visible = true;
            all_options_hide();
        }
        private void option_2_click(object sender, EventArgs e)
        {
            event_txt_box.Text = ui_interface.getEventOptionText(1);
            show_info_btn.Visible = false;
            close_opt_end_txt.Visible = true;
            all_options_hide();
        }
        private void option_3_click(object sender, EventArgs e)
        {
            event_txt_box.Text = ui_interface.getEventOptionText(2);
            show_info_btn.Visible = false;
            close_opt_end_txt.Visible = true;
            all_options_hide();
        }

        private void option_4_click(object sender, EventArgs e)
        {
            event_txt_box.Text = ui_interface.getEventOptionText(3);
            show_info_btn.Visible = false;
            close_opt_end_txt.Visible = true;
            all_options_hide();
        }

        private void update_aktionpoints()
        {
            int action_points = ui_interface.getActionPoints();
            int cur_phase = ui_interface.getCurrentPhase();
            int overall_phase = ui_interface.getMaxPhaseLength();
            if (action_points_txt.Text == "Aktionspunkte: 12")
            {
                action_points_txt.Text = "Aktionspunkte: " + action_points;
                current_phase_txt.Text = "Derzeitige Phase: " + cur_phase;
            }
            action_points_txt.Text = "Aktionspunkte: " + action_points;
            left_phase_txt.Text = "Verbleibene Länge der Phase: " + (12 - action_points);
            progress_prog_bar.Value = 1;
            money_prog_bar.Text = ui_interface.getPlayerMoney().ToString() + "€";
            learn_prog_bar.Value = ui_interface.getPlayerSuccess();
            motivation_prog_bar.Value = ui_interface.getPlayerMotivation();
            mental_prog_bar.Value = ui_interface.getPlayerMentalHealth();
            if(action_points == 1)
            {
                option_1_btn.Enabled = false;
                option_2_btn.Enabled = false;
                option_3_btn.Enabled = false;
                option_4_btn.Enabled = false;
                show_info_btn.Enabled = false;
            }
            if(action_points == 14 && option_1_btn.Enabled == false)
            {
                option_1_btn.Enabled = true;
                option_2_btn.Enabled = true;
                option_3_btn.Enabled = true;
                option_4_btn.Enabled = true;
                show_info_btn.Enabled = true;
            }
            game_over_check();
        }
        private void get_new_actions()
        {
            action_0_btn.Text = ui_interface.getActionTitle(0);
            action_1_btn.Text = ui_interface.getActionTitle(1);
            action_2_btn.Text = ui_interface.getActionTitle(2);
            action_3_btn.Text = ui_interface.getActionTitle(3);

            action_0_btn.Image = get_right_icon(ui_interface.getActionOptionMainStat(0));
            action_1_btn.Image = get_right_icon(ui_interface.getActionOptionMainStat(1));
            action_2_btn.Image = get_right_icon(ui_interface.getActionOptionMainStat(2));
            action_3_btn.Image = get_right_icon(ui_interface.getActionOptionMainStat(3));

        }
        private Image get_right_icon(int r)
        {
            if (r == 0)
            {
                //mental health
                return Spiel_Des_Lebens.Properties.Resources.mentalhealth_48px;
            }
            else if (r == 1)
            {
                return Spiel_Des_Lebens.Properties.Resources.motivation_48px;
                //moneyyyyy
            }
            else if (r == 2)
            {
                return Spiel_Des_Lebens.Properties.Resources.money_48px;
                //motivation
            }
            else
            {
                return Spiel_Des_Lebens.Properties.Resources.Homework_Icon_small3;
                //lernstand
            }
        }
        private void close_opt_txt(object sender, EventArgs e)
        {
            close_opt_end_txt.Visible = false;
            btnLoadEvent_Click();
        }
        private void game_over_check()
        {
            String[] stats = new String[4];
            int i = 0; ;
            if (money_prog_bar.Text == "0€")
            {
                stats[i] = "money";
                i++;
            }
            if (learn_prog_bar.Value <= 0)
            {
                stats[i] = "learn";
                i++;
            }
            if (motivation_prog_bar.Value <= 0)
            {
                stats[i] = "motivation";
                i++;
            }
            if (mental_prog_bar.Value <= 0)
            {
                stats[i] = "mental";
                i++;
            }
            if (stats[0] != null)
            {
                game_over(stats);
            }
        }
        private void game_over(string[] stat)
        {
            if (stat[0] == "money")
            {
                game_over_txt.Text = "Geld beachten";
            }
            if (stat[0] == "learn")
            {
                game_over_txt.Text = "Lerstand beachten";
            }
            if (stat[0] == "motivation")
            {
                game_over_txt.Text = "Motivation beachten";
            }
            if (stat[0] == "mental")
            {
                game_over_txt.Text = "Mental beachten";
            }
            if (stat[1] != null)
            {
                if (stat[0] == "learn")
                {
                    game_over_txt.Text = game_over_txt + "Lernstand beachten.";
                }
                if (stat[0] == "motivation")
                {
                    game_over_txt.Text = game_over_txt + "Motivation beachten.";
                }
                if (stat[0] == "mental")
                {
                    game_over_txt.Text = game_over_txt + "Mental Health beachten.";
                }
            }
            if (stat[2] != null)
            {
                if (stat[0] == "motivation")
                {
                    game_over_txt.Text = game_over_txt + "Motivation beachten.";
                }
                if (stat[0] == "mental")
                {
                    game_over_txt.Text = game_over_txt + "Mental Health beachten.";
                }
            }
            if (stat[3] != null)
            {
                game_over_txt.Text = game_over_txt + "Mental Health beachten.";
            }
            game_over_panel.Visible = true;
            all_options_disable();
        }

        private void game_over_btn_Click(object sender, EventArgs e)
        {
            Form1 t = new Form1();
            t.Show();
            Hide();
        }

        private void end_tutorial(object sender, EventArgs e)
        {
            tutorial_ask_panel.Visible = false;
            all_options_enable();
        }

        private void start_tutorial(object sender, EventArgs e)
        {
            tutorial_ask_panel.Visible = false;
            tutorial_panel_1.Visible = true;
        }

        private void continue_tutorial_1(object sender, EventArgs e)
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
        private void continue_tutorial_2(object sender, EventArgs e)
        {
            tutorial_panel_3.Visible = true;
            tutorial_panel_2.Visible = false;
        }
        private void continue_tutorial_3(object sender, EventArgs e)
        {
            tutorial_panel_4.Visible = true;
            tutorial_panel_3.Visible = false;
        }
        private void continue_tutorial_4(object sender, EventArgs e)
        {
            tutorial_panel_5.Visible = true;
            tutorial_panel_4.Visible = false;
            if (show_info_btn.Visible == false)
            {
                show_info_btn.Visible = true;
                show_info_btn.Visible = false;
            }
        }
        private void continue_tutorial_5(object sender, EventArgs e)
        {
            if (show_info_btn.Visible == false)
            {
                show_info_btn.Visible = false;
            }
            tutorial_panel_6.Visible = true;
            tutorial_panel_5.Visible = false;
        }
        private void continue_tutorial_6(object sender, EventArgs e)
        {
            if (tutorial_txt_6.Text == "Rechts kannst du erkennen in welcher Phase du dich befindest. Eine Phase gibt eine Semesterlänge an.")
            {
                tutorial_txt_6.Text = "Eine Aktion erhöht die Anzahl der Aktionspunktebei einem. Ein Event erhöht die Anzahl der Aktionspnkte bei zwei.";
            }
            else
            {
                tutorial_panel_6.Visible = false;
                all_options_enable();
            }
        }

        private void action_close(object sender, EventArgs e)
        {
            action_panel.Visible = false;
            all_options_enable();
        }

        private void hover_action_txt_show_0(object sender, EventArgs e)
        {
            info_action_panel_0.Visible = true;
            info_action_txt_0.Text = ui_interface.getActionInfo(0);
        }
        private void hover_action_txt_show_1(object sender, EventArgs e)
        {
            info_action_panel_1.Visible = true;
            info_action_txt_1.Text = ui_interface.getActionInfo(1);
        }
        private void hover_action_txt_show_2(object sender, EventArgs e)
        {
            info_action_panel_2.Visible = true;
            info_action_txt_2.Text = ui_interface.getActionInfo(2);
        }
        private void hover_action_txt_show_3(object sender, EventArgs e)
        {
            info_action_panel_3.Visible = true;
            info_action_txt_3.Text = ui_interface.getActionInfo(3);
        }

        private void close_hover_action(object sender, EventArgs e)
        {
            info_action_panel_0.Visible = false;
            info_action_panel_1.Visible = false;
            info_action_panel_2.Visible = false;
            info_action_panel_3.Visible = false;
        }

        private void new_profession_no_btn_Click(object sender, EventArgs e)
        {
            if (new_profession_no_btn.Text == "Weiter")
            {
                ui_interface = new UI_Interface(true, alter, name, training, profession);
                lblPlayerPath.Text = new_profession_combo_box.Text;
            }
            new_profession_panel.Visible = false;
            all_options_enable();
        }

        private void new_profession_opt_open(object sender, EventArgs e)
        {
            all_options_disable();
            new_profession_panel.Visible = true;
            new_profession_no_btn.Text = "Nein";
            new_profession_yes_btn.Visible = true;
        }

        private void new_profession_yes_opt(object sender, EventArgs e)
        {
            new_profession_combo_box.Visible = true;
            new_profession_yes_btn.Visible = false;
            new_profession_no_btn.Text = "Weiter";
            new_profession_yes_btn.Visible = false;
            new_profession_lable.Visible = true;
            new_profession_no_btn.Enabled = false;
            if(refrence_training == "Training")
            {
                new_profession_combo_box.Items.AddRange(new object[] { "Krankenpflege", "Industriekaufmann", "Pharmazeutisch Technische Assistenz", "Fachinformatiker", "Rechtanwaltsfachangestellter" });
            }
            else if (refrence_training == "DualStudy")
            {
                new_profession_combo_box.Items.AddRange(new object[] { "Angewandte Gesundheits- und Pflegewissenschaften", "BWL", "Angewandte Physik", "Angewandtes Informatikstudium", "Steuerwesen" });
            }
            else if (refrence_training == "Study")
            {
                new_profession_combo_box.Items.AddRange(new object[] { "Medizinstudium", "BWL", "Physikstudium", "Informatikstudium", "Jurastudium" });
            }
        }

        private void new_profession_txt_change(object sender, EventArgs e)
        {
            new_profession_no_btn.Enabled = true;
        }
        
    }
}
