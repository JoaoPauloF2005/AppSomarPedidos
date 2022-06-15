using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double resultado;
        double resultado_dp;
        double resultado_saldo_empresa;
        

       

        private void btnInserir_Click(object sender, EventArgs e)
        {
            double pedido = double.Parse(txtPedido.Text);
            string Cliente = txtCliente.Text;
            double valor = double.Parse(txtValor.Text);

            resultado += pedido * valor;

            lblPedido.Text = resultado.ToString("C");

            ListViewItem item = new ListViewItem(txtPedido.Text);
            
            item.SubItems.Add(txtCliente.Text);
            item.SubItems.Add(txtValor.Text);
            listPedido.Items.Add(item);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnInserirDespesas_Click(object sender, EventArgs e)
        {
            string despesas = txtDespesas.Text;
            double valor_despesas = double.Parse(txtValorDp.Text);

            ListViewItem item = new ListViewItem(txtDespesas.Text);
            item.SubItems.Add(txtValorDp.Text);
            listDespesas.Items.Add(item);

            resultado_dp += valor_despesas;

            lblSaldoDespesa.Text = resultado_dp.ToString("C");

            double saldo = resultado - resultado_dp;

            lblSaldoTotal.Text = saldo.ToString("C");

            
        }

      

       

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtPedido.Clear();
            txtCliente.Clear();
            txtValor.Clear();
            txtDespesas.Clear();
            txtValorDp.Clear();
            listPedido.Clear();
            listDespesas.Clear();
        }

        private void lblSaldoEmpresa_Click(object sender, EventArgs e)
        {
            double valor = double.Parse(txtValor.Text); 
            double valorDespesas = double.Parse(lblValorDespesas.Text);

            resultado_saldo_empresa = valor - valorDespesas;

           
        }



      
    }
}
