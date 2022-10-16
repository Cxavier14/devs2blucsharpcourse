namespace ProjetoDevs2Blu.SistemaAgendaContatos
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gpCadastroContato = new System.Windows.Forms.GroupBox();
            this.cboUF = new System.Windows.Forms.ComboBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.txtRedeSocial = new System.Windows.Forms.TextBox();
            this.mskTelefone = new System.Windows.Forms.MaskedTextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gpCadastroCompromisso = new System.Windows.Forms.GroupBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.cboDiaSemana = new System.Windows.Forms.ComboBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.dtpDataCompromisso = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvContatos = new System.Windows.Forms.DataGridView();
            this.dgvCompromissos = new System.Windows.Forms.DataGridView();
            this.btnClean = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.gpCadastroContato.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.gpCadastroCompromisso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompromissos)).BeginInit();
            this.SuspendLayout();
            // 
            // gpCadastroContato
            // 
            this.gpCadastroContato.BackColor = System.Drawing.SystemColors.Highlight;
            this.gpCadastroContato.Controls.Add(this.cboUF);
            this.gpCadastroContato.Controls.Add(this.txtCidade);
            this.gpCadastroContato.Controls.Add(this.txtBairro);
            this.gpCadastroContato.Controls.Add(this.txtNumero);
            this.gpCadastroContato.Controls.Add(this.txtRua);
            this.gpCadastroContato.Controls.Add(this.txtRedeSocial);
            this.gpCadastroContato.Controls.Add(this.mskTelefone);
            this.gpCadastroContato.Controls.Add(this.txtEmail);
            this.gpCadastroContato.Controls.Add(this.txtNome);
            this.gpCadastroContato.Controls.Add(this.label12);
            this.gpCadastroContato.Controls.Add(this.label8);
            this.gpCadastroContato.Controls.Add(this.label7);
            this.gpCadastroContato.Controls.Add(this.label6);
            this.gpCadastroContato.Controls.Add(this.label5);
            this.gpCadastroContato.Controls.Add(this.label4);
            this.gpCadastroContato.Controls.Add(this.label3);
            this.gpCadastroContato.Controls.Add(this.label2);
            this.gpCadastroContato.Controls.Add(this.label1);
            this.gpCadastroContato.ForeColor = System.Drawing.SystemColors.Control;
            this.gpCadastroContato.Location = new System.Drawing.Point(12, 27);
            this.gpCadastroContato.Name = "gpCadastroContato";
            this.gpCadastroContato.Size = new System.Drawing.Size(456, 178);
            this.gpCadastroContato.TabIndex = 0;
            this.gpCadastroContato.TabStop = false;
            this.gpCadastroContato.Text = "Cadastro de Contato";
            // 
            // cboUF
            // 
            this.cboUF.FormattingEnabled = true;
            this.cboUF.Location = new System.Drawing.Point(388, 144);
            this.cboUF.Name = "cboUF";
            this.cboUF.Size = new System.Drawing.Size(56, 21);
            this.cboUF.TabIndex = 9;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(61, 143);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(221, 20);
            this.txtCidade.TabIndex = 8;
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(61, 113);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(117, 20);
            this.txtBairro.TabIndex = 7;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(252, 86);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(30, 20);
            this.txtNumero.TabIndex = 6;
            // 
            // txtRua
            // 
            this.txtRua.Location = new System.Drawing.Point(61, 84);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(154, 20);
            this.txtRua.TabIndex = 5;
            // 
            // txtRedeSocial
            // 
            this.txtRedeSocial.Location = new System.Drawing.Point(307, 54);
            this.txtRedeSocial.Name = "txtRedeSocial";
            this.txtRedeSocial.Size = new System.Drawing.Size(139, 20);
            this.txtRedeSocial.TabIndex = 4;
            // 
            // mskTelefone
            // 
            this.mskTelefone.Location = new System.Drawing.Point(356, 24);
            this.mskTelefone.Mask = "(00) 00000-0000";
            this.mskTelefone.Name = "mskTelefone";
            this.mskTelefone.Size = new System.Drawing.Size(90, 20);
            this.mskTelefone.TabIndex = 2;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(61, 54);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(154, 20);
            this.txtEmail.TabIndex = 3;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(61, 25);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(221, 20);
            this.txtNome.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.Control;
            this.label12.Location = new System.Drawing.Point(9, 144);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 18);
            this.label12.TabIndex = 8;
            this.label12.Text = "Cidade";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(10, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 18);
            this.label8.TabIndex = 7;
            this.label8.Text = "Bairro";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(225, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "Nº";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(23, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Rua";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(336, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Estado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(225, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Rede Social";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(15, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(288, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Telefone";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(14, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(854, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // gpCadastroCompromisso
            // 
            this.gpCadastroCompromisso.BackColor = System.Drawing.SystemColors.Highlight;
            this.gpCadastroCompromisso.Controls.Add(this.txtStatus);
            this.gpCadastroCompromisso.Controls.Add(this.cboDiaSemana);
            this.gpCadastroCompromisso.Controls.Add(this.txtTitulo);
            this.gpCadastroCompromisso.Controls.Add(this.dtpDataCompromisso);
            this.gpCadastroCompromisso.Controls.Add(this.label13);
            this.gpCadastroCompromisso.Controls.Add(this.label11);
            this.gpCadastroCompromisso.Controls.Add(this.label10);
            this.gpCadastroCompromisso.Controls.Add(this.label9);
            this.gpCadastroCompromisso.ForeColor = System.Drawing.SystemColors.Control;
            this.gpCadastroCompromisso.Location = new System.Drawing.Point(474, 27);
            this.gpCadastroCompromisso.Name = "gpCadastroCompromisso";
            this.gpCadastroCompromisso.Size = new System.Drawing.Size(367, 106);
            this.gpCadastroCompromisso.TabIndex = 1;
            this.gpCadastroCompromisso.TabStop = false;
            this.gpCadastroCompromisso.Text = "Cadastro de Compromisso";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(268, 29);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(54, 20);
            this.txtStatus.TabIndex = 11;
            // 
            // cboDiaSemana
            // 
            this.cboDiaSemana.FormattingEnabled = true;
            this.cboDiaSemana.Location = new System.Drawing.Point(120, 63);
            this.cboDiaSemana.Name = "cboDiaSemana";
            this.cboDiaSemana.Size = new System.Drawing.Size(95, 21);
            this.cboDiaSemana.TabIndex = 12;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(63, 28);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(152, 20);
            this.txtTitulo.TabIndex = 10;
            // 
            // dtpDataCompromisso
            // 
            this.dtpDataCompromisso.Location = new System.Drawing.Point(268, 65);
            this.dtpDataCompromisso.Name = "dtpDataCompromisso";
            this.dtpDataCompromisso.Size = new System.Drawing.Size(89, 20);
            this.dtpDataCompromisso.TabIndex = 13;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.Control;
            this.label13.Location = new System.Drawing.Point(217, 30);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 18);
            this.label13.TabIndex = 9;
            this.label13.Text = "Status";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.Control;
            this.label11.Location = new System.Drawing.Point(225, 65);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 18);
            this.label11.TabIndex = 7;
            this.label11.Text = "Data";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(14, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 18);
            this.label10.TabIndex = 6;
            this.label10.Text = "Dia da Semana";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(13, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 18);
            this.label9.TabIndex = 5;
            this.label9.Text = "Título";
            // 
            // dgvContatos
            // 
            this.dgvContatos.AllowUserToAddRows = false;
            this.dgvContatos.AllowUserToOrderColumns = true;
            this.dgvContatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContatos.Location = new System.Drawing.Point(12, 226);
            this.dgvContatos.Name = "dgvContatos";
            this.dgvContatos.ReadOnly = true;
            this.dgvContatos.Size = new System.Drawing.Size(456, 209);
            this.dgvContatos.TabIndex = 2;
            this.dgvContatos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvContatos_CellDoubleClick);
            // 
            // dgvCompromissos
            // 
            this.dgvCompromissos.AllowUserToAddRows = false;
            this.dgvCompromissos.AllowUserToOrderColumns = true;
            this.dgvCompromissos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompromissos.Location = new System.Drawing.Point(474, 226);
            this.dgvCompromissos.Name = "dgvCompromissos";
            this.dgvCompromissos.ReadOnly = true;
            this.dgvCompromissos.Size = new System.Drawing.Size(368, 209);
            this.dgvCompromissos.TabIndex = 5;
            // 
            // btnClean
            // 
            this.btnClean.BackgroundImage = global::ProjetoDevs2Blu.SistemaAgendaContatos.Properties.Resources.clear;
            this.btnClean.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClean.FlatAppearance.BorderSize = 0;
            this.btnClean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClean.Location = new System.Drawing.Point(644, 154);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(56, 50);
            this.btnClean.TabIndex = 16;
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            this.btnClean.MouseHover += new System.EventHandler(this.btnClean_MouseHover);
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = global::ProjetoDevs2Blu.SistemaAgendaContatos.Properties.Resources.Delete;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(718, 154);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(45, 50);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            this.btnDelete.MouseHover += new System.EventHandler(this.btnDelete_MouseHover);
            // 
            // btnInfo
            // 
            this.btnInfo.BackgroundImage = global::ProjetoDevs2Blu.SistemaAgendaContatos.Properties.Resources.Info2;
            this.btnInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInfo.FlatAppearance.BorderSize = 0;
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo.Location = new System.Drawing.Point(783, 154);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(56, 49);
            this.btnInfo.TabIndex = 18;
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            this.btnInfo.MouseHover += new System.EventHandler(this.btnInfo_MouseHover);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackgroundImage = global::ProjetoDevs2Blu.SistemaAgendaContatos.Properties.Resources.Update;
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Location = new System.Drawing.Point(564, 154);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(56, 50);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            this.btnUpdate.MouseHover += new System.EventHandler(this.btnUpdate_MouseHover);
            // 
            // btnInsert
            // 
            this.btnInsert.BackgroundImage = global::ProjetoDevs2Blu.SistemaAgendaContatos.Properties.Resources.Insert;
            this.btnInsert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInsert.FlatAppearance.BorderSize = 0;
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.ForeColor = System.Drawing.SystemColors.Control;
            this.btnInsert.Location = new System.Drawing.Point(480, 153);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(56, 50);
            this.btnInsert.TabIndex = 14;
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            this.btnInsert.MouseHover += new System.EventHandler(this.btnInsert_MouseHover);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 450);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dgvCompromissos);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.dgvContatos);
            this.Controls.Add(this.gpCadastroCompromisso);
            this.Controls.Add(this.gpCadastroContato);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Sistema de Agenda";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.gpCadastroContato.ResumeLayout(false);
            this.gpCadastroContato.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gpCadastroCompromisso.ResumeLayout(false);
            this.gpCadastroCompromisso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompromissos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpCadastroContato;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox gpCadastroCompromisso;
        private System.Windows.Forms.DataGridView dgvContatos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.MaskedTextBox mskTelefone;
        private System.Windows.Forms.TextBox txtRedeSocial;
        private System.Windows.Forms.DateTimePicker dtpDataCompromisso;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.ComboBox cboUF;
        private System.Windows.Forms.DataGridView dgvCompromissos;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.ComboBox cboDiaSemana;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

