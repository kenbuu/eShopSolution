using eShopSolution.ViewModels.System.Users;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Application.System.Users
{
    public class LoginRequestValidator : AbstractValidator<LoginRequest>
    {
        public LoginRequestValidator()
        {
            RuleFor(x => x.UserName).NotEmpty().WithMessage("User name is requied");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Password is requied")
                .MinimumLength(6).WithMessage("Password is at least 6 character");
        }
    }
}
