using FromStupidToSolid.Solid.ISP.PrinterExample.Abstractions;
using System;

namespace FromStupidToSolid.Solid.ISP.PrinterExample.Implementations
{
    public class NoNetworkCapabilitiesPrinter :
        IMultiFunctionPrinter,
        IScanner,
        IPhotocopier
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

        //// this class does not implement IMailSender so, no "SendEmail()" method declared
    }
}