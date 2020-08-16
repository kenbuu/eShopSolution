using FluentValidation;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace eShopSolution.ViewModels.System.Users
{
    public class RegisterRequestValidator : AbstractValidator<RegisterRequest>
    {
        public RegisterRequestValidator()
        {
            RuleFor(x => x.FirstName).NotEmpty().WithMessage("First name is requied")
                .MaximumLength(200).WithMessage("First name cannot over 200 characters");

            RuleFor(x => x.LastName).NotEmpty().WithMessage("Last name is requied")
                .MaximumLength(200).WithMessage("Last name cannot over 200 characters");

            RuleFor(x => x.Dob).GreaterThan(DateTime.Now.AddYears(-100)).WithMessage("Birthday cannot greater than 100 years");

            RuleFor(x => x.Email).NotEmpty().WithMessage("Email is requied")
                .Matches(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$")
                .WithMessage("Email format not match");

            RuleFor(x => x.PhoneNumber).NotEmpty().WithMessage("Phone number is requied");

            RuleFor(x => x.UserName).NotEmpty().WithMessage("User name is requied");

            RuleFor(x => x.Password).NotEmpty().WithMessage("Password is requied")
                .MinimumLength(6).WithMessage("Password is at least 6 characters");

            RuleFor(x => x).Custom((request, context) =>
            {
                if (request.ConfirmPassword != request.Password)
                {
                    context.AddFailure("Confirm password is not match");
                }
            });
        }
    }
}
