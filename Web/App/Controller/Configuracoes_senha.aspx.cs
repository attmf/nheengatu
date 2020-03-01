using System;
using System.Collections.Generic;
using Core;

namespace Web_app
{
    public partial class Configuracoes_senha : System.Web.UI.Page
    {
        List<object> list;
        string msg;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Buscar.Usuario.ID.Equals(0))
            {
                Response.Redirect("/App/Logout.aspx");
            }

            if (Request.HttpMethod.Equals("POST"))
            {
                Preencher.List(list = new List<object>(), Request.Form, 3);

                msg = Alterar.Cliente.Login(list) ? Msg.AcaoRealizada : Msg.SenhaNaoCoincide;
                page_content.InnerHtml = Criar.Output("<p class='col label'>" + msg + "</p>");
            }

            Criar.HtmlForm(page_content, Etiquetas.Configuracoes.Senha.Fields, Etiquetas.Configuracoes.Senha.Widths, Etiquetas.Configuracoes.Senha.Lengths, "mudarSenha", Etiquetas.Configuracoes.Senha.Types);
        }
    }
}