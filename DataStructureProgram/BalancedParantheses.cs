using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureProgram
{
    internal class BalancedParantheses
    {
        public void ReadTextFile(string filepath)
        {
            string list = File.ReadAllText(filepath);
            string[] words = list.Split(" ");
            ListStack<string> Liststack = new ListStack<string>();
            foreach (var data in words)
            {
                if (data.Equals("("))
                    Liststack.Push(data);
                if (data.Equals(")"))
                    Liststack.Pop();
            }
            if (Liststack.Peek())
            {
                Console.WriteLine("Balanced Parantheses");
            }
            else
                Console.WriteLine("Not a Balanced Parantheses");
        }
    }
}
