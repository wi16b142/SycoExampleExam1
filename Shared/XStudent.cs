using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    [DataContract]
    public class XStudent
    {
        public XStudent(string lastname, string firstname, string city, string street, int zip, Guid studentID)
        {
            Lastname = lastname;
            Firstname = firstname;
            City = city;
            Street = street;
            Zip = zip;
            StudentID = studentID;
        }

        [DataMember]
        public string Lastname { get; set; }
        [DataMember]
        public string Firstname { get; set; }
        [DataMember]
        public string City { get; set; }
        [DataMember]
        public string Street { get; set; }
        [DataMember]
        public int Zip { get; set; }
        [DataMember]
        public Guid StudentID { get; set; }
    }
}
