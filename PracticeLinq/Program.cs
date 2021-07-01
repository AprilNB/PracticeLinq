using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticeLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> gameNames = new List<string>{"Minecraft", "Raft", "Lego World", "Slime Rancher", "Mario Maker"};

            IEnumerable<string> longGameNames = gameNames
                .Where(name => name.Length >= 5)
                .OrderBy(name => name.Length);
        }
    }
}
