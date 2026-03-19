public class Consulta
{
    public string Data { get; set; }
    public Paciente Paciente { get; set; }
    public Medico Medico { get; set; }
    public bool Concluida { get; set; }

    
    public void Marcar(Paciente paciente, Medico medico, string data)
    {
        this.Paciente = paciente; 
        this.Medico = medico;     
        this.Data = data;
        this.Concluida = false;
        Console.WriteLine($"Vínculo estabelecido: {paciente.Nome} <-> {medico.Nome} para o dia {data}.");
    }

    public void Concluir(string resumo)
    {
        this.Concluida = true;
        Console.WriteLine($"Consulta concluída com sucesso. Resumo: {resumo}");
    }
    public string GetResumo()
    {
        return $"Consulta de {Paciente.Nome} com Dr. {Medico.Nome} em {Data}. Status: {(Concluida ? "Finalizada" : "Pendente")}";
    }
}