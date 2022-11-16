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
    }
}