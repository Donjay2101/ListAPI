using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ListAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Listing> Get()
        {
            var list = new List<Listing>
            {
                new Listing
                {
                    Id=1,
                    Description="A very old boat. Bargain price",
                    Name="Old Boat",
                    Price=3000
                },
                new Listing
                {
                    Id=2,
                    Description="Computer",
                    Name="From the 1990s, a classic!",
                    Price=4000
                },
                new Listing
                {
                    Id=3,
                    Description="Good condition, free delivery",
                    Name="Basketball Hoop",
                    Price=3000
                },
                 new Listing
                {
                    Id=4,
                    Description="Bicycle",
                    Name="Bright blue, very fast",
                    Price=1000
                },
            };

            return list;
        }

        [HttpGet("myListings")]
        public IEnumerable<Listing> myListings()
        {
            var list = new List<Listing>
            {
                new Listing
                {
                    Id=1,
                    Description="A very old boat. Bargain price",
                    Name="Old Boat",
                    Price=3000
                },
                new Listing
                {
                    Id=2,
                    Description="Computer",
                    Name="From the 1990s, a classic!",
                    Price=4000
                }
            };

            return list;
        }
    }

    public class Listing
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
    }
}
