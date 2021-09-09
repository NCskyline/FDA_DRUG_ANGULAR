@Code
    Layout = ""
End Code



    <div>
        <div>
            <div>
                <table width="100%" style="font-family:'Taviraj'">
                    <tr>
                        <td width="40%">ใบอนุญาต  ({{lcnnoType}})</td>
                        @*<td align="right">เลขบัตรผู้ดำเนิน</td>
                        <td>
                            <input style="width: 50%" class="form-control" ng-model="BSN_CITIZEN" placeholder="เลขบัตรผู้ดำเนินฯ....." />
                        </td>*@
                        <td align="right">
                            <button class="btn btn-lg" ng-click="BTN_INPUT()">สร้างคำขอ</button>
                        </td>
                    </tr>
                </table>
                <div class="row">
                    <div class="col-sm-12">
                        <div class="card" style=" border-top: 10px solid #277210;">
                            <table width="100%" style="font-family:'Taviraj'">
                                <thead>
                                    <tr>
                                        <td>เลขที่ใบอนุญาต</td>
                                        <td>สถานะ</td>
                                        <td>ชื่อสถานที่</td>
                                        <td>ที่อยู่</td>
                                        <td>เลขสถานที่</td>
                                        <td>เลขดำเนินการ</td>
                                        <td>เหตุผลการคืนคำขอ</td>
                                        <td></td>
                                    </tr>
                                </thead>
                                <tbody>
                                    <tr ng-repeat="data in DATA_LCN">
                                        <td>{{data.LCNNO_MANUAL}}</td>
                                        <td>{{data.STATUS_NAME}}</td>
                                        <td>{{data.thanameplace}}</td>
                                        <td>{{data.fulladdr}}</td>
                                        <td>{{data.HOUSENO}}</td>
                                        <td>{{data.TRANSECTION_ID_UPLOAD}}</td>
                                        <td>{{data.REMARK}}</td>
                                        <td>
                                            <span class="fa fa-eye"></span>
                                            <a ng-click="">
                                                ดูข้อมูล
                                            </a>
                                        </td>
                                    </tr>
                                </tbody>
                            </table>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>