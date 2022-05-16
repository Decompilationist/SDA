// using System;

// namespace csharp
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Cliente c = new Cliente();
//             CartaoDeCredito cdc = new CartaoDeCredito();
//             cdc.cliente = c;

//             cdc.numero = 1;
//             cdc.dataDeValidade = "28/04/2022";
//             cdc.cliente.nome = "Tutu";

//             Console.WriteLine("Dados do Cliente e do Cartão de Crédito ...");
//             Console.WriteLine("Número: " + cdc.numero);
//             Console.WriteLine("Data de Validade: " + cdc.dataDeValidade);
//             Console.WriteLine("Nome do cliente: " + cdc.cliente.nome);            
//         }
//     }
// }