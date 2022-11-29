using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo_App
{
    class DeleteCard
    {
        public static void Delete()
        {
            Console.WriteLine("First, it is need to choose card that you want to delete.");
            
            Console.Write("Please, enter card headline: ");
            string headline = Console.ReadLine();

            bool control = false;
            foreach (Card item in Board.allList)
            {
                if (item.Headline==headline)
                {
                    control = true;
                    Transactions.DeletingCard(Board.toDoList, headline);
                    Transactions.DeletingCard(Board.inProgressList, headline);
                    Transactions.DeletingCard(Board.doneList, headline);
                }
            }

            if (!control)
            {
                Console.WriteLine("There is no card information according to your request! Please, make a choice.");
                Console.WriteLine("To Finish Deleting Process : (1)");
                Console.WriteLine("To Try Again : (2)");
                int subprocess = int.Parse(Console.ReadLine());

                if (subprocess==2)
                {
                    Delete();
                }
            }
        }
    }
}
