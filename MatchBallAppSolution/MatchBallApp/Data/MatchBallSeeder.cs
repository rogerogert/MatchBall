using MatchBallApp.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchBallApp.Data
{
    public class MatchBallSeeder
    {
        private readonly MatchBallContext _ctx;

        public MatchBallSeeder(MatchBallContext ctx)
        {
            _ctx = ctx;
        }
        public void Seed()
        {
            _ctx.Database.EnsureCreated();

            if (!_ctx.Products.Any())
            {
                //Criar dados para testes em ambiente de desenvolvimento
                var product = new Product()
                {
                    Category = "Bebida",
                    Code = "COCA",
                    Description = "Coca Cola Lata 350ml",
                    Price = 3.50m,
                    Id = 1
                };
                var order = new Order()
                {
                    OrderDate = DateTime.Now,
                    OrderNumber = "123",
                    Items = new List<OrderItem>()
                    {
                        new OrderItem()
                        {
                            Product = product,
                            Quantity = 2,
                            UnitPrice = product.Price
                        }
                    }
                };
                _ctx.Orders.Add(order);
                _ctx.SaveChanges();
            }
        }
    }
}
