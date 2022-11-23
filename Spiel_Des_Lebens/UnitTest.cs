using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Spiel_Des_Lebens
{
    [TestClass]
    public class UnitTest
    {
        private UI_Interface UIinterface;


        [TestInitialize]
        public void SetUp()
        {

        }

        [TestMethod]
        public void createPlayer()
        {
            Player player = new Player(true, 21, "Maximilian Koch", Data.Path.DualStudy, Data.Profession.Stem);
        }

        [TestMethod]
        public void getEvents()
        {
            
        }

    }
}