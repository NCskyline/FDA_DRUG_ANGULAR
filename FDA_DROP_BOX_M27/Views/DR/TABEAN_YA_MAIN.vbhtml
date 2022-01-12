﻿@Code
'Layout = ""
End Code

@*<h2>TABEAN_YA_MAIN</h2>*@
    <script src="~/Scripts_angular/ANGULAR_APP.js"></script>
    <script src="~/Scripts_angular/CENTER_SV.js"></script>
    <script src="~/Scripts_angular/DR_CTRL.js"></script>
<style>
    .tab {
        overflow: hidden;
        border: none;
        background-color: #f1f1f1;
        
    }

/* Style the buttons that are used to open the tab content */
        .tab button {
            background-color: inherit;
            float: left;
            border: none;
            outline: none;
            cursor: pointer;
            padding: 14px 16px;
            transition: 0.3s;
            font-family:'Taviraj';
        }

/* Change background color of buttons on hover */
.tab button:hover {
  background-color: #ddd;
}

/* Create an active/current tablink class */
            .tab button.active {
                background-color: #ccc;
            }

    /* Style the tab content */
.tabcontent {
  display: none;
  padding: 6px 12px;
  border: 1px solid #ccc;
  border-top: none;
}
</style>
<div ng-app="ANGULAR_APP" ng-controller="DR_CTRL"> 
    <div class="ic" style="font-family:'Taviraj'">
        <div>
            <h1>ข้อมูล</h1>
            <table class="table" width="100%" border="1">
                <tr>
                    <td>ชื่อบริษัท</td>
                    <td>ทดสอบ จำกัด</td>
                    <td>เลขที่ใบอนุญาต</td>
                    <td>ผย1 กท 999/2563</td>
                </tr>
                <tr>
                    <td>ชื่อยา (ภาษาไหย)</td>
                    <td>พาราทดสอบ</td>
                    <td>ชื่อยา (ภาษาอังกฤษ)</td>
                    <td></td>
                </tr>
                <tr>
                    <td>หมวดยา</td>
                    <td>แก๊สทางการแพทย์</td>
                    <td>ชนิดยา</td>
                    <td></td>
                </tr>
                <tr>
                    <td>เลขที่ตำรับ</td>
                    <td>DL-64-01257</td>
                </tr>
            </table>
            <br />
            <div>
                <div class="tab">
                    <button class="tablinks" onclick="openTab(event, 'DS')" >ยาตัวอย่าง</button>
                    <button class="tablinks" onclick="openTab(event, 'DR')" id="defaultOpen">คำขอขึ้นทะเบียนตำรับยา</button>
                </div>
            </div>

            @*------------------  DS  ------------------*@

        <div id="DS" class="tabcontent">
            <h3 style="color:red">ยาตัวอย่าง</h3>
            <table width="100%" style="font-family:'Taviraj'">
                <tr>
                    <td width="40%">ใบอนุญาตคำขออนุญาตผลิตยาตัวอย่างเพื่อขอขึ้นทะเบียนตำรับยา ({{lcnnoType}})</td>

                    <td align="right">
                        <button class="btn btn-lg" ng-click="BTN_DS_INPUT()">สร้างคำขอ</button>
                    </td>
                </tr>
            </table>
            <br />
            <div class="row">
                <div class="col-sm-12" style="width:100%;">
                    <div class="card" style=" border-top: 10px solid #F9D027">
                        <table width="100%" style="font-family:'Taviraj'" class="table">
                            <thead style="font-weight:300;">
                                <tr>
                                    <td>รหัสบัญชีรายการยา</td>
                                    <td>ชื่อยา (Th/Eng)</td>
                                    <td>เลขดำเนินการ</td>
                                    <td>สถานะ</td>
                                    <td></td>
                                    <td></td>
                                </tr>
                            </thead>
                            <tbody>
                                @*<tr>
                                    <td>DL-64-01257</td>
                                    <td>พาราทดสอบ</td>
                                    <td>640009999</td>
                                    <td>บันทึกแล้ว รอการส่งเรื่อง</td>
                                    <td>
                                        <span class="fa fa-eye"></span>
                                        <a ng-click="">
                                            ดูข้อมูล
                                        </a>
                                    </td>
                                    <td></td>
                                </tr>
                                <tr>
                                    <td>DL-64-01257</td>
                                    <td>พาราทดสอบ</td>
                                    <td>640009999</td>
                                    <td>ส่งเรื่องแล้ว รอการชำระเงิน</td>
                                    <td>
                                        <span class="fa fa-eye"></span>
                                        <a ng-click="">
                                            ดูข้อมูล
                                        </a>
                                    </td>
                                    <td></td>
                                </tr>
                                <tr>
                                    <td>DL-64-01257</td>
                                    <td>พาราทดสอบ</td>
                                    <td>640009999</td>
                                    <td>อนุมัติคำขอ</td>
                                    <td>
                                        <span class="fa fa-eye"></span>
                                        <a ng-click="">
                                            ดูข้อมูล
                                        </a>
                                    </td>
                                    <td></td>
                                </tr>
                                <tr>
                                    <td>DL-64-01257</td>
                                    <td>พาราทดสอบ</td>
                                    <td>640009999</td>
                                    <td>รอการแก้ไขคำขอ</td>
                                    <td>
                                        <span class="fa fa-eye"></span>
                                        <a ng-click="SELECT_DS()">
                                            ดูข้อมูล
                                        </a>
                                    </td>
                                    <td>
                                        <span class="fa fa-pen"></span>
                                        <a ng-click="">
                                            ดูรายละเอียดที่ต้องแก้ไข
                                        </a>
                                    </td>
                                </tr>*@
                                <tr ng-repeat="data in DATA_EDIT_LCN_RQT">
                                    <td>{{data.RCVNO_MANUAL}}</td>
                                    <td></td>
                                    <td>{{data.LCNNO_MANUAL}}</td>
                                    <td>{{data.STATUS_NAME}}</td>
                                    <td>{{data.TRANSACTION_UPLOAD}}</td>
                                    <td>
                                        <span class="fa fa-eye"></span>
                                        <a ng-click="SELECT_DS()">
                                            ดูข้อมูล
                                        </a>
                                    </td>
                                    <td>
                                        <span class="fa fa-pen"></span>
                                        <a ng-click="">
                                            ดูรายละเอียดที่ต้องแก้ไข
                                        </a>
                                    </td>
                                </tr>
                            </tbody>
                        </table>
                    </div>
                </div>
            </div>
            <div align="right">
                <a ng-click="BTN_PAYMENT()" style="color:blue">กดที่นี่เพื่อชำระเงิน</a>
            </div>
        </div>

            @*------------------  DR  ------------------*@

            <div id="DR" class="tabcontent">
                <h3 style="color:red">ย.1</h3>
                <table width="100%" style="font-family:'Taviraj'">
                    <tr>
                        <td width="40%">ใบอนุญาตคำขออนุญาตผลิตยาตัวอย่างเพื่อขอขึ้นทะเบียนตำรับยา ({{lcnnoType}})</td>

                        <td align="right">
                            <button class="btn btn-lg" ng-click="BTN_INPUT()">สร้างคำขอ</button>
                        </td>
                        <td>
                            <button class="btn btn-lg" ng-click="BTN_TRANSFER()">คำขอ Transfer/Refer/Copy</button>
                        </td>
                    </tr>
                </table>
                <hr />
                <br />
                <div class="in">
                    <h3 style="color:red">คำขอขึ้นทะเบียน</h3>
                    <div class="row">
                        <div class="col-sm-12" style="width:100%;">
                            <div class="card" style=" border-top: 10px solid #F9D027;">
                                <table width="100%" style="font-family:'Taviraj'" class="table">
                                    <thead style="font-weight:300;">
                                        <tr>
                                            <td>สถานะ</td>
                                            <td>ชื่อภาษาไทย</td>
                                            <td>ชื่อภาษาอังกฤษ</td>
                                            <td>เลขดำเนินการ</td>
                                            <td></td>
                                            <td></td>
                                        </tr>
                                    </thead>
                                    <tbody>
                                        @*<tr ng-repeat="data in DATA_EDIT_LCN_RQT">
                                            <td>{{data.RCVNO_MANUAL}}</td>
                                            <td>{{data.LCNNO_MANUAL}}</td>
                                            <td>{{data.STATUS_NAME}}</td>
                                            <td>{{data.TRANSACTION_UPLOAD}}</td>
                                            <td>
                                                <span class="fa fa-eye"></span>
                                                <a ng-click="">
                                                    ดูข้อมูล
                                                </a>
                                            </td>
                                        </tr>*@
                                        <tr>
                                            <td>สร้างคำขอแล้ว รอชำระเงิน</td>
                                            <td>พารา</td>
                                            <td>para</td>
                                            <td>640009999</td>
                                            <td>
                                                <span class="fa fa-eye"></span>
                                                <a ng-click="BTN_PREVIEW(datas)">
                                                    ดูข้อมูล
                                                </a>
                                            </td>
                                            <td>
                                                <span class="fa fa-eye"></span>
                                                <a ng-click="BTN_RQT(datas)">
                                                    เพิ่มข้อมูลส่วนที่ 2
                                                </a>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>บันทึกข้อมูลและรอสร้างคำขอ</td>
                                            <td>พารา</td>
                                            <td>para</td>
                                            <td>640009999</td>
                                            <td>
                                                <span class="fa fa-eye"></span>
                                                <a ng-click="BTN_PREVIEW(datas)">
                                                    ดูข้อมูล
                                                </a>
                                            </td>
                                            <td>
                                                <span class="fa fa-pager"></span>
                                                <a ng-click="BTN_RQT(datas)">
                                                    เพิ่มข้อมูลส่วนที่ 2
                                                </a>
                                            </td>
                                        </tr>
                                    </tbody>
                                </table>
                            </div>
                        </div>
                    </div>
                    <div align="right">
                        <a ng-click="BTN_PAYMENT()" style="color:blue">กดที่นี่เพื่อชำระเงิน</a>
                    </div>
                </div>
                <br />
                <div class="in">
                    <h3 style="color:red">ทะเบียนตำรับ</h3>
                    <div class="row">
                        <div class="col-sm-12" style="width:100%;">
                            <div class="card" style=" border-top: 10px solid #F9D027;">
                                <table width="100%" style="font-family:'Taviraj'" class="table">
                                    <thead style="font-weight:300;">
                                        <tr>
                                            <td>สถานะ</td>
                                            <td>ชื่อภาษาไทย</td>
                                            <td>ชื่อภาษาอังกฤษ</td>
                                            <td>เลขดำเนินการ</td>
                                            <td></td>
                                            <td></td>
                                        </tr>
                                    </thead>
                                    <tbody>
                                        <tr>
                                            <td>ชำระค่าใบสำคัญการขึ้นทะเบียน</td>
                                            <td>พารา</td>
                                            <td>para</td>
                                            <td>640009999</td>
                                            <td>
                                                <span class="fa fa-eye"></span>
                                                <a ng-click="">
                                                    ดูข้อมูล
                                                </a>
                                            </td>
                                            <td></td>
                                        </tr>
                                        <tr ng-repeat="data in DATA_EDIT_LCN_RQT">
                                            <td>{{data.RCVNO_MANUAL}}</td>
                                            <td>{{data.LCNNO_MANUAL}}</td>
                                            <td>{{data.STATUS_NAME}}</td>
                                            <td>{{data.TRANSACTION_UPLOAD}}</td>
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
                    <div align="right">
                        <a ng-click="BTN_PAYMENT()" style="color:blue">กดที่นี่เพื่อชำระเงิน</a>
                    </div>
                </div>

            </div>
        <div id="DR" class="tabcontent">
            <h3 style="color:red">คำขอขึ้นทะเบียนตำรับยา</h3>
            <table width="100%" style="font-family:'Taviraj'" >
                <tr>
                    <td width="10%" style="font-size:20px"><b>ชื่อยาภาษาไทย :</b></td>
                    <td width="30%">ยาภาษาไทย</td>
                    <td width="12%" style="font-size:20px"><b>ชื่อยาภาษาอังกฤษ :</b></td>
                    <td width="28%"></td>
                    <td width="10%" align="right" >
                        <button class="btn btn-lg" ng-click="BTN_INPUT()">สร้างคำขอ</button>
                    </td>
                    <td width="10%">
                        <button class="btn btn-lg" ng-click="BTN_TRANSFER()">คำขอ Transfer/Refer/Copy</button>
                    </td>
                </tr>
            </table>
            <hr />
            <br />
            <div class="in">
                <h3 style="color:red">คำขอขึ้นทะเบียน</h3>
                <div class="row">
                    <div class="col-sm-12" style="width:100%;">
                        <div class="card" style=" border-top: 10px solid #F9D027;">
                            <table width="100%" style="font-family:'Taviraj'" class="table">
                                <thead style="font-weight:300;">
                                    <tr>
                                        <td>สถานะ</td>
                                        <td>ชื่อภาษาไทย</td>
                                        <td>ชื่อภาษาอังกฤษ</td>
                                        <td>รหัสการดำเนินการ</td>
                                        <td></td>
                                        <td></td>
                                    </tr>
                                </thead>
                                <tbody>
                                    @*<tr ng-repeat="data in DATA_EDIT_LCN_RQT">
            <td>{{data.RCVNO_MANUAL}}</td>
            <td>{{data.LCNNO_MANUAL}}</td>
            <td>{{data.STATUS_NAME}}</td>
            <td>{{data.TRANSACTION_UPLOAD}}</td>
            <td>
                <span class="fa fa-eye"></span>
                <a ng-click="">
                    ดูข้อมูล
                </a>
            </td>
        </tr>*@
                                    <tr>
                                        <td>สร้างคำขอแล้ว รอชำระเงิน</td>
                                        <td>พารา</td>
                                        <td>para</td>
                                        <td>640009999</td>
                                        <td>
                                            <span class="fa fa-eye"></span>
                                            <a ng-click="BTN_PREVIEW(datas)">
                                                ดูข้อมูลล
                                            </a>
                                        </td>
                                        <td>
                                            <span class="fa fa-pen"></span>
                                            <a ng-click="BTN_RQT(datas)">
                                                เพิ่มข้อมูลส่วนที่ 2
                                            </a>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>บันทึกข้อมูลและรอสร้างคำขอ</td>
                                        <td>พารา A</td>
                                        <td>para</td>
                                        <td>640009999</td>
                                        <td>
                                            <span class="fa fa-eye"></span>
                                            <a ng-click="BTN_PREVIEW(datas)">
                                                ดูข้อมูลล
                                            </a>
                                        </td>
                                        <td>
                                            <span class="fa fa-pen"></span>
                                            <a ng-click="BTN_RQT(datas)">
                                                เพิ่มข้อมูลส่วนที่ 2
                                            </a>
                                        </td>
                                    </tr>
                                </tbody>
                            </table>
                        </div>
                    </div>
                </div>
            </div>
            <br />
            <div class="in">
                <h3 style="color:red">ทะเบียนตำรับ</h3>
                <div class="row">
                    <div class="col-sm-12" style="width:100%;">
                        <div class="card" style=" border-top: 10px solid #F9D027;">
                            <table width="100%" style="font-family:'Taviraj'" class="table">
                                <thead style="font-weight:300;">
                                    <tr>
                                        <td>สถานะ</td>
                                        <td>ชื่อภาษาไทย</td>
                                        <td>ชื่อภาษาอังกฤษ</td>
                                        <td>รหัสการดำเนินการ</td>
                                        <td></td>
                                        <td></td>
                                    </tr>
                                </thead>
                                <tbody>
                                    <tr>
                                        <td>ชำระค่าใบสำคัญการขึ้นทะเบียน</td>
                                        <td>พารา</td>
                                        <td>para</td>
                                        <td>640009999</td>
                                        <td>
                                            <span class="fa fa-eye"></span>
                                            <a ng-click="">
                                                ดูข้อมูล
                                            </a>
                                        </td>
                                        <td></td>
                                    </tr>
                                    <tr ng-repeat="data in DATA_EDIT_LCN_RQT">
                                        <td>{{data.RCVNO_MANUAL}}</td>
                                        <td>{{data.LCNNO_MANUAL}}</td>
                                        <td>{{data.STATUS_NAME}}</td>
                                        <td>{{data.TRANSACTION_UPLOAD}}</td>
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
    </div>
</div>

<script>
    function openTab(evt, Type) {
        var i, tabcontent, tablinks;

        tabcontent = document.getElementsByClassName("tabcontent");
        for (i = 0; i < tabcontent.length; i++) {
            tabcontent[i].style.display = "none";
        }
        
        tablinks = document.getElementsByClassName("tablinks");
        for (i = 0; i < tablinks.length; i++) {
            tablinks[i].className = tablinks[i].className.replace(" active", "");
        }

        document.getElementById(Type).style.display = "block";
        evt.currentTarget.className += " active";
    }
    document.getElementById("defaultOpen").click();
</script>