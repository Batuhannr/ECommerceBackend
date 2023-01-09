using ECommerce.Business.Services;
using ECommerce.DataAccess.Interfaces;
using ECommerce.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Business.Concreate
{
    public class CategoryManager: GenericManager<Category>, ICategoryService
    {
        public CategoryManager(ICategoryDal _categoryDal) : base(_categoryDal)
        {

        }
    }
}
