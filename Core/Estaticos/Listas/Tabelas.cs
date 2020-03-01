using System;
using System.Data;

namespace Core
{
    public class Tabela
    {
        static DataTable table;
        
        public static DataTable Situacoes
        {
            get
            {
                table = new DataTable();
                table.Columns.Add("situacao");
                int limite = Etiquetas.situacoes.Length - (Buscar.Usuario.IsTecnico ? 0 : 2);

                for (int i = 0; i < limite; i++)
                {
                    table.Rows.Add(Etiquetas.situacoes[i]);
                }

                return table;
            }
        }

        public static DataTable Estados
        {
            get
            {
                table = new DataTable();
                table.Columns.Add("estado");

                for (int i = 0; i < Etiquetas.estados.Length; i++)
                {
                    table.Rows.Add(Etiquetas.estados[i]);
                }

                return table;
            }
        }

        public static DataTable Sexos
        {
            get
            {
                table = new DataTable();
                table.Columns.Add("sexo");

                for (int i = 0; i < Etiquetas.sexos.Length; i++)
                {
                    table.Rows.Add(Etiquetas.sexos[i]);
                }

                return table;
            }
        }

        public static class Horario
        {
            public static DataTable Geral
            {
                get
                {
                    table = new DataTable();
                    table.Columns.Add("hora");

                    for (int i = 0; i < 24; i++)
                    {
                        table.Rows.Add(((i < 10 ? "0" + i : i + string.Empty) + ":00:00"));
                    }

                    return table;
                }
            }

            public static DataTable Funcionamento
            {
                get
                {
                    DateTime abertura, fechamento;

                    table = new DataTable();
                    table.Columns.Add("hora");

                    abertura = Buscar.Estabelecimento.Abertura;
                    fechamento = Buscar.Estabelecimento.Fechamento.AddMinutes(Buscar.Estabelecimento.Atendimento);

                    while (abertura < fechamento)
                    {
                        table.Rows.Add(abertura.ToString("HH:mm:ss"));
                        abertura = abertura.AddMinutes(Buscar.Estabelecimento.Atendimento);
                    }

                    return table;
                }
            }
        }

        public static DataTable TempoDeAtendimento
        {
            get
            {
                table = new DataTable();
                table.Columns.Add("tempo");

                for (int i = 0; i < Etiquetas.atendimento.Length; i++)
                {
                    table.Rows.Add(Etiquetas.atendimento[i]);
                }

                return table;
            }
        }

    }
}
