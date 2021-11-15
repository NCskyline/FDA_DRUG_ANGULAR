﻿@Code
    ViewData("Title") = "FRM_EXTEND_STAFF_CONFIRM"
End Code

<div>
    <div class="content-part">
        <div class="part part-2-3">
            <div style="font-family:'Taviraj';font-size:20px;">
                <div>
                    <p style="text-align: right;">แบบ ข.ย.๑๕</p>
                </div>
                <table style="width:100%">
                    <tr>
                        <td style="width:35%"></td>
                        <td style="width:35%"></td>
                        <td style="width:5%;text-align:right">เลขที่:</td>
                        <td style=" width:25%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"> <label>{{LCN_LIST.RCVNO_DISPLAY}}</label></td>
                    </tr>
                </table>
                <table style="width:100%">
                    <tr>
                        <td style="width:35%"></td>
                        <td style="width:35%"></td>
                        <td style="width:5%;text-align:right">วันที่:</td>
                        <td style=" width:25%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"><label>{{LCN_LIST.RCV_DATE_DISPLAY}}</label></td>
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
                <hr />
                <div> <h3 style="text-align:center">คำขอต่ออายุใบอนุญาต</h3></div>
                <div style="padding-left:45%;">
                    <p style="text-align:left">
                        <label><input type="checkbox" disabled />ขายยาแผนปัจจุบัน </label>
                        <br /> <label>
                            <input type="checkbox" disabled />ขายส่งยาแผนปัจจุบัน
                        </label>
                        <br /> <label>
                            <input type="checkbox" disabled />ขายยาแผนปัจจุบันเฉพาะยาบรรจุเสร็จที่ไม่ใช่ยาอันตรายหรือยาควบคุมพิเศษ
                        </label>
                        <br /> <label><input type="checkbox" disabled />ขายยาแผนปัจจุบันเฉพาะยาบรรจุเสร็จสำหรับสัตว์</label>
                </div>
                <hr />
                <table style="width:100%; font-size:20px">
                    <tr>
                        <td style="text-align:right;width:90%">
                            เขียนที่
                        </td>
                        <td style="width:40%">
                            <input class="form-control inline" ng-model="LIST_LCN.dalcn.WRITE_AT" style="font-family:'Taviraj';font-size:20px;" type="text" />
                        </td>
                    </tr>
                    <tr>
                        <td style="text-align:right;width:100px">
                            วันที่
                        </td>
                        <td>
                            <md-datepicker ng-model="LIST_LCN.dalcn.WRITE_DATE" md-placeholder="Enter date"
                                           input-aria-describedby="datepicker-description"
                                           input-aria-labelledby="datepicker-header ">
                            </md-datepicker>
                        </td>
                    </tr>
                </table>
                <br />
                <table style="width:100%">
                    <tr>
                        <td style="width:10%;text-align:right">ข้าพเจ้า :</td>
                        <td style="width:90%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"></td>
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
                        <td style="width:74%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"></td>
                        <td style="width:13%;">(เฉพาะกรณีนิติบุคคล)</td>
                    </tr>
                </table>
                <table style="width:100%">
                    <tr>
                        <td style="width:13%;">เลขที่บัตรประชาชน</td>
                        <td style="width:50%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"></td>
                        <td style="width:13%;">ได้รับอนุญาตให้ขายยา</td>
                        <td style="width:24%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"></td>
                    </tr>
                </table>
                <table style="width:100%">
                    <tr>
                        <td style="width:13%;">ใบอนุญาตเลขที่</td>
                        <td style="width:87%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"></td>
                    <tr />
                    <tr>
                        <td style="width:13%;">ณ สถานที่ขายยาชื่อ</td>
                        <td style="width:87%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"></td>
                    </tr>
                </table>
                <table style="width:100%">
                    <tr>
                        <td style="width:10%;">ตั้งอยู่เลขที่</td>
                        <td style="width:90%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"></td>
                    </tr>
                </table>
                <table style="width:100%">
                    <tr>
                        <td style="width:13%;">โทรศัพท์/โทรศัพท์มือถือ</td>
                        <td style="width:87%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"></td>
                    </tr>
                </table>
                <table style="width:100%">
                    <tr>
                        <td style="width:30%"> ขอต่ออายุใบอนุญาตดังกล่าว เพื่อใช้ต่อไปในปี พ.ศ.</td>
                        <td style="width:20%;border-bottom:dotted;border-bottom-width:thin;"> </td>
                    </tr>
                </table>
                <br />
                <table style="width:100%">
                    <tr>
                        <td style="width:5%">
                        <td style="width:95%">ข้าพเจ้าเป็นผู้มีคุณสมบัติครบถ้วนตามมาตรา ๑๔ ของพระราชบัญญัติยา พ.ศ. ๒๕๑๐ ซึ่งไม่เป็นบุคคลล้มละลายและข้าพเจ้าได้แนบหลักฐานมาด้วย คือ </td>
                    </tr>
                </table>
                @*<table style="width:100%">
                <tr>
                    <td style="width:5%"></td>
                    <td style="width:95%">(๑) ใบรับรองของผู้ประกอบวิชาชีพเวชกรรมผู้ประกอบวิชาชีพเวชกรรมซึ่งรับรองว่าผู้รับอนุญาตหรือผู้ดำเนินกิจการสุขภาพแข็งแรงและ ไม่เป็นโรคตามมาตรา ๑๔ (๖) แห่งพระราชบัญญัติยา พ.ศ. ๒๕๑๐</td>
                </tr>
            </table>
            <table style="width:100%">
                <tr>
                    <td style="width:5%"></td>
                    <td style="width:95%">(๒) ใบรับรองของผู้ประกอบวิชาชีพเวชกรรมผู้ประกอบวิชาชีพเวชกรรมซึ่งรับรองว่าผู้มีหน้าที่ปฏิบัติการมีสุขภาพแข็งแรงสามารถประกอบวิชาชีพได้</td>
                </tr>
            </table>
            <table style="width:100%">
                <tr>
                    <td style="width:5%"></td>
                    <td style="width:95%">(๓) ใบอนุญาตประกอบธุรกิจเกี่ยวกับยาแผนปัจจุบันหรือใบแทน</td>
                </tr>
            </table>
            <table style="width:100%">
                <tr>
                    <td style="width:5%"></td>
                    <td style="width:95%">(๔) เอกสารแสดงว่าผู้ดำเนินกิจการซึ่งเป็นผู้แทนหรือผู้จัดการนิติบุคคลของนิติบุคคล (กรณีนิติบุคคลเป็นผู้ขออนุญาต)</td>
                </tr>
            </table>
            <table style="width:100%">
                <tr>
                    <td style="width:5%"></td>
                    <td style="width:95%">(๕) สำเนาทะเบียนบ้านของผู้รับอนุญาต</td>
                </tr>
            </table>
            <table style="width:100%">
                <tr>
                    <td style="width:5%"></td>
                    <td style="width:95%">(๖) คำรับรองตามแบบ ข.ย. ๑๔ พร้อมเอกสารประกอบ</td>
                </tr>
            </table>
            <table style="width:100%">
                <tr>
                    <td style="width:5%"></td>
                    <td style="width:95%">(๗) ผลการตรวจประเมินวิธีปฏิบัติทางเภสัชกรรมชุมชน</td>
                </tr>
            </table>
            <table style="width:100%">
                <tr>
                    <td style="width:5%"></td>
                    <td style="width:95%">(๘) เอกสารอื่น ๆ (ถ้าจำเป็น)</td>
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
                        <td style="width:20%;text-align:start">ผู้คำขอ</td>
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
                <hr />
                <div>หมายเหตุ :- &nbsp; ใส่เครื่องหมาย &#10004; ในช่อง [  ] หน้าข้อความที่ต้องการ</div>
            </div>
        </div>
        <div class="part part-1-3">
            <div style="width:80%;margin-left:10%">
                <table class="table">
                    @*<tr>
                        <td>โปรดเลือกกระบวนงานที่ท่านต้องการยื่น</td>
                    </tr>*@
                    <tr>
                        <td>
                            <select class="form-control">
                                <option>อนุมัติคำขอ</option>
                                <option>คืนคำขอ</option>
                            </select>
                        </td>
                    </tr>
                </table>
                <br />
                <div class="col-sm-12" style="text-align:center;width:60%;margin-left:20%">
                    <input type="button" class="form-control" value="ยืนยัน" />
                </div>
                <br />
                <div class="col-sm-12" style="text-align:center;width:60%;margin-left:20%" ">
                    <input type="button" class="form-control" value="ยกเลิก" />
                </div>
                <br />
                <div class="col-sm-12" style="text-align:center;width:60%;margin-left:20%" ">
                    <input type="button" class="form-control" value="Download PDF" />
                </div>
                <br />
                <div class="col-sm-12" style="text-align:center;width:60%;margin-left:20%" ">
                    <input type="button" class="form-control" ng-click="BTN_BACK()" value="กลับหน้ารายการ" />
                </div>
            </div>
        </div>
    </div>
</div>

