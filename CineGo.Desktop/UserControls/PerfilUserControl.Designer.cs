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
            label1 = new Label();
            panel1 = new Panel();
            guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            label2 = new Label();
            label3 = new Label();
            panel2 = new Panel();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 21);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 0;
            label1.Text = "👤 Meu Perfil";
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(guna2CircleButton1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(41, 49);
            panel1.Name = "panel1";
            panel1.Size = new Size(625, 364);
            panel1.TabIndex = 1;
            // 
            // guna2CircleButton1
            // 
            guna2CircleButton1.DisabledState.BorderColor = Color.DarkGray;
            guna2CircleButton1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2CircleButton1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2CircleButton1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2CircleButton1.Font = new Font("Segoe UI", 9F);
            guna2CircleButton1.ForeColor = Color.White;
            guna2CircleButton1.Location = new Point(254, 9);
            guna2CircleButton1.Name = "guna2CircleButton1";
            guna2CircleButton1.ShadowDecoration.CustomizableEdges = customizableEdges1;
            guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna2CircleButton1.Size = new Size(100, 100);
            guna2CircleButton1.TabIndex = 0;
            guna2CircleButton1.Text = "U";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(280, 124);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 0;
            label2.Text = "Usuário";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(238, 150);
            label3.Name = "label3";
            label3.Padding = new Padding(50, 10, 50, 10);
            label3.Size = new Size(134, 35);
            label3.TabIndex = 0;
            label3.Text = "Perfil";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaptionText;
            panel2.Location = new Point(38, 195);
            panel2.Name = "panel2";
            panel2.Size = new Size(550, 1);
            panel2.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 202);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
            label4.TabIndex = 0;
            label4.Text = "E-MAIL";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(38, 226);
            label5.Name = "label5";
            label5.Size = new Size(16, 15);
            label5.TabIndex = 0;
            label5.Text = "...";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(38, 281);
            label6.Name = "label6";
            label6.Size = new Size(16, 15);
            label6.TabIndex = 0;
            label6.Text = "...";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(38, 255);
            label7.Name = "label7";
            label7.Size = new Size(98, 15);
            label7.TabIndex = 0;
            label7.Text = "API CONECTADA";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(38, 311);
            label8.Name = "label8";
            label8.Size = new Size(74, 15);
            label8.TabIndex = 0;
            label8.Text = "PERMISSÕES";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(38, 335);
            label9.Name = "label9";
            label9.Size = new Size(16, 15);
            label9.TabIndex = 0;
            label9.Text = "...";
            // 
            // PerfilUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "PerfilUserControl";
            Size = new Size(711, 438);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
        private Panel panel2;
        private Label label4;
        private Label label7;
        private Label label9;
        private Label label8;
        private Label label6;
        private Label label5;
        private Label label3;
        private Label label2;
    }
}
