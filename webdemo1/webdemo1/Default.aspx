<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="webdemo1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div>
        <h1>Works Now</h1>
        <form id="form1" runat="server">
          <% for(int i = 0; i < 6; i++) %> 
       <% { Response.Write("<br>" + i.ToString());
               Response.Write(Request.QueryString);

           }%>
    </form>
    </div>

</asp:Content>
