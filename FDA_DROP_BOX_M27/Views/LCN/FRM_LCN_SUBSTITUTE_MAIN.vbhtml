@Code
    Layout = ""
End Code
<div ng-controller="LCN_CTRL" ng-app="ANGULAR_APP">
    <div class="content-part " style="font-family:'Taviraj'">
        <div class="part part-2-3 ic" >
            <div style="width:100%;">
                <div>
                    <table width="100%" style="font-family:'Taviraj';font-size:20px;">
                        <tr>
                            <td width="40%">คำขอใบแทน</td>
                        </tr>
                    </table>
                    <hr />
                    <table width="100%" style="font-family:'Taviraj'">
                        <tr>
                            <td width="100%"><input style="width:60%" class="form-control" placeholder="ค้นหา..." ng-model="filter" /></td>
                            <td align="right">
                                <button class="btn btn-lg" ng-click="BTN_INPUT_STT()">สร้างคำขอ</button>
                            </td>
                        </tr>
                    </table>
                    <div class="row">
                        <div class="col-sm-12" style="width:100%;">
                            <div class="card" style=" border-top: 10px solid #F9D027;">
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
                                    @*<tbody>
            <tr ng-repeat="data in DATA_SUBTITUTE | filter: filter">
                <td>{{data.RCVNO_MANUAL}}</td>
                <td>{{data.LCNNO_MANUAL}}</td>
                <td>{{data.STATUS_NAME}}</td>
                <td>{{data.TRANSECTION_ID_UPLOAD}}</td>
                <td>{{data.PURPOSE}}</td>
                <td>
                    <span class="fa fa-eye"></span>
                    <a ng-click="BTN_SUBTITUTE_PREVIEW(data)">
                        ดูข้อมูล
                    </a>
                </td>
            </tr>
        </tbody>*@
                                <tbody>

                                    <tr>
                                        <td>6409999</td>
                                        <td>ขย1 กท 9999/2555</td>
                                        <td>ยื่นคำขอแล้วรอเจ้าหน้าที่พิจารณา</td>
                                        <td>64009999</td>
                                        <td></td>
                                        <td>
                                            <span class="fa fa-eye"></span>
                                            <a ng-click="SELECT_STT(datas)">
                                                ดูข้อมูล
                                            </a>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>6409999</td>
                                        <td>ขย1 กท 9999/2555</td>
                                        <td>อนุมัติแล้วรอชำระเงิน</td>
                                        <td>64009999</td>
                                        <td></td>
                                        <td>
                                            <span class="fa fa-eye"></span>
                                            <a ng-click="SELECT_STT(datas)">
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