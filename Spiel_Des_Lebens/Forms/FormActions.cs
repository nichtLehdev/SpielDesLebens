using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spiel_Des_Lebens.Forms
{
    public partial class FormActions : Form
    {
        private UI_Interface ui_interface = new UI_Interface(true, 4, "Fritz", 0, 0);
        public FormActions()
        {
            InitializeComponent();
            pictureBoxBackground.Controls.Add(panelSchool);
            panelSchool.Location = new Point(605, 274);
            panelSchool.BackColor = Color.Transparent;
        }

        private void panelSchool_Click(object sender, EventArgs e)
        {
            FormSchool school = new FormSchool();
            school.TopLevel = false;
            school.FormBorderStyle = FormBorderStyle.None;
            school.Dock = DockStyle.Fill;
            this.Controls.Add(school);
            this.Tag = school;
            school.BringToFront();
            school.Show();
        }

        private void btnLoadEvent_Click(object sender, EventArgs e)
        {
            //ui_interface.getNextEvent();
            Console.WriteLine("sdfg");
            Console.WriteLine("Chosen Event: " + ui_interface.getNextEvent().ToString());
        }
    }
}
