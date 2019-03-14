using FromStupidToSolid.Solid.ISP.PrinterExample.Abstractions;
using System;

namespace FromStupidToSolid.Solid.ISP.PrinterExample.Implementations
{
    public class FullMultiFunctionPrinter :
        IMultiFunctionPrinter,
        IPhotocopier,
        IScanner,
        IMailNotifier
    {
        public void Print()
        {
            Console.WriteLine("Printing...");
        }

        public void Photocopy()
        {
            Console.WriteLine("I know how to photocopy!");
        }

        public void Scan()
        {
            Console.WriteLine("Scaning...");
        }

        public void SendEmail()
        {
            Console.WriteLine("Sending email to...");
        }
    }
}