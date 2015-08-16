<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddClaim.aspx.cs" MasterPageFile="~/UbietyMenu.Master" Inherits="Admin.AddClaim" Title="Add Claim | Ubiety - GeneiHR Solutions" %>

<asp:Content ID="Content1" ContentPlaceHolderID="body" Runat="Server">

    <div class="row wrapper border-bottom white-bg page-heading">
            <div class="col-lg-10">
                <h1>Create New Claim</h1>
                <%--<ol class="breadcrumb">
                    <li>
                       <h5>GenieHR Solutions Pvt. Ltd.</h5>
                    </li>
                </ol>--%>
            </div>
            
        </div>

    <br />
        <link href="css/plugins/iCheck/custom.css" rel="stylesheet"/>
         <link href="css/plugins/awesome-bootstrap-checkbox/awesome-bootstrap-checkbox.css" rel="stylesheet"/>
    
    <div class="ibox-content">
                            <form method="post" id="formoid" class="m-t form-horizontal" role="form">
                                <div class="form-group">
                                    <div class="col-sm-2"><label class="control-label">Claim Purpose</label></div>
                                    <div class="col-sm-10"><input type="text" placeholder="Enter Claim Purpose" id="cliamTitle" name="claimTitle" class="text-box form-control"/></div>
                                </div>
                                <div class="hr-line-dashed"></div>
                                <div class="form-group "> 
                                    <div class="col-sm-2"><label class="control-label">Add new expense</label></div>
                                    <div class="col-sm-10">
                                    <button type="button" class="btn btn-success btn-outline" data-toggle="modal" data-target="#travelModal"> Travel</button>
                                    <button type="button" class="btn btn-success btn-outline" > Hotel</button>
                                    <button type="button" class="btn btn-success btn-outline" > Food</button></div>
                                </div>
                                <div class="hr-line-dashed"></div>
                            </form>
        </div>
    <script src="js/plugins/daterangepicker/daterangepicker.js"></script>

    <div class="modal inmodal" id="travelModal" tabindex="-1" role="dialog"  aria-hidden="true">

                                    <div class="modal-dialog">
                                    <div class="modal-content animated fadeIn">
                                        <div class="modal-header">
                                            <button type="button" class="close" data-dismiss="modal"><span aria-hidden="true">&times;</span><span class="sr-only">Close</span></button>
                                            <h4 class="modal-title">Add Travel Expense</h4>
                                            <small>Add a new local or outstation travel expense</small>
                                        </div>
                                        <div class="modal-body">
                                            <form method="post"  class="m-t form-horizontal" role="form">
                                <div class="form-group">
                                    <div class="col-sm-2"><label class="control-label"> Purpose</label></div>
                                    <div class="col-sm-10"><input type="text"  id="travelPurpose" name="travelPurpose" class="input-sm form-control"/></div>
                                </div>
                                <div class="form-group">
                                    <div class="col-sm-2"><label class="control-label"> Date</label></div>
                                    <div class="col-sm-10"><input type="date"  id="travelDate" name="travelDate" class="input-sm form-control"/></div>
                                </div>

                                                <div class="form-group ">
                                                    <div class="col-sm-2"><label class="control-label"> Mode</label></div>
                                                    <div class="col-sm-10">
                                        <div class="i-checks inline"><label> <input type="radio"  value="A" name="a" checked=""/> <i></i> Auto </label></div>&nbsp;&nbsp;
                                        <div class="i-checks inline"><label> <input type="radio"  value="B"  name="a"/> <i></i> Bus </label></div> &nbsp;&nbsp;
                                        <div class="i-checks inline"><label> <input type="radio"  value="T"  name="a"/> <i></i> Train </label></div>&nbsp;&nbsp;
                                        <div class="i-checks inline"><label> <input type="radio"  value="X"  name="a"/> <i></i> Taxi </label></div>&nbsp;&nbsp;
                                                    </div>
                                                </div>
                                                
                                                
                                            <div class="form-group" id="data_6">
                                                <div class="col-sm-2">
                                <label class="control-label">Travel</label></div>
                                                <div class="col-sm-10">
                                <div class="input-daterange input-group" >
                                    <span class="input-group-addon">From</span>

                                    <input type="text" class="input-sm form-control"  name="start" />
                                    <span class="input-group-addon">To</span>
                                    <input type="text" class="input-sm form-control"  name="end"  />
                                </div>
                                                    </div>
                            </div>
                                                <div class="form-group">
                                    <div class="col-sm-2"><label class="control-label">Distance(km)</label></div>
                                    <div class="col-sm-10"><input type="number"  id="travelDistance" name="travelDistance" class="input-sm form-control"/></div>

                                </div>
                                                <div class="form-group">
                                    <div class="col-sm-2"><label class="control-label">Rate / km</label></div>
                                    <div class="col-sm-10"><input type="number"  id="rate" name="rate" class="input-sm form-control"/></div>

                                </div>
                                                <div class="form-group">
                                    <div class="col-sm-2"><label class="control-label">Amount</label></div>
                                    <div class="col-sm-10"><input type="number"  id="Amount" name="rate" class="input-sm form-control"/></div>
                                </div>
                                                </form>

                                        </div>
                                        <div class="modal-footer">
                                            <button type="button" class="btn btn-info">Add</button>
                                        </div>
                                       
                                    </div>
                                </div>
                            </div>

                        

    
</asp:Content>