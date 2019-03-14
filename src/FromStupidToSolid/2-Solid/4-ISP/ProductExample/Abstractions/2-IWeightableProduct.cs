namespace FromStupidToSolid.Solid.ISP.ProductExample.Abstractions
{
    public interface IWeightableProduct : IProduct
    {
        decimal Weight { get; set; }
    }
}