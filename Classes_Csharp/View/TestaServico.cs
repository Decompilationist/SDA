// using System;

// namespace csharp
// {
//   class Program
//   {
//     static void Main(string[] args)
//     {
//         Servico serv = new Servico();
//         Cliente cli = new Cliente();
//         Funcionario fun = new Funcionario();

//         serv.Contratante = cli;
//         serv.Responsavel = fun;

//         serv.Contratante.nome = "Xaxa";
//         serv.Responsavel.nome = "Tutu";
//         serv.DataDeContratacao = "18/05/2022";

//         Console.WriteLine("Nome do contratante: " + serv.Contratante.nome);
//         Console.WriteLine("Nome do funcionário: " + serv.Responsavel.nome);
//         Console.WriteLine("Data da contratação: " + serv.DataDeContratacao);        
//     }
//   }
// }