
namespace VENDAS_DE_CARRO
{
    partial class FormVendas
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
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.directorySearcher2 = new System.DirectoryServices.DirectorySearcher();
            this.directorySearcher3 = new System.DirectoryServices.DirectorySearcher();
            this.directorySearcher4 = new System.DirectoryServices.DirectorySearcher();
            this.directorySearcher5 = new System.DirectoryServices.DirectorySearcher();
            this.tbID = new System.Windows.Forms.TextBox();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.tbDescricao = new System.Windows.Forms.TextBox();
            this.tbQuantidade = new System.Windows.Forms.TextBox();
            this.tbAtivo = new System.Windows.Forms.TextBox();
            this.lbID = new System.Windows.Forms.Label();
            this.lbNome = new System.Windows.Forms.Label();
            this.lbDescrição = new System.Windows.Forms.Label();
            this.lbQuantidade = new System.Windows.Forms.Label();
            this.lbAtivo = new System.Windows.Forms.Label();
            this.dgConfirme = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAtivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgConfirme)).BeginInit();
            this.SuspendLayout();
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // directorySearcher2
            // 
            this.directorySearcher2.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher2.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher2.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // directorySearcher3
            // 
            this.directorySearcher3.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher3.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher3.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // directorySearcher4
            // 
            this.directorySearcher4.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher4.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher4.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // directorySearcher5
            // 
            this.directorySearcher5.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher5.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher5.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // tbID
            // 
            this.tbID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbID.Location = new System.Drawing.Point(71, 48);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(64, 27);
            this.tbID.TabIndex = 0;
            // 
            // tbNome
            // 
            this.tbNome.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNome.Location = new System.Drawing.Point(266, 51);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(64, 27);
            this.tbNome.TabIndex = 1;
            // 
            // tbDescricao
            // 
            this.tbDescricao.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDescricao.Location = new System.Drawing.Point(121, 135);
            this.tbDescricao.Name = "tbDescricao";
            this.tbDescricao.Size = new System.Drawing.Size(432, 27);
            this.tbDescricao.TabIndex = 2;
            // 
            // tbQuantidade
            // 
            this.tbQuantidade.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbQuantidade.Location = new System.Drawing.Point(489, 54);
            this.tbQuantidade.Name = "tbQuantidade";
            this.tbQuantidade.Size = new System.Drawing.Size(64, 27);
            this.tbQuantidade.TabIndex = 3;
            // 
            // tbAtivo
            // 
            this.tbAtivo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAtivo.Location = new System.Drawing.Point(733, 54);
            this.tbAtivo.Name = "tbAtivo";
            this.tbAtivo.Size = new System.Drawing.Size(64, 27);
            this.tbAtivo.TabIndex = 4;
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lbID.Location = new System.Drawing.Point(28, 51);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(27, 21);
            this.lbID.TabIndex = 5;
            this.lbID.Text = "ID";
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lbNome.Location = new System.Drawing.Point(191, 54);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(57, 21);
            this.lbNome.TabIndex = 6;
            this.lbNome.Text = "Nome";
            // 
            // lbDescrição
            // 
            this.lbDescrição.AutoSize = true;
            this.lbDescrição.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lbDescrição.Location = new System.Drawing.Point(28, 138);
            this.lbDescrição.Name = "lbDescrição";
            this.lbDescrição.Size = new System.Drawing.Size(87, 21);
            this.lbDescrição.TabIndex = 7;
            this.lbDescrição.Text = "Descrição";
            // 
            // lbQuantidade
            // 
            this.lbQuantidade.AutoSize = true;
            this.lbQuantidade.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lbQuantidade.Location = new System.Drawing.Point(375, 57);
            this.lbQuantidade.Name = "lbQuantidade";
            this.lbQuantidade.Size = new System.Drawing.Size(108, 21);
            this.lbQuantidade.TabIndex = 8;
            this.lbQuantidade.Text = "Quantidade";
            // 
            // lbAtivo
            // 
            this.lbAtivo.AutoSize = true;
            this.lbAtivo.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lbAtivo.Location = new System.Drawing.Point(674, 57);
            this.lbAtivo.Name = "lbAtivo";
            this.lbAtivo.Size = new System.Drawing.Size(53, 21);
            this.lbAtivo.TabIndex = 9;
            this.lbAtivo.Text = "Ativo";
            // 
            // dgConfirme
            // 
            this.dgConfirme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgConfirme.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colNome,
            this.colDescricao,
            this.colQuantidade,
            this.colAtivo});
            this.dgConfirme.Location = new System.Drawing.Point(32, 314);
            this.dgConfirme.Name = "dgConfirme";
            this.dgConfirme.Size = new System.Drawing.Size(841, 150);
            this.dgConfirme.TabIndex = 10;
            this.dgConfirme.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgConfirme_CellContentClick);
            // 
            // colID
            // 
            this.colID.HeaderText = "ID";
            this.colID.Name = "colID";
            this.colID.Width = 50;
            // 
            // colNome
            // 
            this.colNome.HeaderText = "Nome";
            this.colNome.Name = "colNome";
            this.colNome.Width = 125;
            // 
            // colDescricao
            // 
            this.colDescricao.HeaderText = "Descricao";
            this.colDescricao.Name = "colDescricao";
            this.colDescricao.Width = 500;
            // 
            // colQuantidade
            // 
            this.colQuantidade.HeaderText = "Quantidade";
            this.colQuantidade.Name = "colQuantidade";
            this.colQuantidade.Width = 60;
            // 
            // colAtivo
            // 
            this.colAtivo.HeaderText = "Ativo";
            this.colAtivo.Name = "colAtivo";
            this.colAtivo.Width = 60;
            // 
            // FormVendas
            // 
            this.ClientSize = new System.Drawing.Size(938, 495);
            this.Controls.Add(this.dgConfirme);
            this.Controls.Add(this.lbAtivo);
            this.Controls.Add(this.lbQuantidade);
            this.Controls.Add(this.lbDescrição);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.tbAtivo);
            this.Controls.Add(this.tbQuantidade);
            this.Controls.Add(this.tbDescricao);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.tbID);
            this.Name = "FormVendas";
            this.Text = "Vendas de Carro";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgConfirme)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.DirectoryServices.DirectorySearcher directorySearcher2;
        private System.DirectoryServices.DirectorySearcher directorySearcher3;
        private System.DirectoryServices.DirectorySearcher directorySearcher4;
        private System.DirectoryServices.DirectorySearcher directorySearcher5;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.TextBox tbDescricao;
        private System.Windows.Forms.TextBox tbQuantidade;
        private System.Windows.Forms.TextBox tbAtivo;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lbDescrição;
        private System.Windows.Forms.Label lbQuantidade;
        private System.Windows.Forms.Label lbAtivo;
        private System.Windows.Forms.DataGridView dgConfirme;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAtivo;
    }
}

