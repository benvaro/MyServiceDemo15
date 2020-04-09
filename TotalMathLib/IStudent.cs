using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace TotalMathLib
{
    [ServiceContract]
    public interface IStudentService
    {
        [OperationContract]
        void AddStudent(Student st);
        [OperationContract]
        List<Student> GetStudents();
    }

    public class StudentService : IStudentService
    {
        List<Student> students = new List<Student>();
        public void AddStudent(Student st)
        {
            students.Add(st);
        }

        public List<Student> GetStudents()
        {
            return students;
        }
    }
    [DataContract]
    public class Student
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public int Age { get; set; }
        [DataMember]
        public Address Address { get; set; }
    }

    [DataContract]
    public class Address
    {
        [DataMember]
        public string City { get; set; }
        [DataMember]
        public string Street { get; set; }
    }
}
