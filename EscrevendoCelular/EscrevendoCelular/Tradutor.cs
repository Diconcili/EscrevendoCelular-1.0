namespace EscrevendoCelular
{
    class Tradutor
    {

        string numeros = "";

        public string Traduz(char letra)
        {
            switch (letra)
            {
                case 'A': numeros = "2"; break;
                case 'B': numeros = "22"; break;
                case 'C': numeros = "222"; break;
                case 'D': numeros = "3"; break;
                case 'E': numeros = "33"; break;
                case 'F': numeros = "333"; break;
                case 'G': numeros = "4"; break;
                case 'H': numeros = "44"; break;
                case 'I': numeros = "444"; break;
                case 'J': numeros = "5"; break;
                case 'K': numeros = "55"; break;
                case 'L': numeros = "555"; break;
                case 'M': numeros = "6"; break;
                case 'N': numeros = "66"; break;
                case 'O': numeros = "666"; break;
                case 'P': numeros = "7"; break;
                case 'Q': numeros = "77"; break;
                case 'R': numeros = "777"; break;
                case 'S': numeros = "77777"; break;
                case 'T': numeros = "8"; break;
                case 'U': numeros = "88"; break;
                case 'V': numeros = "888"; break;
                case 'W': numeros = "9"; break;
                case 'X': numeros = "99"; break;
                case 'Y': numeros = "999"; break;
                case 'Z': numeros = "9999"; break;
                case ' ': numeros = "0"; break;
            }

            return numeros;
        }



    }
}
