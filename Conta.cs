using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_13
{
    public class Conta
    {
        public string Agencia { get; set; }
        public string NumConta { get; set; }
        public string Titular { get; set; }
        public double Saldo { get; set; }
        public void Depositar(double valor)
        {
            Saldo += valor;
        }
    }
}
