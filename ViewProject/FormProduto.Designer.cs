
namespace ViewProject
{
    partial class FormProduto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblEstoqueProduto = new System.Windows.Forms.Label();
            this.lblPrecoDeVendaProduto = new System.Windows.Forms.Label();
            this.txtPrecoDeCustoProduto = new System.Windows.Forms.TextBox();
            this.txtDescricaoProduto = new System.Windows.Forms.TextBox();
            this.lblIdProduto = new System.Windows.Forms.Label();
            this.lblDescricaoProduto = new System.Windows.Forms.Label();
            this.lblPrecoDeCustoProduto = new System.Windows.Forms.Label();
            this.txtIdProduto = new System.Windows.Forms.TextBox();
            this.txtPrecoDeVendaProduto = new System.Windows.Forms.TextBox();
            this.txtEstoqueProduto = new System.Windows.Forms.TextBox();
            this.btnGravarProdutos = new System.Windows.Forms.Button();
            this.btnRemoverProdutos = new System.Windows.Forms.Button();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.46043F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.53957F));
            this.tableLayoutPanel1.Controls.Add(this.lblEstoqueProduto, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblPrecoDeVendaProduto, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtPrecoDeCustoProduto, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtDescricaoProduto, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblIdProduto, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblDescricaoProduto, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblPrecoDeCustoProduto, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtIdProduto, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtPrecoDeVendaProduto, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtEstoqueProduto, 1, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(417, 203);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // lblEstoqueProduto
            // 
            this.lblEstoqueProduto.Location = new System.Drawing.Point(3, 151);
            this.lblEstoqueProduto.Name = "lblEstoqueProduto";
            this.lblEstoqueProduto.Size = new System.Drawing.Size(94, 31);
            this.lblEstoqueProduto.TabIndex = 8;
            this.lblEstoqueProduto.Text = "Estoque:";
            this.lblEstoqueProduto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblEstoqueProduto.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblPrecoDeVendaProduto
            // 
            this.lblPrecoDeVendaProduto.Location = new System.Drawing.Point(3, 106);
            this.lblPrecoDeVendaProduto.Name = "lblPrecoDeVendaProduto";
            this.lblPrecoDeVendaProduto.Size = new System.Drawing.Size(94, 31);
            this.lblPrecoDeVendaProduto.TabIndex = 6;
            this.lblPrecoDeVendaProduto.Text = "Preço de venda:";
            this.lblPrecoDeVendaProduto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPrecoDeCustoProduto
            // 
            this.txtPrecoDeCustoProduto.Location = new System.Drawing.Point(105, 65);
            this.txtPrecoDeCustoProduto.Name = "txtPrecoDeCustoProduto";
            this.txtPrecoDeCustoProduto.Size = new System.Drawing.Size(222, 20);
            this.txtPrecoDeCustoProduto.TabIndex = 5;
            // 
            // txtDescricaoProduto
            // 
            this.txtDescricaoProduto.Location = new System.Drawing.Point(105, 34);
            this.txtDescricaoProduto.Name = "txtDescricaoProduto";
            this.txtDescricaoProduto.Size = new System.Drawing.Size(222, 20);
            this.txtDescricaoProduto.TabIndex = 4;
            // 
            // lblIdProduto
            // 
            this.lblIdProduto.Location = new System.Drawing.Point(3, 0);
            this.lblIdProduto.Name = "lblIdProduto";
            this.lblIdProduto.Size = new System.Drawing.Size(82, 31);
            this.lblIdProduto.TabIndex = 0;
            this.lblIdProduto.Text = "Id:";
            this.lblIdProduto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDescricaoProduto
            // 
            this.lblDescricaoProduto.Location = new System.Drawing.Point(3, 31);
            this.lblDescricaoProduto.Name = "lblDescricaoProduto";
            this.lblDescricaoProduto.Size = new System.Drawing.Size(67, 31);
            this.lblDescricaoProduto.TabIndex = 1;
            this.lblDescricaoProduto.Text = "Descrição:";
            this.lblDescricaoProduto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPrecoDeCustoProduto
            // 
            this.lblPrecoDeCustoProduto.Location = new System.Drawing.Point(3, 62);
            this.lblPrecoDeCustoProduto.Name = "lblPrecoDeCustoProduto";
            this.lblPrecoDeCustoProduto.Size = new System.Drawing.Size(82, 31);
            this.lblPrecoDeCustoProduto.TabIndex = 2;
            this.lblPrecoDeCustoProduto.Text = "Preço de custo:";
            this.lblPrecoDeCustoProduto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtIdProduto
            // 
            this.txtIdProduto.Enabled = false;
            this.txtIdProduto.Location = new System.Drawing.Point(105, 3);
            this.txtIdProduto.Name = "txtIdProduto";
            this.txtIdProduto.Size = new System.Drawing.Size(222, 20);
            this.txtIdProduto.TabIndex = 3;
            // 
            // txtPrecoDeVendaProduto
            // 
            this.txtPrecoDeVendaProduto.Location = new System.Drawing.Point(105, 109);
            this.txtPrecoDeVendaProduto.Name = "txtPrecoDeVendaProduto";
            this.txtPrecoDeVendaProduto.Size = new System.Drawing.Size(222, 20);
            this.txtPrecoDeVendaProduto.TabIndex = 7;
            // 
            // txtEstoqueProduto
            // 
            this.txtEstoqueProduto.Location = new System.Drawing.Point(105, 154);
            this.txtEstoqueProduto.Name = "txtEstoqueProduto";
            this.txtEstoqueProduto.Size = new System.Drawing.Size(222, 20);
            this.txtEstoqueProduto.TabIndex = 9;
            // 
            // btnGravarProdutos
            // 
            this.btnGravarProdutos.Location = new System.Drawing.Point(108, 212);
            this.btnGravarProdutos.Name = "btnGravarProdutos";
            this.btnGravarProdutos.Size = new System.Drawing.Size(106, 23);
            this.btnGravarProdutos.TabIndex = 2;
            this.btnGravarProdutos.Text = "Gravar";
            this.btnGravarProdutos.UseVisualStyleBackColor = true;
            this.btnGravarProdutos.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnRemoverProdutos
            // 
            this.btnRemoverProdutos.Location = new System.Drawing.Point(220, 212);
            this.btnRemoverProdutos.Name = "btnRemoverProdutos";
            this.btnRemoverProdutos.Size = new System.Drawing.Size(110, 23);
            this.btnRemoverProdutos.TabIndex = 4;
            this.btnRemoverProdutos.Text = "Remover";
            this.btnRemoverProdutos.UseVisualStyleBackColor = true;
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AllowUserToAddRows = false;
            this.dgvProdutos.AllowUserToDeleteRows = false;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Location = new System.Drawing.Point(13, 256);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.ReadOnly = true;
            this.dgvProdutos.Size = new System.Drawing.Size(407, 182);
            this.dgvProdutos.TabIndex = 5;
            // 
            // FormProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 450);
            this.Controls.Add(this.dgvProdutos);
            this.Controls.Add(this.btnRemoverProdutos);
            this.Controls.Add(this.btnGravarProdutos);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormProduto";
            this.Text = "Atualização/Cadastro de Produtos";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtPrecoDeCustoProduto;
        private System.Windows.Forms.TextBox txtDescricaoProduto;
        private System.Windows.Forms.Label lblIdProduto;
        private System.Windows.Forms.Label lblDescricaoProduto;
        private System.Windows.Forms.Label lblPrecoDeCustoProduto;
        private System.Windows.Forms.TextBox txtIdProduto;
        private System.Windows.Forms.Label lblPrecoDeVendaProduto;
        private System.Windows.Forms.Label lblEstoqueProduto;
        private System.Windows.Forms.TextBox txtPrecoDeVendaProduto;
        private System.Windows.Forms.TextBox txtEstoqueProduto;
        private System.Windows.Forms.Button btnGravarProdutos;
        private System.Windows.Forms.Button btnRemoverProdutos;
        private System.Windows.Forms.DataGridView dgvProdutos;
    }
}