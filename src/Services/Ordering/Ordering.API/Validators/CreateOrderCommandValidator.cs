using FluentValidation;
using Ordering.API.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordering.API.Validators
{
    public class CreateOrderCommandValidator : AbstractValidator<CreateOrderCommand>
    {
        public CreateOrderCommandValidator()
        {
            RuleFor(x => x.BuyerId).NotNull().GreaterThan(0);
            RuleFor(x => x.Description).MinimumLength(5);
        }
    }
}
