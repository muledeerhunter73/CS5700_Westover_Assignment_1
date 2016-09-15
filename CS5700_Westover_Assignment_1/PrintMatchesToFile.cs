using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CS5700_Westover_Assignment_1
{
    class PrintMatchesToFile : PrintOutput
    {
        public void PrintResults(Match match)
        {
            string filename = "output_of_matching_pairs.txt";

            if (File.Exists(filename))
            {
                using (StreamWriter writer = File.AppendText(filename))
                {
                    writer.WriteLine($"({match.ObjectID1},{match.ObjectID2})");
                }
            }
            else
            {
                using (StreamWriter writer = File.CreateText(filename))
                {
                    writer.WriteLine($"({match.ObjectID1},{match.ObjectID2})");
                }
            }
                
        }
    }
}
