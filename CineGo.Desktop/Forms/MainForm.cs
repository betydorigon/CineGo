using CineGo.Desktop.Helpers;
using CineGo.Desktop.Services;
using CineGo.Desktop.UserControls;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CineGo.Desktop.Forms
{
    public partial class MainForm : Form
    {
        //======================================
        // CAMPOS PRIVADOS
        //======================================
        private UserControl? _userControl;

        private Guna2Button? _activeButton;

        private AuthApiService _authService = null;

        /// <summary>
        /// Construtor padrão sem parâmetros
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Guard: não executa em tempo de design
            if (DesignMode) return;

            // Instancia o serviço
            _authService = new AuthApiService();

            // Atualiza o título com a versão
            this.Text = $"CineGo Desktop - {AppConfig.Version}";

            // Preenche dados dinâmicos de sessão no header
            lblUsuario.Text = $"👷{SessionManager.Instance.GetDisplayName()}";
            lblPerfil.Text = SessionManager.Instance.IsAdmin ? "🔑 Administrador" : "👁️‍🗨️ Usuário Comum";
            lblPerfil.ForeColor = SessionManager.Instance.IsAdmin ? Color.Orange : Color.Blue;
            lblSessao.Text = $"🟢 {SessionManager.Instance.GetEmail()}";

            // Configura permissões baseadas no perfil do usuário
            ConfigurarPermissoes();

            // Abre o DashBoard como tela inicial
            NavegarParaDashboard();
        }

        private void ConfigurarPermissoes()
        {
            var isAdmin = SessionManager.Instance.IsAdmin;

            btnCategoria.Visible = isAdmin;
            btnUsuarios.Visible = isAdmin;
        }

        private void NavegarParaDashboard()
        {
            Navegar(new DashboardUserControl(), btnDashboard);
        }

        private void Navegar(UserControl control, Guna2Button? button = null)
        {
            // Remove o Usercontrol anterior
            if (_userControl != null)
            {
                pnlConteudo.Controls.Remove(_userControl);
                _userControl.Dispose();
                _userControl = null;
            }

            // Adiciona o novo UserControl(Tela interna)
            control.Dock = DockStyle.Fill;
            pnlConteudo.Controls.Add(control);
            _userControl = control;

            AtualizarBotaoAtivo(button);
        }

        private void AtualizarBotaoAtivo(Guna2Button? button)
        {
            if (_activeButton != null)
            {
                _activeButton.FillColor = Color.Transparent;
                _activeButton.ForeColor = Color.White;

                _activeButton = button;
                if (_activeButton != null)
                {
                    _activeButton.FillColor = Color.FromArgb(0, 50, 110);
                    _activeButton.ForeColor = Color.White;
                    _activeButton.CustomBorderColor = Color.Orange;
                }
            }
        }

        private async void btnLogout_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Deseja realmente encerrar a sessão?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result != DialogResult.Yes) return;

            try
            {
                await _authService.LogoutAsync();
            }
            catch
            {
                // Mesmo se a API falhar, limpa a sessão local
            }
            finally
            {
                SessionManager.Instance.Clear();
                this.Close();
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e) => Navegar(new DashboardUserControl(), btnDashboard);
        private void btnFilmes_Click(object sender, EventArgs e) => Navegar(new FilmesUserControl(), btnFilmes);
        private void btnCategoria_Click(object sender, EventArgs e) => Navegar(new CategoriasUserControl(), btnCategoria);
        private void btnUsuarios_Click(object sender, EventArgs e) => Navegar(new UsuariosUserControl(), btnUsuarios);
        private void btnMeuPerfil_Click(object sender, EventArgs e) => Navegar(new PerfilUserControl(), btnMeuPerfil);
    }
}
