
namespace ViewProject
{
    partial class FormFornecedor
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
            this.txtCnpj = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCnpj = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.dgvFornecedor = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFornecedor)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.11905F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 89.88095F));
            this.tableLayoutPanel1.Controls.Add(this.txtCnpj, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtNome, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblId, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblNome, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblCnpj, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtId, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(504, 97);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // txtCnpj
            // 
            this.txtCnpj.Location = new System.Drawing.Point(54, 69);
            this.txtCnpj.Name = "txtCnpj";
            this.txtCnpj.Size = new System.Drawing.Size(222, 20);
            this.txtCnpj.TabIndex = 5;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(54, 36);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(222, 20);
            this.txtNome.TabIndex = 4;
            // 
            // lblId
            // 
            this.lblId.Location = new System.Drawing.Point(3, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(44, 31);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Id:";
            this.lblId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNome
            // 
            this.lblNome.Location = new System.Drawing.Point(3, 33);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(44, 33);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome:";
            this.lblNome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCnpj
            // 
            this.lblCnpj.Location = new System.Drawing.Point(3, 66);
            this.lblCnpj.Name = "lblCnpj";
            this.lblCnpj.Size = new System.Drawing.Size(44, 31);
            this.lblCnpj.TabIndex = 2;
            this.lblCnpj.Text = "CNPJ:";
            this.lblCnpj.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(54, 3);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(222, 20);
            this.txtId.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.67265F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.32735F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 129F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 116F));
            this.tableLayoutPanel2.Controls.Add(this.btnRemover, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnCancelar, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnGravar, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnNovo, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 101);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(504, 38);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(390, 3);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(110, 23);
            this.btnRemover.TabIndex = 3;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(261, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(106, 23);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(134, 3);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(106, 23);
            this.btnGravar.TabIndex = 1;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(3, 3);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(107, 23);
            this.btnNovo.TabIndex = 0;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // dgvFornecedor
            // 
            this.dgvFornecedor.AllowUserToAddRows = false;
            this.dgvFornecedor.AllowUserToDeleteRows = false;
            this.dgvFornecedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFornecedor.Location = new System.Drawing.Point(0, 146);
            this.dgvFornecedor.Name = "dgvFornecedor";
            this.dgvFornecedor.ReadOnly = true;
            this.dgvFornecedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFornecedor.Size = new System.Drawing.Size(504, 250);
            this.dgvFornecedor.TabIndex = 2;
            // 
            // FormFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 402);
            this.Controls.Add(this.dgvFornecedor);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormFornecedor";
            this.Text = "Manutenção em dados de Fornecedores";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFornecedor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtCnpj;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCnpj;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.DataGridView dgvFornecedor;
    }
}