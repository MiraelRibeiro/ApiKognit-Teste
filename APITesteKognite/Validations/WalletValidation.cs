using APITesteKognite.Models.Dtos;
using FluentValidation;

namespace APITesteKognite.Validations
{
    public class WalletValidation : AbstractValidator<WalletDto>
    {
        public WalletValidation()
        {
            RuleFor(c => c.UserID)
                .NotEmpty()
                .NotNull()
                .WithMessage("O campo UserID deve ser informado");

            RuleFor(c => c.Banco)
                .NotEmpty()
                .NotNull()
                .WithMessage("O campo Banco deve ser informado");

            RuleFor(c => c.ValorAtual)
                .NotEmpty()
                .NotNull()
                .WithMessage("O campo de valor atual deve ser informado");

        }
    }
}
