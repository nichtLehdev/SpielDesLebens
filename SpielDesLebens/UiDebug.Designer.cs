// @author: Maximilian Koch

// For Debugging only !!!

namespace SpielDesLebens
{
    partial class UiDebug
    {
#if DEBUG
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
            _textBox1 = new System.Windows.Forms.TextBox();
            _textBox3 = new System.Windows.Forms.TextBox();
            _textBox2 = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            _textBox1.Location = new System.Drawing.Point(-2, 0);
            _textBox1.Multiline = true;
            _textBox1.Name = "textBox1";
            _textBox1.Size = new System.Drawing.Size(231, 784);
            _textBox1.TabIndex = 1;
            // 
            // textBox3
            // 
            _textBox3.Location = new System.Drawing.Point(472, 0);
            _textBox3.Multiline = true;
            _textBox3.Name = "textBox3";
            _textBox3.Size = new System.Drawing.Size(1223, 784);
            _textBox3.TabIndex = 1;
            // 
            // textBox2
            // 
            _textBox2.Location = new System.Drawing.Point(235, 0);
            _textBox2.Multiline = true;
            _textBox2.Name = "textBox2";
            _textBox2.Size = new System.Drawing.Size(231, 784);
            _textBox2.TabIndex = 1;
            // 
            // Form
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1695, 783);
            Controls.Add(_textBox2);
            Controls.Add(_textBox3);
            Controls.Add(_textBox1);
            Name = "Form";
            Text = "Form";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _textBox1;
        private System.Windows.Forms.TextBox _textBox3;
        private System.Windows.Forms.TextBox _textBox2;
#endif
    }
}