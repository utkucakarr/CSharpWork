using System;

namespace BuilderDesign
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Örnek olarak e ticaret sitesinde yeni gelen kullanıcıyla eski kullanıcaya gösterilen ürün listesini farklı göstermek istediğimizde.
            ProductDirector director = new ProductDirector();
            var builder = new OldCustomerProductBuilder(new ProductViewModel());
            director.GenerateProduct(builder);
            var model = builder.GetModel();

            Console.WriteLine(model.Id);
            Console.WriteLine(model.ProductName);
            Console.WriteLine(model.CategoryName);
            Console.WriteLine(model.DiscountApplied);
            Console.WriteLine(model.Discount);
            Console.WriteLine(model.UnitPrice);

            Console.ReadLine();
        }
    }

    class ProductViewModel
    {
        public int Id { get; set; }

        public string CategoryName { get; set; }

        public string ProductName { get; set; }

        public decimal UnitPrice { get; set; }

        public decimal Discount { get; set; }

        public bool DiscountApplied { get; set; }
    }

    abstract class ProductBuilder
    {
        public abstract void GetProductData();

        public abstract void ApplyDiscount();

        public abstract ProductViewModel GetModel();
    }

    class NewCustomerProductBuilder : ProductBuilder
    {
        private readonly ProductViewModel _productViewModel;

        public NewCustomerProductBuilder(ProductViewModel productViewModel)
        {
            _productViewModel = productViewModel;
        }

        public override void ApplyDiscount()
        {
            _productViewModel.Discount = _productViewModel.UnitPrice * (decimal) 0.90;
            _productViewModel.DiscountApplied = true;
        }

        public override ProductViewModel GetModel()
        {
            return _productViewModel;
        }

        public override void GetProductData()
        {
            _productViewModel.Id = 1;
            _productViewModel.CategoryName = "Beverages";
            _productViewModel.ProductName = "Chai";
            _productViewModel.UnitPrice = 20;
        }
    }

    class OldCustomerProductBuilder : ProductBuilder
    {
        private readonly ProductViewModel _productViewModel;

        public OldCustomerProductBuilder(ProductViewModel productViewModel)
        {
            _productViewModel = productViewModel;
        }

        public override void ApplyDiscount()
        {
            _productViewModel.Discount = _productViewModel.UnitPrice;
            _productViewModel.DiscountApplied = false;
        }

        public override ProductViewModel GetModel()
        {
            return _productViewModel;
        }

        public override void GetProductData()
        {
            _productViewModel.Id = 1;
            _productViewModel.CategoryName = "Beverages";
            _productViewModel.ProductName = "Chai";
            _productViewModel.UnitPrice = 20;
        }
    }

    class ProductDirector
    {
        public void GenerateProduct(ProductBuilder productBuilder)
        {
            productBuilder.GetProductData();
            productBuilder.ApplyDiscount();
        }
    }
}
