using System;
using System.Data;
using System.Web.UI;
using Core;

namespace Web_app
{
    public partial class Agendamentos : Page
    {
        string body, container = "<div class='col margin-bottom'>{%}</div>";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Buscar.Usuario.ID.Equals(0))
            {
                Response.Redirect("Logout.aspx");
            }
            
            var table = Listar.Agendamentos.PorCliente(Buscar.Usuario.ID);

            if (table.Rows.Count.Equals(0))
            {
                body = container.Replace("{%}", Msg.NaoHaRegistros);
            }
            else
            {
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    Buscar.Editor.ID = Convert.ToInt32(table.Rows[i]["id"]);

                    body += Snippets.Agendamento.Home;

                    body = body.Replace("{m}", Buscar.Agendamento.Info["tecnico"].ToString());
                    body = body.Replace("{e}", Buscar.Agendamento.Info["especialidade"].ToString());
                    body = body.Replace("{d}", Buscar.Agendamento.Info["dia"].ToString());
                    body = body.Replace("{h}", Buscar.Agendamento.Info["hora"].ToString());
                    body = body.Replace("{s}", Buscar.Agendamento.Info["situacao"].ToString().Equals("Finalizado") ? "{l}" : Buscar.Agendamento.Info["situacao"].ToString());
                    body = body.Replace("{l}", Criar.Links(new [] { Buscar.Agendamento.Info["situacao"].ToString() }));
                    body = body.Replace("{i}", Buscar.Agendamento.Info["id"].ToString());
                    body = body.Replace("{u}", "Agendamentos_resumo");
                }
            }

            page_content.InnerHtml = Criar.Output(body);
        }
    }
}
