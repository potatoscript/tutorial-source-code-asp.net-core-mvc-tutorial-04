using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using WebApplication5.Models;

namespace WebApplication5.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {

        public IConfiguration _configuration;

        public WeatherForecastController(IConfiguration configuration)
        {
            _configuration = configuration;
        }


        [HttpGet]
        public IEnumerable<Food> Get()
        {
            using(var _context= new FoodDBContext(_configuration))
            {

                Food food = _context.Foods.First(a => a.FoodId == 2);

                _context.Foods.Remove(food);

                _context.SaveChanges();

                return _context.Foods.ToList();
            }

            
            
        }
    }
}
