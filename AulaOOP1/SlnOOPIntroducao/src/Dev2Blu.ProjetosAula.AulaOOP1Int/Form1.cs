using Devs2Blu.ProjetosAula.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dev2Blu.ProjetosAula.AulaOOP1Int
{
    public partial class Form1 : Form
    {
        double ProlaboreInput;
        int NumeroCrachaInput;

        public List<Recepcionista> RecepcionistasList { get; set; }
        public List<Diretor> DiretoresList { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RecepcionistasList = new List<Recepcionista>();
            DiretoresList = new List<Diretor>();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (rdDiretor.Checked)
            {
                Double.TryParse(txtProlabore.Text, out ProlaboreInput);
                Diretor diretor = new Diretor(txtNome.Text, txtSobrenome.Text, ProlaboreInput);

                SalvarDiretor(diretor);
            }
            else if (rdRecepcionista.Checked)
            {
                Int32.TryParse(txtNumCracha.Text, out NumeroCrachaInput);
                Recepcionista recepcionista = new Recepcionista(txtNome.Text, txtSobrenome.Text, NumeroCrachaInput);

                SalvarRecepcionista(recepcionista);
            }
            MostraIdade();
        }


        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparFormulario();
        }

        private void rdRecepcionista_CheckedChanged(object sender, EventArgs e)
        {
            txtProlabore.Enabled = false;
            txtNumCracha.Enabled = true;
            txtProlabore.Text = "";
        }

        private void rdDiretor_CheckedChanged(object sender, EventArgs e)
        {
            txtProlabore.Enabled = true;
            txtNumCracha.Enabled = false;
            txtNumCracha.Text = "";
        }

        #region Metodos
        private void SalvarRecepcionista(Recepcionista recepcionista)
        {
            RecepcionistasList.Add(recepcionista);
            txtStatus.Text += "\r\nRecepcionista adicionada!";
        }

        private void SalvarDiretor(Diretor diretor)
        {
            DiretoresList.Add(diretor);
            txtStatus.Text += "\r\nDiretor Adicionado!";
        }

        private void LimparFormulario()
        {
            txtNome.Text = "";
            txtSobrenome.Text = "";
            dtpNascimento.Text = "";
            txtEndereco.Text = "";
            txtIdade.Text = "";
            txtNumCracha.Text = "";
            txtProlabore.Text = "";

        }

        private void MostraIdade()
        {
            if (dtpNascimento.Value < DateTime.Now)
            {
                int idade = CalculaIdade(dtpNascimento.Value);
                txtIdade.Text = idade.ToString();
            }
            else
            {
                MessageBox.Show("Data inválida!");
            }
        }

        private static int CalculaIdade(DateTime dataNascimento)
        {
            int idade = DateTime.Now.Year - dataNascimento.Year;
            if (DateTime.Now.DayOfYear < dataNascimento.DayOfYear)
            {
                idade = idade - 1;
            }
            return idade;
        }
              
        #endregion
    }
}
