<%@ Page Title="ASP Програмиране - 2016" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ComputerStore._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <h1>ASP Програмиране</h1>
        
        <p class="lead">Кликни бутона отдолу за добавяне на готови XML файлове.</p>

        <div class="row">
            <div class="col-md-3">
                <a runat="server" href="~/FileInput" class="btn btn-primary btn-lg">Кликни ме! &raquo;</a>
            </div>
            <div class="col-md-offset-9">
                <asp:Image runat="server" ImageUrl="~/Content/images/webforms.gif" />
            </div>
        </div>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>Ръчно добавяне</h2>
            <p>Кликни отдолу за ръчно попълване на XML файл.</p>
            <p>
                <a runat="server" class="btn btn-default" href="~/ManualInput">Натисни ме!! &raquo;</a>
            </p>
        </div>
    </div>

</asp:Content>
