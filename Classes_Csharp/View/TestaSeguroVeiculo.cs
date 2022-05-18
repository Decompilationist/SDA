// using System;

// namespace csharp
// {
//   class Program
//   {
//     static void Main(string[] args)
//     {
//        SeguroDeVeiculo sdv = new SeguroDeVeiculo();
//        Cliente cli = new Cliente();
//        Funcionario fun = new Funcionario();
//        Veiculo veic = new Veiculo();

//        sdv.Contratante = cli;
//        sdv.Responsavel = fun;
//        sdv.Veiculo = veic;

//        //setamos os atributos das classes Cliente e Funcionario
//        sdv.Contratante.nome = "Xaxa";
//        sdv.Responsavel.nome = "Tutu";
//        sdv.DataDeContratacao = "18/05/2022";

//        //setamos os atributos da classe Veiculo
//        sdv.Veiculo.Marca = "VW";
//        sdv.Veiculo.Modelo = "Jetta";
//        sdv.Veiculo.Cor = "Cinza chumbo";

//        //setamos os atributos da classe SeguroDeVeiculo
//        sdv.ValorDoSeguro = 130000;
//        sdv.Franquia = 20000;

//        Console.WriteLine("Dados do contrato   ...");
//        Console.WriteLine("Nome do segurado   : " + sdv.Contratante.nome);
//        Console.WriteLine("Nome do responsável: " + sdv.Responsavel.nome);
//        Console.WriteLine("Data da contratação: " + sdv.DataDeContratacao);
//        Console.WriteLine("Dados do veículo   : ");
//        Console.WriteLine("Marca              : " + sdv.Veiculo.Marca);
//        Console.WriteLine("Modelo             : " + sdv.Veiculo.Modelo);
//        Console.WriteLine("Cor                : " + sdv.Veiculo.Cor);
//        Console.WriteLine("Dados do seguro do veículo ...");
//        Console.WriteLine("Valor do seguro    : " + sdv.ValorDoSeguro);
//        Console.WriteLine("Valor da franquia  : " + sdv.Franquia);
//     }
//   }
// }