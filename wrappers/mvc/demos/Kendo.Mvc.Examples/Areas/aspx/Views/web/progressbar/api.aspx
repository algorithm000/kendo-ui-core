﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Areas/aspx/Views/Shared/Web.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>

<asp:Content ContentPlaceHolderID="MainContent" runat="server">
<div class="configuration k-widget k-header">
    <span class="configHead">ProgressBar API Functions</span>
    <ul class="options">
        <li>
            <input type="text" id="newValue" value="25" class="k-textbox" />
            <button class="k-button" id="setProgressBarValue">Set value</button>
        </li>
        <li>
            <button class="k-button" id="getProgressBarValue">Get value</button>
        </li>
        <li>
            <button class="k-button" id="enableProgressBar">Enable</button> or <button class="k-button" id="disableProgressBar">Disable</button>
        </li>
    </ul>
</div>

<div class="demo-section">
    <%= Html.Kendo().ProgressBar()
          .Name("progressBar")
          .Min(0)
          .Max(100)
          .Type(ProgressBarType.Value)
          .Animation(a => a.Duration(400))
    %>
</div>

<script>
    $(function () {
        var pb = $("#progressBar").data("kendoProgressBar");

        $("#setProgressBarValue").click(function () {
            pb.value($("#newValue").val());
        });

        $("#getProgressBarValue").click(function () {
            alert("Current ProgressBar value is: " + pb.value());
        });

        $("#enableProgressBar").click(function () {
            pb.enable();
        });

        $("#disableProgressBar").click(function () {
            pb.enable(false);
        });
    });
</script>

</asp:Content>