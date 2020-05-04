using Microsoft.AspNetCore.Mvc;
using ShoppingApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingApi.Controllers
{
    public class ShoppingListController : ControllerBase
    {
        
        [HttpGet("shoppinglist")]
        public async Task<ActionResult> GetFullShoppingList()
        {
            // Step 1
            var response = new GetShoppingListResponse();
            // Step 2??

            // Step 3 PROFIT!
            return Ok(response);
        }
    }
}
