<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="test_2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 29px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td class="auto-style1">Name</td>
                    <td class="auto-style1">
                        <asp:TextBox ID="name_txt" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Department</td>
                    <td>
                        <asp:TextBox ID="dep_txt" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>PRN</td>
                    <td>
                        <asp:TextBox ID="prn_txt" runat="server"></asp:TextBox></td>
                </tr>
            </table>
        </div>
        <asp:Button ID="view_btn" runat="server" Text="View" OnClick="view_btn_Click" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="insert_btn" runat="server" Text="Insert" OnClick="insert_btn_Click" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="delete_btn" runat="server" Text="Delete" OnClick="delete_btn_Click" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="update_btn" runat="server" Text="Update" />

        <asp:GridView ID="Gridview1" runat="server"></asp:GridView>
    </form>
    
</body>
</html>
