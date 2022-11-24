using System;
using System.Windows.Forms;

namespace Spiel_Des_Lebens
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var carrer = new EducationPath(Data.Path.Training, Data.Profession.Social);
            var eventgenerator = new Eventgenerator(carrer);
            var test = eventgenerator.loadEvents();
            string output = "";
            foreach (var item in test)
            {
                output += item.id + "\r\n";
                foreach (var timings in item.requirements.timings)
                {
                    output += "path: ";
                    foreach (var path in timings.path)
                    {
                        output += path;
                        output += " ";
                    }
                    output += "\r\n";

                    output += "profession: ";
                    foreach (var profession in timings.profession)
                    {
                        output += profession;
                        output += " ";
                    }
                    output += "\r\n";

                    output += "phase: ";
                    foreach (var phase in timings.phase)
                    {
                        output += phase;
                        output += " ";
                    }
                    output += "\r\n";
                    output += "\r\n";


                }
            }

            textBox1.Text = output;

            output = "";
            var actionTest = new ActionGenerator().loadActions();
            foreach(Action action in actionTest)
            {
                output += action.id + "\r\n";
                Option o = action.result;
                output += o.id + "\r\n";
                foreach(StatParameter item in o.optionStat.getStats())
                {
                    output += item.getName() + ": " + item.getValue() + "\r\n";
                }
            }

            textBox2.Text = output;

        }
        
    }
}
