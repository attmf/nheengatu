using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Core
{
    public class Alterar : DtBase
    {
        public static class Administrador
        {
            public static void Login(List<object> list)
            {
                counter = 0;
                command = new SqlCommand("usp_alterar_administrador_login", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("id", Convert.ToInt32(list[counter++]));
                command.Parameters.AddWithValue("senha", list[counter++]);

                Executar.NonQuery();
            }
        }
        
        public class Agendamento
        {
            public static bool Info(List<object> list, int starAt = 0)
            {
                command = new SqlCommand("usp_alterar_agendamento", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@tecnico", list[starAt++]);
                command.Parameters.AddWithValue("@dia", Convert.ToDateTime(list[starAt++]));
                command.Parameters.AddWithValue("@hora", Convert.ToDateTime(list[starAt++]));
                command.Parameters.AddWithValue("@situacao", list[starAt++]);
                command.Parameters.AddWithValue("@id", Buscar.Editor.ID);

                return Executar.NonQuery();
            }

            public static bool Resumos(List<object> list, int startAt = 0)
            {
                command = new SqlCommand("usp_alterar_agendamento_resumos", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@resumo_tecnico", list[startAt++]);
                command.Parameters.AddWithValue("@resumo_cliente", list[startAt++]);
                command.Parameters.AddWithValue("@medicamentos", list[startAt++]);
                command.Parameters.AddWithValue("@encaminhamentos", list[startAt++]);
                command.Parameters.AddWithValue("@id", Buscar.Editor.ID);

                return Executar.NonQuery();
            }
        }

        public class Cliente
        {
            public static bool Info(List<object> list)
            {
                counter = 0;
                command = new SqlCommand("usp_alterar_cliente", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@nome", list[counter++]);
                command.Parameters.AddWithValue("@cpf", list[counter++]);
                command.Parameters.AddWithValue("@nascimento", Convert.ToDateTime(list[counter++]));
                command.Parameters.AddWithValue("@sexo", list[counter++]);
                command.Parameters.AddWithValue("@cep", list[counter++]);
                command.Parameters.AddWithValue("@numero", list[counter++]);
                command.Parameters.AddWithValue("@complemento", list[counter++]);
                command.Parameters.AddWithValue("@logradouro", list[counter++]);
                command.Parameters.AddWithValue("@bairro", list[counter++]);
                command.Parameters.AddWithValue("@cidade", list[counter++]);
                command.Parameters.AddWithValue("@uf", list[counter++]);
                command.Parameters.AddWithValue("@email", list[counter++]);
                command.Parameters.AddWithValue("@telefone", list[counter++]);
                command.Parameters.AddWithValue("@celular", list[counter++]);
                command.Parameters.AddWithValue("@id", Buscar.Editor.ID);

                return Executar.NonQuery();
            }

            public static bool Endereco(List<object> list)
            {
                counter = Buscar.Editor.ID.Equals(0) ? 0 : counter;

                command = new SqlCommand("usp_alterar_cliente_endereco", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@cep", list[counter++]);
                command.Parameters.AddWithValue("@numero", list[counter++]);
                command.Parameters.AddWithValue("@complemento", list[counter++]);
                command.Parameters.AddWithValue("@logradouro", list[counter++]);
                command.Parameters.AddWithValue("@bairro", list[counter++]);
                command.Parameters.AddWithValue("@cidade", list[counter++]);
                command.Parameters.AddWithValue("@uf", list[counter++]);
                command.Parameters.AddWithValue("@id", Buscar.Editor.ID.Equals(0) ? Buscar.Usuario.ID : Buscar.Editor.ID);

                return Executar.NonQuery();
            }

            public static bool Login(List<object> list)
            {
                counter = 0;

                command = new SqlCommand("usp_alterar_cliente_login", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@senha_antiga", list[counter++]);
                command.Parameters.AddWithValue("@senha_nova", list[counter++]);
                command.Parameters.AddWithValue("@lembrete", list[counter++]);
                command.Parameters.AddWithValue("@id", Buscar.Usuario.ID);

                return Executar.NonQuery();
            }
        }

        public class Estabelecimento
        {
            public static bool Info(List<object> list)
            {
                counter = 0;

                command = new SqlCommand("usp_alterar_estabelecimento", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@cnpj", list[counter++]);
                command.Parameters.AddWithValue("@razao_social", list[counter++]);
                command.Parameters.AddWithValue("@nome_fantasia", list[counter++]);
                command.Parameters.AddWithValue("@cep", list[counter++]);
                command.Parameters.AddWithValue("@numero", list[counter++]);
                command.Parameters.AddWithValue("@complemento", list[counter++]);
                command.Parameters.AddWithValue("@logradouro", list[counter++]);
                command.Parameters.AddWithValue("@bairro", list[counter++]);
                command.Parameters.AddWithValue("@cidade", list[counter++]);
                command.Parameters.AddWithValue("@uf", list[counter++]);
                command.Parameters.AddWithValue("@email", list[counter++]);
                command.Parameters.AddWithValue("@telefone", list[counter++]);
                command.Parameters.AddWithValue("@celular", list[counter++]);
                command.Parameters.AddWithValue("@abertura", Convert.ToDateTime(list[counter++]));
                command.Parameters.AddWithValue("@fechamento", Convert.ToDateTime(list[counter++]));
                command.Parameters.AddWithValue("@atendimento", list[counter++]);

                return Executar.NonQuery();
            }

            public static bool CargoEspecialidade(List<object> list)
            {
                counter = 0;

                command = new SqlCommand("usp_alterar_estabelecimento_cargo_especialidade", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@cargo_tecnico", list[counter++]);
                command.Parameters.AddWithValue("@especialidade_nenhuma", list[counter++]);

                return Executar.NonQuery();
            }
        }

        public class Funcionario
        {
            public static bool Info(List<object> list)
            {
                counter = 0;

                command = new SqlCommand("usp_alterar_funcionario", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@nome", list[counter++]);
                command.Parameters.AddWithValue("@cpf", list[counter++]);
                command.Parameters.AddWithValue("@nascimento", Convert.ToDateTime(list[counter++]));
                command.Parameters.AddWithValue("@sexo", list[counter++]);
                command.Parameters.AddWithValue("@cep", list[counter++]);
                command.Parameters.AddWithValue("@numero", list[counter++]);
                command.Parameters.AddWithValue("@complemento", list[counter++]);
                command.Parameters.AddWithValue("@logradouro", list[counter++]);
                command.Parameters.AddWithValue("@bairro", list[counter++]);
                command.Parameters.AddWithValue("@cidade", list[counter++]);
                command.Parameters.AddWithValue("@uf", list[counter++]);
                command.Parameters.AddWithValue("@email", list[counter++]);
                command.Parameters.AddWithValue("@telefone", list[counter++]);
                command.Parameters.AddWithValue("@celular", list[counter++]);
                command.Parameters.AddWithValue("@cargo", list[counter++]);
                command.Parameters.AddWithValue("@especialidade", list[counter++]);
                command.Parameters.AddWithValue("@registro", list[counter++]);
                command.Parameters.AddWithValue("@registro_uf", list[counter++]);
                command.Parameters.AddWithValue("@id", Buscar.Editor.ID.Equals(0) ? Buscar.Usuario.ID : Buscar.Editor.ID);

                return Executar.NonQuery();
            }

            public static bool Login(List<object> list)
            {
                counter = 0;

                command = new SqlCommand("usp_alterar_funcionario_login", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@senha_antiga", list[counter++]);
                command.Parameters.AddWithValue("@senha_nova", list[counter++]);
                command.Parameters.AddWithValue("@lembrete", list[counter++]);
                command.Parameters.AddWithValue("@id", Buscar.Usuario.ID);

                return Executar.NonQuery();
            }
        }
    }
}
