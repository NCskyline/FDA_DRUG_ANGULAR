﻿@Code
    ViewData("Title") = "FRM_MAIN_PRODUCT_LCN"
End Code

<link rel="stylesheet" href="../dist/listree.min.css" />
<link href="../css/bootstrap_limitless.min.css" rel="stylesheet" />
<script src="~/Scripts_angular/ANGULAR_APP.js"></script>
<script src="~/Scripts_angular/CENTER_SV.js"></script>
<script src="~/Scripts_angular/LCN_CTRL.js"></script>


<div  ng-controller="LCN_CTRL" ng-app="ANGULAR_APP">
    <div class="content-part">
        <div class="part part-1-3 ic" style="font-family:'Taviraj';width:100%">
            <ul class="listree">
                <li>
                    <div class="listree-submenu-heading" style="color:black">
                        <a ng-click="BTN_MENU_LCT('99')" style="color:#06B716">ข้อมูลสถานที่ตั้งที่ลงทะเบียน (ขออนุญาตใหม่)</a>
                    </div>
                </li>
                <li>
                    <div class="listree-submenu-heading" style="color:black">
                        <a ng-click="BTN_MENU_LCT('100741')" style="color:#06B716">ยื่นคำขอต่ออายุใบอนุญาต (ระบบใหม่)</a>
                    </div>
                </li>
                <li>
                    <div class="listree-submenu-heading" style="color:black">
                        <a ng-click="BTN_MENU_LCT('130099')" style="color:#06B716">คำขอใบแทนใบอนุญาตสถานที่ด้านยา</a>
                    </div>
                </li>
                <li>
                    <div class="listree-submenu-heading" style="color:black">
                        <a ng-click="BTN_MENU_LCT('130099')" style="color:#06B716">ระบบขอรับรองการตรวจประเมิน (GPP)</a>
                    </div>
                </li>
            </ul>
        </div>
        <div class="part part-2-3 ">
            <div class="ic" style="font-family:'Taviraj'">
                <div>
                    <table class="table" width="100%">
                        <tr>
                            <td width="70%"><h3><b>สถานที่ขาย สถานที่นำหรือสั่งฯ/สถานที่ผลิต</b></h3></td>
                            <td>
                                <input type="button" class="form-control" value="ลงทะเบียนสถานที่ตั้ง / สถานที่เก็บใหม่" />
                            </td>
                        </tr>
                    </table>
                    <br />
                    <div class="row">
                        <div class="col-sm-12">
                            <div class="search-item">
                                <input class="search-input" type="text" placeholder="ค้นหา..." ng-model="filter">
                                <i class="fa fa-search search-icon"></i>
                            </div>
                        </div>
                    </div>
                    <br />
                </div>
                <div class="row">
                    <div class="col-sm-12" style="width:100%;">
                        <div class="card" style=" border-top: 10px solid #F9D027;">
                            <table width="100%" class="table" id="myTable" datatable="ng">
                                <thead style="font-weight:300;">
                                    <tr>
                                        <td>เลขรับ</td>
                                        <td>วันที่ส่งเรื่อง</td>
                                        <td>ชื่อสถานที่</td>
                                        <td>ที่อยู่</td>
                                        <td>รหัสดำเนินการ</td>
                                        <td>สถานะ</td>
                                        <td>เหตุผลการคืนคำขอ</td>
                                        <td></td>
                                        <td>การขอใบอนุญาต</td>
                                    </tr>
                                </thead>
                                <tbody>
                                    <tr>
                                        <td></td>
                                        <td></td>
                                        <td>บริษัท สถานที่ใหม่ จำกัด มหาชน 3</td>
                                        <td>บ้านเลขที่46/1 1 1 อาคาร 1 ซอย23/5 ถนนจันทน์ หมู่2 แขวงคลองสาน เขตคลองสาน จังหวัดกรุงเทพมหานคร 73150</td>
                                        <td></td>
                                        <td>ส่งเรื่องและรอพิจารณา</td>
                                        <td></td>
                                        <td>
                                            <span class="fa fa-eye"></span>
                                            <a ng-click="SELECT_STAFF_LCN(data)">
                                                ดูข้อมูล
                                            </a>
                                        </td>
                                        <td></td>
                                    </tr>
                                    <tr>
                                        <td></td>
                                        <td></td>
                                        <td>บริษัท สถานที่ใหม่ จำกัด มหาชน 3</td>
                                        <td>บ้านเลขที่46/1 1 1 อาคาร 1 ซอย23/5 ถนนจันทน์ หมู่2 แขวงคลองสาน เขตคลองสาน จังหวัดกรุงเทพมหานคร 73150</td>
                                        <td></td>
                                        <td>อนุมัติ</td>
                                        <td></td>
                                        <td>
                                            <span class="fa fa-eye"></span>
                                            <a ng-click="SELECT_STAFF_LCN(data)">
                                                ดูข้อมูล
                                            </a>
                                        </td>
                                        <td>
                                            <span class="fa fa-check"></span>
                                            <a ng-click="SELECT_STAFF_LCN(data)">
                                                กดเพื่อยื่นขออนุญาต
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
