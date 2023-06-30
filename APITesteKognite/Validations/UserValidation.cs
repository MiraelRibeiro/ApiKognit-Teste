using APITesteKognite.Models.Dtos;
using FluentValidation;

namespace APITesteKognite.Validations
{
    public class UserValidation : AbstractValidator<UserDto>
    {
        public UserValidation()
        {
            RuleFor(c => c.Nome)
                .NotEmpty()
                .NotNull()
                .WithMessage("O campo nome deve ser informado");

            RuleFor(c => c.Nascimeto)
                .NotEmpty()
                .NotNull()
                .WithMessage("O campo de Data de Nascimento deve ser informado");

            RuleFor(c => c.CPF)
                .NotEmpty()
                .NotNull()
                .WithMessage("O campo CPF deve ser informado");

        }
    }
}
