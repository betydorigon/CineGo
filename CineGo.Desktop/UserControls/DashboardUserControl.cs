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
    private FilmeApiService _filmeService = null;
    private CategoriaApiService _categoriaService = null; 
    public partial class DashboardUserControl : UserControl
    {
        
        public DashboardUserControl()
        {
            InitializeComponent();
        }

        private async Task DashboardUserControl_Load(object sender, EventArgs e)
        {
            if (DesignMode) return;

            _filmeService = filmeApiService();
            _categoriaService = new CategoriaApiService();

            lblTitulo.Text = $"Olá, {SessionManager.Instance.GetDisplayName()!} 👋";
            lblSubtitulo.Text = $"Bem-vindo ao SenacGames Desktop - {DateTime.Now:dddd, dd 'de' MMM 'de' yyyy}";

            await CarregarDadosAsync();
        }
        private async Task CarregarDadosAsync()
        {
            SetCarregando();

            try
            {
                var tarefaFilmes = _filmeService.GetAllAsync();
                var tarefaCategorias = _categoriaService.GetAllAsync();
                await Task.WhenAll(tarefaFilmes, tarefaCategorias);

                var filmes = tarefaFilmes.Result;
                var categorias = tarefaCategorias.Result;
            } 
            catch (Exception ex)
            {

            }
        }
    }
}
