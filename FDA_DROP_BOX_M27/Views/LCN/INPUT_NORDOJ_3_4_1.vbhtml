<script type="text/javascript">

</script>

<style>
    .title1 {
        width: 150px;
        height: 170px;
        /*background-color: aqua;*/
        text-align: center;
        border: solid;
        float: right;
    }

    .title2 {
        width: 400px;
        height: 120px;
        /*background-color:antiquewhite;*/
        text-align: center;
        border: solid;
        float: left;
    }

    .checkbox {
        width: 20px;
        height: 20px;
        margin-top: 1%;
        margin-right: 2%
    }

    .hr {
        width: 95%;
        height: 10px;
        background-color: black;
    }
</style>
<script src="../Scripts_angular/ANGULAR_APP.js"></script>
<script src="../Scripts_angular/CENTER_SV.js"></script>
<script src="../Scripts_angular/LCN_CTRL.js"></script>

<script type="text/javascript">
    $(document).ready(function () {
        $('select').selectpicker('refresh');
    })
</script>

<div class="ic" ng-controller="LCN_CTRL" ng-app="ANGULAR_APP" ng-init="pageload()" ng-cloak="">
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
                <td></td>
                <td style="width:10%">
                    <strong>ประจำปี พ.ศ.</strong>
                </td>
                <td></td>
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

        <table style="width:100%; font-size:20px;">
            <tr>
                <td style="text-align:right;width:90%">
                    เขียนที่
                </td>
                <td style="width:40%">
                    <input class="form-control inline" ng-model="LIST_LCN.dalcn.WRITE_AT" style="font-family:'Taviraj';font-size:20px;" type="text" />
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

        <h2 style="font-size:24px;">
            <strong>๑. ข้อมูลผู้ขอรับใบอนุญาต</strong>
        </h2>
        <table style="width:90%;margin-left:5%" >
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
                <td style="font-size:20px;width:20%"></td>
                <td style="font-size:20px;width:5%">
                    เลขที่
                </td>
                <td style="font-size:20px ;width:15%;text-align:center"></td>
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
        <table style="width:90%;margin-left:5%" >
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
                <td style="font-size:20px ;width:15%;text-align:center">
                    @*<label>{{LIST_LCN.BSN_THAIFULLNAME}}</label>*@
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

        <table style="width:90%;font-size:20px;" >
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

        <table style="width:100%;font-size:20px;" >
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
            @*<tr>
                <td width="20%">
                    โดยมีเภสัชกรชื่อ  1.
                    <select class="dropdown" ng-model="LIST_LCN.DALCN_PHR.PHR_PREFIX_ID" style="width:200px;">
                        <option value="0">--กรุณาเลือก--</option>
                        <option ng-repeat="x in PREFIX" value="{{x.prefixcd}}">{{x.thanm}}</option>
                    </select>
                </td>
                <td align="left">
                    <input class="form-control inline" ng-model="LIST_LCN.DALCN_PHR.PHR_NAME" style="font-family:'Taviraj';font-size:20px;" type="text" />
                </td>
                <td style="width:15%">
                    ใบอนุญาตประกอบวิชาชีพเภสัชกรรมเลขที่
                </td>
                <td align="left">
                    <input class="form-control inline" ng-model="LIST_LCN.DALCN_PHR.PHR_TEXT_NUM" style="font-family:'Taviraj';font-size:20px;" type="text" />
                </td>
            </tr>*@
        </table>
        <table style="font-size:20px;width:100%">
            <tr>
                <td style="width:20%">
                    โดยมีเภสัชกรชั้น
                </td>
                <td style="width:10%">
                    <input class="form-control inline" ng-model="LIST_PHR_ADD.PHR_LEVEL" style="font-family:'Taviraj';font-size:20px;" type="text" />
                </td>
                <td style="text-align:center">
                    ชื่อ
                </td>
                <td style="width:10%">
                    <select class="form-control selectpicker" data-live-search="true" title="-- Please select --" ng-model="LIST_PHR_ADD.PHR_PREFIX_ID">
                        @*<option value="0">--กรุณาเลือก--</option>*@
                        <option ng-repeat="x in PREFIX" value="{{x.prefixcd}}">{{x.thanm}}</option>
                    </select>
                </td>
                <td>
                    <input class="form-control inline" ng-model="LIST_PHR_ADD.PHR_NAME" style="font-family:'Taviraj';font-size:20px;" type="text" />
                </td>
            </tr>
            <tr>
                <td style="width:20%">
                    เลขบัตรประจำตัวประชาชน
                </td>
                <td colspan="4">
                    <input class="form-control inline" ng-model="LIST_PHR_ADD.PHR_CTZNO" style="font-family:'Taviraj';font-size:20px;" type="text" />
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
                <td>
                    <input class="form-control inline" ng-model="LIST_PHR_ADD.PHR_TEXT_NUM" style="font-family:'Taviraj';font-size:20px;" type="text" />
                </td>
            </tr>
        </table>
        <br />
        <input type="button" style="font-size:20px;width:100px" value="เพิ่ม" ng-click="BTN_ADD_PHR(LIST_PHR_ADD)" />
        <div>
            <table class="table" width="100%">
                <thead>
                    <tr>
                        <th>ลำดับ</th>
                        <th>เภสัชกรชั้น</th>
                        <th>ชื่อ-นามสกุล</th>
                        <th>เลขบัตรประจำตัวประชาชน</th>
                        <th>ใบอนุญาตประกอบวิชาชีพเภสัชกรรมเลขที่</th>
                    </tr>
                </thead>
                <tbody>
                    <tr ng-repeat="datas in COLLECT_PHR">
                        <td>{{$index + 1}}</td>
                        <td>{{datas.PHR_LEVEL}}</td>
                        <td>{{datas.PHR_NAME}}</td>
                        <td>{{datas.PHR_CTZNO}}</td>
                        <td>{{datas.PHR_TEXT_NUM}}</td>
                        <td>
                            <span class="fas fa-edit"></span>
                            <a ng-click="deletePHR(datas,$index)">
                                ลบข้อมูล
                            </a>
                        </td>
                    </tr>
                </tbody>
                <tfoot>
                    <tr></tr>
                </tfoot>
            </table>
        </div>


        <br />
        <div style="margin-left:5%;font-size:20px;">เป็นผู้ควบคุมตามมาตรา ๕๓ แห่งพระราชบัญญัติวัตถุที่ออกฤทธิ์ต่อจิตและประสาท พ.ศ. ๒๕๕๙</div>
        <br />

        @*<table style="width:100%;font-size:20px;">
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
                <td colspan="4">
                    <select class="dropdown" ng-model="LIST_LCN.LOCATION_SELECT" ng-change="getdetails(LIST_LCN.LOCATION_SELECT)">
                        <option value="0">--กรุณาเลือก--</option>
                        <option ng-repeat="x in REF_LOCATION_KEEP" value="{{x.IDA}}">{{x.thanameplace}}</option>
                    </select>
                </td>
                <td style="width:15%">
                    เลขรหัสประจำบ้าน
                </td>
                <td>
                    <label>{{LIST_LABEL.HOUSENO}}</label>
                </td>
            </tr>
            <tr>
                <td>
                    อยู่เลขที่
                </td>
                <td>
                    <label>{{LIST_LABEL.fulladdr}}</label>
                </td>
            </tr>
            <tr>
                <td>
                    โทรศัพท์ / มือถือ
                </td>
                <td>
                    <label>{{LIST_LABEL.tel}}</label>
                </td>
            </tr>

        </table>*@
        <h2>๔. ข้อมูลสถานที่เก็บ (กรณีเป็นสถานที่คนละแห่งกับสถานที่ตาม ๓)</h2>
        <table style="width:50%">
            <tr>
                <td>
                    ณ สถานที่ชื่อ
                </td>
                <td>
                   
                    <select class="form-control selectpicker" data-live-search="true" title="-- Please select --" ng-model="LIST_LCN.LOCATION_SELECT" ng-change="getdetails(LIST_LCN.LOCATION_SELECT)">
                        @*<option value="">--กรุณาเลือก--</option>*@
                        <option ng-repeat="x in REF_LOCATION_KEEP" value="{{x.IDA}}">{{x.thanameplace}}</option>
                    </select>
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
        <input type="button" style="font-size:20px;width:100px" value="เพิ่ม" ng-click="BTN_ADD_KEEP(LIST_LABEL,LIST_LCN.LOCATION_SELECT)" />
        <div>
            <table class="table" style="width:100%;">
                <thead>
                    <tr>
                        <th hidden>IDA</th>
                        <th>ลำดับ</th>
                        <th>ชื่อสถานที่เก็บ</th>
                        <th>ที่อยู่</th>
                    </tr>
                </thead>
                <tbody>
                    <tr ng-repeat="datas in COLLECT_KEEP">
                        <td hidden>{{datas.LOCATION_IDA}}</td>
                        <td>{{$index + 1}}</td>
                        <td>{{datas.thanameplace}}</td>
                        <td>{{datas.fulladdr}}</td>
                        <td>
                            <span class="fas fa-edit"></span>
                            <a ng-click="deleteKEEP(datas,$index)">
                                ลบที่เก็บ
                            </a>
                        </td>
                    </tr>
                </tbody>
                <tfoot>
                    <tr></tr>
                </tfoot>
            </table>
        </div>




        <table style="width:100%;font-size:20px;" >
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
        <table style="width:90%;font-size:20px ;margin-left:10%" >
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
        <table style="width:90%;font-size:20px ;margin-left:10%" >
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
        <table style="width:90%;font-size:20px ;margin-left:10%" >
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

        <table style="width:85%;font-size:20px ;margin-left:12.5%" >
            <tr>
                <td style="text-align:right">
                    (ลายมือชื่อ)
                </td>
                <td style="text-align:center;width:40%"></td>
                <td>
                    ผู้ขอรับใบอนุญาต/ผู้ได้รับมอบหมายหรือแต่งตั้งให้ดำเนินกิจการ
                </td>
            </tr>
            <tr>
                <td style="text-align:right">
                    (
                </td>
                <td style="text-align:center">
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
        <table style="width:90%;font-size:20px ;margin-left:12.5%" >
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

        <div class="col-sm-12" style="text-align:center;margin-bottom:40px;">
            <input type="button" class="btn btn-lg " ng-click="BTN_SAVE_LCN_INPUT()" value="บันทึก" />

            <input type="button" class="btn btn-lg " ng-click="BTN_LCN_BACK()" value="ย้อนกลับ" />
        </div>

    </div>
    </div>
















