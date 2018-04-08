using System.Collections.Generic;
using MatchBallApp.Data.Entities;

namespace MatchBallApp.Data
{
    public interface IMatchBallRepository
    {
        IEnumerable<Product> GetProducts();
        IEnumerable<Product> GetProductsByCategory(string category);
    }
}