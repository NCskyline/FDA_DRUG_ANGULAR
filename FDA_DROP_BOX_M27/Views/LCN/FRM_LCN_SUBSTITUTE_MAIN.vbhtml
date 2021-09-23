@Code
    Layout = ""
End Code
<div ng-controller="LCN_CTRL" ng-app="ANGULAR_APP">
    <div class="content-part " style="width:100%;font-family:'Taviraj'">
        <div class="part part-2-3 ic" style="width:100%;">


            <div style="width:100%;">
                <div>
                    <table width="100%" style="font-family:'Taviraj'">
                        <tr>
                            <td width="40%">คำขอใบแทน</td>

                            <td align="right">
                                <button class="btn btn-lg" ng-click="BTN_INPUT_STT()">สร้างคำขอ</button>
                            </td>
                        </tr>
                    </table>
                    <div class="row">
                        <div class="col-sm-12" style="width:100%;">
                            <div class="card" style=" border-top: 10px solid #277210;">
                                <table width="100%" style="font-family:'Taviraj'" class="table" id="myTable" datatable="ng">
                                    <thead style="font-weight:300;">
                                        <tr>
                                            <td>เลขรับที่</td>
                                            <td>เลขที่ใบอนุญาต</td>
                                            <td>สถานะ</td>
                                            <td>เลขดำเนินการ</td>
                                            <td>เหตุผล</td>
                                            <td></td>
                                        </tr>
                                    </thead>
                                    <tbody>
                                        <tr ng-repeat="data in DATA_SUBTITUTE">
                                            <td>{{data.RCVNO_MANUAL}}</td>
                                            <td>{{data.LCNNO_MANUAL}}</td>
                                            <td>{{data.STATUS_NAME}}</td>
                                            <td>{{data.TRANSECTION_ID_UPLOAD}}</td>
                                            <td>{{data.PURPOSE}}</td>
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
