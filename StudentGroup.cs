using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prakt15
{
    public class StudentGroup
    {
        public string GroupName { get; set; }
        public List<Student> Students { get; set; }
        public StudentGroup(string groupName)
        {
            GroupName = groupName;
            Students = new List<Student>();
        }

        public void AddStudent(Student student)
        {
            Students.Add(student);
        }

        public void RemoveStudent(Student student)
        {
            Students.Remove(student);
        }

        public void SortBySurname()
        {
            Students = Students.OrderBy(s => s.Surname).ToList();
        }

        public void SortByDateofBirth() 
        {
            Students = Students.OrderBy(s => s.DateofBirth).ToList();
        }
     
        public List<Student> SearchBySurname(string surname) 
        {
            return Students.Where(s => s.Surname == surname).ToList();     
        }
        public List<Student> SearchByDateofBirth(DateTime dateofbirth)
        {
            return Students.Where(s => s.DateofBirth == dateofbirth).ToList();
        }
        public List<Student> SearchByNomer(string nomer)
        {
            return Students.Where(s => s.PhoneNomber == nomer).ToList();
        }
    }
}
