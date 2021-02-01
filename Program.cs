using System;

namespace Warunki_operatory
{
    class Program
    {
        static void Main(string[] args)
        {

            IsEqual();                        // Zadanie 1

            IsEven();                         // Zadanie 2

            IsPositive();                     // Zadanie 3

            IsBissextile();                   // Zadanie 4

            MinimalAgeToPolitics();           // Zadanie 5

            CategoryOfHeigh();                // Zadanie 6

            TheHighestNumber();               // Zadanie 7

            PointsForUniversity();            // Zadanie 8

            Temperature();                    // Zadanie 9

            Triangle();                       // Zadanie 10

            ChangeGrade();                    // Zadanie 11

            DayOfTheWeek();                   // Zadanie 12

            Calculator();                     // Zadanie 13
        }
        static void IsEqual()
        {
            Console.Write("Podaj dwie liczby całkowite aby sprawdzić, czy są równe: \na: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b: ");
            int b = int.Parse(Console.ReadLine());
            if (a == b)
                Console.WriteLine($"Liczby {a} i {b} są równe.\n");
            else
                Console.WriteLine($"Liczby {a} i {b} nie są równe.\n");
        }
        static void IsEven()
        {
            Console.Write("Wprowadź liczbę aby sprawdzić, czy jest parzysta: ");
            int number = int.Parse(Console.ReadLine());
            if (number % 2 == 0)
                Console.WriteLine($"{number} jest liczbą parzystą.\n");
            else
                Console.WriteLine($"{number} jest liczbą nieparzystą.\n");
        }
        static void IsPositive()
        {
            Console.Write("Wprowadź liczbę aby sprawdzić czy jest dodatnia: ");
            int number = int.Parse(Console.ReadLine());
            if (number >= 0)
                Console.WriteLine($"{number} jest liczbą dodatnią\n");
            else
                Console.WriteLine($"{number} jest liczbą ujemną\n");
        }
        static void IsBissextile()
        {
            Console.Write("Podaj rok aby sprawdzić czy jest przestępny: ");
            int year = int.Parse(Console.ReadLine());
            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                Console.WriteLine($"{year} jest rokiem przestępnym.\n");
            }
            else
                Console.WriteLine($"{year} nie jest rokiem przestępnym\n");
        }
        static void MinimalAgeToPolitics()
        {
            Console.Write("Podaj wiek aby sprawdzić, czy możesz być posłem, premierem, senatorem lub prezydentem: ");
            int age = int.Parse(Console.ReadLine());
            if (age >= 21)
            {
                if (age >= 30)
                {
                    if (age >= 35)
                    {
                        Console.WriteLine($"Mając {age} lat możesz obejmować już na każde stanowisko.\n");
                    }
                    else
                        Console.WriteLine($"Mając {age} możesz objąć stanowisko posła, senatora lub premiera.\n");
                }
                else
                    Console.WriteLine($"Mająć {age} możesz kandydować na posła.\n");
            }
            else
                Console.WriteLine($"Musisz poczekać jeszcze przynajmniej {21 - age} lat aby kandydować.\n");
        }
        static void CategoryOfHeigh()
        {
            Console.Write("Podaj swoj wzrost (w cm) a powiem Ci kim jesteś: ");
            double heigh = double.Parse(Console.ReadLine());
            if (heigh >= 70)
                if (heigh >= 100)
                    if (heigh >= 150)
                        if (heigh >= 200)
                            Console.WriteLine("Jesteś czarodziejem. Say hallo to Gandalf!\n");
                        else
                            Console.WriteLine("Jesteś elfem. Say hello to Legolas!\n");
                    else
                        Console.WriteLine("Jesteś krasnoludem. Say hallo to Gimli!\n");
                else
                    Console.WriteLine("Jesteś niziołkiem. Say hello to Frodo!\n");

            else
                Console.WriteLine("Jesteś gnomem. Say hello to Gollum!\n");
        }
        static void TheHighestNumber()
        {
            Console.Write("Podaj trzy liczby \npierwsza liczba: ");
            double nr1 = double.Parse(Console.ReadLine());
            Console.Write("druga liczba: ");
            double nr2 = double.Parse(Console.ReadLine());
            Console.Write("trzecia liczba: ");
            double nr3 = double.Parse(Console.ReadLine());
            double max = nr1;

            if (nr2 > max)
                max = nr2;
            if (nr3 > max)
                max = nr3;

            Console.WriteLine($"{max} jest największą z podanych liczb.\n");
        }
        static void PointsForUniversity()
        {
            Console.WriteLine("Podaj swoje punkty z matury aby przekonać się, czy możesz rekrutować.");
            Console.Write("Matematyka: ");
            int math = int.Parse(Console.ReadLine());
            Console.Write("Fizyka: ");
            int physics = int.Parse(Console.ReadLine());
            Console.Write("Chemia: ");
            int chemistry = int.Parse(Console.ReadLine());

            int sum = math + physics + chemistry;

            if ((math > 70 && physics > 55 && chemistry > 45 && sum > 180) || (math + physics > 150) || (math + chemistry > 150))
                Console.WriteLine("Jesteś dopuszczony do rekrutacji.\n");
            else
                Console.WriteLine("Nie masz wystarczającej ilości punktów.\n");
        }
        static void Temperature()
        {
            Console.Write("Podaj temperaturę w Celsjuszach: ");
            double temp = double.Parse(Console.ReadLine());

            if (temp >= 0)
                if (temp >= 10)
                    if (temp >= 20)
                        if (temp >=30)
                            if (temp >= 40)
                                Console.WriteLine("A weź! Wyprowadzam się na Alaskę!\n");
                            else
                                Console.WriteLine("Zaczyna być słabo bo gorąco!\n");
                        else
                            Console.WriteLine("W sam raz.\n");
                    else
                        Console.WriteLine("Chłodno.\n");
                else
                    Console.WriteLine("Zimno.\n");
            else
                Console.WriteLine("Cholernie piździ!\n");
        }
        static void Triangle()
        {
            Console.Write("Podaj 3 długości aby sprawdzić, czy da się z nich stworzyć trójkąt.\nbok 1: ");
            int side1 = int.Parse(Console.ReadLine());
            Console.Write("bok 2: ");
            int side2 = int.Parse(Console.ReadLine());
            Console.Write("bok 3: ");
            int side3 = int.Parse(Console.ReadLine());

            if ((side1+side2>side3) && (side1+side3>side2) && (side2+side3>side1))
                Console.WriteLine("Można zbudować trójkąt.\n");
            else
                Console.WriteLine("Nie można zbudować trójkąta.\n");
        }
        static void ChangeGrade()
        {
            Console.Write("Podaj ocenę w skali od 1 do 6: ");
            int grade = int.Parse(Console.ReadLine());

            switch (grade)
            {
                case 1:
                    Console.WriteLine("Niedostateczny\n");
                    break;
                case 2:
                    Console.WriteLine("Dopuszczający\n");
                    break;
                case 3:
                    Console.WriteLine("Dostateczny\n");
                    break;
                case 4:
                    Console.WriteLine("Dobry\n");
                    break;
                case 5:
                    Console.WriteLine("Bardzo dobry\n");
                    break;
                case 6:
                    Console.WriteLine("Celujący\n");
                    break;
                default:
                    Console.WriteLine("Nie ma takiej oceny!\n");
                    break;
            }
        }
        static void DayOfTheWeek()
        {
            Console.Write("Podaj numer dnia tygodnia: ");
            int day = int.Parse(Console.ReadLine());

            switch (day)
            {
                case 1:
                    Console.WriteLine("Poniedziałek\n");
                    break;
                case 2:
                    Console.WriteLine("Wtorek\n");
                    break;
                case 3:
                    Console.WriteLine("Środa\n");
                    break;
                case 4:
                    Console.WriteLine("Czwartek\n");
                    break;
                case 5:
                    Console.WriteLine("Piątek\n");
                    break;
                case 6:
                    Console.WriteLine("Sobota\n");
                    break;
                case 7:
                    Console.WriteLine("Niedziela\n");
                    break;
                default:
                    Console.WriteLine("Nie ma takiego dnia tygodnia\n");
                    break;
            }
        }
        static void Calculator()
        {
            Console.WriteLine("Podaj liczby aby wykonać na nich działania w kalkulatorze.");
            Console.Write("Podaj pierwszą liczbę: ");
            int nr1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj drugą liczbę: ");
            int nr2 = int.Parse(Console.ReadLine());
            Console.WriteLine("MENU\n1 - Dodawanie\n2 - Odejmowanie\n3 - Mnożenie\n4 - Dzielenie");
            Console.Write("Podaj numer działania z menu jakie chcesz wykonać: ");
            int sign = int.Parse(Console.ReadLine());

            switch (sign)
            {
                case 1:
                    Console.WriteLine($"{nr1} + {nr2} = {nr1 + nr2}\n");
                    break;
                case 2:
                    Console.WriteLine($"{nr1} - {nr2} = {nr1 - nr2}\n");
                    break;
                case 3:
                    Console.WriteLine($"{nr1} * {nr2} = {nr1 * nr2}\n");
                    break;
                case 4:
                    {
                        if (nr2 != 0)
                            Console.WriteLine($"{nr1} / {nr2} = {nr1 / nr2}\n");
                        else
                            Console.WriteLine("Nie można dzielić przez 0!\n");
                    }
                    break;
                default:
                    Console.WriteLine("Nie ma takiego działania.\n");
                    break;
            }
        }
    }
}
