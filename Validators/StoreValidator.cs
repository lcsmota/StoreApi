using System.Text.RegularExpressions;
using FluentValidation;
using StoreApi.Models;

namespace StoreApi.Validators;

public class StoreValidator : AbstractValidator<Store>
{
    public StoreValidator()
    {
        RuleFor(e => e.StoreName)
            .NotEmpty()
            .NotNull()
            .MaximumLength(255).WithMessage("Maximum length must be 255 characters")
            .MinimumLength(6).WithMessage("Minimum length must be 6 characters")
            .WithMessage("Invalid name");

        RuleFor(e => e.Phone)
            .NotEmpty()
            .NotNull().WithMessage("Phone is required")
            .MaximumLength(20).WithMessage("Mamixum length must be 20 digits")
            .Must(phone => Regex.IsMatch(phone, @"^[+]?[(]?[0-9]{1,3}[)]?[-\s.]?[0-9]{1,3}[-\s.]?[0-9]{2,4}[-\s.]?[0-9]{2,4}$"))
            .WithMessage("Invalid phone number");

        RuleFor(e => e.Email)
            .NotEmpty()
            .NotNull().WithMessage("Phone is required")
            .EmailAddress().WithMessage("Invalid email");

        RuleFor(e => e.Street)
            .NotEmpty()
            .NotNull().WithMessage("Street is required")
            .MaximumLength(255).WithMessage("Maximum length must be 255 characters")
            .MinimumLength(6).WithMessage("Minimum length must be 6 characters");

        RuleFor(e => e.City)
            .NotEmpty()
            .NotNull().WithMessage("City is required")
            .MaximumLength(80).WithMessage("Maximum length must be 80 characters")
            .MinimumLength(6).WithMessage("Minimum length must be 6 characters");

        RuleFor(e => e.State)
            .NotEmpty()
            .NotNull().WithMessage("State is required")
            .MaximumLength(40).WithMessage("Maximum length must be 40 characters")
            .MinimumLength(6).WithMessage("Minimum length must be 6 characters");
    }
}
