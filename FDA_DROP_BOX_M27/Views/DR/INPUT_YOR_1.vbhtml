@Code ViewData("Title") = "INPUT_YOR_1" End Code

<script src="~/Scripts_angular/ANGULAR_APP.js"></script>
<script src="~/Scripts_angular/CENTER_SV.js"></script>
<script src="~/Scripts_angular/DR_CTRL.js"></script>
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
<div ng-app="" ng-controller="">
    <div class="ic" style="font-family:'Taviraj';width:100%">
        <div>
            <p style="text-align: right;">แบบ ย.1</p>
            <p style="text-align: right;">FORM MA-1</p>

        </div>
        <table style="width:100%">
            <tr>
                <td style="width:35%"></td>
                <td style="width:35%"></td>
                <td style="width:5%;text-align:right">เลขที่:</td>
                <td style=" width:25%;text-align:center"></td>
            </tr>
        </table>
        <table style="width:100%">
            <tr>
                <td style="width:35%"></td>
                <td style="width:35%"></td>
                <td style="width:5%;text-align:right">วันที่:</td>
                <td style=" width:25%;text-align:center"></td>
            </tr>
        </table>
        <table style="width:100%">
            <tr>
                <td style="width:35%"></td>
                <td style="width:35%"></td>
                <td style="width:5%;text-align:right"> ลงชื่อ:</td>
                <td style=" width:15%;text-align:center"></td>
                <td style="width:10%">ผู้รับคำขอ</td>
            </tr>
        </table>


        <h1 style="text-align: center;"> คำขอขึ้นทะเบียนตำรับยา</h1>
        <div>
            <div>
                <p style="text-align: center;">
                    <label>ประเภท</label> <input type="radio" /> ยาแผนปัจจุบัน <input type="radio" /> ยาแผนโบราณ
            </div> <p style="text-align: center;">
                <input type="radio" /> ผลิต <input type="radio" /> แบ่งบรรจุ <input type="radio" /> นำเเข้าหรือสั่งเข้ามาในราชอาณาจักร
        </div>
        <table style="width:100%">
            <tr>
                <td style="width:35%;text-align:right">ใบอนุญาตเลขที่ :</td>
                <td style="width:35%"></td>
                <td style="width:30%"></td>
            </tr>
            <tr>
                <h4>๑.รายละเอียดของผู้ยื่นคำขอและผู้ผลิต</h4>
            </tr>
        </table>
        <div> &nbsp; &nbsp; &nbsp;๑.๑ ชื่อและที่อยู่ของผู้ยื่นคำขอ (ผู้รับอนุญาตผลิต ผู้รับอนุญาตนำหรือสั่งยาเข้ามาในราชอาณาจักร)</div>
        <table style="width:100%">
            <tr>
                <td style=" width:15%;text-align:right"> ชื่อผู้รับอนุญาต :</td>
                <td style=" width:85%;text-align:center"></td>
            </tr>
            <tr>
                <td style=" width:15%;text-align:right">อยู่เลขที่ :</td>
                <td style=" width:85%;text-align:center"></td>
            </tr>
        </table>
        <table style="width:100%">
            <tr>
                <td style="width:15%;text-align:right">ประเทศ :</td>
                <td style="width:40%;text-align:center"></td>
                <td style="width:10%;text-align:right">โทรศัพท์/โทรสาร :</td>
                <td style="width:35%" text-align:center></td>
            </tr>
        </table>
        <div> &nbsp; &nbsp; &nbsp;๑.๒ ชื่อและที่อยุ่ของผู้ผลิตสำเร็จรูป</div>
        <table style="width:100%">
            <tr>
                <td style=" width:15%;text-align:right"> ชื่อผู้ผลิตยาสำเร็จรูป :</td>
                <td style=" width:85%;text-align:center"></td>
            </tr>
            <tr>
                <td style=" width:15%;text-align:right">อยู่เลขที่ :</td>
                <td style=" width:85%;text-align:center"></td>
            </tr>
        </table>
        <table style="width:100%">
            <tr>
                <td style="width:15%;text-align:right">ประเทศ :</td>
                <td style="width:85%" text-align:center></td>
            </tr>
        </table>
        <div> &nbsp; &nbsp; &nbsp;๑.๓ ชื่อและที่อยู่ของผู้ผลิตที่ทำหน้าที่แบ่งบรรจุ</div>
        <table style="width:100%">
            <tr>
                <td style=" width:15%;text-align:right">ชื่อผู้แบ่งบรรจุปฐมภูมิ :</td>
                <td style=" width:85%;text-align:center"></td>
            </tr>
            <tr>
                <td style=" width:15%;text-align:right">อยู่เลขที่ :</td>
                <td style=" width:85%;text-align:center"></td>
            </tr>
        </table>
        <table style="width:100%">
            <tr>
                <td style="width:15%;text-align:right">ประเทศ :</td>
                <td style="width:35%" text-align:center></td>
            </tr>
            <tr>
                <td style=" width:15%;text-align:right">ชื่อผู้แบ่งบรรจุทุติยภูมิ :</td>
                <td style=" width:85%;text-align:center"></td>
            </tr>
            <tr>
                <td style=" width:15%;text-align:right">อยู่เลขที่ :</td>
                <td style=" width:85%;text-align:center"></td>
            </tr>
        </table>
        <table style="width:100%">
            <tr>
                <td style="width:15%;text-align:right">ประเทศ :</td>
                <td style="width:85%" text-align:center></td>
            </tr>
        </table>
        <div>&nbsp; &nbsp; &nbsp;๑.๔ ชื่อและที่อยู่ของผู้ผลิตที่รับผิดชอบในการตรวจปล่อยหรือผ่านเพื่อจำหน่าย</div>
        <table style="width:100%">
            <tr>
                <td style="width:33%;text-align:right">&nbsp; &nbsp; &nbsp; ชื่อผู้ผลิตที่รับผิดชอบในการตรวจปล่อยหรือผ่านเพื่อจำหน่าย :</td>
                <td style=" width:72%;text-align:center"></td>
            </tr>
        </table>
        <table style="width:100%">
            <tr>
                <td style="width:15%;text-align:right">อยู่เลขที่ :</td>
                <td style="width:85%"></td>
            </tr>
            <tr>
                <td style="width:15%;text-align:right">ประเทศ :</td>
                <td style="width:85%"></td>
            </tr>
        </table>
        <div>&nbsp; &nbsp; &nbsp;๑.๕ รายละเอียดผู้ผลิตที่เกี่ยวข้อง</div>
        <table style="width:100%">
            <tr>
                <td style="width:50%;text-align:center">ชื่อและที่อยู่</td>
                <td style="width:50%;text-align:center">หน้าที่รับผิดชอบในขั้นตอนการผลิต**</td>
            </tr>
        </table>
        <table style="width:100%" border="1">
            <tr>
                <td style="width:50%;text-align:center"></td>
                <td style="width:50%;text-align:center"></td>
            </tr>
        </table>
        <br />
        <div style="text-align:center">** ตัวอย่างเช่น การเตรียมผลิตภัณฑ์กึ่งสำเร็จรูป, การบรรจุผลิตภัณฑ์, การทำ granulation, ผู้ผลิต bulk finished dosage form เป็นต้น</div>
        <br />
        <br />
        <div> <h4>๒. รายละเอียดของผลิตภัณฑ์</h4></div>
        <div>&nbsp; &nbsp; &nbsp;๒.๑ รายละเอียดของผลิตภัณฑ์</div>
        <table style="width:100%" border="1">
            <tr>
                <td style="width:10%;text-align:right">ชื่อยา :</td>
                <td style="width:90%"></td>
            </tr>
            <tr>
                <td style="width:10%;text-align:right">รูปแบบยา :</td>
                <td style="width:90%"></td>
            </tr>
            <tr>
                <td style="width:10%;text-align:right">ความแรง :</td>
                <td style="width:90%"></td>
            </tr>
            <tr>
                <td style="width:10%;text-align:right">ขนาดบรรจุ :</td>
                <td style="width:90%"></td>
            </tr>
        </table>
        <tr>
            <div>&nbsp; &nbsp; &nbsp;๒.๒ ลักษณะยา :</div>
            <td style="width:90%"></td>
        </tr>
        <div>&nbsp; &nbsp; &nbsp;๒.๓ ชื่อและปริมาณของตัวยาสำำคัญและส่วนประกอบในตำรับยา</div>

        <table style="width:100%">
            <tr>
                <td style="width:5%">Each</td>
                <td style="width:10%;text-align:center"></td>
                <td style="width:10%;text-align:center"></td>
                <td style="width:75%;text-align:start">Contains</td>
            </tr>
        </table>
        <table style="width:100%" border="1">
            <tr>
                <td style="width:5%;text-align:center">ลำดับ</td>
                <td style="width:30%;text-align:center">ชื่อสามัญ/ชื่อวัตถุ</td>
                <td style="width:10%;text-align:center">ปริมาณ</td>
                <td style="width:5%;text-align:center">หน่วย</td>
                <td style="width:3%;text-align:center">ประเภท</td>
                <td style="width:20%;text-align:center">เอกสารอ้างอิง</td>
                <td style="width:27%;text-align:center">หมายเหตุ</td>
            </tr>
            <tr>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
            </tr>
        </table>
        <br />
        <div>
            &nbsp; &nbsp; &nbsp;๒.๔ รายการขนาดบรรจุที่แนบท้ายคำขอ
        </div>
        <table style="width:100%">
            <tr>
                <td style="width:100%;text-align:center"></td>
            </tr>
        </table>

        <br />
        @*<div><h4>๓.ยาตัวอย่าง</h4></div>
            <div><h4>๔.หลักฐานแสดงข้อมูลด้านวิชาการของตำรับยา</h4></div>
            <div> &nbsp; &nbsp; &nbsp;๔.๑ เอกสารด้านคุณภาพ</div>
            <div> &nbsp; &nbsp; &nbsp;๔.๒ เอกสารด้านความปลอดภับ</div>
            <div> &nbsp; &nbsp; &nbsp;๔.๓ เอกสารด้านประสิทธิภาพ</div>
            <div><h4>๕. ฉลากและเอกสารกำกับยา</h4></div>
            <div><h4>๖. หนังสือรับรองเกี่ยวกับผู้ผลิตและการจำหน่ายผลิตภัณฑ์สำหรับกรณีที่เป็นยานำเข้า อย่างน้อยต้องประกอบด้วย</h4></div>
            <div><h4>&nbsp; &nbsp; &nbsp;หนังสือรับรองมาตรฐานการผลิตหรือเอกสารอื่นที่เกี่ยวข้อง หนังสือรับรองการจำหน่ายา</h4></div>
            <div><h4>๗. เอกสารแสดงเลขที่คำขอรับสิทธิบัตรหรืออนุสิทธิบัตรที่ประกาศโฆษณาแล้วตามกฏหมายว่าด้วยสิทธิบัตร หรือข้อมูลจด</h4></div>
            <div><h4>&nbsp; &nbsp; &nbsp;ทะเบียนสิทธิภูมิปัญญาการแพทย์แผนไทยส่วนบุคคลภูมิปัญญาที่เป็นตำรับยาแผนไทยทั่วไปหรือตำราการแพทย์แผนไทย</h4></div>
            <div><h4>&nbsp; &nbsp; &nbsp;ทั่วไป หรือการได้รับอนุญาตให้ใช้ประโยชน์จากตำรับยาแผนไทยของชาติ หรือตำราการแพทย์แผนไทยของชาติตาม</h4></div>
            <div><h4>&nbsp; &nbsp; &nbsp;กฏหมายว่าด้วยการคุ้มครองและส่งเสริมภูมิปัญญาการแพทย์แผนไทย (ถ้ามี)</h4></div>
            <div><h4>๘. หลักฐานอื่น ๆ ตามที่สำนักงานคณะกรรมการอาหารและยากำหนด</h4></div>*@
        <table style="width:100%">
            <tr>
                <td style="width:50%;text-align:center"></td>
                <td style="width:10%;text-align:right">(ลายมือชื่อ)</td>
                <td style="width:20%;text-align:center"></td>
                <td style="width:20%;text-align:start">ผู้รับอนุญาต</td>
            </tr>
        </table>
        <table style="width:100%">
            <tr>
                <td style="width:50%;text-align:center"></td>
                <td style="width:10%;text-align:right">(</td>
                <td style="width:20%;text-align:center"></td>
                <td style="width:20%;text-align:start">) (ตัวบรรจง)</td>
            </tr>
        </table>
        <hr />
        <div>หมายเหตุ : &nbsp;(๑) ใส่เครื่องหมาย &#10004; ในช่อง [ ] ที่ต้องการ</div>
        <div>&nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;(๒) กรณีเป็นทะเบียนตำรับยาที่ผลิตหรือแบ่งบรรจุในราชอาณาจักร ผู้ยื่นคำขอตามข้อ ๑.๑ ต้องเป็นผู้รับอนุญาตผลิตยาเท่านั้น</div>
        <div>&nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;(๓) กรณีเป็นทะเบียนตำรับยาที่นำหรือสั่งเข้ามาในราชอาณาจักรผู้ยื่นคำขอตามข้อ ๑.๑ ต้องเป็นผู้รับอนุญาตนำหรือสั่งยาเข้ามาในราชอาณาจักรเท่านั้น</div>
        <div>&nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;(๔) ชื่อของผู้ผลิตตามข้อ ๑.๑ - ๑.๔ ในบางกรณีอาจหมายความรวมถึงชื่อสถานที่ผลิตด้วยก็ได้</div>
        <br />
        @*<div style="text-align:center"><h3>รายละเอียดสูตรตำรับที่แนบท้ายคำขอ</h3></div>*@

    </div>
    <div class="in">
        <table class="table" width="100%">
            <tr>
                <td width="30%"><h4><b>โปรดระบุวิธียื่นเอกสารประกอบคำขอ</b></h4></td>
                <td><input type="radio" />&nbsp;&nbsp;&nbsp;&nbsp;  1. ยื่นผ่านระบบ eReview/docuBridge</td>
            </tr>
            <tr>
                <td></td>
                <td><input type="radio" />&nbsp;&nbsp;&nbsp;&nbsp; 2. ยื่นผ่านระบบ Skynet Smart Dropbox</td>
            </tr>
            <tr>
                <td></td>
                <td><input type="radio" />&nbsp;&nbsp;&nbsp;&nbsp; 3. ยื่นผ่านระบบ PDF ผ่านระบบนี้</td>
            </tr>
            <tr>
                <td></td>
                <td><input type="radio" />&nbsp;&nbsp;&nbsp;&nbsp; 4. ยื่นผ่านระบบ walk in</td>
            </tr>
            <tr>
                <td>กรณีเลือกข้อ 1 และ 2 ให้ระบุเลข identifier/รหัสอ้างอิง</td>
                <td>
                    <input type="text" class="form-control" />
                </td>
            </tr>

        </table>
        <br />
    </div>
    <div class="in">
        <br />
        <div>
            <h2><b>รายการไฟล์แนบ</b></h2>
        </div>
        <br />
        <div class="tab">
            <button class="tablinks" onclick="openTab(event, 'FIRST')">เอกสารประกอบการขึ้นทะเบียน</button>
            <button class="tablinks" onclick="openTab(event, 'SECOND')">Dose proportionality based biowaiver</button>
            <button class="tablinks" onclick="openTab(event, 'THIRD')">Bioequivalence report</button>
            <button class="tablinks" onclick="openTab(event, 'FORU')">BCS Class I based biowaiver</button>
        </div>
        <div id="FIRST" class="tabcontent">
            <table style="width:100%" border="1">
                <tr>
                    <td style="width:10%" align="center"><b>ลำดับที่</b></td>
                    <td style="width:50%" align="center"><b>รายการตรวจสอบเอกสาร</b></td>
                    <td style="width:20%" align="center"><b>ไฟล์แนบ</b></td>
                    @*<td style="width:10%" align="center"><b>เจ้าหน้าที่ตรวจสอบ</b></td>*@
                    <td style="width:20%" align="center"><b>บันทึกข้อบกพร่อง</b></td>
                </tr>
                <tr>
                    <td style="width:10%" align="center"><b><u>1.</u></b></td>
                    <td colspan="4">
                        <b><u>เอกสารประกอบการขึ้นทะเบียน</u></b>
                    </td>
                </tr>
                <tr>
                    <td style="width:10%" align="center">1</td>
                    <td style="width:50%">
                        กรณียื่นแบบ eCTD โปรดระบุ หมายเลข eCTD identifier .......................................................
                    </td>
                    <td style="width:20%"><input id="file-input" align="center" ng-model="FILE_DATA" type="file" name="file" ngf-select="selectFileforUpload(datas,$files)" /></td>
                    @*<td style="width:10%"></td>*@
                    <td style="width:20%"></td>
                </tr>
                <tr>
                    <td style="width:10%" align="center">2</td>
                    <td style="width:50%">ยาตัวอย่าง (โดยแนบภาพถ่ายของยาตัวอย่าง)</td>
                    <td style="width:20%"><input id="file-input" align="center" ng-model="FILE_DATA" type="file" name="file" ngf-select="selectFileforUpload(datas,$files)" /></td>
                    @*<td style="width:10%"></td>*@
                    <td style="width:20%"></td>
                </tr>
                <tr>
                    <td style="width:10%" align="center">3</td>
                    <td style="width:50%">เอกสารวิชาการประกอบการขึ้นทะเบียนตำรับยา (Technicals Dossiers)</td>
                    <td style="width:20%"><input id="file-input" align="center" ng-model="FILE_DATA" type="file" name="file" ngf-select="selectFileforUpload(datas,$files)" /></td>
                    @*<td style="width:10%"></td>*@
                    <td style="width:20%"></td>
                </tr>
                <tr>
                    <td style="width:10%" align="center">3.1</td>
                    <td style="width:50%">เอกสารด้านคุณภาพ [ ] ยื่นประเมินแบบ eCTD [ ] ยืนประเมินแบบกระดาษ [ ] ยื่นประเมินแบบ NeeS (โปรดแนบไฟล์ในระบบนี้)</td>
                    <td style="width:20%"><input id="file-input" align="center" ng-model="FILE_DATA" type="file" name="file" ngf-select="selectFileforUpload(datas,$files)" /></td>
                    @*<td style="width:10%"></td>*@
                    <td style="width:20%"></td>
                </tr>
                <tr>
                    <td style="width:10%" align="center">3.2</td>
                    <td style="width:50%">
                        เอกสารด้านความปลอดภัย [ ] ยื่นประเมินแบบ eCTD [ ] ยืนประเมินแบบกระดาษ [ ] ยื่นประเมินแบบ NeeS (โปรดแนบไฟล์ในระบบนี้)
                    </td>
                    <td style="width:20%"><input id="file-input" align="center" ng-model="FILE_DATA" type="file" name="file" ngf-select="selectFileforUpload(datas,$files)" /></td>
                    @*<td style="width:10%"></td>*@
                    <td style="width:20%"></td>
                </tr>
                <tr>
                    <td style="width:10%" align="center">3.3</td>
                    <td style="width:50%">
                        เอกสารด้านประสิทธิภาพ [ ] ยื่นประเมินแบบ eCTD [ ] ยืนประเมินแบบกระดาษ [ ] ยื่นประเมินแบบ NeeS (โปรดแนบไฟล์ในระบบนี้)
                    </td>
                    <td style="width:20%"><input id="file-input" align="center" ng-model="FILE_DATA" type="file" name="file" ngf-select="selectFileforUpload(datas,$files)" /></td>
                    @*<td style="width:10%"></td>*@
                    <td style="width:20%"></td>
                </tr>
                <tr>
                    <td style="width:10%" align="center">4</td>
                    <td style="width:50%">ฉลาก</td>
                    <td style="width:20%"><input id="file-input" align="center" ng-model="FILE_DATA" type="file" name="file" ngf-select="selectFileforUpload(datas,$files)" /></td>
                    @*<td style="width:10%"></td>*@
                    <td style="width:20%"></td>
                </tr>
                <tr>
                    <td style="width:10%" align="center">5</td>
                    <td style="width:50%">เอกสารกำกับยา</td>
                    <td style="width:20%"><input id="file-input" align="center" ng-model="FILE_DATA" type="file" name="file" ngf-select="selectFileforUpload(datas,$files)" /></td>
                    @*<td style="width:10%"></td>*@
                    <td style="width:20%"></td>
                </tr>
                <tr>
                    <td style="width:10%" align="center">5.1</td>
                    <td style="width:50%">เอกสารกำกับยาแบบ PI ภาษาไทย</td>
                    <td style="width:20%"><input id="file-input" align="center" ng-model="FILE_DATA" type="file" name="file" ngf-select="selectFileforUpload(datas,$files)" /></td>
                    @*<td style="width:10%"></td>*@
                    <td style="width:20%"></td>
                </tr>
                <tr>
                    <td style="width:10%" align="center">5.2</td>
                    <td style="width:50%">
                        เอกสารกำกับยาแบบ PIL ภาษาไทย
                    </td>
                    <td style="width:20%"><input id="file-input" align="center" ng-model="FILE_DATA" type="file" name="file" ngf-select="selectFileforUpload(datas,$files)" /></td>
                    @*<td style="width:10%"></td>*@
                    <td style="width:20%"></td>
                </tr>
                <tr>
                    <td style="width:10%" align="center">5.3</td>
                    <td style="width:50%">
                        เอกสารกำกับยาแบบ SPC ภาษาไทย
                    </td>
                    <td style="width:20%"><input id="file-input" align="center" ng-model="FILE_DATA" type="file" name="file" ngf-select="selectFileforUpload(datas,$files)" /></td>
                    @*<td style="width:10%"></td>*@
                    <td style="width:20%"></td>
                </tr>
                <tr>
                    <td style="width:10%" align="center">5.4</td>
                    <td style="width:50%">เอกสารกำกับยาแบบ PI ภาษาอังกฤษ</td>
                    <td style="width:20%"><input id="file-input" align="center" ng-model="FILE_DATA" type="file" name="file" ngf-select="selectFileforUpload(datas,$files)" /></td>
                    @*<td style="width:10%"></td>*@
                    <td style="width:20%"></td>
                </tr>
                <tr>
                    <td style="width:10%" align="center">5.5</td>
                    <td style="width:50%">
                        เอกสารกำกับยาแบบ PIL ภาษาอังกฤษ
                    </td>
                    <td style="width:20%"><input id="file-input" align="center" ng-model="FILE_DATA" type="file" name="file" ngf-select="selectFileforUpload(datas,$files)" /></td>
                    @*<td style="width:10%"></td>*@
                    <td style="width:20%"></td>
                </tr>
                <tr>
                    <td style="width:10%" align="center">5.6</td>
                    <td style="width:50%">
                        เอกสารกำกับยาแบบ SPC ภาษาอังกฤษ
                    </td>
                    <td style="width:20%"><input id="file-input" align="center" ng-model="FILE_DATA" type="file" name="file" ngf-select="selectFileforUpload(datas,$files)" /></td>
                    @*<td style="width:10%"></td>*@
                    <td style="width:20%"></td>
                </tr>
                <tr>
                    <td style="width:10%" align="center">5.7</td>
                    <td style="width:50%">
                        เอกสารกำกับยาภาษาอื่น ๆ (ถ้ามี)
                    </td>
                    <td style="width:20%"><input id="file-input" align="center" ng-model="FILE_DATA" type="file" name="file" ngf-select="selectFileforUpload(datas,$files)" /></td>
                    @*<td style="width:10%"></td>*@
                    <td style="width:20%"></td>
                </tr>
                <tr>
                    <td style="width:10%" align="center">6</td>
                    <td style="width:50%">
                        หนังสือรับรองเกี่ยวกับผู้ผลิตและการจำหน่ายผลิตภัณฑ์สำหรับกรณีที่เป็นยานำเข้า อย่างน้อยต้องประกอบด้วย หนังสือรับรองมาตรฐานการผลิตหรือเอกสารอื่นที่เกี่ยวข้อง หนังสือรับรองการจำหน่าย
                    </td>
                    <td style="width:20%"><input id="file-input" align="center" ng-model="FILE_DATA" type="file" name="file" ngf-select="selectFileforUpload(datas,$files)" /></td>
                    @*<td style="width:10%"></td>*@
                    <td style="width:20%"></td>
                </tr>
                <tr>
                    <td style="width:10%" align="center">7</td>
                    <td style="width:50%">เอกสารแสดงเลขที่คำขอรับสิทธิบัตรหรืออนุสิทธิบัตรที่ประกาศโฆษณาแล้วตามกฏหมายว่าด้วยสิทธิบัตร หรือข้อมูลจดทะเบียนสิทธิภูมิปัญญาการแพทย์แผนไทยส่วนบุคคลภูมิปัญญาที่เป็นตำรับยาแผนไทยทั่วไปหรือตำราการแพทย์แผนไทยทั่วไป หรือการได้รับอนุญาตให้ใช้ประโยชน์จากตำรับยาแผนไทยของชาติ หรือตำราการแพทย์แผนไทยของชาติตามกฏหมายว่าด้วยการคุ้มครองและส่งเสริมภูมิปัญญาการแพทย์แผนไทย (ถ้ามี)ง</td>
                    <td style="width:20%"><input id="file-input" align="center" ng-model="FILE_DATA" type="file" name="file" ngf-select="selectFileforUpload(datas,$files)" /></td>
                    @*<td style="width:10%"></td>*@
                    <td style="width:20%"></td>
                </tr>
                <tr>
                    <td style="width:10%" align="center">8</td>
                    <td style="width:50%">หลักฐานอื่น ๆ ตามที่สำนักงานคณะกรรมการอาหารและยากำหนด</td>
                    <td style="width:20%"><input id="file-input" align="center" ng-model="FILE_DATA" type="file" name="file" ngf-select="selectFileforUpload(datas,$files)" /></td>
                    @*<td style="width:10%"></td>*@
                    <td style="width:20%"></td>
                </tr>
                <tr>
                    <td style="width:10%" align="center">8.1</td>
                    <td style="width:50%">ข้อกำหนดมาตรฐานและวิธีวิเคราะห์ (Finnish Products Specification)</td>
                    <td style="width:20%"><input id="file-input" align="center" ng-model="FILE_DATA" type="file" name="file" ngf-select="selectFileforUpload(datas,$files)" /></td>
                    @*<td style="width:10%"></td>*@
                    <td style="width:20%"></td>
                </tr>
                <tr>
                    <td style="width:10%" align="center">8.2</td>
                    <td style="width:50%">คำรับรองในการส่งเอกสารเพิ่มเติมในการศึกษาความคงสภาพของยา</td>
                    <td style="width:20%"><input id="file-input" align="center" ng-model="FILE_DATA" type="file" name="file" ngf-select="selectFileforUpload(datas,$files)" /></td>
                    @*<td style="width:10%"></td>*@
                    <td style="width:20%"></td>
                </tr>
                <tr>
                    <td style="width:10%" align="center">8.3</td>
                    <td style="width:50%">คำรับรองเงื่อนไขการขึ้นทะเบียนตำรับยาเฉพาะกลุ่ม (กรณียาที่จำหน่ายได้เฉพาะในโรงพยาบาล/ สถานพยาบาล)</td>
                    <td style="width:20%"><input id="file-input" align="center" ng-model="FILE_DATA" type="file" name="file" ngf-select="selectFileforUpload(datas,$files)" /></td>
                    @*<td style="width:10%"></td>*@
                    <td style="width:20%"></td>
                </tr>
                <tr>
                    <td style="width:10%" align="center">8.4</td>
                    <td style="width:50%">คำรับรองเงื่อนไขการขึ้นทะเบียนตำรับยาเพื่อการส่งออก</td>
                    <td style="width:20%"><input id="file-input" align="center" ng-model="FILE_DATA" type="file" name="file" ngf-select="selectFileforUpload(datas,$files)" /></td>
                    @*<td style="width:10%"></td>*@
                    <td style="width:20%"></td>
                </tr>
                <tr>
                    <td style="width:10%" align="center">8.5</td>
                    <td style="width:50%">คำรับรองเงื่อนไขอื่น ๆ</td>
                    <td style="width:20%"><input id="file-input" align="center" ng-model="FILE_DATA" type="file" name="file" ngf-select="selectFileforUpload(datas,$files)" /></td>
                    @*<td style="width:10%"></td>*@
                    <td style="width:20%"></td>
                </tr>
                <tr>
                    <td style="width:10%" align="center">8.6</td>
                    <td style="width:50%">หนังสือมอบอำนาจ</td>
                    <td style="width:20%"><input id="file-input" align="center" ng-model="FILE_DATA" type="file" name="file" ngf-select="selectFileforUpload(datas,$files)" /></td>
                    @*<td style="width:10%"></td>*@
                    <td style="width:20%"></td>
                </tr>
                <tr>
                    <td style="width:10%" align="center">8.7</td>
                    <td style="width:50%">เอกสารอื่นๆ</td>
                    <td style="width:20%"><input id="file-input" align="center" ng-model="FILE_DATA" type="file" name="file" ngf-select="selectFileforUpload(datas,$files)" /></td>
                    @*<td style="width:10%"></td>*@
                    <td style="width:20%"></td>
                </tr>
            </table>
        </div>
        <div id="SECOND" class="tabcontent">
            <table width="100%" border="1">
                <tr>
                    <td style="width:10%" align="center"><b>ลำดับที่</b></td>
                    <td style="width:50%" align="center"><b>รายการตรวจสอบเอกสาร</b></td>
                    <td style="width:20%" align="center"><b>ไฟล์แนบ</b></td>
                    @*<td style="width:10%" align="center"><b>เจ้าหน้าที่ตรวจสอบ</b></td>*@
                    <td style="width:20%" align="center"><b>บันทึกข้อบกพร่อง</b></td>
                </tr>
                <tr>
                    <td align="center">1.</td>
                    <td colspan="4">ข้อมูลทั่วไป (Administrative data)</td>
                </tr>
                <tr>
                    <td align="center">1.1</td>
                    <td>หนังสือปะหน้า/หนังสือนำส่ง (Cover letter)</td>
                    <td><input id="file-input" align="center" ng-model="FILE_DATA" type="file" name="file" ngf-select="selectFileforUpload(datas,$files)" /></td>
                    @*<td></td>*@
                    <td></td>
                </tr>
                <tr>
                    <td align="center">1.2</td>
                    <td>หนังสือมอบอำนาจจากผู้รับอนุญาต (Letter of attorney)</td>
                    <td><input id="file-input" align="center" ng-model="FILE_DATA" type="file" name="file" ngf-select="selectFileforUpload(datas,$files)" /></td>
                    @*<td></td>*@
                    <td></td>
                </tr>
                <tr>
                    <td align="center">1.3</td>
                    <td>หนังสือรับรองของผู้ดำเนินการศึกษา (Investigator’s declaration)</td>
                    <td><input id="file-input" align="center" ng-model="FILE_DATA" type="file" name="file" ngf-select="selectFileforUpload(datas,$files)" /></td>
                    @*<td></td>*@
                    <td></td>
                </tr>
                <tr>
                    <td align="center">1.4</td>
                    <td>หนังสือรับรองของผู้ให้ทุนการวิจัย (ถ้ามี) (Sponsor’s declaration) (if available)</td>
                    <td><input id="file-input" align="center" ng-model="FILE_DATA" type="file" name="file" ngf-select="selectFileforUpload(datas,$files)" /></td>
                    @*<td></td>*@
                    <td></td>
                </tr>
                <tr>
                    <td align="center">1.5</td>
                    <td>หนังสือรับรองของผู้ผลิตว่าผลิตภัณฑ์ยาทดสอบเหมือนกับผลิตภัณฑ์ยาที่จะจำหน่ายในประเทศไทย (Letter of confirmation for the sameness of test product to the marketed products in Thailand)</td>
                    <td><input id="file-input" align="center" ng-model="FILE_DATA" type="file" name="file" ngf-select="selectFileforUpload(datas,$files)" /></td>
                    @*<td></td>*@
                    <td></td>
                </tr>
                <tr>
                    <td align="center">1.6</td>
                    <td>หนังสือรับรองผลิตภัณฑ์ยา ผลิตโดย ผู้ผลิต สถานที่ผลิต และกระบวนการผลิตเดียวกัน (Letter of confirmation for the same manufacturer, site and manufacturing process of the products)</td>
                    <td><input id="file-input" align="center" ng-model="FILE_DATA" type="file" name="file" ngf-select="selectFileforUpload(datas,$files)" /></td>
                    @*<td></td>*@
                    <td></td>
                </tr>
                <tr>
                    <td align="center">1.7</td>
                    <td><u>หนังสืออนุมัติรายงานการศึกษาชีวสมมูล ที่ความแรงสูงสุด หรือ สูงกว่าจากสำนักยา หรือ หลักฐานการยื่นคำขออนุมัติรายงานการศึกษาชีวสมมูล (Letter of approval for bioequivalence report from Bureau of Drug control or equality)</u></td>
                    <td><input id="file-input" align="center" ng-model="FILE_DATA" type="file" name="file" ngf-select="selectFileforUpload(datas,$files)" /></td>
                    @*<td></td>*@
                    <td></td>
                </tr>
                <tr>
                    <td align="center">1.8</td>
                    <td>F-D2-121 คำรับรองการปฏิบัติตามหลักเกณฑ์และเงื่อนไขของกองยา</td>
                    <td><input id="file-input" align="center" ng-model="FILE_DATA" type="file" name="file" ngf-select="selectFileforUpload(datas,$files)" /></td>
                    @*<td></td>*@
                    <td></td>
                </tr>
                <tr>
                    <td align="center">1.9</td>
                    <td>สรุปย่อการศึกษา (Study synopsis) ให้จัดทำในรูปแบบตารางที่อ่านได้ง่าย และมีข้อมูล อย่างน้อย ดังต่อไปนี้ Study title, Objectives, Letter of confirmation for the same manufacturer, site and manufacturing process of Test & Reference or Comparator or Innovator product, Letter of approval for bioequivalence report from Bureau of Drug control or equality, Test & Reference or Comparator or Innovator product information (including the Comparison of Descriptions & Compositions) , the Confirmation evidence for proportionality of these product compositions, Supportive evidences for the Linear pharmacokinetic, Batch size, Batch number, Comparative dissolution profile</td>
                    <td><input id="file-input" align="center" ng-model="FILE_DATA" type="file" name="file" ngf-select="selectFileforUpload(datas,$files)" /></td>
                    @*<td></td>*@
                    <td></td>
                </tr>
                <tr>
                    <td align="center">1.10</td>
                    <td>สารบัญ (Table of content)</td>
                    <td><input id="file-input" align="center" ng-model="FILE_DATA" type="file" name="file" ngf-select="selectFileforUpload(datas,$files)" /></td>
                    @*<td></td>*@
                    <td></td>
                </tr>
                <tr>
                    <td align="center">1.11</td>
                    <td>หัวข้อเรื่องที่ทำการศึกษา (Study title)</td>
                    <td><input id="file-input" align="center" ng-model="FILE_DATA" type="file" name="file" ngf-select="selectFileforUpload(datas,$files)" /></td>
                    @*<td></td>*@
                    <td></td>
                </tr>
                <tr>
                    <td align="center">1.12</td>
                    <td>ชื่อและที่อยู่ผู้รับอนุญาต (Name and address of applicant)</td>
                    <td><input id="file-input" align="center" ng-model="FILE_DATA" type="file" name="file" ngf-select="selectFileforUpload(datas,$files)" /></td>
                    @*<td></td>*@
                    <td></td>
                </tr>
                <tr>
                    <td align="center">1.13</td>
                    <td>ชื่อและที่อยู่ผู้ให้ทุนการศึกษา(ถ้ามี) (Name and address of sponsor) (if available)</td>
                    <td><input id="file-input" align="center" ng-model="FILE_DATA" type="file" name="file" ngf-select="selectFileforUpload(datas,$files)" /></td>
                    @*<td></td>*@
                    <td></td>
                </tr>
                <tr>
                    <td align="center">1.14</td>
                    <td>ชื่อและที่อยู่ผู้ผลิต (Name and address of manufacturer)</td>
                    <td><input id="file-input" align="center" ng-model="FILE_DATA" type="file" name="file" ngf-select="selectFileforUpload(datas,$files)" /></td>
                    @*<td></td>*@
                    <td></td>
                </tr>
                <tr>
                    <td align="center">1.15</td>
                    <td>ชื่อและที่อยู่ผู้ดำเนินการศึกษา (Name and address of investigator)</td>
                    <td><input id="file-input" align="center" ng-model="FILE_DATA" type="file" name="file" ngf-select="selectFileforUpload(datas,$files)" /></td>
                    @*<td></td>*@
                    <td></td>
                </tr>
                <tr>
                    <td align="center">1.16</td>
                    <td>ชื่อและที่อยู่สถานที่ทำการศึกษา (Name and address of the laboratory)</td>
                    <td><input id="file-input" align="center" ng-model="FILE_DATA" type="file" name="file" ngf-select="selectFileforUpload(datas,$files)" /></td>
                    @*<td></td>*@
                    <td></td>
                </tr>
                <tr>
                    <td align="center">2.</td>
                    <td colspan="4">เอกสารสนับสนุนการขอยกเว้นการศึกษาชีวสมมูลฯ แบบ Dose proportionality (Justification for the Dose proportionality based biowaiver)</td>
                </tr>
                <tr>
                    <td align="center">2.1</td>
                    <td>วัตถุประสงค์ (Objectives)</td>
                    <td><input id="file-input" align="center" ng-model="FILE_DATA" type="file" name="file" ngf-select="selectFileforUpload(datas,$files)" /></td>
                    @*<td></td>*@
                    <td></td>
                </tr>
                <tr>
                    <td align="center">2.2</td>
                    <td>
                        บทนำ (Introduction / Overall summary for Dose proportionality based biowaiver report)<br />
                        โปรดระบุรายละเอียดของภาพรวมสำหรับ รายงานการศึกษาการขอยกเว้นการศึกษาชีวสมมูลฯ แบบ Dose proportionality
                    </td>
                    <td><input id="file-input" align="center" ng-model="FILE_DATA" type="file" name="file" ngf-select="selectFileforUpload(datas,$files)" /></td>
                    @*<td></td>*@
                    <td></td>
                </tr>
                <tr>
                    <td align="center">2.3</td>
                    <td>
                        ข้อมูลตัวยาสำคัญ (API) (โปรดดูรายละเอียดหัวข้อ/เนื้อหาที่ต้องการในหมายเหตุ)
                        <a data-toggle="modal" data-target="#popup1" style="color:red">
                            ดูรายละเอียด กดที่นี่
                        </a>
                    </td>
                    <td><input id="file-input" align="center" ng-model="FILE_DATA" type="file" name="file" ngf-select="selectFileforUpload(datas,$files)" /></td>
                    @*<td></td>*@
                    <td></td>
                </tr>
                <tr>
                    <td align="center">2.4</td>
                    <td>เภสัชจลนศาสตร์ของตัวยา มีความสัมพันธ์เชิงเส้นตรงกับขนาดยา (Linear pharmacokinetic) โปรดอภิปราย อย่างกระชับ ชัดเจน ได้ใจความ และแนบเอกสารอ้างอิง</td>
                    <td><input id="file-input" align="center" ng-model="FILE_DATA" type="file" name="file" ngf-select="selectFileforUpload(datas,$files)" /></td>
                    @*<td></td>*@
                    <td></td>
                </tr>
                <tr>
                    <td align="center">2.5</td>
                    <td>
                        ข้อมูลผลิตภัณฑ์ยา (Product information) (โปรดดูรายละเอียดหัวข้อ/เนื้อหาที่ต้องการในหมายเหตุ)<br />
                        <a data-toggle="modal" data-target="#popup2" style="color:red">
                            ดูรายละเอียด กดที่นี่
                        </a>
                    </td>
                    <td><input id="file-input" align="center" ng-model="FILE_DATA" type="file" name="file" ngf-select="selectFileforUpload(datas,$files)" /></td>
                    @*<td></td>*@
                    <td></td>
                </tr>
                <tr>
                    <td align="center">2.6</td>
                    <td colspan="4">
                        ข้อกำหนดมาตรฐานและวิธีการวิเคราะห์ รายการ การทดสอบ วิธีการทดสอบ วิธีการวิเคราะห์ และเกณฑ์ที่ใช้ในการพิจารณาการยอมรับผลิตภัณฑ์ยา (Specifications, Test method, Analytical procedure & Acceptance criteria or limit)***<br />
                        <font style="color:red">***ข้อกำหนดมาตรฐานและวิธีการวิเคราะห์ ตามตำรายาที่รัฐมนตรีประกาศเทียบเท่าหรือใหม่กว่า หรือ วิธีของผู้ผลิต (In-house method) หรือ ICH guidelines Q6A specification: Test procedures and Acceptance criteria for New substances and New drug products: Chemical substances***</font> (โปรดดูรายละเอียดหัวข้อ/เนื้อหาที่ต้องการในหมายเหตุ)
                        <a data-toggle="modal" data-target="#popup3" style="color:red">
                            ดูรายละเอียด กดที่นี่
                        </a>
                    </td>
                </tr>
                <tr>
                    <td align="center">2.7</td>
                    <td>เอกสารอ้างอิง (References) โปรดแนบเอกสารอ้างอิง ที่มี highlight พร้อมแสดง crosslink กับข้อมูลในคำขอฯ ให้ครบถ้วน ทุกหัวข้อ</td>
                    <td><input id="file-input" align="center" ng-model="FILE_DATA" type="file" name="file" ngf-select="selectFileforUpload(datas,$files)" /></td>
                    @*<td></td>*@
                    <td></td>
                </tr>
                <tr>
                    <td align="center">2.8</td>
                    <td colspan="4">
                        สรุปรายละเอียดของผลิตภัณฑ์ที่ทดสอบ (โปรดระบุรายละเอียดของผลิตภัณฑ์ให้ครบถ้วน)
                        <a data-toggle="modal" data-target="#popup4" style="color:red">
                            ดูรายละเอียด กดที่นี่
                        </a>
                    </td>
                </tr>
            </table>
        </div>
        <br />
        <br />
        <br />
        <div style="text-align:center">
            <button class="btn btn-lg">บันทึก</button>
            <button class="btn btn-lg" ng-click="BTN_BACK()">ย้อนกลับ</button>
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
                <div></div>
            </div>
            <div class="modal-footer">
                <button type="button" class="btn btn-secondary" data-dismiss="modal">Close</button>
            </div>
        </div>
    </div>
</div>

<div class="modal fade" id="popup2" tabindex="-1" role="dialog" aria-label="exampleModalCenterTitle" aria-hidden="true">
    <div class="modal-dialog modal-dialog-centered" role="document">
        <div class="modal-content">
            <div class="modal-header">
                <h5 class="modal-title" id="exampleModalLongTitle></h5>
                <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                    <span aria-hidden="true"></span>
                </button>
            </div>
            <div class="modal-body">
                <div>เอกสารต้องประกอบด้วยหัวข้ออย่างน้อยดังต่อไปนี้</div>
                <table width="100%" border="1">
                    <tr>
                        <td width="10%" align="center">ลำดับ</td>
                        <td align="center">รายการ</td>
                    </tr>
                    <tr>
                        <td>2.5.1</td>
                        <td>General information, Uses and administration, Pharmacodynamics, Pharmacokinetics, Adverse effects and Precautions (โปรดดูรายละเอียดหัวข้อ/เนื้อหาที่ต้องการในหมายเหตุ)</td>
                    </tr>
                    <tr>
                        <td align="center">2.5.2</td>
                        <td>
                            ผลิตภัณฑ์ยาทดสอบ (Test product)<br />
                            <span style="margin-left:2em">- ชื่อการค้า (Trade name)</span><br />
                            <span style="margin-left:2em">- ตัวยาสำคัญ (API)</span><br />
                            <span style="margin-left:2em">- ความแรง (Strength)</span><br />
                            <span style="margin-left:2em">- รูปแบบยา (Dosage form)</span><br />
                            <span style="margin-left:2em">- ชื่อและที่อยู่ผู้ผลิต (Name and address of manufacturer)</span><br />
                            <span style="margin-left:2em">- ชื่อและที่อยู่ผู้นำสั่งยาเข้ามาในราชอาณาจักร (ถ้ามี) (Name and address of importer) (if available)</span><br />
                            <span style="margin-left:2em">- รุ่นที่ผลิต (Batch number)</span><br />
                            <span style="margin-left:2em">- วันที่ผลิต (Date of manufacture)</span><br />
                            <span style="margin-left:2em">- วันหมดอายุ (Expiry date)</span><br />
                            <span style="margin-left:2em">- Batch size มีขนาดเท่าไหร่ หากน้อยกว่า 100,000 หน่วย ต้องแนบเอกสารเพิ่มเติมตามเงื่อนไขและเอกสารที่ต้องยื่นประกอบการพิจารณารุ่นการผลิตนำร่อง (Pilot batch) ที่น้อยกว่า 100,000 หน่วยหรือหนังสืออนุมัติ ทั้งนี้ต้องแสดง Batch record ประกอบ การพิจารณา</span><br />
                            <span style="margin-left:2em">- ลักษณะยาและส่วนประกอบของผลิตภัณฑ์ยา (Description and Composition of product)***</span><br />
                            แสดงรายละเอียดรูปแบบ ลักษณะเฉพาะของ ผลิตภัณฑ์ยา น้ำหนักหรือปริมาตรรวมต่อหน่วย<br />
                            แสดงชื่อและปริมาณส่วนประกอบในตำรับยาต่อหน่วย ซึ่งต้องสอดคล้องกับ สูตรยาต่อรุ่นการผลิต (Batch formula)<br />
                            <span style="margin-left:2em">- สูตรยาต่อรุ่นการผลิต จำนวนผลิตภัณฑ์ยาที่ผลิตต่อรุ่นการผลิต ปริมาณที่ Overage และกระบวนการผลิต (Batch formula, Production batch and Manufacturing process)***</span><br />
                            <font style="color:red">***กรณีที่มีการ  Overage : ข้อมูลใน Batch formula ให้แสดงปริมาณที่ Overage และแจ้ง % Overage พร้อมทั้งแสดงการคำนวณ Overage ให้ชัดเจน***</font><br />
                            <span style="margin-left:2em">- Finish Product Specification (FPS)</span><br />
                            <span style="margin-left:2em">- หนังสือรับรองการวิเคราะห์ของผลิตภัณฑ์ ยาทดสอบ (COA of test product)</span>
                        </td>
                    </tr>
                    <tr>
                        <td align="center">2.5.3</td>
                        <td>
                            ผลิตภัณฑ์ยาอ้างอิง หรือ ผลิตภัณฑ์ยาเปรียบเทียบ หรือ ผลิตภัณฑ์ยาต้นแบบ ซึ่งใช้เป็นผลิตภัณฑ์ยาความแรงเปรียบเทียบ (Reference or Comparator or Innovator product that be selected for the Reference strength drug product)<br />
                            <span style="margin-left:2em">- ชื่อการค้า (Trade name)</span><br />
                            <span style="margin-left:2em">- เลขทะเบียนตำรับยา (Drug Registration Number)</span><br />
                            <span style="margin-left:2em">- ตัวยาสำคัญ (API)</span><br />
                            <span style="margin-left:2em">- ความแรง (Strength)</span><br />
                            <span style="margin-left:2em">- รูปแบบยา (Dosage form)</span><br />
                            <span style="margin-left:2em">- ชื่อและที่อยู่ผู้ผลิต (Name and address of manufacturer)</span><br />
                            <span style="margin-left:2em">- ชื่อและที่อยู่ผู้นำสั่งยาเข้ามาในราชอาณาจักร (ถ้ามี) (Name and address of importer) (if available)</span><br />
                            <span style="margin-left:2em">- รุ่นที่ผลิต (Batch number)</span><br />
                            <span style="margin-left:2em">- วันที่ผลิต (Date of manufacture)</span><br />
                            <span style="margin-left:2em">- วันหมดอายุ (Expiry date)</span><br />
                            <span style="margin-left:2em">- ลักษณะยาและส่วนประกอบของผลิตภัณฑ์ยา (Description and Composition of product)***</span><br />
                            แสดงรายละเอียดรูปแบบ ลักษณะเฉพาะของ ผลิตภัณฑ์ยา น้ำหนักหรือปริมาตรรวมต่อหน่วย<br />
                            แสดงชื่อ หน้าที่และปริมาณส่วนประกอบในตำรับยาต่อหน่วย<br />
                            <span style="margin-left:2em">- หนังสือรับรองการวิเคราะห์ของยาอ้างอิง หรือ ผลิตภัณฑ์ยาเปรียบเทียบ หรือ ผลิตภัณฑ์ยาต้นแบบ  (COA of  Reference or Comparator or Innovator product)</span>
                        </td>
                    </tr>
                    <tr>
                        <td align="center">2.5.4</td>
                        <td>
                            ตารางแสดงการเปรียบเทียบ ลักษณะยาและส่วนประกอบของผลิตภัณฑ์ยา ระหว่างผลิตภัณฑ์ยาทดสอบ และผลิตภัณฑ์ยาอ้างอิง หรือ ผลิตภัณฑ์ยาเปรียบเทียบ หรือ ผลิตภัณฑ์ยาต้นแบบ (Tabulation of the Comparison for Description & Composition of Test & Reference or Comparator or Innovator product) เพื่อยืนยันความเป็น proportionality<br />
                            <span style="margin-left:2em">- โดยแสดงรายละเอียดการเปรียบเทียบ ตามหัวข้อในแบบ ย.1 หน้า 3 (Page No. 3 of Form MA-1 สำหรับคำขอขึ้นทะเบียนตำรับยา) พร้อมแสดงหน้าที่ของส่วนประกอบแต่ละตัวในตำรับยา และร้อยละของส่วนประกอบในตำรับ-ยาต่อหน่วย เทียบกับน้ำหนักหรือปริมาตรรวมต่อหน่วย</span><br />
                            <span style="margin-left:2em">- กรณีสูตรตำรับยา มีความเบี่ยงเบนไปจาก ความเป็น proportionality เช่น potent drug  มีปริมาณไม่เกิน 5% ของ core weight หรือ 10 mg ต่อเม็ด เป็นต้น</span><br />
                            โปรดชี้แจง และอภิปรายเหตุผล
                        </td>
                    </tr>
                </table>
            </div>
            <div class="modal-footer">
                <button type="button" class="btn btn-secondary" data-dismiss="modal">Close</button>
            </div>
        </div>
    </div>
</div>

<div class="modal fade" id="popup3" tabindex="-1" role="dialog" aria-label="exampleModalCenterTitle" aria-hidden="true">
    <div class="modal-dialog modal-dialog-centered" role="document">
        <div class="modal-content">
            <div class="modal-header">
                <h5 class="modal-title" id="exampleModalLongTitle></h5>
                <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                    <span aria-hidden="true"></span>
                </button>
            </div>
            <div class="modal-body">
                <div>เอกสารต้องประกอบด้วยหัวข้ออย่างน้อยดังต่อไปนี้</div>
                <table width="100%" border="1">
                    <tr>
                        <td width="10%" align="center">ลำดับ</td>
                        <td align="center">รายการ</td>
                    </tr>
                </table>
            </div>
            <div class="modal-footer">
                <button type="button" class="btn btn-secondary" data-dismiss="modal">Close</button>
            </div>
        </div>
    </div>
</div>

<div class="modal fade" id="popup4" tabindex="-1" role="dialog" aria-labelledby="exampleModalCenterTitle" aria-hidden="true">
    <div class="modal-dialog modal-dialog-centered" role="document">
        <div class="modal-content">
            <div class="modal-header">
                <h5 class="modal-title" id="exampleModalLongTitle></h5>
                <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                    <span aria-hidden="true"></span>
                </button>
            </div>
            <div class="modal-body">
                <table width="100%" border="1">
                    <tr>
                        <td width="40%" align="center">รายการ</td>
                        <td width="25%" align="center">☐ Test product</td>
                        <td width="35%" align="center">☐ Reference or ☐ Comparator or ☐ Innovator product</td>
                    </tr>
                    <tr>
                        <td>☐ ตัวยาสำคัญ (API)</td>
                        <td></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>☐ ความแรง (Strength)</td>
                        <td></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>☐ รูปแบบยา (Dosage form)</td>
                        <td></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>☐ ชื่อการค้า (Trade name)</td>
                        <td></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>☐ เลขทะเบียนตำรับยา</td>
                        <td></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>☐ ชื่อและที่อยู่ของผู้ผลิต</td>
                        <td></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>☐ ชื่อและที่อยู่ของผู้นำสั่งยาเข้ามาในราชอาณาจักร</td>
                        <td></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>☐ Batch number</td>
                        <td></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>☐ Batch size</td>
                        <td></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>☐ Manufactured date</td>
                        <td></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>☐ Expired date</td>
                        <td></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>☐ ตัวยาสำคัญ (API)</td>
                        <td></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>☐ Certificate Of Analysis</td>
                        <td></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>☐ สูตรตำรับ<u>เหมือน</u>กับที่จะนำเข้ามาในราชอาณาจักร</td>
                        <td></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>☐ Content of Active ingredient(s) [% Label amount]</td>
                        <td></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td colspan="3">☐ Uniformity of dosage unit</td>
                    </tr>
                    <tr>
                        <td><span style="padding-left:2em">☐ Weight variation <b><u>หรือ</u></b></span></td>
                        <td></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td><span style="padding-left:2em">☐ Content uniformity</span></td>
                        <td></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td colspan="3">
                            ☐ Dissolution Profile Comparison (Comparative dissolutioin profile) ทดสอบทั้งหมด......................pH<br />
                            ระบุค่า ของแต่ละ pH พร้อมแสดง<br />
                            <span style="padding-left:2em">☐ ⨍₂หรือ</span><br />
                            <span style="padding-left:4em">☐ วิธีทางสถิติอื่นๆ ที่เหมาะสม (โปรดระบุ Statistical model ที่เลือกใช้ พร้อมเหตุผล...................)</span>
                        </td>
                    </tr>
                    <tr>
                        <td width="30%">☐ pH 1.2...............</td>
                        <td colspan="2"></td>
                    </tr>
                    <tr>
                        <td width="30%">☐ pH...............</td>
                        <td colspan="2"></td>
                    </tr>
                    <tr>
                        <td width="30%">☐ pH 4.5...............</td>
                        <td colspan="2"></td>
                    </tr>
                    <tr>
                        <td width="30%">☐ pH...............</td>
                        <td colspan="2"></td>
                    </tr>
                    <tr>
                        <td width="30%">☐ pH 6.8...............</td>
                        <td colspan="2"></td>
                    </tr>
                    <tr>
                        <td width="30%">☐ pH...............</td>
                        <td colspan="2"></td>
                    </tr>
                    <tr>
                        <td width="30%">☐ pH...............</td>
                        <td colspan="2"></td>
                    </tr>
                    <tr>
                        <td width="30%">☐ pH...............</td>
                        <td colspan="2"></td>
                    </tr>
                    <tr>
                        <td width="30%">☐ pH...............</td>
                        <td colspan="2"></td>
                    </tr>
                    <tr>
                        <td width="30%">☐ pH...............</td>
                        <td colspan="2"></td>
                    </tr>
                </table>
            </div>
            <div class="modal-footer">
                <button type="button" class="btn btn-secondary" data-dismiss="modal">Close</button>
            </div>
        </div>
    </div>
</div>