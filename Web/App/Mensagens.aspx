<%@ Page

Language = "C#"
Inherits = "Web_app.Mensagens"
CodeBehind = "~/App/Controller/Mensagens.aspx.cs"
MasterPageFile = "~/App/Master/Default.master"

%>

<asp:Content ContentPlaceHolderID="content_title" runat="server">
Central de mensagens
</asp:Content>

<asp:Content ContentPlaceHolderID="content_body" runat="server">
<div id="page_content" class="row-padding" runat="server"></div>
</asp:Content>
