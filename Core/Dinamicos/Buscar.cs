using System;
using System.Collections.Generic;
using System.Data;
namespace Core
{
    public class Buscar : DtBase
    {
        public static class Estabelecimento
        {
            public static DataTable Info
            {
                get
                {
                    return Executar.Reader("usp_buscar_estabelecimento");
                }
            }
            
            public static int CargoTecnico
            {
                get
                {
                    return Convert.ToInt32(Info.Rows[0]["cargo_tecnico"]);
                }
            }

            public static int EspecialidadeNenhuma
            {
                get
                {
                    return Convert.ToInt32(Info.Rows[0]["especialidade_nenhuma"]);
                }
            }

            public static DateTime Abertura
            {
                get
                {
                	return Convert.ToDateTime(Convert.ToString(Info.Rows[0]["abertura"]));
                }
            }

            public static DateTime Fechamento
            {
                get
                {
                	return Convert.ToDateTime(Convert.ToString(Info.Rows[0]["fechamento"]));
                }
            }

            public static int Atendimento
            {
                get
                {
                    return Convert.ToInt32(Info.Rows[0]["atendimento"]);
                }
            }

            public static string NomeFantasia
            {
                get
                {
                    return Info.Rows[0]["nome_fantasia"].ToString();
                }
            }

            public static string Telefone
            {
                get
                {
                    return Info.Rows[0]["telefone"].ToString();
                }
            }
        }

        public static class Usuario
        {
            public static void Login(object value1, object value2)
            {
                table = Executar.Reader("usp_buscar_{c}_login".Replace("{c}", Classe), value1, value2);
                
                if (!table.Rows.Count.Equals(0))
                {
                    ID = Convert.ToInt32(table.Rows[0]["id"]);
                }
                else
                {
                    ID = 0;
                }
            }

            public static string Classe
            {
                get;
                set;
            }

            public static DataRow Info
            {
                get
                {
                    return Executar.Reader("usp_buscar_{c}".Replace("{c}", Classe), ID).Rows[0];
                }
            }

            public static int ID
            {
                get;
                set;
            }

            public static string Nome
            {
                get
                {
                    return Info["nome"].ToString();
                }
            }
            
            public static string Especialidade
            {
                get
                {
                    return Info["especialidade_titulo"].ToString();
                }
            }
            
            public static int Cargo
            {
                get
                {
                    return Convert.ToInt32(Info["cargo"]);
                }
            }

            public static bool IsTecnico
            {
                get
                {
                    return Convert.ToInt32(Info["cargo"]).Equals(Estabelecimento.CargoTecnico);
                }
            }
        }

        public static class Agendamento
        {
            public static DataRow Info
            {
                get
                {
                    return Executar.Reader("usp_buscar_agendamento", Buscar.Editor.ID).Rows[0];
                }
            }

            public static bool Overbooking(List<object> list, int id = 0, int startAt = 0)
            {
                table = Executar.Reader("usp_buscar_agendamento_overbook", list[startAt++], list[startAt++], list[startAt++], id);
                return table.Rows.Count.Equals(0);
            }
        }
        
        public static class Mensagens
        {
            public static DataTable Conversa(object value1)
            {
                return Executar.Reader("usp_listar_mensagens", value1, Usuario.ID);
            }
           // public static bool Situacao()
          //  {
            //    return Executar.Reader("usp_buscar_mensagem_situacao", Buscar.Usuario.ID, Buscar.Editor.ID);
           // }
        }
        
        public static class Editor
        {
            public static int ID
            {
                get;
                set;
            }
        
            public static string CPF
            {
                get;
                set;
            }
        
            public static string Type
            {
                get;
                set;
            }
        
            public static bool IsTrue
            {
                get;
                set;
            }
        
            public static bool IsCadastrado(object value1)
            {
                return Buscar.Executar.Reader("usp_buscar_{c}".Replace("{c}", Buscar.Editor.Type), value1).Rows.Count.Equals(1);
            }
        
            public static bool IsMensagem
            {
                get;
                set;
            }
        }
    }
}