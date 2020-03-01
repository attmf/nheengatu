using System;
using System.Collections.Generic;
using System.Web.UI;
using Core;

namespace Web_app
{
    public partial class Configuracoes_endereco : Page
    {
        List<object> list;
        string msg;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Buscar.Usuario.ID.Equals(0))
            {
                Response.Redirect("Logout.aspx");
            }

            if (Request.HttpMethod.Equals("POST"))
            {
                Buscar.Editor.ID = 0;
                Preencher.List(list = new List<object>(), Request.Form, 3);

                msg = "<p class='col label'>{m}</p>";
                msg = msg.Replace("{m}", Alterar.Cliente.Endereco(list) ? Msg.AcaoRealizada : Msg.SenhaNaoCoincide);

                page_content.InnerHtml = Criar.Output(msg);
            }

            Criar.HtmlForm(page_content, Etiquetas.Endereco.Fields, Etiquetas.Endereco.Widths, Etiquetas.Endereco.Lengths, "atualizarEndereco");
            Preencher.HtmlForm(page_content, Buscar.Usuario.Info, 5);
        }
    }
}