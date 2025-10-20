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
    }
}
