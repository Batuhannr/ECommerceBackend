using ECommerce.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Entities.Models
{
    public class Product : BaseClass
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string SKU { get; set; }
        public int CategoryId { get; set; }
        public Category CategoryDetail { get; set; }
        public int InventoryId { get; set; }
        public ProductInventory InventoryDetail { get; set; }
        public double Price { get; set; }
        public int DiscountId{ get; set; }
        public Discount DiscountDetail{ get; set; }
    }
}
