﻿using FluentValidation;
using MailBox.Models.GroupModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MailBox.Validators
{
    public class NewGroupValidator : AbstractValidator<NewGroup>
    {
        public readonly int nameMaxLength = 30;
        public NewGroupValidator()
        {
            RuleFor(x => x.Name)
                .NotNull()
                .NotEmpty()
                .MaximumLength(nameMaxLength);
        }
    }
}
