using CineGo.Desktop.DTOs;
using CineGo.Desktop.Forms;
using CineGo.Desktop.Helpers;
using CineGo.Desktop.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

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

        private async void FilmesUserControl_Load(object sender, EventArgs e)
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
            btnNovo.Visible = isAdmin;
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

                PopularGrid(_todosFilmes);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar filmes: {ex.Message}",
                    "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void PopularGrid(List<FilmeResponseDto > filmes)
        {
            gridFilmes.Rows.Clear();
            foreach (var f in filmes)
            {
                gridFilmes.Rows.Add(
                    f.Id,
                    f.Titulo,
                    f.CategoryName,
                    f.RealeseYear,
                    f.CreatedAt.ToString("dd/MM/yyyy HH:mm"));

            }
        }

        private async void btnNovo_Click(object sender, EventArgs e)
        {
            using var form = new FilmeFormDialog(_categorias, null);
            if (form.ShowDialog() == DialogResult.OK && form.FilmeDto != null)
            {
                var (success, _, error) = await _filmeService.CreateAsync(form.FilmeDto);
                if (success)
                {
                    MessageBox.Show("✅ Filme criado com sucesso!",
                        "Sucesso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    await CarregarDadosAsync();
                }

                else
                {
                    MessageBox.Show($"❌ {error}",
                          "Erro",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Error);
                }
            }
        }

        private async Task btnEditar_Click(object sender, EventArgs e)
        {
            var filme = ObterFilmeSelecionado();
            if (filme == null)
            {
                MessageBox.Show($"Selecione um game para editar.",
                      "Aviso",
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Warning);
                return;
            }
            using var form = new FilmeFormDialog(_categorias, filme);
            if (form.ShowDialog() == DialogResult.OK && form.UpdateDto != null)
            {
                var (success, _, error) = await _filmeService.UpdateAsync(filme.Id, form.UpdateDto);
                if (success)
                {
                    MessageBox.Show("✅ Game atualizado com sucesso!",
                                            "Sucesso",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Information);
                    await CarregarDadosAsync();
                }
                else
                {
                    MessageBox.Show($"❌ {error}",
                      "Erro",
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Error);
                }
            }
        }

        private FilmeResponseDto? ObterFilmeSelecionado()
        {
            if (gridFilmes.SelectedRows.Count == 0) return null;
            var row = gridFilmes.SelectedRows[0];
            var id = Convert.ToInt32(row.Cells["ColId"].Value);
            return _todosFilmes.FirstOrDefault(g => g.Id == id);
        }

        private async Task btnExcluir_Click(object sender, EventArgs e)
        {
            var filme = ObterFilmeSelecionado();
            if (filme == null)
            {
                MessageBox.Show("Selecione um game para excluir.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var conf = MessageBox.Show(
                $"Tem certeza que deseja excluir o filme:\n\"{filme.Titulo}\"?",
                "Confirmar Exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            if (conf != DialogResult.Yes) return;

            var (success, error) = await _filmeService.DeleteAsync(filme.Id);
            if (success)
            {
                MessageBox.Show("✅ filme excluído com sucesso!", "Sucesso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                await CarregarDadosAsync();
            }
            else
            {
                MessageBox.Show($"❌ {error}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnAtualizar_Click(object sender, EventArgs e) => await CarregarDadosAsync();

        private void gridFilmes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
