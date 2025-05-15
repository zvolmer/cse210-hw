using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> entries = new List<Entry>();
    private const string Separator = "|";

    public void AddEntry(Entry entry)
    {
        entries.Add(entry);
    }

    public void Display()
    {
        Console.WriteLine("\n--- Journal Entries ---");
        foreach (Entry entry in entries)
        {
            Console.WriteLine("Date: "     + entry.Date);
            Console.WriteLine("Prompt: "   + entry.Prompt);
            Console.WriteLine("Response: "+ entry.Response);
            Console.WriteLine();  // blank line between entries
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry e in entries)
            {
                // date|prompt|response
                outputFile.WriteLine($"{e.Date}{Separator}{e.Prompt}{Separator}{e.Response}");
            }
        }
        Console.WriteLine("Journal saved successfully.");
    }

    public void LoadFromFile(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        entries.Clear();
        string[] lines = File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split(Separator);
            if (parts.Length == 3)
            {
                entries.Add(new Entry(parts[0], parts[1], parts[2]));
            }
        }
        Console.WriteLine("Journal loaded successfully.");
    }
}
