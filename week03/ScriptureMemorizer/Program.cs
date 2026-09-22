using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("1Nephi", 3, 7);

        Scripture scripture = new Scripture(
            reference,
            "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them."
        );
        string input = "";

        while (input.ToLower() != "quit" && !scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type'quit' to finish:");

            input = Console.ReadLine() ?? "";

            if (input.ToLower() != "quit")
            {
                scripture.HideRandomWords(3);
            }
        }
        if (scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
        }
    }
}