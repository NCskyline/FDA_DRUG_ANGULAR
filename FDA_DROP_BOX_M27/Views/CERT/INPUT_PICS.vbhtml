@Code
    Layout = ""
End Code

@*<h2>INPUT_PICS</h2>*@

<script type="text/javascript">
        $(document).ready(function () {
            $('select').selectpicker('refresh');
        })
</script>


<div class="ic">
    <h2 style="font-family:'Taviraj';font-size:24px;">
        <b> รายละเอียดใบรับรองสถานที่ผลิตเภสัชเคมีภัณฑ์</b>
    </h2>
    <h2 style="font-family:'Taviraj';font-size:24px;">
        <b> (Information of Certificate of Drug Substance Manufacturer)</b>
    </h2>
    <table width="100%" style="font-family:'Taviraj';font-size:20px;">
        <tr>
            <td style="height:25px">
                1. ชื่อผู้ผลิตเภสัชเคมีภัณฑ์ (Drug Substance Manufacturer)<font color="red">*</font>
            </td>
            <td>
                <input class="form-control inline" ng-model="LIST_GMP.CER_DETAIL_MANUFACTURE.NAME_ADDRESS" style="font-family:'Taviraj';font-size:20px;" type="text" />
            </td>
        </tr>
        <tr>
            <td style="height:25px">
                2. ที่ตั้ง (Site Address)<font color="red">*</font>
            </td>
            <td>
                <input class="form-control inline" ng-model="LIST_GMP.CER_DETAIL_MANUFACTURE.ADDRESS_NUMBER" style="font-family:'Taviraj';font-size:20px;" type="text" />
            </td>
        </tr>
        <tr>
            <td style="height:25px">
                3. เมือง (City / Province / State)<font color="red">*</font>
            </td>
            <td>
                <input class="form-control inline" ng-model="LIST_GMP.CER_DETAIL_MANUFACTURE.ADDRESS_CITY" style="font-family:'Taviraj';font-size:20px;" type="text" />
            </td>
        </tr>
        <tr>
            <td style="height:25px">
                4. ประเทศ (Country)<font color="red">*</font>
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
        <tr>
            <td style="height:25px">
                5. วันที่ขายที่ระบุในหลักฐานการขาย (Sale Date on Purchase Order)<font color="red">*</font>
            </td>
            <td>
                <md-datepicker ng-model="LIST_GMP.CER_DETAIL_MANUFACTURE.SALE_DATE" md-placeholder="Enter date"
                               input-aria-describedby="datepicker-description"
                               input-aria-labelledby="datepicker-header "></md-datepicker>
            </td>
        </tr>
        <tr>
            <td style="height:25px">
                6. มาตรฐานสถานที่ผลิตเภสัชเคมีภัณฑ์ (Standard of Drug Substance Manufacturer)
            </td>
            <td>
                <select class="form-control selectpicker" data-live-search="true" title="-- Please select --" style="font-family:'Taviraj';font-size:20px;" ng-model="LIST_GMP.CER_DETAIL_MANUFACTURE.LOCATION_STANDARD">
                    @*<option value="0">--กรุณาเลือก--</option>*@
                    <option value="1">PIC/S</option>
                    <option value="2">National GMP</option>
                    <option value="3">WHO GMP</option>
                </select>
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
                7. ชื่อผู้ผลิตยาสำเร็จรูปในต่างประเทศที่เป็นผู้ซื้อ (Foreign Drug Product Manufacturer as Purchaser)<font color="red">*</font>
            </td>
            <td>
                <input class="form-control inline" ng-model="LIST_GMP.CER.BUYER_NAME" style="font-family:'Taviraj';font-size:20px;" type="text" />

            </td>
        </tr>

        <tr>
            <td style="height:25px">
                8. ประเทศผู้ซื้อ (Country of Purchaser)<font color="red">*</font>
            </td>
            <td>
                <select class="form-control selectpicker" data-live-search="true" title="-- Please select --" style="font-family:'Taviraj';font-size:20px;" ng-model="LIST_GMP.CER.BUYER_COUNTRY">
                    @*<option value="0">--กรุณาเลือก--</option>*@
                    <option ng-repeat="x in CNT_LIST" value="{{x.IDA}}">{{x.engcntnm}}</option>
                </select>

            </td>
        </tr>

        <tr>
            <td style="height:25px">
                9. มาตรฐาน GMP ของสถานที่ผลิตยาสำเร็จรูปของผู้ซื้อ (GMP Standard of Drug Product manufacturer as Purchaser)<font color="red">*</font>
            </td>
            <td>
                <select class="form-control selectpicker" data-live-search="true" title="-- Please select --" style="font-family:'Taviraj';font-size:20px;" ng-model="LIST_GMP.CER.BUYER_STANDARD">
                    @*<option value="0">--กรุณาเลือก--</option>*@
                    <option value="1">ประเทศตามชื่อสมาชิก PIC/S</option>
                </select>
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
</div>