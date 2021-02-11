using System;

namespace ProductInventory.Shared
{
    public class ProductInventory
    {
        public Product Product { get; set; }
        public ProductType ProductType { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? Price { get; set; }

        public decimal? Total { get => Quantity * Price; }

    }
}
