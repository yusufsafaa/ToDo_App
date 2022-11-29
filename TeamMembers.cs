using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo_App
{
    class TeamMembers
    {
        public static Dictionary<int, string> members = new Dictionary<int, string>();
        public TeamMembers()
        {
            members.Add(12345, "Ahmet");
            members.Add(12346, "Berat");
            members.Add(12347, "Mehmet");
            members.Add(12348, "Alperen");
            members.Add(12349, "Yusuf");
        }

        public enum importance
        {
            XS=1,S,M,L,XL
        }

        public static importance a;
    }
}
