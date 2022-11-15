using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
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


        [TestMethod]
        public void filterEvents() //remove later
        {
            //EducationPath edupath= new EducationPath();
            List<Event> filteredEvents = new List<Event>();

            int[,,] phases = { 
                {    {0,1,2 } },            //Paths
                {    {1,2,3 } },            //Profession
                {    {1,2,3 } },            //Phase
            };
            Stat statmin = new Stat(0, 0, 0, 0);
            Stat statmax = new Stat(100, 100, 100, 100);

            Requirement requirement = new Requirement(null, statmin, statmax );

            int[,,] phases2 = {
                {    {0,1,2 } },            //Paths
                {    {1,2,3 } },            //Profession
                {    {0,1,1 } },            //Phase
            };
          
            Requirement requirement2 = new Requirement(null, statmin, statmax);

            Option option = new Option("1", "1", "1", statmin);

            List<Option> listOption= new List<Option>();
            listOption.Add(option);

            
            Event event1 = new Event("1","Test1", "pls", 6 ,requirement, listOption);
            Event event2 = new Event("2", "Test1", "pls", 6, requirement2, listOption);

            filteredEvents.Add(event1);
            filteredEvents.Add(event2);

            //Events in filteredEvents kopieren
        }
    }
}