
namespace Clínica_Hospital
{
    public class Hospital
    {
        private List<Medico> medicos;
        private List<Paciente> pacientes;
        private List<Consulta> consultas;

        public Hospital()
        {
            medicos = new List<Medico>();
            pacientes = new List<Paciente>();
            consultas = new List<Consulta>();
        }

        public void CadastrarMedico(Medico medico)
        {
            medicos.Add(medico);
        }

        public void CadastrarPaciente(Paciente paciente)
        {
            pacientes.Add(paciente);
        }

        public void CadastrarConsulta(Consulta consulta)
        {
            consultas.Add(consulta);
        }

        public List<Consulta> ListarConsultasDoDia(string data)
        {
            return consultas.Where(c => c.Data == data).ToList();
        }
    }
}