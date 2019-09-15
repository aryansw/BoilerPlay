<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="BoilerPlay.Registration" %>

<!DOCTYPE html>
 <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Registration</title>
</head>
<body>
    <div class="row m-5">
        <div class="col-md-3"></div>
        <div class="col-md-6">
            <div class="card">
                <div class="card-body">
                    <div class="card-header container-fluid bg-dark text-white">
                        <h2 class="text-center">BoilerPlay</h2>
                    </div>
                    <form class="form-horizontal" id="registration_form" role="form" runat="server">
                        <div class="form-group m-3">
                            <input type="text" class="form-control bg-light"  runat="server" id="Name" name="name" placeholder="Name" value="" required>
                        </div>
                        <div class="form-group m-3">
                            <input type="email" class="form-control bg-light" runat="server" id="email" name="email" placeholder="Email ID" value="">
                        </div>
                         <div class="form-group m-3">
                            <input type="tel" id="phone" name="phone" maxlength="10" runat="server" pattern="[0-9]{10}" class="form-control bg-light" required placeholder="Phone number" >
                        </div>
                        <div class="form-group m-3" id="form" runat="server">
                            <h4>Year:</h4>
                            <label class="radio-inline mx-3" id ="form1"><input type="radio" name="optradio" checked>Freshman</label>
                            <label class="radio-inline mx-3" id ="form2"><input type="radio" name="optradio">Sophomore</label>
                            <label class="radio-inline mx-3" id ="form3"><input type="radio" name="optradio">Junior</label>
                            <label class="radio-inline mx-3" id ="form4"><input type="radio" name="optradio">Senior</label>
                        </div>
                        <div class="form-group m-3">
                            <input type="password" class="form-control bg-light" runat="server" id="Password" placeholder="Password">
                        </div>
                        <div class="form-group m-3">
                            <input type="password" class="form-control bg-light" runat="server" id="Password1" placeholder="Re-enter Password">
                        </div>
                        <div class="form-group m-3">
                            <input type="text" id="description" name="description" runat="server" class="form-control bg-light" placeholder="Description (Fun Facts/Interests)">
                        </div>
                        <div class="form-group text-center">
                            <button class="btn btn-dark" id="Register" runat="server" onServerClick="Register_ServerClick">SIGN UP</button>
                        </div>
                     </form>
                 </div>
            </div>
        </div>
    </div>
</body>
</html>
