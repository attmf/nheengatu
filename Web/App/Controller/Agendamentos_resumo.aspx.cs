using System;
using System.Web.UI;
using Core;

namespace Web_app
{
    public partial class Agendamentos_resumo : Page
    {
        string body;

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Buscar.Usuario.ID.Equals(0))
                {
                    Response.Redirect("Logout.aspx");
                }

                body = Snippets.Agendamento.Resumo;
                Buscar.Editor.ID = Convert.ToInt32(Request.QueryString["id"]);

                if (Buscar.Agendamento.Info["situacao"].ToString().ToLower().Equals("finalizado") && Buscar.Agendamento.Info["cliente_id"].Equals(Buscar.Usuario.ID))
                {
                    body = body.Replace("{m}", Buscar.Agendamento.Info["tecnico"].ToString());
                    body = body.Replace("{e}", Buscar.Agendamento.Info["especialidade"].ToString());
                    body = body.Replace("{d}", Buscar.Agendamento.Info["dia"].ToString());
                    body = body.Replace("{h}", Buscar.Agendamento.Info["hora"].ToString());
                    body = body.Replace("{r}", Buscar.Agendamento.Info["resumo_cliente"].ToString());
                    body = body.Replace("{me}", Buscar.Agendamento.Info["medicamentos"].ToString());
                    body = body.Replace("{en}", Buscar.Agendamento.Info["encaminhamentos"].ToString());

                }

                page_content.InnerHtml = Criar.Output(body);
            }
            catch
            {
                Response.Redirect("Agendamentos.aspx");
            }
        }
    }
}