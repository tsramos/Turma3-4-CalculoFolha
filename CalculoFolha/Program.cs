using System;

namespace CalculoFolha
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario = new Funcionario();
            
            Console.WriteLine("Informe o nome do funcionario");
            funcionario.Nome = Console.ReadLine();
            Console.WriteLine("Informe o salario bruto");
            funcionario.Salario = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a taxa de imposto");
            funcionario.Imposto = double.Parse(Console.ReadLine());
            Console.WriteLine("Nome:" + funcionario.Nome);
            double salarioLiquido = funcionario.CalculoSalarioLiquido();
            Console.WriteLine("Salario Liquido " + salarioLiquido);
            Console.WriteLine("Informe a porcentagem de aumento");
            double taxaAumento = double.Parse(Console.ReadLine());
            funcionario.CalculoNovoSalario(taxaAumento);
            Console.WriteLine($"Nome : {funcionario.Nome}");
            salarioLiquido = funcionario.CalculoSalarioLiquido();
            Console.WriteLine($"SalarioLiquido : {salarioLiquido}");
        }
    }
}
