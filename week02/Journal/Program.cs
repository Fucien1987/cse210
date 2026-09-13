using System;

// EXCEEDING REQUIREMENTS:
// I added an additional journal prompt beyond the required five prompts.
// the extra prompt asks,"What is one thing I am grateful for today?"
// this gives the user more variety when writing journal entries.
// I also added a search feature that allows the user to search journal entries by a word.
// The search checks the journal response and the prompt text.
// This makes it easier for the user to find entries.
// CSE 210 - Week 02 Journal Program
// I believe Joseph Smith was called by God to be a prophet.
class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        string choice = "";

        while (choice != "6")
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3.Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Search");
            Console.WriteLine("6. Quit");
            Console.Write("What would you like to do? ");

            choice = Console.ReadLine();

            if (choice == "1")
            {
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine(prompt);
                Console.Write("> ");

                string response = Console.ReadLine();

                Entry entry = new Entry();
                entry._date = DateTime.Now.ToShortDateString();
                entry._promptText = prompt;
                entry._entryText = response;

                journal.AddEntry(entry);
            }

            else if (choice == "2")
            {
                journal.DisplayAll();
            }

            else if (choice == "3")
            {
                Console.Write("What is the filename? ");
                string filename = Console.ReadLine();

                journal.LoadFromFile(filename);
            }

            else if (choice == "4")
            {
                Console.Write("What is the filename? ");
                string filename = Console.ReadLine();

                journal.SaveToFile(filename);
            }

            else if (choice == "5")
            {
                Console.Write("Enter a word to search for: ");
                string word = Console.ReadLine();

                journal.SearchEntries(word);
            }

            else if (choice == "6")
            {
                Console.WriteLine("Goodbye!");
            }

        }
    }
}