using System;
using System.Diagnostics;

namespace Paragon
{
    public class Programs
    {
        private readonly string _powerDvd = @"C:\Program Files\CyberLink\PowerDVD20\PDVDLP.exe";
        private readonly string _outlook = @"C:\Program Files\Microsoft Office\root\Office16\OUTLOOK.EXE";
        private readonly string _steam = @"D:\Steam\steam.exe";

        public void PowerDvd()
        {
            Console.WriteLine("-----Starting PowerDvD-----");
            Console.WriteLine();
            Process.Start(_powerDvd);
        }

        public void Outlook()
        {
            Console.WriteLine("-----Starting Outlook-----");
            Console.WriteLine();
            Process.Start(_outlook);
        }

        public void Steam()
        {
            Console.WriteLine("-----Starting Steam-----");
            Console.WriteLine();
            Process.Start(_steam);
        }

        public void Calculator()
        {
            Console.WriteLine("-----Starting Calculator-----");
            Console.WriteLine();
            var calculator = new Calculator();
            calculator.CalculatorBuild();
        }
    }
}