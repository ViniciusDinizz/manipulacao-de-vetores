using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        string texto, d, e;
        int b, c;
        texto = Console.ReadLine();

        Console.WriteLine($"A Caracteres- {texto.Length} caracteres");
        Console.WriteLine($"B Vogais- {b = ContadorVog(texto)}");
        Console.WriteLine($"C Consoantes- {c = ContadorConso(texto)}");
        Console.WriteLine($"D Alternado- {d = AlternarChar(texto)}");
        Console.WriteLine($"E Espelhado- {e = InverterString(texto)}");

        //Inverte os elementos de uma string
        string InverterString(string texto)
        {
            StringBuilder textoaux = new StringBuilder(texto);

            for (int i = 0; i < texto.Length; i++)
            {
                textoaux[i] = texto[texto.Length - 1 - i];
            }
            return textoaux.ToString();
        }

        //Alterna os caracteres de um string entre maiusculo e minusculo
        string AlternarChar(string texto)
        {
            StringBuilder textoaux = new StringBuilder(texto);
            for (int i = 0; i < texto.Length; i++)
            {
                if (i % 2 == 0)
                {
                    textoaux[i] = char.ToUpper(textoaux[i]);
                }
                if (i % 2 == 1)
                {
                    textoaux[i] = char.ToLower(textoaux[i]);
                }
            }
            return textoaux.ToString();
        }

        //Contador de vogais dentro de uma string
        int ContadorVog(string texto)
        {
            int vogal1 = 0;
            texto = texto.ToUpper();

            for (int i = 0; i < texto.Length; i++)
            {
                if (char.IsLetter(texto[i]))
                {
                    if (texto[i] == 'A' || texto[i] == 'E' || texto[i] == 'I' || texto[i] == 'O' || texto[i] == 'U')
                    {
                        vogal1 += 1;
                    }
                }
            }
            return vogal1;
        }

        //Contador de consoantes dentro de uma string
        int ContadorConso(string texto)
        {
            int conso1 = 0;
            texto = texto.ToUpper();

            for (int i = 0; i < texto.Length; i++)
            {
                if (char.IsLetter(texto[i]))
                    if (texto[i] != 'A' && texto[i] != 'E' && texto[i] != 'I' && texto[i] != 'O' && texto[i] != 'U')
                    {
                        conso1 += 1;
                    }
            }
            return conso1;
        }

    }
}
