using System;

namespace desafiosCsharp
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            Aumento de Salário

            A empresa ABC resolveu conceder um aumento de salários a seus funcionários de
            acordo com a tabela abaixo:
            salario: 0 - 400.00         percentual = 15%
            salario: 400.01 - 800.00    percentual = 12%
            salario: 800.01 - 1200.00   percentual = 10%
            salario: 1200.01 - 2000.00  percentual = 7%
            salario: acima de 2000.00   percentual = 4%

            Leia o salário do funcionário e calcule e mostre o novo salário, bem como o
            valor de reajuste ganho e o índice reajustado, em percentual.
            
            Entrada
            A entrada contém apenas um valor de ponto flutuante, que pode ser maior ou
            igual a zero, com duas casas decimais.

            Saída  
            Imprima 3 linhas na saída: o novo salário, o valor ganho de reajuste e o
            percentual de reajuste ganho, conforme exemplo abaixo.

            Exemplo de Entrada	Exemplo de Saída
            400.00              Novo salario: 460.00
                                Reajuste ganho: 60.00
                                Em percentual: 15 %
            _________________________________________                    
            800.01              Novo salario: 880.01
                                Reajuste ganho: 80.00
                                Em percentual: 10 %
            _________________________________________
            2000.00             Novo salario: 2140.00
                                Reajuste ganho: 140.00
                                Em percentual: 7 %
            */

            
            double salario, reajuste, novoSalario, percentual;
            salario = Convert.ToDouble(Console.ReadLine());

            //insira os valores corretos de acordo com o enunciado



            if (salario >= 0.00 && salario <= 400.00)
            {
                percentual = 15;
                reajuste = (salario / 100) * percentual;
                novoSalario = salario + reajuste;
                Console.WriteLine("Novo salario: {0:0.00}", novoSalario);
                Console.WriteLine("Reajuste ganho: {0:0.00}", reajuste);
                Console.WriteLine("Em percentual: {0} %", percentual);
            }
            else if (salario >= 400.01 && salario <= 800.00)
            {
                percentual = 12;
                reajuste = (salario / 100) * percentual;
                novoSalario = salario + reajuste;
                Console.WriteLine("Novo salario: {0:0.00}", novoSalario);
                Console.WriteLine("Reajuste ganho: {0:0.00}", reajuste);
                Console.WriteLine("Em percentual: {0} %", percentual);
            }
            else if (salario >= 800.01 && salario <= 1200.00)
            {
                percentual = 10;
                reajuste = (salario / 100) * percentual;
                novoSalario = salario + reajuste;
                Console.WriteLine("Novo salario: {0:0.00}", novoSalario);
                Console.WriteLine("Reajuste ganho: {0:0.00}", reajuste);
                Console.WriteLine("Em percentual: {0} %", percentual);
            }
            else if (salario >= 1200.01 && salario <= 2000.00)
            {
                percentual = 7;
                reajuste = (salario / 100) * percentual;
                novoSalario = salario + reajuste;
                Console.WriteLine("Novo salario: {0:0.00}", novoSalario);
                Console.WriteLine("Reajuste ganho: {0:0.00}", reajuste);
                Console.WriteLine("Em percentual: {0} %", percentual);
            }
            else if (salario > 2000.00)
            {
                //complete o codigo
                percentual = 4;
                reajuste = (salario / 100) * percentual;
                novoSalario = salario + reajuste;
                Console.WriteLine("Novo salario: {0:0.00}", novoSalario);
                Console.WriteLine("Reajuste ganho: {0:0.00}", reajuste);
                Console.WriteLine("Em percentual: {0} %", percentual);
            }
        }
    }
}
