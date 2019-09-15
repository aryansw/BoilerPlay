<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainPage.aspx.cs" Inherits="BoilerPlay.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" />
<head runat="server">
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <title>BoilerPlay</title>
</head>
<body>
    <div class="container-fluid bg-dark text-white pt-5">
        <div class="row mb-5">
            <div class="col-md-4 mb-5"></div>
            <div class="col-md-4 col-12">
                <h1 class="text-center">BoilerPlay</h1>
                <p class="text-center">Find teammates anytime, anywhere!</p>
                <div class="row text-center">
                    <div class="col-6 col-md-6"><a href="#" class="btn btn-light mb-5">Create Event</a></div>                
                    <div class="col-6 col-md-6"><a href="#" class="btn btn-light mb-5">My events</a></div>
                </div>
             </div>
            <div class="col-md-4 col-12 text-right">
                <a href="#"><img src="avatar_circle.png" width="20%" /></a>
                    <p><a href="#">NAME</a></p>
            </div>
        </div>
    </div>
    <div class="card" runat="server" id="card0">
        <img class="card-img-top" src="random.jpeg" alt="Card image cap">
        <div class="card-body">
           <h4 class="card-title"><b>Sport name</b></h4>
           <p runat="server" id="DatePrint0" class="card-text">Date and Time</p>
           <p runat="server" id="Location0" class="card-text">Location</p>
           <p runat="server" id="Proficiency0" class="card-text">Proficiency</p>
           <p runat="server" id="People0" class="card-text">People committed</p>
           <p runat="server" id="Description0" class="card-text">Description</p>


            <a href="#" class="btn btn-primary">I'm interested!</a>
        </div>  
    </div>
     <div class="card" runat="server" id="card1">
        <img class="card-img-top" src="random.jpeg" alt="Card image cap">
        <div class="card-body">
           <h4 class="card-title"><b>Sport name</b></h4>
           <p runat="server" id="DatePrint1" class="card-text">Date and Time</p>
           <p runat="server" id="Location1" class="card-text">Location</p>
           <p runat="server" id="Proficiency1" class="card-text">Proficiency</p>
           <p runat="server" id="People1" class="card-text">People committed</p>
           <p runat="server" id="Description1" class="card-text">Description</p>


            <a href="#" class="btn btn-primary">I'm interested!</a>
        </div>  
    </div>
     <div class="card" runat="server" id="card2">
        <img class="card-img-top" src="random.jpeg" alt="Card image cap">
        <div class="card-body">
           <h4 class="card-title"><b>Sport name</b></h4>
           <p runat="server" id="DatePrint2" class="card-text">Date and Time</p>
           <p runat="server" id="Location2" class="card-text">Location</p>
           <p runat="server" id="Proficiency2" class="card-text">Proficiency</p>
           <p runat="server" id="People2" class="card-text">People committed</p>
           <p runat="server" id="Description2" class="card-text">Description</p>


            <a href="#" class="btn btn-primary">I'm interested!</a>
        </div>  
    </div>
    <div class="card" runat="server" id="card3">
        <img class="card-img-top" src="random.jpeg" alt="Card image cap">
        <div class="card-body">
           <h4 class="card-title"><b>Sport name</b></h4>
           <p runat="server" id="DatePrint3" class="card-text">Date and Time</p>
           <p runat="server" id="Location3" class="card-text">Location</p>
           <p runat="server" id="Proficiency3" class="card-text">Proficiency</p>
           <p runat="server" id="People3" class="card-text">People committed</p>
           <p runat="server" id="Description3" class="card-text">Description</p>


            <a href="#" class="btn btn-primary">I'm interested!</a>
        </div>  
    </div>
     <div class="card" runat="server" id="card4">
        <img class="card-img-top" src="random.jpeg" alt="Card image cap">
        <div class="card-body">
           <h4 class="card-title"><b>Sport name</b></h4>
           <p runat="server" id="DatePrint4" class="card-text">Date and Time</p>
           <p runat="server" id="Location4" class="card-text">Location</p>
           <p runat="server" id="Proficiency4" class="card-text">Proficiency</p>
           <p runat="server" id="People4" class="card-text">People committed</p>
           <p runat="server" id="Description4" class="card-text">Description</p>


            <a href="#" class="btn btn-primary">I'm interested!</a>
        </div>  
    </div>
     <div class="card" runat="server" id="card5">
        <img class="card-img-top" src="random.jpeg" alt="Card image cap">
        <div class="card-body">
           <h4 class="card-title"><b>Sport name</b></h4>
           <p runat="server" id="DatePrint5" class="card-text">Date and Time</p>
           <p runat="server" id="Location5" class="card-text">Location</p>
           <p runat="server" id="Proficiency5" class="card-text">Proficiency</p>
           <p runat="server" id="People5" class="card-text">People committed</p>
           <p runat="server" id="Description5" class="card-text">Description</p>


            <a href="#" class="btn btn-primary">I'm interested!</a>
        </div>  
    </div>
     <div class="card" runat="server" id="card6">
        <img class="card-img-top" src="random.jpeg" alt="Card image cap">
        <div class="card-body">
           <h4 class="card-title"><b>Sport name</b></h4>
           <p runat="server" id="DatePrint6" class="card-text">Date and Time</p>
           <p runat="server" id="Location6" class="card-text">Location</p>
           <p runat="server" id="Proficiency6" class="card-text">Proficiency</p>
           <p runat="server" id="People6" class="card-text">People committed</p>
           <p runat="server" id="Description6" class="card-text">Description</p>


            <a href="#" class="btn btn-primary">I'm interested!</a>
        </div>  
    </div>
     <div class="card" runat="server" id="card7">
        <img class="card-img-top" src="random.jpeg" alt="Card image cap">
        <div class="card-body">
           <h4 class="card-title"><b>Sport name</b></h4>
           <p runat="server" id="DatePrint7" class="card-text">Date and Time</p>
           <p runat="server" id="Location7" class="card-text">Location</p>
           <p runat="server" id="Proficiency7" class="card-text">Proficiency</p>
           <p runat="server" id="People7" class="card-text">People committed</p>
           <p runat="server" id="Description7" class="card-text">Description</p>


            <a href="#" class="btn btn-primary">I'm interested!</a>
        </div>  
    </div>
     <div class="card" runat="server" id="card8">
        <img class="card-img-top" src="random.jpeg" alt="Card image cap">
        <div class="card-body">
           <h4 class="card-title"><b>Sport name</b></h4>
           <p runat="server" id="DatePrint8" class="card-text">Date and Time</p>
           <p runat="server" id="Location8" class="card-text">Location</p>
           <p runat="server" id="Proficiency8" class="card-text">Proficiency</p>
           <p runat="server" id="People8" class="card-text">People committed</p>
           <p runat="server" id="Description8" class="card-text">Description</p>


            <a href="#" class="btn btn-primary">I'm interested!</a>
        </div>  
    </div>
     <div class="card" runat="server" id="card9">
        <img class="card-img-top" src="random.jpeg" alt="Card image cap">
        <div class="card-body">
           <h4 class="card-title"><b>Sport name</b></h4>
           <p runat="server" id="DatePrint9" class="card-text">Date and Time</p>
           <p runat="server" id="Location9" class="card-text">Location</p>
           <p runat="server" id="Proficiency9" class="card-text">Proficiency</p>
           <p runat="server" id="People9" class="card-text">People committed</p>
           <p runat="server" id="Description9" class="card-text">Description</p>


            <a href="#" class="btn btn-primary">I'm interested!</a>
        </div>  
    </div>
        
    </div>
    <form id="form1" runat="server">
    <div class="row">
        
        </div>
    </div>
        <div>
        </div>
    </form>
</body>
</html>
