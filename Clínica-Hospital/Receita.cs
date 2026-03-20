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

   
}