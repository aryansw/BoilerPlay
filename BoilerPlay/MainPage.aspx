<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainPage.aspx.cs" Inherits="BoilerPlay.WebForm1" %>

<!DOCTYPE html>

<link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" />

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8"/>
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no"/>
    <title>BoilerPlay</title>
</head>
<body>
    
        
    <form id="form1" runat="server">

    <div class="container-fluid bg-dark text-white pt-5">
        <div class="row mb-5">
            <div class="col-md-4 mb-5"></div>
            <div class="col-md-4 col-12">
                <h1 class="text-center">BoilerPlay</h1>
                <p class="text-center">Find teammates anytime, anywhere!</p>
                <div class="row text3center">
                    <div class="col-3 col-md-3"><asp:Button runat="server" CssClass="btn btn-light mb-5" ID="createEventBtn" style="font-size: 11.9px; font-weight: bold" OnClick="createEventBtn_Click" Text="Create Event" /></div>                 
                    <div class="col-3 col-md-3"><asp:Button runat="server" CssClass="btn btn-light mb-5" ID="allEventsBtn" style="font-size: 11.9px; font-weight: bold" OnClick="allEventsBtn_Click" Text="All Events" /></div>               
                    <div class="col-3 col-md-3"><asp:Button runat="server" CssClass="btn btn-light mb-5" ID="myEventBtn" style="font-size: 11.9px; font-weight: bold" OnClick="myEventBtn_Click" Text="My Events" /></div>
                    <div class="col-3 col-md-3"><asp:Button runat="server" CssClass="btn btn-light mb-5" ID="profileBtn" style="font-size: 11.9px; font-weight: bold" OnClick="profileBtn_Click" Text="Profile" /></div>
                </div>                       
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




    <div class="container-fluid mb-5">
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
                                        </select>
                                    </div>
                                </div>
                                <div class="col-12">
                                    <p>Date:</p>
                                    <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
                                </div>
                                <div class="col-12">
                                    <div class="form-group mt-md-3">
                                        <p>Start Time:<asp:TextBox runat="server" TextMode="Time" ID="TimeStartFilter" /></p>
                                        <asp:TextBox runat="server" ID="textBx" TextMode="Time"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="col-12">
                                    <div class="form-group mt-md-3">
                                        <p>End Time: <asp:TextBox runat="server" TextMode="Time" ID="TimeEndFilter" /></p>
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
            
            
            <div class="col-md-8 container-fluid">


              <div class="card pl-5" runat="server" id="card0">
                    <div class="card-body">
                       <h4 class="card-title" runat="server" id="CardTitle0"><b>Sport name</b></h4>
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
                                <p><span runat="server" id="People0" class="card-text">People committed</span></p>
                            </div>
                            <div class="col-md-6 col-6">
                                <p>Description: <span runat="server" id="Description0" class="card-text">Description</span></p>
                            </div>
                            <div class="col-md-6 col-6">
                                <p><span runat="server" id="Gender0" class="card-text">Gender:</span></p>
                            </div>
                            <div class="col-md-6 col-6">
                                <a href="<%=this.host_name0%>" target="_blank" id="button_0" class="btn btn-dark" onserverclick="button0_ServerClick_0">View Profile of Host</a>
                            </div>
                            <div class="col-md-6 col-6">
                                <button runat="server" id="button0" class="btn btn-dark" onserverclick="button0_ServerClick">I'm interested!</button>
                            </div>
                        </div>              
                    </div>
                 </div>
                <div class="card pl-5 mt-3" runat="server" id="card1">
                  <div class="card-body">
                       <h4 class="card-title" runat="server" id="CardTitle1"><b>Sport name</b></h4>
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
                                <p><span runat="server" id="People1" class="card-text">People committed</span></p>
                            </div>
                            <div class="col-md-6 col-6">
                                <p>Description: <span runat="server" id="Description1" class="card-text">Description</span></p>
                            </div>
                            <div class="col-md-6 col-6">
                                <p><span runat="server" id="Gender1" class="card-text">Gender:</span></p>
                            </div>
                            <div class="col-md-6 col-6">
                                <a href="<%=this.host_name1%>" target="_blank" id="button_1" class="btn btn-dark" onserverclick="button1_ServerClick_1">View Profile of Host</a>
                            </div>
                            <div class="col-md-6 col-6">
                                <button runat="server" id="button1" class="btn btn-dark" onserverclick="button1_ServerClick">I'm interested!</button>
                            </div>
                        </div>              
                    </div> 
                </div> 

                <div class="card pl-5 mt-3" runat="server" id="card2">
                  <div class="card-body">
                       <h4 class="card-title" runat="server" id="CardTitle2"><b>Sport name</b></h4>
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
                                <p><span runat="server" id="People2" class="card-text">People committed</span></p>
                            </div>
                            <div class="col-md-6 col-6">
                                <p>Description: <span runat="server" id="Description2" class="card-text">Description</span></p>
                            </div>
                            <div class="col-md-6 col-6">
                                <p><span runat="server" id="Gender2" class="card-text">Gender:</span></p>
                            </div>
                            <div class="col-md-6 col-6">
                                <a href="<%=this.host_name2%>" target="_blank" id="button_2" class="btn btn-dark" onserverclick="button2_ServerClick_2">View Profile of Host</a>
                            </div>
                            <div class="col-md-6 col-6">
                                <button runat="server" id="button2" class="btn btn-dark" onserverclick="button2_ServerClick">I'm interested!</button>
                            </div>
                        </div>              
                    </div> 
                    </div>
                <div class="card pl-5 mt-3" runat="server" id="card3">
                  <div class="card-body">
                       <h4 class="card-title" runat="server" id="CardTitle3"><b>Sport name</b></h4>
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
                                <p><span runat="server" id="People3" class="card-text">People committed</span></p>
                            </div>
                            <div class="col-md-6 col-6">
                                <p>Description: <span runat="server" id="Description3" class="card-text">Description</span></p>
                            </div>
                            <div class="col-md-6 col-6">
                                <p><span runat="server" id="Gender3" class="card-text">Gender:</span></p>
                            </div>
                            <div class="col-md-6 col-6">
                                <a href="<%=this.host_name3%>" target="_blank" id="button_3" class="btn btn-dark" onserverclick="button3_ServerClick_3">View Profile of Host</a>
                            </div>
                            <div class="col-md-6 col-6">
                                <button runat="server" id="button3"  class="btn btn-dark" onserverclick="button3_ServerClick">I'm interested!</button>
                            </div>
                        </div>              
                    </div> 
                </div>
                <div class="card pl-5 mt-3" runat="server" id="card4">
                  <div class="card-body">
                       <h4 class="card-title" runat="server" id="CardTitle4"><b>Sport name</b></h4>
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
                                <p><span runat="server" id="People4" class="card-text">People committed</span></p>
                            </div>
                            <div class="col-md-6 col-6">
                                <p>Description: <span runat="server" id="Description4" class="card-text">Description</span></p>
                            </div>
                            <div class="col-md-6 col-6">
                                <p><span runat="server" id="Gender4" class="card-text">Gender:</span></p>
                            </div>
                            <div class="col-md-6 col-6">
                                <a href="<%=this.host_name4%>" target="_blank" id="button_4" class="btn btn-dark" onserverclick="button4_ServerClick_4">View Profile of Host</a>
                            </div>
                            <div class="col-md-6 col-6">
                                <button runat="server" id="button4" class="btn btn-dark" onserverclick="button4_ServerClick">I'm interested!</button>
                            </div>
                        </div>              
                    </div> 
                </div>
                <div class="card pl-5 mt-3" runat="server" id="card5">
                  <div class="card-body">
                       <h4 class="card-title" runat="server" id="CardTitle5"><b>Sport name</b></h4>
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
                                <p><span runat="server" id="People5" class="card-text">People committed</span></p>
                            </div>
                            <div class="col-md-6 col-6">
                                <p>Description: <span runat="server" id="Description5" class="card-text">Description</span></p>
                            </div>
                            <div class="col-md-6 col-6">
                                <p><span runat="server" id="Gender5" class="card-text">Gender:</span></p>
                            </div>
                            <div class="col-md-6 col-6">
                                <a href="<%=this.host_name5%>" target="_blank" id="button_5" class="btn btn-dark" onserverclick="button5_ServerClick_5">View Profile of Host</a>
                            </div>
                            <div class="col-md-6 col-6">
                                <button runat="server" id="button5" class="btn btn-dark" onserverclick="button5_ServerClick">I'm interested!</button>
                            </div>
                        </div>              
                    </div> 
                </div>
                <div class="card pl-5 mt-3" runat="server" id="card6">
                  <div class="card-body">
                       <h4 class="card-title" runat="server" id="CardTitle6"><b>Sport name</b></h4>
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
                                <p><span runat="server" id="People6" class="card-text">People committed</span></p>
                            </div>
                            <div class="col-md-6 col-6">
                                <p>Description: <span runat="server" id="Description6" class="card-text">Description</span></p>
                            </div>
                            <div class="col-md-6 col-6">
                                <p><span runat="server" id="Gender6" class="card-text">Gender:</span></p>
                            </div>
                            <div class="col-md-6 col-6">
                                <a href="<%=this.host_name6%>" target="_blank" id="button_6" class="btn btn-dark" onserverclick="button6_ServerClick_6">View Profile of Host</a>
                            </div>
                            <div class="col-md-6 col-6">
                                <button runat="server" id="button6" class="btn btn-dark" onserverclick="button6_ServerClick">I'm interested!</button>
                            </div>
                        </div>              
                    </div> 
                </div>
                <div class="card pl-5 mt-3" runat="server" id="card7">
                  <div class="card-body">
                       <h4 class="card-title" runat="server" id="CardTitle7"><b>Sport name</b></h4>
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
                                <p><span runat="server" id="People7" class="card-text">People committed</span></p>
                            </div>
                            <div class="col-md-6 col-6">
                                <p>Description: <span runat="server" id="Description7" class="card-text">Description</span></p>
                            </div>
                            <div class="col-md-6 col-6">
                                <p><span runat="server" id="Gender7" class="card-text">Gender:</span></p>
                            </div>
                            <div class="col-md-6 col-6">
                                <a href="<%=this.host_name7%>" target="_blank" id="button_7" class="btn btn-dark" onserverclick="button7_ServerClick_7">View Profile of Host</a>
                            </div>
                            <div class="col-md-6 col-6">
                                <button runat="server" id="button7" class="btn btn-dark" onserverclick="button7_ServerClick">I'm interested!</button>
                            </div>
                        </div>              
                    </div> 
                </div>
                <div class="card pl-5 mt-3" runat="server" id="card8">
                  <div class="card-body">
                       <h4 class="card-title" runat="server" id="CardTitle8"><b>Sport name</b></h4>
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
                                <p><span runat="server" id="People8" class="card-text">People committed</span></p>
                            </div>
                            <div class="col-md-6 col-6">
                                <p>Description: <span runat="server" id="Description8" class="card-text">Description</span></p>
                            </div>
                            <div class="col-md-6 col-6">
                                <p><span runat="server" id="Gender8" class="card-text">Gender:</span></p>
                            </div>
                            <div class="col-md-6 col-6">
                                <a href="<%=this.host_name8%>" target="_blank" id="button_8" class="btn btn-dark" onserverclick="button8_ServerClick_8">View Profile of Host</a>
                            </div>
                            <div class="col-md-6 col-6">
                                <button runat="server" id="button8" class="btn btn-dark" onserverclick="button8_ServerClick">I'm interested!</button>
                            </div>
                        </div>              
                    </div>
                   </div>
                <div class="card pl-5 mt-3" runat="server" id="card9">
                  <div class="card-body">
                       <h4 class="card-title" runat="server" id="CardTitle9"><b>Sport name</b></h4>
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
                                <p><span runat="server" id="People9" class="card-text">People committed</span></p>
                            </div>
                            <div class="col-md-6 col-6">
                                <p>Description: <span runat="server" id="Description9" class="card-text">Description</span></p>
                            </div>
                            <div class="col-md-6 col-6">
                                <p><span runat="server" id="Gender9" class="card-text">Gender:</span></p>
                            </div>
                            <div class="col-md-6 col-6">
                                <a href="<%=this.host_name9%>" target="_blank" id="button_9" class="btn btn-dark" onserverclick="button9_ServerClick_9">View Profile of Host</a>
                            </div>
                            <div class="col-md-6 col-6">
                                <button runat="server" id="button9" class="btn btn-dark" onserverclick="button9_ServerClick">I'm interested!</button>
                            </div>
                        </div>              
                    </div> 
                </div>

            </div>


        </div>
    </div>
    
    </form>

    <div class="container">
        <div class="row mt-3 mb-3 text-right">
            <div class="col-12 col-md-12">
                <p>Next>> </p>
                <button runat="server" id="PageButton0" class="btn btn-dark p-2">1</button>
                <button runat="server" id="PageButton1" class="btn btn-dark p-2">2</button>
                <button runat="server" id="PageButton2" class="btn btn-dark p-2">3</button>
                <button runat="server" id="PageButton3" class="btn btn-dark p-2">4</button>
                <button runat="server" id="PageButton4" class="btn btn-dark p-2">5</button>
                <button runat="server" id="PageButton5" class="btn btn-dark p-2">6</button>
                <button runat="server" id="PageButton6" class="btn btn-dark p-2">7</button>
                <button runat="server" id="PageButton7" class="btn btn-dark p-2">8</button>
                <button runat="server" id="PageButton8" class="btn btn-dark p-2">9</button>
                <button runat="server" id="PageButton9" class="btn btn-dark p-2">10</button>
            </div>
        </div>
    </div>

</body>
</html>
