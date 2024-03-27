using System;

namespace ProblemaAlmentoSalario
{
    public class Funcionario
    {

        public string Nome { get; set; }
        public double SalarioBruto { get; set; }
        public double ImpostoPorcentagem { get; set; }

        public Funcionario(string nome, double salarioBruto, double impostoPorcentagem)
        {
            Nome = nome;
            SalarioBruto = salarioBruto;
            ImpostoPorcentagem = impostoPorcentagem;
        }

        public double CalcularSalarioLiquido()
        {
            double imposto = SalarioBruto * (ImpostoPorcentagem / 100);
            return SalarioBruto - imposto;
        }

        public void AumentarSalario(double aumentoPorcentagem)
        {
            double aumentoValor = SalarioBruto * (aumentoPorcentagem / 100);
            SalarioBruto += aumentoValor;
        }
    }
}
