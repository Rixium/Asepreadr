namespace Asepreadr.Loaders
{
    public interface IContentLoader<T>
    {
        T GetContent(string path);
    }
}