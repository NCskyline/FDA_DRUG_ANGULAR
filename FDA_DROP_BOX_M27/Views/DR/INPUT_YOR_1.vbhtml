@Code
    ViewData("Title") = "INPUT_YOR_1"
End Code

    <script src="~/Scripts_angular/ANGULAR_APP.js"></script>
    <script src="~/Scripts_angular/CENTER_SV.js"></script>
    <script src="~/Scripts_angular/DR_CTRL.js"></script>

<div  ng-app="" ng-controller="">
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
        <br />
        <div>
            <h2><b>รายการไฟล์แนบ</b></h2>
        </div>
        <br />

        <table class="table" width="100%">
            <tr>
                <td width="40%">รูปภาพยา</td>
                <td>
                    <input id="file-input" style="width:70%" ng-model="datas.FILE_DATA" type="file" name="file" ngf-select="selectFileforUpload(datas,$files)" />
                </td>
            </tr>
            <tr>
                <td>ฉลากและเอกสารกำกับผลิตภัณฑ์ ทุกภาชนะบรรจุ</td>
                <td>
                    <input id="file-input" style="width:70%" ng-model="datas.FILE_DATA" type="file" name="file" ngf-select="selectFileforUpload(datas,$files)" />
                </td>
            </tr>
            <tr>
                <td>ผลการวิเคราะห์คุณภาพยาสำเร็จรูป</td>
                <td>
                    <input id="file-input" style="width:70%" ng-model="datas.FILE_DATA" type="file" name="file" ngf-select="selectFileforUpload(datas,$files)" />
                </td>
            </tr>
            <tr>
                <td>คำรับรองเงื่อนไขต่างๆที่เกี่ยวข้อง</td>
                <td>
                    <input id="file-input" style="width:70%" ng-model="datas.FILE_DATA" type="file" name="file" ngf-select="selectFileforUpload(datas,$files)" />
                </td>
            </tr>
            <tr>
                <td>กรรมวิธีการผลิต</td>
                <td>
                    <input id="file-input" style="width:70%" ng-model="datas.FILE_DATA" type="file" name="file" ngf-select="selectFileforUpload(datas,$files)" />
                </td>
            </tr>
            <tr>
                <td>การขออนุมัติโครงร่างการศึกษาความเท่าเทียมกันทางผลการรักษา (Therapeutic equivalence protocol)</td>
                <td>
                    <input id="file-input" style="width:70%" ng-model="datas.FILE_DATA" type="file" name="file" ngf-select="selectFileforUpload(datas,$files)" />
                </td>
            </tr>
            <tr>
                <td>การขออนุมัติรายงานการยกเว้นการศึกษาชีวสมมูลในมนุษย์แบบ BCS Class I และ Dose Proportionality</td>
                <td>
                    <input id="file-input" style="width:70%" ng-model="datas.FILE_DATA" type="file" name="file" ngf-select="selectFileforUpload(datas,$files)" />
                </td>
            </tr>
            <tr>
                <td>การขออนุมัติรายงานการศึกษาชีวสมมูล (Bioequivalence report)</td>
                <td>
                    <input id="file-input" style="width:70%" ng-model="datas.FILE_DATA" type="file" name="file" ngf-select="selectFileforUpload(datas,$files)" />
                </td>
            </tr>
        </table>
        <br />
        <a style="color:red">หมายเหตุ : กรุณาแนบเอกสารเพิ่มเติมให้ครบทั้ง 6 ข้อ ในรูปแบบ PDF</a>
        <br />
        <br />
        <div style="text-align:center">
            <button class="btn btn-lg">บันทึก</button>
            <button class="btn btn-lg" ng-click="BTN_BACK()">ย้อนกลับ</button>
        </div>
    </div>
</div>