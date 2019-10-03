
using System.Collections.Generic;
using FluentBanco.Models;

namespace FluentBanco.Builder
{
    public class CuentaFluentBuilder
    {
        private readonly Cuenta _cuenta;

        public static CuentaFluentBuilder Crear(Tipo tipo)
        {
            return new CuentaFluentBuilder(tipo);
        }

        private CuentaFluentBuilder(Tipo tipo)
        {
            _cuenta = new Cuenta { Tipo = tipo };
        }

        public CuentaFluentBuilder NumeroCuenta(int numCuenta)
        {
            _cuenta.NumeroCuenta = numCuenta;
            return this;
        }
        public CuentaFluentBuilder Propietario(string propietario)
        {
            _cuenta.Propietario = propietario;
            return this;
        }
        public CuentaFluentBuilder Tasa(double tasa)
        {
            _cuenta.Tasa = tasa;
            return this;
        }
        public CuentaFluentBuilder SaldoInicial(double saldoinicial)
        {
            _cuenta.Saldo = saldoinicial;
            return this;
        }

        public Cuenta AbrirCuenta()
        {
            return _cuenta;
        }
    }
}
