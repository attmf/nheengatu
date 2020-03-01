<%@ Page

Language = "C#"
CodeBehind = "Controller/Mensagens_conversa.aspx.cs"
Inherits = "Web_app.Mensagens_conversa"
MasterPageFile ="~/App/Master/Default.master"

%>

<asp:Content ContentPlaceHolderID="content_title" runat="server">
Central de mensagens: exibir conversa
</asp:Content>

<asp:Content ContentPlaceHolderID="content_body" runat="server">
<div id="page_content" class="row-padding" runat="server"></div>
</asp:Content>
