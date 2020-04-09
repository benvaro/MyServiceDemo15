using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentClient.ServiceStudentReference;
namespace StudentClient
{
    class Program
    {
        static async Task Main(string[] args)
        {
            using (StudentServiceClient proxy = new StudentServiceClient())
            {
                proxy.AddStudent(new Student 
                { 
                    Address = new Address 
                        {
                            City = "Rivne",
                            Street = "Soborna"
                        },
                    Age = 21,
                    Name = "Viktor"
                });

                //Student[] result = proxy.GetStudents();
                Student[] result = await proxy.GetStudentsAsync();
                foreach (var item in result)
                {
                    Console.WriteLine(item.Name + " " + item.Address.City);
                }

                Console.WriteLine("Main works....");
                Console.ReadLine();
            }
        }
    }
}
