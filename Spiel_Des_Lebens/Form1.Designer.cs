namespace Spiel_Des_Lebens
{
   partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.fiction_txt_box = new System.Windows.Forms.RichTextBox();
            this.fiction_panel = new System.Windows.Forms.Panel();
            this.accept_fict_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_mini_3 = new System.Windows.Forms.Button();
            this.button_mini_2 = new System.Windows.Forms.Button();
            this.button_mini_1 = new System.Windows.Forms.Button();
            this.slot_btn_1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.slot_btn_2 = new System.Windows.Forms.Button();
            this.slot_btn_3 = new System.Windows.Forms.Button();
            this.Layout_neues_Spiel = new System.Windows.Forms.FlowLayoutPanel();
            this.avatarBox1 = new System.Windows.Forms.PictureBox();
            this.avatarBox2 = new System.Windows.Forms.PictureBox();
            this.avatarBox3 = new System.Windows.Forms.PictureBox();
            this.avatarBox4 = new System.Windows.Forms.PictureBox();
            this.avatarBox5 = new System.Windows.Forms.PictureBox();
            this.avatarBox6 = new System.Windows.Forms.PictureBox();
            this.btnHauptschule = new System.Windows.Forms.Button();
            this.btnRealschule = new System.Windows.Forms.Button();
            this.btnFachabi = new System.Windows.Forms.Button();
            this.btnAbi = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dropDown_profession = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dropDown_path = new System.Windows.Forms.ComboBox();
            this.lable_1 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_age = new System.Windows.Forms.TextBox();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.lbl_userInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.fiction_panel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.Layout_neues_Spiel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatarBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avatarBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avatarBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avatarBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avatarBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avatarBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // fiction_txt_box
            // 
            this.errorProvider1.SetIconAlignment(this.fiction_txt_box, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.fiction_txt_box.Location = new System.Drawing.Point(87, 117);
            this.fiction_txt_box.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fiction_txt_box.Name = "fiction_txt_box";
            this.fiction_txt_box.ReadOnly = true;
            this.fiction_txt_box.Size = new System.Drawing.Size(277, 195);
            this.fiction_txt_box.TabIndex = 0;
            this.fiction_txt_box.Text = "\nDies ist ein rein fiktives Spiel. Alle Namen, Charakter, Geschichten und Events " +
    "sind fiktiv.";
            // 
            // fiction_panel
            // 
            this.fiction_panel.BackgroundImage = global::Spiel_Des_Lebens.Properties.Resources.rotschwarzimg;
            this.fiction_panel.Controls.Add(this.accept_fict_btn);
            this.fiction_panel.Controls.Add(this.fiction_txt_box);
            this.fiction_panel.Location = new System.Drawing.Point(0, 0);
            this.fiction_panel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fiction_panel.Name = "fiction_panel";
            this.fiction_panel.Size = new System.Drawing.Size(457, 629);
            this.fiction_panel.TabIndex = 4;
            // 
            // accept_fict_btn
            // 
            this.accept_fict_btn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.accept_fict_btn.Location = new System.Drawing.Point(87, 433);
            this.accept_fict_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.accept_fict_btn.Name = "accept_fict_btn";
            this.accept_fict_btn.Size = new System.Drawing.Size(279, 23);
            this.accept_fict_btn.TabIndex = 1;
            this.accept_fict_btn.Text = "Vestanden";
            this.accept_fict_btn.UseVisualStyleBackColor = true;
            this.accept_fict_btn.Click += new System.EventHandler(this.accept_fict_btn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Brown;
            this.panel1.BackgroundImage = global::Spiel_Des_Lebens.Properties.Resources.rotschwarzimg;
            this.panel1.Controls.Add(this.fiction_panel);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.slot_btn_1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.slot_btn_2);
            this.panel1.Controls.Add(this.slot_btn_3);
            this.panel1.Location = new System.Drawing.Point(672, 38);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(457, 629);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::Spiel_Des_Lebens.Properties.Resources.rotschwarzimg;
            this.panel2.Controls.Add(this.button_mini_3);
            this.panel2.Controls.Add(this.button_mini_2);
            this.panel2.Controls.Add(this.button_mini_1);
            this.panel2.Location = new System.Drawing.Point(80, 209);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(349, 215);
            this.panel2.TabIndex = 6;
            this.panel2.Visible = false;
            // 
            // button_mini_3
            // 
            this.button_mini_3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_mini_3.Location = new System.Drawing.Point(47, 160);
            this.button_mini_3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_mini_3.Name = "button_mini_3";
            this.button_mini_3.Size = new System.Drawing.Size(248, 23);
            this.button_mini_3.TabIndex = 3;
            this.button_mini_3.Text = "Zurück";
            this.button_mini_3.UseVisualStyleBackColor = true;
            this.button_mini_3.Visible = false;
            this.button_mini_3.Click += new System.EventHandler(this.Close_option_spiel_start);
            // 
            // button_mini_2
            // 
            this.button_mini_2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_mini_2.Location = new System.Drawing.Point(47, 98);
            this.button_mini_2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_mini_2.Name = "button_mini_2";
            this.button_mini_2.Size = new System.Drawing.Size(248, 23);
            this.button_mini_2.TabIndex = 2;
            this.button_mini_2.Text = "Löschen";
            this.button_mini_2.UseVisualStyleBackColor = true;
            this.button_mini_2.Visible = false;
            this.button_mini_2.Click += new System.EventHandler(this.button_mini_2_Click);
            // 
            // button_mini_1
            // 
            this.button_mini_1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_mini_1.Location = new System.Drawing.Point(47, 41);
            this.button_mini_1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_mini_1.Name = "button_mini_1";
            this.button_mini_1.Size = new System.Drawing.Size(248, 23);
            this.button_mini_1.TabIndex = 1;
            this.button_mini_1.Text = "Laden";
            this.button_mini_1.UseVisualStyleBackColor = true;
            this.button_mini_1.Visible = false;
            this.button_mini_1.Click += new System.EventHandler(this.loadSaveGame);
            // 
            // slot_btn_1
            // 
            this.slot_btn_1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.slot_btn_1.Location = new System.Drawing.Point(87, 177);
            this.slot_btn_1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.slot_btn_1.Name = "slot_btn_1";
            this.slot_btn_1.Size = new System.Drawing.Size(299, 28);
            this.slot_btn_1.TabIndex = 0;
            this.slot_btn_1.Text = "Spielstand Test";
            this.slot_btn_1.UseVisualStyleBackColor = true;
            this.slot_btn_1.Click += new System.EventHandler(this.neues_Spiel_open);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Snow;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(160, 85);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(133, 23);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "Spiel des Lebens";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // slot_btn_2
            // 
            this.slot_btn_2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.slot_btn_2.Location = new System.Drawing.Point(87, 300);
            this.slot_btn_2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.slot_btn_2.Name = "slot_btn_2";
            this.slot_btn_2.Size = new System.Drawing.Size(299, 28);
            this.slot_btn_2.TabIndex = 3;
            this.slot_btn_2.Text = "Neues Spiel";
            this.slot_btn_2.UseVisualStyleBackColor = true;
            this.slot_btn_2.Click += new System.EventHandler(this.neues_Spiel_open);
            // 
            // slot_btn_3
            // 
            this.slot_btn_3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.slot_btn_3.Location = new System.Drawing.Point(87, 431);
            this.slot_btn_3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.slot_btn_3.Name = "slot_btn_3";
            this.slot_btn_3.Size = new System.Drawing.Size(299, 28);
            this.slot_btn_3.TabIndex = 2;
            this.slot_btn_3.Text = "Neues Spiel";
            this.slot_btn_3.UseVisualStyleBackColor = true;
            this.slot_btn_3.Click += new System.EventHandler(this.neues_Spiel_open);
            // 
            // Layout_neues_Spiel
            // 
            this.Layout_neues_Spiel.BackColor = System.Drawing.Color.Transparent;
            this.Layout_neues_Spiel.BackgroundImage = global::Spiel_Des_Lebens.Properties.Resources.rotschwarzimg;
            this.Layout_neues_Spiel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Layout_neues_Spiel.Controls.Add(this.avatarBox1);
            this.Layout_neues_Spiel.Controls.Add(this.avatarBox2);
            this.Layout_neues_Spiel.Controls.Add(this.avatarBox3);
            this.Layout_neues_Spiel.Controls.Add(this.avatarBox4);
            this.Layout_neues_Spiel.Controls.Add(this.avatarBox5);
            this.Layout_neues_Spiel.Controls.Add(this.avatarBox6);
            this.Layout_neues_Spiel.Controls.Add(this.btnHauptschule);
            this.Layout_neues_Spiel.Controls.Add(this.btnRealschule);
            this.Layout_neues_Spiel.Controls.Add(this.btnFachabi);
            this.Layout_neues_Spiel.Controls.Add(this.btnAbi);
            this.Layout_neues_Spiel.Controls.Add(this.label2);
            this.Layout_neues_Spiel.Controls.Add(this.dropDown_profession);
            this.Layout_neues_Spiel.Controls.Add(this.label3);
            this.Layout_neues_Spiel.Controls.Add(this.dropDown_path);
            this.Layout_neues_Spiel.Controls.Add(this.lable_1);
            this.Layout_neues_Spiel.Controls.Add(this.txt_name);
            this.Layout_neues_Spiel.Controls.Add(this.label1);
            this.Layout_neues_Spiel.Controls.Add(this.txt_age);
            this.Layout_neues_Spiel.Controls.Add(this.btn_back);
            this.Layout_neues_Spiel.Controls.Add(this.btn_next);
            this.Layout_neues_Spiel.Controls.Add(this.lbl_userInfo);
            this.Layout_neues_Spiel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Layout_neues_Spiel.Location = new System.Drawing.Point(672, 38);
            this.Layout_neues_Spiel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Layout_neues_Spiel.Name = "Layout_neues_Spiel";
            this.Layout_neues_Spiel.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.Layout_neues_Spiel.Size = new System.Drawing.Size(457, 629);
            this.Layout_neues_Spiel.TabIndex = 0;
            this.Layout_neues_Spiel.Visible = false;
            // 
            // avatarBox1
            // 
            this.avatarBox1.ErrorImage = global::Spiel_Des_Lebens.Properties.Resources.avatare_boy_0;
            this.avatarBox1.Image = global::Spiel_Des_Lebens.Properties.Resources.avatare_boy_0;
            this.avatarBox1.Location = new System.Drawing.Point(17, 16);
            this.avatarBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.avatarBox1.Name = "avatarBox1";
            this.avatarBox1.Size = new System.Drawing.Size(133, 153);
            this.avatarBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.avatarBox1.TabIndex = 0;
            this.avatarBox1.TabStop = false;
            this.avatarBox1.Click += new System.EventHandler(this.changeAvatar);
            // 
            // avatarBox2
            // 
            this.avatarBox2.Image = global::Spiel_Des_Lebens.Properties.Resources.avatare_boy_1;
            this.avatarBox2.Location = new System.Drawing.Point(158, 16);
            this.avatarBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.avatarBox2.Name = "avatarBox2";
            this.avatarBox2.Size = new System.Drawing.Size(133, 153);
            this.avatarBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.avatarBox2.TabIndex = 1;
            this.avatarBox2.TabStop = false;
            this.avatarBox2.Click += new System.EventHandler(this.changeAvatar);
            // 
            // avatarBox3
            // 
            this.avatarBox3.ErrorImage = null;
            this.avatarBox3.Image = global::Spiel_Des_Lebens.Properties.Resources.avatare_boy_2;
            this.avatarBox3.InitialImage = null;
            this.avatarBox3.Location = new System.Drawing.Point(299, 16);
            this.avatarBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.avatarBox3.Name = "avatarBox3";
            this.avatarBox3.Size = new System.Drawing.Size(133, 153);
            this.avatarBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.avatarBox3.TabIndex = 2;
            this.avatarBox3.TabStop = false;
            this.avatarBox3.Click += new System.EventHandler(this.changeAvatar);
            // 
            // avatarBox4
            // 
            this.avatarBox4.Image = global::Spiel_Des_Lebens.Properties.Resources.avatare_girl_0;
            this.avatarBox4.Location = new System.Drawing.Point(17, 177);
            this.avatarBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.avatarBox4.Name = "avatarBox4";
            this.avatarBox4.Size = new System.Drawing.Size(133, 153);
            this.avatarBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.avatarBox4.TabIndex = 3;
            this.avatarBox4.TabStop = false;
            this.avatarBox4.Click += new System.EventHandler(this.changeAvatar);
            // 
            // avatarBox5
            // 
            this.avatarBox5.Image = global::Spiel_Des_Lebens.Properties.Resources.avatare_girl_1;
            this.avatarBox5.Location = new System.Drawing.Point(158, 177);
            this.avatarBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.avatarBox5.Name = "avatarBox5";
            this.avatarBox5.Size = new System.Drawing.Size(133, 153);
            this.avatarBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.avatarBox5.TabIndex = 4;
            this.avatarBox5.TabStop = false;
            this.avatarBox5.Click += new System.EventHandler(this.changeAvatar);
            // 
            // avatarBox6
            // 
            this.avatarBox6.Image = global::Spiel_Des_Lebens.Properties.Resources.avatare_girl_2;
            this.avatarBox6.Location = new System.Drawing.Point(299, 177);
            this.avatarBox6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.avatarBox6.Name = "avatarBox6";
            this.avatarBox6.Size = new System.Drawing.Size(133, 153);
            this.avatarBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.avatarBox6.TabIndex = 5;
            this.avatarBox6.TabStop = false;
            this.avatarBox6.Click += new System.EventHandler(this.changeAvatar);
            // 
            // btnHauptschule
            // 
            this.btnHauptschule.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnHauptschule.Location = new System.Drawing.Point(17, 338);
            this.btnHauptschule.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHauptschule.Name = "btnHauptschule";
            this.btnHauptschule.Size = new System.Drawing.Size(203, 28);
            this.btnHauptschule.TabIndex = 6;
            this.btnHauptschule.Text = "Hauptschulabschluss";
            this.btnHauptschule.UseVisualStyleBackColor = true;
            this.btnHauptschule.Click += new System.EventHandler(this.changePath);
            // 
            // btnRealschule
            // 
            this.btnRealschule.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnRealschule.Location = new System.Drawing.Point(228, 338);
            this.btnRealschule.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRealschule.Name = "btnRealschule";
            this.btnRealschule.Size = new System.Drawing.Size(205, 28);
            this.btnRealschule.TabIndex = 7;
            this.btnRealschule.Text = "Realschulabschluss";
            this.btnRealschule.UseVisualStyleBackColor = true;
            this.btnRealschule.Click += new System.EventHandler(this.changePath);
            // 
            // btnFachabi
            // 
            this.btnFachabi.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnFachabi.Location = new System.Drawing.Point(17, 374);
            this.btnFachabi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFachabi.Name = "btnFachabi";
            this.btnFachabi.Size = new System.Drawing.Size(203, 28);
            this.btnFachabi.TabIndex = 8;
            this.btnFachabi.Text = "Fachhochschulreife";
            this.btnFachabi.UseVisualStyleBackColor = true;
            this.btnFachabi.Click += new System.EventHandler(this.changePath);
            // 
            // btnAbi
            // 
            this.btnAbi.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAbi.Location = new System.Drawing.Point(228, 374);
            this.btnAbi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAbi.Name = "btnAbi";
            this.btnAbi.Size = new System.Drawing.Size(205, 28);
            this.btnAbi.TabIndex = 9;
            this.btnAbi.Text = "allg. Hochschulreife";
            this.btnAbi.UseVisualStyleBackColor = true;
            this.btnAbi.Click += new System.EventHandler(this.changePath);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(17, 412);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Bildungsweg";
            // 
            // dropDown_profession
            // 
            this.dropDown_profession.FormattingEnabled = true;
            this.dropDown_profession.Location = new System.Drawing.Point(123, 410);
            this.dropDown_profession.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dropDown_profession.Name = "dropDown_profession";
            this.dropDown_profession.Size = new System.Drawing.Size(297, 24);
            this.dropDown_profession.TabIndex = 17;
            this.dropDown_profession.TextChanged += new System.EventHandler(this.education_path_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(17, 444);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 6, 9, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Karriereweg";
            // 
            // dropDown_path
            // 
            this.dropDown_path.FormattingEnabled = true;
            this.dropDown_path.Location = new System.Drawing.Point(125, 442);
            this.dropDown_path.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dropDown_path.Name = "dropDown_path";
            this.dropDown_path.Size = new System.Drawing.Size(297, 24);
            this.dropDown_path.TabIndex = 19;
            this.dropDown_path.TextChanged += new System.EventHandler(this.profession_path_TextChanged);
            // 
            // lable_1
            // 
            this.lable_1.AutoSize = true;
            this.lable_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable_1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lable_1.Location = new System.Drawing.Point(17, 476);
            this.lable_1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 0);
            this.lable_1.Name = "lable_1";
            this.lable_1.Size = new System.Drawing.Size(49, 17);
            this.lable_1.TabIndex = 10;
            this.lable_1.Text = "Name";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(74, 474);
            this.txt_name.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(355, 22);
            this.txt_name.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(17, 506);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 6, 13, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Alter";
            // 
            // txt_age
            // 
            this.txt_age.Location = new System.Drawing.Point(76, 504);
            this.txt_age.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_age.Name = "txt_age";
            this.txt_age.Size = new System.Drawing.Size(353, 22);
            this.txt_age.TabIndex = 14;
            this.txt_age.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_alter_KeyPress);
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.RosyBrown;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_back.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_back.Location = new System.Drawing.Point(73, 534);
            this.btn_back.Margin = new System.Windows.Forms.Padding(60, 4, 4, 4);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(176, 59);
            this.btn_back.TabIndex = 16;
            this.btn_back.Text = "Zurück";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.open_main_menu);
            // 
            // btn_next
            // 
            this.btn_next.BackColor = System.Drawing.Color.RosyBrown;
            this.btn_next.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_next.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_next.Location = new System.Drawing.Point(260, 534);
            this.btn_next.Margin = new System.Windows.Forms.Padding(7, 4, 4, 4);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(176, 59);
            this.btn_next.TabIndex = 15;
            this.btn_next.Text = "Weiter";
            this.btn_next.UseVisualStyleBackColor = false;
            this.btn_next.Click += new System.EventHandler(this.open_next);
            // 
            // lbl_userInfo
            // 
            this.lbl_userInfo.AutoSize = true;
            this.lbl_userInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lbl_userInfo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_userInfo.Location = new System.Drawing.Point(17, 597);
            this.lbl_userInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_userInfo.Name = "lbl_userInfo";
            this.lbl_userInfo.Size = new System.Drawing.Size(193, 17);
            this.lbl_userInfo.TabIndex = 21;
            this.lbl_userInfo.Text = "Erstelle deinen Charakter";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1809, 817);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Layout_neues_Spiel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Spiel des Lebens";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.fiction_panel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.Layout_neues_Spiel.ResumeLayout(false);
            this.Layout_neues_Spiel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatarBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avatarBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avatarBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avatarBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avatarBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avatarBox6)).EndInit();
            this.ResumeLayout(false);

      }

      #endregion
      private System.Windows.Forms.PictureBox avatarBox1;
      private System.Windows.Forms.PictureBox avatarBox2;
      private System.Windows.Forms.PictureBox avatarBox3;
      private System.Windows.Forms.Button btnHauptschule;
      private System.Windows.Forms.Button btnRealschule;
      private System.Windows.Forms.Button btnFachabi;
      private System.Windows.Forms.Button btnAbi;
      private System.Windows.Forms.Label lable_1;
      private System.Windows.Forms.TextBox txt_name;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.TextBox txt_age;
      private System.Windows.Forms.Button btn_next;
      private System.Windows.Forms.FlowLayoutPanel Layout_neues_Spiel;
      private System.Windows.Forms.Panel panel1;
      private System.Windows.Forms.Button slot_btn_1;
      private System.Windows.Forms.Button slot_btn_2;
      private System.Windows.Forms.Button slot_btn_3;
      private System.Windows.Forms.TextBox textBox1;
      private System.Windows.Forms.Button btn_back;
      private System.Windows.Forms.ErrorProvider errorProvider1;
      private System.Windows.Forms.Panel panel2;
      private System.Windows.Forms.Button button_mini_3;
      private System.Windows.Forms.Button button_mini_2;
      private System.Windows.Forms.Button button_mini_1;
      private System.Windows.Forms.Panel fiction_panel;
      private System.Windows.Forms.RichTextBox fiction_txt_box;
      private System.Windows.Forms.Button accept_fict_btn;
        private System.Windows.Forms.PictureBox avatarBox4;
        private System.Windows.Forms.PictureBox avatarBox5;
        private System.Windows.Forms.PictureBox avatarBox6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox dropDown_profession;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox dropDown_path;
        private System.Windows.Forms.Label lbl_userInfo;
    }
}