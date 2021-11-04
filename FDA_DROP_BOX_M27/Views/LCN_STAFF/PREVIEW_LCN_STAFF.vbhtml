@Code ViewData("Title") = "PREVIEW_LCN_STAFF" End Code

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

<div class="ic" ng-app="ANGULAR_APP" ng-controller="LCN_STAFF_CTRL" ng-init="LoadPreview()">
    <div>
        <div class="content-part">
            <div class="part part-2-3 ic">
                @*-------------------------------------------------------------------*@
                <div ng-show="LIST_LCN.PROCESS == '101'">
                    <div style="font-family:'Taviraj';font-size:24px;width:100%">
                        <h1 style="text-align:right;font-size:24px;">
                            <strong>แบบ ข.ย.๑</strong>
                        </h1>
                        <br />

                        <div class="title1" style="font-size: 16px;margin-top: 25px">
                            ที่ปิดรูปถ่าย<br />
                            ผู้ขออนุญาติ<br />
                            หรือ<br />
                            ผู้ดำเนินกิจการ<br />
                            ขนาด ๓ x ๔ ซม.<br />

                        </div>

                        <div class="title2">
                            <table style="font-size:20px;width:95%;margin-top:10px;margin-left:10px">
                                <tr>
                                    <td style="text-align:left;width:20%">
                                        เลขรับที่
                                    </td>

                                    <td style="border-bottom:dotted;border-bottom-width:thin;" colspan="3">
                                        {{LCN_LIST.RCVNO_DISPLAY}}
                                    </td>
                                </tr>
                                <tr>
                                    <td style="text-align:left">
                                        วันที่
                                    </td>

                                    <td style="border-bottom:dotted;border-bottom-width:thin;" colspan="3">
                                        {{LCN_LIST.RCV_DATE_DISPLAY}}
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

                        <h1 style="text-align:center;">
                            <strong>คำขออนุญาตขายยาแผนปัจจุบัน</strong>
                        </h1>
                        @*process =101 *@


                        <div style="text-align:center">
                            <hr style=" border-top:2px dotted ;width:17%" />
                        </div>

                        <table style="width:100%">
                            <tr>
                                <td style="text-align:right;width:90%">
                                    เขียนที่
                                </td>
                                <td style="width:40%;border-bottom:dotted;border-bottom-width:thin;">

                                    {{LIST_LCN.dalcn.WRITE_AT}}
                                </td>
                            </tr>
                            <tr>
                                <td style="text-align:right;width:100px">
                                    วันที่
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;">

                                    {{LIST_LCN.dalcn.WRITE_DATE}}
                                </td>
                            </tr>

                        </table>
                        <br />
                        <table style="width:100%;">
                            <tr>
                                <td width="5%">
                                    ข้าพเจ้า
                                </td>
                                <td style="text-align:center;border-bottom:dotted;border-bottom-width:thin;">
                                    {{LIST_LCN.thanm}}
                                </td>
                            </tr>
                            <tr>
                                <td></td>
                                <td style="text-align:center;">
                                    (ชื่อผู้ขออนุญาต)
                                </td>
                            </tr>
                        </table>

                        <br />

                        <table style=" font-size:20px;width:100%" ;>
                            <tr>
                                <td>
                                    ซึ่งมีผู้ดำเนินกิจการ ชื่อ
                                </td>
                                <td style="text-align:left;width:2000px;border-bottom:dotted;border-bottom-width:thin;">
                                    {{LIST_LCN.BSN_THAIFULLNAME}}
                                </td>
                                <td colspan="4">
                                    (เฉพาะกรณีนิติบุคคล)
                                </td>
                            </tr>
                            <tr>
                                <td style="width:20%;">
                                    เลขบัตรประจำตัวประชาชน
                                </td>
                                <td style="text-align:left;width:30%;">
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
                                </td>
                                <td>
                                    อายุ
                                </td>
                                <td style="text-align: left; width: 20%;border-bottom:dotted;border-bottom-width:thin;" align="center">
                                    {{LIST_LCN.AGE}}
                                </td>
                                <td>
                                    ปี
                                </td>
                                <td>
                                    สัญชาติ
                                </td>
                                <td style="text-align:left;width:10%;border-bottom:dotted;border-bottom-width:thin;">
                                    @*<input class="form-control inline" ng-model="LIST_LCN.dalcn.NATION" style="font-family:'Taviraj';" type="text" />*@
                                    {{LIST_LCN.dalcn.NATION}}
                                </td>

                            </tr>
                        </table>

                        <table style="font-size:20px;width:100%">
                            <tr>
                                <td style="width:200px">
                                    อยู่เลขที่
                                </td>
                                <td style="text-align:left;border-bottom:dotted;border-bottom-width:thin;" colspan="3">
                                    {{LIST_LCN.BSN_FULL_ADDR}}
                                </td>

                            </tr>
                            <tr>
                                <td>
                                    โทรศัพท์
                                </td>
                                <td style="text-align:left;border-bottom:dotted;border-bottom-width:thin;">
                                    {{LIST_LCN.BSN_TELEPHONE}}
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    โทรศัพท์มือถือ
                                </td>
                                <td style="text-align:left;border-bottom:dotted;border-bottom-width:thin;">
                                    {{LIST_LCN.BSN_FAX}}
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    E-mail
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;">
                                    @*<input class="form-control inline" ng-model="LIST_LCN.dalcn.Email" style="font-family:'Taviraj';" type="text" />*@
                                    {{LIST_LCN.dalcn.Email}}
                                </td>
                            </tr>
                        </table>
                        <br />
                        <br />
                        <h3>
                            ขอรับใบอนุญาตขายยาแผนปัจจุบันโดยมีสถานที่ขายยาชื่อ
                        </h3>
                        <table style=" font-size:20px;width:100%;">
                            <tr style="text-align:center">
                                <td style="width:10%"></td>
                                <td style="text-align:left;border-bottom:dotted;border-bottom-width:thin;">
                                    {{LIST_LCN.thanameplace}}
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    อยู่เลขที่
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;">
                                    {{LIST_LCN.fulladdr3}}
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    โทรศัพท์
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;">
                                    {{LIST_LCN.tel}}
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    โทรศัพท์มือถือ
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;">
                                    {{LIST_LCN.fax}}
                                </td>
                            </tr>
                        </table>
                        <br />
                        <br />

                        <div style=" font-size:20px;margin-left:10%"> ลักษณะการประกอบการ (๑)</div>

                        <table style=" font-size:20px;width:100%;margin-left:10%">

                            <tr>
                                <td>
                                    <form name="rdl_gmp">


                                        <input type="radio" ng-model="LIST_LCN.dalcn.CHK_SELL_TYPE" id="Rdl_gmpt" value="1" disabled> ขายปลีก<br />
                                        <input type="radio" ng-model="LIST_LCN.dalcn.CHK_SELL_TYPE" id="Rdl_gmpt" value="2" disabled> ขายส่ง<br />
                                        <input type="radio" ng-model="LIST_LCN.dalcn.CHK_SELL_TYPE" id="Rdl_gmpt" value="3" disabled> ปรุงยาสำหรับผู้ป่วยเฉพาะราย(เฉพาะขายปลีกเท่านั้น)

                                    </form>
                                </td>

                            </tr>
                        </table>
                        <br />
                        <br />
                        <hr class="hr" />
                        <br />
                        <div style=" font-size:20px;margin-left:5%">๑) ให้ตอบมากกว่า ๑ ข้อ ในกรณีมีลักษณะการประกอบการมากกว่าหนึ่งลักษณะโดยการตอบจะมีผลต่อการประเมินความพร้อมของสถานที่ </div>
                        <div style=" font-size:20px">อุปกรณ์ และการดำเนินการตามหลักวิธีปฏิบัติทางเภสัชกรรมชุมชน เพื่อประกอบการอนุญาต</div>
                        <br />

                        <div class="row">
                            <div class="col-sm-12">
                                <div class="card" style=" border-top: 10px solid #F9D027;">
                                    <table width="100%" style="font-family:'Taviraj'">
                                        <thead>
                                            <tr>
                                                <td>ชื่อสถานที่เก็บ</td>
                                                <td>อยู่เลขที่</td>
                                            </tr>
                                        </thead>
                                        <tbody>
                                            <tr ng-repeat="data in DATA_KEEP_SHOW">
                                                <td>{{datas.thanameplace}}</td>
                                                <td>{{datas.fulladdr}}</td>
                                            </tr>
                                        </tbody>
                                    </table>
                                </div>
                            </div>
                        </div>
                        <br />

                        <h3>เภสัชกร</h3>
                        <div class="row">
                            <div class="col-sm-12">
                                <div class="card" style=" border-top: 10px solid #F9D027;">
                                    <table width="100%" style="font-family:'Taviraj'">
                                        <thead>
                                            <tr>
                                                <td>เภสัชกรชั้น</td>
                                                <td>ชื่อ-นามสกุล</td>
                                                <td>เลขบัตรประจำตัวประชาชน</td>
                                                <td>ใบอนุญาตประกอบวิชาชีพเภสัชกรรมเลขที่</td>

                                            </tr>
                                        </thead>
                                        <tbody>
                                            <tr ng-repeat="data in DATA_PHR_SHOW">
                                                <td>{{data.PHR_LEVEL}}</td>
                                                <td>{{data.PHR_NAME}}</td>
                                                <td>{{data.PHR_CTZNO}}</td>
                                                <td>{{data.PHR_TEXT_NUM}}</td>
                                            </tr>
                                        </tbody>
                                    </table>
                                </div>
                            </div>
                        </div>


                        <br />
                        @*<input type="button" style="font-size:20px;width:100px" value="เพิ่ม" />*@
                        @*<input type="button" style="font-size:20px;width:100px;margin-left:10px" value="ลบ" />*@
                        <hr />

                        <table style="width:100%">
                            <tr>
                                <td style="text-align:center" colspan="2">
                                    <strong>(ถ้ามีมากกว่าหนึ่งคนให้แจ้งเพิ่มเติมท้ายคำขอนี้จน)</strong>
                                </td>
                            </tr>
                            <tr>
                                <td colspan="2">
                                    เป็นผู้มีหน้าที่ปฏิบัติการตามมาตรา ๓๙ หรือมาตรา ๔๐ แห่งรพระราชบัญญัติยา พ.ศ. ๒๕๑๐
                                </td>
                            </tr>
                            <tr>
                                <td style="width:30%">
                                    <strong>เวลาทำการ (เวลาปฏิบัติการ ของผู้มีหน้าที่ปฏิบัติการ)</strong>
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;">
                                    @*<input class="form-control inline" ng-model="LIST_LCN.DALCN_PHR.PHR_TEXT_WORK_TIME" style="font-size:20px;" type="text" />*@
                                    {{LIST_LCN.DALCN_PHR.PHR_TEXT_WORK_TIME}}
                                </td>
                            </tr>
                        </table>
                        <br />

                        <div>
                            ข้าพเจ้าขอรับรองว่าในระยะเวลาสองปีก่อนยื่นคำขอนี้ ข้าพเจ้าไม่เคยได้รับโทษจำคุกโดยคำพิพากษาถึงที่สุดหรือคำสั่งที่ชอบด้วยกฎหมายให้จำคุกในความผิดที่
                            กฎหมายบัญญัติ ให้ถือเอาการกระทำโดยทุจริตเป็นองค์ประกอบหรือในความผิดตามกฎหมายว่าด้วยยาเสพติดให้โทษ กฎหมายว่าด้วยวัตถุที่ออกฤทธิ์ต่อจิตและ
                            ประสาท กฎหมายว่าด้วยการขายยาหรือพระราชบัญญัตินี้
                            ข้าพเจ้าได้แนบหลักฐานมาด้วย คือ
                        </div>
                        <br />
                        <div style="margin-left:10%;font-size:20px">(๑) รูปถ่ายของผู้ขออนุญาต ขนาด ๓ x ๔ เซนติเมตร จำนวน ๓ รูป</div>
                        <div style="margin-left:10%;font-size:20px">(๒) เอกสารแสดงการเป็นเจ้าของกิจการและหลักทรัพย์</div>
                        <div style="margin-left:10%;font-size:20px">(๓) สำเนาทะเบียนบ้านของผู้ขออนุญาต (กรณีบุคคลธรรมดาเป็นผู้ขออนุญาต) หรือ ผู้ดำเนินกิจการ (กรณีนิติบุคคลเป็นผู้ขออนุญาต)</div>
                        <div style="margin-left:10%;font-size:20px">(๔) ใบรับรองของผู้ประกอบวิชาชีพเวชกรรมซึ่งรับรองว่าผู้ขออนุญาตไม่เป็นโรคตามมาตรา ๑๔ (๖) แห่งพระราชบัญญัติยา พ.ศ. ๒๕๑๐</div>
                        <div style="margin-left:10%;font-size:20px">(๕) สัญญาระหว่างผู้ขออนุญาตและเภสัชกร ซึ่งรับจะเป็นผู้มีหน้าที่ปฏิบัติการของผู้ขออนุญาต</div>
                        <div style="margin-left:10%;font-size:20px">(๖) สำเนาหรือรูปถ่ายใบอนุญาตประกอบวิชาชีพเภสัชกรรมของเภสัชกรทุกคน ซึ่งรับจะเป็นผู้มีหน้าที่ปฏิบัติการของผู้ขออนุญาต</div>
                        <div style="margin-left:10%;font-size:20px">(๗) เอกสารแสดงว่าเป็นผู้ดำเนินกิจการ (กรณีนิติบุคคลเป็นผู้ขออนุญาต)</div>
                        <br />
                        <br />
                        <br />
                        <table style="font-size:20px;width:40%;float:right">
                            <tr>
                                <td>
                                    (ลายมือชื่อ)
                                </td>
                                <td style="width:50%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"></td>
                                <td style="text-align:left">
                                    ผู้ขออนุญาต
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    (
                                </td>
                                <td style="width:50%;text-align:center;border-bottom:dotted;border-bottom-width:thin;">
                                    {{LIST_LCN.BSN_THAIFULLNAME}}
                                </td>
                                <td style="text-align:left">
                                    ตัวบรรจง)
                                </td>
                            </tr>
                        </table>
                    </div>
                </div>
                <div ng-show="LIST_LCN.PROCESS == 103">
                    <div class="ic" style="width:100%;font-family:'Taviraj';font-size:24px">
                        <h1 style="text-align:right;font-size:24px;">
                            <strong>แบบ ขย.๓</strong>
                        </h1>

                        <br />

                        <div class="title1">
                            <label style="font-size: 16px;margin-top: 25px">
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
                        @*process =103 *@
                        <h2 style="text-align:center;font-size:24px;">
                            <strong>คำขออนุญาตขายยาแผนปัจจุบัน</strong>
                        </h2>
                        <h2 style="text-align:center;font-size:24px;">
                            <strong>เฉพาะยาบรรจุเสร็จสำหรับสัตว์</strong>
                        </h2>



                        <div style="text-align:center">
                            <hr style=" border-top:2px dotted ;width:17%" />
                        </div>


                        <table style="width:100%">
                            <tr>
                                <td style="text-align:right;width:90%">
                                    เขียนที่
                                </td>
                                <td style="width:40%;border-bottom:dotted;border-bottom-width:thin;">

                                    {{LIST_LCN.dalcn.WRITE_AT}}
                                </td>
                            </tr>
                            <tr>
                                <td style="text-align:right;width:100px">
                                    วันที่
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;">

                                    {{LIST_LCN.dalcn.WRITE_DATE}}
                                </td>
                            </tr>

                        </table>
                        <br />
                        <table style="width:100%;">
                            <tr>
                                <td style="font-size:20px" width="5%">
                                    ข้าพเจ้า
                                </td>
                                <td style="text-align:center; font-size:20px;border-bottom:dotted;border-bottom-width:thin;">
                                    <label>{{LIST_LCN.thanm}}</label>
                                </td>
                            </tr>
                            <tr>
                                <td></td>
                                <td style="text-align:center;font-size:16px;">
                                    (ชื่อผู้ขออนุญาต)
                                </td>
                            </tr>
                        </table>
                        <br />

                        <table style=" font-size:20px;width:100%" ;>
                            <tr>
                                <td>
                                    ซึ่งมีผู้ดำเนินกิจการ ชื่อ
                                </td>
                                <td style="text-align:left;width:2000px;border-bottom:dotted;border-bottom-width:thin;">
                                    <label>{{LIST_LCN.BSN_THAIFULLNAME}}</label>
                                </td>
                                <td colspan="4">
                                    (เฉพาะกรณีนิติบุคคล)
                                </td>
                            </tr>
                            <tr>
                                <td style="width:20%;">
                                    เลขบัตรประจำตัวประชาชน
                                </td>
                                <td style="text-align:left;width:30%;">
                                    @*<label>{{LIST_LCN.BSN_IDENTIFY}}</label>*@
                                    <form action="javascript:void(0)">
                                        <table>
                                            <tr>
                                                <td style="border-bottom:dotted;border-bottom-width:thin;">
                                                    @*<input class="form-control inline" ng-model="LIST_LCN.BSN_IDENTIFY" id="txt_bsn_identify" style="font-family:'Taviraj';font-size:20px;" type="text" />*@
                                                    {{LIST_LCN.BSN_IDENTIFY}}
                                                </td>
                                                @*<td>
                                                        <input type="button" value="ค้นหาผู้ดำเนินฯ" ng-click="BTN_Search_BSN(LIST_LCN.BSN_IDENTIFY)" />
                                                    </td>*@
                                            </tr>
                                        </table>


                                    </form>
                                </td>
                                <td>
                                    อายุ
                                </td>
                                <td style="text-align:left;width:20%;border-bottom:dotted;border-bottom-width:thin;" align="center">
                                    <label>{{LIST_LCN.AGE}}</label>
                                </td>
                                <td>
                                    ปี
                                </td>
                                <td>
                                    สัญชาติ
                                </td>
                                <td style="text-align:left;width:10%;border-bottom:dotted;border-bottom-width:thin;">
                                    @*<input class="form-control inline" ng-model="LIST_LCN.dalcn.NATION" style="font-family:'Taviraj';font-size:20px;" type="text" />*@
                                    {{LIST_LCN.dalcn.NATION}}
                                </td>

                            </tr>
                        </table>
                        <table style="font-size:20px;width:100%">
                            <tr>
                                <td style="width:200px">
                                    อยู่เลขที่
                                </td>
                                <td style="text-align:left;border-bottom:dotted;border-bottom-width:thin;" colspan="3">
                                    <label>{{LIST_LCN.BSN_FULL_ADDR}}</label>
                                </td>

                            </tr>
                            <tr>
                                <td>
                                    โทรศัพท์
                                </td>
                                <td style="text-align:left;border-bottom:dotted;border-bottom-width:thin;">
                                    <label>{{LIST_LCN.BSN_TELEPHONE}}</label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    โทรศัพท์มือถือ
                                </td>
                                <td style="text-align:left;border-bottom:dotted;border-bottom-width:thin;">
                                    <label>{{LIST_LCN.BSN_FAX}}</label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    E-mail
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;">
                                    @*<input class="form-control inline" ng-model="LIST_LCN.dalcn.Email" style="font-family:'Taviraj';" type="text" />*@
                                    {{LIST_LCN.dalcn.Email}}
                                </td>
                            </tr>
                        </table>
                        <br />
                        <br />
                        <div style=" font-size:20px;margin-left:10px">ขอรับใบอนุญาตขายยาแผนปัจจุบันเฉพาะยาบรรจุเสร็จสำหรับสัตว์โดยมีสถานที่ขายยา</div>
                        <table style=" font-size:20px;width:100%">
                            <tr style="text-align:center">
                                <td style="text-align:left;width:10%">
                                    ชื่อ
                                </td>
                                <td style="text-align:left;border-bottom:dotted;border-bottom-width:thin;">
                                    <label>{{LIST_LCN.thanameplace}}</label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    อยู่เลขที่
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;">
                                    <label>{{LIST_LCN.fulladdr3}}</label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    โทรศัพท์
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;">
                                    <label>{{LIST_LCN.tel}}</label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    โทรศัพท์มือถือ
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;">
                                    <label>{{LIST_LCN.fax}}</label>
                                </td>
                            </tr>
                        </table>
                        <br />
                        <br />

                        <table style="width:50%">
                            <tr>
                                <td>
                                    ชื่อสถานที่เก็บ ( 1 ) :
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;">
                                    @*<select class="form-control selectpicker" data-live-search="true" title="-- Please select --" ng-model="LIST_LCN.LOCATION_SELECT" ng-change="getdetails(LIST_LCN.LOCATION_SELECT)">
                                        @*<option value="0">--กรุณาเลือก--</option>*@
                                    @*<option ng-repeat="x in REF_LOCATION_KEEP" value="{{x.IDA}}">{{x.thanameplace}}</option>
                                        </select>*@
                                    {{LIST_LCN.LOCATION_SELECT}}
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    อยู่เลขที่
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;">
                                    <label>{{LIST_LABEL.fulladdr}}</label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    โทรศัพท์
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;">
                                    <label>{{LIST_LABEL.tel}}</label>
                                </td>
                            </tr>
                            <tr style="font-size: 20px">
                                <td>
                                    โทรศัพท์มือถือ
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;">
                                    <label>{{LIST_LABEL.Mobile}}</label>
                                </td>
                            </tr>
                        </table>
                        <br />
                        @*<input type="button" style="font-size:20px;width:100px" value="เพิ่ม" ng-click="BTN_ADD_KEEP(LIST_LABEL,LIST_LCN.LOCATION_SELECT)" />*@
                        <br />
                        <div class="col-sm-12">
                            <div class="card" style=" border-top: 10px solid #F9D027;">
                                <table width="100%" style="font-family:'Taviraj'">
                                    <thead>
                                        <tr>
                                            <td>ชื่อสถานที่เก็บ</td>
                                            <td>อยู่เลขที่</td>
                                        </tr>
                                    </thead>
                                    <tbody>
                                        <tr ng-repeat="data in DATA_KEEP_SHOW">
                                            <td>{{datas.thanameplace}}</td>
                                            <td>{{datas.fulladdr}}</td>
                                        </tr>
                                    </tbody>
                                </table>
                            </div>
                        </div>
                        <br />
                        <br />
                        <table>
                            <tr>
                                <td>
                                    เลือกประเภทผู้ประกอบวิชาชีพเภสัชกรรมหรือสัตวแพทย์
                                </td>
                                <td>
                                    @*<select ng-model="LIST_PHR_ADD.PHR_CHK_JOB">
                                            <option value="1">ผู้ประกอบวิชาชีพเภสัชกรรม</option>
                                            <option value="2">ผู้ประกอบวิชาชีพการสัตวแพทย์</option>
                                        </select>*@
                                    {{LIST_PHR_ADD.PHR_CHK_JOB}}
                                </td>
                            </tr>
                        </table>
                        <div ng-show="LIST_PHR_ADD.PHR_CHK_JOB == '1'">
                            <table style="font-size:20px;width:100%">
                                <tr>
                                    <td style="width:20%">
                                        โดยมีผู้ประกอบวิชาชีพเภสัชกรรม ชั้น
                                    </td>
                                    <td style="width:10%;border-bottom:dotted;border-bottom-width:thin;">
                                        @*<input class="form-control inline" ng-model="LIST_PHR_ADD.PHR_LEVEL" style="font-family:'Taviraj';font-size:20px;" type="text" />*@
                                        {{LIST_PHR_ADD.PHR_LEVEL}}
                                    </td>
                                    <td style="text-align:center">
                                        ชื่อ
                                    </td>
                                    <td style="width:10%;border-bottom:dotted;border-bottom-width:thin;">
                                        @*<select class="form-control selectpicker" data-live-search="true" title="-- Please select --" ng-model="LIST_PHR_ADD.PHR_PREFIX_ID">
                                            @*<option value="0">--กรุณาเลือก--</option>*@
                                        @*<option ng-repeat="x in PREFIX" value="{{x.prefixcd}}">{{x.thanm}}</option>
                                            </select>*@
                                        {{LIST_PHR_ADD.PHR_PREFIX_ID}}
                                    </td>
                                    <td style="border-bottom:dotted;border-bottom-width:thin;">
                                        @*<input class="form-control inline" ng-model="LIST_PHR_ADD.PHR_NAME" style="font-family:'Taviraj';font-size:20px;" type="text" />*@
                                        {{LIST_PHR_ADD.PHR_NAME}}
                                    </td>
                                </tr>
                                <tr>
                                    <td style="width:20%">
                                        เลขบัตรประจำตัวประชาชน
                                    </td>
                                    <td style="border-bottom:dotted;border-bottom-width:thin;" colspan="4">
                                        @*<input class="form-control inline" ng-model="LIST_PHR_ADD.PHR_CTZNO" style="font-family:'Taviraj';font-size:20px;" type="text" />*@
                                        {{LIST_PHR_ADD.PHR_CTZNO}}
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        ใบอนุญาตประกอบวิชาชีพเภสัชกรรมเลขที่
                                    </td>
                                    <td style="border-bottom:dotted;border-bottom-width:thin;" colspan="4"></td>
                                </tr>
                                <tr>
                                    <td>
                                        เภสัชกรรมเลขที่
                                    </td>
                                    <td style="border-bottom:dotted;border-bottom-width:thin;">
                                        @*<input class="form-control inline" ng-model="LIST_PHR_ADD.PHR_TEXT_NUM" style="font-family:'Taviraj';font-size:20px;" type="text" />*@
                                        {{LIST_PHR_ADD.PHR_TEXT_NUM}}
                                    </td>
                                </tr>
                            </table>
                            <br />
                            @*<input type="button" style="font-size:20px;width:100px" value="เพิ่ม" ng-click="BTN_ADD_PHR(LIST_PHR_ADD)" />*@
                        </div>
                        <div ng-show="LIST_PHR_ADD.PHR_CHK_JOB == '2'">
                            <table style="font-size:20px;width:100%">
                                <tr>
                                    <td>
                                        โดยมี
                                    </td>
                                    <td>
                                        ผู้ประกอบวิชาชีพการสัตวแพทย์ ชั้น
                                    </td>
                                    <td style="border-bottom:dotted;border-bottom-width:thin;">
                                        @*<input class="form-control inline" ng-model="LIST_PHR_ADD.PHR_LEVEL" style="font-family:'Taviraj';font-size:20px;" type="text" />*@
                                        {{LIST_PHR_ADD.PHR_LEVEL}}
                                    </td>
                                    <td style="text-align:center; width:10%">
                                        สาขา
                                    </td>
                                    <td style="border-bottom:dotted;border-bottom-width:thin;">
                                        @*<input class="form-control inline" ng-model="LIST_PHR_ADD.PHR_VETERINARY_FIELD" style="font-family:'Taviraj';font-size:20px;" type="text" />*@
                                        {{LIST_PHR_ADD.PHR_VETERINARY_FIELD}}
                                    </td>
                                </tr>
                                <tr>
                                    <td style="width:10%">
                                        ชื่อ
                                    </td>
                                    <td style="width:10%;border-bottom:dotted;border-bottom-width:thin;">
                                        @*<select class="form-control selectpicker" data-live-search="true" title="-- Please select --" ng-model="LIST_PHR_ADD.PHR_PREFIX_ID">
                                            @*<option value="0">--กรุณาเลือก--</option>*@
                                        @*<option ng-repeat="x in PREFIX" value="{{x.prefixcd}}">{{x.thanm}}</option>
                                            </select>*@
                                        {{LIST_PHR_ADD.PHR_PREFIX_ID}}
                                    </td>
                                    <td style="border-bottom:dotted;border-bottom-width:thin;">
                                        @*<input class="form-control inline" ng-model="LIST_PHR_ADD.PHR_NAME" style="font-family:'Taviraj';font-size:20px;" type="text" />*@
                                        {{LIST_PHR_ADD.PHR_NAME}}
                                    </td>
                                </tr>
                                <tr>
                                    <td style="width:10%" colspan="2">
                                        เลขบัตรประจำตัวประชาชน
                                    </td>
                                    <td style="border-bottom:dotted;border-bottom-width:thin;">
                                        @*<input class="form-control inline" ng-model="LIST_PHR_ADD.PHR_CTZNO" style="font-family:'Taviraj';font-size:20px;" type="text" />*@
                                        {{LIST_PHR_ADD.PHR_CTZNO}}
                                    </td>

                                </tr>
                            </table>

                            <table style="font-size:20px;width:100%">
                                <tr>
                                    <td style="width:40%">
                                        ใบอนุญาตประกอบวิชาชีพการสัตวแพทย์เลขที่

                                    </td>
                                    <td style="border-bottom:dotted;border-bottom-width:thin;">
                                        @*<input class="form-control inline" ng-model="LIST_PHR_ADD.PHR_TEXT_NUM" style="font-family:'Taviraj';font-size:20px;" type="text" />*@
                                        {{LIST_PHR_ADD.PHR_TEXT_NUM}}
                                    </td>
                                </tr>
                            </table>
                            <br />
                            @*<input type="button" style="font-size:20px;width:100px" value="เพิ่ม" ng-click="BTN_ADD_PHR(LIST_PHR_ADD)" />*@
                        </div>

                        <br />
                        <div class="row">
                            <div class="col-sm-12">
                                <div class="card" style=" border-top: 10px solid #F9D027;">
                                    <table width="100%" style="font-family:'Taviraj'">
                                        <thead>
                                            <tr>
                                                <td>เภสัชกรชั้น</td>
                                                <td>ชื่อ-นามสกุล</td>
                                                <td>เลขบัตรประจำตัวประชาชน</td>
                                                <td>ใบอนุญาตประกอบวิชาชีพเภสัชกรรมเลขที่</td>

                                            </tr>
                                        </thead>
                                        <tbody>
                                            <tr ng-repeat="data in DATA_PHR_SHOW">
                                                <td>{{data.PHR_LEVEL}}</td>
                                                <td>{{data.PHR_NAME}}</td>
                                                <td>{{data.PHR_CTZNO}}</td>
                                                <td>{{data.PHR_TEXT_NUM}}</td>
                                            </tr>
                                        </tbody>
                                    </table>
                                </div>
                            </div>
                        </div>
                        <br />

                        <table style="font-size:16px;width:100%">
                            <tr>
                                <td style="text-align:center" colspan="2">
                                    <strong>(ถ้ามีมากกว่าหนึ่งคนให้แจ้งเพิ่มเติมท้ายคำขอนี้จน)</strong>
                                </td>
                            </tr>
                            <tr>
                                <td colspan="2">
                                    เป็นผู้มีหน้าที่ปฏิบัติการตามมาตรา ๓๙ หรือมาตรา ๔๐ แห่งรพระราชบัญญัติยา พ.ศ. ๒๕๑๐
                                </td>
                            </tr>
                            <tr>
                                <td style="width:30%">
                                    <strong>เวลาทำการ (เวลาปฏิบัติการ ของผู้มีหน้าที่ปฏิบัติการ)</strong>
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;">
                                    @*<input class="form-control inline" ng-model="LIST_LCN.dalcn.opentime" style="font-family:'Taviraj';font-size:20px;" type="text" />*@
                                    {{LIST_LCN.dalcn.opentime}}
                                </td>
                            </tr>
                        </table>
                        <br />
                        <hr />
                        <div style="font-size:20px">
                            ข้าพเจ้าขอรับรองว่าในระยะเวลาสองปีก่อนยื่นคำขอนี้ ข้าพเจ้าไม่เคยได้รับโทษจำคุกโดยคำพิพากษาถึงที่สุดหรือคำสั่งที่ชอบด้วยกฎหมายให้จำคุกในความผิดที่
                            กฎหมายบัญญัติ ให้ถือเอาการกระทำโดยทุจริตเป็นองค์ประกอบหรือในความผิดตามกฎหมายว่าด้วยยาเสพติดให้โทษ กฎหมายว่าด้วยวัตถุที่ออกฤทธิ์ต่อจิตและ
                            ประสาท กฎหมายว่าด้วยการขายยาหรือพระราชบัญญัตินี้
                            ข้าพเจ้าได้แนบหลักฐานมาด้วย คือ
                        </div>
                        <br />
                        <div style="margin-left:10%;font-size:20px">(๑) รูปถ่ายของผู้ขออนุญาต ขนาด ๓ x ๔ เซนติเมตร จำนวน ๓ รูป</div>
                        <div style="margin-left:10%;font-size:20px">(๒) เอกสารแสดงการเป็นเจ้าของกิจการและหลักทรัพย์</div>
                        <div style="margin-left:10%;font-size:20px">(๓) สำเนาทะเบียนบ้านของผู้ขออนุญาต (กรณีบุคคลธรรมดาเป็นผู้ขออนุญาต) หรือ ผู้ดำเนินกิจการ (กรณีนิติบุคคลเป็นผู้ขออนุญาต)</div>
                        <div style="margin-left:10%;font-size:20px">(๔) ใบรับรองของผู้ประกอบวิชาชีพเวชกรรมซึ่งรับรองว่าผู้ขออนุญาตไม่เป็นโรคตามมาตรา ๑๔ (๖) แห่งพระราชบัญญัติยา พ.ศ. ๒๕๑๐</div>
                        <div style="margin-left:10%;font-size:20px">(๕) สัญญาระหว่างผู้ขออนุญาตและเภสัชกร ซึ่งรับจะเป็นผู้มีหน้าที่ปฏิบัติการของผู้ขออนุญาต</div>
                        <div style="margin-left:10%;font-size:20px">(๖) สำเนาหรือรูปถ่ายใบอนุญาตประกอบวิชาชีพเภสัชกรรมของเภสัชกรทุกคน ซึ่งรับจะเป็นผู้มีหน้าที่ปฏิบัติการของผู้ขออนุญาต</div>
                        <div style="margin-left:10%;font-size:20px">(๗) เอกสารแสดงว่าเป็นผู้ดำเนินกิจการ (กรณีนิติบุคคลเป็นผู้ขออนุญาต)</div>
                        <div style="margin-left:10%;font-size:20px">(๘) เอกสารอื่นๆ ถ้าจำเป็น</div>
                        <br />
                        <br />
                        <br />
                        <table style="font-size:20px;width:40%;float:right">
                            <tr>
                                <td>
                                    (ลายมือชื่อ)
                                </td>
                                <td style="width:50%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"></td>
                                <td style="text-align:left">
                                    ผู้ขออนุญาต
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    (
                                </td>
                                <td style="width:50%;text-align:center;border-bottom:dotted;border-bottom-width:thin;">
                                    <label>{{LIST_LCN.BSN_THAIFULLNAME}}</label>
                                </td>
                                <td style="text-align:left">
                                    ตัวบรรจง)
                                </td>
                            </tr>
                        </table>
                    </div>
                </div>
                <div ng-show="LIST_LCN.PROCESS == 104">
                    <div style="font-family:'Taviraj';font-size:24px;width:100%">
                        <h1 style="text-align:right;font-size:24px;">
                            <strong>แบบ ข.ย.๔</strong>
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
                            <strong>คำขออนุญาตขายส่งยาแผนปัจจุบัน</strong>
                        </h2>

                        @*process =104 *@

                        <div style="text-align:center">
                            <hr style=" border-top:2px dotted ;width:17%" />
                        </div>

                        <table style="width:100%">
                            <tr>
                                <td style="text-align:right;width:90%">
                                    เขียนที่
                                </td>
                                <td style="width:40%;border-bottom:dotted;border-bottom-width:thin;">

                                    {{LIST_LCN.dalcn.WRITE_AT}}
                                </td>
                            </tr>
                            <tr>
                                <td style="text-align:right;width:100px">
                                    วันที่
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;">

                                    {{LIST_LCN.dalcn.WRITE_DATE}}
                                </td>
                            </tr>

                        </table>
                        <br />
                        <table style="width:100%;">
                            <tr>
                                <td style="font-size:20px" width="5%">
                                    ข้าพเจ้า
                                </td>
                                <td style="text-align:center; font-size:20px;border-bottom:dotted;border-bottom-width:thin;">
                                    <label>{{LIST_LCN.thanm}}</label>
                                </td>
                            </tr>
                        </table>

                        <div style="text-align:center;font-size:16px">
                            (ชื่อผู้ขออนุญาต)
                        </div>
                        <br />

                        <table style=" font-size:20px;width:100%" ;>
                            <tr>
                                <td>
                                    ซึ่งมีผู้ดำเนินกิจการ ชื่อ
                                </td>
                                <td style="text-align:left;width:2000px;border-bottom:dotted;border-bottom-width:thin;">
                                    <label>{{LIST_LCN.BSN_THAIFULLNAME}}</label>
                                </td>
                                <td colspan="4">
                                    (เฉพาะกรณีนิติบุคคล)
                                </td>
                            </tr>
                            <tr>
                                <td style="width:20%;">
                                    เลขบัตรประจำตัวประชาชน
                                </td>
                                <td style="text-align:left;width:30%;">
                                    @*<label>{{LIST_LCN.BSN_IDENTIFY}}</label>*@
                                    <form action="javascript:void(0)">
                                        <table>
                                            <tr>
                                                <td style="border-bottom:dotted;border-bottom-width:thin;">
                                                    @*<input class="form-control inline" ng-model="LIST_LCN.BSN_IDENTIFY" id="txt_bsn_identify" style="font-family:'Taviraj';font-size:20px;" type="text" />*@
                                                    {{LIST_LCN.BSN_IDENTIFY}}
                                                </td>
                                                @*<td>
                                                        <input type="button" value="ค้นหาผู้ดำเนินฯ" ng-click="BTN_Search_BSN(LIST_LCN.BSN_IDENTIFY)" />
                                                    </td>*@
                                            </tr>
                                        </table>


                                    </form>
                                </td>
                                <td>
                                    อายุ
                                </td>
                                <td style="text-align:left;width:20%;border-bottom:dotted;border-bottom-width:thin;" align="center">
                                    <label>{{LIST_LCN.AGE}}</label>
                                </td>
                                <td>
                                    ปี
                                </td>
                                <td>
                                    สัญชาติ
                                </td>
                                <td style="text-align:left;width:10%;border-bottom:dotted;border-bottom-width:thin;">
                                    @*<input class="form-control inline" ng-model="LIST_LCN.dalcn.NATION" style="font-family:'Taviraj';font-size:20px;" type="text" />*@
                                    {{LIST_LCN.dalcn.NATION}}
                                </td>

                            </tr>
                        </table>

                        <table style="font-size:20px;width:100%">
                            <tr>
                                <td style="width:200px">
                                    อยู่เลขที่
                                </td>
                                <td style="text-align:left;border-bottom:dotted;border-bottom-width:thin;" colspan="3">
                                    <label>{{LIST_LCN.BSN_FULL_ADDR}}</label>
                                </td>

                            </tr>
                            <tr>
                                <td>
                                    โทรศัพท์
                                </td>
                                <td style="text-align:left;border-bottom:dotted;border-bottom-width:thin;">
                                    <label>{{LIST_LCN.BSN_TELEPHONE}}</label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    โทรศัพท์มือถือ
                                </td>
                                <td style="text-align:left;border-bottom:dotted;border-bottom-width:thin;">
                                    <label>{{LIST_LCN.BSN_FAX}}</label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    E-mail
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;">
                                    @*<input class="form-control inline" ng-model="LIST_LCN.dalcn.Email" style="font-family:'Taviraj';" type="text" />*@
                                    {{LIST_LCN.dalcn.Email}}
                                </td>
                            </tr>
                        </table>
                        <br />
                        <br />
                        <table style=" font-size:20px;width:100%" ;>
                            <tr style="text-align:center">
                                <td>
                                    ขอรับใบอนุญาตขายยาแผนปัจจุบันโดยมีสถานที่ขายยาชื่อ
                                </td>
                                <td style="text-align:left;border-bottom:dotted;border-bottom-width:thin;">
                                    {{LIST_LCN.thanameplace}}
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    อยู่เลขที่
                                </td>
                                <td align="left" style="border-bottom:dotted;border-bottom-width:thin;">
                                    <label>{{LIST_LCN.fulladdr3}}</label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    โทรศัพท์
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;">
                                    <label>{{LIST_LCN.tel}}</label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    โทรศัพท์มือถือ
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;">
                                    <label>{{LIST_LCN.fax}}</label>
                                </td>
                            </tr>
                        </table>
                        <br />
                        <br />

                        <div style=" font-size:20px;margin-left:10%"> ลักษณะการประกอบการ (๑)</div>

                        <table style=" font-size:20px;width:100%;margin-left:10%">

                            <tr>
                                <td>
                                    <form name="rdl_gmp">


                                        <label><input type="radio" ng-model="LIST_LCN.dalcn.CHK_SELL_TYPE" id="Rdl_gmpt" value="13"> ขายส่งยาสำเร็จรูป</label><br />
                                        <label><input type="radio" ng-model="LIST_LCN.dalcn.CHK_SELL_TYPE" id="Rdl_gmpt" value="12"> ขายส่งเภสัชเคมีภัณฑ์</label>

                                    </form>
                                </td>
                            </tr>


                        </table>
                        <br />
                        <br />
                        <hr class="hr" />
                        <br />
                        <div style=" font-size:20px;margin-left:5%">๑) ให้ตอบมากกว่า ๑ ข้อ ในกรณีมีลักษณะการประกอบการมากกว่าหนึ่งลักษณะโดยการตอบจะมีผลต่อการประเมินความพร้อมของสถานที่ </div>
                        <div style=" font-size:20px">อุปกรณ์ และการดำเนินการตามหลักวิธีปฏิบัติทางเภสัชกรรมชุมชน เพื่อประกอบการอนุญาต</div>
                        <br />

                        <table style="width:50%">
                            <tr>
                                <td>
                                    ชื่อสถานที่เก็บ ( 1 ) :
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;">
                                    @*<select class="form-control selectpicker" data-live-search="true" title="-- Please select --" ng-model="LIST_LCN.LOCATION_SELECT" ng-change="getdetails(LIST_LCN.LOCATION_SELECT)">
                                        @*<option value="0">--กรุณาเลือก--</option>*@
                                    @*<option ng-repeat="x in REF_LOCATION_KEEP" value="{{x.IDA}}">{{x.thanameplace}}</option>
                                        </select>*@
                                    {{LIST_LCN.LOCATION_SELECT}}
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    อยู่เลขที่
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;">
                                    <label>{{LIST_LABEL.fulladdr}}</label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    โทรศัพท์
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;">
                                    <label>{{LIST_LABEL.tel}}</label>
                                </td>
                            </tr>
                            <tr style="font-size: 20px">
                                <td>
                                    โทรศัพท์มือถือ
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;">
                                    <label>{{LIST_LABEL.Mobile}}</label>
                                </td>
                            </tr>
                        </table>
                        <br />
                        <br />
                        @*<input type="button" style="font-size:20px;width:100px" value="เพิ่ม" ng-click="BTN_ADD_KEEP(LIST_LABEL,LIST_LCN.LOCATION_SELECT)" />*@
                        <div class="col-sm-12">
                            <div class="card" style=" border-top: 10px solid #F9D027;">
                                <table width="100%" style="font-family:'Taviraj'">
                                    <thead>
                                        <tr>
                                            <td>ชื่อสถานที่เก็บ</td>
                                            <td>อยู่เลขที่</td>
                                        </tr>
                                    </thead>
                                    <tbody>
                                        <tr ng-repeat="data in DATA_KEEP_SHOW">
                                            <td>{{datas.thanameplace}}</td>
                                            <td>{{datas.fulladdr}}</td>
                                        </tr>
                                    </tbody>
                                </table>
                            </div>
                        </div>
                        <br />
                        <br />
                        <table style="font-size:20px;width:100%">
                            <tr>
                                <td style="width:20%">
                                    โดยมีเภสัชกรชั้น
                                </td>
                                <td style="width:10%;border-bottom:dotted;border-bottom-width:thin;">
                                    @*<input class="form-control inline" ng-model="LIST_PHR_ADD.PHR_LEVEL" style="font-family:'Taviraj';font-size:20px;" type="text" />*@
                                    {{LIST_PHR_ADD.PHR_LEVEL}}
                                </td>
                                <td style="text-align:center">
                                    ชื่อ
                                </td>
                                <td style="width:10%;border-bottom:dotted;border-bottom-width:thin;">
                                    @*<select class="form-control selectpicker" data-live-search="true" title="-- Please select --" ng-model="LIST_PHR_ADD.PHR_PREFIX_ID">
                                        @*<option value="0">--กรุณาเลือก--</option>*@
                                    @*<option ng-repeat="x in PREFIX" value="{{x.prefixcd}}">{{x.thanm}}</option>
                                        </select>*@
                                    {{LIST_PHR_ADD.PHR_PREFIX_ID}}
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;">
                                    @*<input class="form-control inline" ng-model="LIST_PHR_ADD.PHR_NAME" style="font-family:'Taviraj';font-size:20px;" type="text" />*@
                                    {{LIST_PHR_ADD.PHR_NAME}}
                                </td>
                            </tr>
                            <tr>
                                <td style="width:20%">
                                    เลขบัตรประจำตัวประชาชน
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;" colspan="4">
                                    @*<input class="form-control inline" ng-model="LIST_PHR_ADD.PHR_CTZNO" style="font-family:'Taviraj';font-size:20px;" type="text" />*@
                                    {{LIST_PHR_ADD.PHR_CTZNO}}
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    ใบอนุญาตประกอบวิชาชีพ
                                </td>
                                <td style="border-bottom:dotted;" colspan="4"></td>
                            </tr>
                            <tr>
                                <td>
                                    เภสัชกรรมเลขที่
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;">
                                    @*<input class="form-control inline" ng-model="LIST_PHR_ADD.PHR_TEXT_NUM" style="font-family:'Taviraj';font-size:20px;" type="text" />*@
                                    {{LIST_PHR_ADD.PHR_TEXT_NUM}}
                                </td>
                            </tr>
                        </table>
                        <br />
                        @*<input type="button" style="font-size:20px;width:100px" value="เพิ่ม" ng-click="BTN_ADD_PHR(LIST_PHR_ADD)" />*@
                        <div class="row">
                            <div class="col-sm-12">
                                <div class="card" style=" border-top: 10px solid #F9D027;">
                                    <table width="100%" style="font-family:'Taviraj'">
                                        <thead>
                                            <tr>
                                                <td>เภสัชกรชั้น</td>
                                                <td>ชื่อ-นามสกุล</td>
                                                <td>เลขบัตรประจำตัวประชาชน</td>
                                                <td>ใบอนุญาตประกอบวิชาชีพเภสัชกรรมเลขที่</td>

                                            </tr>
                                        </thead>
                                        <tbody>
                                            <tr ng-repeat="data in DATA_PHR_SHOW">
                                                <td>{{data.PHR_LEVEL}}</td>
                                                <td>{{data.PHR_NAME}}</td>
                                                <td>{{data.PHR_CTZNO}}</td>
                                                <td>{{data.PHR_TEXT_NUM}}</td>
                                            </tr>
                                        </tbody>
                                    </table>
                                </div>
                            </div>
                        </div>
                        <hr />

                        <table style="font-size:16px;width:100%">
                            <tr>
                                <td style="text-align:center" colspan="2">
                                    <strong>(ถ้ามีมากกว่าหนึ่งคนให้แจ้งเพิ่มเติมท้ายคำขอนี้จน)</strong>
                                </td>
                            </tr>
                            <tr>
                                <td colspan="2">
                                    เป็นผู้มีหน้าที่ปฏิบัติการตามมาตรา ๓๙ หรือมาตรา ๔๐ แห่งรพระราชบัญญัติยา พ.ศ. ๒๕๑๐
                                </td>
                            </tr>
                            <tr>
                                <td style="width:30%">
                                    <strong>เวลาทำการ (เวลาปฏิบัติการ ของผู้มีหน้าที่ปฏิบัติการ)</strong>
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;">
                                    @*<input class="form-control inline" ng-model="LIST_LCN.DALCN_PHR.PHR_TEXT_WORK_TIME" style="font-size:20px;" type="text" />*@
                                    {{LIST_LCN.DALCN_PHR.PHR_TEXT_WORK_TIME}}
                                </td>
                            </tr>
                        </table>
                        <br />

                        <div style="font-size:20px">
                            ข้าพเจ้าขอรับรองว่าในระยะเวลาสองปีก่อนยื่นคำขอนี้ ข้าพเจ้าไม่เคยได้รับโทษจำคุกโดยคำพิพากษาถึงที่สุดหรือคำสั่งที่ชอบด้วยกฎหมายให้จำคุกในความผิดที่
                            กฎหมายบัญญัติ ให้ถือเอาการกระทำโดยทุจริตเป็นองค์ประกอบหรือในความผิดตามกฎหมายว่าด้วยยาเสพติดให้โทษ กฎหมายว่าด้วยวัตถุที่ออกฤทธิ์ต่อจิตและ
                            ประสาท กฎหมายว่าด้วยการขายยาหรือพระราชบัญญัตินี้
                            ข้าพเจ้าได้แนบหลักฐานมาด้วย คือ
                        </div>
                        <br />
                        <div style="margin-left:10%;font-size:20px">(๑) รูปถ่ายของผู้ขออนุญาต ขนาด ๓ x ๔ เซนติเมตร จำนวน ๓ รูป</div>
                        <div style="margin-left:10%;font-size:20px">(๒) เอกสารแสดงการเป็นเจ้าของกิจการและหลักทรัพย์</div>
                        <div style="margin-left:10%;font-size:20px">(๓) สำเนาทะเบียนบ้านของผู้ขออนุญาต (กรณีบุคคลธรรมดาเป็นผู้ขออนุญาต) หรือ ผู้ดำเนินกิจการ (กรณีนิติบุคคลเป็นผู้ขออนุญาต)</div>
                        <div style="margin-left:10%;font-size:20px">(๔) ใบรับรองของผู้ประกอบวิชาชีพเวชกรรมซึ่งรับรองว่าผู้ขออนุญาตไม่เป็นโรคตามมาตรา ๑๔ (๖) แห่งพระราชบัญญัติยา พ.ศ. ๒๕๑๐</div>
                        <div style="margin-left:10%;font-size:20px">(๕) สัญญาระหว่างผู้ขออนุญาตและเภสัชกร ซึ่งรับจะเป็นผู้มีหน้าที่ปฏิบัติการของผู้ขออนุญาต</div>
                        <div style="margin-left:10%;font-size:20px">(๖) สำเนาหรือรูปถ่ายใบอนุญาตประกอบวิชาชีพเภสัชกรรมของเภสัชกรทุกคน ซึ่งรับจะเป็นผู้มีหน้าที่ปฏิบัติการของผู้ขออนุญาต</div>
                        <div style="margin-left:10%;font-size:20px">(๗) เอกสารแสดงว่าเป็นผู้ดำเนินกิจการ (กรณีนิติบุคคลเป็นผู้ขออนุญาต)</div>
                        <br />
                        <br />
                        <br />
                        <table style="font-size:20px;width:40%;float:right">
                            <tr>
                                <td>
                                    (ลายมือชื่อ)
                                </td>
                                <td style="width:50%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"></td>
                                <td style="text-align:left">
                                    ผู้ขออนุญาต
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    (
                                </td>
                                <td style="width:50%;text-align:center;border-bottom:dotted;border-bottom-width:thin;">
                                    <label>{{LIST_LCN.BSN_THAIFULLNAME}}</label>
                                </td>
                                <td style="text-align:left">
                                    ตัวบรรจง)
                                </td>
                            </tr>
                        </table>
                    </div>
                </div>

                <div ng-show="LIST_LCN.PROCESS == '105'">
                    <div style="font-family:'Taviraj';font-size:24px;">
                        <h1 style="text-align:right;font-size:24px;">
                            <strong>เเบบ</strong>
                        </h1>
                        <br />
                        <div class="title1">
                            <label style="font-size:16px;margin-top:25px">
                                ที่ปิดรูปถ่าย<br />
                                ผู้ขออนุญาติ<br />
                                หรือ<br />
                                ผู้ดำเนินกิจการ<br />
                                ขนาด 3 x 4 ซม.<br />
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
                            <strong>คำขออนุญาตนำเข้าหรือสั่งยาเเผนปัจจุบันเข้ามาในราชอาณาจักร</strong>
                        </h2>

                        <div style="text-align:center">
                            <hr style="width:20%" />
                        </div>

                        <table style="width:100%">
                            <tr>
                                <td style="text-align:right;width:90%">
                                    เขียนที่
                                </td>
                                <td style="width:40%;border-bottom:dotted;border-bottom-width:thin;">

                                    {{LIST_LCN.dalcn.WRITE_AT}}
                                </td>
                            </tr>
                            <tr>
                                <td style="text-align:right;width:100px">
                                    วันที่
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;">

                                    {{LIST_LCN.dalcn.WRITE_DATE}}
                                </td>
                            </tr>

                        </table>
                        <br />
                        <table style="width:100%;">
                            <tr>
                                <td style="text-align:center;font-size:20px;border-bottom:dotted;border-bottom-width:thin;">
                                    <label>{{LIST_LCN.thanm}}</label>
                                </td>
                            </tr>
                            <tr>
                                <td style="text-align:center;font-size:16px">
                                    (ชื่อผู้ขออนุญาต)
                                </td>
                            </tr>
                        </table>
                        <br />
                        <table style=" font-size:20px;width:100%" ;>
                            <tr>
                                <td>
                                    ซึ่งมีผู้ดำเนินกิจการ ชื่อ
                                </td>
                                <td style="text-align:left;width:2000px;border-bottom:dotted;border-bottom-width:thin;">
                                    <label>{{LIST_LCN.BSN_THAIFULLNAME}}</label>
                                </td>
                                <td colspan="4">
                                    (เฉพาะกรณีนิติบุคคล)
                                </td>
                            </tr>
                            <tr>
                                <td style="width:20%;">
                                    เลขบัตรประจำตัวประชาชน
                                </td>
                                <td style="text-align:left;width:30%;">
                                    @*<label>{{LIST_LCN.BSN_IDENTIFY}}</label>*@
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
                                </td>
                                <td>
                                    อายุ
                                </td>
                                <td style="text-align: left; width: 20%;border-bottom:dotted;border-bottom-width:thin;" align="center">
                                    <label>{{LIST_LCN.AGE}}</label>
                                </td>
                                <td>
                                    ปี
                                </td>
                                <td>
                                    สัญชาติ
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;">
                                    @*<input class="form-control inline" ng-model="LIST_LCN.dalcn.NATION" style="font-family:'Taviraj';" type="text" />*@
                                    {{LIST_LCN.dalcn.NATION}}
                                </td>

                            </tr>
                        </table>

                        <table style="font-size:20px;width:100%">
                            <tr>
                                <td style="width:200px">
                                    อยู่เลขที่
                                </td>
                                <td style="text-align:left;border-bottom:dotted;border-bottom-width:thin;" colspan="3">
                                    <label>{{LIST_LCN.fulladdr_bsn}}</label>
                                </td>

                            </tr>
                            <tr>
                                <td>
                                    โทรศัพท์
                                </td>
                                <td style="text-align:left;border-bottom:dotted;border-bottom-width:thin;">
                                    <label>{{LIST_LCN.BSN_TELEPHONE}}</label>
                                </td>
                            </tr>
                        </table>
                        <div style="font-size:20px">
                            ขอรับใบอนุญาตนำหรือสั่งยาแผนปัจจุบันเข้ามาในราชอาณาจักร
                        </div>

                        @*process =105 *@
                        <table style="font-size:20px;width:100%">
                            <tr>
                                <td style="width:500px">
                                    โดยมีสถานที่นำหรือสั่งยาชื่อ
                                </td>
                                <td style="text-align:left;width:2000px;border-bottom:dotted;border-bottom-width:thin;">
                                    <label>{{LIST_LCN.thanameplace}}</label>
                                </td>

                            </tr>

                        </table>
                        <table style="font-size:20px;width:100%">
                            <tr>
                                <td style="width:10%">
                                    อยู่เลขที่
                                </td>
                                <td colspan="2" style="border-bottom:dotted;border-bottom-width:thin;">
                                    <label>{{LIST_LCN.fulladdr3}}</label>
                                </td>
                            </tr>
                            <tr>
                                <td style="width:155px">
                                    โทรศัพท์
                                </td>
                                <td style="text-align:left;border-bottom:dotted;border-bottom-width:thin;" width="500">
                                    <label>{{LIST_LCN.tel}}</label>
                                </td>

                            </tr>
                            <tr>
                                <td style="width:100px">
                                    เวลาทำการ
                                </td>
                                <td style="text-align:left;border-bottom:dotted;border-bottom-width:thin;">
                                    @*<input type="text" ng-model="LIST_LCN.dalcn.opentime" style="font-family:'Taviraj';font-size:20px;" />*@
                                    {{LIST_LCN.dalcn.opentime}}
                                </td>
                            </tr>
                        </table>
                        <table style="font-size:20px;width:100%">
                            <tr>
                                <td style="width:20%">
                                    โดยมีเภสัชกรชั้น
                                </td>
                                <td style="width:10%;border-bottom:dotted;border-bottom-width:thin;">
                                    @*<input class="form-control inline" ng-model="LIST_PHR_ADD.PHR_LEVEL" style="font-family:'Taviraj';font-size:20px;" type="text" />*@
                                    {{LIST_PHR_ADD.PHR_LEVEL}}
                                </td>
                                <td style="text-align:center">
                                    ชื่อ
                                </td>
                                <td style="width:10%;border-bottom:dotted;border-bottom-width:thin;">
                                    @*<select class="form-control selectpicker" data-live-search="true" title="-- Please select --" ng-model="LIST_PHR_ADD.PHR_PREFIX_ID">
                                        @*<option value="0">--กรุณาเลือก--</option>*@
                                    @*<option ng-repeat="x in PREFIX" value="{{x.prefixcd}}">{{x.thanm}}</option>
                                        </select>*@
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;">
                                    @*<input class="form-control inline" ng-model="LIST_PHR_ADD.PHR_NAME" style="font-family:'Taviraj';font-size:20px;" type="text" />*@
                                    {{LIST_PHR_ADD.PHR_NAME}}
                                </td>
                            </tr>
                            <tr>
                                <td style="width:20%">
                                    เลขบัตรประจำตัวประชาชน
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;" colspan="4">
                                    @*<input class="form-control inline" ng-model="LIST_PHR_ADD.PHR_CTZNO" style="font-family:'Taviraj';font-size:20px;" type="text" />*@
                                    {{LIST_PHR_ADD.PHR_CTZNO}}
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    ใบอนุญาตประกอบวิชาชีพ
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;" colspan="4"></td>
                            </tr>
                            <tr>
                                <td>
                                    เภสัชกรรมเลขที่
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;">
                                    @*<input class="form-control inline" ng-model="LIST_PHR_ADD.PHR_TEXT_NUM" style="font-family:'Taviraj';font-size:20px;" type="text" />*@
                                    {{LIST_PHR_ADD.PHR_TEXT_NUM}}
                                </td>
                            </tr>
                        </table>
                        <br />
                        @*<input type="button" style="font-size:20px;width:100px" value="เพิ่ม" ng-click="BTN_ADD_PHR(LIST_PHR_ADD)" />*@
                        <div class="row">
                            <div class="col-sm-12">
                                <div class="card" style=" border-top: 10px solid #F9D027;">
                                    <table width="100%" style="font-family:'Taviraj'">
                                        <thead>
                                            <tr>
                                                <td>เภสัชกรชั้น</td>
                                                <td>ชื่อ-นามสกุล</td>
                                                <td>เลขบัตรประจำตัวประชาชน</td>
                                                <td>ใบอนุญาตประกอบวิชาชีพเภสัชกรรมเลขที่</td>

                                            </tr>
                                        </thead>
                                        <tbody>
                                            <tr ng-repeat="data in DATA_PHR_SHOW">
                                                <td>{{data.PHR_LEVEL}}</td>
                                                <td>{{data.PHR_NAME}}</td>
                                                <td>{{data.PHR_CTZNO}}</td>
                                                <td>{{data.PHR_TEXT_NUM}}</td>
                                            </tr>
                                        </tbody>
                                    </table>
                                </div>
                            </div>
                        </div>

                        <div style="font-size:16px;text-align:center">(ถ้ามีมากกว่าหนึ่งคนให้แจ้งเพิ่มเติมไว้ท้ายคำขอนี้จนครบ)</div>
                        <br />
                        <center>
                            <table style="font-size:20px">
                                <tr>
                                    <td style="text-align:left;">
                                        เป็นผู้มีหน้าที่ปฏิบัติการตามมาตรา 44 แห่งพระราชบัญญัติยา พ.ศ. 2510
                                    </td>
                                </tr>
                                <tr>
                                    <td style="text-align:right;">
                                        ข้าพเจ้าขอรับรองว่า ในระยะเวลาสองปีก่อนยื่นคำขอนี้ ข้าพเจ้าไม่เคยได้รับโทษจำคุกโดย
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        คำพิพากษาถึงที่สุดหรือคำสั่งที่ชอบด้วยกฎหมายให้จำคุกในความผิดที่กฎหมายบัญญัติให้ถือเอาการกระทำ
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        โดยทุจริตเป็นองค์ประกอบหรือในความผิดตามกฎหมายว่าด้วยยาเสพติดให้โทษกฎหมายว่าด้วยวัตถุที่ออก
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        ฤทธิ์ต่อจิตและประสาทกฎหมายว่าด้วยการขายยาหรือพระราชบัญญัตินี้
                                    </td>
                                </tr>
                            </table>
                        </center>
                        <br />
                        <table style="width:50%">
                            <tr>
                                <td>
                                    ชื่อสถานที่เก็บ ( 1 ) :
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;">
                                    @*<select class="form-control selectpicker" data-live-search="true" title="-- Please select --" ng-model="LIST_LCN.LOCATION_SELECT" ng-change="getdetails(LIST_LCN.LOCATION_SELECT)">
                                        @*<option value="0">--กรุณาเลือก--</option>*@
                                    @*<option ng-repeat="x in REF_LOCATION_KEEP" value="{{x.IDA}}">{{x.thanameplace}}</option>
                                        </select>*@
                                    {{LIST_LCN.LOCATION_SELECT}}
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    อยู่เลขที่
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;">
                                    <label>{{LIST_LABEL.fulladdr}}</label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    โทรศัพท์
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;">
                                    <label>{{LIST_LABEL.tel}}</label>
                                </td>
                            </tr>
                            <tr style="font-size: 20px">
                                <td>
                                    โทรศัพท์มือถือ
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;">
                                    <label>{{LIST_LABEL.Mobile}}</label>
                                </td>
                            </tr>
                        </table>
                        <br />
                        <br />
                        @*<input type="button" style="font-size:20px;width:100px" value="เพิ่ม" ng-click="BTN_ADD_KEEP(LIST_LABEL,LIST_LCN.LOCATION_SELECT)" />*@
                        <div class="row">
                            <div class="col-sm-12">
                                <div class="card" style=" border-top: 10px solid #F9D027;">
                                    <table width="100%" style="font-family:'Taviraj'">
                                        <thead>
                                            <tr>
                                                <td>ชื่อสถานที่เก็บ</td>
                                                <td>อยู่เลขที่</td>
                                            </tr>
                                        </thead>
                                        <tbody>
                                            <tr ng-repeat="data in DATA_KEEP_SHOW">
                                                <td>{{datas.thanameplace}}</td>
                                                <td>{{datas.fulladdr}}</td>
                                            </tr>
                                        </tbody>
                                    </table>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>

                <div ng-show="LIST_LCN.PROCESS == 106">
                    <div style="font-family:'Taviraj'">

                        <h1 style="text-align:right;font-size:24px;">
                            <strong>แบบ ผ.ย.๑</strong>
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
                            <strong>คำขออนุญาตผลิตยาแผนปัจจุบัน</strong>
                        </h2>

                        @*process =106 *@

                        <div style="text-align:center">
                            <hr style=" border-top:2px dotted ;width:17%" />
                        </div>

                        <table style="width:100%">
                            <tr>
                                <td style="text-align:right;width:90%">
                                    เขียนที่
                                </td>
                                <td style="width:40%;border-bottom:dotted;border-bottom-width:thin;">

                                    {{LIST_LCN.dalcn.WRITE_AT}}
                                </td>
                            </tr>
                            <tr>
                                <td style="text-align:right;width:100px">
                                    วันที่
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;">

                                    {{LIST_LCN.dalcn.WRITE_DATE}}
                                </td>
                            </tr>

                        </table>
                        <br />
                        <table style="width:100%;">
                            <tr>
                                <td width="5%">
                                    ข้าพเจ้า
                                </td>
                                <td style="text-align:center;border-bottom:dotted;border-bottom-width:thin;">
                                    <label>{{LIST_LCN.thanm}}</label>
                                </td>
                            </tr>
                            <tr>
                                <td></td>
                                <td style="text-align:center;">
                                    (ชื่อผู้ขออนุญาต)
                                </td>
                            </tr>
                        </table>
                        <br />

                        <table style=" font-size:20px;width:100%" ;>
                            <tr>
                                <td>
                                    ซึ่งมีผู้ดำเนินกิจการ ชื่อ
                                </td>
                                <td style="text-align:left;border-bottom:dotted;border-bottom-width:thin;">
                                    <label>{{LIST_LCN.BSN_THAIFULLNAME}}</label>
                                </td>
                                <td colspan="4">
                                    (เฉพาะกรณีนิติบุคคล)
                                </td>
                            </tr>
                            <tr>
                                <td style="width:20%;">
                                    เลขบัตรประจำตัวประชาชน
                                </td>
                                <td style="text-align:left;width:30%;">
                                    <form>
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
                                </td>
                                <td>
                                    อายุ
                                </td>
                                <td style="text-align: left; width: 20%;border-bottom:dotted;border-bottom-width:thin;" align="center">
                                    <label>{{LIST_LCN.AGE}}</label>
                                </td>
                                <td>
                                    ปี
                                </td>
                                <td>
                                    สัญชาติ
                                </td>
                                <td style="text-align:left;width:10%;border-bottom:dotted;border-bottom-width:thin;">
                                    @*<input class="form-control inline" ng-model="LIST_LCN.dalcn.NATION" style="font-family:'Taviraj';" type="text" />*@
                                    {{LIST_LCN.dalcn.NATION}}
                                </td>

                            </tr>
                        </table>

                        <table style="font-size:20px;width:100%">
                            <tr>
                                <td style="width:200px">
                                    อยู่เลขที่
                                </td>
                                <td style="text-align:left;border-bottom:dotted;border-bottom-width:thin;" colspan="3">
                                    <label>{{LIST_LCN.BSN_FULL_ADDR}}</label>
                                </td>

                            </tr>
                            <tr>
                                <td>
                                    โทรศัพท์
                                </td>
                                <td style="text-align:left;border-bottom:dotted;border-bottom-width:thin;">
                                    <label>{{LIST_LCN.BSN_TELEPHONE}}</label>
                                </td>

                            </tr>
                        </table>

                        <table style="font-size:20px;width:100%">
                            <tr>
                                <td style="text-align:left;width:700px">
                                    ผลิตยาแผนปัจจุบันโดยมีสถานที่ผลิตยาชื่อ
                                </td>
                                <td style="text-align:left;border-bottom:dotted;border-bottom-width:thin;">
                                    <label>{{LIST_LCN.thanameplace}}</label>
                                </td>
                            </tr>
                            <tr>
                                <td style="width:10%">
                                    อยู่เลขที่
                                </td>
                                <td colspan="2" style="border-bottom:dotted;border-bottom-width:thin;">
                                    <label>{{LIST_LCN.fulladdr3}}</label>
                                </td>
                            </tr>
                        </table>

                        <table style="font-size:20px;width:100%">
                            <tr>
                                <td style="width:155px">
                                    โทรศัพท์
                                </td>
                                <td style="text-align:left;border-bottom:dotted;border-bottom-width:thin;" width="500">
                                    <label>{{LIST_LCN.tel}}</label>
                                </td>

                            </tr>
                            <tr>
                                <td style="width:100px">
                                    เวลาทำการ
                                </td>
                                <td style="text-align:left">
                                    @*<input type="text" ng-model="LIST_LCN.dalcn.opentime" style="font-family:'Taviraj';font-size:20px;" />*@
                                        {{LIST_LCN.dalcn.opentime}}
                                </td>
                            </tr>
                        </table>
                        <br />
                        <div style="font-size:20px;margin-left:5%">สำหรับผลิตยาแผนปัจจุบันในหมวดยาต่อไปนี้</div>

                        <div>
                            <table style=" width:60% ;font-size:20px;margin:auto">
                                <tr style="text-align:center">
                                    <th style="width:60%">
                                        หมวดยา
                                    </th>
                                    <th>
                                        ผลิต
                                    </th>
                                    <th>
                                        บรรจุ
                                    </th>
                                </tr>
                                <tr>
                                    <td>
                                        ยาปราศจากเชื้อ
                                    </td>
                                    <td>
                                        <input class="checkbox" type="checkbox" ng-model="LIST_LCN.dalcn.syslcnsid_identify" />
                                        {{LIST_LCN.dalcn.syslcnsid_identify}}
                                    </td>
                                    <td>
                                        <input class="checkbox" type="checkbox" ng-model="LIST_LCN.dalcn.syslcnsid_lcnsid" />
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        ยาที่ไม่ใช่ยาปราศจากเชื้อ
                                    </td>
                                    <td>
                                        <input class="checkbox" type="checkbox" ng-model="LIST_LCN.dalcn.lcnsid_crtlct" />
                                    </td>
                                    <td>
                                        <input class="checkbox" type="checkbox" ng-model="LIST_LCN.dalcn.lcnsid_chngwtcd" />
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        ยาชีววัตถุ
                                    </td>
                                    <td>
                                        <input class="checkbox" type="checkbox" ng-model="LIST_LCN.dalcn.lcnsid_ntcd" />
                                    </td>
                                    <td>
                                        <input class="checkbox" type="checkbox" ng-model="LIST_LCN.dalcn.lcnsid_taxno" />
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        เภสัชเคมีภัณฑ์
                                    </td>
                                    <td>
                                        <input class="checkbox" type="checkbox" ng-model="LIST_LCN.dalcn.lcnsid_trdregno" />
                                    </td>
                                    <td>
                                        <input class="checkbox" type="checkbox" ng-model="LIST_LCN.dalcn.lcnsid_ctzno" />
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        เภสัชชีววัตถุ
                                    </td>
                                    <td>
                                        <input class="checkbox" type="checkbox" ng-model="LIST_LCN.dalcn.lcnsid_remark" />
                                    </td>
                                    <td>
                                        <input class="checkbox" type="checkbox" ng-model="LIST_LCN.dalcn.lcnsid_idst" />
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        เภสัชภัณฑ์รังสี
                                    </td>

                                    <td>
                                        <input class="checkbox" type="checkbox" ng-model="LIST_LCN.dalcn.lcnsid_phrno" />
                                    </td>
                                    <td>
                                        <input class="checkbox" type="checkbox" ng-model="LIST_LCN.dalcn.lcnsid_stfcd" />
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        ยาเตรียมแอโรโซลสำหรับสูดดมแบบกำหนดขนาดใช้
                                    </td>
                                    <td>
                                        <input class="checkbox" type="checkbox" ng-model="LIST_LCN.dalcn.lcnsid_nmprnst" />
                                    </td>
                                    <td>
                                        <input class="checkbox" type="checkbox" ng-model="LIST_LCN.dalcn.lcnsid_lstfcd" />
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        ผลิตภัณฑ์ยาสัตว์ที่ไม่ใช่ยากระตุ้นภูมิคุ้มกัน
                                    </td>
                                    <td>
                                        <input class="checkbox" type="checkbox" ng-model="LIST_LCN.dalcn.lcnsid_lcnsidst" />
                                    </td>
                                    <td>
                                        <input class="checkbox" type="checkbox" ng-model="LIST_LCN.dalcn.lcnsid_scridst" />
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        ยาสกัด
                                    </td>
                                    <td>
                                        <input class="checkbox" type="checkbox" ng-model="LIST_LCN.dalcn.lcnsid_url" />
                                    </td>
                                    <td>
                                        <input class="checkbox" type="checkbox" ng-model="LIST_LCN.dalcn.lcnsid_cncremark" />
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        ยาอื่นๆ
                                    </td>
                                    <td>
                                        <input class="checkbox" type="checkbox" ng-model="LIST_LCN.dalcn.lcnsid_email" />
                                    </td>
                                    <td>
                                        <input class="checkbox" type="checkbox" ng-model="LIST_LCN.dalcn.lcnsid_otaxno" />
                                    </td>
                                </tr>
                            </table>
                        </div>
                        <br />
                        <div style="font-size:20px">(ทั้งนี้ ให้ระบุรายละเอียดรายการหมวดยาที่ขออนุญาตผลิดในเอกสารแนบ ๑)</div>
                        <br />
                        <div style="font-size:20px;margin-left:10%">
                            โดยมีเภสัชกรชั้นหนึ่ง ตามรายการชื่อผู้มีหน้าที่ปฏิบัติการที่แนบท้าย (เอกสารแนบ ๒) เป็นผู้มีหน้าที่ปฏิบัติการ

                        </div>
                        <div style="font-size:20px">
                            ตามมาตรา ๓๘ แห่งพระราชบัญญัติยา พ.ศ.๒๕๑๐
                        </div>
                        <br />




                        <table style="width:50%">
                            <tr>
                                <td>
                                    ชื่อสถานที่เก็บ ( 1 ) :
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;">
                                    @*<select class="form-control selectpicker" data-live-search="true" title="-- Please select --" ng-model="LIST_LCN.LOCATION_SELECT" ng-change="getdetails(LIST_LCN.LOCATION_SELECT)">
                                        @*<option value="0">--กรุณาเลือก--</option>*@
                                    @*<option ng-repeat="x in REF_LOCATION_KEEP" value="{{x.IDA}}">{{x.thanameplace}}</option>
                                        </select>*@
                                    {{LIST_LCN.LOCATION_SELECT}}
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    อยู่เลขที่
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;">
                                    <label>{{LIST_LABEL.fulladdr}}</label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    โทรศัพท์
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;">
                                    <label>{{LIST_LABEL.tel}}</label>
                                </td>
                            </tr>
                            <tr style="font-size: 20px">
                                <td>
                                    โทรศัพท์มือถือ
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;">
                                    <label>{{LIST_LABEL.Mobile}}</label>
                                </td>
                            </tr>
                        </table>
                        <br />
                        <br />
                        @*<input type="button" style="font-size:20px;width:100px" value="เพิ่ม" ng-click="BTN_ADD_KEEP(LIST_LABEL,LIST_LCN.LOCATION_SELECT)" />*@
                        <div class="row">
                            <div class="col-sm-12">
                                <div class="card" style=" border-top: 10px solid #F9D027;">
                                    <table width="100%" style="font-family:'Taviraj'">
                                        <thead>
                                            <tr>
                                                <td>ชื่อสถานที่เก็บ</td>
                                                <td>อยู่เลขที่</td>
                                            </tr>
                                        </thead>
                                        <tbody>
                                            <tr ng-repeat="data in DATA_KEEP_SHOW">
                                                <td>{{datas.thanameplace}}</td>
                                                <td>{{datas.fulladdr}}</td>
                                            </tr>
                                        </tbody>
                                    </table>
                                </div>
                            </div>
                        </div>
                        <br />
                        <table style="font-size:20px;width:100%">
                            <tr>
                                <td style="width:20%">
                                    โดยมีเภสัชกรชั้น
                                </td>
                                <td style="width:10%;border-bottom:dotted;border-bottom-width:thin;">
                                    @*<input class="form-control inline" ng-model="LIST_PHR_ADD.PHR_LEVEL" style="font-family:'Taviraj';font-size:20px;" type="text" />*@
                                </td>
                                <td style="text-align:center">
                                    ชื่อ
                                </td>
                                <td style="width:10%">
                                    @*<select class="form-control selectpicker" data-live-search="true" title="-- Please select --" ng-model="LIST_PHR_ADD.PHR_PREFIX_ID">
                                        @*<option value="0">--กรุณาเลือก--</option>*@
                                    @*<option ng-repeat="x in PREFIX" value="{{x.prefixcd}}">{{x.thanm}}</option>
                                        </select>*@
                                    {{LIST_PHR_ADD.PHR_PREFIX_ID}}
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;">
                                    @*<input class="form-control inline" ng-model="LIST_PHR_ADD.PHR_NAME" style="font-family:'Taviraj';font-size:20px;" type="text" />*@
                                    {{LIST_PHR_ADD.PHR_NAME}}
                                </td>
                            </tr>
                            <tr>
                                <td style="width:20%">
                                    เลขบัตรประจำตัวประชาชน
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;" colspan="4">
                                    @*<input class="form-control inline" ng-model="LIST_PHR_ADD.PHR_CTZNO" style="font-family:'Taviraj';font-size:20px;" type="text" />*@
                                    {{LIST_PHR_ADD.PHR_CTZNO}}
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    ใบอนุญาตประกอบวิชาชีพ
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;" colspan="4"></td>
                            </tr>
                            <tr>
                                <td>
                                    เภสัชกรรมเลขที่
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;">
                                    @*<input class="form-control inline" ng-model="LIST_PHR_ADD.PHR_TEXT_NUM" style="font-family:'Taviraj';font-size:20px;" type="text" />*@
                                    {{LIST_PHR_ADD.PHR_TEXT_NUM}}
                                </td>
                            </tr>
                            <tr>
                                <td style="padding-left:4%">
                                    หน้าที่ (ถ้ามี)
                                </td>
                                <td>
                                    @*<select class="form-control selectpicker" data-live-search="true" title="-- Please select --" style="font-family:'Taviraj';font-size:20px;" ng-model="LIST_PHR_ADD.PHR_JOB_TYPE">
                                        @*<option value="0">--กรุณาเลือก--</option>*@
                                    @*<option ng-repeat="x in CNT_functnm" value="{{x.functcd}}">{{x.functnm}}</option>
                                        </select>*@
                                    @*<div hidden>
                                            {{LIST_PHR_ADD.PHR_JOB_TYPE_NAME}}
                                        </div>*@

                                </td>
                            </tr>
                        </table>
                        <br />
                        @*<input type="button" style="font-size:20px;width:100px" value="เพิ่ม" ng-click="BTN_ADD_PHR(LIST_PHR_ADD)" />*@
                        <div class="row">
                            <div class="col-sm-12">
                                <div class="card" style=" border-top: 10px solid #F9D027;">
                                    <table width="100%" style="font-family:'Taviraj'">
                                        <thead>
                                            <tr>
                                                <td>เภสัชกรชั้น</td>
                                                <td>ชื่อ-นามสกุล</td>
                                                <td>เลขบัตรประจำตัวประชาชน</td>
                                                <td>ใบอนุญาตประกอบวิชาชีพเภสัชกรรมเลขที่</td>

                                            </tr>
                                        </thead>
                                        <tbody>
                                            <tr ng-repeat="data in DATA_PHR_SHOW">
                                                <td>{{data.PHR_LEVEL}}</td>
                                                <td>{{data.PHR_NAME}}</td>
                                                <td>{{data.PHR_CTZNO}}</td>
                                                <td>{{data.PHR_TEXT_NUM}}</td>
                                            </tr>
                                        </tbody>
                                    </table>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>



                <div ng-show="LIST_LCN.PROCESS == '107'">
                    <div style="font-family:'Taviraj';font-size:24px;">
                        <h2 style="text-align:center;font-size:24px;">
                            <strong>คำขอ</strong>
                        </h2>
                        <center>
                            <table style="font-size:20px">
                                <tr>
                                    <td>
                                        <form name="rdl_gmp">

                                            <input type="radio" ng-model="LIST_LCN.PROCESS" id="rdl_lcn_process" value="109" disabled="disabled">
                                            ผลิตยาแผนโบราณ

                                            <input type="radio" ng-model="LIST_LCN.PROCESS" id="rdl_lcn_process" value="107" disabled="disabled">
                                            ขายยาแผนโบราณ

                                            <input type="radio" ng-model="LIST_LCN.PROCESS" id="rdl_lcn_process" value="108" disabled="disabled">
                                            นำหรือสั่งยาแผนโบราณเข้ามาในราชอาณาจักร

                                        </form>
                                    </td>
                                </tr>
                            </table>
                        </center>
                        <br />
                        <table style="width:100%">
                            <tr>
                                <td style="text-align:right;width:90%">
                                    เขียนที่
                                </td>
                                <td style="width:40%;border-bottom:dotted;border-bottom-width:thin;">

                                    {{LIST_LCN.dalcn.WRITE_AT}}
                                </td>
                            </tr>
                            <tr>
                                <td style="text-align:right;width:100px">
                                    วันที่
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;">

                                    {{LIST_LCN.dalcn.WRITE_DATE}}
                                </td>
                            </tr>

                        </table>
                        <br />
                        <table style="width:100%;">
                            <tr>
                                <td>
                                    ข้าพเจ้า <label>{{LIST_LCN.thanm}}</label>
                                </td>
                            </tr>
                            <tr>
                                <td style="text-align:center;font-size:16px">
                                    (ชื่อผู้ขออนุญาต)
                                </td>
                            </tr>
                        </table>
                        <br />
                        <table style=" font-size:20px;width:100%" ;>
                            <tr>
                                <td style="width:30%">
                                    ซึ่งมีผู้ดำเนินกิจการ ชื่อ
                                </td>
                                <td style="text-align:left;width:2000px;border-bottom:dotted;border-bottom-width:thin;">
                                    <label>{{LIST_LCN.BSN_THAIFULLNAME}}</label>
                                </td>
                                <td colspan="5"></td>
                            </tr>
                            <tr>
                                <td style="width:20%;">
                                    เลขบัตรประจำตัวประชาชน
                                </td>
                                <td style="text-align:left;width:30%;">
                                    @*<label>{{LIST_LCN.BSN_IDENTIFY}}</label>*@
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
                                </td>
                                <td>
                                    อายุ
                                </td>
                                <td style="text-align: left; width: 20%;border-bottom:dotted;border-bottom-width:thin;" align="center">
                                    <label>{{LIST_LCN.AGE}}</label>
                                </td>
                                <td>
                                    ปี
                                </td>
                                <td>
                                    สัญชาติ
                                </td>
                                <td style="text-align:left;width:10%;border-bottom:dotted;border-bottom-width:thin;">
                                    @*<input class="form-control inline" ng-model="LIST_LCN.dalcn.NATION" style="font-family:'Taviraj';" type="text" />*@
                                    {{LIST_LCN.dalcn.NATION}}
                                </td>

                            </tr>
                        </table>
                        <table style="font-size:20px;width:100%">
                            <tr>
                                <td style="width:200px">
                                    อยู่เลขที่
                                </td>
                                <td style="text-align:left;border-bottom:dotted;border-bottom-width:thin;" colspan="3">
                                    <label>{{LIST_LCN.BSN_FULL_ADDR}}</label>
                                </td>

                            </tr>
                            <tr>
                                <td>
                                    โทรศัพท์
                                </td>
                                <td style="text-align:left;border-bottom:dotted;border-bottom-width:thin;">
                                    <label>{{LIST_LCN.BSN_TELEPHONE}}</label>
                                </td>
                            </tr>
                        </table>
                        <table style="font-size:20px;width:100%">
                            <tr>
                                <td>
                                    ขอรับใบอนุญาต
                                </td>
                                <td>
                                    <form name="rdl_gmp">

                                        <input type="radio" ng-model="LIST_LCN.PROCESS" id="rdl_lcn_process" value="109" disabled="disabled">
                                        ผลิตยาแผนโบราณ

                                        <input type="radio" ng-model="LIST_LCN.PROCESS" id="rdl_lcn_process" value="107" disabled="disabled">
                                        ขายยาแผนโบราณ

                                        <input type="radio" ng-model="LIST_LCN.PROCESS" id="rdl_lcn_process" value="108" disabled="disabled">
                                        นำหรือสั่งยาแผนโบราณเข้ามาในราชอาณาจักร

                                    </form>
                                </td>
                                <td>
                                    หมวด
                                </td>
                                <td style=border-bottom:dotted;border-bottom-width:thin;>
                                    @*<input class="form-control inline" ng-model="LIST_LCN.dalcn.CATEGORY_DRUG" style="font-family:'Taviraj';font-size:20px;" type="text" />*@
                                    {{LIST_LCN.dalcn.CATEGORY_DRUG}}
                                </td>
                            </tr>
                        </table>
                        <table style="font-size:20px;width:100%">
                            <tr>
                                <td style="width:500px">
                                    โดยมีสถานที่ประกอบธุรกิจ
                                </td>
                                <td style="text-align:left;width:2000px;border-bottom:dotted;border-bottom-width:thin;">
                                    <label>{{LIST_LCN.thanameplace}}</label>
                                </td>

                            </tr>

                        </table>
                        <table style="font-size:20px;width:100%">
                            <tr>
                                <td style="width:10%">
                                    อยู่เลขที่
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;">
                                    <label>{{LIST_LCN.fulladdr3}}</label>
                                </td>
                            </tr>
                            <tr>
                                <td style="width:155px">
                                    โทรศัพท์
                                </td>
                                <td style="text-align:left;border-bottom:dotted;border-bottom-width:thin;" width="500">
                                    <label>{{LIST_LCN.tel}}</label>
                                </td>

                            </tr>
                            <tr>
                                <td style="width:100px">
                                    เวลาทำการ
                                </td>
                                <td style="text-align:left;border-bottom:dotted;border-bottom-width:thin;">
                                    @*<input type="text" ng-model="LIST_LCN.dalcn.opentime" />*@
                                    {{LIST_LCN.dalcn.opentime}}
                                </td>
                            </tr>
                        </table>
                        <table style="font-size:20px;width:100%">
                            <tr>
                                <td style="width:13%">
                                    โดยมีผู้ประกอบโรคศิลปะแผนโบราณ สาขา
                                </td>
                                <td style="text-align:left;width:8%;border-bottom:dotted;border-bottom-width:thin;">
                                    @*<input class="form-control inline" ng-model="LIST_LCN.DALCN_PHR.PHR_VETERINARY_FIELD" style="font-family:'Taviraj';font-size:20px;" type="text" />*@
                                    {{LIST_LCN.DALCN_PHR.PHR_VETERINARY_FIELD}}
                                </td>
                                <td>
                                    เลขบัตรประชาชน
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;">
                                    @*<input class="form-control inline" ng-model="LIST_LCN.DALCN_PHR.PHR_CTZNO" style="font-family:'Taviraj';font-size:20px;" type="text" />*@
                                    {{LIST_LCN.DALCN_PHR.PHR_CTZNO}}
                                </td>
                                <td style="text-align:center;width:5%">
                                    ชื่อ
                                </td>
                                <td style="text-align:left ;width:7.5%;border-bottom:dotted;border-bottom-width:thin;">
                                    @*<select class="dropdown" ng-model="LIST_LCN.DALCN_PHR.PHR_PREFIX_ID">
                                        @*<option value="0">--กรุณาเลือก--</option>*@
                                    @*<option ng-repeat="x in PREFIX" value="{{x.prefixcd}}">{{x.thanm}}</option>
                                        </select>*@
                                    {{LIST_LCN.DALCN_PHR.PHR_PREFIX_ID}}
                                </td>
                                <td style="text-align:left;border-bottom:dotted;border-bottom-width:thin;">
                                    @*<input class="form-control inline" ng-model="LIST_LCN.DALCN_PHR.PHR_NAME" style="font-family:'Taviraj';font-size:20px;" type="text" />*@
                                    {{LIST_LCN.DALCN_PHR.PHR_NAME}}
                                </td>
                            </tr>
                        </table>
                        <table style="font-size:20px;width:100%">
                            <tr>
                                <td style="width:20%">
                                    โดยมีผู้ประกอบโรคศิลปะแผนโบราณ สาขา
                                </td>
                                <td style="width:10%;border-bottom:dotted;border-bottom-width:thin;">
                                    @*<input class="form-control inline" ng-model="LIST_PHR_ADD.PHR_VETERINARY_FIELD" style="font-family:'Taviraj';font-size:20px;" type="text" />*@
                                    {{LIST_PHR_ADD.PHR_VETERINARY_FIELD}}
                                </td>
                                <td style="text-align:center">
                                    ชื่อ
                                </td>
                                <td style="width:10%">
                                    @*<select class="form-control selectpicker" data-live-search="true" title="-- Please select --" ng-model="LIST_PHR_ADD.PHR_PREFIX_ID">
                                        @*<option value="0">--กรุณาเลือก--</option>*@
                                    @*<option ng-repeat="x in PREFIX" value="{{x.prefixcd}}">{{x.thanm}}</option>
                                        </select>*@
                                    {{LIST_PHR_ADD.PHR_PREFIX_ID}}
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;">
                                    @*<input class="form-control inline" ng-model="LIST_PHR_ADD.PHR_NAME" style="font-family:'Taviraj';font-size:20px;" type="text" />*@
                                    {{LIST_PHR_ADD.PHR_NAME}}
                                </td>
                            </tr>
                            <tr>
                                <td style="width:20%">
                                    เลขบัตรประจำตัวประชาชน
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;" colspan="4">
                                    @*<input class="form-control inline" ng-model="LIST_PHR_ADD.PHR_CTZNO" style="font-family:'Taviraj';font-size:20px;" type="text" />*@
                                    {{LIST_PHR_ADD.PHR_CTZNO}}
                                </td>
                            </tr>

                            <tr>
                                <td>
                                    ใบอนุญาตประกอบวิชาชีพเภสัชกรรมเลขที่
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;">
                                    @*<input class="form-control inline" ng-model="LIST_PHR_ADD.PHR_TEXT_NUM" style="font-family:'Taviraj';font-size:20px;" type="text" />*@
                                    {{LIST_PHR_ADD.PHR_TEXT_NUM}}
                                </td>
                            </tr>
                        </table>
                        <br />
                        @*<input type="button" style="font-size:20px;width:100px" value="เพิ่ม" ng-click="BTN_ADD_PHR(LIST_PHR_ADD)" />*@
                        <div class="row">
                            <div class="col-sm-12">
                                <div class="card" style=" border-top: 10px solid #F9D027;">
                                    <table width="100%" style="font-family:'Taviraj'">
                                        <thead>
                                            <tr>
                                                <td>ผู้ประกอบโรคศิลปะแผนโบราณ สาขา</td>
                                                <td>ชื่อ-นามสกุล</td>
                                                <td>เลขบัตรประจำตัวประชาชน</td>
                                            </tr>
                                        </thead>
                                        <tbody>
                                            <tr ng-repeat="data in DATA_PHR_SHOW">
                                                <td>{{data.PHR_VETERINARY_FIELD}}</td>
                                                <td>{{data.PHR_NAME}}</td>
                                                <td>{{data.PHR_CTZNO}}</td>
                                            </tr>
                                        </tbody>
                                    </table>
                                </div>
                            </div>
                        </div>
                        <table>
                            <tr>
                                <td>
                                    เป็นผู้มีหน้าที่ปฏิบัติการตามมาตรา
                                </td>
                                <td>
                                    <form name="rdl_gmp">
                                        <label><input type="radio" ng-model="LIST_LCN.PHR_LAW_SECTION" id="rdl_law_select" value="1"> มาตรา ๖๘</label>
                                        <label><input type="radio" ng-model="LIST_LCN.PHR_LAW_SECTION" id="rdl_law_select" value="2"> มาตรา ๖๙</label>
                                        <label><input type="radio" ng-model="LIST_LCN.PHR_LAW_SECTION" id="rdl_law_select" value="3">  มาตรา ๗๐ แห่งพระราชบัญญัติยา พ.ศ. ๒๕๑๐ </label>

                                    </form>
                                </td>
                            </tr>

                        </table>

                        <table style="width:50%">
                            <tr>
                                <td>
                                    ชื่อสถานที่เก็บ ( 1 ) :
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;">
                                    @*<select class="form-control selectpicker" data-live-search="true" title="-- Please select --" ng-model="LIST_LCN.LOCATION_SELECT" ng-change="getdetails(LIST_LCN.LOCATION_SELECT)">
                                        @*<option value="">--กรุณาเลือก--</option>*@
                                    @*<option ng-repeat="x in REF_LOCATION_KEEP" value="{{x.IDA}}">{{x.thanameplace}}</option>
                                        </select>*@
                                    {{LIST_LCN.LOCATION_SELECT}}
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    อยู่เลขที่
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;">
                                    <label>{{LIST_LABEL.fulladdr}}</label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    โทรศัพท์
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;">
                                    <label>{{LIST_LABEL.tel}}</label>
                                </td>
                            </tr>
                            <tr style="font-size: 20px">
                                <td>
                                    โทรศัพท์มือถือ
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;">
                                    <label>{{LIST_LABEL.Mobile}}</label>
                                </td>
                            </tr>
                        </table>


                        <br />
                        @*<input type="button" style="font-size:20px;width:100px" value="เพิ่ม" ng-click="BTN_ADD_KEEP(LIST_LABEL,LIST_LCN.LOCATION_SELECT)" />*@
                        <div class="row">
                            <div class="col-sm-12">
                                <div class="card" style=" border-top: 10px solid #F9D027;">
                                    <table width="100%" style="font-family:'Taviraj'">
                                        <thead>
                                            <tr>
                                                <td>ชื่อสถานที่เก็บ</td>
                                                <td>อยู่เลขที่</td>
                                            </tr>
                                        </thead>
                                        <tbody>
                                            <tr ng-repeat="data in DATA_KEEP_SHOW">
                                                <td>{{datas.thanameplace}}</td>
                                                <td>{{datas.fulladdr}}</td>
                                            </tr>
                                        </tbody>
                                    </table>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>

                <div ng-show="LIST_LCN.PROCESS == '108'">
                    <div style="font-family:'Taviraj';font-size:24px;">
                        <h2 style="text-align:center;font-size:24px;">
                            <strong>คำขอ</strong>
                        </h2>
                        <center>
                            <table style="font-size:20px">
                                <tr>
                                    <td>
                                        <form name="rdl_gmp">

                                            <input type="radio" ng-model="LIST_LCN.PROCESS" id="rdl_lcn_process" value="109" disabled="disabled">
                                            ผลิตยาแผนโบราณ

                                            <input type="radio" ng-model="LIST_LCN.PROCESS" id="rdl_lcn_process" value="107" disabled="disabled">
                                            ขายยาแผนโบราณ

                                            <input type="radio" ng-model="LIST_LCN.PROCESS" id="rdl_lcn_process" value="108" disabled="disabled">
                                            นำหรือสั่งยาแผนโบราณเข้ามาในราชอาณาจักร

                                        </form>
                                    </td>
                                </tr>
                            </table>
                        </center>
                        <br />
                        <table style="width:100%">
                            <tr>
                                <td style="text-align:right;width:90%">
                                    เขียนที่
                                </td>
                                <td style="width:40%;border-bottom:dotted;border-bottom-width:thin;">

                                    {{LIST_LCN.dalcn.WRITE_AT}}
                                </td>
                            </tr>
                            <tr>
                                <td style="text-align:right;width:100px">
                                    วันที่
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;">

                                    {{LIST_LCN.dalcn.WRITE_DATE}}
                                </td>
                            </tr>

                        </table>
                        <br />
                        <table style="width:100%;">
                            <tr>
                                <td>
                                    ข้าพเจ้า <label>{{LIST_LCN.thanm}}</label>
                                </td>
                            </tr>
                            <tr>
                                <td style="text-align:center;font-size:16px">
                                    (ชื่อผู้ขออนุญาต)
                                </td>
                            </tr>
                        </table>
                        <br />
                        <table style=" font-size:20px;width:100%" ;>
                            <tr>
                                <td style="width:30%">
                                    ซึ่งมีผู้ดำเนินกิจการ ชื่อ
                                </td>
                                <td style="text-align:left;width:2000px;border-bottom:dotted;border-bottom-width:thin;">
                                    <label>{{LIST_LCN.BSN_THAIFULLNAME}}</label>
                                </td>
                                <td colspan="5"></td>
                            </tr>
                            <tr>
                                <td style="width:20%;">
                                    เลขบัตรประจำตัวประชาชน
                                </td>
                                <td style="text-align:left;width:30%;">
                                    @*<label>{{LIST_LCN.BSN_IDENTIFY}}</label>*@
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
                                </td>
                                <td>
                                    อายุ
                                </td>
                                <td style="text-align: left; width: 20%;border-bottom:dotted;border-bottom-width:thin;" align="center">
                                    <label>{{LIST_LCN.AGE}}</label>
                                </td>
                                <td>
                                    ปี
                                </td>
                                <td>
                                    สัญชาติ
                                </td>
                                <td style="text-align:left;width:10%;border-bottom:dotted;border-bottom-width:thin;">
                                    @*<input class="form-control inline" ng-model="LIST_LCN.dalcn.NATION" style="font-family:'Taviraj';" type="text" />*@
                                    {{LIST_LCN.dalcn.NATION}}
                                </td>

                            </tr>
                        </table>
                        <table style="font-size:20px;width:100%">
                            <tr>
                                <td style="width:200px">
                                    อยู่เลขที่
                                </td>
                                <td style="text-align:left;border-bottom:dotted;border-bottom-width:thin;" colspan="3">
                                    <label>{{LIST_LCN.BSN_FULL_ADDR}}</label>
                                </td>

                            </tr>
                            <tr>
                                <td>
                                    โทรศัพท์
                                </td>
                                <td style="text-align:left;border-bottom:dotted;border-bottom-width:thin;">
                                    <label>{{LIST_LCN.BSN_TELEPHONE}}</label>
                                </td>
                            </tr>
                        </table>
                        <table style="font-size:20px;width:100%">
                            <tr>
                                <td>
                                    ขอรับใบอนุญาต
                                </td>
                                <td>
                                    <form name="rdl_gmp">

                                        <input type="radio" ng-model="LIST_LCN.PROCESS" id="rdl_lcn_process" value="109" disabled="disabled">
                                        ผลิตยาแผนโบราณ

                                        <input type="radio" ng-model="LIST_LCN.PROCESS" id="rdl_lcn_process" value="107" disabled="disabled">
                                        ขายยาแผนโบราณ

                                        <input type="radio" ng-model="LIST_LCN.PROCESS" id="rdl_lcn_process" value="108" disabled="disabled">
                                        นำหรือสั่งยาแผนโบราณเข้ามาในราชอาณาจักร

                                    </form>
                                </td>
                                <td>
                                    หมวด
                                </td>
                                <td style=border-bottom:dotted;border-bottom-width:thin;>
                                    @*<input class="form-control inline" ng-model="LIST_LCN.dalcn.CATEGORY_DRUG" style="font-family:'Taviraj';font-size:20px;" type="text" />*@
                                    {{LIST_LCN.dalcn.CATEGORY_DRUG}}
                                </td>
                            </tr>
                        </table>
                        <table style="font-size:20px;width:100%">
                            <tr>
                                <td style="width:500px">
                                    โดยมีสถานที่ประกอบธุรกิจ
                                </td>
                                <td style="text-align:left;width:2000px;border-bottom:dotted;border-bottom-width:thin;">
                                    <label>{{LIST_LCN.thanameplace}}</label>
                                </td>

                            </tr>

                        </table>
                        <table style="font-size:20px;width:100%">
                            <tr>
                                <td style="width:10%">
                                    อยู่เลขที่
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;">
                                    <label>{{LIST_LCN.fulladdr3}}</label>
                                </td>
                            </tr>
                            <tr>
                                <td style="width:155px">
                                    โทรศัพท์
                                </td>
                                <td style="text-align:left;border-bottom:dotted;border-bottom-width:thin;" width="500">
                                    <label>{{LIST_LCN.tel}}</label>
                                </td>

                            </tr>
                            <tr>
                                <td style="width:100px">
                                    เวลาทำการ
                                </td>
                                <td style="text-align:left;border-bottom:dotted;border-bottom-width:thin;">
                                    @*<input type="text" ng-model="LIST_LCN.dalcn.opentime" />*@
                                    {{LIST_LCN.dalcn.opentime}}
                                </td>
                            </tr>
                        </table>
                        <table style="font-size:20px;width:100%">
                            <tr>
                                <td style="width:13%">
                                    โดยมีผู้ประกอบโรคศิลปะแผนโบราณ สาขา
                                </td>
                                <td style="text-align:left;width:8%;border-bottom:dotted;border-bottom-width:thin;">
                                    @*<input class="form-control inline" ng-model="LIST_LCN.DALCN_PHR.PHR_VETERINARY_FIELD" style="font-family:'Taviraj';font-size:20px;" type="text" />*@
                                    {{LIST_LCN.DALCN_PHR.PHR_VETERINARY_FIELD}}
                                </td>
                                <td>
                                    เลขบัตรประชาชน
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;">
                                    @*<input class="form-control inline" ng-model="LIST_LCN.DALCN_PHR.PHR_CTZNO" style="font-family:'Taviraj';font-size:20px;" type="text" />*@
                                    {{LIST_LCN.DALCN_PHR.PHR_CTZNO}}
                                </td>
                                <td style="text-align:center;width:5%">
                                    ชื่อ
                                </td>
                                <td style="text-align:left ;width:7.5%;border-bottom:dotted;border-bottom-width:thin;">
                                    @*<select class="dropdown" ng-model="LIST_LCN.DALCN_PHR.PHR_PREFIX_ID">
                                        @*<option value="0">--กรุณาเลือก--</option>*@
                                    @*<option ng-repeat="x in PREFIX" value="{{x.prefixcd}}">{{x.thanm}}</option>
                                        </select>*@
                                    {{LIST_LCN.DALCN_PHR.PHR_PREFIX_ID}}
                                </td>
                                <td style="text-align:left;border-bottom:dotted;border-bottom-width:thin;">
                                    @*<input class="form-control inline" ng-model="LIST_LCN.DALCN_PHR.PHR_NAME" style="font-family:'Taviraj';font-size:20px;" type="text" />*@
                                    {{LIST_LCN.DALCN_PHR.PHR_NAME}}
                                </td>
                            </tr>
                        </table>
                        <table style="font-size:20px;width:100%">
                            <tr>
                                <td style="width:20%">
                                    โดยมีผู้ประกอบโรคศิลปะแผนโบราณ สาขา
                                </td>
                                <td style="width:10%;border-bottom:dotted;border-bottom-width:thin;">
                                    @*<input class="form-control inline" ng-model="LIST_PHR_ADD.PHR_VETERINARY_FIELD" style="font-family:'Taviraj';font-size:20px;" type="text" />*@
                                    {{LIST_PHR_ADD.PHR_VETERINARY_FIELD}}
                                </td>
                                <td style="text-align:center">
                                    ชื่อ
                                </td>
                                <td style="width:10%">
                                    @*<select class="form-control selectpicker" data-live-search="true" title="-- Please select --" ng-model="LIST_PHR_ADD.PHR_PREFIX_ID">
                                        @*<option value="0">--กรุณาเลือก--</option>*@
                                    @*<option ng-repeat="x in PREFIX" value="{{x.prefixcd}}">{{x.thanm}}</option>
                                        </select>*@
                                    {{LIST_PHR_ADD.PHR_PREFIX_ID}}
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;">
                                    @*<input class="form-control inline" ng-model="LIST_PHR_ADD.PHR_NAME" style="font-family:'Taviraj';font-size:20px;" type="text" />*@
                                    {{LIST_PHR_ADD.PHR_NAME}}
                                </td>
                            </tr>
                            <tr>
                                <td style="width:20%">
                                    เลขบัตรประจำตัวประชาชน
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;" colspan="4">
                                    @*<input class="form-control inline" ng-model="LIST_PHR_ADD.PHR_CTZNO" style="font-family:'Taviraj';font-size:20px;" type="text" />*@
                                    {{LIST_PHR_ADD.PHR_CTZNO}}
                                </td>
                            </tr>

                            <tr>
                                <td>
                                    ใบอนุญาตประกอบวิชาชีพเภสัชกรรมเลขที่
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;">
                                    @*<input class="form-control inline" ng-model="LIST_PHR_ADD.PHR_TEXT_NUM" style="font-family:'Taviraj';font-size:20px;" type="text" />*@
                                    {{LIST_PHR_ADD.PHR_TEXT_NUM}}
                                </td>
                            </tr>
                        </table>
                        <br />
                        @*<input type="button" style="font-size:20px;width:100px" value="เพิ่ม" ng-click="BTN_ADD_PHR(LIST_PHR_ADD)" />*@
                        <div class="row">
                            <div class="col-sm-12">
                                <div class="card" style=" border-top: 10px solid #F9D027;">
                                    <table width="100%" style="font-family:'Taviraj'">
                                        <thead>
                                            <tr>
                                                <td>ผู้ประกอบโรคศิลปะแผนโบราณ สาขา</td>
                                                <td>ชื่อ-นามสกุล</td>
                                                <td>เลขบัตรประจำตัวประชาชน</td>
                                            </tr>
                                        </thead>
                                        <tbody>
                                            <tr ng-repeat="data in DATA_PHR_SHOW">
                                                <td>{{data.PHR_VETERINARY_FIELD}}</td>
                                                <td>{{data.PHR_NAME}}</td>
                                                <td>{{data.PHR_CTZNO}}</td>
                                            </tr>
                                        </tbody>
                                    </table>
                                </div>
                            </div>
                        </div>
                        <table>
                            <tr>
                                <td>
                                    เป็นผู้มีหน้าที่ปฏิบัติการตามมาตรา
                                </td>
                                <td>
                                    <form name="rdl_gmp">
                                        <label><input type="radio" ng-model="LIST_LCN.PHR_LAW_SECTION" id="rdl_law_select" value="1"> มาตรา ๖๘</label>
                                        <label><input type="radio" ng-model="LIST_LCN.PHR_LAW_SECTION" id="rdl_law_select" value="2"> มาตรา ๖๙</label>
                                        <label><input type="radio" ng-model="LIST_LCN.PHR_LAW_SECTION" id="rdl_law_select" value="3">  มาตรา ๗๐ แห่งพระราชบัญญัติยา พ.ศ. ๒๕๑๐ </label>

                                    </form>
                                </td>
                            </tr>

                        </table>

                        <table style="width:50%">
                            <tr>
                                <td>
                                    ชื่อสถานที่เก็บ ( 1 ) :
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;">
                                    @*<select class="form-control selectpicker" data-live-search="true" title="-- Please select --" ng-model="LIST_LCN.LOCATION_SELECT" ng-change="getdetails(LIST_LCN.LOCATION_SELECT)">
                                        @*<option value="">--กรุณาเลือก--</option>*@
                                    @*<option ng-repeat="x in REF_LOCATION_KEEP" value="{{x.IDA}}">{{x.thanameplace}}</option>
                                        </select>*@
                                    {{LIST_LCN.LOCATION_SELECT}}
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    อยู่เลขที่
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;">
                                    <label>{{LIST_LABEL.fulladdr}}</label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    โทรศัพท์
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;">
                                    <label>{{LIST_LABEL.tel}}</label>
                                </td>
                            </tr>
                            <tr style="font-size: 20px">
                                <td>
                                    โทรศัพท์มือถือ
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;">
                                    <label>{{LIST_LABEL.Mobile}}</label>
                                </td>
                            </tr>
                        </table>


                        <br />
                        @*<input type="button" style="font-size:20px;width:100px" value="เพิ่ม" ng-click="BTN_ADD_KEEP(LIST_LABEL,LIST_LCN.LOCATION_SELECT)" />*@
                        <div class="row">
                            <div class="col-sm-12">
                                <div class="card" style=" border-top: 10px solid #F9D027;">
                                    <table width="100%" style="font-family:'Taviraj'">
                                        <thead>
                                            <tr>
                                                <td>ชื่อสถานที่เก็บ</td>
                                                <td>อยู่เลขที่</td>
                                            </tr>
                                        </thead>
                                        <tbody>
                                            <tr ng-repeat="data in DATA_KEEP_SHOW">
                                                <td>{{datas.thanameplace}}</td>
                                                <td>{{datas.fulladdr}}</td>
                                            </tr>
                                        </tbody>
                                    </table>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>

                <div ng-show="LIST_LCN.PROCESS == '109'">
                    <div style="font-family:'Taviraj';font-size:24px;">
                        <h2 style="text-align:center;font-size:24px;">
                            <strong>คำขอ</strong>
                        </h2>
                        <center>
                            <table style="font-size:20px">
                                <tr>
                                    <td>
                                        <form name="rdl_gmp">

                                            <input type="radio" ng-model="LIST_LCN.PROCESS" id="rdl_lcn_process" value="109" disabled="disabled">
                                            ผลิตยาแผนโบราณ

                                            <input type="radio" ng-model="LIST_LCN.PROCESS" id="rdl_lcn_process" value="107" disabled="disabled">
                                            ขายยาแผนโบราณ

                                            <input type="radio" ng-model="LIST_LCN.PROCESS" id="rdl_lcn_process" value="108" disabled="disabled">
                                            นำหรือสั่งยาแผนโบราณเข้ามาในราชอาณาจักร

                                        </form>
                                    </td>
                                </tr>
                            </table>
                        </center>
                        <br />
                        <table style="width:100%">
                            <tr>
                                <td style="text-align:right;width:90%">
                                    เขียนที่
                                </td>
                                <td style="width:40%;border-bottom:dotted;border-bottom-width:thin;">

                                    {{LIST_LCN.dalcn.WRITE_AT}}
                                </td>
                            </tr>
                            <tr>
                                <td style="text-align:right;width:100px">
                                    วันที่
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;">

                                    {{LIST_LCN.dalcn.WRITE_DATE}}
                                </td>
                            </tr>

                        </table>
                        <br />
                        <table style="width:100%;">
                            <tr>
                                <td>
                                    ข้าพเจ้า <label>{{LIST_LCN.thanm}}</label>
                                </td>
                            </tr>
                            <tr>
                                <td style="text-align:center;font-size:16px">
                                    (ชื่อผู้ขออนุญาต)
                                </td>
                            </tr>
                        </table>
                        <br />
                        <table style=" font-size:20px;width:100%" ;>
                            <tr>
                                <td style="width:30%">
                                    ซึ่งมีผู้ดำเนินกิจการ ชื่อ
                                </td>
                                <td style="text-align:left;width:2000px;border-bottom:dotted;border-bottom-width:thin;">
                                    <label>{{LIST_LCN.BSN_THAIFULLNAME}}</label>
                                </td>
                                <td colspan="5"></td>
                            </tr>
                            <tr>
                                <td style="width:20%;">
                                    เลขบัตรประจำตัวประชาชน
                                </td>
                                <td style="text-align:left;width:30%;">
                                    @*<label>{{LIST_LCN.BSN_IDENTIFY}}</label>*@
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
                                </td>
                                <td>
                                    อายุ
                                </td>
                                <td style="text-align: left; width: 20%;border-bottom:dotted;border-bottom-width:thin;" align="center">
                                    <label>{{LIST_LCN.AGE}}</label>
                                </td>
                                <td>
                                    ปี
                                </td>
                                <td>
                                    สัญชาติ
                                </td>
                                <td style="text-align:left;width:10%;border-bottom:dotted;border-bottom-width:thin;">
                                    @*<input class="form-control inline" ng-model="LIST_LCN.dalcn.NATION" style="font-family:'Taviraj';" type="text" />*@
                                    {{LIST_LCN.dalcn.NATION}}
                                </td>

                            </tr>
                        </table>
                        <table style="font-size:20px;width:100%">
                            <tr>
                                <td style="width:200px">
                                    อยู่เลขที่
                                </td>
                                <td style="text-align:left;border-bottom:dotted;border-bottom-width:thin;" colspan="3">
                                    <label>{{LIST_LCN.BSN_FULL_ADDR}}</label>
                                </td>

                            </tr>
                            <tr>
                                <td>
                                    โทรศัพท์
                                </td>
                                <td style="text-align:left;border-bottom:dotted;border-bottom-width:thin;">
                                    <label>{{LIST_LCN.BSN_TELEPHONE}}</label>
                                </td>
                            </tr>
                        </table>
                        <table style="font-size:20px;width:100%">
                            <tr>
                                <td>
                                    ขอรับใบอนุญาต
                                </td>
                                <td>
                                    <form name="rdl_gmp">

                                        <input type="radio" ng-model="LIST_LCN.PROCESS" id="rdl_lcn_process" value="109" disabled="disabled">
                                        ผลิตยาแผนโบราณ

                                        <input type="radio" ng-model="LIST_LCN.PROCESS" id="rdl_lcn_process" value="107" disabled="disabled">
                                        ขายยาแผนโบราณ

                                        <input type="radio" ng-model="LIST_LCN.PROCESS" id="rdl_lcn_process" value="108" disabled="disabled">
                                        นำหรือสั่งยาแผนโบราณเข้ามาในราชอาณาจักร

                                    </form>
                                </td>
                                <td>
                                    หมวด
                                </td>
                                <td style=border-bottom:dotted;border-bottom-width:thin;>
                                    @*<input class="form-control inline" ng-model="LIST_LCN.dalcn.CATEGORY_DRUG" style="font-family:'Taviraj';font-size:20px;" type="text" />*@
                                    {{LIST_LCN.dalcn.CATEGORY_DRUG}}
                                </td>
                            </tr>
                        </table>
                        <table style="font-size:20px;width:100%">
                            <tr>
                                <td style="width:500px">
                                    โดยมีสถานที่ประกอบธุรกิจ
                                </td>
                                <td style="text-align:left;width:2000px;border-bottom:dotted;border-bottom-width:thin;">
                                    <label>{{LIST_LCN.thanameplace}}</label>
                                </td>

                            </tr>

                        </table>
                        <table style="font-size:20px;width:100%">
                            <tr>
                                <td style="width:10%">
                                    อยู่เลขที่
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;">
                                    <label>{{LIST_LCN.fulladdr3}}</label>
                                </td>
                            </tr>
                            <tr>
                                <td style="width:155px">
                                    โทรศัพท์
                                </td>
                                <td style="text-align:left;border-bottom:dotted;border-bottom-width:thin;" width="500">
                                    <label>{{LIST_LCN.tel}}</label>
                                </td>

                            </tr>
                            <tr>
                                <td style="width:100px">
                                    เวลาทำการ
                                </td>
                                <td style="text-align:left;border-bottom:dotted;border-bottom-width:thin;">
                                    @*<input type="text" ng-model="LIST_LCN.dalcn.opentime" />*@
                                    {{LIST_LCN.dalcn.opentime}}
                                </td>
                            </tr>
                        </table>
                        <table style="font-size:20px;width:100%">
                            <tr>
                                <td style="width:13%">
                                    โดยมีผู้ประกอบโรคศิลปะแผนโบราณ สาขา
                                </td>
                                <td style="text-align:left;width:8%;border-bottom:dotted;border-bottom-width:thin;">
                                    @*<input class="form-control inline" ng-model="LIST_LCN.DALCN_PHR.PHR_VETERINARY_FIELD" style="font-family:'Taviraj';font-size:20px;" type="text" />*@
                                    {{LIST_LCN.DALCN_PHR.PHR_VETERINARY_FIELD}}
                                </td>
                                <td>
                                    เลขบัตรประชาชน
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;">
                                    @*<input class="form-control inline" ng-model="LIST_LCN.DALCN_PHR.PHR_CTZNO" style="font-family:'Taviraj';font-size:20px;" type="text" />*@
                                    {{LIST_LCN.DALCN_PHR.PHR_CTZNO}}
                                </td>
                                <td style="text-align:center;width:5%">
                                    ชื่อ
                                </td>
                                <td style="text-align:left ;width:7.5%;border-bottom:dotted;border-bottom-width:thin;">
                                    @*<select class="dropdown" ng-model="LIST_LCN.DALCN_PHR.PHR_PREFIX_ID">
                                        @*<option value="0">--กรุณาเลือก--</option>*@
                                    @*<option ng-repeat="x in PREFIX" value="{{x.prefixcd}}">{{x.thanm}}</option>
                                        </select>*@
                                    {{LIST_LCN.DALCN_PHR.PHR_PREFIX_ID}}
                                </td>
                                <td style="text-align:left;border-bottom:dotted;border-bottom-width:thin;">
                                    @*<input class="form-control inline" ng-model="LIST_LCN.DALCN_PHR.PHR_NAME" style="font-family:'Taviraj';font-size:20px;" type="text" />*@
                                    {{LIST_LCN.DALCN_PHR.PHR_NAME}}
                                </td>
                            </tr>
                        </table>
                        <table style="font-size:20px;width:100%">
                            <tr>
                                <td style="width:20%">
                                    โดยมีผู้ประกอบโรคศิลปะแผนโบราณ สาขา
                                </td>
                                <td style="width:10%;border-bottom:dotted;border-bottom-width:thin;">
                                    @*<input class="form-control inline" ng-model="LIST_PHR_ADD.PHR_VETERINARY_FIELD" style="font-family:'Taviraj';font-size:20px;" type="text" />*@
                                    {{LIST_PHR_ADD.PHR_VETERINARY_FIELD}}
                                </td>
                                <td style="text-align:center">
                                    ชื่อ
                                </td>
                                <td style="width:10%">
                                    @*<select class="form-control selectpicker" data-live-search="true" title="-- Please select --" ng-model="LIST_PHR_ADD.PHR_PREFIX_ID">
                                        @*<option value="0">--กรุณาเลือก--</option>*@
                                    @*<option ng-repeat="x in PREFIX" value="{{x.prefixcd}}">{{x.thanm}}</option>
                                        </select>*@
                                    {{LIST_PHR_ADD.PHR_PREFIX_ID}}
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;">
                                    @*<input class="form-control inline" ng-model="LIST_PHR_ADD.PHR_NAME" style="font-family:'Taviraj';font-size:20px;" type="text" />*@
                                    {{LIST_PHR_ADD.PHR_NAME}}
                                </td>
                            </tr>
                            <tr>
                                <td style="width:20%">
                                    เลขบัตรประจำตัวประชาชน
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;" colspan="4">
                                    @*<input class="form-control inline" ng-model="LIST_PHR_ADD.PHR_CTZNO" style="font-family:'Taviraj';font-size:20px;" type="text" />*@
                                    {{LIST_PHR_ADD.PHR_CTZNO}}
                                </td>
                            </tr>

                            <tr>
                                <td>
                                    ใบอนุญาตประกอบวิชาชีพเภสัชกรรมเลขที่
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;">
                                    @*<input class="form-control inline" ng-model="LIST_PHR_ADD.PHR_TEXT_NUM" style="font-family:'Taviraj';font-size:20px;" type="text" />*@
                                    {{LIST_PHR_ADD.PHR_TEXT_NUM}}
                                </td>
                            </tr>
                        </table>
                        <br />
                        @*<input type="button" style="font-size:20px;width:100px" value="เพิ่ม" ng-click="BTN_ADD_PHR(LIST_PHR_ADD)" />*@
                        <div class="row">
                            <div class="col-sm-12">
                                <div class="card" style=" border-top: 10px solid #F9D027;">
                                    <table width="100%" style="font-family:'Taviraj'">
                                        <thead>
                                            <tr>
                                                <td>ผู้ประกอบโรคศิลปะแผนโบราณ สาขา</td>
                                                <td>ชื่อ-นามสกุล</td>
                                                <td>เลขบัตรประจำตัวประชาชน</td>
                                            </tr>
                                        </thead>
                                        <tbody>
                                            <tr ng-repeat="data in DATA_PHR_SHOW">
                                                <td>{{data.PHR_VETERINARY_FIELD}}</td>
                                                <td>{{data.PHR_NAME}}</td>
                                                <td>{{data.PHR_CTZNO}}</td>
                                            </tr>
                                        </tbody>
                                    </table>
                                </div>
                            </div>
                        </div>
                        <table>
                            <tr>
                                <td>
                                    เป็นผู้มีหน้าที่ปฏิบัติการตามมาตรา
                                </td>
                                <td>
                                    <form name="rdl_gmp">
                                        <label><input type="radio" ng-model="LIST_LCN.PHR_LAW_SECTION" id="rdl_law_select" value="1"> มาตรา ๖๘</label>
                                        <label><input type="radio" ng-model="LIST_LCN.PHR_LAW_SECTION" id="rdl_law_select" value="2"> มาตรา ๖๙</label>
                                        <label><input type="radio" ng-model="LIST_LCN.PHR_LAW_SECTION" id="rdl_law_select" value="3">  มาตรา ๗๐ แห่งพระราชบัญญัติยา พ.ศ. ๒๕๑๐ </label>

                                    </form>
                                </td>
                            </tr>

                        </table>

                        <table style="width:50%">
                            <tr>
                                <td>
                                    ชื่อสถานที่เก็บ ( 1 ) :
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;">
                                    @*<select class="form-control selectpicker" data-live-search="true" title="-- Please select --" ng-model="LIST_LCN.LOCATION_SELECT" ng-change="getdetails(LIST_LCN.LOCATION_SELECT)">
                                        @*<option value="">--กรุณาเลือก--</option>*@
                                    @*<option ng-repeat="x in REF_LOCATION_KEEP" value="{{x.IDA}}">{{x.thanameplace}}</option>
                                        </select>*@
                                    {{LIST_LCN.LOCATION_SELECT}}
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    อยู่เลขที่
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;">
                                    <label>{{LIST_LABEL.fulladdr}}</label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    โทรศัพท์
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;">
                                    <label>{{LIST_LABEL.tel}}</label>
                                </td>
                            </tr>
                            <tr style="font-size: 20px">
                                <td>
                                    โทรศัพท์มือถือ
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;">
                                    <label>{{LIST_LABEL.Mobile}}</label>
                                </td>
                            </tr>
                        </table>


                        <br />
                        @*<input type="button" style="font-size:20px;width:100px" value="เพิ่ม" ng-click="BTN_ADD_KEEP(LIST_LABEL,LIST_LCN.LOCATION_SELECT)" />*@
                        <div class="row">
                            <div class="col-sm-12">
                                <div class="card" style=" border-top: 10px solid #F9D027;">
                                    <table width="100%" style="font-family:'Taviraj'">
                                        <thead>
                                            <tr>
                                                <td>ชื่อสถานที่เก็บ</td>
                                                <td>อยู่เลขที่</td>
                                            </tr>
                                        </thead>
                                        <tbody>
                                            <tr ng-repeat="data in DATA_KEEP_SHOW">
                                                <td>{{datas.thanameplace}}</td>
                                                <td>{{datas.fulladdr}}</td>
                                            </tr>
                                        </tbody>
                                    </table>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>

                <div ng-show="LIST_LCN.PROCESS == '131'">
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
                                    <input type="radio" name="gender" ng-model="LIST_LCN.PROCESS" value="131" id="rdl_CHK_SELL_TYPE" disabled="disabled" /> <strong>วัตถุออกฤทธิ์ในประเภท ๓</strong>
                                </td>
                                <td>
                                    <input type="radio" name="gender" ng-model="LIST_LCN.PROCESS" value="132" id="rdl_CHK_SELL_TYPE" disabled="disabled" /> <strong>วัตถุออกฤทธิ์ในประเภท ๔</strong>
                                </td>
                            </tr>
                            <tr>
                                <td style="font-size:16px" colspan="3">
                                    <strong>(คำขอ ๑ ฉบับ ให้ยื่นขอได้เพียงหนึ่งประเภทเท่านั้น)</strong>
                                </td>
                            </tr>
                        </table>

                        <table style="width:100%; font-size:20px;">
                            <tr>
                                <td style="width:20%">
                                    <input type="checkbox" name="gender" disabled="disabled" ng-checked="true" /> <strong>ขอรับใบอนุญาต</strong>
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
                                    <input type="checkbox" name="gender" disabled="disabled" /> <strong>ขอรับใบแทนใบอนุญาต</strong>
                                </td>
                                <td>
                                    เนื่องจากใบอนุญาต
                                </td>
                                <td>
                                    <input class="checkbox" type="checkbox" disabled="disabled" /> <strong>สูญหาย</strong>
                                </td>
                                <td>
                                    <input class="checkbox" type="checkbox" disabled="disabled" /> <strong>ถูกทำลายหรือลบเลือนในสาระสำคัญ</strong>
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

                                    {{LIST_LCN.dalcn.WRITE_AT}}
                                </td>
                            </tr>
                            <tr>
                                <td style="text-align:right;width:100px">
                                    วันที่
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;">

                                    {{LIST_LCN.dalcn.WRITE_DATE}}
                                </td>
                            </tr>

                        </table>
                        <br />

                        <h2 style="font-size:24px;">
                            <strong>๑. ข้อมูลผู้ขอรับใบอนุญาต</strong>
                        </h2>
                        <table style="width:90%;margin-left:5%">
                            <tr>
                                <td style="font-size:20px;" width="40%">
                                    ข้าพเจ้า (ชื่อบุคคล/นิติบุคคล)
                                </td>
                                <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;" colspan="6">
                                    <label>{{LIST_LCN.thanm}}</label>
                                </td>
                            </tr>
                            <tr>
                                <td style="font-size:20px;">
                                    เลขประจำตัวประชาชน
                                </td>

                                <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;" colspan="6">
                                    <label>{{LIST_LCN.CITIZEN_AUTHORIZE}}</label>
                                </td>
                            </tr>
                            <tr>
                                <td style="font-size:20px;">
                                    หรือบัตรประจำตัวอื่นที่ทางราชการออกให้ คือ
                                </td>
                                <td style="font-size:20px;width:20%;border-bottom:dotted;border-bottom-width:thin;"></td>
                                <td style="font-size:20px;width:5%">
                                    เลขที่
                                </td>
                                <td style="font-size:20px ;width:15%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"></td>
                                <td style="font-size:20px;">
                                    (กรณีไม่ใช่ผู้มีสัญชาติไทย)
                                </td>
                            </tr>
                            <tr>
                                <td style="font-size:20px;">
                                    หรือทะเบียนนิติบุคคล/บัตรประจำตัวผู้เสียภาษี เลขที่
                                </td>
                                <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;" colspan="6">
                                    <label>{{LIST_LCN.IDENTIFY}}</label>
                                </td>
                            </tr>
                            <tr>
                                <td style="font-size:20px;">
                                    เลขรหัสประจำบ้าน
                                </td>
                                <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;" colspan="6">
                                    <label>{{LIST_LCN.HOUSENO}}</label>
                                </td>
                            </tr>
                            <tr>
                                <td style="font-size:20px;">
                                    อยู่เลขที่
                                </td>
                                <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;" colspan="6">
                                    <label>{{LIST_LCN.fulladdr3}}</label>
                                </td>
                            </tr>
                            <tr>
                                <td style="font-size:20px;">
                                    โทรศัพท์/มือถือ
                                </td>
                                <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;" colspan="6">
                                    <label>{{LIST_LCN.tel}}</label>
                                </td>
                            </tr>
                            <tr>
                                <td style="font-size:20px;">
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
                                <td style="font-size:20px;" width="40%">
                                    ข้าพเจ้า
                                </td>
                                <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;" colspan="6">
                                    <label>{{LIST_LCN.BSN_THAIFULLNAME}}</label>
                                </td>
                            </tr>
                            <tr>
                                <td style="font-size:20px;">
                                    เลขประจำตัวประชาชน
                                </td>
                                <td style="text-align:left;width:30%;">
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
                                </td>
                            </tr>
                            <tr>
                                <td style="font-size:20px;">
                                    หรือบัตรประจำตัวอื่นที่ทางราชการออกให้ คือ
                                </td>
                                <td style="font-size:20px;width:20%;border-bottom:dotted;border-bottom-width:thin;">
                                    <label>{{LIST_LCN.BSN_THAIFULLNAME}}</label>
                                </td>
                                <td style="font-size:20px;width:5%">
                                    เลขที่
                                </td>
                                <td style="font-size:20px ;width:15%;text-align:center;border-bottom:dotted;border-bottom-width:thin;">
                                    <label>{{LIST_LCN.BSN_THAIFULLNAME}}</label>
                                </td>
                                <td style="font-size:20px;">
                                    (กรณีไม่ใช่ผู้มีสัญชาติไทย)
                                </td>
                            </tr>
                            <tr>
                                <td style="font-size:20px;">
                                    หรือทะเบียนนิติบุคคล/บัตรประจำตัวผู้เสียภาษี เลขที่
                                </td>
                                <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;" colspan="6">
                                    <label>{{LIST_LCN.BSN_IDENTIFY}}</label>
                                </td>
                            </tr>
                            <tr>
                                <td style="font-size:20px;">
                                    เลขรหัสประจำบ้าน
                                </td>
                                <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;" colspan="6">
                                    <label>{{LIST_LCN.BSN_HOUSENO}}</label>
                                </td>
                            </tr>
                            <tr>
                                <td style="font-size:20px;">
                                    อยู่เลขที่
                                </td>
                                <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;" colspan="6">
                                    <label>{{LIST_LCN.BSN_FULL_ADDR}}</label>
                                </td>
                            </tr>
                            <tr>
                                <td style="font-size:20px;">
                                    โทรศัพท์/มือถือ
                                </td>
                                <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;" colspan="6">
                                    <label>{{LIST_LCN.BSN_TELEPHONE}}</label>
                                </td>
                            </tr>
                            <tr>
                                <td style="font-size:20px;">
                                    E-mail
                                </td>
                                <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;" colspan="6">
                                    <label>{{LIST_LCN.dalcn.Email}}</label>
                                </td>
                            </tr>
                            <tr>
                                <td style="font-size:20px;" colspan="2">
                                    โดยได้รับอนุญาตนำสั่งยาแผนปัจจุบันเข้ามาในราชอาณาจักร เลขที่
                                </td>
                                <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;" colspan="2">
                                    <label>{{LIST_HEAD_LCN.HEAD_LCNNO_NCT}}</label>
                                </td>
                                <td style="font-size:20px;">
                                    ตามกฎหมายว่าด้วยยา
                                </td>
                            </tr>
                        </table>

                        <table style="width:90%;font-size:20px;">
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
                                        <input type="text" ng-model="LIST_LCN.dalcn.syslctaddr_thasoi" id="chbl_typeee" ng-value="1">
                                    </form>
                                </td>
                            </tr>
                        </table>
                        <br />

                        <table style="width:100%;font-size:20px;">
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
                                    <label>{{LIST_LCN.thanameplace}}</label>
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
                        <table style="font-size:20px;width:100%">
                            <tr>
                                <td style="width:20%">
                                    โดยมีเภสัชกรชั้น
                                </td>
                                <td style="width:10%;border-bottom:dotted;border-bottom-width:thin;">
                                    @*<input class="form-control inline" ng-model="LIST_PHR_ADD.PHR_LEVEL" style="font-family:'Taviraj';font-size:20px;" type="text" />*@
                                    {{LIST_PHR_ADD.PHR_LEVEL}}
                                </td>
                                <td style="text-align:center">
                                    ชื่อ
                                </td>
                                <td style="width:10%;border-bottom:dotted;border-bottom-width:thin;">
                                    @*<select class="form-control selectpicker" data-live-search="true" title="-- Please select --" ng-model="LIST_PHR_ADD.PHR_PREFIX_ID">
                                        @*<option value="0">--กรุณาเลือก--</option>*@
                                    @*<option ng-repeat="x in PREFIX" value="{{x.prefixcd}}">{{x.thanm}}</option>
                                        </select>*@
                                    {{LIST_PHR_ADD.PHR_PREFIX_ID}}
                                </td>
                                <td>
                                    @*<input class="form-control inline" ng-model="LIST_PHR_ADD.PHR_NAME" style="font-family:'Taviraj';font-size:20px;" type="text" />*@
                                    {{LIST_PHR_ADD.PHR_NAME}}
                                </td>
                            </tr>
                            <tr>
                                <td style="width:20%">
                                    เลขบัตรประจำตัวประชาชน
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;" colspan="4">
                                    @*<input class="form-control inline" ng-model="LIST_PHR_ADD.PHR_CTZNO" style="font-family:'Taviraj';font-size:20px;" type="text" />*@
                                    {{LIST_PHR_ADD.PHR_CTZNO}}
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    ใบอนุญาตประกอบวิชาชีพ
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;" colspan="4"></td>
                            </tr>
                            <tr>
                                <td>
                                    เภสัชกรรมเลขที่
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;">
                                    @*<input class="form-control inline" ng-model="LIST_PHR_ADD.PHR_TEXT_NUM" style="font-family:'Taviraj';font-size:20px;" type="text" />*@
                                    {{LIST_PHR_ADD.PHR_TEXT_NUM}}
                                </td>
                            </tr>
                        </table>
                        <br />
                        @*<input type="button" style="font-size:20px;width:100px" value="เพิ่ม" ng-click="BTN_ADD_PHR(LIST_PHR_ADD)" />*@
                        <div class="row">
                            <div class="col-sm-12">
                                <div class="card" style=" border-top: 10px solid #F9D027;">
                                    <table width="100%" style="font-family:'Taviraj'">
                                        <thead>
                                            <tr>
                                                <td>เภสัชกรชั้น</td>
                                                <td>ชื่อ-นามสกุล</td>
                                                <td>เลขบัตรประจำตัวประชาชน</td>
                                                <td>ใบอนุญาตประกอบวิชาชีพเภสัชกรรมเลขที่</td>

                                            </tr>
                                        </thead>
                                        <tbody>
                                            <tr ng-repeat="data in DATA_PHR_SHOW">
                                                <td>{{data.PHR_LEVEL}}</td>
                                                <td>{{data.PHR_NAME}}</td>
                                                <td>{{data.PHR_CTZNO}}</td>
                                                <td>{{data.PHR_TEXT_NUM}}</td>
                                            </tr>
                                        </tbody>
                                    </table>
                                </div>
                            </div>
                        </div>


                        <br />
                        <div style="margin-left:5%;font-size:20px;">เป็นผู้ควบคุมตามมาตรา ๕๓ แห่งพระราชบัญญัติวัตถุที่ออกฤทธิ์ต่อจิตและประสาท พ.ศ. ๒๕๕๙</div>
                        <br />
                        <h2>๔. ข้อมูลสถานที่เก็บ (กรณีเป็นสถานที่คนละแห่งกับสถานที่ตาม ๓)</h2>
                        <table style="width:50%">
                            <tr>
                                <td>
                                    ณ สถานที่ชื่อ
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;">

                                    @*<select class="form-control selectpicker" data-live-search="true" title="-- Please select --" ng-model="LIST_LCN.LOCATION_SELECT" ng-change="getdetails(LIST_LCN.LOCATION_SELECT)">
                                        @*<option value="">--กรุณาเลือก--</option>*@
                                    @*<option ng-repeat="x in REF_LOCATION_KEEP" value="{{x.IDA}}">{{x.thanameplace}}</option>
                                        </select>*@
                                    {{LIST_LCN.LOCATION_SELECT}}
                                </td>
                            </tr>
                            <tr>
                                <td style="width:15%">
                                    เลขรหัสประจำบ้าน
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;">
                                    <label>{{LIST_LABEL.HOUSENO}}</label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    อยู่เลขที่
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;">
                                    <label>{{LIST_LABEL.fulladdr}}</label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    โทรศัพท์
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;">
                                    <label>{{LIST_LABEL.tel}}</label>
                                </td>
                            </tr>
                            <tr style="font-size: 20px;">
                                <td>
                                    โทรศัพท์มือถือ
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;">
                                    <label>{{LIST_LABEL.Mobile}}</label>
                                </td>
                            </tr>
                        </table>


                        <br />
                        @*<input type="button" style="font-size:20px;width:100px" value="เพิ่ม" ng-click="BTN_ADD_KEEP(LIST_LABEL,LIST_LCN.LOCATION_SELECT)" />*@
                        <div class="col-sm-12">
                            <div class="card" style=" border-top: 10px solid #F9D027;">
                                <table width="100%" style="font-family:'Taviraj'">
                                    <thead>
                                        <tr>
                                            <td>ชื่อสถานที่เก็บ</td>
                                            <td>อยู่เลขที่</td>
                                        </tr>
                                    </thead>
                                    <tbody>
                                        <tr ng-repeat="data in DATA_KEEP_SHOW">
                                            <td>{{datas.thanameplace}}</td>
                                            <td>{{datas.fulladdr}}</td>
                                        </tr>
                                    </tbody>
                                </table>
                            </div>
                        </div>

                        <table style="width:100%;font-size:20px;">
                            <tr>
                                <td style="width:50%">
                                    โดยได้รับอนุญาตนำสั่งยาแผนปัจจุบันเข้ามาในราชอาณาจักร เลขที่
                                </td>
                                <td style="width:30%;border-bottom:dotted;border-bottom-width:thin;">
                                    <label>{{LIST_HEAD_LCN.HEAD_LCNNO_NCT}}</label>
                                </td>
                                <td>
                                    ตามกฎหมายว่าด้วยยา
                                </td>
                            </tr>
                        </table>
                        <br />

                        <div style="margin-left:5%;font-size:20px;">เป็นผู้ควบคุมตามมาตรา ๕๓ แห่งพระราชบัญญัติวัตถุที่ออกฤทธิ์ต่อจิตและประสาท พ.ศ. ๒๕๕๙</div>
                        <br />

                        <div style="font-size:20px;"><strong>๕. พร้อมกับคำขอนี้ข้าพเจ้าได้แนบเอกสารหรือหลักฐานต่างๆ มาด้วย คือ</strong></div>
                        <div style="margin-left:5%;font-size:20px;"><strong>๕.๑ กรณีขอรับใบอนุญาต (กรณีรายใหม่)</strong></div>
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
                        <div style="margin-left:5%;font-size:20px;"><strong>๕.๒ กรณีขอต่ออายุใบอนุญาต</strong></div>
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
                        <div style="margin-left:5%;font-size:20px;"><strong>๕.๓ กรณีขอรับใบแทนใบอนุญาต</strong></div>
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
                        <br />

                        <div style="margin-left:5%;font-size:20px;"> หมายเหตุ : (๑) ให้ขีดเลือกข้อความในช่อง ☐/〇 ให้ตรงตามที่ประสงค์จะดำเนินการ</div>
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

                <div ng-show="LIST_LCN.PROCESS == '132'">
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
                                    <input type="radio" name="gender" ng-model="LIST_LCN.PROCESS" value="131" id="rdl_CHK_SELL_TYPE" disabled="disabled" /> <strong>วัตถุออกฤทธิ์ในประเภท ๓</strong>
                                </td>
                                <td>
                                    <input type="radio" name="gender" ng-model="LIST_LCN.PROCESS" value="132" id="rdl_CHK_SELL_TYPE" disabled="disabled" /> <strong>วัตถุออกฤทธิ์ในประเภท ๔</strong>
                                </td>
                            </tr>
                            <tr>
                                <td style="font-size:16px" colspan="3">
                                    <strong>(คำขอ ๑ ฉบับ ให้ยื่นขอได้เพียงหนึ่งประเภทเท่านั้น)</strong>
                                </td>
                            </tr>
                        </table>

                        <table style="width:100%; font-size:20px;">
                            <tr>
                                <td style="width:20%">
                                    <input type="checkbox" name="gender" disabled="disabled" ng-checked="true" /> <strong>ขอรับใบอนุญาต</strong>
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
                                    <input type="checkbox" name="gender" disabled="disabled" /> <strong>ขอรับใบแทนใบอนุญาต</strong>
                                </td>
                                <td>
                                    เนื่องจากใบอนุญาต
                                </td>
                                <td>
                                    <input class="checkbox" type="checkbox" disabled="disabled" /> <strong>สูญหาย</strong>
                                </td>
                                <td>
                                    <input class="checkbox" type="checkbox" disabled="disabled" /> <strong>ถูกทำลายหรือลบเลือนในสาระสำคัญ</strong>
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

                                    {{LIST_LCN.dalcn.WRITE_AT}}
                                </td>
                            </tr>
                            <tr>
                                <td style="text-align:right;width:100px">
                                    วันที่
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;">

                                    {{LIST_LCN.dalcn.WRITE_DATE}}
                                </td>
                            </tr>

                        </table>
                        <br />

                        <h2 style="font-size:24px;">
                            <strong>๑. ข้อมูลผู้ขอรับใบอนุญาต</strong>
                        </h2>
                        <table style="width:90%;margin-left:5%">
                            <tr>
                                <td style="font-size:20px;" width="40%">
                                    ข้าพเจ้า (ชื่อบุคคล/นิติบุคคล)
                                </td>
                                <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;" colspan="6">
                                    <label>{{LIST_LCN.thanm}}</label>
                                </td>
                            </tr>
                            <tr>
                                <td style="font-size:20px;">
                                    เลขประจำตัวประชาชน
                                </td>

                                <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;" colspan="6">
                                    <label>{{LIST_LCN.CITIZEN_AUTHORIZE}}</label>
                                </td>
                            </tr>
                            <tr>
                                <td style="font-size:20px;">
                                    หรือบัตรประจำตัวอื่นที่ทางราชการออกให้ คือ
                                </td>
                                <td style="font-size:20px;width:20%;border-bottom:dotted;border-bottom-width:thin;"></td>
                                <td style="font-size:20px;width:5%">
                                    เลขที่
                                </td>
                                <td style="font-size:20px ;width:15%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"></td>
                                <td style="font-size:20px;">
                                    (กรณีไม่ใช่ผู้มีสัญชาติไทย)
                                </td>
                            </tr>
                            <tr>
                                <td style="font-size:20px;">
                                    หรือทะเบียนนิติบุคคล/บัตรประจำตัวผู้เสียภาษี เลขที่
                                </td>
                                <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;" colspan="6">
                                    <label>{{LIST_LCN.IDENTIFY}}</label>
                                </td>
                            </tr>
                            <tr>
                                <td style="font-size:20px;">
                                    เลขรหัสประจำบ้าน
                                </td>
                                <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;" colspan="6">
                                    <label>{{LIST_LCN.HOUSENO}}</label>
                                </td>
                            </tr>
                            <tr>
                                <td style="font-size:20px;">
                                    อยู่เลขที่
                                </td>
                                <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;" colspan="6">
                                    <label>{{LIST_LCN.fulladdr3}}</label>
                                </td>
                            </tr>
                            <tr>
                                <td style="font-size:20px;">
                                    โทรศัพท์/มือถือ
                                </td>
                                <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;" colspan="6">
                                    <label>{{LIST_LCN.tel}}</label>
                                </td>
                            </tr>
                            <tr>
                                <td style="font-size:20px;">
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
                                <td style="font-size:20px;" width="40%">
                                    ข้าพเจ้า
                                </td>
                                <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;" colspan="6">
                                    <label>{{LIST_LCN.BSN_THAIFULLNAME}}</label>
                                </td>
                            </tr>
                            <tr>
                                <td style="font-size:20px;">
                                    เลขประจำตัวประชาชน
                                </td>
                                <td style="text-align:left;width:30%;">
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
                                </td>
                            </tr>
                            <tr>
                                <td style="font-size:20px;">
                                    หรือบัตรประจำตัวอื่นที่ทางราชการออกให้ คือ
                                </td>
                                <td style="font-size:20px;width:20%;border-bottom:dotted;border-bottom-width:thin;">
                                    <label>{{LIST_LCN.BSN_THAIFULLNAME}}</label>
                                </td>
                                <td style="font-size:20px;width:5%">
                                    เลขที่
                                </td>
                                <td style="font-size:20px ;width:15%;text-align:center;border-bottom:dotted;border-bottom-width:thin;">
                                    <label>{{LIST_LCN.BSN_THAIFULLNAME}}</label>
                                </td>
                                <td style="font-size:20px;">
                                    (กรณีไม่ใช่ผู้มีสัญชาติไทย)
                                </td>
                            </tr>
                            <tr>
                                <td style="font-size:20px;">
                                    หรือทะเบียนนิติบุคคล/บัตรประจำตัวผู้เสียภาษี เลขที่
                                </td>
                                <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;" colspan="6">
                                    <label>{{LIST_LCN.BSN_IDENTIFY}}</label>
                                </td>
                            </tr>
                            <tr>
                                <td style="font-size:20px;">
                                    เลขรหัสประจำบ้าน
                                </td>
                                <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;" colspan="6">
                                    <label>{{LIST_LCN.BSN_HOUSENO}}</label>
                                </td>
                            </tr>
                            <tr>
                                <td style="font-size:20px;">
                                    อยู่เลขที่
                                </td>
                                <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;" colspan="6">
                                    <label>{{LIST_LCN.BSN_FULL_ADDR}}</label>
                                </td>
                            </tr>
                            <tr>
                                <td style="font-size:20px;">
                                    โทรศัพท์/มือถือ
                                </td>
                                <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;" colspan="6">
                                    <label>{{LIST_LCN.BSN_TELEPHONE}}</label>
                                </td>
                            </tr>
                            <tr>
                                <td style="font-size:20px;">
                                    E-mail
                                </td>
                                <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;" colspan="6">
                                    <label>{{LIST_LCN.dalcn.Email}}</label>
                                </td>
                            </tr>
                            <tr>
                                <td style="font-size:20px;" colspan="2">
                                    โดยได้รับอนุญาตนำสั่งยาแผนปัจจุบันเข้ามาในราชอาณาจักร เลขที่
                                </td>
                                <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;" colspan="2">
                                    <label>{{LIST_HEAD_LCN.HEAD_LCNNO_NCT}}</label>
                                </td>
                                <td style="font-size:20px;">
                                    ตามกฎหมายว่าด้วยยา
                                </td>
                            </tr>
                        </table>

                        <table style="width:90%;font-size:20px;">
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
                                        <input type="text" ng-model="LIST_LCN.dalcn.syslctaddr_thasoi" id="chbl_typeee" ng-value="1">
                                    </form>
                                </td>
                            </tr>
                        </table>
                        <br />

                        <table style="width:100%;font-size:20px;">
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
                                    <label>{{LIST_LCN.thanameplace}}</label>
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
                        <table style="font-size:20px;width:100%">
                            <tr>
                                <td style="width:20%">
                                    โดยมีเภสัชกรชั้น
                                </td>
                                <td style="width:10%;border-bottom:dotted;border-bottom-width:thin;">
                                    @*<input class="form-control inline" ng-model="LIST_PHR_ADD.PHR_LEVEL" style="font-family:'Taviraj';font-size:20px;" type="text" />*@
                                    {{LIST_PHR_ADD.PHR_LEVEL}}
                                </td>
                                <td style="text-align:center">
                                    ชื่อ
                                </td>
                                <td style="width:10%;border-bottom:dotted;border-bottom-width:thin;">
                                    @*<select class="form-control selectpicker" data-live-search="true" title="-- Please select --" ng-model="LIST_PHR_ADD.PHR_PREFIX_ID">
                                        @*<option value="0">--กรุณาเลือก--</option>*@
                                    @*<option ng-repeat="x in PREFIX" value="{{x.prefixcd}}">{{x.thanm}}</option>
                                        </select>*@
                                    {{LIST_PHR_ADD.PHR_PREFIX_ID}}
                                </td>
                                <td>
                                    @*<input class="form-control inline" ng-model="LIST_PHR_ADD.PHR_NAME" style="font-family:'Taviraj';font-size:20px;" type="text" />*@
                                    {{LIST_PHR_ADD.PHR_NAME}}
                                </td>
                            </tr>
                            <tr>
                                <td style="width:20%">
                                    เลขบัตรประจำตัวประชาชน
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;" colspan="4">
                                    @*<input class="form-control inline" ng-model="LIST_PHR_ADD.PHR_CTZNO" style="font-family:'Taviraj';font-size:20px;" type="text" />*@
                                    {{LIST_PHR_ADD.PHR_CTZNO}}
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    ใบอนุญาตประกอบวิชาชีพ
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;" colspan="4"></td>
                            </tr>
                            <tr>
                                <td>
                                    เภสัชกรรมเลขที่
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;">
                                    @*<input class="form-control inline" ng-model="LIST_PHR_ADD.PHR_TEXT_NUM" style="font-family:'Taviraj';font-size:20px;" type="text" />*@
                                    {{LIST_PHR_ADD.PHR_TEXT_NUM}}
                                </td>
                            </tr>
                        </table>
                        <br />
                        @*<input type="button" style="font-size:20px;width:100px" value="เพิ่ม" ng-click="BTN_ADD_PHR(LIST_PHR_ADD)" />*@
                        <div class="row">
                            <div class="col-sm-12">
                                <div class="card" style=" border-top: 10px solid #F9D027;">
                                    <table width="100%" style="font-family:'Taviraj'">
                                        <thead>
                                            <tr>
                                                <td>เภสัชกรชั้น</td>
                                                <td>ชื่อ-นามสกุล</td>
                                                <td>เลขบัตรประจำตัวประชาชน</td>
                                                <td>ใบอนุญาตประกอบวิชาชีพเภสัชกรรมเลขที่</td>

                                            </tr>
                                        </thead>
                                        <tbody>
                                            <tr ng-repeat="data in DATA_PHR_SHOW">
                                                <td>{{data.PHR_LEVEL}}</td>
                                                <td>{{data.PHR_NAME}}</td>
                                                <td>{{data.PHR_CTZNO}}</td>
                                                <td>{{data.PHR_TEXT_NUM}}</td>
                                            </tr>
                                        </tbody>
                                    </table>
                                </div>
                            </div>
                        </div>


                        <br />
                        <div style="margin-left:5%;font-size:20px;">เป็นผู้ควบคุมตามมาตรา ๕๓ แห่งพระราชบัญญัติวัตถุที่ออกฤทธิ์ต่อจิตและประสาท พ.ศ. ๒๕๕๙</div>
                        <br />
                        <h2>๔. ข้อมูลสถานที่เก็บ (กรณีเป็นสถานที่คนละแห่งกับสถานที่ตาม ๓)</h2>
                        <table style="width:50%">
                            <tr>
                                <td>
                                    ณ สถานที่ชื่อ
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;">

                                    @*<select class="form-control selectpicker" data-live-search="true" title="-- Please select --" ng-model="LIST_LCN.LOCATION_SELECT" ng-change="getdetails(LIST_LCN.LOCATION_SELECT)">
                                        @*<option value="">--กรุณาเลือก--</option>*@
                                    @*<option ng-repeat="x in REF_LOCATION_KEEP" value="{{x.IDA}}">{{x.thanameplace}}</option>
                                        </select>*@
                                    {{LIST_LCN.LOCATION_SELECT}}
                                </td>
                            </tr>
                            <tr>
                                <td style="width:15%">
                                    เลขรหัสประจำบ้าน
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;">
                                    <label>{{LIST_LABEL.HOUSENO}}</label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    อยู่เลขที่
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;">
                                    <label>{{LIST_LABEL.fulladdr}}</label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    โทรศัพท์
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;">
                                    <label>{{LIST_LABEL.tel}}</label>
                                </td>
                            </tr>
                            <tr style="font-size: 20px;">
                                <td>
                                    โทรศัพท์มือถือ
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;">
                                    <label>{{LIST_LABEL.Mobile}}</label>
                                </td>
                            </tr>
                        </table>


                        <br />
                        @*<input type="button" style="font-size:20px;width:100px" value="เพิ่ม" ng-click="BTN_ADD_KEEP(LIST_LABEL,LIST_LCN.LOCATION_SELECT)" />*@
                        <div class="col-sm-12">
                            <div class="card" style=" border-top: 10px solid #F9D027;">
                                <table width="100%" style="font-family:'Taviraj'">
                                    <thead>
                                        <tr>
                                            <td>ชื่อสถานที่เก็บ</td>
                                            <td>อยู่เลขที่</td>
                                        </tr>
                                    </thead>
                                    <tbody>
                                        <tr ng-repeat="data in DATA_KEEP_SHOW">
                                            <td>{{datas.thanameplace}}</td>
                                            <td>{{datas.fulladdr}}</td>
                                        </tr>
                                    </tbody>
                                </table>
                            </div>
                        </div>

                        <table style="width:100%;font-size:20px;">
                            <tr>
                                <td style="width:50%">
                                    โดยได้รับอนุญาตนำสั่งยาแผนปัจจุบันเข้ามาในราชอาณาจักร เลขที่
                                </td>
                                <td style="width:30%;border-bottom:dotted;border-bottom-width:thin;">
                                    <label>{{LIST_HEAD_LCN.HEAD_LCNNO_NCT}}</label>
                                </td>
                                <td>
                                    ตามกฎหมายว่าด้วยยา
                                </td>
                            </tr>
                        </table>
                        <br />

                        <div style="margin-left:5%;font-size:20px;">เป็นผู้ควบคุมตามมาตรา ๕๓ แห่งพระราชบัญญัติวัตถุที่ออกฤทธิ์ต่อจิตและประสาท พ.ศ. ๒๕๕๙</div>
                        <br />

                        <div style="font-size:20px;"><strong>๕. พร้อมกับคำขอนี้ข้าพเจ้าได้แนบเอกสารหรือหลักฐานต่างๆ มาด้วย คือ</strong></div>
                        <div style="margin-left:5%;font-size:20px;"><strong>๕.๑ กรณีขอรับใบอนุญาต (กรณีรายใหม่)</strong></div>
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
                        <div style="margin-left:5%;font-size:20px;"><strong>๕.๒ กรณีขอต่ออายุใบอนุญาต</strong></div>
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
                        <div style="margin-left:5%;font-size:20px;"><strong>๕.๓ กรณีขอรับใบแทนใบอนุญาต</strong></div>
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
                        <br />

                        <div style="margin-left:5%;font-size:20px;"> หมายเหตุ : (๑) ให้ขีดเลือกข้อความในช่อง ☐/〇 ให้ตรงตามที่ประสงค์จะดำเนินการ</div>
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

                <div ng-show="LIST_LCN.PROCESS == '123'">
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
                                    <input type="radio" name="gender" ng-model="LIST_LCN.PROCESS" value="123" id="rdl_CHK_SELL_TYPE" disabled="disabled" /> <strong>วัตถุออกฤทธิ์ในประเภท ๓</strong>
                                </td>
                                <td>
                                    <input type="radio" name="gender" ng-model="LIST_LCN.PROCESS" value="124" id="rdl_CHK_SELL_TYPE" disabled="disabled" /> <strong>วัตถุออกฤทธิ์ในประเภท ๔</strong>
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
                                    <input type="checkbox" name="gender" disabled="disabled" ng-checked="true" /> <strong>ขอรับใบอนุญาต</strong>
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
                                    <input type="checkbox" name="gender" disabled="disabled" /> <strong>ขอรับใบแทนใบอนุญาต</strong>
                                </td>
                                <td>
                                    เนื่องจากใบอนุญาต
                                </td>
                                <td>
                                    <input class="checkbox" type="checkbox" disabled="disabled" /> <strong>สูญหาย</strong>
                                </td>
                                <td>
                                    <input class="checkbox" type="checkbox" disabled="disabled" /> <strong>ถูกทำลายหรือลบเลือนในสาระสำคัญ</strong>
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

                                    {{LIST_LCN.dalcn.WRITE_AT}}
                                </td>
                            </tr>
                            <tr>
                                <td style="text-align:right;width:100px">
                                    วันที่
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;">

                                    {{LIST_LCN.dalcn.WRITE_DATE}}
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
                                <td style="text-align:left;width:30%;">
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
                                </td>
                            </tr>
                            <tr>
                                <td style="font-size:20px">
                                    หรือบัตรประจำตัวอื่นที่ทางราชการออกให้ คือ
                                </td>
                                <td style="font-size:20px;width:20%;border-bottom:dotted;border-bottom-width:thin;">
                                    <label>{{LIST_LCN.BSN_THAIFULLNAME}}</label>
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
                                    <label>{{LIST_LCN.thanameplace}}</label>
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
                        <br />
                        <table style="font-size:20px;width:100%">
                            <tr>
                                <td style="width:20%">
                                    โดยมีเภสัชกรชั้น
                                </td>
                                <td style="width:10%;border-bottom:dotted;border-bottom-width:thin;">
                                    @*<input class="form-control inline" ng-model="LIST_PHR_ADD.PHR_LEVEL" style="font-family:'Taviraj';font-size:20px;" type="text" />*@
                                    {{LIST_PHR_ADD.PHR_LEVEL}}
                                </td>
                                <td style="text-align:center">
                                    ชื่อ
                                </td>
                                <td style="width:10%;border-bottom:dotted;border-bottom-width:thin;">
                                    @*<select class="form-control selectpicker" data-live-search="true" title="-- Please select --" ng-model="LIST_PHR_ADD.PHR_PREFIX_ID">
                                        @*<option value="0">--กรุณาเลือก--</option>*@
                                    @*<option ng-repeat="x in PREFIX" value="{{x.prefixcd}}">{{x.thanm}}</option>
                                        </select>*@
                                    {{LIST_PHR_ADD.PHR_PREFIX_ID}}
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;">
                                    @*<input class="form-control inline" ng-model="LIST_PHR_ADD.PHR_NAME" style="font-family:'Taviraj';font-size:20px;" type="text" />*@
                                    {{LIST_PHR_ADD.PHR_NAME}}
                                </td>
                            </tr>
                            <tr>
                                <td style="width:20%">
                                    เลขบัตรประจำตัวประชาชน
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;" colspan="4">
                                    @*<input class="form-control inline" ng-model="LIST_PHR_ADD.PHR_CTZNO" style="font-family:'Taviraj';font-size:20px;" type="text" />*@
                                    {{LIST_PHR_ADD.PHR_CTZNO}}
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    ใบอนุญาตประกอบวิชาชีพ
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;" colspan="4"></td>
                            </tr>
                            <tr>
                                <td>
                                    เภสัชกรรมเลขที่
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;">
                                    @*<input class="form-control inline" ng-model="LIST_PHR_ADD.PHR_TEXT_NUM" style="font-family:'Taviraj';font-size:20px;" type="text" />*@
                                    {{LIST_PHR_ADD.PHR_TEXT_NUM}}
                                </td>
                            </tr>
                        </table>
                        <br />
                        @*<input type="button" style="font-size:20px;width:100px" value="เพิ่ม" ng-click="BTN_ADD_PHR(LIST_PHR_ADD)" />*@
                        <div class="row">
                            <div class="col-sm-12">
                                <div class="card" style=" border-top: 10px solid #F9D027;">
                                    <table width="100%" style="font-family:'Taviraj'">
                                        <thead>
                                            <tr>
                                                <td>เภสัชกรชั้น</td>
                                                <td>ชื่อ-นามสกุล</td>
                                                <td>เลขบัตรประจำตัวประชาชน</td>
                                                <td>ใบอนุญาตประกอบวิชาชีพเภสัชกรรมเลขที่</td>

                                            </tr>
                                        </thead>
                                        <tbody>
                                            <tr ng-repeat="data in DATA_PHR_SHOW">
                                                <td>{{data.PHR_LEVEL}}</td>
                                                <td>{{data.PHR_NAME}}</td>
                                                <td>{{data.PHR_CTZNO}}</td>
                                                <td>{{data.PHR_TEXT_NUM}}</td>
                                            </tr>
                                        </tbody>
                                    </table>
                                </div>
                            </div>
                        </div>
                        <br />
                        <table style="width:100%;font-size:20px">
                            <tr>
                                <td>
                                    เป็นผู้รับอนุญาตขายยาแผนใบอนุญาตเลขที่
                                </td>
                                <td style="width:50%;border-bottom:dotted;border-bottom-width:thin;">
                                    <label>{{LIST_HEAD_LCN.HEAD_LCNNO_NCT}}</label>
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
                                    <label>{{LIST_HEAD_LCN.HEAD_LCNNO_NCT}}</label>
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
                                    <label>{{LIST_HEAD_LCN.HEAD_LCNNO_NCT}}</label>
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

                        <h2>๔. ข้อมูลสถานที่เก็บ (กรณีเป็นสถานที่คนละแห่งกับสถานที่ตาม ๓)</h2>
                        <table style="width:50%">
                            <tr>
                                <td>
                                    ณ สถานที่ชื่อ
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;">

                                    @*<select class="form-control selectpicker" data-live-search="true" title="-- Please select --" ng-model="LIST_LCN.LOCATION_SELECT" ng-change="getdetails(LIST_LCN.LOCATION_SELECT)">
                                        @*<option value="">--กรุณาเลือก--</option>*@
                                    @*<option ng-repeat="x in REF_LOCATION_KEEP" value="{{x.IDA}}">{{x.thanameplace}}</option>
                                        </select>*@
                                    {{LIST_LCN.LOCATION_SELECT}}
                                </td>
                            </tr>
                            <tr>
                                <td style="width:15%">
                                    เลขรหัสประจำบ้าน
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;">
                                    <label>{{LIST_LABEL.HOUSENO}}</label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    อยู่เลขที่
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;">
                                    <label>{{LIST_LABEL.fulladdr}}</label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    โทรศัพท์
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;">
                                    <label>{{LIST_LABEL.tel}}</label>
                                </td>
                            </tr>
                            <tr style="font-size: 20px">
                                <td>
                                    โทรศัพท์มือถือ
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;">
                                    <label>{{LIST_LABEL.Mobile}}</label>
                                </td>
                            </tr>
                        </table>


                        <br />
                        @*<input type="button" style="font-size:20px;width:100px" value="เพิ่ม" ng-click="BTN_ADD_KEEP(LIST_LABEL,LIST_LCN.LOCATION_SELECT)" />*@
                        <div class="col-sm-12">
                            <div class="card" style=" border-top: 10px solid #F9D027;">
                                <table width="100%" style="font-family:'Taviraj'">
                                    <thead>
                                        <tr>
                                            <td>ชื่อสถานที่เก็บ</td>
                                            <td>อยู่เลขที่</td>
                                        </tr>
                                    </thead>
                                    <tbody>
                                        <tr ng-repeat="data in DATA_KEEP_SHOW">
                                            <td>{{datas.thanameplace}}</td>
                                            <td>{{datas.fulladdr}}</td>
                                        </tr>
                                    </tbody>
                                </table>
                            </div>
                        </div>
                        <br />
                        <br />

                        <div style="font-size:20px"><strong>๕. พร้อมกับคำขอนี้ข้าพเจ้าได้แนบเอกสารหรือหลักฐานต่างๆ มาด้วย คือ</strong></div>
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
                        <br />

                        <table style="width:100%">
                            <tr>
                                <td style="width:25%"></td>
                                <td style="width:30%">(ลายมือชื่อ)</td>
                                <td style="width:45%">ผู้ขอรับใบอนุญาต/ผู้ได้รับมอบหมายหรือแต่งตั้งให้ดำเนินกิจการ</td>
                            </tr>
                        </table>
                        <table style="width:100%">
                            <tr>
                                <td style="width:30%"></td>
                                <td style="width:30%">({{LIST_LCN.BSN_THAIFULLNAME}})</td>
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

                <div ng-show="LIST_LCN.PROCESS == '124'">
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
                                    <input type="radio" name="gender" ng-model="LIST_LCN.PROCESS" value="123" id="rdl_CHK_SELL_TYPE" disabled="disabled" /> <strong>วัตถุออกฤทธิ์ในประเภท ๓</strong>
                                </td>
                                <td>
                                    <input type="radio" name="gender" ng-model="LIST_LCN.PROCESS" value="124" id="rdl_CHK_SELL_TYPE" disabled="disabled" /> <strong>วัตถุออกฤทธิ์ในประเภท ๔</strong>
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
                                    <input type="checkbox" name="gender" disabled="disabled" ng-checked="true" /> <strong>ขอรับใบอนุญาต</strong>
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
                                    <input type="checkbox" name="gender" disabled="disabled" /> <strong>ขอรับใบแทนใบอนุญาต</strong>
                                </td>
                                <td>
                                    เนื่องจากใบอนุญาต
                                </td>
                                <td>
                                    <input class="checkbox" type="checkbox" disabled="disabled" /> <strong>สูญหาย</strong>
                                </td>
                                <td>
                                    <input class="checkbox" type="checkbox" disabled="disabled" /> <strong>ถูกทำลายหรือลบเลือนในสาระสำคัญ</strong>
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

                                    {{LIST_LCN.dalcn.WRITE_AT}}
                                </td>
                            </tr>
                            <tr>
                                <td style="text-align:right;width:100px">
                                    วันที่
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;">

                                    {{LIST_LCN.dalcn.WRITE_DATE}}
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
                                <td style="text-align:left;width:30%;">
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
                                </td>
                            </tr>
                            <tr>
                                <td style="font-size:20px">
                                    หรือบัตรประจำตัวอื่นที่ทางราชการออกให้ คือ
                                </td>
                                <td style="font-size:20px;width:20%;border-bottom:dotted;border-bottom-width:thin;">
                                    <label>{{LIST_LCN.BSN_THAIFULLNAME}}</label>
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
                                    <label>{{LIST_LCN.thanameplace}}</label>
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
                        <br />
                        <table style="font-size:20px;width:100%">
                            <tr>
                                <td style="width:20%">
                                    โดยมีเภสัชกรชั้น
                                </td>
                                <td style="width:10%;border-bottom:dotted;border-bottom-width:thin;">
                                    @*<input class="form-control inline" ng-model="LIST_PHR_ADD.PHR_LEVEL" style="font-family:'Taviraj';font-size:20px;" type="text" />*@
                                    {{LIST_PHR_ADD.PHR_LEVEL}}
                                </td>
                                <td style="text-align:center">
                                    ชื่อ
                                </td>
                                <td style="width:10%;border-bottom:dotted;border-bottom-width:thin;">
                                    @*<select class="form-control selectpicker" data-live-search="true" title="-- Please select --" ng-model="LIST_PHR_ADD.PHR_PREFIX_ID">
                                        @*<option value="0">--กรุณาเลือก--</option>*@
                                    @*<option ng-repeat="x in PREFIX" value="{{x.prefixcd}}">{{x.thanm}}</option>
                                        </select>*@
                                    {{LIST_PHR_ADD.PHR_PREFIX_ID}}
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;">
                                    @*<input class="form-control inline" ng-model="LIST_PHR_ADD.PHR_NAME" style="font-family:'Taviraj';font-size:20px;" type="text" />*@
                                    {{LIST_PHR_ADD.PHR_NAME}}
                                </td>
                            </tr>
                            <tr>
                                <td style="width:20%">
                                    เลขบัตรประจำตัวประชาชน
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;" colspan="4">
                                    @*<input class="form-control inline" ng-model="LIST_PHR_ADD.PHR_CTZNO" style="font-family:'Taviraj';font-size:20px;" type="text" />*@
                                    {{LIST_PHR_ADD.PHR_CTZNO}}
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    ใบอนุญาตประกอบวิชาชีพ
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;" colspan="4"></td>
                            </tr>
                            <tr>
                                <td>
                                    เภสัชกรรมเลขที่
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;">
                                    @*<input class="form-control inline" ng-model="LIST_PHR_ADD.PHR_TEXT_NUM" style="font-family:'Taviraj';font-size:20px;" type="text" />*@
                                    {{LIST_PHR_ADD.PHR_TEXT_NUM}}
                                </td>
                            </tr>
                        </table>
                        <br />
                        @*<input type="button" style="font-size:20px;width:100px" value="เพิ่ม" ng-click="BTN_ADD_PHR(LIST_PHR_ADD)" />*@
                        <div class="row">
                            <div class="col-sm-12">
                                <div class="card" style=" border-top: 10px solid #F9D027;">
                                    <table width="100%" style="font-family:'Taviraj'">
                                        <thead>
                                            <tr>
                                                <td>เภสัชกรชั้น</td>
                                                <td>ชื่อ-นามสกุล</td>
                                                <td>เลขบัตรประจำตัวประชาชน</td>
                                                <td>ใบอนุญาตประกอบวิชาชีพเภสัชกรรมเลขที่</td>

                                            </tr>
                                        </thead>
                                        <tbody>
                                            <tr ng-repeat="data in DATA_PHR_SHOW">
                                                <td>{{data.PHR_LEVEL}}</td>
                                                <td>{{data.PHR_NAME}}</td>
                                                <td>{{data.PHR_CTZNO}}</td>
                                                <td>{{data.PHR_TEXT_NUM}}</td>
                                            </tr>
                                        </tbody>
                                    </table>
                                </div>
                            </div>
                        </div>
                        <br />
                        <table style="width:100%;font-size:20px">
                            <tr>
                                <td>
                                    เป็นผู้รับอนุญาตขายยาแผนใบอนุญาตเลขที่
                                </td>
                                <td style="width:50%;border-bottom:dotted;border-bottom-width:thin;">
                                    <label>{{LIST_HEAD_LCN.HEAD_LCNNO_NCT}}</label>
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
                                    <label>{{LIST_HEAD_LCN.HEAD_LCNNO_NCT}}</label>
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
                                    <label>{{LIST_HEAD_LCN.HEAD_LCNNO_NCT}}</label>
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

                        <h2>๔. ข้อมูลสถานที่เก็บ (กรณีเป็นสถานที่คนละแห่งกับสถานที่ตาม ๓)</h2>
                        <table style="width:50%">
                            <tr>
                                <td>
                                    ณ สถานที่ชื่อ
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;">

                                    @*<select class="form-control selectpicker" data-live-search="true" title="-- Please select --" ng-model="LIST_LCN.LOCATION_SELECT" ng-change="getdetails(LIST_LCN.LOCATION_SELECT)">
                                        @*<option value="">--กรุณาเลือก--</option>*@
                                    @*<option ng-repeat="x in REF_LOCATION_KEEP" value="{{x.IDA}}">{{x.thanameplace}}</option>
                                        </select>*@
                                    {{LIST_LCN.LOCATION_SELECT}}
                                </td>
                            </tr>
                            <tr>
                                <td style="width:15%">
                                    เลขรหัสประจำบ้าน
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;">
                                    <label>{{LIST_LABEL.HOUSENO}}</label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    อยู่เลขที่
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;">
                                    <label>{{LIST_LABEL.fulladdr}}</label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    โทรศัพท์
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;">
                                    <label>{{LIST_LABEL.tel}}</label>
                                </td>
                            </tr>
                            <tr style="font-size: 20px">
                                <td>
                                    โทรศัพท์มือถือ
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;">
                                    <label>{{LIST_LABEL.Mobile}}</label>
                                </td>
                            </tr>
                        </table>


                        <br />
                        @*<input type="button" style="font-size:20px;width:100px" value="เพิ่ม" ng-click="BTN_ADD_KEEP(LIST_LABEL,LIST_LCN.LOCATION_SELECT)" />*@
                        <div class="col-sm-12">
                            <div class="card" style=" border-top: 10px solid #F9D027;">
                                <table width="100%" style="font-family:'Taviraj'">
                                    <thead>
                                        <tr>
                                            <td>ชื่อสถานที่เก็บ</td>
                                            <td>อยู่เลขที่</td>
                                        </tr>
                                    </thead>
                                    <tbody>
                                        <tr ng-repeat="data in DATA_KEEP_SHOW">
                                            <td>{{datas.thanameplace}}</td>
                                            <td>{{datas.fulladdr}}</td>
                                        </tr>
                                    </tbody>
                                </table>
                            </div>
                        </div>
                        <br />
                        <br />

                        <div style="font-size:20px"><strong>๕. พร้อมกับคำขอนี้ข้าพเจ้าได้แนบเอกสารหรือหลักฐานต่างๆ มาด้วย คือ</strong></div>
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
                        <br />

                        <table style="width:100%">
                            <tr>
                                <td style="width:25%"></td>
                                <td style="width:30%">(ลายมือชื่อ)</td>
                                <td style="width:45%">ผู้ขอรับใบอนุญาต/ผู้ได้รับมอบหมายหรือแต่งตั้งให้ดำเนินกิจการ</td>
                            </tr>
                        </table>
                        <table style="width:100%">
                            <tr>
                                <td style="width:30%"></td>
                                <td style="width:30%">({{LIST_LCN.BSN_THAIFULLNAME}})</td>
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

                <div ng-show="LIST_LCN.PROCESS == '133'">
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
                            <strong>ใบอนุญาตส่งออกวัตถุออกฤทธิ์ในประเภท ๓ หรือประเภท ๔</strong>
                        </h2>
                        @*process =133,134 *@

                        <table style="width:70%; font-size:20px;margin:auto;text-align:center">
                            <tr>
                                <td>
                                    <strong>สำหรับส่งออก</strong>
                                </td>
                                <td>
                                    <input type="radio" name="gender" ng-model="LIST_LCN.PROCESS" value="133" id="rdl_CHK_SELL_TYPE" disabled="disabled" /> <strong>วัตถุออกฤทธิ์ในประเภท ๓</strong>
                                </td>
                                <td>
                                    <input type="radio" name="gender" ng-model="LIST_LCN.PROCESS" value="134" id="rdl_CHK_SELL_TYPE" disabled="disabled" /> <strong>วัตถุออกฤทธิ์ในประเภท ๔</strong>
                                </td>
                            </tr>
                            <tr>
                                <td style="font-size:16px" colspan="3">
                                    <strong>(คำขอ ๑ ฉบับ ให้ยื่นขอได้เพียงหนึ่งประเภทเท่านั้น)</strong>
                                </td>
                            </tr>
                        </table>

                        <table style="width:100%; font-size:20px;">
                            <tr>
                                <td style="width:20%">
                                    <input type="checkbox" name="gender" disabled="disabled" ng-checked="true" /> <strong>ขอรับใบอนุญาต</strong>
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
                                    <input type="checkbox" name="gender" disabled="disabled" /> <strong>ขอรับใบแทนใบอนุญาต</strong>
                                </td>
                                <td>
                                    เนื่องจากใบอนุญาต
                                </td>
                                <td>
                                    <input class="checkbox" type="checkbox" disabled="disabled" /> <strong>สูญหาย</strong>
                                </td>
                                <td>
                                    <input class="checkbox" type="checkbox" disabled="disabled" /> <strong>ถูกทำลายหรือลบเลือนในสาระสำคัญ</strong>
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

                                    {{LIST_LCN.dalcn.WRITE_AT}}
                                </td>
                            </tr>
                            <tr>
                                <td style="text-align:right;width:100px">
                                    วันที่
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;">

                                    {{LIST_LCN.dalcn.WRITE_DATE}}
                                </td>
                            </tr>

                        </table>
                        <br />

                        <h2 style="font-size:24px;">
                            <strong>๑. ข้อมูลผู้ขอรับใบอนุญาต</strong>
                        </h2>
                        <table style="width:90%;margin-left:5%">
                            <tr>
                                <td style="font-size:20px;" width="40%">
                                    ข้าพเจ้า (ชื่อบุคคล/นิติบุคคล)
                                </td>
                                <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;" colspan="6">
                                    <label>{{LIST_LCN.thanm}}</label>
                                </td>
                            </tr>
                            <tr>
                                <td style="font-size:20px;">
                                    เลขประจำตัวประชาชน
                                </td>

                                <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;" colspan="6">
                                    <label>{{LIST_LCN.CITIZEN_AUTHORIZE}}</label>
                                </td>
                            </tr>
                            <tr>
                                <td style="font-size:20px;">
                                    หรือบัตรประจำตัวอื่นที่ทางราชการออกให้ คือ
                                </td>
                                <td style="font-size:20px;width:20%;border-bottom:dotted;border-bottom-width:thin;"></td>
                                <td style="font-size:20px;width:5%">
                                    เลขที่
                                </td>
                                <td style="font-size:20px ;width:15%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"></td>
                                <td style="font-size:20px;">
                                    (กรณีไม่ใช่ผู้มีสัญชาติไทย)
                                </td>
                            </tr>
                            <tr>
                                <td style="font-size:20px;">
                                    หรือทะเบียนนิติบุคคล/บัตรประจำตัวผู้เสียภาษี เลขที่
                                </td>
                                <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;" colspan="6">
                                    <label>{{LIST_LCN.IDENTIFY}}</label>
                                </td>
                            </tr>
                            <tr>
                                <td style="font-size:20px;">
                                    เลขรหัสประจำบ้าน
                                </td>
                                <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;" colspan="6">
                                    <label>{{LIST_LCN.HOUSENO}}</label>
                                </td>
                            </tr>
                            <tr>
                                <td style="font-size:20px;">
                                    อยู่เลขที่
                                </td>
                                <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;" colspan="6">
                                    <label>{{LIST_LCN.fulladdr3}}</label>
                                </td>
                            </tr>
                            <tr>
                                <td style="font-size:20px;">
                                    โทรศัพท์/มือถือ
                                </td>
                                <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;" colspan="6">
                                    <label>{{LIST_LCN.tel}}</label>
                                </td>
                            </tr>
                            <tr>
                                <td style="font-size:20px;">
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
                                <td style="font-size:20px;" width="40%">
                                    ข้าพเจ้า
                                </td>
                                <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;" colspan="6">
                                    <label>{{LIST_LCN.BSN_THAIFULLNAME}}</label>
                                </td>
                            </tr>
                            <tr>
                                <td style="font-size:20px;">
                                    เลขประจำตัวประชาชน
                                </td>
                                <td style="text-align:left;width:30%;">
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
                                </td>
                            </tr>
                            <tr>
                                <td style="font-size:20px;">
                                    หรือบัตรประจำตัวอื่นที่ทางราชการออกให้ คือ
                                </td>
                                <td style="font-size:20px;width:20%;border-bottom:dotted;border-bottom-width:thin;">
                                    <label>{{LIST_LCN.BSN_IDENTIFY}}</label>
                                </td>
                                <td style="font-size:20px;width:5%">
                                    เลขที่
                                </td>
                                <td style="font-size:20px ;width:15%;text-align:center;border-bottom:dotted;border-bottom-width:thin;">
                                </td>
                                <td style="font-size:20px;">
                                    (กรณีไม่ใช่ผู้มีสัญชาติไทย)
                                </td>
                            </tr>
                            <tr>
                                <td style="font-size:20px;">
                                    หรือทะเบียนนิติบุคคล/บัตรประจำตัวผู้เสียภาษี เลขที่
                                </td>
                                <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;" colspan="6">
                                    <label>{{LIST_LCN.BSN_IDENTIFY}}</label>
                                </td>
                            </tr>
                            <tr>
                                <td style="font-size:20px;">
                                    เลขรหัสประจำบ้าน
                                </td>
                                <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;" colspan="6">
                                    <label>{{LIST_LCN.BSN_HOUSENO}}</label>
                                </td>
                            </tr>
                            <tr>
                                <td style="font-size:20px;">
                                    อยู่เลขที่
                                </td>
                                <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;" colspan="6">
                                    <label>{{LIST_LCN.BSN_FULL_ADDR}}</label>
                                </td>
                            </tr>
                            <tr>
                                <td style="font-size:20px;">
                                    โทรศัพท์/มือถือ
                                </td>
                                <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;" colspan="6">
                                    <label>{{LIST_LCN.BSN_TELEPHONE}}</label>
                                </td>
                            </tr>
                            <tr>
                                <td style="font-size:20px;">
                                    E-mail
                                </td>
                                <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;" colspan="6">
                                    <label>{{LIST_LCN.dalcn.Email}}</label>
                                </td>
                            </tr>
                        </table>
                        <br />

                        <table style="width:100%;font-size:20px;">
                            <tr>
                                <td colspan="4">
                                    <p><strong>๓. ข้อมูลสถานที่ส่งออก</strong></p>
                                </td>
                            </tr>
                            <tr>
                                <td style="width:15%;">
                                    ณ สถานที่ชื่อ
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;">
                                    <label>{{LIST_LCN.thanameplace}}</label>
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
                                <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;">
                                    <label>{{LIST_HEAD_LCN.HEAD_LCNNO_NCT}}</label>
                                </td>
                            </tr>
                        </table>

                        <table style="font-size:20px;width:100%">
                            <tr>
                                <td style="width:20%">
                                    โดยมีเภสัชกรชั้น
                                </td>
                                <td style="width:10%;border-bottom:dotted;border-bottom-width:thin;">
                                    @*<input class="form-control inline" ng-model="LIST_PHR_ADD.PHR_LEVEL" style="font-family:'Taviraj';font-size:20px;" type="text" />*@
                                    {{LIST_PHR_ADD.PHR_LEVEL}}
                                </td>
                                <td style="text-align:center">
                                    ชื่อ
                                </td>
                                <td style="width:10%;border-bottom:dotted;border-bottom-width:thin;">
                                    @*<select class="form-control selectpicker" data-live-search="true" title="-- Please select --" ng-model="LIST_PHR_ADD.PHR_PREFIX_ID">
                                        @*<option value="0">--กรุณาเลือก--</option>*@
                                    @*<option ng-repeat="x in PREFIX" value="{{x.prefixcd}}">{{x.thanm}}</option>
                                        </select>*@
                                    {{LIST_PHR_ADD.PHR_PREFIX_ID}}
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;">
                                    @*<input class="form-control inline" ng-model="LIST_PHR_ADD.PHR_NAME" style="font-family:'Taviraj';font-size:20px;" type="text" />*@
                                    {{LIST_PHR_ADD.PHR_NAME}}
                                </td>
                            </tr>
                            <tr>
                                <td style="width:20%">
                                    เลขบัตรประจำตัวประชาชน
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;" colspan="4">
                                    @*<input class="form-control inline" ng-model="LIST_PHR_ADD.PHR_CTZNO" style="font-family:'Taviraj';font-size:20px;" type="text" />*@
                                    {{LIST_PHR_ADD.PHR_CTZNO}}
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    ใบอนุญาตประกอบวิชาชีพ
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;" colspan="4"></td>
                            </tr>
                            <tr>
                                <td>
                                    เภสัชกรรมเลขที่
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;">
                                    @*<input class="form-control inline" ng-model="LIST_PHR_ADD.PHR_TEXT_NUM" style="font-family:'Taviraj';font-size:20px;" type="text" />*@
                                    {{LIST_PHR_ADD.PHR_TEXT_NUM}}
                                </td>
                            </tr>
                        </table>
                        <br />
                        @*<input type="button" style="font-size:20px;width:100px" value="เพิ่ม" ng-click="BTN_ADD_PHR(LIST_PHR_ADD)" />*@
                        <div class="row">
                            <div class="col-sm-12">
                                <div class="card" style=" border-top: 10px solid #F9D027;">
                                    <table width="100%" style="font-family:'Taviraj'">
                                        <thead>
                                            <tr>
                                                <td>เภสัชกรชั้น</td>
                                                <td>ชื่อ-นามสกุล</td>
                                                <td>เลขบัตรประจำตัวประชาชน</td>
                                                <td>ใบอนุญาตประกอบวิชาชีพเภสัชกรรมเลขที่</td>

                                            </tr>
                                        </thead>
                                        <tbody>
                                            <tr ng-repeat="data in DATA_PHR_SHOW">
                                                <td>{{data.PHR_LEVEL}}</td>
                                                <td>{{data.PHR_NAME}}</td>
                                                <td>{{data.PHR_CTZNO}}</td>
                                                <td>{{data.PHR_TEXT_NUM}}</td>
                                            </tr>
                                        </tbody>
                                    </table>
                                </div>
                            </div>
                        </div>
                        <div style="font-size:20px;">เป็นผู้ควบคุมตามมาตรา ๕๓ แห่งพระราชบัญญัติวัตถุที่ออกฤทธิ์ต่อจิตและประสาท พ.ศ. ๒๕๕๙</div>
                        <br />

                        <div style="font-size:20px;"><strong>๔. พร้อมกับคำขอนี้ข้าพเจ้าได้แนบเอกสารหรือหลักฐานต่างๆ มาด้วย คือ</strong></div>
                        <div style="margin-left:5%;font-size:20px;"><strong>๔.๑ กรณีขอรับใบอนุญาต (กรณีรายใหม่)</strong></div>
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
                        <div style="margin-left:5%;font-size:20px;"><strong>๔.๒ กรณีขอต่ออายุใบอนุญาต</strong></div>
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
                        <div style="margin-left:5%;font-size:20px;"><strong>๔.๓ กรณีขอรับใบแทนใบอนุญาต</strong></div>
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
                        <br />

                        <div style="margin-left:5%;font-size:20px;"> หมายเหตุ : (๑) ให้ขีดเลือกข้อความในช่อง ☐/〇 ให้ตรงตามที่ประสงค์จะดำเนินการ</div>
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

                <div ng-show="LIST_LCN.PROCESS == '134'">
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
                            <strong>ใบอนุญาตส่งออกวัตถุออกฤทธิ์ในประเภท ๓ หรือประเภท ๔</strong>
                        </h2>
                        @*process =133,134 *@

                        <table style="width:70%; font-size:20px;margin:auto;text-align:center">
                            <tr>
                                <td>
                                    <strong>สำหรับส่งออก</strong>
                                </td>
                                <td>
                                    <input type="radio" name="gender" ng-model="LIST_LCN.PROCESS" value="133" id="rdl_CHK_SELL_TYPE" disabled="disabled" /> <strong>วัตถุออกฤทธิ์ในประเภท ๓</strong>
                                </td>
                                <td>
                                    <input type="radio" name="gender" ng-model="LIST_LCN.PROCESS" value="134" id="rdl_CHK_SELL_TYPE" disabled="disabled" /> <strong>วัตถุออกฤทธิ์ในประเภท ๔</strong>
                                </td>
                            </tr>
                            <tr>
                                <td style="font-size:16px" colspan="3">
                                    <strong>(คำขอ ๑ ฉบับ ให้ยื่นขอได้เพียงหนึ่งประเภทเท่านั้น)</strong>
                                </td>
                            </tr>
                        </table>

                        <table style="width:100%; font-size:20px;">
                            <tr>
                                <td style="width:20%">
                                    <input type="checkbox" name="gender" disabled="disabled" ng-checked="true" /> <strong>ขอรับใบอนุญาต</strong>
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
                                    <input type="checkbox" name="gender" disabled="disabled" /> <strong>ขอรับใบแทนใบอนุญาต</strong>
                                </td>
                                <td>
                                    เนื่องจากใบอนุญาต
                                </td>
                                <td>
                                    <input class="checkbox" type="checkbox" disabled="disabled" /> <strong>สูญหาย</strong>
                                </td>
                                <td>
                                    <input class="checkbox" type="checkbox" disabled="disabled" /> <strong>ถูกทำลายหรือลบเลือนในสาระสำคัญ</strong>
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

                                    {{LIST_LCN.dalcn.WRITE_AT}}
                                </td>
                            </tr>
                            <tr>
                                <td style="text-align:right;width:100px">
                                    วันที่
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;">

                                    {{LIST_LCN.dalcn.WRITE_DATE}}
                                </td>
                            </tr>

                        </table>
                        <br />

                        <h2 style="font-size:24px;">
                            <strong>๑. ข้อมูลผู้ขอรับใบอนุญาต</strong>
                        </h2>
                        <table style="width:90%;margin-left:5%">
                            <tr>
                                <td style="font-size:20px;" width="40%">
                                    ข้าพเจ้า (ชื่อบุคคล/นิติบุคคล)
                                </td>
                                <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;" colspan="6">
                                    <label>{{LIST_LCN.thanm}}</label>
                                </td>
                            </tr>
                            <tr>
                                <td style="font-size:20px;">
                                    เลขประจำตัวประชาชน
                                </td>

                                <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;" colspan="6">
                                    <label>{{LIST_LCN.CITIZEN_AUTHORIZE}}</label>
                                </td>
                            </tr>
                            <tr>
                                <td style="font-size:20px;">
                                    หรือบัตรประจำตัวอื่นที่ทางราชการออกให้ คือ
                                </td>
                                <td style="font-size:20px;width:20%;border-bottom:dotted;border-bottom-width:thin;"></td>
                                <td style="font-size:20px;width:5%">
                                    เลขที่
                                </td>
                                <td style="font-size:20px ;width:15%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"></td>
                                <td style="font-size:20px;">
                                    (กรณีไม่ใช่ผู้มีสัญชาติไทย)
                                </td>
                            </tr>
                            <tr>
                                <td style="font-size:20px;">
                                    หรือทะเบียนนิติบุคคล/บัตรประจำตัวผู้เสียภาษี เลขที่
                                </td>
                                <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;" colspan="6">
                                    <label>{{LIST_LCN.IDENTIFY}}</label>
                                </td>
                            </tr>
                            <tr>
                                <td style="font-size:20px;">
                                    เลขรหัสประจำบ้าน
                                </td>
                                <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;" colspan="6">
                                    <label>{{LIST_LCN.HOUSENO}}</label>
                                </td>
                            </tr>
                            <tr>
                                <td style="font-size:20px;">
                                    อยู่เลขที่
                                </td>
                                <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;" colspan="6">
                                    <label>{{LIST_LCN.fulladdr3}}</label>
                                </td>
                            </tr>
                            <tr>
                                <td style="font-size:20px;">
                                    โทรศัพท์/มือถือ
                                </td>
                                <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;" colspan="6">
                                    <label>{{LIST_LCN.tel}}</label>
                                </td>
                            </tr>
                            <tr>
                                <td style="font-size:20px;">
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
                                <td style="font-size:20px;" width="40%">
                                    ข้าพเจ้า
                                </td>
                                <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;" colspan="6">
                                    <label>{{LIST_LCN.BSN_THAIFULLNAME}}</label>
                                </td>
                            </tr>
                            <tr>
                                <td style="font-size:20px;">
                                    เลขประจำตัวประชาชน
                                </td>
                                <td style="text-align:left;width:30%;">
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
                                </td>
                            </tr>
                            <tr>
                                <td style="font-size:20px;">
                                    หรือบัตรประจำตัวอื่นที่ทางราชการออกให้ คือ
                                </td>
                                <td style="font-size:20px;width:20%;border-bottom:dotted;border-bottom-width:thin;">
                                    <label>{{LIST_LCN.BSN_IDENTIFY}}</label>
                                </td>
                                <td style="font-size:20px;width:5%">
                                    เลขที่
                                </td>
                                <td style="font-size:20px ;width:15%;text-align:center;border-bottom:dotted;border-bottom-width:thin;">
                                </td>
                                <td style="font-size:20px;">
                                    (กรณีไม่ใช่ผู้มีสัญชาติไทย)
                                </td>
                            </tr>
                            <tr>
                                <td style="font-size:20px;">
                                    หรือทะเบียนนิติบุคคล/บัตรประจำตัวผู้เสียภาษี เลขที่
                                </td>
                                <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;" colspan="6">
                                    <label>{{LIST_LCN.BSN_IDENTIFY}}</label>
                                </td>
                            </tr>
                            <tr>
                                <td style="font-size:20px;">
                                    เลขรหัสประจำบ้าน
                                </td>
                                <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;" colspan="6">
                                    <label>{{LIST_LCN.BSN_HOUSENO}}</label>
                                </td>
                            </tr>
                            <tr>
                                <td style="font-size:20px;">
                                    อยู่เลขที่
                                </td>
                                <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;" colspan="6">
                                    <label>{{LIST_LCN.BSN_FULL_ADDR}}</label>
                                </td>
                            </tr>
                            <tr>
                                <td style="font-size:20px;">
                                    โทรศัพท์/มือถือ
                                </td>
                                <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;" colspan="6">
                                    <label>{{LIST_LCN.BSN_TELEPHONE}}</label>
                                </td>
                            </tr>
                            <tr>
                                <td style="font-size:20px;">
                                    E-mail
                                </td>
                                <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;" colspan="6">
                                    <label>{{LIST_LCN.dalcn.Email}}</label>
                                </td>
                            </tr>
                        </table>
                        <br />

                        <table style="width:100%;font-size:20px;">
                            <tr>
                                <td colspan="4">
                                    <p><strong>๓. ข้อมูลสถานที่ส่งออก</strong></p>
                                </td>
                            </tr>
                            <tr>
                                <td style="width:15%;">
                                    ณ สถานที่ชื่อ
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;">
                                    <label>{{LIST_LCN.thanameplace}}</label>
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
                                <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;">
                                    <label>{{LIST_HEAD_LCN.HEAD_LCNNO_NCT}}</label>
                                </td>
                            </tr>
                        </table>

                        <table style="font-size:20px;width:100%">
                            <tr>
                                <td style="width:20%">
                                    โดยมีเภสัชกรชั้น
                                </td>
                                <td style="width:10%;border-bottom:dotted;border-bottom-width:thin;">
                                    @*<input class="form-control inline" ng-model="LIST_PHR_ADD.PHR_LEVEL" style="font-family:'Taviraj';font-size:20px;" type="text" />*@
                                    {{LIST_PHR_ADD.PHR_LEVEL}}
                                </td>
                                <td style="text-align:center">
                                    ชื่อ
                                </td>
                                <td style="width:10%;border-bottom:dotted;border-bottom-width:thin;">
                                    @*<select class="form-control selectpicker" data-live-search="true" title="-- Please select --" ng-model="LIST_PHR_ADD.PHR_PREFIX_ID">
                                        @*<option value="0">--กรุณาเลือก--</option>*@
                                    @*<option ng-repeat="x in PREFIX" value="{{x.prefixcd}}">{{x.thanm}}</option>
                                        </select>*@
                                    {{LIST_PHR_ADD.PHR_PREFIX_ID}}
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;">
                                    @*<input class="form-control inline" ng-model="LIST_PHR_ADD.PHR_NAME" style="font-family:'Taviraj';font-size:20px;" type="text" />*@
                                    {{LIST_PHR_ADD.PHR_NAME}}
                                </td>
                            </tr>
                            <tr>
                                <td style="width:20%">
                                    เลขบัตรประจำตัวประชาชน
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;" colspan="4">
                                    @*<input class="form-control inline" ng-model="LIST_PHR_ADD.PHR_CTZNO" style="font-family:'Taviraj';font-size:20px;" type="text" />*@
                                    {{LIST_PHR_ADD.PHR_CTZNO}}
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    ใบอนุญาตประกอบวิชาชีพ
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;" colspan="4"></td>
                            </tr>
                            <tr>
                                <td>
                                    เภสัชกรรมเลขที่
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;">
                                    @*<input class="form-control inline" ng-model="LIST_PHR_ADD.PHR_TEXT_NUM" style="font-family:'Taviraj';font-size:20px;" type="text" />*@
                                    {{LIST_PHR_ADD.PHR_TEXT_NUM}}
                                </td>
                            </tr>
                        </table>
                        <br />
                        @*<input type="button" style="font-size:20px;width:100px" value="เพิ่ม" ng-click="BTN_ADD_PHR(LIST_PHR_ADD)" />*@
                        <div class="row">
                            <div class="col-sm-12">
                                <div class="card" style=" border-top: 10px solid #F9D027;">
                                    <table width="100%" style="font-family:'Taviraj'">
                                        <thead>
                                            <tr>
                                                <td>เภสัชกรชั้น</td>
                                                <td>ชื่อ-นามสกุล</td>
                                                <td>เลขบัตรประจำตัวประชาชน</td>
                                                <td>ใบอนุญาตประกอบวิชาชีพเภสัชกรรมเลขที่</td>

                                            </tr>
                                        </thead>
                                        <tbody>
                                            <tr ng-repeat="data in DATA_PHR_SHOW">
                                                <td>{{data.PHR_LEVEL}}</td>
                                                <td>{{data.PHR_NAME}}</td>
                                                <td>{{data.PHR_CTZNO}}</td>
                                                <td>{{data.PHR_TEXT_NUM}}</td>
                                            </tr>
                                        </tbody>
                                    </table>
                                </div>
                            </div>
                        </div>
                        <div style="font-size:20px;">เป็นผู้ควบคุมตามมาตรา ๕๓ แห่งพระราชบัญญัติวัตถุที่ออกฤทธิ์ต่อจิตและประสาท พ.ศ. ๒๕๕๙</div>
                        <br />

                        <div style="font-size:20px;"><strong>๔. พร้อมกับคำขอนี้ข้าพเจ้าได้แนบเอกสารหรือหลักฐานต่างๆ มาด้วย คือ</strong></div>
                        <div style="margin-left:5%;font-size:20px;"><strong>๔.๑ กรณีขอรับใบอนุญาต (กรณีรายใหม่)</strong></div>
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
                        <div style="margin-left:5%;font-size:20px;"><strong>๔.๒ กรณีขอต่ออายุใบอนุญาต</strong></div>
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
                        <div style="margin-left:5%;font-size:20px;"><strong>๔.๓ กรณีขอรับใบแทนใบอนุญาต</strong></div>
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
                        <br />

                        <div style="margin-left:5%;font-size:20px;"> หมายเหตุ : (๑) ให้ขีดเลือกข้อความในช่อง ☐/〇 ให้ตรงตามที่ประสงค์จะดำเนินการ</div>
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

                <div ng-show="LIST_LCN.PROCESS =='125'">
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
                            <strong>ใบอนุญาตขายวัตถุออกฤทธิ์ในประเภท ๓ หรือประเภท ๔</strong>
                        </h2>
                        @*process =123,124 *@
                        <table style="width:70%; font-size:20px;margin:auto;text-align:center">
                            <tr>
                                <td>
                                    <strong>สำหรับขาย</strong>
                                </td>
                                <td>
                                    <input type="radio" name="gender" ng-model="LIST_LCN.PROCESS" ng-value="125" id="rdl_CHK_SELL_TYPE" disabled="disabled" /> <strong>วัตถุออกฤทธิ์ในประเภท ๓</strong>
                                </td>
                                <td>
                                    <input type="radio" name="gender" ng-model="LIST_LCN.PROCESS" ng-value="126" id="rdl_CHK_SELL_TYPE" disabled="disabled" /> <strong>วัตถุออกฤทธิ์ในประเภท ๔</strong>
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
                                    <input type="checkbox" name="gender" disabled="disabled" ng-checked="true" /> <strong>ขอรับใบอนุญาต</strong>
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
                                    <input type="checkbox" name="gender" disabled="disabled" /> <strong>ขอรับใบแทนใบอนุญาต</strong>
                                </td>
                                <td>
                                    เนื่องจากใบอนุญาต
                                </td>
                                <td>
                                    <input class="checkbox" type="checkbox" disabled="disabled" /> <strong>สูญหาย</strong>
                                </td>
                                <td>
                                    <input class="checkbox" type="checkbox" disabled="disabled" /> <strong>ถูกทำลายหรือลบเลือนในสาระสำคัญ</strong>
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

                                    {{LIST_LCN.dalcn.WRITE_AT}}
                                </td>
                            </tr>
                            <tr>
                                <td style="text-align:right;width:100px">
                                    วันที่
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;">

                                    {{LIST_LCN.dalcn.WRITE_DATE}}
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
                                <td style="text-align:left;width:30%;">
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
                                </td>
                            </tr>
                            <tr>
                                <td style="font-size:20px">
                                    หรือบัตรประจำตัวอื่นที่ทางราชการออกให้ คือ
                                </td>
                                <td style="font-size:20px;width:20%;border-bottom:dotted;border-bottom-width:thin;">
                                    <label>{{LIST_LCN.BSN_THAIFULLNAME}}</label>
                                </td>
                                <td style="font-size:20px;width:5%">
                                    เลขที่
                                </td>
                                <td style="font-size:20px ;width:15%;text-align:center;border-bottom:dotted;border-bottom-width:thin;">
                                    <label>{{LIST_LCN.BSN_THAIFULLNAME}}</label>
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
                                    <label>{{LIST_LCN.thanameplace}}</label>
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
                                <td style="border-bottom:dotted;border-bottom-width:thin;" colspan="3">
                                    <label>{{LIST_LCN.fulladdr3}}</label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    โทรศัพท์/มือถือ
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;" colspan="3">
                                    <label>{{LIST_LCN.tel}}</label>
                                </td>
                            </tr>

                        </table>
                        <br />
                        <table style="font-size:20px;width:100%">
                            <tr>
                                <td style="width:20%">
                                    โดยมีเภสัชกรชั้น
                                </td>
                                <td style="width:10%;border-bottom:dotted;border-bottom-width:thin;">
                                    @*<input class="form-control inline" ng-model="LIST_PHR_ADD.PHR_LEVEL" style="font-family:'Taviraj';font-size:20px;" type="text" />*@
                                    {{LIST_PHR_ADD.PHR_LEVEL}}
                                </td>
                                <td style="text-align:center">
                                    ชื่อ
                                </td>
                                <td style="width:10%">
                                    @*<select class="form-control selectpicker" data-live-search="true" title="-- Please select --" ng-model="LIST_PHR_ADD.PHR_PREFIX_ID">
                                        @*<option value="0">--กรุณาเลือก--</option>*@
                                    @*<option ng-repeat="x in PREFIX" value="{{x.prefixcd}}">{{x.thanm}}</option>
                                        </select>*@
                                    {{LIST_PHR_ADD.PHR_PREFIX_ID}}
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;">
                                    @*<input class="form-control inline" ng-model="LIST_PHR_ADD.PHR_NAME" style="font-family:'Taviraj';font-size:20px;" type="text" />*@
                                    {{LIST_PHR_ADD.PHR_NAME}}
                                </td>
                            </tr>
                            <tr>
                                <td style="width:20%">
                                    เลขบัตรประจำตัวประชาชน
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;" colspan="4">
                                    @*<input class="form-control inline" ng-model="LIST_PHR_ADD.PHR_CTZNO" style="font-family:'Taviraj';font-size:20px;" type="text" />*@
                                    {{LIST_PHR_ADD.PHR_CTZNO}}
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    ใบอนุญาตประกอบวิชาชีพ
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;" colspan="4"></td>
                            </tr>
                            <tr>
                                <td>
                                    เภสัชกรรมเลขที่
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;">
                                    @*<input class="form-control inline" ng-model="LIST_PHR_ADD.PHR_TEXT_NUM" style="font-family:'Taviraj';font-size:20px;" type="text" />*@
                                    {{LIST_PHR_ADD.PHR_TEXT_NUM}}
                                </td>
                            </tr>
                        </table>
                        <br />
                        @*<input type="button" style="font-size:20px;width:100px" value="เพิ่ม" ng-click="BTN_ADD_PHR(LIST_PHR_ADD)" />*@
                        <div class="row">
                            <div class="col-sm-12">
                                <div class="card" style=" border-top: 10px solid #F9D027;">
                                    <table width="100%" style="font-family:'Taviraj'">
                                        <thead>
                                            <tr>
                                                <td>เภสัชกรชั้น</td>
                                                <td>ชื่อ-นามสกุล</td>
                                                <td>เลขบัตรประจำตัวประชาชน</td>
                                                <td>ใบอนุญาตประกอบวิชาชีพเภสัชกรรมเลขที่</td>

                                            </tr>
                                        </thead>
                                        <tbody>
                                            <tr ng-repeat="data in DATA_PHR_SHOW">
                                                <td>{{data.PHR_LEVEL}}</td>
                                                <td>{{data.PHR_NAME}}</td>
                                                <td>{{data.PHR_CTZNO}}</td>
                                                <td>{{data.PHR_TEXT_NUM}}</td>
                                            </tr>
                                        </tbody>
                                    </table>
                                </div>
                            </div>
                        </div>
                        <br />
                        <table style="width:100%;font-size:20px">
                            <tr>
                                <td>
                                    เป็นผู้รับอนุญาตขายยาแผนใบอนุญาตเลขที่
                                </td>
                                <td style="width:50%;border-bottom:dotted;border-bottom-width:thin;">
                                    <label>{{LIST_HEAD_LCN.HEAD_LCNNO_NCT}}</label>
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
                                    <label>{{LIST_HEAD_LCN.HEAD_LCNNO_NCT}}</label>
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
                                <td style="border-bottom:dotted;border-bottom-width:thin;" colspan="4">
                                    <label>{{LIST_HEAD_LCN.HEAD_LCNNO_NCT}}</label>
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
                                <td style="border-bottom:dotted;border-bottom-width:thin;" colspan="4">
                                    <label>{{LIST_LCN.thanameplace}}</label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    เลขรหัสประจำบ้าน
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;" colspan="4">
                                    <label>{{LIST_LCN.HOUSENO}}</label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    ตั้งอยู่เลขที่
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;" colspan="3">
                                    <label>{{LIST_LCN.fulladdr2}}</label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    โทรศัพท์/มือถือ
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;" colspan="3">
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
                        <h2>๔. ข้อมูลสถานที่เก็บ (กรณีเป็นสถานที่คนละแห่งกับสถานที่ตาม ๓)</h2>
                        <table style="width:50%">
                            <tr>
                                <td>
                                    ณ สถานที่ชื่อ
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;">

                                    @*<select class="form-control selectpicker" data-live-search="true" title="-- Please select --" ng-model="LIST_LCN.LOCATION_SELECT" ng-change="getdetails(LIST_LCN.LOCATION_SELECT)">
                                        @*<option value="">--กรุณาเลือก--</option>*@
                                    @*<option ng-repeat="x in REF_LOCATION_KEEP" value="{{x.IDA}}">{{x.thanameplace}}</option>
                                        </select>*@
                                    {{LIST_LCN.LOCATION_SELECT}}
                                </td>
                            </tr>
                            <tr>
                                <td style="width:15%">
                                    เลขรหัสประจำบ้าน
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;">
                                    <label>{{LIST_LABEL.HOUSENO}}</label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    อยู่เลขที่
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;">
                                    <label>{{LIST_LABEL.fulladdr}}</label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    โทรศัพท์
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;">
                                    <label>{{LIST_LABEL.tel}}</label>
                                </td>
                            </tr>
                            <tr style="font-size: 20px">
                                <td>
                                    โทรศัพท์มือถือ
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;">
                                    <label>{{LIST_LABEL.Mobile}}</label>
                                </td>
                            </tr>
                        </table>


                        <br />
                        @*<input type="button" style="font-size:20px;width:100px" value="เพิ่ม" ng-click="BTN_ADD_KEEP(LIST_LABEL,LIST_LCN.LOCATION_SELECT)" />*@
                        <div class="col-sm-12">
                            <div class="card" style=" border-top: 10px solid #F9D027;">
                                <table width="100%" style="font-family:'Taviraj'">
                                    <thead>
                                        <tr>
                                            <td>ชื่อสถานที่เก็บ</td>
                                            <td>อยู่เลขที่</td>
                                        </tr>
                                    </thead>
                                    <tbody>
                                        <tr ng-repeat="data in DATA_KEEP_SHOW">
                                            <td>{{datas.thanameplace}}</td>
                                            <td>{{datas.fulladdr}}</td>
                                        </tr>
                                    </tbody>
                                </table>
                            </div>
                        </div>
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

                <div ng-show="LIST_LCN.PROCESS =='126'">
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
                            <strong>ใบอนุญาตขายวัตถุออกฤทธิ์ในประเภท ๓ หรือประเภท ๔</strong>
                        </h2>
                        @*process =123,124 *@
                        <table style="width:70%; font-size:20px;margin:auto;text-align:center">
                            <tr>
                                <td>
                                    <strong>สำหรับขาย</strong>
                                </td>
                                <td>
                                    <input type="radio" name="gender" ng-model="LIST_LCN.PROCESS" ng-value="125" id="rdl_CHK_SELL_TYPE" disabled="disabled" /> <strong>วัตถุออกฤทธิ์ในประเภท ๓</strong>
                                </td>
                                <td>
                                    <input type="radio" name="gender" ng-model="LIST_LCN.PROCESS" ng-value="126" id="rdl_CHK_SELL_TYPE" disabled="disabled" /> <strong>วัตถุออกฤทธิ์ในประเภท ๔</strong>
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
                                    <input type="checkbox" name="gender" disabled="disabled" ng-checked="true" /> <strong>ขอรับใบอนุญาต</strong>
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
                                    <input type="checkbox" name="gender" disabled="disabled" /> <strong>ขอรับใบแทนใบอนุญาต</strong>
                                </td>
                                <td>
                                    เนื่องจากใบอนุญาต
                                </td>
                                <td>
                                    <input class="checkbox" type="checkbox" disabled="disabled" /> <strong>สูญหาย</strong>
                                </td>
                                <td>
                                    <input class="checkbox" type="checkbox" disabled="disabled" /> <strong>ถูกทำลายหรือลบเลือนในสาระสำคัญ</strong>
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

                                    {{LIST_LCN.dalcn.WRITE_AT}}
                                </td>
                            </tr>
                            <tr>
                                <td style="text-align:right;width:100px">
                                    วันที่
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;">

                                    {{LIST_LCN.dalcn.WRITE_DATE}}
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
                                <td style="text-align:left;width:30%;">
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
                                </td>
                            </tr>
                            <tr>
                                <td style="font-size:20px">
                                    หรือบัตรประจำตัวอื่นที่ทางราชการออกให้ คือ
                                </td>
                                <td style="font-size:20px;width:20%;border-bottom:dotted;border-bottom-width:thin;">
                                    <label>{{LIST_LCN.BSN_THAIFULLNAME}}</label>
                                </td>
                                <td style="font-size:20px;width:5%">
                                    เลขที่
                                </td>
                                <td style="font-size:20px ;width:15%;text-align:center;border-bottom:dotted;border-bottom-width:thin;">
                                    <label>{{LIST_LCN.BSN_THAIFULLNAME}}</label>
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
                                    <label>{{LIST_LCN.thanameplace}}</label>
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
                                <td style="border-bottom:dotted;border-bottom-width:thin;" colspan="3">
                                    <label>{{LIST_LCN.fulladdr3}}</label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    โทรศัพท์/มือถือ
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;" colspan="3">
                                    <label>{{LIST_LCN.tel}}</label>
                                </td>
                            </tr>

                        </table>
                        <br />
                        <table style="font-size:20px;width:100%">
                            <tr>
                                <td style="width:20%">
                                    โดยมีเภสัชกรชั้น
                                </td>
                                <td style="width:10%;border-bottom:dotted;border-bottom-width:thin;">
                                    @*<input class="form-control inline" ng-model="LIST_PHR_ADD.PHR_LEVEL" style="font-family:'Taviraj';font-size:20px;" type="text" />*@
                                    {{LIST_PHR_ADD.PHR_LEVEL}}
                                </td>
                                <td style="text-align:center">
                                    ชื่อ
                                </td>
                                <td style="width:10%">
                                    @*<select class="form-control selectpicker" data-live-search="true" title="-- Please select --" ng-model="LIST_PHR_ADD.PHR_PREFIX_ID">
                                        @*<option value="0">--กรุณาเลือก--</option>*@
                                    @*<option ng-repeat="x in PREFIX" value="{{x.prefixcd}}">{{x.thanm}}</option>
                                        </select>*@
                                    {{LIST_PHR_ADD.PHR_PREFIX_ID}}
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;">
                                    @*<input class="form-control inline" ng-model="LIST_PHR_ADD.PHR_NAME" style="font-family:'Taviraj';font-size:20px;" type="text" />*@
                                    {{LIST_PHR_ADD.PHR_NAME}}
                                </td>
                            </tr>
                            <tr>
                                <td style="width:20%">
                                    เลขบัตรประจำตัวประชาชน
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;" colspan="4">
                                    @*<input class="form-control inline" ng-model="LIST_PHR_ADD.PHR_CTZNO" style="font-family:'Taviraj';font-size:20px;" type="text" />*@
                                    {{LIST_PHR_ADD.PHR_CTZNO}}
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    ใบอนุญาตประกอบวิชาชีพ
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;" colspan="4"></td>
                            </tr>
                            <tr>
                                <td>
                                    เภสัชกรรมเลขที่
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;">
                                    @*<input class="form-control inline" ng-model="LIST_PHR_ADD.PHR_TEXT_NUM" style="font-family:'Taviraj';font-size:20px;" type="text" />*@
                                    {{LIST_PHR_ADD.PHR_TEXT_NUM}}
                                </td>
                            </tr>
                        </table>
                        <br />
                        @*<input type="button" style="font-size:20px;width:100px" value="เพิ่ม" ng-click="BTN_ADD_PHR(LIST_PHR_ADD)" />*@
                        <div class="row">
                            <div class="col-sm-12">
                                <div class="card" style=" border-top: 10px solid #F9D027">
                                    <table width="100%" style="font-family:'Taviraj'">
                                        <thead>
                                            <tr>
                                                <td>เภสัชกรชั้น</td>
                                                <td>ชื่อ-นามสกุล</td>
                                                <td>เลขบัตรประจำตัวประชาชน</td>
                                                <td>ใบอนุญาตประกอบวิชาชีพเภสัชกรรมเลขที่</td>

                                            </tr>
                                        </thead>
                                        <tbody>
                                            <tr ng-repeat="data in DATA_PHR_SHOW">
                                                <td>{{data.PHR_LEVEL}}</td>
                                                <td>{{data.PHR_NAME}}</td>
                                                <td>{{data.PHR_CTZNO}}</td>
                                                <td>{{data.PHR_TEXT_NUM}}</td>
                                            </tr>
                                        </tbody>
                                    </table>
                                </div>
                            </div>
                        </div>
                        <br />
                        <table style="width:100%;font-size:20px">
                            <tr>
                                <td>
                                    เป็นผู้รับอนุญาตขายยาแผนใบอนุญาตเลขที่
                                </td>
                                <td style="width:50%;border-bottom:dotted;border-bottom-width:thin;">
                                    <label>{{LIST_HEAD_LCN.HEAD_LCNNO_NCT}}</label>
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
                                    <label>{{LIST_HEAD_LCN.HEAD_LCNNO_NCT}}</label>
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
                                <td style="border-bottom:dotted;border-bottom-width:thin;" colspan="4">
                                    <label>{{LIST_HEAD_LCN.HEAD_LCNNO_NCT}}</label>
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
                                <td style="border-bottom:dotted;border-bottom-width:thin;" colspan="4">
                                    <label>{{LIST_LCN.thanameplace}}</label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    เลขรหัสประจำบ้าน
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;" colspan="4">
                                    <label>{{LIST_LCN.HOUSENO}}</label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    ตั้งอยู่เลขที่
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;" colspan="3">
                                    <label>{{LIST_LCN.fulladdr2}}</label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    โทรศัพท์/มือถือ
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;" colspan="3">
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
                        <h2>๔. ข้อมูลสถานที่เก็บ (กรณีเป็นสถานที่คนละแห่งกับสถานที่ตาม ๓)</h2>
                        <table style="width:50%">
                            <tr>
                                <td>
                                    ณ สถานที่ชื่อ
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;">

                                    @*<select class="form-control selectpicker" data-live-search="true" title="-- Please select --" ng-model="LIST_LCN.LOCATION_SELECT" ng-change="getdetails(LIST_LCN.LOCATION_SELECT)">
                                        @*<option value="">--กรุณาเลือก--</option>*@
                                    @*<option ng-repeat="x in REF_LOCATION_KEEP" value="{{x.IDA}}">{{x.thanameplace}}</option>
                                        </select>*@
                                    {{LIST_LCN.LOCATION_SELECT}}
                                </td>
                            </tr>
                            <tr>
                                <td style="width:15%">
                                    เลขรหัสประจำบ้าน
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;">
                                    <label>{{LIST_LABEL.HOUSENO}}</label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    อยู่เลขที่
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;">
                                    <label>{{LIST_LABEL.fulladdr}}</label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    โทรศัพท์
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;">
                                    <label>{{LIST_LABEL.tel}}</label>
                                </td>
                            </tr>
                            <tr style="font-size: 20px">
                                <td>
                                    โทรศัพท์มือถือ
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;">
                                    <label>{{LIST_LABEL.Mobile}}</label>
                                </td>
                            </tr>
                        </table>


                        <br />
                        @*<input type="button" style="font-size:20px;width:100px" value="เพิ่ม" ng-click="BTN_ADD_KEEP(LIST_LABEL,LIST_LCN.LOCATION_SELECT)" />*@
                        <div class="col-sm-12">
                            <div class="card" style=" border-top: 10px solid #F9D027;">
                                <table width="100%" style="font-family:'Taviraj'">
                                    <thead>
                                        <tr>
                                            <td>ชื่อสถานที่เก็บ</td>
                                            <td>อยู่เลขที่</td>
                                        </tr>
                                    </thead>
                                    <tbody>
                                        <tr ng-repeat="data in DATA_KEEP_SHOW">
                                            <td>{{datas.thanameplace}}</td>
                                            <td>{{datas.fulladdr}}</td>
                                        </tr>
                                    </tbody>
                                </table>
                            </div>
                        </div>
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

                <div ng-show="LIST_LCN.PROCESS == '116'">
                    <div style="font-family:'Taviraj';font-size:24px;width:100%">
                        <div>
                            <p style="text-align: left;"><b>แบบ ย.ส. ๓-๑</b></p>
                        </div>
                        <div class="container">
                            <div class="row">
                                <div class="col-md-6">
                                    <table style="width :50%" align="left" border="1">
                                        <tr>
                                            <td style="width: 100%">
                                                เลขที่รับ<br />
                                                วันที่<br />
                                                <span style="padding-left: 30px;">(สำหรับเจ้าหน้าที่เป็นผู้กรอก)</span>
                                            </td>
                                        </tr>
                                    </table>
                                </div>
                                <div class="col-md-6 offset-md-4">
                                    <table style="width: 25%" align="right" border="1">
                                        <tr>
                                            <td style="width:100%; text-align:center"><img src="..." class="rounded float-end" alt="...">ที่ปิดรูปถ่ายของผู้ขอรับอนุญาตหรือผู้ดำเนินกิจการ ขนาด ๓ x ๔ ซม.</td>
                                        </tr>
                                    </table>
                                </div>
                            </div>
                        </div>
                        <br />
                        <div>
                            <p style="text-align: center; font-size: large">คำขอรับอนุญาต</p>
                            <p style="text-align: center; font-size: large">ผลิต นำเข้า ส่งออก จำหน่ายหรือมีไว้ครอบครองเพื่อจำหน่าย</p>
                            <p style="text-align: center; font-size: large">ซึ่งยาเสพติดให้โทษในประเภท ๓</p>
                            <hr style="width: 17%; border-color: black" />
                            <table style="width:100%">
                                <tr>
                                    <td style="text-align:right;width:90%">
                                        เขียนที่
                                    </td>
                                    <td style="width:40%;border-bottom:dotted;border-bottom-width:thin;">

                                        {{LIST_LCN.dalcn.WRITE_AT}}
                                    </td>
                                </tr>
                                <tr>
                                    <td style="text-align:right;width:100px">
                                        วันที่
                                    </td>
                                    <td style="border-bottom:dotted;border-bottom-width:thin;">

                                        {{LIST_LCN.dalcn.WRITE_DATE}}
                                    </td>
                                </tr>

                            </table>
                            <br />
                            <table style="width: 100%">
                                <tr>
                                    <td style="width: 2%"></td>
                                    <td style="width: 30%"><b>๑. ข้าพเจ้า</b>&nbsp; (ชื่อบุคคล/นิติบุคคลผู้ขอรับใบอนุญาต)</td>
                                    <td style="border-bottom:dotted;border-bottom-width:thin;">{{LIST_LCN.thanm}}</td>
                                </tr>
                                <tr>
                                    <td style="width: 2%"></td>
                                    <td style="width: 30%">เลขที่บัตรประชาชน หรือทะเบียนนิติบุคคลเลขที่</td>
                                    <td style="border-bottom:dotted;border-bottom-width:thin;">{{LIST_LCN.IDENTIFY}}</td>
                                </tr>
                            </table>
                            <table style="width: 100%">
                                <tr>
                                    <td style="width: 2%"></td>
                                    <td style="font-size:20px">
                                        อยู่เลขที่
                                    </td>
                                    <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;" colspan="6">
                                        <label>{{LIST_LCN.fulladdr3}}</label>
                                    </td>
                                </tr>
                                <tr>
                                    <td style="width: 2%"></td>
                                    <td style="font-size:20px">
                                        โทรศัพท์/มือถือ
                                    </td>
                                    <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;" colspan="6">
                                        <label>{{LIST_LCN.tel}}</label>
                                    </td>
                                </tr>
                            </table>
                            <table style="width: 100%">
                                <tr>
                                    <td style="width: 2%"></td>
                                    <td style="width: 98%" colspan="2"><b>๒. ซึ่งมีผู้ได้รับมอบหมายให้ดำเนินกิจการของนิติบุคคลผู้ขอรับใบอนุญาตกรณีผู้ขอรับใบอนุญาตเป็นนิติบุคคล</b></td>
                                </tr>
                                <tr>
                                    <td style="width: 2%"></td>
                                    <td>ชื่อ</td>
                                    <td style="width: 98%;border-bottom:dotted;border-bottom-width:thin;">{{LIST_LCN.BSN_THAIFULLNAME}}</td>
                                </tr>
                            </table>
                            <table style="width: 100%">
                                <tr>
                                    <td style="width: 2%"></td>
                                    <td style="width: 20%">เลขที่บัตรประชาชน</td>
                                    <td style="width: 46%">
                                        <form>
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
                                        </form>
                                    </td>
                                    <td>
                                        อายุ
                                    </td>
                                    <td style="text-align: left; width: 20%;border-bottom:dotted;border-bottom-width:thin;" align="center">
                                        <label>{{LIST_LCN.AGE}}</label>ปี
                                    </td>
                                    <td>
                                        สัญชาติ
                                    </td>
                                    <td style="text-align:left;width:10%;">
                                        <input class="form-control inline" ng-model="LIST_LCN.dalcn.NATION" style="font-family:'Taviraj';" type="text" />
                                    </td>
                                </tr>
                            </table>
                            <table style="width: 100%">
                                <tr>
                                    <td style="width: 2%"></td>
                                    <td style="width:200px">
                                        อยู่เลขที่
                                    </td>
                                    <td style="text-align:left;border-bottom:dotted;border-bottom-width:thin;" colspan="3">
                                        <label>{{LIST_LCN.BSN_FULL_ADDR}}</label>
                                    </td>

                                </tr>
                                <tr>
                                    <td style="width: 2%"></td>
                                    <td>
                                        โทรศัพท์
                                    </td>
                                    <td style="text-align:left;border-bottom:dotted;border-bottom-width:thin;">
                                        <label>{{LIST_LCN.BSN_TELEPHONE}}</label>
                                    </td>
                                </tr>
                                <tr>
                                    <td style="width: 2%"></td>
                                    <td>
                                        โทรศัพท์มือถือ
                                    </td>
                                    <td style="text-align:left;border-bottom:dotted;border-bottom-width:thin;">
                                        <label>{{LIST_LCN.BSN_FAX}}</label>
                                    </td>
                                </tr>
                            </table>
                            <table style="width: 100%">
                                <tr>
                                    <td style="width: 2%"></td>
                                    <td style="width: 98%"><b>๓. ขอรับใบอนุญาต</b>(ให้ขีดเลือกข้อความในช่องให้ตรงตามความประสงค์จะขออนุญาตเพียงช่องเดียว)</td>
                                </tr>
                            </table>

                            <table style=" font-size:20px;width:100%;margin-left:10%">

                                <tr>
                                    <td>
                                        <form name="rdl_gmp">


                                            <label><input type="radio" ng-model="LIST_LCN.PROCESS" id="Rdl_gmpt" value="114" disabled> ผลิตซึ่งยาเสพติดให้โทษในประเภท ๓</label><br />
                                            <label><input type="radio" ng-model="LIST_LCN.PROCESS" id="Rdl_gmpt" value="116" disabled> นำเข้าซึ่งยาเสพติดให้โทษในประเภท ๓</label><br />
                                            <label><input type="radio" ng-model="LIST_LCN.PROCESS" id="Rdl_gmpt" value="117" disabled> ส่งออกซึ่งยาเสพติดให้โทษในประเภท ๓</label><br />
                                            <label><input type="radio" ng-model="LIST_LCN.PROCESS" id="Rdl_gmpt" value="115" disabled> จำหน่ายหรือมีไว้ในครอบครองเพื่อจำหน่ายซึ่งยาเสพติดให้โทษในประเภท ๓</label>
                                        </form>
                                    </td>

                                </tr>
                            </table>



                            <table style="width: 100%">
                                <tr>
                                    <td style="width: 2%"></td>
                                    <td style="width: 98%">ณ สถานที่ ชื่อ</td>
                                    <td style="border-bottom:dotted;border-bottom-width:thin;">{{LIST_LCN.thanameplace}}</td>
                                </tr>
                                <tr>
                                    <td>
                                        ตั้งอยู่เลขที่
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
                            </table>
                            <table style="font-size:20px;width:100%">
                                <tr>
                                    <td style="width:20%">
                                        โดยมีเภสัชกรชั้น
                                    </td>
                                    <td style="width:10%;border-bottom:dotted;border-bottom-width:thin;">
                                        @*<input class="form-control inline" ng-model="LIST_PHR_ADD.PHR_LEVEL" style="font-family:'Taviraj';font-size:20px;" type="text" />*@
                                        {{LIST_PHR_ADD.PHR_LEVEL}}
                                    </td>
                                    <td style="text-align:center">
                                        ชื่อ
                                    </td>
                                    <td style="width:10%;border-bottom:dotted;border-bottom-width:thin;">
                                        @*<select class="form-control selectpicker" data-live-search="true" title="-- Please select --" ng-model="LIST_PHR_ADD.PHR_PREFIX_ID">
                                            @*<option value="0">--กรุณาเลือก--</option>*@
                                        @*<option ng-repeat="x in PREFIX" value="{{x.prefixcd}}">{{x.thanm}}</option>
                                            </select>*@
                                        {{LIST_PHR_ADD.PHR_PREFIX_ID}}
                                    </td>
                                    <td style="border-bottom:dotted;border-bottom-width:thin;">
                                        @*<input class="form-control inline" ng-model="LIST_PHR_ADD.PHR_NAME" style="font-family:'Taviraj';font-size:20px;" type="text" />*@
                                        {{LIST_PHR_ADD.PHR_NAME}}
                                    </td>
                                </tr>
                                <tr>
                                    <td style="width:20%">
                                        เลขบัตรประจำตัวประชาชน
                                    </td>
                                    <td style="border-bottom:dotted;border-bottom-width:thin;" colspan="4">
                                        @*<input class="form-control inline" ng-model="LIST_PHR_ADD.PHR_CTZNO" style="font-family:'Taviraj';font-size:20px;" type="text" />*@
                                        {{LIST_PHR_ADD.PHR_CTZNO}}
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        ใบอนุญาตประกอบวิชาชีพ
                                    </td>
                                    <td colspan="4"></td>
                                </tr>
                                <tr>
                                    <td>
                                        เภสัชกรรมเลขที่
                                    </td>
                                    <td style="border-bottom:dotted;border-bottom-width:thin;">
                                        @*<input class="form-control inline" ng-model="LIST_PHR_ADD.PHR_TEXT_NUM" style="font-family:'Taviraj';font-size:20px;" type="text" />*@
                                        {{LIST_PHR_ADD.PHR_TEXT_NUM}}
                                    </td>
                                </tr>
                            </table>
                            <br />
                            @*<input type="button" style="font-size:20px;width:100px" value="เพิ่ม" ng-click="BTN_ADD_PHR(LIST_PHR_ADD)" />*@
                            <div class="row">
                                <div class="col-sm-12">
                                    <div class="card" style=" border-top: 10px solid #F9D027;">
                                        <table width="100%" style="font-family:'Taviraj'">
                                            <thead>
                                                <tr>
                                                    <td>เภสัชกรชั้น</td>
                                                    <td>ชื่อ-นามสกุล</td>
                                                    <td>เลขบัตรประจำตัวประชาชน</td>
                                                    <td>ใบอนุญาตประกอบวิชาชีพเภสัชกรรมเลขที่</td>

                                                </tr>
                                            </thead>
                                            <tbody>
                                                <tr ng-repeat="data in DATA_PHR_SHOW">
                                                    <td>{{data.PHR_LEVEL}}</td>
                                                    <td>{{data.PHR_NAME}}</td>
                                                    <td>{{data.PHR_CTZNO}}</td>
                                                    <td>{{data.PHR_TEXT_NUM}}</td>
                                                </tr>
                                            </tbody>
                                        </table>
                                    </div>
                                </div>
                            </div>

                            <hr style="width: 100%; border-color: black" />
                            <p>เป็นผู้มีหน้าที่ควบคุมตามมาตรา ๒๑ แห่งพระราชบัญญัติยาเสพติดให้โทษ พ.ศ.๒๕๒๒</p>
                            <table style="width: 100%">
                                <tr>
                                    <td style="width: 2%"></td>
                                    <td style="width: 98%"><b>๕. พร้อมกับคำขอนี้ข้าพเจ้าได้แนบเอกสารหรือหลักฐานต่างๆ มาด้วย คือ</b></td>
                                </tr>
                                <tr>
                                    <td style="width: 2%"></td>
                                    <td style="width: 98%">(๑) สำเนาทะเบียนบ้านของผู้ขอรับใบอนุญาตหรือผู้ได้รับมอบหมายให้ดำเนินกิจการ</td>
                                </tr>
                                <tr>
                                    <td style="width: 2%"></td>
                                    <td style="width: 98%">(๒) สำเนาบัตรประชาชนของผู้ขอรับใบอนุญาตหรือผู้ได้รับมอบหมายให้ ดำเนินกิจการ</td>
                                </tr>
                                <tr>
                                    <td style="width: 2%"></td>
                                    <td style="width: 98%">(๓) รูปถ่ายของผู้ขอรับใบอนุญาตหรือผูู้ได้รับมอบหมายให้ดำเนินกิจการขนาด ๓ x ๔ เซนติเมตร จำนวน ๒ รูปซึ่งถ่ายไว้ไม่เกิน ๖ เดือน</td>
                                </tr>
                                <tr>
                                    <td style="width: 2%"></td>
                                    <td style="width: 98%">(๔) สำเนาหนังสือรับรองแสดงการจดทะเบียนเป็นนิติบุคคลซึ่งนายทะเบียนออกไว้ไม่เกิน ๖ เดือน</td>
                                </tr>
                                <tr>
                                    <td style="width: 2%"></td>
                                    <td style="width: 98%">(๕) หนังสือแสดงว่าผู้ได้รับมอบหมายให้ดำเนินกิจการของนิติบุคคลผู้ขอรับใบอนุญาตกรณีผู้ขอรับใบอนุญาตเป็นนิติบุคคล</td>
                                </tr>
                                <tr>
                                    <td style="width: 2%"></td>
                                    <td style="width: 98%">(๖) สำเนาใบอนุญาตประกอบวิชาชีพ</td>
                                </tr>
                                <tr>
                                    <td style="width: 2%"></td>
                                    <td style="width: 98%">(๗) สำเนาใบอนุญาตผลิตหรือขายยาแผนปัจจุบัน หรือใบอนุญาตนำหรือสั่งยาแผนปัจจุบันเข้ามาในราชอาณาจักรตามกฏหมายว่าด้วยยา แล้วแต่กรณี</td>
                                </tr>
                                <tr>
                                    <td style="width: 2%"></td>
                                    <td style="width: 98%">(๘) เอกสารหรือหลักฐานอื่นๆ(ถ้ามี)</td>
                                </tr>
                            </table>
                            <br /><br />


                            <table style="font-size:20px;width:70%;float:right">
                                <tr>
                                    <td style="width:10%;text-align:center">
                                        (ลายมือชื่อ)
                                    </td>
                                    <td style="width:20%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"></td>
                                    <td style="text-align:left;width:40%">
                                        ผู้ขอรับใบอนุญาต / ผู้ได้รับมอบหมายให้ ดำเนินกิจการ
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right">
                                        (
                                    </td>
                                    <td style="width:50%;text-align:center;border-bottom:dotted;border-bottom-width:thin;">
                                        <label>{{LIST_LCN.BSN_THAIFULLNAME}}</label>
                                    </td>
                                    <td style="text-align:left">
                                        )
                                    </td>
                                </tr>
                            </table>

                        </div>
                    </div>
                </div>

                <div ng-show="LIST_LCN.PROCESS == '117'">
                    <div style="font-family:'Taviraj';font-size:24px;width:100%">
                        <div>
                            <p style="text-align: left;"><b>แบบ ย.ส. ๓-๑</b></p>
                        </div>
                        <div class="container">
                            <div class="row">
                                <div class="col-md-6">
                                    <table style="width :50%" align="left" border="1">
                                        <tr>
                                            <td style="width: 100%">
                                                เลขที่รับ<br />
                                                วันที่<br />
                                                <span style="padding-left: 30px;">(สำหรับเจ้าหน้าที่เป็นผู้กรอก)</span>
                                            </td>
                                        </tr>
                                    </table>
                                </div>
                                <div class="col-md-6 offset-md-4">
                                    <table style="width: 25%" align="right" border="1">
                                        <tr>
                                            <td style="width:100%; text-align:center"><img src="..." class="rounded float-end" alt="...">ที่ปิดรูปถ่ายของผู้ขอรับอนุญาตหรือผู้ดำเนินกิจการ ขนาด ๓ x ๔ ซม.</td>
                                        </tr>
                                    </table>
                                </div>
                            </div>
                        </div>
                        <br />
                        <div>
                            <p style="text-align: center; font-size: large">คำขอรับอนุญาต</p>
                            <p style="text-align: center; font-size: large">ผลิต นำเข้า ส่งออก จำหน่ายหรือมีไว้ครอบครองเพื่อจำหน่าย</p>
                            <p style="text-align: center; font-size: large">ซึ่งยาเสพติดให้โทษในประเภท ๓</p>
                            <hr style="width: 17%; border-color: black" />
                            <table style="width:100%">
                                <tr>
                                    <td style="text-align:right;width:90%">
                                        เขียนที่
                                    </td>
                                    <td style="width:40%;border-bottom:dotted;border-bottom-width:thin;">

                                        {{LIST_LCN.dalcn.WRITE_AT}}
                                    </td>
                                </tr>
                                <tr>
                                    <td style="text-align:right;width:100px">
                                        วันที่
                                    </td>
                                    <td style="border-bottom:dotted;border-bottom-width:thin;">

                                        {{LIST_LCN.dalcn.WRITE_DATE}}
                                    </td>
                                </tr>

                            </table>
                            <br />
                            <table style="width: 100%">
                                <tr>
                                    <td style="width: 2%"></td>
                                    <td style="width: 30%"><b>๑. ข้าพเจ้า</b>&nbsp; (ชื่อบุคคล/นิติบุคคลผู้ขอรับใบอนุญาต)</td>
                                    <td style="border-bottom:dotted;border-bottom-width:thin;">{{LIST_LCN.thanm}}</td>
                                </tr>
                                <tr>
                                    <td style="width: 2%"></td>
                                    <td style="width: 30%">เลขที่บัตรประชาชน หรือทะเบียนนิติบุคคลเลขที่</td>
                                    <td style="border-bottom:dotted;border-bottom-width:thin;">{{LIST_LCN.IDENTIFY}}</td>
                                </tr>
                            </table>
                            <table style="width: 100%">
                                <tr>
                                    <td style="width: 2%"></td>
                                    <td style="font-size:20px">
                                        อยู่เลขที่
                                    </td>
                                    <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;" colspan="6">
                                        <label>{{LIST_LCN.fulladdr3}}</label>
                                    </td>
                                </tr>
                                <tr>
                                    <td style="width: 2%"></td>
                                    <td style="font-size:20px">
                                        โทรศัพท์/มือถือ
                                    </td>
                                    <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;" colspan="6">
                                        <label>{{LIST_LCN.tel}}</label>
                                    </td>
                                </tr>
                            </table>
                            <table style="width: 100%">
                                <tr>
                                    <td style="width: 2%"></td>
                                    <td style="width: 98%" colspan="2"><b>๒. ซึ่งมีผู้ได้รับมอบหมายให้ดำเนินกิจการของนิติบุคคลผู้ขอรับใบอนุญาตกรณีผู้ขอรับใบอนุญาตเป็นนิติบุคคล</b></td>
                                </tr>
                                <tr>
                                    <td style="width: 2%"></td>
                                    <td>ชื่อ</td>
                                    <td style="width: 98%;border-bottom:dotted;border-bottom-width:thin;">{{LIST_LCN.BSN_THAIFULLNAME}}</td>
                                </tr>
                            </table>
                            <table style="width: 100%">
                                <tr>
                                    <td style="width: 2%"></td>
                                    <td style="width: 20%">เลขที่บัตรประชาชน</td>
                                    <td style="width: 46%">
                                        <form>
                                            <table>
                                                <tr>
                                                    <td>
                                                        @*<input class="form-control inline" ng-model="LIST_LCN.BSN_IDENTIFY" id="txt_bsn_identify" style="font-family:'Taviraj';" type="text" />*@
                                                            {{LIST_LCN.BSN_IDENTIFY}}
                                                    </td>
                                                    @*<td>
                                                        <input type="button" value="ค้นหาผู้ดำเนินฯ" ng-click="BTN_Search_BSN(LIST_LCN.BSN_IDENTIFY)" />
                                                    </td>*@
                                                </tr>
                                            </table>
                                        </form>
                                    </td>
                                    <td>
                                        อายุ
                                    </td>
                                    <td style="text-align: left; width: 20%;border-bottom:dotted;border-bottom-width:thin;" align="center">
                                        <label>{{LIST_LCN.AGE}}</label>ปี
                                    </td>
                                    <td>
                                        สัญชาติ
                                    </td>
                                    <td style="text-align:left;width:10%;">
                                        @*<input class="form-control inline" ng-model="LIST_LCN.dalcn.NATION" style="font-family:'Taviraj';" type="text" />*@
                                            {{LIST_LCN.dalcn.NATION}}
                                    </td>
                                </tr>
                            </table>
                            <table style="width: 100%">
                                <tr>
                                    <td style="width: 2%"></td>
                                    <td style="width:200px">
                                        อยู่เลขที่
                                    </td>
                                    <td style="text-align:left;border-bottom:dotted;border-bottom-width:thin;" colspan="3">
                                        <label>{{LIST_LCN.BSN_FULL_ADDR}}</label>
                                    </td>

                                </tr>
                                <tr>
                                    <td style="width: 2%"></td>
                                    <td>
                                        โทรศัพท์
                                    </td>
                                    <td style="text-align:left;border-bottom:dotted;border-bottom-width:thin;">
                                        <label>{{LIST_LCN.BSN_TELEPHONE}}</label>
                                    </td>
                                </tr>
                                <tr>
                                    <td style="width: 2%"></td>
                                    <td>
                                        โทรศัพท์มือถือ
                                    </td>
                                    <td style="text-align:left;border-bottom:dotted;border-bottom-width:thin;">
                                        <label>{{LIST_LCN.BSN_FAX}}</label>
                                    </td>
                                </tr>
                            </table>
                            <table style="width: 100%">
                                <tr>
                                    <td style="width: 2%"></td>
                                    <td style="width: 98%"><b>๓. ขอรับใบอนุญาต</b>(ให้ขีดเลือกข้อความในช่องให้ตรงตามความประสงค์จะขออนุญาตเพียงช่องเดียว)</td>
                                </tr>
                            </table>

                            <table style=" font-size:20px;width:100%;margin-left:10%">

                                <tr>
                                    <td>
                                        <form name="rdl_gmp">


                                            <label><input type="radio" ng-model="LIST_LCN.PROCESS" id="Rdl_gmpt" value="114" disabled> ผลิตซึ่งยาเสพติดให้โทษในประเภท ๓</label><br />
                                            <label><input type="radio" ng-model="LIST_LCN.PROCESS" id="Rdl_gmpt" value="116" disabled> นำเข้าซึ่งยาเสพติดให้โทษในประเภท ๓</label><br />
                                            <label><input type="radio" ng-model="LIST_LCN.PROCESS" id="Rdl_gmpt" value="117" disabled> ส่งออกซึ่งยาเสพติดให้โทษในประเภท ๓</label><br />
                                            <label><input type="radio" ng-model="LIST_LCN.PROCESS" id="Rdl_gmpt" value="115" disabled> จำหน่ายหรือมีไว้ในครอบครองเพื่อจำหน่ายซึ่งยาเสพติดให้โทษในประเภท ๓</label>
                                        </form>
                                    </td>

                                </tr>
                            </table>



                            <table style="width: 100%">
                                <tr>
                                    <td style="width: 2%"></td>
                                    <td style="width: 98%">ณ สถานที่ ชื่อ</td>
                                    <td style="border-bottom:dotted;border-bottom-width:thin;">{{LIST_LCN.thanameplace}}</td>
                                </tr>
                                <tr>
                                    <td>
                                        ตั้งอยู่เลขที่
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
                            </table>
                            <table style="font-size:20px;width:100%">
                                <tr>
                                    <td style="width:20%">
                                        โดยมีเภสัชกรชั้น
                                    </td>
                                    <td style="width:10%;border-bottom:dotted;border-bottom-width:thin;">
                                        @*<input class="form-control inline" ng-model="LIST_PHR_ADD.PHR_LEVEL" style="font-family:'Taviraj';font-size:20px;" type="text" />*@
                                        {{LIST_PHR_ADD.PHR_LEVEL}}
                                    </td>
                                    <td style="text-align:center">
                                        ชื่อ
                                    </td>
                                    <td style="width:10%;border-bottom:dotted;border-bottom-width:thin;">
                                        @*<select class="form-control selectpicker" data-live-search="true" title="-- Please select --" ng-model="LIST_PHR_ADD.PHR_PREFIX_ID">
                                            @*<option value="0">--กรุณาเลือก--</option>*@
                                        @*<option ng-repeat="x in PREFIX" value="{{x.prefixcd}}">{{x.thanm}}</option>
                                            </select>*@
                                        {{LIST_PHR_ADD.PHR_PREFIX_ID}}
                                    </td>
                                    <td style="border-bottom:dotted;border-bottom-width:thin;">
                                        @*<input class="form-control inline" ng-model="LIST_PHR_ADD.PHR_NAME" style="font-family:'Taviraj';font-size:20px;" type="text" />*@
                                        {{LIST_PHR_ADD.PHR_NAME}}
                                    </td>
                                </tr>
                                <tr>
                                    <td style="width:20%">
                                        เลขบัตรประจำตัวประชาชน
                                    </td>
                                    <td style="border-bottom:dotted;border-bottom-width:thin;" colspan="4">
                                        @*<input class="form-control inline" ng-model="LIST_PHR_ADD.PHR_CTZNO" style="font-family:'Taviraj';font-size:20px;" type="text" />*@
                                        {{LIST_PHR_ADD.PHR_CTZNO}}
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        ใบอนุญาตประกอบวิชาชีพ
                                    </td>
                                    <td style="border-bottom:dotted;border-bottom-width:thin;" colspan="4"></td>
                                </tr>
                                <tr>
                                    <td>
                                        เภสัชกรรมเลขที่
                                    </td>
                                    <td style="border-bottom:dotted;border-bottom-width:thin;">
                                        @*<input class="form-control inline" ng-model="LIST_PHR_ADD.PHR_TEXT_NUM" style="font-family:'Taviraj';font-size:20px;" type="text" />*@
                                        {{LIST_PHR_ADD.PHR_TEXT_NUM}}
                                    </td>
                                </tr>
                            </table>
                            <br />
                            @*<input type="button" style="font-size:20px;width:100px" value="เพิ่ม" ng-click="BTN_ADD_PHR(LIST_PHR_ADD)" />*@
                            <div class="row">
                                <div class="col-sm-12">
                                    <div class="card" style=" border-top: 10px solid #F9D027;">
                                        <table width="100%" style="font-family:'Taviraj'">
                                            <thead>
                                                <tr>
                                                    <td>เภสัชกรชั้น</td>
                                                    <td>ชื่อ-นามสกุล</td>
                                                    <td>เลขบัตรประจำตัวประชาชน</td>
                                                    <td>ใบอนุญาตประกอบวิชาชีพเภสัชกรรมเลขที่</td>

                                                </tr>
                                            </thead>
                                            <tbody>
                                                <tr ng-repeat="data in DATA_PHR_SHOW">
                                                    <td>{{data.PHR_LEVEL}}</td>
                                                    <td>{{data.PHR_NAME}}</td>
                                                    <td>{{data.PHR_CTZNO}}</td>
                                                    <td>{{data.PHR_TEXT_NUM}}</td>
                                                </tr>
                                            </tbody>
                                        </table>
                                    </div>
                                </div>
                            </div>

                            <hr style="width: 100%; border-color: black" />
                            <p>เป็นผู้มีหน้าที่ควบคุมตามมาตรา ๒๑ แห่งพระราชบัญญัติยาเสพติดให้โทษ พ.ศ.๒๕๒๒</p>
                            <table style="width: 100%">
                                <tr>
                                    <td style="width: 2%"></td>
                                    <td style="width: 98%"><b>๕. พร้อมกับคำขอนี้ข้าพเจ้าได้แนบเอกสารหรือหลักฐานต่างๆ มาด้วย คือ</b></td>
                                </tr>
                                <tr>
                                    <td style="width: 2%"></td>
                                    <td style="width: 98%">(๑) สำเนาทะเบียนบ้านของผู้ขอรับใบอนุญาตหรือผู้ได้รับมอบหมายให้ดำเนินกิจการ</td>
                                </tr>
                                <tr>
                                    <td style="width: 2%"></td>
                                    <td style="width: 98%">(๒) สำเนาบัตรประชาชนของผู้ขอรับใบอนุญาตหรือผู้ได้รับมอบหมายให้ ดำเนินกิจการ</td>
                                </tr>
                                <tr>
                                    <td style="width: 2%"></td>
                                    <td style="width: 98%">(๓) รูปถ่ายของผู้ขอรับใบอนุญาตหรือผูู้ได้รับมอบหมายให้ดำเนินกิจการขนาด ๓ x ๔ เซนติเมตร จำนวน ๒ รูปซึ่งถ่ายไว้ไม่เกิน ๖ เดือน</td>
                                </tr>
                                <tr>
                                    <td style="width: 2%"></td>
                                    <td style="width: 98%">(๔) สำเนาหนังสือรับรองแสดงการจดทะเบียนเป็นนิติบุคคลซึ่งนายทะเบียนออกไว้ไม่เกิน ๖ เดือน</td>
                                </tr>
                                <tr>
                                    <td style="width: 2%"></td>
                                    <td style="width: 98%">(๕) หนังสือแสดงว่าผู้ได้รับมอบหมายให้ดำเนินกิจการของนิติบุคคลผู้ขอรับใบอนุญาตกรณีผู้ขอรับใบอนุญาตเป็นนิติบุคคล</td>
                                </tr>
                                <tr>
                                    <td style="width: 2%"></td>
                                    <td style="width: 98%">(๖) สำเนาใบอนุญาตประกอบวิชาชีพ</td>
                                </tr>
                                <tr>
                                    <td style="width: 2%"></td>
                                    <td style="width: 98%">(๗) สำเนาใบอนุญาตผลิตหรือขายยาแผนปัจจุบัน หรือใบอนุญาตนำหรือสั่งยาแผนปัจจุบันเข้ามาในราชอาณาจักรตามกฏหมายว่าด้วยยา แล้วแต่กรณี</td>
                                </tr>
                                <tr>
                                    <td style="width: 2%"></td>
                                    <td style="width: 98%">(๘) เอกสารหรือหลักฐานอื่นๆ(ถ้ามี)</td>
                                </tr>
                            </table>
                            <br /><br />


                            <table style="font-size:20px;width:70%;float:right">
                                <tr>
                                    <td style="width:10%;text-align:center">
                                        (ลายมือชื่อ)
                                    </td>
                                    <td style="width:20%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"></td>
                                    <td style="text-align:left;width:40%">
                                        ผู้ขอรับใบอนุญาต / ผู้ได้รับมอบหมายให้ ดำเนินกิจการ
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right">
                                        (
                                    </td>
                                    <td style="width:50%;text-align:center;border-bottom:dotted;border-bottom-width:thin;">
                                        <label>{{LIST_LCN.BSN_THAIFULLNAME}}</label>
                                    </td>
                                    <td style="text-align:left">
                                        )
                                    </td>
                                </tr>
                            </table>

                        </div>
                    </div>
                </div>

                <div ng-show="LIST_LCN.PROCESS == '115'">
                    <div style="font-family:'Taviraj';font-size:24px;width:100%">
                        <div>
                            <p style="text-align: left;"><b>แบบ ย.ส. ๓-๑</b></p>
                        </div>
                        <div class="container">
                            <div class="row">
                                <div class="col-md-6">
                                    <table style="width :50%" align="left" border="1">
                                        <tr>
                                            <td style="width: 100%">
                                                เลขที่รับ<br />
                                                วันที่<br />
                                                <span style="padding-left: 30px;">(สำหรับเจ้าหน้าที่เป็นผู้กรอก)</span>
                                            </td>
                                        </tr>
                                    </table>
                                </div>
                                <div class="col-md-6 offset-md-4">
                                    <table style="width: 25%" align="right" border="1">
                                        <tr>
                                            <td style="width:100%; text-align:center"><img src="..." class="rounded float-end" alt="...">ที่ปิดรูปถ่ายของผู้ขอรับอนุญาตหรือผู้ดำเนินกิจการ ขนาด ๓ x ๔ ซม.</td>
                                        </tr>
                                    </table>
                                </div>
                            </div>
                        </div>
                        <br />
                        <div>
                            <p style="text-align: center; font-size: large">คำขอรับอนุญาต</p>
                            <p style="text-align: center; font-size: large">ผลิต นำเข้า ส่งออก จำหน่ายหรือมีไว้ครอบครองเพื่อจำหน่าย</p>
                            <p style="text-align: center; font-size: large">ซึ่งยาเสพติดให้โทษในประเภท ๓</p>
                            <hr style="width: 17%; border-color: black" />
                            <table style="width:100%">
                                <tr>
                                    <td style="text-align:right;width:90%">
                                        เขียนที่
                                    </td>
                                    <td style="width:40%;border-bottom:dotted;border-bottom-width:thin;">

                                        {{LIST_LCN.dalcn.WRITE_AT}}
                                    </td>
                                </tr>
                                <tr>
                                    <td style="text-align:right;width:100px">
                                        วันที่
                                    </td>
                                    <td style="border-bottom:dotted;border-bottom-width:thin;">

                                        {{LIST_LCN.dalcn.WRITE_DATE}}
                                    </td>
                                </tr>

                            </table>
                            <br />
                            <table style="width: 100%">
                                <tr>
                                    <td style="width: 2%"></td>
                                    <td style="width: 30%"><b>๑. ข้าพเจ้า</b>&nbsp; (ชื่อบุคคล/นิติบุคคลผู้ขอรับใบอนุญาต)</td>
                                    <td style="border-bottom:dotted;border-bottom-width:thin;">{{LIST_LCN.thanm}}</td>
                                </tr>
                                <tr>
                                    <td style="width: 2%"></td>
                                    <td style="width: 30%">เลขที่บัตรประชาชน หรือทะเบียนนิติบุคคลเลขที่</td>
                                    <td style="border-bottom:dotted;border-bottom-width:thin;">{{LIST_LCN.IDENTIFY}}</td>
                                </tr>
                            </table>
                            <table style="width: 100%">
                                <tr>
                                    <td style="width: 2%"></td>
                                    <td style="font-size:20px">
                                        อยู่เลขที่
                                    </td>
                                    <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;" colspan="6">
                                        <label>{{LIST_LCN.fulladdr3}}</label>
                                    </td>
                                </tr>
                                <tr>
                                    <td style="width: 2%"></td>
                                    <td style="font-size:20px">
                                        โทรศัพท์/มือถือ
                                    </td>
                                    <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;" colspan="6">
                                        <label>{{LIST_LCN.tel}}</label>
                                    </td>
                                </tr>
                            </table>
                            <table style="width: 100%">
                                <tr>
                                    <td style="width: 2%"></td>
                                    <td style="width: 98%" colspan="2"><b>๒. ซึ่งมีผู้ได้รับมอบหมายให้ดำเนินกิจการของนิติบุคคลผู้ขอรับใบอนุญาตกรณีผู้ขอรับใบอนุญาตเป็นนิติบุคคล</b></td>
                                </tr>
                                <tr>
                                    <td style="width: 2%"></td>
                                    <td>ชื่อ</td>
                                    <td style="width: 98%;border-bottom:dotted;border-bottom-width:thin;">{{LIST_LCN.BSN_THAIFULLNAME}}</td>
                                </tr>
                            </table>
                            <table style="width: 100%">
                                <tr>
                                    <td style="width: 2%"></td>
                                    <td style="width: 20%">เลขที่บัตรประชาชน</td>
                                    <td style="width: 46%">
                                        <form>
                                            <table>
                                                <tr>
                                                    <td>
                                                        @*<input class="form-control inline" ng-model="LIST_LCN.BSN_IDENTIFY" id="txt_bsn_identify" style="font-family:'Taviraj';" type="text" />*@
                                                        {{LIST_LCN.BSN_IDENTIFY}}
                                                    </td>
                                                    @*<td>
                                                        <input type="button" value="ค้นหาผู้ดำเนินฯ" ng-click="BTN_Search_BSN(LIST_LCN.BSN_IDENTIFY)" />
                                                    </td>*@
                                                </tr>
                                            </table>
                                        </form>
                                    </td>
                                    <td>
                                        อายุ
                                    </td>
                                    <td style="text-align: left; width: 20%;border-bottom:dotted;border-bottom-width:thin;" align="center">
                                        <label>{{LIST_LCN.AGE}}</label>ปี
                                    </td>
                                    <td>
                                        สัญชาติ
                                    </td>
                                    <td style="text-align:left;width:10%;">
                                        @*<input class="form-control inline" ng-model="LIST_LCN.dalcn.NATION" style="font-family:'Taviraj';" type="text" />*@
                                        {{LIST_LCN.dalcn.NATION}}
                                    </td>
                                </tr>
                            </table>
                            <table style="width: 100%">
                                <tr>
                                    <td style="width: 2%"></td>
                                    <td style="width:200px">
                                        อยู่เลขที่
                                    </td>
                                    <td style="text-align:left;border-bottom:dotted;border-bottom-width:thin;" colspan="3">
                                        <label>{{LIST_LCN.BSN_FULL_ADDR}}</label>
                                    </td>

                                </tr>
                                <tr>
                                    <td style="width: 2%"></td>
                                    <td>
                                        โทรศัพท์
                                    </td>
                                    <td style="text-align:left;border-bottom:dotted;border-bottom-width:thin;">
                                        <label>{{LIST_LCN.BSN_TELEPHONE}}</label>
                                    </td>
                                </tr>
                                <tr>
                                    <td style="width: 2%"></td>
                                    <td>
                                        โทรศัพท์มือถือ
                                    </td>
                                    <td style="text-align:left;border-bottom:dotted;border-bottom-width:thin;">
                                        <label>{{LIST_LCN.BSN_FAX}}</label>
                                    </td>
                                </tr>
                            </table>
                            <table style="width: 100%">
                                <tr>
                                    <td style="width: 2%"></td>
                                    <td style="width: 98%"><b>๓. ขอรับใบอนุญาต</b>(ให้ขีดเลือกข้อความในช่องให้ตรงตามความประสงค์จะขออนุญาตเพียงช่องเดียว)</td>
                                </tr>
                            </table>

                            <table style=" font-size:20px;width:100%;margin-left:10%">

                                <tr>
                                    <td>
                                        <form name="rdl_gmp">


                                            <label><input type="radio" ng-model="LIST_LCN.PROCESS" id="Rdl_gmpt" value="114" disabled> ผลิตซึ่งยาเสพติดให้โทษในประเภท ๓</label><br />
                                            <label><input type="radio" ng-model="LIST_LCN.PROCESS" id="Rdl_gmpt" value="116" disabled> นำเข้าซึ่งยาเสพติดให้โทษในประเภท ๓</label><br />
                                            <label><input type="radio" ng-model="LIST_LCN.PROCESS" id="Rdl_gmpt" value="117" disabled> ส่งออกซึ่งยาเสพติดให้โทษในประเภท ๓</label><br />
                                            <label><input type="radio" ng-model="LIST_LCN.PROCESS" id="Rdl_gmpt" value="115" disabled> จำหน่ายหรือมีไว้ในครอบครองเพื่อจำหน่ายซึ่งยาเสพติดให้โทษในประเภท ๓</label>
                                        </form>
                                    </td>

                                </tr>
                            </table>



                            <table style="width: 100%">
                                <tr>
                                    <td style="width: 2%"></td>
                                    <td style="width: 98%">ณ สถานที่ ชื่อ</td>
                                    <td style="border-bottom:dotted;border-bottom-width:thin;">{{LIST_LCN.thanameplace}}</td>
                                </tr>
                                <tr>
                                    <td>
                                        ตั้งอยู่เลขที่
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
                            </table>
                            <table style="font-size:20px;width:100%">
                                <tr>
                                    <td style="width:20%">
                                        โดยมีเภสัชกรชั้น
                                    </td>
                                    <td style="width:10%;border-bottom:dotted;border-bottom-width:thin;">
                                        @*<input class="form-control inline" ng-model="LIST_PHR_ADD.PHR_LEVEL" style="font-family:'Taviraj';font-size:20px;" type="text" />*@
                                        {{LIST_PHR_ADD.PHR_LEVEL}}
                                    </td>
                                    <td style="text-align:center">
                                        ชื่อ
                                    </td>
                                    <td style="width:10%;border-bottom:dotted;border-bottom-width:thin;">
                                        @*<select class="form-control selectpicker" data-live-search="true" title="-- Please select --" ng-model="LIST_PHR_ADD.PHR_PREFIX_ID">
                                            @*<option value="0">--กรุณาเลือก--</option>*@
                                        @*<option ng-repeat="x in PREFIX" value="{{x.prefixcd}}">{{x.thanm}}</option>
                                            </select>*@
                                        {{LIST_PHR_ADD.PHR_PREFIX_ID}}
                                    </td>
                                    <td style="border-bottom:dotted;border-bottom-width:thin;">
                                        @*<input class="form-control inline" ng-model="LIST_PHR_ADD.PHR_NAME" style="font-family:'Taviraj';font-size:20px;" type="text" />*@
                                        {{LIST_PHR_ADD.PHR_NAME}}
                                    </td>
                                </tr>
                                <tr>
                                    <td style="width:20%">
                                        เลขบัตรประจำตัวประชาชน
                                    </td>
                                    <td style="border-bottom:dotted;border-bottom-width:thin;" colspan="4">
                                        @*<input class="form-control inline" ng-model="LIST_PHR_ADD.PHR_CTZNO" style="font-family:'Taviraj';font-size:20px;" type="text" />*@
                                        {{LIST_PHR_ADD.PHR_CTZNO}}
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        ใบอนุญาตประกอบวิชาชีพ
                                    </td>
                                    <td style="border-bottom:dotted;border-bottom-width:thin;" colspan="4"></td>
                                </tr>
                                <tr>
                                    <td>
                                        เภสัชกรรมเลขที่
                                    </td>
                                    <td style="border-bottom:dotted;border-bottom-width:thin;">
                                        @*<input class="form-control inline" ng-model="LIST_PHR_ADD.PHR_TEXT_NUM" style="font-family:'Taviraj';font-size:20px;" type="text" />*@
                                        {{LIST_PHR_ADD.PHR_TEXT_NUM}}
                                    </td>
                                </tr>
                            </table>
                            <br />
                            @*<input type="button" style="font-size:20px;width:100px" value="เพิ่ม" ng-click="BTN_ADD_PHR(LIST_PHR_ADD)" />*@
                            <div class="row">
                                <div class="col-sm-12">
                                    <div class="card" style=" border-top: 10px solid #F9D027;">
                                        <table width="100%" style="font-family:'Taviraj'">
                                            <thead>
                                                <tr>
                                                    <td>เภสัชกรชั้น</td>
                                                    <td>ชื่อ-นามสกุล</td>
                                                    <td>เลขบัตรประจำตัวประชาชน</td>
                                                    <td>ใบอนุญาตประกอบวิชาชีพเภสัชกรรมเลขที่</td>

                                                </tr>
                                            </thead>
                                            <tbody>
                                                <tr ng-repeat="data in DATA_PHR_SHOW">
                                                    <td>{{data.PHR_LEVEL}}</td>
                                                    <td>{{data.PHR_NAME}}</td>
                                                    <td>{{data.PHR_CTZNO}}</td>
                                                    <td>{{data.PHR_TEXT_NUM}}</td>
                                                </tr>
                                            </tbody>
                                        </table>
                                    </div>
                                </div>
                            </div>

                            <hr style="width: 100%; border-color: black" />
                            <p>เป็นผู้มีหน้าที่ควบคุมตามมาตรา ๒๑ แห่งพระราชบัญญัติยาเสพติดให้โทษ พ.ศ.๒๕๒๒</p>
                            <table style="width: 100%">
                                <tr>
                                    <td style="width: 2%"></td>
                                    <td style="width: 98%"><b>๕. พร้อมกับคำขอนี้ข้าพเจ้าได้แนบเอกสารหรือหลักฐานต่างๆ มาด้วย คือ</b></td>
                                </tr>
                                <tr>
                                    <td style="width: 2%"></td>
                                    <td style="width: 98%">(๑) สำเนาทะเบียนบ้านของผู้ขอรับใบอนุญาตหรือผู้ได้รับมอบหมายให้ดำเนินกิจการ</td>
                                </tr>
                                <tr>
                                    <td style="width: 2%"></td>
                                    <td style="width: 98%">(๒) สำเนาบัตรประชาชนของผู้ขอรับใบอนุญาตหรือผู้ได้รับมอบหมายให้ ดำเนินกิจการ</td>
                                </tr>
                                <tr>
                                    <td style="width: 2%"></td>
                                    <td style="width: 98%">(๓) รูปถ่ายของผู้ขอรับใบอนุญาตหรือผูู้ได้รับมอบหมายให้ดำเนินกิจการขนาด ๓ x ๔ เซนติเมตร จำนวน ๒ รูปซึ่งถ่ายไว้ไม่เกิน ๖ เดือน</td>
                                </tr>
                                <tr>
                                    <td style="width: 2%"></td>
                                    <td style="width: 98%">(๔) สำเนาหนังสือรับรองแสดงการจดทะเบียนเป็นนิติบุคคลซึ่งนายทะเบียนออกไว้ไม่เกิน ๖ เดือน</td>
                                </tr>
                                <tr>
                                    <td style="width: 2%"></td>
                                    <td style="width: 98%">(๕) หนังสือแสดงว่าผู้ได้รับมอบหมายให้ดำเนินกิจการของนิติบุคคลผู้ขอรับใบอนุญาตกรณีผู้ขอรับใบอนุญาตเป็นนิติบุคคล</td>
                                </tr>
                                <tr>
                                    <td style="width: 2%"></td>
                                    <td style="width: 98%">(๖) สำเนาใบอนุญาตประกอบวิชาชีพ</td>
                                </tr>
                                <tr>
                                    <td style="width: 2%"></td>
                                    <td style="width: 98%">(๗) สำเนาใบอนุญาตผลิตหรือขายยาแผนปัจจุบัน หรือใบอนุญาตนำหรือสั่งยาแผนปัจจุบันเข้ามาในราชอาณาจักรตามกฏหมายว่าด้วยยา แล้วแต่กรณี</td>
                                </tr>
                                <tr>
                                    <td style="width: 2%"></td>
                                    <td style="width: 98%">(๘) เอกสารหรือหลักฐานอื่นๆ(ถ้ามี)</td>
                                </tr>
                            </table>
                            <br /><br />


                            <table style="font-size:20px;width:70%;float:right">
                                <tr>
                                    <td style="width:10%;text-align:center">
                                        (ลายมือชื่อ)
                                    </td>
                                    <td style="width:20%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"></td>
                                    <td style="text-align:left;width:40%">
                                        ผู้ขอรับใบอนุญาต / ผู้ได้รับมอบหมายให้ ดำเนินกิจการ
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right">
                                        (
                                    </td>
                                    <td style="width:50%;text-align:center;border-bottom:dotted;border-bottom-width:thin;">
                                        <label>{{LIST_LCN.BSN_THAIFULLNAME}}</label>
                                    </td>
                                    <td style="text-align:left">
                                        )
                                    </td>
                                </tr>
                            </table>

                        </div>
                    </div>
                </div>

                <div ng-show="LIST_LCN.PROCESS == '127'">
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
                            <strong>ใบอนุญาตผลิตวัตถุออกฤทธิ์ในประเภท ๓ หรือประเภท ๔</strong>
                        </h2>
                        @*process =127,128 *@
                        <table style="width:70%; font-size:20px;margin:auto;text-align:center">
                            <tr>
                                <td>
                                    <strong>สำหรับผลิต</strong>
                                </td>
                                <td>
                                    <input type="radio" name="gender" ng-model="LIST_LCN.PROCESS" value="127" id="rdl_CHK_SELL_TYPE" disabled="disabled" /> <strong>วัตถุออกฤทธิ์ในประเภท ๓</strong>
                                </td>
                                <td>
                                    <input type="radio" name="gender" ng-model="LIST_LCN.PROCESS" value="128" id="rdl_CHK_SELL_TYPE" disabled="disabled" /> <strong>วัตถุออกฤทธิ์ในประเภท ๔</strong>
                                </td>
                            </tr>
                            <tr>
                                <td style="font-size:16px" colspan="3">
                                    <strong>(คำขอ ๑ ฉบับ ให้ยื่นขอได้เพียงหนึ่งประเภทเท่านั้น)</strong>
                                </td>
                            </tr>
                        </table>

                        <table style="width:100%; font-size:20px;">
                            <tr>
                                <td style="width:20%">
                                    <input type="checkbox" name="gender" disabled="disabled" ng-checked="true" /> <strong>ขอรับใบอนุญาต</strong>
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
                                    <input type="checkbox" name="gender" disabled="disabled" /> <strong>ขอรับใบแทนใบอนุญาต</strong>
                                </td>
                                <td>
                                    เนื่องจากใบอนุญาต
                                </td>
                                <td>
                                    <input class="checkbox" type="checkbox" disabled="disabled" /> <strong>สูญหาย</strong>
                                </td>
                                <td>
                                    <input class="checkbox" type="checkbox" disabled="disabled" /> <strong>ถูกทำลายหรือลบเลือนในสาระสำคัญ</strong>
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

                                    {{LIST_LCN.dalcn.WRITE_AT}}
                                </td>
                            </tr>
                            <tr>
                                <td style="text-align:right;width:100px">
                                    วันที่
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;">

                                    {{LIST_LCN.dalcn.WRITE_DATE}}
                                </td>
                            </tr>

                        </table>
                        <br />

                        <h2 style="font-size:24px;">
                            <strong>๑. ข้อมูลผู้ขอรับใบอนุญาต</strong>
                        </h2>
                        <table style="width:90%">
                            <tr>
                                <td style="font-size:20px;" width="40%">
                                    ข้าพเจ้า (ชื่อบุคคล/นิติบุคคล)
                                </td>
                                <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;" colspan="6">
                                    <label>{{LIST_LCN.thanm}}</label>
                                </td>
                            </tr>
                            <tr>
                                <td style="font-size:20px;">
                                    เลขประจำตัวประชาชน
                                </td>

                                <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;" colspan="6">
                                    <label>{{LIST_LCN.CITIZEN_AUTHORIZE}}</label>
                                </td>
                            </tr>
                            <tr>
                                <td style="font-size:20px;">
                                    หรือบัตรประจำตัวอื่นที่ทางราชการออกให้ คือ
                                </td>
                                <td style="font-size:20px;width:20%;border-bottom:dotted;border-bottom-width:thin;"></td>
                                <td style="font-size:20px;width:5%">
                                    เลขที่
                                </td>
                                <td style="font-size:20px ;width:15%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"></td>
                                <td style="font-size:20px;">
                                    (กรณีไม่ใช่ผู้มีสัญชาติไทย)
                                </td>
                            </tr>
                            <tr>
                                <td style="font-size:20px;">
                                    หรือทะเบียนนิติบุคคล/บัตรประจำตัวผู้เสียภาษี เลขที่
                                </td>
                                <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;" colspan="6">
                                    <label>{{LIST_LCN.IDENTIFY}}</label>
                                </td>
                            </tr>
                            <tr>
                                <td style="font-size:20px;">
                                    เลขรหัสประจำบ้าน
                                </td>
                                <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;" colspan="6">
                                    <label>{{LIST_LCN.HOUSENO}}</label>
                                </td>
                            </tr>
                            <tr>
                                <td style="font-size:20px;">
                                    อยู่เลขที่
                                </td>
                                <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;" colspan="6">
                                    <label>{{LIST_LCN.fulladdr3}}</label>
                                </td>
                            </tr>
                            <tr>
                                <td style="font-size:20px;">
                                    โทรศัพท์/มือถือ
                                </td>
                                <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;" colspan="6">
                                    <label>{{LIST_LCN.tel}}</label>
                                </td>
                            </tr>
                            <tr>
                                <td style="font-size:20px;">
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
                                <td style="font-size:20px;" width="40%">
                                    ข้าพเจ้า
                                </td>
                                <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;" colspan="6">
                                    <label>{{LIST_LCN.BSN_THAIFULLNAME}}</label>
                                </td>
                            </tr>
                            <tr>
                                <td style="font-size:20px;">
                                    เลขประจำตัวประชาชน
                                </td>
                                <td style="text-align:left;width:30%;">
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
                                </td>
                            </tr>
                            <tr>
                                <td style="font-size:20px;">
                                    หรือบัตรประจำตัวอื่นที่ทางราชการออกให้ คือ
                                </td>
                                <td style="font-size:20px;width:20%;border-bottom:dotted;border-bottom-width:thin;">
                                    <label>{{LIST_LCN.BSN_THAIFULLNAME}}</label>
                                </td>
                                <td style="font-size:20px;width:5%">
                                    เลขที่
                                </td>
                                <td style="font-size:20px ;width:15%;text-align:center;border-bottom:dotted;border-bottom-width:thin;">
                                </td>
                                <td style="font-size:20px;">
                                    (กรณีไม่ใช่ผู้มีสัญชาติไทย)
                                </td>
                            </tr>
                            <tr>
                                <td style="font-size:20px;">
                                    หรือทะเบียนนิติบุคคล/บัตรประจำตัวผู้เสียภาษี เลขที่
                                </td>
                                <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;" colspan="6">
                                    <label>{{LIST_LCN.BSN_IDENTIFY}}</label>
                                </td>
                            </tr>
                            <tr>
                                <td style="font-size:20px;">
                                    เลขรหัสประจำบ้าน
                                </td>
                                <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;" colspan="6">
                                    <label>{{LIST_LCN.BSN_HOUSENO}}</label>
                                </td>
                            </tr>
                            <tr>
                                <td style="font-size:20px;">
                                    อยู่เลขที่
                                </td>
                                <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;" colspan="6">
                                    <label>{{LIST_LCN.BSN_FULL_ADDR}}</label>
                                </td>
                            </tr>
                            <tr>
                                <td style="font-size:20px;">
                                    โทรศัพท์/มือถือ
                                </td>
                                <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;" colspan="6">
                                    <label>{{LIST_LCN.BSN_TELEPHONE}}</label>
                                </td>
                            </tr>
                            <tr>
                                <td style="font-size:20px;" colspan="2">
                                    โดยได้รับอนุญาตนำสั่งยาแผนปัจจุบันเข้ามาในราชอาณาจักร เลขที่
                                </td>
                                <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;" colspan="2">
                                    <label>{{LIST_HEAD_LCN.HEAD_LCNNO_NCT}}</label>
                                </td>
                                <td style="font-size:20px;">
                                    ตามกฎหมายว่าด้วยยา
                                </td>
                            </tr>
                        </table>

                        <div style="font-size:20px;"><strong>๓. ข้อมูลสถานที่ผลิต</strong></div>
                        <table style="width:100%;font-size:20px;">
                            <tr>
                                <td>
                                    ณ สถานที่ชื่อ
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;">
                                    <label>{{LIST_LCN.thanameplace}}</label>
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

                        <table style="width:100%;font-size:20px;">
                            <tr>
                                <td style="width:25%">
                                    มีความประสงค์ขอรับอนุญาตผลิตวัตถุออกฤทธิ์ในหมวด
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;" colspan="3">
                                    @*<input class="form-control inline" ng-model="LIST_LCN.dalcn.CATEGORY_DRUG" style="font-family:'Taviraj';font-size:20px;" type="text" />*@
                                        {{LIST_LCN.dalcn.CATEGORY_DRUG}}
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    โดยได้รับอนุญาตให้ผลิตยาแผนปัจจุบันเลขที่
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;">
                                    <label>{{LIST_HEAD_LCN.HEAD_LCNNO_NCT}}</label>
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


                        <table style="font-size:20px;width:100%">
                            <tr>
                                <td style="width:20%">
                                    โดยมีเภสัชกรชั้น
                                </td>
                                <td style="width:10%;border-bottom:dotted;border-bottom-width:thin;">
                                    @*<input class="form-control inline" ng-model="LIST_PHR_ADD.PHR_LEVEL" style="font-family:'Taviraj';font-size:20px;" type="text" />*@
                                    {{LIST_PHR_ADD.PHR_LEVEL}}
                                </td>
                                <td style="text-align:center">
                                    ชื่อ
                                </td>
                                <td style="width:10%;border-bottom:dotted;border-bottom-width:thin;">
                                    @*<select class="form-control selectpicker" data-live-search="true" title="-- Please select --" ng-model="LIST_PHR_ADD.PHR_PREFIX_ID">
                                        @*<option value="0">--กรุณาเลือก--</option>*@
                                    @*<option ng-repeat="x in PREFIX" value="{{x.prefixcd}}">{{x.thanm}}</option>
                                        </select>*@
                                    {{LIST_PHR_ADD.PHR_PREFIX_ID}}
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;">
                                    @*<input class="form-control inline" ng-model="LIST_PHR_ADD.PHR_NAME" style="font-family:'Taviraj';font-size:20px;" type="text" />*@
                                    {{LIST_PHR_ADD.PHR_NAME}}
                                </td>
                            </tr>
                            <tr>
                                <td style="width:20%">
                                    เลขบัตรประจำตัวประชาชน
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;" colspan="4">
                                    @*<input class="form-control inline" ng-model="LIST_PHR_ADD.PHR_CTZNO" style="font-family:'Taviraj';font-size:20px;" type="text" />*@
                                    {{LIST_PHR_ADD.PHR_CTZNO}}
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    ใบอนุญาตประกอบวิชาชีพ
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;" colspan="4"></td>
                            </tr>
                            <tr>
                                <td>
                                    เภสัชกรรมเลขที่
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;">
                                    @*<input class="form-control inline" ng-model="LIST_PHR_ADD.PHR_TEXT_NUM" style="font-family:'Taviraj';font-size:20px;" type="text" />*@
                                    {{LIST_PHR_ADD.PHR_TEXT_NUM}}
                                </td>
                            </tr>
                        </table>
                        <br />
                        @*<input type="button" style="font-size:20px;width:100px" value="เพิ่ม" ng-click="BTN_ADD_PHR(LIST_PHR_ADD)" />*@
                        <div class="row">
                            <div class="col-sm-12">
                                <div class="card" style=" border-top: 10px solid #F9D027;">
                                    <table width="100%" style="font-family:'Taviraj'">
                                        <thead>
                                            <tr>
                                                <td>เภสัชกรชั้น</td>
                                                <td>ชื่อ-นามสกุล</td>
                                                <td>เลขบัตรประจำตัวประชาชน</td>
                                                <td>ใบอนุญาตประกอบวิชาชีพเภสัชกรรมเลขที่</td>

                                            </tr>
                                        </thead>
                                        <tbody>
                                            <tr ng-repeat="data in DATA_PHR_SHOW">
                                                <td>{{data.PHR_LEVEL}}</td>
                                                <td>{{data.PHR_NAME}}</td>
                                                <td>{{data.PHR_CTZNO}}</td>
                                                <td>{{data.PHR_TEXT_NUM}}</td>
                                            </tr>
                                        </tbody>
                                    </table>
                                </div>
                            </div>
                        </div>
                        <div style="font-size:20px;">เป็นผู้ควบคุมตามมาตรา ๕๓ แห่งพระราชบัญญัติวัตถุที่ออกฤทธิ์ต่อจิตและประสาท พ.ศ. ๒๕๕๙</div>
                        <br />
                        <h2>๔. ข้อมูลสถานที่เก็บ (กรณีเป็นสถานที่คนละแห่งกับสถานที่ตาม ๓)</h2>
                        <table style="width:50%">
                            <tr>
                                <td>
                                    ณ สถานที่ชื่อ
                                </td>
                                <td>

                                    @*<select class="form-control selectpicker" data-live-search="true" title="-- Please select --" ng-model="LIST_LCN.LOCATION_SELECT" ng-change="getdetails(LIST_LCN.LOCATION_SELECT)">
                                        @*<option value="">--กรุณาเลือก--</option>*@
                                    @*<option ng-repeat="x in REF_LOCATION_KEEP" value="{{x.IDA}}">{{x.thanameplace}}</option>
                                        </select>*@
                                    {{LIST_LCN.LOCATION_SELECT}}
                                </td>
                            </tr>
                            <tr>
                                <td style="width:15%">
                                    เลขรหัสประจำบ้าน
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;">
                                    <label>{{LIST_LABEL.HOUSENO}}</label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    อยู่เลขที่
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;">
                                    <label>{{LIST_LABEL.fulladdr}}</label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    โทรศัพท์
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;">
                                    <label>{{LIST_LABEL.tel}}</label>
                                </td>
                            </tr>
                            <tr style="font-size: 20px;">
                                <td>
                                    โทรศัพท์มือถือ
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;">
                                    <label>{{LIST_LABEL.Mobile}}</label>
                                </td>
                            </tr>
                        </table>


                        <br />
                        @*<input type="button" style="font-size:20px;width:100px" value="เพิ่ม" ng-click="BTN_ADD_KEEP(LIST_LABEL,LIST_LCN.LOCATION_SELECT)" />*@
                        <div class="col-sm-12">
                            <div class="card" style=" border-top: 10px solid #F9D027;">
                                <table width="100%" style="font-family:'Taviraj'">
                                    <thead>
                                        <tr>
                                            <td>ชื่อสถานที่เก็บ</td>
                                            <td>อยู่เลขที่</td>
                                        </tr>
                                    </thead>
                                    <tbody>
                                        <tr ng-repeat="data in DATA_KEEP_SHOW">
                                            <td>{{datas.thanameplace}}</td>
                                            <td>{{datas.fulladdr}}</td>
                                        </tr>
                                    </tbody>
                                </table>
                            </div>
                        </div>
                        <br />
                        <br />

                        <div style="font-size:20px;"><strong>๕. พร้อมกับคำขอนี้ข้าพเจ้าได้แนบเอกสารหรือหลักฐานต่างๆ มาด้วย คือ</strong></div>
                        <div style="margin-left:5%;font-size:20px;"><strong>๕.๑ <u>กรณีขอรับใบอนุญาต (กรณีรายใหม่)</u></strong></div>
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

                        <div style="margin-left:5%;font-size:20px;"><strong>๕.๒ <u>กรณีขอต่ออายุใบอนุญาต</u></strong></div>
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
                        <div style="margin-left:5%;font-size:20px;"><strong>๕.๓ <u>กรณีขอรับใบแทนใบอนุญาต</u></strong></div>
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
                        <br />

                        <div style="margin-left:5%;font-size:20px;"> หมายเหตุ : (๑) ให้ขีดเลือกข้อความในช่อง ☐/〇 ให้ตรงตามที่ประสงค์จะดำเนินการ</div>
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

                <div ng-show="LIST_LCN.PROCESS == '128'">
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
                            <strong>ใบอนุญาตผลิตวัตถุออกฤทธิ์ในประเภท ๓ หรือประเภท ๔</strong>
                        </h2>
                        @*process =127,128 *@
                        <table style="width:70%; font-size:20px;margin:auto;text-align:center">
                            <tr>
                                <td>
                                    <strong>สำหรับผลิต</strong>
                                </td>
                                <td>
                                    <input type="radio" name="gender" ng-model="LIST_LCN.PROCESS" value="127" id="rdl_CHK_SELL_TYPE" disabled="disabled" /> <strong>วัตถุออกฤทธิ์ในประเภท ๓</strong>
                                </td>
                                <td>
                                    <input type="radio" name="gender" ng-model="LIST_LCN.PROCESS" value="128" id="rdl_CHK_SELL_TYPE" disabled="disabled" /> <strong>วัตถุออกฤทธิ์ในประเภท ๔</strong>
                                </td>
                            </tr>
                            <tr>
                                <td style="font-size:16px" colspan="3">
                                    <strong>(คำขอ ๑ ฉบับ ให้ยื่นขอได้เพียงหนึ่งประเภทเท่านั้น)</strong>
                                </td>
                            </tr>
                        </table>

                        <table style="width:100%; font-size:20px;">
                            <tr>
                                <td style="width:20%">
                                    <input type="checkbox" name="gender" disabled="disabled" ng-checked="true" /> <strong>ขอรับใบอนุญาต</strong>
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
                                    <input type="checkbox" name="gender" disabled="disabled" /> <strong>ขอรับใบแทนใบอนุญาต</strong>
                                </td>
                                <td>
                                    เนื่องจากใบอนุญาต
                                </td>
                                <td>
                                    <input class="checkbox" type="checkbox" disabled="disabled" /> <strong>สูญหาย</strong>
                                </td>
                                <td>
                                    <input class="checkbox" type="checkbox" disabled="disabled" /> <strong>ถูกทำลายหรือลบเลือนในสาระสำคัญ</strong>
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

                                    {{LIST_LCN.dalcn.WRITE_AT}}
                                </td>
                            </tr>
                            <tr>
                                <td style="text-align:right;width:100px">
                                    วันที่
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;">

                                    {{LIST_LCN.dalcn.WRITE_DATE}}
                                </td>
                            </tr>

                        </table>
                        <br />

                        <h2 style="font-size:24px;">
                            <strong>๑. ข้อมูลผู้ขอรับใบอนุญาต</strong>
                        </h2>
                        <table style="width:90%">
                            <tr>
                                <td style="font-size:20px;" width="40%">
                                    ข้าพเจ้า (ชื่อบุคคล/นิติบุคคล)
                                </td>
                                <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;" colspan="6">
                                    <label>{{LIST_LCN.thanm}}</label>
                                </td>
                            </tr>
                            <tr>
                                <td style="font-size:20px;">
                                    เลขประจำตัวประชาชน
                                </td>

                                <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;" colspan="6">
                                    <label>{{LIST_LCN.CITIZEN_AUTHORIZE}}</label>
                                </td>
                            </tr>
                            <tr>
                                <td style="font-size:20px;">
                                    หรือบัตรประจำตัวอื่นที่ทางราชการออกให้ คือ
                                </td>
                                <td style="font-size:20px;width:20%;border-bottom:dotted;border-bottom-width:thin;"></td>
                                <td style="font-size:20px;width:5%">
                                    เลขที่
                                </td>
                                <td style="font-size:20px ;width:15%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"></td>
                                <td style="font-size:20px;">
                                    (กรณีไม่ใช่ผู้มีสัญชาติไทย)
                                </td>
                            </tr>
                            <tr>
                                <td style="font-size:20px;">
                                    หรือทะเบียนนิติบุคคล/บัตรประจำตัวผู้เสียภาษี เลขที่
                                </td>
                                <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;" colspan="6">
                                    <label>{{LIST_LCN.IDENTIFY}}</label>
                                </td>
                            </tr>
                            <tr>
                                <td style="font-size:20px;">
                                    เลขรหัสประจำบ้าน
                                </td>
                                <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;" colspan="6">
                                    <label>{{LIST_LCN.HOUSENO}}</label>
                                </td>
                            </tr>
                            <tr>
                                <td style="font-size:20px;">
                                    อยู่เลขที่
                                </td>
                                <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;" colspan="6">
                                    <label>{{LIST_LCN.fulladdr3}}</label>
                                </td>
                            </tr>
                            <tr>
                                <td style="font-size:20px;">
                                    โทรศัพท์/มือถือ
                                </td>
                                <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;" colspan="6">
                                    <label>{{LIST_LCN.tel}}</label>
                                </td>
                            </tr>
                            <tr>
                                <td style="font-size:20px;">
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
                                <td style="font-size:20px;" width="40%">
                                    ข้าพเจ้า
                                </td>
                                <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;" colspan="6">
                                    <label>{{LIST_LCN.BSN_THAIFULLNAME}}</label>
                                </td>
                            </tr>
                            <tr>
                                <td style="font-size:20px;">
                                    เลขประจำตัวประชาชน
                                </td>
                                <td style="text-align:left;width:30%;">
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
                                </td>
                            </tr>
                            <tr>
                                <td style="font-size:20px;">
                                    หรือบัตรประจำตัวอื่นที่ทางราชการออกให้ คือ
                                </td>
                                <td style="font-size:20px;width:20%;border-bottom:dotted;border-bottom-width:thin;">
                                    <label>{{LIST_LCN.BSN_THAIFULLNAME}}</label>
                                </td>
                                <td style="font-size:20px;width:5%">
                                    เลขที่
                                </td>
                                <td style="font-size:20px ;width:15%;text-align:center;border-bottom:dotted;border-bottom-width:thin;">
                                </td>
                                <td style="font-size:20px;">
                                    (กรณีไม่ใช่ผู้มีสัญชาติไทย)
                                </td>
                            </tr>
                            <tr>
                                <td style="font-size:20px;">
                                    หรือทะเบียนนิติบุคคล/บัตรประจำตัวผู้เสียภาษี เลขที่
                                </td>
                                <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;" colspan="6">
                                    <label>{{LIST_LCN.BSN_IDENTIFY}}</label>
                                </td>
                            </tr>
                            <tr>
                                <td style="font-size:20px;">
                                    เลขรหัสประจำบ้าน
                                </td>
                                <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;" colspan="6">
                                    <label>{{LIST_LCN.BSN_HOUSENO}}</label>
                                </td>
                            </tr>
                            <tr>
                                <td style="font-size:20px;">
                                    อยู่เลขที่
                                </td>
                                <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;" colspan="6">
                                    <label>{{LIST_LCN.BSN_FULL_ADDR}}</label>
                                </td>
                            </tr>
                            <tr>
                                <td style="font-size:20px;">
                                    โทรศัพท์/มือถือ
                                </td>
                                <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;" colspan="6">
                                    <label>{{LIST_LCN.BSN_TELEPHONE}}</label>
                                </td>
                            </tr>
                            <tr>
                                <td style="font-size:20px;" colspan="2">
                                    โดยได้รับอนุญาตนำสั่งยาแผนปัจจุบันเข้ามาในราชอาณาจักร เลขที่
                                </td>
                                <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;" colspan="2">
                                    <label>{{LIST_HEAD_LCN.HEAD_LCNNO_NCT}}</label>
                                </td>
                                <td style="font-size:20px;">
                                    ตามกฎหมายว่าด้วยยา
                                </td>
                            </tr>
                        </table>

                        <div style="font-size:20px;"><strong>๓. ข้อมูลสถานที่ผลิต</strong></div>
                        <table style="width:100%;font-size:20px;">
                            <tr>
                                <td>
                                    ณ สถานที่ชื่อ
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;">
                                    <label>{{LIST_LCN.thanameplace}}</label>
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

                        <table style="width:100%;font-size:20px;">
                            <tr>
                                <td style="width:25%">
                                    มีความประสงค์ขอรับอนุญาตผลิตวัตถุออกฤทธิ์ในหมวด
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;" colspan="3">
                                    @*<input class="form-control inline" ng-model="LIST_LCN.dalcn.CATEGORY_DRUG" style="font-family:'Taviraj';font-size:20px;" type="text" />*@
                                        {{LIST_LCN.dalcn.CATEGORY_DRUG}}
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    โดยได้รับอนุญาตให้ผลิตยาแผนปัจจุบันเลขที่
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;">
                                    <label>{{LIST_HEAD_LCN.HEAD_LCNNO_NCT}}</label>
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


                        <table style="font-size:20px;width:100%">
                            <tr>
                                <td style="width:20%">
                                    โดยมีเภสัชกรชั้น
                                </td>
                                <td style="width:10%;border-bottom:dotted;border-bottom-width:thin;">
                                    @*<input class="form-control inline" ng-model="LIST_PHR_ADD.PHR_LEVEL" style="font-family:'Taviraj';font-size:20px;" type="text" />*@
                                    {{LIST_PHR_ADD.PHR_LEVEL}}
                                </td>
                                <td style="text-align:center">
                                    ชื่อ
                                </td>
                                <td style="width:10%;border-bottom:dotted;border-bottom-width:thin;">
                                    @*<select class="form-control selectpicker" data-live-search="true" title="-- Please select --" ng-model="LIST_PHR_ADD.PHR_PREFIX_ID">
                                        @*<option value="0">--กรุณาเลือก--</option>*@
                                    @*<option ng-repeat="x in PREFIX" value="{{x.prefixcd}}">{{x.thanm}}</option>
                                        </select>*@
                                    {{LIST_PHR_ADD.PHR_PREFIX_ID}}
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;">
                                    @*<input class="form-control inline" ng-model="LIST_PHR_ADD.PHR_NAME" style="font-family:'Taviraj';font-size:20px;" type="text" />*@
                                    {{LIST_PHR_ADD.PHR_NAME}}
                                </td>
                            </tr>
                            <tr>
                                <td style="width:20%">
                                    เลขบัตรประจำตัวประชาชน
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;" colspan="4">
                                    @*<input class="form-control inline" ng-model="LIST_PHR_ADD.PHR_CTZNO" style="font-family:'Taviraj';font-size:20px;" type="text" />*@
                                    {{LIST_PHR_ADD.PHR_CTZNO}}
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    ใบอนุญาตประกอบวิชาชีพ
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;" colspan="4"></td>
                            </tr>
                            <tr>
                                <td>
                                    เภสัชกรรมเลขที่
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;">
                                    @*<input class="form-control inline" ng-model="LIST_PHR_ADD.PHR_TEXT_NUM" style="font-family:'Taviraj';font-size:20px;" type="text" />*@
                                    {{LIST_PHR_ADD.PHR_TEXT_NUM}}
                                </td>
                            </tr>
                        </table>
                        <br />
                        @*<input type="button" style="font-size:20px;width:100px" value="เพิ่ม" ng-click="BTN_ADD_PHR(LIST_PHR_ADD)" />*@
                        <div class="row">
                            <div class="col-sm-12">
                                <div class="card" style=" border-top: 10px solid #F9D027;">
                                    <table width="100%" style="font-family:'Taviraj'">
                                        <thead>
                                            <tr>
                                                <td>เภสัชกรชั้น</td>
                                                <td>ชื่อ-นามสกุล</td>
                                                <td>เลขบัตรประจำตัวประชาชน</td>
                                                <td>ใบอนุญาตประกอบวิชาชีพเภสัชกรรมเลขที่</td>

                                            </tr>
                                        </thead>
                                        <tbody>
                                            <tr ng-repeat="data in DATA_PHR_SHOW">
                                                <td>{{data.PHR_LEVEL}}</td>
                                                <td>{{data.PHR_NAME}}</td>
                                                <td>{{data.PHR_CTZNO}}</td>
                                                <td>{{data.PHR_TEXT_NUM}}</td>
                                            </tr>
                                        </tbody>
                                    </table>
                                </div>
                            </div>
                        </div>
                        <div style="font-size:20px;">เป็นผู้ควบคุมตามมาตรา ๕๓ แห่งพระราชบัญญัติวัตถุที่ออกฤทธิ์ต่อจิตและประสาท พ.ศ. ๒๕๕๙</div>
                        <br />
                        <h2>๔. ข้อมูลสถานที่เก็บ (กรณีเป็นสถานที่คนละแห่งกับสถานที่ตาม ๓)</h2>
                        <table style="width:50%">
                            <tr>
                                <td>
                                    ณ สถานที่ชื่อ
                                </td>
                                <td>

                                    @*<select class="form-control selectpicker" data-live-search="true" title="-- Please select --" ng-model="LIST_LCN.LOCATION_SELECT" ng-change="getdetails(LIST_LCN.LOCATION_SELECT)">
                                        @*<option value="">--กรุณาเลือก--</option>*@
                                    @*<option ng-repeat="x in REF_LOCATION_KEEP" value="{{x.IDA}}">{{x.thanameplace}}</option>
                                        </select>*@
                                    {{LIST_LCN.LOCATION_SELECT}}
                                </td>
                            </tr>
                            <tr>
                                <td style="width:15%">
                                    เลขรหัสประจำบ้าน
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;">
                                    <label>{{LIST_LABEL.HOUSENO}}</label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    อยู่เลขที่
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;">
                                    <label>{{LIST_LABEL.fulladdr}}</label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    โทรศัพท์
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;">
                                    <label>{{LIST_LABEL.tel}}</label>
                                </td>
                            </tr>
                            <tr style="font-size: 20px;">
                                <td>
                                    โทรศัพท์มือถือ
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin;">
                                    <label>{{LIST_LABEL.Mobile}}</label>
                                </td>
                            </tr>
                        </table>


                        <br />
                        @*<input type="button" style="font-size:20px;width:100px" value="เพิ่ม" ng-click="BTN_ADD_KEEP(LIST_LABEL,LIST_LCN.LOCATION_SELECT)" />*@
                        <div class="col-sm-12">
                            <div class="card" style=" border-top: 10px solid #F9D027;">
                                <table width="100%" style="font-family:'Taviraj'">
                                    <thead>
                                        <tr>
                                            <td>ชื่อสถานที่เก็บ</td>
                                            <td>อยู่เลขที่</td>
                                        </tr>
                                    </thead>
                                    <tbody>
                                        <tr ng-repeat="data in DATA_KEEP_SHOW">
                                            <td>{{datas.thanameplace}}</td>
                                            <td>{{datas.fulladdr}}</td>
                                        </tr>
                                    </tbody>
                                </table>
                            </div>
                        </div>
                        <br />
                        <br />

                        <div style="font-size:20px;"><strong>๕. พร้อมกับคำขอนี้ข้าพเจ้าได้แนบเอกสารหรือหลักฐานต่างๆ มาด้วย คือ</strong></div>
                        <div style="margin-left:5%;font-size:20px;"><strong>๕.๑ <u>กรณีขอรับใบอนุญาต (กรณีรายใหม่)</u></strong></div>
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

                        <div style="margin-left:5%;font-size:20px;"><strong>๕.๒ <u>กรณีขอต่ออายุใบอนุญาต</u></strong></div>
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
                        <div style="margin-left:5%;font-size:20px;"><strong>๕.๓ <u>กรณีขอรับใบแทนใบอนุญาต</u></strong></div>
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
                        <br />

                        <div style="margin-left:5%;font-size:20px;"> หมายเหตุ : (๑) ให้ขีดเลือกข้อความในช่อง ☐/〇 ให้ตรงตามที่ประสงค์จะดำเนินการ</div>
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

                <div ng-show="LIST_LCN.PROCESS == '114'">
                    <div style="font-family:'Taviraj';font-size:24px;width:100%">
                        <div>
                            <p style="text-align: left;"><b>แบบ ย.ส. ๓-๑</b></p>
                        </div>
                        <div class="container">
                            <div class="row">
                                <div class="col-md-6">
                                    <table style="width :50%" align="left" border="1">
                                        <tr>
                                            <td style="width: 100%">
                                                เลขที่รับ<br />
                                                วันที่<br />
                                                <span style="padding-left: 30px;">(สำหรับเจ้าหน้าที่เป็นผู้กรอก)</span>
                                            </td>
                                        </tr>
                                    </table>
                                </div>
                                <div class="col-md-6 offset-md-4">
                                    <table style="width: 25%" align="right" border="1">
                                        <tr>
                                            <td style="width:100%; text-align:center"><img src="..." class="rounded float-end" alt="...">ที่ปิดรูปถ่ายของผู้ขอรับอนุญาตหรือผู้ดำเนินกิจการ ขนาด ๓ x ๔ ซม.</td>
                                        </tr>
                                    </table>
                                </div>
                            </div>
                        </div>
                        <br />
                        <div>
                            <p style="text-align: center; font-size: large">คำขอรับอนุญาต</p>
                            <p style="text-align: center; font-size: large">ผลิต นำเข้า ส่งออก จำหน่ายหรือมีไว้ครอบครองเพื่อจำหน่าย</p>
                            <p style="text-align: center; font-size: large">ซึ่งยาเสพติดให้โทษในประเภท ๓</p>
                            <hr style="width: 17%; border-color: black" />
                            <table style="width:100%">
                                <tr>
                                    <td style="text-align:right;width:90%">
                                        เขียนที่
                                    </td>
                                    <td style="width:40%;border-bottom:dotted;border-bottom-width:thin;">

                                        {{LIST_LCN.dalcn.WRITE_AT}}
                                    </td>
                                </tr>
                                <tr>
                                    <td style="text-align:right;width:100px">
                                        วันที่
                                    </td>
                                    <td style="border-bottom:dotted;border-bottom-width:thin;">

                                        {{LIST_LCN.dalcn.WRITE_DATE}}
                                    </td>
                                </tr>

                            </table>
                            <br />
                            <table style="width: 100%">
                                <tr>
                                    <td style="width: 2%"></td>
                                    <td style="width: 30%"><b>๑. ข้าพเจ้า</b>&nbsp; (ชื่อบุคคล/นิติบุคคลผู้ขอรับใบอนุญาต)</td>
                                    <td style="border-bottom:dotted;border-bottom-width:thin;">{{LIST_LCN.thanm}}</td>
                                </tr>
                                <tr>
                                    <td style="width: 2%"></td>
                                    <td style="width: 30%">เลขที่บัตรประชาชน หรือทะเบียนนิติบุคคลเลขที่</td>
                                    <td style="border-bottom:dotted;border-bottom-width:thin;">{{LIST_LCN.IDENTIFY}}</td>
                                </tr>
                            </table>
                            <table style="width: 100%">
                                <tr>
                                    <td style="width: 2%"></td>
                                    <td style="font-size:20px">
                                        อยู่เลขที่
                                    </td>
                                    <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;" colspan="6">
                                        <label>{{LIST_LCN.fulladdr3}}</label>
                                    </td>
                                </tr>
                                <tr>
                                    <td style="width: 2%"></td>
                                    <td style="font-size:20px">
                                        โทรศัพท์/มือถือ
                                    </td>
                                    <td style="font-size:20px;border-bottom:dotted;border-bottom-width:thin;" colspan="6">
                                        <label>{{LIST_LCN.tel}}</label>
                                    </td>
                                </tr>
                            </table>
                            <table style="width: 100%">
                                <tr>
                                    <td style="width: 2%"></td>
                                    <td style="width: 98%" colspan="2"><b>๒. ซึ่งมีผู้ได้รับมอบหมายให้ดำเนินกิจการของนิติบุคคลผู้ขอรับใบอนุญาตกรณีผู้ขอรับใบอนุญาตเป็นนิติบุคคล</b></td>
                                </tr>
                                <tr>
                                    <td style="width: 2%"></td>
                                    <td>ชื่อ</td>
                                    <td style="width: 98%;border-bottom:dotted;border-bottom-width:thin;">{{LIST_LCN.BSN_THAIFULLNAME}}</td>
                                </tr>
                            </table>
                            <table style="width: 100%">
                                <tr>
                                    <td style="width: 2%"></td>
                                    <td style="width: 20%">เลขที่บัตรประชาชน</td>
                                    <td style="width: 46%">
                                        <form>
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
                                    </td>
                                    <td>
                                        อายุ
                                    </td>
                                    <td style="text-align: left; width: 20%;border-bottom:dotted;border-bottom-width:thin;" align="center">
                                        <label>{{LIST_LCN.AGE}}</label>ปี
                                    </td>
                                    <td>
                                        สัญชาติ
                                    </td>
                                    <td style="text-align:left;width:10%;">
                                        <input class="form-control inline" ng-model="LIST_LCN.dalcn.NATION" style="font-family:'Taviraj';" type="text" />
                                    </td>
                                </tr>
                            </table>
                            <table style="width: 100%">
                                <tr>
                                    <td style="width: 2%"></td>
                                    <td style="width:200px">
                                        อยู่เลขที่
                                    </td>
                                    <td style="text-align:left;border-bottom:dotted;border-bottom-width:thin;" colspan="3">
                                        <label>{{LIST_LCN.BSN_FULL_ADDR}}</label>
                                    </td>

                                </tr>
                                <tr>
                                    <td style="width: 2%"></td>
                                    <td>
                                        โทรศัพท์
                                    </td>
                                    <td style="text-align:left;border-bottom:dotted;border-bottom-width:thin;">
                                        <label>{{LIST_LCN.BSN_TELEPHONE}}</label>
                                    </td>
                                </tr>
                                <tr>
                                    <td style="width: 2%"></td>
                                    <td>
                                        โทรศัพท์มือถือ
                                    </td>
                                    <td style="text-align:left;border-bottom:dotted;border-bottom-width:thin;">
                                        <label>{{LIST_LCN.BSN_FAX}}</label>
                                    </td>
                                </tr>
                            </table>
                            <table style="width: 100%">
                                <tr>
                                    <td style="width: 2%"></td>
                                    <td style="width: 98%"><b>๓. ขอรับใบอนุญาต</b>(ให้ขีดเลือกข้อความในช่องให้ตรงตามความประสงค์จะขออนุญาตเพียงช่องเดียว)</td>
                                </tr>
                            </table>

                            <table style=" font-size:20px;width:100%;margin-left:10%">

                                <tr>
                                    <td>
                                        <form name="rdl_gmp">


                                            <label><input type="radio" ng-model="LIST_LCN.PROCESS" id="Rdl_gmpt" value="114" disabled> ผลิตซึ่งยาเสพติดให้โทษในประเภท ๓</label><br />
                                            <label><input type="radio" ng-model="LIST_LCN.PROCESS" id="Rdl_gmpt" value="116" disabled> นำเข้าซึ่งยาเสพติดให้โทษในประเภท ๓</label><br />
                                            <label><input type="radio" ng-model="LIST_LCN.PROCESS" id="Rdl_gmpt" value="117" disabled> ส่งออกซึ่งยาเสพติดให้โทษในประเภท ๓</label><br />
                                            <label><input type="radio" ng-model="LIST_LCN.PROCESS" id="Rdl_gmpt" value="115" disabled> จำหน่ายหรือมีไว้ในครอบครองเพื่อจำหน่ายซึ่งยาเสพติดให้โทษในประเภท ๓</label>
                                        </form>
                                    </td>

                                </tr>
                            </table>



                            <table style="width: 100%">
                                <tr>
                                    <td style="width: 2%"></td>
                                    <td style="width: 98%">ณ สถานที่ ชื่อ</td>
                                    <td style="border-bottom:dotted;border-bottom-width:thin;">{{LIST_LCN.thanameplace}}</td>
                                </tr>
                                <tr>
                                    <td>
                                        ตั้งอยู่เลขที่
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
                            </table>
                            <table style="font-size:20px;width:100%">
                                <tr>
                                    <td style="width:20%">
                                        โดยมีเภสัชกรชั้น
                                    </td>
                                    <td style="width:10%;border-bottom:dotted;border-bottom-width:thin;">
                                        @*<input class="form-control inline" ng-model="LIST_PHR_ADD.PHR_LEVEL" style="font-family:'Taviraj';font-size:20px;" type="text" />*@
                                        {{LIST_PHR_ADD.PHR_LEVEL}}
                                    </td>
                                    <td style="text-align:center">
                                        ชื่อ
                                    </td>
                                    <td style="width:10%;border-bottom:dotted;border-bottom-width:thin;">
                                        @*<select class="form-control selectpicker" data-live-search="true" title="-- Please select --" ng-model="LIST_PHR_ADD.PHR_PREFIX_ID">
                                            @*<option value="0">--กรุณาเลือก--</option>*@
                                        @*<option ng-repeat="x in PREFIX" value="{{x.prefixcd}}">{{x.thanm}}</option>
                                            </select>*@
                                        {{LIST_PHR_ADD.PHR_PREFIX_ID}}
                                    </td>
                                    <td style="border-bottom:dotted;border-bottom-width:thin;">
                                        @*<input class="form-control inline" ng-model="LIST_PHR_ADD.PHR_NAME" style="font-family:'Taviraj';font-size:20px;" type="text" />*@
                                        {{LIST_PHR_ADD.PHR_NAME}}
                                    </td>
                                </tr>
                                <tr>
                                    <td style="width:20%">
                                        เลขบัตรประจำตัวประชาชน
                                    </td>
                                    <td style="border-bottom:dotted;border-bottom-width:thin;" colspan="4">
                                        @*<input class="form-control inline" ng-model="LIST_PHR_ADD.PHR_CTZNO" style="font-family:'Taviraj';font-size:20px;" type="text" />*@
                                        {{LIST_PHR_ADD.PHR_CTZNO}}
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        ใบอนุญาตประกอบวิชาชีพ
                                    </td>
                                    <td style="border-bottom:dotted;border-bottom-width:thin;" colspan="4"></td>
                                </tr>
                                <tr>
                                    <td>
                                        เภสัชกรรมเลขที่
                                    </td>
                                    <td style="border-bottom:dotted;border-bottom-width:thin;">
                                        @*<input class="form-control inline" ng-model="LIST_PHR_ADD.PHR_TEXT_NUM" style="font-family:'Taviraj';font-size:20px;" type="text" />*@
                                        {{LIST_PHR_ADD.PHR_TEXT_NUM}}
                                    </td>
                                </tr>
                            </table>
                            <br />
                            @*<input type="button" style="font-size:20px;width:100px" value="เพิ่ม" ng-click="BTN_ADD_PHR(LIST_PHR_ADD)" />*@
                            <div class="row">
                                <div class="col-sm-12">
                                    <div class="card" style=" border-top: 10px solid #F9D027;">
                                        <table width="100%" style="font-family:'Taviraj'">
                                            <thead>
                                                <tr>
                                                    <td>เภสัชกรชั้น</td>
                                                    <td>ชื่อ-นามสกุล</td>
                                                    <td>เลขบัตรประจำตัวประชาชน</td>
                                                    <td>ใบอนุญาตประกอบวิชาชีพเภสัชกรรมเลขที่</td>

                                                </tr>
                                            </thead>
                                            <tbody>
                                                <tr ng-repeat="data in DATA_PHR_SHOW">
                                                    <td>{{data.PHR_LEVEL}}</td>
                                                    <td>{{data.PHR_NAME}}</td>
                                                    <td>{{data.PHR_CTZNO}}</td>
                                                    <td>{{data.PHR_TEXT_NUM}}</td>
                                                </tr>
                                            </tbody>
                                        </table>
                                    </div>
                                </div>
                            </div>

                            <hr style="width: 100%; border-color: black" />
                            <p>เป็นผู้มีหน้าที่ควบคุมตามมาตรา ๒๑ แห่งพระราชบัญญัติยาเสพติดให้โทษ พ.ศ.๒๕๒๒</p>
                            <table style="width: 100%">
                                <tr>
                                    <td style="width: 2%"></td>
                                    <td style="width: 98%"><b>๕. พร้อมกับคำขอนี้ข้าพเจ้าได้แนบเอกสารหรือหลักฐานต่างๆ มาด้วย คือ</b></td>
                                </tr>
                                <tr>
                                    <td style="width: 2%"></td>
                                    <td style="width: 98%">(๑) สำเนาทะเบียนบ้านของผู้ขอรับใบอนุญาตหรือผู้ได้รับมอบหมายให้ดำเนินกิจการ</td>
                                </tr>
                                <tr>
                                    <td style="width: 2%"></td>
                                    <td style="width: 98%">(๒) สำเนาบัตรประชาชนของผู้ขอรับใบอนุญาตหรือผู้ได้รับมอบหมายให้ ดำเนินกิจการ</td>
                                </tr>
                                <tr>
                                    <td style="width: 2%"></td>
                                    <td style="width: 98%">(๓) รูปถ่ายของผู้ขอรับใบอนุญาตหรือผูู้ได้รับมอบหมายให้ดำเนินกิจการขนาด ๓ x ๔ เซนติเมตร จำนวน ๒ รูปซึ่งถ่ายไว้ไม่เกิน ๖ เดือน</td>
                                </tr>
                                <tr>
                                    <td style="width: 2%"></td>
                                    <td style="width: 98%">(๔) สำเนาหนังสือรับรองแสดงการจดทะเบียนเป็นนิติบุคคลซึ่งนายทะเบียนออกไว้ไม่เกิน ๖ เดือน</td>
                                </tr>
                                <tr>
                                    <td style="width: 2%"></td>
                                    <td style="width: 98%">(๕) หนังสือแสดงว่าผู้ได้รับมอบหมายให้ดำเนินกิจการของนิติบุคคลผู้ขอรับใบอนุญาตกรณีผู้ขอรับใบอนุญาตเป็นนิติบุคคล</td>
                                </tr>
                                <tr>
                                    <td style="width: 2%"></td>
                                    <td style="width: 98%">(๖) สำเนาใบอนุญาตประกอบวิชาชีพ</td>
                                </tr>
                                <tr>
                                    <td style="width: 2%"></td>
                                    <td style="width: 98%">(๗) สำเนาใบอนุญาตผลิตหรือขายยาแผนปัจจุบัน หรือใบอนุญาตนำหรือสั่งยาแผนปัจจุบันเข้ามาในราชอาณาจักรตามกฏหมายว่าด้วยยา แล้วแต่กรณี</td>
                                </tr>
                                <tr>
                                    <td style="width: 2%"></td>
                                    <td style="width: 98%">(๘) เอกสารหรือหลักฐานอื่นๆ(ถ้ามี)</td>
                                </tr>
                            </table>
                            <br /><br />


                            <table style="font-size:20px;width:70%;float:right">
                                <tr>
                                    <td style="width:10%;text-align:center">
                                        (ลายมือชื่อ)
                                    </td>
                                    <td style="width:20%;text-align:center;border-bottom:dotted;border-bottom-width:thin;"></td>
                                    <td style="text-align:left;width:40%">
                                        ผู้ขอรับใบอนุญาต / ผู้ได้รับมอบหมายให้ ดำเนินกิจการ
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right">
                                        (
                                    </td>
                                    <td style="width:50%;text-align:center;border-bottom:dotted;border-bottom-width:thin;">
                                        <label>{{LIST_LCN.BSN_THAIFULLNAME}}</label>
                                    </td>
                                    <td style="text-align:left">
                                        )
                                    </td>
                                </tr>
                            </table>

                        </div>
                    </div>
                </div>
                @*-------------------------------------------------------------------*@
            </div>
            <div class="part part-1-3 ic">
                <div class="card">
                    <table class="table">
                        <tr>
                            <td>
                                สถานะ
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <select style="font-family:'Taviraj';font-size:20px;" ng-model="STATUS_ID" class="form-control">
                                    <option ng-repeat="x in STAT_LIST" value="{{x.STATUS_ID}}">{{x.STATUS_NAME}}</option>
                                </select>
                            </td>
                        </tr>
                    </table>

                    <br />
                    <div align="center">
                        <input type="button" style="width:50%" class="btn btn-lg " ng-click="BTN_LCN_CONFIRM(STATUS_ID)" value="บันทึก" />
                    </div>
                    <br />
                    <div align="center">
                        <input type="button" style="width:50%" class="btn btn-lg " ng-click="BTN_BACK()" value="ย้อนกลับ" />
                    </div>
                    <br />
                    <div>

                    </div>

                </div>
            </div>

        </div>
    </div>
</div>