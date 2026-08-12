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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
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
            lblTitulo.Font = new Font("Yu Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(41, 21);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(104, 19);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "👤 Meu Perfil";
            // 
            // card
            // 
            card.BackColor = Color.White;
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
            btnAvatar.FillColor = Color.RoyalBlue;
            btnAvatar.Font = new Font("Yu Gothic", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAvatar.ForeColor = Color.White;
            btnAvatar.Location = new Point(250, 20);
            btnAvatar.Name = "btnAvatar";
            btnAvatar.ShadowDecoration.CustomizableEdges = customizableEdges1;
            btnAvatar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            btnAvatar.Size = new Size(100, 100);
            btnAvatar.TabIndex = 0;
            btnAvatar.Text = "U";
            // 
            // lblEmailLabel
            // 
            lblEmailLabel.AutoSize = true;
            lblEmailLabel.Font = new Font("Yu Gothic", 9F, FontStyle.Bold);
            lblEmailLabel.ForeColor = SystemColors.ControlDark;
            lblEmailLabel.Location = new Point(38, 202);
            lblEmailLabel.Name = "lblEmailLabel";
            lblEmailLabel.Size = new Size(50, 16);
            lblEmailLabel.TabIndex = 0;
            lblEmailLabel.Text = "E-MAIL";
            // 
            // lblApiLabel
            // 
            lblApiLabel.AutoSize = true;
            lblApiLabel.Font = new Font("Yu Gothic", 9F, FontStyle.Bold);
            lblApiLabel.ForeColor = SystemColors.ControlDark;
            lblApiLabel.Location = new Point(38, 255);
            lblApiLabel.Name = "lblApiLabel";
            lblApiLabel.Size = new Size(107, 16);
            lblApiLabel.TabIndex = 0;
            lblApiLabel.Text = "API CONECTADA";
            // 
            // lblRolesValor
            // 
            lblRolesValor.AutoSize = true;
            lblRolesValor.Font = new Font("Yu Gothic", 9F);
            lblRolesValor.Location = new Point(38, 335);
            lblRolesValor.Name = "lblRolesValor";
            lblRolesValor.Size = new Size(16, 16);
            lblRolesValor.TabIndex = 0;
            lblRolesValor.Text = "...";
            // 
            // lblRolesLabel
            // 
            lblRolesLabel.AutoSize = true;
            lblRolesLabel.Font = new Font("Yu Gothic", 9F, FontStyle.Bold);
            lblRolesLabel.ForeColor = SystemColors.ControlDark;
            lblRolesLabel.Location = new Point(38, 311);
            lblRolesLabel.Name = "lblRolesLabel";
            lblRolesLabel.Size = new Size(87, 16);
            lblRolesLabel.TabIndex = 0;
            lblRolesLabel.Text = "PERMISSÕES";
            // 
            // lblApiValor
            // 
            lblApiValor.AutoSize = true;
            lblApiValor.Font = new Font("Yu Gothic", 9F);
            lblApiValor.Location = new Point(38, 281);
            lblApiValor.Name = "lblApiValor";
            lblApiValor.Size = new Size(16, 16);
            lblApiValor.TabIndex = 0;
            lblApiValor.Text = "...";
            // 
            // lblEmailValor
            // 
            lblEmailValor.AutoSize = true;
            lblEmailValor.Font = new Font("Yu Gothic", 9F);
            lblEmailValor.Location = new Point(38, 226);
            lblEmailValor.Name = "lblEmailValor";
            lblEmailValor.Size = new Size(16, 16);
            lblEmailValor.TabIndex = 0;
            lblEmailValor.Text = "...";
            // 
            // lblBagde
            // 
            lblBagde.AutoSize = true;
            lblBagde.BackColor = SystemColors.Highlight;
            lblBagde.Font = new Font("Yu Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBagde.ForeColor = Color.White;
            lblBagde.Location = new Point(233, 150);
            lblBagde.Name = "lblBagde";
            lblBagde.Padding = new Padding(50, 10, 50, 10);
            lblBagde.Size = new Size(138, 36);
            lblBagde.TabIndex = 0;
            lblBagde.Text = "Perfil";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNome.Location = new Point(267, 123);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(70, 21);
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
            Load += PerfilUserControl_Load;
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
