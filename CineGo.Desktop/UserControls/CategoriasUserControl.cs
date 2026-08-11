using CineGo.Desktop.DTOs;
using CineGo.Desktop.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using System.Threading.Tasks;

namespace CineGo.Desktop.UserControls
{
    public partial class CategoriasUserControl : UserControl
    {
        private CategoriaApiService _CategoriaService = null;
        private List<CategoriaResponseDto> _categoria = new();

        private int? _editandoId = null;

        public CategoriasUserControl()
        {
            InitializeComponent();
        }

        private async void CategoriasUserControl_Load(object sender, EventArgs e)
        {
            if (DesignMode) return;

            _CategoriaService = new CategoriaApiService();

            await CarregarDadosAsync();
        }

        private async Task CarregarDadosAsync()
        {
            gridCategorias.Rows.Clear();
            try
            {
                _categoria = await _CategoriaService.GetAllAsync();
                foreach (var c in _categoria)
                    gridCategorias.Rows.Add(c.Id, c.Name, c.FilmesCount);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void MostrarFormulario(CategoriaResponseDto? categoria)
        {
            _editandoId = categoria?.Id;
            txtNome.Text = categoria?.Name ?? string.Empty;
            lblFormTitulo.Text = categoria == null ? "Nova Categoria" : "Editar Categoria";
            pnlForm.Visible = true;
            txtNome.Focus();
        }

        private void OcultarFormulario()
        {
            pnlForm.Visible = false;
            _editandoId = null;
            txtNome.Clear();
        }

        // Novo: retorna a categoria selecionada no grid (ou null)
        private CategoriaResponseDto? ObterCategoriaSelecionada()
        {
            // Tenta usar a linha atual (CurrentRow). Pode ajustar para SelectedRows se preferir seleção por múltiplas linhas.
            var row = gridCategorias.CurrentRow;
            if (row == null) return null;

            // Busca a célula pelo nome da coluna definido no Designer: "colID"
            var cellValue = row.Cells["colID"]?.Value;
            if (cellValue == null) return null;

            if (!int.TryParse(cellValue.ToString(), out var id)) return null;

            // Procura no cache de categorias carregadas
            return _categoria.FirstOrDefault(c => c.Id == id);
        }

        private void btnNova_Click(object sender, EventArgs e) => MostrarFormulario(null);

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var cat = ObterCategoriaSelecionada();
            if (cat == null)
            {
                MessageBox.Show("Selecione uma categoria para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            MostrarFormulario(cat);
        }

        private async void btnExcluir_Click(object sender, EventArgs e)
        {
            var cat = ObterCategoriaSelecionada();
            if (cat == null)
            {
                MessageBox.Show("Selecione uma categoria para excluir.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cat.FilmesCount > 0)
            {
                MessageBox.Show(
                    $"A categoria \"{cat.Name}\" possui {cat.FilmesCount} filme(s) vinculado(s).\nRemova os filmes antes de excluir.",
                    "Não é possível excluir",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var conf = MessageBox.Show(
               $"Excluir a categoria \"{cat.Name}\"?",
               "Confirmar Exclusão",
               MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (conf != DialogResult.Yes) return;

            var (success, error) = await _CategoriaService.DeleteAsync(cat.Id);
            if (success)
            {
                MessageBox.Show("✅ Categoria excluída!", "Sucesso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                await CarregarDadosAsync();
            }
            else
            {
                MessageBox.Show($"❌ {error}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task btnAtualizar_Click(object? sender, EventArgs e) => await CarregarDadosAsync();

        private async Task btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("Informe o nome da categoria.", "Validação",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool success;
            string error;

            if (_editandoId == null)
            {
                var dto = new CreateCategoriaDto { Name = txtNome.Text.Trim() };
                var result = await _CategoriaService.CreateAsync(dto);
                success = result.Success;
                error = result.ErrorMessage;
            }
            else
            {
                var dto = new UpdateCategoriaDto { Name = txtNome.Text.Trim() };
                var result = await _CategoriaService.UpdateAsync(_editandoId.Value, dto);
                success = result.Success;
                error = result.ErrorMessage;
            }
            if (success)
            {
                MessageBox.Show("✅ Categoria salva com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                OcultarFormulario();
                await CarregarDadosAsync();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e) => OcultarFormulario();

        private void CategoriasUserControl_Load_1(object sender, EventArgs e)
        {

        }
    }
}
