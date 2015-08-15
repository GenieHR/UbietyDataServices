<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/UbietyMenu.Master" CodeBehind="dashboard.aspx.cs" Inherits="UbietyAdmin.dashboard" Title="Dashboard | Ubiety - GenieHR Solutions" %>

<asp:Content ID="Content1" ContentPlaceHolderID="body" Runat="Server">

    <div class="col-lg-12">
        <div class="ibox float-e-margins">
            <div class="ibox-title">
                <h5>Quick Links<small class="m-l-sm">Manage your employees' information</small></h5>
            </div>
            <div class="ibox-content">
                <div class="row">
                    <div class="col-lg-3">
                        <div class="widget style1 lazur-bg">
                            <div class="row">
                                <div class="col-xs-4">
                                    <i class="fa fa-table fa-5x"></i>
                                </div>
                                <div class="col-xs-8 text-center">
                                    <a href="CreateEmployee.aspx">
                                        <h3 class="text-primary">Manage</h3>
                                        <h3>Master  Data </h3>
                                    </a>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="col-lg-3">
                        <div class="widget style1 lazur-bg">
                            <div class="row">
                                <div class="col-xs-4">
                                    <i class="fa fa-book fa-5x"></i>
                                </div>
                                <div class="col-xs-8 text-center">
                                    <a href="EmployeeList.aspx">
                                        <h3>Monitor</h3>
                                        <h3>Attendance </h3>
                                    </a>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="col-lg-3">
                        <div class="widget style1 lazur-bg">
                            <div class="row">
                                <div class="col-xs-4">
                                    <i class="fa fa-calculator fa-5x"></i>
                                </div>
                                <div class="col-xs-8 text-center">
                                    <h3>Process</h3>
                                    <h3>Claims </h3>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="col-lg-3">
                        <div class="widget style1 lazur-bg">
                            <div class="row">
                                <div class="col-xs-4">
                                    <i class="fa fa-calendar fa-5x"></i>
                                </div>
                                <div class="col-xs-8 text-center">
                                    <h3>Manage</h3>
                                    <h3>Leave Info </h3>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

</asp:Content>

        


