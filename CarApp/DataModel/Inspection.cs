using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApp.DataModel
{
    class Inspection
    {
        public int Id { get; set; }
        public string DateInspection { get; set; }
        public int NumberInspection { get; set; }

        public int? CarId { get; set; }
        public virtual Car Car { get; set; }
    }
}
