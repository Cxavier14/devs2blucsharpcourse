using Devs2Blu.ProjetosAula.SistemaCadastro.Forms.Data;
using Devs2Blu.ProjetosAula.SistemaCadastro.Models.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Devs2Blu.ProjetosAula.SistemaCadastro.Forms
{
    public partial class Form1 : Form
    {
        public MySqlConnection Conn { get; set; }
        public ConvenioRepository ConvenioRepository = new ConvenioRepository();
        public PacienteRepository PacienteRepository = new PacienteRepository();
        public EnderecoRepository EnderecoRepository = new EnderecoRepository();
        public PessoaRepository PessoaRepository = new PessoaRepository();
        public Paciente PacienteAtual = new Paciente();
        public Pessoa PessoaAtual = new Pessoa();
        public Endereco EnderecoAtual = new Endereco();

        public Form1()
        {
            InitializeComponent();
        }


        #region Methods

        private void PopulaComboConvenio()
        {
            var listConvenios = ConvenioRepository.FetchAll();

            cboConvenio.DataSource = new BindingSource(listConvenios, null);
            cboConvenio.DisplayMember = "nome";
            cboConvenio.ValueMember = "id";
        }

        private void PopulaGridPessoa()
        {
            var listPessoas = PessoaRepository.GetPessoas();
            gridPacientes.DataSource = new BindingSource(listPessoas, null);
        }

        private bool ValidaFormCadastro()
        {
            if (txtNome.Text.Equals(""))
                return false;
            if (txtCGCCPF.Text.Equals(""))
                return false;
            if (cboConvenio.SelectedIndex == -1)
                return false;
            if (mskCEP.Text.Equals(""))
                return false;
            if (cboUF.Text.Equals(""))
                return false;
            if (txtCidade.Text.Equals(""))
                return false;
            if (txtRua.Text.Equals(""))
                return false;
            if (txtNumero.Text.Equals(""))
                return false;
            if (txtBairro.Text.Equals(""))
                return false;

            return true;
        }

        #endregion

        #region Events
        private void Form1_Load(object sender, EventArgs e)
        {
            #region TesteConexao
            /*Conn = ConnectionMySQL.GetConnection();

            if (Conn.State == ConnectionState.Open)
            {
                MessageBox.Show("Conexão efetuada com sucesso!", "Conexão ao MySQL", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Conn.Close();
            }*/
            #endregion
            PopulaComboConvenio();
            PopulaGridPessoa();
        }

        private void rdFisica_CheckedChanged(object sender, EventArgs e)
        {
            txtCGCCPF.Mask = "000.000.000 - 00";
            lblCGCCPF.Text = "CPF";
            lblCGCCPF.Visible = true;
        }

        private void rdJuridica_CheckedChanged(object sender, EventArgs e)
        {
            //txtCGCCPF.Mask = "00.000.000/0000 - 00";
            lblCGCCPF.Text = "CNPJ";
            lblCGCCPF.Visible = true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidaFormCadastro())
            {
                PacienteAtual.Pessoa.Nome = txtNome.Text;
                PacienteAtual.Pessoa.CGCCPF = txtCGCCPF.Text;
                PacienteAtual.Convenio.Id = (int)cboConvenio.SelectedValue;

                EnderecoAtual.CEP = mskCEP.Text.Replace(',', '.');
                EnderecoAtual.UF = cboUF.Text;
                EnderecoAtual.Cidade = txtCidade.Text;
                EnderecoAtual.Rua = txtRua.Text;
                EnderecoAtual.Numero = Int32.Parse(txtNumero.Text);
                EnderecoAtual.Bairro = txtBairro.Text;

                var pacientResult = PacienteRepository.Save(PacienteAtual, EnderecoAtual);
                if(pacientResult.Pessoa.Id > 0)
                    MessageBox.Show($"Pessoa {pacientResult.Pessoa.Id} - {pacientResult.Pessoa.Nome} salva com sucesso!", "Adicionar Pessoa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Houve um problema ao tentar salvar!");
            }
            PopulaGridPessoa();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtCGCCPF.Clear();
            mskCEP.Clear();
            cboUF.Clear();
            txtCidade.Clear();
            txtRua.Clear();
            txtNumero.Clear();
            txtBairro.Clear();

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

            int index = gridPacientes.CurrentCell.RowIndex;
            int idPessoa = (int)gridPacientes.Rows[index].Cells["Código"].Value;
            if (PacienteRepository.Delete(idPessoa))
            {
                if (EnderecoRepository.Delete(idPessoa))
                {
                    if (PessoaRepository.Delete(idPessoa))
                    {
                        MessageBox.Show($"Pessoa {idPessoa} excluída com sucesso!", "Excluir Pessoa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }
        
        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }                       
       
        private void Form1_Activated(object sender, EventArgs e)
        {
            PopulaGridPessoa();
        }

        private void gridPacientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int)gridPacientes.Rows[e.RowIndex].Cells["Código"].Value;
            MySqlDataReader reader = PacienteRepository.GetPacienteById(id);
            
            while (reader.Read())
            {
                txtNome.Text = reader.GetString("Nome");
                txtCGCCPF.Text = reader.GetString("CPF");
                txtPacStatus.Text = reader.GetString("Status");
                txtNumProntuario.Text = reader.GetString("Prontuario");
                txtPacRisco.Text = reader.GetString("Risco");
                cboConvenio.Text = reader.GetString("Convenio");
                mskCEP.Text = reader.GetString("CEP");
                txtRua.Text = reader.GetString("Rua");
                txtNumero.Text = reader.GetString("Número");
                txtBairro.Text = reader.GetString("Bairro");
                txtCidade.Text = reader.GetString("Cidade");
                cboUF.Text = reader.GetString("Estado");
            }            
        }
        #endregion
    }
}
