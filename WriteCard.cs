using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo_App
{
    class WriteCard
    {
        public static void Write(List<Card> listCard)
        {
            foreach (Card item in listCard)
            {
                int sayi = item.Importance;
                TeamMembers.a = (TeamMembers.importance)sayi;
                Console.WriteLine("Headline:    "+item.Headline);
                Console.WriteLine("Content:     "+item.Content);
                Console.WriteLine("Assignee:    "+TeamMembers.members[item.Assignee]);
                Console.WriteLine("Importance:  "+TeamMembers.a.ToString());
                Console.WriteLine("--");

            }
        }

        public static void WriteInfo(Card card,ref int counter)
        {
            int sayi = card.Importance;
            TeamMembers.a = (TeamMembers.importance)sayi;
            Console.WriteLine("Information About Found Card:");
            Console.WriteLine("**********************");
            Console.WriteLine("Headline:    "+card.Headline);
            Console.WriteLine("Content:     "+card.Content);
            Console.WriteLine("Assignee:    "+TeamMembers.members[card.Assignee]);
            Console.WriteLine("Importance:  "+TeamMembers.a.ToString());
            switch (counter)
            {
                case 1:
                    Console.WriteLine("Line:        TODO");
                    break;
                case 2:
                    Console.WriteLine("Line:        IN PROGRESS");
                    break;
                case 3:
                    Console.WriteLine("Line:        DONE");
                    break;
                default:
                    break;
            }
            Console.WriteLine("");
        }
    }
}
