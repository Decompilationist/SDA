// using System;

// namespace csharp
// {
//   class Program
//   {
//     static void Main(string[] args)
//     {
//       Agencia a = new Agencia(123);

//       Conta c1 = new Conta(a);
//       c1.numero = 1234;
//       c1.saldo = 1000;
//       c1.limite = 500;

//       Conta c2 = new Conta(a);
//       c2.numero = 5678;
//       c2.saldo = 2000;
//       c2.limite = 250;

//       Console.WriteLine(" Dados da primeira conta ");
//       Console.WriteLine(" Número : " + c1.numero);
//       Console.WriteLine(" Saldo : " + c1.saldo);
//       Console.WriteLine(" Limite : " + c1.limite);

//       Console.WriteLine(" ----------------------------------------");
//       Console.WriteLine(" Dados da segunda conta ");
//       Console.WriteLine(" Número : " + c2.numero);
//       Console.WriteLine(" Saldo : " + c2.saldo);
//       Console.WriteLine(" Limite : " + c2.limite);
//     }
//   }
// }