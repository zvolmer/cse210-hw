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
        foreach (var entry in entries)
        {
            Console.WriteLine(entry.ToString());
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (var entry in entries)
            {
                string line = $"{entry.Date}{Separator}{entry.Prompt}{Separator}{entry.Response}";
                outputFile.WriteLine(line);
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
        foreach (var line in lines)
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
