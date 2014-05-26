<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Default.aspx.cs" Inherits="MoneyConverter.Default" %>
<asp:Content ID="content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server"><form id="form1" runat="server">
    <table class="nav-justified">
    <tr>
        <td class="auto-style4">Исходная валюта:&nbsp;
            <asp:DropDownList ID="SourceMoneyList" runat="server" AutoPostBack="true" Height="20px" OnSelectedIndexChanged="SourceMoneyList_event">
            </asp:DropDownList>
        </td>
        <td class="auto-style5">Курс к доллару: <asp:TextBox ID="SourceMoneyToDollarTextBox" runat="server" Height="21px" Width="46px" OnTextChanged="SourceMoneyToDollarTextBox_TextChanged"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style3">Сумма:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="SummTextBox" runat="server" Height="21px"></asp:TextBox>
        </td>
        <td class="auto-style1"></td>
    </tr>
    <tr>
        <td class="auto-style2">Целевая валюта:&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="TargetMoneyList" runat="server" AutoPostBack="true" Height="20px" OnSelectedIndexChanged="TargetMoneyList_event">
            </asp:DropDownList>
        </td>
        <td class="auto-style6">Курс к доллару:<asp:TextBox ID="TargetMoneyToDollarTextBox"  runat="server" Height="21px" Width="46px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style2">
            <asp:Button ID="CountButton" runat="server" OnClick="CountButton_Click" Text="Расчитать" />
        </td>
        <td class="auto-style6">&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style2">
            <asp:Label ID="ResultLabel" runat="server"></asp:Label>
        </td>
        <td class="auto-style6">&nbsp;</td>
    </tr>
</table>
</form>
</asp:Content>
<asp:Content ID="Content2" runat="server" contentplaceholderid="head">
    <style type="text/css">
    .auto-style1 {
        height: 17px;
            width: 257px;
        }
    .auto-style2 {
            width: 249px;
        }
    .auto-style3 {
        height: 17px;
        width: 249px;
    }
        .auto-style4 {
            width: 249px;
            height: 29px;
        }
        .auto-style5 {
            height: 29px;
            width: 257px;
        }
        .auto-style6 {
            width: 257px;
        }
    </style>
</asp:Content>

