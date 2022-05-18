// using System;

// namespace csharp
// {
//   class Program
//   {
//     static void Main(string[] args)
//     {
//         Emprestimo emp1 = new Emprestimo();
//         Cliente cli = new Cliente();
//         Funcionario fun = new Funcionario();

//         emp1.Contratante = cli;
//         emp1.Responsavel = fun;

//         //setamos os atributos da classe base servico
//         emp1.Contratante.nome = "Xaxa";
//         emp1.Responsavel.nome = "Tutu";
//         emp1.DataDeContratacao = "18/05/2022";

//         //setamos os atributos da classe Emprestimo
//         emp1.Valor = 1000;
//         emp1.Taxa = 10;

//         Console.WriteLine($"Nome do contratante: {emp1.Contratante.nome}");
//         Console.WriteLine($"Nome do responsável: {emp1.Responsavel.nome}");
//         Console.WriteLine($"Data da contratação: {emp1.DataDeContratacao}");
//         Console.WriteLine($"Valor do empréstimo: {emp1.Valor}");
//         System.Console.WriteLine($"Taxa:    {emp1.Taxa}");
//     }
//   }
// }