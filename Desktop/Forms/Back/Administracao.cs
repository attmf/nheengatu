using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Core;

namespace Desktop_app
{
    public partial class Administracao : Form
    {
        DataTable table;
        DataRow row;
        List<object> list;
        TextBox textBox;
        bool resultado;
        int currentRow;
        string item;

        public Administracao()
        {
            InitializeComponent();

            Preencher.ComboBox(uf_input, Tabela.Estados, "estado");
            Preencher.ComboBox(abertura_input, Tabela.Horario.Geral, "hora");
            Preencher.ComboBox(fechamento_input, Tabela.Horario.Geral, "hora");
            Preencher.ComboBox(atendimento_input, Tabela.TempoDeAtendimento, "tempo");

            Preencher_dgv_funcionarios(null, null);
            Preencher_cargos_especialidades();
        }

        void Preencher_cargos_especialidades()
        {
            Preencher.ComboBox(cargo_default, Listar.Cargos.Todos, "titulo", "id");
            Preencher.ListBox(boxCargos, Listar.Cargos.Todos, "titulo", "id");

            Preencher.ComboBox(especialidade_default, Listar.Especialidades.Todos, "titulo", "id");
            Preencher.ListBox(boxEspecialidades, Listar.Especialidades.Todos, "titulo", "id");

            Atualizar_estabelecimento_Info();
        }

        void Preencher_dgv_funcionarios(object sender, EventArgs e)
        {
            item = sender == null ? string.Empty : (sender as Control).Text;
            table = Listar.Funcionarios.PorNome(item);

            Preencher.GridView(dgv_funcionarios, table, Etiquetas.pessoas, Etiquetas.pessoas_weights, false);

            lbl_naoHaFuncionarios.Visible = dgv_funcionarios.Rows.Count.Equals(0);
        }

        void Funcionario_editar(object sender, EventArgs e)
        {
            var dgv = sender as DataGridView;
            currentRow = dgv.CurrentRow.Index;
            item = dgv.Rows[currentRow].Cells[0].Value.ToString();

            Buscar.Editor.Type = "funcionario";
            Buscar.Editor.ID = Convert.ToInt32(item);

            new Cadastro().ShowDialog(this);
            Preencher_dgv_funcionarios(null, null);
        }

        void Funcionario_inserir(object sender, EventArgs e)
        {
            Buscar.Editor.ID = 0;
            Buscar.Editor.CPF = string.Empty;
            Buscar.Editor.Type = "funcionario";

            new Cadastro().ShowDialog(this);
            Preencher_dgv_funcionarios(null, null);
        }

        void Submit_estabelecimento(object sender, EventArgs e)
        {
            resultado = false;

            if (Validar.Formulario(editor))
            {
                Preencher.List(list = new List<object>(), editor);

                habilitar_edicao.Checked = false;
                resultado = Buscar.Estabelecimento.Info.Rows.Count.Equals(0) ? Inserir.Estabelecimento(list) : Alterar.Estabelecimento.Info(list);
                Preencher_cargos_especialidades();
            }

            Msg.Response(resultado, Msg.PreechimentoIncorreto);
        }

        void Submit_estabelecimento_cargoEspecialidade(object sender, EventArgs e)
        {
            resultado = false;

            if (!Buscar.Estabelecimento.Info.Rows.Count.Equals(0))
            {
                if (Validar.Formulario(cargoEspecialidade_padrao))
                {
                    Preencher.List(list = new List<object>(), cargoEspecialidade_padrao);

                    resultado = Alterar.Estabelecimento.CargoEspecialidade(list);
                    Preencher_cargos_especialidades();
                }
            }

            Msg.Response(resultado, Msg.PreechimentoIncorreto);
        }

        void Submit_estabelecimento_cargoEspecialidade_inserir(object sender, EventArgs e)
        {
            Buscar.Editor.IsTrue = (sender as Control).Name.Contains("cargo");

            textBox = Buscar.Editor.IsTrue ? cargo_input : especialidade_input;
            resultado = false;

            if (Validar.Formulario(textBox.Parent as Panel))
            {
                item = textBox.Text.ToLower().Trim();
                table = Buscar.Editor.IsTrue ? Listar.Cargos.Todos : Listar.Especialidades.Todos;

                Preencher.List(list = new List<object>(), table, 0, "titulo");

                if (!list.Contains(item))
                {
                    resultado = Buscar.Editor.IsTrue ? Inserir.Cargo(item) : Inserir.Especialidade(item);
                    textBox.Clear();
                    titulo.Focus();
                }
            }

            Preencher_cargos_especialidades();

            Msg.Response(resultado, Msg.PreechimentoIncorreto);
        }

        void Habilitar_edicao(object sender, EventArgs e)
        {
            editor.Enabled = habilitar_edicao.Checked;
            cnpj_input.Focus();
        }

        void Atualizar_estabelecimento_Info()
        {
            if (!Buscar.Estabelecimento.Info.Rows.Count.Equals(0))
            {
                row = Buscar.Estabelecimento.Info.Rows[0];

                Preencher.Panel(editor, row);
                Preencher.Panel(cargoEspecialidade_padrao, row, 16);

                cargoEspecialidade_padrao.Visible = !especialidade_default.Items.Count.Equals(0) && !cargo_default.Items.Count.Equals(0);
                btn_novoFuncionario.Visible = !Buscar.Estabelecimento.CargoTecnico.Equals(0) && !Buscar.Estabelecimento.EspecialidadeNenhuma.Equals(0);
            }
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
