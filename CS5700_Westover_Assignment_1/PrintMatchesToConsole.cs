using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS5700_Westover_Assignment_1
{
    class PrintMatchesToConsole : PrintOutput
    {
        public void PrintResults(Match match)
        {
            if (match.IsMatch)
            {
                Console.WriteLine($"({match.ObjectID1},{match.ObjectID2})");
            }
        }
    }
}
