using System;

namespace csharp
{
    public class Gerente
    {
        public string nome { get; set; }
        public double salario { get; set; }

        public void AumentarSalario()
        {
          this.AumentarSalario(0.1);
        }

        public void AumentarSalario(double taxa)
        {
          this.salario += this.salario * taxa;
        }
    }
}