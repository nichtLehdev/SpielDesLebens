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
      private string refrence_profession;
      private Data.Graduation graduation;
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
         profession_set(profession);
         path_set(path);
         if (abschluss == "Realschulabschluss")
         {
            this.graduation = Data.Graduation.Realschulabschluss;
         }
         else if (abschluss == "Hauptschulabschluss")
         {
            this.graduation = Data.Graduation.Hauptschulabschluss;
         }
         else if (abschluss == "Fachhochschulreife")
         {
            this.graduation = Data.Graduation.Fachhochschulreife;
         }
         else if (abschluss == "allg. Hochschulreife")
         {
            this.graduation = Data.Graduation.AllgemeineHochschulreife;
         }
      }

      private void Form1_Load(object sender, EventArgs e)
      {
         ui_interface = new UI_Interface(true, alter, name, training, profession, graduation);
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
         current_phase_txt.Text = "Derzeitige Phase: " + cur_phase;
         action_points_txt.Text = "Benutzte Aktionspunkte: " + (ui_interface.getMaxActionPoints() - action_points);
         left_phase_txt.Text = "Verbleibene Länge der Phase: " + action_points;
         progress_prog_bar.Value = 1;
         money_prog_bar.Text = ui_interface.getPlayerMoney().ToString() + "€";
         learn_prog_bar.Value = ui_interface.getPlayerSuccess();
         motivation_prog_bar.Value = ui_interface.getPlayerMotivation();
         mental_prog_bar.Value = ui_interface.getPlayerMentalHealth();
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
         string warning_check = ui_interface.getStatWarning();
         if (warning_check != "")
         {
            tutorial_panel_2.Visible = true;
            tutorial_txt_2.Text = warning_check;
            tutorial_btn_2.Text = "Schließen";
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
         if (ui_interface.getGameOver() != "")
         {
            game_over_panel.Visible = true;
            all_options_disable();
            game_over_txt.Text = ui_interface.getGameOver();
         }
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
         if (tutorial_btn_2.Text == "Weiter")
         {
            tutorial_panel_3.Visible = true;
         }
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
            lblPlayerPath.Text = new_profession_profession_combo_box.Text;
            path_set(refrence_training);
            profession_set(refrence_profession);
            ui_interface.resetPath(training, profession);
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

      private void new_profession_txt_change(object sender, EventArgs e)
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
            refrence_profession = "Stem";
         }
         if (new_profession_profession_combo_box.Text == "Fachinformatiker" || new_profession_profession_combo_box.Text == "Angewandtes Informatikstudium" || new_profession_profession_combo_box.Text == "Informatikstudium")
         {
            refrence_profession = "Science";
         }
         if (new_profession_profession_combo_box.Text == "Jurastudium" || new_profession_profession_combo_box.Text == "Steuerwesen" || new_profession_profession_combo_box.Text == "Rechtanwaltsfachangestellter")
         {
            refrence_profession = "Civil";
         }
      }

      private void new_profession_path_comboBox_TextChanged(object sender, EventArgs e)
      {
         if (new_profession_path_combo_box.Text == "Ausbildung")
         {
            refrence_training = "Training";
            new_profession_profession_combo_box.Items.AddRange(new object[] { "Krankenpflege", "Industriekaufmann", "Pharmazeutisch Technische Assistenz", "Fachinformatiker", "Rechtanwaltsfachangestellter" });
         }
         else if (new_profession_path_combo_box.Text == "DualStudy")
         {
            refrence_training = "Duales Studium";
            new_profession_profession_combo_box.Items.AddRange(new object[] { "Angewandte Gesundheits- und Pflegewissenschaften", "BWL", "Angewandte Physik", "Angewandtes Informatikstudium", "Steuerwesen" });
         }
         else if (new_profession_path_combo_box.Text == "Study")
         {
            refrence_training = "Studium";
            new_profession_profession_combo_box.Items.AddRange(new object[] { "Medizinstudium", "BWL", "Physikstudium", "Informatikstudium", "Jurastudium" });
         }
         new_profession_profession_combo_box.Enabled = true;
      }
      private void profession_set(string given_profession)
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
      private void path_set(string given_path)
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

      private void next_phase(object sender, EventArgs e)
      {
         ui_interface.nextPhase();
         btnLoadEvent_Click();
         get_new_actions();
         ui_interface.nextEvent();
      }
   }
}
