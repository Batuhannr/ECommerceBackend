using ECommerce.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Entities.Models
{
    public class OrderDetails : BaseClass
    {
        public int UserId { get; set; }
        public User UserDetail { get; set; }
        public double Total { get; set; }
        public int PaymentId { get; set; }
        public PaymentDetail PaymentDetail { get; set; }
    }
}
