<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Create_Event.aspx.cs" Inherits="BoilerPlay.Create_Event" %>

<!DOCTYPE html>
<link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Event</title>
</head>
<body>
    <form runat="server">
    
    <div class="container-fluid bg-dark text-white pt-5">
        <div class="row mb-5">
            <div class="col-md-4 mb-5"></div>
            <div class="col-md-4 col-12">
                <h1 class="text-center">BoilerPlay</h1>
                <p class="text-center">Find teammates anytime, anywhere!</p>
                <div class="row text-center">
                    <div class="col-3 col-md-3"><asp:Button runat="server" CssClass="btn btn-light mb-5" ID="createEventBtn" style="font-size: 11.9px; font-weight: bold" OnClick="createEventBtn_Click" Text="Create Event" /></div>                 
                    <div class="col-3 col-md-3"><asp:Button runat="server" CssClass="btn btn-light mb-5" ID="allEventsBtn" style="font-size: 11.9px; font-weight: bold" OnClick="allEventsBtn_Click" Text="All Events" /></div>               
                    <div class="col-3 col-md-3"><asp:Button runat="server" CssClass="btn btn-light mb-5" ID="myEventBtn" style="font-size: 11.9px; font-weight: bold" OnClick="myEventBtn_Click" Text="My Events" /></div>
                    <div class="col-3 col-md-3"><asp:Button runat="server" CssClass="btn btn-light mb-5" ID="profileBtn" style="font-size: 11.9px; font-weight: bold" OnClick="profileBtn_Click" Text="Profile" /></div>
                </div>
             </div>
        </div>
    </div>
    <div class="col-md-5"></div>
    <div style="text-align:right;margin-right:20px;margin-top:0px">
        <asp:Button runat="server" CssClass="btn btn-secondary mb-5" ID="logOutBtn" style="font-size: 11.9px; font-weight: bold" OnClick="logOutBtn_Click" Text="Log Out" />
    </div>

    <div class="row">
        <div class="col-md-3"></div>
        <div class="col-md-6">
            <div style="width:80%; text-align:center">
                <div class="alert alert-danger" runat="server" id="failedMessage" role="alert">

                </div>
            </div>
        </div>
    </div>

    <form class="form-horizontal mt-5" role="form">
        <div class="container text-center">
        <div class="row">
            <div class="col-md-3 col-3"></div>
            <div class="col-md-2 col-10">
                <div class="form-group">
                    <div class="form-group">
                    <label for="SportName" runat="server" class="dropdown-item-text" >Sport Name</label>
                      <select runat="server"  id="SportName">
                      </select>
                 </div>
                 </div>
             </div>
            <div class="col-md-2 col-10">
                <div class="form-group">
                    <label for="Proficiency" class="dropdown-item-text">Proficiency:</label>
                      <select runat="server" id="proficiency">
                        <option>Beginner</option>
                        <option>Amateur</option>
                        <option>Skilled</option>
                        <option>Expert</option>
                      </select>
                 </div>
            </div>
            <div class="col-md-2 col-10">
                <div class="form-group">
                    <label for="Gender" class="dropdown-item-text">Gender:</label>
                      <select runat="server" id="Gender">
                        <option>Male</option>
                        <option>Female</option>
                        <option>Both</option>
                      </select>
                 </div>
            </div>
            <div class="col-md-3 col-3"></div>
            </div>
            <div class="row">
                <div class="col-md-3 col-3"></div>
                    <div class="col-md-6 col-10">
                        <div class="form-group">
                            <input type="number" class="form-control bg-light" runat="server" id="ReqPeople" placeholder="Number of Poeple Requied">
                         </div>
                    </div>
                <div class="col-md-3 col-3"></div>
                <div class="col-md-3 col-3"></div>
                    <div class="col-md-6 col-10">
                        <div class="form-group">
                            <input type="text" class="form-control bg-light" runat="server" id="Location" placeholder="Location">
                         </div>
                    </div>
            </div>
           <div class="row">
           <div class="col-md-3 col-3"></div>
            <div class="col-md-6 col-10">
                <div class="form-group">
                    <input type="text" class="form-control bg-light" runat="server" id="SportDescription" placeholder="Description">
                 </div>
            </div>
            <div class="col-md-12 col-10 text-center">  
                <div class="row">
                    <div class="col-md-4 col-6 ml-2"></div>
                    <div class="col-md-6 col-6 ml-4">
                        <p> <asp:Calendar ID="Calendar" runat="server"></asp:Calendar></p>
                     </div>
                </div>
                <p class="mt-3 mb-3 ml-n3 mr-4">Time: <input type="time" min="00:00" max="23:59" id="appt" runat="server" name="time"></p>
            
            <div class="form-group text-center">
                 <button class="btn btn-dark" id="CreateEve" runat="server" onServerClick="CreateEve_ServerClick">Create Post</button>
            </div>
            </div>
        </div>
        </div>
    </form>
        </form>
</body>
</html>
