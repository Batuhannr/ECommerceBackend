using ECommerce.Business.Concreate;
using ECommerce.Business.Services;
using ECommerce.Entities.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceBackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private ICategoryService _categoryManager;
        public CategoryController(ICategoryService categoryManager)
        {
            _categoryManager = categoryManager; 
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            List<Category> categories = new List<Category>();
            categories = await _categoryManager.GetAllAsync();
            if (categories.Count > 0)
            {
                return Ok(categories);
            }
            else
            {
                return BadRequest("Don't Found Category");    
            }
        }
    }
}
