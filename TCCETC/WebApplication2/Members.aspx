<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Members.aspx.cs" CodeFile="Members.aspx.cs" Inherits="TCCETC.Members" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
    <html xmlns="http://www.w3.org/1999/xhtml">
    <head>
        <title>Untitled Page</title>
    </head>
    <body>
        <h2>Members</h2>
        <p>Pas de membres inscrits actuellement.</p>

        
            <div>
                <asp:DataGrid ID="Grid" runat="server" PageSize="5" AllowPaging="True" DataKeyField="UserId"
                    AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" OnPageIndexChanged="Grid_PageIndexChanged" OnCancelCommand="Grid_CancelCommand"
                    OnDeleteCommand="Grid_DeleteCommand" OnEditCommand="Grid_EditCommand" OnUpdateCommand="Grid_UpdateCommand">
                    <Columns>
                        <asp:BoundColumn HeaderText="UserId" DataField="UserId"></asp:BoundColumn>
                        <asp:BoundColumn HeaderText="Fisrtname" DataField="Firstname"></asp:BoundColumn>
                        <asp:BoundColumn HeaderText="LastName" DataField="LastName"></asp:BoundColumn>
                        <asp:BoundColumn DataField="UserName" HeaderText="UserName"></asp:BoundColumn>
                        <asp:BoundColumn DataField="IsAnonymous" HeaderText="IsAnonymous"></asp:BoundColumn>
                        <asp:BoundColumn DataField="LastActivityDate" HeaderText="LastActivityDate"></asp:BoundColumn>
                        <asp:EditCommandColumn EditText="Edit" CancelText="Cancel" UpdateText="Update" HeaderText="Edit"></asp:EditCommandColumn>
                        <asp:ButtonColumn CommandName="Delete" HeaderText="Delete" Text="Delete"></asp:ButtonColumn>
                    </Columns>
                    <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                    <SelectedItemStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
                    <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" Mode="NumericPages" />
                    <AlternatingItemStyle BackColor="White" />
                    <ItemStyle BackColor="#FFFBD6" ForeColor="#333333" />
                    <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                </asp:DataGrid>
                <br />
                <br />
                <table>
                    <tr>
                        <td>
                            <asp:Label ID="lblUserId" runat="server" Text="UserId"></asp:Label>
                            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                        </td>
                        <td>
                            <asp:Label ID="lblfname" runat="server" Text="Firstname"></asp:Label>
                            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                        </td>
                        <td>
                            <asp:Label ID="lblLname" runat="server" Text="LastName"></asp:Label>
                            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                        </td>
                        <td>
                            <asp:Label ID="lblUname" runat="server" Text="UserName"></asp:Label>
                            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                        </td>
                        <td>
                            <asp:Label ID="lblIsanonymous" runat="server" Text="IsAnonymous"></asp:Label>
                            <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                            Q
                        </td>
                        <td>
                            <asp:Label ID="lblLastactivitydate" runat="server" Text="LastActivityDate"></asp:Label>
                            <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                </table>
                <asp:Button ID="btnsubmit" runat="server" Text="Submit" OnClick="btnsubmit_Click" />
                <asp:Button ID="btnReset" runat="server" Text="Reset" OnClick="btnReset_Click" />
                <asp:Button ID="btnOk" runat="server" Text="OK" OnClick="btnOk_Click" />
            </div>
            <div>
                <asp:DataGrid ID="Grid1" runat="server" PageSize="5" AllowPaging="True" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None">
                    <Columns>
                        <asp:BoundColumn HeaderText="UserId" DataField="UserId"></asp:BoundColumn>
                        <asp:BoundColumn HeaderText="Firstname" DataField="Firstname"></asp:BoundColumn>
                        <asp:BoundColumn HeaderText="LastName" DataField="LastName"></asp:BoundColumn>
                        <asp:BoundColumn DataField="UserName" HeaderText="UserName"></asp:BoundColumn>
                        <asp:BoundColumn DataField="IsAnonymous" HeaderText="IsAnonymous"></asp:BoundColumn>
                        <asp:BoundColumn DataField="LastActivityDate" HeaderText="LastActivityDate"></asp:BoundColumn>
                    </Columns>
                    <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                    <SelectedItemStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
                    <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" Mode="NumericPages" />
                    <AlternatingItemStyle BackColor="White" />
                    <ItemStyle BackColor="#FFFBD6" ForeColor="#333333" />
                    <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                </asp:DataGrid>
            </div>
        
    </body>
    </html>
</asp:Content>
