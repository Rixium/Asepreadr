using System.IO;
using Asepreadr.Aseprite;
using Asepreadr.Serialization;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Asepreadr.Loaders
{
    public class AsepriteSpriteMapLoader : IContentLoader<AsepriteSpriteMap>
    {
        private readonly IContentDeserializer _contentDeserializer;
        private ContentManager _contentManager;

        public AsepriteSpriteMapLoader(ContentManager contentManager, IContentDeserializer contentDeserializer)
        {
            _contentManager = contentManager;
            _contentDeserializer = contentDeserializer;
        }

        public AsepriteSpriteMap GetContent(string path)
        {
            var asepriteData = _contentDeserializer.Get<AsepriteData>(path);
            var name = Path.GetFileNameWithoutExtension(asepriteData.Meta.Image);
            var fullPath = Path.Combine(Path.GetDirectoryName(path) ?? "",
                Path.GetFileNameWithoutExtension(path));

            var image = _contentManager.Load<Texture2D>(fullPath);

            return new AsepriteSpriteMap(name, image, asepriteData.Meta.Slices);
        }
    }
}