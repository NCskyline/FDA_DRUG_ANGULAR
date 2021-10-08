@Code
    ViewData("Title") = "PDF_DRUG_KORYOR16"
    Layout = ""
End Code

<div class="ic">
    <div style="font-family:'Taviraj';font-size:20px;">
        <div>
            <p style="text-align: left;">แบบ ย.ส.19</p>
        </div>
        <table style="width:100%">
            <tr>
                <td style="width:5%;text-align:right">เลขที่:</td>
                <td style=" width:25%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"></td>
                <td style="width:35%"></td>
                <td style="width:35%"></td>
            </tr>
        </table>
        <table style="width:100%">
            <tr>
                <td style="width:5%;text-align:right">วันที่:</td>
                <td style=" width:25%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"></td>
                <td style="width:35%"></td>
                <td style="width:35%"></td>
            </tr>
        </table>
        <table style="width:100%">
            <tr>
                <td style="width:5%;text-align:right"> ลงชื่อ:</td>
                <td style=" width:15%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"></td>
                <td style="width:10%">ผู้รับคำขอ</td>
                <td style="width:35%"></td>
                <td style="width:35%"></td>
            </tr>
        </table>
        <hr />
        <div> <h3 style="text-align:center">คำขอต่ออายุใบอนุญาต</h3></div>
        <div> <h3 style="text-align:center">ผลิต จำหน่าย นำเข้า หรือส่งออกซึ่งยาเสพติดให้โทษในประเภท 3</h3></div>
        <hr />
        <table style="width:100%">
            <tr>
                <td style="width:70%"></td>
                <td>เขียนที่ <input style="width:100%;text-align:right" /></td>
            </tr>
        </table>
        <table style="width:100%">
            <tr>
                <md-datepicker ng-model="datas.MFD_DATE" md-placeholder="Enter date"
                               input-aria-describedby="datepicker-description"
                               input-aria-labelledby="datepicker-header "></md-datepicker>
            </tr>
        </table>
        <br />
        <table style="width:100%">
            <tr>
                <td style="width:10%;text-align:right">ข้าพเจ้า </td>
                <td style="width:40%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"></td>
                <td style="width:10%;text-align:right">ซึ่งมีผู้ดำเนินกิจการ</td>
                <td style="width:40%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"></td>
            </tr>
        </table>
        <table style="width:100%">
            <tr>
                <td style="width:10%;text-align:right"></td>
                <td style="width:40%;text-align:center">(ชื่อผู้ขอต่อายุใบอนุญาต)</td>
                <td style="width:10%;text-align:right"></td>
                <td style="width:40%;text-align:center"></td>
            </tr>
        </table>
        <table style="width:100%">
            <tr>
                <td style="width:10%;">ชื่อ</td>
                <td style="width:60%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"></td>
                <td style="width:30%;">ได้รับอนุญาตให้ ผลิต จำหน่าย นำเข้า หรือส่งออก</td>
            </tr>
        </table>
        <table style="width:100%">
            <tr>
                <td style="width:30%;">ซึ่งยาเสพติดให้โทษในประเภท 3 ตาม ใบอนุญาตที่</td>
                <td style="width:20%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"></td>
                <td style="width:50%;">ณ สถานที่ผลิต จำหน่าย นำเข้า</td>
            </tr>
        </table>
        <table style="width:100%">
            <tr>
                <td style="width:13%;">หรือส่งออก ชื่อ</td>
                <td style="width:87%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"></td>
            </tr>
        </table>
        <table style="width:100%">
            <tr>
                <td style="width:13%;">อยู่เลขที่</td>
                <td style="width:87%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"></td>
            </tr>
        </table>
        <table style="width:100%">
            <tr>
                <td style="width:20%;">โทรศัพท์/โทรศัพท์มือถือ</td>
                <td style="width:80%;border-bottom:dotted;border-bottom-width:thin;"> </td>
            </tr>
        </table>
        <br />
        <table style="width:100%">
            <tr>
                <td style="width:5%">
                <td style="width:80%">ขอต่ออายุใบอนุญาตดังกล่าว เพื่อใช้ต่อไปในปี พ.ศ.</td>
                <td style="width:15%;border-bottom:dotted;border-bottom-width:thin;">
            </tr>
        </table>
        <br />
        @*<table style="width:100%">
            <tr>
                <td style="width:5%"></td>
                <td style="width:95%">พร้อมกับคำขอนี้ ข้าพเจ้าได้ส่งมอบหลักฐานต่างๆ มาด้วย คือ</td>
            </tr>
        </table>
        <table style="width:100%">
            <tr>
                <td style="width:5%"></td>
                <td style="width:95%">(๑) รูปถ่ายของผู้ขอต่ออายุใบอนุญาตหรือผู้ดำเนินกิจการ ขนาด 3 x 4 เซนติเมตร จำนวน 3 รูป(ในกรณีที่ต้องออกใบอนุญาตใหม่)</td>
            </tr>
        </table>
        <table style="width:100%">
            <tr>
                <td style="width:5%"></td>
                <td style="width:95%">(๒) ใบอนุญาตผลิต จำหน่าย นำเข้า หรือส่งออกซึ่งยาเสพติดให้โทษในประเภท 3 หรือใบแทน</td>
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
                <td style="width:50%;text-align:center"></td>
                <td style="width:10%;text-align:right">(ลายมือชื่อ)</td>
                <td style="width:20%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"></td>
                <td style="width:20%;text-align:start">ผู้ยื่นคำขอ</td>
            </tr>
        </table>
        <br />
        <hr />
        <div>หมายเหตุ ให้ขีดฆ่าข้อความที่ไม่ต้องการออก</div>
    </div>
</div>

