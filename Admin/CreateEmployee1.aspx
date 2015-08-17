<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreateEmployee1.aspx.cs" Inherits="Admin.WebForm1" %>
<!DOCTYPE html>
<html>


<head>

    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">

    <title>Create Employee</title>

    <link href="css/bootstrap.min.css" rel="stylesheet">
    <link href="font-awesome/css/font-awesome.css" rel="stylesheet">

    <link href="css/animate.css" rel="stylesheet">
    <link href="css/style.css" rel="stylesheet">

</head>

<body class="">

    <div id="wrapper">

    <nav class="navbar-default navbar-static-side" role="navigation">
        <div class="sidebar-collapse">
            <ul class="nav metismenu" id="side-menu">
                <li class="nav-header">
                    <div class="dropdown profile-element"> <span>
                            <img alt="image" class="img-circle" src="img/profile_small.jpg" />
                             </span>
                        <a data-toggle="dropdown" class="dropdown-toggle" href="#">
                            <span class="clear"> <span class="block m-t-xs"> <strong class="font-bold">David Williams</strong>
                             </span> <span class="text-muted text-xs block">Art Director <b class="caret"></b></span> </span> </a>
                        <ul class="dropdown-menu animated fadeInRight m-t-xs">
                            <li><a href="#">Profile</a></li>
                            <li><a href="#">Contacts</a></li>
                            <li><a href="#">Mailbox</a></li>
                            <li class="divider"></li>
                            <li><a href="#">Logout</a></li>
                        </ul>
                    </div>
                    <div class="logo-element">
                        IN+
                    </div>
                </li>
                <li>
                    <a href="dashboard.aspx"><i class="fa fa-th-large"></i> <span class="nav-label">Dashboard</span></a>
                </li>
            </ul>

        </div>
    </nav>

        <div id="page-wrapper" class="gray-bg">
        <div class="row border-bottom">
        <nav class="navbar navbar-static-top  " role="navigation" style="margin-bottom: 0">
        <div class="navbar-header">
            <a class="navbar-minimalize minimalize-styl-2 btn btn-primary " href="#"><i class="fa fa-bars"></i> </a>
            <form role="search" class="navbar-form-custom" action="#">
                <div class="form-group">
                    <input type="text" placeholder="Search your Employees..." class="form-control" name="top-search" id="top-search">
                </div>
            </form>
        </div>
            <ul class="nav navbar-top-links navbar-right">
                
                
                <li class="dropdown">
                    <a class="dropdown-toggle count-info" data-toggle="dropdown" href="#">
                        <i class="fa fa-bell"></i>  <span class="label label-primary">8</span>
                    </a>
                    <ul class="dropdown-menu dropdown-alerts">
                        <li>
                            <a href="#">
                                <div>
                                    <i class="fa fa-envelope fa-fw"></i> You have 16 messages
                                    <span class="pull-right text-muted small">4 minutes ago</span>
                                </div>
                            </a>
                        </li>
                        <li class="divider"></li>
                        <li>
                            <a href="#">
                                <div>
                                    <i class="fa fa-twitter fa-fw"></i> 3 New Followers
                                    <span class="pull-right text-muted small">12 minutes ago</span>
                                </div>
                            </a>
                        </li>
                        <li class="divider"></li>
                        <li>
                            <a href="#">
                                <div>
                                    <i class="fa fa-upload fa-fw"></i> Server Rebooted
                                    <span class="pull-right text-muted small">4 minutes ago</span>
                                </div>
                            </a>
                        </li>
                        <li class="divider"></li>
                        <li>
                            <div class="text-center link-block">
                                <a href="#">
                                    <strong>See All Alerts</strong>
                                    <i class="fa fa-angle-right"></i>
                                </a>
                            </div>
                        </li>
                    </ul>
                </li>

                <li>
                    <a href="#">
                        <i class="fa fa-sign-out"></i> Log out
                    </a>
                </li>
            </ul>

        </nav>
        </div>
            <div class="row wrapper border-bottom white-bg page-heading">
                <div class="col-sm-4">
                    <h1>Create Employee</h1>
                    <ol class="breadcrumb">
                        <li>
                            <a href="dashboard.aspx">Home</a>
                        </li>
                        <li class="active">
                            <strong>Master Data / Create Employee</strong>
                        </li>
                    </ol>
                </div>
                
            </div>

            <div class="wrapper wrapper-content">
                <div class="row">
                <div class="col-lg-10 col-lg-offset-1">
                    <div class="ibox float-e-margins">
                        <div class="ibox-title">
                            <h5>Create a new employee</small></h5>
                        </div>
                        <div class="ibox-content">
                            <form method="post" id="formoid" action="api/Employees" class="m-t form-horizontal" role="form">
                                <div class="form-group"><label class="col-sm-2 control-label">Employee No.</label>

                                    <div class="col-sm-10"><input type="text" id="empnum" name="empnum" class="form-control"></div>
                                </div>
                                <div class="hr-line-dashed"></div>
                                <div class="form-group"><label class="col-sm-2 control-label">Employee Name</label>

                                    <div class="col-sm-10"><input type="text" id="empname" name="empname" class="form-control"></div>
                                </div>
                                <div class="hr-line-dashed"></div>
                                <div class="form-group"><label class="col-sm-2 control-label">Mobile Number</label>

                                    <div class="col-sm-10"><input type="text" id="mobile" name="mobile" class="form-control"></div>
                                </div>
                                <div class="hr-line-dashed"></div>
                                <div class="form-group"><label class="col-sm-2 control-label">Email Address</label>

                                    <div class="col-sm-10"><input type="email" name="email" id="email" class="form-control"></div>
                                </div>
                                <div class="hr-line-dashed"></div>
                                <div class="form-group"><label class="col-sm-2 control-label">Designation</label>

                                    <div class="col-sm-10"><input type="text" name="designation" id="designation" class="form-control"></div>
                                </div>
                                <div class="hr-line-dashed"></div>
                                <br />
                                <div class="text-center"><button class="btn btn-primary " id="submitButton" name="submitButton" type="submit"><i class="fa fa-check"></i>&nbsp;Add Employee</button></div>
                                </form>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        </div>

    <!-- Mainly scripts -->
    <script src="js/jquery-2.1.1.js"></script>
    <script src="js/bootstrap.min.js"></script>
    <script src="js/plugins/metisMenu/jquery.metisMenu.js"></script>
    <script src="js/plugins/slimscroll/jquery.slimscroll.min.js"></script>

    <!-- Custom and plugin javascript -->
    <script src="js/inspinia.js"></script>
    <script src="js/plugins/pace/pace.min.js"></script>
    <script src="js/plugins/jquery-ui/jquery-ui.min.js"></script>
    <script src="js/plugins/validate/jquery.validate.min.js"></script>

        <script type='text/javascript'>


             $("#formoid").validate({
                 rules: {
                     mobile: {
                         required: true,
                         number: true
                     },
                     email: {
                         required: true,
                         email: true
                     },
                     empname: {
                         required: true,
                     },
                     empnum: {
                         required: true
                     }
                 },
                 submitHandler: function (form) {
                     
                     $('#submitButton').prop('disabled', true);

                     var posting = $.post('api/Employees', { companyid: <%= Session["SelectClientId"] %>, designation: $('#designation').val(), empnum: $('#empnum').val(), empname: $('#empname').val(), empstatus: 1, email: $('#email').val(), primarymobile: $('#mobile').val() });

                     posting.done(function (data) {
                         if (data.EmpId == 0) {
                             alert("User Not Created");
                         }
                         else
                         {
                             $('#formoid').trigger("reset");
                             alert("User Created Successfully");
                             $('#submitButton').prop('disabled', false);
                         }
                     });
                 }
             });
    
    </script>

</body>
</html>
