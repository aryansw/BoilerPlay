<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="BoilerPlay.LoginPage" %>

<!DOCTYPE html>
 <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
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
                    <form class="form-horizontal" id="login-form" role="form">
                        <div class="form-group m-5">
                            <input type="email" class="form-control bg-light" id="email" name="email" placeholder="Email ID" value="" required>
                        </div>
                        <div class="form-group m-5">
                            <input type="password" class="form-control bg-light" id="Password" placeholder="Password" required>
                        </div>
                        <div class="form-group text-center">
                            <input id="Login" name="submit" type="submit" value="LOGIN" class="btn btn-dark">
                        </div>
                        <p class="text-center">Don't have an account?</p>
                        <div class="form-group text-center">
                            <a href="#" class="btn btn-dark">SIGN UP</a>
                        </div>

                     </form>
                 </div>
            </div>
        </div>
    </div>
</body>
</html>
