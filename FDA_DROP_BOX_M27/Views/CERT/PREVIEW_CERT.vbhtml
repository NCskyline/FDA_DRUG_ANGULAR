@Code
    ViewData("Title") = "PREVIEW_CERT"
End Code
<script src="~/Scripts_angular/ANGULAR_APP.js"></script>
<script src="~/Scripts_angular/CENTER_SV.js"></script>
<script src="~/Scripts_angular/CERT_GMP_CTRL.js"></script>

<div class="ic" ng-controller="CERT_GMP_CTRL" ng-app="ANGULAR_APP">
    @*-------------GMP------------------*@
    <div ng-show="LIST_GMP.CER.CER_TYPE == '31'">
        @*ng-repeat="datas in LIST_GMP"  ng-show="PROCESS == '31'" *@
        <h2 style="font-family:'Taviraj';font-size:24px;">
            <b> แบบกรอกรายละเอียดใบรับรองสถานที่ผลิตในต่างประเทศ (Certificate of GMP)</b>
        </h2>
        <table width="100%" style="font-family:'Taviraj';font-size:20px;" class="table">
            <tr>
                <td style="height:25px;width:35%;font-weight: bolder">
                    1. เลขที่ใบรับรอง (Certificate Number)<font color="red">*</font>  :
                </td>
                <td>
                    {{LIST_GMP.CER.CERTIFICATION_NUMBER_ALL}}
                </td>
            </tr>
            <tr>
                <td style="height:25px;font-weight: bolder">
                    2. ชื่อสถานที่ผลิตในต่างประเทศ (Manufacturer)<font color="red">*</font> :
                </td>
                <td>

                    {{LIST_GMP.CER_DETAIL_MANUFACTURE.NAME_ADDRESS}}
                </td>
            </tr>
            <tr>
                <td style="height:25px;font-weight: bolder">
                    3. ที่อยู่ (Address)<font color="red">*</font> :
                </td>
                <td>

                    {{LIST_GMP.CER_DETAIL_MANUFACTURE.ADDRESS_NUMBER}}
                </td>
            </tr>
            <tr>
                <td style="height:25px;font-weight: bolder">
                    4. เมือง (City / Province/ State)<font color="red">*</font> :
                </td>
                <td>
                    {{LIST_GMP.CER_DETAIL_MANUFACTURE.ADDRESS_CITY}}
                </td>
            </tr>
            <tr>
                <td style="height:25px;font-weight: bolder">
                    5. ประเทศ (Country)<font color="red">*</font> :
                </td>
                <td>
                    {{LIST_GMP.COUNTRY_NAME}}
                </td>
            </tr>
            <tr>
                <td style="height:25px;font-weight: bolder">
                    รหัสไปรษณีย์ (Post code/Zip code) :
                </td>
                <td>
                    {{LIST_GMP.CER_DETAIL_MANUFACTURE.ZIPCODE}}
                </td>
            </tr>
            <tr>
                <td style="height:25px;font-weight: bolder">
                    6. Manufacturer&quot;s License Number :
                </td>
                <td>
                    {{LIST_GMP.CER.MANUFACTURER_LICENCE_NUMBER}}
                </td>
            </tr>
            <tr>
                <td style="height:25px;font-weight: bolder">
                    Global Location Number (GLN) :
                </td>
                <td>
                    {{LIST_GMP.CER_DETAIL_MANUFACTURE.GLN}}
                </td>
            </tr>
            <tr>
                <td style="height:25px;font-weight: bolder">
                    7. วันเดือนปีที่ออกหนังสือ GMP (Issue Date)<font color="red">*</font> :
                </td>
                <td>
                    {{LIST_GMP.STR_DOCUMENT_DATE}}
                </td>
            </tr>
            <tr>
                <td style="height:25px;font-weight: bolder">
                    วันเดือนปีที่หมดอายุ (Expiry Date)<font color="red">*</font> :
                </td>
                <td>
                   
                    {{LIST_GMP.STR_EXP_DOCUMENT_DATE}}
                </td>
            </tr>
            <tr>
                <td style="height:25px;font-weight: bolder">
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
                    @*<input class="form-control inline" ng-model="LIST_GMP.CER.DEPARTMENT_REGIST_CER_NAME" style="font-family:'Taviraj';font-size:20px;height:100px;" type="text" />*@
                    {{LIST_GMP.CER.DEPARTMENT_REGIST_CER_NAME}}

                </td>
            </tr>
            <tr>
                <td style="height:25px;font-weight: bolder">
                    <input type="radio" ng-model="LIST_GMP.CER.DEPARTMENT_REGIST_CER_TYPE" id="Rdl_department" value="2" />
                    ชื่อหน่วยงานอื่นที่ได้รับการรับรองจากหน่วยงานรัฐของประเทศผู้ผลิต
                </td>
                <td></td>
            </tr>
            <tr>
                <td style="height:25px;font-weight: bolder">
                    9. สถานที่ผลิตได้มาตรฐาน GMP ตาม<font color="red">*</font> :

                </td>
                <td>
                    <table>
                        <tr>
                            <td style="height:25px">
                                <form name="rdl_gmp">

                                    <input type="radio" ng-model="LIST_GMP.CER_DETAIL_MANUFACTURE.STANDARD_ID" id="Rdl_gmpt" ng-value="1">
                                    PIC / S GMP

                                    <input type="radio" ng-model="LIST_GMP.CER_DETAIL_MANUFACTURE.STANDARD_ID" id="Rdl_gmpt" ng-value="2">
                                    WHO GMP

                                    <input type="radio" ng-model="LIST_GMP.CER_DETAIL_MANUFACTURE.STANDARD_ID" id="Rdl_gmpt" ng-value="3">
                                    National GMP

                                </form>
                            </td>
                            <td>
                                &nbsp; ประเทศ<font color="red">*</font>
                            </td>
                            <td style="height:25px">
                                @*<select style="font-family:'Taviraj';font-size:20px;" ng-model="LIST_GMP.CER_DETAIL_MANUFACTURE.COUNTRY_GMP">
                                        <option value="0">--กรุณาเลือก--</option>
                                        <option ng-repeat="x in CNT_LIST" value="{{x.IDA}}">{{x.engcntnm}}</option>
                                    </select>*@
                                &nbsp;   <label>{{LIST_GMP.COUNTRY_GMP_SHOW}}</label>
                            </td>
                        </tr>
                    </table>


                </td>
            </tr>
        </table>
        <br />
        <h2 style="font-family:'Taviraj';font-size:20px;">
            <b> รายละเอียดผลิตภัณฑ์ที่ได้รับการรับรอง </b>
        </h2>
        <table width="100%" style="font-family:'Taviraj';font-size:20px;">
            <tr>
                <td style="height:25px;width:35%;">
                    10. ขอบเขตของประเภทยาที่รับรอง
                </td>
                <td>

                    <label>{{LIST_GMP.CER.CER_SCOPE}}</label>
                </td>
            </tr>
        </table>
        <br />
        <div ng-include="INPUT_CHEM">

        </div>
        <br />
        <div>
            <h2 style="font-family:'Taviraj';font-size:20px;">
                ไฟล์แนบ
            </h2>
            <table width="100%" style="font-family:'Taviraj';font-size:20px;">
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
    @*-------------GMP------------------*@

    @*-------------ISO------------------*@
    <div ng-show="LIST_GMP.CER.CER_TYPE == '32'">
        <h2 style="font-family:'Taviraj';font-size:20px;">
            แบบกรอกรายละเอียดใบรับรองสถานที่ผลิตในต่างประเทศ (ISO)
        </h2>
        <table width="100%" style="font-family:'Taviraj';font-size:20px;">
            <tr>
                <td style="height:25px;width:35%;font-weight:bolder">
                    1. Certification Number/Registration Number/License Number<font color="red">*</font> :
                </td>
                <td>
                    <label>{{LIST_GMP.CER.CERTIFICATION_NUMBER_ALL}}</label>
                </td>
            </tr>
            <tr>
                <td style="height:25px;font-weight:bolder">
                    2. ชื่อสถานที่ผลิตในต่างประเทศ (Manufacturer)<font color="red">*</font> :
                </td>
                <td>
                    <label>{{LIST_GMP.CER_DETAIL_MANUFACTURE.NAME_ADDRESS}}</label>
                </td>
            </tr>
            <tr>
                <td style="height:25px;font-weight:bolder">
                    3. ที่อยู่ (Address)<font color="red">*</font> :
                </td>
                <td>
                    <label>{{LIST_GMP.CER_DETAIL_MANUFACTURE.ADDRESS_NUMBER}}</label>
                </td>
            </tr>
            <tr>
                <td style="height:25px;font-weight:bolder">
                    4. เมือง (City / Province/ State)<font color="red">*</font> :
                </td>
                <td>
                    <label>{{LIST_GMP.CER_DETAIL_MANUFACTURE.ADDRESS_CITY}}</label>
                </td>
            </tr>
            <tr>
                <td style="height:25px;font-weight:bolder">
                    5. ประเทศ (Country)<font color="red">*</font> :
                </td>
                <td>
                    <label>{{LIST_GMP.COUNTRY_NAME}}</label>
                </td>
            </tr>
            <tr>
                <td style="height:25px;font-weight:bolder">
                    รหัสไปรษณีย์ (Post code/Zip code) :
                </td>
                <td>
                    <label>{{LIST_GMP.CER_DETAIL_MANUFACTURE.ZIPCODE}}</label>
                </td>
            </tr>
            <tr>
                <td style="height:25px;font-weight:bolder">
                    6. Organization Code (รหัสองค์กร) :
                </td>
                <td>
                    <label>{{LIST_GMP.CER_DETAIL_MANUFACTURE.ORGANIZATION_CODE}}</label>
                </td>
            </tr>
            <tr>
                <td style="height: 25px;font-weight:bolder">
                    Global Location Number (GLN) :
                </td>
                <td>
                    <label>{{LIST_GMP.CER_DETAIL_MANUFACTURE.GLN}}</label>
                </td>
            </tr>
            <tr>
                <td style="height:25px;font-weight:bolder">
                    7. วันเดือนปีที่ออกหนังสือ ISO (Issue Date)<font color="red">*</font> :
                </td>
                <td>
                    <label>{{LIST_GMP.CER.DOCUMENT_DATE}}</label>
                </td>
            </tr>
            <tr>
                <td style="height:25px;font-weight:bolder">
                    วันเดือนปีที่หมดอายุ (Expiry Date) :
                </td>
                <td>
                    <label>{{LIST_GMP.CER.EXP_DOCUMENT_DATE}}</label>
                </td>
            </tr>
            <tr>
                <td style="height:25px;font-weight:bolder">
                    8. หน่วยงานที่ออกใบรับรอง (Certification Body)<font color="red">*</font>
                </td>
                <td>

                    <label>{{LIST_GMP.CER.DEPARTMENT_REGIST_CER_NAME}}</label>
                </td>
            </tr>
            <tr>
                <td style="height:25px;font-weight:bolder">
                    ประเทศของหน่วยงานที่ออกใบรับรอง :
                </td>
                <td>
                    <label>{{LIST_GMP.CER.COUNTRY_OF_DEPARTMENT_NAME}}</label>
                </td>
            </tr>
            <tr>
                <td style="height:25px;font-weight:bolder">
                    9. สถานที่ผลิตได้มาตรฐาน ISO ที่เกี่ยวกับการผลิต<font color="red">*</font> :
                </td>
                <td>
                    <label>{{LIST_GMP.CER_DETAIL_MANUFACTURE.DEPARTMENT_REGIST_CER_NAME}}</label>
                </td>
            </tr>
        </table>
        <br />
        <h2>
            รายละเอียดผลิตภัณฑ์ที่ได้รับการรับรอง
        </h2>
        <table width="100%">
            <tr>
                <td style="height:25px;width:35%;font-weight:bolder">
                    10. ขอบเขตของประเภทยาที่รับรอง
                </td>
                <td>
                    <label>{{LIST_GMP.CER.CER_SCOPE}}</label>
                </td>
            </tr>
        </table>
        <br />
        <div ng-include="INPUT_CHEM">

        </div>
        <br />
    </div>
    @*-------------ISO------------------*@
    @*-------------HACCP------------------*@
    <div class="ic" ng-show="LIST_GMP.CER.CER_TYPE == '33'">
        <h2 style="font-family: 'Taviraj';font-size: 20px;">
            แบบกรอกรายละเอียดใบรับรองสถานที่ผลิตในต่างประเทศ (HACCP)
        </h2>
        <table width="100%" style="font-family:'Taviraj';font-size:20px;">
            <tr>
                <td style="height:25px;width:35%;font-weight:bolder">
                    1. Certification number/Registration Number/License Number<font color="red">*</font> :
                </td>
                <td>
                    <label>{{LIST_GMP.CER.CERTIFICATION_NUMBER_ALL}}</label>
                </td>
            </tr>
            <tr>
                <td style="height:25px;font-weight:bolder">
                    2. ชื่อสถานที่ผลิตในต่างประเทศ (Manufacturer)<font color="red">*</font> :
                </td>
                <td>
                    <label>{{LIST_GMP.CER_DETAIL_MANUFACTURE.NAME_ADDRESS}}</label>
                </td>
            </tr>
            <tr>
                <td style="height:25px;font-weight:bolder">
                    3. ที่อยู่ (Address)<font color="red">*</font> :
                </td>
                <td>
                    <label>{{LIST_GMP.CER_DETAIL_MANUFACTURE.ADDRESS_NUMBER}}</label>
                </td>
            </tr>
            <tr>
                <td style="height:25px;font-weight:bolder">
                    4. เมือง (City / Province/ State)<font color="red">*</font> :
                </td>
                <td>
                    <label>{{LIST_GMP.CER_DETAIL_MANUFACTURE.ADDRESS_CITY}}</label>
                </td>
            </tr>
            <tr>
                <td style="height:25px;font-weight:bolder">
                    5. ประเทศ (Country)<font color="red">*</font> :
                </td>
                <td>
                    <label>{{LIST_GMP.COUNTRY_NAME}}</label>
                </td>
            </tr>
            <tr>
                <td style="height:25px;font-weight:bolder">
                    รหัสไปรษณีย์ (Post code/Zip code) :
                </td>
                <td>
                    <label>{{LIST_GMP.CER_DETAIL_MANUFACTURE.ZIPCODE}}</label>
                </td>
            </tr>
            <tr>
                <td style="height:25px;font-weight:bolder">
                    6. Organization Code (รหัสองค์กร)<font color="red">*</font> :
                </td>
                <td>
                    <label>{{LIST_GMP.CER_DETAIL_MANUFACTURE.ORGANIZATION_CODE}}</label>
                </td>
            </tr>
            <tr>
                <td style="height:25px;font-weight:bolder">
                    Global Location Number (GLN) :
                </td>
                <td>
                    <label>{{LIST_GMP.CER_DETAIL_MANUFACTURE.GLN}}</label>
                </td>
            </tr>
            <tr>
                <td style="height:25px;font-weight:bolder">
                    7. วันเดือนปีที่ออกหนังสือ HACCP (Issue Date)<font color="red">*</font> :
                </td>
                <td>
                    <label>{{LIST_GMP.CER.DOCUMENT_DATE}}</label>
                </td>
            </tr>
            <tr>
                <td style="height:25px;font-weight:bolder">
                    วันเดือนปีที่หมดอายุ (Expiry Date)<font color="red">*</font> :
                </td>
                <td>
                    <label>{{LIST_GMP.CER.EXP_DOCUMENT_DATE}}</label>
                </td>
            </tr>
            <tr>
                <td style="height:25px;font-weight:bolder">
                    8. หน่วยงานที่ออกใบรับรอง (Certification Body)
                </td>
                <td>
                    <label>{{LIST_GMP.CER.DEPARTMENT_REGIST_CER_NAME}}</label>

                </td>
            </tr>
            <tr>
                <td style="height:25px;font-weight:bolder">
                    ประเทศของหน่วยงานที่ออกใบรับรอง :
                </td>
                <td>
                    <label>{{LIST_GMP.CER_DETAIL_MANUFACTURE.COUNTRY_OF_DEPARTMENT_NAME}}</label>

                </td>
            </tr>
            <tr>
                <td style="height:25px;font-weight:bolder">
                    9. สถานที่ผลิตได้มาตฐาน HACCP ตาม :
                </td>
                <td>
                    <label>{{LIST_GMP.CER_DETAIL_MANUFACTURE.LOCATION_STANDARD}}</label>


                </td>
            </tr>
        </table>
        <br />
        <h2 style="font-family:'Taviraj';font-size:20px;">
            รายละเอียดผลิตภัณฑ์ที่ได้รับการรับรอง
        </h2>
        <table width="100%">
            <tr>
                <td style="height:25px;width:35%;font-weight:bolder">
                    10. ขอบเขตของประเภทยาที่รับรอง
                </td>
                <td>
                    <label>{{LIST_GMP.CER.CER_SCOPE}}</label>
                </td>
            </tr>
        </table>
        <br />
        <div ng-include="INPUT_CHEM">

        </div>
        <br />
    </div>
    @*-------------HACCP------------------*@
    @*-------------PICS------------------*@
    <div class="ic" ng-show="LIST_GMP.CER.CER_TYPE == '34'">
        <h2 style="font-family:'Taviraj';font-size:20px;">
            แบบกรอกรายละเอียดใบรับรองสถานที่ผลิตในต่างประเทศ (Purchase Order)
        </h2>
        <table width="100%" style="font-family:'Taviraj';font-size:20px;">
            <tr>
                <td style="height:25px;font-weight:bolder">
                    1. ชื่อสถานที่ผลิตในต่างประเทศ (Manufacturer)<font color="red">*</font> :
                </td>
                <td>
                    <label>{{LIST_GMP.CER.NAME_ADDRESS}}</label>
                </td>
            </tr>
            <tr>
                <td style="height:25px;font-weight:bolder">
                    2. ที่อยู่ (Address)<font color="red">*</font> :
                </td>
                <td>
                    <label>{{LIST_GMP.CER.ADDRESS_NUMBER}}</label>
                </td>
            </tr>
            <tr>
                <td style="height:25px;font-weight:bolder">
                    3. เมือง (City / Province/ State)<font color="red">*</font> :
                </td>
                <td>
                    <label>{{LIST_GMP.CER.ADDRESS_CITY}}</label>
                </td>
            </tr>
            <tr>
                <td style="height:25px;font-weight:bolder">
                    4. ประเทศ (Country)<font color="red">*</font> :
                </td>
                <td>
                    <label>{{LIST_GMP.COUNTRY_NAME}}</label>
                </td>
            </tr>
            <tr>
                <td style="height:25px;font-weight:bolder">
                    รหัสไปรษณีย์ (Post code/Zip code) :
                </td>
                <td>
                    <label>{{LIST_GMP.CER_DETAIL_MANUFACTURE.ZIPCODE}}</label>
                </td>
            </tr>
            <tr>
                <td style="height:25px;font-weight:bolder">
                    5. สถานที่ผลิตได้มาตรฐาน GMP ตาม (โปรดระบุ) :
                </td>
                <td>
                    <select style="font-family:'Taviraj';font-size:20px;" ng-model="LIST_GMP.CER_DETAIL_MANUFACTURE.LOCATION_STANDARD">
                        <option value="0">--กรุณาเลือก--</option>
                        <option value="1">PIC/S</option>
                        <option value="2">National GMP</option>
                        <option value="3">WHO GMP</option>
                    </select>
                </td>
            </tr>
            <tr>
                <td style="height: 25px;font-weight:bolder">
                    Global Location Number (GLN) :
                </td>
                <td>
                    <label>{{LIST_GMP.CER_DETAIL_MANUFACTURE.GLN}}</label>
                </td>
            </tr>
            <tr>
                <td style="height:25px;font-weight:bolder">
                    6. วันเดือนปีการขายที่ระบุในหลักฐานการขาย<font color="red">*</font> :
                </td>
                <td>
                    <label>{{LIST_GMP.CER.SALE_DATE}}</label>
                </td>
            </tr>
            <tr>
                <td style="height:25px;font-weight:bolder">
                    7. ชื่อผู้ซื้อ (Purchaser)<font color="red">*</font>
                </td>
                <td>
                    <input class="form-control inline" ng-model="LIST_GMP.CER.BUYER_NAME" style="font-family:'Taviraj';font-size:20px;" type="text" />
                    <label>{{LIST_GMP.CER.BUYER_NAME}}</label>
                </td>
            </tr>

            <tr>
                <td style="height: 25px;font-weight:bolder">
                    8. ประเทศผู้ซื้อ (Purchaser's Country*)<font color="red">*</font>
                </td>
                <td>
                    <label>{{LIST_GMP.BUYER_COUNTRY_NAME}}</label>
                </td>
            </tr>

            <tr>
                <td style="height:25px;font-weight:bolder">
                    9. มาตราฐานสถานที่ผลิตยาสำเร็จรูปของประเทศผู้ซื้อได้ GMP ตาม (โปรดระบุ)<font color="red">*</font> :
                </td>
                <td>
                    <select style="font-family:'Taviraj';font-size:20px;" ng-model="LIST_GMP.CER.BUYER_STANDARD">
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
                <td style="height:25px;width:35%;font-weight:bolder">
                    10. ขอบเขตของประเภทยาที่รับรอง
                </td>
                <td>
                    <label>{{LIST_GMP.CER.CER_SCOPE}}</label>
                </td>
            </tr>
        </table>
        <br />
        <div ng-include="INPUT_CHEM">

        </div>
        <br />
    </div>
    @*-------------PICS------------------*@
    @*-------------OTHER------------------*@
    <div class="ic" ng-show="LIST_GMP.CER.CER_TYPE == '36'">
        <h2 style="font-family:'Taviraj';font-size:20px;">
            แบบกรอกรายละเอียดใบรับรองสถานที่ผลิตในต่างประเทศ (Other)
        </h2>
        <table width="100%" style="font-family:'Taviraj';font-size:20px;">
            <tr>
                <td style="height:25px;width:35%;font-weight:bolder">
                    1. Reference Number<font color="red">*</font> :
                </td>
                <td>
                    <label>{{LIST_GMP.CER.CERTIFICATION_NUMBER_ALL}}</label>
                </td>
            </tr>
            <tr>
                <td style="font-weight:bolder">
                    2. ชื่อสถานที่ผลิตในต่างประเทศ (Manufacturer)<font color="red">*</font> :
                </td>
                <td>

                    <label>{{LIST_GMP.CER_DETAIL_MANUFACTURE.NAME_ADDRESS}}</label>
                </td>
            </tr>
            <tr>
                <td style="height:25px;font-weight:bolder">
                    3. ที่อยู่ (Address)<font color="red">*</font> :
                </td>
                <td>

                    <label>{{LIST_GMP.CER_DETAIL_MANUFACTURE.ADDRESS_NUMBER}}</label>
                </td>
            </tr>
            <tr>
                <td style="height:25px;font-weight:bolder">
                    4. เมือง (City / Province/ State)<font color="red">*</font> :
                </td>
                <td>

                    <label>{{LIST_GMP.CER_DETAIL_MANUFACTURE.ADDRESS_CITY}}</label>
                </td>
            </tr>
            <tr>
                <td style="height:25px;font-weight:bolder">
                    5. ประเทศ (Country)<font color="red">*</font> :
                </td>
                <td>
                    <label>{{LIST_GMP.COUNTRY_NAME}}</label>
                </td>
            </tr>
            <tr>
                <td style="height:25px;font-weight:bolder">
                    รหัสไปรษณีย์ (Post code/Zip code) :
                </td>
                <td>
                    <label>{{LIST_GMP.CER_DETAIL_MANUFACTURE.ZIPCODE}}</label>
                </td>
            </tr>
            <tr>
                <td style="height:25px;font-weight:bolder">
                    6. Manufactur&#39;s License Number<font color="red">*</font> :
                </td>
                <td>

                    <label>{{LIST_GMP.CER.MANUFACTURER_LICENCE_NUMBER}}</label>
                </td>
            </tr>
            <tr>
                <td style="height:25px;font-weight:bolder">
                    Global Location Number (GLN) :
                </td>
                <td>
                    <label>{{LIST_GMP.CER_DETAIL_MANUFACTURE.GLN}}</label>
                </td>
            </tr>
            <tr>
                <td style="height:25px;font-weight:bolder">
                    7. หน่วยงานที่ออกเอกสาร<font color="red">*</font> :
                </td>
                <td>
                    <label>{{LIST_GMP.CER.DEPARTMENT_REGIST_CER_NAME}}</label>
                </td>
            </tr>
            <tr>
                <td style="height:25px;font-weight:bolder">
                    ประเทศ (Country)<font color="red">*</font> :
                </td>
                <td>
                    <label>{{LIST_GMP.CER.COUNTRY_NAME}}</label>
                </td>
            </tr>
            <tr>
                <td style="font-weight:bolder">
                    8. เลขหนังสือให้ความเห็นชอบ<font color="red">*</font> :
                </td>
                <td>
                    <label>{{LIST_GMP.CER.DEPARTMENT_REGIST_CER_DOCNO}}</label>
                </td>
            </tr>
            <tr>
                <td style="height:25px;font-weight:bolder">
                    9. วันเดือนปีที่ออกหนังสือ (Issue Date)<font color="red">*</font> :
                </td>
                <td>
                    <label>{{LIST_GMP.CER.DOCUMENT_DATE}}</label>
                </td>
            </tr>
            <tr>
                <td style="height:25px;font-weight:bolder">
                    วันเดือนปีที่หมดอายุ (Expiry Date)<font color="red">*</font> :
                </td>
                <td>
                    <label>{{LIST_GMP.CER.EXP_DOCUMENT_DATE}}</label>
                </td>
            </tr>
            <tr>
                <td style="height:25px;font-weight:bolder">
                    ประเทศของหน่วยงานที่ออกใบรับรอง :
                </td>
                <td>
                    <label>{{LIST_GMP.COUNTRY_OF_DEPARTMENT_NAME}}</label>
                </td>
            </tr>
        </table>
        <br />
        <h2 style="font-family:'Taviraj';font-size:20px;">
            รายละเอียดผลิตภัณฑ์
        </h2>
        <table width="100%">
            <tr>
                <td style="height:25px;width:35%;font-weight:bolder">
                    10. ขอบข่าย
                </td>
                <td>
                    <label>{{LIST_GMP.CER.CER_SCOPE}}</label>
                </td>
            </tr>
        </table>
        <br />
        <div ng-include="INPUT_CHEM">

        </div>
        <br />
    </div>
    @*-------------OTHER------------------*@

    <div style="text-align:center">
        <input type="button" class="btn btn-lg" ng-click="BTN_BACK()" value="ย้อนกลับ" />
        <input type="button" class="btn btn-lg" ng-click="PDF_PREVIEW()" value="PDF PREVIEW" />
    </div>

</div>