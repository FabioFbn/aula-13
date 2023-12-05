using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace aula_13
{
    public class Manipula
    {
        private string caminho = "C://aula/Conta.txt";
        public void Gravar(string texto)
        {
            StreamWriter sw = File.AppendText(caminho);
            sw.WriteLine(texto);
            sw.Close();
        }
        public void Alterar(ContaCorrente c)
        {
            string texto = "";
            if (File.Exists(caminho))
            {
                using (StreamReader sr = new StreamReader(caminho))
                {
                    string linha;
                    while ((linha = sr.ReadLine()) != null)
                    {
                        var arquivo = linha.Split(';');
                        if (arquivo[1].Equals(c.NumConta))
                        {
                            string nova = c.Agencia + " ; " + c.NumConta + " ; " + c.Titular + " ; " + c.Limite + " ; ";
                            texto += nova + "\n";

                        }
                        else
                        {
                            texto += linha + "\n";
                        }

                    }
                    sr.Close();
                    File.Delete(caminho);
                    StreamWriter sw = new StreamWriter(caminho);
                    sw.Write(texto);
                    sw.Close();
                }
            }
        }
        public void Apagar(ContaCorrente c)
        {
            string texto = "";
            if (File.Exists(caminho))
            {
                using (StreamReader sr = new StreamReader(caminho))
                {
                    string linha;
                    while ((linha = sr.ReadLine()) != null)
                    {
                        var arquivo = linha.Split(';');
                        if (!arquivo[1].Equals(c.NumConta))
                        {
                            texto += linha + "\n";
                        }

                    }
                    sr.Close();
                    File.Delete(caminho);
                    StreamWriter sw = new StreamWriter(caminho);
                    sw.Write(texto);
                    sw.Close();
                }
            }
        }

        public ContaCorrente Pesquisar(ContaCorrente c)
        {
            ContaCorrente conta = new ContaCorrente();
            if (File.Exists(caminho))
            {
                StreamReader sr = new StreamReader(caminho);
                string linha;
                while ((linha = sr.ReadLine()) != null)
                {
                    var arquivo = linha.Split(';');
                    if (arquivo[1].Equals(c.NumConta))
                    {
                        conta.Agencia = arquivo[0];
                        conta.NumConta = arquivo[1];
                        conta.Titular = arquivo[2];
                        conta.Saldo = Convert.ToDouble(arquivo[3]);
                        conta.Limite = Convert.ToDouble(arquivo[4]);
                    }
                }
                sr.Close();
            }
            return conta;
        }
    }
}
