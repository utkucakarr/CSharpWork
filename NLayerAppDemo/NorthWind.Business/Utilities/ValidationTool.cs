using FluentValidation;
using NorthWind.Business.ValidationRules.FluentValidation;

namespace NorthWind.Business.Utilities
{
    public static class ValidationTool
    {
        public static void Validate(IValidator validator, object entity)
        {
            ProductValidator productValidator = new ProductValidator();
            var result = validator.Validate(entity);
            if (result.Errors.Count > 0)
            {
                throw new ValidationException(result.Errors);
            }
        }
    }
}
