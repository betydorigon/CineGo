// =============================================================================
// ineGo.Desktop - Forms/FilmeFormDialog.cs
// =============================================================================
//  CONCEITO: Dialog de Formulário de Game
//
// Um Dialog é um formulário auxiliar que:
//   - Abre SOBRE o formulário pai (ShowDialog)
//   - Bloqueia a interação com o pai enquanto está aberto
//   - Retorna um resultado (OK ou Cancel)
//
// Usado para: criar e editar games.
// Recebe categorias já carregadas para evitar nova chamada à API.
// =============================================================================

using CineGo.Desktop.DTOs;
using System.Diagnostics.Eventing.Reader;

namespace CineGo.Desktop.Forms
{
    /// <summary>
    /// Formulário de criação/edição de Game.
    /// Retorna CreateFilmeDto (novo) ou UpdateFilmeDto (edição).
    /// </summary>
    public partial class FilmeFormDialog : Form
    {
        // =====================================================================
        // PROPRIEDADES DE SAÍDA
        // =====================================================================

        /// <summary>DTO preenchido quando no modo de criação (OK)</summary>

        public CreateFilmeDto? FilmeDto { get; private set; }

        /// <summary>DTO preenchido quando no modo de edição (OK)</summary>
        public UpdateFilmeDto? UpdateDto { get; private set; }

        // =====================================================================
        // CAMPOS PRIVADOS
        // =====================================================================
        private List<CategoriaResponseDto> _categorias = new();

        private FilmeResponseDto? _filmeExistente;


        // =====================================================================
        // CONSTRUTORES
        // =====================================================================

        /// <summary>
        /// Construtor padrão sem parâmetros — necessário para o Designer.
        /// Use o construtor com parâmetros em produção.
        /// </summary>
        public FilmeFormDialog()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Construtor de produção com categorias e game opcional.
        /// </summary>
        /// <param name="categorias">Lista de categorias para o ComboBox</param>
        /// <param name="filme">null para criação, game existente para edição</param>
        public FilmeFormDialog(List<CategoriaResponseDto> categorias, FilmeResponseDto? filme)
        {
            _categorias = categorias;
            _filmeExistente = filme;
            InitializeComponent();
        }

        // =====================================================================
        // EVENTO LOAD
        // =====================================================================

        private void FilmeFormDialog_Load(object sender, EventArgs e)
        {

        }

        // =====================================================================
        // PREENCHIMENTO (MODO EDIÇÃO)
        // =====================================================================
        private void PreencherCampos()
        {
            if (_filmeExistente == null) return;

            txtTitulo.Text = _filmeExistente.Titulo;
            txtSinopse.Text = _filmeExistente.Sinopse;
            txtAno.Text = _filmeExistente.RealeseYear.ToString();
            txtCoverUrl.Text = _filmeExistente.CoverImageUrl;

            // Seleciona a categoria correspondente
            var idx = _categorias.FindIndex(c => c.Id == _filmeExistente.CategoryId);
            if (idx >= 0) cmbCategoria.SelectedIndex = idx + 1; // +1 pelo placeholder
        }


        // =====================================================================
        // SALVAR
        // =====================================================================
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitulo.Text))
            {
                MessageBox.Show("Informe o título do Filme", "Validação",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtAno.Text, out int ano))
            {
                MessageBox.Show(
                    "Informe um ano de lançamento válido",
                    "Validação",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (cmbCategoria.SelectedIndex <= 0)
            {
                MessageBox.Show(
                    "selecione uma categoria.",
                    "Validação",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            var categoriaIdx = cmbCategoria.SelectedIndex - 1;
            var categoriaId = _categorias[categoriaIdx].Id;

            if (_filmeExistente == null)
            {
                FilmeDto = new CreateFilmeDto
                {
                    Titulo = txtTitulo.Text.Trim(),
                    Sinopse = txtSinopse.Text.Trim(),
                    RealeseYear = ano,
                    CoverImageUrl = txtCoverUrl.Text.Trim(),
                    CategoriaId = categoriaId
                };

            }
            else
            {
                UpdateDto = new UpdateFilmeDto
                {
                    Titulo = txtTitulo.Text.Trim(),
                    Sinopse = txtSinopse.Text.Trim(),
                    RealeseYear = ano,
                    CoverImageUrl = txtCoverUrl.Text.Trim(),
                    CategoryId = categoriaId
                };
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FilmeFormDialog_Load_1(object sender, EventArgs e)
        {
            //Guard: não executa em tempo de design
            if (DesignMode) return;

            // Configura título baseado no modo (criação/edição)
            this.Text = _filmeExistente == null ? "➕ Novo Filme" : "✏️ Editar Filme";
            lblCampTitulo.Text = _filmeExistente == null ? "➕ Novo Filme" : "✏️ Editar Filme";

            // Popula o ComboBox de categorias
            cmbCategoria.Items.Clear();
            cmbCategoria.Items.Add("Selecione uma categoria...");
            foreach (var cat in _categorias)
                cmbCategoria.Items.Add(cat.Name);
            cmbCategoria.SelectedIndex = 1;



            // Preenche campos se estiver no modo edição
            PreencherCampos();

        }
    }
}
