using System;

namespace Estrutura_condicional
{
    class Program
    {
        static void Main(string[] args)
        {//Entrada
            Console.WriteLine("Digite sua idade");
            int idade = int.Parse(Console.ReadLine());
            //Processamento
            int meses = idade * 12;
            int dias = idade * 365;
            int horas = dias *24;
            int minutos = horas * 60;

            Console.WriteLine("Você viveu");
            Console.WriteLine(meses + "Meses");
            Console.WriteLine(dias + "Dias");
            Console.WriteLine(horas + "Horas");
            Console.WriteLine(minutos + "Minutos");
            
        
        
        }
    }

}        
