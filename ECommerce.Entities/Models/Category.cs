using ECommerce.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Entities.Models
{
    public class Category : BaseClass
    {
        public string Name { get; set; }
        public string Description { get; set; }

    }
}
