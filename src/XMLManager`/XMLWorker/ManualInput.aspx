<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ManualInput.aspx.cs" Inherits="XMLWorker.ManualInput" %>

<asp:Content runat="server" ContentPlaceHolderID="MainContent" >
    <h2> Компютърен магазин </h2>
    <div class="row">
        <h3> Процесори: </h3>
        <div class="form-group col-md-3">
            <asp:TextBox class="form-control" ID="txtCpuID" runat="server" placeholder="Идентификатор"></asp:TextBox>
        </div>
        <div class="form-group col-md-3">
            <asp:TextBox class="form-control" ID="txtCpuSocket" runat="server" placeholder="Сокет"></asp:TextBox>
        </div>
        <div class="form-group col-md-3">
            <asp:TextBox class="form-control" ID="txtCpuVideo" runat="server" placeholder="Вграден видео чип?"></asp:TextBox>
        </div>
        <div class="form-group col-md-3">
            <asp:TextBox class="form-control" ID="txtCpuModel" runat="server" placeholder="Модел"></asp:TextBox>
        </div>
        <div class="form-group col-md-3">
            <asp:TextBox class="form-control" ID="txtCpuManufacturer" runat="server" placeholder="Производител"></asp:TextBox>
        </div>
        <div class="form-group col-md-3">
            <asp:TextBox class="form-control" ID="txtCpuArchitecture" runat="server" placeholder="Архитектура"></asp:TextBox>
        </div>
        <div class="form-group col-md-3">
            <asp:TextBox class="form-control" ID="txtCpuFrequency" runat="server" placeholder="Тактова честота"></asp:TextBox>
        </div>
        <div class="form-group col-md-3">
            <asp:TextBox class="form-control" ID="txtCacheLevels" runat="server" placeholder="Нива на кеш"></asp:TextBox>
        </div>
        <div class="form-group col-md-3">
            <asp:TextBox class="form-control" ID="txtCacheMemory" runat="server" placeholder="Памет на кеш"></asp:TextBox>
        </div>
        <div class="form-group col-md-3">
            <asp:TextBox class="form-control" ID="txtLogicalThreads" runat="server" placeholder="Нишки"></asp:TextBox>
        </div>
        <div class="form-group col-md-3">
            <asp:TextBox class="form-control" ID="txtPhysicalThreads" runat="server" placeholder="Ядра"></asp:TextBox>
        </div>
        <div class="form-group col-md-3">
            <asp:TextBox class="form-control" ID="txtAvailable" runat="server" placeholder="Наличност"></asp:TextBox>
        </div>
        <div class="form-group col-md-3">
            <asp:TextBox class="form-control" ID="txtPrice" runat="server" placeholder="Цена"></asp:TextBox>
        </div>
    </div>

    <div class="row">
        <h3> Видео карти: </h3>
        <div class="form-group col-md-3">
            <asp:TextBox class="form-control" ID="txtGpuID" runat="server" placeholder="Идентификатор"></asp:TextBox>
        </div>
        <div class="form-group col-md-3">
            <asp:TextBox class="form-control" ID="txtGpuIface" runat="server" placeholder="Интерфейс"></asp:TextBox>
        </div>
        <div class="form-group col-md-3">
            <asp:TextBox class="form-control" ID="txtGpuModel" runat="server" placeholder="Модел"></asp:TextBox>
        </div>
        <div class="form-group col-md-3">
            <asp:TextBox class="form-control" ID="txtGpuManufacturer" runat="server" placeholder="Производител"></asp:TextBox>
        </div>
        <div class="form-group col-md-3">
            <asp:TextBox class="form-control" ID="txtGpuMemoryTypeID" runat="server" placeholder="ID на тип Памет"></asp:TextBox>
        </div>
        <div class="form-group col-md-3">
            <asp:TextBox class="form-control" ID="txtGpuMemoryAmount" runat="server" placeholder="Размер памет"></asp:TextBox>
        </div>
        <div class="form-group col-md-3">
            <asp:TextBox class="form-control" ID="txtGpuBus" runat="server" placeholder="Ширина на шината"></asp:TextBox>
        </div>
        <div class="form-group col-md-3">
            <asp:TextBox class="form-control" ID="txtGpuBandwidth" runat="server" placeholder="Ширина на честотната лента"></asp:TextBox>
        </div>
        <div class="form-group col-md-3">
            <asp:TextBox class="form-control" ID="txtGpuDirectX" runat="server" placeholder="DirectX"></asp:TextBox>
        </div>
        <div class="form-group col-md-3">
            <asp:TextBox class="form-control" ID="txtGpuShaders" runat="server" placeholder="Шейдъри"></asp:TextBox>
        </div>
        <div class="form-group col-md-3">
            <asp:TextBox class="form-control" ID="txtGpuAvailable" runat="server" placeholder="Наличност"></asp:TextBox>
        </div>
        <div class="form-group col-md-3">
            <asp:TextBox class="form-control" ID="txtGpuPrice" runat="server" placeholder="Цена"></asp:TextBox>
        </div>
    </div>

    <div class="row">
        <h3> Рам памети: </h3>
        <div class="form-group col-md-3">
            <asp:TextBox class="form-control" ID="txtRamID" runat="server" placeholder="Идентификатор"></asp:TextBox>
        </div>
        <div class="form-group col-md-3">
            <asp:TextBox class="form-control" ID="txtRamType" runat="server" placeholder="ID към тип Памет"></asp:TextBox>
        </div>
        <div class="form-group col-md-3">
            <asp:TextBox class="form-control" ID="txtRamManufacturer" runat="server" placeholder="Производител"></asp:TextBox>
        </div>
        <div class="form-group col-md-3">
            <asp:TextBox class="form-control" ID="txtRamMemory" runat="server" placeholder="Размер памет"></asp:TextBox>
        </div>
        <div class="form-group col-md-3">
            <asp:TextBox class="form-control" ID="txtRamFrequency" runat="server" placeholder="Тактова честота"></asp:TextBox>
        </div>
        <div class="form-group col-md-3">
            <asp:TextBox class="form-control" ID="txtRamChannel" runat="server" placeholder="Канали"></asp:TextBox>
        </div>
        <div class="form-group col-md-3">
            <asp:TextBox class="form-control" ID="txtRamAvailable" runat="server" placeholder="Наличност"></asp:TextBox>
        </div>
        <div class="form-group col-md-3">
            <asp:TextBox class="form-control" ID="txtRamPrice" runat="server" placeholder="Цена"></asp:TextBox>
        </div>
    </div>

    <div class="row">
        <h3> Твърди дискове: </h3>
        <div class="form-group col-md-3">
            <asp:TextBox class="form-control" ID="txtHddID" runat="server" placeholder="Идентификатор"></asp:TextBox>
        </div>
        <div class="form-group col-md-3">
            <asp:TextBox class="form-control" ID="txtHddBus" runat="server" placeholder="Шина"></asp:TextBox>
        </div>
        <div class="form-group col-md-3">
            <asp:TextBox class="form-control" ID="txtHddLaptop" runat="server" placeholder="Съвместим с лаптоп?"></asp:TextBox>
        </div>
        <div class="form-group col-md-3">
            <asp:TextBox class="form-control" ID="txtHddManufacturer" runat="server" placeholder="Производител"></asp:TextBox>
        </div>
        <div class="form-group col-md-3">
            <asp:TextBox class="form-control" ID="txtHddMemory" runat="server" placeholder="Размер памет"></asp:TextBox>
        </div>
        <div class="form-group col-md-3">
            <asp:TextBox class="form-control" ID="txtHddType" runat="server" placeholder="Тип памет"></asp:TextBox>
        </div>
        <div class="form-group col-md-3">
            <asp:TextBox class="form-control" ID="txtHddSpeed" runat="server" placeholder="Скорост"></asp:TextBox>
        </div>
        <div class="form-group col-md-3">
            <asp:TextBox class="form-control" ID="txtHddSize" runat="server" placeholder="Физически размер"></asp:TextBox>
        </div>
        <div class="form-group col-md-3">
            <asp:TextBox class="form-control" ID="txtHddAvailable" runat="server" placeholder="Наличност"></asp:TextBox>
        </div>
        <div class="form-group col-md-3">
            <asp:TextBox class="form-control" ID="txtHddPrice" runat="server" placeholder="Цена"></asp:TextBox>
        </div>
    </div>

    <div class="row">
        <h3> Дънни платки: </h3>
        <div class="form-group col-md-3">
            <asp:TextBox class="form-control" ID="txtMoboID" runat="server" placeholder="Идентификатор"></asp:TextBox>
        </div>
        <div class="form-group col-md-3">
            <asp:TextBox class="form-control" ID="txtMoboSocket" runat="server" placeholder="ID на Сокет"></asp:TextBox>
        </div>
        <div class="form-group col-md-3">
            <asp:TextBox class="form-control" ID="txtMoboCpu" runat="server" placeholder="ID на процесор"></asp:TextBox>
        </div>
        <div class="form-group col-md-3">
            <asp:TextBox class="form-control" ID="txtMoboGpu" runat="server" placeholder="ID на видео карта"></asp:TextBox>
        </div>
        <div class="form-group col-md-3">
            <asp:TextBox class="form-control" ID="txtMoboHdd" runat="server" placeholder="ID на твърд диск"></asp:TextBox>
        </div>
        <div class="form-group col-md-3">
            <asp:TextBox class="form-control" ID="txtMoboRam" runat="server" placeholder="ID на рам памет"></asp:TextBox>
        </div>
        <div class="form-group col-md-3">
            <asp:TextBox class="form-control" ID="txtMoboManufacturer" runat="server" placeholder="Производител"></asp:TextBox>
        </div>
        <div class="form-group col-md-3">
            <asp:TextBox class="form-control" ID="txtMoboChipset" runat="server" placeholder="Чипсет"></asp:TextBox>
        </div>
        <div class="form-group col-md-3">
            <asp:TextBox class="form-control" ID="txtMoboAvailable" runat="server" placeholder="Наличност"></asp:TextBox>
        </div>
        <div class="form-group col-md-3">
            <asp:TextBox class="form-control" ID="txtMoboPrice" runat="server" placeholder="Цена"></asp:TextBox>
        </div>
    </div>

    <div class="row">
        <h3> Цокли: </h3>
        <div class="form-group col-md-3">
            <asp:TextBox class="form-control" ID="txtSocketID" runat="server" placeholder="Идентификатор"></asp:TextBox>
        </div>
        <div class="form-group col-md-3">
            <asp:TextBox class="form-control" ID="txtSocketName" runat="server" placeholder="Име"></asp:TextBox>
        </div>
    </div>

    <div class="row">
        <h3> Типове памет: </h3>
        <div class="form-group col-md-3">
            <asp:TextBox class="form-control" ID="txtMemoryID" runat="server" placeholder="Идентификатор"></asp:TextBox>
        </div>
        <div class="form-group col-md-3">
            <asp:TextBox class="form-control" ID="txtMemoryName" runat="server" placeholder="Име"></asp:TextBox>
        </div>
    </div>

    <asp:Button ID="btnSubmit" runat="server" class="btn btn-default" type="submit" Text="Качване" OnClick="btnSubmit_Click" />
</asp:Content>
