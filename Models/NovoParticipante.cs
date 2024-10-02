using System.ComponentModel.DataAnnotations;
using Prova_H1_1BIM.Validations;
namespace Prova_H1_1BIM.Models;

public class NovoParticipante
{
    [Required(ErrorMessage = "Obrigatório")]
    [MaxLength(20, ErrorMessage = "Maximo 20 letras ")]
    public string Nome { get; set; }

    [Required(ErrorMessage = "Obrigatório")]
    [MaxLength(200, ErrorMessage = "Descrição máxima 200 letras")]
    public string DescricaoCarne { get; set; }

    [Required(ErrorMessage = "Obrigatório")]
    [MaxLength(200, ErrorMessage = "Descrição máxima 200 letras")]
    public string DescricaoBebida { get; set; }

    [Required(ErrorMessage = "Obrigatório")]
    [RegrasChurrasValidations(ErrorMessage = "Erro idade")]
    public int Idade { get; set; }
}
