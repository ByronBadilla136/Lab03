using System;
using System.Collections.Generic;
using System.Text;

namespace Lab03
{
    class Cuenta
    {
        public int monto { get; set; }
        public string Nombre { get; set; }
        
        public Cuenta(int monto, string Nombre)
        {
            this.monto = monto;
            this.Nombre = Nombre;
        }
        public virtual string GetSummary()
        {
            return Nombre + " " + monto;

        }
    }
}
