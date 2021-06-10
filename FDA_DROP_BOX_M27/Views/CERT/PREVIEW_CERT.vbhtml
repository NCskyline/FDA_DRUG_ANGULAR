@Code
    ViewData("Title") = "PREVIEW_CERT"
End Code
<script src="~/Scripts_angular/ANGULAR_APP.js"></script>
<script src="~/Scripts_angular/CENTER_SV.js"></script>
<script src="~/Scripts_angular/CERT_GMP_CTRL.js"></script>

<div class="ic" ng-controller="CERT_GMP_CTRL" ng-app="ANGULAR_APP">
    <div ng-show="PROCESS == '31'" >
        @*ng-repeat="datas in LIST_GMP"*@
        <h2 style="font-family:'TH SarabunPSK';font-size:24px;">
            <b> แบบกรอกรายละเอียดใบรับรองสถานที่ผลิตในต่างประเทศ</b>
        </h2>
        <table width="100%" style="font-family:'TH SarabunPSK';font-size:20px;">
            <tr>
                <td style="height:25px;width:35%;">
                    1. เลขที่ใบรับรอง (Certificate Number)<font color="red">*</font>  :
                </td>
                <td>
                    <label>{{LIST_GMP.CER.CERTIFICATION_NUMBER_ALL}}</label>
                </td>
            </tr>
            <tr>
                <td style="height:25px">
                    2. ชื่อสถานที่ผลิตในต่างประเทศ (Manufacturer)<font color="red">*</font> :
                </td>
                <td>

                    <label>{{LIST_GMP.CER_DETAIL_MANUFACTURE.NAME_ADDRESS}}</label>
                </td>
            </tr>
            <tr>
                <td style="height:25px">
                    3. ที่อยู่ (Address)<font color="red">*</font> :
                </td>
                <td>

                    <label>{{LIST_GMP.CER_DETAIL_MANUFACTURE.ADDRESS_NUMBER}}</label>
                </td>
            </tr>
            <tr>
                <td style="height:25px">
                    4. เมือง (City / Province/ State)<font color="red">*</font> :
                </td>
                <td>

                    <label>{{LIST_GMP.CER_DETAIL_MANUFACTURE.ADDRESS_CITY}}</label>
                </td>
            </tr>
            <tr>
                <td style="height:25px">
                    5. ประเทศ (Country<font color="red">*</font> :
                </td>
                <td>
                    <select style="font-family:'TH SarabunPSK';font-size:20px;" ng-model="LIST_GMP.CER.COUNTRY_ID">
                        <option value="0">--กรุณาเลือก--</option>
                        <option ng-repeat="x in CNT_LIST" value="{{x.IDA}}">{{x.engcntnm}}</option>
                    </select>
                    @*<label>{{LCNNO_SHOW}}</label>*@
                </td>
            </tr>
            <tr>
                <td style="height:25px">
                    รหัสไปรษณีย์ (Post code/Zip code) :
                </td>
                <td>
                    <label>{{LIST_GMP.CER_DETAIL_MANUFACTURE.ZIPCODE}}</label>
                </td>
            </tr>
            <tr>
                <td style="height:25px">
                    6. Manufacturer&quot;s License Number :
                </td>
                <td>

                    <label>{{LIST_GMP.CER.MANUFACTURER_LICENCE_NUMBER}}</label>
                </td>
            </tr>
            <tr>
                <td style="height:25px">
                    Global Location Number (GLN) :
                </td>
                <td>
                    <label>{{LIST_GMP.CER_DETAIL_MANUFACTURE.GLN}}</label>
                </td>
            </tr>
            <tr>
                <td style="height:25px">
                    7. วันเดือนปีที่ออกหนังสือ GMP (Issue Date)<font color="red">*</font> :
                </td>
                <td>
                    <md-datepicker ng-model="LIST_GMP.CER.DOCUMENT_DATE" md-placeholder="Enter date"
                                   input-aria-describedby="datepicker-description"
                                   input-aria-labelledby="datepicker-header "></md-datepicker>

                    <label>{{LIST_GMP.CER.DOCUMENT_DATE}}</label>
                </td>
            </tr>
            <tr>
                <td style="height:25px">
                    วันเดือนปีที่หมดอายุ (Expiry Date)<font color="red">*</font> :
                </td>
                <td>
                    <md-datepicker ng-model="LIST_GMP.CER.EXP_DOCUMENT_DATE" md-placeholder="Enter date"
                                   input-aria-describedby="datepicker-description"
                                   input-aria-labelledby="datepicker-header "></md-datepicker>
                    <label>{{LIST_GMP.CER.EXP_DOCUMENT_DATE}}</label>
                </td>
            </tr>
            <tr>
                <td style="height:25px">
                    8. หน่วยงานที่ออกใบรับรอง<font color="red">*</font>
                </td>
                <td>
                    &nbsp;
                </td>
            </tr>
            <tr>
                <td>
                    <input type="radio" ng-model="LIST_GMP.CER.DEPARTMENT_REGIST_CER_TYPE" id="Rdl_department" value="1" />
                    ชื่อหน่วยงานรัฐของประเทศผู้ผลิต
                </td>
                <td rowspan="2" ;">
                    <input class="form-control inline" ng-model="LIST_GMP.CER.DEPARTMENT_REGIST_CER_NAME" style="font-family:'TH SarabunPSK';font-size:20px;height:100px;" type="text" />
                </td>
            </tr>
            <tr>
                <td style="height:25px">
                    <input type="radio" ng-model="LIST_GMP.CER.DEPARTMENT_REGIST_CER_TYPE" id="Rdl_department" value="2" />
                    ชื่อหน่วยงานอื่นที่ได้รับการรับรองจากหน่วยงานรัฐของประเทศผู้ผลิต
                </td>
                <td></td>
            </tr>
            <tr>
                <td style="height:25px">
                    9. สถานที่ผลิตได้มาตรฐาน GMP ตาม<font color="red">*</font> :

                </td>
                <td>
                    <table>
                        <tr>
                            <td style="height:25px">
                                <form name="rdl_gmp">

                                    <input type="radio" ng-model="LIST_GMP.CER_DETAIL_MANUFACTURE.STANDARD_ID" id="Rdl_gmpt" value="1">
                                    PIC / S GMP

                                    <input type="radio" ng-model="LIST_GMP.CER_DETAIL_MANUFACTURE.STANDARD_ID" id="Rdl_gmpt" ng-value="2">
                                    WHO GMP

                                    <input type="radio" ng-model="LIST_GMP.CER_DETAIL_MANUFACTURE.STANDARD_ID" id="Rdl_gmpt" value="3">
                                    National GMP

                                </form>
                            </td>
                            <td>
                                &nbsp; ประเทศ<font color="red">*</font>
                            </td>
                            <td>
                                @*<select style="font-family:'TH SarabunPSK';font-size:20px;" ng-model="LIST_GMP.CER_DETAIL_MANUFACTURE.COUNTRY_GMP">
                                        <option value="0">--กรุณาเลือก--</option>
                                        <option ng-repeat="x in CNT_LIST" value="{{x.IDA}}">{{x.engcntnm}}</option>
                                    </select>*@
                                <label>{{LCNNO_SHOW}}</label>
                            </td>
                        </tr>
                    </table>


                </td>
            </tr>
        </table>
        <br />
        <h2 style="font-family:'TH SarabunPSK';font-size:24px;">
            <b> รายละเอียดผลิตภัณฑ์ที่ได้รับการรับรอง </b>
        </h2>
        <table width="100%">
            <tr>
                <td style="height:25px;width:35%;">
                    10. ขอบเขตของประเภทยาที่รับรอง
                </td>
                <td>
                    <asp:Label ID="lbl_CER_SCOPE" runat="server" Text="-"></asp:Label>
                    <label>{{LCNNO_SHOW}}</label>
                </td>
            </tr>
        </table>
        <br />

        <div>
            <h2 style="font-family:'TH SarabunPSK';font-size:24px;">
                ไฟล์แนบ
            </h2>
            <table width="100%" style="font-family:'TH SarabunPSK';font-size:20px;">
                <tr>
                    <td>
                        ใบ CER GMP
                    </td>
                    <td></td>
                </tr>
                <tr>
                    <td>
                        อื่นๆ
                    </td>
                    <td></td>
                </tr>
            </table>
        </div>
    </div>
</div>