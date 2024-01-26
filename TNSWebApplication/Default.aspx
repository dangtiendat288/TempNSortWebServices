<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TNSWebApplication._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
    <asp:Panel ID="c2fPanel" runat="server">
        <h1>From C to F</h1>
        <p>
            <asp:Label ID="c2fLabel" runat="server" Text="Input: "></asp:Label>
            <asp:TextBox ID="c2fInput" runat="server"></asp:TextBox>
            <asp:Button ID="c2fButton" runat="server" Text="Convert" OnClick="c2fButton_Click" />
        </p>
        <asp:Label ID="c2fResLabel" runat="server" Text="Result here"></asp:Label>
    </asp:Panel>

    <asp:Panel ID="f2cPanel" runat="server">
        <h1>From F to C</h1>
        <p>
            <asp:Label ID="f2cLabel" runat="server" Text="Input: "></asp:Label>
            <asp:TextBox ID="f2cInput" runat="server"></asp:TextBox>
            <asp:Button ID="f2cButton" runat="server" Text="Convert" OnClick="f2cButton_Click" />
        </p>
        <asp:Label ID="f2cResLabel" runat="server" Text="Result here"></asp:Label>
    </asp:Panel>

    <asp:Panel ID="sortPanel" runat="server">
        <h1>Sort String</h1>
        <p>
            <asp:Label ID="stringLabel" runat="server" Text="Input string: "></asp:Label>
            <asp:TextBox ID="stringInput" runat="server" /><asp:Button ID="sortButton" runat="server" Text="Sort" OnClick="sortButton_Click" />
        </p>
        <asp:Label ID="sortResLabel" runat="server" Text="Sorted string here"></asp:Label>
    </asp:Panel>
</asp:Content>
