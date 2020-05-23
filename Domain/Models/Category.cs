using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Supermarket.API.Domain.Models
{
    public class Category
    {
        public int _id { get; set; }
        public string _name { get; set; }
        public IList<Product> _products { get; set; } = new List<Product>();
    }
}