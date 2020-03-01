namespace Core
{
    public class Snippets
    {
        static string body
        {
            get;
            set;
        }
        
        public static string Container
        {
            get
            {
                return "<div class='col margin-bottom'>{%}</div>";
            }
        }
        
        public static class Agendamento
        {
            public static string Home
            {
                get
                {
                    body = string.Empty;
                    
                    body += "<div class='col l4 s12 margin-bottom'>";
                    body += "<div class='border padding'>";
                    body += "<p><b>Técnico:</b> {m} ({e})</p>";
                    body += "<p><b>Dia:</b> {d}</p>";
                    body += "<p><b>Hora:</b> {h}</p>";
                    body += "<p><b>Situação:</b> {s}</p>";
                    body += "</div>";
                    body += "</div>";
                    
                    return body;
                }
            }
            
            public static string Resumo
            {
                get
                {
                    body = string.Empty;

                    body += "<div class='col s12 margin-bottom'>";
                    body += "<div class='border padding'>";
                    body += "<p><b>Técnico:</b> {m} ({e})</p>";
                    body += "<p><b>Dia:</b> {d}</p>";
                    body += "<p><b>Hora:</b> {h}</p>";
                    body += "<p><b>Resumo:</b> {r}</p>";
                    body += "<p><b>Medicamentos Receitados:</b> {me}</p>";
                    body += "<p><b>Encaminhamentos:</b> {en}</p>";
                    body += "</div>";
                    body += "</div>";

                    return body;
                }
            }
        }
    }
}