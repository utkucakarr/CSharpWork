using NorthWind.Entities.Abstract;
using System;
using System.ComponentModel.DataAnnotations;

namespace NorthWind.Entities.Concrete
{
    public class Product : IEntity
    {
        public int ProductID { get; set; }

        public int CategoryID { get; set; }

        [Required]
        public string ProductName { get; set; }

        public decimal UnitPrice { get; set; }

        public string QuantityPerUnit { get; set; }

        public Int16 UnitsInStock { get; set; }
    }
}
