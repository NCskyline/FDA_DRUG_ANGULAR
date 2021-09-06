<script src="~/Scripts_angular/CENTER_SV.js"></script>
@*<script src="~/Scripts_angular/LCN_EDIT_CTRL.js"></script>*@
<script src="~/Scripts_angular/LCN_STAFF_EDIT_CTRL.js"></script>


<div ng-controller="LCN_STAFF_EDIT_CTRL" ng-app="ANGULAR_APP" ng-init="pageload()" class="ic">

    <div style="font-family:'Taviraj';font-size:20px;">
        <h1>ข้อมูลผู้ปฏิบัติงาน</h1>
        <table style="width:100%">
            <tr>
                <td style="width:30%;padding-left:4%">
                    เลขที่บัตรประชาชน
                </td>
                <td>
                    <input class="form-control inline" ng-model="LIST_EDIT_PHR.DALCN_PHR.PHR_CTZNO" style="font-family:'Taviraj';font-size:20px;" type="text" />
                    <input type="button" value="ค้นหา" style="margin-left:1%" ng-click="Search_Phr_name(LIST_EDIT_PHR.DALCN_PHR.PHR_CTZNO)" />
                </td>
            </tr>
            <tr>
                <td style="padding-left:4%">
                    ประเภทผู้มีหน้าที่ปฏิบัติการ
                </td>
                <td>
                    <select style="font-family:'Taviraj';font-size:20px;" ng-model="LIST_EDIT_PHR.DALCN_PHR.PERSONAL_TYPE">
                        <option value="0">--กรุณาเลือก--</option>
                        <option ng-repeat="x in CNT_daphrcd" value="{{x.phrcd}}">{{x.phrnm}}</option>
                    </select>
                </td>
            </tr>
            <tr>
                <td style="padding-left:4%">
                    เภสัชกรชั้น(ถ้ามี)
                </td>
                <td>
                    <input class="form-control inline" ng-model="LIST_EDIT_PHR.DALCN_PHR.PHR_LEVEL" style="font-family:'Taviraj';font-size:20px;" type="text" />
                </td>
            </tr>
            <tr>
                <td style="padding-left:4%">
                    คำนำหน้าชื่อ
                </td>
                <td>
                    <select style="font-family:'Taviraj';font-size:20px;" ng-model="LIST_EDIT_PHR.DALCN_PHR.PHR_PREFIX_ID">
                        <option value="0">--กรุณาเลือก--</option>
                        <option ng-repeat="x in PREFIX_LIST" value="{{x.prefixcd}}">{{x.thanm}}</option>
                    </select>
                </td>
            </tr>
            <tr>
                <td style="padding-left:4%">
                    ชื่อผู้มีหน้าที่ปฏิบัติการ
                </td>
                <td>
                    <input class="form-control inline" ng-model="LIST_EDIT_PHR.DALCN_PHR.PHR_NAME" style="font-family:'Taviraj';font-size:20px;" type="text" />
                </td>
            </tr>

            <tr>
                <td style="padding-left:4%">
                    เลขที่ใบอนุญาตประกอบ วิชาชีพฯ / โรคศิลปะฯ / เลขอ้างอิงการอบรม
                </td>
                <td>
                    <input class="form-control inline" ng-model="LIST_EDIT_PHR.DALCN_PHR.PHR_TEXT_NUM" style="font-family:'Taviraj';font-size:20px;" type="text" />
                </td>
            </tr>
            <tr>
                <td style="padding-left:4%">
                    สาขา
                </td>
                <td>

                    <input class="form-control inline" ng-model="LIST_EDIT_PHR.DALCN_PHR.PHR_VETERINARY_FIELD" style="font-family:'Taviraj';font-size:20px;" type="text" />
                </td>
            </tr>
            <tr>
                <td style="padding-left:4%">
                    คำอธิบายผู้ประกอบวิชาชีพ
                </td>
                <td>
                    <input class="form-control inline" ng-model="LIST_EDIT_PHR.DALCN_PHR.PHR_TEXT_JOB" style="font-family:'Taviraj';font-size:20px;" type="text" />
                </td>
            </tr>
            <tr>
                <td style="width:20%;padding-left:4%">
                    ช่องติ๊กที่ปรากฎในใบอนุญาต
                </td>
                <td>
                    <select style="font-family:'Taviraj';font-size:20px;" ng-model="LIST_EDIT_PHR.DALCN_PHR.PHR_MEDICAL_TYPE">
                        <option value="0">--กรุณาเลือก--</option>
                        <option value="1">เภสัชกร</option>
                        <option value="2">ผู้ประกอบวิชาชีพ</option>
                        <option value="3">ผู้ได้รับมอบหมายการอบรมมาตรา 48</option>
                    </select>
                </td>
            </tr>
            <tr>
                <td style="width:20%;padding-left:4%">
                    (กรณีขย.2 และ ขย.3)
                </td>
            </tr>
            <tr>
                <td style="padding-left:4%">
                    เวลาปฏิบัติการ
                </td>
                <td>
                    <input class="form-control inline" ng-model="LIST_EDIT_PHR.DALCN_PHR.PHR_TEXT_WORK_TIME" style="font-family:'Taviraj';font-size:20px;" type="text" />
                </td>
            </tr>
            <tr>
                <td style="padding-left:4%">
                    หน้าที่ (ถ้ามี)
                </td>
                <td>
                    <select style="font-family:'Taviraj';font-size:20px;" ng-model="LIST_EDIT_PHR.DALCN_PHR.PHR_JOB_TYPE">
                        <option value="0">--กรุณาเลือก--</option>
                        <option ng-repeat="x in CNT_functnm" value="{{x.functcd}}">{{x.functnm}}</option>
                    </select>
                </td>
            </tr>
            <tr>
                <td style="padding-left:4%">
                    ตามมาตรา (ถ้ามี)
                </td>
                <td>
                    <select style="font-family:'Taviraj';font-size:20px;" ng-model="LIST_EDIT_PHR.DALCN_PHR.PHR_LAW_SECTION">
                        <option value="">--กรุณาเลือก--</option>
                        <option value="1">มาตรา 68</option>
                        <option value="2">มาตรา 69</option>
                        <option value="3">มาตรา 70</option>
                    </select>
                </td>
            </tr>
        </table>
        <div style="margin-top:1%"> <center><input type="button" value="แก้ไข" ng-click="BTN_EDIT_PHR()" /><input type="button" value="ย้อนกลับ" ng-click="BTN_BACK_TO_INFORMATION()" /></center></div>
    </div>
</div>