using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControllerProject;
using ModelProject;

namespace ViewProject
{
    public partial class FormProduto : Form
    {
        public FormProduto()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            var produto = new Produto()
            {
                Id = (txtIdProduto.Text == string.Empty ?
                    Guid.NewGuid() : new Guid(txtIdProduto.Text)),
                Descricao = txtDescricaoProduto.Text,
                PrecoCusto = txtPrecoDeCustoProduto.Text,
                PrecoVenda = txtPrecoDeVendaProduto.Text,
                EstoqueProduto = txtEstoqueProduto.Text
            };

            produto = (txtIdProduto.Text == string.Empty ?
                    this.controller.Insert(produto) :
                    this.controller.Update(produto));
            dgvProdutos.DataSource = null;
            dgvProdutos.DataSource = this.controller.GetAll();
            ClearControls();
        }
    }
}
