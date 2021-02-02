using Microsoft.Xna.Framework;

namespace Asepreadr.Aseprite
{
    public class AsepriteFrameSource
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int W { get; set; }
        public int H { get; set; }

        public Rectangle ToRectangle() => new Rectangle(X, Y, W, H);
    }
}