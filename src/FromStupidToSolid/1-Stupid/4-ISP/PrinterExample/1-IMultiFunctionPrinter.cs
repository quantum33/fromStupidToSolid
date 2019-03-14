namespace FromStupidToSolid.Stupid.ISP.PrinterExample
{
    public interface IMultiFunctionPrinter
    {
        void SendEmail();

        void Print();

        void Scan();

        void Photocopy();
    }
}