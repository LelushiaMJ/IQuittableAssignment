using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IQuittableAssignment
{
    public class Person
    {
        // person properties
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // person method - says first and last name
        public void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
    }
}
