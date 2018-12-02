using System;


namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            ValueType();

            for (; ; )
            {
                Greeting();
                Age();
                Settings();
            }
        }

        private static void ValueType()
        {
            int maxInt = int.MaxValue;
            int minInt = int.MinValue;
            long maxLong = long.MaxValue;
            long minLong = long.MinValue;

            Console.WriteLine("maxInt=" + maxInt);
            Console.WriteLine("minInt=" + minInt);
            Console.WriteLine("maxLong=" + maxLong);
            Console.WriteLine("maxLong=" + minLong);
        }

        /// <summary>
        /// Ustawia color skonsoli 
        /// </summary>
        private static void Settings()
        {
            Console.ReadKey();
            Console.Clear();
            Console.ResetColor();
        }
        
        /// <summary>
        /// Sprawdza podany wiek
        /// </summary>
        private static void Age()
        {
            Console.Write("Podaj ile masz lat ");

            int age;
            bool resault = int.TryParse(Console.ReadLine(), out age);

            if (age > 18)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Brawo! Jesteś pełnoletni, możesz wypić browara");
            }
            else if (resault == false)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wprowadziłeś nie poprawny wiek!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Możemy Ci zoproponować jedynie mleko");

            }
        }
        
        /// <summary>
        /// Wypisujemy powitanie użytkownika
        /// </summary>
        private static void Greeting()
        {
            Console.Write("Wpisz swoje imie ");
            string name = Console.ReadLine();
            Console.WriteLine("Witaj, " + name);
        }
    }
}
