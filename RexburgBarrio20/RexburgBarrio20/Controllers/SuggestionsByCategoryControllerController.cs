using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RexburgBarrio20.Models;
using RexburgBarrio20.Services;

namespace RexburgBarrio20.Controllers
{
    [Route("api/[controller]")]
    public class SuggestionsByCategoryController : Controller
    {
        [HttpGet("[action]")]
        public IEnumerable<Category> GetSuggestionsByCategories()
        {
            return Data.GetCategoriesData();
        }       
    }
}
