using System;
using System.Drawing;
using System.Windows.Forms;

namespace Spiel_Des_Lebens.Forms
{
    internal partial class FormActions : Form
    {
        // private UiInterface ui_interface = new UiInterface(0, 4, "Fritz", 0, 0, 0);
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
