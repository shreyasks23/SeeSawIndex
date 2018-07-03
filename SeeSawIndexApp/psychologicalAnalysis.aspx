<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="psychologicalAnalysis.aspx.cs" Inherits="SeeSawIndexApp.psychologicalAnalysis" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Psychological Analysis</title>
    <link href="Content/bootstrap.css" rel="stylesheet" />
</head>
<body style= "background-size:cover ; background-image:url(Assets/PKL1.png)">
    <form id="form1" runat="server">            
       
        <asp:ScriptManager ID="ScriptManager1" runat="server" /> 
        &nbsp &nbsp
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">  
            <ContentTemplate >
                <div class="container" style="align-self:flex-end">
                     <br /> <br /> <br /> <br /> <br />              
            <div class="align-content-sm-end" style="float:right ; background-color:transparent">
                &nbsp
                <br />
                <br />

                
               &nbsp &nbsp &nbsp <asp:Chart ID="Chart1" runat="server" BorderlineWidth="0" EnableTheming="False" DataSourceID="ChartData" OnLoad="Chart1_Load" BorderWidth="30" CssClass="align-content-md-start" >
                   <BorderSkin BackColor="Transparent" PageColor="Transparent" SkinStyle="Emboss" />
                    
                    <series>
                        <asp:Series Name="Series1" YValuesPerPoint="2" XValueMember="EventID" YValueMembers="Score" >
                        </asp:Series>
                    </series>
                    <chartareas>
                        <asp:ChartArea Name="ChartArea1">
                        </asp:ChartArea>
                    </chartareas>                    
                </asp:Chart>
                <asp:SqlDataSource ID="ChartData" runat="server" ConnectionString="<%$ ConnectionStrings:SeeSawIndexConnectionString %>" SelectCommand="SELECT * FROM [PsychologicalIndex]" ProviderName="System.Data.SqlClient"></asp:SqlDataSource>
                
                <div style="float:initial"> &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp
                 <asp:Button ID="Button6"  class="btn-link" ForeColor="WhiteSmoke" Text="Clear" runat="server" Height="50px" Width="120px" OnClick="Unnamed6_Click"/>
                 </div>
                </div>
            <h3 class="align-items-xl-center" style="text-align:center; color:white ">Psychological Index <span class="label label-default">In-Game Analysis</span></h3> 
            &nbsp &nbsp &nbsp &nbsp &nbsp  &nbsp  &nbsp  &nbsp  &nbsp  &nbsp  &nbsp  &nbsp  &nbsp  &nbsp<table class="table" style="display:inline">                
                <tr class="row">                    
                    <td class="col-auto"><asp:Button ID="Button1" class="btn-success" Text ="Alpha" runat="server" Height="40px" Width="150px" OnClick="Unnamed1_Click"   /></td>
                    <td class="col-auto"><asp:Button ID="Button2" class="btn-primary" Text ="Victorious" runat="server"  Height="40px" Width="160px" OnClick="Unnamed2_Click"  /></td>
                    <td class="col-auto"> <asp:Button ID="Button3" class="btn-warning" Text ="Neutral/Composed" runat="server"  Height="40px" Width="180px" OnClick="Unnamed3_Click" /> <br /></td>
                    
                    
                </tr>
                <tr class="row">
                    <td class="col-auto">
                        &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp<asp:Button ID="Button4" class="btn-danger" Text ="Disstress" runat="server"  Height="40px" Width="150px" OnClick="Unnamed4_Click"  /> &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp </td>
                    
                    <td class="col-auto"><asp:Button ID="Button5" class="btn-danger" Text ="Defeat" runat="server"  Height="40px" Width="150px" OnClick="Unnamed5_Click" /> &nbsp &nbsp &nbsp &nbsp</td>
                </tr> 
            </table>
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    
        </div>
                </ContentTemplate>
            </asp:UpdatePanel>
    </form>
</body>
</html>
