using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace csharp
{
    public class SeguroDeVeiculo : Servico
    {
        public Veiculo Veiculo { get; set; }
        public double ValorDoSeguro { get; set; }
        public double Franquia { get; set; }

        public override double CalcularTaxa(){
          return 1 + this.ValorDoSeguro * 0.1;
        }
    }
}