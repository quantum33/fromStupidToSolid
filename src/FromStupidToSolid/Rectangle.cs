using System;

namespace FromStupidToSolid
{
    public class Rectangle
    {
        private int _height;

        private int _width;

        public void SetHeight(int height)
        {
            _height = height;
        }

        public int GetHeight()
            => _height;

        public void SetWidth(int width)
        {
            _width = width;
        }

        public int GetWidth()
            => _width;

        public int GetArea()
            => _height * _width;
    }
}