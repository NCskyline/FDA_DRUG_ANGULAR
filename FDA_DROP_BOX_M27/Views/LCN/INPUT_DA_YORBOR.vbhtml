@*@Code
        ViewData("Title") = "INPUT_DA_YORBOR"
    End Code*@
<script src="../Scripts_angular/CENTER_SV.js"></script>
<script src="../Scripts_angular/LCN_CTRL.js"></script>
<div class="ic" ng-controller="LCN_CTRL" ng-app="ANGULAR_APP" ng-init="pageload()" ng-cloak="">
    <div style="font-family:'Taviraj';font-size:24px;">
        <h2 style="text-align:center;font-size:24px;">
            <strong>คำขอ</strong>
        </h2>
        <center>
            <table style="font-size:20px">
                <tr>
                    <td>
                        <form name="rdl_gmp">

                            <input type="radio" ng-model="LIST_LCN.PROCESS" id="rdl_lcn_process" ng-value="109" disabled="disabled">
                            ผลิตยาแผนโบราณ

                            <input type="radio" ng-model="LIST_LCN.PROCESS" id="rdl_lcn_process" ng-value="107" disabled="disabled">
                            ขายยาแผนโบราณ

                            <input type="radio" ng-model="LIST_LCN.PROCESS" id="rdl_lcn_process" ng-value="108" disabled="disabled">
                            นำหรือสั่งยาแผนโบราณเข้ามาในราชอาณาจักร

                        </form>
                    </td>
                </tr>
            </table>
        </center>
        <br />
        <table style="width:100%; font-size:20px">
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
        <table style="width:100%;">
            <tr>
                <td style="text-align:center;font-size:20px">
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
        <table style=" font-size:20px;width:100%" @*border="1"*@ ;>
            <tr>
                <td style="width:30%">
                    ซึ่งมีผู้ดำเนินกิจการ ชื่อ
                </td>
                <td style="text-align:left;width:2000px">
                    <label>{{LIST_LCN.BSN_THAIFULLNAME}}</label>
                </td>
                <td colspan="5"></td>
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
                <td style="text-align: left; width: 20%;" align="center">
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
        </table>
        <table style="font-size:20px;width:100%" @*border="1"*@>
            <tr>
                <td>
                    ขอรับใบอนุญาต
                </td>
                <td>
                    <form name="rdl_gmp">

                        <input type="radio" ng-model="LIST_LCN.PROCESS" id="rdl_lcn_process" ng-value="109" disabled="disabled">
                        ผลิตยาแผนโบราณ

                        <input type="radio" ng-model="LIST_LCN.PROCESS" id="rdl_lcn_process" ng-value="107" disabled="disabled">
                        ขายยาแผนโบราณ

                        <input type="radio" ng-model="LIST_LCN.PROCESS" id="rdl_lcn_process" ng-value="108" disabled="disabled">
                        นำหรือสั่งยาแผนโบราณเข้ามาในราชอาณาจักร

                    </form>
                </td>
                <td>
                    หมวด
                </td>
                <td>
                    <input class="form-control inline" ng-model="LIST_LCN.dalcn.NATION" style="font-family:'Taviraj';font-size:20px;" type="text" />
                </td>
            </tr>
        </table>
        <table style="font-size:20px;width:100%" @*border="1"*@>
            <tr>
                <td style="width:500px">
                    โดยมีสถานที่ประกอบธุรกิจ
                </td>
                <td style="text-align:left;width:2000px">
                    <label>{{LIST_LCN.thanameplace}}</label>
                </td>

            </tr>

        </table>
        <table style="font-size:20px;width:100%">
            <tr>
                <td style="width:10%">
                    อยู่เลขที่
                </td>
                <td>
                    <label>{{LIST_LCN.fulladdr3}}</label>
                </td>
            </tr>
            <tr>
                <td style="width:155px">
                    โทรศัพท์
                </td>
                <td style="text-align:left" width="500">
                    <label>{{LIST_LCN.tel}}</label>
                </td>
                
            </tr>
            <tr>
                <td style="width:100px">
                    เวลาทำการ
                </td>
                <td style="text-align:left">
                    <input type="text" ng-model="LIST_LCN.dalcn.opentime" style="width:20%;"/>
                </td>
            </tr>
        </table>
        <table style="font-size:20px;width:100%">
            <tr>
                <td style="width:13%">
                    โดยมีผู้ประกอบโรคศิลปะแผนโบราณ สาขา
                </td>
                <td style="text-align:left;width:8%">
                    <input class="form-control inline" ng-model="LIST_LCN.DALCN_PHR.PHR_VETERINARY_FIELD" style="font-family:'Taviraj';font-size:20px;" type="text" />
                </td>
                <td>
                    เลขบัตรประชาชน
                </td>
                <td>
                    <input class="form-control inline" ng-model="LIST_LCN.DALCN_PHR.PHR_CTZNO" style="font-family:'Taviraj';font-size:20px;" type="text" />
                </td>
                <td style="text-align:center;width:5%">
                    ชื่อ
                </td>
                <td style="text-align:left ;width:7.5%">
                    <select class="dropdown" ng-model="LIST_LCN.DALCN_PHR.PHR_PREFIX_ID">
                        <option value="0">--กรุณาเลือก--</option>
                        <option ng-repeat="x in PREFIX" value="{{x.prefixcd}}">{{x.thanm}}</option>
                    </select>
                </td>
                <td style="text-align:left">
                    <input class="form-control inline" ng-model="LIST_LCN.DALCN_PHR.PHR_NAME" style="font-family:'Taviraj';font-size:20px;" type="text" />
                </td>
            </tr>
        </table>
        <table>
            <tr>
                <td>
                    เป็นผู้มีหน้าที่ปฏิบัติการตามมาตรา
                </td>
                <td>
                    <form name="rdl_gmp">
                        <label><input type="radio" ng-model="LIST_LCN.DALCN_PHR.PHR_LAW_SECTION" id="rdl_law_select" value="1"> มาตรา ๖๘</label>
                        <label><input type="radio" ng-model="LIST_LCN.DALCN_PHR.PHR_LAW_SECTION" id="rdl_law_select" value="2"> มาตรา ๖๙</label>
                        <label><input type="radio" ng-model="LIST_LCN.DALCN_PHR.PHR_LAW_SECTION" id="rdl_law_select" value="3">  มาตรา ๗๐ แห่งพระราชบัญญัติยา พ.ศ. ๒๕๑๐ </label>

                    </form>
                </td>
            </tr>

        </table>

        <table style="width:50%">
            <tr>
                <td>
                    ชื่อสถานที่เก็บ ( 1 ) :
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
                    อยู่เลขที่
                </td>
                <td>
                    <label>{{LIST_LABEL.fulladdr}}</label>
                </td>
            </tr>
            <tr>
                <td>
                    โทรศัพท์
                </td>
                <td>
                    <label>{{LIST_LABEL.tel}}</label>
                </td>
            </tr>
            <tr style="font-size: 20px">
                <td>
                    โทรศัพท์มือถือ
                </td>
                <td>
                    <label>{{LIST_LABEL.Mobile}}</label>
                </td>
            </tr>
        </table>
        <br />
        <input type="button" style="font-size:20px;width:100px" value="เพิ่ม" />
        <input type="button" style="font-size:20px;width:100px;margin-left:10px" value="ลบ" />



    </div>
    </div>

