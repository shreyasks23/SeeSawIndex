<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="SeeSawIndexApp.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>See-Saw Index</title>
    <link href="Content/bootstrap.css" rel="stylesheet" />
</head>
<body style= "background-size:cover ; background-image:url(Assets/PKL1.png)">
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server" />
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                &nbsp &nbsp
        <div class="container" style="align-self:flex-end">
            <div class="align-content-sm-end" style="float: right; background-color:transparent">
                 <br />
                 <br />
                 <br />
                 <br />
                 <br />                 
                <asp:Chart ID="Chart1" runat="server" DataSourceID="ChartData" BorderlineWidth="0" EnableTheming="False" OnLoad="Chart1_Load" BorderWidth="30" CssClass="align-content-md-start">
                    <BorderSkin BackColor="Transparent" PageColor="Transparent" SkinStyle="Emboss" />
                    <Series>
                        <asp:Series ChartType="Line" Name="Series1" YValueMembers="EventScore" XValueMember="EventID" YValuesPerPoint="2">
                        </asp:Series>
                    </Series>
                    <ChartAreas>
                        <asp:ChartArea Name="ChartArea1">
                        </asp:ChartArea>
                    </ChartAreas>
                </asp:Chart>
                <asp:SqlDataSource ID="ChartData" runat="server" ConnectionString="<%$ ConnectionStrings:SeeSawIndexConnectionString %>" SelectCommand="SELECT * FROM [SeeSawIndexScore]"></asp:SqlDataSource>
                <div style="float:initial">
                    <br />
                    <br />
            <asp:Button ID="Button11"  class="btn-link" ForeColor="WhiteSmoke" Text="Psychological Index" runat="server" Height="50px" Width="160px" OnClick="Unnamed11_Click" />
              &nbsp &nbsp &nbsp &nbsp<asp:Button ID="Button12"  class="btn-link" ForeColor="WhiteSmoke" Text="Clear" runat="server" Height="50px" Width="120px" OnClick="Unnamed12_Click"  />
                </div>
            </div>
            
             <br />
             <br />
             <br />
            <br />
            
            <h3 style="color:#f95a45; text-align:center">See Saw Index <span class="label label-default">Pre-Game Analysis</span></h3>
            &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp<table class="table" style="display: inline; grid-column-align:stretch">
                <tr class="row">
                    <td class="col-auto">
                        <asp:Button ID="Button1" class="btn-success" Text="Final" runat="server" Height="40px" Width="150px" OnClick="Unnamed1_Click" /></td>
                    <td class="col-auto">
                        <asp:Button ID="Button2" class="btn-primary" Text="Semi-Final & PlayOff" runat="server" Height="40px" Width="160px" OnClick="Unnamed2_Click" /></td>
                    <td class="col-auto">
                        <asp:Button ID="Button3" class="btn-warning" Text="Derby Match/Popularity" runat="server" Height="40px" Width="180px" OnClick="Unnamed3_Click" />
                        <br />
                    </td>
                </tr>
                <tr class="row">
                    <td class="col-auto">
                       &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp <asp:Button ID="Button4" class="btn-danger" Text="Leader Board" runat="server" Height="40px" Width="150px" OnClick="Unnamed4_Click" />
                        &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp </td>

                    <td class="col-auto">
                        <asp:Button ID="Button5" class="btn-danger" Text="Regular Match" runat="server" Height="40px" Width="150px" OnClick="Unnamed5_Click" />
                        &nbsp &nbsp &nbsp &nbsp</td>
                </tr>
            </table>
            <br />
             <br />
            <br />
             <br />
                        

            <h3 style="color:white; text-align:center">See Saw Index <span class="label label-default">In Game Parameters</span></h3>
            &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp<table class="table" style="display: inline">
                <tr class="row">
                    <td class="col-auto">
                        <asp:Button ID="Button6" class="btn-success" Text="Come Back" runat="server" Height="40px" Width="150px" OnClick="Unnamed6_Click" /></td>
                    <td class="col-auto">
                        <asp:Button ID="Button7" class="btn-primary" Text="AllOut/ST/SR/S10/Hi5" runat="server" Height="40px" Width="180px" OnClick="Unnamed7_Click" /></td>
                    <td class="col-auto">
                        <asp:Button ID="Button8" class="btn-warning" Text="Important Player/DoD" runat="server" Height="40px" Width="180px" OnClick="Unnamed8_Click" />
                        &nbsp &nbsp &nbsp &nbsp</td>
                </tr>
                <tr class="row">
                    <td class="col-auto"  style="align-content:center">
                         &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp<asp:Button ID="Button9" class="btn-danger" Text="Regular Raid" runat="server" Height="40px" Width="150px" OnClick="Unnamed9_Click" style="align-self:center"/> &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp
                    </td>
                    <td class="col-auto" >
                        <asp:Button ID="Button10" class="btn-danger" Text="Empty" runat="server" Height="40px" Width="150px" OnClick="Unnamed10_Click" /> &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp
                    </td>
                </tr>
            </table>
            <br />
            <br />
            <br />
            <br />           
            
        </div>
            </ContentTemplate>
        </asp:UpdatePanel>
    </form>
</body>
<script src="Scripts/bootstrap.js"></script>
</html>
