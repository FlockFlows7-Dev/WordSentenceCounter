using System;

class Program
{
    public static void Main(string[] args)
    {
        int spaceCount = 0;
        int words = 0;
        int sentences = 0;
        Console.WriteLine("(WordSentenceCounter)");
        Console.WriteLine("(Hi this was my attempt at a WordSentenceCounter)");
        Console.WriteLine("Type or paste your sentence here:");

        string input = Console.ReadLine();
        spaceCount = input.Split(' ').Length - 1;
        words = spaceCount + 1;
        Console.Clear();

        sentences = input.Split('.').Length - 1
                  + input.Split('?').Length - 1
                  + input.Split('!').Length - 1;

        if (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("Spaces: 0");
            Console.WriteLine("Words: 0");
            Console.WriteLine("Sentences: 0");
            Console.ReadLine();
            return;
        }    

        Console.WriteLine("Spaces: " + spaceCount);
        Console.WriteLine("Words: " + words);
        Console.WriteLine("Sentences: " + sentences);
        Console.ReadLine();
        return;

    }
}