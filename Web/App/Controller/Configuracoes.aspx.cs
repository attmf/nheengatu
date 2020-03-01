using System;
using System.Web.UI;
using Core;

namespace Web_app
{
    public partial class Configuracoes : Page
    {
        string body;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Buscar.Usuario.ID.Equals(0))
            {
                Response.Redirect("/App/Logout.aspx");
            }

            if (!Buscar.Usuario.ID.Equals(0))
            {
                for (int i = 0; i < Etiquetas.Configuracoes.Labels.Length; i++)
                {
                    body += Criar.Links(new [] { Etiquetas.Configuracoes.Labels[i] }, null, "button border light-gray");

                    body = body.Replace("?id={i}", string.Empty);
                    body = body.Replace("{u}", "Configuracoes_" + Etiquetas.Configuracoes.Urls[i]);
                    body = Snippets.Container.Replace("{%}", body);
                }

                page_content.InnerHtml = Criar.Output(body);
            }
        }
    }
}