using System.IO;
using Asepreadr.Aseprite;
using Asepreadr.Serialization;
using Microsoft.Xna.Framework.Graphics;

namespace Asepreadr.Loaders
{
    public class AsepriteSpriteMapLoader : IContentLoader<AsepriteSpriteMap>
    {
        private readonly IContentChest _contentChest;
        private readonly IContentDeserializer _contentDeserializer;

        public AsepriteSpriteMapLoader(IContentChest contentChest, IContentDeserializer contentDeserializer)
        {
            _contentChest = contentChest;
            _contentDeserializer = contentDeserializer;
        }

        public AsepriteSpriteMap GetContent(string path)
        {
            var asepriteData = _contentDeserializer.Get<AsepriteData>(path);
            var name = Path.GetFileNameWithoutExtension(asepriteData.Meta.Image);
            var fullPath = Path.Combine(Path.GetDirectoryName(path) ?? "",
                Path.GetFileNameWithoutExtension(path));

            var image = _contentChest.Get<Texture2D>(fullPath);

            return new AsepriteSpriteMap(name, image, asepriteData.Meta.Slices);
        }
    }
}