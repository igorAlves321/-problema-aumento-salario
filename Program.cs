using System;

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

            Console.WriteLine("digite a porcentagem de imposto.");
            double impostoPorcentagem = double.Parse(Console.ReadLine());

            Funcionario f = new Funcionario(nome, salarioBruto, impostoPorcentagem);

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
