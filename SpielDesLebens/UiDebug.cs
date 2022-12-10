// @author: Maximilian Koch

// For Debugging only !!!

using System;
using System.Collections.Generic;

namespace SpielDesLebens
{
    public partial class UiDebug : System.Windows.Forms.Form
    {
        public UiDebug()
        {
            InitializeComponent();
            ActionPrinter();
            EventPrinter();
            EventMatrix();
        }

        private void ActionPrinter()
        {
            ActionGenerator actiongenerator = new ActionGenerator();
            List<Action> actionsL = actiongenerator.GetActionsDebug();
            string actionsO = "ACTIONS (" + actionsL.Count + ") \r\n------------------------------------------------------------------------ \r\n \r\n";
            foreach (Action item in actionsL)
            {
                actionsO += item.GetId() + "\r\n";
                actionsO += item.GetTitle() + "\r\n \r\n";

                actionsO += "-------------------------------------------------------- \r\n \r\n";
            }

            _textBox1.Text = actionsO;

        }

        private void EventPrinter()
        {
            EducationPath eventsC = new EducationPath(Data.Path.Training, Data.Profession.Social);
            EventGenerator eventgenerator = new EventGenerator(eventsC);
            List<Event> eventsL = eventgenerator.LoadEventsDebug();
            string eventsO = "EVENTS (" + eventsL.Count + ") \r\n------------------------------------------------------------------------ \r\n \r\n";
            foreach (Event item in eventsL)
            {
                eventsO += item.GetId() + "\r\n";
                eventsO += item.GetTitle() + "\r\n \r\n \r\n";
                foreach (Timing timings in item.GetRequirements().GetTimings())
                {
                    eventsO += "path: ";
                    foreach (int path in timings.GetPath())
                    {
                        eventsO += path;
                        eventsO += " ";
                    }
                    eventsO += "\r\n";

                    eventsO += "profession: ";
                    foreach (int profession in timings.GetProfession())
                    {
                        eventsO += profession;
                        eventsO += " ";
                    }
                    eventsO += "\r\n";

                    eventsO += "phase: ";
                    foreach (int phase in timings.GetPhase())
                    {
                        eventsO += phase;
                        eventsO += " ";
                    }
                    eventsO += "\r\n";
                    eventsO += "\r\n";
                }
                eventsO += "-------------------------------------------------------- \r\n \r\n";
            }


            _textBox2.Text = eventsO;
        }

        private void EventMatrix()
        {

            int[,,] emA = new int[3, 5, 19];
            int sI = 0;
            int sJ = 0;
            int sK = 0;

            // Fill matrix with -1.
            for (int i = 0; i < emA.GetLength(0); i++)
            {
                for (int j = 0; j < emA.GetLength(1); j++)
                {
                    for (int k = 0; k < emA.GetLength(2); k++)
                    {
                        emA[i, j, k] = -1;
                    }
                }
            }


            for (int i = 0; i <= 2; i++)
            {
                for (int j = 0; j <= 4; j++)
                {
                    EducationPath emC = new EducationPath((Data.Path)i, (Data.Profession)j);
                    EventGenerator emEventgenerator = new EventGenerator(emC);

                    for (int k = 0; k <= ((int)((3 * 12) / Data.SPhaseL[i])); k++)
                    {
                        emEventgenerator.FilterEventsByPhaseDebug();
                        List<Event> emL = emEventgenerator.GetFilteredEventsPhase();
                        emA[i, j, k] = emL.Count;
                        emC.GetPhase().NextPhase();
                    }
                }
            }

            for (int i = 0; i < emA.GetLength(0); i++)
            {
                for (int j = 0; j < emA.GetLength(1); j++)
                {
                    for (int k = 0; k < emA.GetLength(2); k++)
                    {
                        if (emA[i, j, k] != -1 && emA[i, j, k] < emA[sI, sJ, sK])
                        {
                            sI = i;
                            sJ = j;
                            sK = k;
                        }
                    }
                }

            }

            string emO = "EVENT MATRIX \r\n---------------------------------------------------------------------------------- \r\n \r\nThe least events are in the path " + (Data.Path)sI + " (" + sI + "), with the profession " + (Data.Profession)sJ + " (" + sJ + ") in the phase " + sK + " with " + emA[sI, sJ, sK] + " events. \r\n \r\n \r\n";
            emO += "\t \t \t \t0 \t1 \t2 \t3 \t4 \t5 \t6 \t7  \t8 \t9 \t10 \t11 \t12 \t13 \t14 \t15 \t16 \t17 \t18 \r\n";

            for (int i = 0; i < emA.GetLength(0); i++)
            {


                for (int j = 0; j < emA.GetLength(1); j++)
                {

                    emO += +i + " " + (Data.Path)i + "\t";

                    if (i == 0 || i == 2)
                    {
                        emO += "\t";
                    }

                    emO += +j + " " + (Data.Profession)j + "\t";

                    if (j == 0 || j == 3 || j == 4)
                    {
                        emO += "\t";
                    }


                    for (int k = 0; k < emA.GetLength(2); k++)
                    {
                        emO += emA[i, j, k] + "\t";
                    }

                    emO += "\r\n";
                }

            }

            _textBox3.Text = emO;

        }





        private void RextBox1TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2TextChanged(object sender, EventArgs e)
        {

        }


    }
}





