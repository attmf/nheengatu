<%@ Page

Language = "C#"
Inherits = "Web_app.Default"
CodeBehind = "~/App/Controller/Default.aspx.cs"
MasterPageFile = "~/App/Master/Default.master"

%>

<asp:Content ContentPlaceHolderID="content_title" runat="server">
    Controle de acesso
</asp:Content>

<asp:Content ContentPlaceHolderID="content_body" runat="server">
    <div id="page_content" class="row-padding col l4 m6 s9" runat="server"></div>
</asp:Content>
