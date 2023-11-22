using Entities.Concretes;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class CourseValidator : AbstractValidator<Course>
    {
        public CourseValidator()
        {
            RuleFor(c => c.Name).NotEmpty();
            RuleFor(c => c.Name).MinimumLength(5);
            RuleFor(c => c.Price).NotEmpty();
            RuleFor(c => c.Price).GreaterThanOrEqualTo(10);
            RuleFor(c => c.Price).GreaterThan(10).When(p => p.CategoryId == 1);
            RuleFor(c => c.CategoryId).NotEmpty();
            RuleFor(c => c.CategoryId).GreaterThan(0);
            RuleFor(c => c.Name).Must(StartWithZ).WithMessage("Ürünler Z harfiyle başlamalı! xD");

        }

        private bool StartWithZ(string arg)
        {
            return arg.StartsWith("Z");
        }
    }
}
