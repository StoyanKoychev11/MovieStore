using FluentValidation;
using MovieStore.Controllers;

namespace MovieStore.Validators
{
    public class TestValidator : AbstractValidator<AddMovieRequest>
    {
        public TestValidator()
        {
             RuleFor(x => x.Title)
            .NotNull().NotEmpty();
            RuleFor(x => x.Year)
            .NotNull()
           .NotEmpty();
                
        }

    }
}
