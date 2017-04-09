using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;



namespace CarApp.DataModel
{
    class CarContext : DbContext
    {
        public CarContext()
            : base("DbConnection")
        { }

        public DbSet<Inspection> Inspections { get; set; }
        public DbSet<Car> Cars { get; set; }

    }
}
