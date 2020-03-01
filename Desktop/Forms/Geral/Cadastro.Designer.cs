namespace Desktop_app
{
    partial class Cadastro
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
            this.nome_label = new System.Windows.Forms.Label();
            this.nome_input = new System.Windows.Forms.TextBox();
            this.cpf_input = new System.Windows.Forms.MaskedTextBox();
            this.cpf_label = new System.Windows.Forms.Label();
            this.nascimento_label = new System.Windows.Forms.Label();
            this.sexo_label = new System.Windows.Forms.Label();
            this.numero_input = new System.Windows.Forms.TextBox();
            this.numero_label = new System.Windows.Forms.Label();
            this.logradouro_input = new System.Windows.Forms.TextBox();
            this.logradouro_label = new System.Windows.Forms.Label();
            this.complemento_input = new System.Windows.Forms.TextBox();
            this.complemento_label = new System.Windows.Forms.Label();
            this.bairro_input = new System.Windows.Forms.TextBox();
            this.bairro_label = new System.Windows.Forms.Label();
            this.cep_input = new System.Windows.Forms.MaskedTextBox();
            this.cep_label = new System.Windows.Forms.Label();
            this.cidade_input = new System.Windows.Forms.TextBox();
            this.cidade_label = new System.Windows.Forms.Label();
            this.uf_label = new System.Windows.Forms.Label();
            this.email_input = new System.Windows.Forms.TextBox();
            this.email_label = new System.Windows.Forms.Label();
            this.telefone_input = new System.Windows.Forms.MaskedTextBox();
            this.telefone_label = new System.Windows.Forms.Label();
            this.celular_label = new System.Windows.Forms.Label();
            this.btn_submit = new System.Windows.Forms.Button();
            this.editor = new System.Windows.Forms.Panel();
            this.comum_inputs = new System.Windows.Forms.Panel();
            this.nascimento_input = new System.Windows.Forms.DateTimePicker();
            this.sexo_input = new System.Windows.Forms.ComboBox();
            this.uf_input = new System.Windows.Forms.ComboBox();
            this.celular_input = new System.Windows.Forms.MaskedTextBox();
            this.funcionarios_inputs = new System.Windows.Forms.Panel();
            this.cargo_label = new System.Windows.Forms.Label();
            this.cargo_input = new System.Windows.Forms.ComboBox();
            this.especialidade_label = new System.Windows.Forms.Label();
            this.especialidade_input = new System.Windows.Forms.ComboBox();
            this.registro_label = new System.Windows.Forms.Label();
            this.registro_input = new System.Windows.Forms.TextBox();
            this.registro_uf_label = new System.Windows.Forms.Label();
            this.registro_uf_input = new System.Windows.Forms.ComboBox();
            this.habilitar_edicao_input = new System.Windows.Forms.CheckBox();
            this.editor.SuspendLayout();
            this.comum_inputs.SuspendLayout();
            this.funcionarios_inputs.SuspendLayout();
            this.SuspendLayout();
            // 
            // nome_label
            // 
            this.nome_label.AutoSize = true;
            this.nome_label.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.nome_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.nome_label.Location = new System.Drawing.Point(15, 0);
            this.nome_label.Margin = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.nome_label.Name = "nome_label";
            this.nome_label.Size = new System.Drawing.Size(122, 20);
            this.nome_label.TabIndex = 0;
            this.nome_label.Text = "Nome completo";
            // 
            // nome_input
            // 
            this.nome_input.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.nome_input.Location = new System.Drawing.Point(19, 25);
            this.nome_input.Margin = new System.Windows.Forms.Padding(15, 5, 0, 30);
            this.nome_input.MaxLength = 40;
            this.nome_input.Name = "nome_input";
            this.nome_input.Size = new System.Drawing.Size(437, 33);
            this.nome_input.TabIndex = 1;
            // 
            // cpf_input
            // 
            this.cpf_input.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.cpf_input.Location = new System.Drawing.Point(471, 25);
            this.cpf_input.Margin = new System.Windows.Forms.Padding(15, 5, 0, 30);
            this.cpf_input.Mask = "000\\.000\\.000\\-00";
            this.cpf_input.Name = "cpf_input";
            this.cpf_input.Size = new System.Drawing.Size(218, 33);
            this.cpf_input.TabIndex = 3;
            // 
            // cpf_label
            // 
            this.cpf_label.AutoSize = true;
            this.cpf_label.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.cpf_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cpf_label.Location = new System.Drawing.Point(467, 0);
            this.cpf_label.Margin = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.cpf_label.Name = "cpf_label";
            this.cpf_label.Size = new System.Drawing.Size(35, 20);
            this.cpf_label.TabIndex = 2;
            this.cpf_label.Text = "CPF";
            // 
            // nascimento_label
            // 
            this.nascimento_label.AutoSize = true;
            this.nascimento_label.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.nascimento_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.nascimento_label.Location = new System.Drawing.Point(698, 0);
            this.nascimento_label.Margin = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.nascimento_label.Name = "nascimento_label";
            this.nascimento_label.Size = new System.Drawing.Size(118, 20);
            this.nascimento_label.TabIndex = 4;
            this.nascimento_label.Text = "Dt. Nascimento";
            // 
            // sexo_label
            // 
            this.sexo_label.AutoSize = true;
            this.sexo_label.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.sexo_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.sexo_label.Location = new System.Drawing.Point(860, 0);
            this.sexo_label.Margin = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.sexo_label.Name = "sexo_label";
            this.sexo_label.Size = new System.Drawing.Size(42, 20);
            this.sexo_label.TabIndex = 6;
            this.sexo_label.Text = "Sexo";
            // 
            // numero_input
            // 
            this.numero_input.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.numero_input.Location = new System.Drawing.Point(160, 113);
            this.numero_input.Margin = new System.Windows.Forms.Padding(15, 5, 0, 30);
            this.numero_input.MaxLength = 6;
            this.numero_input.Name = "numero_input";
            this.numero_input.Size = new System.Drawing.Size(70, 33);
            this.numero_input.TabIndex = 11;
            // 
            // numero_label
            // 
            this.numero_label.AutoSize = true;
            this.numero_label.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.numero_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.numero_label.Location = new System.Drawing.Point(156, 88);
            this.numero_label.Margin = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.numero_label.Name = "numero_label";
            this.numero_label.Size = new System.Drawing.Size(48, 20);
            this.numero_label.TabIndex = 10;
            this.numero_label.Text = "Num.";
            // 
            // logradouro_input
            // 
            this.logradouro_input.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.logradouro_input.Location = new System.Drawing.Point(471, 113);
            this.logradouro_input.Margin = new System.Windows.Forms.Padding(15, 5, 0, 30);
            this.logradouro_input.MaxLength = 40;
            this.logradouro_input.Name = "logradouro_input";
            this.logradouro_input.Size = new System.Drawing.Size(449, 33);
            this.logradouro_input.TabIndex = 15;
            // 
            // logradouro_label
            // 
            this.logradouro_label.AutoSize = true;
            this.logradouro_label.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.logradouro_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.logradouro_label.Location = new System.Drawing.Point(467, 88);
            this.logradouro_label.Margin = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.logradouro_label.Name = "logradouro_label";
            this.logradouro_label.Size = new System.Drawing.Size(91, 20);
            this.logradouro_label.TabIndex = 14;
            this.logradouro_label.Text = "Logradouro";
            // 
            // complemento_input
            // 
            this.complemento_input.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.complemento_input.Location = new System.Drawing.Point(245, 113);
            this.complemento_input.Margin = new System.Windows.Forms.Padding(15, 5, 0, 30);
            this.complemento_input.MaxLength = 40;
            this.complemento_input.Name = "complemento_input";
            this.complemento_input.Size = new System.Drawing.Size(211, 33);
            this.complemento_input.TabIndex = 13;
            // 
            // complemento_label
            // 
            this.complemento_label.AutoSize = true;
            this.complemento_label.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.complemento_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.complemento_label.Location = new System.Drawing.Point(241, 88);
            this.complemento_label.Margin = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.complemento_label.Name = "complemento_label";
            this.complemento_label.Size = new System.Drawing.Size(108, 20);
            this.complemento_label.TabIndex = 12;
            this.complemento_label.Text = "Complemento";
            // 
            // bairro_input
            // 
            this.bairro_input.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.bairro_input.Location = new System.Drawing.Point(19, 201);
            this.bairro_input.Margin = new System.Windows.Forms.Padding(15, 5, 0, 30);
            this.bairro_input.MaxLength = 40;
            this.bairro_input.Name = "bairro_input";
            this.bairro_input.Size = new System.Drawing.Size(437, 33);
            this.bairro_input.TabIndex = 17;
            // 
            // bairro_label
            // 
            this.bairro_label.AutoSize = true;
            this.bairro_label.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.bairro_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bairro_label.Location = new System.Drawing.Point(15, 176);
            this.bairro_label.Margin = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.bairro_label.Name = "bairro_label";
            this.bairro_label.Size = new System.Drawing.Size(52, 20);
            this.bairro_label.TabIndex = 16;
            this.bairro_label.Text = "Bairro";
            // 
            // cep_input
            // 
            this.cep_input.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.cep_input.Location = new System.Drawing.Point(19, 113);
            this.cep_input.Margin = new System.Windows.Forms.Padding(15, 5, 0, 30);
            this.cep_input.Mask = "00\\.000\\-000";
            this.cep_input.Name = "cep_input";
            this.cep_input.Size = new System.Drawing.Size(126, 33);
            this.cep_input.TabIndex = 9;
            // 
            // cep_label
            // 
            this.cep_label.AutoSize = true;
            this.cep_label.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.cep_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cep_label.Location = new System.Drawing.Point(15, 88);
            this.cep_label.Margin = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.cep_label.Name = "cep_label";
            this.cep_label.Size = new System.Drawing.Size(35, 20);
            this.cep_label.TabIndex = 8;
            this.cep_label.Text = "CEP";
            // 
            // cidade_input
            // 
            this.cidade_input.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.cidade_input.Location = new System.Drawing.Point(471, 201);
            this.cidade_input.Margin = new System.Windows.Forms.Padding(15, 5, 0, 30);
            this.cidade_input.MaxLength = 40;
            this.cidade_input.Name = "cidade_input";
            this.cidade_input.Size = new System.Drawing.Size(378, 33);
            this.cidade_input.TabIndex = 19;
            // 
            // cidade_label
            // 
            this.cidade_label.AutoSize = true;
            this.cidade_label.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.cidade_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cidade_label.Location = new System.Drawing.Point(467, 176);
            this.cidade_label.Margin = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.cidade_label.Name = "cidade_label";
            this.cidade_label.Size = new System.Drawing.Size(56, 20);
            this.cidade_label.TabIndex = 18;
            this.cidade_label.Text = "Cidade";
            // 
            // uf_label
            // 
            this.uf_label.AutoSize = true;
            this.uf_label.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.uf_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uf_label.Location = new System.Drawing.Point(860, 176);
            this.uf_label.Margin = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.uf_label.Name = "uf_label";
            this.uf_label.Size = new System.Drawing.Size(28, 20);
            this.uf_label.TabIndex = 20;
            this.uf_label.Text = "UF";
            // 
            // email_input
            // 
            this.email_input.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.email_input.Location = new System.Drawing.Point(19, 289);
            this.email_input.Margin = new System.Windows.Forms.Padding(15, 5, 0, 30);
            this.email_input.MaxLength = 40;
            this.email_input.Name = "email_input";
            this.email_input.Size = new System.Drawing.Size(437, 33);
            this.email_input.TabIndex = 23;
            // 
            // email_label
            // 
            this.email_label.AutoSize = true;
            this.email_label.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.email_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.email_label.Location = new System.Drawing.Point(15, 264);
            this.email_label.Margin = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.email_label.Name = "email_label";
            this.email_label.Size = new System.Drawing.Size(53, 20);
            this.email_label.TabIndex = 22;
            this.email_label.Text = "E-mail";
            // 
            // telefone_input
            // 
            this.telefone_input.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.telefone_input.Location = new System.Drawing.Point(471, 289);
            this.telefone_input.Margin = new System.Windows.Forms.Padding(15, 5, 0, 30);
            this.telefone_input.Mask = "\\(00\\)0000\\-0000";
            this.telefone_input.Name = "telefone_input";
            this.telefone_input.Size = new System.Drawing.Size(141, 33);
            this.telefone_input.TabIndex = 25;
            // 
            // telefone_label
            // 
            this.telefone_label.AutoSize = true;
            this.telefone_label.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.telefone_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.telefone_label.Location = new System.Drawing.Point(467, 264);
            this.telefone_label.Margin = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.telefone_label.Name = "telefone_label";
            this.telefone_label.Size = new System.Drawing.Size(69, 20);
            this.telefone_label.TabIndex = 24;
            this.telefone_label.Text = "Telefone";
            // 
            // celular_label
            // 
            this.celular_label.AutoSize = true;
            this.celular_label.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.celular_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.celular_label.Location = new System.Drawing.Point(623, 264);
            this.celular_label.Margin = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.celular_label.Name = "celular_label";
            this.celular_label.Size = new System.Drawing.Size(57, 20);
            this.celular_label.TabIndex = 26;
            this.celular_label.Text = "Celular";
            // 
            // btn_submit
            // 
            this.btn_submit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_submit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btn_submit.FlatAppearance.BorderSize = 0;
            this.btn_submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_submit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_submit.ForeColor = System.Drawing.Color.White;
            this.btn_submit.Location = new System.Drawing.Point(781, 289);
            this.btn_submit.Margin = new System.Windows.Forms.Padding(15, 5, 0, 30);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(139, 33);
            this.btn_submit.TabIndex = 28;
            this.btn_submit.Text = "Salvar dados";
            this.btn_submit.UseVisualStyleBackColor = false;
            this.btn_submit.Click += new System.EventHandler(this.Definir_especialidade);
            this.btn_submit.Click += new System.EventHandler(this.Submit_Cadastro);
            // 
            // editor
            // 
            this.editor.AutoScroll = true;
            this.editor.BackColor = System.Drawing.Color.White;
            this.editor.Controls.Add(this.comum_inputs);
            this.editor.Controls.Add(this.funcionarios_inputs);
            this.editor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editor.Location = new System.Drawing.Point(0, 68);
            this.editor.Name = "editor";
            this.editor.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.editor.Size = new System.Drawing.Size(934, 458);
            this.editor.TabIndex = 1;
            // 
            // comum_inputs
            // 
            this.comum_inputs.Controls.Add(this.nome_label);
            this.comum_inputs.Controls.Add(this.nome_input);
            this.comum_inputs.Controls.Add(this.cpf_label);
            this.comum_inputs.Controls.Add(this.cpf_input);
            this.comum_inputs.Controls.Add(this.nascimento_label);
            this.comum_inputs.Controls.Add(this.nascimento_input);
            this.comum_inputs.Controls.Add(this.sexo_label);
            this.comum_inputs.Controls.Add(this.sexo_input);
            this.comum_inputs.Controls.Add(this.cep_label);
            this.comum_inputs.Controls.Add(this.cep_input);
            this.comum_inputs.Controls.Add(this.numero_label);
            this.comum_inputs.Controls.Add(this.numero_input);
            this.comum_inputs.Controls.Add(this.complemento_label);
            this.comum_inputs.Controls.Add(this.complemento_input);
            this.comum_inputs.Controls.Add(this.logradouro_label);
            this.comum_inputs.Controls.Add(this.logradouro_input);
            this.comum_inputs.Controls.Add(this.bairro_label);
            this.comum_inputs.Controls.Add(this.bairro_input);
            this.comum_inputs.Controls.Add(this.cidade_label);
            this.comum_inputs.Controls.Add(this.cidade_input);
            this.comum_inputs.Controls.Add(this.uf_label);
            this.comum_inputs.Controls.Add(this.uf_input);
            this.comum_inputs.Controls.Add(this.email_label);
            this.comum_inputs.Controls.Add(this.email_input);
            this.comum_inputs.Controls.Add(this.telefone_label);
            this.comum_inputs.Controls.Add(this.telefone_input);
            this.comum_inputs.Controls.Add(this.celular_label);
            this.comum_inputs.Controls.Add(this.celular_input);
            this.comum_inputs.Controls.Add(this.btn_submit);
            this.comum_inputs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comum_inputs.Location = new System.Drawing.Point(0, 113);
            this.comum_inputs.Margin = new System.Windows.Forms.Padding(0);
            this.comum_inputs.Name = "comum_inputs";
            this.comum_inputs.Padding = new System.Windows.Forms.Padding(10, 20, 10, 20);
            this.comum_inputs.Size = new System.Drawing.Size(934, 345);
            this.comum_inputs.TabIndex = 1;
            // 
            // nascimento_input
            // 
            this.nascimento_input.CustomFormat = "dd/MM/yyyy";
            this.nascimento_input.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.nascimento_input.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.nascimento_input.Location = new System.Drawing.Point(702, 25);
            this.nascimento_input.Margin = new System.Windows.Forms.Padding(15, 5, 0, 30);
            this.nascimento_input.MaxDate = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
            this.nascimento_input.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.nascimento_input.Name = "nascimento_input";
            this.nascimento_input.Size = new System.Drawing.Size(147, 33);
            this.nascimento_input.TabIndex = 5;
            this.nascimento_input.Value = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            // 
            // sexo_input
            // 
            this.sexo_input.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.sexo_input.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.sexo_input.DropDownHeight = 80;
            this.sexo_input.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sexo_input.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.sexo_input.IntegralHeight = false;
            this.sexo_input.Items.AddRange(new object[] {
            "F",
            "M"});
            this.sexo_input.Location = new System.Drawing.Point(864, 25);
            this.sexo_input.Margin = new System.Windows.Forms.Padding(15, 5, 0, 30);
            this.sexo_input.Name = "sexo_input";
            this.sexo_input.Size = new System.Drawing.Size(56, 33);
            this.sexo_input.TabIndex = 7;
            // 
            // uf_input
            // 
            this.uf_input.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.uf_input.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.uf_input.DropDownHeight = 80;
            this.uf_input.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uf_input.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.uf_input.IntegralHeight = false;
            this.uf_input.Location = new System.Drawing.Point(864, 201);
            this.uf_input.Margin = new System.Windows.Forms.Padding(15, 5, 0, 30);
            this.uf_input.Name = "uf_input";
            this.uf_input.Size = new System.Drawing.Size(56, 33);
            this.uf_input.TabIndex = 21;
            // 
            // celular_input
            // 
            this.celular_input.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.celular_input.Location = new System.Drawing.Point(627, 289);
            this.celular_input.Margin = new System.Windows.Forms.Padding(15, 5, 0, 30);
            this.celular_input.Mask = "\\(00\\)\\90000\\-0000";
            this.celular_input.Name = "celular_input";
            this.celular_input.Size = new System.Drawing.Size(139, 33);
            this.celular_input.TabIndex = 27;
            // 
            // funcionarios_inputs
            // 
            this.funcionarios_inputs.Controls.Add(this.cargo_label);
            this.funcionarios_inputs.Controls.Add(this.cargo_input);
            this.funcionarios_inputs.Controls.Add(this.especialidade_label);
            this.funcionarios_inputs.Controls.Add(this.especialidade_input);
            this.funcionarios_inputs.Controls.Add(this.registro_label);
            this.funcionarios_inputs.Controls.Add(this.registro_input);
            this.funcionarios_inputs.Controls.Add(this.registro_uf_label);
            this.funcionarios_inputs.Controls.Add(this.registro_uf_input);
            this.funcionarios_inputs.Dock = System.Windows.Forms.DockStyle.Top;
            this.funcionarios_inputs.Location = new System.Drawing.Point(0, 20);
            this.funcionarios_inputs.Margin = new System.Windows.Forms.Padding(0);
            this.funcionarios_inputs.Name = "funcionarios_inputs";
            this.funcionarios_inputs.Size = new System.Drawing.Size(934, 93);
            this.funcionarios_inputs.TabIndex = 0;
            // 
            // cargo_label
            // 
            this.cargo_label.AutoSize = true;
            this.cargo_label.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.cargo_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cargo_label.Location = new System.Drawing.Point(15, 0);
            this.cargo_label.Margin = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.cargo_label.Name = "cargo_label";
            this.cargo_label.Size = new System.Drawing.Size(50, 20);
            this.cargo_label.TabIndex = 0;
            this.cargo_label.Text = "Cargo";
            // 
            // cargo_input
            // 
            this.cargo_input.DisplayMember = "id";
            this.cargo_input.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cargo_input.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.cargo_input.FormattingEnabled = true;
            this.cargo_input.Location = new System.Drawing.Point(19, 25);
            this.cargo_input.Margin = new System.Windows.Forms.Padding(15, 5, 0, 30);
            this.cargo_input.Name = "cargo_input";
            this.cargo_input.Size = new System.Drawing.Size(211, 33);
            this.cargo_input.TabIndex = 1;
            this.cargo_input.SelectedIndexChanged += new System.EventHandler(this.Habilita_RegistroProfissional);
            
            // 
            // especialidade_label
            // 
            this.especialidade_label.AutoSize = true;
            this.especialidade_label.Enabled = false;
            this.especialidade_label.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.especialidade_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.especialidade_label.Location = new System.Drawing.Point(241, 0);
            this.especialidade_label.Margin = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.especialidade_label.Name = "especialidade_label";
            this.especialidade_label.Size = new System.Drawing.Size(102, 20);
            this.especialidade_label.TabIndex = 2;
            this.especialidade_label.Text = "Especialidade";
            // 
            // especialidade_input
            // 
            this.especialidade_input.DisplayMember = "id";
            this.especialidade_input.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.especialidade_input.Enabled = false;
            this.especialidade_input.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.especialidade_input.Location = new System.Drawing.Point(245, 25);
            this.especialidade_input.Margin = new System.Windows.Forms.Padding(15, 5, 0, 30);
            this.especialidade_input.Name = "especialidade_input";
            this.especialidade_input.Size = new System.Drawing.Size(211, 33);
            this.especialidade_input.TabIndex = 3;
            this.especialidade_input.Leave += new System.EventHandler(this.Definir_especialidade);
            // 
            // registro_label
            // 
            this.registro_label.AutoSize = true;
            this.registro_label.Enabled = false;
            this.registro_label.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.registro_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.registro_label.Location = new System.Drawing.Point(467, 0);
            this.registro_label.Margin = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.registro_label.Name = "registro_label";
            this.registro_label.Size = new System.Drawing.Size(68, 20);
            this.registro_label.TabIndex = 4;
            this.registro_label.Text = "Registro";
            // 
            // registro_input
            // 
            this.registro_input.Enabled = false;
            this.registro_input.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.registro_input.Location = new System.Drawing.Point(471, 25);
            this.registro_input.Margin = new System.Windows.Forms.Padding(15, 5, 0, 30);
            this.registro_input.MaxLength = 10;
            this.registro_input.Name = "registro_input";
            this.registro_input.Size = new System.Drawing.Size(216, 33);
            this.registro_input.TabIndex = 5;
            // 
            // registro_uf_label
            // 
            this.registro_uf_label.AutoSize = true;
            this.registro_uf_label.Enabled = false;
            this.registro_uf_label.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.registro_uf_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.registro_uf_label.Location = new System.Drawing.Point(698, 0);
            this.registro_uf_label.Margin = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.registro_uf_label.Name = "registro_uf_label";
            this.registro_uf_label.Size = new System.Drawing.Size(28, 20);
            this.registro_uf_label.TabIndex = 6;
            this.registro_uf_label.Text = "UF";
            // 
            // registro_uf_input
            // 
            this.registro_uf_input.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.registro_uf_input.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.registro_uf_input.DropDownHeight = 80;
            this.registro_uf_input.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.registro_uf_input.Enabled = false;
            this.registro_uf_input.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.registro_uf_input.IntegralHeight = false;
            this.registro_uf_input.Location = new System.Drawing.Point(702, 25);
            this.registro_uf_input.Margin = new System.Windows.Forms.Padding(15, 5, 0, 30);
            this.registro_uf_input.Name = "registro_uf_input";
            this.registro_uf_input.Size = new System.Drawing.Size(61, 33);
            this.registro_uf_input.TabIndex = 7;
            // 
            // habilitar_edicao_input
            // 
            this.habilitar_edicao_input.BackColor = System.Drawing.Color.White;
            this.habilitar_edicao_input.Dock = System.Windows.Forms.DockStyle.Top;
            this.habilitar_edicao_input.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.habilitar_edicao_input.ForeColor = System.Drawing.Color.Black;
            this.habilitar_edicao_input.Location = new System.Drawing.Point(0, 0);
            this.habilitar_edicao_input.Name = "habilitar_edicao_input";
            this.habilitar_edicao_input.Padding = new System.Windows.Forms.Padding(20, 10, 0, 0);
            this.habilitar_edicao_input.Size = new System.Drawing.Size(934, 68);
            this.habilitar_edicao_input.TabIndex = 0;
            this.habilitar_edicao_input.Text = "Habilitar edição";
            this.habilitar_edicao_input.UseVisualStyleBackColor = false;
            this.habilitar_edicao_input.Visible = false;
            this.habilitar_edicao_input.CheckedChanged += new System.EventHandler(this.Habilitar_edicao);
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(934, 526);
            this.Controls.Add(this.editor);
            this.Controls.Add(this.habilitar_edicao_input);
            this.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Cadastro";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            this.editor.ResumeLayout(false);
            this.comum_inputs.ResumeLayout(false);
            this.comum_inputs.PerformLayout();
            this.funcionarios_inputs.ResumeLayout(false);
            this.funcionarios_inputs.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        System.Windows.Forms.Label nome_label;
        System.Windows.Forms.TextBox nome_input;
        System.Windows.Forms.MaskedTextBox cpf_input;
        System.Windows.Forms.Label cpf_label;
        System.Windows.Forms.Label nascimento_label;
        System.Windows.Forms.Label sexo_label;
        System.Windows.Forms.TextBox numero_input;
        System.Windows.Forms.Label numero_label;
        System.Windows.Forms.TextBox logradouro_input;
        System.Windows.Forms.Label logradouro_label;
        System.Windows.Forms.TextBox complemento_input;
        System.Windows.Forms.Label complemento_label;
        System.Windows.Forms.TextBox bairro_input;
        System.Windows.Forms.Label bairro_label;
        System.Windows.Forms.MaskedTextBox cep_input;
        System.Windows.Forms.Label cep_label;
        System.Windows.Forms.TextBox cidade_input;
        System.Windows.Forms.Label cidade_label;
        System.Windows.Forms.Label uf_label;
        System.Windows.Forms.TextBox email_input;
        System.Windows.Forms.Label email_label;
        System.Windows.Forms.MaskedTextBox telefone_input;
        System.Windows.Forms.Label telefone_label;
        System.Windows.Forms.Label celular_label;
        System.Windows.Forms.Button btn_submit;
        System.Windows.Forms.Panel funcionarios_inputs;
        System.Windows.Forms.Label cargo_label;
        System.Windows.Forms.ComboBox especialidade_input;
        System.Windows.Forms.ComboBox cargo_input;
        System.Windows.Forms.Label especialidade_label;
        System.Windows.Forms.Label registro_label;
        System.Windows.Forms.TextBox registro_input;
        System.Windows.Forms.MaskedTextBox celular_input;
        System.Windows.Forms.Panel editor;
        System.Windows.Forms.CheckBox habilitar_edicao_input;
        System.Windows.Forms.DateTimePicker nascimento_input;
        System.Windows.Forms.Label registro_uf_label;
        System.Windows.Forms.Panel comum_inputs;
        System.Windows.Forms.ComboBox registro_uf_input;
        System.Windows.Forms.ComboBox uf_input;
        System.Windows.Forms.ComboBox sexo_input;
    }
}