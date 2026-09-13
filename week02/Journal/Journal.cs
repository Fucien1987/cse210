using System.Security.Cryptography.X509Certificates;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)

    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SearchEntries(string word)
    {
        bool found = false;
        foreach (Entry entry in _entries)
        {
            if (entry._entryText.ToLower().Contains(word.ToLower()) ||
                entry._promptText.ToLower().Contains(word.ToLower()))
            {
                entry.Display();
                found = true;
            }
        }
        if (!found)
        {
            Console.WriteLine("No journal entries found with that word.");
        }
    }
    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}");
            }
        }
    }
    public void LoadFromFile(string file)
    {
        string[] lines = File.ReadAllLines(file);
        
        _entries.Clear();

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            Entry entry = new Entry();
            entry._date = parts[0];
            entry._promptText = parts[1];
            entry._entryText = parts[2];

            _entries.Add(entry);
        }
    }
}
   