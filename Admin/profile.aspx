<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="profile.aspx.cs" Inherits="UbietyAdmin.profile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head >
     <script type="text/javascript" src="//code.jquery.com/jquery-1.11.1.min.js"></script>
    <script src="https://maps.googleapis.com/maps/api/js?v=3.exp"></script>


    <link rel="stylesheet" href="//cdn.datatables.net/1.10.7/css/jquery.dataTables.css"/>
    <link href="css/spinners.css" rel="stylesheet" />
    
    <!-- Data Tables -->
    <link href="css/plugins/dataTables/dataTables.bootstrap.css" rel="stylesheet"/>
    <link href="css/plugins/dataTables/dataTables.responsive.css" rel="stylesheet"/>
    <link href="css/plugins/dataTables/dataTables.tableTools.min.css" rel="stylesheet"/>

    <link href="css/bootstrap.min.css" rel="stylesheet"/>
    <link href="font-awesome/css/font-awesome.css" rel="stylesheet"/>

    <link href="css/animate.css" rel="stylesheet"/>
    <link href="css/style.css" rel="stylesheet"/>

        <title>Employee Profile</title>

    <style>
        .open-viewImageDialog {

        }
    
        .dataTables_wrapper .nohead table thead{
    display:none;
}
    </style>
</head>
<body>

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
            <form role="search" class="navbar-form-custom" >
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
                    <h1>Profile</h1>
                </div>
                
            </div>
            <div class="row">
                 
                <div class="col-sm-4 col-lg-4">
                    <div class="ibox">
                        <div class="ibox-title">
                           <h1 id="EmpName" class="text-center text-navy">  </h1>
                        </div>
                        <div class="ibox-content">
                            <img src="http://www.hydrogenaud.io/forums/uploads/profile/photo-119400.jpg" />
                            <br />
                            <br />
                            <table class="table no-borders ">
                                <tr ><td class="no-top-border"><h4 class="text-justify">Employee No. </h4></td ><td class="no-top-border"><span class="text-info" id="EmpNum"></span></td></tr>
                                <tr><td ><h4 class="text-justify">Email </h4></td><td ><span class="text-info" id="Email"></span></td></tr>
                                <tr><td ><h4 class="text-justify">Mobile No. </h4></td><td ><span class="text-info" id="MobileNo"></span></td></tr>
                                <tr><td>&nbsp;</td><td>&nbsp;</td></tr>
                                </table>
                        </div>
                    </div>
                    </div>
                <div class="col-sm-8 col-lg-8">
                    <div class="ibox">
                        <div class="ibox-title">
                            <h1>Employee Details</h1>
                        </div>
                        <div class="ibox-content ">
                            <%--<span class="text-muted small pull-right">Last modification: <i class="fa fa-clock-o"></i> 2:10 pm - 12.06.2014</span>--%>

                            <ul class="nav nav-tabs ">
                                <li class="active"><a data-toggle="tab" href="#tab-1"><i class="fa fa-user"></i> Attendance</a></li>
                                <li class=""><a data-toggle="tab" href="#tab-2"><i class="fa fa-briefcase"></i> Leave </a></li>
                                <li class=""><a data-toggle="tab" href="#tab-3"><i class="fa fa-money"></i> Claims</a></li>

                            </ul>
                            <div class="tab-content">
                                <div id="tab-1" class="tab-pane active">
                                    <br />
                                    <div class="full-height-scroll">
                                        <div class="table-responsive ">
                                            <div class="dataTables_wrapper">
                                                <table id="regionsdt" class="table table-bordered table-hover">
                                                    <thead>
                                                        <tr>
                                                            <th rowspan="2">Date</th>
                                                            <th colspan="3" class="text-center">IN</th>
                                                            <th colspan="3" class="text-center">OUT</th>
                                                        </tr>
                                                        <tr>
                                                            <th>Time</th>
                                                            <th>Location</th>
                                                            <th>Image</th>
                                                            <th>Time</th>
                                                            <th>Location</th>
                                                            <th>Image</th>
                                                        </tr>
                                                    </thead>
                                                </table>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <div id="tab-2" class="tab-pane">
                                    <div class="full-height-scroll">
                                      <h1 class="text-center">  <span class="text-success"><br /><br /><br /><span class="spinner">Loading…</span><br />Coming Soon...<br /><br /><br /><br /></span></h1>
                                    </div>
                                </div>
                                <div id="tab-3" class="tab-pane">
                                    <div class="full-height-scroll">
                                      <h1 class="text-center">  <span class=" text-success"><br /><br /><br /><span class="spinner">Loading…</span><br />Coming Soon...<br /><br /><br /><br /></span></h1>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>

            <div class="modal inmodal" id="viewImageDialog" tabindex="-1" role="dialog" aria-hidden="true">
                <div class="modal-dialog">
                    <div class="modal-content animated fadeIn">
                        <%--<div class="modal-header">
                            <button type="button" class="close" data-dismiss="modal"><span aria-hidden="true">&times;</span><span class="sr-only">Close</span></button>
                        </div>--%>
                        <div class="modal-body">
                            <br />
                            <br />
                            <br />
                            <br />
                            <div class="col-md-12 col-lg-12">
                                <center>
                                    <img class="north" id="imageId" style="width:50%;height:50%" />
                                    <br />
                                    <br />
                                    <input type="button" value="Rotate" />
                                </center>
                            </div>

                        </div>
                        <div class="modal-footer">
                            <button type="button" class="btn btn-white" data-dismiss="modal">Close</button>
                        </div>
                    </div>
                </div>
                <style>
                    .north {
                        transform: rotate(0deg);
                        -ms-transform: rotate(0deg); /* IE 9 */
                        -webkit-transform: rotate(0deg); /* Safari and Chrome */
                    }

                    .west {
                        transform: rotate(90deg);
                        -ms-transform: rotate(90deg); /* IE 9 */
                        -webkit-transform: rotate(90deg); /* Safari and Chrome */
                    }

                    .south {
                        transform: rotate(180deg);
                        -ms-transform: rotate(180deg); /* IE 9 */
                        -webkit-transform: rotate(180deg); /* Safari and Chrome */
                    }

                    .east {
                        transform: rotate(270deg);
                        -ms-transform: rotate(270deg); /* IE 9 */
                        -webkit-transform: rotate(270deg); /* Safari and Chrome */
                    }
                </style>
                <script>
                    $('input').click(function () {
                        var img = $('#imageId');
                        if (img.hasClass('north')) {
                            img.attr('class', 'west');
                        } else if (img.hasClass('west')) {
                            img.attr('class', 'south');
                        } else if (img.hasClass('south')) {
                            img.attr('class', 'east');
                        } else if (img.hasClass('east')) {
                            img.attr('class', 'north');
                        }
                    });

                </script>
            </div>

            <!-- Mainly scripts -->
            <script src="js/jquery-2.1.1.js"></script>
            <script src="js/bootstrap.min.js"></script>
            <script src="js/plugins/metisMenu/jquery.metisMenu.js"></script>
            <script src="js/plugins/slimscroll/jquery.slimscroll.min.js"></script>

            <!-- Custom and plugin javascript -->
            <script src="js/inspinia.js"></script>
            <script src="js/plugins/pace/pace.min.js"></script>

            <script src="js/plugins/dataTables/jquery.dataTables.js"></script>
            <script src="js/plugins/dataTables/dataTables.bootstrap.js"></script>
            <script src="js/plugins/dataTables/dataTables.responsive.js"></script>
            <script src="js/plugins/dataTables/dataTables.tableTools.min.js"></script>

            <script>

                var profileURL = "http://ubietyapi.azurewebsites.net/api/attendance/of/" + getParameterByName('EmpId');
                var profileURL2 = "http://ubietyapi.azurewebsites.net/api/employees/getempdetail/of/" + getParameterByName('EmpId') + '?jsoncallback=?';
                var empJson = "";
                var url = "https://ghrstorage.blob.core.windows.net/ubiety/";


                function getParameterByName(name) {
                    name = name.replace(/[\[]/, "\\[").replace(/[\]]/, "\\]");
                    var regex = new RegExp("[\\?&]" + name + "=([^&#]*)"),
                        results = regex.exec(location.search);
                    return results === null ? "" : decodeURIComponent(results[1].replace(/\+/g, " "));
                }

                $(document).ready(function () {


                    $.ajax({
                        url: profileURL2,
                        beforeSend: function (xhr) {
                            xhr.overrideMimeType("text/plain; charset=x-user-defined");
                        }
                    })
                      .done(function (data) {
                          var obj = JSON.parse(data);
                              document.getElementById("EmpName").innerHTML = obj.employee[0].EmpName;
                              document.getElementById("EmpNum").innerHTML = obj.employee[0].EmpNum;
                              document.getElementById("Email").innerHTML = obj.employee[0].Email;
                              document.getElementById("MobileNo").innerHTML = obj.employee[0].MobileNum;
                      });

                    var table = $('#regionsdt').DataTable({
                        "retrieve": true,
                        "sDom": 'lfrtip',
                        "bPaginate": true,
                        "bJQueryUI": true,
                        "bLengthChange": false,
                        "bFilter": true,
                        "bSort": true,
                        "bInfo": false,
                        "bAutoWidth": false,
                        "bProcessing": false,
                        "iDisplayLength": 30,
                        "ajax": {
                            "url": profileURL,
                            "dataSrc": "attendance"
                        },
                        "columns": [
                            { "data": "strMarkDate" },
                            { "data": "strInMarkTime" },
                            { "data": "inLocName" },
                            { "data": "inImageURL" },
                            { "data": "strOutMarkTime" },
                            { "data": "outLocName" },
                            { "data": "outImageURL" },
                        ],
                        "columnDefs": [
                             {
                                 "render": function (data, type, row) {
                                     return '<a data-toggle="modal" data-id="' + url + data + '" class="open-viewImageDialog" href="#viewImageDialog">View</a>';
                                 },
                                 "data": null,
                                 "defaultContent": "",
                                 "targets": 3
                             },
                        {
                            "render": function (data, type, row) {
                                return '<a data-toggle="modal" data-id="' + url + data + '" class="open-viewImageDialog" href="#viewImageDialog">View</a>';
                            },
                            "targets": 6
                        }
                        ]
                    });
                });

                $(document).on("click", ".open-viewImageDialog", function () {
                    var myimageId = $(this).data('id');
                    $(".modal-body #imageId").attr('src', myimageId);
                });

            </script>

            

        </div>
    </div>

  

   

</body>
</html>
