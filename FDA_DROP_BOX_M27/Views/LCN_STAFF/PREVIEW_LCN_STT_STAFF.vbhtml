@Code ViewData("Title") = "PREVIEW_LCN_STT_STAFF" End Code

<script src="~/Scripts_angular/ANGULAR_APP.js"></script>
<script src="~/Scripts_angular/CENTER_SV.js"></script>
<script src="~/Scripts_angular/LCN_STAFF_CTRL.js"></script>

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

<div ng-controller="LCN_STAFF_CTRL" ng-app="ANGULAR_APP" class="ic" ng-init="Pageload_subtitute()">
    <div ng-show="LIST_LCN.PROCESS == '100701'">
        <div class="content-part " style="width:100%;font-family:'Taviraj'">
            <div style="font-family:'Taviraj';font-size:20px;">
                <div>
                    <h1><center>แบบ ข.ย.๑๖</center></h1>
                </div>
                <table style="width:100%">
                    <tr>
                        <td style="width:35%"></td>
                        <td style="width:35%"></td>
                        <td style="width:5%;text-align:right">เลขที่</td>
                        <td style=" width:25%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"><label>{{LCN_LIST.RCVNO_DISPLAY}}</label></td>
                    </tr>
                </table>
                <table style="width:100%">
                    <tr>
                        <td style="width:35%"></td>
                        <td style="width:35%"></td>
                        <td style="width:5%;text-align:right">วันที่</td>
                        <td style=" width:25%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"> <label>{{LCN_LIST.RCV_DATE_DISPLAY}}</label></td>
                    </tr>
                </table>
                <table style="width:100%">
                    <tr>
                        <td style="width:35%"></td>
                        <td style="width:35%"></td>
                        <td style="width:5%;text-align:right"> ลงชื่อ</td>
                        <td style=" width:15%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"></td>
                        <td style="width:10%">ผู้รับคำขอ</td>
                    </tr>
                </table>
                <div>
                    <p style="text-align:center">

                        <table width="100%">
                            <tr>
                                <td style="width:30%"></td>
                                <td>
                                    คำขอ
                                </td>
                                <td>
                                    <table>
                                        <tr>
                                            <td>
                                                <label>
                                                    <input type="radio" ng-model="LIST_LCN.REQUEST_TYPE" value="1" disabled />ใบแทนใบอนุญาต
                                                </label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <label>
                                                    <input type="radio" ng-model="LIST_LCN.REQUEST_TYPE" value="2" disabled />ย้ายสถานที่
                                                </label>
                                            </td>
                                        </tr>
                                    </table>
                                </td>
                                <td>
                                    <table>
                                        <tr>
                                            <td>
                                                <input type="radio" ng-model="LIST_LCN.LCN_TYPE" value="1" disabled />ขายยาแผนปัจจุบัน
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <input type="radio" ng-model="LIST_LCN.LCN_TYPE" value="2" disabled />ขายส่งยาแผนปัจจุบัน
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <input type="radio" ng-model="LIST_LCN.LCN_TYPE" value="3" disabled />ขายยาแผนปัจจุบันเฉพาะยาบรรจุเสร็จที่ไม่ใช่ยาอันตรายหรือยาควบคุมพิเศษ
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <input type="radio" ng-model="LIST_LCN.LCN_TYPE" value="4" disabled />ขายยาแผนปัจจุบันเฉพาะยาบรรจุเสร็จสำหรับสัตว์
                                            </td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>

                        </table>

                </div>
                <hr />
                <table style="width:100%">
                    <tr>
                        <td style="text-align:right;width:90%">
                            เขียนที่
                        </td>
                        <td style="width:40%;border-bottom:dotted;border-bottom-width:thin;">

                            {{LIST_LCN.DALCN_NCT_SUBSTITUTE.WRITE_AT}}
                        </td>
                    </tr>
                    <tr>
                        <td style="text-align:right;width:100px">
                            วันที่
                        </td>
                        <td style="border-bottom:dotted;border-bottom-width:thin;">

                            {{LIST_LCN.DALCN_NCT_SUBTITUTE.WRITE_DATE}}
                        </td>
                    </tr>
                </table>
                <table style="width:100%;">
                    <tr>
                        <td style="padding-left:10%;"></td>
                        <td width="5%">
                            ข้าพเจ้า
                        </td>
                        <td style="width:90%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"> <label>{{LIST_LCN.thanm}}</label></td>
                    </tr>
                    <tr>
                        <td></td>
                        <td></td>
                        <td style="text-align:center;">
                            (ชื่อผู้ขออนุญาต)
                        </td>
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
                        <td style="width:24%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"></td>
                    </tr>
                </table>
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
                <div>มีความประสงค์ขอ</div>
                <table style="width:100%;">
                    <tr>
                        <td width="17%"><input type="checkbox" ng-model="LIST_LCN.REQUEST_TYPE" disabled />ใบแทนใบอนุญาตขายยา  เนื่องจาก</td>
                        <td width="68%" style="border-bottom:dotted;border-bottom-width:thin">
                            @*<input type="text" ng-model="LIST_LCN.DALCN_NCT_SUBSTITUTE.PURPOSE" />*@
                            {{LIST_LCN.DALCN_NCT_SUBSTITUTE.PURPOSE}}
                        </td>
                        <td width="15%">
                            (ระบุเหตุที่ขอรับใบแทน)
                        </td>
                    </tr>
                </table>
                <table>
                    <tr>
                        <td><input type="checkbox" ng-model="LIST_LCN.REQUEST_TYPE" disabled />ย้ายสถานที่ขายยาชื่อ</td>
                        <td>
                            @*<select class="form-control selectpicker" data-live-search="true" title="-- Please select --" style="font-family:'Taviraj'" ng-model="LIST_LCN.LOCATION_SELECT" ng-change="getdetails_lct(LIST_LCN.LOCATION_SELECT)">
                                @*<option value="0">--กรุณาเลือก--</option>*@
                            @*<option ng-repeat="x in REF_LOCATION" value="{{x.IDA}}">{{x.thanameplace}}</option>
                                </select>*@
                            {{LIST_LCN.LOCATION_SELECT}}
                        </td>
                    </tr>
                </table>
                <table style="width:100%">
                    <tr>
                        <td style="width:5%">ไปอยู่ที่</td>
                        <td style="width:95%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"><label>{{LIST_LABEL_LCT.fulladdr}}</label></td>
                    </tr>
                </table>
                <table style="width:100%">
                    <tr>
                        <td style="width:13%">โทรศัพท์/โทรศัพท์มือถือ</td>
                        <td style="width:87%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"><label>{{LIST_LABEL_LCT.tel}}</label></td>
                    </tr>
                </table>
                <br />
                <div>ข้าพเจ้าได้แนบหลักฐานมาด้วย คือ</div>
                <table style="width:100%" border="1">
                    <tr>
                        <td style="width:50%"><input type="radio" value="1" ng-model="LIST_LCN.REQUEST_TYPE" disabled /> หลักฐานประกอบคำขอใบแทนใบอนุญาต</td>
                        <td style="width:50%"><input type="radio" value="2" ng-model="LIST_LCN.REQUEST_TYPE" disabled /> หลักฐานประกอบคำขอย้ายสถานที่</td>
                    </tr>
                </table>
                <table style="width:100%" border="1">
                    <tr>
                        <td style="width:50%">(๑) รูปถ่ายของผู้ขออนุญาต หรือผู้แทนหรือผู้จัดการนิติบุคคล ขนาด ๓ x ๔ เซนติเมตร จำนวน ๓ รูป </td>
                        <td style="width:50%">(๑) ใบอนุญาตประกอบธุรกิจเกี่ยวกับยาแผนปัจจุบันหรือใบแทน </td>
                    </tr>
                </table>
                <table style="width:100%" border="1">
                    <tr>
                        <td style="width:50%">(๒) ใบอนุญาตประกอบธุรกิจเกี่ยวกับยาแผนปัจจุบัน (ถ้ามี)</td>
                        <td style="width:50%">(๒) แบบแปลนแผนผังสิ่งปลูกส้รางของสถานที่ขายยาแห่งใหม่</td>
                    </tr>
                </table>
                <table style="width:100%" border="1">
                    <tr>
                        <td style="width:50%">(๓) ใบรับแจ้งความของสถานีตำรวจแห่งท้องที่ที่ใบอนุญาตนั้นสูญหายมาด้วย</td>
                        <td style="width:50%">(๓) เอกสารอื่นถ้าจำเป็น</td>
                    </tr>
                </table>
                <table style="width:100%" border="1">
                    <tr>
                        <td style="width:50%">(๔) ใบอนุญาตใบเดิม (กรณีที่ใบอนุญาตถูกทำำลายในสาระสำคัญ)</td>
                        <td style="width:50%"></td>
                    </tr>
                </table>
                <br />
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
                <hr />
                <div>หมายเหตุ : &nbsp;(๑) ใส่เครื่องหมาย &#10004; ในช่อง [  ] หน้าข้อความที่ต้องการ</div>

            </div>

        </div>
    </div>

    <div ng-show="LIST_LCN.PROCESS == '100702'">
        <div style="font-family:'Taviraj';font-size:20px;" class="ic">
            <br />

            <h1 style="text-align:center;">
                แบบ น.ย.๑๐
            </h1>
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
            <div> <h3 style="text-align:center">คำขอแก้ไขเปลี่ยนแปลงรายการในใบอนุญาตนำหรือสั่งยาแผนปัจจุบัน</h3></div>
            <div>
                <table width="100%">
                    <tr>
                        <td style="width:45%;" align="right"> <h4>คำขอ </h4></td>
                        <td>
                            <table>
                                <tr>
                                    <td>
                                        <label>
                                            <input type="radio" ng-model="LIST_LCN.REQUEST_TYPE" value="1" disabled />ใบแทนใบอนุญาต
                                        </label>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <label>
                                            <input type="radio" ng-model="LIST_LCN.REQUEST_TYPE" value="2" disabled />ย้ายสถานที่
                                        </label>
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>

                </table>
            </div>


            <hr />
            <table style="width:100%">
                <tr>
                    <td style="text-align:right;width:90%">
                        เขียนที่
                    </td>
                    <td style="width:40%;border-bottom:dotted;border-bottom-width:thin;">

                        {{LIST_LCN.DALCN_NCT_SUBSTITUTE.WRITE_AT}}
                    </td>
                </tr>
                <tr>
                    <td style="text-align:right;width:100px">
                        วันที่
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;">

                        {{LIST_LCN.DALCN_NCT_SUBTITUTE.WRITE_DATE}}
                    </td>
                </tr>
            </table>
            <br />
            <table style="width:100%">
                <tr>
                    <td style="width:10%;text-align:right">ข้าพเจ้า :</td>
                    <td style="width:40%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"> <label>{{LIST_LCN.thanm}}</label></td>
                    <td style="width:13%;text-align:right">ซึ่งมีผู้ดำเนินกิจการชื่อ :</td>
                    <td style="width:42%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"> <label>{{LIST_LCN.BSN_THAIFULLNAME}}</label></td>
                </tr>
            </table>
            <table style="width:100%">
                <tr>
                    <td style="width:10%;"></td>
                    <td style="width:40%;text-align:center">(ชื่อผู้รับอนุญาต)</td>
                    <td style="width:13%;"></td>
                    <td style="width:42%;"></td>
                </tr>
            </table>
            <table style="width:100%">
                <tr>
                    <td style="width:38%;">ได้รับอนุญาตให้นำหรือสั่งยาแผนปัจจุบันเข้ามาในราชอาณาจักรตามใบอนุญาตที่</td>
                    <td style="width:62%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"><label>{{LIST_LCN.LCNNO_SHOW}}</label></td>
                </tr>
            </table>
            <table style="width:100%">
                <tr>
                    <td style="width:15%;">ณ สถานที่นำหรือสั่งยาชื่อ</td>
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
                    <td style="width:18%;">โทรศัพท์/โทรศัพท์มือถือ</td>
                    <td style="width:82%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"><label>{{LIST_LCN.tel}}</label></td>
                </tr>
            </table>
            <table width="100%">
                <tr>
                    <td>
                        ขอ
                    </td>
                    <td>
                        <table width="100%">

                            <tr>
                                <td><input type="checkbox" ng-model="LIST_LCN.REQUEST_TYPE" disabled />ใบแทนใบอนุญาตนำหรือสั่งยาแผนปัจจุบันเข้ามาในราชอาณาจักรเนื่องจาก</td>
                            <tr>
                                <td style="border-bottom:dotted;border-bottom-width:thin">
                                    @*<input type="text" ng-model="LIST_LCN.DALCN_NCT_SUBSTITUTE.PURPOSE" />*@
                                    {{LIST_LCN.DALCN_NCT_SUBSTITUTE.PURPOSE}}
                                </td>
                            </tr>
                            <tr>
                                <td style="width:100%;text-align:center">(เหตุที่ขอรับใบแทน)</td>
                            </tr>
                            <tr>
                                <td><input type="checkbox" ng-model="LIST_LCN.REQUEST_TYPE" disabled />ย้ายสถานที่นำหรือสั่งยาแผนปัจจุบันเข้ามาในราชอาณาจักรในนามของ</td>
                            <tr>
                                <td style="border-bottom:dotted;border-bottom-width:thin">
                                    @*<select class="form-control selectpicker" data-live-search="true" title="-- Please select --" style="font-family:'Taviraj'" ng-model="LIST_LCN.LOCATION_SELECT" ng-change="getdetails_lct(LIST_LCN.LOCATION_SELECT)">
                                        @*<option value="0">--กรุณาเลือก--</option>*@
                                    @*<option ng-repeat="x in REF_LOCATION" value="{{x.IDA}}">{{x.thanameplace}}</option>
                                        </select>*@
                                    {{LIST_LCN.LOCATION_SELECT}}
                                </td>
                            </tr>
                            <tr>
                                <td style="width:100%;text-align:center">(ชื่อสถานที่นำหรือสั่งยา)</td>
                            </tr>
                        </table>
                    </td>
                </tr>

            </table>

            <table width="100%">
                <tr>
                    <td style="width:7%">ไปอยู่เลขที่</td>
                    <td style="width:93%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"><label>{{LIST_LABEL_LCT.fulladdr}}</label></td>
                </tr>
            </table>
            <table width="100%">
                <tr>
                    <td style="width:5%">โทรศัพท์</td>
                    <td style="width:95%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"><label>{{LIST_LABEL_LCT.tel}}</label></td>
                </tr>
            </table>
            <table>
                <tr>
                    <td>ข้าพเจ้าได้แนบหลักฐานมาด้วย คือ</td>
                <tr>
                    <td>&nbsp;&nbsp;<input type="radio" value="1" ng-model="LIST_LCN.REQUEST_TYPE" disabled /> หลักฐานประกอบคำขอใบแทนใบอนุญาต</td>
                <tr>
                    <td>&nbsp;&nbsp;&nbsp;&nbsp; (๑) รูปถ่ายของผู้ดำเนินกิจการ ขนาด ๓ x ๔ เซนติเมตร จำนวน ๒ รูป</td>
                <tr>
                    <td>&nbsp;&nbsp;&nbsp;&nbsp; (๒) ใบอนุญาตนำหรือสั่งยาแผนปัจจุบันเข้ามาในราชอาณาจักร ถ้ามี</td>
                <tr>
                    <td>&nbsp;&nbsp;<input type="radio" value="1" ng-model="LIST_LCN.REQUEST_TYPE" disabled /> หลักฐานประกอบคำขอย้ายสถานที่</td>
                <tr>
                    <td>&nbsp;&nbsp;&nbsp;&nbsp; (๑) ใบอนุญาตนำหรือสั่งยาแผนปัจจุบันเข้ามาในราชอาณาจักรหรือใบแทน</td>
                <tr>
                    <td>&nbsp;&nbsp;&nbsp;&nbsp; (๒) แบบแปลนแผนผังสิ่งปลูกสร้างของสถานที่นำหรือสั่งยาแห่งใหม่ จำนวน ๒ ชุด</td>
                <tr>
                    <td>&nbsp;&nbsp;&nbsp;&nbsp; (๓) เอกสารแสดงว่าเป็นผู้ได้รับอนุญาต</td>
                </tr>
            </table>
            <table style="width:100%">
                <tr>
                    <td style="width:50%;text-align:center"></td>
                    <td style="width:10%;text-align:right">(ลายมือชื่อ)</td>
                    <td style="width:20%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"></td>
                    <td style="width:20%;text-align:start">ผู้ยื่นคำขอ</td>
                </tr>
            </table>
            <hr />
            <div>หมายเหตุ : &nbsp;(๑) ในกรณีที่ใบอนุญาตสูญหาย ให้นำใบรับแจ้งความของสถานีตำรวจแห่งท้องที่ที่ใบอนุญาตอนุญาตนั้นสูญหายมาด้วย</div>
            <div>&nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;(๒) ในกรณีที่ใบอนุญาตถูกทำลายในสาระสำคัญ ให้แนบใบอนุญาตนั้น มาด้วย</div>
            <div>&nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;(๓) ใส่เครื่องหมาย &#10004 ในช่อง[  ] หน้าข้อความที่ต้องการ</div>

        </div>
    </div>

    <div ng-show="LIST_LCN.PROCESS == '100703'">
        <div style="font-family:'Taviraj';font-size:20px;" class="ic">
            <div>
                <p style="text-align: right;">แบบ ผ.ย.๑๐</p>
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
                    <td style="text-align:right;width:45%;"> <h2>คำขอ</h2></td>
                    <td width="10%">
                        <table style="width:100%">
                            <tr>
                                <td>
                                    <label>
                                        <input type="radio" ng-model="LIST_LCN.REQUEST_TYPE" value="1" disabled />ใบแทนใบอนุญาต
                                    </label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <label>
                                        <input type="radio" ng-model="LIST_LCN.REQUEST_TYPE" value="2" disabled />ย้ายสถานที่
                                    </label>
                                </td>
                            </tr>
                        </table>
                    </td>
                    <td style="text-align:left;"> <h2>ผลิตยาแผนปัจจุบัน</h2></td>
                </tr>
            </table>

            <hr />
            <table style="width:100%">
                <tr>
                    <td style="text-align:right;width:90%">
                        เขียนที่
                    </td>
                    <td style="width:40%;border-bottom:dotted;border-bottom-width:thin;">

                        {{LIST_LCN.DALCN_NCT_SUBSTITUTE.WRITE_AT}}
                    </td>
                </tr>
                <tr>
                    <td style="text-align:right;width:100px">
                        วันที่
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;">

                        {{LIST_LCN.DALCN_NCT_SUBTITUTE.WRITE_DATE}}
                    </td>
                </tr>
            </table>
            <br />
            <table style="width:100%">
                <tr>
                    <td style="width:10%;text-align:right">ข้าพเจ้า </td>
                    <td style="width:90%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"> <label>{{LIST_LCN.thanm}}</label></td>

                </tr>
            </table>
            <table style="width:100%">
                <tr>
                    <td style="width:10%;"></td>
                    <td style="width:40%;text-align:right">(ชื่อผู้รับอนุญาต)</td>
                    <td style="width:13%;"></td>
                    <td style="width:42%;"></td>
                </tr>
            </table>
            <table style="width:100%">
                <tr>
                    <td style="width:13%;">ซึ่งมีผู้ดำเนินกิจการชื่อ </td>
                    <td style="width:67%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"> <label>{{LIST_LCN.BSN_THAIFULLNAME}}</label></td>
                    <td style="width:20%;text-align:right">ได้รับอนุญาตให้ผลิตยาแผยปัจจุบัน</td>
                </tr>
            </table>
            <table style="width:100%">
                <tr>
                    <td style="width:15%;">ตามใบอนุญาตที่</td>
                    <td style="width:35%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"><label>{{LIST_LCN.LCNNO_SHOW}}</label></td>
                    <td style="width:15%;">ณ สถานที่นำหรือสั่งยาชื่อ</td>
                    <td style="width:35%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"><label>{{LIST_LCN.thanameplace}}</label></td>
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
            <br />
            <table width="100%">
                <tr>
                    <td>
                        ขอ
                    </td>
                    <td>
                        <table width="100%">

                            <tr>
                                <td><input type="checkbox" ng-model="LIST_LCN.REQUEST_TYPE" disabled />ใบแทนใบอนุญาตผลิตนาแผนปัจจุบันเนื่องจาก</td>
                            <tr>
                                <td style="border-bottom:dotted;border-bottom-width:thin">
                                    @*<input type="text" ng-model="LIST_LCN.DALCN_NCT_SUBSTITUTE.PURPOSE" />*@
                                    {{LIST_LCN.DALCN_NCT_SUBSTITUTE.PURPOSE}}
                                </td>
                            </tr>
                            <tr>
                                <td style="width:100%;text-align:center">(เหตุที่ขอรับใบแทน)</td>
                            </tr>
                            <tr>
                                <td><input type="checkbox" ng-model="LIST_LCN.REQUEST_TYPE" disabled />ย้ายสถานที่ผลิตยาแผนปัจจุบัน</td>
                            <tr>
                                <td>
                                    @*<select class="form-control selectpicker" data-live-search="true" title="-- Please select --" style="font-family:'Taviraj'" ng-model="LIST_LCN.LOCATION_SELECT" ng-change="getdetails_lct(LIST_LCN.LOCATION_SELECT)">
                                        @*<option value="0">--กรุณาเลือก--</option>*@
                                    @*<option ng-repeat="x in REF_LOCATION" value="{{x.IDA}}">{{x.thanameplace}}</option>
                                        </select>*@
                                    {{LIST_LCN.LOCATION_SELECT}}
                                </td>
                            </tr>
                            <tr>
                                <td style="width:100%;text-align:center">(ชื่อสถานที่นำหรือสั่งยา)</td>
                            </tr>
                        </table>
                    </td>
                </tr>

            </table>
            <br />
            <table width="100%">
                <tr>
                    <td style="width:7%">ไปอยู่เลขที่</td>
                    <td style="width:93%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"><label>{{LIST_LABEL_LCT.fulladdr}}</label></td>
                </tr>
            </table>
            <table width="100%">
                <tr>
                    <td style="width:5%">โทรศัพท์</td>
                    <td style="width:95%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"><label>{{LIST_LABEL_LCT.tel}}</label></td>
                </tr>
            </table>
            <table>
                <tr>
                    <td>ข้าพเจ้าได้แนบหลักฐานมาด้วย คือ</td>
                <tr>
                    <td>&nbsp;&nbsp;<input type="radio" value="1" ng-model="LIST_LCN.REQUEST_TYPE" disabled /> หลักฐานประกอบคำขอใบแทนใบอนุญาต</td>
                <tr>
                    <td>&nbsp;&nbsp;&nbsp;&nbsp; (๑) รูปถ่ายของผู้ดำเนินกิจการ ขนาด ๓ x ๔ เซนติเมตร จำนวน ๒ รูป</td>
                <tr>
                    <td>&nbsp;&nbsp;&nbsp;&nbsp; (๒) ใบอนุญาตนำหรือสั่งยาแผนปัจจุบันเข้ามาในราชอาณาจักร ถ้ามี</td>
                <tr>
                    <td>&nbsp;&nbsp;<input type="radio" value="1" ng-model="LIST_LCN.REQUEST_TYPE" disabled /> หลักฐานประกอบคำขอย้ายสถานที่</td>
                <tr>
                    <td>&nbsp;&nbsp;&nbsp;&nbsp; (๑) ใบอนุญาตผลิตแผนปัจจุบันหรือใบแทน</td>
                <tr>
                    <td>&nbsp;&nbsp;&nbsp;&nbsp; (๒) แบบแปลนแผนผังสิ่งปลูกสร้างของสถานที่ผลิตแห่งใหม่ จำำนวน ๒ ชุด</td>
                <tr>
                    <td>&nbsp;&nbsp;&nbsp;&nbsp; (๓) เอกสารแสดงว่าเป็นผู้ได้รับอนุญาต</td>
                </tr>
            </table>
            <table style="width:100%">
                <tr>
                    <td style="width:50%;text-align:center"></td>
                    <td style="width:10%;text-align:right">(ลายมือชื่อ)</td>
                    <td style="width:20%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"></td>
                    <td style="width:20%;text-align:start">ผู้ยื่นคำขอ</td>
                </tr>
            </table>
            <hr />
            <div>หมายเหตุ : &nbsp;(๑) ในกรณีที่ใบอนุญาตสูญหาย ให้นำใบรับแจ้งความของสถานีตำรวจแห่งท้องที่ที่ใบอนุญาตอนุญาตนั้นสูญหายมาด้วย</div>
            <div>&nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;(๒) ในกรณีที่ใบอนุญาตถูกทำลายในสาระสำคัญ ให้นับใบอนุญาตนั้น มาด้วย</div>
            <div>&nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;(๓) ใส่เครื่องหมาย &#10004 ในช่อง[  ] หน้าข้อความที่ต้องการ</div>

        </div>
    </div>

    <div ng-show="LIST_LCN.PROCESS == '100704'">
        <div style="font-family:'Taviraj';font-size:20px;" class="ic">
            <div>
                <p style="text-align: right;">แบบ ย.บ.๑๔</p>
            </div>

            <div>
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
                @*<table style="width:100%">
                        <tr>
                            <td style="width:20%"></td>
                            <td style="width:25%"><input type="checkbox" />&nbsp; ใบแทนใบอนุญาต</td>
                            <td style="width:20%"><input type="checkbox" />&nbsp; ผลิตยาแผนโบราณ</td>
                            <td style="width:35%; text-align:center"></td>
                        </tr>
                        <tr>
                            <td style="width:20%">คำขอ</td>
                            <td style="width:25%"></td>
                            <td style="width:20%"><input type="checkbox" />&nbsp; ขายยาแผนโบราณ</td>
                            <td style="width:35%; text-align:center"></td>
                        </tr>
                    </table>
                    <table style="width:100%">
                        <tr>
                            <td style="width:20%"></td>
                            <td style="width:25%"><input type="checkbox" />&nbsp; ย้ายสถานที่</td>
                            <td style="width:55%"><input type="checkbox" />&nbsp; นำหรือสั่งยาแผนโบราณเข้ามาในราชอาณาจักร ในนามของ</td>
                        </tr>
                    </table>*@
                <table style="width:100%">
                    <tr>
                        <td style="text-align:right;width:45%;"> <h2>คำขอ</h2></td>
                        <td width="10%">
                            <table style="width:100%">
                                <tr>
                                    <td>
                                        <label>
                                            <input type="radio" ng-model="LIST_LCN.DALCN_NCT_SUBSTITUTE.REQUEST_TYPE" value="1" disabled />ใบแทนใบอนุญาต
                                        </label>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <label>
                                            <input type="radio" ng-model="LIST_LCN.DALCN_NCT_SUBSTITUTE.REQUEST_TYPE" value="2" disabled />ย้ายสถานที่
                                        </label>
                                    </td>
                                </tr>
                            </table>
                        </td>
                        <td>
                            <table style="width:100%">
                                <tr>
                                    <td style="width:20%"><input type="radio" ng-model="LIST_LCN.LCN_TYPE" value="1" disabled />&nbsp; ผลิตยาแผนโบราณ</td>
                                </tr>
                                <tr>
                                    <td style="width:20%"><input type="radio" ng-model="LIST_LCN.LCN_TYPE" value="2" disabled />&nbsp; ขายยาแผนโบราณ</td>
                                </tr>
                                <tr>
                                    <td style="width:55%"><input type="radio" ng-model="LIST_LCN.LCN_TYPE" value="3" disabled />&nbsp; นำหรือสั่งยาแผนโบราณเข้ามาในราชอาณาจักร ในนามของ</td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                </table>
                <hr style="width:20%; border-color:black;" />
                <table style="width:100%">
                    <tr>
                        <td style="text-align:right;width:90%">
                            เขียนที่
                        </td>
                        <td style="width:40%;border-bottom:dotted;border-bottom-width:thin;">

                            {{LIST_LCN.DALCN_NCT_SUBSTITUTE.WRITE_AT}}
                        </td>
                    </tr>
                    <tr>
                        <td style="text-align:right;width:100px">
                            วันที่
                        </td>
                        <td style="border-bottom:dotted;border-bottom-width:thin;">

                            {{LIST_LCN.DALCN_NCT_SUBTITUTE.WRITE_DATE}}
                        </td>
                    </tr>
                </table>
                <br />
                <table style="width:100%">
                    <tr>
                        <td style="width:10%; text-align:right">ข้าพเจ้า :</td>
                        <td style="width:80%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"> <label>{{LIST_LCN.thanm}}</label></td>
                        <td align="left" style="width:10%;">
                            ซึ่งผู้มีดำเนินกิจการ
                        </td>
                    </tr>
                    <tr>
                        <td style="width:10%;"></td>
                        <td style="width:90%; text-align:center" colspan="2">(ชื่อผู้ขออนุญาต)</td>
                    </tr>
                </table>
                <br />
                <table style="width:100%">
                    <tr>
                        <td style="width:10%;">ชื่อ</td>
                        <td style="width:60%; text-align:center;text-align:center;border-bottom:dotted;border-bottom-width:thin;"> <label>{{LIST_LCN.BSN_THAIFULLNAME}}</label></td>
                        <td>
                            ได้รับอนุญาตให้
                        </td>
                        <td>
                            <input type="radio" ng-model="LIST_LCN.LCN_TYPE" value="1" disabled />&nbsp; ผลิตยาแผนโบราณ
                        </td>
                    </tr>
                    <tr>
                        <td style="width:10%"></td>
                        <td>
                            <input type="radio" ng-model="LIST_LCN.LCN_TYPE" value="1" disabled />&nbsp; ขายยาแผนโบราณ
                            <input type="radio" ng-model="LIST_LCN.LCN_TYPE" value="1" disabled />&nbsp; นำหรือสั่งยาแผนโบราณเข้ามาในราชอาณาจักร ตามใบอนุญาต
                        </td>
                        <td colspan="2"></td>
                    </tr>
                </table>
                <table style="width:100%">
                    <tr>
                        <td style="width:5%">ที่</td>
                        <td style="width:35%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"><label>{{LIST_LCN.LCNNO_SHOW}}</label></td>
                        <td style="width:15%">ณ สถานประกอบการ ชื่อ</td>
                        <td style="width:45%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"><label>{{LIST_LCN.thanameplace}}</label></td>
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
                <br />
                <table style="width:100%">
                    <tr>
                        <td>
                            ขอ
                        </td>
                        <td>
                            <table>
                                <tr>
                                    <td style="width:25%"><input type="checkbox" ng-model="LIST_LCN.DALCN_NCT_SUBSTITUTE.REQUEST_TYPE" disabled />&nbsp; ใบแทนใบอนุญาต</td>
                                </tr>

                            </table>
                        </td>
                        <td>
                            <table>
                                <tr>
                                    <td style="width:20%"><input type="checkbox" ng-model="LIST_LCN.LCN_TYPE" value="1" disabled />&nbsp; ผลิตยาแผนโบราณ</td>
                                </tr>
                                <tr>
                                    <td style="width:20%"><input type="checkbox" ng-model="LIST_LCN.LCN_TYPE" value="2" disabled />&nbsp; ขายยาแผนโบราณ</td>
                                </tr>
                                <tr>
                                    <td style="width:55%"><input type="checkbox" ng-model="LIST_LCN.LCN_TYPE" value="3" disabled />&nbsp; นำหรือสั่งยาแผนโบราณเข้ามาในราชอาณาจักร เนื่องจาก</td>
                                </tr>
                                <tr>
                                    <td style="border-bottom:dotted;border-bottom-width:thin">
                                        @*<input type="text" ng-model="LIST_LCN.DALCN_NCT_SUBSTITUTE.PURPOSE" />*@
                                        {{LIST_LCN.DALCN_NCT_SUBSTITUTE.PURPOSE}}
                                    </td>
                                </tr>
                                <tr>
                                    <td align="center">
                                        (เหตุที่ขอรับใบแทน)
                                    </td>
                                </tr>
                            </table>
                        </td>

                    </tr>
                    <tr>
                        <td></td>
                        <td>
                            <table>
                                <tr>
                                    <td style="width:25%"><input type="checkbox" ng-model="LIST_LCN.DALCN_NCT_SUBSTITUTE.REQUEST_TYPE" disabled />&nbsp; ย้ายสถานที่</td>
                                </tr>
                            </table>
                        </td>
                        <td>
                            <table>
                                <tr>
                                    <td style="width:20%"><input type="checkbox" ng-model="LIST_LCN.LCN_TYPE" value="1" disabled />&nbsp; ผลิตยาแผนโบราณ</td>
                                </tr>
                                <tr>
                                    <td style="width:20%"><input type="checkbox" ng-model="LIST_LCN.LCN_TYPE" value="2" disabled />&nbsp; ขายยาแผนโบราณ</td>
                                </tr>
                                <tr>
                                    <td style="width:55%"><input type="checkbox" ng-model="LIST_LCN.LCN_TYPE" value="3" disabled />&nbsp; นำหรือสั่งยาแผนโบราณเข้ามาในราชอาณาจักร เนื่องจาก</td>
                                </tr>
                                <tr>
                                    <td>
                                        @*<select class="form-control selectpicker" data-live-search="true" title="-- Please select --" style="font-family:'Taviraj'" ng-model="LIST_LCN.LOCATION_SELECT" ng-change="getdetails_lct(LIST_LCN.LOCATION_SELECT)">
                                            @*<option value="0">--กรุณาเลือก--</option>*@
                                        @*<option ng-repeat="x in REF_LOCATION" value="{{x.IDA}}">{{x.thanameplace}}</option>
                                            </select>*@
                                        {{LIST_LCN.LOCATION_SELECT}}
                                    </td>
                                </tr>
                                <tr>
                                    <td align="center">
                                        (ชื่อสถานที่)
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                </table>
                <br />
                <table width="100%">
                    <tr>
                        <td style="width:7%">ไปอยู่เลขที่</td>
                        <td style="width:93%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"><label>{{LIST_LABEL_LCT.fulladdr}}</label></td>
                    </tr>
                </table>
                <table width="100%">
                    <tr>
                        <td style="width:5%">โทรศัพท์</td>
                        <td style="width:95%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"><label>{{LIST_LABEL_LCT.tel}}</label></td>
                    </tr>
                </table>
                <br style="padding-bottom:inherit" />
                <table style="width:100%">
                    <tr>
                        <td style="width:5%"></td>
                        <td style="width:65%">ข้าพเจ้าได้แนบเอกสารมาด้วย คือ</td>
                        <td style="width:35%; text-align:center"></td>
                    </tr>
                </table>
                <br />
                <table style="width:100%">
                    <tr>
                        <td style="width:10%"></td>
                        <td style="width:65%"><input type="checkbox" value="1" ng-model="LIST_LCN.DALCN_NCT_SUBSTITUTE.REQUEST_TYPE" disabled />&nbsp; หลักฐานประกอบคำขอใบแทนใบอนุญาต</td>
                        <td style="width:35%; text-align:center"></td>
                    </tr>
                </table>
                <table style="width:100%">
                    <tr>
                        <td style="width:15%"></td>
                        <td style="width:80%">(๑) รูปถ่ายของผู้ดำเนินกิจการ ขนาด ๓ x ๔ เซนติเมตร จำนวน 2 รูป</td>
                        <td style="width:5%; text-align:center"></td>
                    </tr>
                    <tr>
                        <td style="width:15%"></td>
                        <td style="width:80%">(๒) ใบอนุญาตประกอบธุรกิจเกี่ยวกับยาแผนโบราณ (ถ้ามี)</td>
                        <td style="width:5%; text-align:center"></td>
                    </tr>
                </table>
                <table style="width:100%">
                    <tr>
                        <td style="width:10%"></td>
                        <td style="width:65%"><input type="checkbox" value="2" ng-model="LIST_LCN.DALCN_NCT_SUBSTITUTE.REQUEST_TYPE" disabled />&nbsp; หลักฐานประกอบคำขอย้ายสถานที่</td>
                        <td style="width:35%; text-align:center"></td>
                    </tr>
                </table>
                <table style="width:100%">
                    <tr>
                        <td style="width:15%"></td>
                        <td style="width:80%">(๑) ใบอนุญาตประกอบธุรกิจเกี่ยวกับยาแผนโบราณ หรือใบแทน</td>
                        <td style="width:5%; text-align:center"></td>
                    </tr>
                    <tr>
                        <td style="width:15%;"></td>
                        <td style="width:80%;">(๒) แผนที่แสดงที่ตั้งสถานที่ผลิตยาและสถานที่เก็บยา รวมทั้งสิ่งปลูกสร้างที่อยู่ในบริเวณใกล้เคียงโดยรอบของสถานที่นั้น จำนวน ๒ ชุด</td>
                        <td style="width:5%; text-align:center"></td>
                    </tr>
                    <tr>
                        <td style="width:15%"></td>
                        <td style="width:80%">
                            (๓) แบบแปลนแผนผังสิ่งปลูกสร้างภายในบริเวณสถานที่ผลิตยาและสถานที่เก็บยาที่ถูกต้อง ตามมาตราส่วน โดยแสดงรายการ ดังต่อไปนี้<br />
                            &nbsp; &nbsp; &nbsp; (ก) รูปด้านหน้า ด้านข้าง แปลนพื้น และรูปตัดของอาคารที่ใช้ในการผลิตและเก็บยา<br />
                            &nbsp; &nbsp; &nbsp; (ข) การแบ่งกั้นห้อง เนื้อที่บริเวณที่ใช้ในการผลิตและควบคุมคุณภาพยา รวมทั้งสถานที่เก็บยาและวัสดุอื่นๆ
                        </td>
                        <td style="width:5%; text-align:center"></td>
                    </tr>
                    <tr>
                        <td style="width:15%"></td>
                        <td style="width:80%">(๔) รายการวัสดุที่ใช้ในการก่อสร้างส่วนต่างๆ ของอาคาร เช่น พื้น ผนัง และเพดาน</td>
                        <td style="width:5%; text-align:center"></td>
                    </tr>
                    <tr>
                        <td style="width:15%"></td>
                        <td style="width:80%">(๕) รายการเกี่ยวกับระบบการจัดการน้ำเสีย การกำจัดสิ่งปฏิกูลและมูลฝอย ระบบควบคุมอากาศ ระบบน้ำที่ใช้ในการผลิตยา และระบบรักษความปลอดภัย</td>
                        <td style="width:5%; text-align:center"></td>
                    </tr>
                    <tr>
                        <td style="width:15%"></td>
                        <td style="width:80%">(๖) เอกสารแสดงว่าเป็นผู้ได้รับอนุญาต</td>
                        <td style="width:5%; text-align:center"></td>
                    </tr>
                </table>
                <br />
                <div>
                    <h2 style="font-family:'Taviraj';font-size:20px;">
                        ไฟล์แนบ
                    </h2>
                    <table class="table" style="width:100%">
                        <tr>
                            <td>ชื่อไฟล์</td>
                            <td></td>
                        </tr>
                        <tr ng-repeat="datas in LIST_File.FILE_LISTs" style="background-color:#FDFCE3">
                            <td>{{datas.FILENAME}}</td>
                            <td>
                                <a ng-show="datas.PATH != null && datas.PATH != ''" ng-click="OPEN_DOC_PATH(datas.PATH,datas.FILENAME)">ดูเอกสาร</a>
                            </td>
                        </tr>
                    </table>
                </div>
                <br />
                <br />
                <table style="width:100%">
                    <tr>
                        <td style="width:50%; text-align:center"></td>
                        <td style="width:10%; text-align:right">(ลายมือชื่อ)</td>
                        <td style="width:20%; text-align:center;border-bottom:dotted;border-bottom-width:thin;"></td>
                        <td style="width:20%; text-align:start">ผู้ยื่นขอ</td>
                    </tr>
                </table>
                <hr style="width:95%; border-color:black;" />
                <table style="width:100%">
                    <tr>
                        <td style="width:5%"></td>
                        <td style="width:20%">หมายเหตุ : -</td>
                        <td style="width:70%">(๑)ในกรณีที่ใบอนุญาตสูญหายให้นำใบแจ้งความของสถานีตำรวจท้องที่ที่ใบอนุญาตนั้นสูญหายมาด้วย</td>
                        <td style="width:5%"></td>
                    </tr>
                    <tr>
                        <td style="width:5%"></td>
                        <td style="width:20%"></td>
                        <td style="width:70%">(๒)ในกรณีที่ใบอนุญาตถูกทำลายในสาระสำคัญ ให้แนบใบอนุญาตนั้นมาด้วย</td>
                        <td style="width:5%"></td>
                    </tr>
                    <tr>
                        <td style="width:5%"></td>
                        <td style="width:20%"></td>
                        <td style="width:70%">(๓)ใส่เครื่องหมาย &#10003; ในช่อง &nbsp;<input type="checkbox" />&nbsp; หน้าข้อความที่ต้องการ</td>
                        <td style="width:5%"></td>
                    </tr>
                </table>
                <br />

            </div>

        </div>
    </div>

    <div ng-show="LIST_LCN.PROCESS == '100705'">
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

    <div ng-show="LIST_LCN.PROCESS == '100766'">
        <div style="font-family:'Taviraj';font-size:24px;">
            <h1 style="text-align:left;font-size:24px;">
                <strong>แบบ ข.ว.จ. ๓/๔-๑</strong>
            </h1>
            <br />
            <div class="title1">
                <label style="font-size:16px;margin-top:25px">
                    ที่ปิดรูปถ่าย<br />
                    ผู้ขออนุญาติ<br />
                    หรือ<br />
                    ผู้ดำเนินกิจการ<br />
                    ขนาด ๓ นิ้ว<br />
                </label>
            </div>

            <div class="title2">
                <table style="font-size:20px;width:95%;margin-top:10px;margin-left:10px">
                    <tr>
                        <td style="text-align:left;width:20%">
                            เลขรับที่
                        </td>

                        <td colspan="3" style="border-bottom:dotted;border-bottom-width:thin;">
                            <label>{{LCN_LIST.RCVNO_DISPLAY}}</label>
                        </td>
                    </tr>
                    <tr>
                        <td style="text-align:left">
                            วันที่
                        </td>

                        <td colspan="3" style="border-bottom:dotted;border-bottom-width:thin;">
                            <label>{{LCN_LIST.RCV_DATE_DISPLAY}}</label>
                        </td>
                    </tr>
                    <tr>
                        <td style="text-align:left">
                            ลงชื่่อ

                        </td>

                        <td style="border-bottom:dotted;border-bottom-width:thin;"></td>
                        <td style="text-align:right;width:25%">
                            ผู้รับคำขอ
                        </td>
                    </tr>
                </table>

            </div>


            <div style="clear:both"></div>
            <br />
            <br />

            <h2 style="text-align:center;font-size:24px;">
                <strong>คำขอรับใบอนุญาต คำขอต่ออายุใบอนุญาต คำขอรับใบแทน</strong><br />
                <strong>ใบอนุญาตขายวัตถุออกฤทธิ์ในประเภท ๓ หรือประเภท ๔</strong>
            </h2>
            @*process =123,124 *@
            <table style="width:70%; font-size:20px;margin:auto;text-align:center">
                <tr>
                    <td>
                        <strong>สำหรับขาย</strong>
                    </td>
                    <td>
                        <input type="radio" name="gender" ng-model="LIST_LCN.PROCESS" ng-value="100766" id="rdl_CHK_SELL_TYPE" disabled="disabled" /> <strong>วัตถุออกฤทธิ์ในประเภท ๓</strong>
                    </td>
                    <td>
                        <input type="radio" name="gender" ng-model="LIST_LCN.PROCESS" ng-value="100767" id="rdl_CHK_SELL_TYPE" disabled="disabled" /> <strong>วัตถุออกฤทธิ์ในประเภท ๔</strong>
                    </td>
                </tr>
                <tr>
                    <td style="font-size:16px" colspan="3">
                        <strong>(คำขอ ๑ ฉบับ ให้ยื่นขอได้เพียงหนึ่งประเภทเท่านั้น)</strong>
                    </td>
                </tr>
            </table>

            <table style="width:100%; font-size:20px">
                <tr>
                    <td style="width:20%">
                        <input type="checkbox" name="gender" disabled="disabled" /> <strong>ขอรับใบอนุญาต</strong>
                    </td>
                </tr>
                <tr>
                    <td>
                        <input type="checkbox" name="gender" disabled="disabled" /> <strong>ขอต่ออายุใบอนุญาตเลขที่</strong>
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;"></td>
                    <td style="width:10%">
                        <strong>ประจำปี พ.ศ.</strong>
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;"></td>
                </tr>
                <tr>
                    <td>
                        <input type="checkbox" name="gender" disabled="disabled" ng-checked="true" /> <strong>ขอรับใบแทนใบอนุญาต</strong>
                    </td>
                    <td>
                        เนื่องจากใบอนุญาต
                    </td>
                    <td colspan="2">

                        <form name="frm_lost_type">


                            <label><input type="radio" ng-model="LIST_LCN.DALCN_NCT_SUBSTITUTE.PURPOSE_ID" id="rdl_lost_type" value="1"> สูญหาย</label>
                            <label><input type="radio" ng-model="LIST_LCN.DALCN_NCT_SUBSTITUTE.PURPOSE_ID" id="rdl_lost_type" value="2"> ถูกทำลายหรือลบเลือนในสาระสำคัญ</label><br />

                        </form>



                    </td>

                </tr>
            </table>
            <br />

            <table style="width:100%">
                <tr>
                    <td style="text-align:right;width:90%">
                        เขียนที่
                    </td>
                    <td style="width:40%;border-bottom:dotted;border-bottom-width:thin;">

                        {{LIST_LCN.DALCN_NCT_SUBSTITUTE.WRITE_AT}}
                    </td>
                </tr>
                <tr>
                    <td style="text-align:right;width:100px">
                        วันที่
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;">

                        {{LIST_LCN.DALCN_NCT_SUBTITUTE.WRITE_DATE}}
                    </td>
                </tr>
            </table>
            <br />

            <h2 style="font-size:24px;">
                <strong>๑. ข้อมูลผู้ขอรับใบอนุญาต</strong>
            </h2>
            <table style="width:90%">
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
            <table style="width:90%">
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
                    <td style="text-align:left;width:30%;border-bottom:dotted;border-bottom-width:thin;">
                        <form action="javascript:void(0)">
                            <table>
                                <tr>
                                    <td style="border-bottom:dotted;border-bottom-width:thin;">
                                        @*<input class="form-control inline" ng-model="LIST_LCN.BSN_IDENTIFY" id="txt_bsn_identify" style="font-family:'Taviraj';" type="text" />*@
                                        {{LIST_LCN.BSN_IDENTIFY}}
                                    </td>
                                    @*<td>
                                            <input type="button" value="ค้นหาผู้ดำเนินฯ" ng-click="BTN_Search_BSN(LIST_LCN.BSN_IDENTIFY)" />
                                        </td>*@
                                </tr>
                            </table>


                        </form>
                        <label>{{LIST_LCN.BSN_THAIFULLNAME}}</label>
                    </td>
                </tr>
                <tr>
                    <td style="font-size:20px">
                        หรือบัตรประจำตัวอื่นที่ทางราชการออกให้ คือ
                    </td>
                    <td style="font-size:20px;width:20%;border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_LCN.BSN_IDENTIFY}}</label>
                    </td>
                    <td style="font-size:20px;width:5%">
                        เลขที่
                    </td>
                    <td style="font-size:20px ;width:15%;text-align:center"></td>
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
                        <label>{{LIST_LCN.BSN_FULL_ADDR}}</label>
                    </td>
                </tr>
                <tr>
                    <td style="font-size:20px">
                        โทรศัพท์/มือถือ
                    </td>
                    <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;" colspan="6">
                        <label>{{LIST_LCN.BSN_TELEPHONE}}</label>
                    </td>
                </tr>
            </table>

            <div style="font-size:20px"><strong>๓. ข้อมูลการขออนุญาต</strong></div>
            <div style="font-size:20px;margin-left:5%">(๓.๑) <strong><u>กรณีขายวัตถุออกฤทธฺิ์ในประเภท ๓ หรือประเภท ๔</u></strong></div>
            <table style="width:100%;font-size:20px">
                <tr>
                    <td>
                        ณ สถานที่ชื่อ
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_LCN.THANAMEPLACE}}</label>
                    </td>
                    <td>
                        เลขรหัสประจำบ้าน
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_LCN.HOUSENO}}</label>
                    </td>
                </tr>
                <tr>
                    <td>
                        ตั้งอยู่เลขที่
                    </td>
                    <td colspan="3" style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_LCN.fulladdr3}}</label>
                    </td>
                </tr>
                <tr>
                    <td>
                        โทรศัพท์/มือถือ
                    </td>
                    <td colspan="3" style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_LCN.tel}}</label>
                    </td>
                </tr>

            </table>
            <table style="width:100%;font-size:20px" ng-init="getdetails_phr()">
                <tr>
                    <td style="width:15%;">
                        โดยมีเภสัชกรชื่อ  1.
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;width:15%;">
                        <label>{{LIST_PHR.PHR_NAME}}</label>
                    </td>
                    <td style="width:15%">
                        ใบอนุญาตประกอบวิชาชีพเภสัชกรรมเลขที่
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_PHR.PHR_TEXT_NUM}}</label>
                    </td>
                </tr>
            </table>
            <br />
            @*<input type="button" style="font-size:20px;width:100px" value="เพิ่ม" />*@
            @*<input type="button" style="font-size:20px;width:100px;margin-left:10px" value="ลบ" />*@
            <br />
            <table style="width:100%;font-size:20px">
                <tr>
                    <td>
                        เป็นผู้รับอนุญาตขายยาแผนใบอนุญาตเลขที่
                    </td>
                    <td style="width:50%; border-bottom:dotted;border-bottom-width:thin; ">
                        <label>{{LIST_LCN.HEAD_LCNNO_NCT}}</label>
                    </td>
                    <td>
                        ตามกฎหมายว่าด้วยยา
                    </td>
                </tr>
            </table>
            <div style="font-size:20px">เป็นผู้ควบคุมตามมาตรา ๕๓ แห่งพระราชบัญญัติวัตถุที่ออกฤทธิ์ต่อจิตและประสาท พ.ศ. ๒๕๕๙</div>

            <div style="font-size:20px;margin-left:5%"><strong>(๓.๒) <u>กรณีขายวัตถุออกฤทธฺิ์ในประเภท ๓ หรือประเภท ๔ โดยการขายส่งตรง</u></strong></div>
            <table style="width:100%;font-size:20px">
                <tr>
                    <td colspan="2">
                        ผู้ขอรับใบอนุญาตได้รับอนุญาตให้ผลิต/ขาย/หรือนำเข้าซึ่งวัตถุออกฤทธิ์ในประเภท ๓ หรือประเภท ๔ ตามใบอนุญาต
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        ผู้ขอรับใบอนุญาตได้รับอนุญาตให้ผลิต/ขาย/หรือนำเข้าซึ่งวัตถุออกฤทธิ์ในประเภท ๓ หรือประเภท ๔ ตามใบอนุญาต
                    </td>
                </tr>
                <tr>
                    <td style="width:10%">
                        เลขที่
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_LCN.HEAD_LCNNO}}</label>
                    </td>
                </tr>
            </table>
            <div style="font-size:20px;margin-left:5%"><strong>(๓.๓) <u> กรณีขายวัตถุออกฤทธฺิ์ในประเภท ๓ หรือประเภท ๔ ในบริเวณสถานที่ที่มีการประชุม</u></strong></div>

            <table style="width:100%;font-size:20px">
                <tr>
                    <td colspan="4">
                        ผู้ขอรับใบอนุญาตได้รับอนุญาตให้ผลิต/ขาย/หรือนำเข้าซึ่งวัตถุออกฤทธิ์ในประเภท ๓ หรือประเภท ๔ ตามใบอนุญาต
                    </td>
                </tr>
                <tr>
                    <td style="width:20%">
                        เลขที่
                    </td>
                    <td colspan="4" style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_LCN.HEAD_LCNNO}}</label>
                    </td>
                </tr>
                <tr>
                    <td colspan="4">
                        ขอรับใบอนุญาตขายวัตถุออกฤทธิ์ในบริเวณสถานที่ที่มีการประชุม ณ
                    </td>
                </tr>
                <tr>
                    <td style="width:10%">
                        สถานที่ชื่อ
                    </td>
                    <td colspan="4" style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_LCN.thanameplace}}</label>
                    </td>
                </tr>
                <tr>
                    <td>
                        เลขรหัสประจำบ้าน
                    </td>
                    <td colspan="4" style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_LCN.HOUSENO}}</label>
                    </td>
                </tr>
                <tr>
                    <td>
                        ตั้งอยู่เลขที่
                    </td>
                    <td colspan="3" style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_LCN.fulladdr2}}</label>
                    </td>
                </tr>
                <tr>
                    <td>
                        โทรศัพท์/มือถือ
                    </td>
                    <td colspan="3" style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_LCN.tel}}</label>
                    </td>
                </tr>
                <tr>
                    <td>
                        ตั้งแต่วันที่
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;"></td>
                    <td style="width:20%">
                        ถึงวันที่
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;"></td>
                </tr>
            </table>

            <table style="width:100%;font-size:20px" ng-init="getdetails_keep()">
                <tr>
                    <td colspan="7">
                        <p>
                            <strong>
                                ๔. ข้อมูลสถานที่เก็บ (กรณีเป็นสถานที่คนละแห่งกับสถานที่ตาม ๓)
                            </strong>
                        </p>
                    </td>
                </tr>
                <tr>
                    <td style="width:17%">
                        ณ สถานที่ชื่อ
                    </td>
                    <td colspan="4" style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_KEEP.KEEP_THANAMEPLACE}}</label>
                    </td>
                    <td style="width:15%">
                        เลขรหัสประจำบ้าน
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_KEEP.HOUSENO}}</label>
                    </td>
                </tr>
                <tr>
                    <td>
                        อยู่เลขที่
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_KEEP.KEEP_FULL_ADDR}}</label>
                    </td>
                </tr>
                <tr>
                    <td>
                        โทรศัพท์ / มือถือ
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_KEEP.KEEP_TEL}}</label>
                    </td>
                </tr>

            </table>
            @*<input type="button" style="font-size:20px;width:100px" value="เพิ่ม" />*@
            @*<input type="button" style="font-size:20px;width:100px;margin-left:10px" value="ลบ" />*@
            <br />
            <br />

            <div style=";font-size:20px"><strong>๕. พร้อมกับคำขอนี้ข้าพเจ้าได้แนบเอกสารหรือหลักฐานต่างๆ มาด้วย คือ</strong></div>
            <div style="margin-left:5%;font-size:20px"><strong>๕.๑ <u>กรณีขอรับใบอนุญาต (กรณีรายใหม่)</u></strong></div>
            <div style="margin-left:8%;font-size:20px"><strong>๕.๑.๑ กรณีขอรับใบอนุญาตขายวัตถุออกฤทธิ์ในประเภท ๓ หรือประเภท ๔</strong></div>
            <table style="width:90%;font-size:20px ;margin-left:10%">
                <tr>
                    <td>
                        (๑) สำเนาใบอนุญาตขายยาแผนปัจจุบันตามกฎหมายว่าด้วยยา
                    </td>
                </tr>
                <tr>
                    <td>
                        (๒) คำรับรองของผู้รับอนุญาตและเภสัชกรผู้ควบคุมกิจการ
                    </td>
                </tr>
                <tr>
                    <td>
                        (๓) รูปถ่ายหน้าตรง ไม่สวมหมวกและแว่นตาสีเข้ม ของผู้ขอรับใบอนุญาตหรือผู้ได้รับมอบหมายหรือแต่งตั้ง
                    </td>
                </tr>
                <tr>
                    <td>
                        ให้ดำเนินกิจการเกี่ยวกับใบอนุญาต ขนาด ๑ นิ้ว จำนวน ๓ รูป ซึ่งถ่ายไว้ไม่เกิน ๖ เดือนก่อนวันยื่นคำขอ
                    </td>
                </tr>
                <tr>
                    <td>
                        (๔) สำเนาใบอนุญาตประกอบวิชาชีพเภสัชกรรม
                    </td>
                </tr>
                <tr>
                    <td>
                        (๕) หนังสือแต่งตั้งผู้ดำเนินกิจการ กรณีผู้ขอรับใบอนุญาตเป็นนิติบุคคล
                    </td>
                </tr>
            </table>
            <div style="margin-left:8%;font-size:20px"><strong>๕.๑.๒ กรณีขอรับใบอนุญาตขายวัตถุออกฤทธิ์ในประเภท ๓ หรือประเภท ๔ โดยการขายส่งตรง</strong></div>
            <table style="width:90%;font-size:20px ;margin-left:10%">
                <tr>
                    <td>
                        (๑) สำเนาใบอนุญาตผลิต ขาย หรือนำเข้าวัตถุออกฤทธิ์ในประเภท ๓ หรือประเภท ๔ แล้วแต่กรณี
                    </td>
                </tr>
                <tr>
                    <td>
                        (๒) รูปถ่ายหน้าตรง ไม่สวมหมวกและแว่นตาสีเข้ม ของผู้ขอรับใบอนุญาตหรือผู้ได้รับมอบหมายหรือแต่งตั้งให้
                    </td>
                </tr>
                <tr>
                    <td>
                        ดำเนินกิจการเกี่ยวกับใบอนุญาต ขนาด ๑ นิ้ว จำนวน ๓ รูป ซึ่งถ่ายไว้ไม่เกิน ๖ เดือนก่อนวันยื่นคำขอ
                    </td>
                </tr>
            </table>
            <div style="margin-left:8%;font-size:20px"><strong>๕.๑.๓ กรณีขอรับใบอนุญาตขายวัตถุออกฤทธฺิ์ในประเภท ๓ หรือประเภท ๔ ในบริเวณสถานที่ที่มีการประชุม</strong></div>
            <table style="width:90%;font-size:20px ;margin-left:10%">
                <tr>
                    <td>
                        (๑) สำเนาใบอนุญาตผลิต ขาย หรือนำเข้าวัตถุออกฤทธิ์ในประเภท ๓ หรือประเภท ๔ แล้วแต่กรณี
                    </td>
                </tr>
            </table>

            <div style="margin-left:5%;font-size:20px"><strong>๕.๒ กรณีขอต่ออายุใบอนุญาต</strong></div>
            <table style="width:90%;font-size:20px ;margin-left:10%">
                <tr>
                    <td>
                        (๑) ใบอนุญาตฉบับเดิม
                    </td>
                </tr>
                <tr>
                    <td>
                        (๒) รูปถ่ายหน้าตรง ไม่สวมหมวกและแว่นตาสีเข้ม ของผู้ขอรับใบอนุญาตหรือผู้ได้รับมอบหมายหรือแต่งตั้งให้ดำเนินกิจการ
                        เกี่ยวกับใบอนุญาต ขนาด ๑ นิ้ว จำนวน ๓ รูป ซึ่งถ่ายไว้ไม่เกิน ๖ เดือนก่อนวันยื่นคำขอ
                    </td>
                </tr>

            </table>
            <div style="margin-left:5%;font-size:20px"><strong>๕.๓ กรณีขอรับใบแทนใบอนุญาต</strong></div>
            <table style="width:90%;font-size:20px ;margin-left:10%">
                <tr>
                    <td>
                        (๑) ใบแจ้งความ กรณีใบอนุญาตสูญหาย
                    </td>
                </tr>
                <tr>
                    <td>
                        (๒) ใบอนุญาต กรณีใบอนุญาตดังกล่าวถูกทำลายบางส่วนหรือลบเลือนในสาระสำคัญ
                    </td>
                </tr>
                <tr>
                    <td>
                        (๓) รูปถ่ายหน้าตรง ไม่สวมหมวกและแว่นตาสีเข้ม ของผู้ขอรับใบอนุญาตหรือผู้ได้รับมอบหมายหรือแต่งตั้งให้ดำเนินกิจการเกี่ยวกับ
                        ใบอนุญาต ขนาด ๑ นิ้ว จำนวน ๓ รูป ซึ่งถ่ายไว้ไม่เกิน ๖ เดือนก่อนวันยื่นคำขอ
                    </td>
                </tr>

            </table>
            <div style="margin-left:5%;font-size:20px;text-align:center"><strong>ข้าพเจ้าขอรับรองว่า ข้อความและเอกสารหรือหลักฐานทั้งหมดที่ยื่นเพื่อประกอบคำขอรับใบอนุญาตเป็นความจริงทุกประการ</strong></div>
            <br />
            <div>
                <h2 style="font-family:'Taviraj';font-size:20px;">
                    ไฟล์แนบ
                </h2>
                <table class="table" style="width:100%">
                    <tr>
                        <td>ชื่อไฟล์</td>
                        <td></td>
                    </tr>
                    <tr ng-repeat="datas in LIST_File.FILE_LISTs" style="background-color:#FDFCE3">
                        <td>{{datas.FILENAME}}</td>
                        <td>
                            <a ng-show="datas.PATH != null && datas.PATH != ''" ng-click="OPEN_DOC_PATH(datas.PATH,datas.FILENAME)">ดูเอกสาร</a>
                        </td>
                    </tr>
                </table>
            </div>
            <br />
            <br />

            <table style="width:85%;font-size:20px ;margin-left:12.5%">
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
                        <label>{{LIST_LCN.BSN_THAIFULLNAME}}</label>
                    </td>
                    <td style="text-align:left">
                        )
                    </td>
                </tr>

            </table>
            <br />
            <br />

            <div style="margin-left:5%;font-size:20px"> หมายเหตุ : (๑) ให้ขีดเลือกข้อความในช่อง ☐/〇 ให้ตรงตามที่ประสงค์จะดำเนินการ</div>
            <table style="width:90%;font-size:20px ;margin-left:12.5%">
                <tr>
                    <td>
                        (๒) รับรองสำเนาถูกต้องในเอกสารที่เป็นสำเนาทุกฉบับ
                    </td>
                </tr>
                <tr>
                    <td>
                        (๓) กรณีเอกสารหรือหลักฐานที่ออกโดยสำนักงานคณะกรรมการอาหารและยา ผู้อนุญาตอาจไม่ขอเอกสารหรือหลักฐานดังกล่าวได้
                    </td>
                </tr>

            </table>
            <br />

        </div>
    </div>

    <div ng-show="LIST_LCN.PROCESS == '100767'">
        <div style="font-family:'Taviraj';font-size:24px;">
            <h1 style="text-align:left;font-size:24px;">
                <strong>แบบ ข.ว.จ. ๓/๔-๑</strong>
            </h1>
            <br />
            <div class="title1">
                <label style="font-size:16px;margin-top:25px">
                    ที่ปิดรูปถ่าย<br />
                    ผู้ขออนุญาติ<br />
                    หรือ<br />
                    ผู้ดำเนินกิจการ<br />
                    ขนาด ๓ นิ้ว<br />
                </label>
            </div>

            <div class="title2">
                <table style="font-size:20px;width:95%;margin-top:10px;margin-left:10px">
                    <tr>
                        <td style="text-align:left;width:20%">
                            เลขรับที่
                        </td>

                        <td colspan="3" style="border-bottom:dotted;border-bottom-width:thin;">
                            <label>{{LCN_LIST.RCVNO_DISPLAY}}</label>
                        </td>
                    </tr>
                    <tr>
                        <td style="text-align:left">
                            วันที่
                        </td>

                        <td colspan="3" style="border-bottom:dotted;border-bottom-width:thin;">
                            <label>{{LCN_LIST.RCV_DATE_DISPLAY}}</label>
                        </td>
                    </tr>
                    <tr>
                        <td style="text-align:left">
                            ลงชื่่อ

                        </td>

                        <td style="border-bottom:dotted;border-bottom-width:thin;"></td>
                        <td style="text-align:right;width:25%">
                            ผู้รับคำขอ
                        </td>
                    </tr>
                </table>

            </div>


            <div style="clear:both"></div>
            <br />
            <br />

            <h2 style="text-align:center;font-size:24px;">
                <strong>คำขอรับใบอนุญาต คำขอต่ออายุใบอนุญาต คำขอรับใบแทน</strong><br />
                <strong>ใบอนุญาตขายวัตถุออกฤทธิ์ในประเภท ๓ หรือประเภท ๔</strong>
            </h2>
            @*process =123,124 *@
            <table style="width:70%; font-size:20px;margin:auto;text-align:center">
                <tr>
                    <td>
                        <strong>สำหรับขาย</strong>
                    </td>
                    <td>
                        <input type="radio" name="gender" ng-model="LIST_LCN.PROCESS" ng-value="100766" id="rdl_CHK_SELL_TYPE" disabled="disabled" /> <strong>วัตถุออกฤทธิ์ในประเภท ๓</strong>
                    </td>
                    <td>
                        <input type="radio" name="gender" ng-model="LIST_LCN.PROCESS" ng-value="100767" id="rdl_CHK_SELL_TYPE" disabled="disabled" /> <strong>วัตถุออกฤทธิ์ในประเภท ๔</strong>
                    </td>
                </tr>
                <tr>
                    <td style="font-size:16px" colspan="3">
                        <strong>(คำขอ ๑ ฉบับ ให้ยื่นขอได้เพียงหนึ่งประเภทเท่านั้น)</strong>
                    </td>
                </tr>
            </table>

            <table style="width:100%; font-size:20px">
                <tr>
                    <td style="width:20%">
                        <input type="checkbox" name="gender" disabled="disabled" /> <strong>ขอรับใบอนุญาต</strong>
                    </td>
                </tr>
                <tr>
                    <td>
                        <input type="checkbox" name="gender" disabled="disabled" /> <strong>ขอต่ออายุใบอนุญาตเลขที่</strong>
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;"></td>
                    <td style="width:10%">
                        <strong>ประจำปี พ.ศ.</strong>
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;"></td>
                </tr>
                <tr>
                    <td>
                        <input type="checkbox" name="gender" disabled="disabled" ng-checked="true" /> <strong>ขอรับใบแทนใบอนุญาต</strong>
                    </td>
                    <td>
                        เนื่องจากใบอนุญาต
                    </td>
                    <td colspan="2">

                        <form name="frm_lost_type">


                            <label><input type="radio" ng-model="LIST_LCN.DALCN_NCT_SUBSTITUTE.PURPOSE_ID" id="rdl_lost_type" value="1"> สูญหาย</label>
                            <label><input type="radio" ng-model="LIST_LCN.DALCN_NCT_SUBSTITUTE.PURPOSE_ID" id="rdl_lost_type" value="2"> ถูกทำลายหรือลบเลือนในสาระสำคัญ</label><br />

                        </form>



                    </td>

                </tr>
            </table>
            <br />

            <table style="width:100%">
                <tr>
                    <td style="text-align:right;width:90%">
                        เขียนที่
                    </td>
                    <td style="width:40%;border-bottom:dotted;border-bottom-width:thin;">

                        {{LIST_LCN.DALCN_NCT_SUBSTITUTE.WRITE_AT}}
                    </td>
                </tr>
                <tr>
                    <td style="text-align:right;width:100px">
                        วันที่
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;">

                        {{LIST_LCN.DALCN_NCT_SUBTITUTE.WRITE_DATE}}
                    </td>
                </tr>
            </table>
            <br />

            <h2 style="font-size:24px;">
                <strong>๑. ข้อมูลผู้ขอรับใบอนุญาต</strong>
            </h2>
            <table style="width:90%">
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
            <table style="width:90%">
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
                    <td style="text-align:left;width:30%;border-bottom:dotted;border-bottom-width:thin;">
                        @*<form action="javascript:void(0)">
                                <table>
                                    <tr>
                                        <td style="border-bottom:dotted;border-bottom-width:thin;">
                                            <input class="form-control inline" ng-model="LIST_LCN.BSN_IDENTIFY" id="txt_bsn_identify" style="font-family:'Taviraj';" type="text" />
                                            {{LIST_LCN.BSN_IDENTIFY}}
                                        </td>
                                        <td>
                                                <input type="button" value="ค้นหาผู้ดำเนินฯ" ng-click="BTN_Search_BSN(LIST_LCN.BSN_IDENTIFY)" />
                                            </td>
                                    </tr>
                                </table>


                            </form>*@
                        <label>{{LIST_LCN.BSN_THAIFULLNAME}}</label>
                    </td>
                </tr>
                <tr>
                    <td style="font-size:20px">
                        หรือบัตรประจำตัวอื่นที่ทางราชการออกให้ คือ
                    </td>
                    <td style="font-size:20px;width:20%;border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_LCN.BSN_IDENTIFY}}</label>
                    </td>
                    <td style="font-size:20px;width:5%">
                        เลขที่
                    </td>
                    <td style="font-size:20px ;width:15%;text-align:center"></td>
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
                        <label>{{LIST_LCN.BSN_FULL_ADDR}}</label>
                    </td>
                </tr>
                <tr>
                    <td style="font-size:20px">
                        โทรศัพท์/มือถือ
                    </td>
                    <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;" colspan="6">
                        <label>{{LIST_LCN.BSN_TELEPHONE}}</label>
                    </td>
                </tr>
            </table>

            <div style="font-size:20px"><strong>๓. ข้อมูลการขออนุญาต</strong></div>
            <div style="font-size:20px;margin-left:5%">(๓.๑) <strong><u>กรณีขายวัตถุออกฤทธฺิ์ในประเภท ๓ หรือประเภท ๔</u></strong></div>
            <table style="width:100%;font-size:20px">
                <tr>
                    <td>
                        ณ สถานที่ชื่อ
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_LCN.THANAMEPLACE}}</label>
                    </td>
                    <td>
                        เลขรหัสประจำบ้าน
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_LCN.HOUSENO}}</label>
                    </td>
                </tr>
                <tr>
                    <td>
                        ตั้งอยู่เลขที่
                    </td>
                    <td colspan="3" style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_LCN.fulladdr3}}</label>
                    </td>
                </tr>
                <tr>
                    <td>
                        โทรศัพท์/มือถือ
                    </td>
                    <td colspan="3" style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_LCN.tel}}</label>
                    </td>
                </tr>

            </table>
            <table style="width:100%;font-size:20px" ng-init="getdetails_phr()">
                <tr>
                    <td style="width:15%;">
                        โดยมีเภสัชกรชื่อ  1.
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;width:15%;">
                        <label>{{LIST_PHR.PHR_NAME}}</label>
                    </td>
                    <td style="width:15%">
                        ใบอนุญาตประกอบวิชาชีพเภสัชกรรมเลขที่
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_PHR.PHR_TEXT_NUM}}</label>
                    </td>
                </tr>
            </table>
            <br />
            @*<input type="button" style="font-size:20px;width:100px" value="เพิ่ม" />*@
            @*<input type="button" style="font-size:20px;width:100px;margin-left:10px" value="ลบ" />*@
            <br />
            <table style="width:100%;font-size:20px">
                <tr>
                    <td>
                        เป็นผู้รับอนุญาตขายยาแผนใบอนุญาตเลขที่
                    </td>
                    <td style="width:50%; border-bottom:dotted;border-bottom-width:thin; ">
                        <label>{{LIST_LCN.HEAD_LCNNO_NCT}}</label>
                    </td>
                    <td>
                        ตามกฎหมายว่าด้วยยา
                    </td>
                </tr>
            </table>
            <div style="font-size:20px">เป็นผู้ควบคุมตามมาตรา ๕๓ แห่งพระราชบัญญัติวัตถุที่ออกฤทธิ์ต่อจิตและประสาท พ.ศ. ๒๕๕๙</div>

            <div style="font-size:20px;margin-left:5%"><strong>(๓.๒) <u>กรณีขายวัตถุออกฤทธฺิ์ในประเภท ๓ หรือประเภท ๔ โดยการขายส่งตรง</u></strong></div>
            <table style="width:100%;font-size:20px">
                <tr>
                    <td colspan="2">
                        ผู้ขอรับใบอนุญาตได้รับอนุญาตให้ผลิต/ขาย/หรือนำเข้าซึ่งวัตถุออกฤทธิ์ในประเภท ๓ หรือประเภท ๔ ตามใบอนุญาต
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        ผู้ขอรับใบอนุญาตได้รับอนุญาตให้ผลิต/ขาย/หรือนำเข้าซึ่งวัตถุออกฤทธิ์ในประเภท ๓ หรือประเภท ๔ ตามใบอนุญาต
                    </td>
                </tr>
                <tr>
                    <td style="width:10%">
                        เลขที่
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_LCN.HEAD_LCNNO}}</label>
                    </td>
                </tr>
            </table>
            <div style="font-size:20px;margin-left:5%"><strong>(๓.๓) <u> กรณีขายวัตถุออกฤทธฺิ์ในประเภท ๓ หรือประเภท ๔ ในบริเวณสถานที่ที่มีการประชุม</u></strong></div>

            <table style="width:100%;font-size:20px">
                <tr>
                    <td colspan="4">
                        ผู้ขอรับใบอนุญาตได้รับอนุญาตให้ผลิต/ขาย/หรือนำเข้าซึ่งวัตถุออกฤทธิ์ในประเภท ๓ หรือประเภท ๔ ตามใบอนุญาต
                    </td>
                </tr>
                <tr>
                    <td style="width:20%">
                        เลขที่
                    </td>
                    <td colspan="4" style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_LCN.HEAD_LCNNO}}</label>
                    </td>
                </tr>
                <tr>
                    <td colspan="4">
                        ขอรับใบอนุญาตขายวัตถุออกฤทธิ์ในบริเวณสถานที่ที่มีการประชุม ณ
                    </td>
                </tr>
                <tr>
                    <td style="width:10%">
                        สถานที่ชื่อ
                    </td>
                    <td colspan="4" style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_LCN.thanameplace}}</label>
                    </td>
                </tr>
                <tr>
                    <td>
                        เลขรหัสประจำบ้าน
                    </td>
                    <td colspan="4" style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_LCN.HOUSENO}}</label>
                    </td>
                </tr>
                <tr>
                    <td>
                        ตั้งอยู่เลขที่
                    </td>
                    <td colspan="3" style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_LCN.fulladdr2}}</label>
                    </td>
                </tr>
                <tr>
                    <td>
                        โทรศัพท์/มือถือ
                    </td>
                    <td colspan="3" style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_LCN.tel}}</label>
                    </td>
                </tr>
                <tr>
                    <td>
                        ตั้งแต่วันที่
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;"></td>
                    <td style="width:20%">
                        ถึงวันที่
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;"></td>
                </tr>
            </table>

            <table style="width:100%;font-size:20px" ng-init="getdetails_keep()">
                <tr>
                    <td colspan="7">
                        <p>
                            <strong>
                                ๔. ข้อมูลสถานที่เก็บ (กรณีเป็นสถานที่คนละแห่งกับสถานที่ตาม ๓)
                            </strong>
                        </p>
                    </td>
                </tr>
                <tr>
                    <td style="width:17%">
                        ณ สถานที่ชื่อ
                    </td>
                    <td colspan="4" style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_KEEP.KEEP_THANAMEPLACE}}</label>
                    </td>
                    <td style="width:15%">
                        เลขรหัสประจำบ้าน
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_KEEP.HOUSENO}}</label>
                    </td>
                </tr>
                <tr>
                    <td>
                        อยู่เลขที่
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_KEEP.KEEP_FULL_ADDR}}</label>
                    </td>
                </tr>
                <tr>
                    <td>
                        โทรศัพท์ / มือถือ
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_KEEP.KEEP_TEL}}</label>
                    </td>
                </tr>

            </table>
            @*<input type="button" style="font-size:20px;width:100px" value="เพิ่ม" />*@
            @*<input type="button" style="font-size:20px;width:100px;margin-left:10px" value="ลบ" />*@
            <br />
            <br />

            <div style=";font-size:20px"><strong>๕. พร้อมกับคำขอนี้ข้าพเจ้าได้แนบเอกสารหรือหลักฐานต่างๆ มาด้วย คือ</strong></div>
            <div style="margin-left:5%;font-size:20px"><strong>๕.๑ <u>กรณีขอรับใบอนุญาต (กรณีรายใหม่)</u></strong></div>
            <div style="margin-left:8%;font-size:20px"><strong>๕.๑.๑ กรณีขอรับใบอนุญาตขายวัตถุออกฤทธิ์ในประเภท ๓ หรือประเภท ๔</strong></div>
            <table style="width:90%;font-size:20px ;margin-left:10%">
                <tr>
                    <td>
                        (๑) สำเนาใบอนุญาตขายยาแผนปัจจุบันตามกฎหมายว่าด้วยยา
                    </td>
                </tr>
                <tr>
                    <td>
                        (๒) คำรับรองของผู้รับอนุญาตและเภสัชกรผู้ควบคุมกิจการ
                    </td>
                </tr>
                <tr>
                    <td>
                        (๓) รูปถ่ายหน้าตรง ไม่สวมหมวกและแว่นตาสีเข้ม ของผู้ขอรับใบอนุญาตหรือผู้ได้รับมอบหมายหรือแต่งตั้ง
                    </td>
                </tr>
                <tr>
                    <td>
                        ให้ดำเนินกิจการเกี่ยวกับใบอนุญาต ขนาด ๑ นิ้ว จำนวน ๓ รูป ซึ่งถ่ายไว้ไม่เกิน ๖ เดือนก่อนวันยื่นคำขอ
                    </td>
                </tr>
                <tr>
                    <td>
                        (๔) สำเนาใบอนุญาตประกอบวิชาชีพเภสัชกรรม
                    </td>
                </tr>
                <tr>
                    <td>
                        (๕) หนังสือแต่งตั้งผู้ดำเนินกิจการ กรณีผู้ขอรับใบอนุญาตเป็นนิติบุคคล
                    </td>
                </tr>
            </table>
            <div style="margin-left:8%;font-size:20px"><strong>๕.๑.๒ กรณีขอรับใบอนุญาตขายวัตถุออกฤทธิ์ในประเภท ๓ หรือประเภท ๔ โดยการขายส่งตรง</strong></div>
            <table style="width:90%;font-size:20px ;margin-left:10%">
                <tr>
                    <td>
                        (๑) สำเนาใบอนุญาตผลิต ขาย หรือนำเข้าวัตถุออกฤทธิ์ในประเภท ๓ หรือประเภท ๔ แล้วแต่กรณี
                    </td>
                </tr>
                <tr>
                    <td>
                        (๒) รูปถ่ายหน้าตรง ไม่สวมหมวกและแว่นตาสีเข้ม ของผู้ขอรับใบอนุญาตหรือผู้ได้รับมอบหมายหรือแต่งตั้งให้
                    </td>
                </tr>
                <tr>
                    <td>
                        ดำเนินกิจการเกี่ยวกับใบอนุญาต ขนาด ๑ นิ้ว จำนวน ๓ รูป ซึ่งถ่ายไว้ไม่เกิน ๖ เดือนก่อนวันยื่นคำขอ
                    </td>
                </tr>
            </table>
            <div style="margin-left:8%;font-size:20px"><strong>๕.๑.๓ กรณีขอรับใบอนุญาตขายวัตถุออกฤทธฺิ์ในประเภท ๓ หรือประเภท ๔ ในบริเวณสถานที่ที่มีการประชุม</strong></div>
            <table style="width:90%;font-size:20px ;margin-left:10%">
                <tr>
                    <td>
                        (๑) สำเนาใบอนุญาตผลิต ขาย หรือนำเข้าวัตถุออกฤทธิ์ในประเภท ๓ หรือประเภท ๔ แล้วแต่กรณี
                    </td>
                </tr>
            </table>

            <div style="margin-left:5%;font-size:20px"><strong>๕.๒ กรณีขอต่ออายุใบอนุญาต</strong></div>
            <table style="width:90%;font-size:20px ;margin-left:10%">
                <tr>
                    <td>
                        (๑) ใบอนุญาตฉบับเดิม
                    </td>
                </tr>
                <tr>
                    <td>
                        (๒) รูปถ่ายหน้าตรง ไม่สวมหมวกและแว่นตาสีเข้ม ของผู้ขอรับใบอนุญาตหรือผู้ได้รับมอบหมายหรือแต่งตั้งให้ดำเนินกิจการ
                        เกี่ยวกับใบอนุญาต ขนาด ๑ นิ้ว จำนวน ๓ รูป ซึ่งถ่ายไว้ไม่เกิน ๖ เดือนก่อนวันยื่นคำขอ
                    </td>
                </tr>

            </table>
            <div style="margin-left:5%;font-size:20px"><strong>๕.๓ กรณีขอรับใบแทนใบอนุญาต</strong></div>
            <table style="width:90%;font-size:20px ;margin-left:10%">
                <tr>
                    <td>
                        (๑) ใบแจ้งความ กรณีใบอนุญาตสูญหาย
                    </td>
                </tr>
                <tr>
                    <td>
                        (๒) ใบอนุญาต กรณีใบอนุญาตดังกล่าวถูกทำลายบางส่วนหรือลบเลือนในสาระสำคัญ
                    </td>
                </tr>
                <tr>
                    <td>
                        (๓) รูปถ่ายหน้าตรง ไม่สวมหมวกและแว่นตาสีเข้ม ของผู้ขอรับใบอนุญาตหรือผู้ได้รับมอบหมายหรือแต่งตั้งให้ดำเนินกิจการเกี่ยวกับ
                        ใบอนุญาต ขนาด ๑ นิ้ว จำนวน ๓ รูป ซึ่งถ่ายไว้ไม่เกิน ๖ เดือนก่อนวันยื่นคำขอ
                    </td>
                </tr>

            </table>
            <div style="margin-left:5%;font-size:20px;text-align:center"><strong>ข้าพเจ้าขอรับรองว่า ข้อความและเอกสารหรือหลักฐานทั้งหมดที่ยื่นเพื่อประกอบคำขอรับใบอนุญาตเป็นความจริงทุกประการ</strong></div>
            <br />
            <div>
                <h2 style="font-family:'Taviraj';font-size:20px;">
                    ไฟล์แนบ
                </h2>
                <table class="table" style="width:100%">
                    <tr>
                        <td>ชื่อไฟล์</td>
                        <td></td>
                    </tr>
                    <tr ng-repeat="datas in LIST_File.FILE_LISTs" style="background-color:#FDFCE3">
                        <td>{{datas.FILENAME}}</td>
                        <td>
                            <a ng-show="datas.PATH != null && datas.PATH != ''" ng-click="OPEN_DOC_PATH(datas.PATH,datas.FILENAME)">ดูเอกสาร</a>
                        </td>
                    </tr>
                </table>
            </div>
            <br />
            <br />

            <table style="width:85%;font-size:20px ;margin-left:12.5%">
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
                        <label>{{LIST_LCN.BSN_THAIFULLNAME}}</label>
                    </td>
                    <td style="text-align:left">
                        )
                    </td>
                </tr>

            </table>
            <br />
            <br />

            <div style="margin-left:5%;font-size:20px"> หมายเหตุ : (๑) ให้ขีดเลือกข้อความในช่อง ☐/〇 ให้ตรงตามที่ประสงค์จะดำเนินการ</div>
            <table style="width:90%;font-size:20px ;margin-left:12.5%">
                <tr>
                    <td>
                        (๒) รับรองสำเนาถูกต้องในเอกสารที่เป็นสำเนาทุกฉบับ
                    </td>
                </tr>
                <tr>
                    <td>
                        (๓) กรณีเอกสารหรือหลักฐานที่ออกโดยสำนักงานคณะกรรมการอาหารและยา ผู้อนุญาตอาจไม่ขอเอกสารหรือหลักฐานดังกล่าวได้
                    </td>
                </tr>

            </table>
            <br />

        </div>
    </div>

    <div ng-show="LIST_LCN.PROCESS == '100768'">
        <div style="font-family:'Taviraj';font-size:24px;">

            <h1 style="text-align:left;font-size:24px;">
                <strong>แบบ ผ.ว.จ. ๓/๔-๑</strong>
            </h1>
            <br />
            <div class="title1">
                <label style="font-size:16px;margin-top:25px">
                    ที่ปิดรูปถ่าย<br />
                    ผู้ขออนุญาติ<br />
                    หรือ<br />
                    ผู้ดำเนินกิจการ<br />
                    ขนาด ๓ นิ้ว<br />
                </label>
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
                        <td style="text-align:left">
                            ลงชื่่อ

                        </td>

                        <td style="border-bottom:dotted;border-bottom-width:thin;"></td>
                        <td style="text-align:right;width:25%">
                            ผู้รับคำขอ
                        </td>
                    </tr>
                </table>

            </div>


            <div style="clear:both"></div>
            <br />
            <br />

            <h2 style="text-align:center;font-size:24px;">
                <strong>คำขอรับใบอนุญาต คำขอต่ออายุใบอนุญาต คำขอรับใบแทน</strong><br />
                <strong>ใบอนุญาตผลิตวัตถุออกฤทธิ์ในประเภท ๓ หรือประเภท ๔</strong>
            </h2>
            @*process =1107,1108 *@
            <table style="width:70%; font-size:20px;margin:auto;text-align:center">
                <tr>
                    <td>
                        <strong>สำหรับผลิต</strong>
                    </td>
                    <td>
                        <input type="radio" name="gender" ng-model="LIST_LCN.PROCESS" ng-value="100768" id="rdl_CHK_SELL_TYPE" disabled="disabled" /> <strong>วัตถุออกฤทธิ์ในประเภท ๓</strong>
                    </td>
                    <td>
                        <input type="radio" name="gender" ng-model="LIST_LCN.PROCESS" ng-value="100769" id="rdl_CHK_SELL_TYPE" disabled="disabled" /> <strong>วัตถุออกฤทธิ์ในประเภท ๔</strong>
                    </td>
                </tr>
                <tr>
                    <td style="font-size:16px" colspan="3">
                        <strong>(คำขอ ๑ ฉบับ ให้ยื่นขอได้เพียงหนึ่งประเภทเท่านั้น)</strong>
                    </td>
                </tr>
            </table>

            <table style="width:100%; font-size:20px">
                <tr>
                    <td style="width:20%">
                        <input type="checkbox" name="gender" disabled="disabled" /> <strong>ขอรับใบอนุญาต</strong>
                    </td>
                </tr>
                <tr>
                    <td>
                        <input type="checkbox" name="gender" disabled="disabled" /> <strong>ขอต่ออายุใบอนุญาตเลขที่</strong>
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;"></td>
                    <td style="width:10%">
                        <strong>ประจำปี พ.ศ.</strong>
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;"></td>
                </tr>
                <tr>
                    <td>
                        <input type="checkbox" name="gender" disabled="disabled" ng-checked="true" /> <strong>ขอรับใบแทนใบอนุญาต</strong>
                    </td>
                    <td>
                        เนื่องจากใบอนุญาต
                    </td>
                    <td colspan="2">

                        <form name="frm_lost_type">


                            <label><input type="radio" ng-model="LIST_LCN.DALCN_NCT_SUBSTITUTE.PURPOSE_ID" id="rdl_lost_type" value="1"> สูญหาย</label>
                            <label><input type="radio" ng-model="LIST_LCN.DALCN_NCT_SUBSTITUTE.PURPOSE_ID" id="rdl_lost_type" value="2"> ถูกทำลายหรือลบเลือนในสาระสำคัญ</label><br />

                        </form>



                    </td>

                </tr>
            </table>
            <br />

            <table style="width:100%">
                <tr>
                    <td style="text-align:right;width:90%">
                        เขียนที่
                    </td>
                    <td style="width:40%;border-bottom:dotted;border-bottom-width:thin;">

                        {{LIST_LCN.DALCN_NCT_SUBSTITUTE.WRITE_AT}}
                    </td>
                </tr>
                <tr>
                    <td style="text-align:right;width:100px">
                        วันที่
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;">

                        {{LIST_LCN.DALCN_NCT_SUBTITUTE.WRITE_DATE}}
                    </td>
                </tr>
            </table>
            <br />

            <h2 style="font-size:24px;">
                <strong>๑. ข้อมูลผู้ขอรับใบอนุญาต</strong>
            </h2>
            <table style="width:90%">
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
            <table style="width:90%">
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
                    <td style="text-align:left;width:30%;border-bottom:dotted;border-bottom-width:thin;">
                        @*<form action="javascript:void(0)">
                                <table>
                                    <tr>
                                        <td>
                                            <input class="form-control inline" ng-model="LIST_LCN.BSN_IDENTIFY" id="txt_bsn_identify" style="font-family:'TH SarabunPSK';" type="text" />
                                            {{LIST_LCN.BSN_IDENTIFY}}
                                        </td>
                                        <td>
                                                <input type="button" value="ค้นหาผู้ดำเนินฯ" ng-click="BTN_Search_BSN(LIST_LCN.BSN_IDENTIFY)" />
                                            </td>
                                    </tr>
                                </table>


                            </form>*@
                        <label>{{LIST_LCN.BSN_THAIFULLNAME}}</label>
                    </td>
                </tr>
                <tr>
                    <td style="font-size:20px">
                        หรือบัตรประจำตัวอื่นที่ทางราชการออกให้ คือ
                    </td>
                    <td style="font-size:20px;width:20%;border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_LCN.BSN_IDENTIFY}}</label>
                    </td>
                    <td style="font-size:20px;width:5%">
                        เลขที่
                    </td>
                    <td style="font-size:20px ;width:15%;text-align:center;border-bottom:dotted;border-bottom-width:thin"></td>
                    <td style="font-size:20px">
                        (กรณีไม่ใช่ผู้มีสัญชาติไทย)
                    </td>
                </tr>
                <tr>
                    <td style="font-size:20px">
                        หรือทะเบียนนิติบุคคล/บัตรประจำตัวผู้เสียภาษี เลขที่
                    </td>
                    <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_LCN.BSN_IDENTIFY}}</label>
                    </td>
                </tr>
                <tr>
                    <td style="font-size:20px">
                        เลขรหัสประจำบ้าน
                    </td>
                    <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_LCN.BSN_HOUSENO}}</label>
                    </td>
                </tr>
                <tr>
                    <td style="font-size:20px">
                        อยู่เลขที่
                    </td>
                    <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_LCN.BSN_FULL_ADDR}}</label>
                    </td>
                </tr>
                <tr>
                    <td style="font-size:20px">
                        โทรศัพท์/มือถือ
                    </td>
                    <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_LCN.BSN_TELEPHONE}}</label>
                    </td>
                </tr>
                <tr>
                    <td style="font-size:20px">
                        E-mail
                    </td>
                    <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_LCN.dalcn.Email}}</label>
                    </td>
                </tr>
            </table>

            <div style="font-size:20px"><strong>๓. ข้อมูลสถานที่ผลิต</strong></div>
            <table style="width:100%;font-size:20px">
                <tr>
                    <td>
                        ณ สถานที่ชื่อ
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_LCN.THANAMEPLACE}}</label>
                    </td>
                    <td>
                        เลขรหัสประจำบ้าน
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_LCN.HOUSENO}}</label>
                    </td>
                </tr>
                <tr>
                    <td>
                        ตั้งอยู่เลขที่
                    </td>
                    <td colspan="3" style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_LCN.fulladdr3}}</label>
                    </td>
                </tr>
                <tr>
                    <td>
                        โทรศัพท์/มือถือ
                    </td>
                    <td colspan="3" style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_LCN.tel}}</label>
                    </td>
                </tr>
            </table>

            <table style="width:100%;font-size:20px">
                <tr>
                    <td style="width:25%">
                        มีความประสงค์ขอรับอนุญาตผลิตวัตถุออกฤทธิ์ในหมวด
                    </td>
                    <td colspan="3">
                        @*<input class="form-control inline" ng-model="LIST_LCN.dalcn.CATEGORY_DRUG" style="font-family:'Taviraj';font-size:20px;" type="text" />*@
                        {{LIST_LCN.dalcn.CATEGORY_DRUG}}
                    </td>
                </tr>
                <tr>
                    <td>
                        โดยได้รับอนุญาตให้ผลิตยาแผนปัจจุบันเลขที่
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_LCN.HEAD_LCNNO_NCT}}</label>
                    </td>
                    <td style="width:25%">
                        ตามกฎหมายว่าด้วยยา ในหมวดที่ตรงกับคำขออนุญาต
                    </td>
                </tr>
                <tr>
                    <td colspan="3">
                        ผลิตวัตถุออกฤทธิ์ตามคำขอนี้
                    </td>
                </tr>
            </table>


            <table style="width:100%;font-size:20px" ng-init="getdetails_phr()">
                <tr>
                    <td style="width:15%;">
                        โดยมีเภสัชกรชื่อ  1.
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;width:15%;">
                        <label>{{LIST_PHR.PHR_NAME}}</label>
                    </td>
                    <td style="width:15%">
                        ใบอนุญาตประกอบวิชาชีพเภสัชกรรมเลขที่
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_PHR.PHR_TEXT_NUM}}</label>
                    </td>
                </tr>
            </table>
            @*<input type="button" style="font-size:20px;width:100px" value="เพิ่ม" />*@
            @*<input type="button" style="font-size:20px;width:100px;margin-left:10px" value="ลบ" />*@
            <div style="font-size:20px">เป็นผู้ควบคุมตามมาตรา ๕๓ แห่งพระราชบัญญัติวัตถุที่ออกฤทธิ์ต่อจิตและประสาท พ.ศ. ๒๕๕๙</div>
            <br />
            <table style="width:100%;font-size:20px">
                <tr>
                    <td colspan="7">
                        <strong>
                            ๔. ข้อมูลสถานที่เก็บ (กรณีเป็นสถานที่คนละแห่งกับสถานที่ตาม ๓)
                        </strong>
                    </td>
                </tr>
                <tr>
                    <td style="width:17%">
                        ณ สถานที่ชื่อ
                    </td>
                    <td colspan="4" style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_KEEP.KEEP_THANAMEPLACE}}</label>
                    </td>
                    <td style="width:15%">
                        เลขรหัสประจำบ้าน
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_KEEP.HOUSENO}}</label>
                    </td>
                </tr>
                <tr>
                    <td>
                        อยู่เลขที่
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_KEEP.KEEP_FULL_ADDR}}</label>
                    </td>
                </tr>
                <tr>
                    <td>
                        โทรศัพท์ / มือถือ
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_KEEP.KEEP_TEL}}</label>
                    </td>
                </tr>
            </table>
            @*<input type="button" style="font-size:20px;width:100px" value="เพิ่ม" />*@
            @*<input type="button" style="font-size:20px;width:100px;margin-left:10px" value="ลบ" />*@
            <br />
            <br />

            <div style="font-size:20px"><strong>๕. พร้อมกับคำขอนี้ข้าพเจ้าได้แนบเอกสารหรือหลักฐานต่างๆ มาด้วย คือ</strong></div>
            <div style="margin-left:5%;font-size:20px"><strong>๕.๑ <u>กรณีขอรับใบอนุญาต (กรณีรายใหม่)</u></strong></div>
            <table style="width:90%;font-size:20px ;margin-left:10%">
                <tr>
                    <td>
                        (๑) สำเนาใบอนุญาตขายยาแผนปัจจุบันตามกฎหมายว่าด้วยยา
                    </td>
                </tr>
                <tr>
                    <td>
                        (๒) คำรับรองของผู้รับอนุญาตและเภสัชกรผู้ควบคุมกิจการ
                    </td>
                </tr>
                <tr>
                    <td>
                        (๓) รูปถ่ายหน้าตรง ไม่สวมหมวกและแว่นตาสีเข้ม ของผู้ขอรับใบอนุญาตหรือผู้ได้รับมอบหมายหรือแต่งตั้ง
                    </td>
                </tr>
                <tr>
                    <td>
                        ให้ดำเนินกิจการเกี่ยวกับใบอนุญาต ขนาด ๑ นิ้ว จำนวน ๓ รูป ซึ่งถ่ายไว้ไม่เกิน ๖ เดือนก่อนวันยื่นคำขอ
                    </td>
                </tr>
                <tr>
                    <td>
                        (๔) สำเนาใบอนุญาตประกอบวิชาชีพเภสัชกรรม
                    </td>
                </tr>
                <tr>
                    <td>
                        (๕) หนังสือแต่งตั้งผู้ดำเนินกิจการ กรณีผู้ขอรับใบอนุญาตเป็นนิติบุคคล
                    </td>
                </tr>
                <tr>
                    <td>
                        (๖) แผนที่แสดงที่ตั้งและแผนผังแสดงที่ผลิตหรือเก็บซึ่งวัตถุออกฤทธิ์ในประเภท ๓ หรือประเภท ๔ ของสถานประกอบการ
                    </td>
                </tr>
                <tr>
                    <td>
                        (๗) รูปถ่ายแสดงที่ผลิตหรือเก็บซึ่งวัตถุออกฤทธิ์ในประเภท ๓ หรือประเภท ๔ ของสถานประกอบการจำำนวน ๑ รูป
                    </td>
                </tr>
            </table>

            <div style="margin-left:5%;font-size:20px"><strong>๕.๒ <u>กรณีขอต่ออายุใบอนุญาต</u></strong></div>
            <table style="width:90%;font-size:20px ;margin-left:10%">
                <tr>
                    <td>
                        (๑) ใบอนุญาตฉบับเดิม
                    </td>
                </tr>
                <tr>
                    <td>
                        (๒) รูปถ่ายหน้าตรง ไม่สวมหมวกและแว่นตาสีเข้ม ของผู้ขอรับใบอนุญาตหรือผู้ได้รับมอบหมายหรือแต่งตั้งให้ดำเนินกิจการ
                        เกี่ยวกับใบอนุญาต ขนาด ๑ นิ้ว จำนวน ๓ รูป ซึ่งถ่ายไว้ไม่เกิน ๖ เดือนก่อนวันยื่นคำขอ
                    </td>
                </tr>

            </table>
            <div style="margin-left:5%;font-size:20px"><strong>๕.๓ <u>กรณีขอรับใบแทนใบอนุญาต</u></strong></div>
            <table style="width:90%;font-size:20px ;margin-left:10%">
                <tr>
                    <td>
                        (๑) ใบแจ้งความ กรณีใบอนุญาตสูญหาย
                    </td>
                </tr>
                <tr>
                    <td>
                        (๒) ใบอนุญาต กรณีใบอนุญาตดังกล่าวถูกทำลายบางส่วนหรือลบเลือนในสาระสำคัญ
                    </td>
                </tr>
                <tr>
                    <td>
                        (๓) รูปถ่ายหน้าตรง ไม่สวมหมวกและแว่นตาสีเข้ม ของผู้ขอรับใบอนุญาตหรือผู้ได้รับมอบหมายหรือแต่งตั้งให้ดำเนินกิจการเกี่ยวกับ
                        ใบอนุญาต ขนาด ๑ นิ้ว จำนวน ๓ รูป ซึ่งถ่ายไว้ไม่เกิน ๖ เดือนก่อนวันยื่นคำขอ
                    </td>
                </tr>

            </table>
            <div style="margin-left:5%;font-size:20px;text-align:center"><strong>ข้าพเจ้าขอรับรองว่า ข้อความและเอกสารหรือหลักฐานทั้งหมดที่ยื่นเพื่อประกอบคำขอรับใบอนุญาตเป็นความจริงทุกประการ</strong></div>
            <br />
            <br />

            <table style="width:85%;font-size:20px ;margin-left:12.5%">
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
                        <label>{{LIST_LCN.BSN_THAIFULLNAME}}</label>
                    </td>
                    <td style="text-align:left">
                        )
                    </td>
                </tr>
            </table>
            <br />
            <div>
                <h2 style="font-family:'Taviraj';font-size:20px;">
                    ไฟล์แนบ
                </h2>
                <table class="table" style="width:100%">
                    <tr>
                        <td>ชื่อไฟล์</td>
                        <td></td>
                    </tr>
                    <tr ng-repeat="datas in LIST_File.FILE_LISTs" style="background-color:#FDFCE3">
                        <td>{{datas.FILENAME}}</td>
                        <td>
                            <a ng-show="datas.PATH != null && datas.PATH != ''" ng-click="OPEN_DOC_PATH(datas.PATH,datas.FILENAME)">ดูเอกสาร</a>
                        </td>
                    </tr>
                </table>
            </div>
            <br />
            <br />

            <div style="margin-left:5%;font-size:20px"> หมายเหตุ : (๑) ให้ขีดเลือกข้อความในช่อง ☐/〇 ให้ตรงตามที่ประสงค์จะดำเนินการ</div>
            <table style="width:90%;font-size:20px ;margin-left:12.5%">
                <tr>
                    <td>
                        (๒) รับรองสำเนาถูกต้องในเอกสารที่เป็นสำเนาทุกฉบับ
                    </td>
                </tr>
                <tr>
                    <td>
                        (๓) กรณีเอกสารหรือหลักฐานที่ออกโดยสำนักงานคณะกรรมการอาหารและยา ผู้อนุญาตอาจไม่ขอเอกสารหรือหลักฐานดังกล่าวได้
                    </td>
                </tr>

            </table>

        </div>
    </div>

    <div ng-show="LIST_LCN.PROCESS == '100769'">
        <div style="font-family:'Taviraj';font-size:24px;">

            <h1 style="text-align:left;font-size:24px;">
                <strong>แบบ ผ.ว.จ. ๓/๔-๑</strong>
            </h1>
            <br />
            <div class="title1">
                <label style="font-size:16px;margin-top:25px">
                    ที่ปิดรูปถ่าย<br />
                    ผู้ขออนุญาติ<br />
                    หรือ<br />
                    ผู้ดำเนินกิจการ<br />
                    ขนาด ๓ นิ้ว<br />
                </label>
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
                        <td style="text-align:left">
                            ลงชื่่อ

                        </td>

                        <td style="border-bottom:dotted;border-bottom-width:thin;"></td>
                        <td style="text-align:right;width:25%">
                            ผู้รับคำขอ
                        </td>
                    </tr>
                </table>

            </div>


            <div style="clear:both"></div>
            <br />
            <br />

            <h2 style="text-align:center;font-size:24px;">
                <strong>คำขอรับใบอนุญาต คำขอต่ออายุใบอนุญาต คำขอรับใบแทน</strong><br />
                <strong>ใบอนุญาตผลิตวัตถุออกฤทธิ์ในประเภท ๓ หรือประเภท ๔</strong>
            </h2>
            @*process =1107,1108 *@
            <table style="width:70%; font-size:20px;margin:auto;text-align:center">
                <tr>
                    <td>
                        <strong>สำหรับผลิต</strong>
                    </td>
                    <td>
                        <input type="radio" name="gender" ng-model="LIST_LCN.PROCESS" ng-value="100768" id="rdl_CHK_SELL_TYPE" disabled="disabled" /> <strong>วัตถุออกฤทธิ์ในประเภท ๓</strong>
                    </td>
                    <td>
                        <input type="radio" name="gender" ng-model="LIST_LCN.PROCESS" ng-value="100769" id="rdl_CHK_SELL_TYPE" disabled="disabled" /> <strong>วัตถุออกฤทธิ์ในประเภท ๔</strong>
                    </td>
                </tr>
                <tr>
                    <td style="font-size:16px" colspan="3">
                        <strong>(คำขอ ๑ ฉบับ ให้ยื่นขอได้เพียงหนึ่งประเภทเท่านั้น)</strong>
                    </td>
                </tr>
            </table>

            <table style="width:100%; font-size:20px">
                <tr>
                    <td style="width:20%">
                        <input type="checkbox" name="gender" disabled="disabled" /> <strong>ขอรับใบอนุญาต</strong>
                    </td>
                </tr>
                <tr>
                    <td>
                        <input type="checkbox" name="gender" disabled="disabled" /> <strong>ขอต่ออายุใบอนุญาตเลขที่</strong>
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;"></td>
                    <td style="width:10%">
                        <strong>ประจำปี พ.ศ.</strong>
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;"></td>
                </tr>
                <tr>
                    <td>
                        <input type="checkbox" name="gender" disabled="disabled" ng-checked="true" /> <strong>ขอรับใบแทนใบอนุญาต</strong>
                    </td>
                    <td>
                        เนื่องจากใบอนุญาต
                    </td>
                    <td colspan="2">

                        <form name="frm_lost_type">


                            <label><input type="radio" ng-model="LIST_LCN.DALCN_NCT_SUBSTITUTE.PURPOSE_ID" id="rdl_lost_type" value="1"> สูญหาย</label>
                            <label><input type="radio" ng-model="LIST_LCN.DALCN_NCT_SUBSTITUTE.PURPOSE_ID" id="rdl_lost_type" value="2"> ถูกทำลายหรือลบเลือนในสาระสำคัญ</label><br />

                        </form>



                    </td>

                </tr>
            </table>
            <br />

            <table style="width:100%">
                <tr>
                    <td style="text-align:right;width:90%">
                        เขียนที่
                    </td>
                    <td style="width:40%;border-bottom:dotted;border-bottom-width:thin;">

                        {{LIST_LCN.DALCN_NCT_SUBSTITUTE.WRITE_AT}}
                    </td>
                </tr>
                <tr>
                    <td style="text-align:right;width:100px">
                        วันที่
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;">

                        {{LIST_LCN.DALCN_NCT_SUBTITUTE.WRITE_DATE}}
                    </td>
                </tr>
            </table>
            <br />

            <h2 style="font-size:24px;">
                <strong>๑. ข้อมูลผู้ขอรับใบอนุญาต</strong>
            </h2>
            <table style="width:90%">
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
            <table style="width:90%">
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
                    <td style="text-align:left;width:30%;border-bottom:dotted;border-bottom-width:thin;">
                        @*<form action="javascript:void(0)">
                                <table>
                                    <tr>
                                        <td>
                                            <input class="form-control inline" ng-model="LIST_LCN.BSN_IDENTIFY" id="txt_bsn_identify" style="font-family:'TH SarabunPSK';" type="text" />
                                            {{LIST_LCN.BSN_IDENTIFY}}
                                        </td>
                                        <td>
                                                <input type="button" value="ค้นหาผู้ดำเนินฯ" ng-click="BTN_Search_BSN(LIST_LCN.BSN_IDENTIFY)" />
                                            </td>
                                    </tr>
                                </table>


                            </form>*@
                        <label>{{LIST_LCN.BSN_THAIFULLNAME}}</label>
                    </td>
                </tr>
                <tr>
                    <td style="font-size:20px">
                        หรือบัตรประจำตัวอื่นที่ทางราชการออกให้ คือ
                    </td>
                    <td style="font-size:20px;width:20%;border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_LCN.BSN_IDENTIFY}}</label>
                    </td>
                    <td style="font-size:20px;width:5%">
                        เลขที่
                    </td>
                    <td style="font-size:20px ;width:15%;text-align:center;border-bottom:dotted;border-bottom-width:thin"></td>
                    <td style="font-size:20px">
                        (กรณีไม่ใช่ผู้มีสัญชาติไทย)
                    </td>
                </tr>
                <tr>
                    <td style="font-size:20px">
                        หรือทะเบียนนิติบุคคล/บัตรประจำตัวผู้เสียภาษี เลขที่
                    </td>
                    <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_LCN.BSN_IDENTIFY}}</label>
                    </td>
                </tr>
                <tr>
                    <td style="font-size:20px">
                        เลขรหัสประจำบ้าน
                    </td>
                    <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_LCN.BSN_HOUSENO}}</label>
                    </td>
                </tr>
                <tr>
                    <td style="font-size:20px">
                        อยู่เลขที่
                    </td>
                    <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_LCN.BSN_FULL_ADDR}}</label>
                    </td>
                </tr>
                <tr>
                    <td style="font-size:20px">
                        โทรศัพท์/มือถือ
                    </td>
                    <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_LCN.BSN_TELEPHONE}}</label>
                    </td>
                </tr>
                <tr>
                    <td style="font-size:20px">
                        E-mail
                    </td>
                    <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_LCN.dalcn.Email}}</label>
                    </td>
                </tr>
            </table>

            <div style="font-size:20px"><strong>๓. ข้อมูลสถานที่ผลิต</strong></div>
            <table style="width:100%;font-size:20px">
                <tr>
                    <td>
                        ณ สถานที่ชื่อ
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_LCN.THANAMEPLACE}}</label>
                    </td>
                    <td>
                        เลขรหัสประจำบ้าน
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_LCN.HOUSENO}}</label>
                    </td>
                </tr>
                <tr>
                    <td>
                        ตั้งอยู่เลขที่
                    </td>
                    <td colspan="3" style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_LCN.fulladdr3}}</label>
                    </td>
                </tr>
                <tr>
                    <td>
                        โทรศัพท์/มือถือ
                    </td>
                    <td colspan="3" style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_LCN.tel}}</label>
                    </td>
                </tr>
            </table>

            <table style="width:100%;font-size:20px">
                <tr>
                    <td style="width:25%">
                        มีความประสงค์ขอรับอนุญาตผลิตวัตถุออกฤทธิ์ในหมวด
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin" colspan="3">
                        @*<input class="form-control inline" ng-model="LIST_LCN.dalcn.CATEGORY_DRUG" style="font-family:'Taviraj';font-size:20px;" type="text" />*@
                        {{LIST_LCN.dalcn.CATEGORY_DRUG}}
                    </td>
                </tr>
                <tr>
                    <td>
                        โดยได้รับอนุญาตให้ผลิตยาแผนปัจจุบันเลขที่
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_LCN.HEAD_LCNNO_NCT}}</label>
                    </td>
                    <td style="width:25%">
                        ตามกฎหมายว่าด้วยยา ในหมวดที่ตรงกับคำขออนุญาต
                    </td>
                </tr>
                <tr>
                    <td colspan="3">
                        ผลิตวัตถุออกฤทธิ์ตามคำขอนี้
                    </td>
                </tr>
            </table>


            <table style="width:100%;font-size:20px" ng-init="getdetails_phr()">
                <tr>
                    <td style="width:15%;">
                        โดยมีเภสัชกรชื่อ  1.
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;width:15%;">
                        <label>{{LIST_PHR.PHR_NAME}}</label>
                    </td>
                    <td style="width:15%">
                        ใบอนุญาตประกอบวิชาชีพเภสัชกรรมเลขที่
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_PHR.PHR_TEXT_NUM}}</label>
                    </td>
                </tr>
            </table>
            @*<input type="button" style="font-size:20px;width:100px" value="เพิ่ม" />*@
            @*<input type="button" style="font-size:20px;width:100px;margin-left:10px" value="ลบ" />*@
            <div style="font-size:20px">เป็นผู้ควบคุมตามมาตรา ๕๓ แห่งพระราชบัญญัติวัตถุที่ออกฤทธิ์ต่อจิตและประสาท พ.ศ. ๒๕๕๙</div>
            <br />
            <table style="width:100%;font-size:20px">
                <tr>
                    <td colspan="7">
                        <strong>
                            ๔. ข้อมูลสถานที่เก็บ (กรณีเป็นสถานที่คนละแห่งกับสถานที่ตาม ๓)
                        </strong>
                    </td>
                </tr>
                <tr>
                    <td style="width:17%">
                        ณ สถานที่ชื่อ
                    </td>
                    <td colspan="4" style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_KEEP.KEEP_THANAMEPLACE}}</label>
                    </td>
                    <td style="width:15%">
                        เลขรหัสประจำบ้าน
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_KEEP.HOUSENO}}</label>
                    </td>
                </tr>
                <tr>
                    <td>
                        อยู่เลขที่
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_KEEP.KEEP_FULL_ADDR}}</label>
                    </td>
                </tr>
                <tr>
                    <td>
                        โทรศัพท์ / มือถือ
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_KEEP.KEEP_TEL}}</label>
                    </td>
                </tr>
            </table>
            @*<input type="button" style="font-size:20px;width:100px" value="เพิ่ม" />*@
            @*<input type="button" style="font-size:20px;width:100px;margin-left:10px" value="ลบ" />*@
            <br />
            <br />

            <div style="font-size:20px"><strong>๕. พร้อมกับคำขอนี้ข้าพเจ้าได้แนบเอกสารหรือหลักฐานต่างๆ มาด้วย คือ</strong></div>
            <div style="margin-left:5%;font-size:20px"><strong>๕.๑ <u>กรณีขอรับใบอนุญาต (กรณีรายใหม่)</u></strong></div>
            <table style="width:90%;font-size:20px ;margin-left:10%">
                <tr>
                    <td>
                        (๑) สำเนาใบอนุญาตขายยาแผนปัจจุบันตามกฎหมายว่าด้วยยา
                    </td>
                </tr>
                <tr>
                    <td>
                        (๒) คำรับรองของผู้รับอนุญาตและเภสัชกรผู้ควบคุมกิจการ
                    </td>
                </tr>
                <tr>
                    <td>
                        (๓) รูปถ่ายหน้าตรง ไม่สวมหมวกและแว่นตาสีเข้ม ของผู้ขอรับใบอนุญาตหรือผู้ได้รับมอบหมายหรือแต่งตั้ง
                    </td>
                </tr>
                <tr>
                    <td>
                        ให้ดำเนินกิจการเกี่ยวกับใบอนุญาต ขนาด ๑ นิ้ว จำนวน ๓ รูป ซึ่งถ่ายไว้ไม่เกิน ๖ เดือนก่อนวันยื่นคำขอ
                    </td>
                </tr>
                <tr>
                    <td>
                        (๔) สำเนาใบอนุญาตประกอบวิชาชีพเภสัชกรรม
                    </td>
                </tr>
                <tr>
                    <td>
                        (๕) หนังสือแต่งตั้งผู้ดำเนินกิจการ กรณีผู้ขอรับใบอนุญาตเป็นนิติบุคคล
                    </td>
                </tr>
                <tr>
                    <td>
                        (๖) แผนที่แสดงที่ตั้งและแผนผังแสดงที่ผลิตหรือเก็บซึ่งวัตถุออกฤทธิ์ในประเภท ๓ หรือประเภท ๔ ของสถานประกอบการ
                    </td>
                </tr>
                <tr>
                    <td>
                        (๗) รูปถ่ายแสดงที่ผลิตหรือเก็บซึ่งวัตถุออกฤทธิ์ในประเภท ๓ หรือประเภท ๔ ของสถานประกอบการจำำนวน ๑ รูป
                    </td>
                </tr>
            </table>

            <div style="margin-left:5%;font-size:20px"><strong>๕.๒ <u>กรณีขอต่ออายุใบอนุญาต</u></strong></div>
            <table style="width:90%;font-size:20px ;margin-left:10%">
                <tr>
                    <td>
                        (๑) ใบอนุญาตฉบับเดิม
                    </td>
                </tr>
                <tr>
                    <td>
                        (๒) รูปถ่ายหน้าตรง ไม่สวมหมวกและแว่นตาสีเข้ม ของผู้ขอรับใบอนุญาตหรือผู้ได้รับมอบหมายหรือแต่งตั้งให้ดำเนินกิจการ
                        เกี่ยวกับใบอนุญาต ขนาด ๑ นิ้ว จำนวน ๓ รูป ซึ่งถ่ายไว้ไม่เกิน ๖ เดือนก่อนวันยื่นคำขอ
                    </td>
                </tr>

            </table>
            <div style="margin-left:5%;font-size:20px"><strong>๕.๓ <u>กรณีขอรับใบแทนใบอนุญาต</u></strong></div>
            <table style="width:90%;font-size:20px ;margin-left:10%">
                <tr>
                    <td>
                        (๑) ใบแจ้งความ กรณีใบอนุญาตสูญหาย
                    </td>
                </tr>
                <tr>
                    <td>
                        (๒) ใบอนุญาต กรณีใบอนุญาตดังกล่าวถูกทำลายบางส่วนหรือลบเลือนในสาระสำคัญ
                    </td>
                </tr>
                <tr>
                    <td>
                        (๓) รูปถ่ายหน้าตรง ไม่สวมหมวกและแว่นตาสีเข้ม ของผู้ขอรับใบอนุญาตหรือผู้ได้รับมอบหมายหรือแต่งตั้งให้ดำเนินกิจการเกี่ยวกับ
                        ใบอนุญาต ขนาด ๑ นิ้ว จำนวน ๓ รูป ซึ่งถ่ายไว้ไม่เกิน ๖ เดือนก่อนวันยื่นคำขอ
                    </td>
                </tr>

            </table>
            <div style="margin-left:5%;font-size:20px;text-align:center"><strong>ข้าพเจ้าขอรับรองว่า ข้อความและเอกสารหรือหลักฐานทั้งหมดที่ยื่นเพื่อประกอบคำขอรับใบอนุญาตเป็นความจริงทุกประการ</strong></div>
            <br />
            <br />

            <table style="width:85%;font-size:20px ;margin-left:12.5%">
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
                        <label>{{LIST_LCN.BSN_THAIFULLNAME}}</label>
                    </td>
                    <td style="text-align:left">
                        )
                    </td>
                </tr>
            </table>
            <br />
            <div>
                <h2 style="font-family:'Taviraj';font-size:20px;">
                    ไฟล์แนบ
                </h2>
                <table class="table" style="width:100%">
                    <tr>
                        <td>ชื่อไฟล์</td>
                        <td></td>
                    </tr>
                    <tr ng-repeat="datas in LIST_File.FILE_LISTs" style="background-color:#FDFCE3">
                        <td>{{datas.FILENAME}}</td>
                        <td>
                            <a ng-show="datas.PATH != null && datas.PATH != ''" ng-click="OPEN_DOC_PATH(datas.PATH,datas.FILENAME)">ดูเอกสาร</a>
                        </td>
                    </tr>
                </table>
            </div>
            <br />
            <br />

            <div style="margin-left:5%;font-size:20px"> หมายเหตุ : (๑) ให้ขีดเลือกข้อความในช่อง ☐/〇 ให้ตรงตามที่ประสงค์จะดำเนินการ</div>
            <table style="width:90%;font-size:20px ;margin-left:12.5%">
                <tr>
                    <td>
                        (๒) รับรองสำเนาถูกต้องในเอกสารที่เป็นสำเนาทุกฉบับ
                    </td>
                </tr>
                <tr>
                    <td>
                        (๓) กรณีเอกสารหรือหลักฐานที่ออกโดยสำนักงานคณะกรรมการอาหารและยา ผู้อนุญาตอาจไม่ขอเอกสารหรือหลักฐานดังกล่าวได้
                    </td>
                </tr>

            </table>

        </div>
    </div>

    <div ng-show="LIST_LCN.PROCESS == '100770'">
        <div style="font-family:'Taviraj';font-size:24px;">
            <h1 style="text-align:left;font-size:24px;">
                <strong>แบบ น.ว.จ. ๓/๔-๑</strong>
            </h1>
            <br />
            <div class="title1">
                <label style="font-size:16px;margin-top:25px">
                    ที่ปิดรูปถ่าย<br />
                    ผู้ขออนุญาติ<br />
                    หรือ<br />
                    ผู้ดำเนินกิจการ<br />
                    ขนาด ๓ x ๔ ซม.<br />
                </label>
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
                        <td style="text-align:left">
                            ลงชื่่อ

                        </td>

                        <td style="border-bottom:dotted;border-bottom-width:thin;"></td>
                        <td style="text-align:right;width:25%">
                            ผู้รับคำขอ
                        </td>
                    </tr>
                </table>

            </div>


            <div style="clear:both"></div>
            <br />
            <br />
            @*process =131,132 *@
            <h2 style="text-align:center;font-size:24px;">
                <strong>คำขอรับใบอนุญาต คำขอต่ออายุใบอนุญาต คำขอรับใบแทน</strong><br />
                <strong>ใบอนุญาตนำเข้าวัตถุออกฤทธิ์ในประเภท ๓ หรือประเภท ๔</strong>
            </h2>
            <table style="width:70%; font-size:20px;margin:auto;text-align:center">
                <tr>
                    <td>
                        <strong>สำหรับนำเข้า</strong>
                    </td>
                    <td>
                        <input type="radio" name="gender" ng-model="LIST_LCN.PROCESS" ng-value="100770" id="rdl_CHK_SELL_TYPE" disabled="disabled" /> <strong>วัตถุออกฤทธิ์ในประเภท ๓</strong>
                    </td>
                    <td>
                        <input type="radio" name="gender" ng-model="LIST_LCN.PROCESS" ng-value="100771" id="rdl_CHK_SELL_TYPE" disabled="disabled" /> <strong>วัตถุออกฤทธิ์ในประเภท ๔</strong>
                    </td>
                </tr>
                <tr>
                    <td style="font-size:16px" colspan="3">
                        <strong>(คำขอ ๑ ฉบับ ให้ยื่นขอได้เพียงหนึ่งประเภทเท่านั้น)</strong>
                    </td>
                </tr>
            </table>

            <table style="width:100%; font-size:20px">
                <tr>
                    <td style="width:20%">
                        <input type="checkbox" name="gender" disabled="disabled" /> <strong>ขอรับใบอนุญาต</strong>
                    </td>
                </tr>
                <tr>
                    <td>
                        <input type="checkbox" name="gender" disabled="disabled" /> <strong>ขอต่ออายุใบอนุญาตเลขที่</strong>
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;"></td>
                    <td style="width:10%">
                        <strong>ประจำปี พ.ศ.</strong>
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;"></td>
                </tr>
                <tr>
                    <td>
                        <input type="checkbox" name="gender" disabled="disabled" ng-checked="true" /> <strong>ขอรับใบแทนใบอนุญาต</strong>
                    </td>
                    <td>
                        เนื่องจากใบอนุญาต
                    </td>
                    <td colspan="2">

                        <form name="frm_lost_type">


                            <label><input type="radio" ng-model="LIST_LCN.DALCN_NCT_SUBSTITUTE.PURPOSE_ID" id="rdl_lost_type" value="1"> สูญหาย</label>
                            <label><input type="radio" ng-model="LIST_LCN.DALCN_NCT_SUBSTITUTE.PURPOSE_ID" id="rdl_lost_type" value="2"> ถูกทำลายหรือลบเลือนในสาระสำคัญ</label><br />

                        </form>



                    </td>

                </tr>
            </table>
            <br />

            <table style="width:100%">
                <tr>
                    <td style="text-align:right;width:90%">
                        เขียนที่
                    </td>
                    <td style="width:40%;border-bottom:dotted;border-bottom-width:thin;">

                        {{LIST_LCN.DALCN_NCT_SUBSTITUTE.WRITE_AT}}
                    </td>
                </tr>
                <tr>
                    <td style="text-align:right;width:100px">
                        วันที่
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;">

                        {{LIST_LCN.DALCN_NCT_SUBTITUTE.WRITE_DATE}}
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
                    <td style="text-align:left;width:30%;border-bottom:dotted;border-bottom-width:thin;">
                        @*<form action="javascript:void(0)">
                                <table>
                                    <tr>
                                        <td>
                                            <input class="form-control inline" ng-model="LIST_LCN.BSN_IDENTIFY" id="txt_bsn_identify" style="font-family:'Taviraj';" type="text" />
                                        </td>
                                        <td>
                                            <input type="button" value="ค้นหาผู้ดำเนินฯ" ng-click="BTN_Search_BSN(LIST_LCN.BSN_IDENTIFY)" />
                                        </td>
                                    </tr>
                                </table>


                            </form>*@
                        <label>{{LIST_LCN.BSN_THAIFULLNAME}}</label>
                    </td>
                </tr>
                <tr>
                    <td style="font-size:20px">
                        หรือบัตรประจำตัวอื่นที่ทางราชการออกให้ คือ
                    </td>
                    <td style="font-size:20px;width:20%;border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_LCN.BSN_IDENTIFY}}</label>
                    </td>
                    <td style="font-size:20px;width:5%">
                        เลขที่
                    </td>
                    <td style="font-size:20px ;width:15%;text-align:center;border-bottom:dotted;border-bottom-width:thin"></td>
                    <td style="font-size:20px">
                        (กรณีไม่ใช่ผู้มีสัญชาติไทย)
                    </td>
                </tr>
                <tr>
                    <td style="font-size:20px">
                        หรือทะเบียนนิติบุคคล/บัตรประจำตัวผู้เสียภาษี เลขที่
                    </td>
                    <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_LCN.BSN_IDENTIFY}}</label>
                    </td>
                </tr>
                <tr>
                    <td style="font-size:20px">
                        เลขรหัสประจำบ้าน
                    </td>
                    <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_LCN.BSN_HOUSENO}}</label>
                    </td>
                </tr>
                <tr>
                    <td style="font-size:20px">
                        อยู่เลขที่
                    </td>
                    <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_LCN.BSN_FULL_ADDR}}</label>
                    </td>
                </tr>
                <tr>
                    <td style="font-size:20px">
                        โทรศัพท์/มือถือ
                    </td>
                    <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_LCN.BSN_TELEPHONE}}</label>
                    </td>
                </tr>
                <tr>
                    <td style="font-size:20px">
                        E-mail
                    </td>
                    <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_LCN.dalcn.Email}}</label>
                    </td>
                </tr>
                <tr>
                    <td style="font-size:20px" colspan="2">
                        โดยได้รับอนุญาตนำสั่งยาแผนปัจจุบันเข้ามาในราชอาณาจักร เลขที่
                    </td>
                    <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;" colspan="2">
                        <label>{{LIST_LCN.HEAD_LCNNO_NCT}}</label>
                    </td>
                    <td style="font-size:20px">
                        ตามกฎหมายว่าด้วยยา
                    </td>
                </tr>
            </table>

            <table style="width:90%;font-size:20px">
                <tr>
                    <td colspan="2">
                        <p style="margin-left:5%">มีความประสงค์ขอรับอนุญาตนำเข้าวัตถุออกฤทธิ์ในประเภท ๓ หรือประเภท ๔ เนื่องจาก</p>
                    </td>
                </tr>
                <tr>
                    <td>
                        <form name="rdl_gmp">

                            <label>
                                <input type="checkbox" ng-model="LIST_LCN.dalcn.syslctaddr_thaaddr" id="chbl_typeee" value="1">
                                นำเข้ามาเป็นวัตถุดิบเพื่อจำหน่าย
                            </label>
                            <label>
                                <input type="checkbox" ng-model="LIST_LCN.dalcn.syslctaddr_engaddr" id="chbl_typeee" ng-value="1">
                                นำเข้ามาเป็นวัตถุดิบเพื่อผลิตวัตถุตำรับ
                            </label>
                        </form>
                    </td>
                </tr>
                <tr>
                    <td>
                        <form name="rdl_gmp">
                            <label>
                                <input type="checkbox" ng-model="LIST_LCN.dalcn.syslctaddr_room" id="chbl_typeee" value="1">
                                นำเข้ามาเป็นผลิตภัณฑ์สำเร็จรูปเพื่อจำหน่าย
                            </label>
                            <label>
                                <input type="checkbox" ng-model="LIST_LCN.dalcn.syslctaddr_engsoi" id="chbl_typeee" ng-value="1">
                                นำเข้ามาเป็นผลิตภัณฑ์สำเร็จรูปเพื่อส่งออก
                            </label>
                        </form>
                    </td>
                </tr>
                <tr>
                    <td>
                        <form name="rdl_gmp">
                            <label>
                                <input type="checkbox" ng-model="LIST_LCN.dalcn.syslctaddr_floor" id="chbl_typeee" value="1">
                                อื่นๆ (โปรดระบุ)
                            </label>
                            @*<input type="text" ng-model="LIST_LCN.dalcn.syslctaddr_thasoi" id="chbl_typeee" ng-value="1">*@
                            {{LIST_LCN.dalcn.syslctaddr_thasoi}}
                        </form>
                    </td>
                </tr>
            </table>
            <br />

            <table style="width:100%;font-size:20px">
                <tr>
                    <td colspan="4">
                        ๓. ข้อมูลสถานที่นำเข้า
                    </td>
                </tr>
                <tr>
                    <td>
                        ณ สถานที่ชื่อ
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_LCN.THANAMEPLACE}}</label>
                    </td>
                    <td>
                        เลขรหัสประจำบ้าน
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_LCN.HOUSENO}}</label>
                    </td>
                </tr>
                <tr>
                    <td>
                        ตั้งอยู่เลขที่
                    </td>
                    <td colspan="3" style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_LCN.fulladdr3}}</label>
                    </td>
                </tr>
                <tr>
                    <td>
                        โทรศัพท์/มือถือ
                    </td>
                    <td colspan="3" style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_LCN.tel}}</label>
                    </td>
                </tr>

            </table>

            <table style="width:100%;font-size:20px" ng-init="getdetails_phr()">
                <tr>
                    <td style="width:15%;">
                        โดยมีเภสัชกรชื่อ  1.
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;width:15%;">
                        <label>{{LIST_PHR.PHR_NAME}}</label>
                    </td>
                    <td style="width:15%">
                        ใบอนุญาตประกอบวิชาชีพเภสัชกรรมเลขที่
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_PHR.PHR_TEXT_NUM}}</label>
                    </td>
                </tr>
            </table>
            <br />
            @*<input type="button" style="font-size:20px;width:100px" value="เพิ่ม" />*@
            @*<input type="button" style="font-size:20px;width:100px;margin-left:10px" value="ลบ" />*@
            <br />
            <div style="margin-left:5%;font-size:20px">เป็นผู้ควบคุมตามมาตรา ๕๓ แห่งพระราชบัญญัติวัตถุที่ออกฤทธิ์ต่อจิตและประสาท พ.ศ. ๒๕๕๙</div>
            <br />

            <table style="width:100%;font-size:20px">
                <tr>
                    <td colspan="7">
                        <p>
                            <strong>
                                ๔. ข้อมูลสถานที่เก็บ (กรณีเป็นสถานที่คนละแห่งกับสถานที่ตาม ๓)
                            </strong>
                        </p>
                    </td>
                </tr>
                <tr>
                    <td style="width:17%">
                        ณ สถานที่ชื่อ
                    </td>
                    <td colspan="4" style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_KEEP.KEEP_THANAMEPLACE}}</label>
                    </td>
                    <td style="width:15%">
                        เลขรหัสประจำบ้าน
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_KEEP.HOUSENO}}</label>
                    </td>
                </tr>
                <tr>
                    <td>
                        อยู่เลขที่
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_KEEP.KEEP_FULL_ADDR}}</label>
                    </td>
                </tr>
                <tr>
                    <td>
                        โทรศัพท์ / มือถือ
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_KEEP.KEEP_TEL}}</label>
                    </td>
                </tr>

            </table>
            <table style="width:100%;font-size:20px">
                <tr>
                    <td style="width:50%">
                        โดยได้รับอนุญาตนำสั่งยาแผนปัจจุบันเข้ามาในราชอาณาจักร เลขที่
                    </td>
                    <td style="width:30%;border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_LCN.HEAD_LCNNO_NCT}}</label>
                    </td>
                    <td>
                        ตามกฎหมายว่าด้วยยา
                    </td>
                </tr>
            </table>
            <br />
            @*<input type="button" style="font-size:20px;width:100px" value="เพิ่ม" />*@
            @*<input type="button" style="font-size:20px;width:100px;margin-left:10px" value="ลบ" />*@
            <br />
            <div style="margin-left:5%;font-size:20px">เป็นผู้ควบคุมตามมาตรา ๕๓ แห่งพระราชบัญญัติวัตถุที่ออกฤทธิ์ต่อจิตและประสาท พ.ศ. ๒๕๕๙</div>
            <br />

            <div style="font-size:20px"><strong>๕. พร้อมกับคำขอนี้ข้าพเจ้าได้แนบเอกสารหรือหลักฐานต่างๆ มาด้วย คือ</strong></div>
            <div style="margin-left:5%;font-size:20px"><strong>๕.๑ กรณีขอรับใบอนุญาต (กรณีรายใหม่)</strong></div>
            <table style="width:90%;font-size:20px ;margin-left:10%">
                <tr>
                    <td>
                        (๑) คำรับรองของผู้รับอนุญาตและเภสัชกรผู้ควบคุมกิจการ
                    </td>
                </tr>
                <tr>
                    <td>
                        (๒) รูปถ่ายหน้าตรง ไม่สวมหมวกและแว่นตาสีเข้ม ของผู้ขอรับใบอนุญาตหรือผู้ได้รับมอบหมายหรือแต่งตั้งให้ดำเนินกิจการ
                        เกี่ยวกับใบอนุญาต ขนาด ๑ นิ้ว จำนวน ๓ รูป ซึ่งถ่ายไว้ไม่เกิน ๖ เดือนก่อนวันยื่นคำขอ
                    </td>
                </tr>
                <tr>
                    <td>
                        (๓) สำเนาใบอนุญาตประกอบวิชาชีพเภสัชกรรม
                    </td>
                </tr>
                <tr>
                    <td>
                        (๔) หนังสือแต่งตั้งผู้ดำเนินกิจการ กรณีผู้ขอรับใบอนุญาตเป็นนิติบุคคล
                    </td>
                </tr>
                <tr>
                    <td>
                        (๕) แผนที่แสดงที่ตั้งและแผนผังแสดงที่นำเข้าหรือเก็บซึ่งวัตถุออกฤทธิ์ในประเภท ๓ หรือประเภท ๔ ของสถานประกอบการ
                    </td>
                </tr>
                <tr>
                    <td>
                        (๖) รูปถ่ายแสดงที่นำำเข้าหรือเก็บซึ่งวัตถุออกฤทธิ์ในประเภท ๓ หรือประเภท ๔ ของสถานประกอบการจำำนวน ๑ รูป
                    </td>
                </tr>
            </table>
            <div style="margin-left:5%;font-size:20px"><strong>๕.๒ กรณีขอต่ออายุใบอนุญาต</strong></div>
            <table style="width:90%;font-size:20px ;margin-left:10%">
                <tr>
                    <td>
                        (๑) ใบอนุญาตฉบับเดิม
                    </td>
                </tr>
                <tr>
                    <td>
                        (๒) รูปถ่ายหน้าตรง ไม่สวมหมวกและแว่นตาสีเข้ม ของผู้ขอรับใบอนุญาตหรือผู้ได้รับมอบหมายหรือแต่งตั้งให้ดำเนินกิจการ
                        เกี่ยวกับใบอนุญาต ขนาด ๑ นิ้ว จำนวน ๓ รูป ซึ่งถ่ายไว้ไม่เกิน ๖ เดือนก่อนวันยื่นคำขอ
                    </td>
                </tr>

            </table>
            <div style="margin-left:5%;font-size:20px"><strong>๕.๓ กรณีขอรับใบแทนใบอนุญาต</strong></div>
            <table style="width:90%;font-size:20px ;margin-left:10%">
                <tr>
                    <td>
                        (๑) ใบแจ้งความ กรณีใบอนุญาตสูญหาย
                    </td>
                </tr>
                <tr>
                    <td>
                        (๒) ใบอนุญาต กรณีใบอนุญาตดังกล่าวถูกทำลายบางส่วนหรือลบเลือนในสาระสำคัญ
                    </td>
                </tr>
                <tr>
                    <td>
                        (๓) รูปถ่ายหน้าตรง ไม่สวมหมวกและแว่นตาสีเข้ม ของผู้ขอรับใบอนุญาตหรือผู้ได้รับมอบหมายหรือแต่งตั้งให้ดำเนินกิจการเกี่ยวกับ
                        ใบอนุญาต ขนาด ๑ นิ้ว จำนวน ๓ รูป ซึ่งถ่ายไว้ไม่เกิน ๖ เดือนก่อนวันยื่นคำขอ
                    </td>
                </tr>

            </table>
            <div style="margin-left:5%;font-size:20px;text-align:center"><strong>ข้าพเจ้าขอรับรองว่า ข้อความและเอกสารหรือหลักฐานทั้งหมดที่ยื่นเพื่อประกอบคำขอรับใบอนุญาตเป็นความจริงทุกประการ</strong></div>
            <br />
            <div>
                <h2 style="font-family:'Taviraj';font-size:20px;">
                    ไฟล์แนบ
                </h2>
                <table class="table" style="width:100%">
                    <tr>
                        <td>ชื่อไฟล์</td>
                        <td></td>
                    </tr>
                    <tr ng-repeat="datas in LIST_File.FILE_LISTs" style="background-color:#FDFCE3">
                        <td>{{datas.FILENAME}}</td>
                        <td>
                            <a ng-show="datas.PATH != null && datas.PATH != ''" ng-click="OPEN_DOC_PATH(datas.PATH,datas.FILENAME)">ดูเอกสาร</a>
                        </td>
                    </tr>
                </table>
            </div>
            <br />
            <br />

            <table style="width:85%;font-size:20px ;margin-left:12.5%">
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
                        <label>{{LIST_LCN.BSN_THAIFULLNAME}}</label>
                    </td>
                    <td style="text-align:left">
                        )
                    </td>
                </tr>
            </table>
            <br />
            <br />

            <div style="margin-left:5%;font-size:20px"> หมายเหตุ : (๑) ให้ขีดเลือกข้อความในช่อง ☐/〇 ให้ตรงตามที่ประสงค์จะดำเนินการ</div>
            <table style="width:90%;font-size:20px ;margin-left:12.5%">
                <tr>
                    <td>
                        (๒) รับรองสำเนาถูกต้องในเอกสารที่เป็นสำเนาทุกฉบับ
                    </td>
                </tr>
                <tr>
                    <td>
                        (๓) กรณีเอกสารหรือหลักฐานที่ออกโดยสำนักงานคณะกรรมการอาหารและยา ผู้อนุญาตอาจไม่ขอเอกสารหรือหลักฐานดังกล่าวได้
                    </td>
                </tr>

            </table>


        </div>
    </div>

    <div ng-show="LIST_LCN.PROCESS == '100771'">
        <div style="font-family:'Taviraj';font-size:24px;">
            <h1 style="text-align:left;font-size:24px;">
                <strong>แบบ น.ว.จ. ๓/๔-๑</strong>
            </h1>
            <br />
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
                        <td style="text-align:left">
                            ลงชื่่อ

                        </td>

                        <td style="border-bottom:dotted;border-bottom-width:thin;"></td>
                        <td style="text-align:right;width:25%">
                            ผู้รับคำขอ
                        </td>
                    </tr>
                </table>
            </div>
            <div class="title1">
                <label style="font-size:16px;margin-top:25px">
                    ที่ปิดรูปถ่าย<br />
                    ผู้ขออนุญาติ<br />
                    หรือ<br />
                    ผู้ดำเนินกิจการ<br />
                    ขนาด ๓ x ๔ ซม.<br />
                </label>
            </div>

            <div style="clear:both"></div>
            <br />
            <br />
            @*process =131,132 *@
            <h2 style="text-align:center;font-size:24px;">
                <strong>คำขอรับใบอนุญาต คำขอต่ออายุใบอนุญาต คำขอรับใบแทน</strong><br />
                <strong>ใบอนุญาตนำเข้าวัตถุออกฤทธิ์ในประเภท ๓ หรือประเภท ๔</strong>
            </h2>
            <table style="width:70%; font-size:20px;margin:auto;text-align:center">
                <tr>
                    <td>
                        <strong>สำหรับนำเข้า</strong>
                    </td>
                    <td>
                        <input type="radio" name="gender" ng-model="LIST_LCN.PROCESS" ng-value="100770" id="rdl_CHK_SELL_TYPE" disabled="disabled" /> <strong>วัตถุออกฤทธิ์ในประเภท ๓</strong>
                    </td>
                    <td>
                        <input type="radio" name="gender" ng-model="LIST_LCN.PROCESS" ng-value="100771" id="rdl_CHK_SELL_TYPE" disabled="disabled" /> <strong>วัตถุออกฤทธิ์ในประเภท ๔</strong>
                    </td>
                </tr>
                <tr>
                    <td style="font-size:16px" colspan="3">
                        <strong>(คำขอ ๑ ฉบับ ให้ยื่นขอได้เพียงหนึ่งประเภทเท่านั้น)</strong>
                    </td>
                </tr>
            </table>

            <table style="width:100%; font-size:20px">
                <tr>
                    <td style="width:20%">
                        <input type="checkbox" name="gender" disabled="disabled" /> <strong>ขอรับใบอนุญาต</strong>
                    </td>
                </tr>
                <tr>
                    <td>
                        <input type="checkbox" name="gender" disabled="disabled" /> <strong>ขอต่ออายุใบอนุญาตเลขที่</strong>
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;"></td>
                    <td style="width:10%">
                        <strong>ประจำปี พ.ศ.</strong>
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;"></td>
                </tr>
                <tr>
                    <td>
                        <input type="checkbox" name="gender" disabled="disabled" ng-checked="true" /> <strong>ขอรับใบแทนใบอนุญาต</strong>
                    </td>
                    <td>
                        เนื่องจากใบอนุญาต
                    </td>
                    <td colspan="2">

                        <form name="frm_lost_type">


                            <label><input type="radio" ng-model="LIST_LCN.DALCN_NCT_SUBSTITUTE.PURPOSE_ID" id="rdl_lost_type" value="1"> สูญหาย</label>
                            <label><input type="radio" ng-model="LIST_LCN.DALCN_NCT_SUBSTITUTE.PURPOSE_ID" id="rdl_lost_type" value="2"> ถูกทำลายหรือลบเลือนในสาระสำคัญ</label><br />

                        </form>



                    </td>

                </tr>
            </table>
            <br />

            <table style="width:100%">
                <tr>
                    <td style="text-align:right;width:90%">
                        เขียนที่
                    </td>
                    <td style="width:40%;border-bottom:dotted;border-bottom-width:thin;">

                        {{LIST_LCN.DALCN_NCT_SUBSTITUTE.WRITE_AT}}
                    </td>
                </tr>
                <tr>
                    <td style="text-align:right;width:100px">
                        วันที่
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;">

                        {{LIST_LCN.DALCN_NCT_SUBTITUTE.WRITE_DATE}}
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
                    <td style="text-align:left;width:30%;border-bottom:dotted;border-bottom-width:thin;">
                        @*<form action="javascript:void(0)">
                                <table>
                                    <tr>
                                        <td>
                                            <input class="form-control inline" ng-model="LIST_LCN.BSN_IDENTIFY" id="txt_bsn_identify" style="font-family:'Taviraj';" type="text" />
                                        </td>
                                        <td>
                                            <input type="button" value="ค้นหาผู้ดำเนินฯ" ng-click="BTN_Search_BSN(LIST_LCN.BSN_IDENTIFY)" />
                                        </td>
                                    </tr>
                                </table>


                            </form>*@
                        <label>{{LIST_LCN.BSN_THAIFULLNAME}}</label>
                    </td>
                </tr>
                <tr>
                    <td style="font-size:20px">
                        หรือบัตรประจำตัวอื่นที่ทางราชการออกให้ คือ
                    </td>
                    <td style="font-size:20px;width:20%;border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_LCN.BSN_IDENTIFY}}</label>
                    </td>
                    <td style="font-size:20px;width:5%">
                        เลขที่
                    </td>
                    <td style="font-size:20px ;width:15%;text-align:center;border-bottom:dotted;border-bottom-width:thin"></td>
                    <td style="font-size:20px">
                        (กรณีไม่ใช่ผู้มีสัญชาติไทย)
                    </td>
                </tr>
                <tr>
                    <td style="font-size:20px">
                        หรือทะเบียนนิติบุคคล/บัตรประจำตัวผู้เสียภาษี เลขที่
                    </td>
                    <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_LCN.BSN_IDENTIFY}}</label>
                    </td>
                </tr>
                <tr>
                    <td style="font-size:20px">
                        เลขรหัสประจำบ้าน
                    </td>
                    <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_LCN.BSN_HOUSENO}}</label>
                    </td>
                </tr>
                <tr>
                    <td style="font-size:20px">
                        อยู่เลขที่
                    </td>
                    <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_LCN.BSN_FULL_ADDR}}</label>
                    </td>
                </tr>
                <tr>
                    <td style="font-size:20px">
                        โทรศัพท์/มือถือ
                    </td>
                    <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_LCN.BSN_TELEPHONE}}</label>
                    </td>
                </tr>
                <tr>
                    <td style="font-size:20px">
                        E-mail
                    </td>
                    <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_LCN.dalcn.Email}}</label>
                    </td>
                </tr>
                <tr>
                    <td style="font-size:20px" colspan="2">
                        โดยได้รับอนุญาตนำสั่งยาแผนปัจจุบันเข้ามาในราชอาณาจักร เลขที่
                    </td>
                    <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;" colspan="2">
                        <label>{{LIST_LCN.HEAD_LCNNO_NCT}}</label>
                    </td>
                    <td style="font-size:20px">
                        ตามกฎหมายว่าด้วยยา
                    </td>
                </tr>
            </table>

            <table style="width:90%;font-size:20px">
                <tr>
                    <td colspan="2">
                        <p style="margin-left:5%">มีความประสงค์ขอรับอนุญาตนำเข้าวัตถุออกฤทธิ์ในประเภท ๓ หรือประเภท ๔ เนื่องจาก</p>
                    </td>
                </tr>
                <tr>
                    <td>
                        <form name="rdl_gmp">

                            <label>
                                <input type="checkbox" ng-model="LIST_LCN.dalcn.syslctaddr_thaaddr" id="chbl_typeee" value="1">
                                นำเข้ามาเป็นวัตถุดิบเพื่อจำหน่าย
                            </label>
                            <label>
                                <input type="checkbox" ng-model="LIST_LCN.dalcn.syslctaddr_engaddr" id="chbl_typeee" ng-value="1">
                                นำเข้ามาเป็นวัตถุดิบเพื่อผลิตวัตถุตำรับ
                            </label>
                        </form>
                    </td>
                </tr>
                <tr>
                    <td>
                        <form name="rdl_gmp">
                            <label>
                                <input type="checkbox" ng-model="LIST_LCN.dalcn.syslctaddr_room" id="chbl_typeee" value="1">
                                นำเข้ามาเป็นผลิตภัณฑ์สำเร็จรูปเพื่อจำหน่าย
                            </label>
                            <label>
                                <input type="checkbox" ng-model="LIST_LCN.dalcn.syslctaddr_engsoi" id="chbl_typeee" ng-value="1">
                                นำเข้ามาเป็นผลิตภัณฑ์สำเร็จรูปเพื่อส่งออก
                            </label>
                        </form>
                    </td>
                </tr>
                <tr>
                    <td>
                        <form name="rdl_gmp">
                            <label>
                                <input type="checkbox" ng-model="LIST_LCN.dalcn.syslctaddr_floor" id="chbl_typeee" value="1">
                                อื่นๆ (โปรดระบุ)
                            </label>
                            @*<input type="text" ng-model="LIST_LCN.dalcn.syslctaddr_thasoi" id="chbl_typeee" ng-value="1">*@
                            {{LIST_LCN.dalcn.syslctaddr_thasoi}}
                        </form>
                    </td>
                </tr>
            </table>
            <br />

            <table style="width:100%;font-size:20px">
                <tr>
                    <td colspan="4">
                        ๓. ข้อมูลสถานที่นำเข้า
                    </td>
                </tr>
                <tr>
                    <td>
                        ณ สถานที่ชื่อ
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_LCN.THANAMEPLACE}}</label>
                    </td>
                    <td>
                        เลขรหัสประจำบ้าน
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_LCN.HOUSENO}}</label>
                    </td>
                </tr>
                <tr>
                    <td>
                        ตั้งอยู่เลขที่
                    </td>
                    <td colspan="3" style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_LCN.fulladdr3}}</label>
                    </td>
                </tr>
                <tr>
                    <td>
                        โทรศัพท์/มือถือ
                    </td>
                    <td colspan="3" style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_LCN.tel}}</label>
                    </td>
                </tr>

            </table>

            <table style="width:100%;font-size:20px" ng-init="getdetails_phr()">
                <tr>
                    <td style="width:15%;">
                        โดยมีเภสัชกรชื่อ  1.
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;width:15%;">
                        <label>{{LIST_PHR.PHR_NAME}}</label>
                    </td>
                    <td style="width:15%">
                        ใบอนุญาตประกอบวิชาชีพเภสัชกรรมเลขที่
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_PHR.PHR_TEXT_NUM}}</label>
                    </td>
                </tr>
            </table>
            <br />
            @*<input type="button" style="font-size:20px;width:100px" value="เพิ่ม" />*@
            @*<input type="button" style="font-size:20px;width:100px;margin-left:10px" value="ลบ" />*@
            <br />
            <div style="margin-left:5%;font-size:20px">เป็นผู้ควบคุมตามมาตรา ๕๓ แห่งพระราชบัญญัติวัตถุที่ออกฤทธิ์ต่อจิตและประสาท พ.ศ. ๒๕๕๙</div>
            <br />

            <table style="width:100%;font-size:20px">
                <tr>
                    <td colspan="7">
                        <p>
                            <strong>
                                ๔. ข้อมูลสถานที่เก็บ (กรณีเป็นสถานที่คนละแห่งกับสถานที่ตาม ๓)
                            </strong>
                        </p>
                    </td>
                </tr>
                <tr>
                    <td style="width:17%">
                        ณ สถานที่ชื่อ
                    </td>
                    <td colspan="4" style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_KEEP.KEEP_THANAMEPLACE}}</label>
                    </td>
                    <td style="width:15%">
                        เลขรหัสประจำบ้าน
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_KEEP.HOUSENO}}</label>
                    </td>
                </tr>
                <tr>
                    <td>
                        อยู่เลขที่
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_KEEP.KEEP_FULL_ADDR}}</label>
                    </td>
                </tr>
                <tr>
                    <td>
                        โทรศัพท์ / มือถือ
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_KEEP.KEEP_TEL}}</label>
                    </td>
                </tr>

            </table>
            <table style="width:100%;font-size:20px">
                <tr>
                    <td style="width:50%">
                        โดยได้รับอนุญาตนำสั่งยาแผนปัจจุบันเข้ามาในราชอาณาจักร เลขที่
                    </td>
                    <td style="width:30%;border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_LCN.HEAD_LCNNO_NCT}}</label>
                    </td>
                    <td>
                        ตามกฎหมายว่าด้วยยา
                    </td>
                </tr>
            </table>
            <br />
            @*<input type="button" style="font-size:20px;width:100px" value="เพิ่ม" />*@
            @*<input type="button" style="font-size:20px;width:100px;margin-left:10px" value="ลบ" />*@
            <br />
            <div style="margin-left:5%;font-size:20px">เป็นผู้ควบคุมตามมาตรา ๕๓ แห่งพระราชบัญญัติวัตถุที่ออกฤทธิ์ต่อจิตและประสาท พ.ศ. ๒๕๕๙</div>
            <br />

            <div style="font-size:20px"><strong>๕. พร้อมกับคำขอนี้ข้าพเจ้าได้แนบเอกสารหรือหลักฐานต่างๆ มาด้วย คือ</strong></div>
            <div style="margin-left:5%;font-size:20px"><strong>๕.๑ กรณีขอรับใบอนุญาต (กรณีรายใหม่)</strong></div>
            <table style="width:90%;font-size:20px ;margin-left:10%">
                <tr>
                    <td>
                        (๑) คำรับรองของผู้รับอนุญาตและเภสัชกรผู้ควบคุมกิจการ
                    </td>
                </tr>
                <tr>
                    <td>
                        (๒) รูปถ่ายหน้าตรง ไม่สวมหมวกและแว่นตาสีเข้ม ของผู้ขอรับใบอนุญาตหรือผู้ได้รับมอบหมายหรือแต่งตั้งให้ดำเนินกิจการ
                        เกี่ยวกับใบอนุญาต ขนาด ๑ นิ้ว จำนวน ๓ รูป ซึ่งถ่ายไว้ไม่เกิน ๖ เดือนก่อนวันยื่นคำขอ
                    </td>
                </tr>
                <tr>
                    <td>
                        (๓) สำเนาใบอนุญาตประกอบวิชาชีพเภสัชกรรม
                    </td>
                </tr>
                <tr>
                    <td>
                        (๔) หนังสือแต่งตั้งผู้ดำเนินกิจการ กรณีผู้ขอรับใบอนุญาตเป็นนิติบุคคล
                    </td>
                </tr>
                <tr>
                    <td>
                        (๕) แผนที่แสดงที่ตั้งและแผนผังแสดงที่นำเข้าหรือเก็บซึ่งวัตถุออกฤทธิ์ในประเภท ๓ หรือประเภท ๔ ของสถานประกอบการ
                    </td>
                </tr>
                <tr>
                    <td>
                        (๖) รูปถ่ายแสดงที่นำเข้าหรือเก็บซึ่งวัตถุออกฤทธิ์ในประเภท ๓ หรือประเภท ๔ ของสถานประกอบการจำนวน ๑ รูป
                    </td>
                </tr>
            </table>
            <div style="margin-left:5%;font-size:20px"><strong>๕.๒ กรณีขอต่ออายุใบอนุญาต</strong></div>
            <table style="width:90%;font-size:20px ;margin-left:10%">
                <tr>
                    <td>
                        (๑) ใบอนุญาตฉบับเดิม
                    </td>
                </tr>
                <tr>
                    <td>
                        (๒) รูปถ่ายหน้าตรง ไม่สวมหมวกและแว่นตาสีเข้ม ของผู้ขอรับใบอนุญาตหรือผู้ได้รับมอบหมายหรือแต่งตั้งให้ดำเนินกิจการ
                        เกี่ยวกับใบอนุญาต ขนาด ๑ นิ้ว จำนวน ๓ รูป ซึ่งถ่ายไว้ไม่เกิน ๖ เดือนก่อนวันยื่นคำขอ
                    </td>
                </tr>

            </table>
            <div style="margin-left:5%;font-size:20px"><strong>๕.๓ กรณีขอรับใบแทนใบอนุญาต</strong></div>
            <table style="width:90%;font-size:20px ;margin-left:10%">
                <tr>
                    <td>
                        (๑) ใบแจ้งความ กรณีใบอนุญาตสูญหาย
                    </td>
                </tr>
                <tr>
                    <td>
                        (๒) ใบอนุญาต กรณีใบอนุญาตดังกล่าวถูกทำลายบางส่วนหรือลบเลือนในสาระสำคัญ
                    </td>
                </tr>
                <tr>
                    <td>
                        (๓) รูปถ่ายหน้าตรง ไม่สวมหมวกและแว่นตาสีเข้ม ของผู้ขอรับใบอนุญาตหรือผู้ได้รับมอบหมายหรือแต่งตั้งให้ดำเนินกิจการเกี่ยวกับ
                        ใบอนุญาต ขนาด ๑ นิ้ว จำนวน ๓ รูป ซึ่งถ่ายไว้ไม่เกิน ๖ เดือนก่อนวันยื่นคำขอ
                    </td>
                </tr>

            </table>
            <div style="margin-left:5%;font-size:20px;text-align:center"><strong>ข้าพเจ้าขอรับรองว่า ข้อความและเอกสารหรือหลักฐานทั้งหมดที่ยื่นเพื่อประกอบคำขอรับใบอนุญาตเป็นความจริงทุกประการ</strong></div>
            <br />
            <div>
                <h2 style="font-family:'Taviraj';font-size:20px;">
                    ไฟล์แนบ
                </h2>
                <table class="table" style="width:100%">
                    <tr>
                        <td>ชื่อไฟล์</td>
                        <td></td>
                    </tr>
                    <tr ng-repeat="datas in LIST_File.FILE_LISTs" style="background-color:#FDFCE3">
                        <td>{{datas.FILENAME}}</td>
                        <td>
                            <a ng-show="datas.PATH != null && datas.PATH != ''" ng-click="OPEN_DOC_PATH(datas.PATH,datas.FILENAME)">ดูเอกสาร</a>
                        </td>
                    </tr>
                </table>
            </div>
            <br />
            <br />

            <table style="width:85%;font-size:20px ;margin-left:12.5%">
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
                        <label>{{LIST_LCN.BSN_THAIFULLNAME}}</label>
                    </td>
                    <td style="text-align:left">
                        )
                    </td>
                </tr>
            </table>
            <br />
            <br />

            <div style="margin-left:5%;font-size:20px"> หมายเหตุ : (๑) ให้ขีดเลือกข้อความในช่อง ☐/〇 ให้ตรงตามที่ประสงค์จะดำเนินการ</div>
            <table style="width:90%;font-size:20px ;margin-left:12.5%">
                <tr>
                    <td>
                        (๒) รับรองสำเนาถูกต้องในเอกสารที่เป็นสำเนาทุกฉบับ
                    </td>
                </tr>
                <tr>
                    <td>
                        (๓) กรณีเอกสารหรือหลักฐานที่ออกโดยสำนักงานคณะกรรมการอาหารและยา ผู้อนุญาตอาจไม่ขอเอกสารหรือหลักฐานดังกล่าวได้
                    </td>
                </tr>

            </table>


        </div>
    </div>

    <div ng-show="LIST_LCN.PROCESS == '100772'">
        <div style="font-family:'Taviraj';font-size:24px;">
            <h1 style="text-align:left;font-size:24px;">
                <strong>แบบ ส.ว.จ. ๓/๔-๑</strong>
            </h1>
            <br />
            <div class="title1">
                <label style="font-size:16px;margin-top:25px">
                    ที่ปิดรูปถ่าย<br />
                    ผู้ขออนุญาติ<br />
                    หรือ<br />
                    ผู้ดำเนินกิจการ<br />
                    ขนาด ๓ x ๔ ซม.<br />
                </label>
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
                        <td style="text-align:left">
                            ลงชื่่อ

                        </td>

                        <td style="border-bottom:dotted;border-bottom-width:thin;"></td>
                        <td style="text-align:right;width:25%">
                            ผู้รับคำขอ
                        </td>
                    </tr>
                </table>

            </div>


            <div style="clear:both"></div>
            <br />
            <br />

            <h2 style="text-align:center;font-size:24px;">
                <strong>คำขอรับใบอนุญาต คำขอต่ออายุใบอนุญาต คำขอรับใบแทน</strong><br />
                <strong>ใบอนุญาตส่งออกวัตถุออกฤทธิ์ในประเภท ๓ หรือประเภท ๔</strong>
            </h2>
            @*process =1111,1112 *@

            <table style="width:70%; font-size:20px;margin:auto;text-align:center">
                <tr>
                    <td>
                        <strong>สำหรับส่งออก</strong>
                    </td>
                    <td>
                        <input type="radio" name="gender" ng-model="LIST_LCN.PROCESS" ng-value="100772" id="rdl_CHK_SELL_TYPE" disabled="disabled" /> <strong>วัตถุออกฤทธิ์ในประเภท ๓</strong>
                    </td>
                    <td>
                        <input type="radio" name="gender" ng-model="LIST_LCN.PROCESS" ng-value="100773" id="rdl_CHK_SELL_TYPE" disabled="disabled" /> <strong>วัตถุออกฤทธิ์ในประเภท ๔</strong>
                    </td>
                </tr>
                <tr>
                    <td style="font-size:16px" colspan="3">
                        <strong>(คำขอ ๑ ฉบับ ให้ยื่นขอได้เพียงหนึ่งประเภทเท่านั้น)</strong>
                    </td>
                </tr>
            </table>

            <table style="width:100%; font-size:20px">
                <tr>
                    <td style="width:20%">
                        <input type="checkbox" name="gender" disabled="disabled" /> <strong>ขอรับใบอนุญาต</strong>
                    </td>
                </tr>
                <tr>
                    <td>
                        <input type="checkbox" name="gender" disabled="disabled" /> <strong>ขอต่ออายุใบอนุญาตเลขที่</strong>
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;"></td>
                    <td style="width:10%">
                        <strong>ประจำปี พ.ศ.</strong>
                    </td>
                    <td style="border-bottom-width:thin;"></td>
                </tr>
                <tr>
                    <td>
                        <input type="checkbox" name="gender" disabled="disabled" ng-checked="true" /> <strong>ขอรับใบแทนใบอนุญาต</strong>
                    </td>
                    <td>
                        เนื่องจากใบอนุญาต
                    </td>
                    <td colspan="2">

                        <form name="frm_lost_type">


                            <label><input type="radio" ng-model="LIST_LCN.DALCN_NCT_SUBSTITUTE.PURPOSE_ID" id="rdl_lost_type" value="1"> สูญหาย</label>
                            <label><input type="radio" ng-model="LIST_LCN.DALCN_NCT_SUBSTITUTE.PURPOSE_ID" id="rdl_lost_type" value="2"> ถูกทำลายหรือลบเลือนในสาระสำคัญ</label><br />

                        </form>



                    </td>

                </tr>
            </table>
            <br />

            <table style="width:100%">
                <tr>
                    <td style="text-align:right;width:90%">
                        เขียนที่
                    </td>
                    <td style="width:40%;border-bottom:dotted;border-bottom-width:thin;">

                        {{LIST_LCN.DALCN_NCT_SUBSTITUTE.WRITE_AT}}
                    </td>
                </tr>
                <tr>
                    <td style="text-align:right;width:100px">
                        วันที่
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;">

                        {{LIST_LCN.DALCN_NCT_SUBTITUTE.WRITE_DATE}}
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
                    <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;" colspan="6">
                        <label>{{LIST_LCN.BSN_THAIFULLNAME}}</label>
                    </td>
                </tr>
                <tr>
                    <td style="font-size:20px">
                        เลขประจำตัวประชาชน
                    </td>
                    <td style="text-align:left;width:30%;border-bottom:dotted;border-bottom-width:thin;">
                        @*<form action="javascript:void(0)">
                                <table>
                                    <tr>
                                        <td>
                                            <input class="form-control inline" ng-model="LIST_LCN.BSN_IDENTIFY" id="txt_bsn_identify" style="font-family:'TH SarabunPSK';" type="text" />
                                        </td>
                                        <td>
                                            <input type="button" value="ค้นหาผู้ดำเนินฯ" ng-click="BTN_Search_BSN(LIST_LCN.BSN_IDENTIFY)" />
                                        </td>
                                    </tr>
                                </table>


                            </form>*@
                        <label>{{LIST_LCN.BSN_THAIFULLNAME}}</label>
                    </td>
                </tr>
                <tr>
                    <td style="font-size:20px">
                        หรือบัตรประจำตัวอื่นที่ทางราชการออกให้ คือ
                    </td>
                    <td style="font-size:20px;width:20%;border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_LCN.BSN_IDENTIFY}}</label>
                    </td>
                    <td style="font-size:20px;width:5%">
                        เลขที่
                    </td>
                    <td style="font-size:20px ;width:15%;text-align:center"></td>
                    <td style="font-size:20px">
                        (กรณีไม่ใช่ผู้มีสัญชาติไทย)
                    </td>
                </tr>
                <tr>
                    <td style="font-size:20px">
                        หรือทะเบียนนิติบุคคล/บัตรประจำตัวผู้เสียภาษี เลขที่
                    </td>
                    <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_LCN.BSN_IDENTIFY}}</label>
                    </td>
                </tr>
                <tr>
                    <td style="font-size:20px">
                        เลขรหัสประจำบ้าน
                    </td>
                    <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_LCN.BSN_HOUSENO}}</label>
                    </td>
                </tr>
                <tr>
                    <td style="font-size:20px">
                        อยู่เลขที่
                    </td>
                    <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_LCN.BSN_FULL_ADDR}}</label>
                    </td>
                </tr>
                <tr>
                    <td style="font-size:20px">
                        โทรศัพท์/มือถือ
                    </td>
                    <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_LCN.BSN_TELEPHONE}}</label>
                    </td>
                </tr>
                <tr>
                    <td style="font-size:20px">
                        E-mail
                    </td>
                    <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_LCN.dalcn.Email}}</label>
                    </td>
                </tr>

            </table>

            <br />

            <table style="width:100%;font-size:20px">
                <tr>
                    <td colspan="4">
                        <p><strong>๓. ข้อมูลสถานที่ส่งออก</strong></p>
                    </td>
                </tr>
                <tr>
                    <td>
                        ณ สถานที่ชื่อ
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_LCN.THANAMEPLACE}}</label>
                    </td>
                    <td>
                        เลขรหัสประจำบ้าน
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_LCN.HOUSENO}}</label>
                    </td>
                </tr>
                <tr>
                    <td>
                        ตั้งอยู่เลขที่
                    </td>
                    <td colspan="3" style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_LCN.fulladdr3}}</label>
                    </td>
                </tr>
                <tr>
                    <td>
                        โทรศัพท์/มือถือ
                    </td>
                    <td colspan="3" style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_LCN.tel}}</label>
                    </td>
                </tr>
                <tr>
                    <td style="font-size:20px;width:70%">
                        โดยได้รับอนุญาตให้ผลิต/ขาย/นำเข้าวัตถุออกฤทธิ์ในประเภท ๓ หรือประเภท ๔ ตามใบอนุญาตเลขที่
                    </td>
                    <td style="font-size:20px">
                        <label>{{LIST_LCN.HEAD_LCNNO_NCT}}</label>
                    </td>
                </tr>
            </table>

            <table style="width:100%;font-size:20px">
                <tr>
                    <td style="width:15%;">
                        โดยมีเภสัชกรชื่อ  1.
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;width:15%;">
                        <label>{{LIST_PHR.PHR_NAME}}</label>
                    </td>
                    <td style="width:15%">
                        ใบอนุญาตประกอบวิชาชีพเภสัชกรรมเลขที่
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_PHR.PHR_TEXT_NUM}}</label>
                    </td>
                </tr>
            </table>
            <div style="font-size:20px">เป็นผู้ควบคุมตามมาตรา ๕๓ แห่งพระราชบัญญัติวัตถุที่ออกฤทธิ์ต่อจิตและประสาท พ.ศ. ๒๕๕๙</div>
            <br />



            <div style="font-size:20px"><strong>๔. พร้อมกับคำขอนี้ข้าพเจ้าได้แนบเอกสารหรือหลักฐานต่างๆ มาด้วย คือ</strong></div>
            <div style="margin-left:5%;font-size:20px"><strong>๔.๑ กรณีขอรับใบอนุญาต (กรณีรายใหม่)</strong></div>
            <table style="width:90%;font-size:20px ;margin-left:10%">
                <tr>
                    <td>
                        (๑) คำรับรองของผู้รับอนุญาตและเภสัชกรผู้ควบคุมกิจการ
                    </td>
                </tr>
                <tr>
                    <td>
                        (๒) รูปถ่ายหน้าตรง ไม่สวมหมวกและแว่นตาสีเข้ม ของผู้ขอรับใบอนุญาตหรือผู้ได้รับมอบหมายหรือแต่งตั้งให้ดำเนินกิจการ
                        เกี่ยวกับใบอนุญาต ขนาด ๑ นิ้ว จำนวน ๓ รูป ซึ่งถ่ายไว้ไม่เกิน ๖ เดือนก่อนวันยื่นคำขอ
                    </td>
                </tr>
                <tr>
                    <td>
                        (๓) สำเนาใบอนุญาตประกอบวิชาชีพเภสัชกรรม
                    </td>
                </tr>
                <tr>
                    <td>
                        (๔) หนังสือแต่งตั้งผู้ดำเนินกิจการ กรณีผู้ขอรับใบอนุญาตเป็นนิติบุคคล
                    </td>
                </tr>
                <tr>
                    <td>
                        (๕) แผนที่แสดงที่ตั้งและแผนผังแสดงที่นำเข้าหรือเก็บซึ่งวัตถุออกฤทธิ์ในประเภท ๓ หรือประเภท ๔ ของสถานประกอบการ
                    </td>
                </tr>
                <tr>
                    <td>
                        (๖) รูปถ่ายแสดงที่นำเข้าหรือเก็บซึ่งวัตถุออกฤทธิ์ในประเภท ๓ หรือประเภท ๔ ของสถานประกอบการจำำนวน ๑ รูป
                    </td>
                </tr>
            </table>
            <div style="margin-left:5%;font-size:20px"><strong>๔.๒ กรณีขอต่ออายุใบอนุญาต</strong></div>
            <table style="width:90%;font-size:20px ;margin-left:10%">
                <tr>
                    <td>
                        (๑) ใบอนุญาตฉบับเดิม
                    </td>
                </tr>
                <tr>
                    <td>
                        (๒) รูปถ่ายหน้าตรง ไม่สวมหมวกและแว่นตาสีเข้ม ของผู้ขอรับใบอนุญาตหรือผู้ได้รับมอบหมายหรือแต่งตั้งให้ดำเนินกิจการ
                        เกี่ยวกับใบอนุญาต ขนาด ๑ นิ้ว จำนวน ๓ รูป ซึ่งถ่ายไว้ไม่เกิน ๖ เดือนก่อนวันยื่นคำขอ
                    </td>
                </tr>

            </table>
            <div style="margin-left:5%;font-size:20px"><strong>๔.๓ กรณีขอรับใบแทนใบอนุญาต</strong></div>
            <table style="width:90%;font-size:20px ;margin-left:10%">
                <tr>
                    <td>
                        (๑) ใบแจ้งความ กรณีใบอนุญาตสูญหาย
                    </td>
                </tr>
                <tr>
                    <td>
                        (๒) ใบอนุญาต กรณีใบอนุญาตดังกล่าวถูกทำลายบางส่วนหรือลบเลือนในสาระสำคัญ
                    </td>
                </tr>
                <tr>
                    <td>
                        (๓) รูปถ่ายหน้าตรง ไม่สวมหมวกและแว่นตาสีเข้ม ของผู้ขอรับใบอนุญาตหรือผู้ได้รับมอบหมายหรือแต่งตั้งให้ดำเนินกิจการเกี่ยวกับ
                        ใบอนุญาต ขนาด ๑ นิ้ว จำนวน ๓ รูป ซึ่งถ่ายไว้ไม่เกิน ๖ เดือนก่อนวันยื่นคำขอ
                    </td>
                </tr>

            </table>
            <div style="margin-left:5%;font-size:20px;text-align:center"><strong>ข้าพเจ้าขอรับรองว่า ข้อความและเอกสารหรือหลักฐานทั้งหมดที่ยื่นเพื่อประกอบคำขอรับใบอนุญาตเป็นความจริงทุกประการ</strong></div>
            <br />
            <div>
                <h2 style="font-family:'Taviraj';font-size:20px;">
                    ไฟล์แนบ
                </h2>
                <table class="table" style="width:100%">
                    <tr>
                        <td>ชื่อไฟล์</td>
                        <td></td>
                    </tr>
                    <tr ng-repeat="datas in LIST_File.FILE_LISTs" style="background-color:#FDFCE3">
                        <td>{{datas.FILENAME}}</td>
                        <td>
                            <a ng-show="datas.PATH != null && datas.PATH != ''" ng-click="OPEN_DOC_PATH(datas.PATH,datas.FILENAME)">ดูเอกสาร</a>
                        </td>
                    </tr>
                </table>
            </div>
            <br />
            <br />

            <table style="width:85%;font-size:20px ;margin-left:12.5%">
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
                        <label>{{LIST_LCN.BSN_THAIFULLNAME}}</label>
                    </td>
                    <td style="text-align:left">
                        )
                    </td>
                </tr>
            </table>
            <br />
            <br />

            <div style="margin-left:5%;font-size:20px"> หมายเหตุ : (๑) ให้ขีดเลือกข้อความในช่อง ☐/〇 ให้ตรงตามที่ประสงค์จะดำเนินการ</div>
            <table style="width:90%;font-size:20px ;margin-left:12.5%">
                <tr>
                    <td>
                        (๒) รับรองสำเนาถูกต้องในเอกสารที่เป็นสำเนาทุกฉบับ
                    </td>
                </tr>
                <tr>
                    <td>
                        (๓) กรณีเอกสารหรือหลักฐานที่ออกโดยสำนักงานคณะกรรมการอาหารและยา ผู้อนุญาตอาจไม่ขอเอกสารหรือหลักฐานดังกล่าวได้
                    </td>
                </tr>

            </table>
        </div>
    </div>

    <div ng-show="LIST_LCN.PROCESS == '100773'">
        <div style="font-family:'Taviraj';font-size:24px;">
            <h1 style="text-align:left;font-size:24px;">
                <strong>แบบ ส.ว.จ. ๓/๔-๑</strong>
            </h1>
            <br />
            <div class="title1">
                <label style="font-size:16px;margin-top:25px">
                    ที่ปิดรูปถ่าย<br />
                    ผู้ขออนุญาติ<br />
                    หรือ<br />
                    ผู้ดำเนินกิจการ<br />
                    ขนาด ๓ x ๔ ซม.<br />
                </label>
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
                        <td style="text-align:left">
                            ลงชื่่อ

                        </td>

                        <td style="border-bottom:dotted;border-bottom-width:thin;"></td>
                        <td style="text-align:right;width:25%">
                            ผู้รับคำขอ
                        </td>
                    </tr>
                </table>

            </div>


            <div style="clear:both"></div>
            <br />
            <br />

            <h2 style="text-align:center;font-size:24px;">
                <strong>คำขอรับใบอนุญาต คำขอต่ออายุใบอนุญาต คำขอรับใบแทน</strong><br />
                <strong>ใบอนุญาตส่งออกวัตถุออกฤทธิ์ในประเภท ๓ หรือประเภท ๔</strong>
            </h2>
            @*process =1111,1112 *@

            <table style="width:70%; font-size:20px;margin:auto;text-align:center">
                <tr>
                    <td>
                        <strong>สำหรับส่งออก</strong>
                    </td>
                    <td>
                        <input type="radio" name="gender" ng-model="LIST_LCN.PROCESS" ng-value="100772" id="rdl_CHK_SELL_TYPE" disabled="disabled" /> <strong>วัตถุออกฤทธิ์ในประเภท ๓</strong>
                    </td>
                    <td>
                        <input type="radio" name="gender" ng-model="LIST_LCN.PROCESS" ng-value="100773" id="rdl_CHK_SELL_TYPE" disabled="disabled" /> <strong>วัตถุออกฤทธิ์ในประเภท ๔</strong>
                    </td>
                </tr>
                <tr>
                    <td style="font-size:16px" colspan="3">
                        <strong>(คำขอ ๑ ฉบับ ให้ยื่นขอได้เพียงหนึ่งประเภทเท่านั้น)</strong>
                    </td>
                </tr>
            </table>

            <table style="width:100%; font-size:20px">
                <tr>
                    <td style="width:20%">
                        <input type="checkbox" name="gender" disabled="disabled" /> <strong>ขอรับใบอนุญาต</strong>
                    </td>
                </tr>
                <tr>
                    <td>
                        <input type="checkbox" name="gender" disabled="disabled" /> <strong>ขอต่ออายุใบอนุญาตเลขที่</strong>
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;"></td>
                    <td style="width:10%">
                        <strong>ประจำปี พ.ศ.</strong>
                    </td>
                    <td style="border-bottom-width:thin;"></td>
                </tr>
                <tr>
                    <td>
                        <input type="checkbox" name="gender" disabled="disabled" ng-checked="true" /> <strong>ขอรับใบแทนใบอนุญาต</strong>
                    </td>
                    <td>
                        เนื่องจากใบอนุญาต
                    </td>
                    <td colspan="2">

                        <form name="frm_lost_type">


                            <label><input type="radio" ng-model="LIST_LCN.DALCN_NCT_SUBSTITUTE.PURPOSE_ID" id="rdl_lost_type" value="1"> สูญหาย</label>
                            <label><input type="radio" ng-model="LIST_LCN.DALCN_NCT_SUBSTITUTE.PURPOSE_ID" id="rdl_lost_type" value="2"> ถูกทำลายหรือลบเลือนในสาระสำคัญ</label><br />

                        </form>



                    </td>

                </tr>
            </table>
            <br />

            <table style="width:100%">
                <tr>
                    <td style="text-align:right;width:90%">
                        เขียนที่
                    </td>
                    <td style="width:40%;border-bottom:dotted;border-bottom-width:thin;">

                        {{LIST_LCN.DALCN_NCT_SUBSTITUTE.WRITE_AT}}
                    </td>
                </tr>
                <tr>
                    <td style="text-align:right;width:100px">
                        วันที่
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;">

                        {{LIST_LCN.DALCN_NCT_SUBTITUTE.WRITE_DATE}}
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
                    <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;" colspan="6">
                        <label>{{LIST_LCN.BSN_THAIFULLNAME}}</label>
                    </td>
                </tr>
                <tr>
                    <td style="font-size:20px">
                        เลขประจำตัวประชาชน
                    </td>
                    <td style="text-align:left;width:30%;border-bottom:dotted;border-bottom-width:thin;">
                        @*<form action="javascript:void(0)">
                                <table>
                                    <tr>
                                        <td>
                                            <input class="form-control inline" ng-model="LIST_LCN.BSN_IDENTIFY" id="txt_bsn_identify" style="font-family:'TH SarabunPSK';" type="text" />
                                        </td>
                                        <td>
                                            <input type="button" value="ค้นหาผู้ดำเนินฯ" ng-click="BTN_Search_BSN(LIST_LCN.BSN_IDENTIFY)" />
                                        </td>
                                    </tr>
                                </table>


                            </form>*@
                        <label>{{LIST_LCN.BSN_THAIFULLNAME}}</label>
                    </td>
                </tr>
                <tr>
                    <td style="font-size:20px">
                        หรือบัตรประจำตัวอื่นที่ทางราชการออกให้ คือ
                    </td>
                    <td style="font-size:20px;width:20%;border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_LCN.BSN_IDENTIFY}}</label>
                    </td>
                    <td style="font-size:20px;width:5%">
                        เลขที่
                    </td>
                    <td style="font-size:20px ;width:15%;text-align:center"></td>
                    <td style="font-size:20px">
                        (กรณีไม่ใช่ผู้มีสัญชาติไทย)
                    </td>
                </tr>
                <tr>
                    <td style="font-size:20px">
                        หรือทะเบียนนิติบุคคล/บัตรประจำตัวผู้เสียภาษี เลขที่
                    </td>
                    <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_LCN.BSN_IDENTIFY}}</label>
                    </td>
                </tr>
                <tr>
                    <td style="font-size:20px">
                        เลขรหัสประจำบ้าน
                    </td>
                    <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_LCN.BSN_HOUSENO}}</label>
                    </td>
                </tr>
                <tr>
                    <td style="font-size:20px">
                        อยู่เลขที่
                    </td>
                    <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_LCN.BSN_FULL_ADDR}}</label>
                    </td>
                </tr>
                <tr>
                    <td style="font-size:20px">
                        โทรศัพท์/มือถือ
                    </td>
                    <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_LCN.BSN_TELEPHONE}}</label>
                    </td>
                </tr>
                <tr>
                    <td style="font-size:20px">
                        E-mail
                    </td>
                    <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_LCN.dalcn.Email}}</label>
                    </td>
                </tr>

            </table>

            <br />

            <table style="width:100%;font-size:20px">
                <tr>
                    <td colspan="4">
                        <p><strong>๓. ข้อมูลสถานที่ส่งออก</strong></p>
                    </td>
                </tr>
                <tr>
                    <td>
                        ณ สถานที่ชื่อ
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_LCN.THANAMEPLACE}}</label>
                    </td>
                    <td>
                        เลขรหัสประจำบ้าน
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_LCN.HOUSENO}}</label>
                    </td>
                </tr>
                <tr>
                    <td>
                        ตั้งอยู่เลขที่
                    </td>
                    <td colspan="3" style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_LCN.fulladdr3}}</label>
                    </td>
                </tr>
                <tr>
                    <td>
                        โทรศัพท์/มือถือ
                    </td>
                    <td colspan="3" style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_LCN.tel}}</label>
                    </td>
                </tr>
                <tr>
                    <td style="font-size:20px;width:70%">
                        โดยได้รับอนุญาตให้ผลิต/ขาย/นำเข้าวัตถุออกฤทธิ์ในประเภท ๓ หรือประเภท ๔ ตามใบอนุญาตเลขที่
                    </td>
                    <td style="font-size:20px">
                        <label>{{LIST_LCN.HEAD_LCNNO_NCT}}</label>
                    </td>
                </tr>
            </table>

            <table style="width:100%;font-size:20px">
                <tr>
                    <td style="width:15%;">
                        โดยมีเภสัชกรชื่อ  1.
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;width:15%;">
                        <label>{{LIST_PHR.PHR_NAME}}</label>
                    </td>
                    <td style="width:15%">
                        ใบอนุญาตประกอบวิชาชีพเภสัชกรรมเลขที่
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_PHR.PHR_TEXT_NUM}}</label>
                    </td>
                </tr>
            </table>
            <div style="font-size:20px">เป็นผู้ควบคุมตามมาตรา ๕๓ แห่งพระราชบัญญัติวัตถุที่ออกฤทธิ์ต่อจิตและประสาท พ.ศ. ๒๕๕๙</div>
            <br />



            <div style="font-size:20px"><strong>๔. พร้อมกับคำขอนี้ข้าพเจ้าได้แนบเอกสารหรือหลักฐานต่างๆ มาด้วย คือ</strong></div>
            <div style="margin-left:5%;font-size:20px"><strong>๔.๑ กรณีขอรับใบอนุญาต (กรณีรายใหม่)</strong></div>
            <table style="width:90%;font-size:20px ;margin-left:10%">
                <tr>
                    <td>
                        (๑) คำรับรองของผู้รับอนุญาตและเภสัชกรผู้ควบคุมกิจการ
                    </td>
                </tr>
                <tr>
                    <td>
                        (๒) รูปถ่ายหน้าตรง ไม่สวมหมวกและแว่นตาสีเข้ม ของผู้ขอรับใบอนุญาตหรือผู้ได้รับมอบหมายหรือแต่งตั้งให้ดำเนินกิจการ
                        เกี่ยวกับใบอนุญาต ขนาด ๑ นิ้ว จำนวน ๓ รูป ซึ่งถ่ายไว้ไม่เกิน ๖ เดือนก่อนวันยื่นคำขอ
                    </td>
                </tr>
                <tr>
                    <td>
                        (๓) สำเนาใบอนุญาตประกอบวิชาชีพเภสัชกรรม
                    </td>
                </tr>
                <tr>
                    <td>
                        (๔) หนังสือแต่งตั้งผู้ดำเนินกิจการ กรณีผู้ขอรับใบอนุญาตเป็นนิติบุคคล
                    </td>
                </tr>
                <tr>
                    <td>
                        (๕) แผนที่แสดงที่ตั้งและแผนผังแสดงที่นำเข้าหรือเก็บซึ่งวัตถุออกฤทธิ์ในประเภท ๓ หรือประเภท ๔ ของสถานประกอบการ
                    </td>
                </tr>
                <tr>
                    <td>
                        (๖) รูปถ่ายแสดงที่นำเข้าหรือเก็บซึ่งวัตถุออกฤทธิ์ในประเภท ๓ หรือประเภท ๔ ของสถานประกอบการจำนวน ๑ รูป
                    </td>
                </tr>
            </table>
            <div style="margin-left:5%;font-size:20px"><strong>๔.๒ กรณีขอต่ออายุใบอนุญาต</strong></div>
            <table style="width:90%;font-size:20px ;margin-left:10%">
                <tr>
                    <td>
                        (๑) ใบอนุญาตฉบับเดิม
                    </td>
                </tr>
                <tr>
                    <td>
                        (๒) รูปถ่ายหน้าตรง ไม่สวมหมวกและแว่นตาสีเข้ม ของผู้ขอรับใบอนุญาตหรือผู้ได้รับมอบหมายหรือแต่งตั้งให้ดำเนินกิจการ
                        เกี่ยวกับใบอนุญาต ขนาด ๑ นิ้ว จำนวน ๓ รูป ซึ่งถ่ายไว้ไม่เกิน ๖ เดือนก่อนวันยื่นคำขอ
                    </td>
                </tr>

            </table>
            <div style="margin-left:5%;font-size:20px"><strong>๔.๓ กรณีขอรับใบแทนใบอนุญาต</strong></div>
            <table style="width:90%;font-size:20px ;margin-left:10%">
                <tr>
                    <td>
                        (๑) ใบแจ้งความ กรณีใบอนุญาตสูญหาย
                    </td>
                </tr>
                <tr>
                    <td>
                        (๒) ใบอนุญาต กรณีใบอนุญาตดังกล่าวถูกทำลายบางส่วนหรือลบเลือนในสาระสำคัญ
                    </td>
                </tr>
                <tr>
                    <td>
                        (๓) รูปถ่ายหน้าตรง ไม่สวมหมวกและแว่นตาสีเข้ม ของผู้ขอรับใบอนุญาตหรือผู้ได้รับมอบหมายหรือแต่งตั้งให้ดำเนินกิจการเกี่ยวกับ
                        ใบอนุญาต ขนาด ๑ นิ้ว จำนวน ๓ รูป ซึ่งถ่ายไว้ไม่เกิน ๖ เดือนก่อนวันยื่นคำขอ
                    </td>
                </tr>

            </table>
            <div style="margin-left:5%;font-size:20px;text-align:center"><strong>ข้าพเจ้าขอรับรองว่า ข้อความและเอกสารหรือหลักฐานทั้งหมดที่ยื่นเพื่อประกอบคำขอรับใบอนุญาตเป็นความจริงทุกประการ</strong></div>
            <br />
            <div>
                <h2 style="font-family:'Taviraj';font-size:20px;">
                    ไฟล์แนบ
                </h2>
                <table class="table" style="width:100%">
                    <tr>
                        <td>ชื่อไฟล์</td>
                        <td></td>
                    </tr>
                    <tr ng-repeat="datas in LIST_File.FILE_LISTs" style="background-color:#FDFCE3">
                        <td>{{datas.FILENAME}}</td>
                        <td>
                            <a ng-show="datas.PATH != null && datas.PATH != ''" ng-click="OPEN_DOC_PATH(datas.PATH,datas.FILENAME)">ดูเอกสาร</a>
                        </td>
                    </tr>
                </table>
            </div>
            <br />
            <br />

            <table style="width:85%;font-size:20px ;margin-left:12.5%">
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
                        <label>{{LIST_LCN.BSN_THAIFULLNAME}}</label>
                    </td>
                    <td style="text-align:left">
                        )
                    </td>
                </tr>
            </table>
            <br />
            <br />

            <div style="margin-left:5%;font-size:20px"> หมายเหตุ : (๑) ให้ขีดเลือกข้อความในช่อง ☐/〇 ให้ตรงตามที่ประสงค์จะดำเนินการ</div>
            <table style="width:90%;font-size:20px ;margin-left:12.5%">
                <tr>
                    <td>
                        (๒) รับรองสำเนาถูกต้องในเอกสารที่เป็นสำเนาทุกฉบับ
                    </td>
                </tr>
                <tr>
                    <td>
                        (๓) กรณีเอกสารหรือหลักฐานที่ออกโดยสำนักงานคณะกรรมการอาหารและยา ผู้อนุญาตอาจไม่ขอเอกสารหรือหลักฐานดังกล่าวได้
                    </td>
                </tr>

            </table>
        </div>
    </div>

    <div ng-show="LIST_LCN.PROCESS == '100774'">
        <div style="font-family:'Taviraj';font-size:24px;">
            <h1 style="text-align:left;font-size:24px;">
                <strong>แบบ ข.ว.จ. ๓/๔-๑</strong>
            </h1>
            <br />
            <div class="title1">
                <label style="font-size:16px;margin-top:25px">
                    ที่ปิดรูปถ่าย<br />
                    ผู้ขออนุญาติ<br />
                    หรือ<br />
                    ผู้ดำเนินกิจการ<br />
                    ขนาด ๓ นิ้ว<br />
                </label>
            </div>

            <div class="title2">
                <table style="font-size:20px;width:95%;margin-top:10px;margin-left:10px">
                    <tr>
                        <td style="text-align:left;width:20%">
                            เลขรับที่
                        </td>

                        <td colspan="3" style="border-bottom:dotted;border-bottom-width:thin;">
                            <label>{{LCN_LIST.RCVNO_DISPLAY}}</label>
                        </td>
                    </tr>
                    <tr>
                        <td style="text-align:left">
                            วันที่
                        </td>

                        <td colspan="3" style="border-bottom:dotted;border-bottom-width:thin;">
                            <label>{{LCN_LIST.RCV_DATE_DISPLAY}}</label>
                        </td>
                    </tr>
                    <tr>
                        <td style="text-align:left">
                            ลงชื่่อ

                        </td>

                        <td style="border-bottom:dotted;border-bottom-width:thin;"></td>
                        <td style="text-align:right;width:25%">
                            ผู้รับคำขอ
                        </td>
                    </tr>
                </table>

            </div>


            <div style="clear:both"></div>
            <br />
            <br />

            <h2 style="text-align:center;font-size:24px;">
                <strong>คำขอรับใบอนุญาต คำขอต่ออายุใบอนุญาต คำขอรับใบแทน</strong><br />
                <strong>ใบอนุญาตขายวัตถุออกฤทธิ์ในประเภท ๓ หรือประเภท ๔</strong>
            </h2>
            @*process =123,124 *@
            <table style="width:70%; font-size:20px;margin:auto;text-align:center">
                <tr>
                    <td>
                        <strong>สำหรับขาย</strong>
                    </td>
                    <td>
                        <input type="radio" name="gender" ng-model="LIST_LCN.PROCESS" ng-value="100766" id="rdl_CHK_SELL_TYPE" disabled="disabled" /> <strong>วัตถุออกฤทธิ์ในประเภท ๓</strong>
                    </td>
                    <td>
                        <input type="radio" name="gender" ng-model="LIST_LCN.PROCESS" ng-value="100767" id="rdl_CHK_SELL_TYPE" disabled="disabled" /> <strong>วัตถุออกฤทธิ์ในประเภท ๔</strong>
                    </td>
                </tr>
                <tr>
                    <td style="font-size:16px" colspan="3">
                        <strong>(คำขอ ๑ ฉบับ ให้ยื่นขอได้เพียงหนึ่งประเภทเท่านั้น)</strong>
                    </td>
                </tr>
            </table>

            <table style="width:100%; font-size:20px">
                <tr>
                    <td style="width:20%">
                        <input type="checkbox" name="gender" disabled="disabled" /> <strong>ขอรับใบอนุญาต</strong>
                    </td>
                </tr>
                <tr>
                    <td>
                        <input type="checkbox" name="gender" disabled="disabled" /> <strong>ขอต่ออายุใบอนุญาตเลขที่</strong>
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;"></td>
                    <td style="width:10%">
                        <strong>ประจำปี พ.ศ.</strong>
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;"></td>
                </tr>
                <tr>
                    <td>
                        <input type="checkbox" name="gender" disabled="disabled" ng-checked="true" /> <strong>ขอรับใบแทนใบอนุญาต</strong>
                    </td>
                    <td>
                        เนื่องจากใบอนุญาต
                    </td>
                    <td colspan="2">

                        <form name="frm_lost_type">


                            <label><input type="radio" ng-model="LIST_LCN.DALCN_NCT_SUBSTITUTE.PURPOSE_ID" id="rdl_lost_type" value="1"> สูญหาย</label>
                            <label><input type="radio" ng-model="LIST_LCN.DALCN_NCT_SUBSTITUTE.PURPOSE_ID" id="rdl_lost_type" value="2"> ถูกทำลายหรือลบเลือนในสาระสำคัญ</label><br />

                        </form>



                    </td>

                </tr>
            </table>
            <br />

            <table style="width:100%">
                <tr>
                    <td style="text-align:right;width:90%">
                        เขียนที่
                    </td>
                    <td style="width:40%;border-bottom:dotted;border-bottom-width:thin;">

                        {{LIST_LCN.DALCN_NCT_SUBSTITUTE.WRITE_AT}}
                    </td>
                </tr>
                <tr>
                    <td style="text-align:right;width:100px">
                        วันที่
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;">

                        {{LIST_LCN.DALCN_NCT_SUBTITUTE.WRITE_DATE}}
                    </td>
                </tr>
            </table>
            <br />

            <h2 style="font-size:24px;">
                <strong>๑. ข้อมูลผู้ขอรับใบอนุญาต</strong>
            </h2>
            <table style="width:90%">
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
            <table style="width:90%">
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
                    <td style="text-align:left;width:30%;border-bottom:dotted;border-bottom-width:thin;">
                        <form action="javascript:void(0)">
                            <table>
                                <tr>
                                    <td style="border-bottom:dotted;border-bottom-width:thin;">
                                        @*<input class="form-control inline" ng-model="LIST_LCN.BSN_IDENTIFY" id="txt_bsn_identify" style="font-family:'Taviraj';" type="text" />*@
                                        {{LIST_LCN.BSN_IDENTIFY}}
                                    </td>
                                    @*<td>
                                            <input type="button" value="ค้นหาผู้ดำเนินฯ" ng-click="BTN_Search_BSN(LIST_LCN.BSN_IDENTIFY)" />
                                        </td>*@
                                </tr>
                            </table>


                        </form>
                        <label>{{LIST_LCN.BSN_THAIFULLNAME}}</label>
                    </td>
                </tr>
                <tr>
                    <td style="font-size:20px">
                        หรือบัตรประจำตัวอื่นที่ทางราชการออกให้ คือ
                    </td>
                    <td style="font-size:20px;width:20%;border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_LCN.BSN_IDENTIFY}}</label>
                    </td>
                    <td style="font-size:20px;width:5%">
                        เลขที่
                    </td>
                    <td style="font-size:20px ;width:15%;text-align:center"></td>
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
                        <label>{{LIST_LCN.BSN_FULL_ADDR}}</label>
                    </td>
                </tr>
                <tr>
                    <td style="font-size:20px">
                        โทรศัพท์/มือถือ
                    </td>
                    <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;" colspan="6">
                        <label>{{LIST_LCN.BSN_TELEPHONE}}</label>
                    </td>
                </tr>
            </table>

            <div style="font-size:20px"><strong>๓. ข้อมูลการขออนุญาต</strong></div>
            <div style="font-size:20px;margin-left:5%">(๓.๑) <strong><u>กรณีขายวัตถุออกฤทธฺิ์ในประเภท ๓ หรือประเภท ๔</u></strong></div>
            <table style="width:100%;font-size:20px">
                <tr>
                    <td>
                        ณ สถานที่ชื่อ
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_LCN.THANAMEPLACE}}</label>
                    </td>
                    <td>
                        เลขรหัสประจำบ้าน
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_LCN.HOUSENO}}</label>
                    </td>
                </tr>
                <tr>
                    <td>
                        ตั้งอยู่เลขที่
                    </td>
                    <td colspan="3" style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_LCN.fulladdr3}}</label>
                    </td>
                </tr>
                <tr>
                    <td>
                        โทรศัพท์/มือถือ
                    </td>
                    <td colspan="3" style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_LCN.tel}}</label>
                    </td>
                </tr>

            </table>
            <table style="width:100%;font-size:20px" ng-init="getdetails_phr()">
                <tr>
                    <td style="width:15%;">
                        โดยมีเภสัชกรชื่อ  1.
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;width:15%;">
                        <label>{{LIST_PHR.PHR_NAME}}</label>
                    </td>
                    <td style="width:15%">
                        ใบอนุญาตประกอบวิชาชีพเภสัชกรรมเลขที่
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_PHR.PHR_TEXT_NUM}}</label>
                    </td>
                </tr>
            </table>
            <br />
            @*<input type="button" style="font-size:20px;width:100px" value="เพิ่ม" />*@
            @*<input type="button" style="font-size:20px;width:100px;margin-left:10px" value="ลบ" />*@
            <br />
            <table style="width:100%;font-size:20px">
                <tr>
                    <td>
                        เป็นผู้รับอนุญาตขายยาแผนใบอนุญาตเลขที่
                    </td>
                    <td style="width:50%; border-bottom:dotted;border-bottom-width:thin; ">
                        <label>{{LIST_LCN.HEAD_LCNNO_NCT}}</label>
                    </td>
                    <td>
                        ตามกฎหมายว่าด้วยยา
                    </td>
                </tr>
            </table>
            <div style="font-size:20px">เป็นผู้ควบคุมตามมาตรา ๕๓ แห่งพระราชบัญญัติวัตถุที่ออกฤทธิ์ต่อจิตและประสาท พ.ศ. ๒๕๕๙</div>

            <div style="font-size:20px;margin-left:5%"><strong>(๓.๒) <u>กรณีขายวัตถุออกฤทธฺิ์ในประเภท ๓ หรือประเภท ๔ โดยการขายส่งตรง</u></strong></div>
            <table style="width:100%;font-size:20px">
                <tr>
                    <td colspan="2">
                        ผู้ขอรับใบอนุญาตได้รับอนุญาตให้ผลิต/ขาย/หรือนำเข้าซึ่งวัตถุออกฤทธิ์ในประเภท ๓ หรือประเภท ๔ ตามใบอนุญาต
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        ผู้ขอรับใบอนุญาตได้รับอนุญาตให้ผลิต/ขาย/หรือนำเข้าซึ่งวัตถุออกฤทธิ์ในประเภท ๓ หรือประเภท ๔ ตามใบอนุญาต
                    </td>
                </tr>
                <tr>
                    <td style="width:10%">
                        เลขที่
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_LCN.HEAD_LCNNO}}</label>
                    </td>
                </tr>
            </table>
            <div style="font-size:20px;margin-left:5%"><strong>(๓.๓) <u> กรณีขายวัตถุออกฤทธฺิ์ในประเภท ๓ หรือประเภท ๔ ในบริเวณสถานที่ที่มีการประชุม</u></strong></div>

            <table style="width:100%;font-size:20px">
                <tr>
                    <td colspan="4">
                        ผู้ขอรับใบอนุญาตได้รับอนุญาตให้ผลิต/ขาย/หรือนำเข้าซึ่งวัตถุออกฤทธิ์ในประเภท ๓ หรือประเภท ๔ ตามใบอนุญาต
                    </td>
                </tr>
                <tr>
                    <td style="width:20%">
                        เลขที่
                    </td>
                    <td colspan="4" style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_LCN.HEAD_LCNNO}}</label>
                    </td>
                </tr>
                <tr>
                    <td colspan="4">
                        ขอรับใบอนุญาตขายวัตถุออกฤทธิ์ในบริเวณสถานที่ที่มีการประชุม ณ
                    </td>
                </tr>
                <tr>
                    <td style="width:10%">
                        สถานที่ชื่อ
                    </td>
                    <td colspan="4" style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_LCN.thanameplace}}</label>
                    </td>
                </tr>
                <tr>
                    <td>
                        เลขรหัสประจำบ้าน
                    </td>
                    <td colspan="4" style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_LCN.HOUSENO}}</label>
                    </td>
                </tr>
                <tr>
                    <td>
                        ตั้งอยู่เลขที่
                    </td>
                    <td colspan="3" style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_LCN.fulladdr2}}</label>
                    </td>
                </tr>
                <tr>
                    <td>
                        โทรศัพท์/มือถือ
                    </td>
                    <td colspan="3" style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_LCN.tel}}</label>
                    </td>
                </tr>
                <tr>
                    <td>
                        ตั้งแต่วันที่
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;"></td>
                    <td style="width:20%">
                        ถึงวันที่
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;"></td>
                </tr>
            </table>

            <table style="width:100%;font-size:20px" ng-init="getdetails_keep()">
                <tr>
                    <td colspan="7">
                        <p>
                            <strong>
                                ๔. ข้อมูลสถานที่เก็บ (กรณีเป็นสถานที่คนละแห่งกับสถานที่ตาม ๓)
                            </strong>
                        </p>
                    </td>
                </tr>
                <tr>
                    <td style="width:17%">
                        ณ สถานที่ชื่อ
                    </td>
                    <td colspan="4" style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_KEEP.KEEP_THANAMEPLACE}}</label>
                    </td>
                    <td style="width:15%">
                        เลขรหัสประจำบ้าน
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_KEEP.HOUSENO}}</label>
                    </td>
                </tr>
                <tr>
                    <td>
                        อยู่เลขที่
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_KEEP.KEEP_FULL_ADDR}}</label>
                    </td>
                </tr>
                <tr>
                    <td>
                        โทรศัพท์ / มือถือ
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_KEEP.KEEP_TEL}}</label>
                    </td>
                </tr>

            </table>
            @*<input type="button" style="font-size:20px;width:100px" value="เพิ่ม" />*@
            @*<input type="button" style="font-size:20px;width:100px;margin-left:10px" value="ลบ" />*@
            <br />
            <br />

            <div style=";font-size:20px"><strong>๕. พร้อมกับคำขอนี้ข้าพเจ้าได้แนบเอกสารหรือหลักฐานต่างๆ มาด้วย คือ</strong></div>
            <div style="margin-left:5%;font-size:20px"><strong>๕.๑ <u>กรณีขอรับใบอนุญาต (กรณีรายใหม่)</u></strong></div>
            <div style="margin-left:8%;font-size:20px"><strong>๕.๑.๑ กรณีขอรับใบอนุญาตขายวัตถุออกฤทธิ์ในประเภท ๓ หรือประเภท ๔</strong></div>
            <table style="width:90%;font-size:20px ;margin-left:10%">
                <tr>
                    <td>
                        (๑) สำเนาใบอนุญาตขายยาแผนปัจจุบันตามกฎหมายว่าด้วยยา
                    </td>
                </tr>
                <tr>
                    <td>
                        (๒) คำรับรองของผู้รับอนุญาตและเภสัชกรผู้ควบคุมกิจการ
                    </td>
                </tr>
                <tr>
                    <td>
                        (๓) รูปถ่ายหน้าตรง ไม่สวมหมวกและแว่นตาสีเข้ม ของผู้ขอรับใบอนุญาตหรือผู้ได้รับมอบหมายหรือแต่งตั้ง
                    </td>
                </tr>
                <tr>
                    <td>
                        ให้ดำเนินกิจการเกี่ยวกับใบอนุญาต ขนาด ๑ นิ้ว จำนวน ๓ รูป ซึ่งถ่ายไว้ไม่เกิน ๖ เดือนก่อนวันยื่นคำขอ
                    </td>
                </tr>
                <tr>
                    <td>
                        (๔) สำเนาใบอนุญาตประกอบวิชาชีพเภสัชกรรม
                    </td>
                </tr>
                <tr>
                    <td>
                        (๕) หนังสือแต่งตั้งผู้ดำเนินกิจการ กรณีผู้ขอรับใบอนุญาตเป็นนิติบุคคล
                    </td>
                </tr>
            </table>
            <div style="margin-left:8%;font-size:20px"><strong>๕.๑.๒ กรณีขอรับใบอนุญาตขายวัตถุออกฤทธิ์ในประเภท ๓ หรือประเภท ๔ โดยการขายส่งตรง</strong></div>
            <table style="width:90%;font-size:20px ;margin-left:10%">
                <tr>
                    <td>
                        (๑) สำเนาใบอนุญาตผลิต ขาย หรือนำเข้าวัตถุออกฤทธิ์ในประเภท ๓ หรือประเภท ๔ แล้วแต่กรณี
                    </td>
                </tr>
                <tr>
                    <td>
                        (๒) รูปถ่ายหน้าตรง ไม่สวมหมวกและแว่นตาสีเข้ม ของผู้ขอรับใบอนุญาตหรือผู้ได้รับมอบหมายหรือแต่งตั้งให้
                    </td>
                </tr>
                <tr>
                    <td>
                        ดำเนินกิจการเกี่ยวกับใบอนุญาต ขนาด ๑ นิ้ว จำนวน ๓ รูป ซึ่งถ่ายไว้ไม่เกิน ๖ เดือนก่อนวันยื่นคำขอ
                    </td>
                </tr>
            </table>
            <div style="margin-left:8%;font-size:20px"><strong>๕.๑.๓ กรณีขอรับใบอนุญาตขายวัตถุออกฤทธฺิ์ในประเภท ๓ หรือประเภท ๔ ในบริเวณสถานที่ที่มีการประชุม</strong></div>
            <table style="width:90%;font-size:20px ;margin-left:10%">
                <tr>
                    <td>
                        (๑) สำเนาใบอนุญาตผลิต ขาย หรือนำเข้าวัตถุออกฤทธิ์ในประเภท ๓ หรือประเภท ๔ แล้วแต่กรณี
                    </td>
                </tr>
            </table>

            <div style="margin-left:5%;font-size:20px"><strong>๕.๒ กรณีขอต่ออายุใบอนุญาต</strong></div>
            <table style="width:90%;font-size:20px ;margin-left:10%">
                <tr>
                    <td>
                        (๑) ใบอนุญาตฉบับเดิม
                    </td>
                </tr>
                <tr>
                    <td>
                        (๒) รูปถ่ายหน้าตรง ไม่สวมหมวกและแว่นตาสีเข้ม ของผู้ขอรับใบอนุญาตหรือผู้ได้รับมอบหมายหรือแต่งตั้งให้ดำเนินกิจการ
                        เกี่ยวกับใบอนุญาต ขนาด ๑ นิ้ว จำนวน ๓ รูป ซึ่งถ่ายไว้ไม่เกิน ๖ เดือนก่อนวันยื่นคำขอ
                    </td>
                </tr>

            </table>
            <div style="margin-left:5%;font-size:20px"><strong>๕.๓ กรณีขอรับใบแทนใบอนุญาต</strong></div>
            <table style="width:90%;font-size:20px ;margin-left:10%">
                <tr>
                    <td>
                        (๑) ใบแจ้งความ กรณีใบอนุญาตสูญหาย
                    </td>
                </tr>
                <tr>
                    <td>
                        (๒) ใบอนุญาต กรณีใบอนุญาตดังกล่าวถูกทำลายบางส่วนหรือลบเลือนในสาระสำคัญ
                    </td>
                </tr>
                <tr>
                    <td>
                        (๓) รูปถ่ายหน้าตรง ไม่สวมหมวกและแว่นตาสีเข้ม ของผู้ขอรับใบอนุญาตหรือผู้ได้รับมอบหมายหรือแต่งตั้งให้ดำเนินกิจการเกี่ยวกับ
                        ใบอนุญาต ขนาด ๑ นิ้ว จำนวน ๓ รูป ซึ่งถ่ายไว้ไม่เกิน ๖ เดือนก่อนวันยื่นคำขอ
                    </td>
                </tr>

            </table>
            <div style="margin-left:5%;font-size:20px;text-align:center"><strong>ข้าพเจ้าขอรับรองว่า ข้อความและเอกสารหรือหลักฐานทั้งหมดที่ยื่นเพื่อประกอบคำขอรับใบอนุญาตเป็นความจริงทุกประการ</strong></div>
            <br />
            <div>
                <h2 style="font-family:'Taviraj';font-size:20px;">
                    ไฟล์แนบ
                </h2>
                <table class="table" style="width:100%">
                    <tr>
                        <td>ชื่อไฟล์</td>
                        <td></td>
                    </tr>
                    <tr ng-repeat="datas in LIST_File.FILE_LISTs" style="background-color:#FDFCE3">
                        <td>{{datas.FILENAME}}</td>
                        <td>
                            <a ng-show="datas.PATH != null && datas.PATH != ''" ng-click="OPEN_DOC_PATH(datas.PATH,datas.FILENAME)">ดูเอกสาร</a>
                        </td>
                    </tr>
                </table>
            </div>
            <br />
            <br />

            <table style="width:85%;font-size:20px ;margin-left:12.5%">
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
                        <label>{{LIST_LCN.BSN_THAIFULLNAME}}</label>
                    </td>
                    <td style="text-align:left">
                        )
                    </td>
                </tr>

            </table>
            <br />
            <br />

            <div style="margin-left:5%;font-size:20px"> หมายเหตุ : (๑) ให้ขีดเลือกข้อความในช่อง ☐/〇 ให้ตรงตามที่ประสงค์จะดำเนินการ</div>
            <table style="width:90%;font-size:20px ;margin-left:12.5%">
                <tr>
                    <td>
                        (๒) รับรองสำเนาถูกต้องในเอกสารที่เป็นสำเนาทุกฉบับ
                    </td>
                </tr>
                <tr>
                    <td>
                        (๓) กรณีเอกสารหรือหลักฐานที่ออกโดยสำนักงานคณะกรรมการอาหารและยา ผู้อนุญาตอาจไม่ขอเอกสารหรือหลักฐานดังกล่าวได้
                    </td>
                </tr>

            </table>
            <br />

        </div>
    </div>

    <div ng-show="LIST_LCN.PROCESS == '100775'">
        <div style="font-family:'Taviraj';font-size:24px;">
            <h1 style="text-align:left;font-size:24px;">
                <strong>แบบ ข.ว.จ. ๓/๔-๑</strong>
            </h1>
            <br />
            <div class="title1">
                <label style="font-size:16px;margin-top:25px">
                    ที่ปิดรูปถ่าย<br />
                    ผู้ขออนุญาติ<br />
                    หรือ<br />
                    ผู้ดำเนินกิจการ<br />
                    ขนาด ๓ นิ้ว<br />
                </label>
            </div>

            <div class="title2">
                <table style="font-size:20px;width:95%;margin-top:10px;margin-left:10px">
                    <tr>
                        <td style="text-align:left;width:20%">
                            เลขรับที่
                        </td>

                        <td colspan="3" style="border-bottom:dotted;border-bottom-width:thin;">
                            <label>{{LCN_LIST.RCVNO_DISPLAY}}</label>
                        </td>
                    </tr>
                    <tr>
                        <td style="text-align:left">
                            วันที่
                        </td>

                        <td colspan="3" style="border-bottom:dotted;border-bottom-width:thin;">
                            <label>{{LCN_LIST.RCV_DATE_DISPLAY}}</label>
                        </td>
                    </tr>
                    <tr>
                        <td style="text-align:left">
                            ลงชื่่อ

                        </td>

                        <td style="border-bottom:dotted;border-bottom-width:thin;"></td>
                        <td style="text-align:right;width:25%">
                            ผู้รับคำขอ
                        </td>
                    </tr>
                </table>

            </div>


            <div style="clear:both"></div>
            <br />
            <br />

            <h2 style="text-align:center;font-size:24px;">
                <strong>คำขอรับใบอนุญาต คำขอต่ออายุใบอนุญาต คำขอรับใบแทน</strong><br />
                <strong>ใบอนุญาตขายวัตถุออกฤทธิ์ในประเภท ๓ หรือประเภท ๔</strong>
            </h2>
            @*process =123,124 *@
            <table style="width:70%; font-size:20px;margin:auto;text-align:center">
                <tr>
                    <td>
                        <strong>สำหรับขาย</strong>
                    </td>
                    <td>
                        <input type="radio" name="gender" ng-model="LIST_LCN.PROCESS" ng-value="100766" id="rdl_CHK_SELL_TYPE" disabled="disabled" /> <strong>วัตถุออกฤทธิ์ในประเภท ๓</strong>
                    </td>
                    <td>
                        <input type="radio" name="gender" ng-model="LIST_LCN.PROCESS" ng-value="100767" id="rdl_CHK_SELL_TYPE" disabled="disabled" /> <strong>วัตถุออกฤทธิ์ในประเภท ๔</strong>
                    </td>
                </tr>
                <tr>
                    <td style="font-size:16px" colspan="3">
                        <strong>(คำขอ ๑ ฉบับ ให้ยื่นขอได้เพียงหนึ่งประเภทเท่านั้น)</strong>
                    </td>
                </tr>
            </table>

            <table style="width:100%; font-size:20px">
                <tr>
                    <td style="width:20%">
                        <input type="checkbox" name="gender" disabled="disabled" /> <strong>ขอรับใบอนุญาต</strong>
                    </td>
                </tr>
                <tr>
                    <td>
                        <input type="checkbox" name="gender" disabled="disabled" /> <strong>ขอต่ออายุใบอนุญาตเลขที่</strong>
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;"></td>
                    <td style="width:10%">
                        <strong>ประจำปี พ.ศ.</strong>
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;"></td>
                </tr>
                <tr>
                    <td>
                        <input type="checkbox" name="gender" disabled="disabled" ng-checked="true" /> <strong>ขอรับใบแทนใบอนุญาต</strong>
                    </td>
                    <td>
                        เนื่องจากใบอนุญาต
                    </td>
                    <td colspan="2">

                        <form name="frm_lost_type">


                            <label><input type="radio" ng-model="LIST_LCN.DALCN_NCT_SUBSTITUTE.PURPOSE_ID" id="rdl_lost_type" value="1"> สูญหาย</label>
                            <label><input type="radio" ng-model="LIST_LCN.DALCN_NCT_SUBSTITUTE.PURPOSE_ID" id="rdl_lost_type" value="2"> ถูกทำลายหรือลบเลือนในสาระสำคัญ</label><br />

                        </form>



                    </td>

                </tr>
            </table>
            <br />

            <table style="width:100%">
                <tr>
                    <td style="text-align:right;width:90%">
                        เขียนที่
                    </td>
                    <td style="width:40%;border-bottom:dotted;border-bottom-width:thin;">

                        {{LIST_LCN.DALCN_NCT_SUBSTITUTE.WRITE_AT}}
                    </td>
                </tr>
                <tr>
                    <td style="text-align:right;width:100px">
                        วันที่
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;">

                        {{LIST_LCN.DALCN_NCT_SUBTITUTE.WRITE_DATE}}
                    </td>
                </tr>
            </table>
            <br />

            <h2 style="font-size:24px;">
                <strong>๑. ข้อมูลผู้ขอรับใบอนุญาต</strong>
            </h2>
            <table style="width:90%">
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
            <table style="width:90%">
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
                    <td style="text-align:left;width:30%;border-bottom:dotted;border-bottom-width:thin;">
                        <form action="javascript:void(0)">
                            <table>
                                <tr>
                                    <td style="border-bottom:dotted;border-bottom-width:thin;">
                                        @*<input class="form-control inline" ng-model="LIST_LCN.BSN_IDENTIFY" id="txt_bsn_identify" style="font-family:'Taviraj';" type="text" />*@
                                        {{LIST_LCN.BSN_IDENTIFY}}
                                    </td>
                                    @*<td>
                                            <input type="button" value="ค้นหาผู้ดำเนินฯ" ng-click="BTN_Search_BSN(LIST_LCN.BSN_IDENTIFY)" />
                                        </td>*@
                                </tr>
                            </table>


                        </form>
                        <label>{{LIST_LCN.BSN_THAIFULLNAME}}</label>
                    </td>
                </tr>
                <tr>
                    <td style="font-size:20px">
                        หรือบัตรประจำตัวอื่นที่ทางราชการออกให้ คือ
                    </td>
                    <td style="font-size:20px;width:20%;border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_LCN.BSN_IDENTIFY}}</label>
                    </td>
                    <td style="font-size:20px;width:5%">
                        เลขที่
                    </td>
                    <td style="font-size:20px ;width:15%;text-align:center"></td>
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
                        <label>{{LIST_LCN.BSN_FULL_ADDR}}</label>
                    </td>
                </tr>
                <tr>
                    <td style="font-size:20px">
                        โทรศัพท์/มือถือ
                    </td>
                    <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;" colspan="6">
                        <label>{{LIST_LCN.BSN_TELEPHONE}}</label>
                    </td>
                </tr>
            </table>

            <div style="font-size:20px"><strong>๓. ข้อมูลการขออนุญาต</strong></div>
            <div style="font-size:20px;margin-left:5%">(๓.๑) <strong><u>กรณีขายวัตถุออกฤทธฺิ์ในประเภท ๓ หรือประเภท ๔</u></strong></div>
            <table style="width:100%;font-size:20px">
                <tr>
                    <td>
                        ณ สถานที่ชื่อ
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_LCN.THANAMEPLACE}}</label>
                    </td>
                    <td>
                        เลขรหัสประจำบ้าน
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_LCN.HOUSENO}}</label>
                    </td>
                </tr>
                <tr>
                    <td>
                        ตั้งอยู่เลขที่
                    </td>
                    <td colspan="3" style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_LCN.fulladdr3}}</label>
                    </td>
                </tr>
                <tr>
                    <td>
                        โทรศัพท์/มือถือ
                    </td>
                    <td colspan="3" style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_LCN.tel}}</label>
                    </td>
                </tr>

            </table>
            <table style="width:100%;font-size:20px" ng-init="getdetails_phr()">
                <tr>
                    <td style="width:15%;">
                        โดยมีเภสัชกรชื่อ  1.
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;width:15%;">
                        <label>{{LIST_PHR.PHR_NAME}}</label>
                    </td>
                    <td style="width:15%">
                        ใบอนุญาตประกอบวิชาชีพเภสัชกรรมเลขที่
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_PHR.PHR_TEXT_NUM}}</label>
                    </td>
                </tr>
            </table>
            <br />
            @*<input type="button" style="font-size:20px;width:100px" value="เพิ่ม" />*@
            @*<input type="button" style="font-size:20px;width:100px;margin-left:10px" value="ลบ" />*@
            <br />
            <table style="width:100%;font-size:20px">
                <tr>
                    <td>
                        เป็นผู้รับอนุญาตขายยาแผนใบอนุญาตเลขที่
                    </td>
                    <td style="width:50%; border-bottom:dotted;border-bottom-width:thin; ">
                        <label>{{LIST_LCN.HEAD_LCNNO_NCT}}</label>
                    </td>
                    <td>
                        ตามกฎหมายว่าด้วยยา
                    </td>
                </tr>
            </table>
            <div style="font-size:20px">เป็นผู้ควบคุมตามมาตรา ๕๓ แห่งพระราชบัญญัติวัตถุที่ออกฤทธิ์ต่อจิตและประสาท พ.ศ. ๒๕๕๙</div>

            <div style="font-size:20px;margin-left:5%"><strong>(๓.๒) <u>กรณีขายวัตถุออกฤทธฺิ์ในประเภท ๓ หรือประเภท ๔ โดยการขายส่งตรง</u></strong></div>
            <table style="width:100%;font-size:20px">
                <tr>
                    <td colspan="2">
                        ผู้ขอรับใบอนุญาตได้รับอนุญาตให้ผลิต/ขาย/หรือนำเข้าซึ่งวัตถุออกฤทธิ์ในประเภท ๓ หรือประเภท ๔ ตามใบอนุญาต
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        ผู้ขอรับใบอนุญาตได้รับอนุญาตให้ผลิต/ขาย/หรือนำเข้าซึ่งวัตถุออกฤทธิ์ในประเภท ๓ หรือประเภท ๔ ตามใบอนุญาต
                    </td>
                </tr>
                <tr>
                    <td style="width:10%">
                        เลขที่
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_LCN.HEAD_LCNNO}}</label>
                    </td>
                </tr>
            </table>
            <div style="font-size:20px;margin-left:5%"><strong>(๓.๓) <u> กรณีขายวัตถุออกฤทธฺิ์ในประเภท ๓ หรือประเภท ๔ ในบริเวณสถานที่ที่มีการประชุม</u></strong></div>

            <table style="width:100%;font-size:20px">
                <tr>
                    <td colspan="4">
                        ผู้ขอรับใบอนุญาตได้รับอนุญาตให้ผลิต/ขาย/หรือนำเข้าซึ่งวัตถุออกฤทธิ์ในประเภท ๓ หรือประเภท ๔ ตามใบอนุญาต
                    </td>
                </tr>
                <tr>
                    <td style="width:20%">
                        เลขที่
                    </td>
                    <td colspan="4" style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_LCN.HEAD_LCNNO}}</label>
                    </td>
                </tr>
                <tr>
                    <td colspan="4">
                        ขอรับใบอนุญาตขายวัตถุออกฤทธิ์ในบริเวณสถานที่ที่มีการประชุม ณ
                    </td>
                </tr>
                <tr>
                    <td style="width:10%">
                        สถานที่ชื่อ
                    </td>
                    <td colspan="4" style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_LCN.thanameplace}}</label>
                    </td>
                </tr>
                <tr>
                    <td>
                        เลขรหัสประจำบ้าน
                    </td>
                    <td colspan="4" style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_LCN.HOUSENO}}</label>
                    </td>
                </tr>
                <tr>
                    <td>
                        ตั้งอยู่เลขที่
                    </td>
                    <td colspan="3" style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_LCN.fulladdr2}}</label>
                    </td>
                </tr>
                <tr>
                    <td>
                        โทรศัพท์/มือถือ
                    </td>
                    <td colspan="3" style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_LCN.tel}}</label>
                    </td>
                </tr>
                <tr>
                    <td>
                        ตั้งแต่วันที่
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;"></td>
                    <td style="width:20%">
                        ถึงวันที่
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;"></td>
                </tr>
            </table>

            <table style="width:100%;font-size:20px" ng-init="getdetails_keep()">
                <tr>
                    <td colspan="7">
                        <p>
                            <strong>
                                ๔. ข้อมูลสถานที่เก็บ (กรณีเป็นสถานที่คนละแห่งกับสถานที่ตาม ๓)
                            </strong>
                        </p>
                    </td>
                </tr>
                <tr>
                    <td style="width:17%">
                        ณ สถานที่ชื่อ
                    </td>
                    <td colspan="4" style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_KEEP.KEEP_THANAMEPLACE}}</label>
                    </td>
                    <td style="width:15%">
                        เลขรหัสประจำบ้าน
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_KEEP.HOUSENO}}</label>
                    </td>
                </tr>
                <tr>
                    <td>
                        อยู่เลขที่
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_KEEP.KEEP_FULL_ADDR}}</label>
                    </td>
                </tr>
                <tr>
                    <td>
                        โทรศัพท์ / มือถือ
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_KEEP.KEEP_TEL}}</label>
                    </td>
                </tr>

            </table>
            @*<input type="button" style="font-size:20px;width:100px" value="เพิ่ม" />*@
            @*<input type="button" style="font-size:20px;width:100px;margin-left:10px" value="ลบ" />*@
            <br />
            <br />

            <div style=";font-size:20px"><strong>๕. พร้อมกับคำขอนี้ข้าพเจ้าได้แนบเอกสารหรือหลักฐานต่างๆ มาด้วย คือ</strong></div>
            <div style="margin-left:5%;font-size:20px"><strong>๕.๑ <u>กรณีขอรับใบอนุญาต (กรณีรายใหม่)</u></strong></div>
            <div style="margin-left:8%;font-size:20px"><strong>๕.๑.๑ กรณีขอรับใบอนุญาตขายวัตถุออกฤทธิ์ในประเภท ๓ หรือประเภท ๔</strong></div>
            <table style="width:90%;font-size:20px ;margin-left:10%">
                <tr>
                    <td>
                        (๑) สำเนาใบอนุญาตขายยาแผนปัจจุบันตามกฎหมายว่าด้วยยา
                    </td>
                </tr>
                <tr>
                    <td>
                        (๒) คำรับรองของผู้รับอนุญาตและเภสัชกรผู้ควบคุมกิจการ
                    </td>
                </tr>
                <tr>
                    <td>
                        (๓) รูปถ่ายหน้าตรง ไม่สวมหมวกและแว่นตาสีเข้ม ของผู้ขอรับใบอนุญาตหรือผู้ได้รับมอบหมายหรือแต่งตั้ง
                    </td>
                </tr>
                <tr>
                    <td>
                        ให้ดำเนินกิจการเกี่ยวกับใบอนุญาต ขนาด ๑ นิ้ว จำนวน ๓ รูป ซึ่งถ่ายไว้ไม่เกิน ๖ เดือนก่อนวันยื่นคำขอ
                    </td>
                </tr>
                <tr>
                    <td>
                        (๔) สำเนาใบอนุญาตประกอบวิชาชีพเภสัชกรรม
                    </td>
                </tr>
                <tr>
                    <td>
                        (๕) หนังสือแต่งตั้งผู้ดำเนินกิจการ กรณีผู้ขอรับใบอนุญาตเป็นนิติบุคคล
                    </td>
                </tr>
            </table>
            <div style="margin-left:8%;font-size:20px"><strong>๕.๑.๒ กรณีขอรับใบอนุญาตขายวัตถุออกฤทธิ์ในประเภท ๓ หรือประเภท ๔ โดยการขายส่งตรง</strong></div>
            <table style="width:90%;font-size:20px ;margin-left:10%">
                <tr>
                    <td>
                        (๑) สำเนาใบอนุญาตผลิต ขาย หรือนำเข้าวัตถุออกฤทธิ์ในประเภท ๓ หรือประเภท ๔ แล้วแต่กรณี
                    </td>
                </tr>
                <tr>
                    <td>
                        (๒) รูปถ่ายหน้าตรง ไม่สวมหมวกและแว่นตาสีเข้ม ของผู้ขอรับใบอนุญาตหรือผู้ได้รับมอบหมายหรือแต่งตั้งให้
                    </td>
                </tr>
                <tr>
                    <td>
                        ดำเนินกิจการเกี่ยวกับใบอนุญาต ขนาด ๑ นิ้ว จำนวน ๓ รูป ซึ่งถ่ายไว้ไม่เกิน ๖ เดือนก่อนวันยื่นคำขอ
                    </td>
                </tr>
            </table>
            <div style="margin-left:8%;font-size:20px"><strong>๕.๑.๓ กรณีขอรับใบอนุญาตขายวัตถุออกฤทธฺิ์ในประเภท ๓ หรือประเภท ๔ ในบริเวณสถานที่ที่มีการประชุม</strong></div>
            <table style="width:90%;font-size:20px ;margin-left:10%">
                <tr>
                    <td>
                        (๑) สำเนาใบอนุญาตผลิต ขาย หรือนำเข้าวัตถุออกฤทธิ์ในประเภท ๓ หรือประเภท ๔ แล้วแต่กรณี
                    </td>
                </tr>
            </table>

            <div style="margin-left:5%;font-size:20px"><strong>๕.๒ กรณีขอต่ออายุใบอนุญาต</strong></div>
            <table style="width:90%;font-size:20px ;margin-left:10%">
                <tr>
                    <td>
                        (๑) ใบอนุญาตฉบับเดิม
                    </td>
                </tr>
                <tr>
                    <td>
                        (๒) รูปถ่ายหน้าตรง ไม่สวมหมวกและแว่นตาสีเข้ม ของผู้ขอรับใบอนุญาตหรือผู้ได้รับมอบหมายหรือแต่งตั้งให้ดำเนินกิจการ
                        เกี่ยวกับใบอนุญาต ขนาด ๑ นิ้ว จำนวน ๓ รูป ซึ่งถ่ายไว้ไม่เกิน ๖ เดือนก่อนวันยื่นคำขอ
                    </td>
                </tr>

            </table>
            <div style="margin-left:5%;font-size:20px"><strong>๕.๓ กรณีขอรับใบแทนใบอนุญาต</strong></div>
            <table style="width:90%;font-size:20px ;margin-left:10%">
                <tr>
                    <td>
                        (๑) ใบแจ้งความ กรณีใบอนุญาตสูญหาย
                    </td>
                </tr>
                <tr>
                    <td>
                        (๒) ใบอนุญาต กรณีใบอนุญาตดังกล่าวถูกทำลายบางส่วนหรือลบเลือนในสาระสำคัญ
                    </td>
                </tr>
                <tr>
                    <td>
                        (๓) รูปถ่ายหน้าตรง ไม่สวมหมวกและแว่นตาสีเข้ม ของผู้ขอรับใบอนุญาตหรือผู้ได้รับมอบหมายหรือแต่งตั้งให้ดำเนินกิจการเกี่ยวกับ
                        ใบอนุญาต ขนาด ๑ นิ้ว จำนวน ๓ รูป ซึ่งถ่ายไว้ไม่เกิน ๖ เดือนก่อนวันยื่นคำขอ
                    </td>
                </tr>

            </table>
            <div style="margin-left:5%;font-size:20px;text-align:center"><strong>ข้าพเจ้าขอรับรองว่า ข้อความและเอกสารหรือหลักฐานทั้งหมดที่ยื่นเพื่อประกอบคำขอรับใบอนุญาตเป็นความจริงทุกประการ</strong></div>
            <br />
            <div>
                <h2 style="font-family:'Taviraj';font-size:20px;">
                    ไฟล์แนบ
                </h2>
                <table class="table" style="width:100%">
                    <tr>
                        <td>ชื่อไฟล์</td>
                        <td></td>
                    </tr>
                    <tr ng-repeat="datas in LIST_File.FILE_LISTs" style="background-color:#FDFCE3">
                        <td>{{datas.FILENAME}}</td>
                        <td>
                            <a ng-show="datas.PATH != null && datas.PATH != ''" ng-click="OPEN_DOC_PATH(datas.PATH,datas.FILENAME)">ดูเอกสาร</a>
                        </td>
                    </tr>
                </table>
            </div>
            <br />
            <br />

            <table style="width:85%;font-size:20px ;margin-left:12.5%">
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
                        <label>{{LIST_LCN.BSN_THAIFULLNAME}}</label>
                    </td>
                    <td style="text-align:left">
                        )
                    </td>
                </tr>

            </table>
            <br />
            <br />

            <div style="margin-left:5%;font-size:20px"> หมายเหตุ : (๑) ให้ขีดเลือกข้อความในช่อง ☐/〇 ให้ตรงตามที่ประสงค์จะดำเนินการ</div>
            <table style="width:90%;font-size:20px ;margin-left:12.5%">
                <tr>
                    <td>
                        (๒) รับรองสำเนาถูกต้องในเอกสารที่เป็นสำเนาทุกฉบับ
                    </td>
                </tr>
                <tr>
                    <td>
                        (๓) กรณีเอกสารหรือหลักฐานที่ออกโดยสำนักงานคณะกรรมการอาหารและยา ผู้อนุญาตอาจไม่ขอเอกสารหรือหลักฐานดังกล่าวได้
                    </td>
                </tr>

            </table>
            <br />

        </div>
    </div>

    <div ng-show="LIST_LCN.PROCESS == '100776'">
        <div style="font-family:'Taviraj';font-size:24px;">
            <h1 style="text-align:left;font-size:24px;">
                <strong>แบบ ข.ว.จ. ๓/๔-๑</strong>
            </h1>
            <br />
            <div class="title1">
                <label style="font-size:16px;margin-top:25px">
                    ที่ปิดรูปถ่าย<br />
                    ผู้ขออนุญาติ<br />
                    หรือ<br />
                    ผู้ดำเนินกิจการ<br />
                    ขนาด ๓ นิ้ว<br />
                </label>
            </div>

            <div class="title2">
                <table style="font-size:20px;width:95%;margin-top:10px;margin-left:10px">
                    <tr>
                        <td style="text-align:left;width:20%">
                            เลขรับที่
                        </td>

                        <td colspan="3" style="border-bottom:dotted;border-bottom-width:thin;">
                            <label>{{LCN_LIST.RCVNO_DISPLAY}}</label>
                        </td>
                    </tr>
                    <tr>
                        <td style="text-align:left">
                            วันที่
                        </td>

                        <td colspan="3" style="border-bottom:dotted;border-bottom-width:thin;">
                            <label>{{LCN_LIST.RCV_DATE_DISPLAY}}</label>
                        </td>
                    </tr>
                    <tr>
                        <td style="text-align:left">
                            ลงชื่่อ

                        </td>

                        <td style="border-bottom:dotted;border-bottom-width:thin;"></td>
                        <td style="text-align:right;width:25%">
                            ผู้รับคำขอ
                        </td>
                    </tr>
                </table>

            </div>


            <div style="clear:both"></div>
            <br />
            <br />

            <h2 style="text-align:center;font-size:24px;">
                <strong>คำขอรับใบอนุญาต คำขอต่ออายุใบอนุญาต คำขอรับใบแทน</strong><br />
                <strong>ใบอนุญาตขายวัตถุออกฤทธิ์ในประเภท ๓ หรือประเภท ๔</strong>
            </h2>
            @*process =123,124 *@
            <table style="width:70%; font-size:20px;margin:auto;text-align:center">
                <tr>
                    <td>
                        <strong>สำหรับขาย</strong>
                    </td>
                    <td>
                        <input type="radio" name="gender" ng-model="LIST_LCN.PROCESS" ng-value="100766" id="rdl_CHK_SELL_TYPE" disabled="disabled" /> <strong>วัตถุออกฤทธิ์ในประเภท ๓</strong>
                    </td>
                    <td>
                        <input type="radio" name="gender" ng-model="LIST_LCN.PROCESS" ng-value="100767" id="rdl_CHK_SELL_TYPE" disabled="disabled" /> <strong>วัตถุออกฤทธิ์ในประเภท ๔</strong>
                    </td>
                </tr>
                <tr>
                    <td style="font-size:16px" colspan="3">
                        <strong>(คำขอ ๑ ฉบับ ให้ยื่นขอได้เพียงหนึ่งประเภทเท่านั้น)</strong>
                    </td>
                </tr>
            </table>

            <table style="width:100%; font-size:20px">
                <tr>
                    <td style="width:20%">
                        <input type="checkbox" name="gender" disabled="disabled" /> <strong>ขอรับใบอนุญาต</strong>
                    </td>
                </tr>
                <tr>
                    <td>
                        <input type="checkbox" name="gender" disabled="disabled" /> <strong>ขอต่ออายุใบอนุญาตเลขที่</strong>
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;"></td>
                    <td style="width:10%">
                        <strong>ประจำปี พ.ศ.</strong>
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;"></td>
                </tr>
                <tr>
                    <td>
                        <input type="checkbox" name="gender" disabled="disabled" ng-checked="true" /> <strong>ขอรับใบแทนใบอนุญาต</strong>
                    </td>
                    <td>
                        เนื่องจากใบอนุญาต
                    </td>
                    <td colspan="2">

                        <form name="frm_lost_type">


                            <label><input type="radio" ng-model="LIST_LCN.DALCN_NCT_SUBSTITUTE.PURPOSE_ID" id="rdl_lost_type" value="1"> สูญหาย</label>
                            <label><input type="radio" ng-model="LIST_LCN.DALCN_NCT_SUBSTITUTE.PURPOSE_ID" id="rdl_lost_type" value="2"> ถูกทำลายหรือลบเลือนในสาระสำคัญ</label><br />

                        </form>



                    </td>

                </tr>
            </table>
            <br />

            <table style="width:100%">
                <tr>
                    <td style="text-align:right;width:90%">
                        เขียนที่
                    </td>
                    <td style="width:40%;border-bottom:dotted;border-bottom-width:thin;">

                        {{LIST_LCN.DALCN_NCT_SUBSTITUTE.WRITE_AT}}
                    </td>
                </tr>
                <tr>
                    <td style="text-align:right;width:100px">
                        วันที่
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;">

                        {{LIST_LCN.DALCN_NCT_SUBTITUTE.WRITE_DATE}}
                    </td>
                </tr>
            </table>
            <br />

            <h2 style="font-size:24px;">
                <strong>๑. ข้อมูลผู้ขอรับใบอนุญาต</strong>
            </h2>
            <table style="width:90%">
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
            <table style="width:90%">
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
                    <td style="text-align:left;width:30%;border-bottom:dotted;border-bottom-width:thin;">
                        <form action="javascript:void(0)">
                            <table>
                                <tr>
                                    <td style="border-bottom:dotted;border-bottom-width:thin;">
                                        @*<input class="form-control inline" ng-model="LIST_LCN.BSN_IDENTIFY" id="txt_bsn_identify" style="font-family:'Taviraj';" type="text" />*@
                                        {{LIST_LCN.BSN_IDENTIFY}}
                                    </td>
                                    @*<td>
                                            <input type="button" value="ค้นหาผู้ดำเนินฯ" ng-click="BTN_Search_BSN(LIST_LCN.BSN_IDENTIFY)" />
                                        </td>*@
                                </tr>
                            </table>


                        </form>
                        <label>{{LIST_LCN.BSN_THAIFULLNAME}}</label>
                    </td>
                </tr>
                <tr>
                    <td style="font-size:20px">
                        หรือบัตรประจำตัวอื่นที่ทางราชการออกให้ คือ
                    </td>
                    <td style="font-size:20px;width:20%;border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_LCN.BSN_IDENTIFY}}</label>
                    </td>
                    <td style="font-size:20px;width:5%">
                        เลขที่
                    </td>
                    <td style="font-size:20px ;width:15%;text-align:center"></td>
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
                        <label>{{LIST_LCN.BSN_FULL_ADDR}}</label>
                    </td>
                </tr>
                <tr>
                    <td style="font-size:20px">
                        โทรศัพท์/มือถือ
                    </td>
                    <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;" colspan="6">
                        <label>{{LIST_LCN.BSN_TELEPHONE}}</label>
                    </td>
                </tr>
            </table>

            <div style="font-size:20px"><strong>๓. ข้อมูลการขออนุญาต</strong></div>
            <div style="font-size:20px;margin-left:5%">(๓.๑) <strong><u>กรณีขายวัตถุออกฤทธฺิ์ในประเภท ๓ หรือประเภท ๔</u></strong></div>
            <table style="width:100%;font-size:20px">
                <tr>
                    <td>
                        ณ สถานที่ชื่อ
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_LCN.THANAMEPLACE}}</label>
                    </td>
                    <td>
                        เลขรหัสประจำบ้าน
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_LCN.HOUSENO}}</label>
                    </td>
                </tr>
                <tr>
                    <td>
                        ตั้งอยู่เลขที่
                    </td>
                    <td colspan="3" style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_LCN.fulladdr3}}</label>
                    </td>
                </tr>
                <tr>
                    <td>
                        โทรศัพท์/มือถือ
                    </td>
                    <td colspan="3" style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_LCN.tel}}</label>
                    </td>
                </tr>

            </table>
            <table style="width:100%;font-size:20px" ng-init="getdetails_phr()">
                <tr>
                    <td style="width:15%;">
                        โดยมีเภสัชกรชื่อ  1.
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;width:15%;">
                        <label>{{LIST_PHR.PHR_NAME}}</label>
                    </td>
                    <td style="width:15%">
                        ใบอนุญาตประกอบวิชาชีพเภสัชกรรมเลขที่
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_PHR.PHR_TEXT_NUM}}</label>
                    </td>
                </tr>
            </table>
            <br />
            @*<input type="button" style="font-size:20px;width:100px" value="เพิ่ม" />*@
            @*<input type="button" style="font-size:20px;width:100px;margin-left:10px" value="ลบ" />*@
            <br />
            <table style="width:100%;font-size:20px">
                <tr>
                    <td>
                        เป็นผู้รับอนุญาตขายยาแผนใบอนุญาตเลขที่
                    </td>
                    <td style="width:50%; border-bottom:dotted;border-bottom-width:thin; ">
                        <label>{{LIST_LCN.HEAD_LCNNO_NCT}}</label>
                    </td>
                    <td>
                        ตามกฎหมายว่าด้วยยา
                    </td>
                </tr>
            </table>
            <div style="font-size:20px">เป็นผู้ควบคุมตามมาตรา ๕๓ แห่งพระราชบัญญัติวัตถุที่ออกฤทธิ์ต่อจิตและประสาท พ.ศ. ๒๕๕๙</div>

            <div style="font-size:20px;margin-left:5%"><strong>(๓.๒) <u>กรณีขายวัตถุออกฤทธฺิ์ในประเภท ๓ หรือประเภท ๔ โดยการขายส่งตรง</u></strong></div>
            <table style="width:100%;font-size:20px">
                <tr>
                    <td colspan="2">
                        ผู้ขอรับใบอนุญาตได้รับอนุญาตให้ผลิต/ขาย/หรือนำเข้าซึ่งวัตถุออกฤทธิ์ในประเภท ๓ หรือประเภท ๔ ตามใบอนุญาต
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        ผู้ขอรับใบอนุญาตได้รับอนุญาตให้ผลิต/ขาย/หรือนำเข้าซึ่งวัตถุออกฤทธิ์ในประเภท ๓ หรือประเภท ๔ ตามใบอนุญาต
                    </td>
                </tr>
                <tr>
                    <td style="width:10%">
                        เลขที่
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_LCN.HEAD_LCNNO}}</label>
                    </td>
                </tr>
            </table>
            <div style="font-size:20px;margin-left:5%"><strong>(๓.๓) <u> กรณีขายวัตถุออกฤทธฺิ์ในประเภท ๓ หรือประเภท ๔ ในบริเวณสถานที่ที่มีการประชุม</u></strong></div>

            <table style="width:100%;font-size:20px">
                <tr>
                    <td colspan="4">
                        ผู้ขอรับใบอนุญาตได้รับอนุญาตให้ผลิต/ขาย/หรือนำเข้าซึ่งวัตถุออกฤทธิ์ในประเภท ๓ หรือประเภท ๔ ตามใบอนุญาต
                    </td>
                </tr>
                <tr>
                    <td style="width:20%">
                        เลขที่
                    </td>
                    <td colspan="4" style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_LCN.HEAD_LCNNO}}</label>
                    </td>
                </tr>
                <tr>
                    <td colspan="4">
                        ขอรับใบอนุญาตขายวัตถุออกฤทธิ์ในบริเวณสถานที่ที่มีการประชุม ณ
                    </td>
                </tr>
                <tr>
                    <td style="width:10%">
                        สถานที่ชื่อ
                    </td>
                    <td colspan="4" style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_LCN.thanameplace}}</label>
                    </td>
                </tr>
                <tr>
                    <td>
                        เลขรหัสประจำบ้าน
                    </td>
                    <td colspan="4" style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_LCN.HOUSENO}}</label>
                    </td>
                </tr>
                <tr>
                    <td>
                        ตั้งอยู่เลขที่
                    </td>
                    <td colspan="3" style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_LCN.fulladdr2}}</label>
                    </td>
                </tr>
                <tr>
                    <td>
                        โทรศัพท์/มือถือ
                    </td>
                    <td colspan="3" style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_LCN.tel}}</label>
                    </td>
                </tr>
                <tr>
                    <td>
                        ตั้งแต่วันที่
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;"></td>
                    <td style="width:20%">
                        ถึงวันที่
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;"></td>
                </tr>
            </table>

            <table style="width:100%;font-size:20px" ng-init="getdetails_keep()">
                <tr>
                    <td colspan="7">
                        <p>
                            <strong>
                                ๔. ข้อมูลสถานที่เก็บ (กรณีเป็นสถานที่คนละแห่งกับสถานที่ตาม ๓)
                            </strong>
                        </p>
                    </td>
                </tr>
                <tr>
                    <td style="width:17%">
                        ณ สถานที่ชื่อ
                    </td>
                    <td colspan="4" style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_KEEP.KEEP_THANAMEPLACE}}</label>
                    </td>
                    <td style="width:15%">
                        เลขรหัสประจำบ้าน
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_KEEP.HOUSENO}}</label>
                    </td>
                </tr>
                <tr>
                    <td>
                        อยู่เลขที่
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_KEEP.KEEP_FULL_ADDR}}</label>
                    </td>
                </tr>
                <tr>
                    <td>
                        โทรศัพท์ / มือถือ
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_KEEP.KEEP_TEL}}</label>
                    </td>
                </tr>

            </table>
            @*<input type="button" style="font-size:20px;width:100px" value="เพิ่ม" />*@
            @*<input type="button" style="font-size:20px;width:100px;margin-left:10px" value="ลบ" />*@
            <br />
            <br />

            <div style=";font-size:20px"><strong>๕. พร้อมกับคำขอนี้ข้าพเจ้าได้แนบเอกสารหรือหลักฐานต่างๆ มาด้วย คือ</strong></div>
            <div style="margin-left:5%;font-size:20px"><strong>๕.๑ <u>กรณีขอรับใบอนุญาต (กรณีรายใหม่)</u></strong></div>
            <div style="margin-left:8%;font-size:20px"><strong>๕.๑.๑ กรณีขอรับใบอนุญาตขายวัตถุออกฤทธิ์ในประเภท ๓ หรือประเภท ๔</strong></div>
            <table style="width:90%;font-size:20px ;margin-left:10%">
                <tr>
                    <td>
                        (๑) สำเนาใบอนุญาตขายยาแผนปัจจุบันตามกฎหมายว่าด้วยยา
                    </td>
                </tr>
                <tr>
                    <td>
                        (๒) คำรับรองของผู้รับอนุญาตและเภสัชกรผู้ควบคุมกิจการ
                    </td>
                </tr>
                <tr>
                    <td>
                        (๓) รูปถ่ายหน้าตรง ไม่สวมหมวกและแว่นตาสีเข้ม ของผู้ขอรับใบอนุญาตหรือผู้ได้รับมอบหมายหรือแต่งตั้ง
                    </td>
                </tr>
                <tr>
                    <td>
                        ให้ดำเนินกิจการเกี่ยวกับใบอนุญาต ขนาด ๑ นิ้ว จำนวน ๓ รูป ซึ่งถ่ายไว้ไม่เกิน ๖ เดือนก่อนวันยื่นคำขอ
                    </td>
                </tr>
                <tr>
                    <td>
                        (๔) สำเนาใบอนุญาตประกอบวิชาชีพเภสัชกรรม
                    </td>
                </tr>
                <tr>
                    <td>
                        (๕) หนังสือแต่งตั้งผู้ดำเนินกิจการ กรณีผู้ขอรับใบอนุญาตเป็นนิติบุคคล
                    </td>
                </tr>
            </table>
            <div style="margin-left:8%;font-size:20px"><strong>๕.๑.๒ กรณีขอรับใบอนุญาตขายวัตถุออกฤทธิ์ในประเภท ๓ หรือประเภท ๔ โดยการขายส่งตรง</strong></div>
            <table style="width:90%;font-size:20px ;margin-left:10%">
                <tr>
                    <td>
                        (๑) สำเนาใบอนุญาตผลิต ขาย หรือนำเข้าวัตถุออกฤทธิ์ในประเภท ๓ หรือประเภท ๔ แล้วแต่กรณี
                    </td>
                </tr>
                <tr>
                    <td>
                        (๒) รูปถ่ายหน้าตรง ไม่สวมหมวกและแว่นตาสีเข้ม ของผู้ขอรับใบอนุญาตหรือผู้ได้รับมอบหมายหรือแต่งตั้งให้
                    </td>
                </tr>
                <tr>
                    <td>
                        ดำเนินกิจการเกี่ยวกับใบอนุญาต ขนาด ๑ นิ้ว จำนวน ๓ รูป ซึ่งถ่ายไว้ไม่เกิน ๖ เดือนก่อนวันยื่นคำขอ
                    </td>
                </tr>
            </table>
            <div style="margin-left:8%;font-size:20px"><strong>๕.๑.๓ กรณีขอรับใบอนุญาตขายวัตถุออกฤทธฺิ์ในประเภท ๓ หรือประเภท ๔ ในบริเวณสถานที่ที่มีการประชุม</strong></div>
            <table style="width:90%;font-size:20px ;margin-left:10%">
                <tr>
                    <td>
                        (๑) สำเนาใบอนุญาตผลิต ขาย หรือนำเข้าวัตถุออกฤทธิ์ในประเภท ๓ หรือประเภท ๔ แล้วแต่กรณี
                    </td>
                </tr>
            </table>

            <div style="margin-left:5%;font-size:20px"><strong>๕.๒ กรณีขอต่ออายุใบอนุญาต</strong></div>
            <table style="width:90%;font-size:20px ;margin-left:10%">
                <tr>
                    <td>
                        (๑) ใบอนุญาตฉบับเดิม
                    </td>
                </tr>
                <tr>
                    <td>
                        (๒) รูปถ่ายหน้าตรง ไม่สวมหมวกและแว่นตาสีเข้ม ของผู้ขอรับใบอนุญาตหรือผู้ได้รับมอบหมายหรือแต่งตั้งให้ดำเนินกิจการ
                        เกี่ยวกับใบอนุญาต ขนาด ๑ นิ้ว จำนวน ๓ รูป ซึ่งถ่ายไว้ไม่เกิน ๖ เดือนก่อนวันยื่นคำขอ
                    </td>
                </tr>

            </table>
            <div style="margin-left:5%;font-size:20px"><strong>๕.๓ กรณีขอรับใบแทนใบอนุญาต</strong></div>
            <table style="width:90%;font-size:20px ;margin-left:10%">
                <tr>
                    <td>
                        (๑) ใบแจ้งความ กรณีใบอนุญาตสูญหาย
                    </td>
                </tr>
                <tr>
                    <td>
                        (๒) ใบอนุญาต กรณีใบอนุญาตดังกล่าวถูกทำลายบางส่วนหรือลบเลือนในสาระสำคัญ
                    </td>
                </tr>
                <tr>
                    <td>
                        (๓) รูปถ่ายหน้าตรง ไม่สวมหมวกและแว่นตาสีเข้ม ของผู้ขอรับใบอนุญาตหรือผู้ได้รับมอบหมายหรือแต่งตั้งให้ดำเนินกิจการเกี่ยวกับ
                        ใบอนุญาต ขนาด ๑ นิ้ว จำนวน ๓ รูป ซึ่งถ่ายไว้ไม่เกิน ๖ เดือนก่อนวันยื่นคำขอ
                    </td>
                </tr>

            </table>
            <div style="margin-left:5%;font-size:20px;text-align:center"><strong>ข้าพเจ้าขอรับรองว่า ข้อความและเอกสารหรือหลักฐานทั้งหมดที่ยื่นเพื่อประกอบคำขอรับใบอนุญาตเป็นความจริงทุกประการ</strong></div>
            <br />
            <div>
                <h2 style="font-family:'Taviraj';font-size:20px;">
                    ไฟล์แนบ
                </h2>
                <table class="table" style="width:100%">
                    <tr>
                        <td>ชื่อไฟล์</td>
                        <td></td>
                    </tr>
                    <tr ng-repeat="datas in LIST_File.FILE_LISTs" style="background-color:#FDFCE3">
                        <td>{{datas.FILENAME}}</td>
                        <td>
                            <a ng-show="datas.PATH != null && datas.PATH != ''" ng-click="OPEN_DOC_PATH(datas.PATH,datas.FILENAME)">ดูเอกสาร</a>
                        </td>
                    </tr>
                </table>
            </div>
            <br />
            <br />

            <table style="width:85%;font-size:20px ;margin-left:12.5%">
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
                        <label>{{LIST_LCN.BSN_THAIFULLNAME}}</label>
                    </td>
                    <td style="text-align:left">
                        )
                    </td>
                </tr>

            </table>
            <br />
            <br />

            <div style="margin-left:5%;font-size:20px"> หมายเหตุ : (๑) ให้ขีดเลือกข้อความในช่อง ☐/〇 ให้ตรงตามที่ประสงค์จะดำเนินการ</div>
            <table style="width:90%;font-size:20px ;margin-left:12.5%">
                <tr>
                    <td>
                        (๒) รับรองสำเนาถูกต้องในเอกสารที่เป็นสำเนาทุกฉบับ
                    </td>
                </tr>
                <tr>
                    <td>
                        (๓) กรณีเอกสารหรือหลักฐานที่ออกโดยสำนักงานคณะกรรมการอาหารและยา ผู้อนุญาตอาจไม่ขอเอกสารหรือหลักฐานดังกล่าวได้
                    </td>
                </tr>

            </table>
            <br />

        </div>
    </div>

    <div ng-show="LIST_LCN.PROCESS == '100777'">
        <div style="font-family:'Taviraj';font-size:24px;">
            <h1 style="text-align:left;font-size:24px;">
                <strong>แบบ ข.ว.จ. ๓/๔-๑</strong>
            </h1>
            <br />
            <div class="title1">
                <label style="font-size:16px;margin-top:25px">
                    ที่ปิดรูปถ่าย<br />
                    ผู้ขออนุญาติ<br />
                    หรือ<br />
                    ผู้ดำเนินกิจการ<br />
                    ขนาด ๓ นิ้ว<br />
                </label>
            </div>

            <div class="title2">
                <table style="font-size:20px;width:95%;margin-top:10px;margin-left:10px">
                    <tr>
                        <td style="text-align:left;width:20%">
                            เลขรับที่
                        </td>

                        <td colspan="3" style="border-bottom:dotted;border-bottom-width:thin;">
                            <label>{{LCN_LIST.RCVNO_DISPLAY}}</label>
                        </td>
                    </tr>
                    <tr>
                        <td style="text-align:left">
                            วันที่
                        </td>

                        <td colspan="3" style="border-bottom:dotted;border-bottom-width:thin;">
                            <label>{{LCN_LIST.RCV_DATE_DISPLAY}}</label>
                        </td>
                    </tr>
                    <tr>
                        <td style="text-align:left">
                            ลงชื่่อ

                        </td>

                        <td style="border-bottom:dotted;border-bottom-width:thin;"></td>
                        <td style="text-align:right;width:25%">
                            ผู้รับคำขอ
                        </td>
                    </tr>
                </table>

            </div>


            <div style="clear:both"></div>
            <br />
            <br />

            <h2 style="text-align:center;font-size:24px;">
                <strong>คำขอรับใบอนุญาต คำขอต่ออายุใบอนุญาต คำขอรับใบแทน</strong><br />
                <strong>ใบอนุญาตขายวัตถุออกฤทธิ์ในประเภท ๓ หรือประเภท ๔</strong>
            </h2>
            @*process =123,124 *@
            <table style="width:70%; font-size:20px;margin:auto;text-align:center">
                <tr>
                    <td>
                        <strong>สำหรับขาย</strong>
                    </td>
                    <td>
                        <input type="radio" name="gender" ng-model="LIST_LCN.PROCESS" ng-value="100766" id="rdl_CHK_SELL_TYPE" disabled="disabled" /> <strong>วัตถุออกฤทธิ์ในประเภท ๓</strong>
                    </td>
                    <td>
                        <input type="radio" name="gender" ng-model="LIST_LCN.PROCESS" ng-value="100767" id="rdl_CHK_SELL_TYPE" disabled="disabled" /> <strong>วัตถุออกฤทธิ์ในประเภท ๔</strong>
                    </td>
                </tr>
                <tr>
                    <td style="font-size:16px" colspan="3">
                        <strong>(คำขอ ๑ ฉบับ ให้ยื่นขอได้เพียงหนึ่งประเภทเท่านั้น)</strong>
                    </td>
                </tr>
            </table>

            <table style="width:100%; font-size:20px">
                <tr>
                    <td style="width:20%">
                        <input type="checkbox" name="gender" disabled="disabled" /> <strong>ขอรับใบอนุญาต</strong>
                    </td>
                </tr>
                <tr>
                    <td>
                        <input type="checkbox" name="gender" disabled="disabled" /> <strong>ขอต่ออายุใบอนุญาตเลขที่</strong>
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;"></td>
                    <td style="width:10%">
                        <strong>ประจำปี พ.ศ.</strong>
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;"></td>
                </tr>
                <tr>
                    <td>
                        <input type="checkbox" name="gender" disabled="disabled" ng-checked="true" /> <strong>ขอรับใบแทนใบอนุญาต</strong>
                    </td>
                    <td>
                        เนื่องจากใบอนุญาต
                    </td>
                    <td colspan="2">

                        <form name="frm_lost_type">


                            <label><input type="radio" ng-model="LIST_LCN.DALCN_NCT_SUBSTITUTE.PURPOSE_ID" id="rdl_lost_type" value="1"> สูญหาย</label>
                            <label><input type="radio" ng-model="LIST_LCN.DALCN_NCT_SUBSTITUTE.PURPOSE_ID" id="rdl_lost_type" value="2"> ถูกทำลายหรือลบเลือนในสาระสำคัญ</label><br />

                        </form>



                    </td>

                </tr>
            </table>
            <br />

            <table style="width:100%">
                <tr>
                    <td style="text-align:right;width:90%">
                        เขียนที่
                    </td>
                    <td style="width:40%;border-bottom:dotted;border-bottom-width:thin;">

                        {{LIST_LCN.DALCN_NCT_SUBSTITUTE.WRITE_AT}}
                    </td>
                </tr>
                <tr>
                    <td style="text-align:right;width:100px">
                        วันที่
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;">

                        {{LIST_LCN.DALCN_NCT_SUBTITUTE.WRITE_DATE}}
                    </td>
                </tr>
            </table>
            <br />

            <h2 style="font-size:24px;">
                <strong>๑. ข้อมูลผู้ขอรับใบอนุญาต</strong>
            </h2>
            <table style="width:90%">
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
            <table style="width:90%">
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
                    <td style="text-align:left;width:30%;border-bottom:dotted;border-bottom-width:thin;">
                        <form action="javascript:void(0)">
                            <table>
                                <tr>
                                    <td style="border-bottom:dotted;border-bottom-width:thin;">
                                        @*<input class="form-control inline" ng-model="LIST_LCN.BSN_IDENTIFY" id="txt_bsn_identify" style="font-family:'Taviraj';" type="text" />*@
                                        {{LIST_LCN.BSN_IDENTIFY}}
                                    </td>
                                    @*<td>
                                            <input type="button" value="ค้นหาผู้ดำเนินฯ" ng-click="BTN_Search_BSN(LIST_LCN.BSN_IDENTIFY)" />
                                        </td>*@
                                </tr>
                            </table>


                        </form>
                        <label>{{LIST_LCN.BSN_THAIFULLNAME}}</label>
                    </td>
                </tr>
                <tr>
                    <td style="font-size:20px">
                        หรือบัตรประจำตัวอื่นที่ทางราชการออกให้ คือ
                    </td>
                    <td style="font-size:20px;width:20%;border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_LCN.BSN_IDENTIFY}}</label>
                    </td>
                    <td style="font-size:20px;width:5%">
                        เลขที่
                    </td>
                    <td style="font-size:20px ;width:15%;text-align:center"></td>
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
                        <label>{{LIST_LCN.BSN_FULL_ADDR}}</label>
                    </td>
                </tr>
                <tr>
                    <td style="font-size:20px">
                        โทรศัพท์/มือถือ
                    </td>
                    <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;" colspan="6">
                        <label>{{LIST_LCN.BSN_TELEPHONE}}</label>
                    </td>
                </tr>
            </table>

            <div style="font-size:20px"><strong>๓. ข้อมูลการขออนุญาต</strong></div>
            <div style="font-size:20px;margin-left:5%">(๓.๑) <strong><u>กรณีขายวัตถุออกฤทธฺิ์ในประเภท ๓ หรือประเภท ๔</u></strong></div>
            <table style="width:100%;font-size:20px">
                <tr>
                    <td>
                        ณ สถานที่ชื่อ
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_LCN.THANAMEPLACE}}</label>
                    </td>
                    <td>
                        เลขรหัสประจำบ้าน
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_LCN.HOUSENO}}</label>
                    </td>
                </tr>
                <tr>
                    <td>
                        ตั้งอยู่เลขที่
                    </td>
                    <td colspan="3" style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_LCN.fulladdr3}}</label>
                    </td>
                </tr>
                <tr>
                    <td>
                        โทรศัพท์/มือถือ
                    </td>
                    <td colspan="3" style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_LCN.tel}}</label>
                    </td>
                </tr>

            </table>
            <table style="width:100%;font-size:20px" ng-init="getdetails_phr()">
                <tr>
                    <td style="width:15%;">
                        โดยมีเภสัชกรชื่อ  1.
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;width:15%;">
                        <label>{{LIST_PHR.PHR_NAME}}</label>
                    </td>
                    <td style="width:15%">
                        ใบอนุญาตประกอบวิชาชีพเภสัชกรรมเลขที่
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_PHR.PHR_TEXT_NUM}}</label>
                    </td>
                </tr>
            </table>
            <br />
            @*<input type="button" style="font-size:20px;width:100px" value="เพิ่ม" />*@
            @*<input type="button" style="font-size:20px;width:100px;margin-left:10px" value="ลบ" />*@
            <br />
            <table style="width:100%;font-size:20px">
                <tr>
                    <td>
                        เป็นผู้รับอนุญาตขายยาแผนใบอนุญาตเลขที่
                    </td>
                    <td style="width:50%; border-bottom:dotted;border-bottom-width:thin; ">
                        <label>{{LIST_LCN.HEAD_LCNNO_NCT}}</label>
                    </td>
                    <td>
                        ตามกฎหมายว่าด้วยยา
                    </td>
                </tr>
            </table>
            <div style="font-size:20px">เป็นผู้ควบคุมตามมาตรา ๕๓ แห่งพระราชบัญญัติวัตถุที่ออกฤทธิ์ต่อจิตและประสาท พ.ศ. ๒๕๕๙</div>

            <div style="font-size:20px;margin-left:5%"><strong>(๓.๒) <u>กรณีขายวัตถุออกฤทธฺิ์ในประเภท ๓ หรือประเภท ๔ โดยการขายส่งตรง</u></strong></div>
            <table style="width:100%;font-size:20px">
                <tr>
                    <td colspan="2">
                        ผู้ขอรับใบอนุญาตได้รับอนุญาตให้ผลิต/ขาย/หรือนำเข้าซึ่งวัตถุออกฤทธิ์ในประเภท ๓ หรือประเภท ๔ ตามใบอนุญาต
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        ผู้ขอรับใบอนุญาตได้รับอนุญาตให้ผลิต/ขาย/หรือนำเข้าซึ่งวัตถุออกฤทธิ์ในประเภท ๓ หรือประเภท ๔ ตามใบอนุญาต
                    </td>
                </tr>
                <tr>
                    <td style="width:10%">
                        เลขที่
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_LCN.HEAD_LCNNO}}</label>
                    </td>
                </tr>
            </table>
            <div style="font-size:20px;margin-left:5%"><strong>(๓.๓) <u> กรณีขายวัตถุออกฤทธฺิ์ในประเภท ๓ หรือประเภท ๔ ในบริเวณสถานที่ที่มีการประชุม</u></strong></div>

            <table style="width:100%;font-size:20px">
                <tr>
                    <td colspan="4">
                        ผู้ขอรับใบอนุญาตได้รับอนุญาตให้ผลิต/ขาย/หรือนำเข้าซึ่งวัตถุออกฤทธิ์ในประเภท ๓ หรือประเภท ๔ ตามใบอนุญาต
                    </td>
                </tr>
                <tr>
                    <td style="width:20%">
                        เลขที่
                    </td>
                    <td colspan="4" style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_LCN.HEAD_LCNNO}}</label>
                    </td>
                </tr>
                <tr>
                    <td colspan="4">
                        ขอรับใบอนุญาตขายวัตถุออกฤทธิ์ในบริเวณสถานที่ที่มีการประชุม ณ
                    </td>
                </tr>
                <tr>
                    <td style="width:10%">
                        สถานที่ชื่อ
                    </td>
                    <td colspan="4" style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_LCN.thanameplace}}</label>
                    </td>
                </tr>
                <tr>
                    <td>
                        เลขรหัสประจำบ้าน
                    </td>
                    <td colspan="4" style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_LCN.HOUSENO}}</label>
                    </td>
                </tr>
                <tr>
                    <td>
                        ตั้งอยู่เลขที่
                    </td>
                    <td colspan="3" style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_LCN.fulladdr2}}</label>
                    </td>
                </tr>
                <tr>
                    <td>
                        โทรศัพท์/มือถือ
                    </td>
                    <td colspan="3" style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_LCN.tel}}</label>
                    </td>
                </tr>
                <tr>
                    <td>
                        ตั้งแต่วันที่
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;"></td>
                    <td style="width:20%">
                        ถึงวันที่
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;"></td>
                </tr>
            </table>

            <table style="width:100%;font-size:20px" ng-init="getdetails_keep()">
                <tr>
                    <td colspan="7">
                        <p>
                            <strong>
                                ๔. ข้อมูลสถานที่เก็บ (กรณีเป็นสถานที่คนละแห่งกับสถานที่ตาม ๓)
                            </strong>
                        </p>
                    </td>
                </tr>
                <tr>
                    <td style="width:17%">
                        ณ สถานที่ชื่อ
                    </td>
                    <td colspan="4" style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_KEEP.KEEP_THANAMEPLACE}}</label>
                    </td>
                    <td style="width:15%">
                        เลขรหัสประจำบ้าน
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_KEEP.HOUSENO}}</label>
                    </td>
                </tr>
                <tr>
                    <td>
                        อยู่เลขที่
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_KEEP.KEEP_FULL_ADDR}}</label>
                    </td>
                </tr>
                <tr>
                    <td>
                        โทรศัพท์ / มือถือ
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;">
                        <label>{{LIST_KEEP.KEEP_TEL}}</label>
                    </td>
                </tr>

            </table>
            @*<input type="button" style="font-size:20px;width:100px" value="เพิ่ม" />*@
            @*<input type="button" style="font-size:20px;width:100px;margin-left:10px" value="ลบ" />*@
            <br />
            <br />

            <div style=";font-size:20px"><strong>๕. พร้อมกับคำขอนี้ข้าพเจ้าได้แนบเอกสารหรือหลักฐานต่างๆ มาด้วย คือ</strong></div>
            <div style="margin-left:5%;font-size:20px"><strong>๕.๑ <u>กรณีขอรับใบอนุญาต (กรณีรายใหม่)</u></strong></div>
            <div style="margin-left:8%;font-size:20px"><strong>๕.๑.๑ กรณีขอรับใบอนุญาตขายวัตถุออกฤทธิ์ในประเภท ๓ หรือประเภท ๔</strong></div>
            <table style="width:90%;font-size:20px ;margin-left:10%">
                <tr>
                    <td>
                        (๑) สำเนาใบอนุญาตขายยาแผนปัจจุบันตามกฎหมายว่าด้วยยา
                    </td>
                </tr>
                <tr>
                    <td>
                        (๒) คำรับรองของผู้รับอนุญาตและเภสัชกรผู้ควบคุมกิจการ
                    </td>
                </tr>
                <tr>
                    <td>
                        (๓) รูปถ่ายหน้าตรง ไม่สวมหมวกและแว่นตาสีเข้ม ของผู้ขอรับใบอนุญาตหรือผู้ได้รับมอบหมายหรือแต่งตั้ง
                    </td>
                </tr>
                <tr>
                    <td>
                        ให้ดำเนินกิจการเกี่ยวกับใบอนุญาต ขนาด ๑ นิ้ว จำนวน ๓ รูป ซึ่งถ่ายไว้ไม่เกิน ๖ เดือนก่อนวันยื่นคำขอ
                    </td>
                </tr>
                <tr>
                    <td>
                        (๔) สำเนาใบอนุญาตประกอบวิชาชีพเภสัชกรรม
                    </td>
                </tr>
                <tr>
                    <td>
                        (๕) หนังสือแต่งตั้งผู้ดำเนินกิจการ กรณีผู้ขอรับใบอนุญาตเป็นนิติบุคคล
                    </td>
                </tr>
            </table>
            <div style="margin-left:8%;font-size:20px"><strong>๕.๑.๒ กรณีขอรับใบอนุญาตขายวัตถุออกฤทธิ์ในประเภท ๓ หรือประเภท ๔ โดยการขายส่งตรง</strong></div>
            <table style="width:90%;font-size:20px ;margin-left:10%">
                <tr>
                    <td>
                        (๑) สำเนาใบอนุญาตผลิต ขาย หรือนำเข้าวัตถุออกฤทธิ์ในประเภท ๓ หรือประเภท ๔ แล้วแต่กรณี
                    </td>
                </tr>
                <tr>
                    <td>
                        (๒) รูปถ่ายหน้าตรง ไม่สวมหมวกและแว่นตาสีเข้ม ของผู้ขอรับใบอนุญาตหรือผู้ได้รับมอบหมายหรือแต่งตั้งให้
                    </td>
                </tr>
                <tr>
                    <td>
                        ดำเนินกิจการเกี่ยวกับใบอนุญาต ขนาด ๑ นิ้ว จำนวน ๓ รูป ซึ่งถ่ายไว้ไม่เกิน ๖ เดือนก่อนวันยื่นคำขอ
                    </td>
                </tr>
            </table>
            <div style="margin-left:8%;font-size:20px"><strong>๕.๑.๓ กรณีขอรับใบอนุญาตขายวัตถุออกฤทธฺิ์ในประเภท ๓ หรือประเภท ๔ ในบริเวณสถานที่ที่มีการประชุม</strong></div>
            <table style="width:90%;font-size:20px ;margin-left:10%">
                <tr>
                    <td>
                        (๑) สำเนาใบอนุญาตผลิต ขาย หรือนำเข้าวัตถุออกฤทธิ์ในประเภท ๓ หรือประเภท ๔ แล้วแต่กรณี
                    </td>
                </tr>
            </table>

            <div style="margin-left:5%;font-size:20px"><strong>๕.๒ กรณีขอต่ออายุใบอนุญาต</strong></div>
            <table style="width:90%;font-size:20px ;margin-left:10%">
                <tr>
                    <td>
                        (๑) ใบอนุญาตฉบับเดิม
                    </td>
                </tr>
                <tr>
                    <td>
                        (๒) รูปถ่ายหน้าตรง ไม่สวมหมวกและแว่นตาสีเข้ม ของผู้ขอรับใบอนุญาตหรือผู้ได้รับมอบหมายหรือแต่งตั้งให้ดำเนินกิจการ
                        เกี่ยวกับใบอนุญาต ขนาด ๑ นิ้ว จำนวน ๓ รูป ซึ่งถ่ายไว้ไม่เกิน ๖ เดือนก่อนวันยื่นคำขอ
                    </td>
                </tr>

            </table>
            <div style="margin-left:5%;font-size:20px"><strong>๕.๓ กรณีขอรับใบแทนใบอนุญาต</strong></div>
            <table style="width:90%;font-size:20px ;margin-left:10%">
                <tr>
                    <td>
                        (๑) ใบแจ้งความ กรณีใบอนุญาตสูญหาย
                    </td>
                </tr>
                <tr>
                    <td>
                        (๒) ใบอนุญาต กรณีใบอนุญาตดังกล่าวถูกทำลายบางส่วนหรือลบเลือนในสาระสำคัญ
                    </td>
                </tr>
                <tr>
                    <td>
                        (๓) รูปถ่ายหน้าตรง ไม่สวมหมวกและแว่นตาสีเข้ม ของผู้ขอรับใบอนุญาตหรือผู้ได้รับมอบหมายหรือแต่งตั้งให้ดำเนินกิจการเกี่ยวกับ
                        ใบอนุญาต ขนาด ๑ นิ้ว จำนวน ๓ รูป ซึ่งถ่ายไว้ไม่เกิน ๖ เดือนก่อนวันยื่นคำขอ
                    </td>
                </tr>

            </table>
            <div style="margin-left:5%;font-size:20px;text-align:center"><strong>ข้าพเจ้าขอรับรองว่า ข้อความและเอกสารหรือหลักฐานทั้งหมดที่ยื่นเพื่อประกอบคำขอรับใบอนุญาตเป็นความจริงทุกประการ</strong></div>
            <br />
            <div>
                <h2 style="font-family:'Taviraj';font-size:20px;">
                    ไฟล์แนบ
                </h2>
                <table class="table" style="width:100%">
                    <tr>
                        <td>ชื่อไฟล์</td>
                        <td></td>
                    </tr>
                    <tr ng-repeat="datas in LIST_File.FILE_LISTs" style="background-color:#FDFCE3">
                        <td>{{datas.FILENAME}}</td>
                        <td>
                            <a ng-show="datas.PATH != null && datas.PATH != ''" ng-click="OPEN_DOC_PATH(datas.PATH,datas.FILENAME)">ดูเอกสาร</a>
                        </td>
                    </tr>
                </table>
            </div>
            <br />
            <br />

            <table style="width:85%;font-size:20px ;margin-left:12.5%">
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
                        <label>{{LIST_LCN.BSN_THAIFULLNAME}}</label>
                    </td>
                    <td style="text-align:left">
                        )
                    </td>
                </tr>

            </table>
            <br />
            <br />

            <div style="margin-left:5%;font-size:20px"> หมายเหตุ : (๑) ให้ขีดเลือกข้อความในช่อง ☐/〇 ให้ตรงตามที่ประสงค์จะดำเนินการ</div>
            <table style="width:90%;font-size:20px ;margin-left:12.5%">
                <tr>
                    <td>
                        (๒) รับรองสำเนาถูกต้องในเอกสารที่เป็นสำเนาทุกฉบับ
                    </td>
                </tr>
                <tr>
                    <td>
                        (๓) กรณีเอกสารหรือหลักฐานที่ออกโดยสำนักงานคณะกรรมการอาหารและยา ผู้อนุญาตอาจไม่ขอเอกสารหรือหลักฐานดังกล่าวได้
                    </td>
                </tr>

            </table>
            <br />

        </div>
    </div>

    <div ng-show="LIST_LCN.PROCESS == '100791'">
        <div class="content-part " style="width:100%;font-family:'Taviraj'">
            <div style="font-family:'Taviraj';font-size:20px;">
                <div>
                    <h1><center>แบบ ข.ย.๑๖</center></h1>
                </div>
                <table style="width:100%">
                    <tr>
                        <td style="width:35%"></td>
                        <td style="width:35%"></td>
                        <td style="width:5%;text-align:right">เลขที่</td>
                        <td style=" width:25%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"><label>{{LCN_LIST.RCVNO_DISPLAY}}</label></td>
                    </tr>
                </table>
                <table style="width:100%">
                    <tr>
                        <td style="width:35%"></td>
                        <td style="width:35%"></td>
                        <td style="width:5%;text-align:right">วันที่</td>
                        <td style=" width:25%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"> <label>{{LCN_LIST.RCV_DATE_DISPLAY}}</label></td>
                    </tr>
                </table>
                <table style="width:100%">
                    <tr>
                        <td style="width:35%"></td>
                        <td style="width:35%"></td>
                        <td style="width:5%;text-align:right"> ลงชื่อ</td>
                        <td style=" width:15%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"></td>
                        <td style="width:10%">ผู้รับคำขอ</td>
                    </tr>
                </table>
                <div>
                    <p style="text-align:center">

                        <table width="100%">
                            <tr>
                                <td style="width:30%"></td>
                                <td>
                                    คำขอ
                                </td>
                                <td>
                                    <table>
                                        <tr>
                                            <td>
                                                <label>
                                                    <input type="radio" ng-model="LIST_LCN.REQUEST_TYPE" value="1" disabled />ใบแทนใบอนุญาต
                                                </label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <label>
                                                    <input type="radio" ng-model="LIST_LCN.REQUEST_TYPE" value="2" disabled />ย้ายสถานที่
                                                </label>
                                            </td>
                                        </tr>
                                    </table>
                                </td>
                                <td>
                                    <table>
                                        <tr>
                                            <td>
                                                <input type="radio" ng-model="LIST_LCN.LCN_TYPE" value="1" disabled />ขายยาแผนปัจจุบัน
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <input type="radio" ng-model="LIST_LCN.LCN_TYPE" value="2" disabled />ขายส่งยาแผนปัจจุบัน
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <input type="radio" ng-model="LIST_LCN.LCN_TYPE" value="3" disabled />ขายยาแผนปัจจุบันเฉพาะยาบรรจุเสร็จที่ไม่ใช่ยาอันตรายหรือยาควบคุมพิเศษ
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <input type="radio" ng-model="LIST_LCN.LCN_TYPE" value="4" disabled />ขายยาแผนปัจจุบันเฉพาะยาบรรจุเสร็จสำหรับสัตว์
                                            </td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>

                        </table>

                </div>
                <hr />
                <table style="width:100%">
                    <tr>
                        <td style="text-align:right;width:90%">
                            เขียนที่
                        </td>
                        <td style="width:40%;border-bottom:dotted;border-bottom-width:thin;">

                            {{LIST_LCN.DALCN_NCT_SUBSTITUTE.WRITE_AT}}
                        </td>
                    </tr>
                    <tr>
                        <td style="text-align:right;width:100px">
                            วันที่
                        </td>
                        <td style="border-bottom:dotted;border-bottom-width:thin;">

                            {{LIST_LCN.DALCN_NCT_SUBTITUTE.WRITE_DATE}}
                        </td>
                    </tr>
                </table>
                <table style="width:100%;">
                    <tr>
                        <td style="padding-left:10%;"></td>
                        <td width="5%">
                            ข้าพเจ้า
                        </td>
                        <td style="width:90%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"> <label>{{LIST_LCN.thanm}}</label></td>
                    </tr>
                    <tr>
                        <td></td>
                        <td></td>
                        <td style="text-align:center;">
                            (ชื่อผู้ขออนุญาต)
                        </td>
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
                        <td style="width:24%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"></td>
                    </tr>
                </table>
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
                <div>มีความประสงค์ขอ</div>
                <table style="width:100%;">
                    <tr>
                        <td width="17%"><input type="checkbox" ng-model="LIST_LCN.REQUEST_TYPE" disabled />ใบแทนใบอนุญาตขายยา  เนื่องจาก</td>
                        <td width="68%" style="border-bottom:dotted;border-bottom-width:thin">
                            @*<input type="text" ng-model="LIST_LCN.DALCN_NCT_SUBSTITUTE.PURPOSE" />*@
                            {{LIST_LCN.DALCN_NCT_SUBSTITUTE.PURPOSE}}
                        </td>
                        <td width="15%">
                            (ระบุเหตุที่ขอรับใบแทน)
                        </td>
                    </tr>
                </table>
                <table>
                    <tr>
                        <td><input type="checkbox" ng-model="LIST_LCN.REQUEST_TYPE" disabled />ย้ายสถานที่ขายยาชื่อ</td>
                        <td>
                            @*<select class="form-control selectpicker" data-live-search="true" title="-- Please select --" style="font-family:'Taviraj'" ng-model="LIST_LCN.LOCATION_SELECT" ng-change="getdetails_lct(LIST_LCN.LOCATION_SELECT)">
                                @*<option value="0">--กรุณาเลือก--</option>*@
                            @*<option ng-repeat="x in REF_LOCATION" value="{{x.IDA}}">{{x.thanameplace}}</option>
                                </select>*@
                            {{LIST_LCN.LOCATION_SELECT}}
                        </td>
                    </tr>
                </table>
                <table style="width:100%">
                    <tr>
                        <td style="width:5%">ไปอยู่ที่</td>
                        <td style="width:95%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"><label>{{LIST_LABEL_LCT.fulladdr}}</label></td>
                    </tr>
                </table>
                <table style="width:100%">
                    <tr>
                        <td style="width:13%">โทรศัพท์/โทรศัพท์มือถือ</td>
                        <td style="width:87%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"><label>{{LIST_LABEL_LCT.tel}}</label></td>
                    </tr>
                </table>
                <br />
                <div>ข้าพเจ้าได้แนบหลักฐานมาด้วย คือ</div>
                <table style="width:100%" border="1">
                    <tr>
                        <td style="width:50%"><input type="radio" value="1" ng-model="LIST_LCN.REQUEST_TYPE" disabled /> หลักฐานประกอบคำขอใบแทนใบอนุญาต</td>
                        <td style="width:50%"><input type="radio" value="2" ng-model="LIST_LCN.REQUEST_TYPE" disabled /> หลักฐานประกอบคำขอย้ายสถานที่</td>
                    </tr>
                </table>
                <table style="width:100%" border="1">
                    <tr>
                        <td style="width:50%">(๑) รูปถ่ายของผู้ขออนุญาต หรือผู้แทนหรือผู้จัดการนิติบุคคล ขนาด ๓ x ๔ เซนติเมตร จำนวน ๓ รูป </td>
                        <td style="width:50%">(๑) ใบอนุญาตประกอบธุรกิจเกี่ยวกับยาแผนปัจจุบันหรือใบแทน </td>
                    </tr>
                </table>
                <table style="width:100%" border="1">
                    <tr>
                        <td style="width:50%">(๒) ใบอนุญาตประกอบธุรกิจเกี่ยวกับยาแผนปัจจุบัน (ถ้ามี)</td>
                        <td style="width:50%">(๒) แบบแปลนแผนผังสิ่งปลูกส้รางของสถานที่ขายยาแห่งใหม่</td>
                    </tr>
                </table>
                <table style="width:100%" border="1">
                    <tr>
                        <td style="width:50%">(๓) ใบรับแจ้งความของสถานีตำรวจแห่งท้องที่ที่ใบอนุญาตนั้นสูญหายมาด้วย</td>
                        <td style="width:50%">(๓) เอกสารอื่นถ้าจำเป็น</td>
                    </tr>
                </table>
                <table style="width:100%" border="1">
                    <tr>
                        <td style="width:50%">(๔) ใบอนุญาตใบเดิม (กรณีที่ใบอนุญาตถูกทำำลายในสาระสำคัญ)</td>
                        <td style="width:50%"></td>
                    </tr>
                </table>
                <br />
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
                <hr />
                <div>หมายเหตุ : &nbsp;(๑) ใส่เครื่องหมาย &#10004; ในช่อง [  ] หน้าข้อความที่ต้องการ</div>

            </div>

        </div>
    </div>

    <div ng-show="LIST_LCN.PROCESS == '100792'">
        <div style="font-family:'Taviraj';font-size:20px;" class="ic">
            <br />

            <h1 style="text-align:center;">
                แบบ น.ย.๑๐
            </h1>
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
            <div> <h3 style="text-align:center">คำขอแก้ไขเปลี่ยนแปลงรายการในใบอนุญาตนำหรือสั่งยาแผนปัจจุบัน</h3></div>
            <div>
                <table width="100%">
                    <tr>
                        <td style="width:45%;" align="right"> <h4>คำขอ </h4></td>
                        <td>
                            <table>
                                <tr>
                                    <td>
                                        <label>
                                            <input type="radio" ng-model="LIST_LCN.REQUEST_TYPE" value="1" disabled />ใบแทนใบอนุญาต
                                        </label>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <label>
                                            <input type="radio" ng-model="LIST_LCN.REQUEST_TYPE" value="2" disabled />ย้ายสถานที่
                                        </label>
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>

                </table>
            </div>


            <hr />
            <table style="width:100%">
                <tr>
                    <td style="text-align:right;width:90%">
                        เขียนที่
                    </td>
                    <td style="width:40%;border-bottom:dotted;border-bottom-width:thin;">

                        {{LIST_LCN.DALCN_NCT_SUBSTITUTE.WRITE_AT}}
                    </td>
                </tr>
                <tr>
                    <td style="text-align:right;width:100px">
                        วันที่
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;">

                        {{LIST_LCN.DALCN_NCT_SUBTITUTE.WRITE_DATE}}
                    </td>
                </tr>
            </table>
            <br />
            <table style="width:100%">
                <tr>
                    <td style="width:10%;text-align:right">ข้าพเจ้า :</td>
                    <td style="width:40%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"> <label>{{LIST_LCN.thanm}}</label></td>
                    <td style="width:13%;text-align:right">ซึ่งมีผู้ดำเนินกิจการชื่อ :</td>
                    <td style="width:42%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"> <label>{{LIST_LCN.BSN_THAIFULLNAME}}</label></td>
                </tr>
            </table>
            <table style="width:100%">
                <tr>
                    <td style="width:10%;"></td>
                    <td style="width:40%;text-align:center">(ชื่อผู้รับอนุญาต)</td>
                    <td style="width:13%;"></td>
                    <td style="width:42%;"></td>
                </tr>
            </table>
            <table style="width:100%">
                <tr>
                    <td style="width:38%;">ได้รับอนุญาตให้นำหรือสั่งยาแผนปัจจุบันเข้ามาในราชอาณาจักรตามใบอนุญาตที่</td>
                    <td style="width:62%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"><label>{{LIST_LCN.LCNNO_SHOW}}</label></td>
                </tr>
            </table>
            <table style="width:100%">
                <tr>
                    <td style="width:15%;">ณ สถานที่นำหรือสั่งยาชื่อ</td>
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
                    <td style="width:18%;">โทรศัพท์/โทรศัพท์มือถือ</td>
                    <td style="width:82%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"><label>{{LIST_LCN.tel}}</label></td>
                </tr>
            </table>
            <table width="100%">
                <tr>
                    <td>
                        ขอ
                    </td>
                    <td>
                        <table width="100%">

                            <tr>
                                <td><input type="checkbox" ng-model="LIST_LCN.REQUEST_TYPE" disabled />ใบแทนใบอนุญาตนำหรือสั่งยาแผนปัจจุบันเข้ามาในราชอาณาจักรเนื่องจาก</td>
                            <tr>
                                <td style="border-bottom:dotted;border-bottom-width:thin">
                                    @*<input type="text" ng-model="LIST_LCN.DALCN_NCT_SUBSTITUTE.PURPOSE" />*@
                                    {{LIST_LCN.DALCN_NCT_SUBSTITUTE.PURPOSE}}
                                </td>
                            </tr>
                            <tr>
                                <td style="width:100%;text-align:center">(เหตุที่ขอรับใบแทน)</td>
                            </tr>
                            <tr>
                                <td><input type="checkbox" ng-model="LIST_LCN.REQUEST_TYPE" disabled />ย้ายสถานที่นำหรือสั่งยาแผนปัจจุบันเข้ามาในราชอาณาจักรในนามของ</td>
                            <tr>
                                <td>
                                    @*<select class="form-control selectpicker" data-live-search="true" title="-- Please select --" style="font-family:'Taviraj'" ng-model="LIST_LCN.LOCATION_SELECT" ng-change="getdetails_lct(LIST_LCN.LOCATION_SELECT)">
                                        @*<option value="0">--กรุณาเลือก--</option>*@
                                    @*<option ng-repeat="x in REF_LOCATION" value="{{x.IDA}}">{{x.thanameplace}}</option>
                                        </select>*@
                                    {{LIST_LCN.LOCATION_SELECT}}
                                </td>
                            </tr>
                            <tr>
                                <td style="width:100%;text-align:center">(ชื่อสถานที่นำหรือสั่งยา)</td>
                            </tr>
                        </table>
                    </td>
                </tr>

            </table>

            <table width="100%">
                <tr>
                    <td style="width:7%">ไปอยู่เลขที่</td>
                    <td style="width:93%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"><label>{{LIST_LABEL_LCT.fulladdr}}</label></td>
                </tr>
            </table>
            <table width="100%">
                <tr>
                    <td style="width:5%">โทรศัพท์</td>
                    <td style="width:95%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"><label>{{LIST_LABEL_LCT.tel}}</label></td>
                </tr>
            </table>
            <table>
                <tr>
                    <td>ข้าพเจ้าได้แนบหลักฐานมาด้วย คือ</td>
                <tr>
                    <td>&nbsp;&nbsp;<input type="radio" value="1" ng-model="LIST_LCN.REQUEST_TYPE" disabled /> หลักฐานประกอบคำขอใบแทนใบอนุญาต</td>
                <tr>
                    <td>&nbsp;&nbsp;&nbsp;&nbsp; (๑) รูปถ่ายของผู้ดำเนินกิจการ ขนาด ๓ x ๔ เซนติเมตร จำนวน ๒ รูป</td>
                <tr>
                    <td>&nbsp;&nbsp;&nbsp;&nbsp; (๒) ใบอนุญาตนำหรือสั่งยาแผนปัจจุบันเข้ามาในราชอาณาจักร ถ้ามี</td>
                <tr>
                    <td>&nbsp;&nbsp;<input type="radio" value="1" ng-model="LIST_LCN.REQUEST_TYPE" disabled /> หลักฐานประกอบคำขอย้ายสถานที่</td>
                <tr>
                    <td>&nbsp;&nbsp;&nbsp;&nbsp; (๑) ใบอนุญาตนำหรือสั่งยาแผนปัจจุบันเข้ามาในราชอาณาจักรหรือใบแทน</td>
                <tr>
                    <td>&nbsp;&nbsp;&nbsp;&nbsp; (๒) แบบแปลนแผนผังสิ่งปลูกสร้างของสถานที่นำหรือสั่งยาแห่งใหม่ จำนวน ๒ ชุด</td>
                <tr>
                    <td>&nbsp;&nbsp;&nbsp;&nbsp; (๓) เอกสารแสดงว่าเป็นผู้ได้รับอนุญาต</td>
                </tr>
            </table>
            <table style="width:100%">
                <tr>
                    <td style="width:50%;text-align:center"></td>
                    <td style="width:10%;text-align:right">(ลายมือชื่อ)</td>
                    <td style="width:20%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"></td>
                    <td style="width:20%;text-align:start">ผู้ยื่นคำขอ</td>
                </tr>
            </table>
            <hr />
            <div>หมายเหตุ : &nbsp;(๑) ในกรณีที่ใบอนุญาตสูญหาย ให้นำใบรับแจ้งความของสถานีตำรวจแห่งท้องที่ที่ใบอนุญาตอนุญาตนั้นสูญหายมาด้วย</div>
            <div>&nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;(๒) ในกรณีที่ใบอนุญาตถูกทำลายในสาระสำคัญ ให้แนบใบอนุญาตนั้น มาด้วย</div>
            <div>&nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;(๓) ใส่เครื่องหมาย &#10004 ในช่อง[  ] หน้าข้อความที่ต้องการ</div>

        </div>
    </div>

    <div ng-show="LIST_LCN.PROCESS == '100793'">
        <div style="font-family:'Taviraj';font-size:20px;" class="ic">
            <div>
                <p style="text-align: right;">แบบ ผ.ย.๑๐</p>
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
                    <td style="text-align:right;width:45%;"> <h2>คำขอ</h2></td>
                    <td width="10%">
                        <table style="width:100%">
                            <tr>
                                <td>
                                    <label>
                                        <input type="radio" ng-model="LIST_LCN.REQUEST_TYPE" value="1" disabled />ใบแทนใบอนุญาต
                                    </label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <label>
                                        <input type="radio" ng-model="LIST_LCN.REQUEST_TYPE" value="2" disabled />ย้ายสถานที่
                                    </label>
                                </td>
                            </tr>
                        </table>
                    </td>
                    <td style="text-align:left;"> <h2>ผลิตยาแผนปัจจุบัน</h2></td>
                </tr>
            </table>

            <hr />
            <table style="width:100%">
                <tr>
                    <td style="text-align:right;width:90%">
                        เขียนที่
                    </td>
                    <td style="width:40%;border-bottom:dotted;border-bottom-width:thin;">

                        {{LIST_LCN.DALCN_NCT_SUBSTITUTE.WRITE_AT}}
                    </td>
                </tr>
                <tr>
                    <td style="text-align:right;width:100px">
                        วันที่
                    </td>
                    <td style="border-bottom:dotted;border-bottom-width:thin;">

                        {{LIST_LCN.DALCN_NCT_SUBTITUTE.WRITE_DATE}}
                    </td>
                </tr>
            </table>
            <br />
            <table style="width:100%">
                <tr>
                    <td style="width:10%;text-align:right">ข้าพเจ้า </td>
                    <td style="width:90%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"> <label>{{LIST_LCN.thanm}}</label></td>

                </tr>
            </table>
            <table style="width:100%">
                <tr>
                    <td style="width:10%;"></td>
                    <td style="width:40%;text-align:right">(ชื่อผู้รับอนุญาต)</td>
                    <td style="width:13%;"></td>
                    <td style="width:42%;"></td>
                </tr>
            </table>
            <table style="width:100%">
                <tr>
                    <td style="width:13%;">ซึ่งมีผู้ดำเนินกิจการชื่อ </td>
                    <td style="width:67%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"> <label>{{LIST_LCN.BSN_THAIFULLNAME}}</label></td>
                    <td style="width:20%;text-align:right">ได้รับอนุญาตให้ผลิตยาแผยปัจจุบัน</td>
                </tr>
            </table>
            <table style="width:100%">
                <tr>
                    <td style="width:15%;">ตามใบอนุญาตที่</td>
                    <td style="width:35%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"><label>{{LIST_LCN.LCNNO_SHOW}}</label></td>
                    <td style="width:15%;">ณ สถานที่นำหรือสั่งยาชื่อ</td>
                    <td style="width:35%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"><label>{{LIST_LCN.thanameplace}}</label></td>
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
            <br />
            <table width="100%">
                <tr>
                    <td>
                        ขอ
                    </td>
                    <td>
                        <table width="100%">

                            <tr>
                                <td><input type="checkbox" ng-model="LIST_LCN.REQUEST_TYPE" disabled />ใบแทนใบอนุญาตผลิตนาแผนปัจจุบันเนื่องจาก</td>
                            <tr>
                                <td style="border-bottom:dotted;border-bottom-width:thin">
                                    @*<input type="text" ng-model="LIST_LCN.DALCN_NCT_SUBSTITUTE.PURPOSE" />*@
                                    {{LIST_LCN.DALCN_NCT_SUBSTITUTE.PURPOSE}}
                                </td>
                            </tr>
                            <tr>
                                <td style="width:100%;text-align:center">(เหตุที่ขอรับใบแทน)</td>
                            </tr>
                            <tr>
                                <td><input type="checkbox" ng-model="LIST_LCN.REQUEST_TYPE" disabled />ย้ายสถานที่ผลิตยาแผนปัจจุบัน</td>
                            <tr>
                                <td>
                                    @*<select class="form-control selectpicker" data-live-search="true" title="-- Please select --" style="font-family:'Taviraj'" ng-model="LIST_LCN.LOCATION_SELECT" ng-change="getdetails_lct(LIST_LCN.LOCATION_SELECT)">
                                        @*<option value="0">--กรุณาเลือก--</option>*@
                                    @*<option ng-repeat="x in REF_LOCATION" value="{{x.IDA}}">{{x.thanameplace}}</option>
                                        </select>*@
                                    {{LIST_LCN.LOCATION_SELECT}}
                                </td>
                            </tr>
                            <tr>
                                <td style="width:100%;text-align:center">(ชื่อสถานที่นำหรือสั่งยา)</td>
                            </tr>
                        </table>
                    </td>
                </tr>

            </table>
            <br />
            <table width="100%">
                <tr>
                    <td style="width:7%">ไปอยู่เลขที่</td>
                    <td style="width:93%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"><label>{{LIST_LABEL_LCT.fulladdr}}</label></td>
                </tr>
            </table>
            <table width="100%">
                <tr>
                    <td style="width:5%">โทรศัพท์</td>
                    <td style="width:95%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"><label>{{LIST_LABEL_LCT.tel}}</label></td>
                </tr>
            </table>
            <table>
                <tr>
                    <td>ข้าพเจ้าได้แนบหลักฐานมาด้วย คือ</td>
                <tr>
                    <td>&nbsp;&nbsp;<input type="radio" value="1" ng-model="LIST_LCN.REQUEST_TYPE" disabled /> หลักฐานประกอบคำขอใบแทนใบอนุญาต</td>
                <tr>
                    <td>&nbsp;&nbsp;&nbsp;&nbsp; (๑) รูปถ่ายของผู้ดำเนินกิจการ ขนาด ๓ x ๔ เซนติเมตร จำนวน ๒ รูป</td>
                <tr>
                    <td>&nbsp;&nbsp;&nbsp;&nbsp; (๒) ใบอนุญาตนำหรือสั่งยาแผนปัจจุบันเข้ามาในราชอาณาจักร ถ้ามี</td>
                <tr>
                    <td>&nbsp;&nbsp;<input type="radio" value="1" ng-model="LIST_LCN.REQUEST_TYPE" disabled /> หลักฐานประกอบคำขอย้ายสถานที่</td>
                <tr>
                    <td>&nbsp;&nbsp;&nbsp;&nbsp; (๑) ใบอนุญาตผลิตแผนปัจจุบันหรือใบแทน</td>
                <tr>
                    <td>&nbsp;&nbsp;&nbsp;&nbsp; (๒) แบบแปลนแผนผังสิ่งปลูกสร้างของสถานที่ผลิตแห่งใหม่ จำำนวน ๒ ชุด</td>
                <tr>
                    <td>&nbsp;&nbsp;&nbsp;&nbsp; (๓) เอกสารแสดงว่าเป็นผู้ได้รับอนุญาต</td>
                </tr>
            </table>
            <table style="width:100%">
                <tr>
                    <td style="width:50%;text-align:center"></td>
                    <td style="width:10%;text-align:right">(ลายมือชื่อ)</td>
                    <td style="width:20%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"></td>
                    <td style="width:20%;text-align:start">ผู้ยื่นคำขอ</td>
                </tr>
            </table>
            <hr />
            <div>หมายเหตุ : &nbsp;(๑) ในกรณีที่ใบอนุญาตสูญหาย ให้นำใบรับแจ้งความของสถานีตำรวจแห่งท้องที่ที่ใบอนุญาตอนุญาตนั้นสูญหายมาด้วย</div>
            <div>&nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;(๒) ในกรณีที่ใบอนุญาตถูกทำลายในสาระสำคัญ ให้นับใบอนุญาตนั้น มาด้วย</div>
            <div>&nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;(๓) ใส่เครื่องหมาย &#10004 ในช่อง[  ] หน้าข้อความที่ต้องการ</div>

        </div>
    </div>

    <div ng-show="LIST_LCN.PROCESS == '100794'">
        <div style="font-family:'Taviraj';font-size:20px;" class="ic">
            <div>
                <p style="text-align: right;">แบบ ย.บ.๑๔</p>
            </div>

            <div>
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
                @*<table style="width:100%">
                        <tr>
                            <td style="width:20%"></td>
                            <td style="width:25%"><input type="checkbox" />&nbsp; ใบแทนใบอนุญาต</td>
                            <td style="width:20%"><input type="checkbox" />&nbsp; ผลิตยาแผนโบราณ</td>
                            <td style="width:35%; text-align:center"></td>
                        </tr>
                        <tr>
                            <td style="width:20%">คำขอ</td>
                            <td style="width:25%"></td>
                            <td style="width:20%"><input type="checkbox" />&nbsp; ขายยาแผนโบราณ</td>
                            <td style="width:35%; text-align:center"></td>
                        </tr>
                    </table>
                    <table style="width:100%">
                        <tr>
                            <td style="width:20%"></td>
                            <td style="width:25%"><input type="checkbox" />&nbsp; ย้ายสถานที่</td>
                            <td style="width:55%"><input type="checkbox" />&nbsp; นำหรือสั่งยาแผนโบราณเข้ามาในราชอาณาจักร ในนามของ</td>
                        </tr>
                    </table>*@
                <table style="width:100%">
                    <tr>
                        <td style="text-align:right;width:45%;"> <h2>คำขอ</h2></td>
                        <td width="10%">
                            <table style="width:100%">
                                <tr>
                                    <td>
                                        <label>
                                            <input type="radio" ng-model="LIST_LCN.DALCN_NCT_SUBSTITUTE.REQUEST_TYPE" value="1" disabled />ใบแทนใบอนุญาต
                                        </label>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <label>
                                            <input type="radio" ng-model="LIST_LCN.DALCN_NCT_SUBSTITUTE.REQUEST_TYPE" value="2" disabled />ย้ายสถานที่
                                        </label>
                                    </td>
                                </tr>
                            </table>
                        </td>
                        <td>
                            <table style="width:100%">
                                <tr>
                                    <td style="width:20%"><input type="radio" ng-model="LIST_LCN.LCN_TYPE" value="1" disabled />&nbsp; ผลิตยาแผนโบราณ</td>
                                </tr>
                                <tr>
                                    <td style="width:20%"><input type="radio" ng-model="LIST_LCN.LCN_TYPE" value="2" disabled />&nbsp; ขายยาแผนโบราณ</td>
                                </tr>
                                <tr>
                                    <td style="width:55%"><input type="radio" ng-model="LIST_LCN.LCN_TYPE" value="3" disabled />&nbsp; นำหรือสั่งยาแผนโบราณเข้ามาในราชอาณาจักร ในนามของ</td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                </table>
                <hr style="width:20%; border-color:black;" />
                <table style="width:100%">
                    <tr>
                        <td style="text-align:right;width:90%">
                            เขียนที่
                        </td>
                        <td style="width:40%;border-bottom:dotted;border-bottom-width:thin;">

                            {{LIST_LCN.DALCN_NCT_SUBSTITUTE.WRITE_AT}}
                        </td>
                    </tr>
                    <tr>
                        <td style="text-align:right;width:100px">
                            วันที่
                        </td>
                        <td style="border-bottom:dotted;border-bottom-width:thin;">

                            {{LIST_LCN.DALCN_NCT_SUBTITUTE.WRITE_DATE}}
                        </td>
                    </tr>
                </table>
                <br />
                <table style="width:100%">
                    <tr>
                        <td style="width:10%; text-align:right">ข้าพเจ้า :</td>
                        <td style="width:80%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"> <label>{{LIST_LCN.thanm}}</label></td>
                        <td align="left" style="width:10%;">
                            ซึ่งผู้มีดำเนินกิจการ
                        </td>
                    </tr>
                    <tr>
                        <td style="width:10%;"></td>
                        <td style="width:90%; text-align:center" colspan="2">(ชื่อผู้ขออนุญาต)</td>
                    </tr>
                </table>
                <br />
                <table style="width:100%">
                    <tr>
                        <td style="width:10%;">ชื่อ</td>
                        <td style="width:60%; text-align:center;text-align:center;border-bottom:dotted;border-bottom-width:thin;"> <label>{{LIST_LCN.BSN_THAIFULLNAME}}</label></td>
                        <td>
                            ได้รับอนุญาตให้
                        </td>
                        <td>
                            <input type="radio" ng-model="LIST_LCN.LCN_TYPE" value="1" disabled />&nbsp; ผลิตยาแผนโบราณ
                        </td>
                    </tr>
                    <tr>
                        <td style="width:10%"></td>
                        <td>
                            <input type="radio" ng-model="LIST_LCN.LCN_TYPE" value="1" disabled />&nbsp; ขายยาแผนโบราณ
                            <input type="radio" ng-model="LIST_LCN.LCN_TYPE" value="1" disabled />&nbsp; นำหรือสั่งยาแผนโบราณเข้ามาในราชอาณาจักร ตามใบอนุญาต
                        </td>
                        <td colspan="2"></td>
                    </tr>
                </table>
                <table style="width:100%">
                    <tr>
                        <td style="width:5%">ที่</td>
                        <td style="width:35%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"><label>{{LIST_LCN.LCNNO_SHOW}}</label></td>
                        <td style="width:15%">ณ สถานประกอบการ ชื่อ</td>
                        <td style="width:45%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"><label>{{LIST_LCN.thanameplace}}</label></td>
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
                <br />
                <table style="width:100%">
                    <tr>
                        <td>
                            ขอ
                        </td>
                        <td>
                            <table>
                                <tr>
                                    <td style="width:25%"><input type="checkbox" ng-model="LIST_LCN.DALCN_NCT_SUBSTITUTE.REQUEST_TYPE" disabled />&nbsp; ใบแทนใบอนุญาต</td>
                                </tr>

                            </table>
                        </td>
                        <td>
                            <table>
                                <tr>
                                    <td style="width:20%"><input type="checkbox" ng-model="LIST_LCN.LCN_TYPE" value="1" disabled />&nbsp; ผลิตยาแผนโบราณ</td>
                                </tr>
                                <tr>
                                    <td style="width:20%"><input type="checkbox" ng-model="LIST_LCN.LCN_TYPE" value="2" disabled />&nbsp; ขายยาแผนโบราณ</td>
                                </tr>
                                <tr>
                                    <td style="width:55%"><input type="checkbox" ng-model="LIST_LCN.LCN_TYPE" value="3" disabled />&nbsp; นำหรือสั่งยาแผนโบราณเข้ามาในราชอาณาจักร เนื่องจาก</td>
                                </tr>
                                <tr>
                                    <td style="border-bottom:dotted;border-bottom-width:thin">
                                        @*<input type="text" ng-model="LIST_LCN.DALCN_NCT_SUBSTITUTE.PURPOSE" />*@
                                        {{LIST_LCN.DALCN_NCT_SUBSTITUTE.PURPOSE}}
                                    </td>
                                </tr>
                                <tr>
                                    <td align="center">
                                        (เหตุที่ขอรับใบแทน)
                                    </td>
                                </tr>
                            </table>
                        </td>

                    </tr>
                    <tr>
                        <td></td>
                        <td>
                            <table>
                                <tr>
                                    <td style="width:25%"><input type="checkbox" ng-model="LIST_LCN.DALCN_NCT_SUBSTITUTE.REQUEST_TYPE" disabled />&nbsp; ย้ายสถานที่</td>
                                </tr>
                            </table>
                        </td>
                        <td>
                            <table>
                                <tr>
                                    <td style="width:20%"><input type="checkbox" ng-model="LIST_LCN.LCN_TYPE" value="1" disabled />&nbsp; ผลิตยาแผนโบราณ</td>
                                </tr>
                                <tr>
                                    <td style="width:20%"><input type="checkbox" ng-model="LIST_LCN.LCN_TYPE" value="2" disabled />&nbsp; ขายยาแผนโบราณ</td>
                                </tr>
                                <tr>
                                    <td style="width:55%"><input type="checkbox" ng-model="LIST_LCN.LCN_TYPE" value="3" disabled />&nbsp; นำหรือสั่งยาแผนโบราณเข้ามาในราชอาณาจักร เนื่องจาก</td>
                                </tr>
                                <tr>
                                    <td>
                                        @*<select class="form-control selectpicker" data-live-search="true" title="-- Please select --" style="font-family:'Taviraj'" ng-model="LIST_LCN.LOCATION_SELECT" ng-change="getdetails_lct(LIST_LCN.LOCATION_SELECT)">
                                            @*<option value="0">--กรุณาเลือก--</option>*@
                                        @*<option ng-repeat="x in REF_LOCATION" value="{{x.IDA}}">{{x.thanameplace}}</option>
                                            </select>*@
                                        {{LIST_LCN.LOCATION_SELECT}}
                                    </td>
                                </tr>
                                <tr>
                                    <td align="center">
                                        (ชื่อสถานที่)
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                </table>
                <br />
                <table width="100%">
                    <tr>
                        <td style="width:7%">ไปอยู่เลขที่</td>
                        <td style="width:93%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"><label>{{LIST_LABEL_LCT.fulladdr}}</label></td>
                    </tr>
                </table>
                <table width="100%">
                    <tr>
                        <td style="width:5%">โทรศัพท์</td>
                        <td style="width:95%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"><label>{{LIST_LABEL_LCT.tel}}</label></td>
                    </tr>
                </table>
                <br style="padding-bottom:inherit" />
                <table style="width:100%">
                    <tr>
                        <td style="width:5%"></td>
                        <td style="width:65%">ข้าพเจ้าได้แนบเอกสารมาด้วย คือ</td>
                        <td style="width:35%; text-align:center"></td>
                    </tr>
                </table>
                <br />
                <table style="width:100%">
                    <tr>
                        <td style="width:10%"></td>
                        <td style="width:65%"><input type="checkbox" value="1" ng-model="LIST_LCN.DALCN_NCT_SUBSTITUTE.REQUEST_TYPE" disabled />&nbsp; หลักฐานประกอบคำขอใบแทนใบอนุญาต</td>
                        <td style="width:35%; text-align:center"></td>
                    </tr>
                </table>
                <table style="width:100%">
                    <tr>
                        <td style="width:15%"></td>
                        <td style="width:80%">(๑) รูปถ่ายของผู้ดำเนินกิจการ ขนาด ๓ x ๔ เซนติเมตร จำนวน 2 รูป</td>
                        <td style="width:5%; text-align:center"></td>
                    </tr>
                    <tr>
                        <td style="width:15%"></td>
                        <td style="width:80%">(๒) ใบอนุญาตประกอบธุรกิจเกี่ยวกับยาแผนโบราณ (ถ้ามี)</td>
                        <td style="width:5%; text-align:center"></td>
                    </tr>
                </table>
                <table style="width:100%">
                    <tr>
                        <td style="width:10%"></td>
                        <td style="width:65%"><input type="checkbox" value="2" ng-model="LIST_LCN.DALCN_NCT_SUBSTITUTE.REQUEST_TYPE" disabled />&nbsp; หลักฐานประกอบคำขอย้ายสถานที่</td>
                        <td style="width:35%; text-align:center"></td>
                    </tr>
                </table>
                <table style="width:100%">
                    <tr>
                        <td style="width:15%"></td>
                        <td style="width:80%">(๑) ใบอนุญาตประกอบธุรกิจเกี่ยวกับยาแผนโบราณ หรือใบแทน</td>
                        <td style="width:5%; text-align:center"></td>
                    </tr>
                    <tr>
                        <td style="width:15%;"></td>
                        <td style="width:80%;">(๒) แผนที่แสดงที่ตั้งสถานที่ผลิตยาและสถานที่เก็บยา รวมทั้งสิ่งปลูกสร้างที่อยู่ในบริเวณใกล้เคียงโดยรอบของสถานที่นั้น จำนวน ๒ ชุด</td>
                        <td style="width:5%; text-align:center"></td>
                    </tr>
                    <tr>
                        <td style="width:15%"></td>
                        <td style="width:80%">
                            (๓) แบบแปลนแผนผังสิ่งปลูกสร้างภายในบริเวณสถานที่ผลิตยาและสถานที่เก็บยาที่ถูกต้อง ตามมาตราส่วน โดยแสดงรายการ ดังต่อไปนี้<br />
                            &nbsp; &nbsp; &nbsp; (ก) รูปด้านหน้า ด้านข้าง แปลนพื้น และรูปตัดของอาคารที่ใช้ในการผลิตและเก็บยา<br />
                            &nbsp; &nbsp; &nbsp; (ข) การแบ่งกั้นห้อง เนื้อที่บริเวณที่ใช้ในการผลิตและควบคุมคุณภาพยา รวมทั้งสถานที่เก็บยาและวัสดุอื่นๆ
                        </td>
                        <td style="width:5%; text-align:center"></td>
                    </tr>
                    <tr>
                        <td style="width:15%"></td>
                        <td style="width:80%">(๔) รายการวัสดุที่ใช้ในการก่อสร้างส่วนต่างๆ ของอาคาร เช่น พื้น ผนัง และเพดาน</td>
                        <td style="width:5%; text-align:center"></td>
                    </tr>
                    <tr>
                        <td style="width:15%"></td>
                        <td style="width:80%">(๕) รายการเกี่ยวกับระบบการจัดการน้ำเสีย การกำจัดสิ่งปฏิกูลและมูลฝอย ระบบควบคุมอากาศ ระบบน้ำที่ใช้ในการผลิตยา และระบบรักษความปลอดภัย</td>
                        <td style="width:5%; text-align:center"></td>
                    </tr>
                    <tr>
                        <td style="width:15%"></td>
                        <td style="width:80%">(๖) เอกสารแสดงว่าเป็นผู้ได้รับอนุญาต</td>
                        <td style="width:5%; text-align:center"></td>
                    </tr>
                </table>
                <br />
                <div>
                    <h2 style="font-family:'Taviraj';font-size:20px;">
                        ไฟล์แนบ
                    </h2>
                    <table class="table" style="width:100%">
                        <tr>
                            <td>ชื่อไฟล์</td>
                            <td></td>
                        </tr>
                        <tr ng-repeat="datas in LIST_File.FILE_LISTs" style="background-color:#FDFCE3">
                            <td>{{datas.FILENAME}}</td>
                            <td>
                                <a ng-show="datas.PATH != null && datas.PATH != ''" ng-click="OPEN_DOC_PATH(datas.PATH,datas.FILENAME)">ดูเอกสาร</a>
                            </td>
                        </tr>
                    </table>
                </div>
                <br />
                <br />
                <table style="width:100%">
                    <tr>
                        <td style="width:50%; text-align:center"></td>
                        <td style="width:10%; text-align:right">(ลายมือชื่อ)</td>
                        <td style="width:20%; text-align:center;border-bottom:dotted;border-bottom-width:thin;"></td>
                        <td style="width:20%; text-align:start">ผู้ยื่นขอ</td>
                    </tr>
                </table>
                <hr style="width:95%; border-color:black;" />
                <table style="width:100%">
                    <tr>
                        <td style="width:5%"></td>
                        <td style="width:20%">หมายเหตุ : -</td>
                        <td style="width:70%">(๑)ในกรณีที่ใบอนุญาตสูญหายให้นำใบแจ้งความของสถานีตำรวจท้องที่ที่ใบอนุญาตนั้นสูญหายมาด้วย</td>
                        <td style="width:5%"></td>
                    </tr>
                    <tr>
                        <td style="width:5%"></td>
                        <td style="width:20%"></td>
                        <td style="width:70%">(๒)ในกรณีที่ใบอนุญาตถูกทำลายในสาระสำคัญ ให้แนบใบอนุญาตนั้นมาด้วย</td>
                        <td style="width:5%"></td>
                    </tr>
                    <tr>
                        <td style="width:5%"></td>
                        <td style="width:20%"></td>
                        <td style="width:70%">(๓)ใส่เครื่องหมาย &#10003; ในช่อง &nbsp;<input type="checkbox" />&nbsp; หน้าข้อความที่ต้องการ</td>
                        <td style="width:5%"></td>
                    </tr>
                </table>
                <br />

            </div>

        </div>
    </div>
    <br />
    <div>
        <div class="col-sm-12" style="text-align:center">
            <input type="button" class="btn btn-lg" style="background-color:#38A86B;color:white" ng-click="BTN_SEND_LCN()" value="ยื่นคำขอ" ng-disabled="" />
            <input type="button" class="btn btn-lg" style="background-color:#FFD700" ng-click="BTN_LCN_BACK()" value="ย้อนกลับ" />
            <input type="button" class="btn btn-lg" ng-click="BTN_EDIT()" value="แก้ไขคำขอ" ng-show="LIST_LCN.dalcn.STATUS_ID == '5'" />
        </div>
    </div>
</div>