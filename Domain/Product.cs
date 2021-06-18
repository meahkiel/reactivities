using System;
using System.Collections.ObjectModel;

namespace Domain
{
    
    public class Product : BaseDomain
    {
        
        public string Series { get; set; }
        public string ItemCode { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Model { get; set; }

        public string Division { get; set; }

        public string ItemType { get; set; }
        public string ItemSubType { get; set; }
        
        public string UnitOfMeasure { get; set; }

        public decimal SupplierCost { get; set; }
        public decimal ArrivalCost { get; set; }
        public decimal TotalCost { get; set; }

        public string AgentCode { get; set; }

        public string SupplierCode { get; set; }

        public bool IsActive { get; set; }

        public Collection<ProductPrice> Prices { get; set; }
        
    }
}