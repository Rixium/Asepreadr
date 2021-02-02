using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Vector2 = Microsoft.Xna.Framework.Vector2;

namespace Asepreadr.Graphics
{
    public class Sprite
    {
        public Texture2D Texture { get; }
        public Rectangle Source { get; }
        public Vector2 Origin { get; set; }
        public Vector2 Center => new Vector2(Width, Height) / 2.0f;

        public int Width => Source.Width;
        public int Height => Source.Height;
        public Color Color { get; set; } = Color.White;

        public Sprite(Texture2D texture, Rectangle sourceRectangle, Vector2 origin)
        {
            Texture = texture;
            Source = sourceRectangle;
            Origin = origin;
        }


        public Sprite(Texture2D texture, Rectangle sourceRectangle) : this(texture, sourceRectangle,
            new Vector2(0.5f, 0.5f))
        {
        }

        public Sprite(Texture2D texture) : this(texture, new Rectangle(0, 0, texture.Width, texture.Height),
            new Vector2(0.5f, 0.5f))
        {
        }
    }
}