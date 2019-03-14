using System;

namespace FromStupidToSolid.Stupid.ISP.PrinterExample
{

    public class FullMultiFunctionPrinter : IMultiFunctionPrinter
    {
        public void Photocopy()
        {
            Console.WriteLine("I know how to photocopy!");
        }

        public void Print()
        {
            Console.WriteLine("Printing...");
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