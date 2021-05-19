@Code
    ViewData("Title") = "INPUT_HACCP"
End Code
<script src="~/Scripts_angular/CENTER_SV.js"></script>
<script src="~/Scripts_angular/CERT_GMP_CTRL.js"></script>
<div class="ic" ng-controller="CERT_GMP_CTRL" ng-app="ANGULAR_APP">
    <h2 style="font-family:'TH SarabunPSK';font-size:24px;">
        แบบกรอกรายละเอียดใบรับรองสถานที่ผลิตในต่างประเทศ
    </h2>
    <table width="100%" style="font-family:'TH SarabunPSK';font-size:20px;">
        <tr>
            <td style="height:25px;width:35%;">
                1. Certification number/Registration Number/License Number<font color="red">*</font> :
            </td>
            <td>
                <input class="form-control inline" style="font-family:'TH SarabunPSK';font-size:20px;" type="text" />
            </td>
        </tr>
        <tr>
            <td style="height:25px">
                2. ชื่อสถานที่ผลิตในต่างประเทศ (Manufacturer)<font color="red">*</font> :
            </td>
            <td>
                <input class="form-control inline" style="font-family:'TH SarabunPSK';font-size:20px;" type="text" />
            </td>
        </tr>
        <tr>
            <td style="height:25px">
                3. ที่อยู่ (Address)<font color="red">*</font> :
            </td>
            <td>
                <input class="form-control inline" style="font-family:'TH SarabunPSK';font-size:20px;" type="text" />
            </td>
        </tr>
        <tr>
            <td style="height:25px">
                4. เมือง (City / Province/ State)<font color="red">*</font> :
            </td>
            <td>
                <input class="form-control inline" style="font-family:'TH SarabunPSK';font-size:20px;" type="text" />
            </td>
        </tr>
        <tr>
            <td style="height:25px">
                5. ประเทศ (Country)<font color="red">*</font> :
            </td>
            <td>
                <select style="font-family:'TH SarabunPSK';font-size:20px;" id="ddl_country1">
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
                <input class="form-control inline" style="font-family:'TH SarabunPSK';font-size:20px;" type="text" />
            </td>
        </tr>
        <tr>
            <td style="height:25px">
                6. Organization Code (รหัสองค์กร)<font color="red">*</font> :
            </td>
            <td>
                <input class="form-control inline" style="font-family:'TH SarabunPSK';font-size:20px;" type="text" />
            </td>
        </tr>
        <tr>
            <td style="height:25px">
                Global Location Number (GLN) :
            </td>
            <td>
                <input class="form-control inline" style="font-family:'TH SarabunPSK';font-size:20px;" type="text" />
            </td>
        </tr>
        <tr>
            <td style="height:25px">
                7. วันเดือนปีที่ออกหนังสือ HACCP (Issue Date)<font color="red">*</font> :
            </td>
            <td>
                <md-datepicker ng-model="datas.START_DATE" md-placeholder="Enter date" id="start_date"
                               input-aria-describedby="datepicker-description"
                               input-aria-labelledby="datepicker-header "></md-datepicker>
            </td>
        </tr>
        <tr>
            <td style="height:25px">
                วันเดือนปีที่หมดอายุ (Expiry Date)<font color="red">*</font> :
            </td>
            <td>
                <md-datepicker ng-model="datas.END_DATE" md-placeholder="Enter date" id="end_date"
                               input-aria-describedby="datepicker-description"
                               input-aria-labelledby="datepicker-header "></md-datepicker>
            </td>
        </tr>
        <tr>
            <td style="height:25px">
                8. หน่วยงานที่ออกใบรับรอง (Certification Body)
            </td>
            <td>
                <input class="form-control inline" style="font-family:'TH SarabunPSK';font-size:20px;" type="text" />

            </td>
        </tr>
        <tr>
            <td style="height:25px">
                ประเทศของหน่วยงานที่ออกใบรับรอง :
            </td>
            <td>
                <select style="font-family:'TH SarabunPSK';font-size:20px;" id="ddl_country2">
                    <option value="0">--กรุณาเลือก--</option>
                    <option ng-repeat="x in CNT_LIST" value="{{x.IDA}}">{{x.engcntnm}}</option>
                </select>
            </td>
        </tr>
        <tr>
            <td style="height:25px">
                9. สถานที่ผลิตได้มาตฐาน HACCP ตาม :
            </td>
            <td>
                <input class="form-control inline" style="font-family:'TH SarabunPSK';font-size:20px;" type="text" />


            </td>
        </tr>
    </table>
    <br />
    <h2 style="font-family:'TH SarabunPSK';font-size:24px;">
        รายละเอียดผลิตภัณฑ์ที่ได้รับการรับรอง
    </h2>
    <table width="100%">
        <tr>
            <td style="height:25px;width:35%;">
                10. ขอบเขตของประเภทยาที่รับรอง
            </td>
            <td>
                <input class="form-control inline" style="font-family:'TH SarabunPSK';font-size:20px;" type="text" />
            </td>
        </tr>
    </table>
</div>