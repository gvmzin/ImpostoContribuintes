using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImpostoContribuintes.Entities
{
    internal class PessoaFisica : Contribuinte
    {
        /// Atributos
        public double HealthExpenditures { get; set; }

        /// Construtor
        public PessoaFisica(string name, double income, double healthExpenditures) : base(name, income)
        {
            HealthExpenditures = healthExpenditures;
        }

        /// Método para calcular o imposto
        public override double Tax()
        {
            if (Income < 20000.0)
            {
                return Income * 0.15 - HealthExpenditures * 0.5;
            }
            else
            {
                return Income * 0.25 - HealthExpenditures * 0.5;
            }
        }
    }
}
