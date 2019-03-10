namespace FromStupidToSolid.Stupid.LSP
{
    public class Square : Rectangle
    {
        public new int Height
        {
            get => base.Height;
            set
            {
                base.Height = value;
                base.Width = value;
            }
        }

        public new int Width
        {
            get => base.Width;
            set
            {
                Height = value;
            }
        }
    }
}