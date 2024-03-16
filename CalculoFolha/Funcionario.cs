namespace CalculoFolha
{
    public class Funcionario
    {
        public string Nome;
        public double Salario;
        public double Imposto;

        public double CalculoSalarioLiquido()
        {
            return Salario - (Salario * Imposto / 100);
        }

        public void CalculoNovoSalario(double aumento) 
        {
            Salario += Salario * aumento / 100;
        }
    }
}
