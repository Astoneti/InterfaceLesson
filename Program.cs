using System;

namespace InterfaceLesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human();
            human.SpeakLoud("Я люблю программирование:)");
            human.ThinkAboutSomething("O C# больше всего!");
            human.SpeakNormal("станет хорошим програмистом :)");
            Console.ReadKey();
        }
    }
}
