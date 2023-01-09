using ECommerce.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Entities.Models
{
    public class CartItem : BaseClass
    {
        public int SessionId { get; set; }
        public ShoppingSession SessionDetail { get; set; }
        public int ProductId { get; set; }
        public Product ProductDetail { get; set; }
        public int Quantity { get; set; }
    }
}
