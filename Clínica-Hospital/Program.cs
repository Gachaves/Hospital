using Clínica_Hospital;
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Hospital hospital = new Hospital();

        // Pacientes
        Paciente paciente1 = new Paciente("joao@.com");
        paciente1.Nome = "João";

        Paciente paciente2 = new Paciente("maria@.com");
        paciente2.Nome = "Maria";

        hospital.CadastrarPaciente(paciente1);
        hospital.CadastrarPaciente(paciente2);

        // Médicos
        Medico medico1 = new Medico();
        medico1.Nome = "Dr. Silva";

        Medico medico2 = new Medico();
        medico2.Nome = "Dra. Ana";

        hospital.CadastrarMedico(medico1);
        hospital.CadastrarMedico(medico2);

        Console.WriteLine("=================================");
        Console.WriteLine("      SISTEMA DO HOSPITAL");
        Console.WriteLine("=================================\n");

        Consulta consulta1 = new Consulta();
        consulta1.Marcar(paciente1, medico1, "20/03/2026");

        Consulta consulta2 = new Consulta();
        consulta2.Marcar(paciente2, medico2, "20/03/2026");

        Consulta consulta3 = new Consulta();
        consulta3.Marcar(paciente1, medico2, "21/03/2026");

        hospital.RegistrarConsulta(consulta1);
        hospital.RegistrarConsulta(consulta2);
        hospital.RegistrarConsulta(consulta3);

        consulta1.Concluir("Dor de cabeça leve");
        consulta2.Concluir("Febre alta");

        Receita receita1 = new Receita();
        receita1.AdicionarMedicamento("Paracetamol", "500mg");

        Receita receita2 = new Receita();
        receita2.AdicionarMedicamento("Ibuprofeno", "400mg");

        medico1.EmitirReceita(consulta1, receita1);
        consulta1.Receita = receita1;
        receita1.Consulta = consulta1;

        medico2.EmitirReceita(consulta2, receita2);
        consulta2.Receita = receita2;
        receita2.Consulta = consulta2;


        Console.WriteLine("\n=================================");
        Console.WriteLine("        CONSULTAS GERAIS");
        Console.WriteLine("=================================\n");

        List<Consulta> todasConsultas = new List<Consulta>();
        todasConsultas.AddRange(hospital.ListarConsultasDoDia("20/03/2026"));
        todasConsultas.AddRange(hospital.ListarConsultasDoDia("21/03/2026"));

        foreach (Consulta c in todasConsultas)
        {
            Console.WriteLine("=================================");
            Console.WriteLine("CONSULTA");
            Console.WriteLine("=================================");

            Console.WriteLine("Paciente : " + c.Paciente.Nome);
            Console.WriteLine("Médico   : " + c.Medico.Nome);
            Console.WriteLine("Data     : " + c.Data);
            Console.WriteLine("Status   : " + (c.Concluida ? "Concluída" : "Pendente"));

            if (c.Receita != null)
            {
                Console.WriteLine("\nReceita:");
                List<string> meds = c.Receita.ListarMedicamentos();

                foreach (string m in meds)
                {
                    Console.WriteLine("- " + m);
                }
            }
            else
            {
                Console.WriteLine("\nReceita: Nenhuma");
            }

            Console.WriteLine("=================================\n");
        }

        Console.WriteLine("FIM DO SISTEMA");
    }
}