
<script type="text/javascript">

</script>
<script src="../Scripts_angular/CENTER_SV.js"></script>
<script src="../Scripts_angular/LCN_CTRL.js"></script>
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
</style>


<h1 style="text-align:right;font-size:24px;">
    <strong>แบบ ขย.๒</strong>
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
<div class="ic" ng-controller="LCN_CTRL" ng-app="ANGULAR_APP" ng-init="pageload()" ng-cloak="">
    <div class="title2">
        <table style="font-size:20px;width:95%;margin-top:10px;margin-left:10px" @*border="1"*@>
            <tr>
                <td style="text-align:left;width:20%">
                    เลขรับที่
                </td>

                <td colspan="3">
                    <label>{{LCN_LIST.RCVNO_DISPLAY}}</label>
                </td>
            </tr>
            <tr>
                <td style="text-align:left">
                    วันที่
                </td>

                <td colspan="3">
                    <label>{{LCN_LIST.RCV_DATE_DISPLAY}}</label>
                </td>
            </tr>
            <tr>
                <td style="text-align:left">
                    ลงชื่่อ

                </td>

                <td></td>
                <td style="text-align:right;width:25%">
                    ผู้รับคำขอ
                </td>
            </tr>
        </table>
    </div>
    <div style="clear:both"></div>
    <br />
    <br />
    <div class="ic" ng-controller="LCN_CTRL" ng-app="ANGULAR_APP" ng-init="pageload()" ng-cloak="">
        <h2 style="text-align:center;font-size:24px;">
            <strong>คำขออนุญาตขายยาแผนปัจจุบัน</strong>
        </h2>
        <h2 style="text-align:center;font-size:24px;">
            <strong>เฉพาะยาบรรจุเสร็จที่ไม่ใช่ยาอันตรายหรือยาควบคุม</strong>
        </h2>
        @*process =102 *@


        <div style="text-align:center">
            <hr style=" border-top:2px dotted ;width:17%" />
        </div>

        <table style="width:100%; font-size:20px">
            <tr>
                <td style="text-align:right;width:90%">
                    เขียนที่
                </td>
                <td style="width:40%">
                    <input class="form-control inline" ng-model="LIST_LCN.dalcn.WRITE_AT" style="font-family:'TH SarabunPSK';font-size:20px;" type="text" />
                </td>
            </tr>
            <tr>
                <td style="text-align:right;width:100px">
                    วันที่
                </td>
                <td>
                    <md-datepicker ng-model="LIST_LCN.dalcn.WRITE_DATE" md-placeholder="Enter date"
                                   input-aria-describedby="datepicker-description"
                                   input-aria-labelledby="datepicker-header ">
                    </md-datepicker>
                </td>
            </tr>

        </table>
        <br />
        <table style="width:100%;" @*border="1"*@>
            <tr>
                <td style="font-size:20px" width="5%">
                    ข้าพเจ้า
                </td>
                <td style="text-align:center; font-size:20px">
                    <label>{{LIST_LCN.thanm}}</label>
                </td>
            </tr>
            <tr>
                <td></td>
                <td style="text-align:center;font-size:16px">
                    (ชื่อผู้ขออนุญาต)
                </td>
            </tr>
        </table>

        <br />

        <table style=" font-size:20px;width:100%" @*border="1"*@ ;>
            <tr>
                <td>
                    ซึ่งมีผู้ดำเนินกิจการ ชื่อ
                </td>
                <td style="text-align:left;width:2000px">
                    <label>{{LIST_LCN.BSN_THAIFULLNAME}}</label>
                </td>
                <td colspan="4">
                    (เฉพาะกรณีนิติบุคคล)
                </td>
            </tr>
            <tr>
                <td style="width:20%;">
                    เลขบัญประจำตัวประชาชน
                </td>
                <td style="text-align:left;width:30%;">
                    @*<label>{{LIST_LCN.BSN_IDENTIFY}}</label>*@
                    <form action="javascript:void(0)">
                        <table>
                            <tr>
                                <td>
                                    <input class="form-control inline" ng-model="LIST_LCN.BSN_IDENTIFY" id="txt_bsn_identify" style="font-family:'TH SarabunPSK';font-size:20px;" type="text" />
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
                <td style="text-align:left;width:20%;" align="center">
                    <label>{{LIST_LCN.AGE}}</label>
                </td>
                <td>
                    ปี
                </td>
                <td>
                    สัญชาติ
                </td>
                <td style="text-align:left;width:10%;">
                    <input class="form-control inline" ng-model="LIST_LCN.dalcn.NATION" style="font-family:'TH SarabunPSK';font-size:20px;" type="text" />
                </td>

            </tr>
        </table>
        <table style="font-size:20px;width:100%" @*border="1"*@>
            <tr>
                <td style="width:200px">
                    อยู่เลขที่
                </td>
                <td style="text-align:left" colspan="3">
                    <label>{{LIST_LCN.BSN_FULL_ADDR}}</label>
                </td>

            </tr>
            <tr>
                <td>
                    โทรศัพท์
                </td>
                <td style="text-align:left">
                    <label>{{LIST_LCN.BSN_TELEPHONE}}</label>
                </td>
            </tr>
            <tr>
                <td>
                    โทรศัพท์มือถือ
                </td>
                <td style="text-align:left">
                    <label>{{LIST_LCN.BSN_FAX}}</label>
                </td>
            </tr>
            <tr>
                <td>
                    E-mail
                </td>
                <td>
                    <input class="form-control inline" ng-model="LIST_LCN.dalcn.Email" style="font-family:'TH SarabunPSK';font-size:20px;" type="text" />
                </td>
            </tr>
        </table>
        <br />
        <br />
        <div style=" font-size:20px;margin-left:10px">ขอรับใบอนุญาตขายยาแผนปัจจุบันเฉพาะยาบรรจุเสร็จที่ไม่ใช่ยาอันตรายหรือยาควบคุมพิเศษ โดยมีสถานที่ขายยา</div>
        <table style=" font-size:20px;width:100%">
            <tr style="text-align:center">
                <td style="text-align:left;width:10%">
                    ชื่อ
                </td>
                <td style="text-align:left">
                    <label>{{LIST_LCN.thanameplace}}</label>
                </td>
            </tr>
            <tr>
                <td style="width:10%;">
                    อยู่เลขที่
                </td>
                <td>
                    <label>{{LIST_LCN.fulladdr3}}</label>
                </td>
            </tr>
            <tr>
                <td style="width:10%;">
                    โทรศัพท์
                </td>
                <td>
                    <label>{{LIST_LCN.tel}}</label>
                </td>
            </tr>
            <tr>
                <td style="width:10%;">
                    โทรศัพท์มือถือ
                </td>
                <td>
                    <label>{{LIST_LCN.fax}}</label>
                </td>
            </tr>
        </table>
        <br />
        <br />

        <table style="width:50%">
            <tr>
                <td style="font-size:20px">
                    ชื่อสถานที่เก็บ ( 1 ) :
                </td>
                <td style="font-size:20px">
                    <input style="width:100%" />
                </td>
            </tr>
            <tr style="font-size:20px">
                <td>
                    อยู่เลขที่
                </td>
                <td>
                    <input style="width:100%" />
                </td>
            </tr>
            <tr style="font-size:20px">
                <td>
                    โทรศัพท์
                </td>
                <td>
                    <input style="width:100%" />
                </td>
            </tr>
            <tr style="font-size:20px">
                <td>
                    โทรศัพท์มือถือ
                </td>
                <td>
                    <input style="width:100%" />
                </td>
            </tr>
        </table>
        <br />
        <input type="button" style="font-size:20px;width:100px" value="เพิ่ม" />
        <input type="button" style="font-size:20px;width:100px;margin-left:10px" value="ลบ" />
        <br />
        <br />
        @*<table style="font-size:20px;width:100%" >
            <tr>
                <td style="width:20%">
                    โดยมีเภสัชกรชั้น
                </td>
                <td style="width:10%">
                    <input class="form-control inline" ng-model="LIST_LCN.DALCN_PHR.PHR_LEVEL" style="font-family:'TH SarabunPSK';font-size:20px;" type="text" />
                </td>
                <td style="text-align:center">
                    ชื่อ
                </td>
                <td style="width:10%">
                    <select class="dropdown" ng-model="LIST_LCN.DALCN_PHR.PHR_PREFIX_ID" id="ddl_prefix1">
                        <option value="0">--กรุณาเลือก--</option>
                        <option ng-repeat="x in PREFIX" value="{{x.IDA}}">{{x.prefixnm}}</option>
                    </select>
                </td>
                <td>
                    <input class="form-control inline" ng-model="LIST_LCN.DALCN_PHR.PHR_NAME" style="font-family:'TH SarabunPSK';font-size:20px;" type="text" />
                </td>
            </tr>
            <tr>
                <td style="width:20%">
                    เลขบัตรประจำตัวประชาชน
                </td>
                <td colspan="4">
                    <input class="form-control inline" ng-model="LIST_LCN.DALCN_PHR.PHR_CTZNO" style="font-family:'TH SarabunPSK';font-size:20px;" type="text" />
                </td>
            </tr>
            <tr>
                <td>
                    ใบอนุญาตประกอบวิชาชีพ
                </td>
                <td colspan="4">
                    <input class="form-control inline" ng-model="LIST_LCN.DALCN_PHR.PHR_TEXT_NUM" style="font-family:'TH SarabunPSK';font-size:20px;" type="text" />
                </td>
            </tr>
            <tr>
                <td>
                    เภสัชกรรมเลขที่
                </td>
            </tr>
        </table>*@
        <hr />
        <table style="font-size:20px;width:100%" @*border="1"*@>
            <tr>
                <td style="width:10%">
                    <input class="checkbox" type="radio" id="rdl_type" value="1" />
                </td>
                <td style="width:20%">
                    โดยมี ผู้ประกอบวิชาชีพ
                </td>
                <td></td>
            </tr>
            <tr>
                <td style="width:10%">
                    ชื่อ
                </td>
                <td style="width:10%">
                    <select class="dropdown" ng-model="LIST_LCN.DALCN_PHR.PHR_PREFIX_ID" id="ddl_prefix2">
                        <option value="0">--กรุณาเลือก--</option>
                        <option ng-repeat="x in PREFIX" value="{{x.prefixcd}}">{{x.thanm}}</option>
                    </select>
                </td>
                <td>
                    <input class="form-control inline" ng-model="LIST_LCN.DALCN_PHR.PHR_NAME" style="font-family:'TH SarabunPSK';font-size:20px;" type="text" />
                </td>
            </tr>
            <tr>
                <td style="width:10%" colspan="2">
                    เลขบัตรประจำตัวประชาชน
                </td>
                <td>
                    <input class="form-control inline" ng-model="LIST_LCN.DALCN_PHR.PHR_CTZNO" style="font-family:'TH SarabunPSK';font-size:20px;" type="text" />
                </td>

            </tr>
        </table>
        <table style="font-size:20px;width:100%" @*border="1"*@>
            <tr>
                <td style="width:30%">
                    ใบอนุญาตประกอบวิชาชีพ เลขที่
                </td>
                <td>
                    <input class="form-control inline" ng-model="LIST_LCN.DALCN_PHR.PHR_TEXT_JOB" style="font-family:'TH SarabunPSK';font-size:20px;" type="text" />

                </td>
                <td style="width:10%;text-align:center">
                    เลขที่
                </td>
                <td>
                    <input class="form-control inline" ng-model="LIST_LCN.DALCN_PHR.PHR_TEXT_NUM" style="font-family:'TH SarabunPSK';font-size:20px;" type="text" />
                </td>
            </tr>
        </table>

        <table style="font-size:20px;width:100%" @*border="1"*@>
            <tr>
                <td style="width:10%">
                    <input class="checkbox" type="radio" id="rdl_type" value="2" />
                </td>
                <td colspan="3">
                    ผู้ได้รับการอบรมตามมาตรา ๔๘ แห่งพระราชบัญญัติยา (ฉบับที่ ๓) พ.ศ. ๒๕๒๒
                </td>

            </tr>
            <tr>
                <td style="width:10%">
                    ชื่อ
                </td>
                <td style="width:20%">
                    <select class="dropdown" ng-model="LIST_LCN.DALCN_PHR.PHR_PREFIX_ID" id="ddl_prefix3">
                        <option value="0">--กรุณาเลือก--</option>
                        <option ng-repeat="x in PREFIX" value="{{x.prefixcd}}">{{x.thanm}}</option>
                    </select>
                </td>
                <td>
                    <input class="form-control inline" ng-model="LIST_LCN.DALCN_PHR.PHR_NAME" style="font-family:'TH SarabunPSK';font-size:20px;" type="text" />
                </td>
            </tr>
            <tr>
                <td style="width:20%" colspan="2">
                    เลขบัตรประจำตัวประชาชน
                </td>
                <td>
                    <input class="form-control inline" ng-model="LIST_LCN.DALCN_PHR.PHR_CTZNO" style="font-family:'TH SarabunPSK';font-size:20px;" type="text" />
                </td>

            </tr>
            <tr>
                <td colspan="3">
                    หนังสือรับรองการอบรมตามมาตรา ๔๘ แห่งพระราชบัญิญัติยา (ฉบับที่ ๓) พ.ศ. ๒๕๒๒ เลขที่
                </td>
                <td>
                    <input class="form-control inline" ng-model="LIST_LCN.DALCN_PHR.PHR_CERTIFICATE_TRAINING" style="font-family:'TH SarabunPSK';font-size:20px;" type="text" />
                </td>
            </tr>
        </table>
        <br />

        <table style="font-size:16px;width:100%" @*border="1"*@>
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
                <td>
                    <input class="form-control inline" ng-model="LIST_LCN.DALCN_PHR.PHR_TEXT_WORK_TIME" style="font-family:'TH SarabunPSK';font-size:20px;" type="text" />
                </td>
            </tr>
        </table>
        <br />














        <div style="font-size:20px">
            ข้าพเจ้าขอรับรองว่าในระยะเวลาสองปีก่อนยื่นคำำขอนี้ ข้าพเจ้าไม่เคยได้รับโทษจำำคุกโดยคำำพิพากษาถึงที่สุดหรือคำำสั่งที่ชอบด้วยกฎหมายให้จำำคุกในความผิดที่
            กฎหมายบัญญัติ ให้ถือเอาการกระทำำโดยทุจริตเป็นองค์ประกอบหรือในความผิดตามกฎหมายว่าด้วยยาเสพติดให้โทษ กฎหมายว่าด้วยวัตถุที่ออกฤทธิ์ต่อจิตและ
            ประสาท กฎหมายว่าด้วยการขายยาหรือพระราชบัญญัตินี้
            ข้าพเจ้าได้แนบหลักฐานมาด้วย คือ
        </div>
        <br />
        <div style="margin-left:10%;font-size:20px">(๑) รูปถ่ายของผู้ขออนุญาต ขนาด ๓ x ๔ เซนติเมตร จำำนวน ๓ รูป</div>
        <div style="margin-left:10%;font-size:20px">(๒) เอกสารแสดงการเป็นเจ้าของกิจการและหลักทรัพย์</div>
        <div style="margin-left:10%;font-size:20px">(๓) สำเนาทะเบียนบ้านของผู้ขออนุญาต (กรณีบุคคลธรรมดาเป็นผู้ขออนุญาต) หรือ ผู้ดำำเนินกิจการ (กรณีนิติบุคคลเป็นผู้ขออนุญาต)</div>
        <div style="margin-left:10%;font-size:20px">(๔) ใบรับรองของผู้ประกอบวิชาชีพเวชกรรมซึ่งรับรองว่าผู้ขออนุญาตไม่เป็นโรคตามมาตรา ๑๔ (๖) แห่งพระราชบัญญัติยา พ.ศ. ๒๕๑๐</div>
        <div style="margin-left:10%;font-size:20px">(๕) สัญญาระหว่างผู้ขออนุญาตและเภสัชกร ซึ่งรับจะเป็นผู้มีหน้าที่ปฏิบัติการของผู้ขออนุญาต</div>
        <div style="margin-left:10%;font-size:20px">(๖) สำเนาหรือรูปถ่ายใบอนุญาตประกอบวิชาชีพเภสัชกรรมของเภสัชกรทุกคน ซึ่งรับจะเป็นผู้มีหน้าที่ปฏิบัติการของผู้ขออนุญาต</div>
        <div style="margin-left:10%;font-size:20px">(๗) เอกสารแสดงว่าเป็นผู้ดำำเนินกิจการ (กรณีนิติบุคคลเป็นผู้ขออนุญาต)</div>
        <div style="margin-left:10%;font-size:20px">(๘) เอกสารอื่นๆ ถ้าจำำเป็น</div>
        <br />
        <br />
        <br />
        <table style="font-size:20px;width:40%;float:right">
            <tr>
                <td>
                    (ลายมือชื่อ)
                </td>
                <td style="width:50%;text-align:center"></td>
                <td style="text-align:left">
                    ผู้ขออนุญาต
                </td>
            </tr>
            <tr>
                <td>
                    (
                </td>
                <td style="width:50%;text-align:center">
                    <input class="form-control inline" ng-model="LIST_LCN.BSN_THAIFULLNAME" style="font-family:'TH SarabunPSK';font-size:20px;" type="text" />
                </td>
                <td style="text-align:left">
                    ตัวบรรจง)
                </td>
            </tr>
        </table>
    </div>
