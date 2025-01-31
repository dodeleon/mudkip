namespace Cpsc370Final;

using System.Text.Json;
using System.Text.Json.Serialization;

public class Storage<T>
{
    private string jsonFileName;

    public Storage(string fileName)
    {
        jsonFileName = fileName;
    }
        
    public void AddObjectToJson(T obj)
    {
        List<T> objects = ReadObjectsFromJson();
        objects.Add(obj);
        
        string json = JsonSerializer.Serialize(objects, new JsonSerializerOptions { WriteIndented = true });
        
        File.WriteAllText(jsonFileName, json);
    }

    public List<T> ReadObjectsFromJson()
    {
        if (!File.Exists(jsonFileName))
        {
            return new List<T>();
        }
        
        string json = File.ReadAllText(jsonFileName);
        
        return JsonSerializer.Deserialize<List<T>>(json) ?? new List<T>();
    }
    
}