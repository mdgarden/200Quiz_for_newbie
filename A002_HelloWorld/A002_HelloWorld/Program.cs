using System;

namespace A002_HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hello");
            Console.WriteLine("World!");
            Console.Write("이름을 입력하세요");

            string name = Console.ReadLine(); //이름을 입력받음
            Console.Write("안녕하세요,");
            Console.Write(name);
            Console.WriteLine("님!");
        }
    }
}
