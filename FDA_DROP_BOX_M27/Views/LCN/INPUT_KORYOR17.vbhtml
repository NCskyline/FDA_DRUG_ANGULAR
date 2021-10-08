<script src="../Scripts_angular/CENTER_SV.js"></script>
<script src="../Scripts_angular/LCN_CTRL.js"></script>
<div class="ic" ng-controller="LCN_CTRL" ng-app="ANGULAR_APP" ng-init="pageload_modify()" ng-cloak="">
    <div style="font-family:'Taviraj';font-size:24px;">
        <div>
            <p style="text-align: right;">แบบ ข.ย.๑๗</p>
        </div>
        <table style="width:100%">
            <tr>
                <td style="width:35%"></td>
                <td style="width:35%"></td>
                <td style="width:5%;text-align:right">เลขที่:</td>
                <td style=" width:25%;text-align:center;border-bottom:dotted;border-bottom-width:thin;" "><label>{{LCN_LIST.RCVNO_DISPLAY}}</label></td>
            </tr>
        </table>
        <table style="width:100%">
            <tr>
                <td style="width:35%"></td>
                <td style="width:35%"></td>
                <td style="width:5%;text-align:right">วันที่:</td>
                <td style=" width:25%;text-align:center;border-bottom:dotted;border-bottom-width:thin;" "><label>{{LCN_LIST.RCV_DATE_DISPLAY}}</label></td>
            </tr>
        </table>
        <table style="width:100%">
            <tr>
                <td style="width:35%"></td>
                <td style="width:35%"></td>
                <td style="width:5%;text-align:right"> ลงชื่อ:</td>
                <td style=" width:15%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"></td>
                <td style="width:10%">ผู้รับคำขอ</td>
            </tr>
        </table>
        <div> <p style="text-align:center">คำขอแก้ไขเปลี่ยนแปลงรายการในใบอนุญาตขายยาแผนปัจจุบัน</p></div>
        <hr />
        <table style="width:100%">
            <tr>
                <td style="text-align:right;width:90%;border-bottom:dotted;border-bottom-width:thin;">
                    เขียนที่
                </td>
                <td style="width:40%">

                    {{LIST_LCN.DALCN_EDIT_RREQUEST.WRITE_AT}}
                </td>
            </tr>
            <tr>
                <td style="text-align:right;width:100px">
                    วันที่
                </td>
                <td style="border-bottom:dotted;border-bottom-width:thin;">

                    {{LIST_LCN.DALCN_EDIT_RREQUEST.WRITE_DATE}}
                </td>
            </tr>

        </table>
        <table style="width:100%">
            <tr>
                <td style="width:10%;text-align:right">ข้าพเจ้า :</td>
                <td style="width:90%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"> <label>{{LIST_LCN.thanm}}</label></td>
            </tr>
        </table>
        <table style="width:100%">
            <tr>
                <td style="width:10%;"></td>
                <td style="width:90%;text-align:center">(ชื่อผู้รับอนุญาต)</td>
            </tr>
        </table>
        <table style="width:100%">
            <tr>
                <td style="width:13%;">มีผู้ดำเนินกิจการ ชื่อ</td>
                <td style="width:74%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"> <label>{{LIST_LCN.BSN_THAIFULLNAME}}</label></td>
                <td style="width:13%;">(เฉพาะกรณีนิติบุคคล)</td>
            </tr>
        </table>

        <table style="width:100%;">
            <tr>
                <td style="width:13%;">เลขที่บัตรประชาชน</td>
                <td style="width:87%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"> <label>{{LIST_LCN.BSN_IDENTIFY}}</label></td>
            </tr>
        </table>
        <div style="padding-left:30%;">
            <table>
                <tr>
                    <td>ได้รับอนุญาตให้ :</td>
                    <td>
                        <input type="radio" name="type_a" ng-model="LIST_LCN.CHK_TYPE" value="1" id="rdl_CHK_SELL_TYPE" disabled="disabled" />ขายยาแผนปัจจุบัน
                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <input type="radio" name="type_a" ng-model="LIST_LCN.CHK_TYPE" value="2" id="rdl_CHK_SELL_TYPE" disabled="disabled" />ขายยาแผนปัจจุบันเฉพาะยาบรรจุเสร็จที่ไม่ใช่ยาอันตรายหรือยาควบคุมพิเศษ
                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td> <input type="radio" name="type_a" ng-model="LIST_LCN.CHK_TYPE" value="3" id="rdl_CHK_SELL_TYPE" disabled="disabled" />ขายยาแผนปัจจุบันเฉพาะยาบรรจุเสร็จสำหรับสัตว์</td>
                </tr>
                <tr>
                    <td></td>
                    <td> <input type="radio" name="type_a" ng-model="LIST_LCN.CHK_TYPE" value="4" id="rdl_CHK_SELL_TYPE" disabled="disabled" />ขายส่งยาแผนปัจจุบัน</td>
                </tr>
            </table>
        </div>
        <table style="width:100%">
            <tr>
                <td style="width:13%;">ใบอนุญาตเลขที่</td>
                <td style="width:20%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"><label>{{LIST_LCN.LCNNO_SHOW}}</label></td>
                <td style="width:12%;">ณ สถานที่ขายยาชื่อ</td>
                <td style="width:55%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"><label>{{LIST_LCN.thanameplace}}</label></td>
            </tr>
        </table>
        <table style="width:100%">
            <tr>
                <td style="width:10%;">ตั้งอยู่เลขที่</td>
                <td style="width:90%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"><label>{{LIST_LCN.fulladdr3}}</label></td>
            </tr>
        </table>
        <table style="width:100%">
            <tr>
                <td style="width:13%;">โทรศัพท์/โทรศัพท์มือถือ</td>
                <td style="width:87%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"><label>{{LIST_LCN.tel}}</label></td>
            </tr>
        </table>
        <table style="width:100%">
            <tr>
                <td>ขอเปลี่ยนแปลงรายการในใบอนุญาต ดังต่อไปนี้</td>
            <tr>
                <td>
                    <input class="form-control inline" ng-model="LIST_LCN.DALCN_EDIT_REQUEST.EDIT_DESCRIPTION" style="font-family:'Taviraj';font-size:20px;width:100%;" type="text" />

                </td>
            </tr>
        </table>
        <br />
        <div class="row">
            <div class="col-sm-10" style="width:100%">
                <div class="card" ng-repeat="datas in DOC_LIST.FILE_LISTs">
                    <div class="card-header" ng-show="datas.PIORITY=='HIGH'">
                        หัวข้อเอกสาร <span style="color:red;"> (บังคับแนบ)</span>
                    </div>
                    <div class="card-header" ng-show="datas.PIORITY=='LOW'">
                        หัวข้อเอกสาร (ไม่บังคับแนบ)
                    </div>
                    <div class="card-body">

                        <table class="table" style="width:100%">
                            <tr>
                                <td colspan="5">
                                    {{datas.DES}}
                                </td>
                            </tr>
                            <tr>
                                <td style="width:15%;"><input id="file-input" ng-model="datas.FILE_DATA" type="file" name="file" ngf-select="selectFileforUpload(datas,$files)" /></td>
                                <td style="width:10%;">ชื่อไฟล์</td>
                                <td style="width:50%;">{{datas.FILENAME}}</td>
                                <td style="width:5%">
                                    <a ng-click="OPEN_DOC_PATH(datas.PATH)">{{FLAG}}</a>
                                </td>
                                <td style="width:20%; text-align: right;">
                                    @*<input type="button" ng-click="UPLOAD_PDFs(datas)" value="บันทึก" />*@
                                    @*<input type="button" ng-click="deleteRow(datas,$index)" value="ลบ" />*@
                                </td>
                            </tr>

                        </table>
                    </div>

                </div>
            </div>
        </div>
        @*<table>
            <tr>
                <td> &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; ขายส่งยาแผนปัจจุบัน คือ</td>
            </tr>
        </table>
        <table>
            <tr>
                <td> &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; (๑) ใบอนุญาตประกอบธุรกิจเกี่ยวกับยาหรือใบแทน</td>
            </tr>
        </table>
        <table>
            <tr>
                <td> &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; (๒) เอกสารที่เป็นหลักฐานเกี่ยวข้องกับรายการที่ขอเปลี่ยนแปลง</td>
            </tr>
        </table>*@
        <table style="width:100%">
            <tr>
                <td style="width:50%;text-align:center"></td>
                <td style="width:10%;text-align:right">(ลายมือชื่อ)</td>
                <td style="width:20%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"></td>
                <td style="width:20%;text-align:start">ผู้รับอนุญาต</td>
            </tr>
        </table>
        <table style="width:100%">
            <tr>
                <td style="width:50%;text-align:center"></td>
                <td style="width:10%;text-align:right">(</td>
                <td style="width:20%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"></td>
                <td style="width:20%;text-align:start">) (ตัวบรรจง)</td>
            </tr>
        </table>
        <table style="width:100%">
            <tr>
                <td style="width:50%;text-align:center"></td>
                <td style="width:10%;text-align:right">(ลายมือชื่อ)</td>
                <td style="width:20%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"></td>
                <td style="width:20%;text-align:start">ผู้มีหน้าที่ปฏิบัติการ</td>
            </tr>
        </table>
        <table style="width:100%">
            <tr>
                <td style="width:50%;text-align:center"></td>
                <td style="width:10%;text-align:right">(</td>
                <td style="width:20%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"></td>
                <td style="width:20%;text-align:start">) (ตัวบรรจง)</td>
            </tr>
        </table>
        <br />
        <div class="col-sm-12">
            <div class="row">
                <div class="col-sm-3" style="text-align:center">
                    รายละเอืยด :
                </div>
                <div class="col-sm-9">
                    {{REMARK}}
                </div>
            </div>
            <br />
            <table class="table" style="width:100%">
                <tr>
                    <td>ชื่อไฟล์</td>
                    <td></td>
                </tr>
                <tr ng-repeat="datas in LIST_LCN" style="background-color:#FDFCE3">
                    <td>{{datas.FILENAME}}</td>
                    <td>
                        <a ng-show="PROCESS == '11105'" ng-click="OPEN_DOC_PATH(datas.PATH,datas.FILENAME)">ดูเอกสาร</a>
                    </td>
                </tr>
            </table>
        </div>
    </div>
    <br />
    <div style="text-align:center">
        <input type="button" class="btn btn-lg" ng-click="BTN_BACK()" value="ย้อนกลับ" />
        <input type="button" class="btn btn-lg" ng-click="BTN_SAVE_EDIT()" value="บันทึก" />
    </div>
</div>