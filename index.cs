using System;

class Program
{
    static void Main()
    {
        Console.WriteLine(welcome("Samanta"));
        Console.WriteLine(reverseString("OMAR"));
        Console.WriteLine(existWordInText("La vida es para vivirla", "vida") ? "Existe" : "No existe");
        Console.WriteLine(replaceSpacesWithAsterisks("La vida es para vivirla"));
        Console.WriteLine(encryptText("Samanta"));
    }

    // Dado el nombre de una persona, obtenga el mensaje: "Bienvenido Sr(a) NOMBRE INGRESADO a su tienda de preferencia.".

    static string welcome(string name)
    {
        return $"Bienvenido Sr(a) {name.Trim()} a su tienda de preferencia.";
    }

    // Dado un nombre, obtenga el nombre en forma invertida, por ejemplo: "OMAR" invertido es "RAMO".

    static string reverseString(string text)
    {
        char[] arrayText = text.Trim().ToCharArray();
        Array.Reverse(arrayText);
        return String.Join("", arrayText);
    }

    // Lea una frase y una palabra, determine si la palabra existe en la frase.

    static bool existWordInText(string text, string word)
    {
        string formatText = text.ToLower();
        string formatWord = word.ToLower().Trim();

        return formatText.Contains(formatWord);
    }

    // Dada una frase, devuelva la frase con asteriscos en lugar de espacios.

    static string replaceSpacesWithAsterisks(string text)
    {
        return text.Trim().Replace(" ", "*");
    }

    // Cree un algoritmo para encriptar una frase con el valor del caracter ASCII, sumando 3 posiciones.

    static string encryptText(string text)
    {
        char[] arrayLetter = text.Trim().ToCharArray();
        char[] encryptArrayLetter = new char[arrayLetter.Length];

        for (int i = 0; i < arrayLetter.Length; i++)
        {
            encryptArrayLetter[i] = ((char)((int)arrayLetter[i] + 3));
        }

        return String.Join("", encryptArrayLetter);
    }
}