namespace CineGo.Desktop.UserControls
{
    partial class CategoriasUserControl
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            lblTitulo = new Label();
            pnlToolBar = new Panel();
            btnAtualizar = new Guna.UI2.WinForms.Guna2Button();
            btnExcluir = new Guna.UI2.WinForms.Guna2Button();
            btnEditar = new Guna.UI2.WinForms.Guna2Button();
            btnNova = new Guna.UI2.WinForms.Guna2Button();
            pnlForm = new Panel();
            btnCancelar = new Guna.UI2.WinForms.Guna2Button();
            btnSalvar = new Guna.UI2.WinForms.Guna2Button();
            txtNome = new Guna.UI2.WinForms.Guna2TextBox();
            lblNome = new Label();
            lblFormTitulo = new Label();
            gridCategorias = new DataGridView();
            colID = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            colFilmesCount = new DataGridViewTextBoxColumn();
            pnlToolBar.SuspendLayout();
            pnlForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridCategorias).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Yu Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(22, 21);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(247, 19);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "🏷️ Gerenciamento de Categorias";
            // 
            // pnlToolBar
            // 
            pnlToolBar.Controls.Add(btnAtualizar);
            pnlToolBar.Controls.Add(btnExcluir);
            pnlToolBar.Controls.Add(btnEditar);
            pnlToolBar.Controls.Add(btnNova);
            pnlToolBar.Location = new Point(22, 51);
            pnlToolBar.Name = "pnlToolBar";
            pnlToolBar.Size = new Size(468, 90);
            pnlToolBar.TabIndex = 1;
            // 
            // btnAtualizar
            // 
            btnAtualizar.BorderRadius = 10;
            btnAtualizar.CustomizableEdges = customizableEdges1;
            btnAtualizar.DisabledState.BorderColor = Color.DarkGray;
            btnAtualizar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAtualizar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAtualizar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAtualizar.FillColor = Color.Goldenrod;
            btnAtualizar.Font = new Font("Segoe UI", 9F);
            btnAtualizar.ForeColor = Color.White;
            btnAtualizar.Location = new Point(349, 27);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnAtualizar.Size = new Size(106, 45);
            btnAtualizar.TabIndex = 0;
            btnAtualizar.Text = "🔃 Atualizar";
            // 
            // btnExcluir
            // 
            btnExcluir.BorderRadius = 10;
            btnExcluir.CustomizableEdges = customizableEdges3;
            btnExcluir.DisabledState.BorderColor = Color.DarkGray;
            btnExcluir.DisabledState.CustomBorderColor = Color.DarkGray;
            btnExcluir.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnExcluir.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnExcluir.FillColor = Color.DarkRed;
            btnExcluir.Font = new Font("Segoe UI", 9F);
            btnExcluir.ForeColor = Color.White;
            btnExcluir.Location = new Point(237, 27);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnExcluir.Size = new Size(106, 45);
            btnExcluir.TabIndex = 0;
            btnExcluir.Text = "🗑️ Excluir";
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnEditar
            // 
            btnEditar.BorderRadius = 10;
            btnEditar.CustomizableEdges = customizableEdges5;
            btnEditar.DisabledState.BorderColor = Color.DarkGray;
            btnEditar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnEditar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnEditar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnEditar.FillColor = Color.RoyalBlue;
            btnEditar.Font = new Font("Segoe UI", 9F);
            btnEditar.ForeColor = Color.White;
            btnEditar.Location = new Point(125, 27);
            btnEditar.Name = "btnEditar";
            btnEditar.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnEditar.Size = new Size(106, 45);
            btnEditar.TabIndex = 0;
            btnEditar.Text = "✏️ Editar";
            btnEditar.Click += btnEditar_Click;
            // 
            // btnNova
            // 
            btnNova.BorderRadius = 10;
            btnNova.CustomizableEdges = customizableEdges7;
            btnNova.DisabledState.BorderColor = Color.DarkGray;
            btnNova.DisabledState.CustomBorderColor = Color.DarkGray;
            btnNova.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnNova.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnNova.FillColor = Color.ForestGreen;
            btnNova.Font = new Font("Segoe UI", 9F);
            btnNova.ForeColor = Color.White;
            btnNova.Location = new Point(13, 27);
            btnNova.Name = "btnNova";
            btnNova.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnNova.Size = new Size(106, 45);
            btnNova.TabIndex = 0;
            btnNova.Text = "+ Nova Categoria";
            btnNova.Click += btnNova_Click;
            // 
            // pnlForm
            // 
            pnlForm.BackColor = Color.White;
            pnlForm.Controls.Add(btnCancelar);
            pnlForm.Controls.Add(btnSalvar);
            pnlForm.Controls.Add(txtNome);
            pnlForm.Controls.Add(lblNome);
            pnlForm.Controls.Add(lblFormTitulo);
            pnlForm.Location = new Point(496, 144);
            pnlForm.Name = "pnlForm";
            pnlForm.Size = new Size(206, 280);
            pnlForm.TabIndex = 1;
            // 
            // btnCancelar
            // 
            btnCancelar.BorderRadius = 5;
            btnCancelar.CustomizableEdges = customizableEdges9;
            btnCancelar.DisabledState.BorderColor = Color.DarkGray;
            btnCancelar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCancelar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCancelar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCancelar.FillColor = Color.Silver;
            btnCancelar.Font = new Font("Segoe UI", 9F);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(103, 144);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.ShadowDecoration.CustomizableEdges = customizableEdges10;
            btnCancelar.Size = new Size(90, 34);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "❌Cancelar";
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.Transparent;
            btnSalvar.BorderRadius = 5;
            btnSalvar.CustomizableEdges = customizableEdges11;
            btnSalvar.DisabledState.BorderColor = Color.DarkGray;
            btnSalvar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSalvar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSalvar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSalvar.FillColor = Color.ForestGreen;
            btnSalvar.Font = new Font("Segoe UI", 9F);
            btnSalvar.ForeColor = Color.White;
            btnSalvar.Location = new Point(11, 144);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.ShadowDecoration.CustomizableEdges = customizableEdges12;
            btnSalvar.Size = new Size(90, 34);
            btnSalvar.TabIndex = 2;
            btnSalvar.Text = "🗃️ Salvar";
            // 
            // txtNome
            // 
            txtNome.BorderRadius = 5;
            txtNome.CustomizableEdges = customizableEdges13;
            txtNome.DefaultText = "";
            txtNome.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtNome.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtNome.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtNome.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtNome.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtNome.Font = new Font("Segoe UI", 9F);
            txtNome.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtNome.Location = new Point(12, 97);
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Ex: Suspense, Ação...";
            txtNome.SelectedText = "";
            txtNome.ShadowDecoration.CustomizableEdges = customizableEdges14;
            txtNome.Size = new Size(180, 36);
            txtNome.TabIndex = 1;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNome.Location = new Point(15, 72);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(111, 15);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome da categoria:";
            // 
            // lblFormTitulo
            // 
            lblFormTitulo.AutoSize = true;
            lblFormTitulo.Font = new Font("Yu Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFormTitulo.Location = new Point(15, 30);
            lblFormTitulo.Name = "lblFormTitulo";
            lblFormTitulo.Size = new Size(123, 19);
            lblFormTitulo.TabIndex = 0;
            lblFormTitulo.Text = "Nova Categoria";
            // 
            // gridCategorias
            // 
            gridCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridCategorias.Columns.AddRange(new DataGridViewColumn[] { colID, colName, colFilmesCount });
            gridCategorias.Location = new Point(22, 147);
            gridCategorias.Name = "gridCategorias";
            gridCategorias.Size = new Size(468, 277);
            gridCategorias.TabIndex = 2;
            // 
            // colID
            // 
            colID.HeaderText = "ID";
            colID.Name = "colID";
            // 
            // colName
            // 
            colName.HeaderText = "Nome da categoria";
            colName.Name = "colName";
            // 
            // colFilmesCount
            // 
            colFilmesCount.HeaderText = "Total de filmes";
            colFilmesCount.Name = "colFilmesCount";
            // 
            // CategoriasUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(gridCategorias);
            Controls.Add(pnlForm);
            Controls.Add(pnlToolBar);
            Controls.Add(lblTitulo);
            Name = "CategoriasUserControl";
            Size = new Size(711, 438);
            pnlToolBar.ResumeLayout(false);
            pnlForm.ResumeLayout(false);
            pnlForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridCategorias).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Panel pnlToolBar;
        private Panel pnlForm;
        private Guna.UI2.WinForms.Guna2Button btnAtualizar;
        private Guna.UI2.WinForms.Guna2Button btnExcluir;
        private Guna.UI2.WinForms.Guna2Button btnEditar;
        private Guna.UI2.WinForms.Guna2Button btnNova;
        private Guna.UI2.WinForms.Guna2Button btnCancelar;
        private Guna.UI2.WinForms.Guna2Button btnSalvar;
        private Guna.UI2.WinForms.Guna2TextBox txtNome;
        private Label lblNome;
        private Label lblFormTitulo;
        private DataGridView gridCategorias;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colFilmesCount;
    }
}
