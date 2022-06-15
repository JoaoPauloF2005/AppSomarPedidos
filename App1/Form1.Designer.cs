namespace App1
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
            this.lblProduto = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.txtPedido = new System.Windows.Forms.TextBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.btnInserir = new System.Windows.Forms.Button();
            this.listPedido = new System.Windows.Forms.ListView();
            this.Coluna1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Coluna2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Coluna3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.lblSaldoTotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPedido = new System.Windows.Forms.Label();
            this.lblSaldoEmpresa = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDespesas = new System.Windows.Forms.Label();
            this.txtDespesas = new System.Windows.Forms.TextBox();
            this.lblValorDespesas = new System.Windows.Forms.Label();
            this.txtValorDp = new System.Windows.Forms.TextBox();
            this.listDespesas = new System.Windows.Forms.ListView();
            this.Coluna1Dp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Coluna2Dp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnInserirDespesas = new System.Windows.Forms.Button();
            this.lblTotalDp = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.lblSaldoDespesa = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Location = new System.Drawing.Point(34, 58);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(43, 13);
            this.lblProduto.TabIndex = 0;
            this.lblProduto.Text = "Pedido:";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(34, 90);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(42, 13);
            this.lblCliente.TabIndex = 1;
            this.lblCliente.Text = "Cliente:";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(42, 129);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(34, 13);
            this.lblValor.TabIndex = 2;
            this.lblValor.Text = "Valor:";
            // 
            // txtPedido
            // 
            this.txtPedido.Location = new System.Drawing.Point(94, 55);
            this.txtPedido.Name = "txtPedido";
            this.txtPedido.Size = new System.Drawing.Size(207, 20);
            this.txtPedido.TabIndex = 3;
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(94, 87);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(303, 20);
            this.txtCliente.TabIndex = 4;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(94, 126);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(207, 20);
            this.txtValor.TabIndex = 5;
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(186, 182);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnInserir.Size = new System.Drawing.Size(98, 36);
            this.btnInserir.TabIndex = 6;
            this.btnInserir.Text = "Inserir Pedido";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // listPedido
            // 
            this.listPedido.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Coluna1,
            this.Coluna2,
            this.Coluna3});
            this.listPedido.HideSelection = false;
            this.listPedido.Location = new System.Drawing.Point(37, 235);
            this.listPedido.Name = "listPedido";
            this.listPedido.Size = new System.Drawing.Size(425, 253);
            this.listPedido.TabIndex = 7;
            this.listPedido.UseCompatibleStateImageBehavior = false;
            this.listPedido.View = System.Windows.Forms.View.Details;
            // 
            // Coluna1
            // 
            this.Coluna1.Text = "Pedido";
            this.Coluna1.Width = 129;
            // 
            // Coluna2
            // 
            this.Coluna2.Text = "Cliente";
            this.Coluna2.Width = 132;
            // 
            // Coluna3
            // 
            this.Coluna3.Text = "Valor";
            this.Coluna3.Width = 158;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(79, 532);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(121, 16);
            this.lblTotal.TabIndex = 8;
            this.lblTotal.Text = "Total dos Pedidos:";
          
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldo.Location = new System.Drawing.Point(79, 590);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(123, 16);
            this.lblSaldo.TabIndex = 9;
            this.lblSaldo.Text = "Saldo da Empresa:";
            // 
            // lblSaldoTotal
            // 
            this.lblSaldoTotal.AutoSize = true;
            this.lblSaldoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldoTotal.Location = new System.Drawing.Point(103, 654);
            this.lblSaldoTotal.Name = "lblSaldoTotal";
            this.lblSaldoTotal.Size = new System.Drawing.Size(46, 16);
            this.lblSaldoTotal.TabIndex = 10;
            this.lblSaldoTotal.Text = "Saldo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(161, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "Pedidos";
            // 
            // lblPedido
            // 
            this.lblPedido.AutoSize = true;
            this.lblPedido.Location = new System.Drawing.Point(293, 532);
            this.lblPedido.Name = "lblPedido";
            this.lblPedido.Size = new System.Drawing.Size(0, 13);
            this.lblPedido.TabIndex = 12;
            // 
            // lblSaldoEmpresa
            // 
            this.lblSaldoEmpresa.AutoSize = true;
            this.lblSaldoEmpresa.Location = new System.Drawing.Point(293, 590);
            this.lblSaldoEmpresa.Name = "lblSaldoEmpresa";
            this.lblSaldoEmpresa.Size = new System.Drawing.Size(7, 13);
            this.lblSaldoEmpresa.TabIndex = 13;
            this.lblSaldoEmpresa.Text = "\r\n";
            this.lblSaldoEmpresa.Click += new System.EventHandler(this.lblSaldoEmpresa_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(743, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 24);
            this.label4.TabIndex = 14;
            this.label4.Text = "Despesas";
            // 
            // lblDespesas
            // 
            this.lblDespesas.AutoSize = true;
            this.lblDespesas.Location = new System.Drawing.Point(621, 62);
            this.lblDespesas.Name = "lblDespesas";
            this.lblDespesas.Size = new System.Drawing.Size(57, 13);
            this.lblDespesas.TabIndex = 15;
            this.lblDespesas.Text = "Despesas:";
            // 
            // txtDespesas
            // 
            this.txtDespesas.Location = new System.Drawing.Point(694, 59);
            this.txtDespesas.Name = "txtDespesas";
            this.txtDespesas.Size = new System.Drawing.Size(316, 20);
            this.txtDespesas.TabIndex = 16;
            // 
            // lblValorDespesas
            // 
            this.lblValorDespesas.AutoSize = true;
            this.lblValorDespesas.Location = new System.Drawing.Point(627, 129);
            this.lblValorDespesas.Name = "lblValorDespesas";
            this.lblValorDespesas.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblValorDespesas.Size = new System.Drawing.Size(34, 13);
            this.lblValorDespesas.TabIndex = 17;
            this.lblValorDespesas.Text = "Valor:";
            // 
            // txtValorDp
            // 
            this.txtValorDp.Location = new System.Drawing.Point(694, 126);
            this.txtValorDp.Name = "txtValorDp";
            this.txtValorDp.Size = new System.Drawing.Size(229, 20);
            this.txtValorDp.TabIndex = 18;
            // 
            // listDespesas
            // 
            this.listDespesas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Coluna1Dp,
            this.Coluna2Dp});
            this.listDespesas.HideSelection = false;
            this.listDespesas.Location = new System.Drawing.Point(594, 235);
            this.listDespesas.Name = "listDespesas";
            this.listDespesas.Size = new System.Drawing.Size(416, 253);
            this.listDespesas.TabIndex = 19;
            this.listDespesas.UseCompatibleStateImageBehavior = false;
            this.listDespesas.View = System.Windows.Forms.View.Details;
            // 
            // Coluna1Dp
            // 
            this.Coluna1Dp.Text = "Despesas";
            this.Coluna1Dp.Width = 199;
            // 
            // Coluna2Dp
            // 
            this.Coluna2Dp.Text = "Valor";
            this.Coluna2Dp.Width = 213;
            // 
            // btnInserirDespesas
            // 
            this.btnInserirDespesas.Location = new System.Drawing.Point(747, 182);
            this.btnInserirDespesas.Name = "btnInserirDespesas";
            this.btnInserirDespesas.Size = new System.Drawing.Size(110, 36);
            this.btnInserirDespesas.TabIndex = 20;
            this.btnInserirDespesas.Text = "Inserir Despesas";
            this.btnInserirDespesas.UseVisualStyleBackColor = true;
            this.btnInserirDespesas.Click += new System.EventHandler(this.btnInserirDespesas_Click);
            // 
            // lblTotalDp
            // 
            this.lblTotalDp.AutoSize = true;
            this.lblTotalDp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDp.Location = new System.Drawing.Point(604, 530);
            this.lblTotalDp.Name = "lblTotalDp";
            this.lblTotalDp.Size = new System.Drawing.Size(126, 16);
            this.lblTotalDp.TabIndex = 21;
            this.lblTotalDp.Text = "Total de Despesas:";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(667, 636);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(119, 49);
            this.btnLimpar.TabIndex = 22;
            this.btnLimpar.Text = "Novo Lançamento";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(856, 636);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(119, 49);
            this.btnFechar.TabIndex = 23;
            this.btnFechar.Text = "Reiniciar Sistema";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // lblSaldoDespesa
            // 
            this.lblSaldoDespesa.AutoSize = true;
            this.lblSaldoDespesa.Location = new System.Drawing.Point(826, 530);
            this.lblSaldoDespesa.Name = "lblSaldoDespesa";
            this.lblSaldoDespesa.Size = new System.Drawing.Size(0, 13);
            this.lblSaldoDespesa.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(249, 654);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 738);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblSaldoDespesa);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.lblTotalDp);
            this.Controls.Add(this.btnInserirDespesas);
            this.Controls.Add(this.listDespesas);
            this.Controls.Add(this.txtValorDp);
            this.Controls.Add(this.lblValorDespesas);
            this.Controls.Add(this.txtDespesas);
            this.Controls.Add(this.lblDespesas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblSaldoEmpresa);
            this.Controls.Add(this.lblPedido);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSaldoTotal);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.listPedido);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.txtPedido);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.lblProduto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox txtPedido;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.ListView listPedido;
        private System.Windows.Forms.ColumnHeader Coluna1;
        private System.Windows.Forms.ColumnHeader Coluna2;
        private System.Windows.Forms.ColumnHeader Coluna3;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label lblSaldoTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPedido;
        private System.Windows.Forms.Label lblSaldoEmpresa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDespesas;
        private System.Windows.Forms.TextBox txtDespesas;
        private System.Windows.Forms.Label lblValorDespesas;
        private System.Windows.Forms.TextBox txtValorDp;
        private System.Windows.Forms.ListView listDespesas;
        private System.Windows.Forms.ColumnHeader Coluna1Dp;
        private System.Windows.Forms.ColumnHeader Coluna2Dp;
        private System.Windows.Forms.Button btnInserirDespesas;
        private System.Windows.Forms.Label lblTotalDp;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label lblSaldoDespesa;
        private System.Windows.Forms.Label label2;
    }
}

