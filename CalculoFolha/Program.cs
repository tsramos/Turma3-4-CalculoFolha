using System;

namespace CalculoFolha
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double salario, imposto;

            Console.WriteLine("Informe o nome do funcionario");
            nome = Console.ReadLine();
            Console.WriteLine("Informe o salario bruto");
            salario = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a taxa de imposto");
            imposto = double.Parse(Console.ReadLine());
            Console.WriteLine("Nome:" + nome);
            double salarioLiquido = CalculaSalarioLiquido(salario, imposto);
            Console.WriteLine("Salario Liquido " + salarioLiquido);
            Console.WriteLine("Informe a porcentagem de aumento");
            double taxaAumento = double.Parse(Console.ReadLine());
            double salarioNovo = CalculaAumento(salario, taxaAumento);
            Console.WriteLine($"Nome : {nome}");
            salarioLiquido = CalculaSalarioLiquido(salarioNovo, imposto);
            Console.WriteLine($"SalarioLiquido : {salarioLiquido}");
        }

        public static double CalculaAumento(double salario, double aumento)
        {
            double novoSalario = salario + (salario * aumento / 100);
            return novoSalario;
        }

        public static double CalculaSalarioLiquido (double salario, double imposto)
        {
            double salarioLiquido = salario - (salario * (imposto / 100));
            return salarioLiquido;
        }
    }
}
