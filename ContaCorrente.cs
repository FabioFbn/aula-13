using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_13
{
    public class ContaCorrente : Conta, IConta
    {
        public double Limite { get; set; }
        public double CalculaTributo()
        {
            return Saldo * 0.015;
        }

        public void Sacar(double valor)
        {
           if((Saldo + Limite)>=valor)
            {
                Saldo -= valor;
            }
        }
    }
}
