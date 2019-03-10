namespace FromStupidToSolid
{
    public class Square : Rectangle
    {
        public Square()
        {
            Name = nameof(Square);
        }

        public new void SetHeight(int height)
        {
            base.SetHeight(height);
            base.SetWidth(height);
        }

        public new void SetWidth(int width)
        {
            SetHeight(width);
        }
    }
}