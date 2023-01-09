using ECommerce.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Entities.Models
{
    public class UserAddress 
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User UserDetail { get; set; }
        public string AddressLineFirst { get; set; }
        public string AddressLineSecond { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Telephone { get; set; }
        public string Mobile { get; set; }
    }
}
