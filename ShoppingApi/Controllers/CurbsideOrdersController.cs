using Microsoft.AspNetCore.Mvc;
using ShoppingApi.Data;
using ShoppingApi.Mappers;
using ShoppingApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingApi.Controllers
{
    public class CurbsideOrdersController : ControllerBase 
    {
        private readonly IMapCurbsideOrders CurbsideMapper;

        public CurbsideOrdersController(IMapCurbsideOrders curbsideMapper)
        {
            CurbsideMapper = curbsideMapper;
        }

        [HttpPost("curbsideorders")]
        public async Task<ActionResult> PlaceOrder([FromBody] CreateCurbsideOrder orderToPlace)
        {
            // 1. Validate It (bad? return 400)
            // 2. Save it to the database - (e.g. do domain stuff)
            // 3. Return
            //      201 Created
            //      Location Header with the location of the new resource
            //      A copy of the entity they would get if they did a GET to the location
            CurbsideOrder response = await CurbsideMapper.PlaceOrder(orderToPlace);
            return Ok(response);
        }
    }
}
