using EntityLayer.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Validator
{
    public class UserValidator:AbstractValidator<Users>
    {
        public UserValidator() 
        {
            RuleFor(i => i.Username).NotEmpty().WithMessage("Username can not be empty");
            RuleFor(i => i.Password).NotEmpty().WithMessage("Password can not be empty");
            RuleFor(i => i.Phone).NotEmpty().WithMessage("Phone can not be empty");

            RuleFor(i => i.Username).MinimumLength(3).WithMessage("Username must be more than 3 word");
            RuleFor(i => i.Password).MinimumLength(3).WithMessage("Password must be more than 3 word");
            RuleFor(i => i.Phone).MinimumLength(11).WithMessage("Phone must be 11 number");

            RuleFor(i => i.Username).MaximumLength(20).WithMessage("Password must be less than 20 word");
            RuleFor(i => i.Password).MaximumLength(20).WithMessage("Password must be more than 20 word");
            RuleFor(i => i.Phone).MaximumLength(11).WithMessage("Phone must be 11 number");
            
        }
    }
}
