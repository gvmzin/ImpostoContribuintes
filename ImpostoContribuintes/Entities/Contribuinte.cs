using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImpostoContribuintes.Entities
{
    abstract class Contribuinte
    {
        /// Atributos
        public string Name { get; set; }
        public double Income { get; set; }

        /// Construtor
        public Contribuinte(string name, double income)
        {
            Name = name;
            Income = income;
        }

        /// Método para calcular o imposto
        public abstract double Tax();
    }
}
