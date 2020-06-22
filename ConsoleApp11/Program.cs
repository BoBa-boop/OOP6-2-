using System;

namespace ConsoleApp11
{
    class newClass
    {
        private string Method;
        public newClass()
        {
            Method = "Пусто";
        }
        public newClass(string Line)
        {
            if (Line.Length > 10)
                Method = "Слишком длинная строка";
            else
                Method = Line;
        }
        public void Display()
        {
            Console.WriteLine(Method);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            newClass first = new newClass();
            first.Display();
            newClass second = new newClass("Больше 10 символов");
            second.Display();
            newClass third = new newClass("Меньше 10");
            third.Display();
            Console.ReadKey();
        }
    }
}
