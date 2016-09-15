using System;
using System.Collections.Generic;
using System.IO;

namespace CS5700_Westover_Assignment_1
{
    abstract class ParseInput
    {
        protected StreamReader Reader;
        public abstract List<Person> LoadInput(string filename);

        protected virtual void CreateReader(string filename)
        {
            try
            {
                Reader = new StreamReader(filename);
            }
            catch (Exception error)
            {
                Console.WriteLine($"Error opening the Input File: {filename}, Error was : {error}");
            }
        }
  
    }
}
