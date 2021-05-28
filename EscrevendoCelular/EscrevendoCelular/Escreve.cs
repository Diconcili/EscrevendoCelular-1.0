using System;

namespace EscrevendoCelular
{
    class Escreve
    {
        string montagem = "";
        public string VerificaTexto(string texto)
        {
            Tradutor conversor = new Tradutor();

            texto.ToUpper();
            char[] letras = texto.ToCharArray();

            if (letras.Length > 255)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("O limite de caracteres é 255, tente novamente com uma mensagem menor.");
                Console.ResetColor();
            }
            else
            {
                for (int i = 0; i < letras.Length; i++)
                {
                    montagem += conversor.Traduz(letras[i]);
                }
            }

            return montagem;
        }
    }
}
