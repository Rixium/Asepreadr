using Microsoft.Xna.Framework.Content;

namespace Asepreadr
{
    public interface IContentChest
    {
        ContentManager ContentManager { get; set; }
        T Get<T>(string assetName);
    }
}