@Code
    Layout = ""
End Code

@*<h2>INPUT_PICS</h2>*@

<div class="ic">
    <h2 style="font-family:'TH SarabunPSK';font-size:40px;">
        แบบกรอกรายละเอียดใบรับรองสถานที่ผลิตในต่างประเทศ
    </h2>
    <table width="100%" style="font-family:'TH SarabunPSK';font-size:20px;">
        <tr>
            <td style="height:25px">
                1. ชื่อสถานที่ผลิตในต่างประเทศ (Manufacturer)<font color="red">*</font> :
            </td>
            <td>
                <input class="form-control inline" ng-model="LIST_GMP.CER_DETAIL_MANUFACTURE.NAME_ADDRESS" style="font-family:'TH SarabunPSK';font-size:20px;" type="text" />
            </td>
        </tr>
        <tr>
            <td style="height:25px">
                2. ที่อยู่ (Address)<font color="red">*</font> :
            </td>
            <td>
                <input class="form-control inline" ng-model="LIST_GMP.CER_DETAIL_MANUFACTURE.ADDRESS_NUMBER" style="font-family:'TH SarabunPSK';font-size:20px;" type="text" />
            </td>
        </tr>
        <tr>
            <td style="height:25px">
                3. เมือง (City / Province/ State)<font color="red">*</font> :
            </td>
            <td>
                <input class="form-control inline" ng-model="LIST_GMP.CER_DETAIL_MANUFACTURE.ADDRESS_CITY" style="font-family:'TH SarabunPSK';font-size:20px;" type="text" />
            </td>
        </tr>
        <tr>
            <td style="height:25px">
                4. ประเทศ (Country)<font color="red">*</font> :
            </td>
            <td>
                <select style="font-family:'TH SarabunPSK';font-size:20px;" ng-model="LIST_GMP.CER.COUNTRY_ID">
                    <option value="0">--กรุณาเลือก--</option>
                    <option ng-repeat="x in CNT_LIST" value="{{x.IDA}}">{{x.engcntnm}}</option>
                </select>
            </td>
        </tr>
        <tr>
            <td style="height:25px">
                รหัสไปรษณีย์ (Post code/Zip code) :
            </td>
            <td>
                <input class="form-control inline" ng-model="LIST_GMP.CER_DETAIL_MANUFACTURE.ZIPCODE" style="font-family:'TH SarabunPSK';font-size:20px;" type="text" />
            </td>
        </tr>
        <tr>
            <td style="height:25px">
                5. สถานที่ผลิตได้มาตรฐาน GMP ตาม (โปรดระบุ) :
            </td>
            <td>
                <select style="font-family:'TH SarabunPSK';font-size:20px;" ng-model="LIST_GMP.CER_DETAIL_MANUFACTURE.LOCATION_STANDARD">
                    <option value="0">--กรุณาเลือก--</option>
                    <option value="1">PIC/S</option>
                    <option value="2">National GMP</option>
                    <option value="3">WHO GMP</option>
                </select>
            </td>
        </tr>
        <tr>
            <td style="height:25px">
                Global Location Number (GLN) :
            </td>
            <td>
                <input class="form-control inline" ng-model="LIST_GMP.CER_DETAIL_MANUFACTURE.GLN" style="font-family:'TH SarabunPSK';font-size:20px;" type="text" />
            </td>
        </tr>
        <tr>
            <td style="height:25px">
                6. วันเดือนปีการขายที่ระบุในหลักฐานการขาย<font color="red">*</font> :
            </td>
            <td>
                <md-datepicker ng-model="LIST_GMP.CER_DETAIL_MANUFACTURE.SALE_DATE" md-placeholder="Enter date"
                               input-aria-describedby="datepicker-description"
                               input-aria-labelledby="datepicker-header "></md-datepicker>
            </td>
        </tr>
        <tr>
            <td style="height:25px">
                7. ชื่อผู้ซื้อ (Purchaser)<font color="red">*</font>
            </td>
            <td>
                <input class="form-control inline" ng-model="LIST_GMP.CER.BUYER_NAME" style="font-family:'TH SarabunPSK';font-size:20px;" type="text" />

            </td>
        </tr>

        <tr>
            <td style="height:25px">
                8. ประเทศผู้ซื้อ (Purchaser's Country*)<font color="red">*</font>
            </td>
            <td>
                <select style="font-family:'TH SarabunPSK';font-size:20px;" ng-model="LIST_GMP.CER.BUYER_COUNTRY">
                    <option value="0">--กรุณาเลือก--</option>
                    <option ng-repeat="x in CNT_LIST" value="{{x.IDA}}">{{x.engcntnm}}</option>
                </select>

            </td>
        </tr>

        <tr>
            <td style="height:25px">
                9. มาตราฐานสถานที่ผลิตยาสำเร็จรูปของประเทศผู้ซื้อได้ GMP ตาม (โปรดระบุ)<font color="red">*</font> :
            </td>
            <td>
                <select style="font-family:'TH SarabunPSK';font-size:20px;" ng-model="LIST_GMP.CER.BUYER_STANDARD">
                    <option value="0">--กรุณาเลือก--</option>
                    <option value="1">ประเทศตามชื่อสมาชิก PIC/S</option>
                </select>
            </td>
        </tr>
    </table>
    <br />
    <h2>
        รายละเอียดผลิตภัณฑ์ที่ได้รับการรับรอง
    </h2>
    <table width="100%">
        <tr>
            <td style="height:25px;width:35%;">
                10. ขอบเขตของประเภทยาที่รับรอง
            </td>
            <td>
                <input class="form-control inline" ng-model="LIST_GMP.CER.CER_SCOPE" style="font-family:'TH SarabunPSK';font-size:20px;" type="text" />
            </td>
        </tr>
    </table>
</div>