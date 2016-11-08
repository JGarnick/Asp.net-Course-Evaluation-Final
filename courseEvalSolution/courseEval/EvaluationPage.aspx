<%@ Page Title="Evaluation Page" Language="C#" MasterPageFile="~/EvaluationMaster.Master" AutoEventWireup="true" CodeBehind="EvaluationPage.aspx.cs" Inherits="courseEval.EvaluationPage" %>

<%@ Register Src="~/qType1.ascx" TagPrefix="my" TagName="type1" %>

<%@ Register Src="~/qType2.ascx" TagPrefix="my" TagName="type2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
        <form id="testForm" class="center" runat="server">
            <div class="col-xs-12">
                <asp:DropDownList ID="questionSelect" CssClass="question-select" runat="server"></asp:DropDownList>
            </div>
            <div class="col-xs-12">
                <asp:Button ID="getQuestionsBtn" CssClass="get-questions-btn btn btn-default" runat="server" Text="Get Questions" Type="button" OnClick="getQuestionsBtn_Click"></asp:Button>
            </div>
            <div class="col-xs-12">
                <asp:Button ID="submitBtn" runat="server" Text="Submit Evaluation" CssClass="btn btn-warning" OnClick="submitBtn_Click" Visible="false"/>
            </div>            
        </form>
</asp:Content>

