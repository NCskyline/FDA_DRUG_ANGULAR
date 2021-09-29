
@Code
    ViewData("Title") = "MAIN_STAFF_CTRL"
    Layout = ""
End Code

<div ng-controller="LCN_CTRL" ng-app="ANGULAR_APP">
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
                                            <td>เลขที่ใบอนุญาต</td>
                                            <td>ที่อยู่</td>
                                            <td>สถานะ</td>
                                            <td>เลขดำเนินการ</td>
                                            <td>ผู้รับผิดชอบคำขอ</td>
                                            <td></td>
                                            <td></td>
                                            <td></td>
                                        </tr>
                                    </thead>
                                    <tbody>
                                        <tr ng-repeat="data in DATA_LCN_STAFF">
                                            <td>{{data.LCNNO_MANUAL}}</td>
                                            <td>{{data.fulladdr}}</td>
                                            <td>{{data.STATUS_NAME}}</td>
                                            <td>{{data.TRANSECTION_ID_UPLOAD}}</td>
                                            <td>{{data.STAFF_NAME}}</td>
                                            <td>
                                                <span class="fa fa-eye"></span>
                                                <a ng-click="">
                                                    ดูข้อมูล
                                                </a>
                                            </td>
                                            <td>
                                                <span class="fa fa-eye"></span>
                                                <a ng-click="">
                                                    แก้ไขการเสนอลงนาม
                                                </a>
                                            </td>
                                            <td>
                                                <span class="fa fa-eye"></span>
                                                <a ng-click="">
                                                    เพิ่มผู้รับผิดชอบคำขอ
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