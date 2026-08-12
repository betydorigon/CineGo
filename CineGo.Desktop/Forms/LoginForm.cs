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
        private AuthApiService _authService = null!;
        public LoginForm()
        {
            InitializeComponent();
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

        private void SetCarregando(bool carregando)
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

        private void btnFechar_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }



        private async void btnEntrar_Click_1(object sender, EventArgs e)
        {
            ExibirErro(string.Empty);

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                ExibirErro("⚠️ Informe seu E-mail");
                txtEmail.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtSenha.Text))
            {
                ExibirErro("⚠️ Informe sua Senha");
                txtSenha.Focus();
                return;
            }

            SetCarregando(true);

            try
            {
                var (success, user, errorMessage) = await _authService.LoginAsync(txtEmail.Text.Trim(), txtSenha.Text);


                if (success && user != null)
                {
                    SessionManager.Instance.SetUser(user);

                    this.Hide();

                    using var mainForm = new MainForm();
                    mainForm.ShowDialog();

                    this.Close();
                }
                else
                {

                    ExibirErro($"❌ {errorMessage}");
                    MessageBox.Show($"{errorMessage}");
                }
            }
            catch (HttpRequestException exHttp)
            {
                ExibirErro($"Não foi possível conectar à API. \nVerifique se a API está em execução erro do sistema: {exHttp.Message}");
                MessageBox.Show($"❌ Não foi possível conectar à API. \nVerifique se a API está em execução erro do sistema: {exHttp.Message}");
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

        private void LoginForm_Load(object sender, EventArgs e)
        {
            if (DesignMode) return;

            _authService = new AuthApiService();

            lblAPI.Text = $"Versão {AppConfig.Version} | ©️ {DateTime.Now.Year} SENAC-SMP";

            txtEmail.Text = "Admin@CineGo.com.br";
            txtSenha.Text = "Admin@123";
        }
    }
}
