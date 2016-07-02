﻿<%@ Page Language="C#" MasterPageFile="~/Site.Master" Title="Въвеждане чрез файл" AutoEventWireup="true" CodeBehind="FileInput.aspx.cs" Inherits="ComputerStore.FileInput" %>

<asp:Content runat="server" ContentPlaceHolderID="MainContent" >
    <div class="form-group">
        <h3>Избиране на файлове</h3>
        <asp:FileUpload  ID="fuXmlFiles" runat="server" AllowMultiple="true"  />
    </div>

    <div id="dtd-warning"> *DTD файлът трябва да се намира в <%= UserUploads %>* </div>

    <asp:Button id="btnSubmit" runat="server" class="btn btn-default" type="submit" Text="Качване" OnClick="btnSubmit_Click" />

    <% if (tblResults.Rows.Count > 0) { %>
        <hr />
    <% } %>

    <asp:Table ID="tblResults" runat="server" CellPadding="10" >
    </asp:Table>

    <div>
        <h3> Изчистване на базата </h3>
        <asp:Button ID="btnClear" runat="server" class="btn btn-default" Text="Натисни ме" OnClick="btnClear_Click" />
    </div>
</asp:Content>
