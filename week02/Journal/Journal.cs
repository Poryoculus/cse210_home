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
    try
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No entries to save.");
            return;
        }

        string json = JsonSerializer.Serialize(_entries, new JsonSerializerOptions { WriteIndented = true });

        using (FileStream fs = new FileStream(filename, FileMode.Create, FileAccess.Write))
        using (StreamWriter writer = new StreamWriter(fs))
        {
            writer.Write(json);
        }

        Console.WriteLine($"Journal saved to {filename}.");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error saving journal: {ex.Message}");
    }
}
    public void LoadFromFile(string file)
    {

    }

}