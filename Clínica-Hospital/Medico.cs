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
            Console.WriteLine($"Receita emitida pelo Dr. {Nome} para o paciente {consulta.Paciente.Nome}.");
        }
        else
        {
            Console.WriteLine("ERRO: Não é possível emitir receita para uma consulta não concluída.");
        }
    }
}