namespace CineGo.Desktop.UserControls
{
    partial class FilmesUserControl
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges19 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges20 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges21 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges22 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges23 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges24 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            lblTitulo = new Label();
            pnlToolBar = new Panel();
            gridFilmes = new DataGridView();
            txtPesquisa = new Guna.UI2.WinForms.Guna2TextBox();
            btnPesquisar = new Guna.UI2.WinForms.Guna2Button();
            brnNovo = new Guna.UI2.WinForms.Guna2Button();
            btnEditar = new Guna.UI2.WinForms.Guna2Button();
            btnExcluir = new Guna.UI2.WinForms.Guna2Button();
            btnAtualizar = new Guna.UI2.WinForms.Guna2Button();
            colId = new DataGridViewTextBoxColumn();
            colTitle = new DataGridViewTextBoxColumn();
            colCategoryName = new DataGridViewTextBoxColumn();
            colReleaseYear = new DataGridViewTextBoxColumn();
            colCreatedAt = new DataGridViewTextBoxColumn();
            colClass = new DataGridViewTextBoxColumn();
            pnlToolBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridFilmes).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(24, 18);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(156, 15);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "🎬 Gerenciamento de Filmes";
            // 
            // pnlToolBar
            // 
            pnlToolBar.Controls.Add(btnAtualizar);
            pnlToolBar.Controls.Add(btnExcluir);
            pnlToolBar.Controls.Add(btnEditar);
            pnlToolBar.Controls.Add(brnNovo);
            pnlToolBar.Controls.Add(btnPesquisar);
            pnlToolBar.Controls.Add(txtPesquisa);
            pnlToolBar.Location = new Point(14, 47);
            pnlToolBar.Name = "pnlToolBar";
            pnlToolBar.Size = new Size(684, 71);
            pnlToolBar.TabIndex = 1;
            // 
            // gridFilmes
            // 
            gridFilmes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridFilmes.Columns.AddRange(new DataGridViewColumn[] { colId, colTitle, colCategoryName, colReleaseYear, colCreatedAt, colClass });
            gridFilmes.Location = new Point(14, 127);
            gridFilmes.Name = "gridFilmes";
            gridFilmes.Size = new Size(684, 293);
            gridFilmes.TabIndex = 2;
            // 
            // txtPesquisa
            // 
            txtPesquisa.CustomizableEdges = customizableEdges13;
            txtPesquisa.DefaultText = "";
            txtPesquisa.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtPesquisa.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtPesquisa.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtPesquisa.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtPesquisa.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPesquisa.Font = new Font("Segoe UI", 9F);
            txtPesquisa.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPesquisa.Location = new Point(8, 18);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.PlaceholderText = "🔎 Pesquisar por título...";
            txtPesquisa.SelectedText = "";
            txtPesquisa.ShadowDecoration.CustomizableEdges = customizableEdges14;
            txtPesquisa.Size = new Size(172, 36);
            txtPesquisa.TabIndex = 0;
            // 
            // btnPesquisar
            // 
            btnPesquisar.CustomizableEdges = customizableEdges15;
            btnPesquisar.DisabledState.BorderColor = Color.DarkGray;
            btnPesquisar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnPesquisar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnPesquisar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnPesquisar.Font = new Font("Segoe UI", 9F);
            btnPesquisar.ForeColor = Color.White;
            btnPesquisar.Location = new Point(184, 18);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.ShadowDecoration.CustomizableEdges = customizableEdges16;
            btnPesquisar.Size = new Size(89, 36);
            btnPesquisar.TabIndex = 1;
            btnPesquisar.Text = "Pesquisar";
            // 
            // brnNovo
            // 
            brnNovo.CustomizableEdges = customizableEdges17;
            brnNovo.DisabledState.BorderColor = Color.DarkGray;
            brnNovo.DisabledState.CustomBorderColor = Color.DarkGray;
            brnNovo.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            brnNovo.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            brnNovo.Font = new Font("Segoe UI", 9F);
            brnNovo.ForeColor = Color.White;
            brnNovo.Location = new Point(286, 18);
            brnNovo.Name = "brnNovo";
            brnNovo.ShadowDecoration.CustomizableEdges = customizableEdges18;
            brnNovo.Size = new Size(105, 36);
            brnNovo.TabIndex = 1;
            brnNovo.Text = "+ Novo Filme";
            // 
            // btnEditar
            // 
            btnEditar.CustomizableEdges = customizableEdges19;
            btnEditar.DisabledState.BorderColor = Color.DarkGray;
            btnEditar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnEditar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnEditar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnEditar.Font = new Font("Segoe UI", 9F);
            btnEditar.ForeColor = Color.White;
            btnEditar.Location = new Point(397, 18);
            btnEditar.Name = "btnEditar";
            btnEditar.ShadowDecoration.CustomizableEdges = customizableEdges20;
            btnEditar.Size = new Size(89, 36);
            btnEditar.TabIndex = 1;
            btnEditar.Text = "✏️ Editar";
            // 
            // btnExcluir
            // 
            btnExcluir.CustomizableEdges = customizableEdges21;
            btnExcluir.DisabledState.BorderColor = Color.DarkGray;
            btnExcluir.DisabledState.CustomBorderColor = Color.DarkGray;
            btnExcluir.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnExcluir.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnExcluir.Font = new Font("Segoe UI", 9F);
            btnExcluir.ForeColor = Color.White;
            btnExcluir.Location = new Point(492, 18);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.ShadowDecoration.CustomizableEdges = customizableEdges22;
            btnExcluir.Size = new Size(89, 36);
            btnExcluir.TabIndex = 1;
            btnExcluir.Text = "🗑️ Excluir";
            // 
            // btnAtualizar
            // 
            btnAtualizar.CustomizableEdges = customizableEdges23;
            btnAtualizar.DisabledState.BorderColor = Color.DarkGray;
            btnAtualizar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAtualizar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAtualizar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAtualizar.Font = new Font("Segoe UI", 9F);
            btnAtualizar.ForeColor = Color.White;
            btnAtualizar.Location = new Point(587, 18);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.ShadowDecoration.CustomizableEdges = customizableEdges24;
            btnAtualizar.Size = new Size(89, 36);
            btnAtualizar.TabIndex = 1;
            btnAtualizar.Text = "🔃 Atualizar";
            // 
            // colId
            // 
            colId.HeaderText = "ID";
            colId.Name = "colId";
            // 
            // colTitle
            // 
            colTitle.HeaderText = "Título";
            colTitle.Name = "colTitle";
            // 
            // colCategoryName
            // 
            colCategoryName.HeaderText = "Categoria";
            colCategoryName.Name = "colCategoryName";
            // 
            // colReleaseYear
            // 
            colReleaseYear.HeaderText = "Ano";
            colReleaseYear.Name = "colReleaseYear";
            // 
            // colCreatedAt
            // 
            colCreatedAt.HeaderText = "Cadastrado em";
            colCreatedAt.Name = "colCreatedAt";
            // 
            // colClass
            // 
            colClass.HeaderText = "Classificação";
            colClass.Name = "colClass";
            // 
            // FilmesUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(gridFilmes);
            Controls.Add(pnlToolBar);
            Controls.Add(lblTitulo);
            Name = "FilmesUserControl";
            Size = new Size(711, 438);
            pnlToolBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridFilmes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Panel pnlToolBar;
        private DataGridView gridFilmes;
        private Guna.UI2.WinForms.Guna2Button btnAtualizar;
        private Guna.UI2.WinForms.Guna2Button btnExcluir;
        private Guna.UI2.WinForms.Guna2Button btnEditar;
        private Guna.UI2.WinForms.Guna2Button brnNovo;
        private Guna.UI2.WinForms.Guna2Button btnPesquisar;
        private Guna.UI2.WinForms.Guna2TextBox txtPesquisa;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colTitle;
        private DataGridViewTextBoxColumn colCategoryName;
        private DataGridViewTextBoxColumn colReleaseYear;
        private DataGridViewTextBoxColumn colCreatedAt;
        private DataGridViewTextBoxColumn colClass;
    }
}
