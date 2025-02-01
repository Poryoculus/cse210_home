using System;
using System.IO;
using System.Text.Json;

public class Journal 

{
    public List<Entry> _entries;

    public Journal()
    {
        _entries = new List<Entry>(); // Se inicializa la lista
    }

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {

            Console.WriteLine($"Date: {entry._date} - Prompt: {entry._promptText}");
            Console.WriteLine($"{entry._entryText}");
        }
    }
    public void SaveToJson(string filename)
{
    
    string json = JsonSerializer.Serialize(_entries, new JsonSerializerOptions { WriteIndented = true });
    File.WriteAllText(filename, json);
    Console.WriteLine($"Journal saved to {filename}.");
    
}
    public List<Entry> LoadFromFile(string file)
    {

        using FileStream json = File.OpenRead(file);
        List<Entry> entries = JsonSerializer.Deserialize<List<Entry>>(json);

        return entries ?? new List<Entry>();
    }
}

