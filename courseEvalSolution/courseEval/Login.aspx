<%@ Page Title="" Language="C#" MasterPageFile="~/EvaluationMaster.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="courseEval.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="login-wrap">
        <div class="col-xs-12 center">
            <asp:Label ID="successLabel" cssClass="bright-green center" runat="server" Text="" Visible="false"></asp:Label>
        </div>
		<h1 class="page-header">Evaluation Login</h1>
		<div class="panel trans-panel panel-default">				
			<div class="panel-body">
				<form runat="server" class="form-horizontal">							
					<div class="form-group">
						<div class="col-xs-12">
						    <div class="row">
							    <label for="inputLnum" class="col-sm-offset-3 col-sm-2 label label-default control-label">Lnumber</label>
							    <div class="col-sm-5">
								    <input runat="server" type="text" class="form-control short-input" id="inputLnum" placeholder="Lnumber" required="required" />
							    </div>
                                <div class="col-sm-4">
                                    <!-- validation control goes here -->            
                                    <asp:RequiredFieldValidator ID="valReqUserid" CssClass="text-danger" runat="server" 
                                        ControlToValidate="inputLnum" ErrorMessage="You must enter a user id" 
                                        SetFocusOnError="True" EnableClientScript="false">
                                    </asp:RequiredFieldValidator>
                                    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" CssClass="text-danger" runat="server"  
                                        ControlToValidate="inputLnum" ErrorMessage="L number must start with L followed by 8 numbers" 
                                        SetFocusOnError="True" ValidationExpression="/^[l]\d{8}$/gi" EnableClientScript="false"> 

                                    </asp:RegularExpressionValidator>  
                                </div>
						    </div>
						</div>
					</div>
					<div class="form-group">
					    <div class="col-xs-12">
						    <div class="row">
							    <label for="inputPassword" class="col-sm-offset-3 col-sm-2 control-label label label-default">Password</label>
							    <div class="col-sm-5">
								    <input runat="server" type="password" class="form-control short-input" id="inputPassword" placeholder="Password" />
							    </div>
                                <div class="col-sm-4">
                                    <!-- validation control goes here -->
                                    <asp:RequiredFieldValidator ID="valRePassword" CssClass="text-danger" runat="server" 
                                        ControlToValidate="inputLnum" ErrorMessage="You must enter a user id" 
                                        SetFocusOnError="True" EnableClientScript="false">
                                    </asp:RequiredFieldValidator>
                                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" CssClass="text-danger" runat="server"  
                                        ControlToValidate="inputPassword" ErrorMessage="Password must be 8 to 16 characters" 
                                        SetFocusOnError="True" ValidationExpression="^(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{8,16}$" EnableClientScript="false"> 

                                    </asp:RegularExpressionValidator>
                                </div>
						    </div>
					    </div>
					</div>
					<div class="form-group">
					    <div class="col-sm-12">
						    <div class="checkbox">
						    <label>
							    <input runat="server" type="checkbox" /> Remember me
						    </label>
						    </div>
					    </div>
					</div>
					<div class="form-group">
					    <div class="col-sm-12">
                            <div class="row">
                                
                                <div class="col-xs-12">
						            <asp:button runat="server" type="submit" class="btn btn-warning" text="Sign In" ID="submitBtn" OnClick="submitBtn_Click"></asp:button>
                                </div>
                                <asp:Label ID="loginErrorMessage" CssClass="col-xs-12 text-danger" runat="server" Text=""></asp:Label>
                            </div>
					    </div>
					</div>
				</form>
			</div>
		</div>
	</div>
</asp:Content>

