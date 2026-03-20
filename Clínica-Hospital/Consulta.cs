using Clínica_Hospital;

public class Consulta
{
    public string Data { get; set; }
    public Paciente Paciente { get; set; }
    public Medico Medico { get; set; }
    public bool Concluida { get; set; }

    public Receita Receita { get; set; }

    private string resumo;

    public void Marcar(Paciente paciente, Medico medico, string data)
    {
        Paciente = paciente;
        Medico = medico;
        Data = data;
        Concluida = false;
        resumo = null;

        Console.WriteLine($"Vínculo estabelecido: {paciente.Nome} <-> {medico.Nome} para o dia {data}.");
    }

    public void Concluir(string resumo)
    {
        this.resumo = resumo;
        Concluida = true;
    }

    public string GetResumo()
    {
        return resumo;
    }
}