using CineGo.Desktop.Helpers;
using CineGo.Desktop.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CineGo.Desktop.UserControls
{
    public partial class PerfilUserControl : UserControl
    {
        //===================================================
        // SERVIÇOS (Inicializados no Load)
        //===================================================
        private AuthApiService _authService = null!;

        //===================================================
        // CONSTRUTOR
        //===================================================
        public PerfilUserControl()
        {
            InitializeComponent();
        }

        private void PerfilUserControl_Load(object sender, EventArgs e)
        {
            // Guard: não executa em tempo de design
            if (DesignMode) return;

            // Inicializa os serviços de autenticação
            _authService = new AuthApiService();

            // Preenche os dados de sessão nas varíaveis
            var displayName = SessionManager.Instance.GetDisplayName();
            var email = SessionManager.Instance.GetEmail();
            var IsAdmin = SessionManager.Instance.IsAdmin;

            btnAvatar.Text = displayName.Length > 0 ? displayName.Substring(0, 1).ToUpper() : "U";

            // Preenche os campos do perfil
            lblNome.Text = displayName;
            lblEmailValor.Text = email;
            lblApiValor.Text = AppConfig.ApiBaseUrl;

            // bagde do perfil
            var perfil = IsAdmin ? "🔑 Administrador" : "👁️‍🗨️ Usuário";
            var corBagde = IsAdmin ? Color.Orange : Color.Blue;
            lblBagde.Text = perfil;
            lblBagde.BackColor = corBagde;

            // Roles - Permissões do usuário
            var roles = SessionManager.Instance.CurrentUser?.Roles ?? new List<string>();

            lblRolesValor.Text = roles.Count > 0 ? string.Join(", ", roles) : "Sem perfil atribuído";
        }
    }
}
