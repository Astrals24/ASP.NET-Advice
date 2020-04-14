<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Entering.aspx.cs" Inherits="Entering" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="css/style.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript" language="javascript" src="js/jquery.js"></script>
</head>
<body>
    <form runat="server">
        <div class="place">
      
        </div>
        <br>

        <asp:SqlDataSource ID="StudentData" runat="server" ConnectionString="<%$ ConnectionStrings:physique_test %>" SelectCommand="SELECT * FROM [tb_class]"></asp:SqlDataSource>

        <h4>请选择班级进行录入成绩：</h4>
        <a>年级：</a>
        
        &nbsp;&nbsp;&nbsp;&nbsp;


	<a>班级：</a>
        <asp:DropDownList ID="selectClass" name="selectClass" runat="server" Style="width: 120px" AppendDataBoundItems="True" DataSourceID="StudentData" DataTextField="ClassName" DataValueField="ClassID">
        </asp:DropDownList>&nbsp;&nbsp;

        <asp:Button ID="submitSelect" runat="server" Text="确定" Style="width: 60px" OnClick="submitSelect_Click" />
        <br>
        <br>

        <div id="tableDiv" >
            <h1><asp:Label ID="Label1" runat="server" Text="" Style="text-align: center"></asp:Label></h1>
            <asp:GridView ID="physicalTable" runat="server" CellPadding="4" align="center" ForeColor="#333333" GridLines="None" AutoGenerateColumns="False" style="margin-top: 0px" >
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:BoundField DataField="StudentId" HeaderText="学生编号" ReadOnly="True" />
                    <asp:BoundField DataField="StudentName" HeaderText="学生姓名" ReadOnly="True" />
                    <asp:TemplateField Visible="false">
                        <ItemTemplate>   
                            <asp:Label ID="StudentSex" runat="server" Text='<%# Bind("Studentsex") %>' ></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="身高">
                        <ItemTemplate>   
                            <asp:TextBox ID="Height" Text='<%# Bind("Height") %>' runat="server" Width="50px"></asp:TextBox>
                            厘米
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="体重" >
                        <ItemTemplate>
                         
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
                         
                            厘米
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="800米跑" >
                        <ItemTemplate>
                            <asp:TextBox ID="Run800" Text='<%# Bind("Run800") %>' runat="server" Width="60px"></asp:TextBox>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="1000米跑" >
                        <ItemTemplate>
                            <asp:TextBox ID="Run1000" Text='<%# Bind("Run1000") %>' runat="server" Width="60px"></asp:TextBox>
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
                            
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="录入" >
                        <ItemTemplate>
                            <%--<asp:Button ID="Button1" runat="server" Text="确定" OnClick="Button1_Click" />--%>
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

        <%--<div id="tableDiv" style="display: none">
            <span id="baocuntishi"></span>
            <h1 id="classPhysical" style="text-align: center"></h1>
            <table id="physicalTable" class="altrowstable">
                <tr>
                    <th>学生编号</th>
                    <th>学生姓名</th>
                    <th>性别</th>
                    <th>身高</th>
                    <th>体重</th>
                    <th>肺活量</th>
                    <th>50米跑</th>
                    <th>立定跳远</th>
                    <th>坐位体前屈</th>
                    <th>800米跑</th>
                    <th>1000米跑</th>
                    <th>仰卧起坐</th>
                    <th>引体向上</th>
                    <th>左眼视力</th>
                    <th>右眼视力</th>
                    <th>操作</th>
                </tr>

                <tbody id="physicalTable1">
                </tbody>
            </table>
            <br>
            <div style="text-align: center">
                <input id="submit" type="Button" value="提交全部">
            </div>
        </div>--%>
    </form>
</body>
</html>
