<%@ Page Language="C#" MasterPageFile="~/Site.Master" Title="Ръчно въвеждане" AutoEventWireup="true" CodeBehind="ManualInput.aspx.cs" Inherits="ComputerStore.ManualInput" %>

<asp:Content runat="server" ContentPlaceHolderID="MainContent" >
    <h2> Компютърен магазин </h2>

    <h3> Процесори: </h3>
    <asp:ListView id="lvProcessors" runat="server" InsertItemPosition="LastItem" ItemType="DataAccess.Models.XML.Processor" DataKeyNames="ID" SelectMethod="GetProcessors" InsertMethod="InsertProcessor">  
    <InsertItemTemplate>
        <div class="row">
            <div class="form-group col-md-3">
                <asp:TextBox class="form-control" ID="txtCpuIDI" runat="server" placeholder="Идентификатор" Text="<%# BindItem.ID %>"></asp:TextBox>
            </div>
            <div class="form-group col-md-3">
                <asp:TextBox class="form-control" ID="txtCpuSocketI" runat="server" placeholder="Сокет" Text="<%# BindItem.Socket %>"></asp:TextBox>
            </div>
            <div class="form-group col-md-3">
                <asp:TextBox class="form-control" ID="txtCpuModelI" runat="server" placeholder="Модел" Text="<%# BindItem.Model %>"></asp:TextBox>
            </div>    
            <div class="form-group col-md-3">
                <asp:TextBox class="form-control" ID="txtCpuManufacturer" runat="server" placeholder="Производител" Text="<%# BindItem.Manufacturer %>"></asp:TextBox>
            </div>
            <div class="form-group col-md-3">
                <asp:TextBox class="form-control" ID="txtCpuArchitecture" runat="server" placeholder="Архитектура" Text="<%# BindItem.Architecture %>"></asp:TextBox>
            </div>
            <div class="form-group col-md-3">
                <asp:TextBox class="form-control" ID="txtCpuFrequency" runat="server" placeholder="Тактова честота" Text="<%# BindItem.ClockFrequency %>"></asp:TextBox>
            </div>
            <div class="form-group col-md-3">
                <asp:TextBox class="form-control" ID="txtCacheLevels" runat="server" placeholder="Нива на кеш" Text="<%# BindItem.Cache.Levels %>"></asp:TextBox>
            </div>
            <div class="form-group col-md-3">
                <asp:TextBox class="form-control" ID="txtCacheMemory" runat="server" placeholder="Памет на кеш" Text="<%# BindItem.Cache.Memory %>"></asp:TextBox>
            </div>
            <div class="form-group col-md-3">
                <asp:TextBox class="form-control" ID="txtLogicalThreads" runat="server" placeholder="Нишки" Text="<%# BindItem.Threads.Logical %>"></asp:TextBox>
            </div>
            <div class="form-group col-md-3">
                <asp:TextBox class="form-control" ID="txtPhysicalThreads" runat="server" placeholder="Ядра" Text="<%# BindItem.Threads.Physical %>"></asp:TextBox>
            </div>
            <div class="form-group col-md-3">
                <asp:TextBox class="form-control" ID="txtCpuAvailable" runat="server" placeholder="Наличност" Text="<%# BindItem.Available %>"></asp:TextBox>
            </div>
            <div class="form-group col-md-3">
                <asp:TextBox class="form-control" ID="txtCpuPrice" runat="server" placeholder="Цена" Text="<%# BindItem.Price %>"></asp:TextBox>
            </div>
            <div class="form-group col-md-3">
                <asp:Label runat="server">Вграден видео чип?</asp:Label>
                <asp:CheckBox ID="chkCpuVideo" runat="server" Checked="<%# BindItem.IntegratedVideo %>"></asp:CheckBox>
            <div>  
                <asp:Button ID="btnInsertCpu" class="btn btn-default" runat="server" CommandName="Insert" Text="Добавяне на процесор" />
            </div>
        </div>
        </InsertItemTemplate>
    </asp:ListView>
        
    <h3> Видео карти: </h3>
    <asp:ListView id="ListView1" runat="server" InsertItemPosition="LastItem" ItemType="DataAccess.Models.XML.VideoCard" DataKeyNames="ID" SelectMethod="GetVideoCards" InsertMethod="InsertVideoCard">
            
    <InsertItemTemplate>
        <div class="row">
            <div class="form-group col-md-3">
                <asp:TextBox class="form-control" ID="txtGpuID" runat="server" placeholder="Идентификатор" Text="<%# BindItem.ID %>"></asp:TextBox>
            </div>
            <div class="form-group col-md-3">
                <asp:TextBox class="form-control" ID="txtGpuIface" runat="server" placeholder="Интерфейс" Text="<%# BindItem.Interface %>"></asp:TextBox>
            </div>
            <div class="form-group col-md-3">
                <asp:TextBox class="form-control" ID="txtGpuModel" runat="server" placeholder="Модел" Text="<%# BindItem.Model %>"></asp:TextBox>
            </div>
            <div class="form-group col-md-3">
                <asp:TextBox class="form-control" ID="txtGpuManufacturer" runat="server" placeholder="Производител" Text="<%# BindItem.Manufacturer %>"></asp:TextBox>
            </div>
            <div class="form-group col-md-3">
                <asp:TextBox class="form-control" ID="txtGpuMemoryTypeID" runat="server" placeholder="ID на тип Памет" Text="<%# BindItem.GPUMemory.Type %>"></asp:TextBox>
            </div>
            <div class="form-group col-md-3">
                <asp:TextBox class="form-control" ID="txtGpuMemoryAmount" runat="server" placeholder="Размер памет" Text="<%# BindItem.GPUMemory.Amount %>"></asp:TextBox>
            </div>
            <div class="form-group col-md-3">
                <asp:TextBox class="form-control" ID="txtGpuBus" runat="server" placeholder="Ширина на шината" Text="<%# BindItem.BusWidth %>"></asp:TextBox>
            </div>
            <div class="form-group col-md-3">
                <asp:TextBox class="form-control" ID="txtGpuBandwidth" runat="server" placeholder="Ширина на честотната лента" Text="<%# BindItem.Bandwidth %>"></asp:TextBox>
            </div>
            <div class="form-group col-md-3">
                <asp:TextBox class="form-control" ID="txtGpuDirectX" runat="server" placeholder="DirectX" Text="<%# BindItem.DirectX %>"></asp:TextBox>
            </div>
            <div class="form-group col-md-3">
                <asp:TextBox class="form-control" ID="txtGpuShaders" runat="server" placeholder="Шейдъри" Text="<%# BindItem.Shaders %>"></asp:TextBox>
            </div>
            <div class="form-group col-md-3">
                <asp:TextBox class="form-control" ID="txtGpuAvailable" runat="server" placeholder="Наличност" Text="<%# BindItem.Available %>"></asp:TextBox>
            </div>
            <div class="form-group col-md-3">
                <asp:TextBox class="form-control" ID="txtGpuPrice" runat="server" placeholder="Цена" Text="<%# BindItem.Price %>"></asp:TextBox>
            </div>
            <div>  
                <asp:Button ID="btnInsertGPU" class="btn btn-default" runat="server" CommandName="Insert" Text="Добавяне на видео-карта" />
            </div>
        </div>
    </InsertItemTemplate>
    </asp:ListView>
    
    <h3> Рам памети: </h3>
    <asp:ListView id="lvRamBoards" runat="server" InsertItemPosition="LastItem" ItemType="DataAccess.Models.XML.RamBoard" DataKeyNames="ID" SelectMethod="GetRamBoards" InsertMethod="InsertRamBoard">
    <InsertItemTemplate>
        <div class="row">
            <div class="form-group col-md-3">
                <asp:TextBox class="form-control" ID="txtRamID" runat="server" placeholder="Идентификатор" Text="<%# BindItem.ID %>"></asp:TextBox>
            </div>
            <div class="form-group col-md-3">
                <asp:TextBox class="form-control" ID="txtRamType" runat="server" placeholder="ID към тип Памет" Text="<%# BindItem.Type %>"></asp:TextBox>
            </div>
            <div class="form-group col-md-3">
                <asp:TextBox class="form-control" ID="txtRamManufacturer" runat="server" placeholder="Производител" Text="<%# BindItem.Manufacturer %>"></asp:TextBox>
            </div>
            <div class="form-group col-md-3">
                <asp:TextBox class="form-control" ID="txtRamMemory" runat="server" placeholder="Размер памет" Text="<%# BindItem.Memory %>"></asp:TextBox>
            </div>
            <div class="form-group col-md-3">
                <asp:TextBox class="form-control" ID="txtRamFrequency" runat="server" placeholder="Тактова честота" Text="<%# BindItem.Frequency %>"></asp:TextBox>
            </div>
            <div class="form-group col-md-3">
                <asp:TextBox class="form-control" ID="txtRamAvailable" runat="server" placeholder="Наличност" Text="<%# BindItem.Available %>"></asp:TextBox>
            </div>
            <div class="form-group col-md-3">
                <asp:TextBox class="form-control" ID="txtRamPrice" runat="server" placeholder="Цена" Text="<%# BindItem.Price %>"></asp:TextBox>
            </div>
            <div class="form-group col-md-4">
                <div>
                    <asp:Label runat="server">Каналност:</asp:Label>
                </div>
                <asp:DropDownList ID="drpRamChannel" class="form-control" runat="server">
                    <asp:ListItem Selected="True" Text="Едноканална" Value="single"></asp:ListItem>
                    <asp:ListItem Text="Двуканална" Value="dual"></asp:ListItem>
                    <asp:ListItem Text="Триканална" Value="triple"></asp:ListItem>
                </asp:DropDownList>
            </div>
            <div>  
                <asp:Button ID="btnInsertRamBoard" class="btn btn-default" runat="server" CommandName="Insert" Text="Добавяне на рам памет" />
            </div>
        </div>
    </InsertItemTemplate>
    </asp:ListView>
    
    <h3> Твърди дискове: </h3>
    <asp:ListView id="lvHard" runat="server" InsertItemPosition="LastItem" ItemType="DataAccess.Models.XML.HardDrive" DataKeyNames="ID" SelectMethod="GetHardDrives" InsertMethod="InsertHardDrive">
    <InsertItemTemplate>
        <div class="row">
            <div class="form-group col-md-3">
                <asp:TextBox class="form-control" ID="txtHddID" runat="server" placeholder="Идентификатор" Text="<%# BindItem.ID %>"></asp:TextBox>
            </div>
            <div class="form-group col-md-3">
                <asp:TextBox class="form-control" ID="txtHddBus" runat="server" placeholder="Шина" Text="<%# BindItem.Bus %>"></asp:TextBox>
            </div>
            <div class="form-group col-md-3">
                <asp:TextBox class="form-control" ID="txtHddLaptop" runat="server" placeholder="Съвместим с лаптоп?" Text="<%# BindItem.LaptopCompatible %>"></asp:TextBox>
            </div>
            <div class="form-group col-md-3">
                <asp:TextBox class="form-control" ID="txtHddManufacturer" runat="server" placeholder="Производител" Text="<%# BindItem.Manufacturer %>"></asp:TextBox>
            </div>
            <div class="form-group col-md-3">
                <asp:TextBox class="form-control" ID="txtHddMemory" runat="server" placeholder="Размер памет" Text="<%# BindItem.DriveMemory.Amount %>"></asp:TextBox>
            </div>
            <div class="form-group col-md-3">
                <asp:TextBox class="form-control" ID="txtHddType" runat="server" placeholder="Тип памет" Text="<%# BindItem.DriveMemory.Type %>"></asp:TextBox>
            </div>
            <div class="form-group col-md-3">
                <asp:TextBox class="form-control" ID="txtHddSpeed" runat="server" placeholder="Скорост" Text="<%# BindItem.Speed %>"></asp:TextBox>
            </div>
            <div class="form-group col-md-3">
                <asp:TextBox class="form-control" ID="txtHddSize" runat="server" placeholder="Физически размер" Text="<%# BindItem.Size %>"></asp:TextBox>
            </div>
            <div class="form-group col-md-3">
                <asp:TextBox class="form-control" ID="txtHddAvailable" runat="server" placeholder="Наличност" Text="<%# BindItem.Available %>"></asp:TextBox>
            </div>
            <div class="form-group col-md-3">
                <asp:TextBox class="form-control" ID="txtHddPrice" runat="server" placeholder="Цена" Text="<%# BindItem.Price %>"></asp:TextBox>
            </div>
            <div>  
                <asp:Button ID="btnInsertHDD" class="btn btn-default" runat="server" CommandName="Insert" Text="Добавяне на хард диск" />
            </div>
        </div>
    </InsertItemTemplate>
    </asp:ListView>

    <h3> Дънни платки: </h3>
    <asp:ListView id="lvMotherboards" runat="server" InsertItemPosition="LastItem" ItemType="DataAccess.Models.XML.Motherboard" DataKeyNames="ID" SelectMethod="GetMotherboards" InsertMethod="InsertMotherboard">
    <InsertItemTemplate>
        <div class="row">
            <div class="form-group col-md-3">
                <asp:TextBox class="form-control" ID="txtMoboID" runat="server" placeholder="Идентификатор" Text="<%# BindItem.ID %>"></asp:TextBox>
            </div>
            <div class="form-group col-md-3">
                <asp:TextBox class="form-control" ID="txtMoboSocket" runat="server" placeholder="ID на Сокет" Text="<%# BindItem.SocketID %>"></asp:TextBox>
            </div>
            <div class="form-group col-md-3">
                <asp:TextBox class="form-control" ID="txtMoboCpu" runat="server" placeholder="ID на процесор" Text="<%# BindItem.Processor %>"></asp:TextBox>
            </div>
            <div class="form-group col-md-3">
                <asp:TextBox class="form-control" ID="txtMoboGpu" runat="server" placeholder="ID на видео карта" Text="<%# BindItem.VideoCard %>"></asp:TextBox>
            </div>
            <div class="form-group col-md-3">
                <asp:TextBox class="form-control" ID="txtMoboHdd" runat="server" placeholder="ID на твърд диск" Text="<%# BindItem.HardDrive %>"></asp:TextBox>
            </div>
            <div class="form-group col-md-3">
                <asp:TextBox class="form-control" ID="txtMoboRam" runat="server" placeholder="ID на рам памет" Text="<%# BindItem.RamMemory %>"></asp:TextBox>
            </div>
            <div class="form-group col-md-3">
                <asp:TextBox class="form-control" ID="txtMoboManufacturer" runat="server" placeholder="Производител" Text="<%# BindItem.Manufacturer %>"></asp:TextBox>
            </div>
            <div class="form-group col-md-3">
                <asp:TextBox class="form-control" ID="txtMoboChipset" runat="server" placeholder="Чипсет" Text="<%# BindItem.Chipset %>"></asp:TextBox>
            </div>
            <div class="form-group col-md-3">
                <asp:TextBox class="form-control" ID="txtMoboAvailable" runat="server" placeholder="Наличност" Text="<%# BindItem.Available %>"></asp:TextBox>
            </div>
            <div class="form-group col-md-3">
                <asp:TextBox class="form-control" ID="txtMoboPrice" runat="server" placeholder="Цена" Text="<%# BindItem.Price %>"></asp:TextBox>
            </div>
            <div>  
                <asp:Button ID="btnInsertMobo" class="btn btn-default" runat="server" CommandName="Insert" Text="Добавяне на дънна платка" />
            </div>
        </div>
    </InsertItemTemplate>
    </asp:ListView>
    
    <h3> Цокли: </h3>
    <asp:ListView id="lvSockets" runat="server" InsertItemPosition="LastItem" ItemType="DataAccess.Models.XML.Socket" DataKeyNames="ID" SelectMethod="GetSockets" InsertMethod="InsertSocket">
    <InsertItemTemplate>
        <div class="row">
            <div class="form-group col-md-3">
                <asp:TextBox class="form-control" ID="txtSocketID" runat="server" placeholder="Идентификатор"></asp:TextBox>
            </div>
            <div class="form-group col-md-3">
                <asp:TextBox class="form-control" ID="txtSocketName" runat="server" placeholder="Име"></asp:TextBox>
            </div>
            <div>  
                <asp:Button ID="btnInsertRamBoard" class="btn btn-default" runat="server" CommandName="Insert" Text="Добавяне на рам памет" />
            </div>
        </div>
    </InsertItemTemplate>
    </asp:ListView>
    
    <h3> Типове памет: </h3>
    <asp:ListView id="lvMemoryTypes" runat="server" InsertItemPosition="LastItem" ItemType="DataAccess.Models.XML.Memory" DataKeyNames="ID" SelectMethod="GetMemoryTypes" InsertMethod="InsertMemoryType">
    <InsertItemTemplate>
        <div class="row">
            <div class="form-group col-md-3">
                <asp:TextBox class="form-control" ID="txtMemoryID" runat="server" placeholder="Идентификатор"></asp:TextBox>
            </div>
            <div class="form-group col-md-3">
                <asp:TextBox class="form-control" ID="txtMemoryName" runat="server" placeholder="Име"></asp:TextBox>
            </div>
            <div>  
                <asp:Button ID="btnInsertMemoryType" class="btn btn-default" runat="server" CommandName="Insert" Text="Добавяне на тип памет" />
            </div>
        </div>
    </InsertItemTemplate>
    </asp:ListView>

    <asp:Button ID="btnSubmit" runat="server" class="btn btn-default" type="submit" Text="Качване" OnClick="btnSubmit_Click" />
</asp:Content>
