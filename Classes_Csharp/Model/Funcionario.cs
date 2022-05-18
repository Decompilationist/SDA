using System;

namespace csharp.Model
{
    public class Funcionario
    {
        //public double salario { get; set; }

        string Nome;
        public string nome
        {
          get { return Nome; }
          set { Nome = value; }
        }
                
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