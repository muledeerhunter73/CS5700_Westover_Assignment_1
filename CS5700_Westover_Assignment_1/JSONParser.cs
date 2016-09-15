using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Json;

namespace CS5700_Westover_Assignment_1
{
    class JSONParser : ImportFileStrategy
    {
        public override List<Person> LoadInput(string filename)
        {
            List<Person> allpersons = new List<Person>();
            DataContractJsonSerializer json = new DataContractJsonSerializer(typeof(List<Person>), new Type[]
            {
                typeof(Person), typeof(Adult), typeof(Child)
            });
            CreateReader(filename);
            allpersons = json.ReadObject(Reader.BaseStream) as List<Person>;
            Reader.Close();

            return allpersons;
        }
    }
}
