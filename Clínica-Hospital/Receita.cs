using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clínica_Hospital
{
    public class Receita
    {
        private List<string> medicamentos = new List<string>();

        public void AdicionarMedicamento(string nome, string dose)
        {
            medicamentos.Add(nome + " " + dose);
        }

        public void RemoverMedicamento(string nome)
        {
            List<string> novaLista = new List<string>();

            for (int i = 0; i < medicamentos.Count; i++)
            {
                if (medicamentos[i] != nome)
                {
                    novaLista.Add(medicamentos[i]);
                }
            }

            medicamentos = novaLista;
        }

        public List<string> ListarMedicamentos()
        {
            return medicamentos;
        }
    }
}
