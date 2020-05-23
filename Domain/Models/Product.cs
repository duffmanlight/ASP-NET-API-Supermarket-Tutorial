using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Supermarket.API.Domain.Models
{
    public class Product
    {
        public int _id { get; set; }
        public string _name { get; set; }
        public short _quantityInPackage { get; set; }
        public EUnitOfMeasurement _unitOfMeasurement { get; set; }
        public int _categoryId { get; set; }
        public Category _category { get; set; }
    }
}
