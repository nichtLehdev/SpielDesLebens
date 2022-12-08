// @author: Joel Dag, Kevin Kern, Maximilian Koch

namespace SpielDesLebens
{
    internal static class Data
    {

        public enum Path { Training = 0, DualStudy = 1, Study = 2 };
        public enum Profession { Social = 0, Business = 1, Science = 2, Stem = 3, Civil = 4 };
        public enum StatType { mentalHealth = 0, money = 1, motivation = 2, success = 3 };
        public enum Graduation { Hauptschulabschluss = 0, Realschulabschluss = 1, Fachhochschulreife = 2, AllgemeineHochschulreife = 3 }; // in german, because translation is not valid


        public static string[,] Career = new string[3, 5] { { "Krankenpflege", "Industriekaufmann", "Pharmazeutisch Technische Assistenz", "Fachinformatiker", "Rechtanwaltsfachangestellter" },
                                                     {"Angewandte Gesundheits- und Pflegewissenschaften", "BWL", "Angewandte Physik", "Angewandtes Informatikstudium", "Steuerwesen"},
                                                     {"Medizinstudium", "BWL", "Physikstudium", "Informatikstudium", "Jurastudium"} };
        public static int[] PhaseL = new int[3] { 2, 3, 3 };

        public static Stat[] StatArray = new Stat[3] { new Stat(0, 25, -15, -45), new Stat(0, 50, -30, -45), new Stat(0, 0, -40, -45) };

    }
}
