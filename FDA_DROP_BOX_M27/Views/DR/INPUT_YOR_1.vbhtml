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
            <button class="tablinks" onclick="openTab(event, 'FOUR')">BCS Class I based biowaiver</button>
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
                    <td align="center"><b>1.</b></td>
                    <td colspan="4"><b>ข้อมูลทั่วไป (Administrative data)</b></td>
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
                    <td align="center"><b>2.</b></td>
                    <td colspan="4"><b>เอกสารสนับสนุนการขอยกเว้นการศึกษาชีวสมมูลฯ แบบ Dose proportionality (Justification for the Dose proportionality based biowaiver)</b></td>
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
                    <td>
                        ข้อกำหนดมาตรฐานและวิธีการวิเคราะห์ รายการ การทดสอบ วิธีการทดสอบ วิธีการวิเคราะห์ และเกณฑ์ที่ใช้ในการพิจารณาการยอมรับผลิตภัณฑ์ยา (Specifications, Test method, Analytical procedure & Acceptance criteria or limit)***<br />
                        <font style="color:red">***ข้อกำหนดมาตรฐานและวิธีการวิเคราะห์ ตามตำรายาที่รัฐมนตรีประกาศเทียบเท่าหรือใหม่กว่า หรือ วิธีของผู้ผลิต (In-house method) หรือ ICH guidelines Q6A specification: Test procedures and Acceptance criteria for New substances and New drug products: Chemical substances***</font> (โปรดดูรายละเอียดหัวข้อ/เนื้อหาที่ต้องการในหมายเหตุ)
                        <a data-toggle="modal" data-target="#popup3" style="color:red">
                            ดูรายละเอียด กดที่นี่
                        </a>
                    </td>
                    <td><input id="file-input" align="center" ng-model="FILE_DATA" type="file" name="file" ngf-select="selectFileforUpload(datas,$files)" /></td>
                    @*<td></td>*@
                    <td></td>
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
                    <td>
                        สรุปรายละเอียดของผลิตภัณฑ์ที่ทดสอบ (โปรดระบุรายละเอียดของผลิตภัณฑ์ให้ครบถ้วน)
                        <a data-toggle="modal" data-target="#popup4" style="color:red">
                            ดูรายละเอียด กดที่นี่
                        </a>
                    </td>
                    <td><input id="file-input" align="center" ng-model="FILE_DATA" type="file" name="file" ngf-select="selectFileforUpload(datas,$files)" /></td>
                    @*<td></td>*@
                    <td></td>
                </tr>
            </table>
        </div>
        <div id="THIRD" class="tabcontent">
            <table width="100%" border="1">
                <tr>
                    <td style="width:10%" align="center"><b>ลำดับที่</b></td>
                    <td style="width:50%" align="center"><b>รายการตรวจสอบเอกสาร</b></td>
                    <td style="width:20%" align="center"><b>ไฟล์แนบ</b></td>
                    @*<td style="width:10%" align="center"><b>เจ้าหน้าที่ตรวจสอบ</b></td>*@
                    <td style="width:20%" align="center"><b>บันทึกข้อบกพร่อง</b></td>
                </tr>
                <tr>
                    <td align="center"><b>1.</b></td>
                    <td colspan="4"><b>ข้อมูลทั่วไป (Administrative data)</b></td>
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
                    <td>F-D2-121 คำรับรองการปฏิบัติตามหลักเกณฑ์และเงื่อนไขของกองยา</td>
                    <td><input id="file-input" align="center" ng-model="FILE_DATA" type="file" name="file" ngf-select="selectFileforUpload(datas,$files)" /></td>
                    @*<td></td>*@
                    <td></td>
                </tr>
                <tr>
                    <td align="center">1.4</td>
                    <td>
                        เอกสารนำ (Title/Cover page) (โปรดดูรายละเอียดหัวข้อ/เนื้อหาที่ต้องการในหมายเหตุ)
                        <a data-toggle="modal" data-target="#popup5" style="color:red">
                            ดูรายละเอียด กดที่นี่
                        </a>
                    </td>
                    <td><input id="file-input" align="center" ng-model="FILE_DATA" type="file" name="file" ngf-select="selectFileforUpload(datas,$files)" /></td>
                    @*<td></td>*@
                    <td></td>
                </tr>
                <tr>
                    <td align="center">1.5</td>
                    <td>ข้อมูลผลิตภัณฑ์ยาในส่วน P3 การผลิต (Drug product information: P3 Manufacture)</td>
                    <td><input id="file-input" align="center" ng-model="FILE_DATA" type="file" name="file" ngf-select="selectFileforUpload(datas,$files)" /></td>
                    @*<td></td>*@
                    <td></td>
                </tr>
                <tr>
                    <td align="center">1.6</td>
                    <td>หนังสือรับรองพร้อมการลงนามจากผู้เสนอรายงานวิจัย หรือ Sponsor เพื่อยืนยันว่า Biobatch ของผลิตภัณฑ์ยาทดสอบ เป็น batch ที่มีสูตร กระบวนการผลิต และเครื่องมือที่ใช้เหมือนกับ batch ที่จะผลิตเพื่อจำหน่ายในประเทศไทย <font style="color:red">*กรณีมีการเปลี่ยนแปลงสูตรให้แนบหลักฐานการอนุมัติ*</font></td>
                    <td><input id="file-input" align="center" ng-model="FILE_DATA" type="file" name="file" ngf-select="selectFileforUpload(datas,$files)" /></td>
                    @*<td></td>*@
                    <td></td>
                </tr>
                <tr>
                    <td align="center">2</td>
                    <td>สรุปย่อการศึกษา (Study synopsis)</td>
                    <td><input id="file-input" align="center" ng-model="FILE_DATA" type="file" name="file" ngf-select="selectFileforUpload(datas,$files)" /></td>
                    @*<td></td>*@
                    <td></td>
                </tr>
                <tr>
                    <td align="center">3</td>
                    <td>สารบัญ (Table of contents)</td>
                    <td><input id="file-input" align="center" ng-model="FILE_DATA" type="file" name="file" ngf-select="selectFileforUpload(datas,$files)" /></td>
                    @*<td></td>*@
                    <td></td>
                </tr>
                <tr>
                    <td align="center">4</td>
                    <td>คำย่อ และนิยามศัพท์ (Abbreviations and definition of terms)</td>
                    <td><input id="file-input" align="center" ng-model="FILE_DATA" type="file" name="file" ngf-select="selectFileforUpload(datas,$files)" /></td>
                    @*<td></td>*@
                    <td></td>
                </tr>
                <tr>
                    <td align="center"><b>5</b></td>
                    <td colspan="4"><b>บทนำ (Introduction)</b></td>
                </tr>
                <tr>
                    <td align="center">5.1 </td>
                    <td>เภสัชวิทยา (Pharmacology)</td>
                    <td><input id="file-input" align="center" ng-model="FILE_DATA" type="file" name="file" ngf-select="selectFileforUpload(datas,$files)" /></td>
                    @*<td></td>*@
                    <td></td>
                </tr>
                <tr>
                    <td align="center">5.2</td>
                    <td>เภสัชจลนศาสตร์ (Pharmacokinetics)</td>
                    <td><input id="file-input" align="center" ng-model="FILE_DATA" type="file" name="file" ngf-select="selectFileforUpload(datas,$files)" /></td>
                    @*<td></td>*@
                    <td></td>
                </tr>
                <tr>
                    <td align="center">5.3</td>
                    <td>เหตุการณ์ไม่พึงประสงค์ (Adverse Events)</td>
                    <td><input id="file-input" align="center" ng-model="FILE_DATA" type="file" name="file" ngf-select="selectFileforUpload(datas,$files)" /></td>
                    @*<td></td>*@
                    <td></td>
                </tr>
                <tr>
                    <td align="center">6</td>
                    <td>วัตถุประสงค์ (Objectives)</td>
                    <td><input id="file-input" align="center" ng-model="FILE_DATA" type="file" name="file" ngf-select="selectFileforUpload(datas,$files)" /></td>
                    @*<td></td>*@
                    <td></td>
                </tr>
                <tr>
                    <td align="center"><b>7</b></td>
                    <td colspan="4"><b>ข้อมูลผลิตภัณฑ์ยา (Product information)</b></td>
                </tr>
                <tr>
                    <td align="center">7.1</td>
                    <td>
                        ผลิตภัณฑ์ยาทดสอบ (Test Product) (โปรดดูรายละเอียดหัวข้อ/เนื้อหาที่ต้องการในหมายเหตุ)<br />
                        <a data-toggle="modal" data-target="#popup6" style="color:red">
                            ดูรายละเอียด กดที่นี่
                        </a>
                    </td>
                    <td><input id="file-input" align="center" ng-model="FILE_DATA" type="file" name="file" ngf-select="selectFileforUpload(datas,$files)" /></td>
                    @*<td></td>*@
                    <td></td>
                </tr>
                <tr>
                    <td align="center">7.2</td>
                    <td>
                        ผลิตภัณฑ์ยาอ้างอิง (Reference Product) (โปรดดูรายละเอียดหัวข้อ/เนื้อหาที่ต้องการในหมายเหตุ)<br />
                        <a data-toggle="modal" data-target="#popup7" style="color:red">
                            ดูรายละเอียด กดที่นี่
                        </a>
                    </td>
                    <td><input id="file-input" align="center" ng-model="FILE_DATA" type="file" name="file" ngf-select="selectFileforUpload(datas,$files)" /></td>
                    @*<td></td>*@
                    <td></td>
                </tr>
                <tr>
                    <td align="center"><b>8</b></td>
                    <td colspan="4"><b>ข้อมูลความเท่าเทียมกันทางเภสัชกรรม (Pharmaceutical Equivalence Data)</b></td>
                </tr>
                <tr>
                    <td align="center">8.1</td>
                    <td>สรุปผลการเปรียบเทียบปริมาณตัวยาสำคัญในผลิตภัณฑ์ยา (Summary of comparison of content of active ingredient/potency of product)</td>
                    <td><input id="file-input" align="center" ng-model="FILE_DATA" type="file" name="file" ngf-select="selectFileforUpload(datas,$files)" /></td>
                    @*<td></td>*@
                    <td></td>
                </tr>
                <tr>
                    <td align="center">8.2</td>
                    <td>สรุปผลการเปรียบเทียบข้อมูล Uniformity of dosage units ของผลิตภัณฑ์ยา (Summary of comparison of uniformity of dosage units of product)</td>
                    <td><input id="file-input" align="center" ng-model="FILE_DATA" type="file" name="file" ngf-select="selectFileforUpload(datas,$files)" /></td>
                    @*<td></td>*@
                    <td></td>
                </tr>
                <tr>
                    <td align="center">8.3</td>
                    <td>
                        รายงานการเปรียบเทียบข้อมูลการละลาย (Dissolution profile comparison report) ของผลิตภัณฑ์ยาทดสอบ และผลิตภัณฑ์ยาอ้างอิง <font style="color:red">*ทดสอบภายใต้สภาวะทดสอบ (Condition) และห้องทดลองเดียวกัน*</font> (โปรดดูรายละเอียดหัวข้อ/เนื้อหาที่ต้องการในหมายเหตุ)
                        <a data-toggle="modal" data-target="#popup8" style="color:red">
                            ดูรายละเอียด กดที่นี่
                        </a>
                    </td>
                    <td><input id="file-input" align="center" ng-model="FILE_DATA" type="file" name="file" ngf-select="selectFileforUpload(datas,$files)" /></td>
                    @*<td></td>*@
                    <td></td>
                </tr>
                <tr>
                    <td align="center"><b>9</b></td>
                    <td colspan="4"><b>ข้อมูลทางคลินิก (Clinical part)</b></td>
                </tr>
                <tr>
                    <td align="center">9.1</td>
                    <td>
                        แผนการศึกษา (Investigational plan) (โปรดดูรายละเอียดหัวข้อ/เนื้อหาที่ต้องการในหมายเหตุ)<br />
                        <a data-toggle="modal" data-target="#popup9" style="color:red">
                            ดูรายละเอียด กดที่นี่
                        </a>
                    </td>
                    <td><input id="file-input" align="center" ng-model="FILE_DATA" type="file" name="file" ngf-select="selectFileforUpload(datas,$files)" /></td>
                    @*<td></td>*@
                    <td></td>
                </tr>
                <tr>
                    <td align="center">9.2</td>
                    <td>พารามิเตอร์และการทดสอบทางเภสัชจลนศาสตร์ (Pharmacokinetic parameters and tests)</td>
                    <td><input id="file-input" align="center" ng-model="FILE_DATA" type="file" name="file" ngf-select="selectFileforUpload(datas,$files)" /></td>
                    @*<td></td>*@
                    <td></td>
                </tr>
                <tr>
                    <td align="center">9.3</td>
                    <td>
                        วิธีทางสถิติที่ระบุในแผนการศึกษาและการคำนวณขนาดกลุ่มตัวอย่างและค่าอำนาจจำแนกความแตกต่างระหว่างกลุ่ม (Statistical method planned in the protocol and determination of sample size and power of the study) (โปรดดูรายละเอียดหัวข้อ/เนื้อหาที่ต้องการในหมายเหตุ)
                        <a data-toggle="modal" data-target="#popup10" style="color:red">
                            ดูรายละเอียด กดที่นี่
                        </a>
                    </td>
                    <td><input id="file-input" align="center" ng-model="FILE_DATA" type="file" name="file" ngf-select="selectFileforUpload(datas,$files)" /></td>
                    @*<td></td>*@
                    <td></td>
                </tr>
                <tr>
                    <td align="center"><b>10</b></td>
                    <td colspan="4"><b>ผลการศึกษาและการอภิปราย (Results and Discussion)</b></td>
                </tr>
                <tr>
                    <td align="center">10.1</td>
                    <td>
                        ผลการศึกษาทางคลินิก (Clinical study results) (โปรดดูรายละเอียดหัวข้อ/เนื้อหาที่ต้องการในหมายเหตุ)<br />
                        <a data-toggle="modal" data-target="#popup11" style="color:red">
                            ดูรายละเอียด กดที่นี่
                        </a>
                    </td>
                    <td><input id="file-input" align="center" ng-model="FILE_DATA" type="file" name="file" ngf-select="selectFileforUpload(datas,$files)" /></td>
                    @*<td></td>*@
                    <td></td>
                </tr>
                <tr>
                    <td align="center">10.2</td>
                    <td>
                        ผลสรุปการวิเคราะห์ (Summary of analytical results) (โปรดดูรายละเอียดหัวข้อ/เนื้อหาที่ต้องการในหมายเหตุ)
                        <a data-toggle="modal" data-target="#popup12" style="color:red">
                            ดูรายละเอียด กดที่นี่
                        </a>
                    </td>
                    <td><input id="file-input" align="center" ng-model="FILE_DATA" type="file" name="file" ngf-select="selectFileforUpload(datas,$files)" /></td>
                    @*<td></td>*@
                    <td></td>
                </tr>
                <tr>
                    <td align="center">10.3</td>
                    <td>
                        การวิเคราะห์ทางสถิติ (Statistical analyses) (โปรดดูรายละเอียดหัวข้อ/เนื้อหาที่ต้องการในหมายเหตุ)<br />
                        <a data-toggle="modal" data-target="#popup13" style="color:red">
                            ดูรายละเอียด กดที่นี่
                        </a>
                    </td>
                    <td><input id="file-input" align="center" ng-model="FILE_DATA" type="file" name="file" ngf-select="selectFileforUpload(datas,$files)" /></td>
                    @*<td></td>*@
                    <td></td>
                </tr>
                <tr>
                    <td align="center">11</td>
                    <td>สรุปผลการศึกษา (Conclusions)</td>
                    <td><input id="file-input" align="center" ng-model="FILE_DATA" type="file" name="file" ngf-select="selectFileforUpload(datas,$files)" /></td>
                    @*<td></td>*@
                    <td></td>
                </tr>
                <tr>
                    <td align="center">12</td>
                    <td>เอกสารอ้างอิง (References)</td>
                    <td><input id="file-input" align="center" ng-model="FILE_DATA" type="file" name="file" ngf-select="selectFileforUpload(datas,$files)" /></td>
                    @*<td></td>*@
                    <td></td>
                </tr>
                <tr>
                    <td align="center"><b>13</b></td>
                    <td colspan="4"><b>ภาคผนวก (Appendices)</b></td>
                </tr>
                <tr>
                    <td align="center">13.1</td>
                    <td>
                        โครงร่างงานศึกษาวิจัยที่ได้รับการอนุมัติ และ หนังสือรับรองจากคณะกรรมการจริยธรรมการวิจัยในมนุษย์ (Approval of the institutional review board/Ethical committee) (โปรดดูรายละเอียดหัวข้อ/เนื้อหาที่ต้องการในหมายเหตุ)
                        <a data-toggle="modal" data-target="#popup14" style="color:red">
                            ดูรายละเอียด กดที่นี่
                        </a>
                    </td>
                    <td><input id="file-input" align="center" ng-model="FILE_DATA" type="file" name="file" ngf-select="selectFileforUpload(datas,$files)" /></td>
                    @*<td></td>*@
                    <td></td>
                </tr>
                <tr>
                    <td align="center">13.2</td>
                    <td>
                        ข้อมูลการตรวจสอบความถูกต้องของวิธีวิเคราะห์ (Method validation data) (โปรดดูรายละเอียดหัวข้อ/เนื้อหาที่ต้องการในหมายเหตุ)
                        <a data-toggle="modal" data-target="#popup15" style="color:red">
                            ดูรายละเอียด กดที่นี่
                        </a>
                    </td>
                    <td><input id="file-input" align="center" ng-model="FILE_DATA" type="file" name="file" ngf-select="selectFileforUpload(datas,$files)" /></td>
                    @*<td></td>*@
                    <td></td>
                </tr>
                <tr>
                    <td align="center">13.3</td>
                    <td>
                        ข้อมูลการวิเคราะห์ระดับยา (Analytical data of drug levels) (โปรดดูรายละเอียดหัวข้อ/เนื้อหาที่ต้องการในหมายเหตุ)
                        <a data-toggle="modal" data-target="#popup16" style="color:red">
                            ดูรายละเอียด กดที่นี่
                        </a>
                    </td>
                    <td><input id="file-input" align="center" ng-model="FILE_DATA" type="file" name="file" ngf-select="selectFileforUpload(datas,$files)" /></td>
                    @*<td></td>*@
                    <td></td>
                </tr>
                <tr>
                    <td align="center">13.4</td>
                    <td>
                        หลักฐานแสดงการรับรองมาตรฐานห้องปฏิบัติการ (Certificate of facility/laboratory) (โปรดดูรายละเอียดหัวข้อ/เนื้อหาที่ต้องการในหมายเหตุ)
                        <a data-toggle="modal" data-target="#popup17" style="color:red">
                            ดูรายละเอียด กดที่นี่
                        </a>
                    </td>
                    <td><input id="file-input" align="center" ng-model="FILE_DATA" type="file" name="file" ngf-select="selectFileforUpload(datas,$files)" /></td>
                    @*<td></td>*@
                    <td></td>
                </tr>
            </table>
        </div>
        <div id="FOUR" class="tabcontent">
            <table width="100%" border="1">
                <tr>
                    <td style="width:10%" align="center"><b>ลำดับที่</b></td>
                    <td style="width:50%" align="center"><b>รายการตรวจสอบเอกสาร</b></td>
                    <td style="width:20%" align="center"><b>ไฟล์แนบ</b></td>
                    @*<td style="width:10%" align="center"><b>เจ้าหน้าที่ตรวจสอบ</b></td>*@
                    <td style="width:20%" align="center"><b>บันทึกข้อบกพร่อง</b></td>
                </tr>
                <tr>
                    <td align="center"><b>1.</b></td>
                    <td colspan="4"><b>ข้อมูลทั่วไป (Administrative data)</b></td>
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
                    <td>หนังสือรับรองของผู้ผลิตว่า ผลิตภัณฑ์ยาทดสอบเหมือนกับผลิตภัณฑ์ยาที่จะจำหน่ายในประเทศไทย (Letter of confirmation for the sameness of the test product to the marketed product in Thailand)</td>
                    <td><input id="file-input" align="center" ng-model="FILE_DATA" type="file" name="file" ngf-select="selectFileforUpload(datas,$files)" /></td>
                    @*<td></td>*@
                    <td></td>
                </tr>
                <tr>
                    <td align="center">1.6</td>
                    <td>F-D2-121 คำรับรองการปฏิบัติตามหลักเกณฑ์และเงื่อนไขของกองยา</td>
                    <td><input id="file-input" align="center" ng-model="FILE_DATA" type="file" name="file" ngf-select="selectFileforUpload(datas,$files)" /></td>
                    @*<td></td>*@
                    <td></td>
                </tr>
                <tr>
                    <td align="center">1.7</td>
                    <td>สรุปย่อการศึกษา (Study synopsis) ให้จัดทำในรูปแบบตารางที่อ่านได้ง่าย และมีข้อมูล อย่างน้อย ดังต่อไปนี้ Study title, Objectives, Test & Reference or Comparator or Innovator product information, Batch size, Batch number, Solubility results, Supportive evidences for Permeability, Excipients, Comparative dissolution profile, Supportive evidences for Therapeutic index, Drug products are not intended to be absorbed in oral cavity & Risk and benefit assessment</td>
                    <td><input id="file-input" align="center" ng-model="FILE_DATA" type="file" name="file" ngf-select="selectFileforUpload(datas,$files)" /></td>
                    @*<td></td>*@
                    <td></td>
                </tr>
                <tr>
                    <td align="center">1.8</td>
                    <td>สารบัญ (Table of content)</td>
                    <td><input id="file-input" align="center" ng-model="FILE_DATA" type="file" name="file" ngf-select="selectFileforUpload(datas,$files)" /></td>
                    @*<td></td>*@
                    <td></td>
                </tr>
                <tr>
                    <td align="center">1.9</td>
                    <td>หัวข้อเรื่องที่ทำการศึกษา (Study title)</td>
                    <td><input id="file-input" align="center" ng-model="FILE_DATA" type="file" name="file" ngf-select="selectFileforUpload(datas,$files)" /></td>
                    @*<td></td>*@
                    <td></td>
                </tr>
                <tr>
                    <td align="center">1.10</td>
                    <td>ชื่อและที่อยู่ผู้รับอนุญาต (Name and address of applicant)</td>
                    <td><input id="file-input" align="center" ng-model="FILE_DATA" type="file" name="file" ngf-select="selectFileforUpload(datas,$files)" /></td>
                    @*<td></td>*@
                    <td></td>
                </tr>
                <tr>
                    <td align="center">1.11</td>
                    <td>ชื่อและที่อยู่ผู้ให้ทุนการศึกษา(ถ้ามี) (Name and address of sponsor) (if available)</td>
                    <td><input id="file-input" align="center" ng-model="FILE_DATA" type="file" name="file" ngf-select="selectFileforUpload(datas,$files)" /></td>
                    @*<td></td>*@
                    <td></td>
                </tr>
                <tr>
                    <td align="center">1.12</td>
                    <td>ชื่อและที่อยู่ผู้ผลิต (Name and address of manufacturer)</td>
                    <td><input id="file-input" align="center" ng-model="FILE_DATA" type="file" name="file" ngf-select="selectFileforUpload(datas,$files)" /></td>
                    @*<td></td>*@
                    <td></td>
                </tr>
                <tr>
                    <td align="center">1.13</td>
                    <td>ชื่อและที่อยู่ผู้ดำเนินการศึกษา (Name and address of investigator)</td>
                    <td><input id="file-input" align="center" ng-model="FILE_DATA" type="file" name="file" ngf-select="selectFileforUpload(datas,$files)" /></td>
                    @*<td></td>*@
                    <td></td>
                </tr>
                <tr>
                    <td align="center">1.14</td>
                    <td>ชื่อและที่อยู่สถานที่ทำการศึกษา (Name and address of the laboratory)</td>
                    <td><input id="file-input" align="center" ng-model="FILE_DATA" type="file" name="file" ngf-select="selectFileforUpload(datas,$files)" /></td>
                    @*<td></td>*@
                    <td></td>
                </tr>
                <tr>
                    <td align="center"><b>2.</b></td>
                    <td colspan="4"><b>เอกสารสนับสนุนการขอยกเว้นการศึกษาชีวสมมูลฯ แบบ BCS Class I (Justification for the BCS Class I biowaiver)</b></td>
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
                    <td>บทนำ (Introduction / Overall summary for BCS Class I based biowaiver report) โปรดระบุรายละเอียดของ ภาพรวมสำหรับ รายงานการศึกษาการขอยกเว้นการศึกษาชีวสมมูลฯ แบบ BCS Class I</td>
                    <td><input id="file-input" align="center" ng-model="FILE_DATA" type="file" name="file" ngf-select="selectFileforUpload(datas,$files)" /></td>
                    @*<td></td>*@
                    <td></td>
                </tr>
                <tr>
                    <td align="center">2.3</td>
                    <td>
                        ข้อมูลตัวยาสำคัญ (API) (โปรดดูรายละเอียดหัวข้อ/เนื้อหาที่ต้องการในหมายเหตุ)
                        <a data-toggle="modal" data-target="#popup18" style="color:red">
                            ดูรายละเอียด กดที่นี่
                        </a>
                    </td>
                    <td><input id="file-input" align="center" ng-model="FILE_DATA" type="file" name="file" ngf-select="selectFileforUpload(datas,$files)" /></td>
                    @*<td></td>*@
                    <td></td>
                </tr>
                <tr>
                    <td align="center">2.4</td>
                    <td>
                        การละลายของตัวยาสำคัญ (Solubility study) (โปรดดูรายละเอียดหัวข้อ/เนื้อหาที่ต้องการในหมายเหตุ)<br />
                        <a data-toggle="modal" data-target="#popup19" style="color:red">
                            ดูรายละเอียด กดที่นี่
                        </a>
                    </td>
                    <td><input id="file-input" align="center" ng-model="FILE_DATA" type="file" name="file" ngf-select="selectFileforUpload(datas,$files)" /></td>
                    @*<td></td>*@
                    <td></td>
                </tr>
                <tr>
                    <td align="center">2.5</td>
                    <td>
                        การซึมผ่านเซลล์ (Permeability) (โปรดดูรายละเอียดหัวข้อ/เนื้อหาที่ต้องการในหมายเหตุ)
                        <a data-toggle="modal" data-target="#popup20" style="color:red">
                            ดูรายละเอียด กดที่นี่
                        </a>
                    </td>
                    <td><input id="file-input" align="center" ng-model="FILE_DATA" type="file" name="file" ngf-select="selectFileforUpload(datas,$files)" /></td>
                    @*<td></td>*@
                    <td></td>
                </tr>
                <tr>
                    <td align="center">2.6</td>
                    <td>
                        ข้อมูลผลิตภัณฑ์ยา (Product information) (โปรดดูรายละเอียดหัวข้อ/เนื้อหาที่ต้องการในหมายเหตุ)<br />
                        <a data-toggle="modal" data-target="#popup21" style="color:red">
                            ดูรายละเอียด กดที่นี่
                        </a>
                    </td>
                    <td><input id="file-input" align="center" ng-model="FILE_DATA" type="file" name="file" ngf-select="selectFileforUpload(datas,$files)" /></td>
                    @*<td></td>*@
                    <td></td>
                </tr>
                <tr>
                    <td align="center">2.7</td>
                    <td>
                        ข้อมูลส่วนประกอบตัวยาไม่สำคัญ (Excipients) (โปรดดูรายละเอียดหัวข้อ/เนื้อหาที่ต้องการในหมายเหตุ)<br />
                        <a data-toggle="modal" data-target="#popup22" style="color:red">
                            ดูรายละเอียด กดที่นี่
                        </a>
                    </td>
                    <td><input id="file-input" align="center" ng-model="FILE_DATA" type="file" name="file" ngf-select="selectFileforUpload(datas,$files)" /></td>
                    @*<td></td>*@
                    <td></td>
                </tr>
                <tr>
                    <td align="center">2.8</td>
                    <td>
                        ข้อกำหนดมาตรฐานและวิธีการวิเคราะห์ รายการ การทดสอบ วิธีการทดสอบ วิธีการวิเคราะห์ และเกณฑ์ที่ใช้ในการพิจารณาการยอมรับผลิตภัณฑ์ยา (Specifications, Test method, Analytical procedure & Acceptance criteria or limit)*** <font style="color:red">***ข้อกำหนดมาตรฐานและวิธีการวิเคราะห์ ตามตำรายาที่รัฐมนตรีประกาศเทียบเท่าหรือใหม่กว่า หรือ วิธีของผู้ผลิต (In-house method) หรือ ICH guidelines Q6A specification: Test procedures and Acceptance criteria for New substances and New drug products: Chemical substances***</font> (โปรดดูรายละเอียดหัวข้อ/เนื้อหาที่ต้องการในหมายเหตุ)
                        <a data-toggle="modal" data-target="#popup23" style="color:red">
                            ดูรายละเอียด กดที่นี่
                        </a>
                    </td>
                    <td><input id="file-input" align="center" ng-model="FILE_DATA" type="file" name="file" ngf-select="selectFileforUpload(datas,$files)" /></td>
                    @*<td></td>*@
                    <td></td>
                </tr>
                <tr>
                    <td align="center">2.9</td>
                    <td>หลักฐานแสดงว่า ผลิตภัณฑ์ยาไม่เป็นผลิตภัณฑ์ที่ออกแบบให้มีการดูดซึมในช่องปาก (Drug product are not intended to be absorbed in oral cavity) (โปรดดูรายละเอียดหัวข้อ/เนื้อหาที่ต้องการในหมายเหตุ)</td>
                    <td><input id="file-input" align="center" ng-model="FILE_DATA" type="file" name="file" ngf-select="selectFileforUpload(datas,$files)" /></td>
                    @*<td></td>*@
                    <td></td>
                </tr>
                <tr>
                    <td align="center">2.10</td>
                    <td>
                        ดุลความเสี่ยงและประโยชน์ที่ได้รับ  (Risk and benefit assessment) (โปรดดูรายละเอียดหัวข้อ/เนื้อหาที่ต้องการในหมายเหตุ)
                        <a data-toggle="modal" data-target="#popup24" style="color:red">
                            ดูรายละเอียด กดที่นี่
                        </a>
                    </td>
                    <td><input id="file-input" align="center" ng-model="FILE_DATA" type="file" name="file" ngf-select="selectFileforUpload(datas,$files)" /></td>
                    @*<td></td>*@
                    <td></td>
                </tr>
                <tr>
                    <td align="center">2.11</td>
                    <td>เอกสารอ้างอิง (References) โปรดแนบเอกสารอ้างอิง ที่มี highlight พร้อมแสดง crosslink กับข้อมูลในคำขอฯ ให้ครบถ้วน ทุกหัวข้อ</td>
                    <td><input id="file-input" align="center" ng-model="FILE_DATA" type="file" name="file" ngf-select="selectFileforUpload(datas,$files)" /></td>
                    @*<td></td>*@
                    <td></td>
                </tr>
                <tr>
                    <td align="center">2.12</td>
                    <td>
                        สรุปรายละเอียดของผลิตภัณฑ์ที่ทดสอบ (โปรดระบุรายละเอียดของผลิตภัณฑ์ให้ครบถ้วน) (โปรดดูรายละเอียดหัวข้อ/เนื้อหาที่ต้องการในหมายเหตุ)
                        <a data-toggle="modal" data-target="#popup25" style="color:red">
                            ดูรายละเอียด กดที่นี่
                        </a>
                    </td>
                    <td><input id="file-input" align="center" ng-model="FILE_DATA" type="file" name="file" ngf-select="selectFileforUpload(datas,$files)" /></td>
                    @*<td></td>*@
                    <td></td>
                </tr>
            </table>
        </div>
        <br />
        <br />
        <br />
        <div style="text-align:center">
            <button class="btn btn-lg" style="background-color:#38A86B;color:white">บันทึก</button>
            <button class="btn btn-lg" style="background-color:#FFD700" ng-click="BTN_BACK()">ย้อนกลับ</button>
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

<div class="modal fade bd-example-modal-lg" id="popup1" tabindex="-1" role="dialog" aria-label="exampleModalCenterTitle" aria-hidden="true">
    <div class="modal-dialog modal-lg" role="document">
        <div class="modal-content">
            <div class="modal-header">
                <h5 class="modal-title" id="exampleModalLongTitle"></h5>
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
                        <td align="center">2.3.1</td>
                        <td>
                            คุณสมบัติทางเคมีกายภาพ (Physicochemical properties)<br />
                            โปรดระบุข้อมูล Appearance, CAS No., Chemical name (IUPAC), INN name, Hygroscopic, Stereo-isomer, Molecular formula*, Molecular structure*, Molecular weight, pKa,  Specific optical rotation, Partition coefficient*, Polymorphism*, Crystalline forms*, Solubility*, Particle size*<br />
                            <font style="color:red">***กรณีตัวยาสำคัญที่อยู่ในรูปเกลือ, hydrate หรือ solvates ต้องแสดงข้อมูล Molecular formula และ Molecular weight ของ  free base  หรือ anhydrous  หรือ unsolvated เพิ่มเติม***</font><br />
                            พร้อมแสดงรายละเอียดว่า ตัวยาสำคัญที่เลือกใช้ นั้นแตกต่าง หรือ เหมือน ผลิตภัณฑ์ยาอ้างอิง หรือ ผลิตภัณฑ์ยาเปรียบเทียบ หรือ ผลิตภัณฑ์ยาต้นแบบ (Reference or Comparator or Innovator product)
                        </td>
                    </tr>
                    <tr>
                        <td align="center">2.3.2</td>
                        <td>ชื่อและที่อยู่ผู้ผลิต (Manufacturer) ที่อยู่ผู้ผลิตระบุประเทศด้วย***</td>
                    </tr>
                    <tr>
                        <td align="center">2.3.3</td>
                        <td>
                            Certificate of Analysis (COA) ของ API<br />
                            **เฉพาะกรณีตัวยาสำคัญเป็นยาในกลุ่ม Sartans เช่น Irbesartan Valsartan เป็นต้น โปรดแสดงรายละเอียดต่อไปนี้<br />
                            <span style="padding-left:2em">- ตัวยาสำคัญ ได้รับ Certification of Suitability (CEP) จาก European Directorate for the Quality of Medicines (EDQM) หรือไม่</span><br />
                            <span style="padding-left:4em">ใช่ (โปรดให้รายละเอียดเพิ่มเติมในข้อ b)</span><br />
                            <span style="padding-left:4em">ไม่ใช่ (โปรดให้รายละเอียดเพิ่มเติมในข้อ c)</span><br />
                            <span style="padding-left:2em">- โปรดแสดงสำเนา  CEP ดังกล่าว ซึ่งสามารถตรวจสอบได้จาก <a href="https://www.edqm.eu/en/news/certification-of-suitability">https://www.edqm.eu/en/news/certification-of-suitability</a> และ <a href="https://extranet.edqm.eu/publications/Recherches_CEP.shtml">https://extranet.edqm.eu/publications/Recherches_CEP.shtml</a></span><br />
                            <span style="padding-left:2em">- โปรดแสดงเหตุผลและหลักฐานประกอบการพิจารณาเลือกใช้วัตถุดิบจากแหล่งผลิตนี้ รวมถึงการควบคุม Nitrosamine impurities และ Acceptant criteria</span>
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

<div class="modal fade bd-example-modal-lg" id="popup2" tabindex="-1" role="dialog" aria-label="exampleModalCenterTitle" aria-hidden="true">
    <div class="modal-dialog modal-lg" role="document">
        <div class="modal-content">
            <div class="modal-header">
                <h5 class="modal-title" id="exampleModalLongTitle"></h5>
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
                        <td align="center">2.5.1</td>
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

<div class="modal fade bd-example-modal-lg" id="popup3" tabindex="-1" role="dialog" aria-label="exampleModalCenterTitle" aria-hidden="true">
    <div class="modal-dialog modal-lg" role="document">
        <div class="modal-content">
            <div class="modal-header">
                <h5 class="modal-title" id="exampleModalLongTitle"></h5>
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
                        <td align="center">2.6.1</td>
                        <td>
                            ปริมาณตัวยาสำคัญ ของผลิตภัณฑ์ยาทดสอบ และผลิตภัณฑ์ยาอ้างอิง หรือ ผลิตภัณฑ์ยาเปรียบเทียบ หรือ ผลิตภัณฑ์ยาต้นแบบ (Content of Active ingredient(s)/ Potency of Test & Reference or Comparator or Innovator product)<br />
                            <font style="color:red">*ทดสอบภายใต้สภาวะทดสอบ (Condition) และห้องทดลองเดียวกัน*</font><br />
                            <span style="margin-left:2em">- วิธีการวิเคราะห์ เกณฑ์ที่ใช้ในการพิจารณาการยอมรับผลิตภัณฑ์ยา และผลการหาปริมาณตัวยาสำคัญของผลิตภัณฑ์ยา (Analytical method & procedure, Acceptance criteria or limit and Results) ***</span><br />
                            <span style="margin-left:2em">- รายงานวิธีการตรวจสอบความถูกต้องของวิธี การวิเคราะห์ (Analytical method Validation/ Verification report for assay)***</span>
                        </td>
                    </tr>
                    <tr>
                        <td align="center">2.6.2</td>
                        <td>
                            Uniformity of dosage unit ของผลิตภัณฑ์ยาทดสอบ และผลิตภัณฑ์ยาอ้างอิง หรือ ผลิตภัณฑ์ยาเปรียบเทียบ หรือ ผลิตภัณฑ์ยาต้นแบบ (Uniformity of dosage unit For Test & Reference or Comparator or Innovator product)<br />
                            <font style="color:red">*ทดสอบภายใต้สภาวะทดสอบ (Condition) และห้องทดลองเดียวกัน*</font><br />
                            <span style="padding-left:2em">- Weight variation แสดงวิธีการทดสอบ เกณฑ์ที่ใช้ในการพิจารณาการยอมรับผลิตภัณฑ์ยา ผลการทดสอบ อภิปราย และสรุปผล (Weight variation method & procedure, Acceptance criteria or limit, Results Discussion and Conclusion) หรือ</span><br />
                            <span style="padding-left:2em">- Content uniformity แสดงวิธีการวิเคราะห์   เกณฑ์ที่ใช้ในการพิจารณาการยอมรับผลิตภัณฑ์ยา  ผลการวิเคราะห์ อภิปราย สรุปผล และรายงานวิธีการตรวจสอบความถูกต้องของวิธีการวิเคราะห์ ฉบับสมบูรณ์  (Content uniformity method & procedure, Acceptance criteria or limit, Results Discussion and Conclusion including full report of Analytical method Validation/Verification)</span>
                        </td>
                    </tr>
                    <tr>
                        <td align="center">2.6.3</td>
                        <td>
                            Dissolution Profile Comparison ของผลิตภัณฑ์ยาทดสอบ และผลิตภัณฑ์ยาอ้างอิง หรือ ผลิตภัณฑ์ยาเปรียบเทียบ หรือ ผลิตภัณฑ์ยาต้นแบบ (Content of Active ingredient(s)/Potency of Test & Reference or Comparator or Innovator product)<br />
                            <font style="color:red">*ทดสอบภายใต้สภาวะทดสอบ (Condition) และห้องทดลองเดียวกัน*</font><br />
                            <span style="padding-left:2em">- บทนำ วัตถุประสงค์ รายละเอียดของ วิธีดำเนินการทดสอบการละลายของผลิตภัณฑ์ยา วิธีการวิเคราะห์ และเกณฑ์ที่ใช้ในการพิจารณา การยอมรับผลิตภัณฑ์ยา (Introduction, Objectives, Dissolution method & procedure & Acceptance criteria or limit)***</span><br />
                            <span style="padding-left:2em">- สารเคมีและเครื่องมือที่ใช้ (Chemicals & Instruments)</span><br />
                            <span style="padding-left:2em">- ตัวกลางการละลาย (Dissolution media) โปรดระบุข้อมูล อย่างน้อย ดังต่อไปนี้</span><br />
                            <span style="padding-left:4em">- ส่วนประกอบและการเตรียมตัวกลางการละลาย (Compositions & Preparations)</span><br />
                            <span style="padding-left:4em">- pH</span><br />
                            <span style="padding-left:4em">- อุณหภูมิ (Temperature)</span><br />
                            <span style="padding-left:4em">- ปริมาตร (Volume)</span><br />
                            <span style="padding-left:4em">- วิธีการกำจัดก๊าซ (Method of de-aeration) เป็นต้น</span><br />
                            <span style="padding-left:2em">- จำนวนหน่วยของผลิตภัณฑ์ยาที่ใช้ (Number of units) (โปรดระบุ)………………………………………………</span><br />
                            <span style="padding-left:2em">- โครงร่างการตรวจสอบรายงานวิธีการตรวจสอบความถูกต้องของวิธีการวิเคราะห์ (Protocol & Report for Analytical method Validation/Verification)</span><br />
                            <span style="padding-left:2em">- ผลการศึกษา (Results) โดยรายงานผลการทดสอบการละลายของผลิตภัณฑ์ยา ในตัวกลาง การละลายทั้งหมด ด้วยรูปแบบตารางแสดง</span><br />
                            <span style="padding-left:4em">- ร้อยละของการปลดปล่อยตัวยาสำคัญ  (% Drug release) แต่ละหน่วย/จุดเวลา และแสดงรายละเอียดการคำนวณดังกล่าว</span><br />
                            <span style="padding-left:4em">- ค่าเฉลี่ยร้อยละการปลดปล่อยตัวยาสำคัญ  12 หน่วย/จุดเวลา</span><br />
                            <span style="padding-left:4em">- ส่วนเบี่ยงเบนมาตรฐาน (Standard deviation: SD ) ของร้อยละการปลดปล่อยตัวยาสำคัญ  12 หน่วย/จุดเวลา</span><br />
                            <span style="padding-left:4em">- % CV หรือ RSD ของร้อยละการปลดปล่อยตัวยาสำคัญ 12 หน่วย/จุดเวลา</span><br />
                            <span style="padding-left:4em">- กราฟแสดงการเปรียบเทียบผลการละลายของผลิตภัณฑ์ยาทดสอบและยาอ้างอิง (Comparative dissolution profiles)</span><br />
                            <span style="padding-left:4em">- เปรียบเทียบความเหมือนกันระหว่างผล การละลายของผลิตภัณฑ์ยาทดสอบและยาอ้างอิง หรือ ผลิตภัณฑ์ยาเปรียบเทียบ หรือ ผลิตภัณฑ์ยาต้นแบบ ด้วยการแสดงการคำนวณค่า similarity factor (f2) หรือวิธีอื่นที่เหมาะสม พร้อมเหตุผลสนับสนุน</span><br />
                            <span style="padding-left:4em">- การอภิปราย และสรุปผลการทดสอบการละลายของผลิตภัณฑ์ยา (Discussion and Conclusions)</span><br />
                            <span style="padding-left:4em">- ข้อมูลดิบของการทดสอบการละลายของผลิตภัณฑ์ยา (Raw data of Comparative dissolution profile)</span>
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

<div class="modal fade bd-example-modal-lg" id="popup4" tabindex="-1" role="dialog" aria-labelledby="exampleModalCenterTitle" aria-hidden="true">
    <div class="modal-dialog modal-lg">
        <div class="modal-content">
            <div class="modal-header">
                <h5 class="modal-title" id="exampleModalLongTitle"></h5>
                <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                    <span aria-hidden="true"></span>
                </button>
            </div>
            <div class="modal-body">
                <div>เอกสารต้องประกอบด้วยหัวข้ออย่างน้อยดังต่อไปนี้</div>
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

<div class="modal fade bd-example-modal-lg" id="popup5" tabindex="-1" role="dialog" aria-labelledby="exampleModalCenterTitle" aria-hidden="true">
    <div class="modal-dialog modal-lg">
        <div class="modal-content">
            <div class="modal-header">
                <h5 class="modal-title" id="exampleModalLongTitle"></h5>
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
                        <td align="center">1.4.1</td>
                        <td>ชื่อรายงาน (Study title)</td>
                    </tr> 
                    <tr>
                        <td align="center">1.4.2</td>
                        <td>ชื่อและที่อยู่ผู้ให้การสนับสนุน (Name and address of sponsor)</td>
                    </tr> 
                    <tr>
                        <td align="center">1.4.3</td>
                        <td>ชื่อผู้รับผิดชอบโครงการศึกษา และที่อยู่ของสถาบันที่ดำเนินการศึกษา (Name, Person in charge and address of institution)</td>
                    </tr>
                    <tr>
                        <td align="center">1.4.4</td>
                        <td>ชื่อและที่อยู่ของผู้วิจัยศึกษาหลัก (Name and address of principal investigator)</td>
                    </tr> 
                    <tr>
                        <td align="center">1.4.5</td>
                        <td>ชื่อแพทย์หรือผู้วิจัยศึกษาทางคลินิก (Name of medical/ clinical investigator)</td>
                    </tr> 
                    <tr>
                        <td align="center">1.4.6</td>
                        <td>ชื่อและที่อยู่ของผู้รับผิดชอบหลักด้านห้องปฏิบัติการทางคลินิก (Name, Person in charge and address of clinical laboratory)</td>
                    </tr> 
                    <tr>
                        <td align="center">1.4.7</td>
                        <td>ชื่อและที่อยู่ของผู้รับผิดชอบหลักด้านห้องปฏิบัติการวิเคราะห์ระดับยา (Name, Person in charge and address of analytical laboratory)</td>
                    </tr> 
                    <tr>
                        <td align="center">1.4.8</td>
                        <td>ชื่อและที่อยู่ของผู้รับผิดชอบหลักด้านการจัดการข้อมูล การวิเคราะห์ทางเภสัชจลนศาสตร์และทางสถิติ (Name, Person in charge and address for data management, pharmacokinetics and statistical)</td>
                    </tr>
                    <tr>
                        <td align="center">1.4.9</td>
                        <td>ชื่อและที่อยู่ของผู้ร่วมศึกษาวิจัยคนอื่น ๆ (ถ้ามี) (Name and address of other investigator(s) and study personnel) (if applicable)</td>
                    </tr> 
                    <tr>
                        <td align="center">1.4.10</td>
                        <td>วันที่โครงร่างฯ ได้รับการอนุมัติจาก IRB/EC (Ethical approval date)</td>
                    </tr>
                    <tr>
                        <td align="center">1.4.11</td>
                        <td>วันเวลาที่เริ่มและยุติการศึกษาทางคลินิกและการวิเคราะห์ระดับยา (Start and end date of clinical and analytical study)</td>
                    </tr> 
                    <tr>
                        <td align="center">1.4.12</td>
                        <td>การลงนามพร้อมวันที่ของผู้ศึกษาวิจัย (Signature and date of investigator(s)) ผู้เขียนรายงานทางการแพทย์ (Medical writer) ผู้จัดการด้านการประกันคุณภาพ (QA Manager)</td>
                    </tr>
                </table>
            </div>
            <div class="modal-footer">
                <button type="button" class="btn btn-secondary" data-dismiss="modal">Close</button>
            </div>
        </div>
    </div>
</div>

<div class="modal fade bd-example-modal-lg" id="popup6" tabindex="-1" role="dialog" aria-labelledby="exampleModalCenterTitle" aria-hidden="true">
    <div class="modal-dialog modal-lg">
        <div class="modal-content">
            <div class="modal-header">
                <h5 class="modal-title" id="exampleModalLongTitle"></h5>
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
                        <td align="center">7.1.1</td>
                        <td>
                            ตัวยาสำคัญ (API) *แนบหนังสือรับรองการวิเคราะห์ของตัวยาสำคัญ (Certificate of analysis of API)*<br />
                            **เฉพาะกรณีตัวยาสำคัญเป็นยาในกลุ่ม Sartans เช่น Irbesartan Valsartan เป็นต้น โปรดแสดงรายละเอียดต่อไปนี้<br />
                            <span style="padding-left:2em">- ตัวยาสำคัญ ได้รับ Certification of Suitability (CEP) จาก European Directorate for the Quality of Medicines (EDQM) หรือไม่</span><br />
                            <span style="padding-left:4em">- ใช่ (โปรดให้รายละเอียดเพิ่มเติมในข้อ b)</span><br />
                            <span style="padding-left:4em">- ไม่ใช่ (โปรดให้รายละเอียดเพิ่มเติมในข้อ c)</span><br />
                            <span style="padding-left:2em">- โปรดแสดงสำเนา  CEP ดังกล่าว ซึ่งสามารถตรวจสอบได้จาก<a href="https://www.edqm.eu/en/news/certification-of-suitability">https://www.edqm.eu/en/news/certification-of-suitability</a> และ <a href="https://extranet.edqm.eu/publications/Recherches_CEP.shtml">https://extranet.edqm.eu/publications/Recherches_CEP.shtml</a></span><br />
                            <span style="padding-left:2em">- โปรดแสดงเหตุผลและหลักฐานประกอบการพิจารณาเลือกใช้วัตถุดิบจากแหล่งผลิตนี้ รวมถึงการควบคุม Nitrosamine impurities และ Acceptant criteria</span>
                        </td>
                    </tr>
                    <tr>
                        <td align="center">7.1.2</td>
                        <td>ชื่อการค้า (Trade Name)</td>
                    </tr> 
                    <tr>
                        <td align="center">7.1.3</td>
                        <td>ความแรง (Strength)</td>
                    </tr> 
                    <tr>
                        <td align="center">7.1.4</td>
                        <td>รูปแบบยา (Dosage form)</td>
                    </tr>
                    <tr>
                        <td align="center">7.1.5</td>
                        <td>ชื่อและที่อยู่ของผู้ผลิต (Name and address of manufacturer)</td>
                    </tr> 
                    <tr>
                        <td align="center">7.1.6</td>
                        <td>ชื่อและที่อยู่ผู้นำสั่งยาเข้ามาในราชอาณาจักร (ถ้ามี) (Name and address of importer) (if available)</td>
                    </tr> 
                    <tr>
                        <td align="center">7.1.7</td>
                        <td>รุ่นที่ผลิต (Batch number)</td>
                    </tr> 
                    <tr>
                        <td align="center">7.1.8</td>
                        <td>วันที่ผลิต (Date of manufacture)</td>
                    </tr>
                    <tr>
                        <td align="center">7.1.9</td>
                        <td>วันหมดอายุ (Expiry date)</td>
                    </tr> 
                    <tr>
                        <td align="center">7.1.10</td>
                        <td>ขนาดรุ่นการผลิต (Batch size) หากน้อยกว่า 100,000 หน่วย ต้องแนบเอกสารเพิ่มเติมตามเงื่อนไขและเอกสารที่ต้องยื่นประกอบการพิจารณารุ่นการผลิตนำร่อง (Pilot batch) ที่น้อยกว่า 100,000 หน่วยหรือหนังสืออนุมัติ</td>
                    </tr> 
                    <tr>
                        <td align="center">7.1.11</td>
                        <td>สูตรตำรับ (Product formulation) แสดงลักษณะยาและส่วนประกอบของผลิตภัณฑ์ยา (Description and Composition of product)</td>
                    </tr>
                    <tr>
                        <td align="center">7.1.12</td>
                        <td>ข้อกำหนดมาตรฐานและวิธีวิเคราะห์ (Finished product specifications)</td>
                    </tr>
                    <tr>
                        <td align="center">7.1.13</td>
                        <td>หนังสือรับรองการวิเคราะห์ของผลิตภัณฑ์ยาทดสอบ (Certificate of analysis of test product)</td>
                    </tr>
                </table>
            </div>
            <div class="modal-footer">
                <button type="button" class="btn btn-secondary" data-dismiss="modal">Close</button>
            </div>
        </div>
    </div>
</div>

<div class="modal fade bd-example-modal-lg" id="popup7" tabindex="-1" role="dialog" aria-labelledby="exampleModalCenterTitle" aria-hidden="true">
    <div class="modal-dialog modal-lg">
        <div class="modal-content">
            <div class="modal-header">
                <h5 class="modal-title" id="exampleModalLongTitle"></h5>
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
                        <td align="center">7.2.1</td>
                        <td>ชื่อการค้า (Trade name)</td>
                    </tr>
                    <tr>
                        <td align="center">7.2.2</td>
                        <td>ตัวยาสำคัญ (API)</td>
                    </tr> 
                    <tr>
                        <td align="center">7.2.3</td>
                        <td>ความแรง (Strength)</td>
                    </tr> 
                    <tr>
                        <td align="center">7.2.4</td>
                        <td>รูปแบบยา (Dosage form)</td>
                    </tr>
                    <tr>
                        <td align="center">7.2.5</td>
                        <td>ชื่อและที่อยู่ผู้ผลิต (Name and address of manufacturer)</td>
                    </tr> 
                    <tr>
                        <td align="center">7.2.6</td>
                        <td>ชื่อและที่อยู่ผู้นาสั่งยาเข้ามาในราชอาณาจักร (ถ้ามี) (Name and address of importer) (if available)</td>
                    </tr> 
                    <tr>
                        <td align="center">7.2.7</td>
                        <td>รุ่นที่ผลิต (Batch number)</td>
                    </tr> 
                    <tr>
                        <td align="center">7.2.8</td>
                        <td>วันที่ผลิต (Date of manufacture)</td>
                    </tr>
                    <tr>
                        <td align="center">7.2.9</td>
                        <td>วันหมดอายุ (Expiry date)</td>
</tr> 
                    <tr>
                        <td align="center">7.2.10</td>
                        <td>สูตรตำรับ (Product Formulation) แสดงลักษณะยาและส่วนประกอบของผลิตภัณฑ์ยา (Description and Composition of product)</td>
                    </tr> 
                    <tr>
                        <td align="center">7.2.11</td>
                        <td>หนังสือรับรองการวิเคราะห์ของยาอ้างอิง หรือผลิตภัณฑ์ยาเปรียบเทียบ หรือ ผลิตภัณฑ์ยาต้นแบบ (COA of Reference or Comparator or Innovator product)</td>
                    </tr> 
                    <tr>
                        <td align="center">7.2.12</td>
                        <td>
                            ผลิตภัณฑ์ยาอ้างอิงผลิตจากแหล่งผลิตเดียวกันกับผลิตภัณฑ์ยาต้นแบบที่ขึ้นทะเบียนในประเทศไทย (The sameness of manufacturing site(s) of used reference product)<br />
                            <span style="padding-left:2em">- ใช่ เลขทะเบียนตำรับยา (Drug registration number)..................................................</span><br />
                            <span style="padding-left:2em">- ไม่ใช่ แนบข้อมูล Comparison of dissolution profile ระหว่างแหล่งผลิตของผลิตภัณฑ์ยาอ้างอิง</span><br />
                            <span style="padding-left:2em">- อื่น ๆ..................................................</span>
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

<div class="modal fade bd-example-modal-lg" id="popup8" tabindex="-1" role="dialog" aria-labelledby="exampleModalCenterTitle" aria-hidden="true">
    <div class="modal-dialog modal-lg">
        <div class="modal-content">
            <div class="modal-header">
                <h5 class="modal-title" id="exampleModalLongTitle"></h5>
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
                        <td align="center">8.3.1</td>
                        <td>บทนำ วัตถุประสงค์ รายละเอียดของ วิธีดำเนินการทดสอบการละลายของผลิตภัณฑ์ยา วิธีการวิเคราะห์ และเกณฑ์ที่ใช้ในการพิจารณาการยอมรับผลิตภัณฑ์ยา (Introduction, Objectives, Dissolution method & procedure & Acceptance criteria or limit)</td>
                    </tr>
                    <tr>
                        <td align="center">8.3.2</td>
                        <td>สารเคมีและเครื่องมือที่ใช้ (Chemicals & Instruments)</td>
                    </tr>
                    <tr>
                        <td align="center">8.3.3</td>
                        <td>
                            ตัวกลางการละลาย (Dissolution media) โปรดระบุข้อมูล อย่างน้อย ดังต่อไปนี้<br />
                            <span style="padding-left:2em">- ส่วนประกอบและการเตรียมตัวกลางการละลาย (Compositions & Preparations)</span><br />
                            <span style="padding-left:2em">- pH</span><br />
                            <span style="padding-left:2em">- อุณหภูมิ (Temperature)</span><br />
                            <span style="padding-left:2em">- ปริมาตร (Volume)</span><br />
                            <span style="padding-left:2em">- วิธีการกำจัดก๊าซ (Method of de-aeration) เป็นต้น</span>
                        </td>
                    </tr>
                    <tr>
                        <td align="center">8.3.4</td>
                        <td>จำนวนหน่วยของผลิตภัณฑ์ยาที่ใช้ (Number of units) (โปรดระบุ)..................................................</td>
                    </tr>
                    <tr>
                        <td align="center">8.3.5</td>
                        <td>โครงร่างการตรวจสอบรายงานวิธีการตรวจสอบความถูกต้องของวิธีการวิเคราะห์ (Protocol & Summary report for analytical method validation/verification)</td>
                    </tr>
                    <tr>
                        <td align="center">8.3.6</td>
                        <td>
                            ผลการทดสอบการละลายของผลิตภัณฑ์ยาในตัวกลางการละลายทั้งหมด (Dissolution profile comparison results)<br />
                            <span style="padding-left:2em">- ผลการศึกษา (Results) แสดงด้วยรูปแบบตาราง</span><br />
                            <span style="padding-left:2em">- ร้อยละของการปลดปล่อยตัวยาสำคัญ (% Drug release) แต่ละหน่วย/จุดเวลา และแสดงรายละเอียดการคำนวณดังกล่าว</span><br />
                            <span style="padding-left:2em">- ค่าเฉลี่ยร้อยละการปลดปล่อยตัวยาสำคัญ 12 หน่วย/ จุดเวลา</span><br />
                            <span style="padding-left:2em">- ส่วนเบี่ยงเบนมาตรฐาน (Standard deviation: SD) ของร้อยละการปลดปล่อยตัวยาสำคัญ 12 หน่วย/จุดเวลา</span><br />
                            <span style="padding-left:2em">- % CV หรือ RSD ของร้อยละการปลดปล่อยตัวยาสำคัญ 12 หน่วย/จุดเวลา</span><br />
                            <span style="padding-left:2em">- กราฟแสดงการเปรียบเทียบผลการละลายของผลิตภัณฑ์ยาทดสอบและยาอ้างอิง (Comparative dissolution profiles)</span><br />
                            <span style="padding-left:2em">- เปรียบเทียบความเหมือนกันระหว่างผลการละลายของผลิตภัณฑ์ยาทดสอบและยาอ้างอิง หรือ ผลิตภัณฑ์ยาเปรียบเทียบ หรือ ผลิตภัณฑ์ยาต้นแบบ ด้วยการแสดงการคำนวณค่า similarity factor (f2) หรือวิธีอื่นที่เหมาะสม พร้อมเหตุผลสนับสนุน</span><br />
                            <span style="padding-left:2em">- การอภิปราย และสรุปผลการทดสอบการละลายของผลิตภัณฑ์ยา (Discussion and Conclusions)</span>
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

<div class="modal fade bd-example-modal-lg" id="popup9" tabindex="-1" role="dialog" aria-labelledby="exampleModalCenterTitle" aria-hidden="true">
    <div class="modal-dialog modal-lg">
        <div class="modal-content">
            <div class="modal-header">
                <h5 class="modal-title" id="exampleModalLongTitle"></h5>
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
                        <td align="center">9.1.1</td>
                        <td>รูปแบบการศึกษาทางคลินิกและแผนการศึกษา (Clinical study design and plan)</td>
                    </tr>
                    <tr>
                        <td align="center">9.1.2</td>
                        <td>
                            การคัดเลือกอาสาสมัคร (Selection of subject)<br />
                            <span style="padding-left:2em">- เกณฑ์การคัดเข้า (Inclusion criteria)</span><br />
                            <span style="padding-left:2em">- เกณฑ์การคัดออก (Exclusion criteria)</span><br />
                            <span style="padding-left:2em">- สาเหตุการคัดอาสาสมัครออกจากศึกษา (Removal of subject from study includes withdraw and/or dropout)</span>
                        </td>
                    </tr> 
                    <tr>
                        <td align="center">9.1.3</td>
                        <td>
                            การรักษา (Treatments)<br />
                            <span style="padding-left:2em">- วิธีการให้ยา (Treatments administered)</span><br />
                            <span style="padding-left:2em">- ข้อมูลผลิตภัณฑ์ยาที่ใช้ในการทดสอบ (Identity of drug product(s))</span><br />
                            <span style="padding-left:2em">- การเลือกขนาดยาที่ใช้ในการศึกษา (Selection of doses in the study)</span><br />
                            <span style="padding-left:2em">- วิธีการกำหนดอาสาสมัครให้กลุ่มการรักษา (Method of assigning subjects to treatment groups)</span>
                        </td>
                    </tr>
                    <tr>
                        <td align="center">9.1.4</td>
                        <td>
                            ประสิทธิภาพและความปลอดภัย (Efficacy and Safety)<br />
                            <span style="padding-left:2em">- การบันทึก การประเมิน และแผนผังการวัดค่าทางคลินิกและความปลอดภัย (Clinical and safety measurements records, assessed and flow chart)</span><br />
                            <span style="padding-left:2em">- การเลือกจุดเจาะเลือด(Selection of sampling time points)</span><br />
                            <span style="padding-left:2em">- การวัดระดับยาในเลือด (Drug concentration measurements)</span>
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

<div class="modal fade bd-example-modal-lg" id="popup10" tabindex="-1" role="dialog" aria-labelledby="exampleModalCenterTitle" aria-hidden="true">
    <div class="modal-dialog modal-lg">
        <div class="modal-content">
            <div class="modal-header">
                <h5 class="modal-title" id="exampleModalLongTitle"></h5>
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
                        <td align="center">9.3.1</td>
                        <td>แผนการวิเคราะห์ทางสถิติ (Statistical and analytical plans)</td>
                    </tr> 
                    <tr>
                        <td align="center">9.3.2</td>
                        <td>การคำนวณขนาดกลุ่มตัวอย่าง และค่าอำนาจจำแนกความแตกต่างระหว่างกลุ่ม (Determination of sample size and power of the study)</td>
                    </tr>
                    <tr>
                        <td align="center">9.3.3</td>
                        <td>การเปลี่ยนแปลงในการทำการศึกษาหรือแผนการวิเคราะห์(Changes in the conduct of the study or planned analyses)</td>
                    </tr> 
                    <tr>
                        <td align="center">9.3.4</td>
                        <td>สรุปวิธีการวิเคราะห์ระดับยาในเลือด (Summary of bioanalytical method)</td>
                    </tr>
                    <tr>
                        <td align="center">9.3.5</td>
                        <td>การประกันคุณภาพของข้อมูล (Data quality assurance) โดยระบุ QA statement</td>
                    </tr>
                </table>
            </div>
            <div class="modal-footer">
                <button type="button" class="btn btn-secondary" data-dismiss="modal">Close</button>
            </div>
        </div>
    </div>
</div>

<div class="modal fade bd-example-modal-lg" id="popup11" tabindex="-1" role="dialog" aria-labelledby="exampleModalCenterTitle" aria-hidden="true">
    <div class="modal-dialog modal-lg">
        <div class="modal-content">
            <div class="modal-header">
                <h5 class="modal-title" id="exampleModalLongTitle"></h5>
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
                        <td align="center">10.1.1</td>
                        <td>Demographic characteristics of the subject</td>
                    </tr>
                    <tr>
                        <td align="center">10.1.2</td>
                        <td>Details of clinical activity</td>
                    </tr>
                    <tr>
                        <td align="center">10.1.3</td>
                        <td>Deviation from protocol</td>
                    </tr>
                    <tr>
                        <td align="center">10.1.4</td>
                        <td>Results of drug/alcohol/smoking usage, medical history and physical examination, vital sign and relevant laboratory test of subject</td>
                    </tr>
                    <tr>
                        <td align="center">10.1.5</td>
                        <td>Adverse event/reaction reports for test product and reference product</td>
                    </tr>
                </table>
            </div>
            <div class="modal-footer">
                <button type="button" class="btn btn-secondary" data-dismiss="modal">Close</button>
            </div>
        </div>
    </div>
</div>

<div class="modal fade bd-example-modal-lg" id="popup12" tabindex="-1" role="dialog" aria-labelledby="exampleModalCenterTitle" aria-hidden="true">
    <div class="modal-dialog modal-lg">
        <div class="modal-content">
            <div class="modal-header">
                <h5 class="modal-title" id="exampleModalLongTitle"></h5>
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
                        <td align="center">10.2.1</td>
                        <td>Drug levels at each sampling time, descriptive statistics</td>
                    </tr>
                    <tr>
                        <td align="center">10.2.2</td>
                        <td>Figure of mean plasma or urine concentration-time profile</td>
                    </tr>
                    <tr>
                        <td align="center">10.2.3</td>
                        <td>Figure of individual subject plasma or urine concentration-time profile</td>
                    </tr>
                    <tr>
                        <td align="center">10.2.4</td>
                        <td>Table of individual subject pharmacokinetic parameters, descriptive statistics</td>
                    </tr>
                </table>
            </div>
            <div class="modal-footer">
                <button type="button" class="btn btn-secondary" data-dismiss="modal">Close</button>
            </div>
        </div>
    </div>
</div>

<div class="modal fade bd-example-modal-lg" id="popup13" tabindex="-1" role="dialog" aria-labelledby="exampleModalCenterTitle" aria-hidden="true">
    <div class="modal-dialog modal-lg">
        <div class="modal-content">
            <div class="modal-header">
                <h5 class="modal-title" id="exampleModalLongTitle"></h5>
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
                        <td align="center">10.3.1</td>
                        <td>Statistical considerations</td>
                    </tr>
                    <tr>
                        <td align="center">10.3.2</td>
                        <td>Time points selected for Kel, T1/2</td>
                    </tr>
                    <tr>
                        <td align="center">10.3.3</td>
                        <td>
                            Summary statistical significance for Cmax and AUC (based on log-transformed data calculated as 90% CI of test/reference geometric means)<br />
                            <span style="padding-left:2em">- Intra-subject variability</span><br />
                            <span style="padding-left:2em">- Assessment of sequence, period and treatment effects</span><br />
                            <span style="padding-left:2em">- Table of analysis of variance, geometric least-squares means for each pharmacokinetic parameters</span><br />
                            <span style="padding-left:2em">- Table of</span>
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

<div class="modal fade bd-example-modal-lg" id="popup14" tabindex="-1" role="dialog" aria-labelledby="exampleModalCenterTitle" aria-hidden="true">
    <div class="modal-dialog modal-lg">
        <div class="modal-content">
            <div class="modal-header">
                <h5 class="modal-title" id="exampleModalLongTitle"></h5>
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
                        <td align="center">13.1.1</td>
                        <td>Study protocol and its amendments together with Institutional Review Board/Ethical Committee approvals</td>
                    </tr>
                    <tr>
                        <td align="center">13.1.2</td>
                        <td>Informed consent form</td>
                    </tr>
                </table>
            </div>
            <div class="modal-footer">
                <button type="button" class="btn btn-secondary" data-dismiss="modal">Close</button>
            </div>
        </div>
    </div>
</div>

<div class="modal fade bd-example-modal-lg" id="popup15" tabindex="-1" role="dialog" aria-labelledby="exampleModalCenterTitle" aria-hidden="true">
    <div class="modal-dialog modal-lg">
        <div class="modal-content">
            <div class="modal-header">
                <h5 class="modal-title" id="exampleModalLongTitle"></h5>
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
                        <td align="center">13.2.1</td>
                        <td>รายงานการตรวจสอบความถูกต้องของวิธีวิเคราะห์ (Method validation report)</td>
                    </tr>
                    <tr>
                        <td align="center">13.2.2</td>
                        <td>Summary sequences of injection for all run (100%)</td>
                    </tr> 
                    <tr>
                        <td align="center">13.2.3</td>
                        <td>ข้อมูลดิบโครมาโตแกรมอย่างน้อย 20% ซึ่งรวมถึงโครมาโตแกรมในหัวข้อ selectivity, precision and accuracy, long-term stability of drug in plasma (Raw chromatograms at least 20% includes selectivity, precision and accuracy, long-term stability of drug in plasma)</td>
                    </tr>
                </table>
            </div>
            <div class="modal-footer">
                <button type="button" class="btn btn-secondary" data-dismiss="modal">Close</button>
            </div>
        </div>
    </div>
</div>

<div class="modal fade bd-example-modal-lg" id="popup16" tabindex="-1" role="dialog" aria-labelledby="exampleModalCenterTitle" aria-hidden="true">
    <div class="modal-dialog modal-lg">
        <div class="modal-content">
            <div class="modal-header">
                <h5 class="modal-title" id="exampleModalLongTitle"></h5>
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
                        <td align="center">13.3.1</td>
                        <td>รายงานการวิเคราะห์ระดับยา (Analytical report)</td>
                    </tr> 
                    <tr>
                        <td align="center">13.3.2</td>
                        <td>Summary sequences of injection for all run (100%)</td>
                    </tr> 
                    <tr>
                        <td align="center">13.3.3</td>
                        <td>ข้อมูลดิบโครมาโตแกรมอย่างน้อย 20% พร้อมระบุวิธีการเลือกข้อมูลดิบโครมาโตแกรมของอาสาสมัครที่ส่งมา (Raw chromatograms at least 20% and method for selection the raw chromatograms of subjects)</td>
                    </tr> 
                    <tr>
                        <td align="center">13.3.4</td>
                        <td>ข้อมูลดิบระดับยาในเลือดสำหรับอาสาสมัครทุกคนแสดงใน Excel file (Raw data of drug levels in plasma for all subjects presented in excel file)</td>
                    </tr>
                </table>
            </div>
            <div class="modal-footer">
                <button type="button" class="btn btn-secondary" data-dismiss="modal">Close</button>
            </div>
        </div>
    </div>
</div>

<div class="modal fade bd-example-modal-lg" id="popup17" tabindex="-1" role="dialog" aria-labelledby="exampleModalCenterTitle" aria-hidden="true">
    <div class="modal-dialog modal-lg">
        <div class="modal-content">
            <div class="modal-header">
                <h5 class="modal-title" id="exampleModalLongTitle"></h5>
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
                        <td align="center">13.4.1</td>
                        <td>หลักฐานแสดงการรับรองมาตรฐานของสถานที่การศึกษาวิจัยทางคลินิก (Certificate of Clinical facility) และ/หรือ หลักฐานแสดงการรับรองมาตรฐานของสถานที่ตรวจวิเคราะห์ระดับยา (Certificate of Analytical laboratory) <font style="color:red">*พิจารณาตามแบบตรวจสอบหลักฐานแสดงมาตรฐานห้องปฏิบัติการชีวสมมูล (F-D2-216)*</font></td>
                    </tr>
                    <tr>
                        <td align="center">13.4.2</td>
                        <td>หลักฐานแสดงการรับรองมาตรฐานห้องปฏิบัติการที่ตรวจวิเคราะห์ผลทางคลินิก (Certificate of Clinical laboratory) และ</td>
                    </tr>
                    <tr>
                        <td align="center">13.4.3</td>
                        <td>F-D2-216 แบบตรวจสอบหลักฐานแสดงมาตรฐานห้องปฏิบัติการชีวสมมูล</td>
                    </tr>
                </table>
            </div>
            <div class="modal-footer">
                <button type="button" class="btn btn-secondary" data-dismiss="modal">Close</button>
            </div>
        </div>
    </div>
</div>

<div class="modal fade bd-example-modal-lg" id="popup18" tabindex="-1" role="dialog" aria-labelledby="exampleModalCenterTitle" aria-hidden="true">
    <div class="modal-dialog modal-lg">
        <div class="modal-content">
            <div class="modal-header">
                <h5 class="modal-title" id="exampleModalLongTitle"></h5>
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
                        <td align="center">2.3.1</td>
                        <td>
                            คุณสมบัติทางเคมีกายภาพ (Physicochemical properties) โปรดระบุข้อมูลAppearance, CAS No., Chemical name (IUPAC), INN name, Hygroscopic, Stereo-isomer, Molecular formula*, Molecular structure*, Molecular weight, pKa,  Specific optical rotation, Partition coefficient*, Polymorphism*, Crystalline forms*, Solubility*, Particle size*<br />
                            <font style="color:red">***กรณีตัวยาสำคัญที่อยู่ในรูปเกลือ, hydrate หรือ solvates ต้องแสดงข้อมูล Molecular formula และ Molecular weight ของ  free base  หรือ anhydrous  หรือ unsolvated เพิ่มเติม***</font><br />
                            พร้อมแสดงรายละเอียดว่า ตัวยาสำคัญที่เลือกใช้ นั้นแตกต่าง หรือ เหมือน ผลิตภัณฑ์ยาอ้างอิง หรือ ผลิตภัณฑ์ยาเปรียบเทียบ หรือ ผลิตภัณฑ์ยาต้นแบบ (Reference or Comparator or Innovator product)
                        </td>
                    </tr> 
                    <tr>
                        <td align="center">2.3.2</td>
                        <td>ชื่อและที่อยู่ผู้ผลิต (Manufacturer) ที่อยู่ผู้ผลิตระบุประเทศด้วย***</td>
                    </tr> 
                    <tr>
                        <td align="center">2.3.3</td>
                        <td>
                            Certificate of Analysis (COA) ของ API***<br />
                            **เฉพาะกรณีตัวยาสำคัญเป็นยาในกลุ่ม Sartans เช่น Irbesartan Valsartan เป็นต้น โปรดแสดงรายละเอียดต่อไปนี้<br />
                            <span style="padding-left:2em">- ตัวยาสำคัญ ได้รับ Certification of Suitability (CEP) จาก European Directorate for the Quality of Medicines (EDQM) หรือไม่</span><br />
                            <span style="padding-left:4em">- ใช่ (โปรดให้รายละเอียดเพิ่มเติมในข้อ b)</span><br />
                            <span style="padding-left:4em">- ไม่ใช่ (โปรดให้รายละเอียดเพิ่มเติมในข้อ c)</span><br />
                            <span style="padding-left:2em">- โปรดแสดงสำเนา  CEP ดังกล่าว ซึ่งสามารถตรวจสอบได้จาก <a href="https://www.edqm.eu/en/news/certification-of-suitability">https://www.edqm.eu/en/news/certification-of-suitability</a>  และ <a href="https://extranet.edqm.eu/publications/Recherches_CEP.shtml">https://extranet.edqm.eu/publications/Recherches_CEP.shtml</a></span><br />
                            <span style="padding-left:2em">- โปรดแสดงเหตุผลและหลักฐานประกอบ การพิจารณาเลือกใช้วัตถุดิบจากแหล่งผลิตนี้ รวมถึงการควบคุม Nitrosamine impurities และ Acceptant criteria</span>
                        </td>
                    </tr>
                    <tr>
                        <td align="center">2.3.4</td>
                        <td>
                            ดัชนีการรักษา (Therapeutic index)<br />
                            <span style="padding-left:2em">- LD50/ED50 ≥ 2 เท่า โดยแหล่งข้อมูลมาจาก Species และ Route เดียวกัน (โปรดระบุ)..................................................</span><br />
                            <span style="padding-left:2em">- Narrow Therapeutic index (NTI) drug lists จาก Regulatory Agencies (โปรดระบุ)..................................................</span><br />
                            <span style="padding-left:2em">- อื่นๆ (โปรดระบุ)..................................................</span>
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

<div class="modal fade bd-example-modal-lg" id="popup19" tabindex="-1" role="dialog" aria-labelledby="exampleModalCenterTitle" aria-hidden="true">
    <div class="modal-dialog modal-lg">
        <div class="modal-content">
            <div class="modal-header">
                <h5 class="modal-title" id="exampleModalLongTitle"></h5>
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
                        <td align="center">2.4.1</td>
                        <td>ขนาดยาสูงสุดสำหรับการรับประทาน 1 ครั้ง (Highest single dose administered**) และขนาดยาสูงสุดที่มีการจำหน่ายในท้องตลาดทั่วโลก (Maximum dose strength that is marketed)</td>
                    </tr>  
                    <tr>
                        <td align="center">2.4.2</td>
                        <td>ข้อมูลความคงตัวของตัวยาสำคัญในช่วง physiological pH 1.2 – 6.8 (ถ้ามี) (Stability of API in the physiological pH range from 1.2 – 6.8) (if available)</td>
                    </tr> 
                    <tr>
                        <td align="center">2.4.3</td>
                        <td>
                            โครงร่างและวิธีการทดสอบการละลายของตัวยาสำคัญ  (Solubility study protocol and method of solubility determination)<br />
                            โปรดระบุดังนี้<br />
                            <span style="padding-left:2em">- วิธีการทดสอบอย่างละเอียด (Detailed study method) Shake flask method หรือ วิธีอื่นที่เทียบเท่า พร้อมเหตุผลสนับสนุน (โปรดระบุ)..................................................</span><br />
                            <span style="padding-left:2em">- สารเคมีและเครื่องมือที่ใช้ (Chemical & Instruments)</span><br />
                            <span style="padding-left:2em">- ชนิด ปริมาตร และ pH ของตัวกลางการละลาย (Type, volume and pH of medium)</span><br />
                            <span style="padding-left:2em">- การเตรียม standard solutions และ sample solutions (Preparations of standard and sample solutions)</span><br />
                            <span style="padding-left:2em">- การควบคุม pH ของตัวกลางการละลาย ตลอดระยะเวลาที่ทดสอบ</span><br />
                            <span style="padding-left:2em">- การควบคุมอุณหภูมิ (temperature)  ของตัวกลาง การละลาย ที่ 37 ± 1 ºC ตลอดระยะเวลาที่ทดสอบ</span><br />
                            <span style="padding-left:2em">- Chromatographic system เช่น Detector, flow rate, mobile phase, column เป็นต้น</span>
                        </td>
                    </tr> 
                    <tr>
                        <td align="center">2.4.4</td>
                        <td>
                            วันที่ทำการทดสอบการละลายของตัวยาสำคัญ (Solubility study date) โปรดระบุ<br />
                            <span style="padding-left:2em">- วันที่บังคับใช้โครงร่างการทดสอบการละลายของตัวยาสำคัญ (Effective date of study protocol)</span><br />
                            <span style="padding-left:2em">- วันที่ทำการทดสอบการทดสอบการละลายของตัวยาสำคัญ (Solubility study date)</span><br />
                            <span style="padding-left:2em">- วันที่รายงานผลการทดสอบการละลายของ  ตัวยาสำคัญ (Study report date)</span>
                        </td>
                    </tr> 
                    <tr>
                        <td align="center">2.4.5</td>
                        <td>โครงร่างการตรวจสอบความถูกต้องของวิธีการวิเคราะห์ และรายงานผลการตรวจสอบความถูกต้องของวิธีการวิเคราะห์ (Analytical method Validation/verification protocol and report)</td>
                    </tr>  
                    <tr>
                        <td align="center">2.4.6</td>
                        <td>
                            ผลการทดสอบและการอภิปรายผล (Results and discussion)<br />
                            <span style="padding-left:2em">- รายงานผลการทดสอบการละลายของตัวยาสำคัญ ฉบับสมบูรณ์ (Full report of solubility study) พร้อมการแสดงผลการทดสอบในรูปแบบตาราง  เพื่อแสดงค่าการละลายของตัวยาสำคัญที่ทำการทดสอบในตัวกลางการละลายแต่ละ pH และ แสดงการคำนวณ maximum dose strength /solubility ratio  (โปรดดูตัวอย่างตารางแนบท้าย)</span><br />
                            <span style="padding-left:2em">- ข้อมูลดิบของผลการทดสอบการละลายของ ตัวยาสำคัญ (Raw data of solubility study results)</span><br />
                            <span style="padding-left:2em">- กราฟแสดงความสัมพันธ์ระหว่าง pH และ การละลายของตัวยาสำคัญ (pH solubility profile of the drug substance)</span>
                        </td>
                    </tr> 
                    <tr>
                        <td align="center">2.4.7</td>
                        <td>สรุปผลการทดสอบการละลายของตัวยาสำคัญ (Conclusion for solubility study)</td>
                    </tr>
                </table>
            </div>
            <div class="modal-footer">
                <button type="button" class="btn btn-secondary" data-dismiss="modal">Close</button>
            </div>
        </div>
    </div>
</div>

<div class="modal fade bd-example-modal-lg" id="popup20" tabindex="-1" role="dialog" aria-labelledby="exampleModalCenterTitle" aria-hidden="true">
    <div class="modal-dialog modal-lg">
        <div class="modal-content">
            <div class="modal-header">
                <h5 class="modal-title" id="exampleModalLongTitle"></h5>
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
                        <td align="center">2.5.1</td>
                        <td> การดูดซึมยาในคน (Fraction absorption) มีค่า  ≥ 85% : วิธี Mass balance หรือ การศึกษา Absolute bioavailability (Human mass balance studies and/or Human absolute bioavailability studies) (โปรดระบุ).........................................................</td>
                    </tr>
                    <tr>
                        <td align="center">2.5.2</td>
                        <td>วิธีการศึกษาอื่นๆ ตามระเบียบที่เกี่ยวข้อง (ถ้ามี) (Supportive studies) (if available) (โปรดระบุ)..................................................</td>
                    </tr>
                </table>
            </div>
            <div class="modal-footer">
                <button type="button" class="btn btn-secondary" data-dismiss="modal">Close</button>
            </div>
        </div>
    </div>
</div>

<div class="modal fade bd-example-modal-lg" id="popup21" tabindex="-1" role="dialog" aria-labelledby="exampleModalCenterTitle" aria-hidden="true">
    <div class="modal-dialog modal-lg">
        <div class="modal-content">
            <div class="modal-header">
                <h5 class="modal-title" id="exampleModalLongTitle"></h5>
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
                        <td align="center">2.6.1</td>
                        <td>General information, Uses & administration, Pharmacodynamics, Pharmacokinetics, Adverse effects & Precautions</td>
                    </tr>
                    <tr>
                        <td align="center">2.6.2</td>
                        <td>
                            ผลิตภัณฑ์ยาทดสอบ (Test product)
                            <span style="padding-left:2em">- ชื่อการค้า (Trade name)</span><br />
                            <span style="padding-left:2em">- ตัวยาสำคัญ (API)</span><br />
                            <span style="padding-left:2em">- ความแรง (Strength)</span><br />
                            <span style="padding-left:2em">- รูปแบบยา (Dosage form)</span><br />
                            <span style="padding-left:2em">- ชื่อและที่อยู่ผู้ผลิต (Name and address of manufacturer)</span><br />
                            <span style="padding-left:2em">- ชื่อและที่อยู่ผู้นำสั่งยาเข้ามาในราชอาณาจักร (ถ้ามี) (Name and address of importer) (if available)</span><br />
                            <span style="padding-left:2em">- รุ่นที่ผลิต (Batch number)</span><br />
                            <span style="padding-left:2em">- วันที่ผลิต (Date of manufacture)</span><br />
                            <span style="padding-left:2em">- วันหมดอายุ (Expiry date)</span><br />
                            <span style="padding-left:2em">- Batch size หากน้อยกว่า 100,000 หน่วย ต้องแนบเอกสารเพิ่มเติมตามเงื่อนไขและเอกสารที่ต้องยื่นประกอบการพิจารณารุ่นการผลิตนำร่อง (Pilot batch) ที่น้อยกว่า 100,000 หน่วยหรือหนังสืออนุมัติ ทั้งนี้ต้องแสดง Batch record ประกอบ การพิจารณา</span><br />
                            <span style="padding-left:2em">- ลักษณะยาและส่วนประกอบของผลิตภัณฑ์ยา (Description and Composition of product)</span><br />
                            *แสดงรายละเอียดรูปแบบ ลักษณะเฉพาะของ ผลิตภัณฑ์ยา น้ำหนักหรือปริมาตรรวมต่อหน่วย<br />
                            **แสดงชื่อและปริมาณตัวยาสำคัญ และปริมาณส่วนประกอบในตำรับยาต่อหน่วย ซึ่งต้องสอดคล้องกับสูตรยาต่อรุ่นการผลิต (Batch formula)<br />
                            <span style="padding-left:2em">- สูตรยาต่อรุ่นการผลิต จำนวนผลิตภัณฑ์ยาที่ผลิตต่อรุ่นการผลิต ปริมาณที่ Overage และกระบวนการผลิต (Batch formula, Production batch and Manufacturing process)***</span><br />
                            <font style="color:red">***กรณีที่มีการ  Overage : ข้อมูลใน Batch formula ให้แสดงปริมาณที่ Overage และแจ้ง % Overage พร้อมทั้งแสดงการคำนวณ Overage ให้ชัดเจน***</font><br />
                            <span style="padding-left:2em">- Finish Product Specification (FPS)</span><br />
                            <span style="padding-left:2em">- หนังสือรับรองการวิเคราะห์ของผลิตภัณฑ์ยาทดสอบ (COA of Test product)***</span>
                        </td>
                    </tr>
                    <tr>
                        <td align="center">2.6.3</td>
                        <td>
                            ผลิตภัณฑ์ยาอ้างอิง หรือ ผลิตภัณฑ์ยาเปรียบเทียบ หรือ ผลิตภัณฑ์ยาต้นแบบ ซึ่งใช้เป็นผลิตภัณฑ์ยาความแรงเปรียบเทียบ (Reference or Comparator or Innovator product that be selected for the Reference strength drug product)<br />
                            ผลิตภัณฑ์ยาอ้างอิงผลิตจากแหล่งผลิตเดียวกันกับผลิตภัณฑ์ยาต้นแบบที่ขึ้นทะเบียนในประเทศไทย (The sameness of manufacturing site(s) of used reference product)<br />
                            <span style="padding-left:4em">- ใช่ เลขทะเบียนตำรับยา (Drug registration number)..................................</span><br />
                            <span style="padding-left:4em">- ไม่ใช่ แนบข้อมูล Comparison of dissolution profile ระหว่างแหล่งผลิตของผลิตภัณฑ์ยาอ้างอิง</span><br />
                            <span style="padding-left:4em">- อื่น ๆ................................</span><br />
                            <span style="padding-left:2em">- ชื่อการค้า (Trade name)</span><br />
                            <span style="padding-left:2em">- เลขทะเบียนตำรับยา (Drug Registration Number)</span><br />
                            <span style="padding-left:2em">- ตัวยาสำคัญ (API)</span><br />
                            <span style="padding-left:2em">- ความแรง (Strength)</span><br />
                            <span style="padding-left:2em">- รูปแบบยา (Dosage form)</span><br />
                            <span style="padding-left:2em">- ชื่อและที่อยู่ผู้ผลิต (Name and address of manufacturer)</span><br />
                            <span style="padding-left:2em">- ชื่อและที่อยู่ผู้นำสั่งยาเข้ามาในราชอาณาจักร (ถ้ามี) (Name and address of importer) (if available)</span><br />
                            <span style="padding-left:2em">- รุ่นที่ผลิต (Batch number)</span><br />
                            <span style="padding-left:2em">- วันที่ผลิต (Date of manufacture)</span><br />
                            <span style="padding-left:2em">- วันหมดอายุ (Expiry date)</span><br />
                            <span style="padding-left:2em">- ลักษณะยาและส่วนประกอบของผลิตภัณฑ์ยา (Description and Composition of product)***</span><br />
                            แสดงรายละเอียดรูปแบบ ลักษณะเฉพาะของ ผลิตภัณฑ์ยา น้ำหนักหรือปริมาตรรวมต่อหน่วย<br />
                            แสดงชื่อ หน้าที่และปริมาณตัวยาสำคัญ และปริมาณส่วนประกอบในตำรับยาต่อหน่วย***<br />
                            <span style="padding-left:2em">- หนังสือรับรองการวิเคราะห์ของยาอ้างอิง หรือ ผลิตภัณฑ์ยาเปรียบเทียบ หรือ ผลิตภัณฑ์ยาต้นแบบ (COA of  Reference or Comparator or Innovator product)</span>
                        </td>
                    </tr>
                    <tr>
                        <td align="center">2.6.4</td>
                        <td>ตารางแสดงการเปรียบเทียบ ลักษณะยาและส่วนประกอบของผลิตภัณฑ์ยา ระหว่างผลิตภัณฑ์ยาทดสอบ และผลิตภัณฑ์ยาอ้างอิง หรือ ผลิตภัณฑ์ยาเปรียบเทียบ หรือ ผลิตภัณฑ์ยาต้นแบบ (Comparison for Description and Composition of Test & Reference or Comparator or Innovator product โดยแสดงรายละเอียดการเปรียบเทียบ ตามหัวข้อในแบบ ย.1 หน้า 3 (Page No. 3 of Form MA-1) สำหรับคำขอขึ้นทะเบียนตำรับยา พร้อมแสดงหน้าที่ของส่วนประกอบแต่ละตัวในตำรับยา</td>
                    </tr>
                </table>
            </div>
            <div class="modal-footer">
                <button type="button" class="btn btn-secondary" data-dismiss="modal">Close</button>
            </div>
        </div>
    </div>
</div>

<div class="modal fade bd-example-modal-lg" id="popup22" tabindex="-1" role="dialog" aria-labelledby="exampleModalCenterTitle" aria-hidden="true">
    <div class="modal-dialog modal-lg">
        <div class="modal-content">
            <div class="modal-header">
                <h5 class="modal-title" id="exampleModalLongTitle"></h5>
                <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                    <span aria-hidden="true"></span>
                </button>
            </div>
            <div class="modal-body">
                <div>โปรดชี้แจงพร้อมเอกสารสนับสนุน ว่าส่วนประกอบตัวยาไม่สำคัญแต่ละตัว</div>
                <div style="padding-left:2em">- ไม่เป็นสารที่อาจมีผลต่อการดูดซึมยา </div>
                <div style="padding-left:2em">- เป็นสารที่มีการใช้อย่างกว้างขวาง</div>
                <div style="padding-left:2em">- ไม่มีอันตรกิริยาต่อเภสัชจลนศาสตร์ของตัวยาสำคัญ</div>
                <div style="padding-left:2em">- ปริมาณที่ใช้ไม่สูงกว่าปกติ  และ </div>
                <div style="padding-left:2em">- ไม่เป็นสารชนิดใหม่</div>
                <div><font style="color:red">*กรณีที่มีการใช้ส่วนประกอบตัวยาไม่สำคัญ ในปริมาณสูงมากกว่าปกติหรือเป็นสารชนิดใหม่ เป็นส่วนประกอบในสูตรตำรับ ต้องส่งข้อมูลเพิ่มเติม*</font></div>
            </div>
            <div class="modal-footer">
                <button type="button" class="btn btn-secondary" data-dismiss="modal">Close</button>
            </div>
        </div>
    </div>
</div>

<div class="modal fade bd-example-modal-lg" id="popup23" tabindex="-1" role="dialog" aria-labelledby="exampleModalCenterTitle" aria-hidden="true">
    <div class="modal-dialog modal-lg">
        <div class="modal-content">
            <div class="modal-header">
                <h5 class="modal-title" id="exampleModalLongTitle"></h5>
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
                        <td align="center">2.8.1</td>
                        <td>
                            ปริมาณตัวยาสำคัญ<br />
                            ของผลิตภัณฑ์ยาทดสอบ และผลิตภัณฑ์ยาอ้างอิง หรือ ผลิตภัณฑ์ยาเปรียบเทียบ หรือ ผลิตภัณฑ์ยาต้นแบบ (Content of Active ingredient(s)/Potency of Test & Reference or Comparator or Innovator product)<br />
                            <font style="color:red">*ทดสอบภายใต้สภาวะทดสอบ (Condition) และห้องทดลองเดียวกัน*</font><br />
                            <span style="padding-left:2em">- วิธีการวิเคราะห์ เกณฑ์ที่ใช้ในการพิจารณาการยอมรับผลิตภัณฑ์ยา และผลการหาปริมาณตัวยาสำคัญของผลิตภัณฑ์ยา (Analytical method & procedure, Acceptance criteria or limit and Results)***</span><br />
                            <span style="padding-left:2em">- รายงานวิธีการตรวจสอบความถูกต้องของวิธีการวิเคราะห์ (Analytical method Validation/ Verification report for assay)***</span>
                        </td>
                    </tr>
                    <tr>
                        <td align="center">2.8.2</td>
                        <td>
                            Uniformity of dosage unit<br />
                            ของผลิตภัณฑ์ยาทดสอบ และผลิตภัณฑ์ยาอ้างอิง หรือ ผลิตภัณฑ์ยาเปรียบเทียบ หรือ ผลิตภัณฑ์ยาต้นแบบ (Uniformity of dosage unit For Test & Reference or Comparator or Innovator product)<br />
                            <font style="color:red">*ทดสอบภายใต้สภาวะทดสอบ (Condition) และห้องทดลองเดียวกัน*</font><br />
                            <span style="padding-left:2em">- Weight variation แสดงวิธีการทดสอบ เกณฑ์ที่ใช้ในการพิจารณาการยอมรับผลิตภัณฑ์ยา ผลการทดสอบ อภิปราย และสรุปผล (Weight variation method & procedure, Acceptance criteria or limit, Results Discussion and Conclusion) หรือ</span><br />
                            <span style="padding-left:2em">- Content uniformity แสดงวิธีการวิเคราะห์   เกณฑ์ที่ใช้ในการพิจารณาการยอมรับผลิตภัณฑ์ยา  ผลการวิเคราะห์ อภิปราย สรุปผล และรายงานวิธีการตรวจสอบความถูกต้องของวิธีการวิเคราะห์  ฉบับสมบูรณ์  (Content uniformity method & procedure, Acceptance criteria or limit, Results Discussion and Conclusion including full report of Analytical method Validation/Verification)</span>
                        </td>
                    </tr>
                    <tr>
                        <td align="center">2.8.3</td>
                        <td>
                            Dissolution Profile Comparison<br />
                            ของผลิตภัณฑ์ยาทดสอบ และผลิตภัณฑ์ยาอ้างอิง หรือ ผลิตภัณฑ์ยาเปรียบเทียบ หรือ ผลิตภัณฑ์ยาต้นแบบ (Content of Active ingredient(s)/Potency of Test & Reference or Comparator or Innovator product)<br />
                            <font style="color:red">*ทดสอบภายใต้สภาวะทดสอบ (Condition) และห้องทดลองเดียวกัน*</font><br />
                            <span style="padding-left:2em">- บทนำ วัตถุประสงค์ รายละเอียดของ วิธีดำเนินการทดสอบการละลายของผลิตภัณฑ์ยา วิธีการวิเคราะห์ และเกณฑ์ที่ใช้ในการพิจารณาการยอมรับผลิตภัณฑ์ยา (Introduction, Objectives, Dissolution method & procedure & Acceptance criteria or limit)***</span><br />
                            <font style="color:red">*The recommended pH : 1.2, 4.5 & 6.8 (Ph.Eur. buffers Recommended & no surfactant; in case of gelatin capsules or tablets with gelatin coatings the use of enzymes may be acceptable) ± Other pH(s) with justification & Scientific supportive evidences*</font><br />
                            <span style="padding-left:2em">- สารเคมีและเครื่องมือที่ใช้ (Chemicals & Instruments)</span><br />
                            <span style="padding-left:2em">- ตัวกลางการละลาย (Dissolution media) โปรดระบุข้อมูล อย่างน้อย ดังต่อไปนี้</span><br />
                            <span style="padding-left:4em">- ส่วนประกอบและการเตรียม ตัวกลางการละลาย (Compositions & Preparations)</span><br />
                            <span style="padding-left:4em">- pH</span><br />
                            <span style="padding-left:4em">- อุณหภูมิ (Temperature)</span><br />
                            <span style="padding-left:4em">- ปริมาตร (Volume)</span><br />
                            <span style="padding-left:4em">- วิธีการกำจัดก๊าซ (Method of de-aeration) เป็นต้น</span><br />
                            <span style="padding-left:2em">- จำนวนหน่วยของผลิตภัณฑ์ยาที่ใช้ (Number of units) (โปรดระบุ).........................</span><br />
                            <span style="padding-left:2em">- โครงร่างการตรวจสอบรายงานวิธีการตรวจสอบความถูกต้องของวิธีการวิเคราะห์ (Protocol & Report for Analytical method Validation/Verification)</span><br />
                            <span style="padding-left:2em">- ผลการศึกษา (Results) โดยรายงานผลการทดสอบการละลายของผลิตภัณฑ์ยา ในตัวกลางการละลายทั้งหมด ด้วยรูปแบบตารางแสดง</span><br />
                            <span style="padding-left:4em">- ร้อยละของการปลดปล่อยตัวยาสำคัญ (% Drug release) แต่ละหน่วย/จุดเวลา และแสดงรายละเอียดการคำนวณดังกล่าว</span><br />
                            <span style="padding-left:4em">- ค่าเฉลี่ยร้อยละการปลดปล่อยตัวยาสำคัญ  12 หน่วย/จุดเวลา</span><br />
                            <span style="padding-left:4em">- ส่วนเบี่ยงเบนมาตรฐาน (Standard deviation: SD ) ของร้อยละการปลดปล่อยตัวยาสำคัญ  12 หน่วย/จุดเวลา</span><br />
                            <span style="padding-left:4em">- % CV หรือ RSD ของร้อยละการปลดปล่อยตัวยาสำคัญ 12 หน่วย/จุดเวลา</span><br />
                            <span style="padding-left:4em">- กราฟแสดงการเปรียบเทียบผลการละลายของผลิตภัณฑ์ยาทดสอบและยาอ้างอิง (Comparative dissolution profiles)</span><br />
                            <span style="padding-left:4em">- เปรียบเทียบความเหมือนกันระหว่างผลการละลายของผลิตภัณฑ์ยาทดสอบ และยาอ้างอิง หรือ ผลิตภัณฑ์ยาเปรียบเทียบ หรือ ผลิตภัณฑ์ยาต้นแบบ ด้วยการแสดงการคำนวณค่า similarity factor (f2) หรือวิธีอื่นที่เหมาะสม พร้อมเหตุผลสนับสนุน</span><br />
                            <span style="padding-left:4em">- การอภิปราย และสรุปผลการทดสอบการละลายของผลิตภัณฑ์ยา (Discussion and Conclusions)</span><br />
                            <span style="padding-left:2em">- ข้อมูลดิบของการทดสอบการละลายของผลิตภัณฑ์ยา (Raw data of Comparative dissolution profile)</span>
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

<div class="modal fade bd-example-modal-lg" id="popup24" tabindex="-1" role="dialog" aria-labelledby="exampleModalCenterTitle" aria-hidden="true">
    <div class="modal-dialog modal-lg">
        <div class="modal-content">
            <div class="modal-header">
                <h5 class="modal-title" id="exampleModalLongTitle"></h5>
                <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                    <span aria-hidden="true"></span>
                </button>
            </div>
            <div class="modal-body">
                <div>เอกสารต้องประกอบด้วยหัวข้ออย่างน้อยดังต่อไปนี้</div>
                <div>จากการยกเว้นการศึกษาชีวสมมูลนั้น ยอมรับได้ในทางสาธารณสุข โดยพิจารณาจากข้อบ่งใช้และดัชนีการรักษาของยา  ด้วยการอภิปรายในหัวข้อ ดังนี้</div>
                <div style="padding-left:2em">- กรณีเกิด Inferior bioavailability จะส่งผลอย่างไรต่อประสิทธิภาพการรักษา โดยเฉพาะประเด็นของการเกิด drug resistance ซึ่งอาจนำไปสู่อันตรายของการใช้ยานี้ในข้อบ่งใช้ต่างๆ</div>
                <div style="padding-left:2em">- กรณีเกิด Superior bioavailability ส่งผลอย่างไรในส่วนของฤทธิ์ทางเภสัชวิทยา และผลข้างเคียงที่อาจเกิดขึ้นให้ชัดเจน (เป็นมติคณะอนุกรรมการฯ)</div>
                <div style="padding-left:2em">- เชื่อมโยงความสัมพันธ์ ระหว่างดุลความเสี่ยงและประโยชน์ที่ได้รับ ผลการทดสอบการละลายของตัวยาสำคัญ การซึมผ่านเซลล์ และผลการทดสอบการละลายของผลิตภัณฑ์ยา</div>
            </div>
            <div class="modal-footer">
                <button type="button" class="btn btn-secondary" data-dismiss="modal">Close</button>
            </div>
        </div>
    </div>
</div>

<div class="modal fade bd-example-modal-lg" id="popup25" tabindex="-1" role="dialog" aria-labelledby="exampleModalCenterTitle" aria-hidden="true">
    <div class="modal-dialog modal-lg">
        <div class="modal-content">
            <div class="modal-header">
                <h5 class="modal-title" id="exampleModalLongTitle"></h5>
                <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                    <span aria-hidden="true"></span>
                </button>
            </div>
            <div class="modal-body">
                <div>เอกสารต้องประกอบด้วยหัวข้ออย่างน้อยดังต่อไปนี้</div>
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