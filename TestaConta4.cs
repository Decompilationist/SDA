using System;

namespace csharp
{
  class Program
  {
    static void Main(string[] args)
    {
      Conta c1 = new Conta();
      Console.WriteLine("Dados da conta ...");
      c1.Saldo = 100;
      Console.WriteLine("Saldo inicial ...: " + c1.Saldo);

      Console.Write("Informe o valor a ser depositado: ");
      double vlr_deposita = Convert.ToDouble(Console.ReadLine());
      c1.Depositar(vlr_deposita);
      Console.Write("Saldo após o depósito: " + c1.Saldo);

      Console.Write("\nInforme o valor a ser sacado: ");
      double vlr_saque = Convert.ToDouble(Console.ReadLine());
      c1.Sacar(vlr_saque);
      Console.Write("Saldo após o saque: " + c1.Saldo);
    }
  }
}