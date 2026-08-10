namespace CineGo.Desktop.UserControls
{
    partial class DashboardUserControl
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
            lblTitulo = new Label();
            lblSubtitulo = new Label();
            lblCarregando = new Label();
            lblUltimosFilmesCadastrados = new Label();
            gridUltimosFilmes = new DataGridView();
            cardFilmes = new Panel();
            cardCategorias = new Panel();
            pnlCorCategorias = new Panel();
            pnlCorFilmes = new Panel();
            cardFilmesLblTitulo = new Label();
            cardFilmesLblNumero = new Label();
            cardFilmesLblDesc = new Label();
            cardCatedoriasLblTitulo = new Label();
            cardCategoriasLblNumero = new Label();
            cardCategoriasLblDesc = new Label();
            colId = new DataGridViewTextBoxColumn();
            ColClass = new DataGridViewTextBoxColumn();
            colTitle = new DataGridViewTextBoxColumn();
            colCategoryName = new DataGridViewTextBoxColumn();
            colReleaseYear = new DataGridViewTextBoxColumn();
            colCreatedAt = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)gridUltimosFilmes).BeginInit();
            cardFilmes.SuspendLayout();
            cardCategorias.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(41, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(89, 15);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Olá, Usuario! 👋";
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Location = new Point(41, 51);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(171, 15);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.Text = "Bem-Vindo ao CineGo Desktop";
            // 
            // lblCarregando
            // 
            lblCarregando.AutoSize = true;
            lblCarregando.Location = new Point(41, 81);
            lblCarregando.Name = "lblCarregando";
            lblCarregando.Size = new Size(150, 15);
            lblCarregando.TabIndex = 2;
            lblCarregando.Text = "Carregando dados da API...";
            // 
            // lblUltimosFilmesCadastrados
            // 
            lblUltimosFilmesCadastrados.AutoSize = true;
            lblUltimosFilmesCadastrados.Location = new Point(41, 247);
            lblUltimosFilmesCadastrados.Name = "lblUltimosFilmesCadastrados";
            lblUltimosFilmesCadastrados.Size = new Size(164, 15);
            lblUltimosFilmesCadastrados.TabIndex = 3;
            lblUltimosFilmesCadastrados.Text = "🗃️ Últimos filmes cadastrados";
            // 
            // gridUltimosFilmes
            // 
            gridUltimosFilmes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridUltimosFilmes.Columns.AddRange(new DataGridViewColumn[] { colId, ColClass, colTitle, colCategoryName, colReleaseYear, colCreatedAt });
            gridUltimosFilmes.Location = new Point(31, 270);
            gridUltimosFilmes.Name = "gridUltimosFilmes";
            gridUltimosFilmes.Size = new Size(646, 150);
            gridUltimosFilmes.TabIndex = 4;
            // 
            // cardFilmes
            // 
            cardFilmes.Controls.Add(cardFilmesLblDesc);
            cardFilmes.Controls.Add(cardFilmesLblNumero);
            cardFilmes.Controls.Add(cardFilmesLblTitulo);
            cardFilmes.Location = new Point(41, 125);
            cardFilmes.Name = "cardFilmes";
            cardFilmes.Size = new Size(200, 113);
            cardFilmes.TabIndex = 5;
            // 
            // cardCategorias
            // 
            cardCategorias.Controls.Add(cardCategoriasLblDesc);
            cardCategorias.Controls.Add(cardCategoriasLblNumero);
            cardCategorias.Controls.Add(cardCatedoriasLblTitulo);
            cardCategorias.Location = new Point(282, 125);
            cardCategorias.Name = "cardCategorias";
            cardCategorias.Size = new Size(200, 113);
            cardCategorias.TabIndex = 5;
            // 
            // pnlCorCategorias
            // 
            pnlCorCategorias.Location = new Point(282, 125);
            pnlCorCategorias.Name = "pnlCorCategorias";
            pnlCorCategorias.Size = new Size(200, 13);
            pnlCorCategorias.TabIndex = 5;
            // 
            // pnlCorFilmes
            // 
            pnlCorFilmes.Location = new Point(41, 125);
            pnlCorFilmes.Name = "pnlCorFilmes";
            pnlCorFilmes.Size = new Size(200, 13);
            pnlCorFilmes.TabIndex = 5;
            // 
            // cardFilmesLblTitulo
            // 
            cardFilmesLblTitulo.AutoSize = true;
            cardFilmesLblTitulo.Location = new Point(15, 23);
            cardFilmesLblTitulo.Name = "cardFilmesLblTitulo";
            cardFilmesLblTitulo.Size = new Size(56, 15);
            cardFilmesLblTitulo.TabIndex = 0;
            cardFilmesLblTitulo.Text = "🎬 Filmes";
            // 
            // cardFilmesLblNumero
            // 
            cardFilmesLblNumero.AutoSize = true;
            cardFilmesLblNumero.Location = new Point(15, 54);
            cardFilmesLblNumero.Name = "cardFilmesLblNumero";
            cardFilmesLblNumero.Size = new Size(13, 15);
            cardFilmesLblNumero.TabIndex = 1;
            cardFilmesLblNumero.Text = "0";
            // 
            // cardFilmesLblDesc
            // 
            cardFilmesLblDesc.AutoSize = true;
            cardFilmesLblDesc.Location = new Point(15, 85);
            cardFilmesLblDesc.Name = "cardFilmesLblDesc";
            cardFilmesLblDesc.Size = new Size(150, 15);
            cardFilmesLblDesc.TabIndex = 2;
            cardFilmesLblDesc.Text = "Total de filmes cadastrados";
            // 
            // cardCatedoriasLblTitulo
            // 
            cardCatedoriasLblTitulo.AutoSize = true;
            cardCatedoriasLblTitulo.Location = new Point(16, 23);
            cardCatedoriasLblTitulo.Name = "cardCatedoriasLblTitulo";
            cardCatedoriasLblTitulo.Size = new Size(78, 15);
            cardCatedoriasLblTitulo.TabIndex = 0;
            cardCatedoriasLblTitulo.Text = "🏷️ Categorias";
            // 
            // cardCategoriasLblNumero
            // 
            cardCategoriasLblNumero.AutoSize = true;
            cardCategoriasLblNumero.Location = new Point(16, 54);
            cardCategoriasLblNumero.Name = "cardCategoriasLblNumero";
            cardCategoriasLblNumero.Size = new Size(13, 15);
            cardCategoriasLblNumero.TabIndex = 1;
            cardCategoriasLblNumero.Text = "0";
            // 
            // cardCategoriasLblDesc
            // 
            cardCategoriasLblDesc.AutoSize = true;
            cardCategoriasLblDesc.Location = new Point(16, 85);
            cardCategoriasLblDesc.Name = "cardCategoriasLblDesc";
            cardCategoriasLblDesc.Size = new Size(171, 15);
            cardCategoriasLblDesc.TabIndex = 2;
            cardCategoriasLblDesc.Text = "Total de categorias cadastradas";
            // 
            // colId
            // 
            colId.HeaderText = "ID";
            colId.Name = "colId";
            // 
            // ColClass
            // 
            ColClass.HeaderText = "Classificação";
            ColClass.Name = "ColClass";
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
            // DashboardUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlCorFilmes);
            Controls.Add(pnlCorCategorias);
            Controls.Add(cardCategorias);
            Controls.Add(cardFilmes);
            Controls.Add(gridUltimosFilmes);
            Controls.Add(lblUltimosFilmesCadastrados);
            Controls.Add(lblCarregando);
            Controls.Add(lblSubtitulo);
            Controls.Add(lblTitulo);
            Name = "DashboardUserControl";
            Size = new Size(711, 438);
            ((System.ComponentModel.ISupportInitialize)gridUltimosFilmes).EndInit();
            cardFilmes.ResumeLayout(false);
            cardFilmes.PerformLayout();
            cardCategorias.ResumeLayout(false);
            cardCategorias.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblSubtitulo;
        private Label lblCarregando;
        private Label lblUltimosFilmesCadastrados;
        private DataGridView gridUltimosFilmes;
        private Panel cardFilmes;
        private Label cardFilmesLblDesc;
        private Label cardFilmesLblNumero;
        private Label cardFilmesLblTitulo;
        private Panel cardCategorias;
        private Label cardCategoriasLblDesc;
        private Label cardCategoriasLblNumero;
        private Label cardCatedoriasLblTitulo;
        private Panel pnlCorCategorias;
        private Panel pnlCorFilmes;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn ColClass;
        private DataGridViewTextBoxColumn colTitle;
        private DataGridViewTextBoxColumn colCategoryName;
        private DataGridViewTextBoxColumn colReleaseYear;
        private DataGridViewTextBoxColumn colCreatedAt;
    }
}
