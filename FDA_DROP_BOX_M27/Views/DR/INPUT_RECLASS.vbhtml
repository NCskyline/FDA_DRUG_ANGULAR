﻿@Code
    Layout = ""
End Code
<div class="ic"  style="font-family:'Taviraj';">

    <div>
        <table style="width:100%">
            <tr>
                <td style="width:30%"></td>
                <td style="width:20%"></td>
                <td style="width:30%; text-align:right">เลขที่ :</td>
                <td style="width:25%; text-align:center"></td>
            </tr>
            <tr>
                <td style="width:30%"></td>
                <td style="width:20%"></td>
                <td style="width:30%; text-align:right">วันที่ :</td>
                <td style="width:25%; text-align:center"></td>
            </tr>
            <tr>
                <td style="width:30%"></td>
                <td style="width:20%"></td>
                <td style="width:30%;text-align:right">ลงชื่อ :</td>
                <td style="width:25%;text-align:right">ผู้รับคำขอ</td>
            </tr>
        </table>
        <br />
        <center><h1>คำขอเปลี่ยนประเภทยาแผนปัจจุบันสำหรับมนุษย์</h1></center>
        <br />
        <table style="width:100%">
            <tr>
                <td style="text-align:right;width:90%">
                    เขียนที่
                </td>
                <td style="width:40%">
                    <input class="form-control inline" ng-model="LIST_DRRC.DR_RECLASS.WRITE_AT" style="font-family:'Taviraj';" type="text" />
                </td>
            </tr>
            <tr>
                <td style="text-align:right;width:100px">
                    วันที่
                </td>
                <td>

                    <md-datepicker ng-model="LIST_DRRC.DR_RECLASS.WRITE_DATE" md-placeholder="Enter date"
                                   input-aria-describedby="datepicker-description"
                                   input-aria-labelledby="datepicker-header ">
                    </md-datepicker>
                </td>
            </tr>
        </table>
        <br />
        <table style="width:100%;">
            <tr><td style="width:2%"></td>
                <td width="15%"align="right">
                    ข้าพเจ้า
                </td>
                <td style="text-align:center;border-bottom:dotted;border-bottom-width:thin;">
                    <label>{{LIST_LCN.thanm}}</label>
                </td>
            </tr>
            <tr>
                
                <td style="text-align:center;width:98%" colspan="3">
                    (ชื่อผู้ขออนุญาต)
                </td>
            </tr>
        </table>
        <table style="width:100%">
            <tr><td style="width:2%"></td>
                <td  width="15%">
                    ซึ่งมีผู้ดำเนินกิจการ ชื่อ
                </td>
                <td style="text-align:left;width:2000px;border-bottom:dotted;border-bottom-width:thin;">
                    <label>{{LIST_LCN.BSN_THAIFULLNAME}}</label>
                </td>
            </tr>
            <tr><td style="width:2%"></td>
                <td style="width:98%" colspan="2">ได้รับอนุญาตให้<span style="padding-left:30px;"><input type="radio" disabled /></span>&nbsp; ผลิตยาแผนปัจจุบัน<span style="padding-left: 15px;"><input type="radio" disabled /></span>&nbsp; นำหรือสั่งยาแผนปัจจุบันเข้ามาในราชอาณาจักร</td>
            </tr>
        </table>
        <table style="width:100%">
            <tr>
                <td style="width:2%"></td>
                <td style="width:10%">ตามใบอนุญาตเลขที่</td>
                <td width="30%" style="text-align:center;border-bottom:dotted;border-bottom-width:thin;"></td>
                <td style="width:10%">มีสถานที่ประกอบธุรกิจชื่อ</td>
                <td width="48%" style="text-align:center;border-bottom:dotted;border-bottom-width:thin;"></td>
            </tr>
        </table>
        <table style="width:100%">
            <tr><td style="width:2%"></td>
                <td style="width:200px">
                    อยู่เลขที่
                </td>
                <td style="text-align:left;border-bottom:dotted;border-bottom-width:thin;" colspan="3">
                    {{LIST_LCN.BSN_FULL_ADDR}}
                </td>

            </tr>
            <tr><td style="width:2%"></td>
                <td>
                    โทรศัพท์
                </td>
                <td style="text-align:left;border-bottom:dotted;border-bottom-width:thin;">
                    {{LIST_LCN.BSN_TELEPHONE}}
                </td>
            </tr>
            
        </table>
        <table style="width:100%">
            <tr>
                <td style="width:2%"></td>
                <td style="width:15%">มีความประสงค์ขอเปลี่ยนประเภทยา ชื่อ</td>
                <td width="40%" style="text-align:center;border-bottom:dotted;border-bottom-width:thin;"></td>
                <td style="width:5%">เลขทะเบียนที่</td>
                <td width="38%" style="text-align:center;border-bottom:dotted;border-bottom-width:thin;"></td>
            </tr>
        </table>
        <table style="width:100%">
            <tr>
                <td style="width:2%"></td>
                <td style="width:23%">ทีได้รับอนุญาตไว้จากเดิม</td>
                <td>
                    <form name="rdl_class">


                        <label><input type="radio" ng-model="CHK1" id="Rdl_old_type" value="1" disabled> ยาควบคุมพิเศษ</label>
                        <label><input type="radio" ng-model="CHK1" id="Rdl_old_type" value="2" disabled> ยาอันตราย</label>
                        <label><input type="radio" ng-model="CHK1" id="Rdl_old_type" value="3" disabled> ยาที่ไม่ใช่ยาอันตรายหรือยาควบคุมพิเศษ</label>
                        <label><input type="radio" ng-model="CHK1" id="Rdl_old_type" value="4" disabled> ยาสามัญประจำบ้าน</label>
                    </form>
                </td>
                @*<td style="width:20%"><input type="checkbox" />&nbsp; ยาควบคุมพิเศษ</td>
                <td style="width:13%"><input type="checkbox" />&nbsp; ยาอันตราย</td>
                <td style="width:42%"><input type="checkbox" />&nbsp; ยาที่ไม่ใช่ยาอันตรายหรือยาควบคุมพิเศษ</td>*@
            </tr>
        </table>
        <table style="width:100%">
            <tr>
                <td style="width:2%"></td>
                <td style="width:23%"> เป็น</td>
                <td><form name="rdl_class">
                <label><input type="radio" ng-model="CHK2" id="Rdl_old_type" value="1"> ยาควบคุมพิเศษ</label>
                <label><input type="radio" ng-model="CHK2" id="Rdl_old_type" value="2"> ยาอันตราย</label>
                <label><input type="radio" ng-model="CHK2" id="Rdl_old_type" value="3"> ยาที่ไม่ใช่ยาอันตรายหรือยาควบคุมพิเศษ</label>
                <label><input type="radio" ng-model="CHK2" id="Rdl_old_type" value="4"> ยาสามัญประจำบ้าน</label>
                    </form>
                </td>
            </tr>
        </table>
        <br />
        <p><span style="padding-left: 55px;">ข้าพเจ้าได้แนบเอกสาร หรือหลักฐาน ตามที่สำนักงานคณะกรรมการอาหารและยา ประกาศกำหนดไว้ในแนวทางการจัดเตรียมเอกสารประกอบการขอเปลี่ยนประเภทยาแผนปัจจุบันสำหรับมนุษย์</span></p>
        <table style="width:100%">
            @*<tr>
                <td style="width:8%"></td>
                <td style="width:92%"><input type="checkbox" />&nbsp; แบบตรวจสอบการยื่นเอกสาร พร้อมเอกสารและหลักฐานประกอบการขอเปลี่ยนประเภทยาแผนปัจจุบันสำหรับมนุษย์ ลงนามยืนยันความถูกต้อง ครบถ้วนของเอกสาร</td>
            </tr>
            <tr>
                <td style="width:8%"></td>
                <td style="width:92%"><input type="checkbox" />&nbsp; สำเนาใบอนุญาต กรณีผู้ยื่นคำขอเป็นผู้รับอนุญาต</td>
            </tr>
            <tr>
                <td style="width:8%"></td>
                <td style="width:92%"><input type="checkbox" />&nbsp; หนังสือมอบอำนาจ ที่ระบุอำนาจให้ยื่นคำขอรวมถึงเอกสาร หลักฐาน แก้ไขเพิ่มเติม รับทราบ ติดตามผลการพิจารณา และยกเลิกคำขอพร้อมรับคำขอและเอกสาร หลักฐานคืน สำเนาบัตรประชาชนผู้มอบและผู้รับมอบอำนาจ พร้อมติดอากรแสตมป์ 30 บาท (กรณีมอบอำนาจมาเพื่อดำเนินการ)</td>
            </tr>*@
            <tr><td style="width:2%"></td>
                <td>
                    <form name="rdl_class">
                        <label><input type="checkbox" ng-model="ATTACH" id="Rdl_old_type" value="1">  แบบตรวจสอบการยื่นเอกสาร พร้อมเอกสารและหลักฐานประกอบการขอเปลี่ยนประเภทยาแผนปัจจุบันสำหรับมนุษย์ ลงนามยืนยันความถูกต้อง ครบถ้วนของเอกสาร</label><br />
                        <label><input type="checkbox" ng-model="ATTACH" id="Rdl_old_type" value="2">  สำเนาใบอนุญาต กรณีผู้ยื่นคำขอเป็นผู้รับอนุญาต</label><br />
                        <label><input type="checkbox" ng-model="ATTACH" id="Rdl_old_type" value="3"> หนังสือมอบอำนาจ ที่ระบุอำนาจให้ยื่นคำขอรวมถึงเอกสาร หลักฐาน แก้ไขเพิ่มเติม รับทราบ ติดตามผลการพิจารณา และยกเลิกคำขอพร้อมรับคำขอและเอกสาร หลักฐานคืน สำเนาบัตรประชาชนผู้มอบและผู้รับมอบอำนาจ พร้อมติดอากรแสตมป์ 30 บาท (กรณีมอบอำนาจมาเพื่อดำเนินการ)</label>
          
                    </form>
                </td>
                
            </tr>
        </table>
        <br />
        <table style="width:100%">
            <tr>
                <td style="width:50%; text-align:center"></td>
                <td style="width:10%; text-align:right">(ลายมือชื่อ)</td>
                <td style="width:20%; text-align:center"></td>
                <td style="width:20%; text-align:start">ผู้ยื่นคำขอ</td>
            </tr>
            <tr>
                <td style="width:50%; text-align:center"></td>
                <td style="width:10%; text-align:right">(</td>
                <td style="width:20%; text-align:center"></td>
                <td style="width:20%; text-align:start">)</td>
            </tr>
        </table>
        <hr style="width:95%; border-color:black" />
        <table>
            <tr>
                <td style="width:2%"></td>
                <td style="width:12%"><b>หมายเหตุ :-</b></td>
                <td style="width:86%">&nbsp; ใส่เครื่องหมาย &#128504; ในช่อง &#11036; หน้าข้อความที่ต้องการ</td>
            </tr>
        </table>
    </div>
</div>