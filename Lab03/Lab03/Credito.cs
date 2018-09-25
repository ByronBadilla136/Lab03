using System;
using System.Collections.Generic;
using System.Text;

namespace Lab03
{
    class Credito : Cuenta
    {
        public int creditosaldo { get; set; }
        public Credito(int monto, string Nombre, int creditosaldo) : base(monto, Nombre)
        {
            this.creditosaldo = creditosaldo;
        }

        public override string GetSummary()
        {
            string montoCstring = "";
            for (int i = 0; i < creditosaldo; i++)
            {
                montoCstring += creditosaldo;
            }

            return "Debito: " + base.GetSummary() + "Monto: " + montoCstring;
        }
    }
}
