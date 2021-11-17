@Code
    Layout = ""
End Code


<script src="../Scripts_angular/ANGULAR_APP.js"></script>
<script src="../Scripts_angular/CENTER_SV.js"></script>
<script src="../Scripts_angular/LCN_CTRL.js"></script>
<div  ng-init="pageload()"> @*ng-controller="LCN_CTRL" ng-app="ANGULAR_APP" class="ic"*@
    <div style="font-family:'Taviraj';font-size:20px">
        <h2>ต่ออายุใบอนุญาตสถานที่ด้านยา</h2>
        <table width="100%">
            <tr>
                <td></td>
                <td align="right">
                    <table>
                        <tr>
                            <td>
                                <input class="btn btn-lg" type="button" value="รีเฟรชหน้าจอ" ng-click="RELOAD_PAGE()" />
                            </td>
                            <td>
                                <input class="btn btn-lg" type="button" value="ยื่นคำขอต่ออายุใบอนุญาต (ระบบใหม่)" ng-click="BTN_EXTEND()" />
                            </td>
                        </tr>
                    </table>


                </td>
            </tr>
        </table>
        <table width="100%">
            <tr>
                <td width="25%">แสดงรายการที่ยื่นคำขอต่ออายุ</td>
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
                                @*<td></td>*@
                            </tr>
                        </thead>
                        @*<tbody>
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
                    <a ng-click="BTN_PREVIEW_EXTEND(data)">
                        ดูข้อมูล
                    </a>
                </td>
                <td>
                    <span class="fa fa-pager"></span>
                    <a ng-click="BTN_FILE(data)">
                        พิมพ์ใบปะหน้า
                    </a>
                </td>
            </tr>
        </tbody>*@
                        <tbody>
                            <tr>
                                <td>ผย1 กท 1/2564</td>
                                <td>ชำระเงินคำขอแล้วรอเจ้าหน้าที่พิจารณา</td>
                                <td>บริษัท ทดสอบ จำกัด</td>
                                <td>12/5 ตรอก/ซอย หิ้ว ถนน พระประแดง หมู่ที่ 3 ตำบล/แขวง สุขเดือนห้า อำเภอ/เขต เนินขาม จังหวัด ชัยนาท 10921</td>
                                <td>6400005</td>
                                <td></td>
                                <td>2565</td>
                                <td>
                                    <span class="fa fa-eye"></span>
                                    <a ng-click="BTN_PREVIEW_EXTEND(data)">
                                        ดูข้อมูล
                                    </a>
                                </td>
                                @*<td>
                                    <span class="fa fa-pager"></span>
                                    <a ng-click="BTN_FILE(data)">
                                        พิมพ์ใบปะหน้า
                                    </a>
                                </td>*@
                        <tbody>
                            <tr>
                                <td>ขย1 กท 1/2564</td>
                                <td>อนุมัติ</td>
                                <td>บริษัท ทดสอบ จำกัด</td>
                                <td>12/5 ตรอก/ซอย หิ้ว ถนน พระประแดง หมู่ที่ 3 ตำบล/แขวง สุขเดือนห้า อำเภอ/เขต เนินขาม จังหวัด ชัยนาท 10921</td>
                                <td>6400007</td>
                                <td></td>
                                <td>2565</td>
                                <td>
                                    <span class="fa fa-eye"></span>
                                    <a ng-click="BTN_PREVIEW_EXTEND(data)">
                                        ดูข้อมูล
                                    </a>
                                </td>
                                <td>
                                    <span class="fa fa-pager"></span>
                                    <a ng-click="BTN_FILE(data)">
                                        พิมพ์ใบปะหน้า
                                    </a>
                                </td>
                            </tr>
                            <tr>
                                <td>ขย1 กท 1/2564</td>
                                <td>ชำระเงินคำขอแล้วรอเจ้าหน้าที่พิจารณา</td>
                                <td>บริษัท ทดสอบ จำกัด</td>
                                <td>12/5 ตรอก/ซอย หิ้ว ถนน พระประแดง หมู่ที่ 3 ตำบล/แขวง สุขเดือนห้า อำเภอ/เขต เนินขาม จังหวัด ชัยนาท 10921</td>
                                <td>6400006</td>
                                <td></td>
                                <td>2565</td>
                                <td>
                                    <span class="fa fa-eye"></span>
                                    <a ng-click="BTN_PREVIEW_EXTEND(data)">
                                        ดูข้อมูล
                                    </a>
                                </td>
                                <td>
                                    <span class="fa fa-pager"></span>
                                    <a ng-click="BTN_FILE(data)">
                                        พิมพ์ใบปะหน้า
                                    </a>
                                </td>
                            </tr>
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
                                    <a ng-click="BTN_PREVIEW_EXTEND(data)">
                                        ดูข้อมูล
                                    </a>
                                </td>
                                <td>
                                    <span class="fa fa-pager"></span>
                                    <a ng-click="BTN_FILE(data)">
                                        พิมพ์ใบปะหน้า
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