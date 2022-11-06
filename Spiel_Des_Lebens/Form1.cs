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
        }

        

        private void open_next(object sender, EventArgs e)
        {
            Form2 t = new Form2(txt_name.Text, txt_alter.Text, avatar);
            t.Show();
        }
    }
}
