
namespace Clínica_Hospital;

public class Medico
{
    public string Nome { get; set; }


    public void AgendarAtendimento(Paciente paciente, string data)
    {
        Console.WriteLine($"Médico {Nome} confirmou agenda para {paciente.Nome} em {data}.");
    }
    public List<Consulta> ListarConsultas() => new List<Consulta>();

    public void EmitirReceita(Consulta consulta, Receita receita)
    {

        if (consulta.Concluida)
        {
            consulta.Receita = receita;
            receita.Consulta = consulta;
        }
    }
}