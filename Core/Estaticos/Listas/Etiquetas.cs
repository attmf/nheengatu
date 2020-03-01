namespace Core
{
    public class Etiquetas
    {
        public static string[] agendamentos
        {
            get
            {
                return new [] { "ID", "Cliente", "Técnico", "Dia", "Hora", "Situação" };
            }
        }

        public static string[] agendamentos_finalizadas
        {
            get
            {
                return new [] { "ID", "Dia", "Hora", "Técnico" };
            }
        }

        public static string[] pessoas
        {
            get
            {
                return new [] { "ID", "Nome", "CPF", "Dt Nasc", "Sexo" };
            }
        }
        
        public static class Default
        {
            public static string[] Labels
            {
                get
                {
                    return new [] { "CPF", "Senha" };
                }
            }
            
            public static string[] Types
            {
                get
                {
                    return new [] { "txt", "pwd" };
                }
            }
            
            public static int[] Widths
            {
                get
                {
                    return new [] { 12, 12 };
                }
            }
            
            public static int[] Lengths
            {
                get
                {
                    return new [] { 11, 16 };
                }
            }
        }
        
        public static class Configuracoes
        {
            public static string[] Labels
            {
                get
                {
                    return new [] { "Mudar senha", "Atualizar endereço" };
                }
            }
            
            public static string[] Urls
            {
                get
                {
                    return new [] { "senha", "endereco" };
                }
            }
            
            public static class Senha
            {
                public static string[] Fields
                {
                    get
                    {
                        return new [] { "Senha atual", "Nova senha", "Lembrete de senha" };
                    }
                }
                
                public static string[] Types
                {
                    get
                    {
                        return new [] { "pwd", "pwd", "txt" };
                    }
                }
                
                public static int[] Widths
                {
                    get
                    {
                        return new [] { 4, 4, 4 };
                    }
                }
                
                public static int[] Lengths
                {
                    get
                    {
                        return new [] { 16, 16, 20 };
                    }
                }
            }
        }

        public static class Nav
        {
            public static string[] Labels
            {
                get
                {
                    return new [] { "Meus Agendamentos", "Central de Mensagens", "Editor de Configurações", "Desconectar" };
                }
            }

            public static string[] Urls
            {
                get
                {
                    return new [] { "Agendamentos", "Mensagens", "Configuracoes", "Logout" };
                }
            }
        }

        public static string[] sexos
        {
            get
            {
                return new [] { "F", "M" };
            }
        }

        public static string[] estados
        {
            get
            {
                return new[] { "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO" };
            }
        }

        public static string[] situacoes
        {
            get
            {
                return new[] { "Agendado", "Atrasado", "Cancelado", "Em atendimento", "Finalizado" };
            }
        }

        public static int[] agendamentos_weights
        {
            get
            {
                return new [] { 5, 30, 30, 15, 10, 10 };
            }
        }

        public static int[] agendamentos_finalizadas_weights
        {
            get
            {
                return new [] { 5, 10, 15, 70 };
            }
        }

        public static int[] pessoas_weights
        {
            get
            {
                return new [] { 5, 50, 25, 15, 5 };
            }
        }

        public static int[] atendimento
        {
            get
            {
                return new [] { 5, 10, 15, 20, 25, 30 };
            }
        }

        public static class Endereco
        {
            public static string[] Fields
            {
                get
                {
                    return new [] { "CEP", "Numero", "Complemento", "Logradouro", "Bairro", "Cidade", "UF" };
                }
            }

            public static int[] Widths
            {
                get
                {
                    return new [] { 3, 3, 6, 12, 5, 5, 2 };
                }
            }

            public static int[] Lengths
            {
                get
                {
                    return new [] { 10, 6, 40, 40, 40, 40, 2 };
                }
            }
        }
    }
}
