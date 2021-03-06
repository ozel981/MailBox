
﻿using FluentValidation;
using MailBox.Models.GroupModels;

namespace MailBox.Validators
{
    public class GroupNameUpdateValidator : AbstractValidator<GroupNameUpdate>
    {
        public readonly int nameMaxLength = 30;
        public GroupNameUpdateValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .MaximumLength(nameMaxLength);
        }
    }
}
