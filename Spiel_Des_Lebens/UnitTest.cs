using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Spiel_Des_Lebens
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void createPlayer()
        {
            Player player = new Player(true, 21, "Maximilian Koch", EducationPath.Path.DualStudy, EducationPath.Profession.Stem);
        }
    }
}
