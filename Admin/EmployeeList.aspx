<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmployeeList.aspx.cs" Inherits="UbietyAdmin.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head >
     <script type="text/javascript" src="//code.jquery.com/jquery-1.11.1.min.js"></script>

    <link rel="stylesheet" href="//cdn.datatables.net/1.10.7/css/jquery.dataTables.css"/>

    <!-- Data Tables -->
    <link href="css/plugins/dataTables/dataTables.bootstrap.css" rel="stylesheet"/>
    <link href="css/plugins/dataTables/dataTables.responsive.css" rel="stylesheet"/>
    <link href="css/plugins/dataTables/dataTables.tableTools.min.css" rel="stylesheet"/>

<link href="css/bootstrap.min.css" rel="stylesheet"/>
    <link href="font-awesome/css/font-awesome.css" rel="stylesheet"/>

    <link href="css/animate.css" rel="stylesheet"/>
    <link href="css/style.css" rel="stylesheet"/>

    <title>Employee List</title>
</head>
<body>
    <form id="form1" runat="server">
    <div class="container">
    
        <div class="wrapper wrapper-content animated fadeInRight">
            <div class="row">
                <div class="col-lg-12">
                <div class="ibox float-e-margins">
                    <div class="ibox-title">
                        <h5>Employees reporting to you.</h5>
                        <div class="ibox-tools">
                            <a class="collapse-link">
                                <i class="fa fa-chevron-up"></i>
                            </a>
                            <a class="dropdown-toggle" data-toggle="dropdown" href="#">
                                <i class="fa fa-wrench"></i>
                            </a>
                            <ul class="dropdown-menu dropdown-user">
                                <li><a href="#">Config option 1</a>
                                </li>
                                <li><a href="#">Config option 2</a>
                                </li>
                            </ul>
                            <a class="close-link">
                                <i class="fa fa-times"></i>
                            </a>
                        </div>
                    </div>
                    <div class="ibox-content">

                    <table id="regionsdt" class="table table-striped table-bordered table-hover" >
                    <thead >
                        <tr>
                            <th>Details</th>
                            <th>Employee Number</th>
                            <th>Name</th>
                            <th>Email</th>
                            <th>Mobile No.</th>
                 
                                   </tr>
                    </thead>
             </table>
                        </div>
                    </div>
                    </div>
                </div>
            </div>
        
        
    </div>
    </form>

    <script src="js/plugins/dataTables/jquery.dataTables.js"></script>
    <script src="js/plugins/dataTables/dataTables.bootstrap.js"></script>
    <script src="js/plugins/dataTables/dataTables.responsive.js"></script>
    <script src="js/plugins/dataTables/dataTables.tableTools.min.js"></script>



    
<script>

    
        $(document).ready(function () {

            var table = $('#regionsdt').DataTable({
                "retrieve": true,
                "bPaginate": true,
                "bJQueryUI": true,  
                "bLengthChange": false,
                "bFilter": true,
                "bSort": true,
                "bInfo": true,
                "bAutoWidth": false,
                "bProcessing": false,
                "iDisplayLength": 30,
                "ajax": {
                    "url": "http://ubietyapi.azurewebsites.net/api/employees/GetEmpDetails",
                    "dataSrc": ""
                },
                "columns": [
                    { "data": "EmpId" },
                    { "data": "EmpNum" },
                    { "data": "EmpName" },
                    { "data": "Email" },
                    { "data": "MobileNum" }
                ],
                "columnDefs": [
            {
                // The `data` parameter refers to the data for the cell (defined by the
                // `data` option, which defaults to the column being worked with, in
                // this case `data: 0`.

                "render": function (data, type, row) {
                    return '<a  href="profile_new.aspx?EmpId=' + data + '">' + 'View' + '</a>';
                },
                "targets": 0
            }
                ]
            });
    });


</script>
    
</body>
</html>
