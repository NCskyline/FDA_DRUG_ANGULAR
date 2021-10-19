@Code
    Layout = ""

End Code

@*<script src="../Scripts/bootstrap-select.js"></script>
<script src="../Scripts/bootstrap-select.min.js"></script>*@
@*<script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.3/umd/popper.min.js"></script>*@

    <script type="text/javascript">
        $(document).ready(function () {
            $('select').selectpicker('refresh');
        })
    </script>

<style type="text/css">
    .auto-style1 {
        height: 23px;
    }
    
</style>

<div class="ic">
    <h2 style="font-family:'Taviraj';font-size:24px;">
        <b> รายละเอียดใบรับรองสถานที่ผลิตเภสัชเคมีภัณฑ์</b>
    </h2>
    <h2 style="font-family:'Taviraj';font-size:24px;">
        <b> (Information of Certificate of Drug Substance Manufacturer)</b>
    </h2>
    <table width="100%" style="font-family:'Taviraj';font-size:20px;">
        <tr>
            <td>
                1. เลข สธ หนังสือ อย. ให้ความเห็นชอบ ตย. 1009.4.3/123 (Reference No. of FDA Approval Letter e.g. 1009.4.3/123)<font color="red">*</font>
            </td>
            <td>
                <input class="form-control inline" ng-model="LIST_GMP.CER.DEPARTMENT_REGIST_CER_DOCNO" style="font-family:'Taviraj';font-size:20px;" type="text" />
            </td>
        </tr>
        <tr>
            <td style="height:25px;width:35%;">
                2. เลขที่ใบรับรอง (Certificate Number / Registration Number)<font color="red">*</font>
            </td>
            <td>
                <input class="form-control inline" ng-model="LIST_GMP.CER.CERTIFICATION_NUMBER_ALL" style="font-family:'Taviraj';font-size:20px;" type="text" />
            </td>
        </tr>
        <tr>
            <td style="height:25px">
                3. ชื่อผู้ผลิต (Manufacturer)<font color="red">*</font>
            </td>
            <td>
                <input class="form-control inline" ng-model="LIST_GMP.CER_DETAIL_MANUFACTURE.NAME_ADDRESS" style="font-family:'Taviraj';font-size:20px;" type="text" />
            </td>
        </tr>
        <tr>
            <td style="height:25px">
                4. เลขที่ใบอนุญาตผลิต (Manufacturing License Number)<font color="red">*</font>
            </td>
            <td>
                <input class="form-control inline" ng-model="LIST_GMP.CER.MANUFACTURER_LICENCE_NUMBER" style="font-family:'Taviraj';font-size:20px;" type="text" />
            </td>
        </tr>
        <tr>
            <td style="height:25px">
                5. ที่ตั้ง (Site Address)<font color="red">*</font>
            </td>
            <td>
                <input class="form-control inline" ng-model="LIST_GMP.CER_DETAIL_MANUFACTURE.ADDRESS_NUMBER" style="font-family:'Taviraj';font-size:20px;" type="text" />
            </td>
        </tr>
        <tr>
            <td style="height:25px">
                6. เมือง (City / Province / State)<font color="red">*</font>
            </td>
            <td>
                <input class="form-control inline" ng-model="LIST_GMP.CER_DETAIL_MANUFACTURE.ADDRESS_CITY" style="font-family:'Taviraj';font-size:20px;" type="text" />
            </td>
        </tr>
        <tr>
            <td style="height:25px">
                7. ประเทศ (Country)<font color="red">*</font>
            </td>
            <td>
                @*<input list="countrys"  class="form-control" style="font-family:'Taviraj';font-size:20px;" ng-model="LIST_GMP.CER.COUNTRY_ID" />*@
                <select style="font-family:'Taviraj';font-size:20px;" ng-model="LIST_GMP.CER.COUNTRY_ID" class="form-control selectpicker" data-live-search="true" title="-- Please select --">
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
                Global Location Number (GLN)
            </td>
            <td>
                <input class="form-control inline" ng-model="LIST_GMP.CER_DETAIL_MANUFACTURE.GLN" style="font-family:'Taviraj';font-size:20px;" type="text" />
            </td>
        </tr>*@
        <tr>
            <td style="height:25px">
                ประเทศ (Country)<font color="red">*</font>
            </td>
            <td>
                <select class="form-control selectpicker" style="font-family:'Taviraj';font-size:20px;" ng-model="LIST_GMP.CER.COUNTRY_ID" data-live-search="true" title="-- Please select --">
                    @*<option value="0">--กรุณาเลือก--</option>*@
                    <option ng-repeat="x in CNT_LIST" value="{{x.IDA}}">{{x.engcntnm}}</option>
                </select>
            </td>
        </tr>
        <tr>
            <td style="height:25px">
                8. วันที่ออกใบรับรอง (Issue Date)<font color="red">*</font>
            </td>
            <td>

                <md-datepicker ng-model="LIST_GMP.CER.DOCUMENT_DATE" md-placeholder="Enter date"
                               input-aria-describedby="datepicker-description"
                               input-aria-labelledby="datepicker-header "></md-datepicker>

            </td>
        </tr>
        <tr>
            <td style="height:25px">
                วันที่หมดอายุใบรับรอง (Expiry Date / Valid Until)<font color="red">*</font>
            </td>
            <td>
                <md-datepicker ng-model="LIST_GMP.CER.EXP_DOCUMENT_DATE" md-placeholder="Enter date"
                               input-aria-describedby="datepicker-description"
                               input-aria-labelledby="datepicker-header "></md-datepicker>
            </td>
        </tr>
        <tr>
            <td style="height:25px">
                9. หน่วยงานที่ออกใบรับรอง (Certification Agency)<font color="red">*</font>
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
                <select class="form-control selectpicker" data-live-search="true" style="font-family:'Taviraj';font-size:20px;" ng-model="LIST_GMP.CER.COUNTRY_OF_DEPARTMENT_IDA" title="-- Please select --">
                    @*<option value="0">--กรุณาเลือก--</option>*@
                    <option ng-repeat="x in CNT_LIST" value="{{x.IDA}}">{{x.engcntnm}}</option>
                </select>
            </td>
        </tr>
    </table>
    <br />
    <h2 style="font-family:'Taviraj';font-size:24px;">
        รายละเอียดเภสัชเคมีภัณฑ์ที่ได้รับการรับรอง (Information of Drug Substance under the Certification)
    </h2>
    <table width="100%">
        <tr>
            <td style="height:25px;width:35%;font-family:'Taviraj';font-size:20px;">
                10. ขอบเขตของเภสัชเคมีภัณฑ์ที่ได้รับการรับรอง (Scope of Inspection / Certification)
            </td>
            <td>
                <input class="form-control inline" ng-model="LIST_GMP.CER.CER_SCOPE" style="font-family:'Taviraj';font-size:20px;" type="text" />
            </td>
        </tr>
    </table>
</div>