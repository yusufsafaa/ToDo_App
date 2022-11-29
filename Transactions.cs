using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo_App
{
    class Transactions
    {
        public static void MovingCard(List<Card> List,string headline,ref bool control,ref int counter)
        {
            if (!control)
            {
                counter++;
                foreach (Card _item in List)
                {
                    if (_item.Headline == headline)
                    {
                        control = true;
                        List.Remove(_item);
                        WriteCard.WriteInfo(_item,ref counter);
                        Console.WriteLine("Which line do you want to move this card?");
                        Console.WriteLine("(1) TODO");
                        Console.WriteLine("(2) IN PROGRESS");
                        Console.WriteLine("(3) DONE");
                        int line = int.Parse(Console.ReadLine());
                        switch (line)
                        {
                            case 1:
                                Board.toDoList.Add(_item);
                                Console.WriteLine("The card has been moved to TODO Line successfully.");
                                break;

                            case 2:
                                Board.inProgressList.Add(_item);
                                Console.WriteLine("The card has been moved to IN PROGRESS Line successfully.");
                                break;

                            case 3:
                                Board.doneList.Add(_item);
                                Console.WriteLine("The card has been moved to DONE Line successfully.");
                                break;

                            default:
                                Console.WriteLine("You entered incorrect data!");
                                break;
                        }
                        break;
                    }
                }
            }
        }

        public static void DeletingCard(List<Card> List,string headline)
        {
            foreach (var _item in List)
            {
                if (_item.Headline == headline)
                {
                    List.Remove(_item);
                    Console.WriteLine(_item.Headline + " card has been deleted.");
                    break;
                }

            }
        }
    }
}
