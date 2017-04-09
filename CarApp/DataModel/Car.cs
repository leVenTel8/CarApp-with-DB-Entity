using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApp.DataModel
{
    class Car
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public int YearMade { get; set; }
        public string GosNumber { get; set; }
        public string DateRegistration { get; set; } 

        public virtual ICollection<Inspection> Inspections { get; set; }

        public Car()
        {
            Inspections = new List<Inspection>();
        }
        public override string ToString()
        {
            return Model;
        }

    }
}
