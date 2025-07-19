using System;

namespace RecapProject1.Entities
{
    public class Product
    {
        public int ProductID { get; set; }

        public int CategoryID { get; set; }

        public string PRoductName { get; set; }

        public decimal UnitPrice { get; set; }

        // Int16 SmallInt'e karşılık gelir
        public Int16 UnitsInStock { get; set; }

        public string QuantityPerUnit { get; set; }
    }
}
