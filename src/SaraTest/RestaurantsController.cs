using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SaraTest.Interfaces;
using SaraTest.Models;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace SaraTest
{
    [Route("api/[controller]")]
    public class RestaurantsController : Controller
    {
        private IRestaurantService _rService;
        [HttpGet]
        public IActionResult Get()
        {
            List<Restaurant> restuarants = _rService.GetRestaurantList();

            if(restuarants != null)
            {
                return Ok(restuarants);
            }
            else
            {
                return BadRequest();
            }
        }

        public RestaurantsController(IRestaurantService rService)
        {
            _rService = rService;
        }
    }
}
