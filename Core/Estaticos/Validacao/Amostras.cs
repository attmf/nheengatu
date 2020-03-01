namespace Core
{
    public class Amostras
    {
        public static class Letras
        {
            public static string[] Campos
            {
                get
                {
                    return new [] { "nome", "razao_social", "cargo", "especialidade" };
                }
            }

            public static string Pattern
            {
                get
                {
                    return @"^[a-zà-ú\s]+$";
                }
            }

        }

        public static class LetrasHifen
        {
            public static string[] Campos
            {
                get
                {
                    return new [] { "nome_fantasia", "logradouro", "cidade", "bairro" };
                }
            }

            public static string Pattern
            {
                get
                {
                    return @"^[a-zà-ú\s-]+$";
                }
            }
        }

        public static class LetrasHifenNumeros
        {
            public static string[] Campos
            {
                get
                {
                    return new [] { "complemento" };
                }
            }

            public static string Pattern
            {
                get
                {
                    return @"^[0-9a-zà-ú\s-]+$";
                }
            }
        }

        public static class LetrasHifenNumerosArrobaUnderline
        {
            public static string[] Campos
            {
                get
                {
                    return new [] { "email" };
                }
            }

            public static string Pattern
            {
                get
                {
                    return @"^[0-9a-z._-]+@[a-z0-9.-]+.[a-z]{2,4}$";
                }
            }
        }

        public static class LetrasHifenNumerosArrobaUnderlinePontuacao
        {
            public static string[] Campos
            {
                get
                {
                    return new [] { "mensagem" };
                }
            }

            public static string Pattern
            {
                get
                {
                    return @"^[0-9a-zà-ú!@#$%&*()[]{}+,.;/°ºª¹²³\s-]+$";
                }
            }
        }

        public static class Numeros
        {
            public static string[] Campos
            {
                get
                {
                    return new [] { "numero", "registro" };
                }
            }

            public static string Pattern
            {
                get
                {
                    return @"^[0-9]+$";
                }
            }
        }

        public static class NumerosComMascara
        {
            public static string[] Campos
            {
                get
                {
                    return new [] { "cpf", "cnpj", "cep", "telefone", "celular" };
                }
            }
        }
    }
}
