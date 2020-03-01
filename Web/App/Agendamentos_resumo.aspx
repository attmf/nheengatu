<%@ Page

Language = "C#"
Inherits = "Web_app.Agendamentos_resumo"
CodeBehind = "~/App/Controller/Agendamentos_resumo.aspx.cs"
MasterPageFile = "~/App/Master/Default.master"

%>

<asp:Content ContentPlaceHolderID="content_title" runat="server">
    Meus agendamentos: resumo de atendimento
</asp:Content>

<asp:Content ContentPlaceHolderID="content_body" runat="server">
    <div id="page_content" class="row-padding" runat="server"></div>
</asp:Content>
