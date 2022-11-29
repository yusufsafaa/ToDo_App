using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo_App
{
    class DefaultCards
    {
        
        public DefaultCards()
        {
            Card card1 = new Card() { Headline = "Studying Exam", Content = "BBG Lesson", Importance = 5, Assignee = 12349 };
            Card card2 = new Card() { Headline = "Gym", Content = "Do Sport", Importance = 2, Assignee = 12345 };
            Board.doneList.Add(card1);
            Board.inProgressList.Add(card2);
            Board.allList.Add(card1);
            Board.allList.Add(card2);

        }
    }
}
