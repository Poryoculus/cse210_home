using System; 
using System.IO;
using Newtonsoft.Json;

public class JsonLector
{
    public List<Scripture> LoadScriptures(string file)
    {
        
            var json = File.ReadAllText(file);

            
            var scriptureDataList = JsonConvert.DeserializeObject<List<Df>>(json);
            
            
            List<Scripture> scriptures = new List<Scripture>();
            foreach (var item in scriptureDataList)
            {
                Reference reference;
                if (item.Reference.EndVerse == null)
                    {
                        reference = new Reference(item.Reference.Book, item.Reference.Chapter, item.Reference.StartVerse);
                    }
                else
                    {
                        reference = new Reference(item.Reference.Book, item.Reference.Chapter, item.Reference.StartVerse, item.Reference.EndVerse.Value);
                    }
                var scripture = new Scripture(reference, item.ScriptureText);
                
                scriptures.Add(scripture);
            }

            return scriptures;
        
    }

}

public class Df
{
    public RefData Reference { get; set; }
    public string ScriptureText { get; set; }
}

public class RefData
{
    public string Book { get; set; }
    public int Chapter { get; set; }
    public int StartVerse { get; set; }
    public int? EndVerse { get; set; } 
}