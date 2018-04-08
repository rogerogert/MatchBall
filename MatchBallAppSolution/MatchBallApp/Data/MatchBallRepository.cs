using MatchBallApp.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchBallApp.Data
{
    public class MatchBallRepository : IMatchBallRepository
    {
        private readonly MatchBallContext _ctx;
        public MatchBallRepository(MatchBallContext ctx)
        {
            _ctx = ctx;
        }
        public IEnumerable<Product> GetProducts()
        {
            return _ctx.Products
                        .OrderBy(p => p.Code)
                        .ToList();
        }
        public IEnumerable<Product> GetProductsByCategory(string category)
        {
            return _ctx.Products
                        .Where(p => p.Category == category)
                        .ToList();
        }
        
    }
}
