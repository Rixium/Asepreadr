namespace Asepreadr.Aseprite
{
    public class AsepriteFrame
    {
        public string FileName { get; set; }
        public AsepriteFrameSource Frame { get; set; }
        public bool Rotated { get; set; }
        public bool Trimmed { get; set; }
        public AsepriteFrameSource SpriteSourceSize { get; set; }
        public AsepriteSize SourceSize { get; set; }
        public int Duration { get; set; }
    }
}