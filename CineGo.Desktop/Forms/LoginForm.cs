using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CineGo.Desktop.Services;
using CineGo.Desktop.Helpers;
using System.Diagnostics.Eventing.Reader;

namespace CineGo.Desktop.Forms
{
    public partial class LoginForm : Form
    {
        private AuthApiService _authService = null;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            if (DesignMode) return;

            _authServuce = AuthService();

            lblAPI.Text = $"API: {AppConfig.ApiBaseUrl}";

            txtEmail.Text = "Admin@CineGo.com";
            txtSenha.Text = "Admin@123";

        }

        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) txtSenha.Focus();
        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btnEntrar_Click(sender, e);

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private async Task btnEntrar_Click(object sender, EventArgs e)
        {
            ExibirErro(string.Empty);

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                ExibirErro("Informe seu E-mail");
                txtEmail.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtSenha.Text))
            {
                ExibirErro("Informe sua Senha");
                txtSenha.Focus();
                return;
            }

            SetCarregando(true);

            try
            {
                var (success, user, errorMessage) = await _authService.LoginAsync(txtEmail.Text.Trim(), txtSenha.Text);


                if (sucess && User != null)
                {
                    SessioManager.Instance.SetUser(user);

                    this.Hide();

                    var mainForm = new MainForm();
                    mainForm.ShowDialog();

                    this.Close();
                }
                else
                {

                    ExibirErro($"X{errorMessage}");
                    MessageBox.Show($"{errorMessage}");
                }
            }
            catch (HttpRequestException exHttp)
            {
                ExibirErro($"Não foi possível conectar à API. \nVerifique se a API está em execução erro do sistema: {exHttp.Message}");
                MessageBox.Show($"❌ Não foi possível conectar à API. \nVerifique se a API está em execução erro do sistema: {exHttp.Message}")
            }
            catch (Exception ex) 
            {
                ExibirErro($"❌ Erro inesperado: {ex.Message}");
                MessageBox.Show($"❌ Erro inesperado: {ex.Message}");
            }
            finally
            {
                SetCarregando(false);
            }


        }

        private void ExibirErro(string mensagem)
        {
            if (string.IsNullOrEmpty(mensagem))
            {
                lblErro.Text = string.Empty;
                lblErro.Visible = false;
            }
            else
            {
                lblErro.Text = mensagem;
                lblErro.Visible = true;
            }
        }

        private void SetCarregando(bool val)
        {
            btnEntrar.Enabled = !carregando;
            txtEmail.Enabled = !carregando;
            txtSenha.Enabled = !carregando;
            lblCarregando.Visible = carregando;

            if (carregando)
            {
                btnEntrar.Text = "Carregando...";
                lblErro.Visible = false;

            }
            else
            {
                btnEntrar.Text = "Entrar";
            }
        }

    }
}
