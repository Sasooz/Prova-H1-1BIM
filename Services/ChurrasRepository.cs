using Prova_H1_1BIM.Models;
namespace Prova_H1_1BIM.Services;


public class ChurrasRepository : IChurrasRepository
{
    private static List<Participantes> ParticipantesList = new List<Participantes>();

    public void Inserir(Participantes novoParticipante)
    {
        ParticipantesList.Add(novoParticipante);
    }
    public List<Participantes> ObterTodosParticipantes()
    {
        return ParticipantesList; 
    }

}


