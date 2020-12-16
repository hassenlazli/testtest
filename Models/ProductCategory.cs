using System;
using System.Collections.Generic;

#nullable disable

namespace test.Models
{
    public partial class ProductCategory
    {
        public ProductCategory()
        {
            InverseParentCategoryNavigation = new HashSet<ProductCategory>();
            Products = new HashSet<Product>();
        }

        public Guid Oid { get; set; }
        public string FullName { get; set; }
        public Guid? ParentCategory { get; set; }
        public string Name { get; set; }
        public string Id { get; set; }
        public int? TypeFamille { get; set; }
        public bool? ImmoManagement { get; set; }
        public Guid? Account { get; set; }
        public int? Counter { get; set; }
        public Guid? Parameters { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }

        public virtual ProductCategory ParentCategoryNavigation { get; set; }
        public virtual ICollection<ProductCategory> InverseParentCategoryNavigation { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
