using SaraTest.Interfaces;
using SaraTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaraTest.Services
{
    public class RestaurantService:IRestaurantService
    {
        private IGenericRepo _repo;

        public List<Restaurant> GetRestaurantList()
        {
            List<Restaurant> restaurants = _repo.Query<Restaurant>().ToList();
            return restaurants;
        }

        public RestaurantService(IGenericRepo repo)
        {
            _repo = repo;
        }
    }
}
