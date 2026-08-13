using CineGo.Desktop.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CineGo.Desktop.Forms
{
    public partial class UsuarioFormDialog : Form
    {
        public CreateUsuarioDto? CreateDto { get; private set; }
        public UpdateUsuarioDto? UpdateDto { get; private set; }

        private List<string> _perfis = new();
        private UsuarioResponseDto? _usuarioExistente;


        public UsuarioFormDialog()
        {
            InitializeComponent();
        }

        public UsuarioFormDialog(List<string> perfis, UsuarioResponseDto? UsuarioExistente = null) : this()
        {
            _perfis = perfis;
            _usuarioExistente = UsuarioExistente;

            PreencherComboPerfis();

            if (_usuarioExistente != null)
            {
                lblTitulo.Text = "✏️ Editar Usuario";
                txtEmail.Text = _usuarioExistente.Email;

                if (cmbPerfil.Items.Contains(_usuarioExistente.Perfil))
                {
                    cmbPerfil.SelectedItem = _usuarioExistente.Perfil;
                }
            }
            else
            {
                lblTitulo.Text = "➕ Novo Usuario";
                if (cmbPerfil.Items.Count > 0)
                {
                    cmbPerfil.SelectedIndex = 0;
                }


            }
        }

        private void PreencherComboPerfis()
        {
            cmbPerfil.Items.Clear();
            foreach (var p in _perfis)
            {
                cmbPerfil.Items.Add(p);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show(" Email são obrigatórios.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_usuarioExistente == null && string.IsNullOrWhiteSpace(txtSenha.Text))
            {
                MessageBox.Show("Senha é obrigatória para novos usuários.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtSenha.Text != txtConfirmar.Text)
            {
                MessageBox.Show("As senhas não coincidem.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbPerfil.SelectedItem == null)
            {
                MessageBox.Show("Selecione um perfil.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_usuarioExistente == null)
            {
                CreateDto = new CreateUsuarioDto
                {

                    Email = txtEmail.Text.Trim(),
                    Password = txtSenha.Text,
                    ConfirmPassword = txtConfirmar.Text,
                    Perfil = cmbPerfil.SelectedItem.ToString()!
                };

            }
            else
            {
                UpdateDto = new UpdateUsuarioDto
                {
                    Email = txtEmail.Text.Trim(),
                    Password = string.IsNullOrEmpty(txtSenha.Text) ? null : txtSenha.Text,
                    ConfirmPassword = string.IsNullOrEmpty(txtConfirmar.Text) ? null : txtConfirmar.Text,
                    Perfil = cmbPerfil.SelectedItem.ToString()!
                };
            }
            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

    

        private void UsuarioFormDialog_Load(object sender, EventArgs e)
        {

        }
    }
}
