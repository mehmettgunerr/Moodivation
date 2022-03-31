﻿using FluentValidation;
using Moodivation.Entities.Dtos;

namespace Moodivation.Validators
{
    public class ProductCreateValidators : AbstractValidator<ProductCreateDto>
    {
        public ProductCreateValidators()
        {
            RuleFor(c => c.CategoryId).NotEmpty().WithMessage("Select a category");
            RuleFor(c => c.Name).NotEmpty().WithMessage("Enter product name");
            RuleFor(c => c.Description).NotEmpty().WithMessage("Enter product description");
            RuleFor(c => c.Price).NotEmpty().WithMessage("Enter product price").ScalePrecision(2, 6).WithMessage("Wrong format");
            RuleFor(c => c.Stock).InclusiveBetween(1, int.MaxValue).WithMessage("Enter product stock");
        }
    }
}
