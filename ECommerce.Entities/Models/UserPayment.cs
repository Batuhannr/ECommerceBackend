using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ECommerce.Entities.Models.ECommerceEnums;

namespace ECommerce.Entities.Models
{
    public class UserPayment
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User UserDetail { get; set; }
        public PaymentType PaymentType { get; set; }
        public string Provider { get; set; }
        public int AccountNo { get; set; }
        public DateTime Expiry { get; set; }
    }
}
