using System.IO;
using Microsoft.Xna.Framework.Content;

namespace Asepreadr
{
    public class ContentChest : IContentChest
    {
        public ContentManager ContentManager { get; set; }
        public T Get<T>(string assetName)
        {
            var fixedPath = assetName.Replace($"Assets{Path.DirectorySeparatorChar}", "");
            fixedPath = fixedPath.Split('.')[0];
            return ContentManager.Load<T>(fixedPath);
        }
    }
}