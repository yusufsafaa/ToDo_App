using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo_App
{
    class Board
    {
        public static List<Card> toDoList = new List<Card>();
        public static void ToDoLine()
        {
            Console.WriteLine("TODO Line");
            Console.WriteLine("*****************");
            WriteCard.Write(toDoList);

        }

        public static List<Card> inProgressList = new List<Card>();
        public static void InProgressLine()
        {
            Console.WriteLine("IN PROGRESS Line");
            Console.WriteLine("*****************");
            WriteCard.Write(inProgressList);
        }

        public static List<Card> doneList = new List<Card>();
        public static void DoneLine()
        {
            Console.WriteLine("DONE Line");
            Console.WriteLine("*****************");
            WriteCard.Write(doneList);
        }

        public static List<Card> allList = new List<Card>();
        public static void AllLine()
        {
            ToDoLine();
            InProgressLine();
            DoneLine();
        }
    }
}
