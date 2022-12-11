// @author: Joel Dag, Liz Wellhausen

namespace SpielDesLebens
{
   partial class UiMenu
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
            this._errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this._fictionTxtBox = new System.Windows.Forms.RichTextBox();
            this._fictionPanel = new System.Windows.Forms.Panel();
            this._acceptFictBtn = new System.Windows.Forms.Button();
            this._panel1 = new System.Windows.Forms.Panel();
            this._title = new System.Windows.Forms.Label();
            this._panel2 = new System.Windows.Forms.Panel();
            this._buttonMini3 = new System.Windows.Forms.Button();
            this._buttonMini2 = new System.Windows.Forms.Button();
            this._buttonMini1 = new System.Windows.Forms.Button();
            this._slotBtn1 = new System.Windows.Forms.Button();
            this._slotBtn2 = new System.Windows.Forms.Button();
            this._slotBtn3 = new System.Windows.Forms.Button();
            this._layouNewGame = new System.Windows.Forms.FlowLayoutPanel();
            this._avatarBox1 = new System.Windows.Forms.PictureBox();
            this._avatarBox2 = new System.Windows.Forms.PictureBox();
            this._avatarBox3 = new System.Windows.Forms.PictureBox();
            this._avatarBox4 = new System.Windows.Forms.PictureBox();
            this._avatarBox5 = new System.Windows.Forms.PictureBox();
            this._avatarBox6 = new System.Windows.Forms.PictureBox();
            this._btnHauptschule = new System.Windows.Forms.Button();
            this._btnRealschule = new System.Windows.Forms.Button();
            this._btnFachAbi = new System.Windows.Forms.Button();
            this._btnAbi = new System.Windows.Forms.Button();
            this._label2 = new System.Windows.Forms.Label();
            this._dropDownProfession = new System.Windows.Forms.ComboBox();
            this._label3 = new System.Windows.Forms.Label();
            this._dropDownPath = new System.Windows.Forms.ComboBox();
            this._lable4 = new System.Windows.Forms.Label();
            this._txtName = new System.Windows.Forms.TextBox();
            this._label1 = new System.Windows.Forms.Label();
            this._txtAge = new System.Windows.Forms.TextBox();
            this._btnBack = new System.Windows.Forms.Button();
            this._btnNext = new System.Windows.Forms.Button();
            this._lblUserInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._errorProvider1)).BeginInit();
            this._fictionPanel.SuspendLayout();
            this._panel1.SuspendLayout();
            this._panel2.SuspendLayout();
            this._layouNewGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._avatarBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._avatarBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._avatarBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._avatarBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._avatarBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._avatarBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // _errorProvider1
            // 
            this._errorProvider1.ContainerControl = this;
            // 
            // _fictionTxtBox
            // 
            this._errorProvider1.SetIconAlignment(this._fictionTxtBox, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this._fictionTxtBox.Location = new System.Drawing.Point(65, 95);
            this._fictionTxtBox.Name = "_fictionTxtBox";
            this._fictionTxtBox.ReadOnly = true;
            this._fictionTxtBox.Size = new System.Drawing.Size(209, 159);
            this._fictionTxtBox.TabIndex = 0;
            this._fictionTxtBox.Text = "\nDies ist ein rein fiktives Spiel. Alle Namen, Charaktere, Geschichten und Events" +
    " sind fiktiv.";
            // 
            // _fictionPanel
            // 
            this._fictionPanel.BackgroundImage = global::SpielDesLebens.Properties.Resources.redBlack;
            this._fictionPanel.Controls.Add(this._acceptFictBtn);
            this._fictionPanel.Controls.Add(this._fictionTxtBox);
            this._fictionPanel.Location = new System.Drawing.Point(504, 31);
            this._fictionPanel.Name = "_fictionPanel";
            this._fictionPanel.Size = new System.Drawing.Size(343, 511);
            this._fictionPanel.TabIndex = 4;
            // 
            // _acceptFictBtn
            // 
            this._acceptFictBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this._acceptFictBtn.Location = new System.Drawing.Point(65, 352);
            this._acceptFictBtn.Margin = new System.Windows.Forms.Padding(2);
            this._acceptFictBtn.Name = "_acceptFictBtn";
            this._acceptFictBtn.Size = new System.Drawing.Size(209, 19);
            this._acceptFictBtn.TabIndex = 1;
            this._acceptFictBtn.Text = "Vestanden";
            this._acceptFictBtn.UseVisualStyleBackColor = true;
            this._acceptFictBtn.Click += new System.EventHandler(this.AcceptFictBtnClick);
            // 
            // _panel1
            // 
            this._panel1.BackColor = System.Drawing.Color.Brown;
            this._panel1.BackgroundImage = global::SpielDesLebens.Properties.Resources.redBlack;
            this._panel1.Controls.Add(this._title);
            this._panel1.Controls.Add(this._panel2);
            this._panel1.Controls.Add(this._slotBtn1);
            this._panel1.Controls.Add(this._slotBtn2);
            this._panel1.Controls.Add(this._slotBtn3);
            this._panel1.Location = new System.Drawing.Point(504, 31);
            this._panel1.Name = "_panel1";
            this._panel1.Size = new System.Drawing.Size(343, 511);
            this._panel1.TabIndex = 1;
            // 
            // _title
            // 
            this._title.AutoEllipsis = true;
            this._title.AutoSize = true;
            this._title.BackColor = System.Drawing.Color.Transparent;
            this._title.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._title.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this._title.Location = new System.Drawing.Point(100, 58);
            this._title.Name = "_title";
            this._title.Size = new System.Drawing.Size(164, 22);
            this._title.TabIndex = 7;
            this._title.Text = "Spiel des Lebens";
            // 
            // _panel2
            // 
            this._panel2.BackgroundImage = global::SpielDesLebens.Properties.Resources.redBlack;
            this._panel2.Controls.Add(this._buttonMini3);
            this._panel2.Controls.Add(this._buttonMini2);
            this._panel2.Controls.Add(this._buttonMini1);
            this._panel2.Location = new System.Drawing.Point(45, 170);
            this._panel2.Margin = new System.Windows.Forms.Padding(2);
            this._panel2.Name = "_panel2";
            this._panel2.Size = new System.Drawing.Size(262, 175);
            this._panel2.TabIndex = 6;
            this._panel2.Visible = false;
            // 
            // _buttonMini3
            // 
            this._buttonMini3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this._buttonMini3.Location = new System.Drawing.Point(35, 130);
            this._buttonMini3.Margin = new System.Windows.Forms.Padding(2);
            this._buttonMini3.Name = "_buttonMini3";
            this._buttonMini3.Size = new System.Drawing.Size(186, 19);
            this._buttonMini3.TabIndex = 3;
            this._buttonMini3.Text = "Zurück";
            this._buttonMini3.UseVisualStyleBackColor = true;
            this._buttonMini3.Visible = false;
            this._buttonMini3.Click += new System.EventHandler(this.CloseOptionSpielStart);
            // 
            // _buttonMini2
            // 
            this._buttonMini2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this._buttonMini2.Location = new System.Drawing.Point(35, 80);
            this._buttonMini2.Margin = new System.Windows.Forms.Padding(2);
            this._buttonMini2.Name = "_buttonMini2";
            this._buttonMini2.Size = new System.Drawing.Size(186, 19);
            this._buttonMini2.TabIndex = 2;
            this._buttonMini2.Text = "Löschen";
            this._buttonMini2.UseVisualStyleBackColor = true;
            this._buttonMini2.Visible = false;
            this._buttonMini2.Click += new System.EventHandler(this.ButtonMini2Click);
            // 
            // _buttonMini1
            // 
            this._buttonMini1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this._buttonMini1.Location = new System.Drawing.Point(35, 33);
            this._buttonMini1.Margin = new System.Windows.Forms.Padding(2);
            this._buttonMini1.Name = "_buttonMini1";
            this._buttonMini1.Size = new System.Drawing.Size(186, 19);
            this._buttonMini1.TabIndex = 1;
            this._buttonMini1.Text = "Laden";
            this._buttonMini1.UseVisualStyleBackColor = true;
            this._buttonMini1.Visible = false;
            this._buttonMini1.Click += new System.EventHandler(this.LoadSaveGame);
            // 
            // _slotBtn1
            // 
            this._slotBtn1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this._slotBtn1.Location = new System.Drawing.Point(65, 144);
            this._slotBtn1.Name = "_slotBtn1";
            this._slotBtn1.Size = new System.Drawing.Size(224, 23);
            this._slotBtn1.TabIndex = 0;
            this._slotBtn1.Text = "Spielstand Test";
            this._slotBtn1.UseVisualStyleBackColor = true;
            this._slotBtn1.Click += new System.EventHandler(this.NewGameOpen);
            // 
            // _slotBtn2
            // 
            this._slotBtn2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this._slotBtn2.Location = new System.Drawing.Point(65, 244);
            this._slotBtn2.Name = "_slotBtn2";
            this._slotBtn2.Size = new System.Drawing.Size(224, 23);
            this._slotBtn2.TabIndex = 3;
            this._slotBtn2.Text = "Neues Spiel";
            this._slotBtn2.UseVisualStyleBackColor = true;
            this._slotBtn2.Click += new System.EventHandler(this.NewGameOpen);
            // 
            // _slotBtn3
            // 
            this._slotBtn3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this._slotBtn3.Location = new System.Drawing.Point(65, 350);
            this._slotBtn3.Name = "_slotBtn3";
            this._slotBtn3.Size = new System.Drawing.Size(224, 23);
            this._slotBtn3.TabIndex = 2;
            this._slotBtn3.Text = "Neues Spiel";
            this._slotBtn3.UseVisualStyleBackColor = true;
            this._slotBtn3.Click += new System.EventHandler(this.NewGameOpen);
            // 
            // _layouNewGame
            // 
            this._layouNewGame.BackColor = System.Drawing.Color.Transparent;
            this._layouNewGame.BackgroundImage = global::SpielDesLebens.Properties.Resources.redBlack;
            this._layouNewGame.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._layouNewGame.Controls.Add(this._avatarBox1);
            this._layouNewGame.Controls.Add(this._avatarBox2);
            this._layouNewGame.Controls.Add(this._avatarBox3);
            this._layouNewGame.Controls.Add(this._avatarBox4);
            this._layouNewGame.Controls.Add(this._avatarBox5);
            this._layouNewGame.Controls.Add(this._avatarBox6);
            this._layouNewGame.Controls.Add(this._btnHauptschule);
            this._layouNewGame.Controls.Add(this._btnRealschule);
            this._layouNewGame.Controls.Add(this._btnFachAbi);
            this._layouNewGame.Controls.Add(this._btnAbi);
            this._layouNewGame.Controls.Add(this._label2);
            this._layouNewGame.Controls.Add(this._dropDownProfession);
            this._layouNewGame.Controls.Add(this._label3);
            this._layouNewGame.Controls.Add(this._dropDownPath);
            this._layouNewGame.Controls.Add(this._lable4);
            this._layouNewGame.Controls.Add(this._txtName);
            this._layouNewGame.Controls.Add(this._label1);
            this._layouNewGame.Controls.Add(this._txtAge);
            this._layouNewGame.Controls.Add(this._btnBack);
            this._layouNewGame.Controls.Add(this._btnNext);
            this._layouNewGame.Controls.Add(this._lblUserInfo);
            this._layouNewGame.ForeColor = System.Drawing.SystemColors.ControlText;
            this._layouNewGame.Location = new System.Drawing.Point(504, 31);
            this._layouNewGame.Name = "_layouNewGame";
            this._layouNewGame.Padding = new System.Windows.Forms.Padding(10);
            this._layouNewGame.Size = new System.Drawing.Size(343, 511);
            this._layouNewGame.TabIndex = 0;
            this._layouNewGame.Visible = false;
            // 
            // _avatarBox1
            // 
            this._avatarBox1.ErrorImage = global::SpielDesLebens.Properties.Resources.avatarBoy0;
            this._avatarBox1.Image = global::SpielDesLebens.Properties.Resources.avatarBoy0;
            this._avatarBox1.Location = new System.Drawing.Point(13, 13);
            this._avatarBox1.Name = "_avatarBox1";
            this._avatarBox1.Size = new System.Drawing.Size(100, 124);
            this._avatarBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this._avatarBox1.TabIndex = 0;
            this._avatarBox1.TabStop = false;
            this._avatarBox1.Click += new System.EventHandler(this.ChangeAvatar);
            // 
            // _avatarBox2
            // 
            this._avatarBox2.Image = global::SpielDesLebens.Properties.Resources.avatarBoy1;
            this._avatarBox2.Location = new System.Drawing.Point(119, 13);
            this._avatarBox2.Name = "_avatarBox2";
            this._avatarBox2.Size = new System.Drawing.Size(100, 124);
            this._avatarBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this._avatarBox2.TabIndex = 1;
            this._avatarBox2.TabStop = false;
            this._avatarBox2.Click += new System.EventHandler(this.ChangeAvatar);
            // 
            // _avatarBox3
            // 
            this._avatarBox3.ErrorImage = null;
            this._avatarBox3.Image = global::SpielDesLebens.Properties.Resources.avatarBoy2;
            this._avatarBox3.InitialImage = null;
            this._avatarBox3.Location = new System.Drawing.Point(225, 13);
            this._avatarBox3.Name = "_avatarBox3";
            this._avatarBox3.Size = new System.Drawing.Size(100, 124);
            this._avatarBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this._avatarBox3.TabIndex = 2;
            this._avatarBox3.TabStop = false;
            this._avatarBox3.Click += new System.EventHandler(this.ChangeAvatar);
            // 
            // _avatarBox4
            // 
            this._avatarBox4.Image = global::SpielDesLebens.Properties.Resources.avatarGirl0;
            this._avatarBox4.Location = new System.Drawing.Point(13, 143);
            this._avatarBox4.Name = "_avatarBox4";
            this._avatarBox4.Size = new System.Drawing.Size(100, 124);
            this._avatarBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this._avatarBox4.TabIndex = 3;
            this._avatarBox4.TabStop = false;
            this._avatarBox4.Click += new System.EventHandler(this.ChangeAvatar);
            // 
            // _avatarBox5
            // 
            this._avatarBox5.Image = global::SpielDesLebens.Properties.Resources.avatarGirl1;
            this._avatarBox5.Location = new System.Drawing.Point(119, 143);
            this._avatarBox5.Name = "_avatarBox5";
            this._avatarBox5.Size = new System.Drawing.Size(100, 124);
            this._avatarBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this._avatarBox5.TabIndex = 4;
            this._avatarBox5.TabStop = false;
            this._avatarBox5.Click += new System.EventHandler(this.ChangeAvatar);
            // 
            // _avatarBox6
            // 
            this._avatarBox6.Image = global::SpielDesLebens.Properties.Resources.avatarGirl2;
            this._avatarBox6.Location = new System.Drawing.Point(225, 143);
            this._avatarBox6.Name = "_avatarBox6";
            this._avatarBox6.Size = new System.Drawing.Size(100, 124);
            this._avatarBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this._avatarBox6.TabIndex = 5;
            this._avatarBox6.TabStop = false;
            this._avatarBox6.Click += new System.EventHandler(this.ChangeAvatar);
            // 
            // _btnHauptschule
            // 
            this._btnHauptschule.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this._btnHauptschule.Location = new System.Drawing.Point(13, 273);
            this._btnHauptschule.Name = "_btnHauptschule";
            this._btnHauptschule.Size = new System.Drawing.Size(152, 23);
            this._btnHauptschule.TabIndex = 6;
            this._btnHauptschule.Text = "Hauptschulabschluss";
            this._btnHauptschule.UseVisualStyleBackColor = true;
            this._btnHauptschule.Click += new System.EventHandler(this.ChangePath);
            // 
            // _btnRealschule
            // 
            this._btnRealschule.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this._btnRealschule.Location = new System.Drawing.Point(171, 273);
            this._btnRealschule.Name = "_btnRealschule";
            this._btnRealschule.Size = new System.Drawing.Size(154, 23);
            this._btnRealschule.TabIndex = 7;
            this._btnRealschule.Text = "Realschulabschluss";
            this._btnRealschule.UseVisualStyleBackColor = true;
            this._btnRealschule.Click += new System.EventHandler(this.ChangePath);
            // 
            // _btnFachAbi
            // 
            this._btnFachAbi.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this._btnFachAbi.Location = new System.Drawing.Point(13, 302);
            this._btnFachAbi.Name = "_btnFachAbi";
            this._btnFachAbi.Size = new System.Drawing.Size(152, 23);
            this._btnFachAbi.TabIndex = 8;
            this._btnFachAbi.Text = "Fachhochschulreife";
            this._btnFachAbi.UseVisualStyleBackColor = true;
            this._btnFachAbi.Click += new System.EventHandler(this.ChangePath);
            // 
            // _btnAbi
            // 
            this._btnAbi.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this._btnAbi.Location = new System.Drawing.Point(171, 302);
            this._btnAbi.Name = "_btnAbi";
            this._btnAbi.Size = new System.Drawing.Size(154, 23);
            this._btnAbi.TabIndex = 9;
            this._btnAbi.Text = "allg. Hochschulreife";
            this._btnAbi.UseVisualStyleBackColor = true;
            this._btnAbi.Click += new System.EventHandler(this.ChangePath);
            // 
            // _label2
            // 
            this._label2.AutoSize = true;
            this._label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this._label2.Location = new System.Drawing.Point(13, 333);
            this._label2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this._label2.Name = "_label2";
            this._label2.Size = new System.Drawing.Size(78, 13);
            this._label2.TabIndex = 18;
            this._label2.Text = "Bildungsweg";
            // 
            // _dropDownProfession
            // 
            this._dropDownProfession.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._dropDownProfession.FormattingEnabled = true;
            this._dropDownProfession.Location = new System.Drawing.Point(97, 331);
            this._dropDownProfession.Name = "_dropDownProfession";
            this._dropDownProfession.Size = new System.Drawing.Size(224, 21);
            this._dropDownProfession.TabIndex = 17;
            this._dropDownProfession.TextChanged += new System.EventHandler(this.EducationPathTextChanged);
            // 
            // _label3
            // 
            this._label3.AutoSize = true;
            this._label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this._label3.Location = new System.Drawing.Point(13, 360);
            this._label3.Margin = new System.Windows.Forms.Padding(3, 5, 7, 0);
            this._label3.Name = "_label3";
            this._label3.Size = new System.Drawing.Size(74, 13);
            this._label3.TabIndex = 20;
            this._label3.Text = "Karriereweg";
            // 
            // _dropDownPath
            // 
            this._dropDownPath.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._dropDownPath.FormattingEnabled = true;
            this._dropDownPath.Location = new System.Drawing.Point(97, 358);
            this._dropDownPath.Name = "_dropDownPath";
            this._dropDownPath.Size = new System.Drawing.Size(224, 21);
            this._dropDownPath.TabIndex = 19;
            this._dropDownPath.TextChanged += new System.EventHandler(this.ProfessionPathTextChanged);
            // 
            // _lable4
            // 
            this._lable4.AutoSize = true;
            this._lable4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lable4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this._lable4.Location = new System.Drawing.Point(13, 387);
            this._lable4.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this._lable4.Name = "_lable4";
            this._lable4.Size = new System.Drawing.Size(39, 13);
            this._lable4.TabIndex = 10;
            this._lable4.Text = "Name";
            // 
            // _txtName
            // 
            this._txtName.Location = new System.Drawing.Point(58, 385);
            this._txtName.Name = "_txtName";
            this._txtName.Size = new System.Drawing.Size(267, 20);
            this._txtName.TabIndex = 11;
            // 
            // _label1
            // 
            this._label1.AutoSize = true;
            this._label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this._label1.Location = new System.Drawing.Point(13, 413);
            this._label1.Margin = new System.Windows.Forms.Padding(3, 5, 10, 0);
            this._label1.Name = "_label1";
            this._label1.Size = new System.Drawing.Size(33, 13);
            this._label1.TabIndex = 13;
            this._label1.Text = "Alter";
            // 
            // _txtAge
            // 
            this._txtAge.Location = new System.Drawing.Point(59, 411);
            this._txtAge.Name = "_txtAge";
            this._txtAge.Size = new System.Drawing.Size(266, 20);
            this._txtAge.TabIndex = 14;
            this._txtAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtOldKeyPress);
            // 
            // _btnBack
            // 
            this._btnBack.BackColor = System.Drawing.Color.RosyBrown;
            this._btnBack.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this._btnBack.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this._btnBack.Location = new System.Drawing.Point(55, 437);
            this._btnBack.Margin = new System.Windows.Forms.Padding(45, 3, 3, 3);
            this._btnBack.Name = "_btnBack";
            this._btnBack.Size = new System.Drawing.Size(132, 48);
            this._btnBack.TabIndex = 16;
            this._btnBack.Text = "Zurück";
            this._btnBack.UseVisualStyleBackColor = false;
            this._btnBack.Click += new System.EventHandler(this.OpenMainMenu);
            // 
            // _btnNext
            // 
            this._btnNext.BackColor = System.Drawing.Color.RosyBrown;
            this._btnNext.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this._btnNext.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this._btnNext.Location = new System.Drawing.Point(195, 437);
            this._btnNext.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this._btnNext.Name = "_btnNext";
            this._btnNext.Size = new System.Drawing.Size(132, 48);
            this._btnNext.TabIndex = 15;
            this._btnNext.Text = "Weiter";
            this._btnNext.UseVisualStyleBackColor = false;
            this._btnNext.Click += new System.EventHandler(this.OpenNewGame);
            // 
            // _lblUserInfo
            // 
            this._lblUserInfo.AutoSize = true;
            this._lblUserInfo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this._lblUserInfo.Location = new System.Drawing.Point(13, 488);
            this._lblUserInfo.Name = "_lblUserInfo";
            this._lblUserInfo.Size = new System.Drawing.Size(119, 13);
            this._lblUserInfo.TabIndex = 21;
            this._lblUserInfo.Text = "Erstelle einen Charakter";
            // 
            // UiMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1357, 664);
            this.Controls.Add(this._fictionPanel);
            this.Controls.Add(this._panel1);
            this.Controls.Add(this._layouNewGame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UiMenu";
            this.Text = "Spiel des Lebens";
            ((System.ComponentModel.ISupportInitialize)(this._errorProvider1)).EndInit();
            this._fictionPanel.ResumeLayout(false);
            this._panel1.ResumeLayout(false);
            this._panel1.PerformLayout();
            this._panel2.ResumeLayout(false);
            this._layouNewGame.ResumeLayout(false);
            this._layouNewGame.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._avatarBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._avatarBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._avatarBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._avatarBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._avatarBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._avatarBox6)).EndInit();
            this.ResumeLayout(false);

      }

      #endregion
      private System.Windows.Forms.PictureBox _avatarBox1;
      private System.Windows.Forms.PictureBox _avatarBox2;
      private System.Windows.Forms.PictureBox _avatarBox3;
      private System.Windows.Forms.Button _btnHauptschule;
      private System.Windows.Forms.Button _btnRealschule;
      private System.Windows.Forms.Button _btnFachAbi;
      private System.Windows.Forms.Button _btnAbi;
      private System.Windows.Forms.Label _lable4;
      private System.Windows.Forms.TextBox _txtName;
      private System.Windows.Forms.Label _label1;
      private System.Windows.Forms.TextBox _txtAge;
      private System.Windows.Forms.Button _btnNext;
      private System.Windows.Forms.FlowLayoutPanel _layouNewGame;
      private System.Windows.Forms.Panel _panel1;
      private System.Windows.Forms.Button _slotBtn1;
      private System.Windows.Forms.Button _slotBtn2;
      private System.Windows.Forms.Button _slotBtn3;
      private System.Windows.Forms.Button _btnBack;
      private System.Windows.Forms.ErrorProvider _errorProvider1;
      private System.Windows.Forms.Panel _panel2;
      private System.Windows.Forms.Button _buttonMini3;
      private System.Windows.Forms.Button _buttonMini2;
      private System.Windows.Forms.Button _buttonMini1;
      private System.Windows.Forms.Panel _fictionPanel;
      private System.Windows.Forms.RichTextBox _fictionTxtBox;
      private System.Windows.Forms.Button _acceptFictBtn;
      private System.Windows.Forms.PictureBox _avatarBox4;
      private System.Windows.Forms.PictureBox _avatarBox5;
      private System.Windows.Forms.PictureBox _avatarBox6;
      private System.Windows.Forms.Label _label2;
      private System.Windows.Forms.ComboBox _dropDownProfession;
      private System.Windows.Forms.Label _label3;
      private System.Windows.Forms.ComboBox _dropDownPath;
      private System.Windows.Forms.Label _title;
      private System.Windows.Forms.Label _lblUserInfo;
    }
}