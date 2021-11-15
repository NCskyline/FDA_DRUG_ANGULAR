@Code
    ViewData("Title") = "PREVIEW_EXTEND"
End Code

<script src="~/Scripts_angular/ANGULAR_APP.js"></script>
<script src="~/Scripts_angular/CENTER_SV.js"></script>
<script src="~/Scripts_angular/LCN_CTRL.js"></script>

<div class="ic" > @*ng-app="" ng-controller="LCN_CTRL"*@
    <div style="font-family:'Taviraj';font-size:20px;">
        <div>
            <p style="text-align: right;">แบบ ผ.ย.๙</p>
        </div>
        <table style="width:100%">
            <tr>
                <td style="width:35%"></td>
                <td style="width:35%"></td>
                <td style="width:5%;text-align:right">เลขที่:</td>
                <td style=" width:25%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"><label>{{LCN_LIST.RCVNO_DISPLAY}}</label></td>
            </tr>
        </table>
        <table style="width:100%">
            <tr>
                <td style="width:35%"></td>
                <td style="width:35%"></td>
                <td style="width:5%;text-align:right">วันที่:</td>
                <td style=" width:25%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"><label>{{LCN_LIST.RCV_DATE_DISPLAY}}</label></td>
            </tr>
        </table>
        <table style="width:100%">
            <tr>
                <td style="width:35%"></td>
                <td style="width:35%"></td>
                <td style="width:5%;text-align:right"> ลงชื่อ:</td>
                <td style=" width:15%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"></td>
                <td style="width:10%">ผู้รับคำขอ</td>
            </tr>
        </table>
        <hr />
        <div> <h3 style="text-align:center">คำขอต่ออายุใบอนุญาตผลิตยาแผนปัจจุบัน</h3></div>
        <hr />
        <table style="width:100%">
            <tr>
                <td style="text-align:right;width:90%">
                    เขียนที่
                </td>
                <td style="width:40%;border-bottom:dotted;border-bottom-width:thin;">

                    {{LIST_LCN.LCN_EXTEND_LITE.WRITE_AT}}
                </td>
            </tr>
            <tr>
                <td style="text-align:right;width:100px">
                    วันที่
                </td>
                <td style="border-bottom:dotted;border-bottom-width:thin;">

                    {{LIST_LCN.LCN_EXTEND_LITE.WRITE_DATE}}
                </td>
            </tr>
        </table>
        <br />
        <table style="width:100%">
            <tr>
                <td style="width:10%;text-align:right">ข้าพเจ้า :</td>
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
                <td style="width:13%;">ซึ่งมีผู้ดำเนินกิจการ ชื่อ</td>
                <td style="width:69%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"></td>
                <td style="width:18%;">ได้รับอนุญาตให้ผลิตยาแผนปัจจุบัน</td>
            </tr>
        </table>
        <table style="width:100%">
            <tr>
                <td style="width:13%;">ตามใบนอนุญาตที่</td>
                <td style="width:50%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"><label>{{LIST_LCN.LCNNO_SHOW}}</label></td>
                <td style="width:13%;">ณ สถานที่ผลิตยาชื่อ</td>
                <td style="width:24%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"><label>{{LIST_LCN.thanameplace}}</label></td>
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
        <table style="width:100%">
            <tr>
                <td>ขอต่ออายุใบอนุญาตดังกล่าวเพื่อใช้ต่อไปในปี พ.ศ.</td>
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
        
        <div class="row">
            <div class="col-sm-12 in" style="width:100%">
                <div ng-include="FILE_ATTACH">

                </div>
            </div>
        </div>
        <br />
        <table style="width:100%">
            <tr>
                <td style="width:50%;text-align:center"></td>
                <td style="width:10%;text-align:right">(ลายมือชื่อ)</td>
                <td style="width:20%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"></td>
                <td style="width:20%;text-align:start">ผู้ยื่นคำขอ</td>
            </tr>
        </table>
    </div>
</div>