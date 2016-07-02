<%@ Page Language="C#" MasterPageFile="~/Site.Master" Title="Въвеждане чрез файл" AutoEventWireup="true" CodeBehind="FileInput.aspx.cs" Inherits="ComputerStore.FileInput" %>

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
    
    <% if (gvStores.Rows.Count > 0) { %>
    <hr />
    <h4> Текущи магазини в базата от данни </h4>
    <% } %>
    <asp:GridView runat="server" ID="gvStores" ItemType="ComputerStore.ViewModels.ComputerStoreViewModel" 
        DataKeyNames="ID" SelectMethod="GetComputerStores" AutoGenerateColumns="false" CssClass="table table-hover table-striped" GridLines="None">
        <Columns>
            <asp:BoundField DataField="ID" HeaderText="ID" />
            <asp:BoundField DataField="ProcessorCount" HeaderText="Брой процесори" />
            <asp:BoundField DataField="GPUCount" HeaderText="Брой видео-карти" />
            <asp:BoundField DataField="HDDCount" HeaderText="Брой твърди дискове" />
            <asp:BoundField DataField="RAMCount" HeaderText="Брой рам памети" />
            <asp:BoundField DataField="MoboCount" HeaderText="Брой дънни платки" />
            <asp:BoundField DataField="SocketCount" HeaderText="Брой цокли" />
            <asp:BoundField DataField="MemoryCount" HeaderText="Брой видове памети" />
        </Columns>
    </asp:GridView>

    <div>
        <hr />
        <h4> Изчистване на базата </h4>
        <asp:Button ID="btnClear" runat="server" class="btn btn-default" Text="Натисни ме" OnClick="btnClear_Click" />
    </div>
</asp:Content>
