using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace CS5700_Westover_Assignment_1
{
    [DataContract]
    class Child : Person
    {
        [DataMember]
        private string NewbornScreeningNumber { get; set; }
        [DataMember]
        private string MotherMiddleName { get; set; }
        [DataMember]
        private string MotherLastName { get; set; }
        [DataMember]
        private string MotherFirstName { get; set; }
        [DataMember]
        private string IsPartOfMultipleBirth { get; set; }
        [DataMember]
        private int BirthOrder { get; set; }
        [DataMember]
        private int BirthCountry { get; set; }
    }
}
