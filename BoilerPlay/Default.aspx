<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="BoilerPlay._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row m-5">
        <div class="col-md-6 col-6 m-5">
            <div class ="card">
                <div class="row text-center">
                    <div class="col-md-4 col-4">
                        <img src="Images/IMG_2429.jpg" class="img-responsive card-img-top" width="100%"/>
                    </div>
                </div>
                <input id="UserName" type="text" placeholder="Username"/>
                <br />
                <input id="Password" type="password" placeholder="Password" /><br />
                <asp:LinkButton runat="server" BorderStyle="Solid" BorderWidth="50px" BorderHeight="20px" Font-Bold="True"><a href="#">LOGIN</a></asp:LinkButton><br />
                <asp:LinkButton ID="SignUp" runat="server" BorderStyle="Solid" Font-Bold="True"><a href="#">SIGN UP</a></asp:LinkButton>
            </div>

        </div>
    </div>
    
       

</asp:Content>
