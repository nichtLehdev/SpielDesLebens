using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Spiel_Des_Lebens
{
    [TestClass]
    public class UnitTest
    {
        private UiInterface UiInterface;


        [TestInitialize]
        public void SetUp()
        {
            this.UiInterface = new UiInterface(new Player(0, 21, "Maximilian Koch", Data.Path.DualStudy, Data.Profession.Stem, Data.Graduation.AllgemeineHochschulreife));

        }

        [TestMethod]
        public void createPlayer()
        {
            Player player = new Player(0, 21, "Maximilian Koch", Data.Path.DualStudy, Data.Profession.Stem, Data.Graduation.AllgemeineHochschulreife);
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