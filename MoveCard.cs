using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo_App
{
    class MoveCard
    {
        public static void Move()
        {
            Console.WriteLine("First, it is need to choose card that you want to move.");
            Console.Write("Please, enter card headline: ");
            string headline = Console.ReadLine();
            Console.WriteLine("");

            int counter = 0;
            bool control = false;
            foreach (Card item in Board.allList)
            {
                if (item.Headline==headline)
                {
                    Transactions.MovingCard(Board.toDoList, headline, ref control, ref counter);
                    Transactions.MovingCard(Board.inProgressList, headline, ref control, ref counter);
                    Transactions.MovingCard(Board.doneList, headline, ref control, ref counter);
                }
            }

            if (!control)
            {
                Console.WriteLine("There is no card information according to your request! Please, make a choice.");
                Console.WriteLine("To Finish Moving Process : (1)");
                Console.WriteLine("To Try Again : (2)");
                int subprocess = int.Parse(Console.ReadLine());

                if (subprocess==2)
                {
                    Move();
                }
            }
        }
    }
}
