using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fifa2023.Core
{
    public class Transferencias
    {
        public int idTransferencia;

        public DateOnly Fecha;

        public float Precio;

        public int idVendedor;

        public int idComprador;

        public int idFutbolista;

        public bool Transferencia_exitosa;
    }
}