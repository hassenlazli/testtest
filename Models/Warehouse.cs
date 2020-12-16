using System;
using System.Collections.Generic;

#nullable disable

namespace apiProject.Models
{
    public partial class Warehouse
    {
        public Warehouse()
        {
            Products = new HashSet<Product>();
        }

        public Guid Oid { get; set; }
        public bool? IsDefaultWarehouse { get; set; }
        public string Id { get; set; }
        public string BarCode { get; set; }
        public string Name { get; set; }
        public int? Type { get; set; }
        public Guid? Manager { get; set; }
        public int? Priority { get; set; }
        public bool? IsActif { get; set; }
        public bool? ExcludedFromPreparation { get; set; }
        public bool? ImmoManagement { get; set; }
        public bool? AllowBulkQuantities { get; set; }
        public Guid? Parameters { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
        public int? ObjectType { get; set; }

        public virtual Truck Truck { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
