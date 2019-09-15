<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DisplayProfile.aspx.cs" Inherits="BoilerPlay.DisplayProfile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" />
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no"/>
    <title>Display Profile</title>
</head>
<body>
    <div class="row m-5">
        <div class="col-md-3"></div>
        <div class="col-md-6">
            <div class="card">
                <div class="card-body">
                    <div class="card-header container-fluid bg-dark text-white">
                        <h2 class="text-center">Profile</h2>
                    </div>
                    <form class="form-horizontal" id="registration_form" role="form" runat="server">
                        <div class="form-group m-3">
                            <p>Name: <input type="text" class="form-control bg-light"  runat="server" id="Name" name="name" placeholder="Name" value="" disabled="disabled"/></p>
                        </div>
                        <div class="form-group m-3">
                            <p>Email: <input type="email" class="form-control bg-light" runat="server" id="email" name="email" placeholder="Email ID" value="" disabled="disabled"/></p>
                        </div>
                        <div class="form-group m-3">
                            <p>Year: <input type="text" class="form-control bg-light"  runat="server" id="Year" name="year" placeholder="Year" value="" disabled="disabled"/></p>
                        </div>
                        <div class="form-group m-3">
                            <p>Description: <input type="text" id="description" name="description" runat="server" class="form-control bg-light" placeholder="Description (Fun Facts/Interests)" disabled="disabled"/></p>
                        </div>
                     </form>
                 </div>
            </div>
        </div>
    </div>
</body>
</html>
