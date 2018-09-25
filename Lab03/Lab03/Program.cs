using System;
using System.Text;

namespace Lab03
{
    class Program
    {
        static void Main(string[] args)
        {
            Cuenta debito = new Debito(1, "Marco", 100);
            Cuenta credito = new Credito(0,"Annie",300);

            Console.WriteLine(Print(debito));
        }

        private static string Print(Cuenta c)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(c);
            sb.AppendLine();
            sb.Append(c.GetSummary());

            return sb.ToString();
        

        }

       
    }
}
