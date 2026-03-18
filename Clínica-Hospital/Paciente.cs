using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clínica_Hospital
{
    public class Paciente
    {
        private string contato;
        private List<Consulta> consultas = new List<Consulta>();

        public Paciente(string contato)
        {
            this.contato = contato;
        }

        // Agendar consulta conforme UML
        public void AgendarConsulta(Medico m, string data)
        {
            Consulta c = new Consulta();
            c.Marcar(this, m, data);
            consultas.Add(c);
        }

        // Listar consultas
        public List<Consulta> ListarConsultas()
        {
            return consultas;
        }

        // Atualizar contato
        public void AtualizarContato(string contato)
        {
            this.contato = contato;
        }
    }
}
