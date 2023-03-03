using System;
namespace ConsoleApp2
{
    class program
    {
        static void Main (string [] args)
        {
            Console.Write("Digite sua altura : ");
            double altura = double.Parse(Console.ReadLine());

            Console.Write("Digite seu peso: ");
            double peso = double.Parse(Console.ReadLine());

            Imc Objetoimc = new Imc(peso,altura);

            Console.WriteLine("Você está: " + Objetoimc.imc()); ;
        }
    }
}
