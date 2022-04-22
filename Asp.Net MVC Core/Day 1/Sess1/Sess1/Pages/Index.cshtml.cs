using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Sess1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sess1.Pages
{
    public class IndexModel : PageModel
    {
        public List<Product> products = new List<Product>();

        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;

            products.AddRange(
                new Product[]
                {
                    new Product{Name = "abc", Price = 45.3},
                    new Product{Name = "pqr", Price = 75.8},
                    new Product{Name = "xyz", Price = 35.4}
                });
        }

        public void OnGet()
        {

        }

        public void OnPost()
        {

        }
    }
}
