using System;

namespace csharp.Model
{
    public class Servico
    {
        public Cliente Contratante { get; set; }
        public Funcionario Responsavel { get; set; }
        public string DataDeContratacao { get; set; }

        public virtual double CalcularTaxa(){
          return 10;
        }
    }
}