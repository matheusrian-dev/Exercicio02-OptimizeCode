using System;
using System.Text.RegularExpressions;

public class Teste
{
    // Main Method
    static public void Main(String[] args)
    {
        Console.WriteLine(Exercise.ReplaceDigits("4 score and 7 years ago, 8 men had the same PIN code: 6571"));
    }
}

public class Exercise
{
    public static string ReplaceDigits(string sentence)
    {
        string[] words = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" }; //array de strings com as palavras para substituir
        for (int i = 0; i < sentence.Length; i++) //percorre a sentence
        {
            for (int j = 0; j < words.Length; j++) //percorre o array para verificar se há um dígito na posição atual
            {
                if (sentence[i].Equals(j.ToString()[0])) //se o valor for igual, substitui o dígito pela string
                {
                    sentence = sentence.Replace(sentence[i].ToString(), words[j] + " "); //adiciona também um espaço em branco para separar palavras.
                }
            }
        }
        RegexOptions options = RegexOptions.None; //configuração do regex
        Regex regex = new Regex("[ ]{2,}", options); //inicialização do regex
        sentence = regex.Replace(sentence, " "); //remove espaços em branco duplicados
        sentence = sentence.Trim();//remove espaços em branco no início e final da string
        return sentence;
    }
}