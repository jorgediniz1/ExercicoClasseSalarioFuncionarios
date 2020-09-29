using System;
using System.Dynamic;

namespace ExercicoClasseSalarioFuncionarios
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario F1, F2;

            F1 = new Funcionario();
            F2 = new Funcionario();

            Console.WriteLine("Entre com o nome e salário do primeiro funcionário");
            F1.Nome = Console.ReadLine();
            F1.Salario = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o nome e salário do segundo funcionário");
            F2.Nome = Console.ReadLine();
            F2.Salario = int.Parse(Console.ReadLine());

            double salario_medio;
            salario_medio = (F1.Salario + F2.Salario) / 2;

            Console.WriteLine("O salário médio dos funcionarios {0} e {1} é de {2}", F1.Nome, F2.Nome, salario_medio);
            
        }
    }
}
