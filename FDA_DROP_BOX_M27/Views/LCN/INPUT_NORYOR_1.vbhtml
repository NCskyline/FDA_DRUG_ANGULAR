﻿<script type="text/javascript">

</script>

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
                    เลขบัญประจำตัวประชาชน
                </td>
                <td style="text-align:left;width:30%;">
                    @*<label>{{LIST_LCN.BSN_IDENTIFY}}</label>*@
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
                <td style="text-align:left;width:10%;">
                    <input class="form-control inline" ng-model="LIST_LCN.dalcn.NATION" style="font-family:'Taviraj';" type="text" />
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
                <td style="text-align:left">
                    <input type="text" ng-model="LIST_LCN.dalcn.opentime" style="font-family:'Taviraj';font-size:20px;" />
                </td>
            </tr>
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
        @*<input type="button" style="font-size:20px;width:100px" value="เพิ่ม" ng-click="BTN_ADD_PHR(LIST_PHR_ADD)" />*@
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
        <br />
        @*<input type="button" style="font-size:20px;width:100px" value="เพิ่ม" ng-click="BTN_ADD_KEEP(LIST_LABEL,LIST_LCN.LOCATION_SELECT)" />*@
        <div class="row">
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
        </div>
        <br />
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
                        <a ng-show="PROCESS == '105'" ng-click="OPEN_DOC_PATH(datas.PATH,datas.FILENAME)">ดูเอกสาร</a>
                    </td>
                </tr>
            </table>
        </div>
        <br />
        <div class="col-sm-12" style="text-align:center;margin-bottom:40px;">
            <input type="button" class="btn btn-lg " ng-click="BTN_SAVE_LCN_INPUT()" value="บันทึก" />
            <input type="button" class="btn btn-lg " ng-click="BTN_LCN_BACK()" value="ย้อนกลับ" />
        </div>


    </div>
        </div>
</div>