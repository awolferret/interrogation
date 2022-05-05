using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Как Вас зовут?");
            string name = Console.ReadLine();
            Console.WriteLine("Сколько Вам лет");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Какой у Вас знак зодиака?");
            string zodiak = Console.ReadLine();
            Console.WriteLine("Чем Вы занимаетесь");
            string work = Console.ReadLine();
            Console.WriteLine($"Вас зовут {name}, Вам {age} лет, Ваш знак зодиака {zodiak} и Вы {work}");

        }
    }
}
