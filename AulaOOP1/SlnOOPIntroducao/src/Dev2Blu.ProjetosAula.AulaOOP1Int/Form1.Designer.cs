namespace Dev2Blu.ProjetosAula.AulaOOP1Int
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbAnos = new System.Windows.Forms.Label();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.lbSobrenome = new System.Windows.Forms.Label();
            this.gbTipoFuncionario = new System.Windows.Forms.GroupBox();
            this.txtNumCracha = new System.Windows.Forms.TextBox();
            this.txtProlabore = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbProlabore = new System.Windows.Forms.Label();
            this.rdDiretor = new System.Windows.Forms.RadioButton();
            this.rdRecepcionista = new System.Windows.Forms.RadioButton();
            this.txtSobrenome = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lbEndereco = new System.Windows.Forms.Label();
            this.lbNascimento = new System.Windows.Forms.Label();
            this.lbNome = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.dtpNascimento = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.gbTipoFuncionario.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSalmon;
            this.groupBox1.Controls.Add(this.dtpNascimento);
            this.groupBox1.Controls.Add(this.lbAnos);
            this.groupBox1.Controls.Add(this.txtIdade);
            this.groupBox1.Controls.Add(this.txtEndereco);
            this.groupBox1.Controls.Add(this.lbSobrenome);
            this.groupBox1.Controls.Add(this.gbTipoFuncionario);
            this.groupBox1.Controls.Add(this.txtSobrenome);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.lbEndereco);
            this.groupBox1.Controls.Add(this.lbNascimento);
            this.groupBox1.Controls.Add(this.lbNome);
            this.groupBox1.Location = new System.Drawing.Point(43, 39);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(384, 466);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastro de Funcionários";
            // 
            // lbAnos
            // 
            this.lbAnos.AutoSize = true;
            this.lbAnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAnos.Location = new System.Drawing.Point(325, 98);
            this.lbAnos.Name = "lbAnos";
            this.lbAnos.Size = new System.Drawing.Size(41, 18);
            this.lbAnos.TabIndex = 13;
            this.lbAnos.Text = "anos";
            // 
            // txtIdade
            // 
            this.txtIdade.Enabled = false;
            this.txtIdade.Location = new System.Drawing.Point(283, 95);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.ReadOnly = true;
            this.txtIdade.Size = new System.Drawing.Size(40, 21);
            this.txtIdade.TabIndex = 12;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(90, 137);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(276, 21);
            this.txtEndereco.TabIndex = 4;
            // 
            // lbSobrenome
            // 
            this.lbSobrenome.AutoSize = true;
            this.lbSobrenome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSobrenome.Location = new System.Drawing.Point(8, 61);
            this.lbSobrenome.Name = "lbSobrenome";
            this.lbSobrenome.Size = new System.Drawing.Size(90, 18);
            this.lbSobrenome.TabIndex = 9;
            this.lbSobrenome.Text = "Sobrenome:";
            // 
            // gbTipoFuncionario
            // 
            this.gbTipoFuncionario.Controls.Add(this.txtNumCracha);
            this.gbTipoFuncionario.Controls.Add(this.txtProlabore);
            this.gbTipoFuncionario.Controls.Add(this.label1);
            this.gbTipoFuncionario.Controls.Add(this.lbProlabore);
            this.gbTipoFuncionario.Controls.Add(this.rdDiretor);
            this.gbTipoFuncionario.Controls.Add(this.rdRecepcionista);
            this.gbTipoFuncionario.Location = new System.Drawing.Point(14, 177);
            this.gbTipoFuncionario.Name = "gbTipoFuncionario";
            this.gbTipoFuncionario.Size = new System.Drawing.Size(352, 143);
            this.gbTipoFuncionario.TabIndex = 7;
            this.gbTipoFuncionario.TabStop = false;
            this.gbTipoFuncionario.Text = "Tipo de Funcionário";
            // 
            // txtNumCracha
            // 
            this.txtNumCracha.Enabled = false;
            this.txtNumCracha.Location = new System.Drawing.Point(167, 105);
            this.txtNumCracha.Name = "txtNumCracha";
            this.txtNumCracha.Size = new System.Drawing.Size(142, 21);
            this.txtNumCracha.TabIndex = 8;
            // 
            // txtProlabore
            // 
            this.txtProlabore.Enabled = false;
            this.txtProlabore.Location = new System.Drawing.Point(167, 60);
            this.txtProlabore.Name = "txtProlabore";
            this.txtProlabore.Size = new System.Drawing.Size(142, 21);
            this.txtProlabore.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 18);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nº do Crachá:";
            // 
            // lbProlabore
            // 
            this.lbProlabore.AutoSize = true;
            this.lbProlabore.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProlabore.Location = new System.Drawing.Point(31, 63);
            this.lbProlabore.Name = "lbProlabore";
            this.lbProlabore.Size = new System.Drawing.Size(77, 18);
            this.lbProlabore.TabIndex = 14;
            this.lbProlabore.Text = "Prolabore:";
            // 
            // rdDiretor
            // 
            this.rdDiretor.AutoSize = true;
            this.rdDiretor.Location = new System.Drawing.Point(250, 31);
            this.rdDiretor.Name = "rdDiretor";
            this.rdDiretor.Size = new System.Drawing.Size(62, 19);
            this.rdDiretor.TabIndex = 6;
            this.rdDiretor.Text = "Diretor";
            this.rdDiretor.UseVisualStyleBackColor = true;
            this.rdDiretor.CheckedChanged += new System.EventHandler(this.rdDiretor_CheckedChanged);
            // 
            // rdRecepcionista
            // 
            this.rdRecepcionista.AutoSize = true;
            this.rdRecepcionista.Location = new System.Drawing.Point(34, 31);
            this.rdRecepcionista.Name = "rdRecepcionista";
            this.rdRecepcionista.Size = new System.Drawing.Size(103, 19);
            this.rdRecepcionista.TabIndex = 5;
            this.rdRecepcionista.Text = "Recepcionista";
            this.rdRecepcionista.UseVisualStyleBackColor = true;
            this.rdRecepcionista.CheckedChanged += new System.EventHandler(this.rdRecepcionista_CheckedChanged);
            // 
            // txtSobrenome
            // 
            this.txtSobrenome.Location = new System.Drawing.Point(108, 58);
            this.txtSobrenome.Name = "txtSobrenome";
            this.txtSobrenome.Size = new System.Drawing.Size(258, 21);
            this.txtSobrenome.TabIndex = 2;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(67, 19);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(299, 21);
            this.txtNome.TabIndex = 1;
            // 
            // lbEndereco
            // 
            this.lbEndereco.AutoSize = true;
            this.lbEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEndereco.Location = new System.Drawing.Point(8, 140);
            this.lbEndereco.Name = "lbEndereco";
            this.lbEndereco.Size = new System.Drawing.Size(76, 18);
            this.lbEndereco.TabIndex = 2;
            this.lbEndereco.Text = "Endereço:";
            // 
            // lbNascimento
            // 
            this.lbNascimento.AutoSize = true;
            this.lbNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNascimento.Location = new System.Drawing.Point(8, 98);
            this.lbNascimento.Name = "lbNascimento";
            this.lbNascimento.Size = new System.Drawing.Size(147, 18);
            this.lbNascimento.TabIndex = 1;
            this.lbNascimento.Text = "Data de Nascimento:";
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome.Location = new System.Drawing.Point(8, 22);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(53, 18);
            this.lbNome.TabIndex = 0;
            this.lbNome.Text = "Nome:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.SandyBrown;
            this.groupBox2.Controls.Add(this.btnLimpar);
            this.groupBox2.Controls.Add(this.btnSalvar);
            this.groupBox2.Location = new System.Drawing.Point(447, 340);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(233, 165);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Controles";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(34, 95);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(163, 33);
            this.btnLimpar.TabIndex = 10;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(34, 37);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(163, 33);
            this.btnSalvar.TabIndex = 9;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.LightSalmon;
            this.groupBox3.Controls.Add(this.txtStatus);
            this.groupBox3.Location = new System.Drawing.Point(447, 39);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Size = new System.Drawing.Size(233, 294);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Status";
            // 
            // txtStatus
            // 
            this.txtStatus.BackColor = System.Drawing.Color.SaddleBrown;
            this.txtStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatus.ForeColor = System.Drawing.SystemColors.Window;
            this.txtStatus.Location = new System.Drawing.Point(7, 22);
            this.txtStatus.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtStatus.Multiline = true;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(219, 265);
            this.txtStatus.TabIndex = 0;
            this.txtStatus.Text = "Cadastrando funcionários...";
            // 
            // dtpNascimento
            // 
            this.dtpNascimento.CustomFormat = "";
            this.dtpNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNascimento.Location = new System.Drawing.Point(161, 95);
            this.dtpNascimento.Name = "dtpNascimento";
            this.dtpNascimento.Size = new System.Drawing.Size(115, 21);
            this.dtpNascimento.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.ClientSize = new System.Drawing.Size(728, 519);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "OOP1 Sistema de Cadastro";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbTipoFuncionario.ResumeLayout(false);
            this.gbTipoFuncionario.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtSobrenome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lbEndereco;
        private System.Windows.Forms.Label lbNascimento;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.GroupBox gbTipoFuncionario;
        private System.Windows.Forms.RadioButton rdDiretor;
        private System.Windows.Forms.RadioButton rdRecepcionista;
        private System.Windows.Forms.Label lbSobrenome;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label lbAnos;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.TextBox txtNumCracha;
        private System.Windows.Forms.TextBox txtProlabore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbProlabore;
        private System.Windows.Forms.DateTimePicker dtpNascimento;
    }
}

