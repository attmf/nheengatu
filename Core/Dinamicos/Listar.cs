using System.Data;

namespace Core
{
    public class Listar : DtBase
    {

        public static class Administradores
        {
            public static DataTable All
            {
                get
                {
                    return Executar.Reader("usp_listar_administradores");
                }
            }
        }

        public static class Cargos
        {
            public static DataTable Todos
            {
                get
                {
                    return Executar.Reader("usp_listar_cargos");
                }
            }
        }

        public static class Especialidades
        {
            public static DataTable Todos
            {
                get
                {
                    return Executar.Reader("usp_listar_especialidades");
                }
            }

        }
        
        public static class Clientes
        {
            public static DataTable PorNome(object value1 = null)
            {
                return Executar.Reader("usp_listar_clientes", value1);
            }
        }
        
        public static class Funcionarios
        {
            public static DataTable PorNome(object value1)
            {
                return Executar.Reader("usp_listar_funcionarios", value1);
            }
            
            public static DataTable Tecnicos()
            {
                return Executar.Reader("usp_listar_funcionarios_tecnicos", Buscar.Estabelecimento.CargoTecnico);
            }
        }
        
        public static class Agendamentos
        {
            public static DataTable PorDia(object value1)
            {
                return Executar.Reader("usp_listar_agendamentos", value1, (Buscar.Usuario.IsTecnico ? Buscar.Usuario.ID : 0));
            }
            
            public static DataTable PorCliente(int value1)
            {
                return Executar.Reader("usp_listar_agendamentos_cliente", value1);
            }
            
            public static DataTable Datas()
            {
                return Executar.Reader("usp_listar_agendamentos_datas", Buscar.Usuario.IsTecnico ? Buscar.Usuario.ID : 0);
            }
            
            public static DataTable Finalizados()
            {
                return Executar.Reader("usp_listar_agendamentos_finalizados", Buscar.Editor.CPF);
            }
        }
        
        public static class Mensagens
        {
            public static DataTable Contatos()
            {
                return Executar.Reader("usp_listar_mensagens_contatos", Buscar.Usuario.ID, Buscar.Usuario.Classe);
            }

            public static DataTable All()
            {
                return Executar.Reader("usp_listar_mensagens", Buscar.Usuario.ID, Buscar.Editor.ID);
            }
        }
    }
}