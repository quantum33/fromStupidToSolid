namespace FromStupidToSolid.Solid.LSP
{
    public abstract class FormBase
    {
        public abstract int GetArea();
    }

    public class Rectangle : FormBase
    {
        public int Height { get; set; }
        public int Width { get; set; }

        public override int GetArea()
            => Height * Width;
    }

    public class Square : FormBase
    {
        public int Side { get; set; }

        public override int GetArea()
            => Side * Side;
    }
}