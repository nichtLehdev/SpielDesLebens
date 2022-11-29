﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

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
        public Form2(string name, string alter, Image avatar, string abschluss, Boolean new_game)
        {
            InitializeComponent();
            pictureBox1.Image = avatar;
            this.name = name;
            this.alter = Convert.ToInt16(alter);
            this.abschluss = abschluss;
            this.avatar = avatar;
            this.new_game = new_game;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ui_interface = new UI_Interface(true, 18, "Fritz", Data.Path.Training, Data.Profession.Business);
            lblPlayerAge.Text = Convert.ToString(this.alter);
            lblPlayerName.Text = this.name;
            btnLoadEvent_Click();
            update_aktionpoints();
            if (new_game == true)
            {
                all_options_disable();
                tutorial_ask_panel.Visible = true;
            }
        }

        public void OpenChildForm(Form childForm, object btnSender)
        {
            if(activeForm != null)
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

        private void btnAktion_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormActions(), sender);
        }

        private void btnSport_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormFreetime(), sender);
            ui_interface.receiveAction(3);
            update_aktionpoints();
        }

        private void btnHausis_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormSchool(), sender);
            ui_interface.receiveAction(1);
            update_aktionpoints();
        }

        private void btnMusik_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormFreetime(), sender);
            ui_interface.receiveAction(2);
            update_aktionpoints();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            ui_interface.receiveAction(4);
            update_aktionpoints();
            OpenChildForm(new Forms.FormFreetime(), sender);

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
                if(ui_interface.getEventOptionTitle(3) != "")
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
        }
        private void all_options_enable()
        {
            option_1_btn.Enabled = true;
            option_2_btn.Enabled = true;
            option_3_btn.Enabled = true;
            option_4_btn.Enabled = true;
            show_info_btn.Enabled = true;
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
            int overall_phase = ui_interface.getMaxPhase();
            if (action_points_txt.Text == "Aktionspunkte: 12")
            {
                action_points_txt.Text = "Aktionspunkte: " + action_points;
                current_phase_txt.Text = "Derzeitige Phase: " + cur_phase;
            }
            action_points_txt.Text = "Aktionspunkte: " + action_points;
            left_phase_txt.Text = "Verbleibene Länge der Phase: " + (12 - action_points);
            progress_prog_bar.Value = 100*((cur_phase-1)* 12 +action_points)/(overall_phase*12) ;
            if (ui_interface.getPlayerMoney() <= 100)
            {
                money_prog_bar.Value = ui_interface.getPlayerMoney();
            }
            learn_prog_bar.Value = ui_interface.getPlayerSuccess();
            motivation_prog_bar.Value = ui_interface.getPlayerMotivation();
            mental_prog_bar.Value = ui_interface.getPlayerMentalHealth();
            game_over_check();
        }
        private void get_new_actions()
        {
            /*
            String[] action_array = (String[]) ui_interface.getNextActionList(); // Vlt als String mir übergeben?
            if (action_array.Contains("Hausaufgaben"))
            {
                option_1_btn.Text = "Hausaufgaben";
                option_1_btn.Image = Spiel_Des_Lebens.Properties.Resources.Homework_Icon_small3;
            }
            */
        }
        private void close_opt_txt(object sender, EventArgs e)
        {
            close_opt_end_txt.Visible = false;
            btnLoadEvent_Click();
    }
        private void game_over_check()
        {
            String[] stats = new String[4];
            int i = 0;
            if (money_prog_bar.Value <= 0)
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
            if(show_info_btn.Visible == false)
            {
                show_info_btn.Visible = true;
                show_info_btn.Visible = false;
            }
        }
        private void continue_tutorial_5(object sender, EventArgs e)
        {
            if(show_info_btn.Visible == false)
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
    }
}