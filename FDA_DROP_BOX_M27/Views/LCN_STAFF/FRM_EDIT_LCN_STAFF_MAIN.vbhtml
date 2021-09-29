
@Code
    Layout = ""
End Code
<div ng-controller="MAIN_STAFF_CTRL" ng-app="ANGULAR_APP">
    <div class="content-part " style="width:100%;font-family:'Taviraj'">

        <div class="part part-2-3 ic" style="width:100%;">


            <div style="width:100%;">
                <div>
                    <div class="row">
                        <div class="col-sm-12" style="width:100%;">
                            <div class="card" style=" border-top: 10px solid #277210;">
                                <table width="100%" style="font-family:'Taviraj'" class="table" id="myTable" datatable="ng">
                                    <thead style="font-weight:300;">
                                        <tr>
                                            <td>เลขรับ</td>
                                            <td>เลขที่ใบอนุญาต</td>
                                            <td>สถานะ</td>
                                            <td>เลขดำเนินการ</td>
                                            <td></td>
                                           
                                        </tr>
                                    </thead>
                                    <tbody>
                                        <tr ng-repeat="data in DATA_LCN_EDIT_STAFF">
                                            <td>{{data.RCVNO_MANUAL}}</td>
                                            <td>{{data.LCNNO_MANUAL}}</td>
                                            <td>{{data.STATUS_NAME}}</td>
                                            <td>{{data.TRANSACTION_UPLOAD}}</td>
                               
                                            <td>
                                                <span class="fa fa-eye"></span>
                                                <a ng-click="">
                                                    ดูข้อมูล
                                                </a>
                                            </td>
                                           
                                        </tr>
                                    </tbody>
                                    <tfoot>
                                        <tr></tr>
                                    </tfoot>
                                </table>

                            </div>

                        </div>
                    </div>
                </div>


            </div>
        </div>




    </div>
</div>