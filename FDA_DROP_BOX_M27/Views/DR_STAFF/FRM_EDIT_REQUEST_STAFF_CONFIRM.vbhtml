﻿@Code
    ViewData("Title") = "FRM_EDIT_REQUEST_STAFF_CONFIRM"
End Code

<div>
    <div class="content-part">
        <div class="part part-2-3">
            <div class="ic">
                <div style="font-family:'Taviraj';width:100%">
                    <div>
                        <p style="text-align: right;">แบบ ย.๕</p>
                        <p style="text-align: right;">FORM MA-5</p>
                    </div>
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
                    <br />
                    <br />
                    <h1 style="text-align: center;"> คำขอแก้ไขเปลี่ยนแปลงรายการในทะเบียนตำรับยา</h1>
                    <br />
                    <table width="100%" style="font-family:'Taviraj';font-size:20px">
                        <tr>
                            <td width="10%" align="right">ข้าพเจ้า</td>
                            <td width="65%" style="border-bottom:dotted;border-bottom-width:thin">
                                @*<input class="form-control inline" style="font-family:'Taviraj';font-size:20px;width:100%" />*@
                            </td>
                            <td>ผู้รับอนุญาต/ผู้ดำเนินการ ตามใบอนุญาต</td>
                        </tr>
                    </table>
                    <br />
                    <table width="100%" style="font-family:'Taviraj';font-size:20px">
                        <tr>
                            <td width="15%"></td>
                            <td>
                                <input type="checkbox" value="1" />&nbsp;&nbsp;ผลิตยา
                            </td>
                            <td>
                                <input type="checkbox" value="2" />&nbsp;&nbsp;นำเข้าหรือสั่งยาเข้ามาในราชอาณาจักร
                            </td>
                        </tr>
                        <tr>
                            <td width="15%"></td>
                            <td>
                                <input type="checkbox" value="3" />&nbsp;&nbsp;แผนปัจจุบัน
                            </td>
                            <td>
                                <input type="checkbox" value="4" />&nbsp;&nbsp;แผนโบราณ
                            </td>
                        </tr>
                    </table>
                    <br />
                    <table width="100%" style="font-family:'Taviraj';font-size:20px">
                        <tr>
                            <td width="10%" align="center">ใบอนุญาตเลขที่</td>
                            <td style="border-bottom:dotted;border-bottom-width:thin">
                                @*<input class="form-control inline" type="text" style="font-family:'Taviraj';font-size:20px;width:100%" />*@
                            </td>
                            <td width="2%"></td>
                            <td width="15%">ในนาม บริษัท/ห้าง/ร้าน</td>
                            <td style="border-bottom:dotted;border-bottom-width:thin">
                                @*<input class="form-control inline" type="text" style="font-family:'Taviraj';font-size:20px;width:100%" />*@
                            </td>
                        </tr>
                    </table>
                    <table width="100%" style="font-family:'Taviraj';font-size:20px">
                        <tr>
                            <td width="30%">ขอแก้ไขเปลี่ยนแปลงรายการในทะเบียนตำรับยาชื่อ</td>
                            <td style="border-bottom:dotted;border-bottom-width:thin">
                                @*<input class="form-control inline" type="text" style="font-family:'Taviraj';font-size:20px;width:100%" />*@
                            </td>
                        </tr>
                    </table>
                    <table width="100%" style="font-family:'Taviraj';font-size:20px">
                        <tr>
                            <td width="8%">เลขทะเบียนที่</td>
                            <td style="border-bottom:dotted;border-bottom-width:thin">
                                @*<input class="form-control inline" type="text" style="font-family:'Taviraj';font-size:20px;width:100%" />*@
                            </td>
                            <td width="2%"></td>
                            <td width="20%">รายการที่ขอแก้ไขเปลี่ยนแปลง (ระบุ)</td>
                            <td style="border-bottom:dotted;border-bottom-width:thin">
                                @*<input class="form-control inline" type="text" style="font-family:'Taviraj';font-size:20px;width:100%" />*@
                            </td>
                        </tr>
                    </table>
                    <br />
                    <div style="font-size:20px;font-family:'Taviraj';margin-left:10%">ข้าพเจ้าได้แนบเอกสารหรือหลักฐานตามที่สำนักงานคณะกรรมการอาหารและยาประกาศกำหนดมาพร้อมนี้</div>
                    <div style="font-size:20px;font-family:'Taviraj';margin-left:5%">และขอรับรองว่าข้อความอื่นใดที่ไม่ได้ระบุไว้ในคำขอฉบับนี้เหมือนเดิมทุกประการและขอยกเลิกรายการเดิมในทะเบียนตำรับยา</div>
                    <div style="font-size:20px;font-family:'Taviraj';margin-left:5%">ตั้งแต่วันที่ได้รับอนุญาตให้แก้ไขเปลี่ยนแปลงรายการดังกล่าวในทะเบียนตำรับยา เว้นแต่พนักงานเจ้าหน้าที่จะมีคำสั่งเป็นอย่างอื่น</div>
                    <br />
                    <br />
                    <table style="font-size:20px;font-family:'Taviraj';width:50%;float:right">
                        <tr>
                            <td width="15%">
                                (ลายมือชื่อ)
                            </td>
                            <td style="width:30%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"></td>
                            <td style="text-align:left">
                                ผู้รับอนุญาต
                            </td>
                        </tr>
                        <tr>
                            <td width="15%" style="text-align:right">
                                (
                            </td>
                            <td style="width:40%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"></td>
                            <td style="text-align:left">
                                ) (ตัวบรรจง)
                            </td>
                        </tr>
                        <tr>
                            <td width="15%">
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
                                ) (ตัวบรรจง)
                            </td>
                        </tr>
                    </table>
                    <br />
                    <br />
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
                            <td width="15%">
                                <input type="checkbox" />&nbsp;&nbsp;อนุญาต
                            </td>
                            <td></td>
                        </tr>
                        <tr>
                            <td width="15%">
                                <input type="checkbox" />&nbsp;&nbsp;ไม่อนุญาต เนื่องจาก
                            </td>
                            <td style="border-bottom:dotted;border-bottom-width:thin">
                                @*<input class="form-control inline" style="font-family:'Taviraj';font-size:20px;width:90%" type="text" />*@
                            </td>
                        </tr>
                        <tr>
                            <td width="15%">
                                <input type="checkbox" />&nbsp;&nbsp;คำสั่งอื่น
                            </td>
                            <td style="border-bottom:dotted;border-bottom-width:thin">
                                @*<input class="form-control inline" style="font-family:'Taviraj';font-size:20px;width:90%" type="text" />*@
                            </td>
                        </tr>
                    </table>
                    <br />
                    <table style="font-size:20px;font-family:'Taviraj';width:50%;float:right">
                        <tr>
                            <td width="15%" align="right">
                                (ลายมือชื่อ)
                            </td>
                            <td style="width:60%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"></td>
                            <td width="10%"></td>
                        </tr>
                        <tr>
                            <td width="15%" align="right">
                                ตำแหน่ง
                            </td>
                            <td style="width:60%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"></td>
                            <td width="10%"></td>
                        </tr>
                    </table>
                    <br />
                    <br />
                    <br />
                    <div style="font-size:20px;margin-left:70%;font-family:'Taviraj';">พนักงานเจ้าหน้าที่</div>
                    <table style="font-size:20px;font-family:'Taviraj';width:50%;float:right">
                        <tr>
                            <td width="15%" align="right">
                                ลงวันที่
                            </td>
                            <td style="width:60%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"></td>
                            <td width="10%"></td>
                        </tr>
                    </table>
                    <br />
                    <br />
                </div>
            </div>
            <div class="in">
                <div style="font-family:'Taviraj';width:100%">
                    <div>
                        <p style="text-align:right">แบบ ย.๕ หน้า ๒</p>
                    </div>
                    <br />
                    <h1 style="text-align:center">รายละเอียดการแก้ไขเปลี่ยนแปลงรายการในทะเบียนตำรับยา</h1>
                    <br />
                    <table width="100%" style="font-family:'Taviraj';font-size:20px">
                        <tr>
                            <td width="42%">
                                <ul class="list-tree">
                                    <li>
                                        <div>การแก้ไขเปลี่ยนแปลงรายการในทะเบียนตำรับยาตามแบบ ย. ๕ เลขที่รับ</div>
                                    </li>
                                </ul>
                            </td>
                            <td style="border-bottom:dotted;border-bottom-width:thin">
                                @*<input class="form-control inline" type="text" style="font-family:'Taviraj';font-size:20px;width:100%" />*@
                            </td>
                        </tr>
                    </table>
                    <table width="100%" style="font-family:'Taviraj';font-size:20px">
                        <tr>
                            <td width="5%">ชื่อยา</td>
                            <td style="border-bottom:dotted;border-bottom-width:thin">
                                @*<input class="form-control inline" type="text" style="font-family:'Taviraj';font-size:20px;width:100%" />*@
                            </td>
                            <td width="2%"></td>
                            <td width="10%">เลขทะเบียนที่</td>
                            <td style="border-bottom:dotted;border-bottom-width:thin">
                                @*<input class="form-control inline" type="text" style="font-family:'Taviraj';font-size:20px;width:100%" />*@
                            </td>
                        </tr>
                    </table>
                    <br />
                    <div style="font-size:20px;font-family:'Taviraj';margin-left:5%">รายการที่ขอแก้ไขเปลี่ยนแปลง</div>
                    <table width="100%" style="font-family:'Taviraj';font-size:20px;margin-left:10%">
                        <tr>
                            <td><input type="checkbox" />&nbsp;&nbsp;ฉลาก</td>
                            <td></td>
                        </tr>
                        <tr>
                            <td><input type="checkbox" />&nbsp;&nbsp;เอกสารกำกับยา</td>
                            <td></td>
                        </tr>
                        <tr>
                            <td><input type="checkbox" />&nbsp;&nbsp;ขนาดบรรจุ</td>
                            <td></td>
                        </tr>
                        <tr>
                            <td><input type="checkbox" />&nbsp;&nbsp;ชื่อยา</td>
                            <td></td>
                        </tr>
                        <tr>
                            <td><input type="checkbox" />&nbsp;&nbsp;ลักษณะยา</td>
                            <td></td>
                        </tr>
                        <tr>
                            <td><input type="checkbox" />&nbsp;&nbsp;สูตรยา (แสดงรายละเอียดการแก้ไขเปลี่ยนแปลงสูตรตำรับยา)</td>
                            <td></td>
                        </tr>
                        <tr>
                            <td>
                                <input type="checkbox" />&nbsp;&nbsp;วิธีวิเคราะห์และข้อกำหนดมาตรฐาน (แสดงรายละเอียดการแก้ไขเปลี่ยนแปลงวิธีวิเคราะห์และข้อกำหนดมาตรฐาน)<br />
                            </td>
                            <td></td>
                        </tr>
                    </table>
                    <table width="100%" style="font-family:'Taviraj';font-size:20px;margin-left:10%">
                        <tr>
                            <td width="17%"><input type="checkbox" />&nbsp;&nbsp;อื่นๆ เกี่ยวกับผลิตภัณฑ์ยา<br /></td>
                            <td style="border-bottom:dotted;border-bottom-width:thin">
                                @*<input class="form-control inline" type="text" style="font-family:'Taviraj';font-size:20px;width:85%" />*@
                            </td>
                        </tr>
                    </table>
                    <table width="100%" style="font-family:'Taviraj';font-size:20px">
                        <tr>
                            <td width="17%">
                                <ul class="list-tree">
                                    <li>
                                        <div>ขอแก้ไขเปลี่ยนแปลงจาก</div>
                                    </li>
                                </ul>
                            </td>
                            <td style="border-bottom:dotted;border-bottom-width:thin">
                                @*<input class="form-control inline" type="text" style="font-family:'Taviraj';font-size:20px;width:100%" />*@
                            </td>
                        </tr>
                    </table>
                    <div style="font-size:20px;font-family:'Taviraj';margin-left:3%">ที่เคยได้รับอนุมัติไว้</div>
                    <table width="100%" style="font-family:'Taviraj';font-size:20px;margin-left:3%">
                        <tr>
                            <td width="5%">เป็น</td>
                            <td style="border-bottom:dotted;border-bottom-width:thin">
                                @*<input class="form-control inline" type="text" style="font-family:'Taviraj';font-size:20px;width:95%" />*@
                            </td>
                        </tr>
                    </table>
                    <div style="font-size:20px;font-family:'Taviraj';margin-left:3%">เป็นการขอแก้ไขเปลี่ยนแปลง</div>
                    <table width="100%" style="font-family:'Taviraj';font-size:20px;margin-left:4%">
                        <tr>
                            <td><span style="padding-left:2em"><input type="checkbox" />&nbsp;&nbsp;ยาแผนปัจจุบัน</span></td>
                        </tr>
                        <tr>
                            <td width="30%"><span style="padding-left:4em"><input type="checkbox" />&nbsp;&nbsp;ตาม ASEAN Variation Guideline(AVG)</span></td>
                            <td width="7%"><span style="padding-left:1em"><input type="checkbox" />&nbsp;&nbsp;MaV</span></td>
                            <td style="border-bottom:dotted;border-bottom-width:thin">
                                @*<input class="form-control inline" type="text" style="font-family:'Taviraj';font-size:20px;width:80%" />*@
                            </td>
                            <td width="8%"><span style="padding-left:1em"><input type="checkbox" />&nbsp;&nbsp;MiV-PA</span></td>
                            <td style="border-bottom:dotted;border-bottom-width:thin">
                                @*<input class="form-control inline" type="text" style="font-family:'Taviraj';font-size:20px;width:80%" />*@
                            </td>
                            <td width="8%"><span style="padding-left:1em"><input type="checkbox" />&nbsp;&nbsp;MiV-N</span></td>
                            <td style="border-bottom:dotted;border-bottom-width:thin">
                                @*<input class="form-control inline" type="text" style="font-family:'Taviraj';font-size:20px;width:80%" />*@
                            </td>
                        </tr>
                    </table>
                    <table width="100%" style="font-family:'Taviraj';font-size:20px;margin-left:4%">
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
                    </table>
                    <table width="100%" style="font-family:'Taviraj';font-size:20px">
                        <tr>
                            <td width="10%"><span style="padding-left:2em"><input type="checkbox" />&nbsp;&nbsp;อื่นๆ</span></td>
                            <td style="border-bottom:dotted;border-bottom-width:thin">
                                @*<input class="form-control inline" style="font-family:'Taviraj';font-size:20px" type="text" />*@
                            </td>
                        </tr>
                    </table>
                </div>
            </div>
        </div>
        <div class="part part-1-3 ic" >
            <div class="card">
                <div >
                    <div>
                        @*style="width:80%;margin-left:10%"*@
                        <table class="table">
                            <tr>
                                <td>วันที่ออกเลขรับคำขอ :</td>
                                <td></td>
                            </tr>
                            <tr>
                                <td>วันที่อนุมัติ :</td>
                                <td></td>
                            </tr>
                            <tr>
                                <td>วิธียื่นเอกสารประกอบคำขอ :</td>
                                <td></td>
                            </tr>
                            <tr>
                                <td>เลข identifier :</td>
                                <td></td>
                            </tr>
                            <tr>
                                <td>สถานะปัจจุบัน :</td>
                                <td></td>
                            </tr>
                        </table>
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
                            วันที่มีผลอนุมัติ
                        </div>
                        <div style="width:80%;margin-left:10%">
                            <md-datepicker ng-model="LIST_GMP.CER.EXP_DOCUMENT_DATE" md-placeholder="Enter date"
                                           input-aria-describedby="datepicker-description"
                                           input-aria-labelledby="datepicker-header ">
                            </md-datepicker>
                        </div>
                        <br />
                        <div class="col-sm-12" style="text-align:center">
                            <input type="button" style="width:90%" class="btn btn-lg " value="แก้ไขรายละเอียดคำขอ" />
                        </div>
                        <br />
                        <div class="col-sm-12" style="text-align:center">
                            <input type="button" style="width:90%" class="btn btn-lg " value="ยืนยัน" />
                        </div>
                        <br />
                        <div class="col-sm-12" style="text-align:center" ">
                            <input type="button" style="width:90%" class="btn btn-lg " value="ระบบปรับปรุงทะเบียน" />
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
    </div>
</div>