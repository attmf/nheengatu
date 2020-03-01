<%@ Page

Language = "C#"
Inherits = "Web_app.Configuracoes"
CodeBehind = "~/App/Controller/Configuracoes.aspx.cs"
MasterPageFile = "~/App/Master/Default.master"

%>

<asp:Content ContentPlaceHolderID="content_title" runat="server">
    Editor de configurações
</asp:Content>

<asp:Content ContentPlaceHolderID="content_body" runat="server">
    <div id="page_content" class="row-padding" runat="server"></div>
</asp:Content>
