using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscrevendoCelular
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Escreve escrita = new Escreve();
                Console.WriteLine("Digite uma mensagem a ser convertida: ");
                string mensagem = Console.ReadLine();

                Console.WriteLine(escrita.VerificaTexto(mensagem));
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
