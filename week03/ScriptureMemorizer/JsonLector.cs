using System; 
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using System.Text.Json;

public class JsonLector
{
    public List<Scripture> LoadScriptures(string file)
    {
        try
        {
            var json = File.ReadAllText(file);
            var scriptures = JsonConvert.DeserializeObject<List<Scripture>>(json);

            return scriptures;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading scriptures: {ex.Message}");
            return new List<Scripture>();
        }
    }

}

