using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopGiaySolution.ViewModels.System.Users
{
    public class LoginRequestValidator : AbstractValidator<LoginRequest>
    {
        public LoginRequestValidator()
        {
            RuleFor(x => x.UserName).NotEmpty().WithMessage("UserName khong duoc rong");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Password khong duoc rong").MinimumLength(6).WithMessage("Password khong duoc qua 6 ky tu");

        }
    }
}
