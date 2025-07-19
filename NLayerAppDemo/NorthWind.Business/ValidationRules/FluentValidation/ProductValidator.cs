using FluentValidation;
using NorthWind.Entities.Concrete;

namespace NorthWind.Business.ValidationRules.FluentValidation
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(x => x.ProductName).NotEmpty().WithMessage("Ürün ismi boş olamaz");
            RuleFor(x => x.CategoryID).NotEmpty();
            RuleFor(x => x.UnitPrice).NotEmpty();
            RuleFor(x => x.QuantityPerUnit).NotEmpty();
            RuleFor(x => x.UnitsInStock).NotEmpty();

            RuleFor(x => x.UnitPrice).GreaterThan(0);
            RuleFor(x => x.UnitsInStock).GreaterThanOrEqualTo((short)0);
            RuleFor(x => x.UnitPrice).GreaterThan(10).When(x => x.CategoryID == 2);

            // Must ile kendimiz kural yazabiliroyuz.
            RuleFor(x => x.ProductName).Must(StarWithA).WithMessage("Ürün Adı A ile başlamalı");

        }

        private bool StarWithA(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}
