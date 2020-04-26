<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Entering.aspx.cs" Inherits="Entering" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="css/style.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript" language="javascript" src="js/jquery.js"></script>
</head>
<body style="background-image:url(images/beijing.jpg)">
    <form runat="server">
        <div class="place">
            <span>位置</span>
            <ul class="place">
                <li ><a href="#">首页</a></li>
                <li ><a href="#">体侧管理系统</a></li>
                <li ><a href="#">录入成绩</a></li>
            </ul>

        </div>
        <br>

        <asp:SqlDataSource ID="StudentData" runat="server" ConnectionString="<%$ ConnectionStrings:physique_testConnectionString %>" SelectCommand="SELECT * FROM [tb_class]"></asp:SqlDataSource>

        <asp:SqlDataSource ID="SqlGrade" runat="server" ConnectionString="<%$ ConnectionStrings:physique_testConnectionString %>" SelectCommand="SELECT * FROM [tb_grade]"></asp:SqlDataSource>

        <h4>请选择班级进行录入成绩：</h4>
        <a>年级：</a>
        <asp:DropDownList ID="ddl_class" runat="server" AutoPostBack="True" DataSourceID="SqlGrade" DataTextField="GradeName" DataValueField="GradeId" OnSelectedIndexChanged="ddl_class_SelectedIndexChanged">
            <asp:listitem value="0">--可选择--</asp:listitem>
            <asp:listitem value="1">2019</asp:listitem>
            <asp:listitem value="2">2018</asp:listitem>
            <asp:listitem value="3">2017</asp:listitem>
        </asp:DropDownList>
        &nbsp;&nbsp;&nbsp;&nbsp;


	<a>班级：</a>
        <asp:DropDownList ID="selectClass" name="selectClass" runat="server" Style="width: 120px" AppendDataBoundItems="True" AutoPostBack="True">
            <asp:ListItem Value="0">--请选择--</asp:ListItem>
        </asp:DropDownList>&nbsp;&nbsp;

        <asp:Button ID="submitSelect" runat="server" Text="确定" Style="width: 60px" OnClick="submitSelect_Click" />
        <br>
        <br>

        <div id="tableDiv" >
            <h1><asp:Label ID="ClassName" runat="server" Style="text-align: center"></asp:Label></h1>
            <asp:GridView ID="physicalTable" runat="server" CellPadding="4" align="center" ForeColor="#333333" GridLines="None" AutoGenerateColumns="False" style="margin-top: 0px" AllowPaging="True" OnPageIndexChanging="physicalTable_PageIndexChanging" PageSize="8" >
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:BoundField DataField="StudentId" HeaderText="学生编号" ReadOnly="True" />
                    <asp:BoundField DataField="StudentName" HeaderText="学生姓名" ReadOnly="True" />
                    <asp:TemplateField Visible="false">
                        <ItemTemplate>   
                            <%--<asp:Label ID="StudentSex" runat="server" Text='<%# Bind("Studentsex") %>' ></asp:Label>--%>
   
                          <%--  <asp:TextBox ID="Studentsex" Text='<%# Bind("Studentsex") %>' runat="server" Width="50px"></asp:TextBox>
                            性别--%>
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="身高">
                        <ItemTemplate>   
                            <asp:TextBox ID="Height" Text='<%# Bind("Height") %>' runat="server" Width="50px"></asp:TextBox>
                            厘米<%--<asp:Label ID="StudentSex" runat="server" Text='<%# Bind("Height") %>' ></asp:Label>--%>
                        
                        </ItemTemplate>

                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="体重"  >


                        <ItemTemplate>
                         <asp:TextBox ID="Weight" Text='<%# Bind("Weight") %>' runat="server" Width="50px"></asp:TextBox>
                            公斤
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="肺活量" >
                        <ItemTemplate>
                            <asp:TextBox ID="LungVolume" Text='<%# Bind("LungVolume") %>' runat="server" Width="50px"></asp:TextBox>
                            毫升
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="50米跑" >
                        <ItemTemplate>
                            <asp:TextBox ID="Run50" Text='<%# Bind("Run50") %>' runat="server" Width="60px"></asp:TextBox>
                            秒
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="立定跳远" >
                        <ItemTemplate>
                            <asp:TextBox ID="StandJump" Text='<%# Bind("StandJump") %>' runat="server" Width="50px"></asp:TextBox>
                            米
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="坐位体前屈" >
                        <ItemTemplate>
                         <asp:TextBox ID="SitReach" Text='<%# Bind("SitReach") %>' runat="server" Width="50px"></asp:TextBox>
                            厘米
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="800米跑" >
                        <ItemTemplate>
                            <asp:TextBox ID="Run800" Text='<%# Bind("Run800") %>' runat="server" Width="60px"></asp:TextBox>
                            秒
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="1000米跑" >
                        <ItemTemplate>
                            <asp:TextBox ID="Run1000" Text='<%# Bind("Run1000") %>' runat="server" Width="60px"></asp:TextBox>
                            秒
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="仰卧起坐" >
                        <ItemTemplate>
                            <asp:TextBox ID="SitUp" Text='<%# Bind("SitUp") %>' runat="server" Width="50px"></asp:TextBox>
                            个
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="引体向上" >
                        <ItemTemplate>
                            <asp:TextBox ID="PullUp" Text='<%# Bind("PullUp") %>' runat="server" Width="50px"></asp:TextBox>
                            个
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="左眼视力" >
                        <ItemTemplate>
                            <asp:TextBox ID="LeftVision" Text='<%# Bind("LeftVision") %>' runat="server" Width="50px"></asp:TextBox>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="右眼视力" >
                        <ItemTemplate>
                             <asp:TextBox ID="RightVision" Text='<%# Bind("RightVision") %>' runat="server" Width="50px"></asp:TextBox>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="录入" >
                        <ItemTemplate>
                            <asp:Button ID="Button1" runat="server" Text="确定" OnClick="Button1_Click" />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
                <EditRowStyle BackColor="#2461BF" />
                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#EFF3FB" />
                <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#F5F7FB" />
                <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                <SortedDescendingCellStyle BackColor="#E9EBEF" />
                <SortedDescendingHeaderStyle BackColor="#4870BE" />
            </asp:GridView>
        </div>

        <%--<asp:Button ID="Button1" runat="server" Text="确定" OnClick="Button1_Click" />--%>
    </form>
</body>
</html>
