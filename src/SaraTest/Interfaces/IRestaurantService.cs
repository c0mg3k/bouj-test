using System.Collections.Generic;
using SaraTest.Models;

namespace SaraTest.Interfaces
{
    public interface IRestaurantService
    {
        List<Restaurant> GetRestaurantList();
    }
}