using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImpostoContribuintes.Entities
{
    internal class PessoaJuridica : Contribuinte
    {
        /// Atributos
        public double NumberOfEmployees { get; set; }

        /// Construtor
        public PessoaJuridica(string name, double income, double numberOfEmployees) : base(name, income)
        {
            NumberOfEmployees = numberOfEmployees;
        }
        /// Método para calcular o imposto
        public override double Tax()
        {
            if (NumberOfEmployees > 10)
            {
                return Income * 0.14;
            }
            else
            {
                return Income * 0.16;
            }
        }
    }
}
