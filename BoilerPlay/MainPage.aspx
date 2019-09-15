<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainPage.aspx.cs" Inherits="BoilerPlay.WebForm1" %>

<!DOCTYPE html>
<link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" />
<meta charset="utf-8">
<meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    
    <title>BoilerPlay</title>
</head>
<body>

   
    <div class="container-fluid bg-dark text-white pt-5 ">
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
                    <p class="text-right"><a href="#">NAME</a></p>
            </div>
        </div>
    </div>
  
    <div class="container-fluid">
        <div class="row">
            <div class="col-md-3">
                <div class="card p-3">
                    <div class="card-body">
                        <h2 class="pb-3">Apply Filters!</h2>
                        <form>
                            <div class="row">
                                <div class="col-12">
                                    <div class="form-group">
                                        <label for="Sport">Sport:</label>
                                        <select runat="server" id="SportFilter">
                                            <option>Basketball</option>
                                        </select>
                                    </div>
                                </div>
                                <div class="col-12">
                                    <p>Date:</p>
                                        <form runat="server" id="CalendarFilter"><asp:Calendar ID="Calendar1" runat="server"></asp:Calendar></form>
                                </div>
                                <div class="col-12">
                                    <div class="form-group mt-md-3">
                                        <p>Start Time:<input type="time" min="00:00" max="23:59" id="TimeStartFilter" /></p>
                                    </div>
                                </div>
                                <div class="col-12">
                                    <div class="form-group mt-md-3">
                                        <p>End Time: <input type="time" min="00:00" max="23:59" id="TimeStartFilter" /></p>
                                    </div>
                                </div>
                                <div class="col-12">
                                    <div class="form-group">
                                        <label for="Proficiency">Proficiency:</label>
                                        <select runat="server" id="ProficiencyFilter">
                                            <option>Beginner</option>
                                            <option>Amatuer</option>
                                            <option>Skilled</option>
                                            <option>Expert</option>
                                        </select>
                                    </div>
                                </div>
                                <div class="col-12">
                                    <div class="form-group">
                                        <label for="Gender">Gender:</label>
                                        <select runat="server" id="GenderFilter">
                                            <option>Both</option>
                                            <option>Male</option>
                                            <option>Female</option>
                                        </select>
                                    </div>
                                </div>
                            </div>
                        </form>
                    </div>
                </div>
            </div>
            <div class="row">
                <div class="col-md-3"></div>
                <div class="col-md-6">
                    <div style="width:80%; text-align:center">
                        <div class="alert alert-success" runat="server" id="successMessage" role="alert">
                            <p style="text-align:center" runat="server" id="successPrint" class="card-text" ></p>
                        </div>
                    </div>
                </div>
                <div class="col-md-2"></div>
            </div>
            <div class="col-md-8 container-fluid">
              <div class="card pl-5">
                    <div class="card-body">
                       <h4 class="card-title"><b>Sport name</b></h4>
                        <div class="row">
                            <div class="col-md-6 col-6">
                                   <p>Date and Time: <span runat="server" id="DatePrint0" class="card-text">Date and Time</span></p>
                               </div>
                            <div class="col-md-6 col-6">
                                <p>Location: <span runat="server" id="Location0" class="card-text">Location</span></p>
                            </div>
                            <div class="col-md-6 col-6">
                                <p>Proficiency: <span runat="server" id="Proficiency0" class="card-text">Proficiency</span></p>
                            </div>
                            <div class="col-md-6 col-6">
                                <p>People: <span runat="server" id="People0" class="card-text">People committed</span></p>
                            </div>
                            <div class="col-md-6 col-6">
                                <p>Description: <span runat="server" id="Description0" class="card-text">Description</span></p>
                            </div>
                            <div class="col-md-6 col-6">
                                <p>Description: <span runat="server" id="Gender0" class="card-text">Gender:</span></p>
                            </div>
                            <div class="col-md-6 col-6"></div>
                            <div class="col-md-6 col-6">
                                <button runat="server" id="button0" class="btn btn-primary" onserverclick="button0_ServerClick">I'm interested!</button>
                            </div>
                        </div>              
                    </div>
                  </div>
                <div class="card pl-5 mt-3">
                  <div class="card-body">
                       <h4 class="card-title"><b>Sport name</b></h4>
                        <div class="row">
                            <div class="col-md-6 col-6">
                                   <p>Date and Time: <span runat="server" id="DatePrint1" class="card-text">Date and Time</span></p>
                               </div>
                            <div class="col-md-6 col-6">
                                <p>Location: <span runat="server" id="Location1" class="card-text">Location</span></p>
                            </div>
                            <div class="col-md-6 col-6">
                                <p>Proficiency: <span runat="server" id="Proficiency1" class="card-text">Proficiency</span></p>
                            </div>
                            <div class="col-md-6 col-6">
                                <p>People: <span runat="server" id="People1" class="card-text">People committed</span></p>
                            </div>
                            <div class="col-md-6 col-6">
                                <p>Description: <span runat="server" id="Description1" class="card-text">Description</span></p>
                            </div>
                            <div class="col-md-6 col-6">
                                <p>Description: <span runat="server" id="Gender1" class="card-text">Gender:</span></p>
                            </div>
                            <div class="col-md-6 col-6"></div>
                            <div class="col-md-6 col-6">
                                <button runat="server" id="button1" class="btn btn-primary" onserverclick="button1_ServerClick">I'm interested!</button>
                            </div>
                        </div>              
                    </div> 
                    </div> 
                <div class="card pl-5 mt-3">
                  <div class="card-body">
                       <h4 class="card-title"><b>Sport name</b></h4>
                        <div class="row">
                            <div class="col-md-6 col-6">
                                   <p>Date and Time: <span runat="server" id="DatePrint2" class="card-text">Date and Time</span></p>
                               </div>
                            <div class="col-md-6 col-6">
                                <p>Location: <span runat="server" id="Location2" class="card-text">Location</span></p>
                            </div>
                            <div class="col-md-6 col-6">
                                <p>Proficiency: <span runat="server" id="Proficiency2" class="card-text">Proficiency</span></p>
                            </div>
                            <div class="col-md-6 col-6">
                                <p>People: <span runat="server" id="People2" class="card-text">People committed</span></p>
                            </div>
                            <div class="col-md-6 col-6">
                                <p>Description: <span runat="server" id="Description2" class="card-text">Description</span></p>
                            </div>
                            <div class="col-md-6 col-6">
                                <p>Description: <span runat="server" id="Gender2" class="card-text">Gender:</span></p>
                            </div>
                            <div class="col-md-6 col-6"></div>
                            <div class="col-md-6 col-6">
                                <button runat="server" id="button2" class="btn btn-primary" onserverclick="button2_ServerClick">I'm interested!</button>
                            </div>
                        </div>              
                    </div> 
                    </div>
                <div class="card pl-5 mt-3">
                  <div class="card-body">
                       <h4 class="card-title"><b>Sport name</b></h4>
                        <div class="row">
                            <div class="col-md-6 col-6">
                                   <p>Date and Time: <span runat="server" id="DatePrint3" class="card-text">Date and Time</span></p>
                               </div>
                            <div class="col-md-6 col-6">
                                <p>Location: <span runat="server" id="Location3" class="card-text">Location</span></p>
                            </div>
                            <div class="col-md-6 col-6">
                                <p>Proficiency: <span runat="server" id="Proficiency3" class="card-text">Proficiency</span></p>
                            </div>
                            <div class="col-md-6 col-6">
                                <p>People: <span runat="server" id="People3" class="card-text">People committed</span></p>
                            </div>
                            <div class="col-md-6 col-6">
                                <p>Description: <span runat="server" id="Description3" class="card-text">Description</span></p>
                            </div>
                            <div class="col-md-6 col-6">
                                <p>Description: <span runat="server" id="Gender3" class="card-text">Gender:</span></p>
                            </div>
                            <div class="col-md-6 col-6"></div>
                            <div class="col-md-6 col-6">
                                <button runat="server" id="button3" class="btn btn-primary" onserverclick="button3_ServerClick">I'm interested!</button>
                            </div>
                        </div>              
                    </div> 
                </div>
                <div class="card pl-5 mt-3">
                  <div class="card-body">
                       <h4 class="card-title"><b>Sport name</b></h4>
                        <div class="row">
                            <div class="col-md-6 col-6">
                                   <p>Date and Time: <span runat="server" id="DatePrint4" class="card-text">Date and Time</span></p>
                               </div>
                            <div class="col-md-6 col-6">
                                <p>Location: <span runat="server" id="Location4" class="card-text">Location</span></p>
                            </div>
                            <div class="col-md-6 col-6">
                                <p>Proficiency: <span runat="server" id="Proficiency4" class="card-text">Proficiency</span></p>
                            </div>
                            <div class="col-md-6 col-6">
                                <p>People: <span runat="server" id="People4" class="card-text">People committed</span></p>
                            </div>
                            <div class="col-md-6 col-6">
                                <p>Description: <span runat="server" id="Description4" class="card-text">Description</span></p>
                            </div>
                            <div class="col-md-6 col-6">
                                <p>Description: <span runat="server" id="Gender4" class="card-text">Gender:</span></p>
                            </div>
                            <div class="col-md-6 col-6"></div>
                            <div class="col-md-6 col-6">
                                <button runat="server" id="button4" class="btn btn-primary" onserverclick="button4_ServerClick">I'm interested!</button>
                            </div>
                        </div>              
                    </div> 
                </div>
                <div class="card pl-5 mt-3">
                  <div class="card-body">
                       <h4 class="card-title"><b>Sport name</b></h4>
                        <div class="row">
                            <div class="col-md-6 col-6">
                                   <p>Date and Time: <span runat="server" id="DatePrint5" class="card-text">Date and Time</span></p>
                               </div>
                            <div class="col-md-6 col-6">
                                <p>Location: <span runat="server" id="Location5" class="card-text">Location</span></p>
                            </div>
                            <div class="col-md-6 col-6">
                                <p>Proficiency: <span runat="server" id="Proficiency5" class="card-text">Proficiency</span></p>
                            </div>
                            <div class="col-md-6 col-6">
                                <p>People: <span runat="server" id="People5" class="card-text">People committed</span></p>
                            </div>
                            <div class="col-md-6 col-6">
                                <p>Description: <span runat="server" id="Description5" class="card-text">Description</span></p>
                            </div>
                            <div class="col-md-6 col-6">
                                <p>Description: <span runat="server" id="Gender5" class="card-text">Gender:</span></p>
                            </div>
                            <div class="col-md-6 col-6"></div>
                            <div class="col-md-6 col-6">
                                <button runat="server" id="button5" class="btn btn-primary" onserverclick="button5_ServerClick">I'm interested!</button>
                            </div>
                        </div>              
                    </div> 
                </div>
                <div class="card pl-5 mt-3">
                  <div class="card-body">
                       <h4 class="card-title"><b>Sport name</b></h4>
                        <div class="row">
                            <div class="col-md-6 col-6">
                                   <p>Date and Time: <span runat="server" id="DatePrint6" class="card-text">Date and Time</span></p>
                               </div>
                            <div class="col-md-6 col-6">
                                <p>Location: <span runat="server" id="Location6" class="card-text">Location</span></p>
                            </div>
                            <div class="col-md-6 col-6">
                                <p>Proficiency: <span runat="server" id="Proficiency6" class="card-text">Proficiency</span></p>
                            </div>
                            <div class="col-md-6 col-6">
                                <p>People: <span runat="server" id="People6" class="card-text">People committed</span></p>
                            </div>
                            <div class="col-md-6 col-6">
                                <p>Description: <span runat="server" id="Description6" class="card-text">Description</span></p>
                            </div>
                            <div class="col-md-6 col-6">
                                <p>Description: <span runat="server" id="Gender6" class="card-text">Gender:</span></p>
                            </div>
                            <div class="col-md-6 col-6"></div>
                            <div class="col-md-6 col-6">
                                <button runat="server" id="button6" class="btn btn-primary" onserverclick="button6_ServerClick">I'm interested!</button>
                            </div>
                        </div>              
                    </div> 
                </div>
                <div class="card pl-5 mt-3">
                  <div class="card-body">
                       <h4 class="card-title"><b>Sport name</b></h4>
                        <div class="row">
                            <div class="col-md-6 col-6">
                                   <p>Date and Time: <span runat="server" id="DatePrint7" class="card-text">Date and Time</span></p>
                               </div>
                            <div class="col-md-6 col-6">
                                <p>Location: <span runat="server" id="Location7" class="card-text">Location</span></p>
                            </div>
                            <div class="col-md-6 col-6">
                                <p>Proficiency: <span runat="server" id="Proficiency7" class="card-text">Proficiency</span></p>
                            </div>
                            <div class="col-md-6 col-6">
                                <p>People: <span runat="server" id="People7" class="card-text">People committed</span></p>
                            </div>
                            <div class="col-md-6 col-6">
                                <p>Description: <span runat="server" id="Description7" class="card-text">Description</span></p>
                            </div>
                            <div class="col-md-6 col-6">
                                <p>Description: <span runat="server" id="Gender7" class="card-text">Gender:</span></p>
                            </div>
                            <div class="col-md-6 col-6"></div>
                            <div class="col-md-6 col-6">
                                <button runat="server" id="button7" class="btn btn-primary" onserverclick="button7_ServerClick">I'm interested!</button>
                            </div>
                        </div>              
                    </div> 
                </div>
                <div class="card pl-5 mt-3">
                  <div class="card-body">
                       <h4 class="card-title"><b>Sport name</b></h4>
                        <div class="row">
                            <div class="col-md-6 col-6">
                                   <p>Date and Time: <span runat="server" id="DatePrint8" class="card-text">Date and Time</span></p>
                               </div>
                            <div class="col-md-6 col-6">
                                <p>Location: <span runat="server" id="Location8" class="card-text">Location</span></p>
                            </div>
                            <div class="col-md-6 col-6">
                                <p>Proficiency: <span runat="server" id="Proficiency8" class="card-text">Proficiency</span></p>
                            </div>
                            <div class="col-md-6 col-6">
                                <p>People: <span runat="server" id="People8" class="card-text">People committed</span></p>
                            </div>
                            <div class="col-md-6 col-6">
                                <p>Description: <span runat="server" id="Description8" class="card-text">Description</span></p>
                            </div>
                            <div class="col-md-6 col-6">
                                <p>Description: <span runat="server" id="Gender8" class="card-text">Gender:</span></p>
                            </div>
                            <div class="col-md-6 col-6"></div>
                            <div class="col-md-6 col-6">
                                <button runat="server" id="button8" class="btn btn-primary" onserverclick="button8_ServerClick">I'm interested!</button>
                            </div>
                        </div>              
                    </div>
                   </div>
                <div class="card pl-5 mt-3">
                  <div class="card-body">
                       <h4 class="card-title"><b>Sport name</b></h4>
                        <div class="row">
                            <div class="col-md-6 col-6">
                                   <p>Date and Time: <span runat="server" id="DatePrint9" class="card-text">Date and Time</span></p>
                               </div>
                            <div class="col-md-6 col-6">
                                <p>Location: <span runat="server" id="Location9" class="card-text">Location</span></p>
                            </div>
                            <div class="col-md-6 col-6">
                                <p>Proficiency: <span runat="server" id="Proficiency9" class="card-text">Proficiency</span></p>
                            </div>
                            <div class="col-md-6 col-6">
                                <p>People: <span runat="server" id="People9" class="card-text">People committed</span></p>
                            </div>
                            <div class="col-md-6 col-6">
                                <p>Description: <span runat="server" id="Description9" class="card-text">Description</span></p>
                            </div>
                            <div class="col-md-6 col-6">
                                <p>Description: <span runat="server" id="Gender9" class="card-text">Gender:</span></p>
                            </div>
                            <div class="col-md-6 col-6"></div>
                            <div class="col-md-6 col-6">
                                <button runat="server" id="button9" class="btn btn-primary" onserverclick="button9_ServerClick">I'm interested!</button>
                            </div>
                        </div>              
                    </div> 
                </div>
              </div>
           </div>
        </div>
    
    

</body>
</html>
