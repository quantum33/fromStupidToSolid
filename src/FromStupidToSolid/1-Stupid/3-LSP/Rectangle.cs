using System;

namespace FromStupidToSolid.Stupid.LSP
{
    public class Rectangle
    {
        public int Height { get; set; }
        public int Width { get; set; }

        public int GetArea()
            => Height * Width;
    }
}