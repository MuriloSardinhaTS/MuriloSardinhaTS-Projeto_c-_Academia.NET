namespace T_systems.ProjetoCurso.WindowsForms.UI
{
    partial class FFormularioinicial
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LBLFornecedor = new Label();
            txtFornecedor = new TextBox();
            LBLEndereco = new Label();
            txtNomeDoContato = new TextBox();
            LBLTelefone = new Label();
            txtEndereco = new TextBox();
            label1 = new Label();
            TXTTelefone = new TextBox();
            BtnSalvar = new Button();
            DGVFornecedores = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)DGVFornecedores).BeginInit();
            SuspendLayout();
            // 
            // LBLFornecedor
            // 
            LBLFornecedor.AutoSize = true;
            LBLFornecedor.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            LBLFornecedor.Location = new Point(12, -3);
            LBLFornecedor.Name = "LBLFornecedor";
            LBLFornecedor.Size = new Size(103, 25);
            LBLFornecedor.TabIndex = 0;
            LBLFornecedor.Text = "Fornecedor";
            LBLFornecedor.Click += label1_Click;
            // 
            // txtFornecedor
            // 
            txtFornecedor.Location = new Point(12, 25);
            txtFornecedor.Name = "txtFornecedor";
            txtFornecedor.Size = new Size(316, 31);
            txtFornecedor.TabIndex = 1;
            // 
            // LBLEndereco
            // 
            LBLEndereco.AutoSize = true;
            LBLEndereco.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            LBLEndereco.Location = new Point(12, 59);
            LBLEndereco.Name = "LBLEndereco";
            LBLEndereco.Size = new Size(87, 25);
            LBLEndereco.TabIndex = 0;
            LBLEndereco.Text = "Endereco";
            LBLEndereco.Click += label1_Click;
            // 
            // txtNomeDoContato
            // 
            txtNomeDoContato.Location = new Point(12, 149);
            txtNomeDoContato.Name = "txtNomeDoContato";
            txtNomeDoContato.Size = new Size(253, 31);
            txtNomeDoContato.TabIndex = 1;
            // 
            // LBLTelefone
            // 
            LBLTelefone.AutoSize = true;
            LBLTelefone.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            LBLTelefone.Location = new Point(12, 183);
            LBLTelefone.Name = "LBLTelefone";
            LBLTelefone.Size = new Size(84, 25);
            LBLTelefone.TabIndex = 0;
            LBLTelefone.Text = "Telefone";
            LBLTelefone.Click += label1_Click;
            // 
            // txtEndereco
            // 
            txtEndereco.Location = new Point(12, 87);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(491, 31);
            txtEndereco.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 121);
            label1.Name = "label1";
            label1.Size = new Size(159, 25);
            label1.TabIndex = 0;
            label1.Text = "Nome do Contato";
            label1.Click += label1_Click;
            // 
            // TXTTelefone
            // 
            TXTTelefone.Location = new Point(12, 211);
            TXTTelefone.Name = "TXTTelefone";
            TXTTelefone.Size = new Size(208, 31);
            TXTTelefone.TabIndex = 1;
            // 
            // BtnSalvar
            // 
            BtnSalvar.Location = new Point(12, 277);
            BtnSalvar.Name = "BtnSalvar";
            BtnSalvar.Size = new Size(177, 61);
            BtnSalvar.TabIndex = 2;
            BtnSalvar.Text = "Salvar";
            BtnSalvar.UseVisualStyleBackColor = true;
            BtnSalvar.Click += btnSalvar_Click;
            // 
            // DGVFornecedores
            // 
            DGVFornecedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVFornecedores.Location = new Point(12, 370);
            DGVFornecedores.Name = "DGVFornecedores";
            DGVFornecedores.RowHeadersWidth = 62;
            DGVFornecedores.Size = new Size(1174, 195);
            DGVFornecedores.TabIndex = 3;
            // 
            // FFormularioinicial
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1223, 600);
            Controls.Add(DGVFornecedores);
            Controls.Add(BtnSalvar);
            Controls.Add(txtEndereco);
            Controls.Add(TXTTelefone);
            Controls.Add(txtNomeDoContato);
            Controls.Add(txtFornecedor);
            Controls.Add(label1);
            Controls.Add(LBLTelefone);
            Controls.Add(LBLEndereco);
            Controls.Add(LBLFornecedor);
            Name = "FFormularioinicial";
            Text = "Tela de Cadastro de Fornecedor";
            Load += FFormularioinicial_Load;
            ((System.ComponentModel.ISupportInitialize)DGVFornecedores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LBLFornecedor;
        private TextBox txtFornecedor;
        private Label LBLEndereco;
        private TextBox txtNomeDoContato;
        private Label LBLTelefone;
        private TextBox txtEndereco;
        private Label label1;
        private TextBox TXTTelefone;
        private Button BtnSalvar;
        private DataGridView DGVFornecedores;
    }
}
