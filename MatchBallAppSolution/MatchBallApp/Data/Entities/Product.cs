using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchBallApp.Data.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

    }
}
