using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataRepository
{
    public class DataHandler
    {
        static List<XPerson> personRepo = new List<XPerson>();
        static List<XStudent> studentRepo = new List<XStudent>();
        static List<AggregatedPerson> aggregatedRepo = new List<AggregatedPerson>();
        static Random random = new Random();

        public DataHandler()
        {
            CreateDemoData(20);
        }

        public List<XPerson> QueryPersonRepository()
        {
            return personRepo;
        }

        public List<AggregatedPerson> GetAggregatedPersonData()
        {
            foreach (var item in personRepo)
            {
                Guid studentId = new Guid();
                if (item.IsStudent)
                {
                    foreach (var student in studentRepo)
                    {
                        if (student.Lastname.Equals(item.Surname) && student.Firstname.Equals(item.Givenname) && student.City.Equals(item.Address[0]))
                        {
                            studentId = student.StudentID;
                        }
                    }
                }
                aggregatedRepo.Add(new AggregatedPerson(
                    item.Surname,
                    item.Givenname,
                    item.Address[0],
                    item.Address[1],
                    int.Parse(item.Address[2]),
                    item.IsStudent,
                    item.Id,
                    studentId
                ));
            }
            return aggregatedRepo;
        }

        public List<XStudent> QueryStudentRepository()
        {
            return studentRepo;
        }

        private void CreateDemoData(int x)
        {
            for (int i = 0; i < x; i++)
            {
                bool student = random.NextDouble() >= 0.5;
                personRepo.Add(new XPerson(
                    "Surname"+i,
                    "Givenname"+i,
                    new string[] { "City"+i, "Street"+i, string.Format("{0}{1}{2}{3}", i,i+1,i+2,i+3) },
                    student,
                    Guid.NewGuid()
                    ));
                if (student)
                {
                    studentRepo.Add(new XStudent(
                    "Surname" + i,
                    "Givenname" + i,
                    "City" + i, 
                    "Street" + i, 
                    int.Parse(string.Format("{0}{1}{2}{3}", i, i + 1, i + 2, i + 3)),
                    Guid.NewGuid()
                    ));
                }
            }
        }


    }
}
