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
    }
}
