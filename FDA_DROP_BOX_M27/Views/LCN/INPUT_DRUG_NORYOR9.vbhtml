
@Code
    ViewData("Title") = "INPUT_DRUG_NORYOR9"
End Code
<script type="text/javascript">
        $(document).ready(function () {
            $('select').selectpicker('refresh');
        })
</script>

<div class="ic" ng-app="" ng-controller="">
    <div style="font-family:'Taviraj';font-size:20px;">
        <div>
            <p style="text-align: right;">แบบ น.ย.๙</p>
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
        <div> <h3 style="text-align:center">คำขอต่ออายุใบอนุญาตนำหรือสั่งยาแผนปัจจุบันเข้ามาในราชอาณาจักร</h3></div>
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
                <td style="width:13%;">ซึ่งมีผู้ดำเนินกิจการชื่อ</td>
                <td style="width:69%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"> <label>{{LIST_LCN.BSN_THAIFULLNAME}}</label></td>
                <td style="width:18%;">ได้รับอนุญาตให้นำหรือสั่งยาแผนปัจจุบันเข้ามาใน</td>
            </tr>
        </table>
        <table style="width:100%">
            <tr>
                <td style="width:15%;">ราชอาณาจักรตามใบอนุญาตที่</td>
                <td style="width:85%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"><label>{{LIST_LCN.LCNNO_SHOW}}</label></td>
            </tr>
        </table>
        <table style="width:100%">
            <tr>
                <td style="width:13%;">ณ สถานที่นำหรือสั่งยา ชื่อ</td>
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
                <td style="width:50%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"><label>{{LIST_LCN.tel}}</label></td>
                <td style="width:10%;">เวลาทำการ</td>
                <td style="width:22%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"><label>{{LIST_LCN.opentime}}</label></td>
            </tr>
        </table>
        <table>
            <tr>
                <td>ขอต่ออายุใบอนุญาตดังกล่าว เพื่อใช้ต่อไปในปี พ.ศ.</td>
                <td style="width:20%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"><label>{{LIST_LCN.EXP_NEWYEAR}}</label></td>
            </tr>
        </table>
        <br />
        <table style="width:100%">
            <tr>
                <td style="width:5%">
                <td style="width:95%">ข้าพเจ้าได้แนบหลักฐานมาด้วย คือ</td>
            </tr>
        </table>
        <table style="width:100%">
            <tr>
                <td style="width:5%"></td>
                <td style="width:95%">(1) ใบรับรองของผู้ประกอบวิชาชีพเวชกรรม ซึ่งรับรองว่าผู้ดำเนินกิจการ ไม่เป็นโรคตามมาตรา 14 (6)แห่งพระราชบัญญัติยา พ.ศ. 2510</td>
            </tr>
        </table>
        <table style="width:100%">
            <tr>
                <td style="width:5%"></td>
                <td style="width:95%">(2) ใบอนุญาตนำหรือสั่งยาแผนปัจจุบันเข้ามาในราชอาณาจักรหรือใบแทน</td>
            </tr>
        </table>
        <table style="width:100%">
            <tr>
                <td style="width:5%"></td>
                <td style="width:95%">(3) เอกสารแสดงว่าผู้จัดการหรือผู้แทน ซึ่งเป็นผู้ดำเนินกิจการของนิติบุคคล (กรณีนิติบุคคลเป็นผู้ขออนุญาต)</td>
            </tr>
        </table>
        <table style="width:100%">
            <tr>
                <td style="width:5%"></td>
                <td style="width:95%">(4) เอกสารอื่น ๆ ถ้ามี</td>
            </tr>
        </table>
        <br />
        <table style="width:100%">
            <tr>
                <td style="width:50%;text-align:center"></td>
                <td style="width:10%;text-align:right">(ลายมือชื่อ)</td>
                <td style="width:20%;text-align:center"></td>
                <td style="width:20%;text-align:start">ผู้ยื่นคำขอ</td>
            </tr>
        </table>
    </div>
</div>
