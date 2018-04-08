using MatchBallApp.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchBallApp.Controllers
{
    [Route("api/[Controller]")]
    public class ProductsController: Controller
    {
        private readonly IMatchBallRepository _repository;
        public ProductsController(IMatchBallRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_repository.GetProducts());
            }
            catch
            {
                return BadRequest("Failed to get products");
            }
        }
    }
}
