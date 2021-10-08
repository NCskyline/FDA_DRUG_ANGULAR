@Code
    ViewData("Title") = "INPUT_YORSOR3_20_TAN"
End Code
<script src="../Scripts_angular/ANGULAR_APP.js"></script>
<script src="../Scripts_angular/CENTER_SV.js"></script>
<script src="../Scripts_angular/LCN_CTRL.js"></script>

<script type="text/javascript">
    $(document).ready(function () {
        $('select').selectpicker('refresh');
    })
</script>

<div class="ic" ng-controller="LCN_CTRL" ng-app="ANGULAR_APP" ng-init="pageload_subtitute()" ng-cloak="">
    <div style="font-family:'Taviraj';font-size:24px;">
        <div>
            <p style="text-align: left;">แบบ ย.ส. 20</p>
        </div>

        <div class="container">
            <div class="row">
                <div class="col-md-6">
                    <table style="width:50%" align="left">
                        <tr>
                            <td style="width:100%">เลขที่รับ</td>
                            <td style=" width:25%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"><label>{{LCN_LIST.RCVNO_DISPLAY}}</label></td>
                        </tr>
                        <tr>
                            <td style="width:100%">วันที่</td>
                            <td style=" width:25%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"><label>{{LCN_LIST.RCV_DATE_DISPLAY}}</label></td>
                        </tr>
                        <tr>
                            <td style="width:100%" align="center" colspan="2">(สำหรับเจ้าหน้าที่เป็นผู้กรอก)</td>
                        </tr>
                    </table>
                </div>
                @*<div class="col-md-6 offset-md-4">
                        <table style="width:17%" align="right" border="1">
                            <tr>
                                <td style="width:100%"><img src="..." class="rounded float-end" alt="...">ที่ปิดรูปถ่ายผู้ขอใบแทนใบอนุญาตหรือผู้ดำเนินกิจการ ขนาด 3x4 เซนติเมตร</td>
                            </tr>
                        </table>
                    </div>*@
            </div>
        </div>
        <br />
        <div>
            <p style="text-align:center; font-size:large"><b>คำขอใบแทนใบอนุญาต</b></p>
            <p style="text-align:center; font-size:medium"><b>ผลิต จำหน่าย นำเข้า ส่งออกซึ่งยาเสพติดให้โทษ</b></p>
            <p style="text-align:center; font-size:medium"><b>ในประเภท 3</b></p>
            <hr style="width:20%; border-color:black;" />
            <table style="width:100%">
                <tr>
                    <td style="text-align:right;width:90%">
                        เขียนที่
                    </td>
                    <td style="width:40%">
                        <input class="form-control inline" ng-model="LIST_LCN.DALCN_NCT_SUBSTITUTE.WRITE_AT" style="font-family:'Taviraj';" type="text" />
                    </td>
                </tr>
                <tr>
                    <td style="text-align:right;width:100px">
                        วันที่
                    </td>
                    <td>

                        <md-datepicker ng-model="LIST_LCN.DALCN_NCT_SUBSTITUTE.WRITE_DATE" md-placeholder="Enter date"
                                       input-aria-describedby="datepicker-description"
                                       input-aria-labelledby="datepicker-header ">
                        </md-datepicker>
                    </td>
                </tr>

            </table>
            <br />
            <table style="width:100%">
                <tr>
                    <td style="width:10%; text-align:right">ข้าพเจ้า :</td>
                    <td style="width:80%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"> <label>{{LIST_LCN.thanm}}</label></td>
                    <td align="left" style="width:10%;">
                        ซึ่งผู้มีดำเนินกิจการ
                    </td>
                </tr>
                <tr>
                    <td style="width:10%;"></td>
                    <td style="width:90%; text-align:center" colspan="2">(ชื่อผู้ขออนุญาต)</td>
                </tr>
            </table>
            <br />
            <table style="width:100%">
                <tr>
                    <td style="width:2%"></td>
                    <td style="width:3%">ชื่อ</td>
                    <td style="width:70%; text-align:center;text-align:center;border-bottom:dotted;border-bottom-width:thin;"> <label>{{LIST_LCN.BSN_THAIFULLNAME}}</label></td>
                    <td>
                    <td style="width:25%; text-align:center">ได้รับอนุญาตให้ผลิต จำหน่าย นำเข้า หรือส่งออก</td>
                </tr>
            </table>
            <table style="width:100%">
                <tr>
                    <td style="width:2%"></td>
                    <td style="width:25%">ซึ่งยาเสพติดให้โทษในประเภท 3 ตามใบอนุญาต ที่</td>
                    <td style="width:50%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"><label>{{LIST_LCN.LCNNO_SHOW}}</label></td>
                    <td style="width:23%; text-align:center">ณ สถานที่ผลิต จำหน่าย นำเข้า</td>
                </tr>
            </table>
            <table style="width:100%">
                <tr>
                    <td style="width:2%"></td>
                    <td style="width:15%">หรือส่งออก ชื่อ</td>
                    <td style="width:83%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"><label>{{LIST_LCN.thanameplace}}</label></td>

                </tr>
            </table>
            <table style="width:100%">
                <tr>
                    <td style="width:5%;">อยู่เลขที่</td>
                    <td style="width:95%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"><label>{{LIST_LCN.fulladdr3}}</label></td>
                </tr>
            </table>
            <table style="width:100%">
                <tr>
                    <td style="width:18%;">โทรศัพท์/โทรศัพท์มือถือ</td>
                    <td style="width:82%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"><label>{{LIST_LCN.tel}}</label></td>
                </tr>
            </table>
            <br />
            <table style="width:100%">
                <tr>
                    <td style="width:15%"></td>
                    <td style="width:85%" colspan="2">ขอรับใบแทนใบอนุญาตผลิต จำหน่าย นำเข้า หรือส่งออกซึ่งยาเสพติดให้โทษในประเภท 3</td>
                </tr>
                <tr>
                    <td style="width:15%"></td>
                    <td style="width:85%" colspan="2">ขอรับใบแทนใบอนุญาตผลิต จำหน่าย นำเข้า ส่งออก หรือมีไว้ครอบครองซึ่งยาเสภติดให้โทษในประเภทในประเภท 4 หรือในประเภท 5</td>
                </tr>
                <tr>
                    <td style="width:15%"></td>
                    <td style="width:10%">เหตุที่ขอรับใบแทน</td>
                    <td>
                        <input type="text" ng-model="LIST_LCN.DALCN_NCT_SUBSTITUTE.PURPOSE" />
                    </td>
                </tr>
            </table>
            <br /><br /><br />
            @*<table style="width:100%">
            <tr>
                <td style="width:15%"></td>
                <td style="width:85%">พร้อมคำขอนี้ข้าพเจ้าได้แนบรูปถ่ายของผู้ขอใบแทนใบอนุญาตหรือผู้ดำเนินกิจการ ขนาด 3x4 เซนติเมตร จำนวน 2 รูป มาด้วยแล้ว</td>
            </tr>
        </table>*@
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
            <br />
            <table style="width:100%">
                <tr>
                    <td style="width:50%; text-align:center"></td>
                    <td style="width:10%; text-align:right">(ลายมือชื่อ)</td>
                    <td style="width:20%; text-align:center;border-bottom:dotted;border-bottom-width:thin;"></td>
                    <td style="width:20%; text-align:start">ผู้ยื่นคำขอ</td>
                </tr>
            </table>
            <br /><br />
            <table style="width:100%">
                <tr>
                    <td style="width:5%"></td>
                    <td style="width:10%">หมายเหตุ</td>
                    <td style="width:70%">(1) ในกรณีใบอนุญาตผลิต จำหน่าย นำเข้า หรือส่งออกซึ่งยาเสพติดให้โทษ ในประเภท 3 สูญหาย ให้นำใบแจ้งความต่อเจ้าหน้าที่ว่าใบอนุญาตดังกล่าวสูญหายมาด้วย</td>
                    <td style="width:15%"></td>
                </tr>
                <tr>
                    <td style="width:5%"></td>
                    <td style="width:10%"></td>
                    <td style="width:70%">(2) ในกรณีใบอนุญาตผลิต จำหน่าย นำเข้า หรือส่งออกซึ่งยาเสพติดให้โทษ ในประเภท 3 ถูกทำลายหรือลบเลือนในสาระสำคัญ ให้แนบใบอนุญาตที่ถูกทำลายหรือลบเลือนนั้นมาด้วย </td>
                    <td style="width:15%"></td>
                </tr>
                <tr>
                    <td style="width:5%"></td>
                    <td style="width:10%"></td>
                    <td style="width:70%">(3) ให้ขีดฆ่าข้อความที่ไม่ต้องการออก</td>
                    <td style="width:15%"></td>
                </tr>
            </table>
        </div>
        <div style="text-align:center">
            <input type="button" class="btn btn-lg" ng-click="BTN_BACK()" value="ย้อนกลับ" />
            <input type="button" class="btn btn-lg" ng-click="BTN_SAVE_STT()" value="บันทึก" />
        </div>
    </div>

</div>

