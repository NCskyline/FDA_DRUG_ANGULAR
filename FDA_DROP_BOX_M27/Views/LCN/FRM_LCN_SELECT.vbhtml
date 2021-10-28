@Code
    Layout = ""
End Code


<script src="~/Scripts_angular/ANGULAR_APP.js"></script>
<script src="~/Scripts_angular/CENTER_SV.js"></script>
<script src="~/Scripts_angular/LCN_CTRL.js"></script>


<div ng-controller="LCN_CTRL" ng-app="ANGULAR_APP">
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
                            <tr ng-repeat="cc in DATA_LCN_F_EDIT">
                                <td>{{cc.LCNNO_DISPLAY}}</td>
                                <td>{{cc.thanameplace}}</td>
                                <td>{{cc.fulladdr}}</td>
                                <td>{{cc.HOUSENO}}</td>
                                <td>{{cc.STATUS_NAME}}</td>
                                <td>{{cc.TRANSECTION_ID_UPLOAD}}</td>
                                <td>{{cc.REMARK}}</td>
                                <td>
                                    <span class="fa fa-eye"></span>
                                    <a ng-click="SELECT_LCN_EDIT(cc)">
                                        เลือก
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