﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Entities.Abstract
{
    public interface ITable
    {
        int Id { get; set; }
        bool Deleted { get; set; }
    }
}
