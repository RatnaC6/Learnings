using System;
using Npgsql;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Sess3
{
    class Program
    {
        static void Main(string[] args)
        {
            NorthwindContext context = new NorthwindContext();

            var allProductNames = from product in context.Products
                                  select product.ProductName;

            //foreach (var item in allProductNames)
            //{
            //    Console.WriteLine(item);
            //}

            var allProductsWithPrice = from product in context.Products
                                       orderby product.UnitPrice descending
                                       select new { Name = product.ProductName, Price = product.UnitPrice }; ;
            foreach (var item in allProductsWithPrice)
            {
                Console.WriteLine(item);
            }
        }
    }
}
