using RestaurantApi.Enitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantApi
{
    public class RestaurantSeeder
    {
        private readonly RestaurantDbContext _dbContext;
        public RestaurantSeeder(RestaurantDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void Seed()
        {
            if (_dbContext.Database.CanConnect())
            {
                if (!_dbContext.Restaurants.Any())
                {
                    var restaurants = GetRestaurants();
                    _dbContext.Restaurants.AddRange(restaurants);
                    _dbContext.SaveChanges();
                }
            }

        }

        private IEnumerable<Restaurant> GetRestaurants()
        {
            var restaurants = new List<Restaurant>()
            {
                new Restaurant()
                {
                    Name = "KFC",
                    Category = "Fast Food",
                    Description = "Kurczaki z momu przemielone razem z klatkami",
                    ContactEmail = "cotact@kfc.com",
                    HasDelivery = true,
                    Dishes = new List<Dish>()
                    {
                         new Dish()
                        {
                            Name = "nashville Hot Chiken",
                            Price = 10.30M,
                        },

                        new Dish()
                        {
                            Name = "Chicken nuggets",
                            Price = 5.30M,
                        },
                    },
                    Address = new Address()
                    {
                        City = "Kraków",
                        Street = "Długa 5",
                        PostalCode = "30-001",
                    }
                },

                new Restaurant()
                {
                    Name = "Mc Donald",
                    Category = "Fast food",
                    Description = "Krowy zmielone razem z łańcuchami",
                    ContactEmail = "contact@mcdonald.com",
                    HasDelivery = false,
                    Dishes = new List<Dish>()
                    {
                         new Dish()
                        {
                            Name = "Big Mac",
                            Price = 11.30M,
                        },

                        new Dish()
                        {
                            Name = "happy Meal",
                            Price = 7.30M,
                        },
                    },
                    Address = new Address()
                    {
                        City = "Warszawa",
                        Street = "Szeroka 5",
                        PostalCode = "00-001",
                    }
                },

            };
            return restaurants;
        }
    }
}
