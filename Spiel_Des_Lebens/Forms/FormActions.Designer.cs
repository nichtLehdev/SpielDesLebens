namespace Spiel_Des_Lebens.Forms
{
    partial class FormActions
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
            this.panelSchool = new System.Windows.Forms.Panel();
            this.lblSchool = new System.Windows.Forms.Label();
            this.pictureBoxBackground = new System.Windows.Forms.PictureBox();
            this.btnLoadEvent = new System.Windows.Forms.Button();
            this.panelSchool.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSchool
            // 
            this.panelSchool.BackgroundImage = global::Spiel_Des_Lebens.Properties.Resources.Schule1;
            this.panelSchool.Controls.Add(this.lblSchool);
            this.panelSchool.Location = new System.Drawing.Point(761, 311);
            this.panelSchool.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelSchool.Name = "panelSchool";
            this.panelSchool.Size = new System.Drawing.Size(260, 228);
            this.panelSchool.TabIndex = 1;
            this.panelSchool.Click += new System.EventHandler(this.panelSchool_Click);
            // 
            // lblSchool
            // 
            this.lblSchool.AutoSize = true;
            this.lblSchool.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.980198F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSchool.Location = new System.Drawing.Point(88, 16);
            this.lblSchool.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSchool.Name = "lblSchool";
            this.lblSchool.Size = new System.Drawing.Size(60, 20);
            this.lblSchool.TabIndex = 0;
            this.lblSchool.Text = "Schule";
            // 
            // pictureBoxBackground
            // 
            this.pictureBoxBackground.BackgroundImage = global::Spiel_Des_Lebens.Properties.Resources.Background;
            this.pictureBoxBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxBackground.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxBackground.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBoxBackground.Name = "pictureBoxBackground";
            this.pictureBoxBackground.Size = new System.Drawing.Size(1067, 554);
            this.pictureBoxBackground.TabIndex = 0;
            this.pictureBoxBackground.TabStop = false;
            // 
            // btnLoadEvent
            // 
            this.btnLoadEvent.Location = new System.Drawing.Point(231, 144);
            this.btnLoadEvent.Name = "btnLoadEvent";
            this.btnLoadEvent.Size = new System.Drawing.Size(131, 23);
            this.btnLoadEvent.TabIndex = 2;
            this.btnLoadEvent.Text = "Load Event";
            this.btnLoadEvent.UseVisualStyleBackColor = true;
            this.btnLoadEvent.Click += new System.EventHandler(this.btnLoadEvent_Click);
            // 
            // FormActions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnLoadEvent);
            this.Controls.Add(this.panelSchool);
            this.Controls.Add(this.pictureBoxBackground);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormActions";
            this.Text = "FormActions";
            this.panelSchool.ResumeLayout(false);
            this.panelSchool.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackground)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxBackground;
        private System.Windows.Forms.Panel panelSchool;
        private System.Windows.Forms.Label lblSchool;
        private System.Windows.Forms.Button btnLoadEvent;
    }
}