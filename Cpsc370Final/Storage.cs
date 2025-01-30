namespace Cpsc370Final;

using System.Text.Json;
using System.Text.Json.Serialization;

public class Storage
{
    private string jsonFileName;

    public Storage(string fileName)
    {
        jsonFileName = fileName;
    }
        
    public void AddObjectToJson<T>(T obj)
    {
        List<T> objects = ReadObjectsFromJson<T>();
        objects.Add(obj);
        
        string json = JsonSerializer.Serialize(objects, new JsonSerializerOptions { WriteIndented = true });
        
        File.WriteAllText(jsonFileName, json);
    }

    public List<T> ReadObjectsFromJson<T>()
    {
        if (!File.Exists(jsonFileName))
        {
            return new List<T>();
        }
        
        string json = File.ReadAllText(jsonFileName);
        
        return JsonSerializer.Deserialize<List<T>>(json) ?? new List<T>();
    }
    
}