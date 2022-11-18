namespace Spiel_Des_Lebens
{
    internal static class Data
    {

        public enum Path { Training = 0, DualStudy = 1, Study = 2 };
        public enum Profession { Social = 0, Business = 1, Science = 2, Stem = 3, Civil = 4 };
        public enum StatType { mentalHealth, money, motivation, success };


        public static string[,] career = new string[3, 5] { { "Krankenpflege", "Industriekaufmann", "Pharmazeutisch Technische Assistenz", "Fachinformatiker", "Rechtanwaltsfachangestellter" },
                                                     {"Angewandte Gesundheits- und Pflegewissenschaften", "BWL", "Angewandte Physik", "Angewandtes Informatikstudium", "Steuerwesen"},
                                                     {"Medizinstudium", "BWL", "Physikstudium", "Informatikstudium", "Jurastudium"} };
        public static int[] phaseL = new int[3] { 2, 3, 3 };

    }
}
