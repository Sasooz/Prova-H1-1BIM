using Prova_H1_1BIM.Models;
namespace Prova_H1_1BIM.Services;

public interface IChurrasRepository
{
    public List<Participantes> ObterTodosParticipantes();

    public void Inserir(Participantes novoParticipante);

}
