using FluentValidation;

using MovieStore.Models.Responses;

namespace MovieStore.Validators
{
    public class TestValidator : AbstractValidator<MovieFullDetailsResponse>
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
