using Core;

namespace Desktop_app
{
    partial class Atendimento
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
            this.titulo = new System.Windows.Forms.Label();
            this.header = new System.Windows.Forms.Panel();
            this.subtitulo = new System.Windows.Forms.Label();
            this.bodyContainer = new System.Windows.Forms.TabControl();
            this.tab_agendamentos = new System.Windows.Forms.TabPage();
            this.agendamentos_container = new System.Windows.Forms.Panel();
            this.agendamentos_content = new System.Windows.Forms.Panel();
            this.lbl_naoHaAgendamentos = new System.Windows.Forms.Label();
            this.dgv_agendamentos = new System.Windows.Forms.DataGridView();
            this.agendamentos_navbar = new System.Windows.Forms.Panel();
            this.agendamentos_search = new System.Windows.Forms.ComboBox();
            this.btn_agendamento = new System.Windows.Forms.Button();
            this.tab_clientes = new System.Windows.Forms.TabPage();
            this.clientes_container = new System.Windows.Forms.Panel();
            this.clientes_content = new System.Windows.Forms.Panel();
            this.lbl_naoHaClientes = new System.Windows.Forms.Label();
            this.dgv_clientes = new System.Windows.Forms.DataGridView();
            this.clientes_navbar = new System.Windows.Forms.Panel();
            this.btn_mensageiro = new System.Windows.Forms.Button();
            this.btn_historico = new System.Windows.Forms.Button();
            this.btn_cadastro = new System.Windows.Forms.Button();
            this.clientes_search = new System.Windows.Forms.TextBox();
            this.body = new System.Windows.Forms.Panel();
            this.header.SuspendLayout();
            this.bodyContainer.SuspendLayout();
            this.tab_agendamentos.SuspendLayout();
            this.agendamentos_container.SuspendLayout();
            this.agendamentos_content.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_agendamentos)).BeginInit();
            this.agendamentos_navbar.SuspendLayout();
            this.tab_clientes.SuspendLayout();
            this.clientes_container.SuspendLayout();
            this.clientes_content.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clientes)).BeginInit();
            this.clientes_navbar.SuspendLayout();
            this.body.SuspendLayout();
            this.SuspendLayout();
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.titulo.Font = new System.Drawing.Font("Segoe UI", 27.75F);
            this.titulo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.titulo.Location = new System.Drawing.Point(10, 20);
            this.titulo.Margin = new System.Windows.Forms.Padding(0);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(237, 50);
            this.titulo.TabIndex = 0;
            this.titulo.Text = "Atendimento";
            this.titulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.header.Controls.Add(this.subtitulo);
            this.header.Controls.Add(this.titulo);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.ForeColor = System.Drawing.Color.White;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Margin = new System.Windows.Forms.Padding(0);
            this.header.Name = "header";
            this.header.Padding = new System.Windows.Forms.Padding(10, 20, 10, 20);
            this.header.Size = new System.Drawing.Size(1158, 120);
            this.header.TabIndex = 0;
            // 
            // subtitulo
            // 
            this.subtitulo.AutoSize = true;
            this.subtitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.subtitulo.ForeColor = System.Drawing.Color.White;
            this.subtitulo.Location = new System.Drawing.Point(10, 70);
            this.subtitulo.Name = "subtitulo";
            this.subtitulo.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.subtitulo.Size = new System.Drawing.Size(234, 20);
            this.subtitulo.TabIndex = 1;
            this.subtitulo.Text = "Bem vindo/a Dr/a. Usuario.Nome";
            // 
            // bodyContainer
            // 
            this.bodyContainer.Controls.Add(this.tab_agendamentos);
            this.bodyContainer.Controls.Add(this.tab_clientes);
            this.bodyContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bodyContainer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bodyContainer.Location = new System.Drawing.Point(10, 10);
            this.bodyContainer.Margin = new System.Windows.Forms.Padding(0);
            this.bodyContainer.Name = "bodyContainer";
            this.bodyContainer.Padding = new System.Drawing.Point(40, 10);
            this.bodyContainer.SelectedIndex = 0;
            this.bodyContainer.Size = new System.Drawing.Size(1138, 462);
            this.bodyContainer.TabIndex = 0;
            this.bodyContainer.TabStop = false;
            // 
            // tab_agendamentos
            // 
            this.tab_agendamentos.BackColor = System.Drawing.Color.White;
            this.tab_agendamentos.Controls.Add(this.agendamentos_container);
            this.tab_agendamentos.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_agendamentos.Location = new System.Drawing.Point(4, 44);
            this.tab_agendamentos.Margin = new System.Windows.Forms.Padding(0);
            this.tab_agendamentos.Name = "tab_agendamentos";
            this.tab_agendamentos.Size = new System.Drawing.Size(1130, 414);
            this.tab_agendamentos.TabIndex = 0;
            this.tab_agendamentos.Text = "Agendamentos";
            // 
            // agendamentos_container
            // 
            this.agendamentos_container.Controls.Add(this.agendamentos_content);
            this.agendamentos_container.Controls.Add(this.agendamentos_navbar);
            this.agendamentos_container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.agendamentos_container.Location = new System.Drawing.Point(0, 0);
            this.agendamentos_container.Margin = new System.Windows.Forms.Padding(0);
            this.agendamentos_container.Name = "agendamentos_container";
            this.agendamentos_container.Padding = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.agendamentos_container.Size = new System.Drawing.Size(1130, 414);
            this.agendamentos_container.TabIndex = 0;
            // 
            // agendamentos_content
            // 
            this.agendamentos_content.BackColor = System.Drawing.Color.LightGray;
            this.agendamentos_content.Controls.Add(this.lbl_naoHaAgendamentos);
            this.agendamentos_content.Controls.Add(this.dgv_agendamentos);
            this.agendamentos_content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.agendamentos_content.Location = new System.Drawing.Point(10, 70);
            this.agendamentos_content.Margin = new System.Windows.Forms.Padding(0);
            this.agendamentos_content.Name = "agendamentos_content";
            this.agendamentos_content.Padding = new System.Windows.Forms.Padding(1);
            this.agendamentos_content.Size = new System.Drawing.Size(1110, 334);
            this.agendamentos_content.TabIndex = 1;
            // 
            // lbl_naoHaAgendamentos
            // 
            this.lbl_naoHaAgendamentos.BackColor = System.Drawing.Color.White;
            this.lbl_naoHaAgendamentos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_naoHaAgendamentos.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_naoHaAgendamentos.ForeColor = System.Drawing.Color.Silver;
            this.lbl_naoHaAgendamentos.Location = new System.Drawing.Point(1, 1);
            this.lbl_naoHaAgendamentos.Name = "lbl_naoHaAgendamentos";
            this.lbl_naoHaAgendamentos.Padding = new System.Windows.Forms.Padding(0, 40, 0, 0);
            this.lbl_naoHaAgendamentos.Size = new System.Drawing.Size(1108, 332);
            this.lbl_naoHaAgendamentos.TabIndex = 1;
            this.lbl_naoHaAgendamentos.Text = "Não há agendamentos para hoje";
            this.lbl_naoHaAgendamentos.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgv_agendamentos
            // 
            this.dgv_agendamentos.AllowUserToAddRows = false;
            this.dgv_agendamentos.AllowUserToDeleteRows = false;
            this.dgv_agendamentos.AllowUserToResizeColumns = false;
            this.dgv_agendamentos.AllowUserToResizeRows = false;
            this.dgv_agendamentos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_agendamentos.BackgroundColor = System.Drawing.Color.White;
            this.dgv_agendamentos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_agendamentos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_agendamentos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_agendamentos.ColumnHeadersHeight = 39;
            this.dgv_agendamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_agendamentos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_agendamentos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_agendamentos.EnableHeadersVisualStyles = false;
            this.dgv_agendamentos.GridColor = System.Drawing.Color.White;
            this.dgv_agendamentos.Location = new System.Drawing.Point(1, 1);
            this.dgv_agendamentos.Margin = new System.Windows.Forms.Padding(0);
            this.dgv_agendamentos.MultiSelect = false;
            this.dgv_agendamentos.Name = "dgv_agendamentos";
            this.dgv_agendamentos.ReadOnly = true;
            this.dgv_agendamentos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_agendamentos.RowHeadersVisible = false;
            this.dgv_agendamentos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_agendamentos.RowTemplate.Height = 39;
            this.dgv_agendamentos.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_agendamentos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv_agendamentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_agendamentos.Size = new System.Drawing.Size(1108, 332);
            this.dgv_agendamentos.StandardTab = true;
            this.dgv_agendamentos.TabIndex = 0;
            this.dgv_agendamentos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Abrir_Formulario);
            this.dgv_agendamentos.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.Definir_EditorID);
            // 
            // agendamentos_navbar
            // 
            this.agendamentos_navbar.Controls.Add(this.agendamentos_search);
            this.agendamentos_navbar.Controls.Add(this.btn_agendamento);
            this.agendamentos_navbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.agendamentos_navbar.Location = new System.Drawing.Point(10, 0);
            this.agendamentos_navbar.Name = "agendamentos_navbar";
            this.agendamentos_navbar.Padding = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.agendamentos_navbar.Size = new System.Drawing.Size(1110, 70);
            this.agendamentos_navbar.TabIndex = 2;
            // 
            // agendamentos_search
            // 
            this.agendamentos_search.BackColor = System.Drawing.Color.White;
            this.agendamentos_search.Dock = System.Windows.Forms.DockStyle.Left;
            this.agendamentos_search.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.agendamentos_search.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agendamentos_search.Location = new System.Drawing.Point(0, 20);
            this.agendamentos_search.Margin = new System.Windows.Forms.Padding(0);
            this.agendamentos_search.Name = "agendamentos_search";
            this.agendamentos_search.Size = new System.Drawing.Size(120, 29);
            this.agendamentos_search.TabIndex = 1;
            this.agendamentos_search.TabStop = false;
            this.agendamentos_search.SelectedIndexChanged += new System.EventHandler(this.Preencher_dgv_agendamentos);
            // 
            // btn_agendamento
            // 
            this.btn_agendamento.AutoSize = true;
            this.btn_agendamento.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_agendamento.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agendamento.Location = new System.Drawing.Point(909, 20);
            this.btn_agendamento.Margin = new System.Windows.Forms.Padding(0);
            this.btn_agendamento.Name = "btn_agendamento";
            this.btn_agendamento.Size = new System.Drawing.Size(201, 30);
            this.btn_agendamento.TabIndex = 3;
            this.btn_agendamento.TabStop = false;
            this.btn_agendamento.Text = "Cadastrar agendamento";
            this.btn_agendamento.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_agendamento.UseVisualStyleBackColor = true;
            this.btn_agendamento.Click += new System.EventHandler(this.Inserir_Objeto);
            // 
            // tab_clientes
            // 
            this.tab_clientes.BackColor = System.Drawing.Color.White;
            this.tab_clientes.Controls.Add(this.clientes_container);
            this.tab_clientes.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.tab_clientes.Location = new System.Drawing.Point(4, 44);
            this.tab_clientes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tab_clientes.Name = "tab_clientes";
            this.tab_clientes.Size = new System.Drawing.Size(1130, 414);
            this.tab_clientes.TabIndex = 1;
            this.tab_clientes.Text = "Clientes";
            // 
            // clientes_container
            // 
            this.clientes_container.Controls.Add(this.clientes_content);
            this.clientes_container.Controls.Add(this.clientes_navbar);
            this.clientes_container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clientes_container.Location = new System.Drawing.Point(0, 0);
            this.clientes_container.Margin = new System.Windows.Forms.Padding(0);
            this.clientes_container.Name = "clientes_container";
            this.clientes_container.Padding = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.clientes_container.Size = new System.Drawing.Size(1130, 414);
            this.clientes_container.TabIndex = 0;
            // 
            // clientes_content
            // 
            this.clientes_content.BackColor = System.Drawing.Color.LightGray;
            this.clientes_content.Controls.Add(this.lbl_naoHaClientes);
            this.clientes_content.Controls.Add(this.dgv_clientes);
            this.clientes_content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clientes_content.Location = new System.Drawing.Point(10, 70);
            this.clientes_content.Name = "clientes_content";
            this.clientes_content.Padding = new System.Windows.Forms.Padding(1);
            this.clientes_content.Size = new System.Drawing.Size(1110, 334);
            this.clientes_content.TabIndex = 1;
            // 
            // lbl_naoHaClientes
            // 
            this.lbl_naoHaClientes.BackColor = System.Drawing.Color.White;
            this.lbl_naoHaClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_naoHaClientes.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_naoHaClientes.ForeColor = System.Drawing.Color.Silver;
            this.lbl_naoHaClientes.Location = new System.Drawing.Point(1, 1);
            this.lbl_naoHaClientes.Name = "lbl_naoHaClientes";
            this.lbl_naoHaClientes.Padding = new System.Windows.Forms.Padding(0, 40, 0, 0);
            this.lbl_naoHaClientes.Size = new System.Drawing.Size(1108, 332);
            this.lbl_naoHaClientes.TabIndex = 2;
            this.lbl_naoHaClientes.Text = "Nenhum resultado para exibir";
            this.lbl_naoHaClientes.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgv_clientes
            // 
            this.dgv_clientes.AllowUserToAddRows = false;
            this.dgv_clientes.AllowUserToDeleteRows = false;
            this.dgv_clientes.AllowUserToResizeColumns = false;
            this.dgv_clientes.AllowUserToResizeRows = false;
            this.dgv_clientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_clientes.BackgroundColor = System.Drawing.Color.White;
            this.dgv_clientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_clientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_clientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_clientes.ColumnHeadersHeight = 39;
            this.dgv_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_clientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_clientes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_clientes.EnableHeadersVisualStyles = false;
            this.dgv_clientes.GridColor = System.Drawing.Color.White;
            this.dgv_clientes.Location = new System.Drawing.Point(1, 1);
            this.dgv_clientes.Margin = new System.Windows.Forms.Padding(0);
            this.dgv_clientes.MultiSelect = false;
            this.dgv_clientes.Name = "dgv_clientes";
            this.dgv_clientes.ReadOnly = true;
            this.dgv_clientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_clientes.RowHeadersVisible = false;
            this.dgv_clientes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_clientes.RowTemplate.Height = 39;
            this.dgv_clientes.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_clientes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv_clientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_clientes.Size = new System.Drawing.Size(1108, 332);
            this.dgv_clientes.StandardTab = true;
            this.dgv_clientes.TabIndex = 0;
            this.dgv_clientes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Abrir_Formulario);
            this.dgv_clientes.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.Definir_EditorID);
            // 
            // clientes_navbar
            // 
            this.clientes_navbar.Controls.Add(this.btn_mensageiro);
            this.clientes_navbar.Controls.Add(this.btn_historico);
            this.clientes_navbar.Controls.Add(this.btn_cadastro);
            this.clientes_navbar.Controls.Add(this.clientes_search);
            this.clientes_navbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.clientes_navbar.Location = new System.Drawing.Point(10, 0);
            this.clientes_navbar.Name = "clientes_navbar";
            this.clientes_navbar.Padding = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.clientes_navbar.Size = new System.Drawing.Size(1110, 70);
            this.clientes_navbar.TabIndex = 0;
            // 
            // btn_mensageiro
            // 
            this.btn_mensageiro.AutoSize = true;
            this.btn_mensageiro.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_mensageiro.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_mensageiro.Location = new System.Drawing.Point(630, 20);
            this.btn_mensageiro.Name = "btn_mensageiro";
            this.btn_mensageiro.Size = new System.Drawing.Size(160, 30);
            this.btn_mensageiro.TabIndex = 5;
            this.btn_mensageiro.Text = "Mensageiro";
            this.btn_mensageiro.UseVisualStyleBackColor = true;
            this.btn_mensageiro.Visible = false;
            this.btn_mensageiro.Click += new System.EventHandler(this.Abrir_Formulario);
            // 
            // btn_historico
            // 
            this.btn_historico.AutoSize = true;
            this.btn_historico.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_historico.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_historico.Location = new System.Drawing.Point(790, 20);
            this.btn_historico.Name = "btn_historico";
            this.btn_historico.Size = new System.Drawing.Size(160, 30);
            this.btn_historico.TabIndex = 4;
            this.btn_historico.Text = "Histórico";
            this.btn_historico.UseVisualStyleBackColor = true;
            this.btn_historico.Visible = false;
            this.btn_historico.Click += new System.EventHandler(this.Abrir_Formulario);
            // 
            // btn_cadastro
            // 
            this.btn_cadastro.AutoSize = true;
            this.btn_cadastro.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_cadastro.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_cadastro.Location = new System.Drawing.Point(950, 20);
            this.btn_cadastro.Name = "btn_cadastro";
            this.btn_cadastro.Size = new System.Drawing.Size(160, 30);
            this.btn_cadastro.TabIndex = 2;
            this.btn_cadastro.Text = "Cadastrar cliente";
            this.btn_cadastro.UseVisualStyleBackColor = true;
            this.btn_cadastro.Click += new System.EventHandler(this.Inserir_Objeto);
            // 
            // clientes_search
            // 
            this.clientes_search.Dock = System.Windows.Forms.DockStyle.Left;
            this.clientes_search.Location = new System.Drawing.Point(0, 20);
            this.clientes_search.MaxLength = 40;
            this.clientes_search.Name = "clientes_search";
            this.clientes_search.Size = new System.Drawing.Size(317, 33);
            this.clientes_search.TabIndex = 3;
            this.clientes_search.TextChanged += new System.EventHandler(this.Preencher_dgv_clientes);
            // 
            // body
            // 
            this.body.BackColor = System.Drawing.SystemColors.Control;
            this.body.Controls.Add(this.bodyContainer);
            this.body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.body.Location = new System.Drawing.Point(0, 120);
            this.body.Margin = new System.Windows.Forms.Padding(0);
            this.body.Name = "body";
            this.body.Padding = new System.Windows.Forms.Padding(10);
            this.body.Size = new System.Drawing.Size(1158, 482);
            this.body.TabIndex = 1;
            // 
            // Atendimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1158, 602);
            this.Controls.Add(this.body);
            this.Controls.Add(this.header);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Atendimento";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atendimento - Sistema Nheengatu";
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            this.bodyContainer.ResumeLayout(false);
            this.tab_agendamentos.ResumeLayout(false);
            this.agendamentos_container.ResumeLayout(false);
            this.agendamentos_content.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_agendamentos)).EndInit();
            this.agendamentos_navbar.ResumeLayout(false);
            this.agendamentos_navbar.PerformLayout();
            this.tab_clientes.ResumeLayout(false);
            this.clientes_container.ResumeLayout(false);
            this.clientes_content.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clientes)).EndInit();
            this.clientes_navbar.ResumeLayout(false);
            this.clientes_navbar.PerformLayout();
            this.body.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        System.Windows.Forms.Label titulo;
        System.Windows.Forms.Panel header;
        System.Windows.Forms.TabControl bodyContainer;
        System.Windows.Forms.TabPage tab_agendamentos;
        System.Windows.Forms.TabPage tab_clientes;
        System.Windows.Forms.Panel agendamentos_container;
        System.Windows.Forms.Panel agendamentos_content;
        System.Windows.Forms.DataGridView dgv_agendamentos;
        System.Windows.Forms.Panel body;
        System.Windows.Forms.Panel agendamentos_navbar;
        System.Windows.Forms.Panel clientes_container;
        System.Windows.Forms.Panel clientes_content;
        System.Windows.Forms.Panel clientes_navbar;
        System.Windows.Forms.Button btn_cadastro;
        System.Windows.Forms.DataGridView dgv_clientes;
        System.Windows.Forms.Button btn_agendamento;
        System.Windows.Forms.ComboBox agendamentos_search;
        System.Windows.Forms.Label lbl_naoHaClientes;
        System.Windows.Forms.Label subtitulo;
        System.Windows.Forms.TextBox clientes_search;
        System.Windows.Forms.Label lbl_naoHaAgendamentos;
        System.Windows.Forms.Button btn_mensageiro;
        System.Windows.Forms.Button btn_historico;
    }
}