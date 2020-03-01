using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Core
{
    public class Inserir : DtBase
    {
        public static bool Agendamento(List<object> list)
        {
            counter = 0;

            command = new SqlCommand("usp_inserir_agendamento", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@cliente", list[counter++]);
            command.Parameters.AddWithValue("@tecnico", list[counter++]);
            command.Parameters.AddWithValue("@dia", Convert.ToDateTime(list[counter++]));
            command.Parameters.AddWithValue("@hora", Convert.ToDateTime(list[counter++]));

            return Executar.NonQuery();
        }

        public static bool Cargo(object titulo)
        {
            command = new SqlCommand("usp_inserir_cargo", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@titulo", titulo);
            return Executar.NonQuery();
        }

        public static bool Especialidade(object titulo)
        {
            command = new SqlCommand("usp_inserir_especialidade", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@titulo", titulo);

            return Executar.NonQuery();
        }

        public static bool Funcionario(List<object> list)
        {
            counter = 0;

            command = new SqlCommand("usp_inserir_funcionario", connection);
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
            command.Parameters.AddWithValue("@cargo", Convert.ToInt32(list[counter++]));
            command.Parameters.AddWithValue("@especialidade", Convert.ToInt32(list[counter++]));
            command.Parameters.AddWithValue("@registro", list[counter++]);
            command.Parameters.AddWithValue("@registro_uf", list[counter++]);

            return Executar.NonQuery();
        }

        public static bool Cliente(List<object> list)
        {
            counter = 0;

            command = new SqlCommand("usp_inserir_cliente", connection);
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

            return Executar.NonQuery();
        }

        public static bool Estabelecimento(List<object> list)
        {
            counter = 0;

            command = new SqlCommand("usp_inserir_estabelecimento", connection);
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

        public static bool Mensagem(List<object> list)
        {
            counter = 0;

            command = new SqlCommand("usp_inserir_mensagem", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@destinatario", list[counter++]);
            command.Parameters.AddWithValue("@remetente", list[counter++]);
            command.Parameters.AddWithValue("@classe", list[counter++]);
            command.Parameters.AddWithValue("@conteudo", list[counter++]);

            return Executar.NonQuery();
        }
    }
}
