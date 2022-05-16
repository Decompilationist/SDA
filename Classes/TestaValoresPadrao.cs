// using System;

// namespace csharp
// {
//   class Program
//   {
//     static void Main(string[] args)
//     {
//       Agencia a = new Agencia(1234);

//       Conta origem = new Conta(a);

//       origem.saldo = 1000;
//       Console.WriteLine(" Saldo da primeira conta : " + origem.saldo);

//       Conta destino = new Conta(a);
//       destino.saldo = 1000;
//       Console.WriteLine(" Saldo da segunda conta : " + destino.saldo);

//       Console.WriteLine(" ----------------------------------------");

//       Console.WriteLine(" Realizando a transferência ");
//       origem.Transfere(destino, 500);

//       Console.WriteLine(" ----------------------------------------");

//       Console.WriteLine(" Saldo da primeira conta : " + origem.saldo);
//       Console.WriteLine(" Saldo da segunda conta : " + destino.saldo);
//     }
//   }
// }