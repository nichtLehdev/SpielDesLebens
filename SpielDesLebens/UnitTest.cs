// @author: Kevin Kern

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace SpielDesLebens
{
    [TestClass]
    internal class UnitTest
    {
        private UiInterface UiInterface;


        [TestInitialize]
        public void SetUp()
        {
            UiInterface = new UiInterface(new Player(0, 21, "Maximilian Koch", Data.SPath.DualStudy, Data.SProfession.Stem, Data.SGraduation.AllgemeineHochschulreife), 3);

        }

        [TestMethod]
        public void CreatePlayer()
        {
            _ = new Player(0, 21, "Maximilian Koch", Data.SPath.DualStudy, Data.SProfession.Stem, Data.SGraduation.AllgemeineHochschulreife);
        }

        [TestMethod]
        public void GetEventText()
        {
            UiInterface.NextEvent();
            Console.WriteLine(UiInterface.GetEventText());
            Assert.AreNotEqual("", UiInterface.GetEventText());
            Assert.IsNotNull(UiInterface.GetEventText());

        }

    }
}