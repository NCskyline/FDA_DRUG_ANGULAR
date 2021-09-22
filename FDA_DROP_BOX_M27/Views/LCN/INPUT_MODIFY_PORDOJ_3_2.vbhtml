
<script type="text/javascript">

</script>

<style>
    .title1 {
        width: 500px;
        height: 170px;
        /*background-color: aqua;*/
        text-align: center;
        border: solid;
        float: right;
    }

    .title2 {
        width: 400px;
        height: 130px;
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

<script src="../Scripts_angular/CENTER_SV.js"></script>
<script src="../Scripts_angular/LCN_CTRL.js"></script>
<div class="ic" ng-controller="LCN_CTRL" ng-app="ANGULAR_APP" ng-init="pageload_modify()" ng-cloak="">
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
                    <td colspan="3">
                        <label>{{LCN_LIST.RCVNO_DISPLAY}}</label>
                    </td>
                </tr>
                <tr>
                    <td style="text-align:left">
                        <strong>ณ สถานที่ ชื่อ</strong>
                    </td>
                    <td colspan="2">
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
                    <td style="text-align:center" colspan="2">
                        (สำหรับเจ้าหน้าที่เป็นผู้กรอก)

                    </td>
            </table>

        </div>
        <div style="clear:both"></div>
        <br />
        <br />
        <table style="width:100%; font-size:20px">
            <tr>
                <td style="text-align:right;width:90%">
                    เขียนที่
                </td>
                <td style="width:40%">
                    <input class="form-control inline" ng-model="LIST_LCN.DALCN_EDIT_REQUEST.WRITE_AT" style="font-family:'Taviraj';font-size:20px;" type="text" />
                </td>
            </tr>
            <tr>
                <td style="text-align:right;width:100px">
                    วันที่
                </td>
                <td>
                    <md-datepicker ng-model="LIST_LCN.DALCN_EDIT_REQUEST.WRITE_DATE" md-placeholder="Enter date"
                                   input-aria-describedby="datepicker-description"
                                   input-aria-labelledby="datepicker-header ">
                    </md-datepicker>
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
                <td style="font-size:20px" colspan="6">
                    <label>{{LIST_LCN.thanm}}</label>
                </td>
            </tr>
            <tr>
                <td style="font-size:20px">
                    เลขประจำตัวประชาชน
                </td>

                <td style="font-size:20px" colspan="6">
                    <label>{{LIST_LCN.CITIZEN_AUTHORIZE}}</label>
                </td>
            </tr>
            <tr>
                <td style="font-size:20px">
                    หรือบัตรประจำตัวอื่นที่ทางราชการออกให้ คือ
                </td>
                <td style="font-size:20px;width:20%"></td>
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
                <td style="font-size:20px" colspan="6">
                    <label>{{LIST_LCN.IDENTIFY}}</label>
                </td>
            </tr>
            <tr>
                <td style="font-size:20px">
                    เลขรหัสประจำบ้าน
                </td>
                <td style="font-size:20px" colspan="6">
                    <label>{{LIST_LCN.HOUSENO}}</label>
                </td>
            </tr>
            <tr>
                <td style="font-size:20px">
                    อยู่เลขที่
                </td>
                <td style="font-size:20px" colspan="6">
                    <label>{{LIST_LCN.fulladdr3}}</label>
                </td>
            </tr>
            <tr>
                <td style="font-size:20px">
                    โทรศัพท์/มือถือ
                </td>
                <td style="font-size:20px" colspan="6">
                    <label>{{LIST_LCN.tel}}</label>
                </td>
            </tr>
            <tr>
                <td style="font-size:20px">
                    E-mail
                </td>
                <td style="font-size:20px" colspan="6">
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
                <td style="font-size:20px" colspan="6">
                    <label>{{LIST_LCN.BSN_THAIFULLNAME}}</label>
                </td>
            </tr>
            <tr>
                <td style="font-size:20px">
                    เลขประจำตัวประชาชน
                </td>

                <td style="font-size:20px" colspan="6">
                    <label>{{LIST_LCN.BSN_IDENTIFY}}</label>
                </td>
            </tr>
            <tr>
                <td style="font-size:20px">
                    หรือบัตรประจำตัวอื่นที่ทางราชการออกให้ คือ
                </td>
                <td style="font-size:20px;width:20%">
                    @*<label>{{LIST_LCN.BSN_THAIFULLNAME}}</label>*@
                </td>
                <td style="font-size:20px;width:5%">
                    เลขที่
                </td>
                <td style="font-size:20px ;width:15%;text-align:center">
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
                <td style="font-size:20px" colspan="6">
                    <label>{{LIST_LCN.BSN_IDENTIFY}}</label>
                </td>
            </tr>
            <tr>
                <td style="font-size:20px">
                    เลขรหัสประจำบ้าน
                </td>
                <td style="font-size:20px" colspan="6">
                    <label>{{LIST_LCN.BSN_HOUSENO}}</label>
                </td>
            </tr>
            <tr>
                <td style="font-size:20px">
                    อยู่เลขที่
                </td>
                <td style="font-size:20px" colspan="6">
                    <label>{{LIST_LCN.fulladdr2}}</label>
                </td>
            </tr>
            <tr>
                <td style="font-size:20px">
                    โทรศัพท์/มือถือ
                </td>
                <td style="font-size:20px" colspan="6">
                    <label>{{LIST_LCN.BSN_TEL}}</label>
                </td>
            </tr>
            <tr>
                <td style="font-size:20px">
                    E-mail
                </td>
                <td style="font-size:20px" colspan="6">
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
                <td>
                    <label>{{LIST_LCN.HOUSENO}}</label>
                </td>
            </tr>
            <tr>
                <td>
                    <strong>สถานที่เดิม</strong> ตั้งอยู่เลขที่
                </td>
                <td>
                    <label>{{LIST_LCN.fulladdr3}}</label>
                </td>
            </tr>
            <tr>
                <td>
                    โทรศัพท์/มือถือ
                </td>
                <td>
                    <label>{{LIST_LCN.tel}}</label>
                </td>
            </tr>
            <tr>
                <td>
                    <strong>สถานที่ใหม่</strong>
                </td>
                <td>
                    <select class="dropdown" ng-model="LIST_LCN.LOCATION_SELECT" ng-change="getdetails_lct(LIST_LCN.LOCATION_SELECT)">
                        <option value="0">--กรุณาเลือก--</option>
                        <option ng-repeat="x in REF_LOCATION" value="{{x.IDA}}">{{x.thanameplace}}</option>
                    </select>
                </td>
            </tr>
            <tr ng-repeat="data in LIST_LABEL_LCT">
                <td>

                    ตั้งอยู่เลขที่
                </td>
                <td>
                    {{data.fulladdr3}}
                </td>
            </tr>
            <tr ng-repeat="datas in LIST_LABEL_LCT">
                <td>
                    โทรศัพท์/มือถือ
                </td>
                <td>
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
                <td>
                    <label>{{LIST_LCN.KEEP_HOUSENO}}</label>
                </td>
            </tr>
            <tr>
                <td>
                    <strong>สถานที่เดิม</strong> ตั้งอยู่เลขที่
                </td>
                <td>
                    <label>{{LIST_LCN.KEEP_FULL_ADDR}}</label>
                </td>
            </tr>
            <tr>
                <td>
                    โทรศัพท์/มือถือ
                </td>
                <td>
                    <label>{{LIST_LCN.KEEP_TEL}}</label>
                </td>
            </tr>
            <tr>
                <td>
                    <strong>สถานที่ใหม่</strong>
                </td>
                <td>
                    <select class="dropdown" ng-model="LIST_LCN.LOCATION_SELECT" ng-change="getdetails(LIST_LCN.LOCATION_SELECT)">
                        <option value="0">--กรุณาเลือก--</option>
                        <option ng-repeat="x in REF_LOCATION_KEEP" value="{{x.IDA}}">{{x.thanameplace}}</option>
                    </select>
                </td>
            </tr>
            <tr>
                <td>
                    ตั้งอยู่เลขที่
                </td>
                <td>
                    <label>{{LIST_LABEL.fulladdr}}</label>
                </td>
            </tr>
            <tr>
                <td>
                    โทรศัพท์/มือถือ
                </td>
                <td>
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
                <td>
                    <input class="form-control inline" ng-model="LIST_LCN.DALCN_EDIT_REQUEST.EDIT_DESCRIPTION" style="font-family:'Taviraj';font-size:20px;" type="text" />
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
                <td style="text-align:center">
                    ใบอนุญาตประกอบวิชาชีพเภสัชกรรมเลขที่
                </td>
                <td>
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
                <td>
                    <input type="text" ng-model="LIST_LCN.DALCN_EDIT_REQUEST.EDIT_DESCRIPTION" id="txt_EDIT_DESCRIPTION" />
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













