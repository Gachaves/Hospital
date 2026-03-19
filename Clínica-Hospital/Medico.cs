using Clínica_Hospital;
using System;
using System.Collections.Generic;

public class Medico
{
    public string Nome { get; set; }

    private List<Consulta> consultas = new List<Consulta>(); // ✅ lista real

    public List<Consulta> ListarConsultas()
    {
        return consultas;
    }

    public void AgendarAtendimento(Paciente paciente, string data)
    {
        Consulta consulta = new Consulta();
        consulta.Marcar(paciente, this, data);

        consultas.Add(consulta);

        Console.WriteLine($"Médico {Nome} confirmou agenda para {paciente.Nome} em {data}.");
    }

    public void EmitirReceita(Consulta consulta, Receita receita)
    {
        if (consulta.Concluida)
        {
            receita.Consulta = consulta;

            Console.WriteLine($"Receita emitida pelo Dr. {Nome} para {consulta.Paciente.Nome}.");
        }
        else
        {
            Console.WriteLine("ERRO: Não é possível emitir receita para uma consulta não concluída.");
        }
    }
}