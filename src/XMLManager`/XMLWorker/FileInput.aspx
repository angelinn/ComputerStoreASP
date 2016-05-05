﻿<%@ Page Language="C#" MasterPageFile="~/Site.Master" Title="Въвеждане чрез файл" AutoEventWireup="true" CodeBehind="FileInput.aspx.cs" Inherits="XMLWorker.FileInput" %>

<asp:Content runat="server" ContentPlaceHolderID="MainContent" >
    <div class="form-group">
        <h3>Избиране на файлове</h3>
        <asp:FileUpload  ID="fuXmlFiles" runat="server" AllowMultiple="true"  />
    </div>
    <asp:Button id="btnSubmit" runat="server" class="btn btn-default" type="submit" Text="Качване" OnClick="btnSubmit_Click" />
</asp:Content>