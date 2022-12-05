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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_mini_3 = new System.Windows.Forms.Button();
            this.button_mini_2 = new System.Windows.Forms.Button();
            this.button_mini_1 = new System.Windows.Forms.Button();
            this.slot_btn_1 = new System.Windows.Forms.Button();
            this.slot_btn_2 = new System.Windows.Forms.Button();
            this.slot_btn_3 = new System.Windows.Forms.Button();
            this.fiction_panel = new System.Windows.Forms.Panel();
            this.accept_fict_btn = new System.Windows.Forms.Button();
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
            this.title = new System.Windows.Forms.Label();
            this.lbl_userInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.fiction_panel.SuspendLayout();
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
            this.fiction_txt_box.Location = new System.Drawing.Point(65, 95);
            this.fiction_txt_box.Name = "fiction_txt_box";
            this.fiction_txt_box.ReadOnly = true;
            this.fiction_txt_box.Size = new System.Drawing.Size(209, 159);
            this.fiction_txt_box.TabIndex = 0;
            this.fiction_txt_box.Text = "\nDies ist ein rein fiktives Spiel. Alle Namen, Charakter, Geschichten und Events " +
    "sind fiktiv.";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Brown;
            this.panel1.BackgroundImage = global::Spiel_Des_Lebens.Properties.Resources.rotschwarzimg;
            this.panel1.Controls.Add(this.title);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.slot_btn_1);
            this.panel1.Controls.Add(this.slot_btn_2);
            this.panel1.Controls.Add(this.slot_btn_3);
            this.panel1.Location = new System.Drawing.Point(155, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(343, 511);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::Spiel_Des_Lebens.Properties.Resources.rotschwarzimg;
            this.panel2.Controls.Add(this.button_mini_3);
            this.panel2.Controls.Add(this.button_mini_2);
            this.panel2.Controls.Add(this.button_mini_1);
            this.panel2.Location = new System.Drawing.Point(60, 170);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(262, 175);
            this.panel2.TabIndex = 6;
            this.panel2.Visible = false;
            // 
            // button_mini_3
            // 
            this.button_mini_3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_mini_3.Location = new System.Drawing.Point(35, 130);
            this.button_mini_3.Margin = new System.Windows.Forms.Padding(2);
            this.button_mini_3.Name = "button_mini_3";
            this.button_mini_3.Size = new System.Drawing.Size(186, 19);
            this.button_mini_3.TabIndex = 3;
            this.button_mini_3.Text = "Zurück";
            this.button_mini_3.UseVisualStyleBackColor = true;
            this.button_mini_3.Visible = false;
            this.button_mini_3.Click += new System.EventHandler(this.Close_option_spiel_start);
            // 
            // button_mini_2
            // 
            this.button_mini_2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_mini_2.Location = new System.Drawing.Point(35, 80);
            this.button_mini_2.Margin = new System.Windows.Forms.Padding(2);
            this.button_mini_2.Name = "button_mini_2";
            this.button_mini_2.Size = new System.Drawing.Size(186, 19);
            this.button_mini_2.TabIndex = 2;
            this.button_mini_2.Text = "Löschen";
            this.button_mini_2.UseVisualStyleBackColor = true;
            this.button_mini_2.Visible = false;
            this.button_mini_2.Click += new System.EventHandler(this.button_mini_2_Click);
            // 
            // button_mini_1
            // 
            this.button_mini_1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_mini_1.Location = new System.Drawing.Point(35, 33);
            this.button_mini_1.Margin = new System.Windows.Forms.Padding(2);
            this.button_mini_1.Name = "button_mini_1";
            this.button_mini_1.Size = new System.Drawing.Size(186, 19);
            this.button_mini_1.TabIndex = 1;
            this.button_mini_1.Text = "Laden";
            this.button_mini_1.UseVisualStyleBackColor = true;
            this.button_mini_1.Visible = false;
            this.button_mini_1.Click += new System.EventHandler(this.loadSaveGame);
            // 
            // slot_btn_1
            // 
            this.slot_btn_1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.slot_btn_1.Location = new System.Drawing.Point(65, 144);
            this.slot_btn_1.Name = "slot_btn_1";
            this.slot_btn_1.Size = new System.Drawing.Size(224, 23);
            this.slot_btn_1.TabIndex = 0;
            this.slot_btn_1.Text = "Spielstand Test";
            this.slot_btn_1.UseVisualStyleBackColor = true;
            this.slot_btn_1.Click += new System.EventHandler(this.neues_Spiel_open);
            // 
            // slot_btn_2
            // 
            this.slot_btn_2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.slot_btn_2.Location = new System.Drawing.Point(65, 244);
            this.slot_btn_2.Name = "slot_btn_2";
            this.slot_btn_2.Size = new System.Drawing.Size(224, 23);
            this.slot_btn_2.TabIndex = 3;
            this.slot_btn_2.Text = "Neues Spiel";
            this.slot_btn_2.UseVisualStyleBackColor = true;
            this.slot_btn_2.Click += new System.EventHandler(this.neues_Spiel_open);
            // 
            // slot_btn_3
            // 
            this.slot_btn_3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.slot_btn_3.Location = new System.Drawing.Point(65, 350);
            this.slot_btn_3.Name = "slot_btn_3";
            this.slot_btn_3.Size = new System.Drawing.Size(224, 23);
            this.slot_btn_3.TabIndex = 2;
            this.slot_btn_3.Text = "Neues Spiel";
            this.slot_btn_3.UseVisualStyleBackColor = true;
            this.slot_btn_3.Click += new System.EventHandler(this.neues_Spiel_open);
            // 
            // fiction_panel
            // 
            this.fiction_panel.BackgroundImage = global::Spiel_Des_Lebens.Properties.Resources.rotschwarzimg;
            this.fiction_panel.Controls.Add(this.accept_fict_btn);
            this.fiction_panel.Controls.Add(this.fiction_txt_box);
            this.fiction_panel.Location = new System.Drawing.Point(986, 59);
            this.fiction_panel.Name = "fiction_panel";
            this.fiction_panel.Size = new System.Drawing.Size(343, 511);
            this.fiction_panel.TabIndex = 4;
            // 
            // accept_fict_btn
            // 
            this.accept_fict_btn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.accept_fict_btn.Location = new System.Drawing.Point(65, 352);
            this.accept_fict_btn.Margin = new System.Windows.Forms.Padding(2);
            this.accept_fict_btn.Name = "accept_fict_btn";
            this.accept_fict_btn.Size = new System.Drawing.Size(209, 19);
            this.accept_fict_btn.TabIndex = 1;
            this.accept_fict_btn.Text = "Vestanden";
            this.accept_fict_btn.UseVisualStyleBackColor = true;
            this.accept_fict_btn.Click += new System.EventHandler(this.accept_fict_btn_Click);
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
            this.Layout_neues_Spiel.Location = new System.Drawing.Point(504, 31);
            this.Layout_neues_Spiel.Name = "Layout_neues_Spiel";
            this.Layout_neues_Spiel.Padding = new System.Windows.Forms.Padding(10);
            this.Layout_neues_Spiel.Size = new System.Drawing.Size(343, 511);
            this.Layout_neues_Spiel.TabIndex = 0;
            this.Layout_neues_Spiel.Visible = false;
            // 
            // avatarBox1
            // 
            this.avatarBox1.ErrorImage = global::Spiel_Des_Lebens.Properties.Resources.avatare_boy_0;
            this.avatarBox1.Image = global::Spiel_Des_Lebens.Properties.Resources.avatare_boy_0;
            this.avatarBox1.Location = new System.Drawing.Point(13, 13);
            this.avatarBox1.Name = "avatarBox1";
            this.avatarBox1.Size = new System.Drawing.Size(100, 124);
            this.avatarBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.avatarBox1.TabIndex = 0;
            this.avatarBox1.TabStop = false;
            this.avatarBox1.Click += new System.EventHandler(this.changeAvatar);
            // 
            // avatarBox2
            // 
            this.avatarBox2.Image = global::Spiel_Des_Lebens.Properties.Resources.avatare_boy_1;
            this.avatarBox2.Location = new System.Drawing.Point(119, 13);
            this.avatarBox2.Name = "avatarBox2";
            this.avatarBox2.Size = new System.Drawing.Size(100, 124);
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
            this.avatarBox3.Location = new System.Drawing.Point(225, 13);
            this.avatarBox3.Name = "avatarBox3";
            this.avatarBox3.Size = new System.Drawing.Size(100, 124);
            this.avatarBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.avatarBox3.TabIndex = 2;
            this.avatarBox3.TabStop = false;
            this.avatarBox3.Click += new System.EventHandler(this.changeAvatar);
            // 
            // avatarBox4
            // 
            this.avatarBox4.Image = global::Spiel_Des_Lebens.Properties.Resources.avatare_girl_0;
            this.avatarBox4.Location = new System.Drawing.Point(13, 143);
            this.avatarBox4.Name = "avatarBox4";
            this.avatarBox4.Size = new System.Drawing.Size(100, 124);
            this.avatarBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.avatarBox4.TabIndex = 3;
            this.avatarBox4.TabStop = false;
            this.avatarBox4.Click += new System.EventHandler(this.changeAvatar);
            // 
            // avatarBox5
            // 
            this.avatarBox5.Image = global::Spiel_Des_Lebens.Properties.Resources.avatare_girl_1;
            this.avatarBox5.Location = new System.Drawing.Point(119, 143);
            this.avatarBox5.Name = "avatarBox5";
            this.avatarBox5.Size = new System.Drawing.Size(100, 124);
            this.avatarBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.avatarBox5.TabIndex = 4;
            this.avatarBox5.TabStop = false;
            this.avatarBox5.Click += new System.EventHandler(this.changeAvatar);
            // 
            // avatarBox6
            // 
            this.avatarBox6.Image = global::Spiel_Des_Lebens.Properties.Resources.avatare_girl_2;
            this.avatarBox6.Location = new System.Drawing.Point(225, 143);
            this.avatarBox6.Name = "avatarBox6";
            this.avatarBox6.Size = new System.Drawing.Size(100, 124);
            this.avatarBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.avatarBox6.TabIndex = 5;
            this.avatarBox6.TabStop = false;
            this.avatarBox6.Click += new System.EventHandler(this.changeAvatar);
            // 
            // btnHauptschule
            // 
            this.btnHauptschule.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnHauptschule.Location = new System.Drawing.Point(13, 273);
            this.btnHauptschule.Name = "btnHauptschule";
            this.btnHauptschule.Size = new System.Drawing.Size(152, 23);
            this.btnHauptschule.TabIndex = 6;
            this.btnHauptschule.Text = "Hauptschulabschluss";
            this.btnHauptschule.UseVisualStyleBackColor = true;
            this.btnHauptschule.Click += new System.EventHandler(this.changePath);
            // 
            // btnRealschule
            // 
            this.btnRealschule.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnRealschule.Location = new System.Drawing.Point(171, 273);
            this.btnRealschule.Name = "btnRealschule";
            this.btnRealschule.Size = new System.Drawing.Size(154, 23);
            this.btnRealschule.TabIndex = 7;
            this.btnRealschule.Text = "Realschulabschluss";
            this.btnRealschule.UseVisualStyleBackColor = true;
            this.btnRealschule.Click += new System.EventHandler(this.changePath);
            // 
            // btnFachabi
            // 
            this.btnFachabi.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnFachabi.Location = new System.Drawing.Point(13, 302);
            this.btnFachabi.Name = "btnFachabi";
            this.btnFachabi.Size = new System.Drawing.Size(152, 23);
            this.btnFachabi.TabIndex = 8;
            this.btnFachabi.Text = "Fachhochschulreife";
            this.btnFachabi.UseVisualStyleBackColor = true;
            this.btnFachabi.Click += new System.EventHandler(this.changePath);
            // 
            // btnAbi
            // 
            this.btnAbi.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAbi.Location = new System.Drawing.Point(171, 302);
            this.btnAbi.Name = "btnAbi";
            this.btnAbi.Size = new System.Drawing.Size(154, 23);
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
            this.label2.Location = new System.Drawing.Point(13, 333);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Bildungsweg";
            // 
            // dropDown_profession
            // 
            this.dropDown_profession.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropDown_profession.FormattingEnabled = true;
            this.dropDown_profession.Location = new System.Drawing.Point(97, 331);
            this.dropDown_profession.Name = "dropDown_profession";
            this.dropDown_profession.Size = new System.Drawing.Size(224, 21);
            this.dropDown_profession.TabIndex = 17;
            this.dropDown_profession.TextChanged += new System.EventHandler(this.education_path_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(13, 360);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 5, 7, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Karriereweg";
            // 
            // dropDown_path
            // 
            this.dropDown_path.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropDown_path.FormattingEnabled = true;
            this.dropDown_path.Location = new System.Drawing.Point(97, 358);
            this.dropDown_path.Name = "dropDown_path";
            this.dropDown_path.Size = new System.Drawing.Size(224, 21);
            this.dropDown_path.TabIndex = 19;
            this.dropDown_path.TextChanged += new System.EventHandler(this.profession_path_TextChanged);
            // 
            // lable_1
            // 
            this.lable_1.AutoSize = true;
            this.lable_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable_1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lable_1.Location = new System.Drawing.Point(13, 387);
            this.lable_1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.lable_1.Name = "lable_1";
            this.lable_1.Size = new System.Drawing.Size(39, 13);
            this.lable_1.TabIndex = 10;
            this.lable_1.Text = "Name";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(58, 385);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(267, 20);
            this.txt_name.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(13, 413);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 5, 10, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Alter";
            // 
            // txt_age
            // 
            this.txt_age.Location = new System.Drawing.Point(59, 411);
            this.txt_age.Name = "txt_age";
            this.txt_age.Size = new System.Drawing.Size(266, 20);
            this.txt_age.TabIndex = 14;
            this.txt_age.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_alter_KeyPress);
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.RosyBrown;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_back.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_back.Location = new System.Drawing.Point(55, 437);
            this.btn_back.Margin = new System.Windows.Forms.Padding(45, 3, 3, 3);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(132, 48);
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
            this.btn_next.Location = new System.Drawing.Point(195, 437);
            this.btn_next.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(132, 48);
            this.btn_next.TabIndex = 15;
            this.btn_next.Text = "Weiter";
            this.btn_next.UseVisualStyleBackColor = false;
            this.btn_next.Click += new System.EventHandler(this.open_next);
            // 
            // title
            // 
            this.title.AutoEllipsis = true;
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.title.Location = new System.Drawing.Point(100, 91);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(164, 22);
            this.title.TabIndex = 7;
            this.title.Text = "Spiel des Lebens";
            // 
            // lbl_userInfo
            // 
            this.lbl_userInfo.AutoSize = true;
            this.lbl_userInfo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_userInfo.Location = new System.Drawing.Point(13, 488);
            this.lbl_userInfo.Name = "lbl_userInfo";
            this.lbl_userInfo.Size = new System.Drawing.Size(119, 13);
            this.lbl_userInfo.TabIndex = 21;
            this.lbl_userInfo.Text = "Erstelle einen Charakter";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1357, 664);
            this.Controls.Add(this.fiction_panel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Layout_neues_Spiel);
            this.Name = "Form1";
            this.Text = "Spiel des Lebens";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.fiction_panel.ResumeLayout(false);
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
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label lbl_userInfo;
    }
}