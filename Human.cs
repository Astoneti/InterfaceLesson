using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceLesson3
{
    class Human : Interface1, Interface2  //Реализация в классе 2х интерфейсов
    {
        public void SpeakLoud(string str)
        {
            Console.WriteLine("Говорит громко - {0}", str);
        }
        public void SpeakNormal(string str)
        {
            Console.WriteLine("Говорит - {0}",str);
        }
        public void ThinkAboutSomething(string str) 
        {
            Console.WriteLine("Думает - {0}",str);
        }



    }
}
