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
            Funcionario f = new Funcionario();
            Console.Write("Digite o nome do funcionário: ");
            f.Nome = Console.ReadLine();

            Console.Write("Digite o salário bruto do funcionário: ");
            f.SalarioBruto = double.Parse(Console.ReadLine());

            Console.WriteLine("digite a porcentagem de imposto.");
            f.ImpostoPorcentagem = double.Parse(Console.ReadLine());

            Console.WriteLine("dados do funcionário.");
            Console.WriteLine($"Nome: {f.Nome}");
            Console.WriteLine($"Salário Líquido: R$ {f.CalcularSalarioLiquido():F2}");

            Console.Write("Digite a porcentagem de aumento salarial: ");
            double aumentoPorcentagem = double.Parse(Console.ReadLine());
            f.AumentarSalario(aumentoPorcentagem);
            Console.WriteLine("Dados atualizados do funcionário:");
            Console.WriteLine($"Nome: {f.Nome}");
            Console.WriteLine($"Novo Salário Líquido: R$ {f.CalcularSalarioLiquido():F2}");

            Console.ReadKey();
        }
    }
}
