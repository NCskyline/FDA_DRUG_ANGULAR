@Code
'Layout = ""
End Code

@*<h2>TABEAN_YA_MAIN</h2>*@
    <script src="~/Scripts_angular/ANGULAR_APP.js"></script>
    <script src="~/Scripts_angular/CENTER_SV.js"></script>
    <script src="~/Scripts_angular/DR_CTRL.js"></script>
<style>
    .tab {
  overflow: hidden;
  border: 1px solid #ccc;
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
                    <button class="tablinks" onclick="openTab(event, 'DS')" id="defaultOpen">ยาตัวอย่าง</button>
                    <button class="tablinks" onclick="openTab(event, 'DR')">ย.1</button>
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
                        <div class="card" style=" border-top: 10px solid #277210;">
                            <table width="100%" style="font-family:'Taviraj'" class="table">
                                <thead style="font-weight:300;">
                                    <tr>
                                        <td>รหัสบัญชีรายการยา</td>
                                        <td>ชื่อยา (Th/Eng)</td>
                                        <td>เลขดำเนินการ</td>
                                        <td>สถานะ</td>
                                        <td></td>
                                    </tr>
                                </thead>
                                <tbody>
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
                        <div class="card" style=" border-top: 10px solid #277210;">
                            <table width="100%" style="font-family:'Taviraj'" class="table">
                                <thead style="font-weight:300;">
                                    <tr>
                                        <td>สถานะ</td>
                                        <td>ชื่อภาษาไทย</td>
                                        <td>ชื่อภาษาอังกฤษ</td>
                                        <td>รหัสการดำเนินการ</td>
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
                                        <td></td>
                                        <td></td>
                                        <td></td>
                                        <td></td>
                                        <td>
                                            <input type="button" ng-click="BTN_PREVIEW()" value="ดูข้อมูลล" />
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
                        <div class="card" style=" border-top: 10px solid #277210;">
                            <table width="100%" style="font-family:'Taviraj'" class="table">
                                <thead style="font-weight:300;">
                                    <tr>
                                        <td>สถานะ</td>
                                        <td>ชื่อภาษาไทย</td>
                                        <td>ชื่อภาษาอังกฤษ</td>
                                        <td>รหัสการดำเนินการ</td>
                                        <td></td>
                                    </tr>
                                </thead>
                                <tbody>
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