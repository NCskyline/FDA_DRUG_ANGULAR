<script src="../Scripts_angular/CENTER_SV.js"></script>
<script src="../Scripts_angular/LCN_CTRL.js"></script>
<div class="ic" ng-controller="LCN_CTRL" ng-app="ANGULAR_APP" ng-init="pageload()" ng-cloak="">
    @*<div ng-show="LIST_GMP.DALCN_EDIT_REQUEST.PROCESS_ID == '11109'">*@
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
                    <td style="width:40%">
                        <input class="form-control inline" ng-model="LIST_LCN.DALCN_EDIT_REQUEST.WRITE_AT" style="font-family:'Taviraj';" type="text" />
                    </td>
                </tr>
                <tr>
                    <td style="text-align:right;width:100px">
                        วันที่
                    </td>
                    <td>

                        <md-datepicker ng-model="LIST_LCN.DALCN_EDIT_REQUEST.WRITE_DATE" md-placeholder="Enter date"
                                       input-aria-describedby="datepicker-description"
                                       input-aria-labelledby="datepicker-header ">
                        </md-datepicker>
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
            <br /><br />
            <div class="row">
                <div class="col-sm-12" style="width:100%">
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

        </div>
    </div>
    <br />
    <div style="text-align:center">
        <input type="button" class="btn btn-lg" style="background-color:#FFD700" ng-click="BTN_BACK()" value="ย้อนกลับ" />
        <input type="button" class="btn btn-lg" style="background-color:#38A86B;color:white" ng-click="BTN_SAVE_EDIT()" value="บันทึก" />
    </div>
</div>