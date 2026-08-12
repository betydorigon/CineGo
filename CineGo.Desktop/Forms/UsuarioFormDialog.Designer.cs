namespace CineGo.Desktop.Forms
{
    partial class UsuarioFormDialog
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
            lblTitulo = new Label();
            lblEmail = new Label();
            lblSenha = new Label();
            lblConf = new Label();
            lblPerfil = new Label();
            txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            txtSenha = new Guna.UI2.WinForms.Guna2TextBox();
            txtConfirmar = new Guna.UI2.WinForms.Guna2TextBox();
            cmbPerfil = new ComboBox();
            btnSalvar = new Guna.UI2.WinForms.Guna2Button();
            btnCancelar = new Guna.UI2.WinForms.Guna2Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Yu Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(43, 25);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(128, 19);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "👤 Novo Usuário";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Yu Gothic", 9F, FontStyle.Bold);
            lblEmail.Location = new Point(43, 60);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(59, 16);
            lblEmail.TabIndex = 0;
            lblEmail.Text = "E-MAIL *";
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Font = new Font("Yu Gothic", 9F, FontStyle.Bold);
            lblSenha.Location = new Point(43, 128);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(58, 16);
            lblSenha.TabIndex = 0;
            lblSenha.Text = "SENHA *";
            // 
            // lblConf
            // 
            lblConf.AutoSize = true;
            lblConf.Font = new Font("Yu Gothic", 9F, FontStyle.Bold);
            lblConf.Location = new Point(43, 193);
            lblConf.Name = "lblConf";
            lblConf.Size = new Size(135, 16);
            lblConf.TabIndex = 0;
            lblConf.Text = "CONFIRMAR SENHA *";
            // 
            // lblPerfil
            // 
            lblPerfil.AutoSize = true;
            lblPerfil.Font = new Font("Yu Gothic", 9F, FontStyle.Bold);
            lblPerfil.Location = new Point(43, 262);
            lblPerfil.Name = "lblPerfil";
            lblPerfil.Size = new Size(95, 16);
            lblPerfil.TabIndex = 0;
            lblPerfil.Text = "PERFIL (ROLE)";
            // 
            // txtEmail
            // 
            txtEmail.BorderRadius = 5;
            txtEmail.CustomizableEdges = customizableEdges1;
            txtEmail.DefaultText = "";
            txtEmail.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtEmail.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtEmail.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtEmail.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtEmail.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtEmail.Font = new Font("Segoe UI", 9F);
            txtEmail.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtEmail.Location = new Point(43, 78);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "seuemail@cinego.com";
            txtEmail.SelectedText = "";
            txtEmail.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtEmail.Size = new Size(441, 36);
            txtEmail.TabIndex = 1;
            // 
            // txtSenha
            // 
            txtSenha.BorderRadius = 5;
            txtSenha.CustomizableEdges = customizableEdges3;
            txtSenha.DefaultText = "";
            txtSenha.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtSenha.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtSenha.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtSenha.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtSenha.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSenha.Font = new Font("Segoe UI", 9F);
            txtSenha.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSenha.Location = new Point(43, 146);
            txtSenha.Name = "txtSenha";
            txtSenha.PlaceholderText = "••••••••••••";
            txtSenha.SelectedText = "";
            txtSenha.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtSenha.Size = new Size(441, 36);
            txtSenha.TabIndex = 1;
            // 
            // txtConfirmar
            // 
            txtConfirmar.BorderRadius = 5;
            txtConfirmar.CustomizableEdges = customizableEdges5;
            txtConfirmar.DefaultText = "";
            txtConfirmar.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtConfirmar.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtConfirmar.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtConfirmar.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtConfirmar.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtConfirmar.Font = new Font("Segoe UI", 9F);
            txtConfirmar.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtConfirmar.Location = new Point(43, 211);
            txtConfirmar.Name = "txtConfirmar";
            txtConfirmar.PlaceholderText = "••••••••••••";
            txtConfirmar.SelectedText = "";
            txtConfirmar.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtConfirmar.Size = new Size(441, 36);
            txtConfirmar.TabIndex = 1;
            // 
            // cmbPerfil
            // 
            cmbPerfil.FormattingEnabled = true;
            cmbPerfil.Location = new Point(43, 280);
            cmbPerfil.Name = "cmbPerfil";
            cmbPerfil.Size = new Size(441, 23);
            cmbPerfil.TabIndex = 2;
            // 
            // btnSalvar
            // 
            btnSalvar.BorderRadius = 10;
            btnSalvar.CustomizableEdges = customizableEdges7;
            btnSalvar.DisabledState.BorderColor = Color.DarkGray;
            btnSalvar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSalvar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSalvar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSalvar.FillColor = Color.ForestGreen;
            btnSalvar.Font = new Font("Segoe UI", 9F);
            btnSalvar.ForeColor = Color.White;
            btnSalvar.Location = new Point(43, 335);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnSalvar.Size = new Size(149, 45);
            btnSalvar.TabIndex = 3;
            btnSalvar.Text = "🗃️ Salvar";
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BorderRadius = 10;
            btnCancelar.CustomizableEdges = customizableEdges9;
            btnCancelar.DisabledState.BorderColor = Color.DarkGray;
            btnCancelar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCancelar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCancelar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCancelar.FillColor = Color.Silver;
            btnCancelar.Font = new Font("Segoe UI", 9F);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(198, 335);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.ShadowDecoration.CustomizableEdges = customizableEdges10;
            btnCancelar.Size = new Size(115, 45);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.Click += btnCancelar_Click;
            // 
            // UsuarioFormDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(520, 425);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Controls.Add(cmbPerfil);
            Controls.Add(txtConfirmar);
            Controls.Add(txtSenha);
            Controls.Add(txtEmail);
            Controls.Add(lblPerfil);
            Controls.Add(lblConf);
            Controls.Add(lblSenha);
            Controls.Add(lblEmail);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UsuarioFormDialog";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UsuarioFormDialog";
            Load += UsuarioFormDialog_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblEmail;
        private Label lblSenha;
        private Label lblConf;
        private Label lblPerfil;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private Guna.UI2.WinForms.Guna2TextBox txtSenha;
        private Guna.UI2.WinForms.Guna2TextBox txtConfirmar;
        private ComboBox cmbPerfil;
        private Guna.UI2.WinForms.Guna2Button btnSalvar;
        private Guna.UI2.WinForms.Guna2Button btnCancelar;
    }
}