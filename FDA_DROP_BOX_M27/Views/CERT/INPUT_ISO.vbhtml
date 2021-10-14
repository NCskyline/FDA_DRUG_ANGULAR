
@Code
    Layout = ""
End Code
@*<script src="~/Scripts_angular/CENTER_SV.js"></script>
    <script src="~/Scripts_angular/CERT_GMP_CTRL.js"></script>*@

<script type="text/javascript">
    $(document).ready(function () {
        $('select').selectpicker('refresh');
    })
</script>


<div class="ic">
    <h2 style="font-family:'Taviraj';font-size:24px;">
        รายละเอียดใบรับรองสถานที่ผลิตเภสัชเคมีภัณฑ์
    </h2>
    <h2 style="font-family:'Taviraj';font-size:24px;">
        <b> (Information of Certificate of Drug Substance Manufacturer)</b>
    </h2>
    <table width="100%" style="font-family:'Taviraj';font-size:20px;">
        <tr>
            <td style="height:25px;width:35%;">
                1. เลขที่ใบรับรอง (Certificate Number / Registration Number)<font color="red">*</font>
            </td>
            <td>
                <input class="form-control inline" ng-model="LIST_GMP.CER.CERTIFICATION_NUMBER_ALL" style="font-family:'Taviraj';font-size:20px;" type="text" />
            </td>
        </tr>
        <tr>
            <td style="height:25px">
                2. ชื่อผู้ผลิต (Manufacturer)<font color="red">*</font>
            </td>
            <td>
                <input class="form-control inline" ng-model="LIST_GMP.CER_DETAIL_MANUFACTURE.NAME_ADDRESS" style="font-family:'Taviraj';font-size:20px;" type="text" />
            </td>
        </tr>
        <tr>
            <td style="height:25px">
                3. ที่ตั้ง (Site Address)<font color="red">*</font>
            </td>
            <td>
                <input class="form-control inline" ng-model="LIST_GMP.CER_DETAIL_MANUFACTURE.ADDRESS_NUMBER" style="font-family:'Taviraj';font-size:20px;" type="text" />
            </td>
        </tr>
        <tr>
            <td style="height:25px">
                4. เมือง (City / Province / State)<font color="red">*</font>
            </td>
            <td>
                <input class="form-control inline" ng-model="LIST_GMP.CER_DETAIL_MANUFACTURE.ADDRESS_CITY" style="font-family:'Taviraj';font-size:20px;" type="text" />
            </td>
        </tr>
        <tr>
            <td style="height:25px">
                5. ประเทศ (Country)<font color="red">*</font>
            </td>
            <td>
                <select class="form-control selectpicker" data-live-search="true" title="-- Please select --" style="font-family:'Taviraj';font-size:20px;" ng-model="LIST_GMP.CER.COUNTRY_ID">
                    @*<option value="0">--กรุณาเลือก--</option>*@
                    <option ng-repeat="x in CNT_LIST" value="{{x.IDA}}">{{x.engcntnm}}</option>
                </select>
            </td>
        </tr>
        <tr>
            <td style="height:25px">
                รหัสไปรษณีย์ (Postal Code / Zip Code)
            </td>
            <td>
                <input class="form-control inline" ng-model="LIST_GMP.CER_DETAIL_MANUFACTURE.ZIPCODE" style="font-family:'Taviraj';font-size:20px;" type="text" />
            </td>
        </tr>
        @*<tr>
                <td style="height:25px">
                    6. Organization Code (รหัสองค์กร) :
                </td>
                <td>
                    <input class="form-control inline" ng-model="LIST_GMP.CER_DETAIL_MANUFACTURE.ORGANIZATION_CODE" style="font-family:'Taviraj';font-size:20px;" type="text" />
                </td>
            </tr>
            <tr>
                <td style="height:25px">
                    Global Location Number (GLN) :
                </td>
                <td>
                    <input class="form-control inline" ng-model="LIST_GMP.CER_DETAIL_MANUFACTURE.GLN" style="font-family:'Taviraj';font-size:20px;" type="text" />
                </td>
            </tr>*@
        <tr>
            <td style="height:25px">
                6. วันที่ออกใบรับรอง ISO (Issue Date)<font color="red">*</font>
            </td>
            <td>
                <md-datepicker ng-model="LIST_GMP.CER.DOCUMENT_DATE" md-placeholder="Enter date"
                               input-aria-describedby="datepicker-description"
                               input-aria-labelledby="datepicker-header "></md-datepicker>
            </td>
        </tr>
        <tr>
            <td style="height:25px">
                วันที่หมดอายุใบรับรอง ISO (Expiry Date / Valid Until)
            </td>
            <td>
                <md-datepicker ng-model="LIST_GMP.CER.EXP_DOCUMENT_DATE" md-placeholder="Enter date"
                               input-aria-describedby="datepicker-description"
                               input-aria-labelledby="datepicker-header "></md-datepicker>
            </td>
        </tr>
        <tr>
            <td style="height:25px">
                7. หน่วยงานที่ออกใบรับรอง (Certification Agency)<font color="red">*</font>
            </td>
            <td>
                <input class="form-control inline" ng-model="LIST_GMP.CER.DEPARTMENT_REGIST_CER_NAME" style="font-family:'Taviraj';font-size:20px;" type="text" />
            </td>
        </tr>
        <tr>
            <td style="height:25px">
                ประเทศของหน่วยงานที่ออกใบรับรอง (Country of Certification Agency)
            </td>
            <td>
                <select class="form-control selectpicker" data-live-search="true" title="-- Please select --" style="font-family:'Taviraj';font-size:20px;" ng-model="LIST_GMP.CER.COUNTRY_OF_DEPARTMENT_IDA">
                    @*<option value="0">--กรุณาเลือก--</option>*@
                    <option ng-repeat="x in CNT_LIST" value="{{x.IDA}}">{{x.engcntnm}}</option>
                </select>
            </td>
        </tr>
        <tr>
            <td style="height:25px">
                8. มาตรฐาน ISO เกี่ยวกับการผลิตของสถานที่ผลิต ต.ย. ISO 9001 : 2015, ISO 22000 : 2018 (ISO Standard for Production of Manufacturer e.g. ISO 9001 : 2015, ISO 22000 : 2018)<font color="red">*</font>
            </td>
            <td>
                <input class="form-control inline" ng-model="LIST_GMP.CER_DETAIL_MANUFACTURE.DEPARTMENT_REGIST_CER_NAME" style="font-family:'Taviraj';font-size:20px;" type="text" />
            </td>
        </tr>
    </table>
    <br />
    <h2 style="font-family:'Taviraj';font-size:24px;">
        <b> รายละเอียดเภสัชเคมีภัณฑ์ที่ได้รับการรับรอง (Information of Drug Substances under Certification) </b>
    </h2>
    <table width="100%">
        <tr>
            <td style="height:25px;width:35%;">
                9. ขอบเขตของเภสัชเคมีภัณฑ์ที่ได้รับการรับรอง (Scope of Inspection / Certification)
            </td>
            <td>
                <input class="form-control inline" ng-model="LIST_GMP.CER.CER_SCOPE" style="font-family:'Taviraj';font-size:20px;" type="text" />
            </td>
        </tr>
    </table>
    <br />
    <div>
        <h2 style="font-family:'Taviraj';font-size:24px;">
            แนบไฟล์ใบรับรอง และเอกสารอื่น (Attach Files of Certificate and Other Documents)
        </h2>
    </div>
</div>