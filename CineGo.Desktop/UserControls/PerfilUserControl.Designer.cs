namespace CineGo.Desktop.UserControls
{
    partial class PerfilUserControl
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            lblTitulo = new Label();
            card = new Panel();
            sep = new Panel();
            btnAvatar = new Guna.UI2.WinForms.Guna2CircleButton();
            lblEmailLabel = new Label();
            lblApiLabel = new Label();
            lblRolesValor = new Label();
            lblRolesLabel = new Label();
            lblApiValor = new Label();
            lblEmailValor = new Label();
            lblBagde = new Label();
            lblNome = new Label();
            card.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(41, 21);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(76, 15);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "👤 Meu Perfil";
            // 
            // card
            // 
            card.Controls.Add(sep);
            card.Controls.Add(btnAvatar);
            card.Controls.Add(lblEmailLabel);
            card.Controls.Add(lblApiLabel);
            card.Controls.Add(lblRolesValor);
            card.Controls.Add(lblRolesLabel);
            card.Controls.Add(lblApiValor);
            card.Controls.Add(lblEmailValor);
            card.Controls.Add(lblBagde);
            card.Controls.Add(lblNome);
            card.Location = new Point(41, 49);
            card.Name = "card";
            card.Size = new Size(625, 364);
            card.TabIndex = 1;
            // 
            // sep
            // 
            sep.BackColor = SystemColors.ActiveCaptionText;
            sep.Location = new Point(38, 195);
            sep.Name = "sep";
            sep.Size = new Size(550, 1);
            sep.TabIndex = 1;
            // 
            // btnAvatar
            // 
            btnAvatar.DisabledState.BorderColor = Color.DarkGray;
            btnAvatar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAvatar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAvatar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAvatar.Font = new Font("Segoe UI", 9F);
            btnAvatar.ForeColor = Color.White;
            btnAvatar.Location = new Point(254, 9);
            btnAvatar.Name = "btnAvatar";
            btnAvatar.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnAvatar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            btnAvatar.Size = new Size(100, 100);
            btnAvatar.TabIndex = 0;
            btnAvatar.Text = "U";
            // 
            // lblEmailLabel
            // 
            lblEmailLabel.AutoSize = true;
            lblEmailLabel.Location = new Point(38, 202);
            lblEmailLabel.Name = "lblEmailLabel";
            lblEmailLabel.Size = new Size(46, 15);
            lblEmailLabel.TabIndex = 0;
            lblEmailLabel.Text = "E-MAIL";
            // 
            // lblApiLabel
            // 
            lblApiLabel.AutoSize = true;
            lblApiLabel.Location = new Point(38, 255);
            lblApiLabel.Name = "lblApiLabel";
            lblApiLabel.Size = new Size(98, 15);
            lblApiLabel.TabIndex = 0;
            lblApiLabel.Text = "API CONECTADA";
            // 
            // lblRolesValor
            // 
            lblRolesValor.AutoSize = true;
            lblRolesValor.Location = new Point(38, 335);
            lblRolesValor.Name = "lblRolesValor";
            lblRolesValor.Size = new Size(16, 15);
            lblRolesValor.TabIndex = 0;
            lblRolesValor.Text = "...";
            // 
            // lblRolesLabel
            // 
            lblRolesLabel.AutoSize = true;
            lblRolesLabel.Location = new Point(38, 311);
            lblRolesLabel.Name = "lblRolesLabel";
            lblRolesLabel.Size = new Size(74, 15);
            lblRolesLabel.TabIndex = 0;
            lblRolesLabel.Text = "PERMISSÕES";
            // 
            // lblApiValor
            // 
            lblApiValor.AutoSize = true;
            lblApiValor.Location = new Point(38, 281);
            lblApiValor.Name = "lblApiValor";
            lblApiValor.Size = new Size(16, 15);
            lblApiValor.TabIndex = 0;
            lblApiValor.Text = "...";
            // 
            // lblEmailValor
            // 
            lblEmailValor.AutoSize = true;
            lblEmailValor.Location = new Point(38, 226);
            lblEmailValor.Name = "lblEmailValor";
            lblEmailValor.Size = new Size(16, 15);
            lblEmailValor.TabIndex = 0;
            lblEmailValor.Text = "...";
            // 
            // lblBagde
            // 
            lblBagde.AutoSize = true;
            lblBagde.Location = new Point(238, 150);
            lblBagde.Name = "lblBagde";
            lblBagde.Padding = new Padding(50, 10, 50, 10);
            lblBagde.Size = new Size(134, 35);
            lblBagde.TabIndex = 0;
            lblBagde.Text = "Perfil";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(280, 124);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(47, 15);
            lblNome.TabIndex = 0;
            lblNome.Text = "Usuário";
            // 
            // PerfilUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(card);
            Controls.Add(lblTitulo);
            Name = "PerfilUserControl";
            Size = new Size(711, 438);
            card.ResumeLayout(false);
            card.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Panel card;
        private Guna.UI2.WinForms.Guna2CircleButton btnAvatar;
        private Panel sep;
        private Label lblEmailLabel;
        private Label lblApiLabel;
        private Label lblRolesValor;
        private Label lblRolesLabel;
        private Label lblApiValor;
        private Label lblEmailValor;
        private Label lblBagde;
        private Label lblNome;
    }
}
