using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spiel_Des_Lebens
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var test = new Eventgenerator(EducationPath.Path.Training, EducationPath.Profession.Business);
            var test2 = "test";
        }
    }
}
