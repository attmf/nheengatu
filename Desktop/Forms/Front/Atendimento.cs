using System;
using System.Windows.Forms;
using Core;
using System.Globalization;

namespace Desktop_app
{
    public partial class Atendimento : Form
    {
        public Atendimento()
        {
            InitializeComponent();

            titulo.Focus();
            ActiveControl = titulo;

            subtitulo.Text = "Bem vind{s}. {n}";
            subtitulo.Text = subtitulo.Text.Replace("{s}", Buscar.Usuario.Info["sexo"].ToString().Equals("F") ? "a {c}a" : "o {c}");
            subtitulo.Text = subtitulo.Text.Replace("{c}", Buscar.Usuario.IsTecnico ? "Dr" : "Sr");
            subtitulo.Text = subtitulo.Text.Replace("{n}", Buscar.Usuario.Nome);

            Preencher_agendamentos_search();

            Preencher_dgv_agendamentos(null, null);
            Preencher_dgv_clientes(null, null);

            if (Listar.Funcionarios.Tecnicos().Rows.Count.Equals(0))
            {
                tab_agendamentos.Dispose();
            }
        }

        void Preencher_agendamentos_search()
        {
            Preencher.ComboBox(agendamentos_search, Listar.Agendamentos.Datas(), "dia");
            agendamentos_search.SelectedValue = Datas.HojeFormatada;
            
            
        }

        void Preencher_dgv_agendamentos(object sender, EventArgs e)
        {
            try
            {
                Datas.Agora = Convert.ToDateTime(agendamentos_search.Text);
            }catch(Exception ex)
            {
                Datas.Agora = Convert.ToDateTime(Datas.HojeFormatada);
            }
            Preencher.GridView(dgv_agendamentos, Listar.Agendamentos.PorDia(Datas.Agora), Etiquetas.agendamentos, Etiquetas.agendamentos_weights, false);

            lbl_naoHaAgendamentos.Visible = dgv_agendamentos.Rows.Count.Equals(0);
        }

        void Preencher_dgv_clientes(object sender, EventArgs e)
        {
            Preencher.GridView(dgv_clientes, Listar.Clientes.PorNome(clientes_search.Text), Etiquetas.pessoas, Etiquetas.pessoas_weights, false);

            lbl_naoHaClientes.Visible = dgv_clientes.Rows.Count.Equals(0);
            btn_mensageiro.Visible = !dgv_clientes.Rows.Count.Equals(0);
            btn_historico.Visible = !dgv_clientes.Rows.Count.Equals(0) && Buscar.Usuario.IsTecnico;
        }

        void Definir_EditorID(object sender, DataGridViewCellEventArgs e)
        {
            Buscar.Editor.ID = Convert.ToInt32((sender as DataGridView).Rows[(sender as DataGridView).CurrentRow.Index].Cells["id"].Value);
            Buscar.Editor.CPF = (sender as DataGridView).Rows[(sender as DataGridView).CurrentRow.Index].Cells["cpf"].Value.ToString();
        }

        void Inserir_Objeto(object sender, EventArgs e)
        {
            Buscar.Editor.ID = 0;
            Buscar.Editor.CPF = string.Empty;
            Abrir_Formulario(sender, e);
        }

        void Abrir_Formulario(object sender, EventArgs e)
        {
            Buscar.Editor.Type = (sender as Control).Name.ToLower().Replace((sender as Control).Name.Substring(0, 4), string.Empty);

            if (Buscar.Editor.ID.Equals(0))
            {
                switch (Buscar.Editor.Type)
                {
                    case "agendamento":
                        new Agendamentos().ShowDialog(this);
                        Preencher_agendamentos_search();
                        break;

                    case "cadastro":
                        Buscar.Editor.CPF = string.Empty;
                        Buscar.Editor.Type = "cliente";
                        new Cadastro().ShowDialog(this);
                        break;
                }
            }
            else
            {
                switch (Buscar.Editor.Type)
                {
                    case "clientes":
                        Buscar.Editor.Type = "cliente";
                        new Cadastro().ShowDialog(this);
                        break;

                    case "agendamentos":
                        string situcao = (sender as DataGridView).Rows[(sender as DataGridView).CurrentRow.Index].Cells["situacao"].Value.ToString();
                        if (situcao.Equals(Etiquetas.situacoes[2]) || situcao.Equals(Etiquetas.situacoes[4]))
                        {
                            MessageBox.Show(Msg.ImpossivelEditar, Msg.Title.Atencao);
                        }
                        else
                        {
                            new Agendamentos().ShowDialog(this);
                        }
                        Preencher_agendamentos_search();
                        break;

                    case "mensageiro":
                        new Mensageiro().ShowDialog(this);
                        break;

                    case "historico":
                        new Historico().ShowDialog(this);
                        break;
                }
            }

            clientes_search.Text = "*";
            clientes_search.Text = string.Empty;
        }
    }
}
