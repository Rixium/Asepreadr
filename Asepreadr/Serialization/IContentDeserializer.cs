namespace Asepreadr.Serialization
{
    public interface IContentDeserializer
    {
        T Get<T>(string path);
    }
}