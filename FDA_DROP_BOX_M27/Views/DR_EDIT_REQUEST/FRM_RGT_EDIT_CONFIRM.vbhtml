@Code
    ViewData("Title") = "FRM_RGT_EDIT_CONFIRM"
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

    <script src="~/Scripts_angular/ANGULAR_APP.js"></script>
    <script src="~/Scripts_angular/CENTER_SV.js"></script>
    <script src="~/Scripts_angular/DR_CTRL.js"></script>

    <div ng-app="ANGULAR_APP" ng-controller="DR_CTRL">
        <div class="content-part">
            <div class="part part-2-3">
                <div style="font-family:'Taviraj';font-size:24px;width:100%">
                    <div>
                        <p style="font-family:'Taviraj';font-size:20px;text-align:right">แบบ ย. ๕</p>
                        <p style="font-family:'Taviraj';font-size:20px;text-align:right">FORM MA-5</p>
                    </div>
                    <br />
                    <div class="title2">
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
                    <br />
                    <br />
                    <br />
                    <br />
                    <h1 style="text-align:center;font-family:'Taviraj';font-size:24px;">
                        <strong>คำขอแก้ไขเปลี่ยนแปลงรายการในทะเบียนตำรับยา</strong>
                    </h1>
                    <br />
                    <table width="100%" style="font-family:'Taviraj';font-size:20px">
                        <tr>
                            <td>ข้าพเจ้า</td>
                            <td width="65%" style="border-bottom:dotted;border-bottom-width:thin"></td>
                            <td>ผู้รับอนุญาต/ผู้ดำเนินการ ตามใบอนุญาต</td>
                        </tr>
                    </table>
                    <table width="100%" style="font-family:'Taviraj';font-size:20px">
                        <tr>
                            <td width="20%"></td>
                            <td>
                                <input type="radio" value="1" checked />&nbsp;&nbsp;ผลิตยา
                            </td>
                            <td width="2%"></td>
                            <td>
                                <input type="radio" value="2" />&nbsp;&nbsp;นำเข้าหรือสั่งยาเข้ามาในราชอาณาจักร
                            </td>
                        </tr>
                        <tr>
                            <td width="20%"></td>
                            <td>
                                <input type="radio" value="3" />&nbsp;&nbsp;แผนปัจจุบัน
                            </td>
                            <td width="2%"></td>
                            <td>
                                <input type="radio" value="4" />&nbsp;&nbsp;แผนโบราณ
                            </td>
                        </tr>
                    </table>
                    <table width="100%" style="font-family:'Taviraj';font-size:20px">
                        <tr>
                            <td>ใบอนุญาตเลขที่</td>
                            <td width="30%" style="border-bottom:dotted;border-bottom-width:thin"></td>
                            <td>ในนาม บริษัท/ห้าง/ร้าน</td>
                            <td width="40%" style="border-bottom:dotted;border-bottom-width:thin"></td>
                        </tr>
                    </table>
                    <table width="100%" style="font-family:'Taviraj';font-size:20px">
                        <tr>
                            <td>ขอแก้ไขเปลี่ยนแปลงรายการในทะเบียนตำรับยาชื่อ</td>
                            <td width="60%" style="border-bottom:dotted;border-bottom-width:thin"></td>
                        </tr>
                    </table>
                    <table width="100%" style="font-family:'Taviraj';font-size:20px">
                        <tr>
                            <td>เลขทะเบียนที่</td>
                            <td width="30%" style="border-bottom:dotted;border-bottom-width:thin"></td>
                            <td>รายการที่ขอแก้ไขเปลี่ยนแปลง (ระบุ)</td>
                            <td width="30%" style="border-bottom:dotted;border-bottom-width:thin;text-align:center">(ตามเอกสารแนบท้าย)</td>
                        </tr>
                    </table>
                    <div style="font-size:20px;font-family:'Taviraj';margin-left:10%">ข้าพเจ้าได้แนบเอกสารหรือหลักฐานตามที่สำนักงานคณะกรรมการอาหารและยาประกาศกำหนดมาพร้อมนี้</div>
                    <div style="font-size:20px;font-family:'Taviraj';">และขอรับรองว่าข้อความอื่นใดที่ไม่ได้ระบุไว้ในคำขอฉบับนี้เหมือนเดิมทุกประการและขอยกเลิกรายการเดิมในทะเบียนตำรับยา</div>
                    <div style="font-size:20px;font-family:'Taviraj';">ตั้งแต่วันที่ได้รับอนุญาตให้แก้ไขเปลี่ยนแปลงรายการดังกล่าวในทะเบียนตำรับยา เว้นแต่พนักงานเจ้าหน้าที่จะมีคำสั่งเป็นอย่างอื่น</div>
                    <br />
                    <br />
                    <table style="font-size:20px;font-family:'Taviraj';width:50%;float:right">
                        <tr>
                            <td>
                                (ลายมือชื่อ)
                            </td>
                            <td style="width:30%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"></td>
                            <td style="text-align:left">
                                ผู้รับอนุญาต
                            </td>
                        </tr>
                        <tr>
                            <td style="text-align:right">
                                (
                            </td>
                            <td style="width:40%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"></td>
                            <td style="text-align:left">
                                )
                            </td>
                        </tr>
                        <tr>
                            <td>
                                (ลายมือชื่อ)
                            </td>
                            <td style="width:50%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"></td>
                            <td style="text-align:left">
                                ผู้มีหน้าที่ปฏิบัติการ
                            </td>
                        </tr>
                        <tr>
                            <td style="text-align:right">
                                (
                            </td>
                            <td style="width:55%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"></td>
                            <td style="text-align:left">
                                )
                            </td>
                        </tr>
                    </table>
                    <br />
                    <br />
                    <br />
                    <br />
                    <div style="font-size:20px;font-family:'Taviraj';">(ยื่นแบบคำขอพร้อมสำเนาคู่ฉบับ)</div>
                    <hr style="width:100%;border-color:black" />
                    <div style="font-size:20px;font-family:'Taviraj';">(ส่วนนี้สำหรับเจ้าหน้าที่)</div>
                    <br />
                    <div style="font-size:20px">คำสั่งเจ้าหน้าที่พนักงาน</div>
                    <table width="100%" style="font-family:'Taviraj';font-size:20px;margin-left:5%">
                        <tr>
                            <td width="20%">
                                <input type="checkbox" />&nbsp;&nbsp;อนุญาต
                            </td>
                            <td></td>
                        </tr>
                        <tr>
                            <td width="20%">
                                <input type="checkbox" />&nbsp;&nbsp;ไม่อนุญาต เนื่องจาก
                            </td>
                            <td>
                                <input class="form-control inline" style="font-family:'Taviraj';font-size:20px" type="text" />
                            </td>
                        </tr>
                        <tr>
                            <td width="20%">
                                <input type="checkbox" />&nbsp;&nbsp;คำสั่งอื่น
                            </td>
                            <td>
                                <input class="form-control inline" style="font-family:'Taviraj';font-size:20px" type="text" />
                            </td>
                        </tr>
                    </table>
                    <br />
                    <table style="font-size:20px;font-family:'Taviraj';width:50%;float:right">
                        <tr>
                            <td width="5%"></td>
                            <td align="right">
                                (ลายมือชื่อ)
                            </td>
                            <td style="width:60%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"></td>
                        </tr>
                        <tr>
                            <td width="5%"></td>
                            <td align="right">
                                ตำแหน่ง
                            </td>
                            <td style="width:60%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"></td>
                        </tr>
                    </table>
                    <br />
                    <br />
                    <br />
                    <div style="font-size:20px;margin-left:75%;font-family:'Taviraj';">พนักงานเจ้าหน้าที่</div>
                    <table style="font-size:20px;font-family:'Taviraj';width:50%;float:right">
                        <tr>
                            <td width="5%"></td>
                            <td align="right">
                                ลงวันที่
                            </td>
                            <td style="width:60%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"></td>
                        </tr>
                    </table>
                </div>
                <br />
                <br />
                <br />
                <hr style="width:100%;border-color:black" />
                <br />
                <div style="font-family:'Taviraj';font-size:24px;width:100%">
                    <div>
                        <p style="font-family:'Taviraj';font-size:20px;text-align:right">แบบ ย. ๕ หน้า ๒</p>
                    </div>
                    <h1 style="text-align:center;font-family:'Taviraj';font-size:24px;">
                        <strong>รายละเอียดการแก้ไขเปลี่ยนแปลงรายการในทะเบียนตำรับยา</strong>
                    </h1>
                    <br />
                    <div style="font-family:'Taviraj';font-size:24px;width:100%">
                        <table width="100%" style="font-family:'Taviraj';font-size:20px">
                            <tr>
                                <td>
                                    <ul class="list-tree">
                                        <li>
                                            <div>การแก้ไขเปลี่ยนแปลงรายการในทะเบียนตำรับยาตามแบบ ย. ๕ เลขที่รับ</div>
                                        </li>
                                    </ul>
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;width:45%"></td>
                            </tr>
                        </table>
                        <table width="100%" style="font-family:'Taviraj';font-size:20px">
                            <tr>
                                <td>ชื่อยา</td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;width:40%"></td>
                                <td>เลขทะเบียนที่</td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;width:45%"></td>
                            </tr>
                        </table>
                        <br />
                        <div style="font-size:20px;font-family:'Taviraj';margin-left:5%">รายการที่ขอแก้ไขเปลี่ยนแปลง</div>
                        <table width="100%" style="font-family:'Taviraj';font-size:20px;margin-left:10%">
                            <tr>
                                <td><input type="checkbox" />&nbsp;&nbsp;ฉลาก</td>
                            </tr>
                            <tr>
                                <td><input type="checkbox" />&nbsp;&nbsp;เอกสารกำกับยา</td>
                            </tr>
                            <tr>
                                <td><input type="checkbox" />&nbsp;&nbsp;ขนาดบรรจุ</td>
                            </tr>
                            <tr>
                                <td><input type="checkbox" />&nbsp;&nbsp;ชื่อยา</td>
                            </tr>
                            <tr>
                                <td><input type="checkbox" />&nbsp;&nbsp;ลักษณะยา</td>
                            </tr>
                            <tr>
                                <td><input type="checkbox" />&nbsp;&nbsp;สูตรยา (แสดงรายละเอียดการแก้ไขเปลี่ยนแปลงสูตรตำรับยา)</td>
                            </tr>
                            <tr>
                                <td>
                                    <input type="checkbox" />&nbsp;&nbsp;วิธีวิเคราะห์และข้อกำหนดมาตรฐาน<br />
                                    <span style="padding-left:1em">(แสดงรายละเอียดการแก้ไขเปลี่ยนแปลงวิธีวิเคราะห์และข้อกำหนดมาตรฐาน)</span>
                                </td>
                            </tr>
                        </table>
                        <br />
                        <table width="100%" style="font-family:'Taviraj';font-size:20px">
                            <tr>
                                <td>
                                    <ul class="list-tree">
                                        <li>
                                            <div>ขอแก้ไขเปลี่ยนแปลงจาก</div>
                                        </li>
                                    </ul>
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;width:78%"></td>
                            </tr>
                        </table>
                        <table width="100%" style="font-family:'Taviraj';font-size:20px;margin-left:4%">
                            <tr>
                                <td>ที่เคยอนุมัติไว้</td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;width:90%"></td>
                            </tr>
                            <tr>
                                <td>เป็น</td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;width:90%"></td>
                            </tr>
                        </table>
                        <table width="100%" style="font-family:'Taviraj';font-size:20px;margin-left:4%">
                            <tr>
                                <td>เป็นการขอแก้ไขเปลี่ยนแปลง</td>
                            </tr>
                        </table>
                        <table width="100%" style="font-family:'Taviraj';font-size:20px;margin-left:4%">
                            <tr>
                                <td><span style="padding-left:2em"><input type="checkbox" />&nbsp;&nbsp;ยาแผนปัจจุบัน</span></td>
                            </tr>
                            <tr>
                                <td><span style="padding-left:4em"><input type="checkbox" />&nbsp;&nbsp;ตาม ASEAN Variation Guideline(AVG)</span></td>
                                <td><span style="padding-left:1em"><input type="checkbox" />&nbsp;&nbsp;MaV</span></td>
                                <td style="width:10%;border-bottom:dotted;border-bottom-width:thin"></td>
                                <td><span style="padding-left:1em"><input type="checkbox" />&nbsp;&nbsp;MiV-PA</span></td>
                                <td style="width:10%;border-bottom:dotted;border-bottom-width:thin"></td>
                                <td><span style="padding-left:1em"><input type="checkbox" />&nbsp;&nbsp;MiV-N</span></td>
                                <td style="width:10%;border-bottom:dotted;border-bottom-width:thin"></td>
                            </tr>
                            <tr>
                                <td><span style="padding-left:2em"><input type="checkbox" />&nbsp;&nbsp;ยาแผนโบราณ</span></td>
                            </tr>
                        </table>
                        <table width="100%" style="font-family:'Taviraj';font-size:20px">
                            <tr>
                                <td>
                                    <ul class="list-tree">
                                        <li>
                                            <div>เอกสารหลักฐาน</div>
                                        </li>
                                    </ul>
                                </td>
                                <td></td>
                            </tr>
                            <tr>
                                <td><span style="padding-left:2em"><input type="checkbox" checked />&nbsp;&nbsp;สำเนาใบสำคัญการขึ้นทะเบียนตำรับยาหรือใบแทน</span></td>
                                <td></td>
                            </tr>
                            <tr>
                                <td><span style="padding-left:2em"><input type="checkbox" checked />&nbsp;&nbsp;สำเนาใบอนุญาต</span></td>
                                <td></td>
                            </tr>
                            <tr>
                                <td><span style="padding-left:2em"><input type="checkbox" checked />&nbsp;&nbsp;เอกสารสนับสนุนการขอแก้ไขเปลี่ยนแปลง</span></td>
                                <td></td>
                            </tr>
                            <tr>
                                <td><span style="padding-left:4em"><input type="checkbox" />&nbsp;&nbsp;เอกสารตาม AVG</span></td>
                                <td></td>
                            </tr>
                            <tr>
                                <td><span style="padding-left:4em"><input type="checkbox" />&nbsp;&nbsp;กรณีนอกเหนือ AVG</span></td>
                                <td></td>
                            </tr>
                            <tr>
                                <td><span style="padding-left:4em"><input type="checkbox" />&nbsp;&nbsp;ยาแผนโบราณ</span></td>
                                <td></td>
                            </tr>
                            <tr>
                                <td><span style="padding-left:2em"><input type="checkbox" />&nbsp;&nbsp;รายละเอียดการแก้ไขเปลี่ยนแปลงสูตรตำรับยา</span></td>
                                <td></td>
                            </tr>
                            <tr>
                                <td><span style="padding-left:2em"><input type="checkbox" />&nbsp;&nbsp;รายละเอียดการแก้ไขเปลี่ยนแปลงวิธีวิเคราะห์และข้อกำหนดมาตรฐาน</span></td>
                                <td></td>
                            </tr>
                            <tr>
                                <td><span style="padding-left:2em"><input type="checkbox" />&nbsp;&nbsp;อื่นๆ</span></td>
                                <td><input class="form-control inline" style="font-family:'Taviraj';font-size:20px" type="text" /></td>
                            </tr>
                        </table>
                        <br />
                    </div>
                </div>
            </div>
            <div class="part part-1-3">
                <div style="width:80%;margin-left:10%">
                    <table class="table">
                        <tr>
                            <td>โปรดเลือกกระบวนงานที่ท่านต้องการยื่น</td>
                        </tr>
                        <tr>
                            <td>
                                <select class="form-control">
                                    <option></option>
                                </select>
                            </td>
                        </tr>
                    </table>
                    <br />
                    <div class="col-sm-12" style="text-align:center;width:60%;margin-left:20%">
                        <input type="button" class="form-control" value="ยืนคำขอ" />
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
