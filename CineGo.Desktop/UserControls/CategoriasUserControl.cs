using CineGo.Desktop.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

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

        private async Task  CarregarDadosAsync()
        {
            gridCategorias.Rows.Clear();
            try
            {
                _categoria = await _CategoriaService.GetAllAsync();
                foreach (var c in _categoria)
                    gridCategorias.Rows.Add(c.Id, c.Name, c.FilmeCount);
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
            lblFormTitulo.Text
        }

    }
}
