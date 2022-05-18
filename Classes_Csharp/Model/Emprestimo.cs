using System;

namespace csharp.Model
{
    public class Emprestimo : Servico
    {
        public double Valor { get; set; }
        public double Taxa { get; set; }

        public override double CalcularTaxa(){
          return this.Valor * 0.1;
        }
    }
}