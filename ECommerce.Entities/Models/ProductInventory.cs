using ECommerce.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Entities.Models
{
    public class ProductInventory : BaseClass
    {
        public int Quantity { get; set; }
    }
}
