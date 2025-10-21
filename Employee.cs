using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IQuittableAssignment
{
    // inherit from person and IQuittable (interface)
    public class Employee : Person, IQuittable
    {
        // employee properties
        public int Id { get; set; }

        // quit method
        public void Quit()
        {
            this.Id = 0;
            Console.WriteLine(this.Id);
            Console.ReadLine();
        }

        // operator overloading for == and != (must be done in pairs) - returns boolean, accepts 2 employee objects
        // prints to console whether they are equal/not equal
        public static bool operator== (Employee a, Employee b)
        {
            Console.WriteLine("Is {0} equal to {1}: {2}", a.Id, b.Id, a.Id == b.Id);
            bool isEqual = a.Id == b.Id;
            return isEqual;
        }

        public static bool operator!= (Employee a, Employee b)
        {
            Console.WriteLine("Is {0} not equal to {1}: {2}", a.Id, b.Id, a.Id != b.Id);
            bool isNotEqual = a.Id != b.Id;
            return isNotEqual;
        }
    }
}
