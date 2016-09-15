using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace CS5700_Westover_Assignment_1
{
    [DataContract]
    class Adult : Person
    {
        [DataMember]
        private string Phone1 { get; set; }
        [DataMember]
        private string Phone2 { get; set; }
    }
}
