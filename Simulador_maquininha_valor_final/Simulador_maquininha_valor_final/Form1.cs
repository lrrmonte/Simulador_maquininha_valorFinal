using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulador_maquininha_valor_final
{
    public partial class Form1 : Form
    {
        double valor_venda, taxa, vlr_receber, valor_pmt, valor_taxa;
        int prazo;
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_Calcular_Click(object sender, EventArgs e)
        {
            Converter();

            vlr_receber = valor_venda * (1 - (taxa / 100));
            valor_pmt=valor_venda/prazo;
            valor_taxa = valor_venda - vlr_receber;

            lb_vlr_receber.Text = Math.Round(vlr_receber,2).ToString();
            lb_pmt_cliente.Text= Math.Round(valor_pmt,2).ToString();
            lb_valor_taxa.Text = Math.Round(valor_taxa,2).ToString();
        }

        private void bt_Limpar_Click(object sender, EventArgs e)
        {
            tb_valor_venda.Clear();
            tb_prazo.Clear();
            tb_taxa.Clear();
            lb_vlr_receber.ResetText();
            lb_pmt_cliente.ResetText();
            lb_valor_taxa.ResetText();
            tb_valor_venda.Focus();
        }

        private void bt_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Converter()
        {
            try
            {
                valor_venda = double.Parse(tb_valor_venda.Text);
                prazo = Convert.ToInt16(tb_prazo.Text);
                taxa = double.Parse(tb_taxa.Text);
            }
            catch(Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
    }
}
