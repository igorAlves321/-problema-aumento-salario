using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProblemaAlmentoSalario
{
    public class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double ImpostoPorcentagem;

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
