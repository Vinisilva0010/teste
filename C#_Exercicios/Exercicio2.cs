using System;

class Program
{
    static void Main()
    {
        
        string texto = "Exemplo de string";

       
        string textoInvertido = InverterString(texto);

        
        Console.WriteLine("Texto original: " + texto);
        Console.WriteLine("Texto invertido: " + textoInvertido);
    }

    static string InverterString(string str)
    {
       
        char[] array = str.ToCharArray();

        /
        for (int i = 0, j = array.Length - 1; i < j; i++, j--)
        {
            char temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }

        
        return new string(array);
    }
}
