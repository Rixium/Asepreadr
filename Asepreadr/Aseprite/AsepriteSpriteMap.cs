using System;
using System.Linq;
using Asepreadr.Graphics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Asepreadr.Aseprite
{
    public class AsepriteSpriteMap
    {
        public AsepriteSlice[] Regions { get; }

        public string Name { get; }
        public Texture2D Image { get; set; }

        public AsepriteSpriteMap(string name, Texture2D image, AsepriteSlice[] regions)
        {
            Name = name;
            Image = image;
            Regions = regions;
        }

        public Sprite CreateSpriteFromRegion(string regionName)
        {
            var region = Regions.FirstOrDefault(x => x.Name.Equals(regionName, StringComparison.OrdinalIgnoreCase));

            if (region == null)
                throw new RegionNotFoundException();

            var regionBounds = region.Keys.First().Bounds.ToRectangle();
            return new Sprite(Image, regionBounds, Vector2.One * 0.5f);
        }
    }

    public class RegionNotFoundException : Exception
    {
    }
}