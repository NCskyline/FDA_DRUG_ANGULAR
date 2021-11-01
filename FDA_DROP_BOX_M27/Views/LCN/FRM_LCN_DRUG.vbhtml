@Code
    ViewData("Title") = "FRM_LCN_DRUG"
    Layout = ""
End Code
<link rel="stylesheet" href="../dist/listree.min.css" />
<script src="~/Scripts_angular/ANGULAR_APP.js"></script>
<script src="~/Scripts_angular/CENTER_SV.js"></script>
<script src="~/Scripts_angular/LCN_CTRL.js"></script>
<link href="../css/bootstrap_limitless.min.css" rel="stylesheet" />

<div ng-controller="LCN_CTRL" ng-app="ANGULAR_APP">
    <div style="width:100%;font-family:'Taviraj'">
        @*<div class="part part-1-3 ic">
                <ul class="listree">
                    <li>
                        <div class="listree-submenu-heading">ขออนุญาตสถานที่ด้านยาแห่งใหม่</div>
                        <ul class="listree-submenu-items" style="color:black">
                            <li>
                                <a ng-click="BTN_MENU('101')" style="color:#06B716">ขย1</a>
                            </li>
                            <li>
                                <a ng-click="BTN_MENU('103')" style="color:#06B716">ขย3</a>
                            </li>
                            <li>
                                <a ng-click="BTN_MENU('104')" style="color:#06B716">ขย4</a>
                            </li>
                            <li>
                                <a ng-click="BTN_MENU('105')" style="color:#06B716">นย1</a>
                            </li>
                            <li>
                                <a ng-click="BTN_MENU('106')" style="color:#06B716">ผย1</a>
                            </li>
                            <li>
                                <a ng-click="BTN_MENU('107')" style="color:#06B716">ขยบ</a>
                            </li>
                            <li>
                                <a ng-click="BTN_MENU('108')" style="color:#06B716">นยบ</a>
                            </li>
                            <li>
                                <a ng-click="BTN_MENU('109')" style="color:#06B716">ผยบ</a>
                            </li>
                        </ul>
                    </li>
                    <li>
                        <div class="listree-submenu-heading">ขออนุญาตสถานที่วัตถุเสพติดแห่งใหม่</div>
                        <ul class="listree-submenu-items" style="color:black">
                            <li>
                                <div class="listree-submenu-heading">วัตถุออกฤทธิ์จิตและประสาทประเภท ๓ , ๔</div>
                                <ul class="listree-submenu-items" style="color:black">
                                    <li>
                                        <a ng-click="BTN_MENU('131')" style="color:#06B716">นำเข้าวัตถุออกฤทธิ์ฯในประเภท ๓</a>
                                    </li>
                                    <li>
                                        <a ng-click="BTN_MENU('132')" style="color:#06B716">นำเข้าวัตถุออกฤทธิ์ฯในประเภท ๔</a>
                                    </li>
                                    <li>
                                        <a ng-click="BTN_MENU('123')" style="color:#06B716">ขายวัตถุออกฤทธิ์ฯในประเภท ๓</a>
                                    </li>
                                    <li>
                                        <a ng-click="BTN_MENU('124')" style="color:#06B716">ขายวัตถุออกฤทธิ์ฯในประเภท ๔</a>
                                    </li>
                                    <li>
                                        <a ng-click="BTN_MENU('133')" style="color:#06B716">ส่งออกวัตถุออกฤทธิ์ฯในประเภท ๓</a>
                                    </li>
                                    <li>
                                        <a ng-click="BTN_MENU('134')" style="color:#06B716">ส่งออกวัตถุออกฤทธิ์ฯในประเภท ๔</a>
                                    </li>
                                    <li>
                                        <a ng-click="BTN_MENU('125')" style="color:#06B716">ขายวัตถุออกฤทธิ์ฯโดยการขายส่งตรง ในประเภท ๓</a>
                                    </li>
                                    <li>
                                        <a ng-click="BTN_MENU('126')" style="color:#06B716">ขายวัตถุออกฤทธิ์ฯโดยการขายส่งตรง ในประเภท ๔</a>
                                    </li>
                                </ul>
                            </li>
                            <li>
                                <div class="listree-submenu-heading">ยาเสพติดให้โทษประเภทที่ ๓ หรือ ๔</div>
                                <ul class="listree-submenu-items" style="color:black">
                                    <li>
                                        <a ng-click="BTN_MENU('14')" style="color:#06B716">นำเข้ายาเสพติดให้โทษในประเภท ๓</a>
                                    </li>
                                    <li>
                                        <a ng-click="BTN_MENU('15')" style="color:#06B716">ส่งออกยาเสพติดให้โทษในประเภท ๓</a>
                                    </li>
                                    <li>
                                        <a ng-click="BTN_MENU('16')" style="color:#06B716">จำหน่ายยาเสพติดให้โทษในประเภท ๓</a>
                                    </li>
                                </ul>
                            </li>
                            <li>
                                <div class="listree-submenu-heading">ผลิตวัตถุออกฤทธิ์ฯประเภท ๓ หรือ ๔</div>
                                <ul class="listree-submenu-items" style="color:black">
                                    <li>
                                        <a ng-click="BTN_MENU('127')" style="color:#06B716">ผลิตวัตถุออกฤทธิ์ฯในประเภท ๓</a>
                                    </li>
                                    <li>
                                        <a ng-click="BTN_MENU('128')" style="color:#06B716">ผลิตวัตถุออกฤทธิ์ฯในประเภท ๔</a>
                                    </li>
                                </ul>
                            </li>
                            <li>
                                <div class="listree-submenu-heading">ผลิตยาเสพติดให้โทษประเภทที่ ๓ หรือ ๔</div>
                                <ul class="listree-submenu-items" style="color:black">
                                    <li>
                                        <a ng-click="BTN_MENU('114')" style="color:#06B716">ผลิตยาเสพติดให้โทษในประเภท ๓</a>
                                    </li>
                                </ul>
                            </li>
                        </ul>
                    </li>
                    <li>
                        <div class="listree-submenu-heading">คำขอแก้ไข/คำขอใบแทน/คำขอต่ออายุ</div>
                        <ul class="listree-submenu-items">
                            <li>
                                <a href="../LCN/FRM_LCN_DRUG?PROCESS=14">คำขอแก้ไขใบอนุญาตวัตถุออกฤทธิ์และยาเสพติด</a>
                            </li>
                            <li>
                                <div class="listree-submenu-heading">คำขอใบแทนใบอนุญาตวัตถุออกฤทธิ์และยาเสพติด</div>
                                <ul class="listree-submenu-items">
                                    <li>
                                        <a href="../LCN/FRM_LCN_DRUG?PROCESS=101">คำขอใบแทนใบอนุญาตขายวัตถุออกฤทธิ์ ฯ ประเภท 3</a>
                                    </li>
                                    <li>
                                        <a href="../LCN/FRM_LCN_DRUG?PROCESS=14">คำขอใบแทนใบอนุญาตขายวัตถุออกฤทธิ์ ฯ ประเภท 4</a>
                                    </li>
                                    <li>
                                        <a href="../LCN/FRM_LCN_DRUG?PROCESS=14">คำขอใบแทนใบอนุญาตผลิตวัตถุออกฤทธิ์ ฯ ประเภท 3</a>
                                    </li>
                                    <li>
                                        <a href="../LCN/FRM_LCN_DRUG?PROCESS=14">คำขอใบแทนใบอนุญาตผลิตวัตถุออกฤทธิ์ ฯ ประเภท 4</a>
                                    </li>
                                    <li>
                                        <a href="../LCN/FRM_LCN_DRUG?PROCESS=14">คำขอใบแทนใบอนุญาตนำเข้าวัตถุออกฤทธิ์ ฯ ประเภท 3</a>
                                    </li>
                                    <li>
                                        <a href="../LCN/FRM_LCN_DRUG?PROCESS=14">คำขอใบแทนใบอนุญาตนำเข้าวัตถุออกฤทธิ์ ฯ ประเภท 4</a>
                                    </li>
                                    <li>
                                        <a href="../LCN/FRM_LCN_DRUG?PROCESS=14">คำขอใบแทนใบอนุญาตส่งออกวัตถุออกฤทธิ์ ฯ ประเภท 3</a>
                                    </li>
                                    <li>
                                        <a href="../LCN/FRM_LCN_DRUG?PROCESS=14">คำขอใบแทนใบอนุญาตส่งออกวัตถุออกฤทธิ์ ฯ ประเภท 4</a>
                                    </li>
                                    <li>
                                        <a href="../LCN/FRM_LCN_DRUG?PROCESS=14">คำขอใบแทนใบอนุญาตขายส่งตรงวัตถุออกฤทธิ์ ฯ ประเภท 3</a>
                                    </li>
                                    <li>
                                        <a href="../LCN/FRM_LCN_DRUG?PROCESS=14">คำขอใบแทนใบอนุญาตขายส่งตรงวัตถุออกฤทธิ์ ฯ ประเภท 4</a>
                                    </li>
                                    <li>
                                        <a href="../LCN/FRM_LCN_DRUG?PROCESS=14">คำขอใบแทนใบอนุญาตขายส่งตรงวัตถุออกฤทธิ์ ฯ ประเภท 3 ประชุม</a>
                                    </li>
                                    <li>
                                        <a href="../LCN/FRM_LCN_DRUG?PROCESS=14">คำขอใบแทนใบอนุญาตขายส่งตรงวัตถุออกฤทธิ์ ฯ ประเภท 4 ประชุม</a>
                                    </li>
                                </ul>
                            </li>
                        </ul>
                    </li>
                </ul>
            </div>*@


        <div >
            <div style="width:100%;">
                <div>
                    <table width="100%" style="font-family:'Taviraj';font-size:20px;">
                        <tr>
                            <td width="40%">ใบอนุญาต  {{lcnnoType}}</td>
                        </tr>
                    </table>
                    <hr />
                    <table width="100%" style="font-family:'Taviraj'">
                        <tr>
                            <td><input style="width:60%" class="form-control" placeholder="ค้นหา..." ng-model="filter" /></td>
                            <td align="right">
                                <button class="btn btn-lg" ng-click="BTN_INPUT()">สร้างคำขอ</button>
                            </td>
                        </tr>
                    </table>
                    <div class="row">
                        <div class="col-sm-12" style="width:100%;" >
                            <div class="card" style=" border-top: 10px solid #F9D027;">
                                <table width="100%" style="font-family:'Taviraj'" class="table" id="myTable" datatable="ng">
                                    <thead style="font-weight:300;">
                                        <tr>
                                            <td>เลขที่ใบอนุญาต</td>
                                            <td>สถานะ</td>
                                            <td>เลขดำเนินการ</td>
                                            <td>เหตุผลการคืนคำขอ</td>
                                            <td></td>
                                        </tr>
                                    </thead>
                                    <tbody>
                                        <tr ng-repeat="data in DATA_LCN_MAIN">
                                            <td>{{data.LCNNO_MANUAL}}</td>
                                            <td>{{data.STATUS_NAME}}</td>
                                            <td>{{data.TRANSECTION_ID_UPLOAD}}</td>
                                            <td>{{data.REMARK}}</td>
                                            <td>
                                                <span class="fa fa-eye"></span>
                                                <a ng-click="BTN_PREVIEW(data)">
                                                    ดูข้อมูล
                                                </a>
                                            </td>
                                        </tr>
                                    </tbody>
                                    <tfoot>
                                        <tr></tr>
                                    </tfoot>
                                </table>

                                @*<hr />
                                <uib-pagination class="pagination-sm" total-items="filterData.length" ng-model="page"
                                                ng-change="pageChanged()" previous-text="&lsaquo;" next-text="&rsaquo;" items-per-page=10
                                                boundary-link-numbers="true" rotate="false" max-size="maxSize">
                                </uib-pagination>
                                <div align="center">
                                    <button type="button" class="btn btn-sm" ng-disabled="currentPage == 0" ng-click="currentPage=currentPage-1"><i class="fas fa-arrow-left"></i>  ก่อนหน้า</button>
                                    <button type="button" class="btn btn-sm" ng-disabled="currentPage >= DATA_LCN_MAIN.length/entryLimit - 1" ng-click="currentPage = currentPage+1">ถัดไป <i class="fas fa-arrow-right"></i></button>
                                </div>*@
                            </div>

                        </div>
                    </div>
                </div>


            </div>
        </div>




    </div>
</div>


