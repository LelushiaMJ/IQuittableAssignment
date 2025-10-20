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
            // instantiate and populate data for new employee
            Employee employee = new Employee() { FirstName = "Sample", LastName = "Student" };
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
