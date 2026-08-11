namespace CineGo.Desktop.Forms
{
    partial class FilmeFormDialog
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
            lblTituloForm = new Label();
            lblCampTitulo = new Label();
            lblCampSinopse = new Label();
            lblCampAno = new Label();
            lblCampCover = new Label();
            lblCampCategoria = new Label();
            btnSalvar = new Guna.UI2.WinForms.Guna2Button();
            btnCancelar = new Guna.UI2.WinForms.Guna2Button();
            txtTitulo = new Guna.UI2.WinForms.Guna2TextBox();
            txtSinopse = new Guna.UI2.WinForms.Guna2TextBox();
            txtAno = new Guna.UI2.WinForms.Guna2TextBox();
            txtCoverUrl = new Guna.UI2.WinForms.Guna2TextBox();
            cmbCategoria = new ComboBox();
            SuspendLayout();
            // 
            // lblTituloForm
            // 
            lblTituloForm.AutoSize = true;
            lblTituloForm.Location = new Point(34, 23);
            lblTituloForm.Name = "lblTituloForm";
            lblTituloForm.Size = new Size(36, 15);
            lblTituloForm.TabIndex = 0;
            lblTituloForm.Text = "Filme";
            // 
            // lblCampTitulo
            // 
            lblCampTitulo.AutoSize = true;
            lblCampTitulo.Location = new Point(34, 57);
            lblCampTitulo.Name = "lblCampTitulo";
            lblCampTitulo.Size = new Size(110, 15);
            lblCampTitulo.TabIndex = 0;
            lblCampTitulo.Text = "TÍTULO DO FILME *";
            // 
            // lblCampSinopse
            // 
            lblCampSinopse.AutoSize = true;
            lblCampSinopse.Location = new Point(34, 124);
            lblCampSinopse.Name = "lblCampSinopse";
            lblCampSinopse.Size = new Size(53, 15);
            lblCampSinopse.TabIndex = 0;
            lblCampSinopse.Text = "SINOPSE";
            // 
            // lblCampAno
            // 
            lblCampAno.AutoSize = true;
            lblCampAno.Location = new Point(34, 245);
            lblCampAno.Name = "lblCampAno";
            lblCampAno.Size = new Size(141, 15);
            lblCampAno.TabIndex = 0;
            lblCampAno.Text = "ANO DE LANÇAMENTO *";
            // 
            // lblCampCover
            // 
            lblCampCover.AutoSize = true;
            lblCampCover.Location = new Point(34, 310);
            lblCampCover.Name = "lblCampCover";
            lblCampCover.Size = new Size(80, 15);
            lblCampCover.TabIndex = 0;
            lblCampCover.Text = "URL DA CAPA";
            // 
            // lblCampCategoria
            // 
            lblCampCategoria.AutoSize = true;
            lblCampCategoria.Location = new Point(34, 375);
            lblCampCategoria.Name = "lblCampCategoria";
            lblCampCategoria.Size = new Size(78, 15);
            lblCampCategoria.TabIndex = 0;
            lblCampCategoria.Text = "CATEGORIA *";
            // 
            // btnSalvar
            // 
            btnSalvar.CustomizableEdges = customizableEdges1;
            btnSalvar.DisabledState.BorderColor = Color.DarkGray;
            btnSalvar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSalvar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSalvar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSalvar.Font = new Font("Segoe UI", 9F);
            btnSalvar.ForeColor = Color.White;
            btnSalvar.Location = new Point(34, 498);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnSalvar.Size = new Size(180, 45);
            btnSalvar.TabIndex = 1;
            btnSalvar.Text = "🗃️ Salvar";
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.CustomizableEdges = customizableEdges3;
            btnCancelar.DisabledState.BorderColor = Color.DarkGray;
            btnCancelar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCancelar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCancelar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCancelar.Font = new Font("Segoe UI", 9F);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(220, 498);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnCancelar.Size = new Size(180, 45);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtTitulo
            // 
            txtTitulo.CustomizableEdges = customizableEdges5;
            txtTitulo.DefaultText = "";
            txtTitulo.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtTitulo.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtTitulo.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtTitulo.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtTitulo.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtTitulo.Font = new Font("Segoe UI", 9F);
            txtTitulo.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtTitulo.Location = new Point(34, 75);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.PlaceholderText = "Ex: Mad Max";
            txtTitulo.SelectedText = "";
            txtTitulo.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtTitulo.Size = new Size(450, 36);
            txtTitulo.TabIndex = 2;
            // 
            // txtSinopse
            // 
            txtSinopse.CustomizableEdges = customizableEdges7;
            txtSinopse.DefaultText = "";
            txtSinopse.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtSinopse.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtSinopse.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtSinopse.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtSinopse.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSinopse.Font = new Font("Segoe UI", 9F);
            txtSinopse.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSinopse.Location = new Point(34, 142);
            txtSinopse.Name = "txtSinopse";
            txtSinopse.PlaceholderText = "Descrição do filme...";
            txtSinopse.SelectedText = "";
            txtSinopse.ShadowDecoration.CustomizableEdges = customizableEdges8;
            txtSinopse.Size = new Size(450, 88);
            txtSinopse.TabIndex = 2;
            txtSinopse.TextOffset = new Point(0, -30);
            // 
            // txtAno
            // 
            txtAno.CustomizableEdges = customizableEdges9;
            txtAno.DefaultText = "";
            txtAno.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtAno.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtAno.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtAno.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtAno.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtAno.Font = new Font("Segoe UI", 9F);
            txtAno.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtAno.Location = new Point(34, 262);
            txtAno.Name = "txtAno";
            txtAno.PlaceholderText = "Ex: 2015";
            txtAno.SelectedText = "";
            txtAno.ShadowDecoration.CustomizableEdges = customizableEdges10;
            txtAno.Size = new Size(450, 36);
            txtAno.TabIndex = 2;
            // 
            // txtCoverUrl
            // 
            txtCoverUrl.CustomizableEdges = customizableEdges11;
            txtCoverUrl.DefaultText = "";
            txtCoverUrl.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtCoverUrl.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtCoverUrl.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtCoverUrl.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtCoverUrl.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtCoverUrl.Font = new Font("Segoe UI", 9F);
            txtCoverUrl.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtCoverUrl.Location = new Point(34, 328);
            txtCoverUrl.Name = "txtCoverUrl";
            txtCoverUrl.PlaceholderText = "https://...";
            txtCoverUrl.SelectedText = "";
            txtCoverUrl.ShadowDecoration.CustomizableEdges = customizableEdges12;
            txtCoverUrl.Size = new Size(450, 36);
            txtCoverUrl.TabIndex = 2;
            // 
            // cmbCategoria
            // 
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(34, 393);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(450, 23);
            cmbCategoria.TabIndex = 3;
            // 
            // FilmeFormDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(520, 580);
            Controls.Add(cmbCategoria);
            Controls.Add(txtSinopse);
            Controls.Add(txtCoverUrl);
            Controls.Add(txtAno);
            Controls.Add(txtTitulo);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Controls.Add(lblCampCategoria);
            Controls.Add(lblCampCover);
            Controls.Add(lblCampAno);
            Controls.Add(lblCampSinopse);
            Controls.Add(lblCampTitulo);
            Controls.Add(lblTituloForm);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FilmeFormDialog";
            Text = "FilmeFormDialog";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTituloForm;
        private Label lblCampTitulo;
        private Label lblCampSinopse;
        private Label lblCampAno;
        private Label lblCampCover;
        private Label lblCampCategoria;
        private Guna.UI2.WinForms.Guna2Button btnSalvar;
        private Guna.UI2.WinForms.Guna2Button btnCancelar;
        private Guna.UI2.WinForms.Guna2TextBox txtTitulo;
        private Guna.UI2.WinForms.Guna2TextBox txtSinopse;
        private Guna.UI2.WinForms.Guna2TextBox txtAno;
        private Guna.UI2.WinForms.Guna2TextBox txtCoverUrl;
        private ComboBox cmbCategoria;
    }
}