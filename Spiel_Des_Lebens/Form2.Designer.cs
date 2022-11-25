namespace Spiel_Des_Lebens
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.option_1_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.close_opt_end_txt = new System.Windows.Forms.Button();
            this.info_panel = new System.Windows.Forms.Panel();
            this.info_close_button = new System.Windows.Forms.Button();
            this.info_text = new System.Windows.Forms.RichTextBox();
            this.option_4_btn = new System.Windows.Forms.Button();
            this.option_3_btn = new System.Windows.Forms.Button();
            this.option_2_btn = new System.Windows.Forms.Button();
            this.event_title = new System.Windows.Forms.TextBox();
            this.show_info_btn = new System.Windows.Forms.Button();
            this.event_txt_box = new System.Windows.Forms.TextBox();
            this.progress_prog_bar = new System.Windows.Forms.ProgressBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.action_4_btn = new System.Windows.Forms.Button();
            this.action_3_btn = new System.Windows.Forms.Button();
            this.action_2_btn = new System.Windows.Forms.Button();
            this.action_1_btn = new System.Windows.Forms.Button();
            this.userInfo = new System.Windows.Forms.Panel();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPlayerAge = new System.Windows.Forms.Label();
            this.btnAktion = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.action_points_txt = new System.Windows.Forms.Label();
            this.left_phase_txt = new System.Windows.Forms.Label();
            this.current_phase_txt = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mental_prog_bar = new System.Windows.Forms.ProgressBar();
            this.motivation_prog_bar = new System.Windows.Forms.ProgressBar();
            this.learn_prog_bar = new System.Windows.Forms.ProgressBar();
            this.money_prog_bar = new System.Windows.Forms.ProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panelActiveChild = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.info_panel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.userInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panelActiveChild.SuspendLayout();
            this.SuspendLayout();
            // 
            // option_1_btn
            // 
            this.option_1_btn.BackColor = System.Drawing.Color.RosyBrown;
            this.option_1_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.option_1_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.option_1_btn.Location = new System.Drawing.Point(59, 230);
            this.option_1_btn.Name = "option_1_btn";
            this.option_1_btn.Size = new System.Drawing.Size(222, 57);
            this.option_1_btn.TabIndex = 0;
            this.option_1_btn.Text = "option_1_btn";
            this.option_1_btn.UseVisualStyleBackColor = false;
            this.option_1_btn.Click += new System.EventHandler(this.option_1_click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.close_opt_end_txt);
            this.panel1.Controls.Add(this.info_panel);
            this.panel1.Controls.Add(this.option_4_btn);
            this.panel1.Controls.Add(this.option_3_btn);
            this.panel1.Controls.Add(this.option_2_btn);
            this.panel1.Controls.Add(this.event_title);
            this.panel1.Controls.Add(this.show_info_btn);
            this.panel1.Controls.Add(this.event_txt_box);
            this.panel1.Controls.Add(this.option_1_btn);
            this.panel1.Location = new System.Drawing.Point(196, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(589, 426);
            this.panel1.TabIndex = 10;
            // 
            // close_opt_end_txt
            // 
            this.close_opt_end_txt.Location = new System.Drawing.Point(472, 23);
            this.close_opt_end_txt.Name = "close_opt_end_txt";
            this.close_opt_end_txt.Size = new System.Drawing.Size(75, 40);
            this.close_opt_end_txt.TabIndex = 8;
            this.close_opt_end_txt.Text = "Nächstes Event";
            this.close_opt_end_txt.UseVisualStyleBackColor = true;
            this.close_opt_end_txt.Visible = false;
            this.close_opt_end_txt.Click += new System.EventHandler(this.close_opt_txt);
            // 
            // info_panel
            // 
            this.info_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.info_panel.Controls.Add(this.info_close_button);
            this.info_panel.Controls.Add(this.info_text);
            this.info_panel.Location = new System.Drawing.Point(135, 115);
            this.info_panel.Name = "info_panel";
            this.info_panel.Size = new System.Drawing.Size(365, 208);
            this.info_panel.TabIndex = 9;
            this.info_panel.Visible = false;
            // 
            // info_close_button
            // 
            this.info_close_button.Location = new System.Drawing.Point(257, 22);
            this.info_close_button.Name = "info_close_button";
            this.info_close_button.Size = new System.Drawing.Size(75, 23);
            this.info_close_button.TabIndex = 6;
            this.info_close_button.Text = "Schließen";
            this.info_close_button.UseVisualStyleBackColor = true;
            this.info_close_button.Visible = false;
            this.info_close_button.Click += new System.EventHandler(this.info_close);
            // 
            // info_text
            // 
            this.info_text.Location = new System.Drawing.Point(32, 61);
            this.info_text.Name = "info_text";
            this.info_text.Size = new System.Drawing.Size(300, 118);
            this.info_text.TabIndex = 0;
            this.info_text.Text = "";
            this.info_text.Visible = false;
            // 
            // option_4_btn
            // 
            this.option_4_btn.BackColor = System.Drawing.Color.RosyBrown;
            this.option_4_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.option_4_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.option_4_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.option_4_btn.Location = new System.Drawing.Point(325, 329);
            this.option_4_btn.Name = "option_4_btn";
            this.option_4_btn.Size = new System.Drawing.Size(222, 57);
            this.option_4_btn.TabIndex = 6;
            this.option_4_btn.Text = "option_1_btn";
            this.option_4_btn.UseVisualStyleBackColor = false;
            this.option_4_btn.Visible = false;
            this.option_4_btn.Click += new System.EventHandler(this.option_4_click);
            // 
            // option_3_btn
            // 
            this.option_3_btn.BackColor = System.Drawing.Color.RosyBrown;
            this.option_3_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.option_3_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.option_3_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.option_3_btn.Location = new System.Drawing.Point(59, 329);
            this.option_3_btn.Name = "option_3_btn";
            this.option_3_btn.Size = new System.Drawing.Size(222, 57);
            this.option_3_btn.TabIndex = 7;
            this.option_3_btn.Text = "option_1_btn";
            this.option_3_btn.UseVisualStyleBackColor = false;
            this.option_3_btn.Visible = false;
            this.option_3_btn.Click += new System.EventHandler(this.option_3_click);
            // 
            // option_2_btn
            // 
            this.option_2_btn.BackColor = System.Drawing.Color.RosyBrown;
            this.option_2_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.option_2_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.option_2_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.option_2_btn.Location = new System.Drawing.Point(325, 230);
            this.option_2_btn.Name = "option_2_btn";
            this.option_2_btn.Size = new System.Drawing.Size(222, 57);
            this.option_2_btn.TabIndex = 6;
            this.option_2_btn.Text = "option_1_btn";
            this.option_2_btn.UseVisualStyleBackColor = false;
            this.option_2_btn.Click += new System.EventHandler(this.option_2_click);
            // 
            // event_title
            // 
            this.event_title.BackColor = System.Drawing.Color.WhiteSmoke;
            this.event_title.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.event_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.event_title.Location = new System.Drawing.Point(59, 35);
            this.event_title.Name = "event_title";
            this.event_title.Size = new System.Drawing.Size(185, 20);
            this.event_title.TabIndex = 4;
            // 
            // show_info_btn
            // 
            this.show_info_btn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.show_info_btn.Cursor = System.Windows.Forms.Cursors.Default;
            this.show_info_btn.Location = new System.Drawing.Point(472, 23);
            this.show_info_btn.Name = "show_info_btn";
            this.show_info_btn.Size = new System.Drawing.Size(75, 40);
            this.show_info_btn.TabIndex = 3;
            this.show_info_btn.TabStop = false;
            this.show_info_btn.Text = "Info";
            this.show_info_btn.UseVisualStyleBackColor = false;
            this.show_info_btn.Visible = false;
            this.show_info_btn.Click += new System.EventHandler(this.show_info);
            // 
            // event_txt_box
            // 
            this.event_txt_box.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.event_txt_box.BackColor = System.Drawing.SystemColors.Control;
            this.event_txt_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.event_txt_box.Location = new System.Drawing.Point(59, 84);
            this.event_txt_box.Multiline = true;
            this.event_txt_box.Name = "event_txt_box";
            this.event_txt_box.Size = new System.Drawing.Size(488, 106);
            this.event_txt_box.TabIndex = 4;
            this.event_txt_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // progress_prog_bar
            // 
            this.progress_prog_bar.ForeColor = System.Drawing.Color.GreenYellow;
            this.progress_prog_bar.Location = new System.Drawing.Point(196, 53);
            this.progress_prog_bar.Name = "progress_prog_bar";
            this.progress_prog_bar.Size = new System.Drawing.Size(548, 44);
            this.progress_prog_bar.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Brown;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.action_4_btn);
            this.panel2.Controls.Add(this.action_3_btn);
            this.panel2.Controls.Add(this.action_2_btn);
            this.panel2.Controls.Add(this.action_1_btn);
            this.panel2.Controls.Add(this.userInfo);
            this.panel2.Controls.Add(this.btnAktion);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(240, 642);
            this.panel2.TabIndex = 6;
            // 
            // action_4_btn
            // 
            this.action_4_btn.FlatAppearance.BorderSize = 0;
            this.action_4_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.action_4_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.980198F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.action_4_btn.ForeColor = System.Drawing.Color.Black;
            this.action_4_btn.Image = global::Spiel_Des_Lebens.Properties.Resources.Music_Icon_small;
            this.action_4_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.action_4_btn.Location = new System.Drawing.Point(0, 500);
            this.action_4_btn.Name = "action_4_btn";
            this.action_4_btn.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.action_4_btn.Size = new System.Drawing.Size(240, 60);
            this.action_4_btn.TabIndex = 15;
            this.action_4_btn.Text = "andere Aktion";
            this.action_4_btn.UseVisualStyleBackColor = true;
            this.action_4_btn.Click += new System.EventHandler(this.button6_Click);
            // 
            // action_3_btn
            // 
            this.action_3_btn.FlatAppearance.BorderSize = 0;
            this.action_3_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.action_3_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.980198F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.action_3_btn.ForeColor = System.Drawing.Color.Black;
            this.action_3_btn.Image = global::Spiel_Des_Lebens.Properties.Resources.Music_Icon_small;
            this.action_3_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.action_3_btn.Location = new System.Drawing.Point(0, 430);
            this.action_3_btn.Name = "action_3_btn";
            this.action_3_btn.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.action_3_btn.Size = new System.Drawing.Size(240, 60);
            this.action_3_btn.TabIndex = 14;
            this.action_3_btn.Text = "Musik";
            this.action_3_btn.UseVisualStyleBackColor = true;
            this.action_3_btn.Click += new System.EventHandler(this.btnMusik_Click);
            // 
            // action_2_btn
            // 
            this.action_2_btn.FlatAppearance.BorderSize = 0;
            this.action_2_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.action_2_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.980198F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.action_2_btn.ForeColor = System.Drawing.Color.Black;
            this.action_2_btn.Image = global::Spiel_Des_Lebens.Properties.Resources.Sports_Icon_small;
            this.action_2_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.action_2_btn.Location = new System.Drawing.Point(0, 360);
            this.action_2_btn.Name = "action_2_btn";
            this.action_2_btn.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.action_2_btn.Size = new System.Drawing.Size(240, 60);
            this.action_2_btn.TabIndex = 13;
            this.action_2_btn.Text = "Sport";
            this.action_2_btn.UseVisualStyleBackColor = true;
            this.action_2_btn.Click += new System.EventHandler(this.btnSport_Click);
            // 
            // action_1_btn
            // 
            this.action_1_btn.FlatAppearance.BorderSize = 0;
            this.action_1_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.action_1_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.980198F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.action_1_btn.ForeColor = System.Drawing.Color.Black;
            this.action_1_btn.Image = global::Spiel_Des_Lebens.Properties.Resources.Homework_Icon_small3;
            this.action_1_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.action_1_btn.Location = new System.Drawing.Point(0, 290);
            this.action_1_btn.Name = "action_1_btn";
            this.action_1_btn.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.action_1_btn.Size = new System.Drawing.Size(240, 60);
            this.action_1_btn.TabIndex = 12;
            this.action_1_btn.Text = "Hausaufgaben";
            this.action_1_btn.UseVisualStyleBackColor = true;
            this.action_1_btn.Click += new System.EventHandler(this.btnHausis_Click);
            // 
            // userInfo
            // 
            this.userInfo.BackColor = System.Drawing.Color.Brown;
            this.userInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.userInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userInfo.Controls.Add(this.lblPlayerName);
            this.userInfo.Controls.Add(this.lblAge);
            this.userInfo.Controls.Add(this.pictureBox1);
            this.userInfo.Controls.Add(this.lblName);
            this.userInfo.Controls.Add(this.lblPlayerAge);
            this.userInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.userInfo.Location = new System.Drawing.Point(0, 0);
            this.userInfo.Name = "userInfo";
            this.userInfo.Size = new System.Drawing.Size(238, 188);
            this.userInfo.TabIndex = 10;
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Location = new System.Drawing.Point(112, 140);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(70, 13);
            this.lblPlayerName.TabIndex = 6;
            this.lblPlayerName.Text = "Spieler Name";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.841584F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.Location = new System.Drawing.Point(52, 156);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(37, 13);
            this.lblAge.TabIndex = 9;
            this.lblAge.Text = "Alter:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(55, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 117);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.841584F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(52, 140);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(43, 13);
            this.lblName.TabIndex = 8;
            this.lblName.Text = "Name:";
            // 
            // lblPlayerAge
            // 
            this.lblPlayerAge.AutoSize = true;
            this.lblPlayerAge.Location = new System.Drawing.Point(112, 156);
            this.lblPlayerAge.Name = "lblPlayerAge";
            this.lblPlayerAge.Size = new System.Drawing.Size(63, 13);
            this.lblPlayerAge.TabIndex = 7;
            this.lblPlayerAge.Text = "Spieler Alter";
            // 
            // btnAktion
            // 
            this.btnAktion.FlatAppearance.BorderSize = 0;
            this.btnAktion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAktion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.980198F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAktion.ForeColor = System.Drawing.Color.Black;
            this.btnAktion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAktion.Location = new System.Drawing.Point(0, 220);
            this.btnAktion.Name = "btnAktion";
            this.btnAktion.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnAktion.Size = new System.Drawing.Size(240, 60);
            this.btnAktion.TabIndex = 0;
            this.btnAktion.Text = "Aktionsfenster";
            this.btnAktion.UseVisualStyleBackColor = true;
            this.btnAktion.Click += new System.EventHandler(this.btnAktion_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Brown;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.action_points_txt);
            this.panel3.Controls.Add(this.left_phase_txt);
            this.panel3.Controls.Add(this.current_phase_txt);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.mental_prog_bar);
            this.panel3.Controls.Add(this.motivation_prog_bar);
            this.panel3.Controls.Add(this.learn_prog_bar);
            this.panel3.Controls.Add(this.money_prog_bar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1147, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(253, 642);
            this.panel3.TabIndex = 7;
            // 
            // action_points_txt
            // 
            this.action_points_txt.AutoSize = true;
            this.action_points_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.267326F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.action_points_txt.Location = new System.Drawing.Point(36, 154);
            this.action_points_txt.Name = "action_points_txt";
            this.action_points_txt.Size = new System.Drawing.Size(182, 16);
            this.action_points_txt.TabIndex = 12;
            this.action_points_txt.Text = "Aktionspunkte: XY Punkte";
            // 
            // left_phase_txt
            // 
            this.left_phase_txt.AutoSize = true;
            this.left_phase_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.980198F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.left_phase_txt.Location = new System.Drawing.Point(20, 106);
            this.left_phase_txt.Name = "left_phase_txt";
            this.left_phase_txt.Size = new System.Drawing.Size(233, 17);
            this.left_phase_txt.TabIndex = 11;
            this.left_phase_txt.Text = "Verbleibende Länge der Phase";
            // 
            // current_phase_txt
            // 
            this.current_phase_txt.AutoSize = true;
            this.current_phase_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.980198F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.current_phase_txt.Location = new System.Drawing.Point(28, 70);
            this.current_phase_txt.Name = "current_phase_txt";
            this.current_phase_txt.Size = new System.Drawing.Size(212, 17);
            this.current_phase_txt.TabIndex = 10;
            this.current_phase_txt.Text = "Derzeitige Phase: XY Phase";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 448);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Mental Health";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 371);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Motivation";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 301);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Lernstand";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Geld";
            // 
            // mental_prog_bar
            // 
            this.mental_prog_bar.BackColor = System.Drawing.Color.DarkGray;
            this.mental_prog_bar.ForeColor = System.Drawing.Color.Maroon;
            this.mental_prog_bar.Location = new System.Drawing.Point(35, 467);
            this.mental_prog_bar.MarqueeAnimationSpeed = 50;
            this.mental_prog_bar.Name = "mental_prog_bar";
            this.mental_prog_bar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mental_prog_bar.Size = new System.Drawing.Size(162, 23);
            this.mental_prog_bar.TabIndex = 3;
            this.mental_prog_bar.Value = 70;
            // 
            // motivation_prog_bar
            // 
            this.motivation_prog_bar.BackColor = System.Drawing.Color.DarkGray;
            this.motivation_prog_bar.ForeColor = System.Drawing.Color.Maroon;
            this.motivation_prog_bar.Location = new System.Drawing.Point(35, 388);
            this.motivation_prog_bar.Name = "motivation_prog_bar";
            this.motivation_prog_bar.Size = new System.Drawing.Size(162, 23);
            this.motivation_prog_bar.TabIndex = 2;
            this.motivation_prog_bar.Value = 70;
            // 
            // learn_prog_bar
            // 
            this.learn_prog_bar.BackColor = System.Drawing.Color.DarkGray;
            this.learn_prog_bar.ForeColor = System.Drawing.Color.Maroon;
            this.learn_prog_bar.Location = new System.Drawing.Point(38, 318);
            this.learn_prog_bar.Name = "learn_prog_bar";
            this.learn_prog_bar.Size = new System.Drawing.Size(162, 23);
            this.learn_prog_bar.TabIndex = 1;
            this.learn_prog_bar.Value = 70;
            // 
            // money_prog_bar
            // 
            this.money_prog_bar.BackColor = System.Drawing.Color.DarkGray;
            this.money_prog_bar.ForeColor = System.Drawing.Color.Maroon;
            this.money_prog_bar.Location = new System.Drawing.Point(35, 239);
            this.money_prog_bar.Name = "money_prog_bar";
            this.money_prog_bar.Size = new System.Drawing.Size(162, 23);
            this.money_prog_bar.TabIndex = 0;
            this.money_prog_bar.Value = 70;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.69307F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(193, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Fortschritt";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Brown;
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.progress_prog_bar);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(240, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(907, 119);
            this.panel4.TabIndex = 9;
            // 
            // panelActiveChild
            // 
            this.panelActiveChild.Controls.Add(this.panel1);
            this.panelActiveChild.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelActiveChild.Location = new System.Drawing.Point(240, 119);
            this.panelActiveChild.Name = "panelActiveChild";
            this.panelActiveChild.Size = new System.Drawing.Size(907, 523);
            this.panelActiveChild.TabIndex = 1;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1400, 642);
            this.Controls.Add(this.panelActiveChild);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "Form2";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.info_panel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.userInfo.ResumeLayout(false);
            this.userInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panelActiveChild.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button option_1_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox event_txt_box;
        private System.Windows.Forms.Button show_info_btn;
        private System.Windows.Forms.ProgressBar progress_prog_bar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar mental_prog_bar;
        private System.Windows.Forms.ProgressBar motivation_prog_bar;
        private System.Windows.Forms.ProgressBar learn_prog_bar;
        private System.Windows.Forms.ProgressBar money_prog_bar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAktion;
        private System.Windows.Forms.Panel info_panel;
        private System.Windows.Forms.Button info_close_button;
        private System.Windows.Forms.RichTextBox info_text;
        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.Label lblPlayerAge;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Panel userInfo;
        private System.Windows.Forms.Button action_2_btn;
        private System.Windows.Forms.Button action_1_btn;
        private System.Windows.Forms.Button action_3_btn;
        private System.Windows.Forms.Button action_4_btn;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panelActiveChild;
        private System.Windows.Forms.Label action_points_txt;
        private System.Windows.Forms.Label left_phase_txt;
        private System.Windows.Forms.Label current_phase_txt;
        private System.Windows.Forms.TextBox event_title;
        private System.Windows.Forms.Button option_2_btn;
        private System.Windows.Forms.Button option_4_btn;
        private System.Windows.Forms.Button option_3_btn;
        private System.Windows.Forms.Button close_opt_end_txt;
    }
}

