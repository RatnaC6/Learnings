using System;
using System.Collections.Generic;

#nullable disable

namespace Sess1.Models
{
    public partial class Productsinstock
    {
        public short? ProductId { get; set; }
        public string ProductName { get; set; }
        public short? SupplierId { get; set; }
        public short? CategoryId { get; set; }
        public string QuantityPerUnit { get; set; }
        public float? UnitPrice { get; set; }
        public short? UnitsInStock { get; set; }
        public short? UnitsOnOrder { get; set; }
        public short? ReorderLevel { get; set; }
        public int? Discontinued { get; set; }
    }
}
