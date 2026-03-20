using System;

namespace Clínica_Hospital
{
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
            this.Paciente = paciente;
            this.Medico = medico;
            this.Data = data;
            this.Concluida = false;
            this.resumo = null;
            Console.WriteLine($"Vínculo estabelecido: {paciente.Nome} <-> {medico.Nome} para o dia {data}.");
        }

        public void Concluir(string resumo)
        {
            this.resumo = resumo;
            this.Concluida = true;
        }

        public string GetResumo()
        {
            return this.resumo;
        }
    }
}