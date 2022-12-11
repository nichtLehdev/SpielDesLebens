// @author: Joel Dag, Kevin Kern, Maximilian Koch
// General data class with all the enums and arrays, which are used at many points in the project.

namespace SpielDesLebens
{
    internal class Data
    {

        public enum Path { Training = 0, DualStudy = 1, Study = 2 };
        public enum Profession { Social = 0, Business = 1, Science = 2, Stem = 3, Civil = 4 };
        public enum StatType { mentalHealth = 0, money = 1, motivation = 2, success = 3 };
        // In german, because translation is not valid.
        public enum Graduation { Hauptschulabschluss = 0, Realschulabschluss = 1, Fachhochschulreife = 2, AllgemeineHochschulreife = 3 };


        public static string[,] SCareer = new string[3, 5] { { "Krankenpflege", "Industriekaufmann", "Pharmazeutisch Technische Assistenz", "Fachinformatiker", "Rechtanwaltsfachangestellter" },
                                                     {"Angewandte Gesundheits- und Pflegewissenschaften", "BWL", "Angewandte Physik", "Angewandtes Informatikstudium", "Steuerwesen"},
                                                     {"Medizinstudium", "BWL", "Physikstudium", "Informatikstudium", "Jurastudium"} };
        public static int[] SPhaseL = new int[3] { 2, 3, 3 };

        public static Stat[] SStatArray = new Stat[3] { new Stat(0, 25, -15, -45), new Stat(0, 50, -30, -45), new Stat(0, 0, -40, -45) };

        public static int SPrioFactor = 100;

        public static string filenameActions = "data//actions.json";
        public static string filenameEvents = "data//events.json";
        public static string filenameSavegames = "data//savegames//sg";

        // For Debugging only !!!
#if DEBUG
        public static void SetFilePathsDebug()
        {
            filenameActions = "..//..//..//data//actions.json";
            filenameEvents = "..//..//..//data//events.json";
            filenameSavegames = "..//..//..//data//savegames//sg";
        }
#endif

    }
}
