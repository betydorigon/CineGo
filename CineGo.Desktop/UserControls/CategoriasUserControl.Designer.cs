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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges25 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges26 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges27 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges28 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
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
            lblTitulo.Location = new Point(22, 21);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(178, 15);
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
            btnAtualizar.CustomizableEdges = customizableEdges15;
            btnAtualizar.DisabledState.BorderColor = Color.DarkGray;
            btnAtualizar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAtualizar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAtualizar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAtualizar.Font = new Font("Segoe UI", 9F);
            btnAtualizar.ForeColor = Color.White;
            btnAtualizar.Location = new Point(349, 27);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.ShadowDecoration.CustomizableEdges = customizableEdges16;
            btnAtualizar.Size = new Size(106, 45);
            btnAtualizar.TabIndex = 0;
            btnAtualizar.Text = "🔃 Atualizar";
            btnAtualizar.Click += this.btnAtualizar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.CustomizableEdges = customizableEdges17;
            btnExcluir.DisabledState.BorderColor = Color.DarkGray;
            btnExcluir.DisabledState.CustomBorderColor = Color.DarkGray;
            btnExcluir.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnExcluir.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnExcluir.Font = new Font("Segoe UI", 9F);
            btnExcluir.ForeColor = Color.White;
            btnExcluir.Location = new Point(237, 27);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.ShadowDecoration.CustomizableEdges = customizableEdges18;
            btnExcluir.Size = new Size(106, 45);
            btnExcluir.TabIndex = 0;
            btnExcluir.Text = "🗑️ Excluir";
            btnExcluir.Click += btnExcluir_Click;
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
            btnEditar.Location = new Point(125, 27);
            btnEditar.Name = "btnEditar";
            btnEditar.ShadowDecoration.CustomizableEdges = customizableEdges20;
            btnEditar.Size = new Size(106, 45);
            btnEditar.TabIndex = 0;
            btnEditar.Text = "✏️ Editar";
            btnEditar.Click += btnEditar_Click;
            // 
            // btnNova
            // 
            btnNova.CustomizableEdges = customizableEdges21;
            btnNova.DisabledState.BorderColor = Color.DarkGray;
            btnNova.DisabledState.CustomBorderColor = Color.DarkGray;
            btnNova.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnNova.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnNova.Font = new Font("Segoe UI", 9F);
            btnNova.ForeColor = Color.White;
            btnNova.Location = new Point(13, 27);
            btnNova.Name = "btnNova";
            btnNova.ShadowDecoration.CustomizableEdges = customizableEdges22;
            btnNova.Size = new Size(106, 45);
            btnNova.TabIndex = 0;
            btnNova.Text = "+ Nova Categoria";
            btnNova.Click += btnNova_Click;
            // 
            // pnlForm
            // 
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
            btnCancelar.CustomizableEdges = customizableEdges23;
            btnCancelar.DisabledState.BorderColor = Color.DarkGray;
            btnCancelar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCancelar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCancelar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCancelar.Font = new Font("Segoe UI", 9F);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(103, 144);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.ShadowDecoration.CustomizableEdges = customizableEdges24;
            btnCancelar.Size = new Size(90, 34);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "❌Cancelar";
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.Transparent;
            btnSalvar.BorderRadius = 5;
            btnSalvar.CustomizableEdges = customizableEdges25;
            btnSalvar.DisabledState.BorderColor = Color.DarkGray;
            btnSalvar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSalvar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSalvar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSalvar.Font = new Font("Segoe UI", 9F);
            btnSalvar.ForeColor = Color.White;
            btnSalvar.Location = new Point(11, 144);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.ShadowDecoration.CustomizableEdges = customizableEdges26;
            btnSalvar.Size = new Size(90, 34);
            btnSalvar.TabIndex = 2;
            btnSalvar.Text = "🗃️ Salvar";
            btnSalvar.Click += btnSalvar_Click;
            // 
            // txtNome
            // 
            txtNome.CustomizableEdges = customizableEdges27;
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
            txtNome.ShadowDecoration.CustomizableEdges = customizableEdges28;
            txtNome.Size = new Size(180, 36);
            txtNome.TabIndex = 1;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(27, 68);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(111, 15);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome da categoria:";
            // 
            // lblFormTitulo
            // 
            lblFormTitulo.AutoSize = true;
            lblFormTitulo.Location = new Point(27, 30);
            lblFormTitulo.Name = "lblFormTitulo";
            lblFormTitulo.Size = new Size(89, 15);
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
