using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentBanco.Models
{
    public class Cuenta
    {
        public Tipo Tipo { get; set; }
        public int NumeroCuenta { get; set; }
        public double Saldo { get; set; }
        public string Propietario { get; set; }
        public double Tasa { get; set; }

        public Cuenta(int numCuenta, double saldo, double tasa, Tipo tipo, string propietario)
        {
            NumeroCuenta = numCuenta;
            Saldo = saldo;
            Tasa = tasa;
            Tipo = tipo;
            Propietario = propietario;
        }

        //internal static Cuenta GetInstance()
        //{
        //    throw new NotImplementedException();
        //}

        public Cuenta()
        {

        }

        //public List<Cuenta> ListaCuentas = new List<Cuenta>();

    }
}
