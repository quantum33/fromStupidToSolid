using System;

namespace FromStupidToSolid.Stupid.ISP.PrinterExample
{
    public class NoNetworkCapabilitiesPrinter : IMultiFunctionPrinter
    {
        public void Photocopy()
        {
            Console.WriteLine("I know how to photocopy!");
        }

        public void Print()
        {
            Console.WriteLine("I know how to print...");
        }

        public void Scan()
        {
            Console.WriteLine("I know how to scan...");
        }

        public void SendEmail()
        {
            throw new InvalidOperationException("I can't send any email: I have no network capabilities");
        }
    }
}