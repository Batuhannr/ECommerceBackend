using ECommerce.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Entities.Base
{
    public class BaseDefinition :IDefinitionTable
    {
        public string Name { get; set; }
    }
}
