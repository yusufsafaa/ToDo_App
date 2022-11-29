using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo_App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("(1) To Add a Card to Board");
            Console.WriteLine("(2) To Delete a Card from Board");
            Console.WriteLine("(3) To Move a Card");
            Console.WriteLine("(4) To List Board");
            Console.WriteLine("(5) Quit");
            Console.Write("Please, enter process you want to make : ");
            int process = int.Parse(Console.ReadLine());

            TeamMembers tm = new TeamMembers();
            DefaultCards dc = new DefaultCards();

            bool control = true;
            while (control)
            {
                switch (process)
                {
                    case 1:
                        Console.WriteLine("----------------------------");
                        AddCard.Add();
                        break;

                    case 2:
                        Console.WriteLine("----------------------------");
                        DeleteCard.Delete();
                        break;
                        
                    case 3:
                        Console.WriteLine("----------------------------");
                        MoveCard.Move();
                        break;

                    case 4:
                        Console.WriteLine("----------------------------");
                        Board.AllLine();
                        break;

                    case 5:
                        Console.WriteLine("----Thank You For Using-----");
                        control = false;
                        break;

                    default:
                        Console.WriteLine("Please enter a valid number!");
                        break;
                }
                if (control)
                {
                    Console.Write("If you want to make another process, please enter: ");
                    process = int.Parse(Console.ReadLine());
                }

            }
            Console.ReadLine();
        }
    }
}
