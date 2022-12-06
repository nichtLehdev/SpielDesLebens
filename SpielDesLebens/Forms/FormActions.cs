using System;
using System.Drawing;
using System.Windows.Forms;

namespace SpielDesLebens.Forms
{
    internal partial class FormActions : Form
    {
        public FormActions()
        {
            InitializeComponent();
            pictureBoxBackground.Controls.Add(panelSchool);
            panelSchool.Location = new Point(605, 274);
            panelSchool.BackColor = Color.Transparent;
        }

        private void PanelSchoolClick(object sender, EventArgs e)
        {
            FormSchool school = new FormSchool
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };
            this.Controls.Add(school);
            this.Tag = school;
            school.BringToFront();
            school.Show();
        }

        private void BtnLoadEventClick(object sender, EventArgs e)
        {
            Console.WriteLine("sdfg");
        }
    }
}
