using ECommerce.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Entities.Models
{
    public class PaymentDetail : BaseClass
    {
        public int OrderId { get; set; }
        public int Amount{ get; set; }
        public string Provider{ get; set; }
        public string Status{ get; set; }
    }
}
