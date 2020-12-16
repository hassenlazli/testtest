using System;
using System.Collections.Generic;

#nullable disable

namespace test.Models
{
    public partial class Truck
    {
        public Truck()
        {
            Vendors = new HashSet<Vendor>();
        }

        public Guid Oid { get; set; }
        public Guid? Vehicule { get; set; }
        public string Matricule { get; set; }

        public virtual Warehouse OidNavigation { get; set; }
        public virtual ICollection<Vendor> Vendors { get; set; }
    }
}
