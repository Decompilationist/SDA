using System;

namespace csharp
{
    public class Funcionario
    {
        //public double salario { get; set; }
        
        double salario;
        public double Salario
        {
          get { return salario; }
          set { salario = value; }
        }

        public void AumentarSalario(double aumento)
        {
          //lógica para aumentar salário
        }
    }
}