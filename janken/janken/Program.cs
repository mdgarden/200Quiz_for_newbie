using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace janken
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int aiChoice = rand.Next(0, 3);
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 0:
                    Console.WriteLine("당신의 선택은 가위입니다.");
                    break;
                case 1:
                    Console.WriteLine("당신의 선택은 바위입니다.");
                    break;
                case 2:
                    Console.WriteLine("당신의 선택은 보입니다.");
                    break;
            }

            switch (aichoice)
            {
                case 0:
                    Console.WriteLine("컴퓨터의 선택은 가위입니다.");
                    break;
                case 1:
                    Console.WriteLine("컴퓨터의 선택은 바위입니다.");
                    break;
                case 2:
                    Console.WriteLine("컴퓨터의 선택은 보입니다.");
                    break;
            }

            if (choice == 0)
            {
                if (aiChoice == 0)
            }
        }
    }
}
