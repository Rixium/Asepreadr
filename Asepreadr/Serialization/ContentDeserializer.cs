using System.IO;
using System.Text.Json;

namespace Asepreadr.Serialization
{
    public class ContentDeserializer : IContentDeserializer
    {
        public T Get<T>(string path)
        {
            var text = File.ReadAllText(path);
            var data = JsonSerializer.Deserialize<T>(text);
            return data;
        }
    }
}