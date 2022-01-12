@Code Layout = "" End Code
<style>
    .tab {
        overflow: hidden;
        border: none solid #ccc;
        /*background-color: #f1f1f1;*/
    }

        /* Style the buttons that are used to open the tab content */
        .tab button {
            background-color: inherit;
            float: left;
            border: none;
            outline: none;
            cursor: pointer;
            padding: 14px 16px;
            transition: 0.3s;
        }

            /* Change background color of buttons on hover */
            .tab button:hover {
                background-color: #ddd;
            }

            /* Create an active/current tablink class */
            .tab button.active {
                background-color: #ccc;
            }

    /* Style the tab content */
    .tabcontent {
        display: none;
        padding: 6px 12px;
        border-top: none;
    }
</style>

<div>
    <p style="text-align:center; font-size:large"><b>แบบตรวจสอบการยื่นเอกสารประกอบขอเปลี่ยนประเภทยาแผนปัจจุบันสำหรับมนุษย์</b></p>
    <table style="width:100%" border="1">
        <tr>
            <td rowspan="2">
                <table>
                    <tr>
                        <td>
                            ชื่อยา
                        </td>
                        <td>
                            &nbsp;
                            {{LIST_READ_RC.DRUG_NAME}}
                        </td>
                    </tr>
                    <tr>
                        <td>
                            &nbsp;
                            เลขทะเบียน
                        </td>
                        <td>
                            {{LIST_READ_RC.RGTNO_DISPLAY}}
                        </td>
                    </tr>
                </table>
      
                
            </td>
            <td style="width:40%">
                เลขที่รับ<br />
                วันที่ยื่นขอ
            </td>
        </tr>
    </table>
    <table style="width:100%" border="1">
        <tr>
            <td style="width:24%">ประเภทยาปัจจุบัน</td>
            <td style="width:76%"><form name="rdl_class">


    <label><input type="radio" ng-model="LIST_READ_RC.thakindnm" id="Rdl_old_type" value="1" disabled> ยาควบคุมพิเศษ</label>
    <label><input type="radio" ng-model="LIST_READ_RC.thakindnm" id="Rdl_old_type" value="2" disabled> ยาอันตราย</label>
    <label><input type="radio" ng-model="LIST_READ_RC.thakindnm" id="Rdl_old_type" value="3" disabled> ยาที่ไม่ใช่ยาอันตรายหรือยาควบคุมพิเศษ</label>
    <label><input type="radio" ng-model="LIST_READ_RC.thakindnm" id="Rdl_old_type" value="4" disabled> ยาสามัญประจำบ้าน</label>
</form></td>
        </tr>
        <tr>
            <td style="width:24%">ขอเปลี่ยนประเภทยาเป็น</td>
            <td style="width:76%"><form name="rdl_class">
    <label><input type="radio" ng-model="LIST_DRRC.NEW_DOSESAGE" id="Rdl_New_type" value="1" disabled> ยาควบคุมพิเศษ</label>
    <label><input type="radio" ng-model="LIST_DRRC.NEW_DOSESAGE" id="Rdl_New_type" value="2" disabled> ยาอันตราย</label>
    <label><input type="radio" ng-model="LIST_DRRC.NEW_DOSESAGE" id="Rdl_New_type" value="3" disabled> ยาที่ไม่ใช่ยาอันตรายหรือยาควบคุมพิเศษ</label>
    <label><input type="radio" ng-model="LIST_DRRC.NEW_DOSESAGE" id="Rdl_New_type" value="4" disabled> ยาสามัญประจำบ้าน</label>
</form></td>
        </tr>
    </table>
    <br /><br />
    <div class="tab">
        <button class="tablinks" onclick="openTab(event, 'FIRST')">เอกสารหลักฐาน</button>
        <button class="tablinks" onclick="openTab(event, 'SECOND')">บทสรุปโดยรวม (Overall Summary)</button>
        <button class="tablinks" onclick="openTab(event, 'THIRD')">ข้อมูลผลิตภัณฑ์</button>
        <button class="tablinks" onclick="openTab(event, 'FOUR')">ข้อมูลของอาการหรือโรคที่ใช้รักษา</button>
        <button class="tablinks" onclick="openTab(event, 'FIVE')">ข้อมูลด้านประสิทธิภาพและความปลอดภัยจากการใช้ยา</button>
        <button class="tablinks" onclick="openTab(event, 'SIX')" data-toggle="modal" data-target="#popup1">เอกสารอ้างอิงด้านประสิทธิภาพและความปลอดภัยจากการใช้ยา</button>
    </div>
    <div id="FIRST" class="tabcontent">
        <table width="100%" border="1">
            <tr>
                <td rowspan="2" align="center" width="50%"><b>เอกสารหลักฐาน</b></td>
                <td rowspan="2" align="center" width="10%"><b>แฟ้ม / หน้า</b></td>
                <td colspan="2" align="center" width="15%"><b>ผู้ยื่นขอ</b></td>
                <td colspan="2" align="center" width="15%"><b>เจ้าหน้าที่ตรวจสอบ</b></td>
                <td rowspan="2" align="center"><b>หมายเหตุ</b></td>
            </tr>
            <tr>
                <td align="center" width="7%"><b>มี</b></td>
                <td align="center" width="8%"><b>ไม่มี</b></td>
                <td align="center" width="7%"><b>มี</b></td>
                <td align="center" width="8%"><b>ไม่มี</b></td>
            </tr>
            <tr>
                <td>คำขอเปลี่ยนประเภทยาแผนปัจจุบันสำหรับมนุษย์ ระบุข้อความครบถ้วนพร้อมลงนาม</td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
            </tr>
            <tr>
                <td>แบบตรวจสอบการยื่นเอกสารประกอบการขอเปลี่ยนประเภทยาฯ พร้อมลงนามยืนยันความครบถ้วนถูกต้องของเอกสาร</td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
            </tr>
            <tr>
                <td>สำเนาใบอนุญาต กรณีผู้ยื่นคำขอเป็นผู้รับอนุญาต</td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
            </tr>
            <tr>
                <td>หนังสือมอบอำนาจ ที่ระบุอำนาจให้ยื่นคำขอรวมถึงเอกสาร หลักฐาน แก้ไขเพิ่มเติม รับทราบ ติดตามผลการพิจารณา และยกเลิกคำขอพร้อมรับคำขอเอกสาร หลักฐานคืน สำเนาบัตรประชาชนผู้มอบและผู้รับมอบอำนาจ พร้อมติดอากรแสตมป์ 30 บาท (กรณีมอบอำนาจมาเพื่อดำเนินการ)</td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
            </tr>
            <tr>
                <td colspan="7"><b>รายการเอกสารประกอบการพิจารณา</b></td>
            </tr>
        </table>
    </div>
    <div id="SECOND" class="tabcontent">
        <table width="100%" border="1">
            <tr>
                <td rowspan="2" align="center" width="50%"><b>เอกสารหลักฐาน</b></td>
                <td rowspan="2" align="center" width="10%"><b>แฟ้ม / หน้า</b></td>
                <td colspan="2" align="center" width="15%"><b>ผู้ยื่นขอ</b></td>
                <td colspan="2" align="center" width="15%"><b>เจ้าหน้าที่ตรวจสอบ</b></td>
                <td rowspan="2" align="center"><b>หมายเหตุ</b></td>
            </tr>
            <tr>
                <td align="center" width="7%"><b>มี</b></td>
                <td align="center" width="8%"><b>ไม่มี</b></td>
                <td align="center" width="7%"><b>มี</b></td>
                <td align="center" width="8%"><b>ไม่มี</b></td>
            </tr>
            <tr>
                <td><b>ส่วนที่ 1 บทสรุปโดยรวม (Overall Summary)</b></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
            </tr>
            <tr>
                <td><span style="padding-left:10px;">บทสรุปของข้อมูลผลิตภัณฑ์</span></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
            </tr>
            <tr>
                <td><span style="padding-left: 20px;">- &nbsp; ข้อมูลทั่วไปของผลิตภัณฑ์โดยสรุป</span></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
            </tr>
            <tr>
                <td><span style="padding-left: 20px;">- &nbsp; ตารางเปรียบเทียบข้อมูลผลิตภัณฑ์ที่เสนอเปลี่ยนประเภทยา เช่น ฉลาก เอกสารกำกับยา ขนาดบรรจุ ขนาดการใช้ยา</span></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
            </tr>
            <tr>
                <td>บทสรุปของข้อมูลของอาการหรือโรคที่ใช้รักษา</td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
            </tr>
            <tr>
                <td>บทสรุปของข้อมูลด้านประสิทธิภาพและความปลอดภัยจากการใช้ยา</td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
            </tr>
            <tr>
                <td>เหตุผลการขอเปลี่ยนประเภทยา (rationale of reclassification)</td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
            </tr>
            <tr>
                <td><span style="padding-left: 20px;">- &nbsp; มีการอธิบายคุณลักษณะของยาที่ยื่นขอเปลี่ยนประเภทว่าเข้าคุณลักษณะยาประเภทนั้นๆ อย่างไร</span></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
            </tr>
            <tr>
                <td><span style="padding-left: 20px;">- &nbsp; มีการชี้แจงเหตุผลในการขอเปลี่ยนประเภทยาที่เหมาะสม โดยอ้างอิงจากข้อมูลด้านประสิทธิภาพและความปลอดภัย การประเมินความเสี่ยง การจัดการความเสี่ยง ผลดีต่อระบบสาธารณสุข เป็นต้น</span></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
            </tr>
        </table>
    </div>
    <div id="THIRD" class="tabcontent">
        <table width="100%" border="1">
            <tr>
                <td rowspan="2" align="center" width="50%"><b>เอกสารหลักฐาน</b></td>
                <td rowspan="2" align="center" width="10%"><b>แฟ้ม / หน้า</b></td>
                <td colspan="2" align="center" width="15%"><b>ผู้ยื่นขอ</b></td>
                <td colspan="2" align="center" width="15%"><b>เจ้าหน้าที่ตรวจสอบ</b></td>
                <td rowspan="2" align="center"><b>หมายเหตุ</b></td>
            </tr>
            <tr>
                <td align="center" width="7%"><b>มี</b></td>
                <td align="center" width="8%"><b>ไม่มี</b></td>
                <td align="center" width="7%"><b>มี</b></td>
                <td align="center" width="8%"><b>ไม่มี</b></td>
            </tr>
            <tr>
                <td><b>ส่วนที่ 2 ข้อมูลผลิตภัณฑ์</b></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
            </tr>
            <tr>
                <td>1.สมบัติของตัวยาสำคัญ</td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
            </tr>
            <tr>
                <td><span style="padding-left: 10px;">1.1 คุณสมบัติทางเคมีและความคงตัวของตัวยาในเภสัชภัณฑ์</span></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
            </tr>
            <tr>
                <td><span style="padding-left: 10px;">1.2 คุณสมบัติทางเภสัชวิทยา</span></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
            </tr>
            <tr>
                <td>2.ข้อมูลเสนอเปลี่ยนแปลงประเภทยา</td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
            </tr>
            <tr>
                <td><span style="padding-left: 10px;">2.1 ตัวยาสำคัญและปริมาณตัวยาสำคัญต่อหน่วยการใช้ยา</span></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
            </tr>
            <tr>
                <td><span style="padding-left: 10px;">2.2 ข้อบ่งใช้และขนาดการใช้ยา</span></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
            </tr>
            <tr>
                <td><span style="padding-left: 20px;">2.2.1 ชี้แจงได้ว่ามีข้อบ่งใช้และ / หรือวิธีการใช้ยาที่เหมาะสมต่อคุณลักษณะของประเภทยาที่จะขอเปลี่ยน เช่น กรณีขอเปลี่ยนประเภทเป็นยาอันตราย ต้องมีวิธีการใช้ยาที่ไม่ต้องอยู่ภายใต้การกำกับดูแลของแพทย์ โดยเภสัชกรสามารถให้คำแนะนำแก่ผู้ใช้ยาได้อย่างเหมาะสมและปลอดภัย</span></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
            </tr>
            <tr>
                <td><span style="padding-left: 10px;">2.3 ฉลากและเอกสารการกำกับยา</span></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
            </tr>
            <tr>
                <td><span style="padding-left: 20px;">2.3.1 กรณีขอจัดประเภทเป็นยาสามัญประจำบ้านหรือยาที่ไม่ใช่ยาอันตรายหรือยาควบคุมพิเศษให้แนบ Patient Information Leaflet (PIL) ตามประกาศ สำนักงานคณะกรรมการอาหารและยา เรื่อง แนวทางการจัดทำเอกสารกำกับยาเพิ่มเติม</span></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
            </tr>
            <tr>
                <td><span style="padding-left: 10px;">2.4 ขนาดบรรจุ</span></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
            </tr>
            <tr>
                <td><span style="padding-left: 20px;">2.4.1 มีขนาดบรรจุที่เหมาะสมกับคุณลักษณะของประเภทยาที่จะขอเปลี่ยน เช่น กรณีที่ขอจัดประเภทเป็นยาสามัญประจำบ้าน ให้ชี้แจงว่าขนาดบรรจุมีความเหมาะสมที่จะใช้เพื่อรักษาด้วยตนเอง</span></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
            </tr>
            <tr>
                <td>3.ข้อมูลผลิตภัณฑ์ตามที่ขึ้นทะเบียนตำรับยาไว้</td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
            </tr>
            <tr>
                <td><span style="padding-left: 10px;">3.1 ชื่อผลิตภัณฑ์</span></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
            </tr>
            <tr>
                <td><span style="padding-left: 10px;">3.2 เลขที่ทะเบียนตำรับยา</span></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
            </tr>
            <tr>
                <td><span style="padding-left: 10px;">3.3 ชื่อและปริมาณตัวยาสำคัญ</span></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
            </tr>
            <tr>
                <td><span style="padding-left: 10px;">3.4 รูปแบบยา</span></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
            </tr>
            <tr>
                <td><span style="padding-left: 20px;">3.4.1 ไม่เป็นรูปแบบยาฉีด</span></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
            </tr>
            <tr>
                <td><span style="padding-left: 10px;">3.5 ข้อบ่งใช้</span></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
            </tr>
            <tr>
                <td><span style="padding-left: 10px;">3.6 ขนาดการใช้ยา</span></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
            </tr>
            <tr>
                <td><span style="padding-left: 10px;">3.7 วิธีการบริหารยา</span></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
            </tr>
            <tr>
                <td><span style="padding-left: 10px;">3.8 คำเตือน ข้อห้ามใช้ ข้อควรระวัง</span></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
            </tr>
            <tr>
                <td><span style="padding-left: 10px;">3.9 ขนาดบรรจุ</span></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
            </tr>
            <tr>
                <td><span style="padding-left: 10px;">3.10 อายุการใช้ยาและสภาวะการเก็บรักษา</span></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
            </tr>
            <tr>
                <td><span style="padding-left: 10px;">3.11 ฉลากและเอกสารกำกับยา โดยแนบเอกสารจริง</span></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
            </tr>
            <tr>
                <td>4. ข้อมูลการทะเบียน และสถานทางกฎหมายในประเทศต่างๆ</td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
            </tr>
            <tr>
                <td><span style="padding-left: 10px;">4.1 สถานะการขึ้นทะเบียนผลิตภัณฑ์ในประเทศต่างๆ ระยะเวลาที่จำหน่ายในประเทศต่างๆ ในแต่ละสถานะ และหลักฐานการขึ้นทะเบียนสถานะนั้นในประเทศต่างๆ</span></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
            </tr>
            <tr>
                <td><span style="padding-left: 10px;">4.2 สถานะการขึ้นทะเบียนผลิตภัณฑ์ในกลุ่มข้อบ่งใช้เดียวกันในประเทศไทย</span></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
            </tr>
        </table>
    </div>
    <div id="FOUR" class="tabcontent">
        <table width="100%" border="1">
            <tr>
                <td rowspan="2" align="center" width="50%"><b>เอกสารหลักฐาน</b></td>
                <td rowspan="2" align="center" width="10%"><b>แฟ้ม / หน้า</b></td>
                <td colspan="2" align="center" width="15%"><b>ผู้ยื่นขอ</b></td>
                <td colspan="2" align="center" width="15%"><b>เจ้าหน้าที่ตรวจสอบ</b></td>
                <td rowspan="2" align="center"><b>หมายเหตุ</b></td>
            </tr>
            <tr>
                <td align="center" width="7%"><b>มี</b></td>
                <td align="center" width="8%"><b>ไม่มี</b></td>
                <td align="center" width="7%"><b>มี</b></td>
                <td align="center" width="8%"><b>ไม่มี</b></td>
            </tr>
            <tr>
                <td><b>ส่วนที่ 3 ข้อมูลของอาการหรือโรคที่ใช้รักษา</b></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
            </tr>
            <tr>
                <td>1.ระบาดวิทยาและธรรมชาติของโรค</td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
            </tr>
            <tr>
                <td>2.อาการของโรคและอาการแทรกซ้อน</td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
            </tr>
            <tr>
                <td>3.การวินิจฉัยโรคและผลที่ตามมาหากวินิจฉัยโรคหรืออาการผิดพลาด</td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
            </tr>
            <tr>
                <td>4.การป้องกันโรค</td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
            </tr>
            <tr>
                <td>5.บรรณานุกรม</td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
            </tr>
        </table>
    </div>
    <div id="FIVE" class="tabcontent">
        <table width="100%" border="1">
            <tr>
                <td rowspan="2" align="center" width="50%"><b>เอกสารหลักฐาน</b></td>
                <td rowspan="2" align="center" width="10%"><b>แฟ้ม / หน้า</b></td>
                <td colspan="2" align="center" width="15%"><b>ผู้ยื่นขอ</b></td>
                <td colspan="2" align="center" width="15%"><b>เจ้าหน้าที่ตรวจสอบ</b></td>
                <td rowspan="2" align="center"><b>หมายเหตุ</b></td>
            </tr>
            <tr>
                <td align="center" width="7%"><b>มี</b></td>
                <td align="center" width="8%"><b>ไม่มี</b></td>
                <td align="center" width="7%"><b>มี</b></td>
                <td align="center" width="8%"><b>ไม่มี</b></td>
            </tr>
            <tr>
                <td><b>ส่วนที่ 4 ข้อมูลด้านประสิทธิภาพและความปลอดภัยจากการใช้ยา</b></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
            </tr>
            <tr>
                <td>1.ภาพรวมของข้อมูลด้านคลินิกและข้อมูลที่ไม่ใช่ข้อมูลด้านคลินิก (Non-clinical and clinical overview)</td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
            </tr>
            <tr>
                <td>2.ข้อมูลด้านความปลอดภัย (Safety data)</td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
            </tr>
            <tr>
                <td>
                    <span style="padding-left: 10px;">
                        2.1 สรุปอุบัติการณ์การเกิด ADR type A และ B จากรายงานความปลอดภัยหลังจัดจำหน่ายที่จัดทำรูปแบบ PSUR (Periodic Satety Update Report) ย้อนหลัง 5 ปี ในประเทศไทย และประเทศอื่นๆ อาทิเช่น USA, UK, Japan, AUS, ASEAN เป็นต้น โดยต้องจัดทำตาม ICH Guideline E2C หรือจากการศึกษาการเฝ้าระวังหลังออกสู่ตลาด (Post-marketing surveillance studies (PMS))<br />
                        (หมายเหตุ-รายงานความปลอดภัยหลังจัดจำหน่ายย้อนหลัง 5 ปี ในประเทศไทยควรมา จากข้อมูลของศูนย์เฝ้าระวังความปลอดภัยด้านผลิตภัณฑ์สุขภาพ สำนักงานคณะกรรมการอาหารและยา และข้อมูลจากบริษัทยา)
                    </span>
                </td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
            </tr>
            <tr>
                <td><span style="padding-left: 20px;">2.1.1 ความถี่ในการเกิด อาการไม่พึงประสงค์ชนิดเอ (ADR Type A) ที่ร้ายแรงที่ระดับพบได้บ่อยมาก-พบได้ปานกลาง</span></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
            </tr>
            <tr>
                <td><span style="padding-left: 20px;">2.1.2 ความถี่ในการเกิด อาการที่ไม่พึงประสงค์ชนิดบี (ADR Type B) ที่ร้ายแรงที่ระดับพบได้บ่อยมาก-พบได้น้อย</span></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
            </tr>
            <tr>
                <td><span style="padding-left: 10px;">2.2 ความปลอดภัยจากการใช้ยาในกลุ่มผู้ที่มีภาวะเสี่ยงสูง (Vulnerable groups)</span></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
            </tr>
            <tr>
                <td><span style="padding-left: 20px;">2.2.1 ผลิตภัณฑ์ควรมีความเสี่ยงต่ำโดยมีข้อมูลสนับสนุนเป็นอย่างดีในกลุ่มผู้ป่วยเฉพาะ เช่น ผู้สูงอายุ หญิงตั้งครรภ์ หญิงให้นมบุตร และผู้ป่วยที่มีความผิดปกติของไตและตับ และ / หรือมีการบริหารจัดการความเสี่ยง (Risk Management) แล้วแต่กรณี</span></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
            </tr>
            <tr>
                <td><span style="padding-left: 10px;">2.3 การประเมินความเสี่ยงด้านความปลอดภัย (Risk Assessment of Drug Safety) หรือความเสี่ยงด้านความปลอดภัยในการใช้ยา (Safety concern) และการบริหารจัดการความเสี่ยง (Risk management)</span></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
            </tr>
            <tr>
                <td><span style="padding-left: 20px;">2.3.1 มีความเป็นพิษทั่วไปสูง</span></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
            </tr>
            <tr>
                <td><span style="padding-left: 20px;">2.3.2 มีความเป็นพิษต่อระบบสืบพันธุ์ ยีน หรือเป็นสารก่อกลายพันธุ์</span></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
            </tr>
            <tr>
                <td><span style="padding-left: 20px;">2.3.3 มีโอกาสทำให้เกิดอันตรายทางอ้อมที่ร้ายแรงจากการรักษาซึ่งไปบดบังอาการที่แท้จริง ซึ่งต้องการความดูแลของแพทย์ เช่น โรคมะเร็ง หรือโรคหัวใจ แม้จะใช้อย่างถูกวิธี หากใช้ยาโดยปราศจากการควบคุมของแพทย์</span></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
            </tr>
            <tr>
                <td><span style="padding-left: 10px;">2.4 การประเมินความเสี่ยงจากการใช้ยาเกินขนาด (Risk Assessment of Drug Overdose)</span></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
            </tr>
            <tr>
                <td><span style="padding-left: 10px;">2.5 อันตรกิริยาระหว่างยา และะ / หรือระหว่างยากับอาหาร (Drug Interaction and / or Food-Drug Interaction)</span></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
            </tr>
            <tr>
                <td><span style="padding-left: 20px;">2.5.1 มีอันตรายรุนแรงที่เกิดจากปฏิกิริยาระหว่างยากับยาที่ใช้กันทั่วไป หรือเกิดจากปฏิกิริยาระหว่างยากับอาหาร</span></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
            </tr>
            <tr>
                <td><span style="padding-left: 10px;">2.6 การนำยาไปใช้ในทางที่ผิด (Misuse and / or Abuse)</span></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
            </tr>
            <tr>
                <td><span style="padding-left: 20px;">2.6.1 เป็นยาที่มีผลกระทบทางลบต่อสังคมอย่างมาก เช่น ยาที่มีฤทธิ์เสพติดหรือออกฤทธิ์ต่อจิตและประสาท ยาที่เมื่อมีการใช้ในทางที่ผิดจะนำไปสู่การติดยา เป็นยาที่อาจนำไปใช้ในทางที่ผิดในวัตถุประสงค์ที่ฝ่าฝืนกฏหมาย อาจทำให้เกิดเชื้อดื้อยาเพิ่มขึ้น เป็นต้น</span></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
            </tr>
            <tr>
                <td><span style="padding-left: 10px;">2.7 ข้อมูลความคุ้มค่าของการใช้ยา (ถ้ามี)</span></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
            </tr>
            <tr>
                <td>
                    3.ข้อมูลด้านประสิทธิภาพทางคลินิก (Clinical Efficacy data)<br />
                    ข้อมูลเกี่ยวกับประสิทธิภาพหรือประสบการณ์การใช้ยาทางคลินิก (เฉพาะกรณีที่บ่งใช้ ปริมาณตัวยาสำคัญ และขนาดการใช้ยาตรงกับที่ขึ้นทะเบียนไว้)
                </td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
            </tr>
        </table>
    </div>
    <div id="SIX" class="tabcontent"></div>

    <br />
    <p>ข้าพเจ้าขอรับรองว่าเอกสารประกอบการพิจารณาประเมินการเปลี่ยนสถานะยาที่แนบมา พร้อมคำขอเปลี่ยนประเภทยานี้เป็นหลักฐานที่ถูกต้อง และหากสำนักยามีข้อสงสัยต่อเอกสารดังกล่าว ข้าพเจ้าพร้อมชี้แจงและให้ข้อมูลเพิ่มเติมเพื่อประกอบการพิจารณา</p>
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
    <br />
    @*<p style="font-size:large">ผลการตรวจสอบเอกสารและหลักฐานประกอบการขอเปลี่ยนประเภทยาแผนปัจจุบันสำหรับมนุษย์ (สำหรับเจ้าหน้าที่)</p>
        <br />
        <p style="font-size:medium"><b><u>ครั้งที่ 1</u></b></p>
        <table style="width:100%">
            <tr>
                <td width="2%"></td>
                <td width="98%"><input type="checkbox" />&nbsp; รับ &nbsp;<input type="checkbox" />&nbsp; ไม่รับ &nbsp;<input type="checkbox" />&nbsp; แก้ไข</td>
            </tr>
        </table>
        <br /><br /><br /><br /><br /><br /><br /><br /><br /><br />
        <table style="width:100%">
            <tr>
                <td style="width:50%; text-align:center"></td>
                <td style="width:10%; text-align:right">(ลายมือชื่อ)</td>
                <td style="width:20%; text-align:center"></td>
                <td style="width:20%; text-align:start">ผู้ตรวจรับคำขอ</td>
            </tr>
            <tr>
                <td style="width:50%; text-align:center"></td>
                <td style="width:10%; text-align:right">(</td>
                <td style="width:20%; text-align:center"></td>
                <td style="width:20%; text-align:start">)</td>
            </tr>
            <tr>
                <td style="width:50%; text-align:center"></td>
                <td style="width:10%; text-align:right">วันที่</td>
                <td style="width:20%; text-align:center"></td>
                <td style="width:20%; text-align:start"></td>
            </tr>
        </table>
        <br />
        <p style="font-size:medium">การแก้ไข</p>
        <br /><br /><br /><br /><br /><br /><br /><br /><br /><br />
        <table style="width:100%">
            <tr>
                <td style="width:50%; text-align:center"></td>
                <td style="width:10%; text-align:right">(ลายมือชื่อ)</td>
                <td style="width:10%; text-align:center"></td>
                <td style="width:30%; text-align:center">ผู้รับอนุญาต / ผู้ยื่นคำขอ</td>
            </tr>
            <tr>
                <td style="width:50%; text-align:center"></td>
                <td style="width:10%; text-align:right">(</td>
                <td style="width:10%; text-align:center"></td>
                <td style="width:30%; text-align:center">)</td>
            </tr>
            <tr>
                <td style="width:50%; text-align:center"></td>
                <td style="width:10%; text-align:right">วันที่</td>
                <td style="width:10%; text-align:center"></td>
                <td style="width:30%; text-align:start"></td>
            </tr>
        </table>
        <p style="font-size:medium"><b><u>ครั้งที่ 2</u></b></p>
        <table style="width:100%">
            <tr>
                <td width="2%"></td>
                <td width="98%"><input type="checkbox" />&nbsp; รับ &nbsp;<input type="checkbox" />&nbsp; ไม่รับ &nbsp;<input type="checkbox" />&nbsp; แก้ไข</td>
            </tr>
        </table>
        <br /><br /><br /><br /><br /><br /><br /><br /><br /><br />
        <table style="width:100%">
            <tr>
                <td style="width:50%; text-align:center"></td>
                <td style="width:10%; text-align:right">(ลายมือชื่อ)</td>
                <td style="width:20%; text-align:center"></td>
                <td style="width:20%; text-align:start">ผู้ตรวจรับคำขอ</td>
            </tr>
            <tr>
                <td style="width:50%; text-align:center"></td>
                <td style="width:10%; text-align:right">(</td>
                <td style="width:20%; text-align:center"></td>
                <td style="width:20%; text-align:start">)</td>
            </tr>
            <tr>
                <td style="width:50%; text-align:center"></td>
                <td style="width:10%; text-align:right">วันที่</td>
                <td style="width:20%; text-align:center"></td>
                <td style="width:20%; text-align:start"></td>
            </tr>
        </table>
        <br />
        <p style="font-size:medium">การแก้ไข</p>
        <br /><br /><br /><br /><br /><br /><br /><br /><br /><br />
        <table style="width:100%">
            <tr>
                <td style="width:50%; text-align:center"></td>
                <td style="width:10%; text-align:right">(ลายมือชื่อ)</td>
                <td style="width:10%; text-align:center"></td>
                <td style="width:30%; text-align:center">ผู้รับอนุญาต / ผู้ยื่นคำขอ</td>
            </tr>
            <tr>
                <td style="width:50%; text-align:center"></td>
                <td style="width:10%; text-align:right">(</td>
                <td style="width:10%; text-align:center"></td>
                <td style="width:30%; text-align:center">)</td>
            </tr>
            <tr>
                <td style="width:50%; text-align:center"></td>
                <td style="width:10%; text-align:right">วันที่</td>
                <td style="width:10%; text-align:center"></td>
                <td style="width:30%; text-align:start"></td>
            </tr>
        </table>
        <br />
        <table style="width:90%" align="center" border="1">
            <tr>
                <td style="width:50%">
                    <input type="checkbox" />&nbsp; คืนคำขอ<br /><br />
                    ลงชื่อ<span style="padding-left: 190px;">ผู้ตรวจรับคำขอ</span><br />
                    <span style="padding-left: 20px;">(</span><span style="padding-left: 190px;">)</span><br />
                    วันที่
                </td>
                <td style="width:50%">
                    <input type="checkbox" />&nbsp; ได้รับคำขอคืนแล้ว<br /><br />
                    ลงชื่อ<span style="padding-left: 130px;">ผู้รับอนุญาต / ผู้ยื่นคำขอ</span>
                    <span style="padding-left: 20px;">(</span><span style="padding-left: 190px;">)</span><br />
                    วันที่
                </td>
            </tr>
        </table>*@
</div>
<script>
    function openTab(evt, Type) {
        var i, tabcontent, tablinks;

        tabcontent = document.getElementsByClassName("tabcontent");
        for (i = 0; i < tabcontent.length; i++) {
            tabcontent[i].style.display = "none";
        }

        tablinks = document.getElementsByClassName("tablinks");
        for (i = 0; i < tablinks.length; i++) {
            tablinks[i].className = tablinks[i].className.replace(" active", "");
        }

        document.getElementById(Type).style.display = "block";
        evt.currentTarget.className += " active";
    }
    document.getElementById("defaultOpen").click();
</script>

<div class="modal fade" id="popup1" tabindex="-1" role="dialog" aria-label="exampleModalCenterTitle" aria-hidden="true">
    <div class="modal-dialog modal-dialog-centered" role="document">
        <div class="modal-content">
            <div class="modal-header">
                <h5 class="modal-title" id="exampleModalLongTitle></h5>
                <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                    <span aria-hidden="true"></span>
                </button>
            </div>
            <div class="modal-body">
                <div>เอกสารส่วนนี้ส่งในแบบ............</div>
            </div>
            <div class="modal-footer">
                <button type="button" class="btn btn-secondary" data-dismiss="modal">Close</button>
            </div>
        </div>
    </div>
</div>