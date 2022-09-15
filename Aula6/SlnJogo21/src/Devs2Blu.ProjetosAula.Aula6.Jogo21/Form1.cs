using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Devs2Blu.ProjetosAula.Aula6.Jogo21
{
    public partial class Form1 : Form
    {
        const int PT1a6 = 1;
        const int PT7 = 10;
        const int PT8a13 = 5;
        const int PT14 = 20;
        const int PT15a20 = 6;
        const int PT21 = 30;
        public int PontuacaoP1 { get; set; }
        public int PontuacaoP2 { get; set; }
        public int GeradoPC { get; set; }
        public int SomaP1 { get; set; }
        public int SomaP2 { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtConsole.Text += "\r\n Pressione \"Iniciar\" para começar o jogo.";

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            txtConsole.Text += "\r\n Primeira Rodada";
            txtConsole.Text += "\r\n Informe um número de 1 a 20";
            txtPlayer1.Focus();
        }

        private void btnPlayer1_Click(object sender, EventArgs e)
        {
            txtConsole.Enabled = true;
            txtConsole.Text += "\r\n Player 1 escolheu seu número...";
            SomaP1 = Int32.Parse(txtPlayer1.Text);
            Thread.Sleep(2000);
            GeraNumeroPlayer2();

        }

        //Exemplo Metodo sem retornar valor
        private void GeraNumeroPlayer2()
        {
            Random rd = new Random();
            SomaP2 = rd.Next(1, 20);
            GeradoPC = rd.Next(1, 20);
            txtPlayer2.Text = SomaP2.ToString();
            txtConsole.Text += "\r\n Player 2 escolheu seu número...";
            txtConsole.Text += $"\r\n Número sorteado {GeradoPC}...";
            txtResultP1.Text += txtPlayer1.Text;
            txtResultP2.Text += txtPlayer2.Text;
            SomaResultado();
        }

        private void SomaResultado()
        {
            SomaP1 += GeradoPC;
            SomaP2 += GeradoPC;
            txtResultP1.Text = SomaP1.ToString();
            txtResultP2.Text = SomaP2.ToString();
            AtribuiPontosP1(SomaP1);
            AtribuiPontosP2(SomaP2);
            txtResultP1.Text = $"{PontuacaoP1.ToString()} Pontos";
            txtResultP2.Text = $"{PontuacaoP2.ToString()} Pontos";
            VerificaVencedor(PontuacaoP1, PontuacaoP2);
        }

        private void AtribuiPontosP1(int pontos)
        {
            switch (pontos)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                    PontuacaoP1 += PT1a6;
                    break;
                case 7:
                    PontuacaoP1 += PT7;
                    break;
                case 8:
                case 9:
                case 10:
                case 11:
                case 12:
                case 13:
                    PontuacaoP1 += PT8a13;
                    break;
                case 14:
                    PontuacaoP1 += PT14;
                    break;
                case 15:
                case 16:
                case 17:
                case 18:
                case 19:
                case 20:
                    PontuacaoP1 += PT15a20;
                    break;
                case 21:
                    PontuacaoP1 += PT21;
                    break;
                case int i when (i > 21):
                    PontuacaoP1 = 0;
                    break;
            }
        }

        private void AtribuiPontosP2(int pontos)
        {
            switch (pontos)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                    PontuacaoP2 += PT1a6;
                    break;
                case 7:
                    PontuacaoP2 += PT7;
                    break;
                case 8:
                case 9:
                case 10:
                case 11:
                case 12:
                case 13:
                    PontuacaoP2 += PT8a13;
                    break;
                case 14:
                    PontuacaoP2 += PT14;
                    break;
                case 15:
                case 16:
                case 17:
                case 18:
                case 19:
                case 20:
                    PontuacaoP2 += PT15a20;
                    break;
                case 21:
                    PontuacaoP2 += PT21;
                    break;
                case int i when (i > 21):
                    PontuacaoP2 = 0;
                    break;
            }
        }

        private void VerificaVencedor(int player1, int player2)
        {
            if (player1 > player2)
            {
                MessageBox.Show("Player 1 é o vencedor!");
            }
            else if (player1 < player2)
            {
                MessageBox.Show("Player 2 é o vencedor!");
            }
            else
            {
                MessageBox.Show("Empatou!");
            }
        }

        private void txtResultP1_TextChanged(object sender, EventArgs e)
        {
            txtResultP1.Enabled = false;
        }

        private void txtResultP2_TextChanged(object sender, EventArgs e)
        {
            txtResultP2.Enabled = false;
        }
    }
}
