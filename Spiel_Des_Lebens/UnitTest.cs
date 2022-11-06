using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Spiel_Des_Lebens;

namespace Spiel_Des_Lebens
{
    [TestClass]
    class UnitTest
    {
        [TestMethod]
        public void createPlayer()
        {
            Player player = new Player(true, 21, "Maximilian Koch", Player.Path.StudyDual);
            player.setDirection(EducationPath.Direction.Stem);
            Assert.Fail();
        }
    }
}
