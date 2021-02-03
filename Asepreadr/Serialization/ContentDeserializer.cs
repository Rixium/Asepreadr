using System.IO;
using Newtonsoft.Json;

namespace Asepreadr.Serialization
{
    public class ContentDeserializer : IContentDeserializer
    {
        public T Get<T>(string path)
        {
            var text = File.ReadAllText(path);
            var data = JsonConvert.DeserializeObject<T>(text);
            return data;
        }
    }
}