﻿@Code
    ViewData("Title") = "PDF_DRUG_YORBOR16"
    Layout = ""
End Code

<div class="ic">
    <div style="font-family:'Taviraj';font-size:20px;">
        <div>
            <p style="text-align: right;">แบบ ย.บ.๑๖</p>
        </div>
        <table style="width:100%">
            <tr>
                <td style="width:35%"></td>
                <td style="width:35%"></td>
                <td style="width:5%;text-align:right">เลขที่:</td>
                <td style=" width:25%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"></td>
            </tr>
        </table>
        <table style="width:100%">
            <tr>
                <td style="width:35%"></td>
                <td style="width:35%"></td>
                <td style="width:5%;text-align:right">วันที่:</td>
                <td style=" width:25%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"></td>
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
        <br />
        <table style="width:100%">
            <tr>
                <td style="text-align:center">คำขอแก้ไขเปลี่ยนแปลงรายการในใบอนุญาต</td>
            </tr>
        </table>
        <table style="width:100%">
            <tr>
                <td style="width:50%"></td>
                <td style="text-align:start"> <input type="checkbox" /> ผลิตยาแผนโบราณ</td>
            <tr>
                <td style="width:50%"></td>
                <td style=";text-align:start"> <input type="checkbox" /> ขายยาแผนโบราณ</td>
            <tr>
                <td style="width:50%"></td>
                <td style="width:50%;text-align:start"> <input type="checkbox" /> นำหรือสั่งยาแผนโบราณเข้ามาในราชอาณาจักร</td>
            </tr>
        </table>
        <hr />
        <table style="width:100%">
            <tr>
                <td style="width:70%"></td>
                <td style="width:5%;text-align:right">เขียนที่</td>
                <td style="width:25%"></td>
            </tr>
        </table>
        <table>
            <tr>
                <md-datepicker ng-model="datas.MFD_DATE" md-placeholder="Enter date"
                               input-aria-describedby="datepicker-description"
                               input-aria-labelledby="datepicker-header "></md-datepicker>
            </tr>
        </table>
        <br />
        <table style="width:100%">
            <tr>
                <td style="width:10%;text-align:right">ข้าพเจ้า :</td>
                <td style="width:30%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"></td>
                <td style="width:15%;text-align:right">ซึ่งมีผู้ดำเนินกิจการ ชื่อ :</td>
                <td style="width:35%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"></td>
            </tr>
        </table>
        <table style="width:100%">
            <tr>
                <td style="width:10%;"></td>
                <td style="width:35%;text-align:center">ได้รับอนุญาตให้</td>
                <td> <input type="checkbox" /> ผลิตยาแผนโบราณ</td>
                <td> <input type="checkbox" /> ขายยาแผนโบราณ</td>
            </tr>
        </table>
        <table style="width:100%">
            <tr>
                <td style="width:40%"> <input type="checkbox" /> นำหรือสั่งยาแผนโบราณเข้ามาในราชอาณาจักร</td>
                <td style="width:15%;text-align:right">ตามใบอนุญาตที่ ชื่อ</td>
                <td style="width:85%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"></td>
            </tr>
        </table>
        <table style="width:100%">
            <tr>
                <td style="width:15%;">ณ สถานที่ประกอบธุรกิจ ชื่อ</td>
                <td style="width:85%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"></td>
            </tr>
        </table>
        <table style="width:100%">
            <tr>
                <td style="width:5%;">อยู่เลขที่</td>
                <td style="width:95%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"></td>
            </tr>
        </table>
        <table style="width:100%">
            <tr>
                <td style="width:18%;">โทรศัพท์</td>
                <td style="width:82%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"></td>
            </tr>
        </table>
        <td>ขอเปลี่ยนแปลงรายการในใบอนุญาต ดังต่อไปนี้</td>
        <table>
            <tr>
                <td width="100%"> <input type="text" /></td>
            </tr>
        </table>
        <br />
        @*<table>
            <tr>
                <td>ข้าพเจ้าได้แนบหลักฐานมาด้วย คือ</td>
            <tr>
                <td>&nbsp;&nbsp;&nbsp;&nbsp; (๑) ใบอนุญาตประกอบธุรกจเกี่ยวกับยาแผนโบราณหรือใบแทน</td>
            <tr>
                <td>&nbsp;&nbsp;&nbsp;&nbsp; (๒) เอกสารที่เป็นหลักฐานเกี่ยวข้องกับรายการที่ขอเปลี่ยนแปลง</td>
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
                <td style="width:20%;text-align:center"></td>
                <td style="width:20%;text-align:start">ผู้ยื่นคำขอ</td>
            </tr>
        </table>
        <table style="width:100%">
            <tr>
                <td style="width:50%;text-align:center"></td>
                <td style="width:10%;text-align:right">(ลายมือชื่อ)</td>
                <td style="width:20%;text-align:center"></td>
                <td style="width:20%;text-align:start">ผู้มีหน้าที่ปฏิบัติการ</td>
            </tr>
        </table>
        <hr />
        <div>หมายเหตุ : &nbsp;ใส่เครื่องหมาย &#10004; ในช่อง [  ] หน้าข้อความที่ต้องการ</div>
    </div>
</div>

