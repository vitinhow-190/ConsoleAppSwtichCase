using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro número: ");
            double num1= double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            double num2 = double.Parse(Console.ReadLine());

            Console.WriteLine("selecione a operação desejada (+, -, *, /): ");
            string op = Console.ReadLine();

            switch (op) 
            {
                case "+":

                num1= num1 + num2;

                    Console.WriteLine("resultado: " + num1);
                break;
                
                case "-":

                    num1 = num1 - num2;

                    Console.WriteLine("resultado: " + num1);
                break;

                case "*":

                    num1 = num1 * num2;

                    Console.WriteLine("resultado: " + num1);
                break;

                case "/":

                    num1 = num1 / num2;

                    Console.WriteLine("resultado: " + num1);
                break;
                
                default:

                    Console.WriteLine("Opção invalida.");
                
                break;

                

            }
            Console.ReadKey();
        }
    }
}
