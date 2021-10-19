@Code
    Layout = ""
End Code

    <script type="text/javascript">
        $(document).ready(function () {
            $('select').selectpicker('refresh');
        })
    </script>

<div class="ic" > @*ng-repeat="datas in LIST_GMP"*@
    <h2 style="font-family:'Taviraj';font-size:24px;">
        <b> รายละเอียดใบรับรองสถานที่ผลิตเภสัชเคมีภัณฑ์</b>
    </h2>
    <h2 style="font-family:'Taviraj';font-size:24px;">
        <b> (Information of Certificate of Drug Substance Manufacturer)</b>
    </h2>
    <table width="100%" style="font-family:'Taviraj';font-size:20px;">
        <tr>
            <td style="height:25px;width:35%;">
                1. เลขที่ใบรับรอง (Certificate Number)<font color="red">*</font>
            </td>
            <td>
                <input class="form-control inline" ng-model="LIST_GMP.CER.CERTIFICATION_NUMBER_ALL" style="font-family:'Taviraj';font-size:20px;font:lighter" type="text" />
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
                3. เลขที่ใบอนุญาตผลิต (Manufacturing Licence Number)
            </td>
            <td>
                <input class="form-control inline" ng-model="LIST_GMP.CER.MANUFACTURER_LICENCE_NUMBER" style="font-family:'Taviraj';font-size:20px;" type="text" />
            </td>
        </tr>
        @*<tr>
            <td style="height:25px">
                Global Location Number (GLN) :
            </td>
            <td>
                <input class="form-control inline" ng-model="LIST_GMP.CER_DETAIL_MANUFACTURE.GLN" style="font-family:'Taviraj';font-size:20px;" type="text" />
            </td>
        </tr>*@
        <tr>
            <td style="height:25px">
                4. ที่ตั้ง (Site Address)<font color="red">*</font>
            </td>
            <td>
                <input class="form-control inline" ng-model="LIST_GMP.CER_DETAIL_MANUFACTURE.ADDRESS_NUMBER" style="font-family:'Taviraj';font-size:20px;" type="text" />
            </td>
        </tr>
        <tr>
            <td style="height:25px">
                5. เมือง (City / Province/ State)<font color="red">*</font>
            </td>
            <td>
                <input class="form-control inline" ng-model="LIST_GMP.CER_DETAIL_MANUFACTURE.ADDRESS_CITY" style="font-family:'Taviraj';font-size:20px;" type="text" />
            </td>
        </tr>
        <tr>
            <td style="height:25px">
                6. ประเทศ (Country<font color="red">*</font>
            </td>
            <td>
                <select style="font-family:'Taviraj';font-size:20px;" class="form-control selectpicker" data-live-search="true" title="-- Please select --" ng-model="LIST_GMP.CER.COUNTRY_ID">
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

        <tr>
            <td style="height:25px">
                7. วันที่ออกใบรับรอง GMP (Issue Date)<font color="red">*</font>
            </td>
            <td>
                <md-datepicker ng-model="LIST_GMP.CER.DOCUMENT_DATE" md-placeholder="Enter date"
                               input-aria-describedby="datepicker-description"
                               input-aria-labelledby="datepicker-header"></md-datepicker>
            </td>
        </tr>
        <tr>
            <td style="height:25px">
                วันที่หมดอายุใบรับรอง GMP (Expiry Date / Valid Until)<font color="red">*</font>
            </td>
            <td>
                <md-datepicker ng-model="LIST_GMP.CER.EXP_DOCUMENT_DATE" md-placeholder="Enter date"
                               input-aria-describedby="datepicker-description"
                               input-aria-labelledby="datepicker-header "></md-datepicker>
            </td>
        </tr>
        <tr>
            <td style="height:25px">
                8. หน่วยงานที่ออกใบรับรอง (Certification Agency)<font color="red">*</font>
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
        <tr>
            <td>
                <input type="radio" ng-model="LIST_GMP.CER.DEPARTMENT_REGIST_CER_TYPE" id="Rdl_department" value="1" />
                หน่วยงานรัฐที่ออกใบรับรอง (Government Certification Agency)
            </td>
            <td rowspan="2" ;">
                <input class="form-control inline" ng-model="LIST_GMP.CER.DEPARTMENT_REGIST_CER_NAME" style="font-family:'Taviraj';font-size:20px;height:100px;" type="text" />
            </td>
        </tr>
        <tr>
            <td style="height:25px">
                <input type="radio" ng-model="LIST_GMP.CER.DEPARTMENT_REGIST_CER_TYPE" id="Rdl_department" value="2" />
                หน่วยงานอื่นที่ได้รับการรับรองจากหน่วยงานรัฐของประเทศที่ออกใบรับรอง (Certification Agency Accredited by Government Agency)
            </td>
            <td>
            </td>
        </tr>
        <tr>
            <td style="height:25px">
                9. มาตรฐาน GMP ของสถานที่ผลิต (GMP Standard of Manufacturer)<font color="red">*</font>

            </td>
            <td>
                <table>
                    <tr>
                        <td style="height:25px">
                            <form name="rdl_gmp">
                                <label>
                                    <input type="radio" ng-model="LIST_GMP.CER_DETAIL_MANUFACTURE.STANDARD_ID" id="Rdl_gmpt" value="1">
                                    PIC/S GMP
                                </label>
                                <label>&nbsp;</label>
                                <label>
                                    <input type="radio" ng-model="LIST_GMP.CER_DETAIL_MANUFACTURE.STANDARD_ID" id="Rdl_gmpt" ng-value="2">
                                    WHO GMP
                                </label>
                                <label>&nbsp;</label>
                                <label>
                                    <input type="radio" ng-model="LIST_GMP.CER_DETAIL_MANUFACTURE.STANDARD_ID" id="Rdl_gmpt" value="3">
                                    National GMP
                                </label>
                            </form>
                        </td>
                        <td>
                            &nbsp; ประเทศ (Country)<font color="red">* &nbsp;&nbsp;</font>
                        </td>
                        <td>
                            <select style="font-family:'Taviraj';font-size:20px;" class="form-control selectpicker" data-live-search="true" title="-- Please select --" ng-model="LIST_GMP.CER_DETAIL_MANUFACTURE.COUNTRY_GMP">
                                @*<option value="0">--กรุณาเลือก--</option>*@
                                <option ng-repeat="x in CNT_LIST" value="{{x.IDA}}">{{x.engcntnm}}</option>
                            </select>

                        </td>
                    </tr>
                </table>


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
                10. ขอบเขตของเภสัชเคมีภัณฑ์ที่ได้รับการรับรอง (Scope of Inspection / Certification)
            </td>
            <td>
                <input class="form-control inline" ng-model="LIST_GMP.CER.CER_SCOPE" style="font-family:'Taviraj';font-size:20px;" type="text" />
            </td>
        </tr>
    </table>
    <br />
</div>
