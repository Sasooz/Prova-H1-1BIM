using System.ComponentModel.DataAnnotations;

namespace Prova_H1_1BIM.Validations;

public class RegrasChurrasValidations : ValidationAttribute
{
    protected override ValidationResult? IsValid(Object? value, ValidationContext validationContext)
    {
        if (value == null)
        {
            return new ValidationResult(ErrorMessage);
        }

        int Idade = (int)value;

        return Idade < 18 ? ValidationResult.Success : new ValidationResult(ErrorMessage);
    }
}

