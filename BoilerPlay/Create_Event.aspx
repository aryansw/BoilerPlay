<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Create_Event.aspx.cs" Inherits="BoilerPlay.Create_Event" %>

<!DOCTYPE html>
<link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Event</title>
</head>
<body>

    <div class="container-fluid bg-dark text-white text-center">
        <div class="row pt-5 pl-5 pr-5 ">
            <div class="col-12 col-md-12 text-center pt-5 pl-5 pr-5">
                 <h1 class="text-center">BoilerPlay</h1>
            </div>
        </div>
    </div>
    <form class="form-horizontal mt-5" id="login_form" role="form" runat="server">
        <div class="container text-center">
        <div class="row">
            <div class="col-md-3 col-3"></div>
            <div class="col-md-2 col-10">
                <div class="form-group">
                    <div class="form-group">
                    <label for="SportName" class="dropdown-item-text"  runat="server" id="SportName">Sport Name</label>
                      <select>
                        <option>Basketball</option>
                      </select>
                 </div>
                 </div>
             </div>
            <div class="col-md-2 col-10">
                <div class="form-group">
                    <label for="Proficiency" class="dropdown-item-text">Proficiency:</label>
                      <select>
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
                      <select>
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
                <div class="col-md-8"></div>
                <div class="col-md-4">
                    <p> <asp:Calendar ID="Calendar" runat="server"></asp:Calendar></p>
                </div>
                <p class="m-3 ml-n5 mr-5">Time: <input type="time" id="appt" name="time" required></p>
            </div>
        </div>
        </div>
    </form>
</body>
</html>
