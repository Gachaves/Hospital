using Clínica_Hospital;

public class Receita
{
    private List<string> medicamentos = new List<string>();

    public Consulta Consulta { get; set; } 

    public void AdicionarMedicamento(string nome, string dose)
    {
        medicamentos.Add(nome + " - " + dose);
    }

    public void RemoverMedicamento(string nome)
    {
        medicamentos.RemoveAll(m => m.Contains(nome));
    }

    public List<string> ListarMedicamentos()
    {
        return medicamentos;
    }

    public void MostrarReceita()
    {
        Console.WriteLine("\n=== RECEITA MÉDICA ===");

        if (Consulta != null)
        {
            Console.WriteLine("Paciente: " + Consulta.Paciente.Nome);
            Console.WriteLine("Médico: " + Consulta.Medico.Nome);
            Console.WriteLine("Data: " + Consulta.Data);
        }

        Console.WriteLine("\nMedicamentos:");
        foreach (string m in medicamentos)
        {
            Console.WriteLine("- " + m);
        }

        Console.WriteLine("======================\n");
    }
}