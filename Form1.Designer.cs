namespace aula_13
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Agencia = new System.Windows.Forms.TextBox();
            this.txt_Titular = new System.Windows.Forms.TextBox();
            this.txt_Conta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Saldo = new System.Windows.Forms.TextBox();
            this.txt_Limite = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_CriarConta = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Valor = new System.Windows.Forms.TextBox();
            this.btn_Depositar = new System.Windows.Forms.Button();
            this.btn_Sacar = new System.Windows.Forms.Button();
            this.btn_Dados = new System.Windows.Forms.Button();
            this.btnEXCLUIR = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Agência:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Titular:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(331, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nº Conta";
            // 
            // txt_Agencia
            // 
            this.txt_Agencia.Location = new System.Drawing.Point(174, 67);
            this.txt_Agencia.Name = "txt_Agencia";
            this.txt_Agencia.Size = new System.Drawing.Size(100, 20);
            this.txt_Agencia.TabIndex = 3;
            // 
            // txt_Titular
            // 
            this.txt_Titular.Location = new System.Drawing.Point(174, 117);
            this.txt_Titular.Name = "txt_Titular";
            this.txt_Titular.Size = new System.Drawing.Size(408, 20);
            this.txt_Titular.TabIndex = 4;
            // 
            // txt_Conta
            // 
            this.txt_Conta.Location = new System.Drawing.Point(418, 70);
            this.txt_Conta.Name = "txt_Conta";
            this.txt_Conta.Size = new System.Drawing.Size(100, 20);
            this.txt_Conta.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(88, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Saldo:";
            // 
            // txt_Saldo
            // 
            this.txt_Saldo.Location = new System.Drawing.Point(174, 171);
            this.txt_Saldo.Name = "txt_Saldo";
            this.txt_Saldo.Size = new System.Drawing.Size(100, 20);
            this.txt_Saldo.TabIndex = 7;
            // 
            // txt_Limite
            // 
            this.txt_Limite.Location = new System.Drawing.Point(482, 181);
            this.txt_Limite.Name = "txt_Limite";
            this.txt_Limite.Size = new System.Drawing.Size(100, 20);
            this.txt_Limite.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(395, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Limite:";
            // 
            // btn_CriarConta
            // 
            this.btn_CriarConta.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CriarConta.Location = new System.Drawing.Point(372, 248);
            this.btn_CriarConta.Name = "btn_CriarConta";
            this.btn_CriarConta.Size = new System.Drawing.Size(111, 54);
            this.btn_CriarConta.TabIndex = 10;
            this.btn_CriarConta.Text = "CRIAR CONTA";
            this.btn_CriarConta.UseVisualStyleBackColor = true;
            this.btn_CriarConta.Click += new System.EventHandler(this.btn_CriarConta_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(237, 331);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Valor:";
            // 
            // txt_Valor
            // 
            this.txt_Valor.Location = new System.Drawing.Point(307, 328);
            this.txt_Valor.Name = "txt_Valor";
            this.txt_Valor.Size = new System.Drawing.Size(138, 20);
            this.txt_Valor.TabIndex = 12;
            // 
            // btn_Depositar
            // 
            this.btn_Depositar.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Depositar.Location = new System.Drawing.Point(133, 384);
            this.btn_Depositar.Name = "btn_Depositar";
            this.btn_Depositar.Size = new System.Drawing.Size(138, 54);
            this.btn_Depositar.TabIndex = 13;
            this.btn_Depositar.Text = "DEPOSITAR";
            this.btn_Depositar.UseVisualStyleBackColor = true;
            this.btn_Depositar.Click += new System.EventHandler(this.btn_Depositar_Click);
            // 
            // btn_Sacar
            // 
            this.btn_Sacar.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sacar.Location = new System.Drawing.Point(321, 384);
            this.btn_Sacar.Name = "btn_Sacar";
            this.btn_Sacar.Size = new System.Drawing.Size(111, 54);
            this.btn_Sacar.TabIndex = 14;
            this.btn_Sacar.Text = "SACAR";
            this.btn_Sacar.UseVisualStyleBackColor = true;
            this.btn_Sacar.Click += new System.EventHandler(this.btn_Sacar_Click);
            // 
            // btn_Dados
            // 
            this.btn_Dados.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Dados.Location = new System.Drawing.Point(494, 384);
            this.btn_Dados.Name = "btn_Dados";
            this.btn_Dados.Size = new System.Drawing.Size(111, 54);
            this.btn_Dados.TabIndex = 15;
            this.btn_Dados.Text = "EXIBIR DADOS";
            this.btn_Dados.UseVisualStyleBackColor = true;
            this.btn_Dados.Click += new System.EventHandler(this.btn_Dados_Click);
            // 
            // btnEXCLUIR
            // 
            this.btnEXCLUIR.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEXCLUIR.Location = new System.Drawing.Point(239, 248);
            this.btnEXCLUIR.Name = "btnEXCLUIR";
            this.btnEXCLUIR.Size = new System.Drawing.Size(111, 54);
            this.btnEXCLUIR.TabIndex = 16;
            this.btnEXCLUIR.Text = "EXCLUIR CONTA";
            this.btnEXCLUIR.UseVisualStyleBackColor = true;
            this.btnEXCLUIR.Click += new System.EventHandler(this.btnEXCLUIR_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Location = new System.Drawing.Point(630, 36);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(111, 50);
            this.btnPesquisar.TabIndex = 17;
            this.btnPesquisar.Text = "PESQUISAR";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnEXCLUIR);
            this.Controls.Add(this.btn_Dados);
            this.Controls.Add(this.btn_Sacar);
            this.Controls.Add(this.btn_Depositar);
            this.Controls.Add(this.txt_Valor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_CriarConta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_Limite);
            this.Controls.Add(this.txt_Saldo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Conta);
            this.Controls.Add(this.txt_Titular);
            this.Controls.Add(this.txt_Agencia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Agencia;
        private System.Windows.Forms.TextBox txt_Titular;
        private System.Windows.Forms.TextBox txt_Conta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Saldo;
        private System.Windows.Forms.TextBox txt_Limite;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_CriarConta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Valor;
        private System.Windows.Forms.Button btn_Depositar;
        private System.Windows.Forms.Button btn_Sacar;
        private System.Windows.Forms.Button btn_Dados;
        private System.Windows.Forms.Button btnEXCLUIR;
        private System.Windows.Forms.Button btnPesquisar;
    }
}

