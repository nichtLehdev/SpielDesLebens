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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.info_panel = new System.Windows.Forms.Panel();
            this.info_close_button = new System.Windows.Forms.Button();
            this.info_text = new System.Windows.Forms.RichTextBox();
            this.info_but = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.userInfo = new System.Windows.Forms.Panel();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPlayerAge = new System.Windows.Forms.Label();
            this.btnAktion = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.sonstige_box = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar5 = new System.Windows.Forms.ProgressBar();
            this.progressBar4 = new System.Windows.Forms.ProgressBar();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panelActiveChild = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.btnMusik = new System.Windows.Forms.Button();
            this.btnSport = new System.Windows.Forms.Button();
            this.btnHausis = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.info_panel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.userInfo.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RosyBrown;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(59, 273);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 44);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.RosyBrown;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(303, 273);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 44);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.info_panel);
            this.panel1.Controls.Add(this.info_but);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Location = new System.Drawing.Point(3, 278);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(475, 363);
            this.panel1.TabIndex = 3;
            // 
            // info_panel
            // 
            this.info_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.info_panel.Controls.Add(this.info_close_button);
            this.info_panel.Controls.Add(this.info_text);
            this.info_panel.Location = new System.Drawing.Point(59, 84);
            this.info_panel.Name = "info_panel";
            this.info_panel.Size = new System.Drawing.Size(365, 208);
            this.info_panel.TabIndex = 5;
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
            // info_but
            // 
            this.info_but.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.info_but.Cursor = System.Windows.Forms.Cursors.Default;
            this.info_but.Location = new System.Drawing.Point(349, 23);
            this.info_but.Name = "info_but";
            this.info_but.Size = new System.Drawing.Size(75, 40);
            this.info_but.TabIndex = 3;
            this.info_but.TabStop = false;
            this.info_but.Text = "Info";
            this.info_but.UseVisualStyleBackColor = false;
            this.info_but.Visible = false;
            this.info_but.Click += new System.EventHandler(this.show_info);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(59, 84);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(365, 168);
            this.textBox1.TabIndex = 4;
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.Color.GreenYellow;
            this.progressBar1.Location = new System.Drawing.Point(196, 53);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(548, 44);
            this.progressBar1.TabIndex = 4;
            this.progressBar1.Value = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Brown;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.btnMusik);
            this.panel2.Controls.Add(this.btnSport);
            this.panel2.Controls.Add(this.btnHausis);
            this.panel2.Controls.Add(this.userInfo);
            this.panel2.Controls.Add(this.btnAktion);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(240, 642);
            this.panel2.TabIndex = 6;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
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
            this.panel3.Controls.Add(this.sonstige_box);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.progressBar5);
            this.panel3.Controls.Add(this.progressBar4);
            this.panel3.Controls.Add(this.progressBar3);
            this.panel3.Controls.Add(this.progressBar2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1191, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(240, 642);
            this.panel3.TabIndex = 7;
            // 
            // sonstige_box
            // 
            this.sonstige_box.BackColor = System.Drawing.SystemColors.ControlLight;
            this.sonstige_box.Location = new System.Drawing.Point(37, 379);
            this.sonstige_box.Name = "sonstige_box";
            this.sonstige_box.Size = new System.Drawing.Size(162, 96);
            this.sonstige_box.TabIndex = 9;
            this.sonstige_box.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 363);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Sonstige";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Mental Health";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Motivation";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Lernstand";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Geld";
            // 
            // progressBar5
            // 
            this.progressBar5.BackColor = System.Drawing.Color.DarkGray;
            this.progressBar5.ForeColor = System.Drawing.Color.Maroon;
            this.progressBar5.Location = new System.Drawing.Point(37, 304);
            this.progressBar5.MarqueeAnimationSpeed = 50;
            this.progressBar5.Name = "progressBar5";
            this.progressBar5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.progressBar5.Size = new System.Drawing.Size(162, 23);
            this.progressBar5.TabIndex = 3;
            // 
            // progressBar4
            // 
            this.progressBar4.BackColor = System.Drawing.Color.DarkGray;
            this.progressBar4.ForeColor = System.Drawing.Color.Maroon;
            this.progressBar4.Location = new System.Drawing.Point(37, 225);
            this.progressBar4.Name = "progressBar4";
            this.progressBar4.Size = new System.Drawing.Size(162, 23);
            this.progressBar4.TabIndex = 2;
            // 
            // progressBar3
            // 
            this.progressBar3.BackColor = System.Drawing.Color.DarkGray;
            this.progressBar3.Location = new System.Drawing.Point(37, 147);
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(162, 23);
            this.progressBar3.TabIndex = 1;
            // 
            // progressBar2
            // 
            this.progressBar2.BackColor = System.Drawing.Color.DarkGray;
            this.progressBar2.ForeColor = System.Drawing.Color.Maroon;
            this.progressBar2.Location = new System.Drawing.Point(37, 73);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(162, 23);
            this.progressBar2.TabIndex = 0;
            this.progressBar2.Value = 10;
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
            this.panel4.Controls.Add(this.progressBar1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(240, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(951, 119);
            this.panel4.TabIndex = 9;
            // 
            // panelActiveChild
            // 
            this.panelActiveChild.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelActiveChild.Location = new System.Drawing.Point(240, 119);
            this.panelActiveChild.Name = "panelActiveChild";
            this.panelActiveChild.Size = new System.Drawing.Size(951, 523);
            this.panelActiveChild.TabIndex = 10;
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.980198F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.Black;
            this.button6.Image = global::Spiel_Des_Lebens.Properties.Resources.Music_Icon_small;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(0, 500);
            this.button6.Name = "button6";
            this.button6.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.button6.Size = new System.Drawing.Size(240, 60);
            this.button6.TabIndex = 15;
            this.button6.Text = "andere Aktion";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnMusik
            // 
            this.btnMusik.FlatAppearance.BorderSize = 0;
            this.btnMusik.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMusik.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.980198F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMusik.ForeColor = System.Drawing.Color.Black;
            this.btnMusik.Image = global::Spiel_Des_Lebens.Properties.Resources.Music_Icon_small;
            this.btnMusik.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMusik.Location = new System.Drawing.Point(0, 430);
            this.btnMusik.Name = "btnMusik";
            this.btnMusik.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnMusik.Size = new System.Drawing.Size(240, 60);
            this.btnMusik.TabIndex = 14;
            this.btnMusik.Text = "Musik";
            this.btnMusik.UseVisualStyleBackColor = true;
            this.btnMusik.Click += new System.EventHandler(this.btnMusik_Click);
            // 
            // btnSport
            // 
            this.btnSport.FlatAppearance.BorderSize = 0;
            this.btnSport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.980198F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSport.ForeColor = System.Drawing.Color.Black;
            this.btnSport.Image = global::Spiel_Des_Lebens.Properties.Resources.Sports_Icon_small;
            this.btnSport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSport.Location = new System.Drawing.Point(0, 360);
            this.btnSport.Name = "btnSport";
            this.btnSport.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnSport.Size = new System.Drawing.Size(240, 60);
            this.btnSport.TabIndex = 13;
            this.btnSport.Text = "Sport";
            this.btnSport.UseVisualStyleBackColor = true;
            this.btnSport.Click += new System.EventHandler(this.btnSport_Click);
            // 
            // btnHausis
            // 
            this.btnHausis.FlatAppearance.BorderSize = 0;
            this.btnHausis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHausis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.980198F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHausis.ForeColor = System.Drawing.Color.Black;
            this.btnHausis.Image = global::Spiel_Des_Lebens.Properties.Resources.Homework_Icon_small3;
            this.btnHausis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHausis.Location = new System.Drawing.Point(0, 290);
            this.btnHausis.Name = "btnHausis";
            this.btnHausis.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnHausis.Size = new System.Drawing.Size(240, 60);
            this.btnHausis.TabIndex = 12;
            this.btnHausis.Text = "Hausaufgaben";
            this.btnHausis.UseVisualStyleBackColor = true;
            this.btnHausis.Click += new System.EventHandler(this.btnHausis_Click);
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
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1431, 642);
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
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button info_but;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar5;
        private System.Windows.Forms.ProgressBar progressBar4;
        private System.Windows.Forms.ProgressBar progressBar3;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAktion;
        private System.Windows.Forms.RichTextBox sonstige_box;
        private System.Windows.Forms.Panel info_panel;
        private System.Windows.Forms.Button info_close_button;
        private System.Windows.Forms.RichTextBox info_text;
        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.Label lblPlayerAge;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Panel userInfo;
        private System.Windows.Forms.Button btnSport;
        private System.Windows.Forms.Button btnHausis;
        private System.Windows.Forms.Button btnMusik;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panelActiveChild;
    }
}

