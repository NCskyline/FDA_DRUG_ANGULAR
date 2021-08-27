
@Code
    ViewData("Title") = "INPUT_PDF_DRUG_KORYOR15"
End Code
<div style="font-family:'Taviraj';font-size:20px;" class="ic">

    <div>
        <p style="text-align: right;">แบบ ข.ย.๑๕</p>
    </div>
    <table style="width:100%">
        <tr>
            <td style="width:35%"></td>
            <td style="width:35%"></td>
            <td style="width:5%;text-align:right">เลขที่:</td>
            <td style=" width:25%;text-align:center"><label>{{LCN_LIST.RCVNO_DISPLAY}}</label></td>
        </tr>
    </table>
    <table style="width:100%">
        <tr>
            <td style="width:35%"></td>
            <td style="width:35%"></td>
            <td style="width:5%;text-align:right">วันที่:</td>
            <td style=" width:25%;text-align:center"><label>{{LCN_LIST.RCV_DATE_DISPLAY}}</label></td>
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
    <hr />
    <table width="100%">
        <tr>
            <td width="35%">
                <h3 style="text-align:right">คำขอต่ออายุใบอนุญาต</h3>
            </td>
            <td>
                <div>
                    <p style="text-align:left">
                        &nbsp;&nbsp;&nbsp;<input type="checkbox" ng-model="LIST_LCN.LCN_TYPE" value="1" disabled />ขายยาแผนปัจจุบัน
                        <br />
                        &nbsp;&nbsp;&nbsp;<input type="checkbox" ng-model="LIST_LCN.LCN_TYPE" value="2" disabled />ขายส่งยาแผนปัจจุบัน
                        <br />
                        &nbsp;&nbsp;&nbsp;<input type="checkbox" ng-model="LIST_LCN.LCN_TYPE" value="3" disabled />ขายยาแผนปัจจุบันเฉพาะยาบรรจุเสร็จที่ไม่ใช่ยาอันตรายหรือยาควบคุมพิเศษ
                        <br />
                        &nbsp;&nbsp;&nbsp;<input type="checkbox" ng-model="LIST_LCN.LCN_TYPE" value="4" disabled />ขายยาแผนปัจจุบันเฉพาะยาบรรจุเสร็จสำหรับสัตว์
                </div>
            </td>
        </tr>
    </table>

    <hr />
    <table style="width:100%">
        <tr>
            <td style="text-align:right;width:90%">
                เขียนที่
            </td>
            <td style="width:40%">
                <input class="form-control inline" ng-model="LIST_LCN.LCN_EXTEND_LITE.WRITE_AT" style="font-family:'Taviraj';" type="text" />
            </td>
        </tr>
        <tr>
            <td style="text-align:right;width:100px">
                วันที่
            </td>
            <td>

                <md-datepicker ng-model="LIST_LCN.LCN_EXTEND_LITE.WRITE_DATE" md-placeholder="Enter date"
                               input-aria-describedby="datepicker-description"
                               input-aria-labelledby="datepicker-header ">
                </md-datepicker>
            </td>
        </tr>

    </table>
    <br />
    <table style="width:100%">
        <tr>
            <td style="width:10%;text-align:right">ข้าพเข้า :</td>
            <td style="width:90%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"> <label>{{LIST_LCN.thanm}}</label></td>
        </tr>
    </table>
    <table style="width:100%">
        <tr>
            <td style="width:10%;"></td>
            <td style="width:90%;text-align:center">(ชื่อผู้รับอนุญาต)</td>
        </tr>
    </table>
    <table style="width:100%">
        <tr>
            <td style="width:13%;">มีผู้ดำเนินกิจการ ชื่อ</td>
            <td style="width:74%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"> <label>{{LIST_LCN.BSN_THAIFULLNAME}}</label></td>
            <td style="width:13%;">(เฉพาะกรณีนิติบุคคล)</td>
        </tr>
    </table>
    <table style="width:100%">
        <tr>
            <td style="width:13%;">เลขที่บัตรประชาชน</td>
            <td style="width:50%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"> <label>{{LIST_LCN.BSN_IDENTIFY}}</label></td>
            <td style="width:13%;">ได้รับอนุญาตให้ขายยา</td>
            <td style="width:24%;text-align:center"></td>
        </tr>
    </table>
    <table style="width:100%">
        <tr>
            <td style="width:13%;">ใบอนุญาตเลขที่</td>
            <td style="width:87%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"><label>{{LIST_LCN.LCNNO_SHOW}}</label></td>
        <tr />
        <tr>
            <td style="width:13%;">ณ สถานที่ขายยาชื่อ</td>
            <td style="width:87%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"><label>{{LIST_LCN.thanameplace}}</label></td>
        </tr>
    </table>
    <table style="width:100%">
        <tr>
            <td style="width:5%;">อยู่เลขที่</td>
            <td style="width:95%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"><label>{{LIST_LCN.fulladdr3}}</label></td>
        </tr>
    </table>
    <table style="width:100%">
        <tr>
            <td style="width:18%;">โทรศัพท์/โทรศัพท์มือถือ</td>
            <td style="width:82%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"><label>{{LIST_LCN.tel}}</label></td>
        </tr>
    </table>
    <table>
        <tr>
            <td > ขอต่ออายุใบอนุญาตดังกล่าว เพื่อใช้ต่อไปในปี พ.ศ.</td>
            <td style="width:20%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"><label>{{LIST_LCN.EXP_NEWYEAR}}</label></td>
        </tr>
    </table>
    <br />
    <table style="width:100%">
        <tr>
            <td style="width:5%">
            <td style="width:95%">ข้าพเจ้าเป็นผู้มีคุณสมบัติครบถ้วนตามมาตรา ๑๔ ของพระราชบัญญัติยา พ.ศ. ๒๕๑๐ ซึ่งไม่เป็นบุคคลล้มละลายและข้าพเจ้าได้แนบหลักฐานมาด้วย คือ </td>
        </tr>
    </table>
    <table style="width:100%">
        <tr>
            <td style="width:5%"></td>
            <td style="width:95%">(๑) ใบรับรองของผู้ประกอบวิชาชีพเวชกรรมผู้ประกอบวิชาชีพเวชกรรมซึ่งรับรองว่าผู้รับอนุญาตหรือผู้ดำเนินกิจการสุขภาพแข็งแรงและ ไม่เป็นโรคตามมาตรา ๑๔ (๖) แห่งพระราชบัญญัติยา พ.ศ. ๒๕๑๐</td>
        </tr>
    </table>
    <table style="width:100%">
        <tr>
            <td style="width:5%"></td>
            <td style="width:95%">(๒) ใบรับรองของผู้ประกอบวิชาชีพเวชกรรมผู้ประกอบวิชาชีพเวชกรรมซึ่งรับรองว่าผู้มีหน้าที่ปฏิบัติการมีสุขภาพแข็งแรงสามารถประกอบวิชาชีพได้</td>
        </tr>
    </table>
    <table style="width:100%">
        <tr>
            <td style="width:5%"></td>
            <td style="width:95%">(๓) ใบอนุญาตประกอบธุรกิจเกี่ยวกับยาแผนปัจจุบันหรือใบแทน</td>
        </tr>
    </table>
    <table style="width:100%">
        <tr>
            <td style="width:5%"></td>
            <td style="width:95%">(๔) เอกสารแสดงว่าผู้ดำเนินกิจการซึ่งเป็นผู้แทนหรือผู้จัดการนิติบุคคลของนิติบุคคล (กรณีนิติบุคคลเป็นผู้ขออนุญาต)</td>
        </tr>
    </table>
    <table style="width:100%">
        <tr>
            <td style="width:5%"></td>
            <td style="width:95%">(๕) สำเนาทะเบียนบ้านของผู้รับอนุญาต</td>
        </tr>
    </table>
    <table style="width:100%">
        <tr>
            <td style="width:5%"></td>
            <td style="width:95%">(๖) คำรับรองตามแบบ ข.ย. ๑๔ พร้อมเอกสารประกอบ</td>
        </tr>
    </table>
    <table style="width:100%">
        <tr>
            <td style="width:5%"></td>
            <td style="width:95%">(๗) ผลการตรวจประเมินวิธีปฏิบัติทางเภสัชกรรมชุมชน</td>
        </tr>
    </table>
    <table style="width:100%">
        <tr>
            <td style="width:5%"></td>
            <td style="width:95%">(๘) เอกสารอื่น ๆ (ถ้าจำเป็น)</td>
        </tr>
    </table>
    <br />
    <table style="width:100%">
        <tr>
            <td style="width:50%;text-align:center"></td>
            <td style="width:10%;text-align:right">(ลายมือชื่อ)</td>
            <td style="width:20%;text-align:center"></td>
            <td style="width:20%;text-align:start">ผู้คำขอ</td>
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
    <div>หมายเหตุ :- &nbsp; ใส่เครื่องหมาย &#10004; ในช่อง [  ] หน้าข้อความที่ต้องการ</div>
</div>