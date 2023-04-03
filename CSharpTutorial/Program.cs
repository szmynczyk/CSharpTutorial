using System;
using System.Globalization;
using System.Threading;

namespace CSharpTutorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //komentarz na jedną linijkę
            /*komentarz
             * na 
             * wiele
             * linii
             */

            #region Klasa Console
            //Console.WriteLine("To jest nowa linia");
            //Console.WriteLine("TO jest druga linia");
            //Console.Write("To się pokaże");
            //Console.Write(" w tej samej linii");
            //Console.WriteLine("Podaj imię");
            //string name = Console.ReadLine();

            //Console.WriteLine($"Oryginalne imie: {name}");
            //var nameToUpper = name.ToUpper();
            //Console.WriteLine($"Imie z dużej: {nameToUpper}");

            //int singleCharacter = Console.Read();
            //Console.WriteLine(singleCharacter);
            //Console.WriteLine(userName);
            #endregion

            //int wiek = 33;

            //long dlugiWiek = wiek;
            //long duzaLiczba = 123456;
            //int duzyInt = (int)duzaLiczba;

            //int doubleToInt = (int)defaultFloatingPointNumber;
            //Console.WriteLine(doubleToInt);

            //int convertedNumber = Convert.ToInt32(defaultFloatingPointNumber);
            //defaultFloatingPointNumber = wiek;

            //Zadeklaruj liczbę zmiennoprzecinkową typu decimal i:
            //a) użyj konwersji jawnej do typu int (z ucięciem tego, co za rpzecinkiem)
            //b) użyj metody Convert.ToInt()

            //Console.WriteLine(convertedNumber);

            #region Bool
            //bool zmiennaDoSprawdzaniaTrueFalse;
            //bool prawda = true;
            //bool nieprawda = false;
            //int age = 15;

            //bool ifPersonIsAdult = age >= 18;
            //Console.WriteLine(ifPersonIsAdult);
            #endregion

            #region Char
            //char pojedynczyZnak;

            //char znakZwyczajny = ' ';
            //char znakSpecjalny = '\n';
            //char znakBackslash = '\\';
            //Console.WriteLine(znakBackslash);
            //Console.Write("Przykładowy tekst");
            //Console.Write("\n Kolejna linia");

            //char znakUnicode = 'a';
            //Console.WriteLine(znakUnicode);
            //int znak = 97;
            //char znakZLiczby = (char)znak;
            //Console.WriteLine($"ZNak z liczby {znakZLiczby}");

            //char literka = 'k';
            //int numerek = literka;
            //Console.WriteLine($"Numerek to {numerek}");
            //string aaa = "a";
            //int converted = int.Parse( aaa );

            //Console.WriteLine(znakUnicode);

            //Zadeklaruj zmienne typu char i wypisz
            //pojedynczy znak
            //znak specjalny
            //znak unicode
            //przekonwertowany int
            #endregion

            #region x++ i ++x
            //int x = 0;
            //Console.WriteLine($"X++: {x++}"); 
            //Console.WriteLine($"X {x}");

            //Console.WriteLine("-----------");

            //int y = 0;
            //Console.WriteLine($"++y: {++y}"); 
            //Console.WriteLine($"y: {y}");
            #endregion

            #region Operatory arytmetyczne
            //int number1 = 5;
            //int number2 = 2;

            //int result = number1 + number2;
            //int resultOdejmowanie = number1 - number2;
            //int resultDivision = number1 / number2;
            //int resulMultiplication = number1 * number2;
            //int resultResztaZDzielenia = number1 % number2;

            //Console.WriteLine($"Reszta z dzielenia: {number1 % number2}");

            //int result2 = number1 += 3;
            //int result3 = number1 + number1 + 3;

            //var resultNew = number2 / number1;

            //Console.WriteLine($"Dodanie do samego siebie {number2}");

            //Zadanie: Napisz program, który pobiera długości boków prostokąta
            //z konsoli (wpisane przez użytkownika) i oblicza pole i obwód tego prostokąta
            //int length1;
            //int length2;

            //Console.WriteLine("Podaj długość pierwszego boku:");
            //length1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Podaj długość drugiego boku:");
            //length2 = int.Parse(Console.ReadLine());

            //Console.WriteLine($"Pole prostokąta wynosi: {length1 * length2}");
            //Console.WriteLine($"Obwód prostokąta wynosi: {2 * length1 + 2 * length2}");
            #endregion

            #region if-else

            //int wiek = 59;

            //bool ifPersonIsAdult = true;

            //if (wiek >= 18 && wiek > 60)
            //{
            //    Console.WriteLine("Jesteś starym dziadem");
            //    int zmienna = 7;
            //}
            //else if (wiek >= 18 && wiek <= 60 && wiek > 45)
            //{
            //    Console.WriteLine("Jesteś w średnim wieku");
            //}
            //else
            //{
            //    Console.WriteLine("Nie jesteś pełnoletni");
            //}

            //var kolor = "zielony";
            //var drugiKolor = "czerwony";
            //var booleanResult = kolor == "zielony" || (kolor == "żółty" && drugiKolor == "niebieski");
            //var intResult = wiek >= 18 && wiek > 60;

            //if (kolor == "czerwony" && (drugiKolor == "czerwony" || kolor == "zielony"))
            //{
            //    Console.WriteLine("Wybrałeś radosny kolor");
            //}
            //else if (kolor == "brązowy")
            //{
            //    Console.WriteLine("Wybrałeś średni kolor");
            //}
            //else
            //{
            //    Console.WriteLine("Twój kolor jest smutny");
            //}

            #region Zadanie if z menu
            //Zadanie 1:
            //Napisz program, który pobierze od urzytkownika 2 liczby ZMIENNOPRZECINKOWE,
            //Wyświetli w konsoli menu z opcjami:
            //**********Wybierz operację na liczbach**********
            //1. Dodawanie
            //2. Odejmowanie
            //3. Mnożenie
            //4. Dzielenie
            //5. Reszta z dzielenia
            //6. Koniec programu
            //I po wybraniu opcji przez użytkownika wykona daną operację matematyczną
            //Dla operacji dzielenia i reszty z dzielenia sprawdź czy DRUGA liczba jest zerem.
            //Jeśli tak - wyświetl komunikat, że nie można dzielić przez zero
            //Dla każdej opcji wyświetl wynik wybranej operacji matematycznej w ładny sposób
            //np. "Wynik mnożenia liczb {liczba1} i {liczba2} to {wynik}
            //Jeśli użytkownik wybrał opcję, której nie ma w menu (np -1, 17 itp) wypisz na konsoli komunikat o błędnej opcji
            //*Sprawdź czy dla różnych typów zmiennoprzecinkowych dla tych samych wartości wyniki będą takie same
            #endregion

            #region Zadanie 1 Kacper S
            //Console.WriteLine($"Podaj pierwszą liczbę");
            //var liczbaA = int.Parse(Console.ReadLine());
            //Console.WriteLine($"Podaj drugą liczbę");
            //var liczbaB = int.Parse(Console.ReadLine());
            //for (int a = 0; a < 10; a++)
            //{
            //    Console.WriteLine($"\n Co chcesz dalej zrobić? Masz do wyboru \n 1 = Dodawanie \n 2 = Odejmowanie \n 3 = Mnożenie \n 4 = Dzielenie \n 5 = Reszta z dzielenia \n 6 = Koniec programu");
            //    var numer = int.Parse(Console.ReadLine());
            //    if (numer == 1)
            //    {
            //        Console.WriteLine($"\n Wynik dodawania {liczbaA} oraz {liczbaB} wynosi: {liczbaA + liczbaB}");
            //    }
            //    else if (numer == 2)
            //    {
            //        Console.WriteLine($"\n Wynik odejmowania {liczbaA} od {liczbaB} wynosi: {liczbaA - liczbaB}");
            //    }
            //    else if (numer == 3)
            //    {
            //        Console.WriteLine($"\n Wynik mnożenia {liczbaA} przez {liczbaB} wynosi: {liczbaA * liczbaB}");
            //    }
            //    else if (numer == 4)
            //    {
            //        if (liczbaB == 0)
            //        {
            //            Console.WriteLine("\n Pamiętaj cholero, nigdy nie dziel przez 0!");
            //        }

            //        Console.WriteLine($"\n Wynik dzielenia {liczbaA} przez {liczbaB} wynosi: {liczbaA / liczbaB}");
            //    }
            //    else if (numer == 5)
            //    {
            //        Console.WriteLine($"\n Reszta z dzielenia {liczbaA} przez {liczbaB} wynosi: {liczbaA % liczbaB}");
            //    }
            //    else if (numer < 1 || numer > 6)
            //    {
            //        Console.WriteLine("\n Umiesz czytać? Masz wybór od 1 do 6");
            //    }
            //    else if (numer == 6)
            //    {
            //        Console.WriteLine($"\n Kończymy na dzisiaj elo");
            //        return;
            //    }
            //}
            #endregion

            #region Zadanie 2 - operatory logiczne
            //Zadanie 2:
            //Napisz program, który pobiera od użytkownika nazwę Kraju i jego wiek
            //I na podstawie tych danych wypisuje info w konsoli, czy taka osoba
            //Może głosować i/lub pić alkohol
            //Dane do zadania:
            //Polska:
            //picie: 18   głosowanie: 18
            //ALgieria:
            //picie: nie wolno pić głosowanie: 18
            //USA:
            //picie: 18, głosowanie: 21
            //Włochy:
            //picie: 16, głosowanie: 18
            //Grecja:
            //picie: nie ma dolnego limitu picia głosowanie: 17
            //Egipt:
            //picie: 21   głosowanie: 18
            //Przykład: użytkownik wpisuje kraj: Włochy, wiek: 17, na konsoli powinno się wypisać:
            //"Jako mieszkaniec Włoszech w wieku 17 lat:"
            //Możesz pić alkohol (minimalny wiek żeby pić alkohol to 16 lat)
            //Nie możesz głosować (minimalny wiek do głosowania to 18 lat)
            //Jeśli użytkownik wprowadzi wiek <= 0 trzeba napisać, że wiek nie może być ujemny
            //Jeśli użytkownik wprowadzi nazwę kraju, którego nie ma na liście, wypisujemy, że nie ma takiego kraju

            #region podejscie 1
            //Console.WriteLine("Podaj nazwę kraju");
            //var countryName = Console.ReadLine();
            //Console.WriteLine("Podaj wiek");
            //var myAge = int.Parse(Console.ReadLine());
            //if (countryName != "Polska" && countryName != "Algieria" && countryName != "USA"
            //    && countryName != "Włochy" && countryName != "Grecja" && countryName != "Egipt")
            //{
            //    Console.WriteLine($"Nie ma danych dla takiego kraju: {countryName}");
            //}
            //else if (myAge <= 0)
            //{
            //    Console.WriteLine("Podałeś nieprawidłowy wiek (musi być większy niż 0)");
            //}
            //else
            //{
            //    Console.WriteLine($"Jako mieszkaniec kraju {countryName} w wieku {myAge} lat:");

            //    if (countryName == "Polska")
            //    {
            //        if (myAge < 18)
            //        {
            //            Console.WriteLine("Nie możesz pić alkoholu");
            //            Console.WriteLine("Nie możesz głosować");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Możesz pić alkohol");
            //            Console.WriteLine("Możesz głosować");
            //        }
            //    }
            //    else if (countryName == "Algieria")
            //    {
            //        Console.WriteLine("Nie możesz pić alkoholu");
            //        if (myAge < 18)
            //        {
            //            Console.WriteLine("Nie możesz głosować");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Możesz głosować");
            //        }
            //    }
            //    else if (countryName == "USA")
            //    {
            //        if (myAge < 18)
            //        {
            //            Console.WriteLine("Nie możesz pić alkoholu");
            //            Console.WriteLine("Nie możesz głosować");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Możesz pić alkohol");

            //        }

            //        if (myAge >= 21)
            //        {
            //            Console.WriteLine("Możesz głosować");
            //        }
            //    }
            //    else if (countryName == "Włochy")
            //    {
            //        if (myAge < 16)
            //        {
            //            Console.WriteLine("Nie możesz pić alkoholu");
            //            Console.WriteLine("Nie możesz głosować");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Możesz pić alkohol");

            //        }

            //        if (myAge >= 18)
            //        {
            //            Console.WriteLine("Możesz głosować");
            //        }
            //    }
            //    else if (countryName == "Grecja")
            //    {
            //        Console.WriteLine("Możesz pić alkohol");

            //        if (myAge < 17)
            //        {
            //            Console.WriteLine("Nie możesz głosować");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Możesz głosować");
            //        }
            //    }
            //    else if (countryName == "Egipt")
            //    {
            //        if (myAge < 16)
            //        {
            //            Console.WriteLine("Nie możesz pić alkoholu");
            //            Console.WriteLine("Nie możesz głosować");
            //        }
            //        else if (myAge >= 21)
            //        {
            //            Console.WriteLine("Możesz pić alkohol");
            //        }

            //        if (myAge >= 18)
            //        {
            //            Console.WriteLine("Możesz głosować");
            //        }
            //    }
            //}
            #endregion

            #endregion

            #endregion

            #region Switch

            //double opcja = double.Parse(Console.ReadLine());
            //switch (opcja)
            //{
            //    case 90.6:
            //    case 91: //dwie opcje po sobie bez break - dla obu takie samo zachowanie
            //        Console.WriteLine("Słuchasz RMF FM");
            //        break;
            //    case 97.7:
            //        Console.WriteLine("Słuchasz TOK FM");
            //        break;
            //    case 89.0:
            //        Console.WriteLine("Słuchasz Radia Maryja");
            //        break;
            //    case < 87.5: // wartość mniejsza niż 87.5
            //        Console.WriteLine("Częstotliwość poniżej zakresu fm w Polsce");
            //        break;
            //    case > 108:
            //        Console.WriteLine("Częstotliwość powyżej zakresu fm w Polsce");
            //        break;
            //    default: //domyślna opcja, niepasująca do wymienionych wyżej
            //        Console.WriteLine("Słuchasz szumu");
            //        break;
            //}

            //string kolor = "czerwony";

            //switch (kolor)
            //{
            //    case "czerwony":
            //        Console.WriteLine("Czerwona może być biedronka (albo komunista)");
            //        int zmienna = 3;
            //        break;
            //    case "zielony":
            //        Console.WriteLine("Zielona może być trawa");
            //        break;
            //    case "granatowy":
            //    case "błękitny":
            //        Console.WriteLine($"Kolor {kolor} może mieć niebo");
            //        break;
            //    default:
            //        Console.WriteLine($"Nie wiem co może być koloru {kolor}");
            //        break;
            //}

            //static void TellMeTheType(object x)
            //{
            //    switch (x)
            //    {
            //        case int i:
            //            Console.WriteLine("To wartość typu int!");
            //            break;
            //        case string s:
            //            Console.WriteLine(s.Length);  // można używać typowanej zmiennej s zamiast x  
            //            break;
            //        case bool b when b == true:     // pasuje kiedy b to true  
            //            Console.WriteLine("Prawda");
            //            break;
            //        case null:                       // można także dopasować wartość pustą  
            //            Console.WriteLine("pusto!");
            //            break;
            //    }
            //}

            //Zadanie:
            //Napisz zadanie z menu i operacjami matematycznymi z użyciem switch zamiast if
            #endregion

            #region Enum
            //string browser = Console.ReadLine();
            //if(browser == "Firefox")
            //{
            //    Console.WriteLine("Korzystasz z Firefoxa");
            //}
            //else
            //{
            //    Console.WriteLine("Nieznana przeglądarka");
            //}

            //Browser selectedBrowser = Browser.Firefox;

            //if(selectedBrowser == Browser.Firefox)
            //{
            //    Console.WriteLine("Wybrałeś Firefoxa");
            //}
            //if (selectedBrowser == Browser.Chromium)
            //{
            //    Console.WriteLine("Wybrałeś Chromium");
            //}
            //if (selectedBrowser == Browser.Safari)
            //{
            //    Console.WriteLine("Wybrałeś Safari");
            //}
            //if (selectedBrowser == Browser.IE)
            //{
            //    Console.WriteLine("Wybrałeś IE");
            //}

            //Console.WriteLine($"Przeglądarka CHromium ma przypisaną wartość {(int)Browser.Chromium}");

            //ulong duzaLiczba = (ulong)BigNumber.Miliard;
            //Browser.Firefox
            //ulong miliard = (ulong)BigNumber.Miliard;
            //Console.WriteLine($"Miliard to {miliard}");

            //Browser browser = (Browser)5;
            //Console.WriteLine($"Wybrana przeglądarka to {browser}");

            //int opcjaDzialania = int.Parse(Console.ReadLine());

            //if(opcjaDzialania == (int)DzialanieMatematyczne.Dodawanie)
            //{
            //}

            //Napisz enum do przechowywania kolorów
            //Napisz instrukcje if
            //jeśli kolor zielony to napisz trawa
            //jelsi kolor czerwony napisz biedronka
            //jesli kolor zolty napisz slonce


            #endregion

            #region String
            //string sampleText = "";
            //string pathToFile = @"C:\Users\mszymczyk\Desktop\Nauka programowania"; //traktowanie stringa "dosłownie"
            //Console.WriteLine(pathToFile);
            //int age = 27;
            //string kolor = "niebieskie";
            //string textWithAdditionalValue = $"Mam {age} lat i {kolor}";
            //Console.WriteLine(textWithAdditionalValue);
            //string textWithValueOld = string.Format("Mam {0} lat i {1} oczy", "10", "niebieskie");
            //Console.WriteLine(textWithValueOld);
            //string otherTextWithValue = "Mam " + age + " lat i " + kolor + " oczy";
            //Console.WriteLine(otherTextWithValue);

            //łączenie stringów:
            //string ala = "Ala";
            //string ma = "ma";
            //string kota = "kota";

            //var addingWithPlus = ala + ma + kota;
            //Console.WriteLine($"Dodawanie stringów plusem: {addingWithPlus}");
            //string addingWithConcat = string.Concat(ala, ma, kota);
            //Console.WriteLine($"Dodawanie stringów przez concat: {addingWithConcat}");
            //string joiningStrings = string.Join(" ", ala, ma, kota);
            //string joiningStrings = string.Join("_", ala, ma, kota);
            //Console.WriteLine($"Dodawanie stringów przez Join: {joiningStrings}");

            //string weirdString = " PoKeMoN gO ";
            //Console.WriteLine(weirdString);
            //Console.WriteLine($"Male literki: {weirdString.ToLower()}");
            //Console.WriteLine($"Duze literki: {weirdString.ToUpper()}");

            //Zadanie:
            //Napisz program przyjmujący nazwę przeglądarki użytkownika
            //I sprawdzający, czy wpisana nazwa to jedna z używanych przeglądarek (firefox, chrome, ie)
            //Niech sprawdzanie będzie niewrażliwe na wielkość znaków

            //zamiana znaków w stringu
            //string dateTimeWithDashes = "09-03-2023 10:59:23";
            //Console.WriteLine($"Oryginalna data: {dateTimeWithDashes}");
            //Console.WriteLine(dateTimeWithDashes.Replace('-', '.'));
            //string textToReplaceWords = "Ala ma kota a kot ma Alę";
            //Console.WriteLine($"Bez podmianki tekst wygląda tak: {textToReplaceWords}");
            //textToReplaceWords = textToReplaceWords.Replace("kot", "rak");

            //Console.WriteLine($"Gdy zmienimy \"kota\" na \"raka\" to text będzie wyglądał tak: " +
            //    $"{textToReplaceWords}");

            //sama metoda nie zmienia oryginalnego stringa         
            //Console.WriteLine($"Oryginalny text: {textToReplaceWords}");

            //trimowanie stringa
            //string weirdString = "  PoKeMoN gO ";
            //Console.WriteLine($"Oryginał: {weirdString}");
            //Console.WriteLine($"Wywalone spacje na początku: {weirdString.TrimStart()}");
            //Console.WriteLine($"Wywalone spacje na końcu: {weirdString.TrimEnd()}");
            //Console.WriteLine($"Wywalone spacje na początku i na końcu: {weirdString.Trim()}");

            //wycinanie kawałka stringa
            //string exampleText = "+48 666 555 444";
            //Console.WriteLine($"Numer telefonu to: {exampleText}");
            //Console.WriteLine($"Bez kierunkowego numer to: {exampleText.Substring(3)}");
            //Console.WriteLine($"Kierunkowy to: {exampleText.Substring(4, 3)}");

            //metoda ToString()
            //int liczba = 17;
            //var zmiennaJakoString = liczba.ToString();

            //Contains
            //var alaMaKotaString = "Ala ma kota";
            //var czyMaKota = alaMaKotaString.Contains("kot");
            //if (czyMaKota)
            //{
            //    Console.WriteLine("Jesteś starą panną");
            //}
            //else 
            //{
            //    Console.WriteLine("Jest dla Ciebie nadzieja");
            //}
            //Console.WriteLine("Słowo kot jest na pozycji: " + alaMaKotaString.IndexOf("kot"));

            //Console.WriteLine("Ala ma kota \r kot ma alę");
            //string stringFromConsole = "Ala ma kota";
            //stringFromConsole = stringFromConsole.ToLower();
            //stringFromConsole = stringFromConsole + 5;

            //string someText = "Jakieś zdanie z literą \u0041";
            //Console.WriteLine(stringFromConsole);

            //Zadanie - konwersja daty:
            //Napisz program, który przyjmie od użytkownika datę urodzenia w formacie YYYY-MM-DD
            //Zamieni ją na format DD.MM.YYYY
            //I sprawdzi, czy użytkownik ma dzisiaj urodziny porównując datę urodzin do dzisiejszej daty, 
            //np. 13.03.2023
            //Dodaj sprawdzenie, czy data jest poprawna czyli:
            //rok jest w zakresie 1900-2022
            //miesiąc jest w zakresie 1-12
            //dzień jest w zakresie 1-30

            #endregion

            #region Tablice
            //inicjalizowanie tablicy
            //pierwszy element tablicy ma index 0
            //ostatni element tablicy jednowymiarowej ma index Length - 1
            //int[] someIntArray = new int[3];
            //Console.WriteLine($"Pierwszy element tablicy ma wartość {someIntArray[0]}");
            //przed zainicjalizowaniem tablicy konkretnymi wartościami ma ona wartości domyślne dla wybranego typu
            //Console.WriteLine($"Element tablicy [1] to: {someIntArray[1]}");
            //someIntArray[0] = 1;
            //someIntArray[1] = 2;
            //someIntArray[2] = 3;
            //Console.WriteLine($"Czwarty element tablicy to: {someIntArray[3]}");
            //someIntArray = new int[4];

            //var anotherArray = new double[] { 1.5, 27.123, 3.14, 4.345 };
            //Console.WriteLine($"Rozmiar tablicy to {anotherArray.Length}");
            //string[] colorsArray = 
            //{ 
            //    "czerwony", 
            //    "zielony", 
            //    "niebieski", 
            //    "żółty", 
            //    "czarny" 
            //};
            //Console.WriteLine($"Pierwszy element tablicy to {colorsArray[0]}");
            //Console.WriteLine($"Rozmiar tablicy to: {colorsArray.Length}");
            //int lastArrayIndex = colorsArray.Length - 1;
            //Console.WriteLine($"Ostatni element tablicy z kolorami to {colorsArray[colorsArray.Length - 1]}");
            //Console.WriteLine($"Ostatni element tablicy to: {colorsArray[lastArrayIndex]}");
            //użycie indexu spoza zakresu

            //pojedynczy znak ze stringa
            //string someLongString = "SN521"; //marka urządzenia, rodzaj urządzenia, model urządzenia
            //Console.WriteLine($"Rodzej urządzenia to: {someLongString[3]}");

            //dzielenie stringa
            //string dateTimeAsString = "09-03-2023 10:59:23";
            //string[] splitDate = dateTimeAsString.Split("-");
            //Console.WriteLine($"Ostatni element po podziale na myślniki to: {splitDate[splitDate.Length - 1]}");
            //string onlyDate = "1990-01-13";
            //string[] dateElements = onlyDate.Split('-');

            //Console.WriteLine($"Rok: {dateElements[0]}");
            //Console.WriteLine($"Miesiąc: {dateElements[1]}");
            //Console.WriteLine($"Dzień: {dateElements[2]}");

            //PLN: 4.70, Euro: 1, USD: 2.5
            //string currencies = " , Euro: 1, USD: 2.5";
            //string[] currenciesArray = currencies.Split(", ");
            //if (currenciesArray[0].Contains("PLN"))
            //{
            //    Console.WriteLine($"Wartość PLN to: {currenciesArray[0].Split(": ")[1]}");
            //}

            //tablice wielowymiarowe
            //var multidimensionalArrayOfInts = new int[4, 2];
            //trzeba konkretne, pojedyncze wartości ustalić
            //multidimensionalArrayOfInts[3,1] = 1;
            //Console.WriteLine($"Length dla tabeli wielowymiarowej to: {multidimensionalArrayOfInts.Length}");
            //multidimensionalArrayOfInts = new int[3, 3]
            //{
            //    { 1, 2, 3 },
            //    { 4, 5, 6 },
            //    { 7, 8, 9 }
            //};

            //rozmiar całej tablicy (liczba elementów)
            //Console.WriteLine("Rozmiar tablicy wielowymiarowej to: " + multidimensionalArrayOfInts.Length);
            //liczba wymiarów:
            //Console.WriteLine($"Liczba wymiarów tablicy to: {multidimensionalArrayOfInts.Rank}");
            //var rozmiarWymiaru = multidimensionalArrayOfInts.GetLength(0);
            //Console.WriteLine($"Rozmiar wymiaru 0 to: {rozmiarWymiaru}");

            //tablice poszarpane
            //int[][] jaggedArray = new int[3][];
            //jaggedArray[0] = new int[] { 1, 2, 3 };
            //jaggedArray[1] = new int[] { 10, 20 };
            //jaggedArray[2] = new int[] { 123, 124, 125, 126, 127 };

            //jaggedArray = new int[][]
            //{
            //    new int[] { 1, 2, 3 },
            //    new int[] { 10, 20 },
            //    new int[] { 123, 124, 125, 126, 127 }
            //};
            #endregion

            #region Pętla for

            //klauzula inicjalizacji - może być więcej niż jedna
            //warunek wykonania
            //klauzula iteracji - może być więcej niż jedna

            //int[,] multiDimArray = new int[4, 3];
            //int counter = 0;

            //for (int i = 0; i < 4; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        multiDimArray[i, j] = counter++;
            //        Console.Write(multiDimArray[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            //int[,,] kostka = new int[3, 3, 3];
            //int nowyCounter = 0;
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        for(int k = 0; k < 3; k++) 
            //        {
            //            kostka[i, j, k] = nowyCounter++;
            //        }
            //    }
            //}

            //elementy w pętli for są opcjonalne
            //int i = 0;
            //for (;;)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //    if (i == 5)
            //    {
            //        break;
            //    }
            //}

            //w pętli for można zmieniać elementy w kolekcji (tablicy)
            //int[] tablica = new int[10];
            //int i;
            //for (i = 0; i < tablica.Length; i++)
            //{
            //    tablica[i] = i + 1;
            //}

            //Zadanie - silnia:
            //policz silnię z liczby wprowadzonej prez użytkownika
            //int[] tablica = new int[10];
            //tablica[0] = 0;
            //tablica[1] = 1;
            //tablica[2] = 2;
            //tablica[3] = 3;
            //tablica[4] = 4;
            //tablica[5] = 5;
            //tablica[6] = 6;
            //tablica[7] = 7;
            //tablica[8] = 8;
            //tablica[9] = 9;

            //var kolory = new string[] { "czerwony", "zielony", "niebieski", "żółty" };

            //string[,] bibliotekaGier = new string[4, 4]
            //{
            //    { "FPS", "RTS", "RPG", "MMO"},
            //    { "COD", "AoE", "Wiedźmin", "Metin"},
            //    { "ET", "Starcraft", "Skyrim", "WoW" },
            //    { "Battlefield", "Warcraft", "Gothic", "Runs of Magic" }
            //};

            //Console.WriteLine("Podaj nazwę gry: ");
            //string gra = Console.ReadLine();
            //int indexNumber = -1;

            //for(int i = 1; i < 4; i++)
            //{
            //    for(int j = 0; j < 4; j++)
            //    {
            //        if (bibliotekaGier[i, j] == gra)
            //        {
            //            indexNumber = j; 
            //            break;
            //        }
            //    }
            //}

            //if(indexNumber != -1)
            //{
            //    Console.WriteLine($"Gra {gra} ma typ: {bibliotekaGier[0, indexNumber]}");
            //}
            //else
            //{
            //    Console.WriteLine("Podałeś złą nazwę gry");
            //}

            //Zadanie - odwróć string
            //Pobierz tekst od użytkownika i wypisz go od tyłu, np kot -> tok

            //var arrayToGoThrough = new int[15];
            //Console.Write("\n[");

            //for (int i = 0; i < arrayToGoThrough.Length; i++)
            //{
            //    arrayToGoThrough[i] = i+1;
            //    Console.Write(arrayToGoThrough[i]);
            //    if(i != arrayToGoThrough.Length - 1)
            //    {
            //        Console.Write(", ");
            //    }
            //}
            //Console.Write("]\n");

            //i żyje tylko wewnątrz pętli

            //Zadanie:
            //Napisz program, który sprawdza, czy dane słowo jest palindromem

            //Console.WriteLine("Podaj słowo:");
            //var textToCheck = Console.ReadLine();
            //bool isPalindrome = true;

            //int a, b = 0;

            //for(int i = 0, j = textToCheck.Length - 1; i < textToCheck.Length / 2; i++, j--)
            //{
            //    if (textToCheck[i] != textToCheck[j])
            //    {
            //        isPalindrome = false;
            //        break;
            //    }
            //}

            //if(isPalindrome)
            //{
            //    Console.WriteLine("Słowo jest palindromem");
            //}
            //else
            //{
            //    Console.WriteLine("Słowo nie jest palindromem");
            //}

            //break i continue

            //Zadanie:
            //Napisz program, który posortuje tablicę liczb int
            //Sortowanie bąbelkowe - porównanie każdego elementu z każdym

            #endregion

            #region Pętla foreach 
            //var tablicaStringów = new string[] { "Ala", "ma", "kota", "perskiego" };

            //foreach (var element in tablicaStringów)
            //{
            //    resultString += element + " " + "słowo";
            //}


            //nie można zmieniać elementu w pętli for - używana kolekcja jest readonly

            //Zadanie - dodawanie elementów z tablicy int
            //Napisz program, który sumuje 
            #endregion

            //for(int i = 0; i < 5; i++)
            //{
            //    if(i == 3)
            //    {
            //        continue;
            //    }

            //    Console.WriteLine(i);
            //}

            //for (int i = 0; i < 5; i++)
            //{
            //    if (i != 3)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}


            //Console.WriteLine("Za pętlą for");

            #region Pętla while

            //Najpierw sprawdzany jest warunek, potem wykonywane jest to, co w środku
            //int j = 0;
            //int[] tablicaIntow = { 0, 1, 2, 3, 4, 5, 6 };
            //while(j < tablicaIntow.Length)
            //{
            //    if (tablicaIntow[j] % 2 == 0)
            //    {
            //        j++;
            //        continue;
            //    }
            //    else
            //    {
            //        j++;
            //        Console.WriteLine($"Liczba {tablicaIntow[j]} jest parzysta");
            //    }
            //}

            //int opcja = 0;
            //do
            //{
            //    Console.WriteLine("To jest pętla do-while");
            //    Console.WriteLine("MENU");
            //    Console.WriteLine("0. Zakończ program");
            //    Console.WriteLine("1. Dodawanie");
            //    Console.WriteLine("2. Odejmowanie");
            //} while (opcja != 0);

            //while (opcja != 0)
            //{
            //    Console.WriteLine("To jest pętla while");
            //    Console.WriteLine("MENU");
            //    Console.WriteLine("0. Zakończ program");
            //    Console.WriteLine("1. Dodawanie");
            //    Console.WriteLine("2. Odejmowanie");
            //}
            //Console.WriteLine("Kod poza pętlą");

            //Nieskończona pętla while

            //różnica między while a do-while

            //Zadanie:
            //Stwórz tablicę z kilkoma elementami
            //Wypisz elementy tablicy używając pętli for, foreach i while

            //Zadanie - wyświetlanie wyniku obliczen,
            //dopoki uzytkownik nie wybierze opcji zakonczenia programu
            //Przyjmij od użytkownika 2 liczby całkowite
            //Wyświetl menu z opcjami:
            //1. Dodawanie
            //2. Odejmowanie
            //3. Mnożenie
            //4. Dzielenie
            //0. Zakończenie programu
            //wyświetlaj menu dopóki użytkownik nie wybierze opcji 0 - zakończenie programu

            #endregion

            //Rozwiazania.SortowanieTablicy();

            #region Typy referencyjne i wartościowe
            //Console.WriteLine("-----Typy referencyjne-----");
            //var person1 = new Person
            //{
            //    FirstName = "Marcin",
            //    LastName = "Szymczyk"
            //};

            //var person2 = person1;

            //Console.WriteLine("Przed zmianą");
            //Console.WriteLine($"person1: {person1.FirstName} {person1.LastName}");
            //Console.WriteLine($"person2: {person2.FirstName} {person2.LastName}");

            //person2.FirstName = "Filip";
            //Console.WriteLine("Po zmianie");
            //Console.WriteLine($"person1: {person1.FirstName} {person1.LastName}");
            //Console.WriteLine($"person2: {person2.FirstName} {person2.LastName}");

            //Console.WriteLine("-----Typy wartościowe-----");
            //int a = 10;
            //int b = a;

            //Console.WriteLine("Przed zmianą:");
            //Console.WriteLine($"a: {a}");
            //Console.WriteLine($"b: {b}");

            //b = 35;
            //Console.WriteLine("Po zmianie:");
            //Console.WriteLine($"a: {a}");
            //Console.WriteLine($"b: {b}");
            #endregion
        }

        #region Enum typy
        enum Browser
        {
            Firefox = 1,
            Chromium = 2,
            Safari = 4,
            IE = 8
        }

        enum BigNumber : ulong
        {
            Tysiąc = 1000,
            Milion = 1000000,
            Miliard = 1000000000
        }

        enum DzialanieMatematyczne
        {
            Dodawanie,
            Odejmowanie,
            Mnozenie,
            Dzielenie,
            ResztaZDzielenia
        }

        #endregion
    }
}