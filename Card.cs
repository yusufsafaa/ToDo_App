using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo_App
{
    class Card
    {
        private string headline;
        private string content;
        private int assignee;
        private int importance;

        public string Headline
        {
            get { return headline; }
            set { headline = value; }
        }
        public string Content
        {
            get { return content; }
            set { content = value; }
        }
        public int Assignee
        {
            get { return assignee; }
            set { assignee = value; }
        }
        public int Importance
        {
            get { return importance; }
            set { importance = value; }
        }
    }
}
