using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IQuittableAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // instantiate and populate data for new employees
            Employee employee = new Employee() { FirstName = "Sample", LastName = "Student", Id = 1 };
            Employee employee1 = new Employee() { FirstName = "Sample", LastName = "Student", Id = 2 };
            // check if employees are equal/not equal to each other
            bool isEqual = employee == employee1;
            bool isNotEqual = employee != employee1;
            Console.WriteLine(isEqual);
            Console.WriteLine(isNotEqual);
            // print employee full name to Console
            employee.SayName();
            Console.ReadLine();
            // polymorph IQuittable with Employee
            IQuittable quittable = new Employee();
            // use Quit method 
            quittable.Quit();
        }
    }
}
