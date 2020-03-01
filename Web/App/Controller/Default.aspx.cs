using System;
using System.Collections.Generic;
using System.Data;
using System.Web.UI;
using Core;

namespace Web_app
{
    public partial class Default : Page
    {
        List<object> list;
        int counter;

        protected void Page_Load(object sender, EventArgs e)
        {
            Buscar.Usuario.ID = 0;
            Buscar.Usuario.Classe = "cliente";

            if (Request.HttpMethod.Equals("POST"))
            {
                Preencher.List(list = new List<object>(), Request.Form, 3);

                counter = 0;
                Buscar.Usuario.Login(list[counter++], list[counter++]);

                if (Buscar.Usuario.ID.Equals(0))
                {
                    Criar.HelpLink(page_content, "&laquo; Tentar novamente", "Default.aspx", Msg.CpfSenhaNaoCoincide);
                }
                else
                {
                    Response.Redirect("Agendamentos.aspx");
                }
            }
            else
            {
                Criar.HtmlForm(page_content, Etiquetas.Default.Labels, Etiquetas.Default.Widths, Etiquetas.Default.Lengths, "login", Etiquetas.Default.Types);
                Criar.HelpLink(page_content, "Esqueceu sua senha?", "recuperarSenha", null, true);
            }
        }
    }
}