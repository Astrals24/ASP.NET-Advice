﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>首页</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        <asp:AccessDataSource ID="AccessDataSource1" runat="server" ConflictDetection="CompareAllValues" DataFile="~/DB/Book.mdb" DeleteCommand="DELETE FROM [tbBook] WHERE [ISBN] = ? AND [BookName] = ? AND (([Price] = ?) OR ([Price] IS NULL AND ? IS NULL)) AND (([PublishDate] = ?) OR ([PublishDate] IS NULL AND ? IS NULL))" InsertCommand="INSERT INTO [tbBook] ([ISBN], [BookName], [Price], [PublishDate]) VALUES (?, ?, ?, ?)" OldValuesParameterFormatString="original_{0}" SelectCommand="SELECT * FROM [tbBook]" UpdateCommand="UPDATE [tbBook] SET [BookName] = ?, [Price] = ?, [PublishDate] = ? WHERE [ISBN] = ? AND [BookName] = ? AND (([Price] = ?) OR ([Price] IS NULL AND ? IS NULL)) AND (([PublishDate] = ?) OR ([PublishDate] IS NULL AND ? IS NULL))">
            <DeleteParameters>
                <asp:Parameter Name="original_ISBN" Type="String" />
                <asp:Parameter Name="original_BookName" Type="String" />
                <asp:Parameter Name="original_Price" Type="Decimal" />
                <asp:Parameter Name="original_Price" Type="Decimal" />
                <asp:Parameter Name="original_PublishDate" Type="DateTime" />
                <asp:Parameter Name="original_PublishDate" Type="DateTime" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="ISBN" Type="String" />
                <asp:Parameter Name="BookName" Type="String" />
                <asp:Parameter Name="Price" Type="Decimal" />
                <asp:Parameter Name="PublishDate" Type="DateTime" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="BookName" Type="String" />
                <asp:Parameter Name="Price" Type="Decimal" />
                <asp:Parameter Name="PublishDate" Type="DateTime" />
                <asp:Parameter Name="original_ISBN" Type="String" />
                <asp:Parameter Name="original_BookName" Type="String" />
                <asp:Parameter Name="original_Price" Type="Decimal" />
                <asp:Parameter Name="original_Price" Type="Decimal" />
                <asp:Parameter Name="original_PublishDate" Type="DateTime" />
                <asp:Parameter Name="original_PublishDate" Type="DateTime" />
            </UpdateParameters>
        </asp:AccessDataSource>
        </div>
        <div>
        <asp:RadioButtonList ID="radBtn" runat="server" AutoPostBack="True" RepeatDirection="Horizontal" style="z-index: 1; left: 15px; top: 374px; position: absolute; height: 26px; width: 191px" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged">
            <asp:ListItem Value="add">添加</asp:ListItem>
            <asp:ListItem Value="delete">删除</asp:ListItem>
            <asp:ListItem Value="update">更新</asp:ListItem>
        </asp:RadioButtonList>
        </div>
        <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" style="z-index: 1; left: 7px; top: 40px; position: absolute; height: 317px; width: 574px" AllowPaging="True" PageSize="4" OnPageIndexChanging="GridView1_PageIndexChanging">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
        </asp:GridView>

        <asp:TextBox ID="TextBox1" runat="server" style="z-index: 1; left: 293px; top: 377px; position: absolute; width: 258px; margin-top: 0px"></asp:TextBox>

        <asp:Button ID="Button7" runat="server" OnClick="Button7_Click" style="z-index: 1; left: 229px; top: 376px; position: absolute" Text="查询" />

        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:physique_testConnectionString %>" SelectCommand="SELECT * FROM [tb_class]"></asp:SqlDataSource>

        <asp:MultiView ID="MultiView1" runat="server">
            <asp:View ID="View1" runat="server">
                ISBN:<asp:TextBox ID="tb_num" runat="server"></asp:TextBox>
                BookName:<asp:TextBox ID="tb_name" runat="server"></asp:TextBox>
                <asp:Button ID="btn_add" runat="server" Text="确定" OnClick="Button3_Click" />
                <asp:Button ID="Button4" runat="server" Text="取消" />
            </asp:View>
            <asp:View ID="View2" runat="server">
                <asp:DropDownList ID="ddl_view2" runat="server" DataSourceID="AccessDataSource1" DataTextField="BookName" DataValueField="ISBN"></asp:DropDownList>
                <asp:Button ID="Button1" runat="server" Text="确定" OnClick="Button1_Click" />
                <asp:Button ID="Button2" runat="server" Text="取消" />
            </asp:View>
            <asp:View ID="View3" runat="server">
                <asp:DropDownList ID="ddl_view3" runat="server" DataSourceID="AccessDataSource1" DataTextField="BookName" DataValueField="ISBN"></asp:DropDownList>
                <asp:TextBox ID="view3_tb_name" runat="server"></asp:TextBox>
                <asp:Button ID="Button5" runat="server" Text="确定" />
                <asp:Button ID="Button6" runat="server" Text="取消" />
            </asp:View>
        </asp:MultiView>

           

    </form>
</body>
</html>
