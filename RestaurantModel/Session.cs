using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantModel
{
    public class Session
    {
        public int Id;
        public Employee Host { get; set; }
        public Table Table { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
	}
}
