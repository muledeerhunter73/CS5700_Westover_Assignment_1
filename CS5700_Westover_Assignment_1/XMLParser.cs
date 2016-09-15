using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace CS5700_Westover_Assignment_1
{
    class XMLParser : ImportFileStrategy
    {
        public override List<Person> LoadInput(string filename)
        {
            List<Person> allpersons = new List<Person>();
            XmlSerializer xml = new XmlSerializer(typeof(List<Person>), new Type[]
            {
                typeof(Person), typeof(Adult), typeof(Child)
            });
            CreateReader(filename);
            allpersons = xml.Deserialize(Reader) as List<Person>;
            Reader.Close();

            return allpersons;
        }
    }
}
