using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace Spiel_Des_Lebens
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void createPlayer()
        {
            Player player = new Player(true, 21, "Maximilian Koch", Data.Path.DualStudy, Data.Profession.Stem);
        }

        public void filterEvents() //remove later
        {
            List<Event> filteredEvents = new List<Event>();

            int[,,] phases = { 
                { 
                    {1,2,3 } 
                } 
            };
            //Requirement requirement = new Requirement();
            //Event event = new Event(1,"Test1","Kill me", "pls",);
            //Events in filteredEvents kopieren

            foreach (Event e in filteredEvents)
            {
                bool phaseExists = false;
                for (int i = 0; i < e.requirements.timings.Length; i++)
                {
                    //if (e.requirements.timings[(int)edupath.GetPath(), (int)edupath.getProfession(), i] == edupath.getPhase().getCurrentPhase())
                    {
                        phaseExists = true;
                    }
                }
                if (phaseExists == false)
                {
                    filteredEvents.Remove(e);
                }
            }
        }
    }
}
