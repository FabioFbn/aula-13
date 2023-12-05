using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula_13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ContaCorrente cc = new ContaCorrente();
        Manipula arquivo = new Manipula();
        Conexao con = new Conexao();

        private void btn_CriarConta_Click(object sender, EventArgs e)
        {
            cc.Agencia = txt_Agencia.Text;
            cc.NumConta = txt_Conta.Text;
            cc.Titular = txt_Titular.Text;
            cc.Saldo = Convert.ToDouble(txt_Saldo.Text);
            cc.Limite=Convert.ToDouble(txt_Limite.Text);
            MessageBox.Show("Conta criada com sucesso!");
            arquivo.Gravar(cc.Agencia + ";" + cc.NumConta + ";" + cc.Titular + ";" + cc.Saldo + ";" + cc.Limite+";");
            string sql = $"insert into db_conta values('{cc.Agencia}'," +
                $"'{cc.NumConta}', '{cc.Titular}', {cc.Saldo}, {cc.Limite});";
            if(con.Conectar())
            {
                if (con.Executa(sql)) MessageBox.Show("Cadastrado com sucesso!!");
                else MessageBox.Show("Nao cadastrou");
                con.Desconectar();
                
            }
            else
            {
                MessageBox.Show("ERRO NO BANCO");
            }
        }

        private void btn_Depositar_Click(object sender, EventArgs e)
        {
            cc.Depositar(Convert.ToDouble(txt_Valor.Text));
            txt_Saldo.Text = cc.Saldo.ToString();
            txt_Valor.Text = "";
            arquivo.Alterar(cc);
            string sql = $"update into db_conta set saldo = {cc.Saldo} where " +
                $"num_conta = '{cc.NumConta}';";
            if (con.Conectar())
            {
                if (con.Executa(sql)) MessageBox.Show("Depositado com suceso");
                else MessageBox.Show("Não foi posivel depositar");
                con.Desconectar();
            }
            else { MessageBox.Show(" Erro ao acessar o Banco"); }
        }

        private void btn_Sacar_Click(object sender, EventArgs e)
        {
            cc.Sacar(Convert.ToDouble(txt_Valor.Text));
            txt_Saldo.Text = cc.Saldo.ToString();
            txt_Valor.Text = "";
            arquivo.Alterar(cc);
            string sql = $"update db_conta set saldo = {cc.Saldo} where " +
                $"num_conta = '{cc.NumConta}';";
            if (con.Conectar())
            {
                if (con.Executa(sql)) MessageBox.Show("Sacado com suceso");
                else MessageBox.Show("Não foi posivel sacar");
                con.Desconectar();
            }
            else { MessageBox.Show(" Erro ao acessar o Banco"); }
        }

        private void btn_Dados_Click(object sender, EventArgs e)
        {
            //MessageBox.Show($"Agência : {cc.Agencia}\n Numero da conta: {cc.NumConta}\n Titular: {cc.Titular} \n Saldo: {cc.Saldo}\n Limite: {cc.Limite} \nValor do Tributo: {cc.CalculaTributo()}");
            if (con.Conectar())
            {
                string sql = $"select * from db_conta";
                DataTable dados = con.Retorna(sql);
                string texto = "";
                for (int i = 0; i < dados.Rows.Count; i++)
                {
                    texto += "Agencia: "+dados.Rows[i]["agencia"].ToString();
                    texto += "\nSaldo: "+dados.Rows[i]["saldo"].ToString();
                    texto += "\nTitular: "+dados.Rows[i]["titular"].ToString();
                    texto += "\nLimite: "+dados.Rows[i]["limite"].ToString();
                    texto += "\n \n";
                   
                }
                MessageBox.Show(texto);
                con.Desconectar();
            }
            else
            {
                MessageBox.Show("Erro ao conectar com o banco!");
            }
        }

        private void btnEXCLUIR_Click(object sender, EventArgs e)
        {
            cc = new ContaCorrente();
            cc.NumConta = txt_Conta.Text;
            arquivo.Apagar(cc);
            MessageBox.Show("Excluido com sucesso!");
            txt_Conta.Text = "";
            string sql = $"delete from db_conta where num_conta = '{cc.NumConta}';"; 
                
            if (con.Conectar())
            {
                if (con.Executa(sql)) MessageBox.Show("Excluido com suceso");
                else MessageBox.Show("Não foi posivel excluir");
                con.Desconectar();
            }
            else { MessageBox.Show("Erro ao acessar o banco"); }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            cc = new ContaCorrente();
            cc.NumConta = txt_Conta.Text;
            ContaCorrente conta = new ContaCorrente();
            conta = arquivo.Pesquisar(cc);
            //txt_Agencia.Text = conta.Agencia;
            //txt_Saldo.Text = conta.Saldo.ToString();
            //txt_Titular.Text = conta.Titular;
            //txt_Limite.Text = conta.Limite.ToString();
            if (con.Conectar())
            { 
            string sql = $"select * from db_conta where num_conta = '{cc.NumConta}';";
            DataTable dados = con.Retorna(sql);
            txt_Agencia.Text = dados.Rows[0]["agencia"].ToString();
            cc.Saldo = Convert.ToDouble(dados.Rows[0]["saldo"].ToString());
            txt_Titular.Text = dados.Rows[0]["titular"].ToString();
            txt_Limite.Text = dados.Rows[0]["limite"].ToString();
            con.Desconectar();
            }
            else
            {
                MessageBox.Show("Erro ao conectar com o banco!");
            }
            

            
            
            
        }
    }
}
