
<script type="text/javascript">

</script>
<script src="../Scripts_angular/ANGULAR_APP.js"></script>
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

<script type="text/javascript">
    $(document).ready(function () {
        $('select').selectpicker('refresh');
    })
</script>

<div class="ic" ng-controller="LCN_CTRL" ng-app="ANGULAR_APP" ng-init="pageload()" ng-cloak="">
    <div ng-show="LIST_LCN.PROCESS == '103'">
        <div class="ic" style="width:100%;font-family:'Taviraj';font-size:24px">
            <h1 style="text-align:right;font-size:24px;">
                <strong>แบบ ขย.๓</strong>
            </h1>

            <br />

            <div class="title1">
                <label style="        font-size: 16px;
        margin-top: 25px
">
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
                        เลขบัญประจำตัวประชาชน
                    </td>
                    <td style="text-align:left;width:30%;">
                        @*<label>{{LIST_LCN.BSN_IDENTIFY}}</label>*@
                        <form action="javascript:void(0)">
                            <table>
                                <tr>
                                    <td>
                                        <input class="form-control inline" ng-model="LIST_LCN.BSN_IDENTIFY" id="txt_bsn_identify" style="font-family:'Taviraj';font-size:20px;" type="text" />
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
                    <td style="text-align:left;width:20%;border-bottom:dotted;border-bottom-width:thin;" align="center">
                        <label>{{LIST_LCN.AGE}}</label>
                    </td>
                    <td>
                        ปี
                    </td>
                    <td>
                        สัญชาติ
                    </td>
                    <td style="text-align:left;width:10%;">
                        <input class="form-control inline" ng-model="LIST_LCN.dalcn.NATION" style="font-family:'Taviraj';font-size:20px;" type="text" />
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
                    <td>
                        <input class="form-control inline" ng-model="LIST_LCN.dalcn.Email" style="font-family:'Taviraj';" type="text" />
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
                    <td>
                        <select class="form-control selectpicker" data-live-search="true" title="-- Please select --" ng-model="LIST_LCN.LOCATION_SELECT" ng-change="getdetails(LIST_LCN.LOCATION_SELECT)">
                            @*<option value="0">--กรุณาเลือก--</option>*@
                            <option ng-repeat="x in REF_LOCATION_KEEP" value="{{x.IDA}}">{{x.thanameplace}}</option>
                        </select>
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
                <div class="card" style=" border-top: 10px solid #277210;">
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
                        <select ng-model="LIST_PHR_ADD.PHR_CHK_JOB">
                            <option value="1">ผู้ประกอบวิชาชีพเภสัชกรรม</option>
                            <option value="2">ผู้ประกอบวิชาชีพการสัตวแพทย์</option>
                        </select>
                    </td>
                </tr>
            </table>
            <div ng-show="LIST_PHR_ADD.PHR_CHK_JOB == '1'">
                <table style="font-size:20px;width:100%">
                    <tr>
                        <td style="width:20%">
                            โดยมีผู้ประกอบวิชาชีพเภสัชกรรม ชั้น
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
                            ใบอนุญาตประกอบวิชาชีพเภสัชกรรมเลขที่
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
                        <td>
                            <input class="form-control inline" ng-model="LIST_PHR_ADD.PHR_LEVEL" style="font-family:'Taviraj';font-size:20px;" type="text" />
                        </td>
                        <td style="text-align:center; width:10%">
                            สาขา
                        </td>
                        <td>
                            <input class="form-control inline" ng-model="LIST_PHR_ADD.PHR_VETERINARY_FIELD" style="font-family:'Taviraj';font-size:20px;" type="text" />
                        </td>
                    </tr>
                    <tr>
                        <td style="width:10%">
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
                        <td style="width:10%" colspan="2">
                            เลขบัตรประจำตัวประชาชน
                        </td>
                        <td>
                            <input class="form-control inline" ng-model="LIST_PHR_ADD.PHR_CTZNO" style="font-family:'Taviraj';font-size:20px;" type="text" />
                        </td>

                    </tr>
                </table>

                <table style="font-size:20px;width:100%">
                    <tr>
                        <td style="width:40%">
                            ใบอนุญาตประกอบวิชาชีพการสัตวแพทย์เลขที่

                        </td>
                        <td>
                            <input class="form-control inline" ng-model="LIST_PHR_ADD.PHR_TEXT_NUM" style="font-family:'Taviraj';font-size:20px;" type="text" />
                        </td>
                    </tr>
                </table>
                <br />
                @*<input type="button" style="font-size:20px;width:100px" value="เพิ่ม" ng-click="BTN_ADD_PHR(LIST_PHR_ADD)" />*@
            </div>

            <br />
            <div class="row">
                <div class="col-sm-12">
                    <div class="card" style=" border-top: 10px solid #277210;">
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
                    <td>
                        <input class="form-control inline" ng-model="LIST_LCN.dalcn.opentime" style="font-family:'Taviraj';font-size:20px;" type="text" />
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
            @*<div style="margin-left:10%;font-size:20px">(๑) รูปถ่ายของผู้ขออนุญาต ขนาด ๓ x ๔ เซนติเมตร จำนวน ๓ รูป</div>
            <div style="margin-left:10%;font-size:20px">(๒) เอกสารแสดงการเป็นเจ้าของกิจการและหลักทรัพย์</div>
            <div style="margin-left:10%;font-size:20px">(๓) สำเนาทะเบียนบ้านของผู้ขออนุญาต (กรณีบุคคลธรรมดาเป็นผู้ขออนุญาต) หรือ ผู้ดำเนินกิจการ (กรณีนิติบุคคลเป็นผู้ขออนุญาต)</div>
            <div style="margin-left:10%;font-size:20px">(๔) ใบรับรองของผู้ประกอบวิชาชีพเวชกรรมซึ่งรับรองว่าผู้ขออนุญาตไม่เป็นโรคตามมาตรา ๑๔ (๖) แห่งพระราชบัญญัติยา พ.ศ. ๒๕๑๐</div>
            <div style="margin-left:10%;font-size:20px">(๕) สัญญาระหว่างผู้ขออนุญาตและเภสัชกร ซึ่งรับจะเป็นผู้มีหน้าที่ปฏิบัติการของผู้ขออนุญาต</div>
            <div style="margin-left:10%;font-size:20px">(๖) สำเนาหรือรูปถ่ายใบอนุญาตประกอบวิชาชีพเภสัชกรรมของเภสัชกรทุกคน ซึ่งรับจะเป็นผู้มีหน้าที่ปฏิบัติการของผู้ขออนุญาต</div>
            <div style="margin-left:10%;font-size:20px">(๗) เอกสารแสดงว่าเป็นผู้ดำเนินกิจการ (กรณีนิติบุคคลเป็นผู้ขออนุญาต)</div>
            <div style="margin-left:10%;font-size:20px">(๘) เอกสารอื่นๆ ถ้าจำเป็น</div>*@
            <div class="row">
                <div class="col-sm-10" style="width:100%">
                    <div class="card" ng-repeat="datas in DOC_LIST.FILE_LISTs">
                        <div class="card-header" ng-show="datas.PIORITY=='HIGH'">
                            หัวข้อเอกสาร <span style="color:red;"> (บังคับแนบ)</span>
                        </div>
                        <div class="card-header" ng-show="datas.PIORITY=='LOW'">
                            หัวข้อเอกสาร (ไม่บังคับแนบ)
                        </div>
                        <div class="card-body">

                            <table class="table" style="width:100%">
                                <tr>
                                    <td colspan="5">
                                        {{datas.DES}}
                                    </td>
                                </tr>
                                <tr>
                                    <td style="width:15%;"><input id="file-input" ng-model="datas.FILE_DATA" type="file" name="file" ngf-select="selectFileforUpload(datas,$files)" /></td>
                                    <td style="width:10%;">ชื่อไฟล์</td>
                                    <td style="width:50%;">{{datas.FILENAME}}</td>
                                    <td style="width:5%">
                                        <a ng-click="OPEN_DOC_PATH(datas.PATH)">{{FLAG}}</a>
                                    </td>
                                    <td style="width:20%; text-align: right;">
                                        @*<input type="button" ng-click="UPLOAD_PDFs(datas)" value="บันทึก" />*@
                                        @*<input type="button" ng-click="deleteRow(datas,$index)" value="ลบ" />*@
                                    </td>
                                </tr>

                            </table>
                        </div>

                    </div>
                </div>
            </div>
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
        <br />
        <div class="col-sm-12">
            <div class="row">
                <div class="col-sm-3" style="text-align:center">
                    รายละเอืยด :
                </div>
                <div class="col-sm-9">
                    {{REMARK}}
                </div>
            </div>
            <br />
            <table class="table" style="width:100%">
                <tr>
                    <td>ชื่อไฟล์</td>
                    <td></td>
                </tr>
                <tr ng-repeat="datas in LIST_LCN" style="background-color:#FDFCE3">
                    <td>{{datas.FILENAME}}</td>
                    <td>
                        <a ng-show="PROCESS == '103'" ng-click="OPEN_DOC_PATH(datas.PATH,datas.FILENAME)">ดูเอกสาร</a>
                    </td>
                </tr>
            </table>
        </div>
    </div>

    <br />
    <div class="col-sm-12" style="text-align:center;margin-bottom:40px;">
        <input type="button" class="btn btn-lg " ng-click="BTN_SAVE_LCN_INPUT()" value="บันทึก" />

        <input type="button" class="btn btn-lg " ng-click="BTN_LCN_BACK()" value="ย้อนกลับ" />
    </div>
</div>
