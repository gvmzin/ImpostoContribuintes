using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImpostoContribuintes.Entities
{
    internal class PessoaJuridica : Contribuinte
    {
        public double NumberOfEmployees { get; set; }

        public PessoaJuridica(string name, double income, double numberOfEmployees) : base(name, income)
        {
            NumberOfEmployees = numberOfEmployees;
        }
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
