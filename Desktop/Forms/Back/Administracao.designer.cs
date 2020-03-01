namespace Desktop_app
{
    partial class Administracao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        System.ComponentModel.IContainer components = null;

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
        void InitializeComponent()
        {
            this.Body = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_funcionarios = new System.Windows.Forms.TabPage();
            this.funcionarios_container = new System.Windows.Forms.Panel();
            this.funcionarios_content = new System.Windows.Forms.Panel();
            this.lbl_naoHaFuncionarios = new System.Windows.Forms.Label();
            this.dgv_funcionarios = new System.Windows.Forms.DataGridView();
            this.funcionarios_navbar = new System.Windows.Forms.Panel();
            this.funcionarios_search = new System.Windows.Forms.TextBox();
            this.btn_novoFuncionario = new System.Windows.Forms.Button();
            this.tab_estabelecimento = new System.Windows.Forms.TabPage();
            this.editor = new System.Windows.Forms.Panel();
            this.cnpj_label = new System.Windows.Forms.Label();
            this.cnpj_input = new System.Windows.Forms.MaskedTextBox();
            this.razao_social_label = new System.Windows.Forms.Label();
            this.razao_social_input = new System.Windows.Forms.TextBox();
            this.nome_fantasia_label = new System.Windows.Forms.Label();
            this.nome_fantasia_input = new System.Windows.Forms.TextBox();
            this.logradouro_label = new System.Windows.Forms.Label();
            this.logradouro_input = new System.Windows.Forms.TextBox();
            this.numero_label = new System.Windows.Forms.Label();
            this.numero_input = new System.Windows.Forms.TextBox();
            this.complemento_label = new System.Windows.Forms.Label();
            this.complemento_input = new System.Windows.Forms.TextBox();
            this.cep_label = new System.Windows.Forms.Label();
            this.cep_input = new System.Windows.Forms.MaskedTextBox();
            this.bairro_label = new System.Windows.Forms.Label();
            this.bairro_input = new System.Windows.Forms.TextBox();
            this.cidade_label = new System.Windows.Forms.Label();
            this.cidade_input = new System.Windows.Forms.TextBox();
            this.uf_label = new System.Windows.Forms.Label();
            this.uf_input = new System.Windows.Forms.ComboBox();
            this.email_label = new System.Windows.Forms.Label();
            this.email_input = new System.Windows.Forms.TextBox();
            this.telefone_label = new System.Windows.Forms.Label();
            this.telefone_input = new System.Windows.Forms.MaskedTextBox();
            this.celular_label = new System.Windows.Forms.Label();
            this.celular_input = new System.Windows.Forms.MaskedTextBox();
            this.abertura_label = new System.Windows.Forms.Label();
            this.abertura_input = new System.Windows.Forms.ComboBox();
            this.fechamento_label = new System.Windows.Forms.Label();
            this.fechamento_input = new System.Windows.Forms.ComboBox();
            this.atendimento_label = new System.Windows.Forms.Label();
            this.atendimento_input = new System.Windows.Forms.ComboBox();
            this.submit = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.habilitar_edicao = new System.Windows.Forms.CheckBox();
            this.tab_cargos_especialidades = new System.Windows.Forms.TabPage();
            this.cargoEspecialidade_padrao = new System.Windows.Forms.Panel();
            this.btn_cargoEspecialidade_padrao = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cargo_default = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.especialidade_default = new System.Windows.Forms.ComboBox();
            this.especialidades_tp = new System.Windows.Forms.Panel();
            this.boxEspecialidades = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.especialidades_tp_criador = new System.Windows.Forms.Panel();
            this.especialidade_input = new System.Windows.Forms.TextBox();
            this.especialidade_submit = new System.Windows.Forms.Button();
            this.cargos_tp = new System.Windows.Forms.Panel();
            this.boxCargos = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cargos_tp_criador = new System.Windows.Forms.Panel();
            this.cargo_input = new System.Windows.Forms.TextBox();
            this.cargo_submit = new System.Windows.Forms.Button();
            this.Header = new System.Windows.Forms.Panel();
            this.btn_sair = new System.Windows.Forms.Button();
            this.subtitulo = new System.Windows.Forms.Label();
            this.titulo = new System.Windows.Forms.Label();
            this.Body.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tab_funcionarios.SuspendLayout();
            this.funcionarios_container.SuspendLayout();
            this.funcionarios_content.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_funcionarios)).BeginInit();
            this.funcionarios_navbar.SuspendLayout();
            this.tab_estabelecimento.SuspendLayout();
            this.editor.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tab_cargos_especialidades.SuspendLayout();
            this.cargoEspecialidade_padrao.SuspendLayout();
            this.especialidades_tp.SuspendLayout();
            this.especialidades_tp_criador.SuspendLayout();
            this.cargos_tp.SuspendLayout();
            this.cargos_tp_criador.SuspendLayout();
            this.Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // Body
            // 
            this.Body.BackColor = System.Drawing.SystemColors.Control;
            this.Body.Controls.Add(this.tabControl1);
            this.Body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Body.Location = new System.Drawing.Point(0, 120);
            this.Body.Margin = new System.Windows.Forms.Padding(0);
            this.Body.Name = "Body";
            this.Body.Padding = new System.Windows.Forms.Padding(10);
            this.Body.Size = new System.Drawing.Size(884, 555);
            this.Body.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_funcionarios);
            this.tabControl1.Controls.Add(this.tab_estabelecimento);
            this.tabControl1.Controls.Add(this.tab_cargos_especialidades);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.HotTrack = true;
            this.tabControl1.Location = new System.Drawing.Point(10, 10);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(40, 10);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(864, 535);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.TabStop = false;
            // 
            // tab_funcionarios
            // 
            this.tab_funcionarios.AutoScroll = true;
            this.tab_funcionarios.Controls.Add(this.funcionarios_container);
            this.tab_funcionarios.Location = new System.Drawing.Point(4, 44);
            this.tab_funcionarios.Name = "tab_funcionarios";
            this.tab_funcionarios.Padding = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.tab_funcionarios.Size = new System.Drawing.Size(856, 487);
            this.tab_funcionarios.TabIndex = 2;
            this.tab_funcionarios.Text = "Funcionários";
            this.tab_funcionarios.UseVisualStyleBackColor = true;
            // 
            // funcionarios_container
            // 
            this.funcionarios_container.Controls.Add(this.funcionarios_content);
            this.funcionarios_container.Controls.Add(this.funcionarios_navbar);
            this.funcionarios_container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.funcionarios_container.Location = new System.Drawing.Point(10, 0);
            this.funcionarios_container.Name = "funcionarios_container";
            this.funcionarios_container.Size = new System.Drawing.Size(836, 477);
            this.funcionarios_container.TabIndex = 1;
            // 
            // funcionarios_content
            // 
            this.funcionarios_content.BackColor = System.Drawing.Color.LightGray;
            this.funcionarios_content.Controls.Add(this.lbl_naoHaFuncionarios);
            this.funcionarios_content.Controls.Add(this.dgv_funcionarios);
            this.funcionarios_content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.funcionarios_content.Location = new System.Drawing.Point(0, 70);
            this.funcionarios_content.Name = "funcionarios_content";
            this.funcionarios_content.Padding = new System.Windows.Forms.Padding(1);
            this.funcionarios_content.Size = new System.Drawing.Size(836, 407);
            this.funcionarios_content.TabIndex = 1;
            // 
            // lbl_naoHaFuncionarios
            // 
            this.lbl_naoHaFuncionarios.BackColor = System.Drawing.Color.White;
            this.lbl_naoHaFuncionarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_naoHaFuncionarios.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_naoHaFuncionarios.ForeColor = System.Drawing.Color.Silver;
            this.lbl_naoHaFuncionarios.Location = new System.Drawing.Point(1, 1);
            this.lbl_naoHaFuncionarios.Name = "lbl_naoHaFuncionarios";
            this.lbl_naoHaFuncionarios.Padding = new System.Windows.Forms.Padding(0, 40, 0, 0);
            this.lbl_naoHaFuncionarios.Size = new System.Drawing.Size(834, 405);
            this.lbl_naoHaFuncionarios.TabIndex = 2;
            this.lbl_naoHaFuncionarios.Text = "Não há resultados para exibir";
            this.lbl_naoHaFuncionarios.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgv_funcionarios
            // 
            this.dgv_funcionarios.AllowUserToAddRows = false;
            this.dgv_funcionarios.AllowUserToDeleteRows = false;
            this.dgv_funcionarios.AllowUserToResizeColumns = false;
            this.dgv_funcionarios.AllowUserToResizeRows = false;
            this.dgv_funcionarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_funcionarios.BackgroundColor = System.Drawing.Color.White;
            this.dgv_funcionarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_funcionarios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_funcionarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_funcionarios.ColumnHeadersHeight = 39;
            this.dgv_funcionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_funcionarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_funcionarios.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_funcionarios.EnableHeadersVisualStyles = false;
            this.dgv_funcionarios.GridColor = System.Drawing.Color.White;
            this.dgv_funcionarios.Location = new System.Drawing.Point(1, 1);
            this.dgv_funcionarios.Margin = new System.Windows.Forms.Padding(0);
            this.dgv_funcionarios.MultiSelect = false;
            this.dgv_funcionarios.Name = "dgv_funcionarios";
            this.dgv_funcionarios.ReadOnly = true;
            this.dgv_funcionarios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_funcionarios.RowHeadersVisible = false;
            this.dgv_funcionarios.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_funcionarios.RowTemplate.Height = 39;
            this.dgv_funcionarios.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_funcionarios.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv_funcionarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_funcionarios.Size = new System.Drawing.Size(834, 405);
            this.dgv_funcionarios.StandardTab = true;
            this.dgv_funcionarios.TabIndex = 0;
            this.dgv_funcionarios.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Funcionario_editar);
            // 
            // funcionarios_navbar
            // 
            this.funcionarios_navbar.Controls.Add(this.funcionarios_search);
            this.funcionarios_navbar.Controls.Add(this.btn_novoFuncionario);
            this.funcionarios_navbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.funcionarios_navbar.Location = new System.Drawing.Point(0, 0);
            this.funcionarios_navbar.Name = "funcionarios_navbar";
            this.funcionarios_navbar.Padding = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.funcionarios_navbar.Size = new System.Drawing.Size(836, 70);
            this.funcionarios_navbar.TabIndex = 0;
            // 
            // funcionarios_search
            // 
            this.funcionarios_search.Dock = System.Windows.Forms.DockStyle.Left;
            this.funcionarios_search.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.funcionarios_search.Location = new System.Drawing.Point(0, 20);
            this.funcionarios_search.Margin = new System.Windows.Forms.Padding(15, 5, 0, 30);
            this.funcionarios_search.MaxLength = 40;
            this.funcionarios_search.Name = "funcionarios_search";
            this.funcionarios_search.Size = new System.Drawing.Size(375, 33);
            this.funcionarios_search.TabIndex = 4;
            this.funcionarios_search.TabStop = false;
            this.funcionarios_search.TextChanged += new System.EventHandler(this.Preencher_dgv_funcionarios);
            // 
            // btn_novoFuncionario
            // 
            this.btn_novoFuncionario.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_novoFuncionario.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_novoFuncionario.Location = new System.Drawing.Point(650, 20);
            this.btn_novoFuncionario.Name = "btn_novoFuncionario";
            this.btn_novoFuncionario.Size = new System.Drawing.Size(186, 30);
            this.btn_novoFuncionario.TabIndex = 2;
            this.btn_novoFuncionario.TabStop = false;
            this.btn_novoFuncionario.Text = "Cadastrar funcionário";
            this.btn_novoFuncionario.UseVisualStyleBackColor = true;
            this.btn_novoFuncionario.Visible = false;
            this.btn_novoFuncionario.Click += new System.EventHandler(this.Funcionario_inserir);
            // 
            // tab_estabelecimento
            // 
            this.tab_estabelecimento.AutoScroll = true;
            this.tab_estabelecimento.Controls.Add(this.editor);
            this.tab_estabelecimento.Controls.Add(this.panel4);
            this.tab_estabelecimento.Location = new System.Drawing.Point(4, 44);
            this.tab_estabelecimento.Name = "tab_estabelecimento";
            this.tab_estabelecimento.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.tab_estabelecimento.Size = new System.Drawing.Size(856, 487);
            this.tab_estabelecimento.TabIndex = 1;
            this.tab_estabelecimento.Text = "Estabelecimento";
            this.tab_estabelecimento.UseVisualStyleBackColor = true;
            // 
            // editor
            // 
            this.editor.AutoScroll = true;
            this.editor.Controls.Add(this.cnpj_label);
            this.editor.Controls.Add(this.cnpj_input);
            this.editor.Controls.Add(this.razao_social_label);
            this.editor.Controls.Add(this.razao_social_input);
            this.editor.Controls.Add(this.nome_fantasia_label);
            this.editor.Controls.Add(this.nome_fantasia_input);
            this.editor.Controls.Add(this.logradouro_label);
            this.editor.Controls.Add(this.logradouro_input);
            this.editor.Controls.Add(this.numero_label);
            this.editor.Controls.Add(this.numero_input);
            this.editor.Controls.Add(this.complemento_label);
            this.editor.Controls.Add(this.complemento_input);
            this.editor.Controls.Add(this.cep_label);
            this.editor.Controls.Add(this.cep_input);
            this.editor.Controls.Add(this.bairro_label);
            this.editor.Controls.Add(this.bairro_input);
            this.editor.Controls.Add(this.cidade_label);
            this.editor.Controls.Add(this.cidade_input);
            this.editor.Controls.Add(this.uf_label);
            this.editor.Controls.Add(this.uf_input);
            this.editor.Controls.Add(this.email_label);
            this.editor.Controls.Add(this.email_input);
            this.editor.Controls.Add(this.telefone_label);
            this.editor.Controls.Add(this.telefone_input);
            this.editor.Controls.Add(this.celular_label);
            this.editor.Controls.Add(this.celular_input);
            this.editor.Controls.Add(this.abertura_label);
            this.editor.Controls.Add(this.abertura_input);
            this.editor.Controls.Add(this.fechamento_label);
            this.editor.Controls.Add(this.fechamento_input);
            this.editor.Controls.Add(this.atendimento_label);
            this.editor.Controls.Add(this.atendimento_input);
            this.editor.Controls.Add(this.submit);
            this.editor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editor.Enabled = false;
            this.editor.Location = new System.Drawing.Point(0, 53);
            this.editor.Name = "editor";
            this.editor.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.editor.Size = new System.Drawing.Size(856, 424);
            this.editor.TabIndex = 1;
            // 
            // cnpj_label
            // 
            this.cnpj_label.AutoSize = true;
            this.cnpj_label.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.cnpj_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cnpj_label.Location = new System.Drawing.Point(10, 7);
            this.cnpj_label.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.cnpj_label.Name = "cnpj_label";
            this.cnpj_label.Size = new System.Drawing.Size(46, 20);
            this.cnpj_label.TabIndex = 0;
            this.cnpj_label.Text = "CNPJ";
            // 
            // cnpj_input
            // 
            this.cnpj_input.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.cnpj_input.Location = new System.Drawing.Point(10, 32);
            this.cnpj_input.Margin = new System.Windows.Forms.Padding(15, 5, 0, 30);
            this.cnpj_input.Mask = "00\\.000\\.000\\/0000\\-00";
            this.cnpj_input.Name = "cnpj_input";
            this.cnpj_input.Size = new System.Drawing.Size(166, 33);
            this.cnpj_input.TabIndex = 1;
            // 
            // razao_social_label
            // 
            this.razao_social_label.AutoSize = true;
            this.razao_social_label.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.razao_social_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.razao_social_label.Location = new System.Drawing.Point(192, 7);
            this.razao_social_label.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.razao_social_label.Name = "razao_social_label";
            this.razao_social_label.Size = new System.Drawing.Size(95, 20);
            this.razao_social_label.TabIndex = 2;
            this.razao_social_label.Text = "Razão Social";
            // 
            // razao_social_input
            // 
            this.razao_social_input.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.razao_social_input.Location = new System.Drawing.Point(192, 32);
            this.razao_social_input.Margin = new System.Windows.Forms.Padding(15, 5, 0, 30);
            this.razao_social_input.MaxLength = 40;
            this.razao_social_input.Name = "razao_social_input";
            this.razao_social_input.Size = new System.Drawing.Size(292, 33);
            this.razao_social_input.TabIndex = 3;
            // 
            // nome_fantasia_label
            // 
            this.nome_fantasia_label.AutoSize = true;
            this.nome_fantasia_label.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.nome_fantasia_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.nome_fantasia_label.Location = new System.Drawing.Point(499, 7);
            this.nome_fantasia_label.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.nome_fantasia_label.Name = "nome_fantasia_label";
            this.nome_fantasia_label.Size = new System.Drawing.Size(114, 20);
            this.nome_fantasia_label.TabIndex = 4;
            this.nome_fantasia_label.Text = "Nome Fantasia";
            // 
            // nome_fantasia_input
            // 
            this.nome_fantasia_input.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.nome_fantasia_input.Location = new System.Drawing.Point(499, 32);
            this.nome_fantasia_input.Margin = new System.Windows.Forms.Padding(15, 5, 0, 30);
            this.nome_fantasia_input.MaxLength = 40;
            this.nome_fantasia_input.Name = "nome_fantasia_input";
            this.nome_fantasia_input.Size = new System.Drawing.Size(323, 33);
            this.nome_fantasia_input.TabIndex = 5;
            // 
            // logradouro_label
            // 
            this.logradouro_label.AutoSize = true;
            this.logradouro_label.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.logradouro_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.logradouro_label.Location = new System.Drawing.Point(499, 95);
            this.logradouro_label.Margin = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.logradouro_label.Name = "logradouro_label";
            this.logradouro_label.Size = new System.Drawing.Size(91, 20);
            this.logradouro_label.TabIndex = 12;
            this.logradouro_label.Text = "Logradouro";
            // 
            // logradouro_input
            // 
            this.logradouro_input.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.logradouro_input.Location = new System.Drawing.Point(499, 120);
            this.logradouro_input.Margin = new System.Windows.Forms.Padding(15, 5, 0, 30);
            this.logradouro_input.MaxLength = 40;
            this.logradouro_input.Name = "logradouro_input";
            this.logradouro_input.Size = new System.Drawing.Size(323, 33);
            this.logradouro_input.TabIndex = 13;
            // 
            // numero_label
            // 
            this.numero_label.AutoSize = true;
            this.numero_label.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.numero_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.numero_label.Location = new System.Drawing.Point(165, 95);
            this.numero_label.Margin = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.numero_label.Name = "numero_label";
            this.numero_label.Size = new System.Drawing.Size(46, 20);
            this.numero_label.TabIndex = 8;
            this.numero_label.Text = "NRO.";
            // 
            // numero_input
            // 
            this.numero_input.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.numero_input.Location = new System.Drawing.Point(169, 120);
            this.numero_input.Margin = new System.Windows.Forms.Padding(15, 5, 0, 30);
            this.numero_input.MaxLength = 6;
            this.numero_input.Name = "numero_input";
            this.numero_input.Size = new System.Drawing.Size(79, 33);
            this.numero_input.TabIndex = 9;
            // 
            // complemento_label
            // 
            this.complemento_label.AutoSize = true;
            this.complemento_label.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.complemento_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.complemento_label.Location = new System.Drawing.Point(263, 95);
            this.complemento_label.Margin = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.complemento_label.Name = "complemento_label";
            this.complemento_label.Size = new System.Drawing.Size(108, 20);
            this.complemento_label.TabIndex = 10;
            this.complemento_label.Text = "Complemento";
            // 
            // complemento_input
            // 
            this.complemento_input.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.complemento_input.Location = new System.Drawing.Point(263, 120);
            this.complemento_input.Margin = new System.Windows.Forms.Padding(15, 5, 0, 30);
            this.complemento_input.MaxLength = 40;
            this.complemento_input.Name = "complemento_input";
            this.complemento_input.Size = new System.Drawing.Size(221, 33);
            this.complemento_input.TabIndex = 11;
            // 
            // cep_label
            // 
            this.cep_label.AutoSize = true;
            this.cep_label.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.cep_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cep_label.Location = new System.Drawing.Point(10, 95);
            this.cep_label.Margin = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.cep_label.Name = "cep_label";
            this.cep_label.Size = new System.Drawing.Size(35, 20);
            this.cep_label.TabIndex = 6;
            this.cep_label.Text = "CEP";
            // 
            // cep_input
            // 
            this.cep_input.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.cep_input.Location = new System.Drawing.Point(10, 120);
            this.cep_input.Margin = new System.Windows.Forms.Padding(15, 5, 0, 30);
            this.cep_input.Mask = "00\\.000\\-000";
            this.cep_input.Name = "cep_input";
            this.cep_input.Size = new System.Drawing.Size(144, 33);
            this.cep_input.TabIndex = 7;
            // 
            // bairro_label
            // 
            this.bairro_label.AutoSize = true;
            this.bairro_label.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.bairro_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bairro_label.Location = new System.Drawing.Point(10, 183);
            this.bairro_label.Margin = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.bairro_label.Name = "bairro_label";
            this.bairro_label.Size = new System.Drawing.Size(52, 20);
            this.bairro_label.TabIndex = 14;
            this.bairro_label.Text = "Bairro";
            // 
            // bairro_input
            // 
            this.bairro_input.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.bairro_input.Location = new System.Drawing.Point(10, 208);
            this.bairro_input.Margin = new System.Windows.Forms.Padding(15, 5, 0, 30);
            this.bairro_input.MaxLength = 40;
            this.bairro_input.Name = "bairro_input";
            this.bairro_input.Size = new System.Drawing.Size(360, 33);
            this.bairro_input.TabIndex = 15;
            // 
            // cidade_label
            // 
            this.cidade_label.AutoSize = true;
            this.cidade_label.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.cidade_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cidade_label.Location = new System.Drawing.Point(385, 183);
            this.cidade_label.Margin = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.cidade_label.Name = "cidade_label";
            this.cidade_label.Size = new System.Drawing.Size(56, 20);
            this.cidade_label.TabIndex = 16;
            this.cidade_label.Text = "Cidade";
            // 
            // cidade_input
            // 
            this.cidade_input.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.cidade_input.Location = new System.Drawing.Point(385, 208);
            this.cidade_input.Margin = new System.Windows.Forms.Padding(15, 5, 0, 30);
            this.cidade_input.MaxLength = 40;
            this.cidade_input.Name = "cidade_input";
            this.cidade_input.Size = new System.Drawing.Size(333, 33);
            this.cidade_input.TabIndex = 17;
            // 
            // uf_label
            // 
            this.uf_label.AutoSize = true;
            this.uf_label.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.uf_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uf_label.Location = new System.Drawing.Point(733, 183);
            this.uf_label.Margin = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.uf_label.Name = "uf_label";
            this.uf_label.Size = new System.Drawing.Size(28, 20);
            this.uf_label.TabIndex = 18;
            this.uf_label.Text = "UF";
            // 
            // uf_input
            // 
            this.uf_input.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.uf_input.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.uf_input.DropDownHeight = 80;
            this.uf_input.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uf_input.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.uf_input.FormattingEnabled = true;
            this.uf_input.IntegralHeight = false;
            this.uf_input.Location = new System.Drawing.Point(733, 208);
            this.uf_input.Margin = new System.Windows.Forms.Padding(15, 5, 0, 30);
            this.uf_input.Name = "uf_input";
            this.uf_input.Size = new System.Drawing.Size(89, 33);
            this.uf_input.TabIndex = 19;
            // 
            // email_label
            // 
            this.email_label.AutoSize = true;
            this.email_label.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.email_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.email_label.Location = new System.Drawing.Point(10, 271);
            this.email_label.Margin = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.email_label.Name = "email_label";
            this.email_label.Size = new System.Drawing.Size(53, 20);
            this.email_label.TabIndex = 20;
            this.email_label.Text = "E-mail";
            // 
            // email_input
            // 
            this.email_input.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.email_input.Location = new System.Drawing.Point(10, 296);
            this.email_input.Margin = new System.Windows.Forms.Padding(15, 5, 0, 30);
            this.email_input.MaxLength = 40;
            this.email_input.Name = "email_input";
            this.email_input.Size = new System.Drawing.Size(361, 33);
            this.email_input.TabIndex = 21;
            // 
            // telefone_label
            // 
            this.telefone_label.AutoSize = true;
            this.telefone_label.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.telefone_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.telefone_label.Location = new System.Drawing.Point(385, 271);
            this.telefone_label.Margin = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.telefone_label.Name = "telefone_label";
            this.telefone_label.Size = new System.Drawing.Size(70, 20);
            this.telefone_label.TabIndex = 22;
            this.telefone_label.Text = "Telefone";
            // 
            // telefone_input
            // 
            this.telefone_input.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.telefone_input.Location = new System.Drawing.Point(385, 296);
            this.telefone_input.Margin = new System.Windows.Forms.Padding(15, 5, 0, 30);
            this.telefone_input.Mask = "\\(00\\)0000\\-0000";
            this.telefone_input.Name = "telefone_input";
            this.telefone_input.Size = new System.Drawing.Size(168, 33);
            this.telefone_input.TabIndex = 23;
            // 
            // celular_label
            // 
            this.celular_label.AutoSize = true;
            this.celular_label.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.celular_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.celular_label.Location = new System.Drawing.Point(564, 271);
            this.celular_label.Margin = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.celular_label.Name = "celular_label";
            this.celular_label.Size = new System.Drawing.Size(57, 20);
            this.celular_label.TabIndex = 24;
            this.celular_label.Text = "Celular";
            // 
            // celular_input
            // 
            this.celular_input.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.celular_input.Location = new System.Drawing.Point(568, 296);
            this.celular_input.Margin = new System.Windows.Forms.Padding(15, 5, 0, 30);
            this.celular_input.Mask = "\\(00\\)\\90000\\-0000";
            this.celular_input.Name = "celular_input";
            this.celular_input.Size = new System.Drawing.Size(150, 33);
            this.celular_input.TabIndex = 25;
            // 
            // abertura_label
            // 
            this.abertura_label.AutoSize = true;
            this.abertura_label.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.abertura_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.abertura_label.Location = new System.Drawing.Point(10, 359);
            this.abertura_label.Margin = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.abertura_label.Name = "abertura_label";
            this.abertura_label.Size = new System.Drawing.Size(72, 20);
            this.abertura_label.TabIndex = 26;
            this.abertura_label.Text = "Abertura";
            // 
            // abertura_input
            // 
            this.abertura_input.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.abertura_input.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.abertura_input.DropDownHeight = 80;
            this.abertura_input.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.abertura_input.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.abertura_input.FormatString = "t";
            this.abertura_input.FormattingEnabled = true;
            this.abertura_input.IntegralHeight = false;
            this.abertura_input.Location = new System.Drawing.Point(10, 384);
            this.abertura_input.Margin = new System.Windows.Forms.Padding(15, 5, 0, 30);
            this.abertura_input.Name = "abertura_input";
            this.abertura_input.Size = new System.Drawing.Size(168, 33);
            this.abertura_input.TabIndex = 27;
            // 
            // fechamento_label
            // 
            this.fechamento_label.AutoSize = true;
            this.fechamento_label.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.fechamento_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fechamento_label.Location = new System.Drawing.Point(193, 359);
            this.fechamento_label.Margin = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.fechamento_label.Name = "fechamento_label";
            this.fechamento_label.Size = new System.Drawing.Size(95, 20);
            this.fechamento_label.TabIndex = 28;
            this.fechamento_label.Text = "Fechamento";
            // 
            // fechamento_input
            // 
            this.fechamento_input.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.fechamento_input.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.fechamento_input.DropDownHeight = 80;
            this.fechamento_input.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fechamento_input.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.fechamento_input.FormatString = "t";
            this.fechamento_input.FormattingEnabled = true;
            this.fechamento_input.IntegralHeight = false;
            this.fechamento_input.Location = new System.Drawing.Point(193, 384);
            this.fechamento_input.Margin = new System.Windows.Forms.Padding(15, 5, 0, 30);
            this.fechamento_input.Name = "fechamento_input";
            this.fechamento_input.Size = new System.Drawing.Size(178, 33);
            this.fechamento_input.TabIndex = 29;
            // 
            // atendimento_label
            // 
            this.atendimento_label.AutoSize = true;
            this.atendimento_label.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.atendimento_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.atendimento_label.Location = new System.Drawing.Point(385, 359);
            this.atendimento_label.Margin = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.atendimento_label.Name = "atendimento_label";
            this.atendimento_label.Size = new System.Drawing.Size(102, 20);
            this.atendimento_label.TabIndex = 30;
            this.atendimento_label.Text = "Atendimento";
            // 
            // atendimento_input
            // 
            this.atendimento_input.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.atendimento_input.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.atendimento_input.DropDownHeight = 80;
            this.atendimento_input.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.atendimento_input.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.atendimento_input.FormattingEnabled = true;
            this.atendimento_input.IntegralHeight = false;
            this.atendimento_input.Items.AddRange(new object[] {
            "10",
            "20",
            "30"});
            this.atendimento_input.Location = new System.Drawing.Point(385, 384);
            this.atendimento_input.Margin = new System.Windows.Forms.Padding(15, 5, 15, 30);
            this.atendimento_input.Name = "atendimento_input";
            this.atendimento_input.Size = new System.Drawing.Size(168, 33);
            this.atendimento_input.TabIndex = 31;
            // 
            // submit
            // 
            this.submit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.submit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.submit.FlatAppearance.BorderSize = 0;
            this.submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit.ForeColor = System.Drawing.Color.White;
            this.submit.Location = new System.Drawing.Point(568, 384);
            this.submit.Margin = new System.Windows.Forms.Padding(15, 5, 15, 5);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(150, 33);
            this.submit.TabIndex = 32;
            this.submit.Text = "Definir";
            this.submit.UseVisualStyleBackColor = false;
            this.submit.Click += new System.EventHandler(this.Submit_estabelecimento);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.habilitar_edicao);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(10, 10, 0, 10);
            this.panel4.Size = new System.Drawing.Size(856, 53);
            this.panel4.TabIndex = 0;
            // 
            // habilitar_edicao
            // 
            this.habilitar_edicao.AutoSize = true;
            this.habilitar_edicao.Dock = System.Windows.Forms.DockStyle.Left;
            this.habilitar_edicao.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.habilitar_edicao.Location = new System.Drawing.Point(10, 10);
            this.habilitar_edicao.Name = "habilitar_edicao";
            this.habilitar_edicao.Size = new System.Drawing.Size(137, 33);
            this.habilitar_edicao.TabIndex = 0;
            this.habilitar_edicao.Text = "Habilitar edição";
            this.habilitar_edicao.UseVisualStyleBackColor = true;
            this.habilitar_edicao.CheckedChanged += new System.EventHandler(this.Habilitar_edicao);
            // 
            // tab_cargos_especialidades
            // 
            this.tab_cargos_especialidades.AutoScroll = true;
            this.tab_cargos_especialidades.Controls.Add(this.cargoEspecialidade_padrao);
            this.tab_cargos_especialidades.Controls.Add(this.especialidades_tp);
            this.tab_cargos_especialidades.Controls.Add(this.cargos_tp);
            this.tab_cargos_especialidades.Location = new System.Drawing.Point(4, 44);
            this.tab_cargos_especialidades.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.tab_cargos_especialidades.Name = "tab_cargos_especialidades";
            this.tab_cargos_especialidades.Padding = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.tab_cargos_especialidades.Size = new System.Drawing.Size(856, 487);
            this.tab_cargos_especialidades.TabIndex = 0;
            this.tab_cargos_especialidades.Text = "Cargos e Especialidades";
            this.tab_cargos_especialidades.UseVisualStyleBackColor = true;
            // 
            // cargoEspecialidade_padrao
            // 
            this.cargoEspecialidade_padrao.BackColor = System.Drawing.SystemColors.Control;
            this.cargoEspecialidade_padrao.Controls.Add(this.btn_cargoEspecialidade_padrao);
            this.cargoEspecialidade_padrao.Controls.Add(this.label3);
            this.cargoEspecialidade_padrao.Controls.Add(this.cargo_default);
            this.cargoEspecialidade_padrao.Controls.Add(this.label2);
            this.cargoEspecialidade_padrao.Controls.Add(this.especialidade_default);
            this.cargoEspecialidade_padrao.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.cargoEspecialidade_padrao.Location = new System.Drawing.Point(42, 313);
            this.cargoEspecialidade_padrao.Margin = new System.Windows.Forms.Padding(10);
            this.cargoEspecialidade_padrao.Name = "cargoEspecialidade_padrao";
            this.cargoEspecialidade_padrao.Size = new System.Drawing.Size(764, 154);
            this.cargoEspecialidade_padrao.TabIndex = 2;
            this.cargoEspecialidade_padrao.Text = "Cargo e especialidade padrão";
            this.cargoEspecialidade_padrao.Visible = false;
            // 
            // btn_cargoEspecialidade_padrao
            // 
            this.btn_cargoEspecialidade_padrao.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_cargoEspecialidade_padrao.BackColor = System.Drawing.Color.Transparent;
            this.btn_cargoEspecialidade_padrao.FlatAppearance.BorderSize = 0;
            this.btn_cargoEspecialidade_padrao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cargoEspecialidade_padrao.ForeColor = System.Drawing.Color.Black;
            this.btn_cargoEspecialidade_padrao.Location = new System.Drawing.Point(336, 111);
            this.btn_cargoEspecialidade_padrao.Margin = new System.Windows.Forms.Padding(15, 5, 0, 30);
            this.btn_cargoEspecialidade_padrao.Name = "btn_cargoEspecialidade_padrao";
            this.btn_cargoEspecialidade_padrao.Size = new System.Drawing.Size(116, 33);
            this.btn_cargoEspecialidade_padrao.TabIndex = 4;
            this.btn_cargoEspecialidade_padrao.Text = "Definir";
            this.btn_cargoEspecialidade_padrao.UseVisualStyleBackColor = false;
            this.btn_cargoEspecialidade_padrao.Click += new System.EventHandler(this.Submit_estabelecimento_cargoEspecialidade);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(483, 15);
            this.label3.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Indicativo sem especialidade";
            // 
            // cargo_default
            // 
            this.cargo_default.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cargo_default.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.cargo_default.Location = new System.Drawing.Point(11, 45);
            this.cargo_default.Margin = new System.Windows.Forms.Padding(15, 5, 0, 30);
            this.cargo_default.Name = "cargo_default";
            this.cargo_default.Size = new System.Drawing.Size(290, 33);
            this.cargo_default.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(94, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cargo Técnico";
            // 
            // especialidade_default
            // 
            this.especialidade_default.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.especialidade_default.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.especialidade_default.Location = new System.Drawing.Point(476, 45);
            this.especialidade_default.Margin = new System.Windows.Forms.Padding(15, 5, 0, 30);
            this.especialidade_default.Name = "especialidade_default";
            this.especialidade_default.Size = new System.Drawing.Size(256, 33);
            this.especialidade_default.TabIndex = 1;
            // 
            // especialidades_tp
            // 
            this.especialidades_tp.BackColor = System.Drawing.SystemColors.Control;
            this.especialidades_tp.Controls.Add(this.boxEspecialidades);
            this.especialidades_tp.Controls.Add(this.label4);
            this.especialidades_tp.Controls.Add(this.especialidades_tp_criador);
            this.especialidades_tp.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.especialidades_tp.Location = new System.Drawing.Point(447, 21);
            this.especialidades_tp.Margin = new System.Windows.Forms.Padding(10, 10, 0, 10);
            this.especialidades_tp.Name = "especialidades_tp";
            this.especialidades_tp.Padding = new System.Windows.Forms.Padding(10);
            this.especialidades_tp.Size = new System.Drawing.Size(382, 272);
            this.especialidades_tp.TabIndex = 1;
            this.especialidades_tp.Text = "Especialidades";
            // 
            // boxEspecialidades
            // 
            this.boxEspecialidades.BackColor = System.Drawing.Color.White;
            this.boxEspecialidades.Dock = System.Windows.Forms.DockStyle.Fill;
            this.boxEspecialidades.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.boxEspecialidades.ItemHeight = 21;
            this.boxEspecialidades.Location = new System.Drawing.Point(10, 48);
            this.boxEspecialidades.Margin = new System.Windows.Forms.Padding(0);
            this.boxEspecialidades.Name = "boxEspecialidades";
            this.boxEspecialidades.ScrollAlwaysVisible = true;
            this.boxEspecialidades.Size = new System.Drawing.Size(362, 171);
            this.boxEspecialidades.TabIndex = 2;
            this.boxEspecialidades.TabStop = false;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Location = new System.Drawing.Point(10, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(362, 38);
            this.label4.TabIndex = 0;
            this.label4.Text = "Especialidades";
            // 
            // especialidades_tp_criador
            // 
            this.especialidades_tp_criador.Controls.Add(this.especialidade_input);
            this.especialidades_tp_criador.Controls.Add(this.especialidade_submit);
            this.especialidades_tp_criador.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.especialidades_tp_criador.Location = new System.Drawing.Point(10, 219);
            this.especialidades_tp_criador.Margin = new System.Windows.Forms.Padding(0);
            this.especialidades_tp_criador.Name = "especialidades_tp_criador";
            this.especialidades_tp_criador.Size = new System.Drawing.Size(362, 43);
            this.especialidades_tp_criador.TabIndex = 3;
            // 
            // especialidade_input
            // 
            this.especialidade_input.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.especialidade_input.Location = new System.Drawing.Point(0, 5);
            this.especialidade_input.Margin = new System.Windows.Forms.Padding(0, 5, 15, 0);
            this.especialidade_input.MaxLength = 40;
            this.especialidade_input.Name = "especialidade_input";
            this.especialidade_input.Size = new System.Drawing.Size(256, 33);
            this.especialidade_input.TabIndex = 0;
            this.especialidade_input.TabStop = false;
            // 
            // especialidade_submit
            // 
            this.especialidade_submit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.especialidade_submit.BackColor = System.Drawing.Color.Transparent;
            this.especialidade_submit.FlatAppearance.BorderSize = 0;
            this.especialidade_submit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.especialidade_submit.ForeColor = System.Drawing.Color.Black;
            this.especialidade_submit.Location = new System.Drawing.Point(271, 5);
            this.especialidade_submit.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.especialidade_submit.Name = "especialidade_submit";
            this.especialidade_submit.Size = new System.Drawing.Size(91, 33);
            this.especialidade_submit.TabIndex = 1;
            this.especialidade_submit.Text = "Inserir";
            this.especialidade_submit.UseVisualStyleBackColor = false;
            this.especialidade_submit.Click += new System.EventHandler(this.Submit_estabelecimento_cargoEspecialidade_inserir);
            // 
            // cargos_tp
            // 
            this.cargos_tp.BackColor = System.Drawing.SystemColors.Control;
            this.cargos_tp.Controls.Add(this.boxCargos);
            this.cargos_tp.Controls.Add(this.label1);
            this.cargos_tp.Controls.Add(this.cargos_tp_criador);
            this.cargos_tp.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.cargos_tp.Location = new System.Drawing.Point(10, 21);
            this.cargos_tp.Margin = new System.Windows.Forms.Padding(10);
            this.cargos_tp.Name = "cargos_tp";
            this.cargos_tp.Padding = new System.Windows.Forms.Padding(10);
            this.cargos_tp.Size = new System.Drawing.Size(417, 272);
            this.cargos_tp.TabIndex = 0;
            this.cargos_tp.Text = "Cargos";
            // 
            // boxCargos
            // 
            this.boxCargos.BackColor = System.Drawing.Color.White;
            this.boxCargos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.boxCargos.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.boxCargos.ItemHeight = 21;
            this.boxCargos.Location = new System.Drawing.Point(10, 48);
            this.boxCargos.Margin = new System.Windows.Forms.Padding(0);
            this.boxCargos.Name = "boxCargos";
            this.boxCargos.ScrollAlwaysVisible = true;
            this.boxCargos.Size = new System.Drawing.Size(397, 171);
            this.boxCargos.TabIndex = 2;
            this.boxCargos.TabStop = false;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(397, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cargos";
            // 
            // cargos_tp_criador
            // 
            this.cargos_tp_criador.Controls.Add(this.cargo_input);
            this.cargos_tp_criador.Controls.Add(this.cargo_submit);
            this.cargos_tp_criador.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cargos_tp_criador.Location = new System.Drawing.Point(10, 219);
            this.cargos_tp_criador.Margin = new System.Windows.Forms.Padding(0);
            this.cargos_tp_criador.Name = "cargos_tp_criador";
            this.cargos_tp_criador.Size = new System.Drawing.Size(397, 43);
            this.cargos_tp_criador.TabIndex = 3;
            // 
            // cargo_input
            // 
            this.cargo_input.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.cargo_input.Location = new System.Drawing.Point(1, 5);
            this.cargo_input.Margin = new System.Windows.Forms.Padding(0, 5, 15, 0);
            this.cargo_input.MaxLength = 40;
            this.cargo_input.Name = "cargo_input";
            this.cargo_input.Size = new System.Drawing.Size(290, 33);
            this.cargo_input.TabIndex = 0;
            this.cargo_input.TabStop = false;
            // 
            // cargo_submit
            // 
            this.cargo_submit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cargo_submit.BackColor = System.Drawing.Color.Transparent;
            this.cargo_submit.FlatAppearance.BorderSize = 0;
            this.cargo_submit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cargo_submit.ForeColor = System.Drawing.Color.Black;
            this.cargo_submit.Location = new System.Drawing.Point(306, 5);
            this.cargo_submit.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.cargo_submit.Name = "cargo_submit";
            this.cargo_submit.Size = new System.Drawing.Size(91, 33);
            this.cargo_submit.TabIndex = 1;
            this.cargo_submit.Text = "Inserir";
            this.cargo_submit.UseVisualStyleBackColor = false;
            this.cargo_submit.Click += new System.EventHandler(this.Submit_estabelecimento_cargoEspecialidade_inserir);
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.Header.Controls.Add(this.btn_sair);
            this.Header.Controls.Add(this.subtitulo);
            this.Header.Controls.Add(this.titulo);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Margin = new System.Windows.Forms.Padding(0);
            this.Header.Name = "Header";
            this.Header.Padding = new System.Windows.Forms.Padding(10, 20, 10, 20);
            this.Header.Size = new System.Drawing.Size(884, 120);
            this.Header.TabIndex = 0;
            // 
            // btn_sair
            // 
            this.btn_sair.AutoSize = true;
            this.btn_sair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btn_sair.FlatAppearance.BorderSize = 0;
            this.btn_sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sair.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.btn_sair.ForeColor = System.Drawing.Color.White;
            this.btn_sair.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_sair.Location = new System.Drawing.Point(743, 74);
            this.btn_sair.Margin = new System.Windows.Forms.Padding(15, 0, 0, 30);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(120, 33);
            this.btn_sair.TabIndex = 6;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // subtitulo
            // 
            this.subtitulo.AutoSize = true;
            this.subtitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.subtitulo.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.subtitulo.ForeColor = System.Drawing.Color.White;
            this.subtitulo.Location = new System.Drawing.Point(10, 70);
            this.subtitulo.Name = "subtitulo";
            this.subtitulo.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.subtitulo.Size = new System.Drawing.Size(143, 20);
            this.subtitulo.TabIndex = 1;
            this.subtitulo.Text = "Sistema Nheengatu";
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.titulo.Font = new System.Drawing.Font("Segoe UI", 27.75F);
            this.titulo.ForeColor = System.Drawing.Color.White;
            this.titulo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.titulo.Location = new System.Drawing.Point(10, 20);
            this.titulo.Margin = new System.Windows.Forms.Padding(0);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(258, 50);
            this.titulo.TabIndex = 0;
            this.titulo.Text = "Administração";
            this.titulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Administracao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(884, 675);
            this.Controls.Add(this.Body);
            this.Controls.Add(this.Header);
            this.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MaximizeBox = false;
            this.Name = "Administracao";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administração - Sistema Nheengatu";
            this.Body.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tab_funcionarios.ResumeLayout(false);
            this.funcionarios_container.ResumeLayout(false);
            this.funcionarios_content.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_funcionarios)).EndInit();
            this.funcionarios_navbar.ResumeLayout(false);
            this.funcionarios_navbar.PerformLayout();
            this.tab_estabelecimento.ResumeLayout(false);
            this.editor.ResumeLayout(false);
            this.editor.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.tab_cargos_especialidades.ResumeLayout(false);
            this.cargoEspecialidade_padrao.ResumeLayout(false);
            this.cargoEspecialidade_padrao.PerformLayout();
            this.especialidades_tp.ResumeLayout(false);
            this.especialidades_tp_criador.ResumeLayout(false);
            this.especialidades_tp_criador.PerformLayout();
            this.cargos_tp.ResumeLayout(false);
            this.cargos_tp_criador.ResumeLayout(false);
            this.cargos_tp_criador.PerformLayout();
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        System.Windows.Forms.Panel Body;
        System.Windows.Forms.TabControl tabControl1;
        System.Windows.Forms.TabPage tab_cargos_especialidades;
        System.Windows.Forms.Panel cargoEspecialidade_padrao;
        System.Windows.Forms.Button btn_cargoEspecialidade_padrao;
        System.Windows.Forms.Label label3;
        System.Windows.Forms.ComboBox cargo_default;
        System.Windows.Forms.Label label2;
        System.Windows.Forms.ComboBox especialidade_default;
        System.Windows.Forms.Panel especialidades_tp;
        System.Windows.Forms.Panel especialidades_tp_criador;
        System.Windows.Forms.TextBox especialidade_input;
        System.Windows.Forms.Button especialidade_submit;
        System.Windows.Forms.ListBox boxEspecialidades;
        System.Windows.Forms.Panel cargos_tp;
        System.Windows.Forms.Panel cargos_tp_criador;
        System.Windows.Forms.TextBox cargo_input;
        System.Windows.Forms.Button cargo_submit;
        System.Windows.Forms.ListBox boxCargos;
        System.Windows.Forms.TabPage tab_estabelecimento;
        System.Windows.Forms.TabPage tab_funcionarios;
        System.Windows.Forms.Panel funcionarios_container;
        System.Windows.Forms.Panel funcionarios_content;
        System.Windows.Forms.Label lbl_naoHaFuncionarios;
        System.Windows.Forms.DataGridView dgv_funcionarios;
        System.Windows.Forms.Panel funcionarios_navbar;
        System.Windows.Forms.Button btn_novoFuncionario;
        System.Windows.Forms.Panel Header;
        System.Windows.Forms.Label titulo;
        System.Windows.Forms.Panel editor;
        System.Windows.Forms.ComboBox atendimento_input;
        System.Windows.Forms.Label atendimento_label;
        System.Windows.Forms.ComboBox abertura_input;
        System.Windows.Forms.Label abertura_label;
        System.Windows.Forms.ComboBox fechamento_input;
        System.Windows.Forms.Label fechamento_label;
        System.Windows.Forms.MaskedTextBox celular_input;
        System.Windows.Forms.Label celular_label;
        System.Windows.Forms.MaskedTextBox telefone_input;
        System.Windows.Forms.Label telefone_label;
        System.Windows.Forms.TextBox email_input;
        System.Windows.Forms.Label email_label;
        System.Windows.Forms.ComboBox uf_input;
        System.Windows.Forms.Label uf_label;
        System.Windows.Forms.TextBox cidade_input;
        System.Windows.Forms.Label cidade_label;
        System.Windows.Forms.TextBox bairro_input;
        System.Windows.Forms.Label bairro_label;
        System.Windows.Forms.MaskedTextBox cep_input;
        System.Windows.Forms.Label cep_label;
        System.Windows.Forms.TextBox complemento_input;
        System.Windows.Forms.Label complemento_label;
        System.Windows.Forms.TextBox numero_input;
        System.Windows.Forms.Label numero_label;
        System.Windows.Forms.TextBox logradouro_input;
        System.Windows.Forms.Label logradouro_label;
        System.Windows.Forms.Button submit;
        System.Windows.Forms.MaskedTextBox cnpj_input;
        System.Windows.Forms.TextBox nome_fantasia_input;
        System.Windows.Forms.Label cnpj_label;
        System.Windows.Forms.Label nome_fantasia_label;
        System.Windows.Forms.Label razao_social_label;
        System.Windows.Forms.TextBox razao_social_input;
        System.Windows.Forms.Panel panel4;
        System.Windows.Forms.CheckBox habilitar_edicao;
        System.Windows.Forms.Label subtitulo;
        System.Windows.Forms.TextBox funcionarios_search;
        System.Windows.Forms.Label label4;
        System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_sair;
    }
}