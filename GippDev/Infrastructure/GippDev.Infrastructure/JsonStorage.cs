using Newtonsoft.Json;

namespace GippDev.Infrastructure;

public class JsonStorage
{
    public T Get<T>(string filePath)
    {
        var json = File.ReadAllText(filePath);
        return JsonConvert.DeserializeObject<T>(json);
    }
}

