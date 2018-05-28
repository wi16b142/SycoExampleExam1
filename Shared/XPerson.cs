using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    [DataContract]
    public class XPerson
    {
        public XPerson(string surname, string givenname, string[] address, bool isStudent, Guid id)
        {
            Surname = surname;
            Givenname = givenname;
            Address = address;
            IsStudent = isStudent;
            Id = id;
        }

        [DataMember]
        public string Surname { get; set; }
        [DataMember]
        public string Givenname { get; set; }
        [DataMember]
        public string[] Address { get; set; }
        [DataMember]
        public bool IsStudent { get; set; }
        [DataMember]
        public Guid Id { get; set; }
    }
}
