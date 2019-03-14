namespace FromStupidToSolid.Solid.ISP.ProductExample.Abstractions
{
    public interface IFixableProduct : IProduct
    {
        bool HasSpareParts { get; set; }
    }
}