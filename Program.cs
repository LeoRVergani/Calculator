using System;

namespace Calculator
{
    class Program
    {    
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Primeiro valor:");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor:");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine("Soma: " + (v1 + v2));
            Console.WriteLine("Subtração: " + (v1 - v2));
            Console.WriteLine("Multiplicação: " + (v1 * v2));
            Console.WriteLine("Divisão: " + (v1 / v2));
        }
    }
}