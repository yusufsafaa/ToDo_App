using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo_App
{
    class AddCard
    {
        public static void Add()
        {
            Console.Write("Enter Headline                                             :");
            string headline = Console.ReadLine();
            Console.Write("Enter Content                                              :");
            string content = Console.ReadLine();
            Console.Write("Choose Importance -> XS(1),S(2),M(3),L(4),XL(5)            :");
            int importance = int.Parse(Console.ReadLine());
            Console.Write("Enter Member ID                                            :");
            int id = int.Parse(Console.ReadLine());

            Card card = new Card() { Headline = headline, Content = content, Importance = importance, Assignee = id };
            Board.toDoList.Add(card);
            Board.allList.Add(card);
        }
    }
}
