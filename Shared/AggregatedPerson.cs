using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    [DataContract]
    public class AggregatedPerson
    {
        public AggregatedPerson(string surname, string givenname, string city, string street, int zip, bool isStudent, Guid id, Guid studentID)
        {
            Surname = surname;
            Givenname = givenname;
            City = city;
            Street = street;
            Zip = zip;
            IsStudent = isStudent;
            Id = id;
            StudentID = studentID;
        }

        [DataMember]
        public string Surname { get; set; }
        [DataMember]
        public string Givenname { get; set; }
        [DataMember]
        public string City { get; set; }
        [DataMember]
        public string Street { get; set; }
        [DataMember]
        public int Zip { get; set; }
        [DataMember]
        public bool IsStudent { get; set; }
        [DataMember]
        public Guid Id { get; set; }
        [DataMember]
        public Guid StudentID { get; set; }
    }
}
