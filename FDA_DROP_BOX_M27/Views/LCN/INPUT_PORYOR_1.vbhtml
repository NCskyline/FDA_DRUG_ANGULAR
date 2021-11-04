<script type="text/javascript">
    var arr_checked_items = data.data.hobby;
    var arraySize = arr_checked_items.length;
    $scope.checkItem = function (id) {
        var checked = "";
        for (var i = 0; i <= arraySize; i++) {
            if (id == arr_checked_items[i]) {
                checked = "checked";
            }
        }
        return checked;
    };

    $(document).ready(function () {
        $('select').selectpicker('refresh');
    })
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

    .checkbox {
        width: 20px;
        height: 20px;
        margin-left: 45%;
        margin-top: 5%;
    }
</style>
<script src="../Scripts_angular/ANGULAR_APP.js"></script>
<script src="../Scripts_angular/CENTER_SV.js"></script>
<script src="../Scripts_angular/LCN_CTRL.js"></script>

<div class="ic" ng-controller="LCN_CTRL" ng-app="ANGULAR_APP" ng-init="pageload()" ng-cloak="">
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
                    <td style="width:40%">
                        <input class="form-control inline" ng-model="LIST_LCN.dalcn.WRITE_AT" style="font-family:'Taviraj';" type="text" />
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
                    <td></td>
                    <td>
                        สัญชาติ
                    </td>
                    <td width="2%"></td>
                    <td>
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
                    <td style="width:10%">
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
            @*<div class="row">
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
        </div>*@
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
            <br />
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
                <tr>
                    <td style="padding-left:4%">
                        หน้าที่ (ถ้ามี)
                    </td>
                    <td>
                        <select class="form-control selectpicker" data-live-search="true" title="-- Please select --" style="font-family:'Taviraj';font-size:20px;" ng-model="LIST_PHR_ADD.PHR_JOB_TYPE">
                            @*<option value="0">--กรุณาเลือก--</option>*@
                            <option ng-repeat="x in CNT_functnm" value="{{x.functcd}}">{{x.functnm}}</option>
                        </select>
                        @*<div hidden>
                        {{LIST_PHR_ADD.PHR_JOB_TYPE_NAME}}
                    </div>*@

                    </td>
                </tr>
            </table>
            <br />
            @*<input type="button" style="font-size:20px;width:100px" value="เพิ่ม" ng-click="BTN_ADD_PHR(LIST_PHR_ADD)" />*@
            @*<div class="row">
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
        </div>*@
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
                            <th></th>
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
            <div class="row">
                <div class="col-sm-12 in" style="width:100%">
                    <div ng-include="FILE_ATTACH">

                    </div>
                </div>
            </div>
            @*<br />
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
                        <a ng-show="PROCESS == '106'" ng-click="OPEN_DOC_PATH(datas.PATH,datas.FILENAME)">ดูเอกสาร</a>
                    </td>
                </tr>
            </table>
        </div>*@

            <br />

            <div class="col-sm-12" style="text-align:center;margin-bottom:40px;">
                <input type="button" class="btn btn-lg " ng-click="BTN_SAVE_LCN_INPUT()" value="บันทึก" />

                <input type="button" class="btn btn-lg " ng-click="BTN_LCN_BACK()" value="ย้อนกลับ" />
            </div>

        </div>
    </div>
</div>

