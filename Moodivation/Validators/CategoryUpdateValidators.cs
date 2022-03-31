using FluentValidation;
using Moodivation.Entities.Dtos;

namespace Moodivation.Validators
{
    public class CategoryUpdateValidators : AbstractValidator<CategoryUpdateDto>
    {
        public CategoryUpdateValidators()
        {
            RuleFor(c => c.Name).NotEmpty().WithMessage("Enter category name");
        }
    }
}
