<script src="../Scripts_angular/ANGULAR_APP.js"></script>
<script src="../Scripts_angular/CENTER_SV.js"></script>
<script src="../Scripts_angular/LCN_CTRL.js"></script>
<div ng-controller="LCN_CTRL" ng-app="ANGULAR_APP" class="ic" ng-init="pageload()">
    <div style="font-family:'Taviraj';font-size:20px;">
        <h2>ต่ออายุใบอนุญาตสถานที่ด้านยา</h2>
        <table width="100%">
            <tr>
                <td></td>
                <td align="right">
                    <table>
                        <tr>
                            <td>
                                <input type="button" value="รีเฟรชหน้าจอ" ng-click="RELOAD_PAGE()"/>
                            </td>
                            <td>
                                <input type="button" value="ยื่นคำขอต่ออายุใบอนุญาต (ระบบใหม่)" ng-click="BTN_EXTEND()" />
                            </td>
                        </tr>
                    </table>


                </td>
            </tr>
        </table>
        <table width="100%">
            <tr>
                <td width="20%">แสดงรายการที่ยื่นคำขอต่ออายุ</td>
                <td>
                    <select style="width:10%;" ng-model="YEAR_SELECT" ng-change="getdetails_extend(YEAR_SELECT)">
                        <option value="1" selected>ปีล่าสุด</option>
                        <option value="2">ทั้งหมด</option>
                    </select>


                </td>
            </tr>
        </table>
        <div class="row">
            <div class="col-sm-12">
                <div class="card" style=" border-top: 10px solid #F9D027;">
                    <table width="100%" style="font-family:'Taviraj'" class="table">
                        <thead>
                            <tr>
                                <td>เลขที่ใบอนุญาต</td>
                                <td>สถานะ</td>
                                <td>ชื่อสถานที่</td>
                                <td>ที่อยู่</td>
                                <td>เลขดำเนินการ</td>
                                <td>เหตุผลการคืนคำขอ</td>
                                <td>เพื่อต่ออายุในปี</td>
                                <td></td>
                            </tr>
                        </thead>
                        <tbody>
                            <tr ng-repeat="data in LIST_EXTEND">
                                <td>{{data.LCNNO_MANUAL}}</td>
                                <td>{{data.STATUS_NAME}}</td>
                                <td>{{data.thanameplace}}</td>
                                <td>{{data.fulladdr}}</td>
                                <td>{{data.TRANSECTION_ID_UPLOAD}}</td>
                                <td>{{data.REMARK}}</td>
                                <td>{{data.expyear}}</td>
                                <td>
                                    <span class="fa fa-eye"></span>
                                    <a ng-click="BTN_PREVIEW(data)">
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