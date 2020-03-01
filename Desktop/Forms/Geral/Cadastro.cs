using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Core;

namespace Desktop_app
{
    public partial class Cadastro : Form
    {
        DataRow row;
        List<object> list;
        bool resultado, is_CargoTecnico, is_EspecialidadeNenhuma;

        public Cadastro()
        {
            InitializeComponent();
            Preencher_Etiquetas();

            funcionarios_inputs.Visible = Buscar.Editor.Type.Equals("funcionario");
            nascimento_input.MaxDate = Datas.Hoje;
            nascimento_input.Text = Datas.HojeFormatada;

            Text = "{acao} de {ator}";
            Text = Text.Replace("{acao}", Buscar.Editor.ID.Equals(0) ? "Cadastrar" : "Editar dados");
            Text = Text.Replace("{ator}", Buscar.Editor.Type);

            Height -= Buscar.Editor.ID.Equals(0) ? habilitar_edicao_input.Height : 0;
            Height -= Buscar.Editor.Type.Equals("funcionario") ? 0 : funcionarios_inputs.Height;

            if (!Buscar.Editor.CPF.Equals(string.Empty))
            {
                cpf_input.Text = Buscar.Editor.CPF;
                cpf_input.Enabled = cpf_label.Enabled = false;
            }

            if (!Buscar.Editor.ID.Equals(0))
            {
                row = Buscar.Executar.Reader("usp_buscar_{t}".Replace("{t}", Buscar.Editor.Type), Buscar.Editor.ID).Rows[0];

                Preencher.Panel(comum_inputs, row, 1);

                if (Buscar.Editor.Type.Equals("funcionario"))
                {
                    Preencher.Panel(funcionarios_inputs, row, 15);
                }

                cpf_label.Enabled = cpf_input.Enabled = editor.Enabled = false;
                habilitar_edicao_input.Visible = true;
            }
        }

        void Preencher_Etiquetas()
        {
            Preencher.ComboBox(sexo_input, Tabela.Sexos, "sexo");
            Preencher.ComboBox(uf_input, Tabela.Estados, "estado");
            Preencher.ComboBox(registro_uf_input, Tabela.Estados, "estado");
            Preencher.ComboBox(cargo_input, Listar.Cargos.Todos, "titulo", "id");
            Preencher.ComboBox(especialidade_input, Listar.Especialidades.Todos, "titulo", "id");

            especialidade_input.SelectedValue = Buscar.Estabelecimento.EspecialidadeNenhuma;
        }

        void Habilitar_edicao(object sender, EventArgs e)
        {
            editor.Enabled = habilitar_edicao_input.Checked;
        }

        void Habilita_RegistroProfissional(object sender, EventArgs e)
        {
            registro_input.Enabled = registro_label.Enabled = registro_uf_input.Enabled = registro_uf_label.Enabled = especialidade_input.Enabled = especialidade_label.Enabled = (sender as ComboBox).SelectedValue.Equals(Buscar.Estabelecimento.CargoTecnico);

            especialidade_input.SelectedValue = Buscar.Estabelecimento.EspecialidadeNenhuma;
            registro_input.Text = string.Empty;
        }

        void Submit_Cadastro(object sender, EventArgs e)
        {
            resultado = false;
            
            if (Validar.Formulario(comum_inputs))
            {
                Preencher.List(list = new List<object>(), comum_inputs);

                switch (Buscar.Editor.Type)
                {
                    case "funcionario":
                        if (Validar.Formulario(funcionarios_inputs))
                        {
                            Preencher.List(list, funcionarios_inputs);

                            if (Buscar.Editor.ID.Equals(0))
                            {
                                if (Buscar.Editor.IsCadastrado(cpf_input.Text))
                                {
                                    Msg.Response(resultado, Msg.JaExisteCadastro);
                                    cpf_input.Focus();
                                }
                                else
                                {
                                    resultado = Inserir.Funcionario(list);
                                }
                            }
                            else
                            {
                                resultado = Alterar.Funcionario.Info(list);
                            }
                        }
                        break;

                    case "cliente":
                        if (Buscar.Editor.ID.Equals(0))
                        {
                            if (Buscar.Editor.IsCadastrado(list[1]))
                            {
                                Msg.Response(resultado, Msg.JaExisteCadastro);
                                cpf_input.Focus();
                            }
                            else
                            {
                                resultado = Inserir.Cliente(list);

                                if (resultado)
                                {
                                    Buscar.Editor.CPF = list[1].ToString();

                                    list = new List<object>
                                    {
                                        Buscar.Editor.CPF,
                                        Buscar.Usuario.ID,
                                        Buscar.Usuario.Classe,
                                        Msg.BoasVindas
                                    };

                                    Inserir.Mensagem(list);
                                }
                            }
                        }
                        else
                        {
                            resultado = Alterar.Cliente.Info(list);
                        }
                        break;
                }

                Msg.Response(resultado, Msg.AcaoNaoRealizada);
            }
            else
            {
                Msg.Response(resultado, Msg.PreechimentoIncorreto);
            }

            if (resultado)
            {
                Dispose();
                Close();
            }
        }

        void Definir_especialidade(object sender, EventArgs e)
        {
            is_CargoTecnico = cargo_input.SelectedValue.Equals(Buscar.Estabelecimento.CargoTecnico);
            is_EspecialidadeNenhuma = especialidade_input.SelectedValue.Equals(Buscar.Estabelecimento.EspecialidadeNenhuma);

            if (is_CargoTecnico && is_EspecialidadeNenhuma)
            {
                MessageBox.Show(Msg.DefinaEspecialidade);
                especialidade_input.Focus();
            }
        }
    }
}
