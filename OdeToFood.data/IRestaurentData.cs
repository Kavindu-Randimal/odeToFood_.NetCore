using System;
using System.Collections.Generic;
using OdeToFood.core;
using System.Linq;

namespace OdeToFood.data
{
    public interface IRestaurentData
    {
        IEnumerable<Restaurent> GetAll();
    }

    public class InMemoryRestaurentData : IRestaurentData
    {
        List<Restaurent> restaurent;

        public InMemoryRestaurentData()
        {
            restaurent = new List<Restaurent>() {
                    new Restaurent { Id = 1, Name = "PIZZA", Location = "London", Cuisine = CuisineType.indian},
                    new Restaurent { Id = 2, Name = "ddf", Location = "London", Cuisine = CuisineType.indian},
                    new Restaurent { Id = 3, Name = "sdfsdfd", Location = "London", Cuisine = CuisineType.indian}
            };
        }

        public IEnumerable<Restaurent> GetAll()
        {
            return from r in restaurent
                   orderby r.Name
                   select r;
        }
    }

}
