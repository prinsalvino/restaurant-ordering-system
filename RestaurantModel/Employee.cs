using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantModel
{
    public class Employee
    {
        public int Number { get; set; }
        public string Name { get; set; }
        public EmployeeRole Role { get; set; }
    }
}
