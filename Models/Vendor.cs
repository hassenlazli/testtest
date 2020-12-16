using System;
using System.Collections.Generic;

#nullable disable

namespace apiProject.Models
{
    public partial class Vendor
    {
        public Guid Oid { get; set; }
        public Guid? Employee { get; set; }
        public string MatriculeEmployé { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public Guid? CashRegister { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
        public Guid? CurrentTruck { get; set; }

        public virtual Truck CurrentTruckNavigation { get; set; }
    }
}
