using System;
using System.Diagnostics;

namespace Calculator
{
    class Program
    {    
        static void Main(string[] args)
        {
            Console.Clear();
            Menu();
        }

        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - Sair");

            Console.WriteLine("=====================");
            Console.WriteLine("Selecione uma opção: ");
            short res = short.Parse(Console.ReadLine());

            switch(res) {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: System.Environment.Exit(0); break;
                default: Menu(); break;
            }
        }

        static void Soma()
        {
            Console.WriteLine("Primeiro valor:");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor:");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine("Soma: " + (v1 + v2));
            Console.ReadKey();
            Menu();
        }

        static void Subtracao()
        {
            Console.WriteLine("Primeiro valor:");
            float v3 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor:");
            float v4 = float.Parse(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine("Subtração: " + (v3 - v4));
            Console.ReadKey();
            Menu();
        }

        static void Divisao()
        {
            Console.WriteLine("Primeiro valor:");
            float v5 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor:");
            float v6 = float.Parse(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine("Divisão: " + (v5 / v6));
            Console.ReadKey();
            Menu();
        }
        
        static void Multiplicacao()
        {
            Console.WriteLine("Primeiro valor:");
            float v7 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor:");
            float v8 = float.Parse(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine("Multiplicação: " + (v7 * v8));
            Console.ReadKey();
            Menu();
        }
    }


}