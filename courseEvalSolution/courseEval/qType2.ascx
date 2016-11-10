<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="qType2.ascx.cs" Inherits="courseEval.qType2" %>
<div class="col-xs-12">
    <div class="panel question-panel panel-default center">
      <div class="panel-body display-inline width-85 center">
          <div class="panel panel-default col-xs-12 question-Text-Panel">        
            <asp:Label ID="qText" runat="server" Text=""></asp:Label>
          </div>
          <textarea id="textResponse" class="question-response" rows="4" runat="server"></textarea>
          <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="textResponse" runat="server" ErrorMessage="Question cannot be empty">
              </asp:RequiredFieldValidator>--%>
      </div>
    </div>
</div>