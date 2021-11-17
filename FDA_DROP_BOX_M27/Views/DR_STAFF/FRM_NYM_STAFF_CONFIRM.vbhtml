@Code
    ViewData("Title") = "FRM_NYM_STAFF_CONFIRM"
End Code

    <style>
        .title1 {
            width: 150px;
            height: 170px;
            /*background-color: aqua;*/
            text-align: center;
            border: solid;
            float: left;
        }

        .title2 {
            width: 400px;
            height: 120px;
            /*background-color:antiquewhite;*/
            text-align: center;
            border: solid;
            float: right;
        }

        .checkbox {
            width: 20px;
            height: 20px;
            margin-left: 45%;
            margin-top: 5%;
        }

        .hr {
            width: 95%;
            height: 10px;
            background-color: black;
        }

        .datepickerdemoBasicUsage {
            /** Demo styles for mdCalendar. */
        }

            .datepickerdemoBasicUsage md-content {
                padding-bottom: 200px;
            }

            .datepickerdemoBasicUsage .validation-messages {
                font-size: 12px;
                color: #dd2c00;
                margin-left: 15px;
            }
    </style>


<div>
    <div class="content-part">
        <div class="part-2-3">
            <div >
                <div class="in" style="font-family:'Taviraj';width:100%">
                    <div>
                        <p style="text-align:right;font-size:20px">แบบ น.ย.ม.2</p>
                    </div>
                    <div class="container">
                        <div class="row" style="width:100%">
                            <div style="text-align:left;border:solid;width:10%"><img src="..." class="" alt="..."></div>
                            <div>
                                <div style="margin-left:10px;font-size:20px;font-family:'Taviraj'">หมายเหตุ</div>
                                <div style="margin-left:10px;font-size:20px;font-family:'Taviraj'">คำขอนี้เป็นเอกสารอิเล็กทรอนิกส์สามารถตรวจสอบ</div>
                                <div style="margin-left:10px;font-size:20px;font-family:'Taviraj'">เอกสารต้นฉบับได้ตาม QR CODE ที่แสดง</div>
                            </div>
                            <div class="title2" style="margin-left:11%">
                                <table style="font-size:20px;width:95%;margin-top:10px;margin-left:10px">
                                    <tr>
                                        <td style="text-align:left;width:20%">
                                            เลขรับที่
                                        </td>

                                        <td colspan="3" style="border-bottom:dotted;border-bottom-width:thin;"></td>
                                    </tr>
                                    <tr>
                                        <td style="text-align:left">
                                            วันที่
                                        </td>
                                        <td colspan="3" style="border-bottom:dotted;border-bottom-width:thin;"></td>
                                    </tr>
                                    <tr>
                                        <td style="text-align:left">
                                            ลงชื่่อ
                                        </td>
                                        <td style="border-bottom:dotted;border-bottom-width:thin;"></td>
                                        <td style="text-align:right;width:30%">
                                            ผู้รับคำขอ
                                        </td>
                                    </tr>
                                </table>
                            </div>
                        </div>
                    </div>
                    <br />
                    <br />
                    <table width="100%" style="font-family:'Taviraj';font-size:20px">
                        <tr>
                            <td width="20%"></td>
                            <td width="15%"></td>
                            <td width="10%"><input type="checkbox" />&nbsp;<b>แผนปัจจุบัน</b></td>
                            <td></td>
                        </tr>
                        <tr>
                            <td></td>
                            <td width="15%"><b>คำขออนุญาตนำหรือสั่งยา</b></td>
                            <td></td>
                            <td width="30%"><b>เข้ามาในราชอาณาจักรเพื่อการวิเคราะห์</b></td>
                        </tr>
                        <tr>
                            <td></td>
                            <td width="15%"></td>
                            <td><input type="checkbox" />&nbsp;<b>แผนโบราณ</b></td>
                            <td></td>
                        </tr>
                    </table>
                    <hr style="width:40%;border-color:black;text-align:center" />
                    <table width="100%" style="font-family:'Taviraj';font-size:20px">
                        <tr>
                            <td style="text-align:right;width:80%">
                                เขียนที่
                            </td>
                            <td style="border-bottom:dotted;border-bottom-width:thin"></td>
                        </tr>
                        <tr>
                            <td style="text-align:right;width:90px">
                                วันที่
                            </td>
                            <td style="border-bottom:dotted;border-bottom-width:thin"></td>
                        </tr>
                    </table>
                    <br />
                    <table width="100%" style="font-size:20px">
                        <tr>
                            <td width="2%"></td>
                            <td width="5%">ข้าพเจ้า</td>
                            <td style="border-bottom:dotted;border-bottom-width:thin"></td>
                            <td width="5%">ตำแหน่ง</td>
                            <td style="border-bottom:dotted;border-bottom-width:thin"></td>
                        </tr>
                    </table>
                    <table width="100%" style="font-size:20px">
                        <tr>
                            <td width="10%"></td>
                            <td width="10%"><input type="checkbox" />&nbsp;กระทรวง</td>
                            <td width="10%"><input type="checkbox" />&nbsp;ทบวง</td>
                            <td width="10%"><input type="checkbox" />&nbsp;กรม</td>
                        </tr>
                        <tr>
                            <td width="10%">ในนามของ</td>
                            <td><input type="checkbox" />&nbsp;สภากาชาดไทย</td>
                            <td><input type="checkbox" />&nbsp;องค์การเภสัชกรรม</td>
                            <td></td>
                        </tr>
                        <tr>
                            <td></td>
                            <td><input type="checkbox" />&nbsp;ผู้รับอนุญาตผลิตยา</td>
                            <td><input type="checkbox" />&nbsp;ผู้รับอนุญาตนำหรือสั่งยาฯ ณ สถานที่ชื่อ</td>
                            <td></td>
                        </tr>
                    </table>
                    <table width="100%" style="font-size:20px">
                        <tr>
                            <td width="5%"></td>
                            <td style="border-bottom:dotted;border-bottom-width:thin"></td>
                            <td width="10%">ใบอนุญาตเลขที่</td>
                            <td style="border-bottom:dotted;border-bottom-width:thin"></td>
                        </tr>
                    </table>
                    <table width="100%" style="font-size:20px">
                        <tr>
                            <td width="5%">อยู่เลขที่</td>
                            <td style="border-bottom:dotted;border-bottom-width:thin"></td>
                        </tr>
                        <tr>
                            <td width="5%">โทรศัพท์</td>
                            <td style="border-bottom:dotted;border-bottom-width:thin"></td>
                        </tr>
                    </table>
                    <table width="100%" style="font-size:20px">
                        <tr>
                            <td width="25%">มีความประสงค์จะขออนุญาตนำหรือสั่งยาชื่อ</td>
                            <td style="border-bottom:dotted;border-bottom-width:thin"></td>
                        </tr>
                    </table>
                    <table width="100%" style="font-size:20px">
                        <tr>
                            <td width="5%">จำนวน</td>
                            <td width="40%" style="border-bottom:dotted;border-bottom-width:thin"></td>
                            <td>เข้ามาในราชอาณาจักรเพื่อการวิเคราะห์</td>
                        </tr>
                    </table>
                    <br />
                    <div style="font-size:20px;font-family:'Taviraj';text-align:center"><b>รายละเอียดของยาที่นำหรือสั่งเข้ามาในราชอาณาจักร</b></div>
                    <div style="font-size:20px;font-family:'Taviraj';text-align:center">ปริมาณของวัตถุส่วนประกอบของยาต้องแจ้งเป็นมาตราเมตริกหรือเป็นร้อยละใน 1 หน่วย</div>
                    <div style="font-size:20px;font-family:'Taviraj';text-align:center;border-bottom:dotted;border-bottom-width:thin">ดูเอกสารแนบท้าย</div>
                    <div style="font-size:20px;font-family:'Taviraj';text-align:center"><b>ขนาดบรรจุ</b></div>
                    <div style="font-size:20px;font-family:'Taviraj';text-align:center">ดูเอกสารแนบท้าย</div>
                    <div style="font-size:20px;font-family:'Taviraj';text-align:center"><b>รายละเอียดของยาที่นำหรือสั่งเข้ามาในราชอาณาจักร</b></div>
                    <div style="font-size:20px;font-family:'Taviraj';text-align:center;border-bottom:dotted;border-bottom-width:thin">ดูเอกสารแนบท้าย</div>
                    <br />
                    <div style="font-size:20px;font-family:'Taviraj'">ข้าพเจ้าได้แนบหลักฐานมาด้วย จำนวน 2 ชุด คือ</div>
                    <div style="font-size:20px;font-family:'Taviraj'">1. ฉลากทุกขนาดบรรจุ</div>
                    <div style="font-size:20px;font-family:'Taviraj'">2. เอกสารกำกับยา</div>
                    <div style="font-size:20px;font-family:'Taviraj'">3. วิธีวิเคราะห์</div>
                    <br />
                    <div class="container">
                        <div class="row">
                            <table style="font-family:'Taviraj';font-size:20px;float:left" width="50%">
                                <tr>
                                    <td style="text-align:center" width="30%"><input type="checkbox" />&nbsp;อนุญาต</td>
                                    <td><input type="checkbox" />&nbsp;ไม่อนุญาต</td>
                                </tr>
                            </table>
                            <table style="font-family:'Taviraj';font-size:20px;float:right" width="50%">
                                <tr>
                                    <td width="20%"><b>&nbsp;</b></td>
                                    <td></td>
                                </tr>
                            </table>
                            <table style="font-family:'Taviraj';font-size:20px;float:left" width="50%">
                                <tr>
                                    <td width="20%"><b>เงื่อนไข/เหตุผล</b></td>
                                    <td width="60%" style="border-bottom:dotted;border-bottom-width:thin;text-align:center">ดูเอกสารแนบท้าย</td>
                                    <td></td>
                                </tr>
                            </table>
                            <table style="font-family:'Taviraj';font-size:20px;float:right" width="50%">
                                <tr>
                                    <td width="15%"><b></b></td>
                                    <td width="60%" style="border-bottom:dotted;border-bottom-width:thin"></td>
                                    <td><b>โดย</b></td>
                                </tr>
                            </table>
                        </div>
                    </div>
                    <div class="container">
                        <div class="row">
                            <table style="font-family:'Taviraj';font-size:20px;float:left" width="50%">
                                <tr>
                                    <td width="15%"><b>(ลายมือชื่อ)</b></td>
                                    <td width="60%" style="border-bottom:dotted;border-bottom-width:thin"></td>
                                    <td><b>ผู้อนุมัติ</b></td>
                                </tr>
                            </table>
                            <table style="font-family:'Taviraj';font-size:20px;float:right" width="50%">
                                <tr>
                                    <td width="15%"><b>(ลายมือชื่อ)</b></td>
                                    <td width="60%" style="border-bottom:dotted;border-bottom-width:thin"></td>
                                    <td><b>ผู้ยื่นคำขอ</b></td>
                                </tr>
                            </table>
                            <table style="font-family:'Taviraj';font-size:20px;float:left" width="50%">
                                <tr>
                                    <td style="text-align:center"><b>ปฏิบัติราชการแทน เลขาธิการคณะกรรมการอาหารและยา</b></td>
                                    <td></td>
                                </tr>
                            </table>
                            <table style="font-family:'Taviraj';font-size:20px;float:right" width="50%">
                                <tr>
                                    <td width="15%" style="text-align:right">(</td>
                                    <td width="60%" style="border-bottom:dotted;border-bottom-width:thin"></td>
                                    <td>)</td>
                                </tr>
                            </table>
                            <table style="font-family:'Taviraj';font-size:20px;float:left" width="50%">
                                <tr>
                                    <td width="5%"><b>วันที่</b></td>
                                    <td width="60%" style="border-bottom:dotted;border-bottom-width:thin"></td>
                                </tr>
                            </table>
                        </div>
                    </div>
                    <hr style="width:100%;border-color:black" />
                    <div style="font-size:20px;font-family:'Taviraj'"><b>หมายเหตุ:-</b><span style="padding-left:2em">ใส่เครื่องหมาย ✓ ในช่อง ☐ หน้าข้อความที่ต้องการ</span></div>
                    <br />
                    <br />
                </div>
                <div class="in">
                    <br />
                    <br />
                    <div style="font-family:'Taviraj';width:100%">
                        <div style="font-size:20px;font-family:'Taviraj';text-align:center"><b>เงื่อนไข/เหตุผลประกอบการอนุญาต/ไม่อนุญาต (ถ้ามี)</b></div>
                        <br />
                        <div style="font-size:20px;font-family:'Taviraj';text-align:center;border-bottom:dotted;border-bottom-width:thin"></div>
                        <div style="font-size:20px;font-family:'Taviraj';text-align:center"><b>รายละเอียดของยาที่นำหรือสั่งเข้ามาในราชอาณาจักร</b></div>
                        <div style="font-size:20px;font-family:'Taviraj'">ลักษณะสีของยา (เฉพาะยาเม็ดแคปซูล)</div>
                        <br />
                        <div style="font-size:20px;font-family:'Taviraj';text-align:center;border-bottom:dotted;border-bottom-width:thin"></div>
                        <div style="font-size:20px;font-family:'Taviraj';text-align:center"><b>รายละเอียดของยาที่นำหรือสั่งเข้ามาในราชอาณาจักร</b></div>
                        <div style="font-size:18px;font-family:'Taviraj';text-align:center">ปริมาณของวัตถุส่วนประกอบของยาต้องแจ้งเป็นมาตราเมตริกหรือเป็นร้อยละใน 1 หน่วย</div>
                        <br />
                        <div style="font-family:'Taviraj';width:100%">
                            <table style="font-family:'Taviraj';font-size:20px;float:left" width="50%">
                                <tr>
                                    <td width="5%"><b>Each</b></td>
                                    <td width="60%" style="border-bottom:dotted;border-bottom-width:thin"></td>
                                    <td><b>Contains</b></td>
                                </tr>
                            </table>
                            <br />
                            <br />
                            <div class="row">
                                <div class="col-sm-12" style="width:100%">
                                    <div class="card" style="border-top:10px solid #F9D027">
                                        <table class="table table-condensed" style="width:100%;font-family:'Taviraj';font-size:20px">
                                            <thead>
                                                <tr>
                                                    <th width="5%" style="text-align:center">ลำดับ</th>
                                                    <th width="25%" style="text-align:center">ชื่อสามัญ/ชื่อวัตถุ</th>
                                                    <th width="10%" style="text-align:center">ปริมาณ</th>
                                                    <th width="10%" style="text-align:center">หน่วย</th>
                                                    <th width="10%" style="text-align:center">ประเภท</th>
                                                </tr>
                                            </thead>
                                            <tbody>
                                                <tr>
                                                    <td></td>
                                                    <td></td>
                                                    <td></td>
                                                    <td></td>
                                                    <td></td>
                                                </tr>
                                            </tbody>
                                            <tfoot></tfoot>
                                        </table>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <br />
                        <div style="font-size:20px;font-family:'Taviraj';text-align:center"><b>ขนาดบรรจุ แบบ SKU</b></div>
                        <div style="font-size:18px;font-family:'Taviraj';text-align:center">(รายละเอียดของการบรรจุ)</div>
                        <br />
                        <div style="font-size:20px;font-family:'Taviraj';text-align:center;border-bottom:dotted;border-bottom-width:thin"></div>
                        <div style="font-size:20px;font-family:'Taviraj';text-align:center"><b>ขนาดบรรจุแบบคำบรรยาย</b></div>
                        <br />
                        <div style="font-size:20px;font-family:'Taviraj';text-align:center;border-bottom:dotted;border-bottom-width:thin"></div>
                        <br />
                        <br />
                    </div>
                </div>
                <div class="in">
                    <div style="font-family:'Taviraj';width:100%">
                        <center>
                            <h2>ข้อมูลสถานที่ผลิต</h2>
                        </center>
                        <table width="100%" style="font-size:20px">
                            <tr>
                                <td width="5%">หน้าที่:</td>
                                <td style="border-bottom:dotted;border-bottom-width:thin"></td>
                            </tr>
                            <tr>
                                <td width="5%">ชื่อ:</td>
                                <td style="border-bottom:dotted;border-bottom-width:thin"></td>
                            </tr>
                            <tr>
                                <td width="5%">อยู่เลขที่:</td>
                                <td style="border-bottom:dotted;border-bottom-width:thin"></td>
                            </tr>
                            <tr>
                                <td width="5%">ประเทศ:</td>
                                <td style="border-bottom:dotted;border-bottom-width:thin"></td>
                            </tr>
                            <tr>
                                <td width="5%">โทรศัพท์:</td>
                                <td style="border-bottom:dotted;border-bottom-width:thin"></td>
                            </tr>
                        </table>
                    </div>
                </div>
            </div>
        </div>
        <br />
        <div class="part part-1-3 ic">
            <div class="card">
                <table class="table">
                    <tr>
                        <td>สถานะ :</td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>ชื่อผู้ลงนาม :</td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>วันที่เสนอลงนาม :</td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>วันที่คาดว่าจะอนุมัติ :</td>
                        <td></td>
                    </tr>
                </table>
                <br />
                <div>
                    โปรดเลือกสถานะถัดไป
                </div>
                <div style="width:80%;margin-left:10%">
                    <select class="form-control">
                        <option></option>
                    </select>
                </div>
                <br />
                <div>
                    วันที่รับ/อนุมัติ
                </div>
                <div style="width:80%;margin-left:10%">
                    <md-datepicker ng-model="APP_DATE" md-placeholder="Enter date"
                                   input-aria-describedby="datepicker-description"
                                   input-aria-labelledby="datepicker-header ">
                    </md-datepicker>
                </div>
                <br />
                <div >
                    เงื่อนไข/เหตุผลประกอบการอนุญาต/ไม่อนุญาต
                </div>
                <div style="width:80%;margin-left:10%">
                    <textarea class="form-control" style="height:120px"></textarea>
                </div>
                <br />
                <div class="col-sm-12" style="text-align:center">
                    <input type="button" style="width:90%" class="btn btn-lg " value="ยืนยัน" />
                </div>
                <br />
                <div class="col-sm-12" style="text-align:center">
                    <input type="button" style="width:90%" class="btn btn-lg " value="ยกเลิก" />
                </div>
                <br />
                <div class="col-sm-12" style="text-align:center">
                    <input type="button" style="width:90%" class="btn btn-lg " value="Download PDF" />
                </div>
                <br />
                <div class="col-sm-12" style="text-align:center">
                    <input type="button" style="width:90%" class="btn btn-lg " value="กลับหน้ารายการ" />
                </div>
            </div>
        </div>
    </div>
</div>

