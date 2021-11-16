@Code
    ViewData("Title") = "PREVIEW_EDIT_LCN" End Code

<script src="~/Scripts_angular/ANGULAR_APP.js"></script>
<script src="~/Scripts_angular/CENTER_SV.js"></script>
<script src="~/Scripts_angular/LCN_CTRL.js"></script>

<style>
    .title1 {
        width: 150px;
        height: 170px;
        /*background-color: aqua;*/
        text-align: center;
        border: solid;
        float: left;
    }

    .title2 {
        width: 400px;
        height: 120px;
        /*background-color:antiquewhite;*/
        text-align: center;
        border: solid;
        float: right;
    }

    .checkbox {
        width: 20px;
        height: 20px;
        margin-left: 45%;
        margin-top: 5%;
    }

    .hr {
        width: 95%;
        height: 10px;
        background-color: black;
    }

    .datepickerdemoBasicUsage {
        /** Demo styles for mdCalendar. */
    }

     .datepickerdemoBasicUsage md-content {
         padding-bottom: 200px;
     }
     
     .datepickerdemoBasicUsage .validation-messages {
         font-size: 12px;
         color: #dd2c00;
         margin-left: 15px;
     }
</style>

<div class="ic" ng-controller="LCN_CTRL" ng-app="ANGULAR_APP" ng-init="pageload_modify()">
    <div ng-show="LIST_LCN.PROCESS == '11105'">
        <div style="font-family:'Taviraj';font-size:24px;">
            <div>
                <p style="text-align: right;">แบบ ข.ย.๑๗</p>
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
            <div> <p style="text-align:center">คำขอแก้ไขเปลี่ยนแปลงรายการในใบอนุญาตขายยาแผนปัจจุบัน</p></div>
            <hr />
            <table style="width:100%">
                <tr>
                    <td style="text-align:right;width:90%">
                        เขียนที่
                    </td>
                    <td style="width:40%;border-bottom:dotted;border-bottom-width:thin;">

                        {{LIST_LCN.DALCN_EDIT_REQUEST.WRITE_AT}}
                    </td>
                </tr>
                <tr>
                    <td style="text-align:right;width:100px">
                        วันที่
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;">

                        {{LIST_LCN.DALCN_EDIT_REQUEST.WRITE_DATE}}
                    </td>
                </tr>
            </table>
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
                    <td style="width:13%;">มีผู้ดำเนินกิจการ ชื่อ</td>
                    <td style="width:74%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"> <label>{{LIST_LCN.BSN_THAIFULLNAME}}</label></td>
                    <td style="width:13%;">(เฉพาะกรณีนิติบุคคล)</td>
                </tr>
            </table>
            <table style="width:100%;">
                <tr>
                    <td style="width:13%;">เลขที่บัตรประชาชน</td>
                    <td style="width:87%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"> <label>{{LIST_LCN.BSN_IDENTIFY}}</label></td>
                </tr>
            </table>
            <div style="padding-left:30%;">
                <table>
                    <tr>
                        <td>ได้รับอนุญาตให้ :</td>
                        <td>
                            <input type="radio" name="type_a" ng-model="LIST_LCN.CHK_TYPE" value="1" id="rdl_CHK_SELL_TYPE" disabled="disabled" />ขายยาแผนปัจจุบัน
                        </td>
                    </tr>
                    <tr>
                        <td></td>
                        <td>
                            <input type="radio" name="type_a" ng-model="LIST_LCN.CHK_TYPE" value="2" id="rdl_CHK_SELL_TYPE" disabled="disabled" />ขายยาแผนปัจจุบันเฉพาะยาบรรจุเสร็จที่ไม่ใช่ยาอันตรายหรือยาควบคุมพิเศษ
                        </td>
                    </tr>
                    <tr>
                        <td></td>
                        <td> <input type="radio" name="type_a" ng-model="LIST_LCN.CHK_TYPE" value="3" id="rdl_CHK_SELL_TYPE" disabled="disabled" />ขายยาแผนปัจจุบันเฉพาะยาบรรจุเสร็จสำหรับสัตว์</td>
                    </tr>
                    <tr>
                        <td></td>
                        <td> <input type="radio" name="type_a" ng-model="LIST_LCN.CHK_TYPE" value="4" id="rdl_CHK_SELL_TYPE" disabled="disabled" />ขายส่งยาแผนปัจจุบัน</td>
                    </tr>
                </table>
            </div>
            <table style="width:100%">
                <tr>
                    <td style="width:13%;">ใบอนุญาตเลขที่</td>
                    <td style="width:20%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"><label>{{LIST_LCN.LCNNO_SHOW}}</label></td>
                    <td style="width:12%;">ณ สถานที่ขายยาชื่อ</td>
                    <td style="width:55%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"><label>{{LIST_LCN.thanameplace}}</label></td>
                </tr>
            </table>
            <table style="width:100%">
                <tr>
                    <td style="width:10%;">ตั้งอยู่เลขที่</td>
                    <td style="width:90%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"><label>{{LIST_LCN.fulladdr3}}</label></td>
                </tr>
            </table>
            <table style="width:100%">
                <tr>
                    <td style="width:13%;">โทรศัพท์/โทรศัพท์มือถือ</td>
                    <td style="width:87%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"><label>{{LIST_LCN.tel}}</label></td>
                </tr>
            </table>
            <table style="width:100%">
                <tr>
                    <td>ขอเปลี่ยนแปลงรายการในใบอนุญาต ดังต่อไปนี้</td>
                <tr>
                    <td style="border-bottom:dotted;border-bottom-width:thin">
                        @*<input class="form-control inline" ng-model="LIST_LCN.DALCN_EDIT_REQUEST.EDIT_DESCRIPTION" style="font-family:'Taviraj';font-size:20px;width:100%;" type="text" />*@
                        {{LIST_LCN.DALCN_EDIT_REQUEST.EDIT_DESCRIPTION}}
                    </td>
                </tr>
            </table>
            <br />
            <table>
                <tr>
                    <td> &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; ขายส่งยาแผนปัจจุบัน คือ</td>
                </tr>
            </table>
            <table>
                <tr>
                    <td> &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; (๑) ใบอนุญาตประกอบธุรกิจเกี่ยวกับยาหรือใบแทน</td>
                </tr>
            </table>
            <table>
                <tr>
                    <td> &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; (๒) เอกสารที่เป็นหลักฐานเกี่ยวข้องกับรายการที่ขอเปลี่ยนแปลง</td>
                </tr>
            </table>
            <table style="width:100%">
                <tr>
                    <td style="width:50%;text-align:center"></td>
                    <td style="width:10%;text-align:right">(ลายมือชื่อ)</td>
                    <td style="width:20%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"></td>
                    <td style="width:20%;text-align:start">ผู้รับอนุญาต</td>
                </tr>
            </table>
            <table style="width:100%">
                <tr>
                    <td style="width:50%;text-align:center"></td>
                    <td style="width:10%;text-align:right">(</td>
                    <td style="width:20%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"></td>
                    <td style="width:20%;text-align:start">) (ตัวบรรจง)</td>
                </tr>
            </table>
            <table style="width:100%">
                <tr>
                    <td style="width:50%;text-align:center"></td>
                    <td style="width:10%;text-align:right">(ลายมือชื่อ)</td>
                    <td style="width:20%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"></td>
                    <td style="width:20%;text-align:start">ผู้มีหน้าที่ปฏิบัติการ</td>
                </tr>
            </table>
            <table style="width:100%">
                <tr>
                    <td style="width:50%;text-align:center"></td>
                    <td style="width:10%;text-align:right">(</td>
                    <td style="width:20%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"></td>
                    <td style="width:20%;text-align:start">) (ตัวบรรจง)</td>
                </tr>
            </table>
        </div>
    </div>

    <div ng-show="LIST_LCN.PROCESS == '11106'">
        <div style="font-family:'Taviraj';font-size:24px;">
            <div>
                <p style="text-align: right;">แบบ ผ.ย.๑๒</p>
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
            <div> <p style="text-align:center">คำขอแก้ไขเปลี่ยนแปลงรายการในใบอนุญาต</p></div>
            <div> <p style="text-align:center">ผลิตยาแผนปัจจุบัน</p></div>
            <hr />
            <table style="width:100%">
                <tr>
                    <td style="text-align:right;width:90%">
                        เขียนที่
                    </td>
                    <td style="width:40%;border-bottom:dotted;border-bottom-width:thin;">

                        {{LIST_LCN.DALCN_EDIT_REQUEST.WRITE_AT}}
                    </td>
                </tr>
                <tr>
                    <td style="text-align:right;width:100px">
                        วันที่
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;">

                        {{LIST_LCN.DALCN_EDIT_REQUEST.WRITE_DATE}}
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
                    <td style="width:15%;">ซึ่งมีผู้ดำเนินกิจการ ชื่อ</td>
                    <td style="width:74%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"> <label>{{LIST_LCN.BSN_THAIFULLNAME}}</label></td>
                    <td style="width:15%;text-align:right">ได้รับอนุญาตให้ผลิตยา</td>
                </tr>
            </table>
            <table style="width:100%">
                <tr>
                    <td style="width:15%;">แผนปัจจุบันตามใบอนุญาตที่</td>
                    <td style="width:35%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"><label>{{LIST_LCN.LCNNO_SHOW}}</label></td>
                    <td style="width:15%;">ณ สถานที่ผลิตยาชื่อ</td>
                    <td style="width:35%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"><label>{{LIST_LCN.THANAMEPLACE}}</label></td>
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
                    <td style="width:18%;">โทรศัพท์</td>
                    <td style="width:82%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"><label>{{LIST_LCN.tel}}</label></td>
                </tr>
            </table>
            <p>ขอเปลี่ยนแปลงรายการในใบอนุญาต ดังต่อไปนี้</p>
            <table style="width:100%">
                <tr>
                    <td style="border-bottom:dotted;border-bottom-width:thin">
                        @*<input class="form-control inline" ng-model="LIST_LCN.DALCN_EDIT_REQUEST.EDIT_DESCRIPTION" style="font-family:'Taviraj';font-size:20px;width:100%;" type="text" />*@
                        {{LIST_LCN.DALCN_EDIT_REQUEST.EDIT_DESCRIPTION}}
                    </td>
                </tr>
            </table>
            <br />
            <table>
                <tr>
                    <td>ข้าพเจ้าได้แนบหลักฐานมาด้วย คือ</td>
                <tr>
                    <td>&nbsp;&nbsp;&nbsp;&nbsp; (๑) ใบอนุญาตผลิตยาแผนปัจจุบันหรือใบแทน</td>
                <tr>
                    <td>&nbsp;&nbsp;&nbsp;&nbsp; (๒) เอกสารที่เป็นหลักฐานเกี่ยวข้องกับรายการที่ขอเปลี่ยนแปลง</td>
                </tr>
            </table>
            <br />
            <table style="width:100%">
                <tr>
                    <td style="width:50%;text-align:center"></td>
                    <td style="width:10%;text-align:right">(ลายมือชื่อ)</td>
                    <td style="width:20%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"></td>
                    <td style="width:20%;text-align:start">ผู้ยื่นคำขอ</td>
                </tr>
            </table>
            <table style="width:100%">
                <tr>
                    <td style="width:50%;text-align:center"></td>
                    <td style="width:10%;text-align:right">(ลายมือชื่อ)</td>
                    <td style="width:20%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"></td>
                    <td style="width:20%;text-align:start">ผู้มีหน้าที่ปฏิบัติการ</td>
                </tr>
            </table>
        </div>
    </div>

    <div ng-show="LIST_LCN.PROCESS == '11107'">
        <div style="font-family:'Taviraj';font-size:24px;">
            <div>
                <p style="text-align: right;">แบบ น.ย.๑๑</p>
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
            <div> <p style="text-align:center">คำขอแก้ไขเปลี่ยนแปลงรายการในใบอนุญาต</p></div>
            <div> <p style="text-align:center">นำหรือสั่งยาแผนปัจจุบันเข้ามาในราชอาณาจักร</p></div>
            <hr />
            <table style="width:100%">
                <tr>
                    <td style="text-align:right;width:90%">
                        เขียนที่
                    </td>
                    <td style="width:40%;border-bottom:dotted;border-bottom-width:thin;">

                        {{LIST_LCN.DALCN_EDIT_RREQUEST.WRITE_AT}}
                    </td>
                </tr>
                <tr>
                    <td style="text-align:right;width:100px">
                        วันที่
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;">

                        {{LIST_LCN.DALCN_EDIT_RREQUEST.WRITE_DATE}}
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
                    <td style="width:15%;">ซึ่งมีผู้ดำเนินกิจการ ชื่อ</td>
                    <td style="width:74%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"> <label>{{LIST_LCN.BSN_THAIFULLNAME}}</label></td>
                    <td style="width:15%;text-align:right">ได้รับอนุญาตให้นำหรือสั่งยา</td>
                </tr>
            </table>
            <table style="width:100%">
                <tr>
                    <td style="width:27%;">แผนปัจจุบันเข้ามาในราชอาณาจักรตามใบอนุญาตที่</td>
                    <td style="width:60%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"><label>{{LIST_LCN.LCNNO_SHOW}}</label></td>
                    <td style="width:23%;text-align:right">ณ สถานที่นำหรือสั่งยาชื่อ</td>
                </tr>
            </table>
            <table style="width:100%">
                <tr>
                    <td style="width:100%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"><label>{{LIST_LCN.THANAMEPLACE}}</label></td>
                </tr>
            </table>
            <table style="width:100%">
                <tr>
                    <td style="width:10%;">ตั้งอยู่เลขที่</td>
                    <td style="width:90%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"><label>{{LIST_LCN.fulladdr3}}</label></td>
                </tr>
            </table>
            <table style="width:100%">
                <tr>
                    <td style="width:13%;">โทรศัพท์</td>
                    <td style="width:87%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"><label>{{LIST_LCN.tel}}</label></td>
                </tr>
            </table>
            <div>ขอเปลี่ยนแปลงรายการในใบอนุญาต ดังต่อไปนี้</div>
            <table style="width:100%">
                <tr>
                    <td style="border-bottom:dotted;border-bottom-width:thin">
                        @*<input class="form-control inline" ng-model="LIST_LCN.DALCN_EDIT_REQUEST.EDIT_DESCRIPTION" style="font-family:'Taviraj';font-size:20px;width:100%;" type="text" />*@
                        {{LIST_LCN.DALCN_EDIT_REQUEST.EDIT_DESCRIPTION}}
                    </td>
                </tr>
            </table>
            <br />
            <table>
                <tr>
                    <td>&nbsp;&nbsp;&nbsp;&nbsp;ข้าพเจ้าได้แนบหลักฐานมาด้วย คือ</td>
                <tr>
                    <td>&nbsp;&nbsp;&nbsp;&nbsp;(๑) ใบอนุญาตนำหรือสั่งยาแผนปัจจุบันเข้ามาในราชอาณาจักรหรือใบแทน</td>
                <tr>
                    <td>&nbsp;&nbsp;&nbsp;&nbsp;(๒) เอกสารที่เป็นหลักฐานเกี่ยวข้องกับรายการที่ขอเปลี่ยนแปลง</td>
                </tr>
            </table>
            <br />
            <table style="width:100%">
                <tr>
                    <td style="width:50%;text-align:center"></td>
                    <td style="width:10%;text-align:right">(ลายมือชื่อ)</td>
                    <td style="width:20%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"></td>
                    <td style="width:20%;text-align:start">ผู้ยื่นคำขอ</td>
                </tr>
            </table>
            <table style="width:100%">
                <tr>
                    <td style="width:50%;text-align:center"></td>
                    <td style="width:10%;text-align:right">(ลายมือชื่อ)</td>
                    <td style="width:20%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"></td>
                    <td style="width:20%;text-align:start">ผู้มีหน้าที่ปฏิบัติการ</td>
                </tr>
            </table>
        </div>
    </div>

    <div ng-show="LIST_LCN.PROCESS == '11108'">
        <div style="font-family:'Taviraj';font-size:24px;">
            <div>
                <p style="text-align: right;">แบบ ย.บ.๑๖</p>
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
            <br />
            <table style="width:100%">
                <tr>
                    <td style="text-align:center">คำขอแก้ไขเปลี่ยนแปลงรายการในใบอนุญาต</td>
                </tr>
            </table>
            <table style="width:100%">
                <tr>
                    <td style="width:50%"></td>
                    <td style="text-align:start"> <input type="radio" ng-model="LIST_LCN.CHK_TYPE" value="1" disabled /> ผลิตยาแผนโบราณ</td>
                <tr>
                    <td style="width:50%"></td>
                    <td style="text-align:start"> <input type="radio" ng-model="LIST_LCN.CHK_TYPE" value="2" disabled /> ขายยาแผนโบราณ</td>
                <tr>
                    <td style="width:50%"></td>
                    <td style="width:50%;text-align:start"> <input type="radio" ng-model="LIST_LCN.CHK_TYPE" value="3" disabled /> นำหรือสั่งยาแผนโบราณเข้ามาในราชอาณาจักร</td>
                </tr>
            </table>
            <hr />
            <table style="width:100%">
                <tr>
                    <td style="text-align:right;width:90%">
                        เขียนที่
                    </td>
                    <td style="width:40%;border-bottom:dotted;border-bottom-width:thin;">

                        {{LIST_LCN.DALCN_EDIT_REQUEST.WRITE_AT}}
                    </td>
                </tr>
                <tr>
                    <td style="text-align:right;width:100px">
                        วันที่
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;">

                        {{LIST_LCN.DALCN_EDIT_REQUEST.WRITE_DATE}}
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
                    <td style="width:13%;">มีผู้ดำเนินกิจการ ชื่อ</td>
                    <td style="width:74%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"> <label>{{LIST_LCN.BSN_THAIFULLNAME}}</label></td>
                    <td style="width:13%;">(เฉพาะกรณีนิติบุคคล)</td>
                </tr>
            </table>
            <table>
                <tr>
                    <td style="width:20%;">ได้รับอนุญาตให้</td>
                    <td> <input type="radio" ng-model="LIST_LCN.CHK_TYPE" value="1" disabled /> ผลิตยาแผนโบราณ</td>
                    <td> <input type="radio" ng-model="LIST_LCN.CHK_TYPE" value="2" disabled /> ขายยาแผนโบราณ</td>
                    <td> <input type="radio" ng-model="LIST_LCN.CHK_TYPE" value="3" disabled /> นำหรือสั่งยาแผนโบราณเข้ามาในราชอาณาจักร</td>
                </tr>
            </table>
            <table style="width:100%">
                <tr>

                    <td style="width:15%;text-align:right">ตามใบอนุญาตที่</td>
                    <td style="width:85%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"><label>{{LIST_LCN.LCNNO_SHOW}}</label></td>
                </tr>
            </table>
            <table style="width:100%">
                <tr>
                    <td style="width:15%;">ณ สถานที่ประกอบธุรกิจ ชื่อ</td>
                    <td style="width:85%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"><label>{{LIST_LCN.THANAMEPLACE}}</label></td>
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
                    <td style="width:18%;">โทรศัพท์</td>
                    <td style="width:82%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"><label>{{LIST_LCN.tel}}</label></td>
                </tr>
            </table>
            <label>ขอเปลี่ยนแปลงรายการในใบอนุญาต ดังต่อไปนี้</label>
            <table style="width:100%">
                <tr>
                    <td style="border-bottom:dotted;border-bottom-width:thin">
                        @*<input class="form-control inline" ng-model="LIST_LCN.DALCN_EDIT_REQUEST.EDIT_DESCRIPTION" style="font-family:'Taviraj';font-size:20px;width:100%;" type="text" />*@
                        {{LIST_LCN.DALCN_EDIT_REQUEST.EDIT_DESCRIPTION}}
                    </td>
                </tr>
            </table>
            <br />
            <table>
                <tr>
                    <td>ข้าพเจ้าได้แนบหลักฐานมาด้วย คือ</td>
                <tr>
                    <td>&nbsp;&nbsp;&nbsp;&nbsp; (๑) ใบอนุญาตประกอบธุรกจเกี่ยวกับยาแผนโบราณหรือใบแทน</td>
                <tr>
                    <td>&nbsp;&nbsp;&nbsp;&nbsp; (๒) เอกสารที่เป็นหลักฐานเกี่ยวข้องกับรายการที่ขอเปลี่ยนแปลง</td>
                </tr>
            </table>
            <br />
            <table style="width:100%">
                <tr>
                    <td style="width:50%;text-align:center"></td>
                    <td style="width:10%;text-align:right">(ลายมือชื่อ)</td>
                    <td style="width:20%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"></td>
                    <td style="width:20%;text-align:start">ผู้ยื่นคำขอ</td>
                </tr>
            </table>
            <table style="width:100%">
                <tr>
                    <td style="width:50%;text-align:center"></td>
                    <td style="width:10%;text-align:right">(ลายมือชื่อ)</td>
                    <td style="width:20%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"></td>
                    <td style="width:20%;text-align:start">ผู้มีหน้าที่ปฏิบัติการ</td>
                </tr>
            </table>
            <hr />
            <div>หมายเหตุ : &nbsp;ใส่เครื่องหมาย &#10004; ในช่อง [  ] หน้าข้อความที่ต้องการ</div>
        </div>
    </div>

    <div ng-show="LIST_LCN.PROCESS == '11109'">
        <div style="font-family:'Taviraj';font-size:15px;">
            <div>
                <h1 style="text-align:center;">
                    คำขอเปลี่ยนแปลงรายการในใบอนุญาต
                </h1>

                <hr style="width:20%; border-color:black;" />
            </div>
            <br />
            <div>
                <table style="width:100%">
                    <tr>
                        <td style="text-align:right;width:90%">
                            เขียนที่
                        </td>
                        <td style="width:40%;border-bottom:dotted;border-bottom-width:thin;">

                            {{LIST_LCN.DALCN_EDIT_REQUEST.WRITE_AT}}
                        </td>
                    </tr>
                    <tr>
                        <td style="text-align:right;width:100px">
                            วันที่
                        </td>
                        <td style="border-bottom:dotted;border-bottom-width:thin;">

                            {{LIST_LCN.DALCN_EDIT_REQUEST.WRITE_DATE}}
                        </td>
                    </tr>
                </table>
                <br />
                <table style="width:100%">
                    <tr>
                        <td style="width:15%; text-align:right">ข้าพเจ้า</td>
                        <td style="width:85%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"> <label>{{LIST_LCN.thanm}}</label></td>
                    </tr>
                </table>
                <table style="width:100%">
                    <tr>
                        <td style="width:40%"></td>
                        <td style="width:60%">ชื่อผู้รับอนุญาต</td>
                    </tr>
                </table>

                <table style="width:100%">
                    <tr>
                        <td style="width:10%">ซึ่งมีผู้ดำเนินกิจการชื่อ</td>
                        <td style="width:75%;border-bottom:dotted;border-bottom-width:thin;"> <label>{{LIST_LCN.BSN_THAIFULLNAME}}</label></td>
                        <td style="width:15%">ได้รับอนุญาตให้</td>
                    </tr>
                </table>
                <table style="width:100%">
                    <tr>
                        <td style="width:40%;border-bottom:dotted;border-bottom-width:thin;"><label>{{LIST_LCN.TYPE_LCN}}</label></td>
                        <td style="width:10%">ตามใบอนุญาตเลขที่</td>
                        <td style="width:50%;border-bottom:dotted;border-bottom-width:thin;"></td>
                    </tr>
                </table>
                <table style="width:100%">
                    <tr>
                        <td style="width:10%">ณ สถานที่ชื่อ</td>
                        <td style="width:90%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"><label>{{LIST_LCN.thanameplace}}</label></td>

                    </tr>
                    <tr>
                        <td style="width:10%;">อยู่เลขที่</td>
                        <td style="width:90%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"><label>{{LIST_LCN.fulladdr3}}</label></td>
                    </tr>
                </table>
                <table style="width:100%">
                    <tr>
                        <td style="width:10%">โทรศัพท์</td>
                        <td style="width:90%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"><label>{{LIST_LCN.tel}}</label></td>
                    </tr>

                </table>
                <table style="width:100%">
                    <tr>
                        <td>ขอเปลี่ยนแปลงรายการในใบอนุญาต ดังต่อไปนี้</td>
                    <tr>
                        <td style="border-bottom:dotted;border-bottom-width:thin">
                            @*<input class="form-control inline" ng-model="LIST_LCN.DALCN_EDIT_REQUEST.EDIT_DESCRIPTION" style="font-family:'Taviraj';font-size:20px;width:100%;" type="text" />*@
                            {{LIST_LCN.DALCN_EDIT_REQUEST.EDIT_DESCRIPTION}}
                        </td>
                    </tr>
                </table>
                <br /><br /><br /><br /><br /><br /><br />
                <table style="width:100%">
                    <tr>
                        <td style="width:10%"></td>
                        <td style="width:90%">ข้าพเจ้าได้แนบหลักฐานมาด้วย คือ</td>
                    </tr>
                    <tr>
                        <td style="width:10%"></td>
                        <td style="width:90%">1.ใบอนุญาต</td>
                    </tr>
                    <tr>
                        <td style="width:10%"></td>
                        <td style="width:90%">2.เอกสารที่เป็นหลักฐานเกี่ยวข้องกับรายการเปลี่ยนแปลง</td>
                    </tr>
                </table>
                <br /><br /><br /><br />
                <table style="width:100%">
                    <tr>
                        <td style="width:50%; text-align:center"></td>
                        <td style="width:10%; text-align:right">(ลายมือชื่อ)</td>
                        <td style="width:20%; text-align:center;border-bottom:dotted;border-bottom-width:thin;"></td>
                        <td style="width:20%; text-align:start">ผู้ยื่นคำขอ</td>
                    </tr>
                </table>
            </div>
        </div>
    </div>

    <div ng-show="LIST_LCN.PROCESS == '11103'">
        <div style="font-family:'Taviraj';font-size:24px;width:100%">
            <h1 style="text-align:left;font-size:24px;">
                <strong>แบบ ข.ว.จ. ๓/๔-๓</strong>
            </h1>
            <br />
            <h2 style="text-align:center;font-size:24px;">
                <strong>คำขอย้าย เปลี่ยนแปลง หรือเพิ่มสถานที่ขายหรือสถานที่เก็บ</strong><br />
                <strong>วัตถุออกฤทธิ์ในประเภท ๓ หรือประเภท ๔</strong>
            </h2>
            <br />
            <div class="title1">
                @*process =11103 *@
                <table style="font-size:20px;margin:auto;margin-top:6%">
                    <tr>
                        <td>
                            <strong>ใบอนุญาตขายวัตถุออกฤทธิ์</strong>
                        </td>
                        <td>
                            <input type="radio" name="gender" ng-model="LIST_LCN.LCN_TYPE_NCT" value="1" /> <strong>ในประเภท ๓</strong>
                        </td>
                        <td>
                            <input type="radio" name="gender" ng-model="LIST_LCN.LCN_TYPE_NCT" value="2" /> <strong>ในประเภท ๔</strong>
                        </td>
                    </tr>
                    <tr>
                        <td style="text-align:left">
                            <strong>เลขที่</strong>
                        </td>
                        <td style="border-bottom:dotted;border-bottom-width:thin;" colspan="3">
                            <label>{{LCN_LIST.RCVNO_DISPLAY}}</label>
                        </td>
                    </tr>
                    <tr>
                        <td style="text-align:left">
                            <strong>ณ สถานที่ ชื่อ</strong>
                        </td>
                        <td style="border-bottom:dotted;border-bottom-width:thin;" colspan="2">
                            <label>{{LIST_LCN.thanameplace}}</label>
                        </td>
                    </tr>
                </table>
            </div>
            <div class="title2">
                <table style="font-size:20px;width:95%;margin-top:10px;margin-left:10px">
                    <tr>
                        <td style="text-align:left;width:20%">
                            เลขรับที่
                        </td>

                        <td style="border-bottom:dotted;border-bottom-width:thin;" colspan="3">
                            <label>{{LCN_LIST.RCVNO_DISPLAY}}</label>
                        </td>
                    </tr>
                    <tr>
                        <td style="text-align:left">
                            วันที่
                        </td>

                        <td style="border-bottom:dotted;border-bottom-width:thin;" colspan="3">
                            <label>{{LCN_LIST.RCV_DATE_DISPLAY}}</label>
                        </td>
                    </tr>
                    <tr>
                        <td style="text-align:center" colspan="2">
                            (สำหรับเจ้าหน้าที่เป็นผู้กรอก)

                        </td>
                </table>

            </div>
            <div style="clear:both"></div>
            <br />
            <br />
            <table style="width:100%">
                <tr>
                    <td style="text-align:right;width:90%">
                        เขียนที่
                    </td>
                    <td style="width:40%;border-bottom:dotted;border-bottom-width:thin;">

                        {{LIST_LCN.DALCN_EDIT_REQUEST.WRITE_AT}}
                    </td>
                </tr>
                <tr>
                    <td style="text-align:right;width:100px">
                        วันที่
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;">

                        {{LIST_LCN.DALCN_EDIT_REQUEST.WRITE_DATE}}
                    </td>
                </tr>
            </table>
            <br />

            <table style="width:100%; font-size:20px">
                <tr>

                    <td style="width:20%">
                        <form name="rdl_gmp">

                            <label><input type="radio" ng-model="LIST_LCN.DALCN_EDIT_REQUEST.CHK_TYPE1" id="rdl_CHK_TYPE" value="1" /> <strong>ย้ายสถานที่</strong></label><br />
                            <label><input type="radio" ng-model="LIST_LCN.DALCN_EDIT_REQUEST.CHK_TYPE1" id="rdl_CHK_TYPE" value="2" /> <strong>เปลี่ยนแปลงสถานที่</strong></label><br />
                            <label><input type="radio" ng-model="LIST_LCN.DALCN_EDIT_REQUEST.CHK_TYPE1" id="rdl_CHK_TYPE" value="3" /> <strong>เพิ่มสถานที่</strong></label>

                        </form>

                    </td>
                </tr>
            </table>
            <br />

            <h2 style="font-size:24px;">
                <strong>๑. ข้อมูลผู้ขอรับใบอนุญาต</strong>
            </h2>
            <table style="width:90%;margin-left:5%">
                <tr>
                    <td style="font-size:20px" width="40%">
                        ข้าพเจ้า (ชื่อบุคคล/นิติบุคคล)
                    </td>
                    <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;" colspan="6">
                        <label>{{LIST_LCN.thanm}}</label>
                    </td>
                </tr>
                <tr>
                    <td style="font-size:20px">
                        เลขประจำตัวประชาชน
                    </td>

                    <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;" colspan="6">
                        <label>{{LIST_LCN.CITIZEN_AUTHORIZE}}</label>
                    </td>
                </tr>
                <tr>
                    <td style="font-size:20px">
                        หรือบัตรประจำตัวอื่นที่ทางราชการออกให้ คือ
                    </td>
                    <td style="font-size:20px;width:20%;border-bottom:dotted;border-bottom-width:thin;"></td>
                    <td style="font-size:20px;width:5%">
                        เลขที่
                    </td>
                    <td style="font-size:20px ;width:15%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"></td>
                    <td style="font-size:20px">
                        (กรณีไม่ใช่ผู้มีสัญชาติไทย)
                    </td>
                </tr>
                <tr>
                    <td style="font-size:20px">
                        หรือทะเบียนนิติบุคคล/บัตรประจำตัวผู้เสียภาษี เลขที่
                    </td>
                    <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;" colspan="6">
                        <label>{{LIST_LCN.IDENTIFY}}</label>
                    </td>
                </tr>
                <tr>
                    <td style="font-size:20px">
                        เลขรหัสประจำบ้าน
                    </td>
                    <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;" colspan="6">
                        <label>{{LIST_LCN.HOUSENO}}</label>
                    </td>
                </tr>
                <tr>
                    <td style="font-size:20px">
                        อยู่เลขที่
                    </td>
                    <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;" colspan="6">
                        <label>{{LIST_LCN.fulladdr3}}</label>
                    </td>
                </tr>
                <tr>
                    <td style="font-size:20px">
                        โทรศัพท์/มือถือ
                    </td>
                    <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;" colspan="6">
                        <label>{{LIST_LCN.tel}}</label>
                    </td>
                </tr>
                <tr>
                    <td style="font-size:20px">
                        E-mail
                    </td>
                    <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;" colspan="6">
                        <label>{{LIST_LCN.Email}}</label>
                    </td>
                </tr>
            </table>

            <h2 style="font-size:24px;">
                <strong>๒. ข้อมูลผู้ได้รับมอบหมายหรือแต่งตั้งให้ดำเนินกิจการเกี่ยวกับใบอนุญาต</strong>
            </h2>
            <table style="width:90%;margin-left:5%">
                <tr>
                    <td style="font-size:20px" width="40%">
                        ข้าพเจ้า
                    </td>
                    <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;" colspan="6">
                        <label>{{LIST_LCN.BSN_THAIFULLNAME}}</label>
                    </td>
                </tr>
                <tr>
                    <td style="font-size:20px">
                        เลขประจำตัวประชาชน
                    </td>

                    <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;" colspan="6">
                        <label>{{LIST_LCN.BSN_IDENTIFY}}</label>
                    </td>
                </tr>
                <tr>
                    <td style="font-size:20px">
                        หรือบัตรประจำตัวอื่นที่ทางราชการออกให้ คือ
                    </td>
                    <td style="font-size:20px;width:20%;border-bottom:dotted;border-bottom-width:thin;">
                        @*<label>{{LIST_LCN.BSN_THAIFULLNAME}}</label>*@
                    </td>
                    <td style="font-size:20px;width:5%">
                        เลขที่
                    </td>
                    <td style="font-size:20px ;width:15%;text-align:center;border-bottom:dotted;border-bottom-width:thin;">
                        @*<label>{{LIST_LCN.BSN_THAIFULLNAME}}</label>*@
                    </td>
                    <td style="font-size:20px">
                        (กรณีไม่ใช่ผู้มีสัญชาติไทย)
                    </td>
                </tr>
                <tr>
                    <td style="font-size:20px">
                        หรือทะเบียนนิติบุคคล/บัตรประจำตัวผู้เสียภาษี เลขที่
                    </td>
                    <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;" colspan="6">
                        <label>{{LIST_LCN.BSN_IDENTIFY}}</label>
                    </td>
                </tr>
                <tr>
                    <td style="font-size:20px">
                        เลขรหัสประจำบ้าน
                    </td>
                    <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;" colspan="6">
                        <label>{{LIST_LCN.BSN_HOUSENO}}</label>
                    </td>
                </tr>
                <tr>
                    <td style="font-size:20px">
                        อยู่เลขที่
                    </td>
                    <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;" colspan="6">
                        <label>{{LIST_LCN.fulladdr2}}</label>
                    </td>
                </tr>
                <tr>
                    <td style="font-size:20px">
                        โทรศัพท์/มือถือ
                    </td>
                    <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;" colspan="6">
                        <label>{{LIST_LCN.BSN_TEL}}</label>
                    </td>
                </tr>
                <tr>
                    <td style="font-size:20px">
                        E-mail
                    </td>
                    <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;" colspan="6">
                        <label>{{LIST_LCN.dalcn.Email}}</label>
                    </td>
                </tr>
            </table>


            <h2 style="font-size:24px;">
                <strong>๓. ขอแก้ไขเปลี่ยนแปลงรายการในใบอนุญาตดังต่อไปนี้</strong>
            </h2>
            <table style="width:90%;font-size:20px;margin-left:5%">
                <tr>
                    <td colspan="2">
                        <strong>(๓.๑) <u>กรณีย้ายสถานที่ขายวัตถุออกฤกธิ์ คือ</u></strong>
                    </td>

                </tr>
                <tr>
                    <td style="width:30%">
                        เลขรหัสประจำบ้าน
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_LCN.HOUSENO}}</label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <strong>สถานที่เดิม</strong> ตั้งอยู่เลขที่
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_LCN.fulladdr3}}</label>
                    </td>
                </tr>
                <tr>
                    <td>
                        โทรศัพท์/มือถือ
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_LCN.tel}}</label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <strong>สถานที่ใหม่</strong>
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;">
                        @*<select class="form-control selectpicker" data-live-search="true" title="-- Please select --" ng-model="LIST_LCN.LOCATION_SELECT" ng-change="getdetails_lct(LIST_LCN.LOCATION_SELECT)">
                            @*<option value="0">--กรุณาเลือก--</option>*@
                        @*<option ng-repeat="x in REF_LOCATION" value="{{x.IDA}}">{{x.thanameplace}}</option>
                            </select>*@
                        {{LIST_LCN.LOCATION_SELECT}}
                    </td>
                </tr>
                <tr ng-repeat="data in LIST_LABEL_LCT">
                    <td>

                        ตั้งอยู่เลขที่
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;">
                        {{data.fulladdr3}}
                    </td>
                </tr>
                <tr ng-repeat="datas in LIST_LABEL_LCT">
                    <td>
                        โทรศัพท์/มือถือ
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;">
                        {{datas.tel}}
                    </td>
                </tr>
            </table>

            <table style="width:90%;font-size:20px;margin-left:5%">
                <tr>
                    <td colspan="2">
                        <strong>(๓.๒) <u>กรณีย้ายสถานที่เก็บวัตถุออกฤกธิ์ คือ</u></strong>
                    </td>

                </tr>
                <tr>
                    <td style="width:30%">
                        เลขรหัสประจำบ้าน
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_LCN.KEEP_HOUSENO}}</label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <strong>สถานที่เดิม</strong> ตั้งอยู่เลขที่
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_LCN.KEEP_FULL_ADDR}}</label>
                    </td>
                </tr>
                <tr>
                    <td>
                        โทรศัพท์/มือถือ
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_LCN.KEEP_TEL}}</label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <strong>สถานที่ใหม่</strong>
                    </td>
                    <td>
                        @*<select class="form-control selectpicker" data-live-search="true" title="-- Please select --" ng-model="LIST_LCN.LOCATION_SELECT" ng-change="getdetails(LIST_LCN.LOCATION_SELECT)">
                            @*<option value="0">--กรุณาเลือก--</option>*@
                        @*<option ng-repeat="x in REF_LOCATION_KEEP" value="{{x.IDA}}">{{x.thanameplace}}</option>
                            </select>*@
                        {{LIST_LCN.LOCATION_SELECT}}
                    </td>
                </tr>
                <tr>
                    <td>
                        ตั้งอยู่เลขที่
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_LABEL.fulladdr}}</label>
                    </td>
                </tr>
                <tr>
                    <td>
                        โทรศัพท์/มือถือ
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_LABEL.tel}}</label>
                    </td>
                </tr>
            </table>

            <table style="width:90%;font-size:20px;margin-left:5%">
                <tr>
                    <td colspan="2">
                        <strong>(๓.๓) <u>กรณีเปลี่ยนแปลงหรือเพิ่มสถานที่ขายหรือสถานที่เก็บวัตถุออกฤทธิ์ </u></strong> (ให้ระบุเหตุผลความจำเป็น และลักษณะของการเปลี่ยน และ
                    </td>

                </tr>
                <tr>
                    <td>
                        ลักษณะของการเปลี่ยนแปลงหรือการเพิ่มสถานที่ เช่น เพิ่ม/ลดขนาดพื้นที่ของอาคาร หรือเพิ่มอาคารแห่งใหม่)
                    </td>
                </tr>
                <tr>
                    <td style="border-bottom:dotted;border-bottom-width:thin">
                        @*<input class="form-control inline" ng-model="LIST_LCN.DALCN_EDIT_REQUEST.EDIT_DESCRIPTION" style="font-family:'Taviraj';font-size:20px;" type="text" />*@
                        {{LIST_LCN.DALCN_EDIT_REQUEST.EDIT_DESCRIPTION}}
                    </td>
                </tr>
            </table>

            <table style="width:90%;font-size:20px;margin-left:5%">
                <tr>
                    <td style="width:17%">
                        <strong>โดยมีเภสัชกรชื่อ</strong> 1
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;">
                        {{LIST_LCN.PHR_NAME}}
                    </td>
                    <td style="text-align:center">
                        ใบอนุญาตประกอบวิชาชีพเภสัชกรรมเลขที่
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;">
                        {{LIST_LCN.PHR_TEXT_NUM}}
                    </td>
                </tr>

                <tr>
                    <td colspan="4">
                        เป็นผู้ควบคุมตามมาตรา ๕๑ แห่งพระราชบัญญัติวัตถุที่ออกฤทธิ์ต่อจิตและประสาท พ.ศ. ๒๕๕๙
                    </td>
                </tr>
            </table>
            <br />
            <div style="font-size:20px"><strong>๔. พร้อมกับคำขอนี้ข้าพเจ้าได้แนบเอกสารหรือหลักฐานต่างๆ มาด้วย คือ</strong></div>
            <table style="width:90%;font-size:20px;margin-left:5%">
                <tr>
                    <td colspan="2">
                        (๔.๑) ใบอนุญาตขายวัตถุออกฤทธิ์ในประเภท ๓ หรือประเภท ๔ แล้วแต่กรณี
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        (๔.๒) เอกสารแสดงรายละเอียดของสถานที่ขายหรือสถานที่เก็บวัตถุออกฤทธิ์แห่งใหม่หรือที่มีการเปลี่ยนแปลง
                    </td>
                </tr>
                <tr>
                    <td style="width:25%">
                        หรือเพิ่ม แล้วแต่กรณี (ถ้ามี)
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin">
                        @*<input type="text" ng-model="LIST_LCN.DALCN_EDIT_REQUEST.EDIT_DESCRIPTION" id="txt_EDIT_DESCRIPTION" />*@
                        {{LIST_LCN.DALCN_EDIT_REQUEST.EDIT_DESCRIPTION}}
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <strong>ข้าพเจ้าขอรับรองว่า ข้อความและเอกสารหรือหลักฐานทั้งหมดที่ยื่นเพื่อประกอบคำขอรับใบอนุญาตเป็นความจริงทุกประการ</strong>
                    </td>
                </tr>
            </table>
            <br />

            <table style="width:85%;font-size:20px">
                <tr>
                    <td style="text-align:right">
                        (ลายมือชื่อ)
                    </td>
                    <td style="text-align:center;width:40%;border-bottom:dotted;border-bottom-width:thin;"></td>
                    <td>
                        ผู้ขอรับใบอนุญาต/ผู้ได้รับมอบหมายหรือแต่งตั้งให้ดำเนินกิจการ
                    </td>
                </tr>
                <tr>
                    <td style="text-align:right">
                        (
                    </td>
                    <td style="text-align:center;border-bottom:dotted;border-bottom-width:thin;">
                        {{LIST_LCN.BSN_THAIFULLNAME}}
                    </td>
                    <td style="text-align:left">
                        )
                    </td>
                </tr>

            </table>
            <br />
            <br />

            <div style="font-size:20px"><strong>หมายเหตุ :</strong> (๑) ให้ยื่นคำขอ ๑ ฉบับต่อ ๑ ใบอนุญาตเท่านั้น</div>
            <div style="font-size:20px;margin-left:6.3%">(๒) ให้ขีดเลือกข้อความในช่อง ☐ ให้ตรงตามที่ประสงค์จะดำเนินการ</div>
            <div style="font-size:20px;margin-left:6.3%">(๓) รับรองสำเนาถูกต้องในเอกสารที่เป็นสำเนาทุกฉบับ</div>
            <div style="font-size:20px;margin-left:6.3%">(๔) กรณีเอกสารหรือหลักฐานที่ออกโดยสำนักงานคณะกรรมการอาหารและยา ผู้อนุญาตอาจไม่ขอเอกสารหรือหลักฐานดังกล่าวก็ได้</div>
            <div style="font-size:20px;margin-left:6.3%">(๕) ในที่นี้</div>
            <div style="font-size:20px;margin-left:10%"><strong>·</strong>"ย้ายสถานที่" หมายถึง กรณีผู้ขออนุญาตย้ายสถานที่ที่ได้รับอนุญาต ไปตั้ง ณ สถานที่อื่นหรือสถานที่</div>
            <div style="font-size:20px">แห่งใหม่ ซึ่งย้ายสถานที่ที่ได้รับอนุญาตแห่งเดิมทั้งหมด มิใช่ย้ายเพียงบางส่วนหรือบางแผนก</div>
            <div style="font-size:20px;margin-left:10%"><strong>·</strong>"เปลี่ยนแปลงสถานที่" หมายถึง กรณีผู้ขออนุญาตเปลี่ยนแปลงสถานที่ที่ได้รับอนุญาตแห่งเดิม</div>
            <div style="font-size:20px">โดยการขยายพื้นที่ของอาคาร ลดพื้นที่ของอาคารลง หรือมีการเปลี่ยนแปลงหรือรับปรุงลักษณะของอาคารที่ได้รับอนุญาต</div>
            <div style="font-size:20px;margin-left:10%"><strong>·</strong>"เพิ่มสถานที่" หมายถึง กรณีผู้ขออนุญาตเพิ่มสถานที่จากที่ได้รับอนุญาตอีกแห่งหนึ่ง เช่น มีอาคารเพิ่ม</div>
            <div style="font-size:20px">อีกแห่งหนึ่งในพื้นที่บริเวณใกล้เคียงกับแห่งเดิม โดยสถานที่แห่งใหม่อาจจะอยู่บนโฉนดที่ดินเดียวกับสถานที่ที่ได้รับอนุญาตแห่งเดิม</div>
            <div style="font-size:20px">หรือโฉนดที่ดินติดกัน แต่ทั้งนี้ ไม่รวมถึงกรณีการเพิ่มสาขาหรือขยายสาขา</div>
            <div style="font-size:20px;margin-left:6.3%">(๖) กรณีการยื่นคำขอโดยวิธีการทางอิเล็กทรอนิกส์ เอกสารหรือหลักฐานประกอบคำขอให้เป็นไปตามระบบ</div>
            <div style="font-size:20px">การยื่นทางอิเล็กทรอนิกส์ที่สำนักงานคณะกรรมการอาหารและยากำหนด</div>
        </div>
    </div>

    <div ng-show="LIST_LCN.PROCESS == '11104'">
        <div style="font-family:'Taviraj';font-size:24px;width:100%">
            <h1 style="text-align:left;font-size:24px;">
                <strong>แบบ ข.ว.จ. ๓/๔-๓</strong>
            </h1>
            <br />
            <h2 style="text-align:center;font-size:24px;">
                <strong>คำขอย้าย เปลี่ยนแปลง หรือเพิ่มสถานที่ผลิตหรือสถานที่เก็บ</strong><br />
                <strong>วัตถุออกฤทธิ์ในประเภท ๓ หรือประเภท ๔</strong>
            </h2>
            <br />
            <div class="title1">
                @*process =11104 *@
                <table style="font-size:20px;margin:auto;margin-top:6%">
                    <tr>
                        <td>
                            <strong>ใบอนุญาตผลิตวัตถุออกฤทธิ์</strong>
                        </td>
                        <td>
                            <input type="radio" name="gender" ng-model="LIST_LCN.LCN_TYPE_NCT" value="1" /> <strong>ในประเภท ๓</strong>
                        </td>
                        <td>
                            <input type="radio" name="gender" ng-model="LIST_LCN.LCN_TYPE_NCT" value="2" /> <strong>ในประเภท ๔</strong>
                        </td>
                    </tr>
                    <tr>
                        <td style="text-align:left">
                            <strong>เลขที่</strong>
                        </td>
                        <td style="border-bottom:dotted;border-bottom-width:thin;" colspan="3">
                            <label>{{LCN_LIST.RCVNO_DISPLAY}}</label>
                        </td>
                    </tr>
                    <tr>
                        <td style="text-align:left">
                            <strong>ณ สถานที่ ชื่อ</strong>
                        </td>
                        <td style="border-bottom:dotted;border-bottom-width:thin;" colspan="2">
                            <label>{{LIST_LCN.thanameplace}}</label>
                        </td>
                    </tr>
                </table>
            </div>
            <div class="title2">
                <table style="font-size:20px;width:95%;margin-top:10px;margin-left:10px">
                    <tr>
                        <td style="text-align:left;width:20%">
                            เลขรับที่
                        </td>

                        <td style="border-bottom:dotted;border-bottom-width:thin;" colspan="3">
                            <label>{{LCN_LIST.RCVNO_DISPLAY}}</label>
                        </td>
                    </tr>
                    <tr>
                        <td style="text-align:left">
                            วันที่
                        </td>

                        <td style="border-bottom:dotted;border-bottom-width:thin;" colspan="3">
                            <label>{{LCN_LIST.RCV_DATE_DISPLAY}}</label>
                        </td>
                    </tr>
                    <tr>
                        <td style="text-align:center" colspan="2">
                            (สำหรับเจ้าหน้าที่เป็นผู้กรอก)

                        </td>
                </table>

            </div>
            <div style="clear:both"></div>
            <br />
            <br />
            <table style="width:100%">
                <tr>
                    <td style="text-align:right;width:90%">
                        เขียนที่
                    </td>
                    <td style="width:40%;border-bottom:dotted;border-bottom-width:thin;">

                        {{LIST_LCN.DALCN_EDIT_REQUEST.WRITE_AT}}
                    </td>
                </tr>
                <tr>
                    <td style="text-align:right;width:100px">
                        วันที่
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;">

                        {{LIST_LCN.DALCN_EDIT_REQUEST.WRITE_DATE}}
                    </td>
                </tr>
            </table>
            <br />

            <table style="width:100%; font-size:20px">
                <tr>

                    <td style="width:20%">
                        <form name="rdl_gmp">


                            <label><input type="radio" ng-model="LIST_LCN.DALCN_EDIT_REQUEST.CHK_TYPE1" id="rdl_CHK_TYPE" value="1" /> <strong>ย้ายสถานที่</strong></label><br />
                            <label><input type="radio" ng-model="LIST_LCN.DALCN_EDIT_REQUEST.CHK_TYPE1" id="rdl_CHK_TYPE" value="2" /> <strong>เปลี่ยนแปลงสถานที่</strong></label><br />
                            <label><input type="radio" ng-model="LIST_LCN.DALCN_EDIT_REQUEST.CHK_TYPE1" id="rdl_CHK_TYPE" value="3" /> <strong>เพิ่มสถานที่</strong></label>

                        </form>

                    </td>
                </tr>
            </table>
            <br />

            <h2 style="font-size:24px;">
                <strong>๑. ข้อมูลผู้ขอรับใบอนุญาต</strong>
            </h2>
            <table style="width:90%;margin-left:5%">
                <tr>
                    <td style="font-size:20px" width="40%">
                        ข้าพเจ้า (ชื่อบุคคล/นิติบุคคล)
                    </td>
                    <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;" colspan="6">
                        <label>{{LIST_LCN.thanm}}</label>
                    </td>
                </tr>
                <tr>
                    <td style="font-size:20px">
                        เลขประจำตัวประชาชน
                    </td>

                    <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;" colspan="6">
                        <label>{{LIST_LCN.CITIZEN_AUTHORIZE}}</label>
                    </td>
                </tr>
                <tr>
                    <td style="font-size:20px">
                        หรือบัตรประจำตัวอื่นที่ทางราชการออกให้ คือ
                    </td>
                    <td style="font-size:20px;width:20%;border-bottom:dotted;border-bottom-width:thin;"></td>
                    <td style="font-size:20px;width:5%">
                        เลขที่
                    </td>
                    <td style="font-size:20px ;width:15%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"></td>
                    <td style="font-size:20px">
                        (กรณีไม่ใช่ผู้มีสัญชาติไทย)
                    </td>
                </tr>
                <tr>
                    <td style="font-size:20px">
                        หรือทะเบียนนิติบุคคล/บัตรประจำตัวผู้เสียภาษี เลขที่
                    </td>
                    <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;" colspan="6">
                        <label>{{LIST_LCN.IDENTIFY}}</label>
                    </td>
                </tr>
                <tr>
                    <td style="font-size:20px">
                        เลขรหัสประจำบ้าน
                    </td>
                    <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;" colspan="6">
                        <label>{{LIST_LCN.HOUSENO}}</label>
                    </td>
                </tr>
                <tr>
                    <td style="font-size:20px">
                        อยู่เลขที่
                    </td>
                    <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;" colspan="6">
                        <label>{{LIST_LCN.fulladdr3}}</label>
                    </td>
                </tr>
                <tr>
                    <td style="font-size:20px">
                        โทรศัพท์/มือถือ
                    </td>
                    <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;" colspan="6">
                        <label>{{LIST_LCN.tel}}</label>
                    </td>
                </tr>
                <tr>
                    <td style="font-size:20px">
                        E-mail
                    </td>
                    <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;" colspan="6">
                        <label>{{LIST_LCN.Email}}</label>
                    </td>
                </tr>
            </table>

            <h2 style="font-size:24px;">
                <strong>๒. ข้อมูลผู้ได้รับมอบหมายหรือแต่งตั้งให้ดำเนินกิจการเกี่ยวกับใบอนุญาต</strong>
            </h2>
            <table style="width:90%;margin-left:5%">
                <tr>
                    <td style="font-size:20px" width="40%">
                        ข้าพเจ้า
                    </td>
                    <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;" colspan="6">
                        <label>{{LIST_LCN.BSN_THAIFULLNAME}}</label>
                    </td>
                </tr>
                <tr>
                    <td style="font-size:20px">
                        เลขประจำตัวประชาชน
                    </td>

                    <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;" colspan="6">
                        <label>{{LIST_LCN.BSN_IDENTIFY}}</label>
                    </td>
                </tr>
                <tr>
                    <td style="font-size:20px">
                        หรือบัตรประจำตัวอื่นที่ทางราชการออกให้ คือ
                    </td>
                    <td style="font-size:20px;width:20%;border-bottom:dotted;border-bottom-width:thin;">
                        @*<label>{{LIST_LCN.BSN_THAIFULLNAME}}</label>*@
                    </td>
                    <td style="font-size:20px;width:5%">
                        เลขที่
                    </td>
                    <td style="font-size:20px ;width:15%;text-align:center;border-bottom:dotted;border-bottom-width:thin;">
                        @*<label>{{LIST_LCN.BSN_THAIFULLNAME}}</label>*@
                    </td>
                    <td style="font-size:20px">
                        (กรณีไม่ใช่ผู้มีสัญชาติไทย)
                    </td>
                </tr>
                <tr>
                    <td style="font-size:20px">
                        หรือทะเบียนนิติบุคคล/บัตรประจำตัวผู้เสียภาษี เลขที่
                    </td>
                    <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;" colspan="6">
                        <label>{{LIST_LCN.BSN_IDENTIFY}}</label>
                    </td>
                </tr>
                <tr>
                    <td style="font-size:20px">
                        เลขรหัสประจำบ้าน
                    </td>
                    <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;" colspan="6">
                        <label>{{LIST_LCN.BSN_HOUSENO}}</label>
                    </td>
                </tr>
                <tr>
                    <td style="font-size:20px">
                        อยู่เลขที่
                    </td>
                    <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;" colspan="6">
                        <label>{{LIST_LCN.fulladdr2}}</label>
                    </td>
                </tr>
                <tr>
                    <td style="font-size:20px">
                        โทรศัพท์/มือถือ
                    </td>
                    <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;" colspan="6">
                        <label>{{LIST_LCN.BSN_TEL}}</label>
                    </td>
                </tr>
                <tr>
                    <td style="font-size:20px">
                        E-mail
                    </td>
                    <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;" colspan="6">
                        <label>{{LIST_LCN.dalcn.Email}}</label>
                    </td>
                </tr>
            </table>


            <h2 style="font-size:24px;">
                <strong>๓. ขอแก้ไขเปลี่ยนแปลงรายการในใบอนุญาตดังต่อไปนี้</strong>
            </h2>
            <table style="width:90%;font-size:20px;margin-left:5%">
                <tr>
                    <td colspan="2">
                        <strong>(๓.๑) <u>กรณีย้ายสถานที่ขายวัตถุออกฤกธิ์ คือ</u></strong>
                    </td>

                </tr>
                <tr>
                    <td style="width:30%">
                        เลขรหัสประจำบ้าน
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_LCN.HOUSENO}}</label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <strong>สถานที่เดิม</strong> ตั้งอยู่เลขที่
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_LCN.fulladdr3}}</label>
                    </td>
                </tr>
                <tr>
                    <td>
                        โทรศัพท์/มือถือ
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_LCN.tel}}</label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <strong>สถานที่ใหม่</strong>
                    </td>
                    <td>
                        @*<select class="form-control selectpicker" data-live-search="true" title="-- Please select --" ng-model="LIST_LCN.LOCATION_SELECT" ng-change="getdetails_lct(LIST_LCN.LOCATION_SELECT)">
                            @*<option value="0">--กรุณาเลือก--</option>*@
                        @*<option ng-repeat="x in REF_LOCATION" value="{{x.IDA}}">{{x.thanameplace}}</option>
                            </select>*@
                        {{LIST_LCN.LOCATION_SELECT}}
                    </td>
                </tr>
                <tr ng-repeat="data in LIST_LABEL_LCT">
                    <td>

                        ตั้งอยู่เลขที่
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;">
                        {{data.fulladdr3}}
                    </td>
                </tr>
                <tr ng-repeat="datas in LIST_LABEL_LCT">
                    <td>
                        โทรศัพท์/มือถือ
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;">
                        {{datas.tel}}
                    </td>
                </tr>
            </table>

            <table style="width:90%;font-size:20px;margin-left:5%">
                <tr>
                    <td colspan="2">
                        <strong>(๓.๒) <u>กรณีย้ายสถานที่เก็บวัตถุออกฤกธิ์ คือ</u></strong>
                    </td>

                </tr>
                <tr>
                    <td style="width:30%">
                        เลขรหัสประจำบ้าน
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_LCN.KEEP_HOUSENO}}</label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <strong>สถานที่เดิม</strong> ตั้งอยู่เลขที่
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_LCN.KEEP_FULL_ADDR}}</label>
                    </td>
                </tr>
                <tr>
                    <td>
                        โทรศัพท์/มือถือ
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_LCN.KEEP_TEL}}</label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <strong>สถานที่ใหม่</strong>
                    </td>
                    <td>
                        @*<select class="form-control selectpicker" data-live-search="true" title="-- Please select --" ng-model="LIST_LCN.LOCATION_SELECT" ng-change="getdetails(LIST_LCN.LOCATION_SELECT)">
                            @*<option value="0">--กรุณาเลือก--</option>*@
                        @*<option ng-repeat="x in REF_LOCATION_KEEP" value="{{x.IDA}}">{{x.thanameplace}}</option>
                            </select>*@
                        {{LIST_LCN.LOCATION_SELECT}}
                    </td>
                </tr>
                <tr>
                    <td>
                        ตั้งอยู่เลขที่
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_LABEL.fulladdr}}</label>
                    </td>
                </tr>
                <tr>
                    <td>
                        โทรศัพท์/มือถือ
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_LABEL.tel}}</label>
                    </td>
                </tr>
            </table>

            <table style="width:90%;font-size:20px;margin-left:5%">
                <tr>
                    <td colspan="2">
                        <strong>(๓.๓) <u>กรณีเปลี่ยนแปลงหรือเพิ่มสถานที่ขายหรือสถานที่เก็บวัตถุออกฤทธิ์ </u></strong> (ให้ระบุเหตุผลความจำเป็น และลักษณะของการเปลี่ยน และ
                    </td>

                </tr>
                <tr>
                    <td>
                        ลักษณะของการเปลี่ยนแปลงหรือการเพิ่มสถานที่ เช่น เพิ่ม/ลดขนาดพื้นที่ของอาคาร หรือเพิ่มอาคารแห่งใหม่)
                    </td>
                </tr>
                <tr>
                    <td style="border-bottom:dotted;border-bottom-width:thin">
                        @*<input class="form-control inline" ng-model="LIST_LCN.DALCN_EDIT_REQUEST.EDIT_DESCRIPTION" style="font-family:'Taviraj';font-size:20px;" type="text" />*@
                        {{LIST_LCN.DALCN_EDIT_REQUEST.EDIT_DESCRIPTION}}
                    </td>
                </tr>
            </table>

            <table style="width:90%;font-size:20px;margin-left:5%">
                <tr>
                    <td style="width:17%">
                        <strong>โดยมีเภสัชกรชื่อ</strong> 1
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;">
                        {{LIST_LCN.PHR_NAME}}
                    </td>
                    <td style="text-align:center">
                        ใบอนุญาตประกอบวิชาชีพเภสัชกรรมเลขที่
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;">
                        {{LIST_LCN.PHR_TEXT_NUM}}
                    </td>
                </tr>

                <tr>
                    <td colspan="4">
                        เป็นผู้ควบคุมตามมาตรา ๕๑ แห่งพระราชบัญญัติวัตถุที่ออกฤทธิ์ต่อจิตและประสาท พ.ศ. ๒๕๕๙
                    </td>
                </tr>
            </table>
            <br />
            <div style="font-size:20px"><strong>๔. พร้อมกับคำขอนี้ข้าพเจ้าได้แนบเอกสารหรือหลักฐานต่างๆ มาด้วย คือ</strong></div>
            <table style="width:90%;font-size:20px;margin-left:5%">
                <tr>
                    <td colspan="2">
                        (๔.๑) ใบอนุญาตขายวัตถุออกฤทธิ์ในประเภท ๓ หรือประเภท ๔ แล้วแต่กรณี
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        (๔.๒) เอกสารแสดงรายละเอียดของสถานที่ขายหรือสถานที่เก็บวัตถุออกฤทธิ์แห่งใหม่หรือที่มีการเปลี่ยนแปลง
                    </td>
                </tr>
                <tr>
                    <td style="width:25%">
                        หรือเพิ่ม แล้วแต่กรณี (ถ้ามี)
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin">
                        @*<input type="text" ng-model="LIST_LCN.DALCN_EDIT_REQUEST.EDIT_DESCRIPTION" id="txt_EDIT_DESCRIPTION" />*@
                        {{LIST_LCN.DALCN_EDIT_REQUEST.EDIT_DESCRIPTION}}
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <strong>ข้าพเจ้าขอรับรองว่า ข้อความและเอกสารหรือหลักฐานทั้งหมดที่ยื่นเพื่อประกอบคำขอรับใบอนุญาตเป็นความจริงทุกประการ</strong>
                    </td>
                </tr>
            </table>
            <br />

            <table style="width:85%;font-size:20px">
                <tr>
                    <td style="text-align:right">
                        (ลายมือชื่อ)
                    </td>
                    <td style="text-align:center;width:40%;border-bottom:dotted;border-bottom-width:thin;"></td>
                    <td>
                        ผู้ขอรับใบอนุญาต/ผู้ได้รับมอบหมายหรือแต่งตั้งให้ดำเนินกิจการ
                    </td>
                </tr>
                <tr>
                    <td style="text-align:right">
                        (
                    </td>
                    <td style="text-align:center;border-bottom:dotted;border-bottom-width:thin;">
                        {{LIST_LCN.BSN_THAIFULLNAME}}
                    </td>
                    <td style="text-align:left">
                        )
                    </td>
                </tr>

            </table>
            <br />
            <br />

            <div style="font-size:20px"><strong>หมายเหตุ :</strong> (๑) ให้ยื่นคำขอ ๑ ฉบับต่อ ๑ ใบอนุญาตเท่านั้น</div>
            <div style="font-size:20px;margin-left:6.3%">(๒) ให้ขีดเลือกข้อความในช่อง ☐ ให้ตรงตามที่ประสงค์จะดำเนินการ</div>
            <div style="font-size:20px;margin-left:6.3%">(๓) รับรองสำเนาถูกต้องในเอกสารที่เป็นสำเนาทุกฉบับ</div>
            <div style="font-size:20px;margin-left:6.3%">(๔) กรณีเอกสารหรือหลักฐานที่ออกโดยสำนักงานคณะกรรมการอาหารและยา ผู้อนุญาตอาจไม่ขอเอกสารหรือหลักฐานดังกล่าวก็ได้</div>
            <div style="font-size:20px;margin-left:6.3%">(๕) ในที่นี้</div>
            <div style="font-size:20px;margin-left:10%"><strong>·</strong>"ย้ายสถานที่" หมายถึง กรณีผู้ขออนุญาตย้ายสถานที่ที่ได้รับอนุญาต ไปตั้ง ณ สถานที่อื่นหรือสถานที่</div>
            <div style="font-size:20px">แห่งใหม่ ซึ่งย้ายสถานที่ที่ได้รับอนุญาตแห่งเดิมทั้งหมด มิใช่ย้ายเพียงบางส่วนหรือบางแผนก</div>
            <div style="font-size:20px;margin-left:10%"><strong>·</strong>"เปลี่ยนแปลงสถานที่" หมายถึง กรณีผู้ขออนุญาตเปลี่ยนแปลงสถานที่ที่ได้รับอนุญาตแห่งเดิม</div>
            <div style="font-size:20px">โดยการขยายพื้นที่ของอาคาร ลดพื้นที่ของอาคารลง หรือมีการเปลี่ยนแปลงหรือรับปรุงลักษณะของอาคารที่ได้รับอนุญาต</div>
            <div style="font-size:20px;margin-left:10%"><strong>·</strong>"เพิ่มสถานที่" หมายถึง กรณีผู้ขออนุญาตเพิ่มสถานที่จากที่ได้รับอนุญาตอีกแห่งหนึ่ง เช่น มีอาคารเพิ่ม</div>
            <div style="font-size:20px">อีกแห่งหนึ่งในพื้นที่บริเวณใกล้เคียงกับแห่งเดิม โดยสถานที่แห่งใหม่อาจจะอยู่บนโฉนดที่ดินเดียวกับสถานที่ที่ได้รับอนุญาตแห่งเดิม</div>
            <div style="font-size:20px">หรือโฉนดที่ดินติดกัน แต่ทั้งนี้ ไม่รวมถึงกรณีการเพิ่มสาขาหรือขยายสาขา</div>
            <div style="font-size:20px;margin-left:6.3%">(๖) กรณีการยื่นคำขอโดยวิธีการทางอิเล็กทรอนิกส์ เอกสารหรือหลักฐานประกอบคำขอให้เป็นไปตามระบบ</div>
            <div style="font-size:20px">การยื่นทางอิเล็กทรอนิกส์ที่สำนักงานคณะกรรมการอาหารและยากำหนด</div>
            <br />
        </div>
    </div>

    <div ng-show="LIST_LCN.PROCESS == '11110'">
        <div style="font-family:'Taviraj';font-size:24px;width:100%">
            <h1 style="text-align:left;font-size:24px;">
                <strong>แบบ ข.ว.จ. ๓/๔-๓</strong>
            </h1>
            <br />
            <h2 style="text-align:center;font-size:24px;">
                <strong>คำขอย้าย เปลี่ยนแปลง หรือเพิ่มสถานที่ผลิตหรือสถานที่เก็บ</strong><br />
                <strong>วัตถุออกฤทธิ์ในประเภท ๓ หรือประเภท ๔</strong>
            </h2>
            <br />
            <div class="title1">
                @*process =11110 *@
                <table style="font-size:20px;margin:auto;margin-top:6%">
                    <tr>
                        <td>
                            <strong>ใบอนุญาตนำเข้าวัตถุออกฤทธิ์</strong>
                        </td>
                        <td>
                            <input type="radio" name="gender" ng-model="LIST_LCN.LCN_TYPE_NCT" value="1" /> <strong>ในประเภท ๓</strong>
                        </td>
                        <td>
                            <input type="radio" name="gender" ng-model="LIST_LCN.LCN_TYPE_NCT" value="2" /> <strong>ในประเภท ๔</strong>
                        </td>
                    </tr>
                    <tr>
                        <td style="text-align:left">
                            <strong>เลขที่</strong>
                        </td>
                        <td style="border-bottom:dotted;border-bottom-width:thin;" colspan="3">
                            <label>{{LCN_LIST.RCVNO_DISPLAY}}</label>
                        </td>
                    </tr>
                    <tr>
                        <td style="text-align:left">
                            <strong>ณ สถานที่ ชื่อ</strong>
                        </td>
                        <td style="border-bottom:dotted;border-bottom-width:thin;" colspan="2">
                            <label>{{LIST_LCN.thanameplace}}</label>
                        </td>
                    </tr>
                </table>
            </div>
            <div class="title2">
                <table style="font-size:20px;width:95%;margin-top:10px;margin-left:10px">
                    <tr>
                        <td style="text-align:left;width:20%">
                            เลขรับที่
                        </td>

                        <td style="border-bottom:dotted;border-bottom-width:thin;" colspan="3">
                            <label>{{LCN_LIST.RCVNO_DISPLAY}}</label>
                        </td>
                    </tr>
                    <tr>
                        <td style="text-align:left">
                            วันที่
                        </td>

                        <td style="border-bottom:dotted;border-bottom-width:thin;" colspan="3">
                            <label>{{LCN_LIST.RCV_DATE_DISPLAY}}</label>
                        </td>
                    </tr>
                    <tr>
                        <td style="text-align:center" colspan="2">
                            (สำหรับเจ้าหน้าที่เป็นผู้กรอก)

                        </td>
                    </tr>
                </table>
            </div>
            <div style="clear:both"></div>
            <br />
            <br />
            <table style="width:100%">
                <tr>
                    <td style="text-align:right;width:90%">
                        เขียนที่
                    </td>
                    <td style="width:40%;border-bottom:dotted;border-bottom-width:thin;">

                        {{LIST_LCN.DALCN_EDIT_REQUEST.WRITE_AT}}
                    </td>
                </tr>
                <tr>
                    <td style="text-align:right;width:100px">
                        วันที่
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;">

                        {{LIST_LCN.DALCN_EDIT_REQUEST.WRITE_DATE}}
                    </td>
                </tr>
            </table>
            <br />

            <table style="width:100%; font-size:20px">
                <tr>

                    <td style="width:20%">
                        <form name="rdl_gmp">


                            <label><input type="radio" ng-model="LIST_LCN.DALCN_EDIT_REQUEST.CHK_TYPE1" id="rdl_CHK_TYPE" value="1" /> <strong>ย้ายสถานที่</strong></label><br />
                            <label><input type="radio" ng-model="LIST_LCN.DALCN_EDIT_REQUEST.CHK_TYPE1" id="rdl_CHK_TYPE" value="2" /> <strong>เปลี่ยนแปลงสถานที่</strong></label><br />
                            <label><input type="radio" ng-model="LIST_LCN.DALCN_EDIT_REQUEST.CHK_TYPE1" id="rdl_CHK_TYPE" value="3" /> <strong>เพิ่มสถานที่</strong></label>

                        </form>

                    </td>
                </tr>
            </table>
            <br />

            <h2 style="font-size:24px;">
                <strong>๑. ข้อมูลผู้ขอรับใบอนุญาต</strong>
            </h2>
            <table style="width:90%;margin-left:5%">
                <tr>
                    <td style="font-size:20px" width="40%">
                        ข้าพเจ้า (ชื่อบุคคล/นิติบุคคล)
                    </td>
                    <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;" colspan="6">
                        <label>{{LIST_LCN.thanm}}</label>
                    </td>
                </tr>
                <tr>
                    <td style="font-size:20px">
                        เลขประจำตัวประชาชน
                    </td>

                    <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;" colspan="6">
                        <label>{{LIST_LCN.CITIZEN_AUTHORIZE}}</label>
                    </td>
                </tr>
                <tr>
                    <td style="font-size:20px">
                        หรือบัตรประจำตัวอื่นที่ทางราชการออกให้ คือ
                    </td>
                    <td style="font-size:20px;width:20%;border-bottom:dotted;border-bottom-width:thin;"></td>
                    <td style="font-size:20px;width:5%">
                        เลขที่
                    </td>
                    <td style="font-size:20px ;width:15%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"></td>
                    <td style="font-size:20px">
                        (กรณีไม่ใช่ผู้มีสัญชาติไทย)
                    </td>
                </tr>
                <tr>
                    <td style="font-size:20px">
                        หรือทะเบียนนิติบุคคล/บัตรประจำตัวผู้เสียภาษี เลขที่
                    </td>
                    <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;" colspan="6">
                        <label>{{LIST_LCN.IDENTIFY}}</label>
                    </td>
                </tr>
                <tr>
                    <td style="font-size:20px">
                        เลขรหัสประจำบ้าน
                    </td>
                    <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;" colspan="6">
                        <label>{{LIST_LCN.HOUSENO}}</label>
                    </td>
                </tr>
                <tr>
                    <td style="font-size:20px">
                        อยู่เลขที่
                    </td>
                    <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;" colspan="6">
                        <label>{{LIST_LCN.fulladdr3}}</label>
                    </td>
                </tr>
                <tr>
                    <td style="font-size:20px">
                        โทรศัพท์/มือถือ
                    </td>
                    <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;" colspan="6">
                        <label>{{LIST_LCN.tel}}</label>
                    </td>
                </tr>
                <tr>
                    <td style="font-size:20px">
                        E-mail
                    </td>
                    <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;" colspan="6">
                        <label>{{LIST_LCN.Email}}</label>
                    </td>
                </tr>
            </table>

            <h2 style="font-size:24px;">
                <strong>๒. ข้อมูลผู้ได้รับมอบหมายหรือแต่งตั้งให้ดำำเนินกิจการเกี่ยวกับใบอนุญาต</strong>
            </h2>
            <table style="width:90%;margin-left:5%">
                <tr>
                    <td style="font-size:20px" width="40%">
                        ข้าพเจ้า
                    </td>
                    <td style="font-size:20px;border:dotted;border-bottom-width:thin;" colspan="6">
                        <label>{{LIST_LCN.BSN_THAIFULLNAME}}</label>
                    </td>
                </tr>
                <tr>
                    <td style="font-size:20px">
                        เลขประจำตัวประชาชน
                    </td>

                    <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;" colspan="6">
                        <label>{{LIST_LCN.BSN_IDENTIFY}}</label>
                    </td>
                </tr>
                <tr>
                    <td style="font-size:20px">
                        หรือบัตรประจำตัวอื่นที่ทางราชการออกให้ คือ
                    </td>
                    <td style="font-size:20px;width:20%;border-bottom:dotted;border-bottom-width:thin;">
                        @*<label>{{LIST_LCN.BSN_THAIFULLNAME}}</label>*@
                    </td>
                    <td style="font-size:20px;width:5%">
                        เลขที่
                    </td>
                    <td style="font-size:20px ;width:15%;text-align:center;border-bottom:dotted;border-bottom-width:thin;">
                        @*<label>{{LIST_LCN.BSN_THAIFULLNAME}}</label>*@
                    </td>
                    <td style="font-size:20px">
                        (กรณีไม่ใช่ผู้มีสัญชาติไทย)
                    </td>
                </tr>
                <tr>
                    <td style="font-size:20px">
                        หรือทะเบียนนิติบุคคล/บัตรประจำตัวผู้เสียภาษี เลขที่
                    </td>
                    <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;" colspan="6">
                        <label>{{LIST_LCN.BSN_IDENTIFY}}</label>
                    </td>
                </tr>
                <tr>
                    <td style="font-size:20px">
                        เลขรหัสประจำบ้าน
                    </td>
                    <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;" colspan="6">
                        <label>{{LIST_LCN.BSN_HOUSENO}}</label>
                    </td>
                </tr>
                <tr>
                    <td style="font-size:20px">
                        อยู่เลขที่
                    </td>
                    <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;" colspan="6">
                        <label>{{LIST_LCN.fulladdr2}}</label>
                    </td>
                </tr>
                <tr>
                    <td style="font-size:20px">
                        โทรศัพท์/มือถือ
                    </td>
                    <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;" colspan="6">
                        <label>{{LIST_LCN.BSN_TEL}}</label>
                    </td>
                </tr>
                <tr>
                    <td style="font-size:20px">
                        E-mail
                    </td>
                    <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;" colspan="6">
                        <label>{{LIST_LCN.dalcn.Email}}</label>
                    </td>
                </tr>
            </table>


            <h2 style="font-size:24px;">
                <strong>๓. ขอแก้ไขเปลี่ยนแปลงรายการในใบอนุญาตดังต่อไปนี้</strong>
            </h2>
            <table style="width:90%;font-size:20px;margin-left:5%">
                <tr>
                    <td colspan="2">
                        <strong>(๓.๑) <u>กรณีย้ายสถานที่ขายวัตถุออกฤกธิ์ คือ</u></strong>
                    </td>

                </tr>
                <tr>
                    <td style="width:30%">
                        เลขรหัสประจำบ้าน
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_LCN.HOUSENO}}</label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <strong>สถานที่เดิม</strong> ตั้งอยู่เลขที่
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_LCN.fulladdr3}}</label>
                    </td>
                </tr>
                <tr>
                    <td>
                        โทรศัพท์/มือถือ
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_LCN.tel}}</label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <strong>สถานที่ใหม่</strong>
                    </td>
                    <td>
                        @*<select class="form-control selectpicker" data-live-search="true" title="-- Please select --" ng-model="LIST_LCN.LOCATION_SELECT" ng-change="getdetails_lct(LIST_LCN.LOCATION_SELECT)">
                            @*<option value="0">--กรุณาเลือก--</option>*@
                        @*<option ng-repeat="x in REF_LOCATION" value="{{x.IDA}}">{{x.thanameplace}}</option>
                            </select>*@
                        {{LIST_LCN.LOCATION_SELECT}}
                    </td>
                </tr>
                <tr ng-repeat="data in LIST_LABEL_LCT">
                    <td>

                        ตั้งอยู่เลขที่
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;">
                        {{data.fulladdr3}}
                    </td>
                </tr>
                <tr ng-repeat="datas in LIST_LABEL_LCT">
                    <td>
                        โทรศัพท์/มือถือ
                    </td>
                    <td style="border-bottom: dotted; border-bottom-width: thin;">
                        {{datas.tel}}
                    </td>
                </tr>
            </table>

            <table style="width:90%;font-size:20px;margin-left:5%">
                <tr>
                    <td colspan="2">
                        <strong>(๓.๒) <u>กรณีย้ายสถานที่เก็บวัตถุออกฤกธิ์ คือ</u></strong>
                    </td>

                </tr>
                <tr>
                    <td style="width:30%">
                        เลขรหัสประจำบ้าน
                    </td>
                    <td style="border-bottom: dotted; border-bottom-width: thin;">
                        <label>{{LIST_LCN.KEEP_HOUSENO}}</label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <strong>สถานที่เดิม</strong> ตั้งอยู่เลขที่
                    </td>
                    <td style="border-bottom: dotted; border-bottom-width: thin;">
                        <label>{{LIST_LCN.KEEP_FULL_ADDR}}</label>
                    </td>
                </tr>
                <tr>
                    <td>
                        โทรศัพท์/มือถือ
                    </td>
                    <td style="border-bottom: dotted; border-bottom-width: thin;">
                        <label>{{LIST_LCN.KEEP_TEL}}</label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <strong>สถานที่ใหม่</strong>
                    </td>
                    <td>
                        @*<select class="form-control selectpicker" data-live-search="true" title="-- Please select --" ng-model="LIST_LCN.LOCATION_SELECT" ng-change="getdetails(LIST_LCN.LOCATION_SELECT)">
                            @*<option value="0">--กรุณาเลือก--</option>*@
                        @*<option ng-repeat="x in REF_LOCATION_KEEP" value="{{x.IDA}}">{{x.thanameplace}}</option>
                            </select>*@
                        {{LIST_LCN.LOCATION_SELECT}}
                    </td>
                </tr>
                <tr>
                    <td>
                        ตั้งอยู่เลขที่
                    </td>
                    <td style="border-bottom: dotted; border-bottom-width: thin;">
                        <label>{{LIST_LABEL.fulladdr}}</label>
                    </td>
                </tr>
                <tr>
                    <td>
                        โทรศัพท์/มือถือ
                    </td>
                    <td style="border-bottom: dotted; border-bottom-width: thin;">
                        <label>{{LIST_LABEL.tel}}</label>
                    </td>
                </tr>
            </table>

            <table style="width:90%;font-size:20px;margin-left:5%">
                <tr>
                    <td colspan="2">
                        <strong>(๓.๓) <u>กรณีเปลี่ยนแปลงหรือเพิ่มสถานที่ขายหรือสถานที่เก็บวัตถุออกฤทธิ์ </u></strong> (ให้ระบุเหตุผลความจำเป็น และลักษณะของการเปลี่ยน และ
                    </td>

                </tr>
                <tr>
                    <td>
                        ลักษณะของการเปลี่ยนแปลงหรือการเพิ่มสถานที่ เช่น เพิ่ม/ลดขนาดพื้นที่ของอาคาร หรือเพิ่มอาคารแห่งใหม่)
                    </td>
                </tr>
                <tr>
                    <td style="border-bottom:dotted;border-bottom-width:thin">
                        @*<input class="form-control inline" ng-model="LIST_LCN.DALCN_EDIT_REQUEST.EDIT_DESCRIPTION" style="font-family:'Taviraj';font-size:20px;" type="text" />*@
                        {{LIST_LCN.DALCN_EDIT_REQUEST.EDIT_DESCRIPTION}}
                    </td>
                </tr>
            </table>

            <table style="width:90%;font-size:20px;margin-left:5%">
                <tr>
                    <td style="width:17%">
                        <strong>โดยมีเภสัชกรชื่อ</strong> 1
                    </td>
                    <td>
                        {{LIST_LCN.PHR_NAME}}
                    </td>
                    <td style="text-align:center;border-bottom:dotted;border-bottom-width:thin;">
                        ใบอนุญาตประกอบวิชาชีพเภสัชกรรมเลขที่
                    </td>
                    <td style="border-bottom: dotted; border-bottom-width: thin;">
                        {{LIST_LCN.PHR_TEXT_NUM}}
                    </td>
                </tr>

                <tr>
                    <td colspan="4">
                        เป็นผู้ควบคุมตามมาตรา ๕๑ แห่งพระราชบัญญัติวัตถุที่ออกฤทธิ์ต่อจิตและประสาท พ.ศ. ๒๕๕๙
                    </td>
                </tr>
            </table>
            <br />
            <div style="font-size:20px"><strong>๔. พร้อมกับคำขอนี้ข้าพเจ้าได้แนบเอกสารหรือหลักฐานต่างๆ มาด้วย คือ</strong></div>
            <table style="width:90%;font-size:20px;margin-left:5%">
                <tr>
                    <td colspan="2">
                        (๔.๑) ใบอนุญาตขายวัตถุออกฤทธิ์ในประเภท ๓ หรือประเภท ๔ แล้วแต่กรณี
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        (๔.๒) เอกสารแสดงรายละเอียดของสถานที่ขายหรือสถานที่เก็บวัตถุออกฤทธิ์แห่งใหม่หรือที่มีการเปลี่ยนแปลง
                    </td>
                </tr>
                <tr>
                    <td style="width:25%">
                        หรือเพิ่ม แล้วแต่กรณี (ถ้ามี)
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin">
                        @*<input type="text" ng-model="LIST_LCN.DALCN_EDIT_REQUEST.EDIT_DESCRIPTION" id="txt_EDIT_DESCRIPTION" />*@
                        {{LIST_LCN.DALCN_EDIT_REQUEST.EDIT_DESCRIPTION}}
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <strong>ข้าพเจ้าขอรับรองว่า ข้อความและเอกสารหรือหลักฐานทั้งหมดที่ยื่นเพื่อประกอบคำขอรับใบอนุญาตเป็นความจริงทุกประการ</strong>
                    </td>
                </tr>
            </table>
            <br />
            <table style="width:85%;font-size:20px">
                <tr>
                    <td style="text-align:right">
                        (ลายมือชื่อ)
                    </td>
                    <td style="text-align:center;width:40%;border-bottom:dotted;border-bottom-width:thin;"></td>
                    <td>
                        ผู้ขอรับใบอนุญาต/ผู้ได้รับมอบหมายหรือแต่งตั้งให้ดำเนินกิจการ
                    </td>
                </tr>
                <tr>
                    <td style="text-align:right">
                        (
                    </td>
                    <td style="text-align:center;border-bottom:dotted;border-bottom-width:thin;">
                        {{LIST_LCN.BSN_THAIFULLNAME}}
                    </td>
                    <td style="text-align:left">
                        )
                    </td>
                </tr>

            </table>
            <br />
            <br />

            <div style="font-size:20px"><strong>หมายเหตุ :</strong> (๑) ให้ยื่นคำขอ ๑ ฉบับต่อ ๑ ใบอนุญาตเท่านั้น</div>
            <div style="font-size:20px;margin-left:6.3%">(๒) ให้ขีดเลือกข้อความในช่อง ☐ ให้ตรงตามที่ประสงค์จะดำเนินการ</div>
            <div style="font-size:20px;margin-left:6.3%">(๓) รับรองสำเนาถูกต้องในเอกสารที่เป็นสำเนาทุกฉบับ</div>
            <div style="font-size:20px;margin-left:6.3%">(๔) กรณีเอกสารหรือหลักฐานที่ออกโดยสำนักงานคณะกรรมการอาหารและยา ผู้อนุญาตอาจไม่ขอเอกสารหรือหลักฐานดังกล่าวก็ได้</div>
            <div style="font-size:20px;margin-left:6.3%">(๕) ในที่นี้</div>
            <div style="font-size:20px;margin-left:10%"><strong>·</strong>"ย้ายสถานที่" หมายถึง กรณีผู้ขออนุญาตย้ายสถานที่ที่ได้รับอนุญาต ไปตั้ง ณ สถานที่อื่นหรือสถานที่</div>
            <div style="font-size:20px">แห่งใหม่ ซึ่งย้ายสถานที่ที่ได้รับอนุญาตแห่งเดิมทั้งหมด มิใช่ย้ายเพียงบางส่วนหรือบางแผนก</div>
            <div style="font-size:20px;margin-left:10%"><strong>·</strong>"เปลี่ยนแปลงสถานที่" หมายถึง กรณีผู้ขออนุญาตเปลี่ยนแปลงสถานที่ที่ได้รับอนุญาตแห่งเดิม</div>
            <div style="font-size:20px">โดยการขยายพื้นที่ของอาคาร ลดพื้นที่ของอาคารลง หรือมีการเปลี่ยนแปลงหรือรับปรุงลักษณะของอาคารที่ได้รับอนุญาต</div>
            <div style="font-size:20px;margin-left:10%"><strong>·</strong>"เพิ่มสถานที่" หมายถึง กรณีผู้ขออนุญาตเพิ่มสถานที่จากที่ได้รับอนุญาตอีกแห่งหนึ่ง เช่น มีอาคารเพิ่ม</div>
            <div style="font-size:20px">อีกแห่งหนึ่งในพื้นที่บริเวณใกล้เคียงกับแห่งเดิม โดยสถานที่แห่งใหม่อาจจะอยู่บนโฉนดที่ดินเดียวกับสถานที่ที่ได้รับอนุญาตแห่งเดิม</div>
            <div style="font-size:20px">หรือโฉนดที่ดินติดกัน แต่ทั้งนี้ ไม่รวมถึงกรณีการเพิ่มสาขาหรือขยายสาขา</div>
            <div style="font-size:20px;margin-left:6.3%">(๖) กรณีการยื่นคำขอโดยวิธีการทางอิเล็กทรอนิกส์ เอกสารหรือหลักฐานประกอบคำขอให้เป็นไปตามระบบ</div>
            <div style="font-size:20px">การยื่นทางอิเล็กทรอนิกส์ที่สำนักงานคณะกรรมการอาหารและยากำหนด</div>
        </div>
    </div>
    <br />
    <div>
        <div class="col-sm-12" style="text-align:center">
            <input type="button" class="btn btn-lg" ng-click="BTN_SEND_LCN()" value="บันทึก" ng-disabled="" />
            <input type="button" class="btn btn-lg btn-success" ng-click="BTN_LCN_BACK()" value="ย้อนกลับ" />
            <input type="button" class="btn btn-lg btn-success" ng-click="BTN_EDIT()" value="แก้ไขคำขอ" ng-show="LIST_LCN.dalcn.STATUS_ID == '5'" />
        </div>
    </div>
</div>