@Code
    ViewData("Title") = "INPUT_F_D2_198_1_UPFILE"
End Code

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
<h2></h2>
<div>
    <div class="ic" style="font-family:'Taviraj'">
        <div>
            <p style="text-align: left; font-size: large"><b><u>แบบตรวจเอกสารคำขอใบอนุญาต : บุคคลธรรมดา</u></b></p>
        </div>

        <div>
            <p style="font-size:medium; text-align: left;">
                <input type="checkbox" />&nbsp; แบบตรวจสอบเอกสารคำขออนุญาต<b> (ขอใหม่) (แนบเอกสารตั้งแต่ 1.5 เป็นต้นไป)<u> วันยื่นคำขอ** กำหนดให้แสดงตัวพร้อมกัน</u> คือ 1.ผู้ยื่นคำขอรับอนุญาตใหม่ / ผู้รับมอบอำนาจ 2.ผู้มีหน้าที่ปฏิบัติการ</b><br />
                <input type="checkbox" />&nbsp; แบบตรวจเอกสารคำขอ<b><u>เปลี่ยนผู้รับอนุญาต</u> (แนบเอกสารตั้งแต่ 1.1 เป็นต้นไป)<u> วันยื่นคำขอ** กำหนดให้แสดงตัวพร้อมกัน</u> คือ 1.ผู้รับอนุญาตเดิม 2.ผู้ยื่นรับคำขอใหม่ / ผู้รับมอบอำนาจ 3.ผู้มีหน้าที่ปฏิบัติการ</b>
        </div>

        <br />

        <div>
            @*<table style="font-size:medium; width:100%" border="1">
            <tr>
                <td style="width:60%">
                    <span style="padding-left: 10px;"></span>ชื่อ-สกุลผู้ยื่นคำขอ / ผู้รับมอบอำนาจ<br />
                    <span style="padding-left: 10px;"></span>โทรศัพท์มือถือ <span style="padding-left: 250px;">E-mail</span><br />
                    <span style="padding-left: 10px;"></span>ชื่อสถานที่ขาย / ผลิต / นำสั่ง<br />
                    <span style="padding-left: 10px;"></span>เลขที่ใบอนุญาตขาย / ผลิต / นำสั่ง
                </td>
                <td style="width:40%">
                    <span style="padding-left: 10px;"></span>*เจ้าหน้าที่รับเอกสารเมื่อครบถ้วนและถูกต้อง*<u>โปรดอ่านเอกสารนี้ และเตรียมเอกสารเรียงลำดับตามรายการ และทำเครื่องหมายในช่อง</u> ผู้ยื่นคำขอ ตรวจสอบ<br />
                    <span style="padding-left: 10px;"></span><b>(มายื่นเรื่องแก้ไขฯ ที่ อย. เท่านั้น ไม่รับยื่นทางไปรษณีย์)</b>
                </td>
            </tr>
        </table>

        <p style="font-size:medium"><b><u>แบบฟอร์มที่ต้องใช้ตามกำหนด</u></b>ของกองยา คือ แบบคำขอทุกประเภท / คำขอฯ / คำรับรองฯ / หนังสือมอบอำนาจกระทำการแทน / หนังสือมอบอำนาจแต่งตั้งผู้ดำเนินกิจการ สอบถามเพิ่มเติมที่ <b><u>(02-590-7200)</u></b> ห้อง 318 งานใบอนุญาต กองยา อย.</p>

        <table style="font-size:medium; width:95%" border="1" align="center">
            <tr>
                <td>
                    <p style="font-size:medium"><b><u>**ดาวน์โหลดแบบฟอร์มเอกสาร</u></b><u> / ฟอร์มถ่ายรูป / แผนที่ / แผนผัง ได้ที่เว็ปไซต์กองยา &rarr; &rarr; &rarr; &rarr; &rarr; ข้อมูล &rarr; &rarr; &rarr; &rarr; &rarr; การบริการคู่มือ &rarr; &rarr; แบบฟอร์ม / คำแนะนำ &rarr; &rarr;</u></p>
                </td>
            </tr>
        </table>
        <p style="font-size:medium">&nbsp; &#10146; &#10146; &#10146; &#10146;<b><u>ขอให้ผู้ยื่นคำขอ จัดเรียงเอกสารตามบัญชีรายการเอกสารข้างล่าง และตรวจสอบด้วยตนเอง พร้อมทั้งทำเครื่องหมาย</u></b></p>
        <p style="font-size:medium">&#10003; &nbsp; กรณีถูกต้องครบถ้วนตามข้อกำหนด หรือทำเครื่องหมาย &nbsp; &#10007; &nbsp; กรณีไม่ถูกต้องหรือไม่ครบถ้วนตามข้อกำหนด หรือเครื่องหมาย &nbsp; &#8213; &nbsp; กรณีไม่จำเป็นต้องมี</p>
        <p style="text-align: left; font-size:medium"><span style="padding-left: 30px;"></span> &#10146; &#10146; &#10146; &#10146; <u>ให้ระบบุวันที่</u> ในเอกสารที่มีให้กรอกวันที่ทุกจุด เช่น คำขอฯ / คำรับรองของผู้ปฏิบัติการ / สัญญาฯ</p>*@

            <div class="tab">
                <button class="tablinks" onclick="openTab(event, 'FIRST')" id="defaultOpen">เอกสารที่ผู้ขออนุญาตต้องเตรียม</button>
                <button class="tablinks" onclick="openTab(event, 'SECOND')">เอกสารที่ผู้มีหน้าที่ปฏิบัติการต้องเตรียม</button>
                <button class="tablinks" onclick="openTab(event, 'THIRD')">เอกสาร</button>
            </div>
            <div id="FIRST" class="tabcontent">
                <table style="width:100%" border="1">
                    <tr>
                        <td style="width:10%" align="center"><b>ลำดับที่</b></td>
                        <td style="width:50%" align="center"><b>รายการตรวจสอบเอกสาร บุคคลธรรมดา</b></td>
                        <td style="width:20%" align="center"><b>ไฟล์แนบ</b></td>
                        @*<td style="width:10%" align="center"><b>เจ้าหน้าที่ตรวจสอบ</b></td>*@
                        <td style="width:20%" align="center"><b>บันทึกข้อบกพร่อง</b></td>
                    </tr>
                    <tr>
                        <td style="width:10%" align="center"><b><u>1.</u></b></td>
                        <td colspan="4">
                            <b><u>เอกสารที่ผู้ขออนุญาตต้องเตรียม</u></b>
                        </td>
                    </tr>
                    <tr>
                        <td style="width:10%" align="center">1.1</td>
                        <td style="width:50%">แบบคำขอเปลี่ยนผู้รับอนุญาต</td>
                        <td style="width:20%"><input id="file-input" align="center" ng-model="FILE_DATA" type="file" name="file" ngf-select="selectFileforUpload(datas,$files)" /></td>
                        @*<td style="width:10%"></td>*@
                        <td style="width:20%"></td>
                    </tr>
                    <tr>
                        <td style="width:10%" align="center">1.2</td>
                        <td style="width:50%">สำเนาบัตรประชาชน (เจ้าของเดิม) เซ็นต์รับรองสำเนาถูกต้อง</td>
                        <td style="width:20%"><input id="file-input" align="center" ng-model="FILE_DATA" type="file" name="file" ngf-select="selectFileforUpload(datas,$files)" /></td>
                        @*<td style="width:10%"></td>*@
                        <td style="width:20%"></td>
                    </tr>
                    <tr>
                        <td style="width:10%" align="center">1.3</td>
                        <td style="width:50%">สำเนาทะเบียนบ้าน (เจ้าของเดิม) เซ็นต์รับรองสำเนาถูกต้อง</td>
                        <td style="width:20%"><input id="file-input" align="center" ng-model="FILE_DATA" type="file" name="file" ngf-select="selectFileforUpload(datas,$files)" /></td>
                        @*<td style="width:10%"></td>*@
                        <td style="width:20%"></td>
                    </tr>
                    <tr>
                        <td style="width:10%" align="center">1.4</td>
                        <td style="width:50%">ใบอนุญาต (ฉบับจริงที่ต่อปีล่าสุด)</td>
                        <td style="width:20%"><input id="file-input" align="center" ng-model="FILE_DATA" type="file" name="file" ngf-select="selectFileforUpload(datas,$files)" /></td>
                        @*<td style="width:10%"></td>*@
                        <td style="width:20%"></td>
                    </tr>
                    <tr>
                        <td style="width:10%" align="center">1.5</td>
                        <td style="width:50%">
                            แบบคำขออนุญาตตามประเภท<br />
                            กรณีเปลี่ยนผู้รับอนุญาตเจ้าของใหม่เป็นผู้ขออนุญาต*<br />
                            <span style="padding-left: 10px;"></span><b><u>เปลี่ยนผู้รับอนุญาต</u></b> สิ่งที่ต้องการเปลี่ยนแปลง ให้แจ้งในใบคำขอนี้)<br />
                            <span style="padding-left: 10px;"></span><b>กรณี : สถานที่เก็บยาอยู่ต่างจังหวัด ต้องยื่นเอกสารทุกรายการทั้งหมด 2 ชุด</b>
                        </td>
                        <td style="width:20%"><input id="file-input" align="center" ng-model="FILE_DATA" type="file" name="file" ngf-select="selectFileforUpload(datas,$files)" /></td>
                        @*<td style="width:10%"></td>*@
                        <td style="width:20%"></td>
                    </tr>
                    <tr>
                        <td style="width:10%" align="center">1.6</td>
                        <td style="width:50%">
                            รูปถ่ายของผู้รับอนุญาต (เจ้าของใหม่ / ผู้ขออนุญาต) ขนาด 3*4 ซม. 3 รูป<br />
                            <u>(หน้าตรง ผมไม่ปิดหน้า ไม่ยิ้ม</u> ไม่สวมแว่นตาดำและหมวก พื้นหลัง (Background) สีเรียบ) ถ่ายไม่เกิน 6 เดือนในวันที่ยื่นคำขอ***
                        </td>
                        <td style="width:20%"><input id="file-input" align="center" ng-model="FILE_DATA" type="file" name="file" ngf-select="selectFileforUpload(datas,$files)" /></td>
                        @*<td style="width:10%"></td>*@
                        <td style="width:20%"></td>
                    </tr>
                    <tr>
                        <td style="width:10%" align="center">1.7</td>
                        <td style="width:50%">สำเนาบัตรประชาชน (เจ้าของใหม่ / ผู้ขออนุญาต) เซ็นต์รับรองสำเนาถูกต้อง</td>
                        <td style="width:20%"><input id="file-input" align="center" ng-model="FILE_DATA" type="file" name="file" ngf-select="selectFileforUpload(datas,$files)" /></td>
                        @*<td style="width:10%"></td>*@
                        <td style="width:20%"></td>
                    </tr>
                    <tr>
                        <td style="width:10%" align="center">1.8</td>
                        <td style="width:50%">สำเนาทะเบียนบ้าน (เจ้าของใหม่ / ผู้ขออนุญาต) เซ็นต์รับรองสำเนาถูกต้อง</td>
                        <td style="width:20%"><input id="file-input" align="center" ng-model="FILE_DATA" type="file" name="file" ngf-select="selectFileforUpload(datas,$files)" /></td>
                        @*<td style="width:10%"></td>*@
                        <td style="width:20%"></td>
                    </tr>
                    <tr>
                        <td style="width:10%" align="center">1.9</td>
                        <td style="width:50%">สำเนาหนังสือขออนุญาตทำงานที่ออกโดยกระทรวงแรงงานฯ และหนังสือเดินทาง (กรณีบุคคลต่างด้าว) เซ็นต์รับรองสำเนาถูกต้อง</td>
                        <td style="width:20%"><input id="file-input" align="center" ng-model="FILE_DATA" type="file" name="file" ngf-select="selectFileforUpload(datas,$files)" /></td>
                        @*<td style="width:10%"></td>*@
                        <td style="width:20%"></td>
                    </tr>
                    <tr>
                        <td style="width:10%" align="center">1.10</td>
                        <td style="width:50%">
                            ใบรับรองแพทย์<u>ตัวจริง</u> (หากไม่มีระบุกำหนดให้ใช้ได้ 1 เดือน ***จะสามารถใช้ได้ไม่เกิน 3 เดือน นับจากวันที่ระบุในใบรับรองแพทย์) พร้อมระบุ <u>5 โรคต้องห้ามเป็น</u> ของผู้รับอนุญาตเกี่ยวกับยา ดังต่อไปนี้<br />
                            <span style="padding-left: 30px;"></span>(1)&nbsp; โรคเรื้อน<br />
                            <span style="padding-left: 30px;"></span>(2)&nbsp; วัณโรคในระยะอันตราย<br />
                            <span style="padding-left: 30px;"></span>(3)&nbsp; โรคเท้าช้างในระยะปรากฏอาการเป็นที่รังเกียจแก่สังคม<br />
                            <span style="padding-left: 30px;"></span>(4)&nbsp; โรคติดยาเสพติดให้โทษอย่างร้ายแรง<br />
                            <span style="padding-left: 30px;"></span>(5)&nbsp; โรคพิษสุราเรื้อรัง
                        </td>
                        <td style="width:20%"><input id="file-input" align="center" ng-model="FILE_DATA" type="file" name="file" ngf-select="selectFileforUpload(datas,$files)" /></td>
                        @*<td style="width:10%"></td>*@
                        <td style="width:20%"></td>
                    </tr>
                    <tr>
                        <td style="width:10%" align="center">1.11</td>
                        <td style="width:50%">หลักทรัพย์ (สำเนาสมุดบัญชีอัพเดตล่าสุด) หรือหนังสือรับรองจากธนาคาร จำนวนเงินตั้งแต่ 10,000 บาทขึ้นไป / สำเนาโฉนดที่ดินไม่ติดภาระผูกพัน</td>
                        <td style="width:20%"><input id="file-input" align="center" ng-model="FILE_DATA" type="file" name="file" ngf-select="selectFileforUpload(datas,$files)" /></td>
                        @*<td style="width:10%"></td>*@
                        <td style="width:20%"></td>
                    </tr>
                    <tr>
                        <td style="width:10%" align="center">1.12</td>
                        <td style="width:50%"><b>สำเนาทะเบียนบ้านของสถานที่ที่อนุญาต</b> เซ็นต์รับรองสำเนาถูกต้อง</td>
                        <td style="width:20%"><input id="file-input" align="center" ng-model="FILE_DATA" type="file" name="file" ngf-select="selectFileforUpload(datas,$files)" /></td>
                        @*<td style="width:10%"></td>*@
                        <td style="width:20%"></td>
                    </tr>
                    <tr>
                        <td style="width:10%" align="center">1.13</td>
                        <td style="width:50%">
                            <b><u>เอกสารแสดงกรรมสิทธิ์ในสถานที่ (ของที่ตั้งตามทะเบียนบ้านในข้อ 1.12) แนบอย่างใดอย่างหนึ่ง**</u></b><br />
                            1.ผู้อนุญาต / ผู้ให้เช่า / ผู้ยินยอมให้ใช้สถานที่ มีชื่อเป็นเจ้าบ้านในทะเบียนบ้าน หรือเป็นผู้ยื่นขอทะเบียนบ้าน<br />
                            2.ผู้อนุญาต / ผู้ให้เช่า / ผู้ยินยอมให้ใช้สถานที่ มีชื่อเป็นผู้ซื้อในสำเนาสัญญาซื้อ-ขาย สิ่งปลูกสร้าง ที่ระบุเลขที่ตั้งตรงกับทะเบียนบ้าน<br />
                            3.ผู้อนุญาต / ผู้ให้เช่า / ผู้ยินยอมให้ใช้สถานที่ มีชื่อเป็นผู้ชำระค่าใช้จ่ายในใบเสร็จที่ระบุที่ตั้งสถานที่ที่ขออนุญาต เช่น ใบเสร็จชำระค่าน้ำ / ค่าไฟ ฯลฯ
                        </td>
                        <td style="width:20%"><input id="file-input" align="center" ng-model="FILE_DATA" type="file" name="file" ngf-select="selectFileforUpload(datas,$files)" /></td>
                        @*<td style="width:10%"></td>*@
                        <td style="width:20%"></td>
                    </tr>
                    <tr>
                        <td style="width:10%" align="center">1.14</td>
                        <td style="width:50%">
                            <b><u>กรณีเช่าสถานที่ (ของที่ตั้งตามทะเบียนบ้านในข้อ 1.12) แนบทุกข้อ</u></b><br />
                            1.สำเนาสัญญาเช่า 1 ฉบับ (ระบุที่อยู่ของสถานที่ที่ให้เช่าครบถ้วนชัดเจนในสัญญาเช่า) เซ็นต์รับรองสำเนาถูกต้อง (เซ็นต์จริงโดยผู้ยื่นขออนุญาต)<br />
                            2.สำเนาเอกสารแสดงกรรมสิทธิ์ในสถานที่ขายยาของผู้ให้เช่า อย่างใดอย่างหนึ่ง ในข้อ 1.13 เซ็นต์รับรองสำเนาถูกต้อง (เซ็นต์จริงโดยผู้ให้เช่า****)<br />
                            3.สำเนาบัตรประชาชน และทะเบียนบ้านของผู้ให้เช่า เซ็นต์รับรองสำเนาถูกต้อง (เซ็นต์จริงโดยผู้ให้เช่า)<br />
                            4.กรณีบริษัทเป็นผู้ให้เช่า ให้ยื่นสำเนาหนังสือรับรองบริษัทที่ออกมาแล้วไม่เกิน 6 เดือน ของบริษัท<u>ผู้ให้เช่า</u> ที่มี<u>ระบุที่ตั้งตรงกับทะเบียนบ้าน</u> (เซ็นต์รับรองสำเนาทุกหน้า โดยกรรมการฯ *จำนวนและประทับตราบริษัท ตามเงื่อนไขของหนังสือรับรองบริษัทนั้น)
                        </td>
                        <td style="width:20%"><input id="file-input" align="center" ng-model="FILE_DATA" type="file" name="file" ngf-select="selectFileforUpload(datas,$files)" /></td>
                        @*<td style="width:10%"></td>*@
                        <td style="width:20%"></td>
                    </tr>
                    <tr>
                        <td style="width:10%" align="center">1.15</td>
                        <td style="width:50%">
                            <b><u>กรณผู้อื่นยินยอมให้ใช้สถานที่ (ของที่ตั้งตามทะเบียนบ้านในข้อ 1.12) แนบทุกข้อ*** (ยินยอมได้ ในกรณีความสัมพันธ์เป็นสามี / ภรรยา / บิดา / มารดา / บุตร เท่านั้น)</u></b><br />
                            1.หนังสือยินยอมให้ใช้สถานที่ฉบับจริง <u>ลงนามโดยผู้มีกรรมสิทธิ์*</u> ยินยอมให้ใช้สถานที่<br />
                            2.เอกสารแสดงรายชื่อผู้มีกรรมสิทธิ์** ในข้อ 1 (ให้ยื่นเอกสารอย่างใดอย่างหนึ่งในข้อ 1.13)<br />
                            3.สำเนาบัตรประชาชนของผู้มีกรรมสิทธิ์ในข้อ 1 เซ็นต์รับรองสำเนาถูกต้อง <u>(เซ็นต์จริง)</u><br />
                            4.สำเนาเอกสารแสดงความสัมพันธ์การเป็นสามี / ภรรยา / บิดา / มารดา / บุตร
                        </td>
                        <td style="width:20%"><input id="file-input" align="center" ng-model="FILE_DATA" type="file" name="file" ngf-select="selectFileforUpload(datas,$files)" /></td>
                        @*<td style="width:10%"></td>*@
                        <td style="width:20%"></td>
                    </tr>
                    <tr>
                        <td style="width:10%" align="center">1.16</td>
                        <td style="width:50%">หนังสือมอบอำนาจกระทำการแทนผู้ขออนุญาต ติดอากรแสตมป์ 10 บาท (กรณีไม่สามารถติดต่อด้วยตนเอง)</td>
                        <td style="width:20%"><input id="file-input" align="center" ng-model="FILE_DATA" type="file" name="file" ngf-select="selectFileforUpload(datas,$files)" /></td>
                        @*<td style="width:10%"></td>*@
                        <td style="width:20%"></td>
                    </tr>
                    <tr>
                        <td style="width:10%" align="center">1.17</td>
                        <td style="width:50%">สำเนาบัตรประชาชนของผู้มอบอำนาจ และผู้รับมอบอำนาจ ในข้อ 1.16 เซ็นต์รับรองสำเนาถูกต้อง</td>
                        <td style="width:20%"><input id="file-input" align="center" ng-model="FILE_DATA" type="file" name="file" ngf-select="selectFileforUpload(datas,$files)" /></td>
                        @*<td style="width:10%"></td>*@
                        <td style="width:20%"></td>
                    </tr>
                </table>
            </div>
            <div id="SECOND" class="tabcontent">
                <table style="width:100%" border="1">
                    <tr>
                        <td style="width:10%" align="center"><b>ลำดับที่</b></td>
                        <td style="width:50%" align="center"><b>รายการตรวจสอบเอกสาร บุคคลธรรมดา</b></td>
                        <td style="width:20%" align="center"><b>ไฟล์แนบ</b></td>
                        @*<td style="width:10%" align="center"><b>เจ้าหน้าที่ตรวจสอบ</b></td>*@
                        <td style="width:20%" align="center"><b>บันทึกข้อบกพร่อง</b></td>
                    </tr>
                    <tr>
                        <td style="width:10%" align="center"><b><u>2.</u></b></td>
                        <td colspan="4">
                            <b><u>เอกสารที่ผู้มีหน้าที่ปฏิบัติการต้องเตรียม</u></b>
                        </td>
                    </tr>
                    <tr>
                        <td style="width:10%" align="center">2.1</td>
                        <td style="width:50%">คำรับรองผู้มีหน้าปฏิบัติการ (ตามประเภท) ต้องมารับรองต่อเจ้าหน้าที่</td>
                        <td style="width:20%"><input id="file-input" align="center" ng-model="FILE_DATA" type="file" name="file" ngf-select="selectFileforUpload(datas,$files)" /></td>
                        @*<td style="width:10%"></td>*@
                        <td style="width:20%"></td>
                    </tr>
                    <tr>
                        <td style="width:10%" align="center">2.2</td>
                        <td style="width:50%">
                            คำรับรองการปฏิบัติงานจากหน่วยงาน (ให้หัวหน้าหน่วยงานเป็นผู้รับรอง และต้องประทับตราหน่วยงานด้วย จึงจะถือว่าสมบูรณ์)<br />
                            ***(กรณีใบอนุญาตขายยา ขย.1 / ขย.3 / ขย.4***)<br />
                            ตามแบบฟอร์มที่สำนักงานคณะกรรมการอาหารและยากำหนด (แบบ ขย.14 หน้า 3)
                        </td>
                        <td style="width:20%"><input id="file-input" align="center" ng-model="FILE_DATA" type="file" name="file" ngf-select="selectFileforUpload(datas,$files)" /></td>
                        @*<td style="width:10%"></td>*@
                        <td style="width:20%"></td>
                    </tr>
                    <tr>
                        <td style="width:10%" align="center">2.3</td>
                        <td style="width:50%">สัญญาระหว่างผู้ขออนุญาตและผู้มีหน้าที่ปฏิการ จำนวน 3 ชุด (ถ้าผู้ขออนุญาตและผู้มีหน้าที่ปฏิบัติการเป็นบุคคลเดียวกัน ไม่ต้องยื่นเอกสารนี้)</td>
                        <td style="width:20%"><input id="file-input" align="center" ng-model="FILE_DATA" type="file" name="file" ngf-select="selectFileforUpload(datas,$files)" /></td>
                        @*<td style="width:10%"></td>*@
                        <td style="width:20%"></td>
                    </tr>
                    <tr>
                        <td style="width:10%" align="center">2.4</td>
                        <td style="width:50%">
                            ใบรับรองแพทย์<u>ตัวจริง</u> (หากไม่มีระบุกำหนดให้ใช้ได้ 1 เดือน ***จะสามารถใช้ได้ไม่เกิน 3 เดือน นับจากวันที่ระบุในใบรับรองแพทย์) พร้อมระบุ <u>5 โรคต้องห้ามเป็น</u> ของผู้รับอนุญาตเกี่ยวกับยา ดังต่อไปนี้<br />
                            <span style="padding-left: 30px;"></span>(1)&nbsp; โรคเรื้อน<br />
                            <span style="padding-left: 30px;"></span>(2)&nbsp; วัณโรคในระยะอันตราย<br />
                            <span style="padding-left: 30px;"></span>(3)&nbsp; โรคเท้าช้างในระยะปรากฏอาการเป็นที่รังเกียจแก่สังคม<br />
                            <span style="padding-left: 30px;"></span>(4)&nbsp; โรคติดยาเสพติดให้โทษอย่างร้ายแรง<br />
                            <span style="padding-left: 30px;"></span>(5)&nbsp; โรคพิษสุราเรื้อรัง
                        </td>
                        <td style="width:20%"></td>
                        @*<td style="width:10%"></td>*@
                        <td style="width:20%"></td>
                    </tr>
                    <tr>
                        <td style="width:10%" align="center">2.5</td>
                        <td style="width:50%">สำเนาใบประกอบโรคศิลปะ หรือสำเนาใบประกอบวิชาชีพ (เซ็นต์รับรองสำเนาถูกต้อง)</td>
                        <td style="width:20%"><input id="file-input" align="center" ng-model="FILE_DATA" type="file" name="file" ngf-select="selectFileforUpload(datas,$files)" /></td>
                        @*<td style="width:10%"></td>*@
                        <td style="width:20%"></td>
                    </tr>
                    <tr>
                        <td style="width:10%" align="center">2.6</td>
                        <td style="width:50%">สำเนาหนังสือรับรองการอบรมการประชุมเชิงปฏิบัติการ หรือสำเนาใบเสร็จรับเงินเข้าร่วมการอบรม <u>สำหรับร้านยา ขย.1</u> (เซ็นต์รับรองสำเนาถูกต้อง)<u> **ติดต่อสมัครที่สภาเภสัชกรรม</u></td>
                        <td style="width:20%"><input id="file-input" align="center" ng-model="FILE_DATA" type="file" name="file" ngf-select="selectFileforUpload(datas,$files)" /></td>
                        @*<td style="width:10%"></td>*@
                        <td style="width:20%"></td>
                    </tr>
                    <tr>
                        <td style="width:10%" align="center">2.7</td>
                        <td style="width:50%">สำเนาผลการค้นหา รายชื่อผู้ประกอบวิชาชีพเภสัชกรรม จากเว็บไซต์สภาเภสัชกรรม <a href="http://www.phamarcycouncil.org/index.php">(http://www.phamarcycouncil.org/index.php)</a> (เซ็นต์รับรองสำเนาถูกต้อง)</td>
                        <td style="width:20%"><input id="file-input" align="center" ng-model="FILE_DATA" type="file" name="file" ngf-select="selectFileforUpload(datas,$files)" /></td>
                        @*<td style="width:10%"></td>*@
                        <td style="width:20%"></td>
                    </tr>
                </table>
                <br />
                <p style="font-size:medium;color:red"><b>*****เอกสารในลำดับที่ 2.5-2.9 ให้ผู้มีหน้าที่ปฏิบัติการลงนามรับรองสำเนาถูกต้องทุกแผ่น*****</b></p>
            </div>
            <div id="THIRD" class="tabcontent">
                <table style="width:100%" border="1">
                    <tr>
                        <td style="width:10%" align="center"><b>ลำดับที่</b></td>
                        <td style="width:50%" align="center"><b>รายการตรวจสอบเอกสาร บุคคลธรรมดา</b></td>
                        <td style="width:20%" align="center"><b>ไฟล์แนบ</b></td>
                        @*<td style="width:10%" align="center"><b>เจ้าหน้าที่ตรวจสอบ</b></td>*@
                        <td style="width:20%" align="center"><b>บันทึกข้อบกพร่อง</b></td>
                    </tr>
                    <tr>
                        <td style="width:10%" align="center"><b><u>3</u></b></td>
                        <td style="width:50%">
                            <b><u>เอกสาร</u></b><br />
                            <u>รูปถ่าย, แผนที่, แผนผัง</u> ของสถานที่ที่ขออนุญาตโดยระบุรายละเอียดที่อยู่ และผู้ขออนุญาตเซ็นต์รับรองทุกหน้า จำนวน 1 ชุด (ใช้แบบฟอร์มรูปถ่าย ของแต่ละประเภทใบอนุญาตให้ถูกต้อง)<br />
                            ***<u>รูปถ่าย</u>ขนาด 4*6 นิ้ว อัดกระดาษโฟโต้จากร้านอัดรูป เท่านั้น และให้ติดรูปบนแบบฟอร์มรูปถ่าย ของแต่ละประเภทใบอนุญาตให้ถูกต้อง<br />
                            <b><u>กรณีขอใบอนุญาตผลิตฯ</u></b><br />
                            ต้องแนบ 1.สำเนาแบบแปลนที่ได้รับการอนุมัติแล้ว เซ็นต์รับรองสำเนาถูกต้อง<u> และ</u> 2.สำเนาบันทึกผลการตรวจสถานที่ที่ระบุว่าเหมาะสม และไม่พบข้อบกพร่อง<br />
                            (เซ็นต์รับรองสำเนาถูกต้องโดยผู้ขออนุญาต** ทุกหน้าในเอกสารทั้ง 2 รายการ)
                        </td>
                        <td style="width:20%"><input id="file-input" align="center" ng-model="FILE_DATA" type="file" name="file" ngf-select="selectFileforUpload(datas,$files)" /></td>
                        @*<td style="width:10%"></td>*@
                        <td style="width:20%"></td>
                    </tr>
                </table>
            </div>
            <br />
        </div>
    </div>
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
