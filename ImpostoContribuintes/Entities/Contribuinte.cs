using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImpostoContribuintes.Entities
{
    abstract class Contribuinte
    {
        public string Name { get; set; }
        public double Income { get; set; }

        public Contribuinte(string name, double income)
        {
            Name = name;
            Income = income;
        }

        public abstract double Tax();
    }
}
