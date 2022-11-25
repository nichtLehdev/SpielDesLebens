using System;
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
        private String[] option = new String[4];
        public Form2(string name, string alter, Image avatar, string abschluss)
        {
            InitializeComponent();
            pictureBox1.Image = avatar;
            this.name = name;
            this.alter = Convert.ToInt16(alter);
            this.abschluss = abschluss;
            this.avatar = avatar;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UI_Interface ui_interface = new UI_Interface(true, 18, "Fritz", Data.Path.Training, Data.Profession.Business);
            lblPlayerAge.Text = Convert.ToString(this.alter);
            lblPlayerName.Text = this.name;
            /*btnAktion_Click(sender, e);*/
            ui_interface.nextEvent();
            
            event_txt_box.Text = ui_interface.getEventText();
            current_phase_txt.Text = "Derzeitige Phase: " + ui_interface.getCurrentPhase();
            left_phase_txt.Text = "Verbleibene Phasenzeit: " + (6- ui_interface.getCurrentPhase());
            action_points_txt.Text = "Aktionspunkte: " + ui_interface.getActionPoints();
            option_1_btn.Text = ui_interface.getEventOptionTitle(0);
            option_2_btn.Text = ui_interface.getEventOptionTitle(1);
            if (ui_interface.getEventOptionTitle(3) == "" && ui_interface.getEventOptionTitle(2) != "")
            {
                option_3_btn.Visible = true;
                option_3_btn.Text = ui_interface.getEventOptionTitle(2);
            }
            else if(ui_interface.getEventOptionTitle(2) != "" && ui_interface.getEventOptionTitle(3) != "")
            {
                option_4_btn.Visible = true;
                option_4_btn.Text = ui_interface.getEventOptionTitle(2);
                option_5_btn.Visible = true;
                option_5_btn.Text = ui_interface.getEventOptionTitle(3);
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
        }

        private void info_close(object sender, EventArgs e)
        {
            info_panel.Visible = false;
            info_close_button.Visible = false;
            info_text.Visible = false;
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
            //txtEvent = ui_interface.nextEvent().ToString();
            event_txt_box.Text = ui_interface.getEventText();
            if(ui_interface.getEventInfo() != ""){
                show_info_btn.Visible = true;
                info_text.Text = ui_interface.getEventInfo();
            }
            //option[] = uI_Interface.getEventOptionTitle()
            option_1_btn.Text = option[0];
            option_2_btn.Text = option[1];
            if (option[4] == "" && option[3] != "")
            {
                option_3_btn.Visible = true;
                option_3_btn.Text = option[2];
                option_4_btn.Visible = false;
                option_5_btn.Visible = false;
            }
            else
            {
                option_3_btn.Visible = false;
                option_4_btn.Visible = true;
                option_4_btn.Text = option[2];
                option_5_btn.Visible = true;
                option_5_btn.Text = option[3];
            }
            update_aktionpoints();
        }

        private void option_1_click(object sender, EventArgs e)
        {
            ui_interface.getEventOptionTitle(1);
            btnLoadEvent_Click();
        }

        private void option_3_click(object sender, EventArgs e)
        {
            ui_interface.getEventOptionTitle(3);
            btnLoadEvent_Click();
        }

        private void option_4_click(object sender, EventArgs e)
        {
            ui_interface.getEventOptionTitle(4);
            btnLoadEvent_Click();
        }

        private void option_2_click(object sender, EventArgs e)
        {
            ui_interface.getEventOptionTitle(1);
            btnLoadEvent_Click();
        }
        private void update_aktionpoints()
        {
            int action_points = ui_interface.getActionPoints();
            int cur_phase = ui_interface.getCurrentPhase();
            if (action_points_txt.Text == "Aktionspunkte: 12")
            {
                action_points_txt.Text = "Aktionspunkte: " + action_points;
                current_phase_txt.Text = "Derzeitige Phase: " + cur_phase;
            }
            action_points_txt.Text = "Aktionspunkte: " + action_points;
            left_phase_txt.Text = "Verbleibene Länge der Phase: " + (12 - action_points);
            progress_prog_bar.Value = (cur_phase-1)* 12 +action_points ; // Hierbei mus geschaut werden wie lange das ganze Spiel ist um das ergebniss mit einen korrekten Wert darzustellen
            money_prog_bar.Value = ui_interface.getPlayerMoney();
            learn_prog_bar.Value = ui_interface.getPlayerSuccess();
            motivation_prog_bar.Value = ui_interface.getPlayerMotivation();
            mental_prog_bar.Value = ui_interface.getPlayerMentalHealth();
            //ist es möglich nachzuschauen ob man die überhaut die sache ändern muss ohne die ganzen Methoden der UI Aufrufen muss?
        }
        private void show_actions()
        {
           int[] action = ui_interface.getNextActionList();
        }

       
    }
}
