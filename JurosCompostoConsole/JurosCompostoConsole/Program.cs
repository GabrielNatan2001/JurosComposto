using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JurosCompostoConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double valor = 0;
            int prazo = 0;
            double juros = 0;

            double valorInicial = 0;
            Console.Write("Informe o capital inicial: ");
            valor = double.Parse(Console.ReadLine());

            Console.Write("Informe o prazo do investimento: ");
            prazo = int.Parse(Console.ReadLine());

            Console.Write("Informe o juros: ");
            juros = double.Parse(Console.ReadLine());

            valorInicial = valor;
            
            double percentual = juros / 100;

            for (int x=1; x<=prazo;x++)
            {
                valor = valor + (valor*percentual);
                Console.WriteLine("O valor do invenstimento no "+x.ToString()+ "° mês foi: " + valor.ToString("F"));
            }

            double jurosFinal =  valor - valorInicial;

            Console.WriteLine("Valor total de juros no final: " + jurosFinal.ToString("F"));

            Console.WriteLine("Valor final do capital investidio: " + valor.ToString("F"));

            Console.ReadLine();

        }
    }
}
