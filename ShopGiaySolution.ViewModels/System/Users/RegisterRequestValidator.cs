using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopGiaySolution.ViewModels.System.Users
{
    public class RegisterRequestValidator : AbstractValidator<RegisterRequest>
    {
        public RegisterRequestValidator()
        {
            RuleFor(x => x.FirstName).NotEmpty().WithMessage("FirtName khong duoc rong").MaximumLength(200).WithMessage("FirtName khong duoc qua 200 ky tu");
            RuleFor(x => x.LastName).NotEmpty().WithMessage("LastName khong duoc rong").MaximumLength(200).WithMessage("LastName khong duoc qua 200 ky tu");
            RuleFor(x => x.Dob).GreaterThan(DateTime.Now.AddYears(-100)).WithMessage("Ngay sinh khong duoc lon hon 100");
            RuleFor(x => x.Email).NotEmpty().WithMessage("Email khong duoc rong").Matches(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$").WithMessage("Dinh dang Email khong dung");
            RuleFor(x => x.PhoneNumber).NotEmpty().WithMessage("So dien thoai khong duoc lon hon 100");
            RuleFor(x => x.UserName).NotEmpty().WithMessage("UserName khong duoc rong");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Password khong duoc rong").MinimumLength(6).WithMessage("Password it nhat 6 ky tu");
            RuleFor(x => x).Custom((request, context) =>
            {
                if (request.Password != request.ConfirmPassword )
                {
                    context.AddFailure("Mat khau khong trung khop");
                }
            });

        }

    }
}
