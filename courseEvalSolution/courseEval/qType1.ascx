﻿<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="qType1.ascx.cs" Inherits="courseEval.qType1" %>

<div class="col-xs-12">
    <div class="panel question-panel panel-default center">
      <div class="panel-body display-inline width-85 center">
        <div class="panel panel-default col-xs-12 question-Text-Panel">       
          <asp:Label ID="qText" runat="server" Text=""></asp:Label>
        </div>
        <label class="radio-inline">
          <input runat="server" type="radio" name="qRating" id="q1" value="1">Strongly Disagree
        </label>
        <label class="radio-inline">
          <input runat="server" type="radio" name="qRating" id="q2" value="2">Disagree
        </label>
        <label class="radio-inline">
          <input runat="server" type="radio" name="qRating" id="q3" value="3">Indifferent
        </label>
        <label class="radio-inline">
          <input runat="server" type="radio" name="qRating" id="q4" value="4">Agree
        </label>
        <label class="radio-inline">
          <input runat="server" type="radio" name="qRating" id="q5" value="5">Strongly Agree
        </label>     
      </div>
    </div>
</div>    

