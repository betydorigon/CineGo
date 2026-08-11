namespace CineGo.Desktop.Forms
{
    partial class MainForm
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
            pnlUsuario = new Panel();
            lblPerfil = new Label();
            lblUsuario = new Label();
            pnlHeader = new Panel();
            btnLogout = new Guna.UI2.WinForms.Guna2Button();
            lblTitulo = new Label();
            pnlLogo = new Panel();
            lblSiderbarSub = new Label();
            lblSiderbarLogo = new Label();
            pnlConteudo = new Panel();
            lblSessao = new Label();
            btnDashboard = new Guna.UI2.WinForms.Guna2Button();
            pnlSidebar = new Panel();
            btnMeuPerfil = new Guna.UI2.WinForms.Guna2Button();
            btnUsuarios = new Guna.UI2.WinForms.Guna2Button();
            btnCategoria = new Guna.UI2.WinForms.Guna2Button();
            btnFilmes = new Guna.UI2.WinForms.Guna2Button();
            pnlUsuario.SuspendLayout();
            pnlHeader.SuspendLayout();
            pnlLogo.SuspendLayout();
            pnlSidebar.SuspendLayout();
            SuspendLayout();
            // 
            // pnlUsuario
            // 
            pnlUsuario.Controls.Add(lblPerfil);
            pnlUsuario.Controls.Add(lblUsuario);
            pnlUsuario.Location = new Point(0, 0);
            pnlUsuario.Name = "pnlUsuario";
            pnlUsuario.Size = new Size(200, 100);
            pnlUsuario.TabIndex = 0;
            // 
            // lblPerfil
            // 
            lblPerfil.AutoSize = true;
            lblPerfil.Location = new Point(27, 59);
            lblPerfil.Name = "lblPerfil";
            lblPerfil.Size = new Size(34, 15);
            lblPerfil.TabIndex = 0;
            lblPerfil.Text = "Perfil";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Yu Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsuario.Location = new Point(27, 30);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(109, 25);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "👤Usuário";
            // 
            // pnlHeader
            // 
            pnlHeader.Controls.Add(btnLogout);
            pnlHeader.Controls.Add(lblTitulo);
            pnlHeader.Location = new Point(201, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(729, 100);
            pnlHeader.TabIndex = 0;
            // 
            // btnLogout
            // 
            btnLogout.BorderRadius = 5;
            btnLogout.CustomizableEdges = customizableEdges1;
            btnLogout.DisabledState.BorderColor = Color.DarkGray;
            btnLogout.DisabledState.CustomBorderColor = Color.DarkGray;
            btnLogout.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnLogout.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnLogout.Font = new Font("Segoe UI", 9F);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(591, 30);
            btnLogout.Name = "btnLogout";
            btnLogout.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnLogout.Size = new Size(99, 36);
            btnLogout.TabIndex = 1;
            btnLogout.Text = "Sair";
            btnLogout.Click += btnLogout_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Yu Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(39, 34);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(86, 27);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "CineGo";
            // 
            // pnlLogo
            // 
            pnlLogo.Controls.Add(lblSiderbarSub);
            pnlLogo.Controls.Add(lblSiderbarLogo);
            pnlLogo.Location = new Point(0, 100);
            pnlLogo.Name = "pnlLogo";
            pnlLogo.Size = new Size(200, 74);
            pnlLogo.TabIndex = 0;
            // 
            // lblSiderbarSub
            // 
            lblSiderbarSub.AutoSize = true;
            lblSiderbarSub.Location = new Point(27, 45);
            lblSiderbarSub.Name = "lblSiderbarSub";
            lblSiderbarSub.Size = new Size(111, 15);
            lblSiderbarSub.TabIndex = 0;
            lblSiderbarSub.Text = "Plataforma Desktop";
            // 
            // lblSiderbarLogo
            // 
            lblSiderbarLogo.AutoSize = true;
            lblSiderbarLogo.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSiderbarLogo.Location = new Point(27, 16);
            lblSiderbarLogo.Name = "lblSiderbarLogo";
            lblSiderbarLogo.Size = new Size(74, 25);
            lblSiderbarLogo.TabIndex = 0;
            lblSiderbarLogo.Text = "CineGo";
            // 
            // pnlConteudo
            // 
            pnlConteudo.Location = new Point(206, 106);
            pnlConteudo.Name = "pnlConteudo";
            pnlConteudo.Size = new Size(711, 438);
            pnlConteudo.TabIndex = 0;
            // 
            // lblSessao
            // 
            lblSessao.AutoSize = true;
            lblSessao.Location = new Point(12, 355);
            lblSessao.Name = "lblSessao";
            lblSessao.Size = new Size(16, 15);
            lblSessao.TabIndex = 0;
            lblSessao.Text = "...";
            // 
            // btnDashboard
            // 
            btnDashboard.CustomizableEdges = customizableEdges3;
            btnDashboard.DisabledState.BorderColor = Color.DarkGray;
            btnDashboard.DisabledState.CustomBorderColor = Color.DarkGray;
            btnDashboard.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnDashboard.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnDashboard.Font = new Font("Segoe UI", 9F);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Location = new Point(0, 0);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnDashboard.Size = new Size(200, 45);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = "Dashboard";
            btnDashboard.Click += btnDashboard_Click;
            // 
            // pnlSidebar
            // 
            pnlSidebar.Controls.Add(btnMeuPerfil);
            pnlSidebar.Controls.Add(btnUsuarios);
            pnlSidebar.Controls.Add(btnCategoria);
            pnlSidebar.Controls.Add(btnFilmes);
            pnlSidebar.Controls.Add(btnDashboard);
            pnlSidebar.Controls.Add(lblSessao);
            pnlSidebar.Location = new Point(0, 174);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(200, 380);
            pnlSidebar.TabIndex = 0;
            // 
            // btnMeuPerfil
            // 
            btnMeuPerfil.CustomizableEdges = customizableEdges5;
            btnMeuPerfil.DisabledState.BorderColor = Color.DarkGray;
            btnMeuPerfil.DisabledState.CustomBorderColor = Color.DarkGray;
            btnMeuPerfil.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnMeuPerfil.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnMeuPerfil.Font = new Font("Segoe UI", 9F);
            btnMeuPerfil.ForeColor = Color.White;
            btnMeuPerfil.Location = new Point(0, 180);
            btnMeuPerfil.Name = "btnMeuPerfil";
            btnMeuPerfil.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnMeuPerfil.Size = new Size(200, 45);
            btnMeuPerfil.TabIndex = 1;
            btnMeuPerfil.Text = "Meu Perfil";
            btnMeuPerfil.Click += btnMeuPerfil_Click;
            // 
            // btnUsuarios
            // 
            btnUsuarios.CustomizableEdges = customizableEdges7;
            btnUsuarios.DisabledState.BorderColor = Color.DarkGray;
            btnUsuarios.DisabledState.CustomBorderColor = Color.DarkGray;
            btnUsuarios.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnUsuarios.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnUsuarios.Font = new Font("Segoe UI", 9F);
            btnUsuarios.ForeColor = Color.White;
            btnUsuarios.Location = new Point(0, 135);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnUsuarios.Size = new Size(200, 45);
            btnUsuarios.TabIndex = 1;
            btnUsuarios.Text = "Usuários";
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // btnCategoria
            // 
            btnCategoria.CustomizableEdges = customizableEdges9;
            btnCategoria.DisabledState.BorderColor = Color.DarkGray;
            btnCategoria.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCategoria.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCategoria.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCategoria.Font = new Font("Segoe UI", 9F);
            btnCategoria.ForeColor = Color.White;
            btnCategoria.Location = new Point(0, 90);
            btnCategoria.Name = "btnCategoria";
            btnCategoria.ShadowDecoration.CustomizableEdges = customizableEdges10;
            btnCategoria.Size = new Size(200, 45);
            btnCategoria.TabIndex = 1;
            btnCategoria.Text = "Categoria";
            btnCategoria.Click += btnCategoria_Click;
            // 
            // btnFilmes
            // 
            btnFilmes.CustomizableEdges = customizableEdges11;
            btnFilmes.DisabledState.BorderColor = Color.DarkGray;
            btnFilmes.DisabledState.CustomBorderColor = Color.DarkGray;
            btnFilmes.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnFilmes.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnFilmes.Font = new Font("Segoe UI", 9F);
            btnFilmes.ForeColor = Color.White;
            btnFilmes.Location = new Point(0, 45);
            btnFilmes.Name = "btnFilmes";
            btnFilmes.ShadowDecoration.CustomizableEdges = customizableEdges12;
            btnFilmes.Size = new Size(200, 45);
            btnFilmes.TabIndex = 1;
            btnFilmes.Text = "Filmes";
            btnFilmes.Click += btnFilmes_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(929, 553);
            Controls.Add(pnlConteudo);
            Controls.Add(pnlSidebar);
            Controls.Add(pnlHeader);
            Controls.Add(pnlLogo);
            Controls.Add(pnlUsuario);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            pnlUsuario.ResumeLayout(false);
            pnlUsuario.PerformLayout();
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlLogo.ResumeLayout(false);
            pnlLogo.PerformLayout();
            pnlSidebar.ResumeLayout(false);
            pnlSidebar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlUsuario;
        private Panel pnlHeader;
        private Label lblPerfil;
        private Label lblUsuario;
        private Guna.UI2.WinForms.Guna2Button btnDashboard;
        private Label lblTitulo;
        private Panel pnlLogo;
        private Label lblSiderbarSub;
        private Label lblSiderbarLogo;
        private Panel pnlConteudo;
        private Label lblSessao;
        private Panel pnlSidebar;
        private Guna.UI2.WinForms.Guna2Button btnMeuPerfil;
        private Guna.UI2.WinForms.Guna2Button btnUsuarios;
        private Guna.UI2.WinForms.Guna2Button btnCategoria;
        private Guna.UI2.WinForms.Guna2Button btnFilmes;
        private Guna.UI2.WinForms.Guna2Button btnLogout;
    }
}