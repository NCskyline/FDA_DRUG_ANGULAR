﻿@Code
    ViewData("Title") = "FRM_EXTEND_TIME_LOCATION_STAFF_MAIN"
    Layout = ""
End Code

<br />
<h4>คำขอแก้ไขใบอนุญาตสถานที่ด้านยา</h4><br />
<table style="width:100%">
<tr>
    <td style="width:8%">เลขนิติบุคคล/เลขบัตรประชาชน</td>
    <td style="width:30%"><input type="text" style="width:30%" ng-model="citizenid"></td>
    </tr>
<tr>
    <td style="width:12%">เลขที่ใบอนุญาตสถานที่</td>
    <td style="width:30%"><input type="text" style="width:30%" ng-model="lcnno"></td>
</tr>
<tr>
    <td style="width:8%">เลขสถานที่</td>
    <td style="width:30%"><input type="text" style="width:30%"></td>
</tr>
    <tr>
        <td colspan="2"><button style="width:20%">ค้นหา</button></td>
    </tr>
</table>

<div class="row">
    <div class="col-sm-12" style="width:100%;">
        <div class="card" style=" border-top: 10px solid #277210;">
            <table width="100%" style="font-family:'Taviraj'" class="table" id="myTable" datatable="ng">
                <thead style="font-weight:300;">
                    <tr>
                        <td>เลขที่ใบอนุญาต</td>
                        <td>ประเภท</td>
                        <td>ที่อยู่</td>
                        <td>สถานะ</td>
                        <td>ต่ออายุในปี</td>
                        <td>เลขดำเนินการ</td>
                        <td>ผู้รับผิดชอบคำขอ</td>
                        <td></td>
                        <td></td>
                        <td></td>
                    </tr>
                </thead>
                <tbody>
                    <tr ng-repeat="data in DATA_LCN_EXTEND_STAFF">
                        <td>{{data.lcnno_no}}</td>
                        <td>{{data.lcntpcd}}</td>
                        <td>{{data.addr}}</td>
                        <td>{{data.STATUS_NAME}}</td>
                        <td>{{data.extend_year}}</td>
                        <td>{{data.TRANSACTION_UPLOAD}}</td>
                        <td>{{data.STAFF_NAME}}</td>
                        <td>{{data.STATUS_NAME}}</td>
                        <td>{{data.STATUS_NAME}}</td>
                        <td>
                            <span class="fa fa-eye"></span>
                            <a ng-click="">
                                ดูข้อมูล
                            </a>
                        </td>
                        <td></td>
                        <td></td>
                    </tr>
                </tbody>
                <tfoot>
                    <tr></tr>
                </tfoot>
            </table>

        </div>

    </div>
</div>