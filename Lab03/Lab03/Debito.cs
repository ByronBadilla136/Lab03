using System;
using System.Collections.Generic;
using System.Text;

namespace Lab03
{
    class Debito : Cuenta
    {
        public int debitosaldo { get; set; }

        public Debito(int monto, string Nombre, int montoD) : base(monto, Nombre)
        {
            this.debitosaldo = montoD;

        }

        public override string GetSummary()
        {
            string montoDstring = "";
            for (int i = 0; i < debitosaldo; i++)
            {
                montoDstring += debitosaldo;
            }

            return "Debito: " + base.GetSummary() + "Monto: " + montoDstring;
        }
    }
}
