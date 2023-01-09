using ECommerce.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Entities.Models
{
    public class OrderItems: BaseClass
    {
        public int OrderId { get; set; }
        public OrderDetails OrderDetails { get; set; }
        public int ProductId { get; set; }
        public Product ProductDetail { get; set; }
        public int Quantity { get; set; }
    }
}
