using System;

namespace csharp
{
  public class Conta
  {
    //atributos
    public int numero { get; set; }
    private double saldo;
    public double Saldo
    {
      get { return saldo; }
      set { saldo = value; }
    }
    
    public double limite { get; set; }
    public Agencia agencia { get; set; }

    //construtor

    public Conta() { }
    public Conta(Agencia agencia)
    {
      this.agencia = agencia;
    }

    //métodos ou ações da classe
    public void Depositar(double valor)
    {
      this.saldo += valor;
      this.DescontarTarifa();
    }

    public void Sacar(double valor)
    {
      this.saldo -= valor;
      this.DescontarTarifa();
    }

    // public void ImprimirExtrato()
    // {
    //   //Console.WriteLine($"{this.saldo}");
    //   Console.WriteLine(this.saldo);
    // }

    public void ImprimirExtrato(int dias)
    {
      //Corpo / Implementação
      // Console.WriteLine("Imprimindo extrato dos últimos: " + dias + " dias");
      Console.WriteLine($"Imprimindo o extrato dos últimos {dias} dias");
    }

    public void ImprimirExtrato() //Extrato dos últimos 15 dias
    {
      this.ImprimirExtrato(15);
    }

    public double ConsultarSaldoDisponivel()
    {
      return this.saldo + this.limite;
    }

    public double ConsultarLimite()
    {
      return this.saldo + this.limite;
    }

    public void Transfere(Conta destino, double valor)
    {
      this.saldo -= valor;
      destino.saldo += valor;
    }

    void DescontarTarifa()
    {
      this.saldo -= this.saldo * 0.1;
    }
  }
}