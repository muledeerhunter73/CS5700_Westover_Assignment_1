using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace CS5700_Westover_Assignment_1
{
    [DataContract]
    class Person
    {
        [DataMember]
        private int ObjectID { get; set; }
        [DataMember]
        private string StateFileNumber { get; set; }
        [DataMember]
        private string SocialSecurityNumber { get; set; }
        [DataMember]
        private string FirstName { get; set; }
        [DataMember]
        private string MiddleName { get; set; }
        [DataMember]
        private string LastName { get; set; }
        [DataMember]
        private int BirthYear { get; set; }
        [DataMember]
        private int BirthMonth { get; set; }
        [DataMember]
        private int BirthDay { get; set; }
        [DataMember]
        private string Gender { get; set; }
    }
}
