using System.Windows.Forms;

namespace Core
{
    public class Msg
    {
        public static void Response(bool TheTruth, string Mensagem)
        {
            if (TheTruth)
            {
                MessageBox.Show(AcaoRealizada, Title.Sucesso);
            }
            else
            {
                MessageBox.Show(Mensagem, Title.Atencao);
            }
        }

        public class Title
        {
            public static string Erro
            {
                get
                {
                    return "Erro!";
                }
            }

            public static string Atencao
            {
                get
                {
                    return "Atencao!";
                }
            }

            public static string Sucesso
            {
                get
                {
                    return "Sucesso!";
                }
            }
        }

        public static string AcaoRealizada
        {
            get
            {
                return "Dados inseridos corretamente";
            }
        }

        public static string AcaoNaoRealizada
        {
            get
            {
                return "Não foi possível realizar a ação";
            }
        }

        public static string CpfSenhaNaoCoincide
        {
            get
            {
                return "CPF/Senha não coincide";
            }
        }

        public static string SenhaNaoCoincide
        {
            get
            {
                return "Senha atual não coincide";
            }
        }

        public static string JaExisteItem
        {
            get
            {
                return "Já existe um cadastro com este rótulo";
            }
        }

        public static string JaExisteCadastro
        {
            get
            {
                return "Já existe um cadastro com este CPF";
            }
        }

        public static string NaoCadastrado
        {
            get
            {
                return "O CPF informado não está cadastrado";
            }
        }

        public static string Overbooking
        {
            get
            {
                return "Não é possível continuar, selecione um horário diferente";
            }
        }

        public static string PreechimentoIncorreto
        {
            get
            {
                return "Um ou mais campos não foram preenchidos corretamente.\nRevise o formulário antes de continuar";
            }
        }

        public static string  NaoHaRegistros
        {
            get
            {
                return "Não há registros";
            }
        }

        public static string ImpossivelExibirResumo
        {
            get
            {
                return "Não é possível exibir resumo para agendamento selecionada";
            }
        }
        
        public static string ImpossivelEditar
        {
            get
            {
                return "Não é possível editar um registro cancelado ou finalizado";
            }
        }

        public static string DefinirDados
        {
            get
            {
                return "Antes de continuar você precisa definir:\n\n- Dados do estabelecimento\n- Cargo técnico\n- Indicativo sem especialidade";
            }
        }

        public static string DefinaEspecialidade
        {
            get
            {
                return "Defina especialidade técnica";
            }
        }

        public static string BoasVindas
        {
            get
            {
                string mensagem;

                mensagem = "Olá, seja bem vindo a {e}. Informamos que nosso horário de funcionamento é das {fi} até às {ff}. Se precisar falar conosco por telefone, utilize o número {t}. Obrigado pela sua visita. Atenciosamente, {u}";

                mensagem = mensagem.Replace("{e}", Buscar.Estabelecimento.NomeFantasia);
                mensagem = mensagem.Replace("{fi}", Buscar.Estabelecimento.Abertura.ToString("HH:mm"));
                mensagem = mensagem.Replace("{ff}", Buscar.Estabelecimento.Fechamento.ToString("HH:mm"));
                mensagem = mensagem.Replace("{t}", Buscar.Estabelecimento.Telefone);
                mensagem = mensagem.Replace("{u}", Buscar.Usuario.Nome);

                return mensagem;
            }
        }
    }
}
