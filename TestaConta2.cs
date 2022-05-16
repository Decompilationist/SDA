// using System;

// namespace csharp
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Conta c1 = new Conta();

//             Console.WriteLine("Dados da Conta ...");
//             Console.WriteLine($"Saldo antes do depósito: {c1.saldo}");

//             Console.Write("Informe um valor para depósito: ");
//             double vlr_dep = Convert.ToDouble(Console.ReadLine());
//             // vamos chamar o método Depositar passando
//             // como parâmetro o valor a ser depositado - vlr_dep
//             c1.Depositar(vlr_dep);

//             Console.WriteLine($"Saldo após o depósito: {c1.saldo}");

//             Console.Write("Informe um valor para sacar: ");
//             double vlr_sacar = Convert.ToDouble(Console.ReadLine());
//             //vamos chamar o método Sacar passando
//             //como parâmetro o valor a ser sacado - vlr_sacar
//             c1.Sacar(vlr_sacar);

//             Console.Write("Saldo após o saque: ");
//             c1.ImprimirExtrato();

//             double vlr_limite = c1.ConsultarLimite();
//             Console.WriteLine("Limite disponível: " + vlr_limite);
//         }
//     }
// }