namespace Asepreadr.Aseprite
{
    public class AsepriteMeta
    {
        public string App { get; set; }
        public string Version { get; set; }
        public string Image { get; set; }
        public string Formate { get; set; }
        public AsepriteSize Size { get; set; }
        public string Scale { get; set; }
        public string[] FrameTags { get; set; }
        public AsepriteLayer[] Layers { get; set; }
        public AsepriteSlice[] Slices { get; set; }
    }
}