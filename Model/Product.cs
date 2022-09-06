using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductDetails.Model
{
    public class Product
    {
        public int Id { get; set; }
        public string Product_Name { get; set; }
        public int Product_Code { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }
}
