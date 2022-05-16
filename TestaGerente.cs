// using System;

// namespace csharp
// {
//     class TestaGerente
//     {
//         static void Main(string[] args)
//         {
//             Gerente ger = new Gerente();
            
//             Console.Write("Digite o salário: ");
//             ger.salario = Convert.ToDouble(Console.ReadLine());
//             Console.WriteLine("Salário =  " + ger.salario);

//             ger.AumentarSalario();
//             Console.WriteLine("Salário com 10% =  " + ger.salario);

//             Console.Write("Digite o percentual de aumento: ");
//             double perc = Convert.ToDouble(Console.ReadLine());
            
//             ger.AumentarSalario(perc);
//             Console.WriteLine($"Salário com {perc}% = {ger.salario} ");
//         }
//     }
// }