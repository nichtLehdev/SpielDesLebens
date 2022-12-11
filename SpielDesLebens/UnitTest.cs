// @author: Kevin Kern
// Class for unit tests.

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace SpielDesLebens
{
    [TestClass]
    internal class UnitTest
    {
        private UiInterface _uiInterface;


        [TestInitialize]
        public void SetUp()
        {
            _uiInterface = new UiInterface(new Player(0, 21, "Maximilian Koch", Data.Path.DualStudy, Data.Profession.Stem, Data.Graduation.AllgemeineHochschulreife), 3);

        }

        [TestMethod]
        public void CreatePlayer()
        {
            _ = new Player(0, 21, "Maximilian Koch", Data.Path.DualStudy, Data.Profession.Stem, Data.Graduation.AllgemeineHochschulreife);
        }

        [TestMethod]
        public void GetEventText()
        {
            _uiInterface.NextEvent();
            Console.WriteLine(_uiInterface.GetEventText());
            Assert.AreNotEqual("", _uiInterface.GetEventText());
            Assert.IsNotNull(_uiInterface.GetEventText());

        }

    }
}