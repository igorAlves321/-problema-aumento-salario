using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProblemaAlmentoSalario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o nome do funcionário: ");
            string nome = Console.ReadLine();

            Console.Write("Digite o salário bruto do funcionário: ");
            double salarioBruto = double.Parse(Console.ReadLine());

            Console.WriteLine("digite a tacha de imposto");
            double impostop = double.Parse(Console.ReadLine());

            double imposto = salarioBruto * (impostop / 100);
            double salarioLiquido = salarioBruto - imposto;

            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Salário Líquido: R$ {salarioLiquido:F2}");

            Console.Write("Digite a porcentagem de aumento salarial: ");
            double aumentoPorcentagem = double.Parse(Console.ReadLine());
            double aumentoValor = salarioBruto * (aumentoPorcentagem / 100);
            double novoSalarioBruto = salarioBruto + aumentoValor;
            double novoImposto = novoSalarioBruto * (impostop / 100);
            double novoSalarioLiquido = novoSalarioBruto - novoImposto;

            Console.WriteLine("dados atualizados");
            Console.WriteLine($"Novo Salário Líquido: R$ {novoSalarioLiquido:F2}");
            Console.ReadKey();
        }
    }
}
