using CineGo.Desktop.DTOs;
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
    public partial class FilmesUserControl : UserControl
    {
        private FilmesApiService _filmeService = null;
        private CategoriaApiService _categoriaService = null;

        private List<FilmeResponseDto> _todosFilmes = new();
        private List<CategoriaResponseDto> _categorias = new();

        public FilmesUserControl()
        {
            InitializeComponent();
        }

        private async Task FilmesUserControl_Load(object sender, EventArgs e)
        {
            if (DesignMode) return;

            _filmeService = new FilmesApiService();
            _categoriaService = new CategoriaApiService();

            ConfigurarPermissoes();

            await CarregarDadosAsync();
        }

        private void ConfigurarPermissoes() 
        {
            bool isAdmin = SessionManager.Instance.IsAdmin;
            btnNovo.visible = isAdmin; 
            btnEditar.Visible = isAdmin;
            btnExcluir.Visible = isAdmin;
        }

        private async Task CarregarDadosAsync()
        {
            gridFilmes.Rows.Clear();

            try
            {
                var tarefaFilmes = _filmeService.GetAllAsync();
                var tarefaCategorias = _categoriaService.GetAllAsync();
                await Task.WhenAll(tarefaFilmes, tarefaCategorias);

                _todosFilmes = tarefaFilmes.Result;
                _categorias = tarefaCategorias.Result;

                popularGrid(_todosFilmes);
            }
            catch (Exception ex) 
            {
                MessageBox.Show($"Erro ao carregar filmes: {ex.Message}",
                    "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void PopularGrid(List<FilmeResponseDto> filmes)
        {
            gridFilmes.Rows.Clear();
            foreach(var f in filmes)
            {
                gridFilmes.Rows.Add(
                    f.Id,
                    f.Name,
                    f.CategoryName,
                    f.Classificacao,
                    f.Duracao,
                    f.RealeseYear,
                    f.CreatedAt.ToString("dd/MM/yyyy HH:mm"));
                    
            }
        }

        


    }
}
