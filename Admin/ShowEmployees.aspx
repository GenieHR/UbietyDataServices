<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ShowEmployees.aspx.cs" MasterPageFile="~/UbietyMenu.Master" Title="Employees | Ubiety - GeneiHR Solutions" Inherits="Admin.showEmployees" %>

<asp:Content ID="Content1" ContentPlaceHolderID="body" Runat="Server">
    <div class="row wrapper border-bottom white-bg page-heading">
            <div class="col-lg-10">
                <h1><%= Request.QueryString["Client"].Split('|')[1] %></h1>
                <ol class="breadcrumb">
                    <li>
                       <h5>GenieHR Solutions Pvt. Ltd.</h5>
                    </li>
                </ol>
            </div>
            <div class="col-lg-2">

            </div>
        </div>
</asp:Content>
