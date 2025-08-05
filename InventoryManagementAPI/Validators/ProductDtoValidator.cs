using FluentValidation;
using InventoryManagementAPI.DTOs;

namespace InventoryManagementAPI.Validators
{
    public class ProductDtoValidator : AbstractValidator<ProductDto>
    {
        public ProductDtoValidator()
        {
            RuleFor(p => p.Name)
                .NotEmpty().WithMessage("Product name is required.")
                .MaximumLength(100);

            RuleFor(p => p.QuantityInStock)
                .GreaterThanOrEqualTo(0);

            RuleFor(p => p.ReorderLevel)
                .GreaterThanOrEqualTo(0);

            RuleFor(p => p.Price)
                .GreaterThan(0);

            RuleFor(p => p.CategoryId)
                .GreaterThan(0);

            RuleFor(p => p.SupplierId)
                .GreaterThan(0);
        }

    }
}
