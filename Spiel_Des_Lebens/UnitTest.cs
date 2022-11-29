using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Spiel_Des_Lebens
{
    [TestClass]
    public class UnitTest
    {
        private UI_Interface UiInterface;


        [TestInitialize]
        public void SetUp()
        {
            this.UiInterface = new UI_Interface(true, 20, "Maximilian Koch", Data.Path.DualStudy, Data.Profession.Stem);

        }

        [TestMethod]
        public void createPlayer()
        {
            Player player = new Player(true, 21, "Maximilian Koch", Data.Path.DualStudy, Data.Profession.Stem);
        }

        [TestMethod]
        public void getEventText()
        {
            UiInterface.nextEvent();
            Console.WriteLine(UiInterface.getEventText());
            //Assert.AreNotEqual("", UiInterface.getEventText());
            Assert.IsNotNull(UiInterface.getEventText());
            
        }

    }
}