@Code
    Layout = ""
End Code

<div>
    <div style="font-family:'Taviraj'">
        <div>
            <table width="100%">
                <tr>
                    <td width="40%">ใบอนุญาต  {{lcnnoType}}</td>                   
                </tr>
            </table>
        </div>
        <hr />
        <div class="row">
            <div class="col-sm-12">
                <div class="card" style=" border-top: 10px solid #F9D027;">
                    @*<table style="margin-top:10px;width:100%;" class="table table-condensed">
                            <tr>
                                <td>เลขที่ใบอนุญาต</td>
                                <td>ชื่อสถานที่</td>
                                <td>ที่อยู่</td>
                                <td>เลขสถานที่</td>
                                <td>สถานะ</td>
                                <td>เลขดำเนินการ</td>
                                <td>เหตุผลการคืนคำขอ</td>
                                <td></td>
                            </tr>
                            <tr></tr>
                        </table>*@

                    <table style="margin-top:10px;width:100%;" class="table table-condensed">
                        <thead>
                            <tr>
                                <th>เลขที่ใบอนุญาต</th>
                                <th>ชื่อสถานที่</th>
                                <th>ที่อยู่</th>
                                <th>เลขสถานที่</th>
                                <th>สถานะ</th>
                                <th>เลขดำเนินการ</th>
                                <th>เหตุผลการคืนคำขอ</th>
                                <th></th>
                            </tr>
                        </thead>
                        <tbody>
                            <tr ng-repeat="cc in DATA_LCN_LIST">
                                <td>{{cc.LCNNO_DISPLAY}}</td>
                                <td>{{cc.thanameplace}}</td>
                                <td>{{cc.fulladdr}}</td>
                                <td>{{cc.HOUSENO}}</td>
                                <td>{{cc.STATUS_NAME}}</td>
                                <td>{{cc.TRANSECTION_ID_UPLOAD}}</td>
                                <td>{{cc.REMARK}}</td>
                                <td>
                                    <span class="fa fa-eye"></span>
                                    <a ng-click="SELECT_LCN_HEAD(cc,lcnnoType)">
                                        ใบย่อย
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