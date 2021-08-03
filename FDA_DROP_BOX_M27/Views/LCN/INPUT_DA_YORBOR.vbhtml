@Code
    ViewData("Title") = "INPUT_DA_YORBOR"
End Code

<script src="~/Scripts_angular/ANGULAR_APP.js"></script>
<script src="~/Scripts_angular/CENTER_SV.js"></script>
<script src="~/Scripts_angular/LCN_CTRL.js"></script>

<div class="ic" ng-app="ANGULAR_APP" ng-controller="LCN_CTRL">
    <h2 style="text-align:center;font-size:24px;">
        <strong>คำขอ</strong>
    </h2>
    <h2 style="text-align:center;font-size:20px;" ng-init="YORBOR()">
        <strong>{{headLCN}}</strong>
    </h2>
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
            <td>
                ซึ่งมีผู้ดำเนินกิจการ ชื่อ
            </td>
            <td style="text-align:left;width:2000px">
                <label>{{LIST_LCN.BSN_THAIFULLNAME}}</label>
            </td>
            <td colspan="2"></td>
        </tr>
        <tr>
            <td>
                อายุ
            </td>
            <td>
                <label>{{LIST_LCN.AGE}}</label>
            </td>
            <td>
                ปี
            </td>
            <td>
                สัญชาติ
            </td>
            <td>
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
                <label>{{LIST_LCN.fulladdr_bsn}}</label>
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

                    <input type="radio" ng-model="LIST_LCN.dalcn.PROCESS_ID" id="rdl_lcn_process" value="109">
                    ผลิตยาแผนโบราณ

                    <input type="radio" ng-model="LIST_LCN.dalcn.PROCESS_ID" id="rdl_lcn_process" ng-value="107">
                    ขายยาแผนโบราณ

                    <input type="radio" ng-model="LIST_LCN.dalcn.PROCESS_ID" id="rdl_lcn_process" value="108">
                    นำหรือสั่งยาแผนโบราณเข้ามาในราชอาณาจักร

                </form>
            </td>
            <td>
                หมวด
            </td>
            <td>
                <input class="form-control inline" ng-model="LIST_LCN.dalcn.NATION" style="font-family:'TH SarabunPSK';font-size:20px;" type="text" />
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
            <td style="width:50%">
                อยู่เลขที่
            </td>
            <td colspan="2">
                <label>{{LIST_LCN.fulladdr2}}</label>
            </td>
        </tr>
        <tr>
            <td style="width:155px">
                โทรศัพท์
            </td>
            <td style="text-align:left" width="500">
                <label>{{LIST_LCN.tel}}</label>
            </td>
            <td style="width:100px">
                เวลาทำการ
            </td>
            <td style="text-align:left">
                <input type="text" ng-model="LIST_LCN.dalcn.opentime" />
            </td>
        </tr>
    </table>
    <table style="font-size:20px;width:100%" border="1">
        <tr>
            <td style="width:13%">
                โดยมีผู้ประกอบโรคศิลปะแผนโบราณ สาขา
            </td>
            <td style="text-align:left;width:8%">
                <input class="form-control inline" ng-model="LIST_LCN.DALCN_PHR.PHR_VETERINARY_FIELD" style="font-family:'TH SarabunPSK';font-size:20px;" type="text" />
            </td>
            <td style="text-align:center;width:5%">
                ชื่อ
            </td>
            <td style="text-align:left ;width:7.5%">
                <select class="dropdown" ng-model="LIST_LCN.DALCN_PHR.PHR_PREFIX_ID">
                    <option value="0">--กรุณาเลือก--</option>
                    <option ng-repeat="x in PREFIX" value="{{x.IDA}}">{{x.prefixnm}}</option>
                </select>
            </td>
            <td style="text-align:left">
                <input class="form-control inline" ng-model="LIST_LCN.DALCN_PHR.PHR_NAME" style="font-family:'TH SarabunPSK';font-size:20px;" type="text" />
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

                    <input type="radio" ng-model="LIST_LCN.DALCN_PHR.PHR_LAW_SECTION" id="rdl_law_select" value="1">
                    มาตรา ๖๘

                    <input type="radio" ng-model="LIST_LCN.DALCN_PHR.PHR_LAW_SECTION" id="rdl_law_select" ng-value="2">
                    มาตรา ๖๙

                    <input type="radio" ng-model="LIST_LCN.DALCN_PHR.PHR_LAW_SECTION" id="rdl_law_select" value="3">
                    มาตรา ๗๐ แห่งพระราชบัญญัติยา พ.ศ. ๒๕๑๐

                </form>
            </td>
        </tr>

    </table>

    //เพิ่มสถานที่เก็บ
</div>