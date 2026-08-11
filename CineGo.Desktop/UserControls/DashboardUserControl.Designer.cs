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
            colId = new DataGridViewTextBoxColumn();
            colTitle = new DataGridViewTextBoxColumn();
            colCategoryName = new DataGridViewTextBoxColumn();
            colReleaseYear = new DataGridViewTextBoxColumn();
            colCreatedAt = new DataGridViewTextBoxColumn();
            cardFilmes = new Panel();
            cardFilmesLblDesc = new Label();
            cardFilmesLblNumero = new Label();
            cardFilmesLblTitulo = new Label();
            cardCategorias = new Panel();
            cardCategoriasLblDesc = new Label();
            cardCategoriasLblNumero = new Label();
            cardCatedoriasLblTitulo = new Label();
            pnlCorCategorias = new Panel();
            pnlCorFilmes = new Panel();
            ((System.ComponentModel.ISupportInitialize)gridUltimosFilmes).BeginInit();
            cardFilmes.SuspendLayout();
            cardCategorias.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(41, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(74, 25);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Olá! 👋";
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtitulo.Location = new Point(41, 49);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(221, 20);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.Text = "Bem-Vindo ao CineGo Desktop";
            // 
            // lblCarregando
            // 
            lblCarregando.AutoSize = true;
            lblCarregando.Font = new Font("Yu Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCarregando.Location = new Point(41, 84);
            lblCarregando.Name = "lblCarregando";
            lblCarregando.Size = new Size(194, 17);
            lblCarregando.TabIndex = 2;
            lblCarregando.Text = "⌛ Carregando dados da API...";
            // 
            // lblUltimosFilmesCadastrados
            // 
            lblUltimosFilmesCadastrados.AutoSize = true;
            lblUltimosFilmesCadastrados.Font = new Font("Yu Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUltimosFilmesCadastrados.Location = new Point(41, 237);
            lblUltimosFilmesCadastrados.Name = "lblUltimosFilmesCadastrados";
            lblUltimosFilmesCadastrados.Size = new Size(229, 19);
            lblUltimosFilmesCadastrados.TabIndex = 3;
            lblUltimosFilmesCadastrados.Text = "🗃️ Últimos filmes cadastrados";
            // 
            // gridUltimosFilmes
            // 
            gridUltimosFilmes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridUltimosFilmes.Columns.AddRange(new DataGridViewColumn[] { colId, colTitle, colCategoryName, colReleaseYear, colCreatedAt });
            gridUltimosFilmes.Location = new Point(31, 263);
            gridUltimosFilmes.Name = "gridUltimosFilmes";
            gridUltimosFilmes.Size = new Size(646, 164);
            gridUltimosFilmes.TabIndex = 4;
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
            // cardFilmes
            // 
            cardFilmes.BackColor = Color.White;
            cardFilmes.Controls.Add(cardFilmesLblDesc);
            cardFilmes.Controls.Add(cardFilmesLblNumero);
            cardFilmes.Controls.Add(cardFilmesLblTitulo);
            cardFilmes.Location = new Point(41, 113);
            cardFilmes.Name = "cardFilmes";
            cardFilmes.Size = new Size(200, 113);
            cardFilmes.TabIndex = 5;
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
            // cardFilmesLblNumero
            // 
            cardFilmesLblNumero.AutoSize = true;
            cardFilmesLblNumero.Font = new Font("Yu Gothic", 26.25F, FontStyle.Bold);
            cardFilmesLblNumero.Location = new Point(15, 37);
            cardFilmesLblNumero.Name = "cardFilmesLblNumero";
            cardFilmesLblNumero.Size = new Size(40, 45);
            cardFilmesLblNumero.TabIndex = 1;
            cardFilmesLblNumero.Text = "0";
            // 
            // cardFilmesLblTitulo
            // 
            cardFilmesLblTitulo.AutoSize = true;
            cardFilmesLblTitulo.Font = new Font("Yu Gothic", 9.75F, FontStyle.Bold);
            cardFilmesLblTitulo.Location = new Point(15, 18);
            cardFilmesLblTitulo.Name = "cardFilmesLblTitulo";
            cardFilmesLblTitulo.Size = new Size(74, 17);
            cardFilmesLblTitulo.TabIndex = 0;
            cardFilmesLblTitulo.Text = "🎬 Filmes";
            // 
            // cardCategorias
            // 
            cardCategorias.BackColor = Color.White;
            cardCategorias.Controls.Add(cardCategoriasLblDesc);
            cardCategorias.Controls.Add(cardCategoriasLblNumero);
            cardCategorias.Controls.Add(cardCatedoriasLblTitulo);
            cardCategorias.Location = new Point(282, 113);
            cardCategorias.Name = "cardCategorias";
            cardCategorias.Size = new Size(200, 113);
            cardCategorias.TabIndex = 5;
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
            // cardCategoriasLblNumero
            // 
            cardCategoriasLblNumero.AutoSize = true;
            cardCategoriasLblNumero.Font = new Font("Yu Gothic", 26.25F, FontStyle.Bold);
            cardCategoriasLblNumero.Location = new Point(16, 37);
            cardCategoriasLblNumero.Name = "cardCategoriasLblNumero";
            cardCategoriasLblNumero.Size = new Size(40, 45);
            cardCategoriasLblNumero.TabIndex = 1;
            cardCategoriasLblNumero.Text = "0";
            // 
            // cardCatedoriasLblTitulo
            // 
            cardCatedoriasLblTitulo.AutoSize = true;
            cardCatedoriasLblTitulo.Font = new Font("Yu Gothic", 9.75F, FontStyle.Bold);
            cardCatedoriasLblTitulo.Location = new Point(16, 18);
            cardCatedoriasLblTitulo.Name = "cardCatedoriasLblTitulo";
            cardCatedoriasLblTitulo.Size = new Size(101, 17);
            cardCatedoriasLblTitulo.TabIndex = 0;
            cardCatedoriasLblTitulo.Text = "🏷️ Categorias";
            // 
            // pnlCorCategorias
            // 
            pnlCorCategorias.Location = new Point(282, 113);
            pnlCorCategorias.Name = "pnlCorCategorias";
            pnlCorCategorias.Size = new Size(200, 13);
            pnlCorCategorias.TabIndex = 5;
            // 
            // pnlCorFilmes
            // 
            pnlCorFilmes.Location = new Point(41, 113);
            pnlCorFilmes.Name = "pnlCorFilmes";
            pnlCorFilmes.Size = new Size(200, 13);
            pnlCorFilmes.TabIndex = 5;
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
        private DataGridViewTextBoxColumn colTitle;
        private DataGridViewTextBoxColumn colCategoryName;
        private DataGridViewTextBoxColumn colReleaseYear;
        private DataGridViewTextBoxColumn colCreatedAt;
    }
}
