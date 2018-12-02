using System;


namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Wpisz swoje imie ");
            string name = Console.ReadLine();
            Console.WriteLine("Witaj, " + name);

            Console.Write("Podaj ile masz lat");

            int age;
            bool resault = int.TryParse(Console.ReadLine(), out age);

            if (age > 18)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Brawo! Jesteś pełnoletni, możesz wypić browara");
            }
            else if (resault==false)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wprowadziłeś nie poprawny wiek!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Możemy Ci zoproponować jedynie mleko");

            }
            Console.ReadKey();
        }

        
    }
}
