using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelProject.Models
{
    public class Trip
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime MyProperty { get; set; } // might not need this prop
        public string UserName { get; set; }
        public  DateTime DateCreated { get; set; }

        public ICollection<Stop> Stops { get; set; }
    }
}
