﻿using System;
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
            var test = new Eventgenerator(Data.Path.Training, Data.Profession.Business);
            List<loadEvent> test3 = test.events;
            textBox1.Text = test3[0].id;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
