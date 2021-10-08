<script src="../Scripts_angular/CENTER_SV.js"></script>
<script src="../Scripts_angular/LCN_CTRL.js"></script>
<div class="ic" ng-controller="LCN_CTRL" ng-app="ANGULAR_APP" ng-init="pageload()" ng-cloak="">
    <div style="font-family:'Taviraj';font-size:15px;">
        <div>
            <h1 style="text-align:center;">
                คำขอเปลี่ยนแปลงรายการในใบอนุญาต
            </h1>

            <hr style="width:20%; border-color:black;" />
        </div>
        <br />
        <div>
            <table style="width:100%">
                <tr>
                    <td style="text-align:right;width:90%">
                        เขียนที่
                    </td>
                    <td style="width:40%;border-bottom:dotted;border-bottom-width:thin;">

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
            <br />
            <table style="width:100%">
                <tr>
                    <td style="width:15%; text-align:right">ข้าพเจ้า</td>
                    <td style="width:85%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"> <label>{{LIST_LCN.thanm}}</label></td>
                </tr>
            </table>
            <table style="width:100%">
                <tr>
                    <td style="width:40%"></td>
                    <td style="width:60%">ชื่อผู้รับอนุญาต</td>
                </tr>
            </table>

            <table style="width:100%">
                <tr>
                    @**@
                    <td style="width:10%">ซึ่งมีผู้ดำเนินกิจการชื่อ</td>
                    <td style="width:75%;border-bottom:dotted;border-bottom-width:thin;"> <label>{{LIST_LCN.BSN_THAIFULLNAME}}</label></td>
                    <td style="width:15%">ได้รับอนุญาตให้</td>
                </tr>
            </table>
            <table style="width:100%">
                <tr>
                    <td style="width:40%;border-bottom:dotted;border-bottom-width:thin;"><label>{{LIST_LCN.TYPE_LCN}}</label></td>
                    <td style="width:10%">ตามใบอนุญาตเลขที่</td>
                    <td style="width:50%;border-bottom:dotted;border-bottom-width:thin;"></td>
                </tr>
            </table>
            <table style="width:100%">
                <tr>
                    <td style="width:10%">ณ สถานที่ชื่อ</td>
                    <td style="width:90%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"><label>{{LIST_LCN.thanameplace}}</label></td>

                </tr>
                <tr>
                    <td style="width:10%;">อยู่เลขที่</td>
                    <td style="width:90%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"><label>{{LIST_LCN.fulladdr3}}</label></td>
                </tr>
            </table>
            <table style="width:100%">
                <tr>
                    <td style="width:10%">โทรศัพท์</td>
                    <td style="width:90%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"><label>{{LIST_LCN.tel}}</label></td>
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
            <br /><br /><br /><br /><br /><br /><br />
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
            @*<table style="width:100%">
            <tr>
                <td style="width:10%"></td>
                <td style="width:90%">ข้าพเจ้าได้แนบหลักฐานมาด้วย คือ</td>
            </tr>
            <tr>
                <td style="width:10%"></td>
                <td style="width:90%">1.ใบอนุญาต</td>
            </tr>
            <tr>
                <td style="width:10%"></td>
                <td style="width:90%">2.เอกสารที่เป็นหลักฐานเกี่ยวข้องกับรายการเปลี่ยนแปลง</td>
            </tr>
        </table>*@
            <br /><br /><br /><br />
            <table style="width:100%">
                <tr>
                    <td style="width:50%; text-align:center"></td>
                    <td style="width:10%; text-align:right">(ลายมือชื่อ)</td>
                    <td style="width:20%; text-align:center;border-bottom:dotted;border-bottom-width:thin;"></td>
                    <td style="width:20%; text-align:start">ผู้ยื่นคำขอ</td>
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
                            <a ng-show="PROCESS == '11109'" ng-click="OPEN_DOC_PATH(datas.PATH,datas.FILENAME)">ดูเอกสาร</a>
                        </td>
                    </tr>
                </table>
            </div>
        </div>
    </div>
</div>