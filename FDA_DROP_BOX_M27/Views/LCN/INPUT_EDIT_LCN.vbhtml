@Code
    ViewData("Title") = "INPUT_EDIT_LCN"
    Layout = ""
End Code

    @*<script src="~/Scripts_angular/ANGULAR_APP.js"></script>
    <script src="~/Scripts_angular/CENTER_SV.js"></script>
    <script src="~/Scripts_angular/LCN_CTRL.js"></script>*@

    <div @*ng-app="ANGULAR_APP" ng-controller="LCN_CTRL"*@>
        <div class="ic" style="font-family:'Taviraj'">
            <div>
                <p style="text-align: center"><b><u>แบบตรวจเอกสารคำขอ : แก้ไขเปลี่ยนแปลงสถานะรายการในใบอนุญาต</u></b></p>
            </div>
            <div style="text-align: left;">
                <input type="checkbox" value="" />&nbsp;1.กรณีเปลี่ยน / เพิ่ม / ถอน / แจ้งเปลี่ยนเจ้าหน้าที่ ผู้มีหน้าที่ปฏิบัติการ<br />
                <input type="checkbox" value="1" ng-model="value" ng-click="BTN_Switch(value)" />&nbsp;2.กรณีย้ายสถานที่ / เพิ่มสถานที่ / ลดขยายสถานที่<br />
                <div style="margin-left:5%" ng-show="value == true">
                    <input type="checkbox" />&nbsp;ย้ายสถานที่<br />
                    <input type="checkbox" />&nbsp;เพิ่มสถานที่<br />
                    <input type="checkbox" />&nbsp;ลดขยายสถานที่<br />
                </div>
                <input type="checkbox" value="" />&nbsp;3.กรณีเปลี่ยนผู้ดำเนินกิจการ (นิติบุคคล)<br />
                <input type="checkbox" value="" />&nbsp;4.กรณีเปลี่ยน เวลาทำการ / เบอร์โทรศัพท์  <b><u>ยกเลิกหมวดยา</u></b><br />
                <input type="checkbox" value="" />&nbsp;5.กรณีเปลียนหมายเลขบ้าน / รายละเอียดของสถานที่ตั้ง / คำนำหน้า / ชื่อตัว / ชื่อสกุลของผู้รับอนุญาต / เภสัชกร / ผู้ดำเนินกิจการ<br />
                <input type="checkbox" value="" />&nbsp;6.กรณีเปลี่ยนชื่อร้าน / ชื่อสถานที่ขายฯ / นำสั่งฯ / ผลิตฯ (บุคคลธรรมดา / นิติบุคคล / แปรสภาพ)<br />
                <input type="checkbox" value="" />&nbsp;7.<b><u>กรณีสืบสิทธิ์แทนผู้รับอนุญาตที่เสียชีวิต แต่ไม่เกิน 30 วัน ***</u></b><br />
                <input type="checkbox" value="" />&nbsp;8.<b>เพิ่มหมวดการผลิตยา / เพิ่มที่เก็บ (สถานที่ผลิต)</b>
            </div>

            <br />

            <div>
                <table style="width:100%" border="1">
                    <tr>
                        <td style="width:60%">
                            <span style="padding-left: 10px;"></span>ชื่อ-สกุลผู้ยื่นคำขอ / ผู้รับมอบอำนาจ<br />
                            <span style="padding-left: 10px;"></span>โทรศัพท์มือถือ <span style="padding-left: 250px;">E-mail</span><br />
                            <span style="padding-left: 10px;"></span>ชื่อสถานที่ขาย / ผลิต / นำสั่ง<br />
                            <span style="padding-left: 10px;"></span>เลขที่ใบอนุญาตขาย / ผลิต / นำสั่ง
                        </td>
                        <td style="width:40%">
                            <span style="padding-left: 10px;"></span>*เจ้าหน้าที่รับเอกสารเมื่อครบถ้วนและถูกต้อง*
                            <u>โปรดอ่านเอกสารนี้ และเตรียมเอกสารเรียงลำดับตามรายการ และทำเครื่องหมายในช่อง ผู้ยื่นคำขอตรวจสอบ</u><br />
                            <span style="padding-left: 10px;"></span>(มายื่นเรื่องแก้ไขฯ ที่ อย. เท่านั้น ไม่รับยื่นทางไปรษณีย์)
                        </td>
                    </tr>
                </table>
            </div>

            <div>
                <p >
                    <b><u>แบบฟอร์มที่ต้องใช้ตามกำหนด</u></b> ของสำนักงานคณะกรรมการอาหารและยา คือ <u>
                        แบบคำขอทุกประเภท / คำขอฯ / คำรับรองฯ / หนังสือมอบอำนาจกระทำการแทน /
                        หนังสือมอบอำนาจแต่งตั้งผู้ดำเนินกิจการ สอบถามเพิ่มเติม (02-590-7200 ห้อง 318 งานใบอนุญาตกองยา อย.)
                    </u>
                </p>
                <p >
                    <u>
                        **ดาวน์โหลดแบบฟอร์มเอกสาร / ฟอร์มรูปถ่าย / แผนที่ / แผนผัง ได้ที่เว็บกองยา &rarr; &rarr; ข้อมูล &rarr; &rarr; การบริการอนุญาตและคู่มือ &rarr; &rarr;
                        แบบฟอร์มคำแนะนำ &rarr; &rarr; เลือกข้อมูลตามประเภทใบอนุญาต
                    </u> <a href="http://www.fda.moph.go.th/sites/drug/SitePages/ApprovalDrugFromPage.aspx">http://www.fda.moph.go.th/sites/drug/SitePages/ApprovalDrugFromPage.aspx</a>
                </p>

                <br />

                <p >&nbsp; &#10146; <b><u>ขอให้ผู้ยื่นคำขอ จัดเรียงเอกสารตามบัญชีรายการเอกสารข้างล่าง และตรวจสอบด้วยตนเอง พร้อมทั้งทำเครื่องหมาย</u></b></p>
                <p >
                    &#10003; &nbsp; <b><u>กรณีถูกต้องครบถ้วนตามข้อกำหนด หรือทำเครื่องหมาย</u></b> &nbsp; &#10007; &nbsp; <b><u>กรณีไม่ถูกต้องหรือไม่ครบถ้วนตามข้อกำหนด หรือเครื่องหมาย</u></b>
                    &nbsp; &#8213; &nbsp; <b><u>กรณีไม่จำเป็นต้องมี</u></b>
                </p><br />
            </div>

            <div>
                <table style="width:100%" border="1">
                    <tr>
                        <td style="width:10%" align="center"><b>ลำดับที่</b></td>
                        <td style="width:50%" align="center"><b>รายการตรวจสอบเอกสาร บุคคลธรรมดา / นิติบุคคล</b></td>
                        <td style="width:10%" align="center"><b><u>ผู้ยื่นคำขอตรวจสอบ</u></b></td>
                        <td style="width:10%" align="center"><b>เจ้าหน้าที่ตรวจสอบ</b></td>
                        <td style="width:20%" align="center"><b>บันทึกข้อบกพร่อง</b></td>
                    </tr>
                    <tr>
                        <td style="width:10%" align="center"><b><u>1.</u></b></td>
                        <td colspan="4">
                            <b><u>กรณีเปลี่ยนหรือเพิ่มผู้ที่มีหน้าที่ปฏิบัติการให้เตรียมทุกข้อ 1.1 - 1.3</u></b><br />
                            <b><u>(ถอน / แจ้งเปลี่ยนหน้าที่</u></b> ให้ยื่นเฉพาะข้อ 1.1 1.10 1.11 1.12)
                        </td>
                    </tr>
                    <tr>
                        <td style="width:10%" align="center">1.1</td>
                        <td style="width:50%">คำขอแก้ไขเปลี่ยนแปลง (ตามประเภทใบอนุญาต)</td>
                        <td style="width:10%"></td>
                        <td style="width:10%"></td>
                        <td style="width:20%"></td>
                    </tr>
                    <tr>
                        <td style="width:10%" align="center">1.2</td>
                        <td style="width:50%">คำรับรองผู้มีหน้าที่ปฏิบัติการ (ตามประเภทใบอนุญาต)</td>
                        <td style="width:10%"></td>
                        <td style="width:10%"></td>
                        <td style="width:20%"></td>
                    </tr>
                    <tr>
                        <td style="width:10%" align="center">1.3</td>
                        <td style="width:50%">
                            คำรับรองการปฏิบัติงานจากหน่วยงาน<br />
                            ***(กรณีใบอนุญาตขายยาแผนปัจจุบัน / ขายยาบรรจุเสร็จฯ / ขายส่ง / ขายยาฯสัตว์)***<br />
                            ตามแบบฟอร์ม ที่สำนักงานคณะกรรมการอาหารและยากำหนด<u> (แบบ ข.ย.14 หน้า 3)</u>
                        </td>
                        <td style="width:10%"></td>
                        <td style="width:10%"></td>
                        <td style="width:20%"></td>
                    </tr>
                    <tr>
                        <td style="width:10%" align="center">1.4</td>
                        <td style="width:50%">สัญญาระหว่างผู้มีหน้าที่ปฏิบัติการกับผู้รับอนุญาต (3 ชุด)</td>
                        <td style="width:10%"></td>
                        <td style="width:10%"></td>
                        <td style="width:20%"></td>
                    </tr>
                    <tr>
                        <td style="width:10%" align="center">1.5</td>
                        <td style="width:50%">สำเนาใบประกอบโรคศิลปะ หรือสำเนาใบประกอบวิชาชีพ เซ็นต์รับรองสำเนาถูกต้อง</td>
                        <td style="width:10%"></td>
                        <td style="width:10%"></td>
                        <td style="width:20%"></td>
                    </tr>
                    <tr>
                        <td style="width:10%" align="center">1.6</td>
                        <td style="width:50%">
                            สำเนาหนังสือรับรองการอบรมการประชุมเชิงปฏิบัติการ <u>(ติดต่อขออบรมที่สภาเภสัชกรรม)</u> หรือสำเนาใบเสร็จรับเงินเข้าร่วมการอบรม เซ็นต์รับรองสำเนาถูกต้อง
                            ***(กรณี<u>ใบอนุญาตขายยาแผนปัจจุบัน</u>)***
                        </td>
                        <td style="width:10%"></td>
                        <td style="width:10%"></td>
                        <td style="width:20%"></td>
                    </tr>
                    <tr>
                        <td style="width:10%" align="center">1.7</td>
                        <td style="width:50%">สำเนาผลการค้นหารายชื่อผู้ประกอบวิชาชีพเภสัชกรรมจากเว็บไซต์สภาเภสัชกรรม <a href="(http://www.pharmacycouncil.org/index.php">http://www.pharmacycouncil.org/index.php</a> เซ็นต์รับรองสำเนาถูกต้อง</td>
                        <td style="width:10%"></td>
                        <td style="width:10%"></td>
                        <td style="width:20%"></td>
                    </tr>
                    <tr>
                        <td style="width:10%" align="center">1.8</td>
                        <td style="width:50%">
                            ใบรับรองแพทย์<u>ตัวจริง</u>ของผู้มีหน้าที่ปฏิบัติการ (ที่ยังไม่หมดอายุ 1 หรือ 3 เดือน) พร้อมระบุ 5 โรคต้องห้ามเป็น ของผู้รับอนุญาตเกี่ยวกับยา ดังต่อไปนี้<br />
                            <span style="padding-left: 30px;"></span>(1)&nbsp; โรคเรื้อน<br />
                            <span style="padding-left: 30px;"></span>(2)&nbsp; วัณโรคในระยะอันตราย<br />
                            <span style="padding-left: 30px;"></span>(3)&nbsp; โรคเท้าช้างในระยะปรากฏอาการเป็นที่รังเกียจแก่สังคม<br />
                            <span style="padding-left: 30px;"></span>(4)&nbsp; โรคติดยาเสพติดให้โทษอย่างร้ายแรง<br />
                            <span style="padding-left: 30px;"></span>(5)&nbsp; โรคพิษสุราเรื้อรัง
                        </td>
                        <td style="width:10%"></td>
                        <td style="width:10%"></td>
                        <td style="width:20%"></td>
                    </tr>
                    <tr>
                        <td style="width:10%" align="center">1.9</td>
                        <td style="width:50%">สำเนาบัตรประชาชนของผู้มีหน้าที่ปฏิการ เซ็นต์รับรองสำเนาถูกต้อง</td>
                        <td style="width:10%"></td>
                        <td style="width:10%"></td>
                        <td style="width:20%"></td>
                    </tr>
                    <tr>
                        <td style="width:10%" align="center">1.9</td>
                        <td style="width:50%">สำเนาทะเบียนบ้านของผู้มีหน้าที่ปฏิการ เซ็นต์รับรองสำเนาถูกต้อง</td>
                        <td style="width:10%"></td>
                        <td style="width:10%"></td>
                        <td style="width:20%"></td>
                    </tr>
                    <tr>
                        <td style="width:10%" align="center">1.10</td>
                        <td style="width:50%">
                            หนังสือมอบอำนาจกระทำการแทน<br />
                            กรณี ผู้ขอไม่อนุญาตไม่สามารถติดต่อด้วยตนเอง (พร้อมอาการแสตมป์ 10 บาท)
                        </td>
                        <td style="width:10%"></td>
                        <td style="width:10%"></td>
                        <td style="width:20%"></td>
                    </tr>
                    <tr>
                        <td style="width:10%" align="center">1.11</td>
                        <td style="width:50%">สำเนาบัตรประชาชนของ ผู้มอบอำนาจ แลผู้รับมอบอำนาจ เซ็นต์รับรองสำเนาถูกต้อง</td>
                        <td style="width:10%"></td>
                        <td style="width:10%"></td>
                        <td style="width:20%"></td>
                    </tr>
                    <tr>
                        <td style="width:10%" align="center">1.12</td>
                        <td style="width:50%">ใบอนุญาตฉบับจริง</td>
                        <td style="width:10%"></td>
                        <td style="width:10%"></td>
                        <td style="width:20%"></td>
                    </tr>
                    <tr>
                        <td style="width:10%" align="center">1.13</td>
                        <td style="width:50%">
                            *** กรณีเปลี่ยนหรือเพิ่มเภสัชกร<b><u>ให้เพิ่มรูปถ่าย 2 รูป</u></b>คือ<br />
                            1.รูปเภสัชกรตัวจริงกับป้ายผู้มีหน้าปฏิบัติการที่ซื่อตรงกัน กับรูปป้ายสถานที่ ในสถานที่จริงที่ได้รับอนุญาต**<br />
                            2.รูปป้ายผู้มึหน้าที่ปฏิบัติการในสถานที่จริงที่ได้รับอนุญาต**<br />
                            ตัวอย่างรูปถ่ายที่ส่งดูได้ที่ข้อ<br />
                            2.3<a href="http://www.fda.moph.go.th/sites/drug/SitePages/ApprovalDrugFromPage.aspx">http://www.fda.moph.go.th/sites/drug/SitePages/ApprovalDrugFromPage.aspx</a><br />
                            อัดกระดาษโฟโต้จากร้านอัดรูป ขนาด 4*6 นิ้ว)
                        </td>
                        <td style="width:10%"></td>
                        <td style="width:10%"></td>
                        <td style="width:20%"></td>
                    </tr>
                </table>
            </div>

            <br />

            <div>
                <table style="width:100%" border="1">
                    <tr>
                        <td style="width:10%" align="center"><b>ลำดับที่</b></td>
                        <td style="width:50%" align="center"><b>รายการตรวจสอบเอกสาร บุคคลธรรมดา / นิติบุคคล</b></td>
                        <td style="width:10%" align="center"><b><u>ผู้ยื่นคำขอตรวจสอบ</u></b></td>
                        <td style="width:10%" align="center"><b>เจ้าหน้าที่ตรวจสอบ</b></td>
                        <td style="width:20%" align="center"><b>บันทึกข้อบกพร่อง</b></td>
                    </tr>
                    <tr>
                        <td style="width:10%" align="center"><b><u>2.</u></b></td>
                        <td colspan="4"><b><u>กรณีย้ายสถานที่, เพิ่มสถานที่, ลดขยายสถานที่</u></b></td>
                    </tr>
                    <tr>
                        <td style="width:10%"></td>
                        <td style="width:50%"><b><u>บุคคลธรรมดา</u></b></td>
                        <td style="width:10%"></td>
                        <td style="width:10%"></td>
                        <td style="width:20%"></td>
                    </tr>
                    <tr>
                        <td style="width:10%" align="center">2.1</td>
                        <td style="width:50%">คำขอย้ายสถานที่ / คำขอแก้ไขเปลี่ยนแปลง (ตามประเภทใบอนุญาต)</td>
                        <td style="width:10%"></td>
                        <td style="width:10%"></td>
                        <td style="width:20%"></td>
                    </tr>
                    <tr>
                        <td style="width:10%" align="center">2.2</td>
                        <td style="width:50%"><u>สัญญาเช่า (กรณีที่เช่าสถานที่) คนที่ลงนามเป็นผู้ให้เช่า**ต้องมีสภาพเป็นเจ้าบ้านในทะเบียนบ้าน หรือกรณีทะเบียนบ้านลอย ต้องมีเอกสารแสดงกรรมสิทธิ์ตามข้อ 2.3 เท่านั้น หรือหนังสือยินยอม (กรณีนามสกุลเดียวกัน)</u></td>
                        <td style="width:10%"></td>
                        <td style="width:10%"></td>
                        <td style="width:20%"></td>
                    </tr>
                    <tr>
                        <td style="width:10%" align="center">2.3</td>
                        <td style="width:50%">
                            <b>สำเนาทะเบียนบ้านของสถานที่ที่ขออนุญาตและสถานที่เก็บยา</b><br />
                            <span style="padding-left: 30px;"></span>- &nbsp; <b>กรณีสำเนาทะเบียนบ้านไม่มีอาศัย(ทะเบียนบ้านลอย)</b>ใช้เอกสารอื่นประกอบ อย่างใดอย่างหนึ่ง**ดังต่อไปนี้ <b><u>ที่ตั้งตรงกับทะเบียนบ้าน</u></b> เพื่อแสดงกรรมสิทธิ์<br />
                            <span style="padding-left: 20px;"></span>[ ] &nbsp;สัญญาซื้อ-ขาย สิ่งปลูกสร้างฯ<br />
                            <span style="padding-left: 20px;"></span>[ ] &nbsp;สำเนาใบอนุญาตก่อสร้าง<br />
                            <span style="padding-left: 20px;"></span>[ ] &nbsp;สำเนาเอกสารอ้างกรรมสิทธิ์ เช่น ใบเสร็จชำระค่าน้ำ ค่าไฟ<br />
                            <span style="padding-left: 30px;"></span>- &nbsp; <b>กรณีสำเนาทะเบียนบ้าน มีผู้อยู่อาศัย</b> คนที่ลงนามเป็นผู้ให้เช่า** ต้องมีสภาพเป็นเจ้าบ้านในทะเบียนบ้านเท่านั้น
                        </td>
                        <td style="width:10%"></td>
                        <td style="width:10%"></td>
                        <td style="width:20%"></td>
                    </tr>
                    <tr>
                        <td style="width:10%" align="center">2.4</td>
                        <td style="width:50%">สำเนาบัตรประชาชนของเจ้าของสถานที่ที่ให้เช่า / ยินยอม เซ็นต์รับรองสำเนาถูกต้อง
                        <td>
                        <td style="width:10%"></td>
                        <td style="width:10%"></td>
                        <td style="width:20%"></td>
                    </tr>
                    <tr>
                        <td style="width:10%" align="center">2.5</td>
                        <td style="width:50%">
                            <b><u>รูปถ่าย</u></b> อัดกระดาษโฟโต้ขนาด 4*6 นิ้ว จากร้านอัดรูปเท่านั้น, <b><u>แผนที่</u></b>,
                            <b><u>แผนผัง</u></b> ของสถานที่ (แบบฟอร์มรูป ใช้ตามประเภทอนุญาต)
                        </td>
                        <td style="width:10%"></td>
                        <td style="width:10%"></td>
                        <td style="width:20%"></td>
                    </tr>
                    <tr>
                        <td style="width:10%" align="center">2.6</td>
                        <td style="width:50%">หนังสือมอบอำนาจกระทำการแทน กรณีผู้ขออนุญาตไม่สามารถติดต่อด้วยตนเอง พร้อมอากรแสตมป์ 10 บาท</td>
                        <td style="width:10%"></td>
                        <td style="width:10%"></td>
                        <td style="width:20%"></td>
                    </tr>
                    <tr>
                        <td style="width:10%" align="center">2.7</td>
                        <td style="width:50%">คำขอย้ายสถานที่ / คำขอแก้ไขเปลี่ยนแปลง (ตามประเภทใบอนุญาต)</td>
                        <td style="width:10%"></td>
                        <td style="width:10%"></td>
                        <td style="width:20%"></td>
                    </tr>
                    <tr>
                        <td style="width:10%" align="center">2.8</td>
                        <td style="width:50%">ใบอนุญาตฉบับจริง</td>
                        <td style="width:10%"></td>
                        <td style="width:10%"></td>
                        <td style="width:20%"></td>
                    </tr>
                    <tr>
                        <td style="width:10%" align="center"><b>2</b></td>
                        <td colspan="4"><b><u>นิติบุคคล</u></b></td>
                    </tr>
                    <tr>
                        <td style="width:10%" align="center"><b>ลำดับที่</b></td>
                        <td style="width:50%" align="center"><b>รายการตรวจสอบเอกสาร บุคคลธรรมดา / นิติบุคคล</b></td>
                        <td style="width:10%" align="center"><b><u>ผู้ยื่นคำขอตรวจสอบ</u></b></td>
                        <td style="width:10%" align="center"><b>เจ้าหน้าที่ตรวจสอบ</b></td>
                        <td style="width:20%" align="center"><b>บันทึกข้อบกพร่อง</b></td>
                    </tr>
                    <tr>
                        <td style="width:10%" align="center">2.1</td>
                        <td style="width:50%">คำขอย้ายสถานที่ / คำขอแก้ไขเปลี่ยนแปลง (ตามประเภทใบอนุญาต)</td>
                        <td style="width:10%"></td>
                        <td style="width:10%"></td>
                        <td style="width:20%"></td>
                    </tr>
                    <tr>
                        <td style="width:10%" align="center">2.2</td>
                        <td style="width:50%">สำเนาทะเบียนบ้านของสถานที่ใหม่</td>
                        <td style="width:10%"></td>
                        <td style="width:10%"></td>
                        <td style="width:20%"></td>
                    </tr>
                    <tr>
                        <td style="width:10%" align="center">2.3</td>
                        <td style="width:50%">สำเนาหนังสือรับรองบริษัทสถานที่ฯใหม่ ที่ออกมาแล้วไม่เกิน 6 เดือน(ต้องได้รับรองการจดทะเบียน สถานที่ใหม่กับกระทรวงพาณิชย์เรียบร้อยแล้ว ถ้ากรณีเพิ่มสถานที่ก็เช่นกัน)</td>
                        <td style="width:10%"></td>
                        <td style="width:10%"></td>
                        <td style="width:20%"></td>
                    </tr>
                    <tr>
                        <td style="width:10%" align="center">2.4</td>
                        <td style="width:50%"><b><u>รูปถ่าย</u></b> อัดกระดาษโฟโต้ขนาด 4*6 นิ้ว จากร้านอัดรูปเท่านั้น, <u>แผนที่</u>, <u>แผนผัง</u>, ของสถานที่ (ตามประเภทใบอนุญาต)</td>
                        <td style="width:10%"></td>
                        <td style="width:10%"></td>
                        <td style="width:20%"></td>
                    </tr>
                    <tr>
                        <td style="width:10%" align="center">2.5</td>
                        <td style="width:50%">หนังสือมอบอำนาจกระทำการแทน กรณีผู้ขออนุญาตไม่สามารถติดต่อด้วยตนเอง (พร้อมอากรแสตมป์ 10 บาท)</td>
                        <td style="width:10%"></td>
                        <td style="width:10%"></td>
                        <td style="width:20%"></td>
                    </tr>
                    <tr>
                        <td style="width:10%" align="center">2.6</td>
                        <td style="width:50%">สำเนาบัตรประชาชนของ ผู้มอบอำนาจ และผู้รับมอบอำนาจ เซ็นต์รับรองสำเนาถูกต้อง</td>
                        <td style="width:10%"></td>
                        <td style="width:10%"></td>
                        <td style="width:20%"></td>
                    </tr>
                    <tr>
                        <td style="width:10%" align="center">2.7</td>
                        <td style="width:50%">ใบอนุญาตฉบับจริง</td>
                        <td style="width:10%"></td>
                        <td style="width:10%"></td>
                        <td style="width:20%"></td>
                    </tr>
                </table>

                <br />

                <table style="width:100%" border="1">
                    <tr>
                        <td style="width:10%" align="center"><b>ลำดับที่</b></td>
                        <td style="width:50%" align="center"><b>รายการตรวจสอบเอกสาร บุคคลธรรมดา / นิติบุคคล</b></td>
                        <td style="width:10%" align="center"><b><u>ผู้ยื่นคำขอตรวจสอบ</u></b></td>
                        <td style="width:10%" align="center"><b>เจ้าหน้าที่ตรวจสอบ</b></td>
                        <td style="width:20%" align="center"><b>บันทึกข้อบกพร่อง</b></td>
                    </tr>
                    <tr>
                        <td style="width:10%" align="center"><b><u>3</u></b></td>
                        <td colspan="4"><b><u>กรณีเปลี่ยนผู้ดำเนินกิจการ (นิติบุคคล)</u></b></td>
                    </tr>
                    <tr>
                        <td style="width:10%" align="center">3.1</td>
                        <td style="width:50%">คำขอแก้ไขเปลี่ยนแปลง (ตามประเภทใบอนุญาต) <u>ลงนามผู้ขอแก้ไขฯ โดยผู้ดำเนินกิจการคนเดิม* หรือกรรมการผู้มีอำนาจลงนาม ตามเงื่อนไขของหนังสือรับรองบริษัท</u>ที่ออกมาแล้วไม่เกิน 6 เดือน</td>
                        <td style="width:10%"></td>
                        <td style="width:10%"></td>
                        <td style="width:20%"></td>
                    </tr>
                    <tr>
                        <td style="width:10%" align="center">3.2</td>
                        <td style="width:50%">คำขออนุญาต (ตามประเภทใบอนุญาต) <u>ผู้ดำเนินกิจการคนใหม่ลงนาม*</u></td>
                        <td style="width:10%"></td>
                        <td style="width:10%"></td>
                        <td style="width:20%"></td>
                    </tr>
                    <tr>
                        <td style="width:10%" align="center">3.3</td>
                        <td style="width:50%">รูปถ่ายของผู้ดำเนินกิจการคนใหม่ รูปสี หน้าตรง ขนาด 3*4 ซม. (3 รูป) ถ่ายไม่เกิน 6 เดือน***</td>
                        <td style="width:10%"></td>
                        <td style="width:10%"></td>
                        <td style="width:20%"></td>
                    </tr>
                    <tr>
                        <td style="width:10%" align="center">3.4</td>
                        <td style="width:50%">
                            ใบรับรองแพทย์<u>ตัวจริง</u>ของผู้มีหน้าที่ปฏิบัติการ (ที่ยังไม่หมดอายุ 1 หรือ 3 เดือน) พร้อมระบุ 5 โรคต้องห้ามเป็น ของผู้รับอนุญาตเกี่ยวกับยา ดังต่อไปนี้<br />
                            <span style="padding-left: 30px;"></span>(1)&nbsp; โรคเรื้อน<br />
                            <span style="padding-left: 30px;"></span>(2)&nbsp; วัณโรคในระยะอันตราย<br />
                            <span style="padding-left: 30px;"></span>(3)&nbsp; โรคเท้าช้างในระยะปรากฏอาการเป็นที่รังเกียจแก่สังคม<br />
                            <span style="padding-left: 30px;"></span>(4)&nbsp; โรคติดยาเสพติดให้โทษอย่างร้ายแรง<br />
                            <span style="padding-left: 30px;"></span>(5)&nbsp; โรคพิษสุราเรื้อรัง
                        </td>
                        <td style="width:10%"></td>
                        <td style="width:10%"></td>
                        <td style="width:20%"></td>
                    </tr>
                    <tr>
                        <td style="width:10%" align="center">3.5</td>
                        <td style="width:50%">สำเนาบัตรประชาชน เซ็นต์รับรองสำเนาถูกต้อง (ผู้ดำเนินกิจการคนใหม่)</td>
                        <td style="width:10%"></td>
                        <td style="width:10%"></td>
                        <td style="width:20%"></td>
                    </tr>
                    <tr>
                        <td style="width:10%" align="center">3.6</td>
                        <td style="width:50%">สำเนาทะเบียนบ้าน เซ็นต์รับรองสำเนาถูกต้อง (ผู้ดำเนินกิจการคนใหม่)</td>
                        <td style="width:10%"></td>
                        <td style="width:10%"></td>
                        <td style="width:20%"></td>
                    </tr>
                    <tr>
                        <td style="width:10%" align="center">3.7</td>
                        <td style="width:50%">สำเนาหนังสือขออนุญาตทำงาน ที่ออกโดยกระทรวงแรงงานฯ และหนังสือเดินทาง <b><u>(กรณีบุคคลต่างด้าว)</u></b></td>
                        <td style="width:10%"></td>
                        <td style="width:10%"></td>
                        <td style="width:20%"></td>
                    </tr>
                    <tr>
                        <td style="width:10%" align="center">3.8</td>
                        <td style="width:50%">
                            หนังสือรับรองบริษัท พร้อมแนบวัตถุประสงค์ของนิติบุคคลที่ออกมาแล้วไม่เกิน 6 เดือน (ต้องมีระบุ วัตถุประสงค์เกี่ยวกับการประกอบธุรกิจ / กิจการด้านยา)***<br />
                            <span style="padding-left: 20px;"></span>- ต้องจดทะเบียนเลขที่ตั้งสถานที่ขออนุญาตในหนังสือรับรองบริษัท<br />
                            <b>***หากมีระบุให้ลงลายมือชื่อพร้อมประทับตราสำคัญของบริษัท*** ต้องมีประทับตราฯแล้ว จึงจะถือว่าเอกสารนั้นสมบูรณ์</b>
                        </td>
                        <td style="width:10%"></td>
                        <td style="width:10%"></td>
                        <td style="width:20%"></td>
                    </tr>
                    <tr>
                        <td style="width:10%" align="center">3.9</td>
                        <td style="width:50%">หนังสือมอบอำนาจแต่งตั้งผู้ดำเนินกิจการ (พร้อมอากรแสตมป์ 30 บาท) (กรรมการผู้มีอำนาจลงนามเป็นผู้แต่งตั้ง*** และประทับตราบริษัทเป็นไปตามเงื่อนไขของหนังสือรับรองบริษัทที่ออกมาแล้วไม่เกิน 6 เดือน)</td>
                        <td style="width:10%"></td>
                        <td style="width:10%"></td>
                        <td style="width:20%"></td>
                    </tr>
                    <tr>
                        <td style="width:10%" align="center">3.10</td>
                        <td style="width:50%">สำเนาบัตรประชาชนของผู้มอบอำนาจและผู้รับมอบอำนาจ เซ็นต์รับรองสำเนาถูกต้อง</td>
                        <td style="width:10%"></td>
                        <td style="width:10%"></td>
                        <td style="width:20%"></td>
                    </tr>
                    <tr>
                        <td style="width:10%" align="center">3.13</td>
                        <td style="width:50%">สัญญาระหว่างผู้ดำเนินกิจการคนใหม่ / ผู้ขออนุญาต กับผู้ที่มีหน้าที่ปฏิบัติการ (จำนวน 3 ชุด ต่อผู้ที่มีหน้าที่ปฏิบัติการ 1 คน)</td>
                        <td style="width:10%"></td>
                        <td style="width:10%"></td>
                        <td style="width:20%"></td>
                    </tr>
                    <tr>
                        <td style="width:10%" align="center">3.14</td>
                        <td style="width:50%">ใบอนุญาตฉบับจริง</td>
                        <td style="width:10%"></td>
                        <td style="width:10%"></td>
                        <td style="width:20%"></td>
                    </tr>
                    <tr>
                        <td style="width:10%" align="center">3.15</td>
                        <td style="width:50%">หนังสือมอบอำนาจกระทำการแทนผู้ดำเนินกิจการใหม่ กรณีไม่สามารถติดต่อ ด้วยตนเอง (พร้อมอากรแสตมป์ 10 บาท)</td>
                        <td style="width:10%"></td>
                        <td style="width:10%"></td>
                        <td style="width:20%"></td>
                    </tr>
                    <tr>
                        <td style="width:10%" align="center">3.15</td>
                        <td style="width:50%">สำเนาบัตรประชาชนของผู้มอบอำนาจแลพผู้รับมอบอำนาจ เซ็นต์รับรองสำเนาถูกต้อง</td>
                        <td style="width:10%"></td>
                        <td style="width:10%"></td>
                        <td style="width:20%"></td>
                    </tr>
                    <tr>
                        <td style="width:10%" align="center"><b>ลำดับที่</b></td>
                        <td style="width:50%" align="center"><b>รายการตรวจสอบเอกสาร บุคคลธรรมดา / นิติบุคคล</b></td>
                        <td style="width:10%" align="center"><b><u>ผู้ยื่นคำขอตรวจสอบ</u></b></td>
                        <td style="width:10%" align="center"><b>เจ้าหน้าที่ตรวจสอบ</b></td>
                        <td style="width:20%" align="center"><b>บันทึกข้อบกพร่อง</b></td>
                    </tr>
                    <tr>
                        <td style="width:10%" align="center"><b><u>4</u></b></td>
                        <td colspan="4"><b><u>กรณีเปลี่ยน เวลาทำการ , เบอร์โทรศัพท์ , ยกเลิกหมวดยา , E-mail</u></b></td>
                    </tr>
                    <tr>
                        <td style="width:10%" align="center">4.1</td>
                        <td style="width:50%">คำขอแก้ไขเปลี่ยนแปลง (ตามใบอนุญาต)</td>
                        <td style="width:10%"></td>
                        <td style="width:10%"></td>
                        <td style="width:20%"></td>
                    </tr>
                    <tr>
                        <td style="width:10%" align="center">4.2</td>
                        <td style="width:50%">หนังสือมอบอำนาจกระทำการแทน กรณีผู้ขออนุญาตไม่สามารถติดต่อด้วยตนเอง (พร้อมอากรแสตมป์ 10 บาท)</td>
                        <td style="width:10%"></td>
                        <td style="width:10%"></td>
                        <td style="width:20%"></td>
                    </tr>
                    <tr>
                        <td style="width:10%" align="center">4.3</td>
                        <td style="width:50%">สำเนาบัตรประชาชนของผู้มอบอำนาจ และผู้รับอำนาจ เซ็นต์สำเนารับรองถูกต้อง</td>
                        <td style="width:10%"></td>
                        <td style="width:10%"></td>
                        <td style="width:20%"></td>
                    </tr>
                    <tr>
                        <td style="width:10%" align="center">4.4</td>
                        <td style="width:50%">ใบอนุญาตฉบับจริง</td>
                        <td style="width:10%"></td>
                        <td style="width:10%"></td>
                        <td style="width:20%"></td>
                    </tr>
                    <tr>
                        <td style="width:10%" align="center">4.5</td>
                        <td style="width:50%">
                            ***กรณี<b><u>เปลี่ยนเวลาทำก่าร ให้เพิ่มรูปถ่าย</u></b> <u>ถ่ายป้ายผู้มีหน้าที่ปฏิบัติการ ที่เปลี่ยนเวลาแล้ว ในสถานที่จริงที่ได้รับบอนุญาต</u><br />
                            **(อัดกระดาษโฟโต้ จากร้านอัดรูป ขนาด 4*6 นิ้ว จำนวน 1 รูป)
                        </td>
                        <td style="width:10%"></td>
                        <td style="width:10%"></td>
                        <td style="width:20%"></td>
                    </tr>
                </table>

                <br />

                <table style="width:100%" border="1">
                    <tr>
                        <td style="width:10%" align="center"><b>ลำดับที่</b></td>
                        <td style="width:50%" align="center"><b>รายการตรวจสอบเอกสาร บุคคลธรรมดา / นิติบุคคล</b></td>
                        <td style="width:10%" align="center"><b><u>ผู้ยื่นคำขอตรวจสอบ</u></b></td>
                        <td style="width:10%" align="center"><b>เจ้าหน้าที่ตรวจสอบ</b></td>
                        <td style="width:20%" align="center"><b>บันทึกข้อบกพร่อง</b></td>
                    </tr>
                    <tr>
                        <td style="width:10%" align="center"><b><u>5</u></b></td>
                        <td colspan="4">
                            <b>
                                <u>
                                    กรณีเปลี่ยนหมายเลขบ้าน, รายละเอียดของสถานที่ตั้ง, คำนำหน้าชื่อ / ชื่อตัว / ชื่อสกุล<br />
                                    ของผู้รับอนุญาต, ผู้มีหน้าที่ปฏิบัติการ, ผู้ดำเนินกิจการ
                                </u>
                            </b>
                        </td>
                    </tr>
                    <tr>
                        <td style="width:10%" align="center">5.1</td>
                        <td style="width:50%">คำขอแก้ไขเปลี่ยนแปลง (ตามประเภทใบอนุญาต)</td>
                        <td style="width:10%"></td>
                        <td style="width:10%"></td>
                        <td style="width:20%"></td>
                    </tr>
                    <tr>
                        <td style="width:10%" align="center">5.2</td>
                        <td style="width:50%">หลักฐานการเปลี่ยนแปลงชื่อตัว / ชื่อสกุล หรือสำเนาทะเบียนสมรส (กรณีสมรส) / สำเนาทะเบียนหย่า (กรณีหย่า)</td>
                        <td style="width:10%"></td>
                        <td style="width:10%"></td>
                        <td style="width:20%"></td>
                    </tr>
                    <tr>
                        <td style="width:10%" align="center">5.3</td>
                        <td style="width:50%">
                            หลักฐานการเปลี่ยนแปลง<b><u>หมายเลขบ้าน / รายละเอียดของสถานที่ตั้ง / คำนำหน้าชื่อ / ชื่อตัว / ชื่อสกุล</u></b>จากหน่วยงานราชการ
                            <b><u>และใบประกอบวิชาชีพเภสัชกรรมที่เปลี่ยนแปลงรายละเอียดแล้ว</u></b>
                        </td>
                        <td style="width:10%"></td>
                        <td style="width:10%"></td>
                        <td style="width:20%"></td>
                    </tr>
                    <tr>
                        <td style="width:10%" align="center">5.4</td>
                        <td style="width:50%">สำเนาทะเบียนบ้านของสถานที่ตั้ง พร้อมเซ็นต์รับรองสำเนาถูกต้อง</td>
                        <td style="width:10%"></td>
                        <td style="width:10%"></td>
                        <td style="width:20%"></td>
                    </tr>
                    <tr>
                        <td style="width:10%" align="center">5.5</td>
                        <td style="width:50%">สำเนาบัตรประชาชนชื่อตัว-สกุลบุคคล ที่เปลี่ยนรายละเอียดแล้ว พร้อมเซ็นต์รับรองสำเนาถูกต้อง</td>
                        <td style="width:10%"></td>
                        <td style="width:10%"></td>
                        <td style="width:20%"></td>
                    </tr>
                    <tr>
                        <td style="width:10%" align="center">5.6</td>
                        <td style="width:50%">หนังสือมอบอำนาจกระทำการแทน (กรณีผู้รับอนุญาตไม่สามารถมาติดต่อด้วยตนเอง) (พร้อมอากรแสตมป์ 10 บาท)</td>
                        <td style="width:10%"></td>
                        <td style="width:10%"></td>
                        <td style="width:20%"></td>
                    </tr>
                    <tr>
                        <td style="width:10%" align="center">5.7</td>
                        <td style="width:50%">สำเนาบัตรประชาชนของผู้มอบอำนาจและผู้รับมอบอำนาจ เซ็นต์รับรองสำเนาถูกต้อง</td>
                        <td style="width:10%"></td>
                        <td style="width:10%"></td>
                        <td style="width:20%"></td>
                    </tr>
                    <tr>
                        <td style="width:10%" align="center">5.8</td>
                        <td style="width:50%">ใบอนุญาตฉบับจริง</td>
                        <td style="width:10%"></td>
                        <td style="width:10%"></td>
                        <td style="width:20%"></td>
                    </tr>
                    <tr>
                        <td style="width:10%" align="center">5.9</td>
                        <td style="width:50%">
                            ***กรณี<b><u>เปลี่ยนคำนำหน้าชื่อ / ชื่อตัว / ชื่อสกุล ให้เพิ่มรูปถ่าย</u></b> <u>ถ่ายป้ายผู้มีหน้าที่ปฏิบัติการ ที่เปลี่ยนคำนำหน้าชื่อ / ชื่อตัว / ชื่อสกุล ในสถานที่จริงที่ได้รับบอนุญาต</u><br />
                            **(อัดกระดาษโฟโต้ จากร้านอัดรูป ขนาด 4*6 นิ้ว จำนวน 1 รูป)
                        </td>
                        <td style="width:10%"></td>
                        <td style="width:10%"></td>
                        <td style="width:20%"></td>
                    </tr>
                </table>

                <br />

                <table style="width:100%" border="1">
                    <tr>
                        <td style="width:10%" align="center"><b><u>6</u></b></td>
                        <td colspan="4"><b><u>กรณีเปลี่ยนชื่อร้าน, ชื่อสถานที่ขายฯ, นำสั่งฯ, ผลิตฯ, (บุคคลธรรมดา, นิติบุคคล, แปรสภาพ / ควบรวมนิติบุคคล)</u></b></td>
                    </tr>
                    <tr>
                        <td style="width:10%" align="center"><b>ลำดับที่</b></td>
                        <td style="width:50%" align="center"><b>รายการตรวจสอบเอกสาร บุคคลธรรมดา / นิติบุคคล</b></td>
                        <td style="width:10%" align="center"><b><u>ผู้ยื่นคำขอตรวจสอบ</u></b></td>
                        <td style="width:10%" align="center"><b>เจ้าหน้าที่ตรวจสอบ</b></td>
                        <td style="width:20%" align="center"><b>บันทึกข้อบกพร่อง</b></td>
                    </tr>
                    <tr>
                        <td style="width:10%" align="center">6.1</td>
                        <td style="width:50%">คำขอแก้ไขเปลี่ยนแปลง (ตามประเภทใบอนุญาต)</td>
                        <td style="width:10%"></td>
                        <td style="width:10%"></td>
                        <td style="width:20%"></td>
                    </tr>
                    <tr>
                        <td style="width:10%" align="center">6.2</td>
                        <td style="width:50%">หนังสือรับรองบริษัทที่แก้ไขรายละเอียดจากกระทรวงพาณืชย์เรียบร้อยแล้ว ที่ออกมาแล้วไม่เกิน 6 เดือน (กรณีนิติบุคคล)</td>
                        <td style="width:10%"></td>
                        <td style="width:10%"></td>
                        <td style="width:20%"></td>
                    </tr>
                    <tr>
                        <td style="width:10%" align="center">6.3</td>
                        <td style="width:50%">หนังสือมอบอำนาจกระทำการแทน (กรณีผู้รับอนุญาตไม่สามารถมาติดต่อด้วยตนเอง) (พร้อมอากรแสตมป์ 10 บาท)</td>
                        <td style="width:10%"></td>
                        <td style="width:10%"></td>
                        <td style="width:20%"></td>
                    </tr>
                    <tr>
                        <td style="width:10%" align="center">6.4</td>
                        <td style="width:50%">สำเนาบัตรประชาชน ผู้มอบอำนาจและผู้รับมอบอำนาจ เซ็นต์รับรองสำเนาถูกต้อง</td>
                        <td style="width:10%"></td>
                        <td style="width:10%"></td>
                        <td style="width:20%"></td>
                    </tr>
                    <tr>
                        <td style="width:10%" align="center">6.5</td>
                        <td style="width:50%">ใบอนุญาตฉบับจริง</td>
                        <td style="width:10%"></td>
                        <td style="width:10%"></td>
                        <td style="width:20%"></td>
                    </tr>
                    <tr>
                        <td style="width:10%" align="center">6.6</td>
                        <td style="width:50%"><b><u>รูปถ่ายเปลี่ยนชื่อร้าน , ชื่อสถานที่ขายฯ , นำสั่งฯ , ผลิตฯ</u></b> ที่เปลี่ยนใหม่<u>ในสถานที่จริงที่ได้รับอนุญาต</u> (รูปถ่ายขนาด 4*6 นิ้ว อัดด้วยกระดาษโฟโต้ จากร้านอัดรูปเท่านั้น)</td>
                        <td style="width:10%"></td>
                        <td style="width:10%"></td>
                        <td style="width:20%"></td>
                    </tr>
                </table>

                <br />

                <table style="width:100%" border="1">
                    <tr>
                        <td style="width:10%" align="center"><b><u>7</u></b></td>
                        <td colspan="4"><b><u>กรณีสืบสิทธิ์แทนผู้รับอนุญาตที่เสียชีวิต แต่ไม่เกิน 30 วัน (บุคคลธรรมดาเท่านั้น)</u></b></td>
                    </tr>
                    <tr>
                        <td style="width:10%" align="center">7.1</td>
                        <td style="width:50%">คำขอแก้ไขเปลี่ยนแปลง (ตามประเภทใบอนุญาต)</td>
                        <td style="width:10%"></td>
                        <td style="width:10%"></td>
                        <td style="width:20%"></td>
                    </tr>
                    <tr>
                        <td style="width:10%" align="center">7.2</td>
                        <td style="width:50%">แบบคำขออนุญาต (ตามประเภท) เจ้าของคนใหม่</td>
                        <td style="width:10%"></td>
                        <td style="width:10%"></td>
                        <td style="width:20%"></td>
                    </tr>
                    <tr>
                        <td style="width:10%" align="center">7.3</td>
                        <td style="width:50%">รูปถ่ายของผู้รับอนุญาต (เจ้าของคนใหม่ / ผู้ขออนุญาต) ขนาด 3*4 ซม. (3 รูป) ถ่ายไม่เกิน 6 เดือน</td>
                        <td style="width:10%"></td>
                        <td style="width:10%"></td>
                        <td style="width:20%"></td>
                    </tr>
                    <tr>
                        <td style="width:10%" align="center">7.4</td>
                        <td style="width:50%">สำเนาบัตรประชาชนรับรองจริง (เจ้าของคนใหม่ / ผู้ขออนุญาต)</td>
                        <td style="width:10%"></td>
                        <td style="width:10%"></td>
                        <td style="width:20%"></td>
                    </tr>
                    <tr>
                        <td style="width:10%" align="center">7.5</td>
                        <td style="width:50%">สำเนาทะเบียนบ้านรับรองจริง (เจ้าของคนใหม่ / ผู้ขออนุญาต)</td>
                        <td style="width:10%"></td>
                        <td style="width:10%"></td>
                        <td style="width:20%"></td>
                    </tr>
                    <tr>
                        <td style="width:10%" align="center">7.6</td>
                        <td style="width:50%">สำเนาหนังสือขออนุญาตทำงานที่ออกโดยกระทรวงแรงงานฯ และหนังสือเดินทาง <b>(กรณีบุคคลต่างด้าว)</b></td>
                        <td style="width:10%"></td>
                        <td style="width:10%"></td>
                        <td style="width:20%"></td>
                    </tr>
                    <tr>
                        <td style="width:10%" align="center">7.7</td>
                        <td style="width:50%">
                            ใบรับรองแพทย์<u>ตัวจริง</u>ของผู้มีหน้าที่ปฏิบัติการ (ที่ยังไม่หมดอายุ 1 หรือ 3 เดือน) พร้อมระบุ 5 โรคต้องห้ามเป็น ของผู้รับอนุญาตเกี่ยวกับยา ดังต่อไปนี้<br />
                            <span style="padding-left: 30px;"></span>(1)&nbsp; โรคเรื้อน<br />
                            <span style="padding-left: 30px;"></span>(2)&nbsp; วัณโรคในระยะอันตราย<br />
                            <span style="padding-left: 30px;"></span>(3)&nbsp; โรคเท้าช้างในระยะปรากฏอาการเป็นที่รังเกียจแก่สังคม<br />
                            <span style="padding-left: 30px;"></span>(4)&nbsp; โรคติดยาเสพติดให้โทษอย่างร้ายแรง<br />
                            <span style="padding-left: 30px;"></span>(5)&nbsp; โรคพิษสุราเรื้อรัง
                        </td>
                        <td style="width:10%"></td>
                        <td style="width:10%"></td>
                        <td style="width:20%"></td>
                    </tr>
                    <tr>
                        <td style="width:10%" align="center">7.8</td>
                        <td style="width:50%">หนังสือยินยอมจากทายาททุกคนที่มีสิทธิ์</td>
                        <td style="width:10%"></td>
                        <td style="width:10%"></td>
                        <td style="width:20%"></td>
                    </tr>
                    <tr>
                        <td style="width:10%" align="center">7.9</td>
                        <td style="width:50%">สำเนาบัตรประชาชนและสำเนาทะเบียนบ้านของทายาททุกคนที่มีสิทธิ์ (เซ็นต์รับรองสำเนาถูกต้อง)</td>
                        <td style="width:10%"></td>
                        <td style="width:10%"></td>
                        <td style="width:20%"></td>
                    </tr>
                    <tr>
                        <td style="width:10%" align="center">7.10</td>
                        <td style="width:50%"><u>สัญญาเช่า (กรณีเช่าสถานที่)</u> คนที่ลงนามเป็นผู้ให้เป็นผู้เช่า** ต้องมีสภาพเป็นเจ้าบ้านในทะเบียนบ้าน หรือกรณีทะเบียนบ้านลอย ต้องมีเอกสารแสดงกรรมสิทธิ์ตามข้อ 7.11 เท่านั้น<u> หรือหนังสือยินยอม (กรณีนามสกุลเดียวกัน)</u></td>
                        <td style="width:10%"></td>
                        <td style="width:10%"></td>
                        <td style="width:20%"></td>
                    </tr>
                    <tr>
                        <td style="width:10%" align="center">7.11</td>
                        <td style="width:50%">
                            <b>สำเนาทะเบียนบ้านของสถานที่ขออนุญาตและสถานที่เก็บยา</b><br />
                            <span style="padding-left: 30px;"></span>- &nbsp; <b>กรณีสำเนาทะเบียนบ้านไม่มีผู้อยู่อาศัย (ทะเบียนบ้านลอย)</b> ใช้เอกสารอื่นประกอบอย่างใดอย่างหนึ่ง** ดังต่อไปนี้ที่ <b><u>ที่ตั้งตรงกับทะเบียนบ้าน</u></b> เพื่อแสดงกรรมสิทธิ์<br />
                            <span style="padding-left: 20px;"></span>[ ] &nbsp;สำเนาสัญญาซื้อ-ขาย สิ่งปลูกสร้าง<br />
                            <span style="padding-left: 20px;"></span>[ ] &nbsp;สำเนาใบอนุญาตก่อสร้าง<br />
                            <span style="padding-left: 20px;"></span> [ ] &nbsp;สำเนาเอกสารอ้างกรรมสิทธิ์ เช่น ใบเสร็จชำระค่าน้ำ ค่าไฟ<br />
                            <span style="padding-left: 30px;"></span>- <b>กรณีสำเนาทะเบียนบ้าน มีผู้อยู่อาศัย</b> คนที่ลงนามให้เป็นผู้เช่า** ต้องมีสภาพเป็นเจ้าบ้านในทะเบียนบ้านเท่านั้น
                        </td>
                        <td style="width:10%"></td>
                        <td style="width:10%"></td>
                        <td style="width:20%"></td>
                    </tr>
                    <tr>
                        <td style="width:10%" align="center">7.12</td>
                        <td style="width:50%">สำเนาบัตรประชาชนของเจ้าของสถานที่ที่ให้เช่า / ยินยอม เซ็นต์รับรองสำเนาถูกต้อง</td>
                        <td style="width:10%"></td>
                        <td style="width:10%"></td>
                        <td style="width:20%"></td>
                    </tr>
                    <tr>
                        <td style="width:10%" align="center">7.13</td>
                        <td style="width:50%">คำรับรองผู้มีหน้าที่ปฏิบัติการ (ตามประเภท)</td>
                        <td style="width:10%"></td>
                        <td style="width:10%"></td>
                        <td style="width:20%"></td>
                    </tr>
                    <tr>
                        <td style="width:10%" align="center">7.14</td>
                        <td style="width:50%">
                            คำรับรองการปฏิบัติงานจากหน่วยงานของผู้มีหน้าที่ปฏิบัติการ<br />
                            ***(กรณีใบอนุญาตขายยาแผนปัจจุบัน / ขายยาบรรจุเสร็จฯ / ขายส่ง / ขายยาฯสัตว์)***<br />
                            ***ตามแบบฟอร์ม ที่สำนักงานคณะกรรมการอาหารและยากำหนด<u> (แบบ ข.ย.14 หน้า 3)</u>
                        </td>
                        <td style="width:10%"></td>
                        <td style="width:10%"></td>
                        <td style="width:20%"></td>
                    </tr>
                    <tr>
                        <td style="width:10%" align="center">7.15</td>
                        <td style="width:50%">สัญญาระหว่างเจ้าของคนใหม่ / ผู้ขออนุญาตกับผู้ที่มีหน้าที่ปฏิบัติการจำนวน 3 ชุด ต่อเภสัชกร 1 คน</td>
                        <td style="width:10%"></td>
                        <td style="width:10%"></td>
                        <td style="width:20%"></td>
                    </tr>
                    <tr>
                        <td style="width:10%" align="center">7.16</td>
                        <td style="width:50%">
                            ใบรับรองแพทย์<u>ตัวจริง</u>ของผู้มีหน้าที่ปฏิบัติการ (ที่ยังไม่หมดอายุ 1 หรือ 3 เดือน) พร้อมระบุ 5 โรคต้องห้ามเป็น ของผู้รับอนุญาตเกี่ยวกับยา ดังต่อไปนี้<br />
                            <span style="padding-left: 30px;"></span>(1)&nbsp; โรคเรื้อน<br />
                            <span style="padding-left: 30px;"></span>(2)&nbsp; วัณโรคในระยะอันตราย<br />
                            <span style="padding-left: 30px;"></span>(3)&nbsp; โรคเท้าช้างในระยะปรากฏอาการเป็นที่รังเกียจแก่สังคม<br />
                            <span style="padding-left: 30px;"></span>(4)&nbsp; โรคติดยาเสพติดให้โทษอย่างร้ายแรง<br />
                            <span style="padding-left: 30px;"></span>(5)&nbsp; โรคพิษสุราเรื้อรัง
                        </td>
                        <td style="width:10%"></td>
                        <td style="width:10%"></td>
                        <td style="width:20%"></td>
                    </tr>
                    <tr>
                        <td style="width:10%" align="center">7.17</td>
                        <td style="width:50%">สำเนาใบประกอบโรคศิลปะ หรือสำเนาใบประกอบวิชาชีพ เช็นต์รับรองสำเนาถูกต้อง</td>
                        <td style="width:10%"></td>
                        <td style="width:10%"></td>
                        <td style="width:20%"></td>
                    </tr>
                    <tr>
                        <td style="width:10%" align="center">7.18</td>
                        <td style="width:50%">
                            สำเนาหนังสือรับรองการอบรมการประชุมเชิงปฏิบัติการ <u>(ติดต่อขออบรมที่สภาเภสัชกรรม) หรือสำเนาใบเสร็จรับเงินเข้าร่วมการอบรม รับรองจริง</u><br />
                            ***(กรณีใบอนุญาตขายยาแผนปัจจุบัน)***
                        </td>
                        <td style="width:10%"></td>
                        <td style="width:10%"></td>
                        <td style="width:20%"></td>
                    </tr>
                    <tr>
                        <td style="width:10%" align="center">7.19</td>
                        <td style="width:50%">สำเนาบัตรประชาชนของผู้มีหน้าที่ปฏิบัติการ เซ็นต์รับรองสำเนาถูกต้อง</td>
                        <td style="width:10%"></td>
                        <td style="width:10%"></td>
                        <td style="width:20%"></td>
                    </tr>
                    <tr>
                        <td style="width:10%" align="center">7.20</td>
                        <td style="width:50%">สำเนาใบมรณบัตรของผู้รับอนุญาตเดิม เซ็นต์รับรองสำเนาถูกต้อง</td>
                        <td style="width:10%"></td>
                        <td style="width:10%"></td>
                        <td style="width:20%"></td>
                    </tr>
                    <tr>
                        <td style="width:10%" align="center">7.21</td>
                        <td style="width:50%">สำเนาหลักทรัพย์ (สำเนาสมุดบัญชีอัพเดตล่าสุด) หรือ หนังสือรับรองจากธนาคาร จำนวนเงินตั้งแต่ 10,000 บาทขึ้นไป / สำเนาโฉนดที่ดินไม่ติดภาระผูกผัน</td>
                        <td style="width:10%"></td>
                        <td style="width:10%"></td>
                        <td style="width:20%"></td>
                    </tr>
                    <tr>
                        <td style="width:10%" align="center">7.22</td>
                        <td style="width:50%">สำเนาทะเบียนบ้านของผู้มีหน้าที่ปฏิบัติการ เซ็นต์รับรองสำเนาถูกต้อง</td>
                        <td style="width:10%"></td>
                        <td style="width:10%"></td>
                        <td style="width:20%"></td>
                    </tr>
                    <tr>
                        <td style="width:10%" align="center">7.23</td>
                        <td style="width:50%">สำเนาผลการค้นหา รายชื่อผู้ประกอบวิชาชีพเภสัชกรรม จากเว็บไซต์สภาเภสัชกรรม <a href="(http://www.pharmacycouncil.org/index.php">http://www.pharmacycouncil.org/index.php</a> เซ็นต์รับรองสำเนาถูกต้อง**</td>
                        <td style="width:10%"></td>
                        <td style="width:10%"></td>
                        <td style="width:20%"></td>
                    </tr>
                    <tr>
                        <td style="width:10%" align="center">7.24</td>
                        <td style="width:50%">หนังสือมอบอำนาจกระทำการแทนผู้ขออนุญาต (กรณีผู้รับอนุญาตใหม่ ไม่สามารถมาติดต่อด้วยตนเอง) พร้อมอากรแสตมป์ 10 บาท</td>
                        <td style="width:10%"></td>
                        <td style="width:10%"></td>
                        <td style="width:20%"></td>
                    </tr>
                    <tr>
                        <td style="width:10%" align="center">7.25</td>
                        <td style="width:50%">สำเนาบัตรประชาชน ผู้มอบอำนาจและผู้รับมอบอำนาจ เซ็นต์รับรองสำเนาถูกต้อง</td>
                        <td style="width:10%"></td>
                        <td style="width:10%"></td>
                        <td style="width:20%"></td>
                    </tr>
                    <tr>
                        <td style="width:10%" align="center">7.26</td>
                        <td style="width:50%">ใบอนุญาตฉบับจริง</td>
                        <td style="width:10%"></td>
                        <td style="width:10%"></td>
                        <td style="width:20%"></td>
                    </tr>
                    <tr>
                        <td style="width:10%" align="center"><b><u>8</u></b></td>
                        <td colspan="4"><b><u>เพิ่มหมวดการผลิตยา หรือเพิ่มที่เก็บยา (กรณีสถานที่ผลิตปัจจุบัน)</u></b></td>
                    </tr>
                    <tr>
                        <td style="width:10%" align="center"><b>ลำดับที่</b></td>
                        <td style="width:50%" align="center"><b>รายการตรวจสอบเอกสาร บุคคลธรรมดา / นิติบุคคล</b></td>
                        <td style="width:10%" align="center"><b><u>ผู้ยื่นคำขอตรวจสอบ</u></b></td>
                        <td style="width:10%" align="center"><b>เจ้าหน้าที่ตรวจสอบ</b></td>
                        <td style="width:20%" align="center"><b>บันทึกข้อบกพร่อง</b></td>
                    </tr>
                    <tr>
                        <td style="width:10%" align="center">8.1</td>
                        <td style="width:50%">
                            คำขอตามประเภท<br />
                            (แบบผ.ย. 11 (สถานที่ผลิตแผนปัจจุบัน))
                        </td>
                        <td style="width:10%"></td>
                        <td style="width:10%"></td>
                        <td style="width:20%"></td>
                    </tr>
                    <tr>
                        <td style="width:10%" align="center">8.2</td>
                        <td style="width:50%">บันทึกผลการตรวจสถานที่ที่มีหมวดยาที่ต้องการเพิ่มระบุชัดเจน<b><u>และ</u></b> สำเนาแบบแปลนที่ออกให้โดย อย. ที่ได้รับการอนุมัติหมวดยาหรือที่เก็บที่ต้องการเพิ่มแล้ว</td>
                        <td style="width:10%"></td>
                        <td style="width:10%"></td>
                        <td style="width:20%"></td>
                    </tr>
                    <tr>
                        <td style="width:10%" align="center">8.3</td>
                        <td style="width:50%">
                            หนังสือมอบอำนาจการกระทำแทน<br />
                            กรณีผู้ขออนุญาตไม่สามารถติดต่อด้วยตนเอง (พร้อมอากรแสตมป์ 10 บาท)<br />
                            (สำเนาบัตรประชาชนของ ผู้มอบอำนาจและผู้รับมอบอำนาจ เซ็นต์รับรองสำเนาถูกต้อง)
                        </td>
                        <td style="width:10%"></td>
                        <td style="width:10%"></td>
                        <td style="width:20%"></td>
                    </tr>
                </table>

                <br />

                @*<table style="width:80%" border="1" align="center">
                    <tr>
                        <td style="width:45%" align="center"><b>สำหรับผู้ยื่นคำขอฯ</b></td>
                        <td style="width:10%" align="center"><b>สำหรับเจ้าหน้าที่</b></td>
                        <td style="width:45%">&nbsp;ออกใบรับคำขอเลขที่</td>
                    </tr>
                    <tr>
                        <td style="width:50%">
                            <span style="padding-left: 15px;"></span><b><u>ครั้งที่ 1 (ยื่นคำขอครั้งแรก)</u></b><br /><br />
                            <span style="padding-left: 15px;"></span>ลงชื่อ <span style="padding-left: 100px;">(ผู้ยื่นขอ / ผู้รับมอบอำนาจ)</span><br />
                            <span style="padding-left: 15px;"></span>(<span style="padding-left: 150px;">)</span><br />
                            <span style="padding-left: 15px;"></span>วันที่<br /><br />
                            <span style="padding-left: 15px;"></span><b>รับทราบข้อบกพร่อง และจะแก้ไขให้เสร็จภายใน <span style="padding-left: 40px;">วันทำการ</span> นับแต่วันถัดจากวันที่รับคำขอ</b> (ถ้ามี)<br /><br />
                            <span style="padding-left: 15px;"></span> ลงชื่อ <span style="padding-left: 100px;">(ผู้ยื่นขอ / ผู้รับมอบอำนาจ)</span><br />
                            <span style="padding-left: 15px;"></span>(<span style="padding-left: 150px;">)</span><br />
                            <span style="padding-left: 15px;"></span>วันที่<br /><br />
                        </td>
                        <td colspan="2">
                            <span style="padding-left: 15px;"></span><b><u>ครั้งที่ 1 (ยื่นคำขอครั้งแรก)</u></b><br /><br />
                            <span style="padding-left: 15px;"></span> <input type="checkbox" /><span style="padding-left: 20px;"></span><b>รับคำขอเพราะเอกสารครบถ้วนถูกต้อง</b><br />
                            <span style="padding-left: 15px;"></span> <input type="checkbox" /><span style="padding-left: 20px;"></span><b>รับคำขอแต่มีเงือนไข เพราะเอกสารไม่ครบถ้วนถูกต้อง พบข้อบกพร่อง ตามที่ระบุไว้ข้างต้น ต้องแก้ไขให้แล้วเสร็จภายใน <span style="padding-left: 40px;">วันทำการ</span> นับแต่วัน ถัดจากวันที่รับคำขอ <u>หากพ้นกำหนดจะยกเลิกและส่งคืนคำขอ</u>ต่อไป</b> (ให้ผู้ยื่นคำขอลงนามรับทราบและรับสำเนาบันทึกข้อบกพร่อง)<br /><br />
                            <span style="padding-left: 15px;"></span>ลงชื่อเจ้าหน้าที่ตรวจสอบเบื้องต้น<br />
                            <span style="padding-left: 170px;"></span>วันที่<br /><br />
                            <span style="padding-left: 15px;"></span>ลงชื่อพนักงานเจ้าหน้าที่ผู้พิจารณา<br />
                            <span style="padding-left: 170px;"></span>วันที่<br />
                        </td>
                        <td style="width:50%"></td>
                    </tr>
                    <tr>
                        <td style="width:50%">
                            <span style="padding-left: 15px;"></span><b><u>ครั้งที่ 2 (การแก้ไขข้อบกพร่อง)</u></b><br /><br />
                            <span style="padding-left: 15px;"></span>ข้าพเจ้าได้ยื่นเอกสารข้อบกพร่อง ไว้จำนวน <span style="padding-left: 40px;">รายการตามที่ระบุไว้ในบันทึกข้อบกพร่อง</span><br /><br />
                            <span style="padding-left: 15px;"></span>ลงชื่อ <span style="padding-left: 100px;">(ผู้ยื่นเอกสารแก้ไขข้อบกพร่อง / ผู้รับมอบอำนาจ)</span><br />
                            <span style="padding-left: 15px;"></span>(<span style="padding-left: 150px;">)</span><br />
                            <span style="padding-left: 15px;"></span>วันที่<br /><br />
                        </td>
                        <td colspan="2" rowspan="2">
                            <span style="padding-left: 15px;"></span><b><u>ครั้งที่ 2 (การแก้ไขข้อบกพร่อง)</u></b><br /><br />
                            <span style="padding-left: 15px;"></span> <input type="checkbox" /><span style="padding-left: 20px;">แก้ไขข้อบกพร่องครบถ้วน</span><br />
                            <span style="padding-left: 15px;"></span>ลงชื่อเจ้าหน้าที่ตรวจสอบเบื้องต้น<br /><br />
                            <span style="padding-left: 170px;"></span>วันที่<br /><br />
                            <span style="padding-left: 15px;"></span>ขอส่งคืนคำขอและเอกสารประกอบทั้งหมด เนื่องจาก<br />
                            <span style="padding-left: 15px;"></span> <input type="checkbox" /><span style="padding-left: 20px;">ไม่มาแก้ไขข้อบกพร่องภายในระยะเวลาที่กำหนด</span><br />
                            <span style="padding-left: 15px;"></span> <input type="checkbox" /><span style="padding-left: 20px;">แก้ไขข้อบกพร่องไม่ครบถ้วน / ไม่ถูกต้อง</span><br /><br />
                            <span style="padding-left: 15px;"></span>ท่านมีสิทธิ์ยื่นคำขอใหม่ โดยจัดเตรียมเอกสารให้ถุกต้องครบถ้วนและสอดคล้อง ตามกฎหมาย หรือจะอุทธรณ์การคืนคำขอครั้งนี้ก็ได้ ขอให้ยื่นคำอุทธรณ์เป็นหนังสือต่อเลขาธิการคณะกรรมการอาหารและยาได้ภายใน 15 วันทำการ นับ แต่วันที่ได้รับแจ้ง<br />
                            <span style="padding-left: 300px;"></span>จึงเรียนมาเพื่อโปรดทราบ<br />
                            <span style="padding-left: 15px;"></span>ลงชื่อเจ้าหน้าที่เจ้าของเรื่อง<br />
                            <span style="padding-left: 150px;"></span>วันที่<br /><br />
                        </td>
                    </tr>
                    <tr>
                        <td style="width:50%">
                            <span style="padding-left: 15px;"></span><b><u>รับคืนคำขอ</u></b><br /><br />
                            <span style="padding-left: 15px;"></span>ลงชื่อ <span style="padding-left: 100px;">(ผู้ยื่นขอ / ผู้รับมอบอำนาจ)</span><br />
                            <span style="padding-left: 15px;"></span>(<span style="padding-left: 150px;">)</span><br />
                            <span style="padding-left: 15px;"></span>วันที่<br /><br />
                        </td>
                        <td colspan="2"></td>
                        <td style="width:50%"></td>
                    </tr>
                </table>*@
            </div>
        </div>

    </div>
    