<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Personal_profile.aspx.cs" Inherits="BoilerPlay.Personal_profile" %>

<!DOCTYPE html>
<link href="https://maxcdn.bootstrapcdn.com/font-awesome/4.3.0/css/font-awesome.min.css" rel="stylesheet">
<link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css">

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <title></title>
</head>
<body>
   <div class="container-fluid bg-dark text-white text-center">
        <div class="row pt-5 pl-5 pr-5 ">
            <div class="col-12 col-md-12 text-center pt-5 pl-5 pr-5">
                 <h1 class="text-center">BoilerPlay</h1>
            </div>
        </div>
    </div>
    <div class="container">
       <div class="row pt-5 text-center">
           <div class="col-md-1"></div>
           <div class="col-md-10 col-10">
              <div class="card">
                <div class="card-body">
                    <form class="form-horizontal" id="Personal_profile_Form" role="form" runat="server">
                        <div class="row">
                            <div class="col-4 col-md-4"></div>
                            <div class="col-4 col-md-4">
                                <h2>Your Profile</h2>
                            </div>
                            <div class="col-4 col-md-4 text-right pr-4">
                                <button class="btn btn-dark" id="Edit">Edit</button>
                            </div>
                        </div>
                        <div class="form-group m-3">
                            <input type="text" class="form-control bg-light" runat="server" id="ProfileName" name="name" placeholder="Profile_Name" value="" required>
                        </div>
                        <div class="form-group m-3">
                            <input type="email" class="form-control bg-light" runat="server" id="ProfileEmail" name="email" placeholder="Profile_Email" value="" required>
                        </div>
                        <div class="form-group m-3">
                            <input type="text" class="form-control bg-light" runat="server" id="Profile_Description" name="description" placeholder="Profile_Description" value="" required>
                        </div>
                        <div class="form-group m-3">
                            <div class="row">
                                <div class="col-6 col-md-6">
                                    <p class="text-left">Phone number: </p>
                                    <input type="tel" id="Profile_PhoneNumber" name="phone" maxlength="10" runat="server" pattern="[0-9]{10}" class="form-control bg-light" required placeholder="Profile_PhoneNumber">
                                </div>
                                <div class="col-6 col-md-6">
                                    <p class="text-left">Year:</p>
                                    <input type="text" class="form-control bg-light" runat="server" id="Profile_Year" name="year" placeholder="Profile_Year" value="" required>
                                </div>
                                <div class="col-6 col-md-6">
                                    <p class="text-left mt-3">Password:</p>
                                    <input type="password" class="form-control bg-light" runat="server" id="Profile_Password" placeholder="Profile_Password" required>
                                </div>
                                <div class="col-6 col-md-6">
                                    <p class="text-left mt-3">Re-enter Password:</p>
                                    <input type="password" class="form-control bg-light" runat="server" id="Profile_Password1" placeholder="Profile_Password" required>
                                </div>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-12 col-md-12 text-right pr-4">
                                <button class="btn btn-dark" id="SubmitChanges">Submit</button>
                            </div>
                        </div>
                     </form>
                 </div>
            </div>
           </div>
       </div>
    </div>
</body>
</html>
