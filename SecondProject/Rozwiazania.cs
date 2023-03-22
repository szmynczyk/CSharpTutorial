namespace SecondProject
{
    internal class Rozwiazania
    {
        public static string Inicjaly(string Imie, string Nazwisko)
        {
            string czescImienia = Imie[0].ToString();
            string czescNazwiska = Nazwisko[0].ToString();
            string inicjaly;
            string[] gloski =
            {
                    "cz", "sz", "dz", "rz", "dż", "dź", "ch"
                };

            foreach (var gloska in gloski)
            {
                if (gloska == Imie.Substring(0, 2).ToLower())
                {
                    czescImienia = Imie.Substring(0, 2);
                    break;
                }
            }

            foreach (var gloska in gloski)
            {
                if (gloska == Nazwisko.Substring(0, 2).ToLower())
                {
                    czescNazwiska = Nazwisko.Substring(0, 2);
                    break;
                }
            }

            inicjaly = czescImienia + "." + czescNazwiska + ".";

            return inicjaly;
        }
    }
}
