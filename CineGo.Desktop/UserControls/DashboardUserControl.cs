using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CineGo.Desktop.Services;
using CineGo.Desktop.Helpers;

namespace CineGo.Desktop.UserControls
{
    public partial class DashboardUserControl : UserControl
    {
    private FilmesApiService _filmeService = null;
    private CategoriaApiService _categoriaService = null; 
        
        public DashboardUserControl()
        {
            InitializeComponent();
        }

        private async void DashboardUserControl_Load(object sender, EventArgs e)
        {
            if (DesignMode) return;

            _filmeService = new FilmesApiService();
            _categoriaService = new CategoriaApiService();

            lblTitulo.Text = $"Olá, {SessionManager.Instance.GetDisplayName()!} 👋";
            lblSubtitulo.Text = $"Bem-vindo ao SenacGames Desktop - {DateTime.Now:dddd, dd 'de' MMM 'de' yyyy}";

            await CarregarDadosAsync();
        }
        private async Task CarregarDadosAsync()
        {
            SetCarregando(true);

            try
            {
                var tarefaFilmes = _filmeService.GetAllAsync();
                var tarefaCategorias = _categoriaService.GetAllAsync();
                await Task.WhenAll(tarefaFilmes, tarefaCategorias);

                var filmes = tarefaFilmes.Result;
                var categorias = tarefaCategorias.Result;

                cardFilmesLblNumero.Text = filmes.Count.ToString();
                cardCatedoriasLblTitulo.Text = categorias.Count.ToString();

                gridUltimosFilmes.Rows.Clear();
                foreach (var filme in filmes.OrderByDescending(x => x.CreatedAt).Take(10))
                {
                    gridUltimosFilmes.Rows.Add(filme.Id, filme.Titulo, filme.Categoria, filme.Duracao, filme.Classificacao, filme.CreatedAt.ToString("dd/MM/yyyy HH:mm:ss"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar dados: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                SetCarregando(false);
            }
        }
        private void AtualizarNumeroCard(Guna.UI2.WinForms.Guna2Panel card,string numero)
        {
            var lblNumero = card.Controls.OfType<Label>().FirstOrDefault(Tag => Tag?.ToString() == "numero");

            if (lblNumero != null)
            {
                lblNumero.Text = numero;
            }
        }

        private void SetCarregando (bool carregando)
        {
            lblCarregando.Visible = carregando;
            cardCategorias.Visible = !carregando;
            cardFilmes.Visible = !carregando;
            lblUltimosFilmesCadastrados.Visible = carregando;
            gridUltimosFilmes.Visible = carregando;
        }
    }
}
