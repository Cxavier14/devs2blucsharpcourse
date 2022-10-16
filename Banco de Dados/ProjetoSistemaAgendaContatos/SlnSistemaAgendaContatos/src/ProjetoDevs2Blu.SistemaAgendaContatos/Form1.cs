using MySql.Data.MySqlClient;
using ProjetoDevs2Blu.SistemaAgendaContatos.Data;
using ProjetoDevs2Blu.SistemaContatos.ClassLibrary;
using ProjetoDevs2Blu.SistemaContatos.ClassLibrary.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoDevs2Blu.SistemaAgendaContatos
{
    public partial class Form1 : Form
    {
        public ContatoRepository ContatoRepository = new ContatoRepository();
        public CompromissoRepository CompromissoRepository = new CompromissoRepository();
        public EstadoRepository EstadoRepository = new EstadoRepository();
        public Contato ContatoForm = new Contato();
        public Estado EstadoForm = new Estado();
        //To retrieve selected item on combobox:
        //YourEnum enum = (YourEnum) yourComboBox.SelectedItem;

        public Form1()
        {
            InitializeComponent();
        }
        #region Methods
        private void PopulaGridCompromissos()
        {
            var listaCompromissos = CompromissoRepository.GetAllCompromissos();
            dgvCompromissos.DataSource = new BindingSource(listaCompromissos, null);
        }
        private void PopulaGridContatos()
        {
            var listaContatos = ContatoRepository.GetAllContatos();
            dgvContatos.DataSource = new BindingSource(listaContatos, null);
        }
        private void SaveContato()
        {
            MySqlConnection conn = ConnectionMySQL.GetConnection();
            ContatoForm = new Contato();
            EstadoForm = new Estado();
            ContatoForm.Nome = txtNome.Text;
            ContatoForm.Telefone = mskTelefone.Text;
            ContatoForm.Email = txtEmail.Text;
            ContatoForm.RedeSocial = txtRedeSocial.Text;
            ContatoForm.Rua = txtRua.Text;
            ContatoForm.Numero = Int32.Parse(txtNumero.Text);
            ContatoForm.Bairro = txtBairro.Text;
            ContatoForm.Cidade = txtCidade.Text;
            EstadoForm.Id = (int)cboUF.SelectedValue;

            if (ContatoRepository.Save(ContatoForm, EstadoForm, conn))
                MessageBox.Show($"Contato {ContatoForm.Nome} salvo com sucesso!", "Contato adicionado", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }
        private void SaveCompromisso()
        {

        }
        private void PopulaDiaSemana()
        {
            cboDiaSemana.DataSource = Enum.GetValues(typeof(DiasSemana));
        }
        private void PopulaEstado()
        {
            var listaEstados = EstadoRepository.FetchAll();

            cboUF.DataSource = new BindingSource(listaEstados, null);
            cboUF.DisplayMember = "uf";
            cboUF.ValueMember = "id";
        }
        private void LimpaContatos()
        {
            txtNome.Clear();
            mskTelefone.Clear();
            txtEmail.Clear();
            txtRedeSocial.Clear();
            txtRua.Clear();
            txtNumero.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            cboUF.Text = "";
        }
        private void PreencheCamposContatos()
        {

        }
        #endregion

        #region Events

        private void Form1_Activated(object sender, EventArgs e)
        {
            PopulaEstado();
            PopulaDiaSemana();
            PopulaGridContatos();
            PopulaGridCompromissos();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Versão 1.0", "Developed by Eduardo Xavier", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            SaveContato();
            LimpaContatos();
        }
        private void btnClean_Click(object sender, EventArgs e)
        {
            LimpaContatos();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            var index = dgvContatos.CurrentCell.RowIndex;
            int idContato = (int)dgvContatos.Rows[index].Cells["id"].Value;
            var nomeContato = dgvContatos.Rows[index].Cells["nome"].Value;

            if (DialogResult.Yes == MessageBox.Show($"Deseja Excluir o Contato {idContato} - {nomeContato}?", "Excluir Contato", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                if (ContatoRepository.Delete(idContato))
                {
                    MessageBox.Show("Contato Excluído com Sucesso!", "Excluir Contato", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Contato contato = new Contato();
            contato.Id = int.Parse(dgvContatos.CurrentRow.Cells[0].Value.ToString());

            MySqlConnection conn = ConnectionMySQL.GetConnection();
            
            ContatoForm.Nome = txtNome.Text;
            ContatoForm.Telefone = mskTelefone.Text;
            ContatoForm.Email = txtEmail.Text;
            ContatoForm.RedeSocial = txtRedeSocial.Text;
            ContatoForm.Rua = txtRua.Text;
            ContatoForm.Numero = Int32.Parse(txtNumero.Text);
            ContatoForm.Bairro = txtBairro.Text;
            ContatoForm.Cidade = txtCidade.Text;
            EstadoForm.Id = (int)cboUF.SelectedValue;

            if (ContatoRepository.Update(ContatoForm, EstadoForm, contato.Id, conn))
                MessageBox.Show($"Contato {ContatoForm.Nome} alterado com sucesso!", "Contato alterado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            LimpaContatos();
        }
        private void dgvContatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int idContato = (int)dgvContatos.Rows[e.RowIndex].Cells["id"].Value;
            MySqlDataReader contatoReader = ContatoRepository.GetContatoById(idContato);
            
            while (contatoReader.Read())
            {
                txtNome.Text = contatoReader.GetString("nome");
                mskTelefone.Text = contatoReader.GetString("telefone");
                txtEmail.Text = contatoReader.GetString("email");
                txtRedeSocial.Text = contatoReader.GetString("redesocial");
                txtRua.Text = contatoReader.GetString("rua");
                txtNumero.Text = contatoReader.GetInt32("numero").ToString();
                txtBairro.Text = contatoReader.GetString("Bairro");
                txtCidade.Text = contatoReader.GetString("cidade");
                cboUF.Text = dgvContatos.CurrentRow.Cells[9].Value.ToString();
            }
        }

        private void btnInsert_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Adiocionar Contato", btnInsert);
        }

        private void btnUpdate_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Editar Contato", btnUpdate);
        }

        private void btnClean_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Limpar Formulário", btnClean);
        }

        private void btnDelete_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Excluir Contato", btnDelete);
        }

        private void btnInfo_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Informações", btnInfo);
        }
        #endregion
    }
}
