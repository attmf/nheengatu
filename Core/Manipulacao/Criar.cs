namespace Core
{
    public class Criar
    {
        static string body;

        public static void HtmlForm(System.Web.UI.HtmlControls.HtmlControl htmlControl, string[] fields, int[] widths, int[] lengths, string functionSubmit = null, string[] types = null)
        {
            System.Web.UI.WebControls.Panel panel;
            System.Web.UI.WebControls.Label label;
            System.Web.UI.WebControls.TextBox textBox;
            System.Web.UI.WebControls.Button button;

            functionSubmit = functionSubmit ?? "void(0)";

            if (types == null)
            {
                types = new string[fields.Length];

                for (int i = 0; i < fields.Length; i++)
                {
                    types[i] = "t";
                }
            }

            for (int i = 0; i < fields.Length; i++)
            {
                label = new System.Web.UI.WebControls.Label
                {
                    ID = "label_" + i,
                    Text = fields[i],
                    CssClass = "label"
                };

                textBox = new System.Web.UI.WebControls.TextBox
                {
                    ID = ("field_" + fields[i]).Replace(" ", "_").ToLower(),
                    MaxLength = lengths[i],
                    CssClass = "input border",
                    TextMode = types[i].Equals("pwd") ? System.Web.UI.WebControls.TextBoxMode.Password : System.Web.UI.WebControls.TextBoxMode.SingleLine
                };

                panel = new System.Web.UI.WebControls.Panel
                {
                    ID = "panel_" + i,
                    CssClass = "col padding-16 s12 m" + widths[i]
                };

                panel.Controls.Add(label);
                panel.Controls.Add(textBox);
                htmlControl.Controls.Add(panel);
            }

            panel = new System.Web.UI.WebControls.Panel
            {
                ID = "panel_submit",
                CssClass = "col padding-16 s12"
            };

            button = new System.Web.UI.WebControls.Button
            {
                ID = "submit_form",
                CssClass = "button blue hover-blue-gray",
                Text = "Enviar dados",
                OnClientClick = functionSubmit
            };

            panel.Controls.Add(button);
            htmlControl.Controls.Add(panel);
        }

        public static void HelpLink(System.Web.UI.HtmlControls.HtmlControl htmlControl, string helpLabel, string helpHref, string helpText = null, bool helpHrefIsJS = false)
        {
            System.Web.UI.WebControls.Panel panel;
            int id = new System.Random().Next();

            panel = new System.Web.UI.WebControls.Panel
            {
                ID = "panel_help_" + id,
                CssClass = "col margin-top s12"
            };

            if (helpText != null)
            {
                panel.Controls.Add(new System.Web.UI.WebControls.Label
                    {
                        ID = "help_text" + id,
                        Text = helpText,
                        CssClass = "col text-red label padding-16 margin-bottom"
                    });
            }

            panel.Controls.Add(new System.Web.UI.WebControls.HyperLink
                {
                    ID = "help_link" + id,
                    NavigateUrl = helpHrefIsJS ? string.Concat("javascript:", helpHref, "();") : helpHref,
                    Text = helpLabel,
                    CssClass = "text-blue hover-blue",
                });

            htmlControl.Controls.Add(panel);
        }

        public static string Links(string[] etiquetas, string[] urls = null, string css = "text-blue hover-blue", bool navbar = false)
        {
            body = string.Empty;
            urls = urls ?? new [] { "{i}" };

            for (int i = 0; i < etiquetas.Length; i++)
            {
                body += "<a href='{h}' class='{c}' data-link='{d}'>{l}</a>";

                body = body.Replace("{h}", navbar ? urls[i] + ".aspx" : "{u}.aspx?id={i}");
                body = body.Replace("{c}", css);
                body = body.Replace("{d}", urls[i].Replace(" ", "_").ToLower());
                body = body.Replace("{l}", etiquetas[i]);
            }

            return Output(body);
        }

        public static string Output(string str)
        {
            str = str.Replace("\'", "\"");
            return str;
        }
    }
}
