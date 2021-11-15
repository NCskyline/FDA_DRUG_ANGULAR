@Code

End Code

<script src="../Scripts_angular/ANGULAR_APP.js"></script>
<script src="../Scripts_angular/CENTER_SV.js"></script>
<script src="../Scripts_angular/DH_STAFF_CTRL.js"></script>

<div ng-controller="DH_STAFF_CTRL" ng-app="ANGULAR_APP" ng-init="PREVIEW_CER()">
    <div>
        <div class="content-part">
            <div class="part part-2-3 ic">
                @*-------------GMP------------------*@
                <div ng-show="LIST_GMP.CER.CER_TYPE == '31'">
                    @*ng-repeat="datas in LIST_GMP"  ng-show="PROCESS == '31'" *@
                    <h2 style="font-family:'Taviraj';font-size:24px;">
                        <b> รายละเอียดใบรับรองสถานที่ผลิตเภสัชเคมีภัณฑ์</b>
                    </h2>
                    <h2 style="font-family:'Taviraj';font-size:24px;">
                        <b>(Information of Certificate of Drug Substance Manufacturer)</b>
                    </h2>
                    <table width="100%" style="font-family:'Taviraj';font-size:20px;" class="table">
                        <tr>
                            <td style="height:25px;width:35%;font-weight: bolder">
                                1. เลขที่ใบรับรอง (Certificate Number)<font color="red">*</font>
                            </td>
                            <td style="border-bottom:dotted;border-bottom-width:thin">
                                {{LIST_GMP.CER.CERTIFICATION_NUMBER_ALL}}
                            </td>
                        </tr>
                        <tr>
                            <td style="height:25px;font-weight: bolder">
                                2. ชื่อผู้ผลิต (Manufacturer)<font color="red">*</font>
                            </td>
                            <td>

                                {{LIST_GMP.CER_DETAIL_MANUFACTURE.NAME_ADDRESS}}
                            </td>
                        </tr>
                        <tr>
                            <td style="height:25px;font-weight: bolder">
                                3. เลขที่ใบอนุญาตผลิต (Manufacturing Licence Number)
                            </td>
                            <td>
                                {{LIST_GMP.CER.MANUFACTURER_LICENCE_NUMBER}}
                            </td>
                        </tr>
                        <tr>
                            <td style="height:25px;font-weight: bolder">
                                4. ที่ตั้ง (Site Address)<font color="red">*</font>
                            </td>
                            <td>

                                {{LIST_GMP.CER_DETAIL_MANUFACTURE.ADDRESS_NUMBER}}
                            </td>
                        </tr>
                        <tr>
                            <td style="height:25px;font-weight: bolder">
                                5. เมือง (City / Province / State)<font color="red">*</font>
                            </td>
                            <td>
                                {{LIST_GMP.CER_DETAIL_MANUFACTURE.ADDRESS_CITY}}
                            </td>
                        </tr>
                        <tr>
                            <td style="height:25px;font-weight: bolder">
                                6. ประเทศ (Country)<font color="red">*</font>
                            </td>
                            <td>
                                {{LIST_GMP.COUNTRY_NAME}}
                            </td>
                        </tr>
                        <tr>
                            <td style="height:25px;font-weight: bolder">
                                <span style="padding-left:1em">รหัสไปรษณีย์ (Postal Code / Zip Code)</span>
                            </td>
                            <td>
                                {{LIST_GMP.CER_DETAIL_MANUFACTURE.ZIPCODE}}
                            </td>
                        </tr>
                        <tr>
                            <td style="height:25px;font-weight: bolder">
                                7. วันที่ออกใบรับรอง GMP (Issue Date)<font color="red">*</font>
                            </td>
                            <td>
                                {{LIST_GMP.STR_DOCUMENT_DATE}}
                            </td>
                        </tr>
                        <tr>
                            <td style="height:25px;font-weight: bolder">
                                <span style="padding-left:1em">วันที่หมดอายุใบรับรอง GMP (Expiry Date / Valid Until)<font color="red">*</font></span>
                            </td>
                            <td>

                                {{LIST_GMP.STR_EXP_DOCUMENT_DATE}}
                            </td>
                        </tr>
                        <tr>
                            <td style="height:25px;font-weight: bolder">
                                8. หน่วยงานที่ออกใบรับรอง (Certification Agency)<font color="red">*</font>
                            </td>
                            <td>
                                &nbsp;
                            </td>
                        </tr>
                        <tr>
                            <td style="height:25px;font-weight: bolder">
                                <span style="padding-left:1em">
                                    <input type="radio" ng-model="LIST_GMP.CER.DEPARTMENT_REGIST_CER_TYPE" id="Rdl_department" value="1" />
                                    หน่วยงานรัฐที่ออกใบรับรอง (Government Certification Agency)
                                </span>
                            </td>
                            <td rowspan="2">
                                @*<input class="form-control inline" ng-model="LIST_GMP.CER.DEPARTMENT_REGIST_CER_NAME" style="font-family:'Taviraj';font-size:20px;height:100px;" type="text" />*@
                                {{LIST_GMP.CER.DEPARTMENT_REGIST_CER_NAME}}

                            </td>
                        </tr>
                        <tr>
                            <td style="height:25px;font-weight: bolder">
                                <span style="padding-left:1em">
                                    <input type="radio" ng-model="LIST_GMP.CER.DEPARTMENT_REGIST_CER_TYPE" id="Rdl_department" value="2" />
                                    หน่วยงานอื่นที่ได้รับการรับรองจากหน่วยงานรัฐของประเทศที่ออกใบรับรอง (Certification Agency Accredited by Government Agency)
                                </span>
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
                                                <label>
                                                    <input type="radio" ng-model="LIST_GMP.CER_DETAIL_MANUFACTURE.STANDARD_ID" id="Rdl_gmpt" ng-value="1">
                                                    PIC / S GMP
                                                </label>
                                                <label>&nbsp;</label>
                                                <label>
                                                    <input type="radio" ng-model="LIST_GMP.CER_DETAIL_MANUFACTURE.STANDARD_ID" id="Rdl_gmpt" ng-value="2">
                                                    WHO GMP
                                                </label>
                                                <label>&nbsp;</label>
                                                <label>
                                                    <input type="radio" ng-model="LIST_GMP.CER_DETAIL_MANUFACTURE.STANDARD_ID" id="Rdl_gmpt" ng-value="3">
                                                    National GMP
                                                </label>
                                            </form>
                                        </td>
                                        <td style="height:25px;font-weight: bolder">
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
                    <h2 style="font-family:'Taviraj';font-size:24px;">
                        <b>รายละเอียดเภสัชเคมีภัณฑ์ที่ได้รับการรับรอง (Information of Drug Substances under Certification)</b>
                    </h2>
                    <table width="100%" style="font-family:'Taviraj';font-size:20px;">
                        <tr>
                            <td style="height:25px;width:35%;font-weight: bolder">
                                10. ขอบเขตของเภสัชเคมีภัณฑ์ที่ได้รับการรับรอง (Scope of Inspection / Certification)
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
                        <table class="table" style="width:100%">
                            <tr>
                                <td>ชื่อไฟล์</td>
                                <td></td>
                            </tr>
                            <tr ng-repeat="datas in LIST_File.FILE_LISTs" style="background-color:#FDFCE3">
                                <td>{{datas.FILENAME}}</td>
                                <td>
                                    <a ng-show="datas.PATH != null && datas.PATH != ''" ng-click="OPEN_DOC_PATH(datas.PATH,datas.FILENAME)">ดูเอกสาร</a>
                                </td>
                            </tr>
                        </table>
                    </div>
                </div>
                @*-------------GMP------------------*@

                @*-------------ISO------------------*@
            <div ng-show="LIST_GMP.CER.CER_TYPE == '32'">
                <h2 style="font-family:'Taviraj';font-size:24px;">
                    <b>รายละเอียดใบรับรองสถานที่ผลิตเภสัชเคมีภัณฑ์</b>
                </h2>
                <h2 style="font-family:'Taviraj';font-size:24px;">
                    <b>(Information of Certificate of Drug Substance Manufacturer)</b>
                </h2>
                <table width="100%" style="font-family:'Taviraj';font-size:20px;">
                    <tr>
                        <td style="height:25px;width:35%;font-weight:bolder">
                            1. เลขที่ใบรับรอง (Certificate Number / Registration Number)<font color="red">*</font>
                        </td>
                        <td>
                            <label>{{LIST_GMP.CER.CERTIFICATION_NUMBER_ALL}}</label>
                        </td>
                    </tr>
                    <tr>
                        <td style="height:25px;font-weight:bolder">
                            2. ชื่อผู้ผลิต (Manufacturer)<font color="red">*</font>
                        </td>
                        <td>
                            <label>{{LIST_GMP.CER_DETAIL_MANUFACTURE.NAME_ADDRESS}}</label>
                        </td>
                    </tr>
                    <tr>
                        <td style="height:25px;font-weight:bolder">
                            3. ที่ตั้ง (Site Address)<font color="red">*</font>
                        </td>
                        <td>
                            <label>{{LIST_GMP.CER_DETAIL_MANUFACTURE.ADDRESS_NUMBER}}</label>
                        </td>
                    </tr>
                    <tr>
                        <td style="height:25px;font-weight:bolder">
                            4. เมือง (City / Province / State)<font color="red">*</font>
                        </td>
                        <td>
                            <label>{{LIST_GMP.CER_DETAIL_MANUFACTURE.ADDRESS_CITY}}</label>
                        </td>
                    </tr>
                    <tr>
                        <td style="height:25px;font-weight:bolder">
                            5. ประเทศ (Country)<font color="red">*</font>
                        </td>
                        <td>
                            <label>{{LIST_GMP.COUNTRY_NAME}}</label>
                        </td>
                    </tr>
                    <tr>
                        <td style="height:25px;font-weight:bolder">
                            <span style="padding-left:1em">รหัสไปรษณีย์ (Postal Code / Zip Code)</span>
                        </td>
                        <td>
                            <label>{{LIST_GMP.CER_DETAIL_MANUFACTURE.ZIPCODE}}</label>
                        </td>
                    </tr>
                    <tr>
                        <td style="height:25px;font-weight:bolder">
                            6. วันที่ออกใบรับรอง ISO (Issue Date)<font color="red">*</font>
                        </td>
                        <td>
                            <label>{{LIST_GMP.CER.DOCUMENT_DATE}}</label>
                        </td>
                    </tr>
                    <tr>
                        <td style="height:25px;font-weight:bolder">
                            <span style="padding-left:1em">วันที่หมดอายุใบรับรอง ISO (Expiry Date / Valid Until)<font color="red">*</font></span>
                        </td>
                        <td>
                            <label>{{LIST_GMP.CER.EXP_DOCUMENT_DATE}}</label>
                        </td>
                    </tr>
                    <tr>
                        <td style="height:25px;font-weight:bolder">
                            7. หน่วยงานที่ออกใบรับรอง (Certification Agency)<font color="red">*</font>
                        </td>
                        <td>

                            <label>{{LIST_GMP.CER.DEPARTMENT_REGIST_CER_NAME}}</label>
                        </td>
                    </tr>
                    <tr>
                        <td style="height:25px;font-weight:bolder">
                            <span style="padding-left:1em">ประเทศของหน่วยงานที่ออกใบรับรอง (Country of Certification Agency)</span>
                        </td>
                        <td>
                            <label>{{LIST_GMP.CER.COUNTRY_OF_DEPARTMENT_NAME}}</label>
                        </td>
                    </tr>
                    <tr>
                        <td style="height:25px;font-weight:bolder">
                            8. มาตรฐาน ISO เกี่ยวกับการผลิตของสถานที่ผลิต ต.ย. ISO 9001 : 2015, ISO 22000 : 2018 (ISO Standard for Production of Manufacturer e.g. ISO 9001 : 2015, ISO 22000 : 2018)<font color="red">*</font>
                        </td>
                        <td>
                            <label>{{LIST_GMP.CER_DETAIL_MANUFACTURE.DEPARTMENT_REGIST_CER_NAME}}</label>
                        </td>
                    </tr>
                </table>
                <br />
                <h2 style="font-family:'Taviraj';font-size:24px;">
                    <b>รายละเอียดเภสัชเคมีภัณฑ์ที่ได้รับการรับรอง (Information of Drug Substances under Certification)</b>
                </h2>
                <table width="100%">
                    <tr>
                        <td style="height:25px;width:35%;font-weight: bolder;font-family:'Taviraj';font-size:20px;">
                            9. ขอบเขตของเภสัชเคมีภัณฑ์ที่ได้รับการรับรอง (Scope of Inspection / Certification)
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
                    <table class="table" style="width:100%">
                        <tr>
                            <td>ชื่อไฟล์</td>
                            <td></td>
                        </tr>
                        <tr ng-repeat="datas in LIST_File.FILE_LISTs" style="background-color:#FDFCE3">
                            <td>{{datas.FILENAME}}</td>
                            <td>
                                <a ng-show="datas.PATH != null && datas.PATH != ''" ng-click="OPEN_DOC_PATH(datas.PATH,datas.FILENAME)">ดูเอกสาร</a>
                            </td>
                        </tr>
                    </table>
                </div>
            </div>
                @*-------------ISO------------------*@
                @*-------------HACCP------------------*@
            <div class="ic" ng-show="LIST_GMP.CER.CER_TYPE == '33'">
                <h2 style="font-family:'Taviraj';font-size:24px;">
                    <b>รายละเอียดใบรับรองสถานที่ผลิตเภสัชเคมีภัณฑ์</b>
                </h2>
                <h2 style="font-family:'Taviraj';font-size:24px;">
                    <b>(Information of Certificate of Drug Substance Manufacturer)</b>
                </h2>
                <table width="100%" style="font-family:'Taviraj';font-size:20px;">
                    <tr>
                        <td style="height:25px;width:35%;font-weight:bolder">
                            1. เลขที่ใบรับรอง (Certificate Number / Registration Number)<font color="red">*</font>
                        </td>
                        <td>
                            <label>{{LIST_GMP.CER.CERTIFICATION_NUMBER_ALL}}</label>
                        </td>
                    </tr>
                    <tr>
                        <td style="height:25px;font-weight:bolder">
                            2. ชื่อผู้ผลิต (Manufacturer)<font color="red">*</font>
                        </td>
                        <td>
                            <label>{{LIST_GMP.CER_DETAIL_MANUFACTURE.NAME_ADDRESS}}</label>
                        </td>
                    </tr>
                    <tr>
                        <td style="height:25px;font-weight:bolder">
                            3. ที่ตั้ง (Site Address)<font color="red">*</font>
                        </td>
                        <td>
                            <label>{{LIST_GMP.CER_DETAIL_MANUFACTURE.ADDRESS_NUMBER}}</label>
                        </td>
                    </tr>
                    <tr>
                        <td style="height:25px;font-weight:bolder">
                            4. เมือง (City / Province / State)<font color="red">*</font>
                        </td>
                        <td>
                            <label>{{LIST_GMP.CER_DETAIL_MANUFACTURE.ADDRESS_CITY}}</label>
                        </td>
                    </tr>
                    <tr>
                        <td style="height:25px;font-weight:bolder">
                            5. ประเทศ (Country)<font color="red">*</font>
                        </td>
                        <td>
                            <label>{{LIST_GMP.COUNTRY_NAME}}</label>
                        </td>
                    </tr>
                    <tr>
                        <td style="height:25px;font-weight:bolder">
                            <span style="padding-left:1em">รหัสไปรษณีย์ (Post Code/Zip Code)</span>
                        </td>
                        <td>
                            <label>{{LIST_GMP.CER_DETAIL_MANUFACTURE.ZIPCODE}}</label>
                        </td>
                    </tr>
                    <tr>
                        <td style="height:25px;font-weight:bolder">
                            6. วันที่ออกใบรับรอง HACCP (Issue Date)<font color="red">*</font>
                        </td>
                        <td>
                            <label>{{LIST_GMP.CER.DOCUMENT_DATE}}</label>
                        </td>
                    </tr>
                    <tr>
                        <td style="height:25px;font-weight:bolder">
                            <span style="padding-left:1em">วันที่หมดอายุใบรับรอง HACCP (Expiry Date / Valid Until)<font color="red">*</font></span>
                        </td>
                        <td>
                            <label>{{LIST_GMP.CER.EXP_DOCUMENT_DATE}}</label>
                        </td>
                    </tr>
                    <tr>
                        <td style="height:25px;font-weight:bolder">
                            7. หน่วยงานที่ออกใบรับรอง (Certification Agency)
                        </td>
                        <td>
                            <label>{{LIST_GMP.CER.DEPARTMENT_REGIST_CER_NAME}}</label>

                        </td>
                    </tr>
                    <tr>
                        <td style="height:25px;font-weight:bolder">
                            <span style="padding-left:1em">ประเทศของหน่วยงานที่ออกใบรับรอง (Country of Certification Agency)</span>
                        </td>
                        <td>
                            <label>{{LIST_GMP.CER_DETAIL_MANUFACTURE.COUNTRY_OF_DEPARTMENT_NAME}}</label>

                        </td>
                    </tr>
                    <tr>
                        <td style="height:25px;font-weight:bolder">
                            8. มาตฐาน HACCP ขแงสถานที่ผลิต ต.ย. Codex General Principles of Food Hygiene CAC/RCP 1-1969 (HACCP Standard of Manufacturer e.g. Codex General Principles of Food Hygiene CAC/RCP 1-1969)
                        </td>
                        <td>
                            <label>{{LIST_GMP.CER_DETAIL_MANUFACTURE.LOCATION_STANDARD}}</label>


                        </td>
                    </tr>
                </table>
                <br />
                <h2 style="font-family:'Taviraj';font-size:24px;">
                    <b>รายละเอียดเภสัชเคมีภัณฑ์ที่ได้รับการรับรอง (Information of Drug Substances under Certification)</b>
                </h2>
                <table width="100%">
                    <tr>
                        <td style="height:25px;width:35%;font-weight:bolder">
                            9. ขอบเขตของเภสัชเคมีภัณฑ์ที่ได้รับการรับรอง (Scope of Inspection / Certification)
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
                    <table class="table" style="width:100%">
                        <tr>
                            <td>ชื่อไฟล์</td>
                            <td></td>
                        </tr>
                        <tr ng-repeat="datas in LIST_File.FILE_LISTs" style="background-color:#FDFCE3">
                            <td>{{datas.FILENAME}}</td>
                            <td>
                                <a ng-show="datas.PATH != null && datas.PATH != ''" ng-click="OPEN_DOC_PATH(datas.PATH,datas.FILENAME)">ดูเอกสาร</a>
                            </td>
                        </tr>
                    </table>
                </div>
            </div>
                @*-------------HACCP------------------*@
                @*-------------PICS------------------*@
            <div class="ic" ng-show="LIST_GMP.CER.CER_TYPE == '34'">
                <h2 style="font-family:'Taviraj';font-size:24px;">
                    <b>รายละเอียดใบรับรองสถานที่ผลิตเภสัชเคมีภัณฑ์</b>
                </h2>
                <h2 style="font-family:'Taviraj';font-size:24px;">
                    <b>(Information of Certificate of Drug Substance Manufacturer)</b>
                </h2>
                <table width="100%" style="font-family:'Taviraj';font-size:20px;">
                    <tr>
                        <td style="height:25px;font-weight:bolder">
                            1. ชื่อผู้ผลิตเภสัชเคมีภัณฑ์ (Drug Substance Manufacturer)<font color="red">*</font>
                        </td>
                        <td>
                            <label>{{LIST_GMP.CER.NAME_ADDRESS}}</label>
                        </td>
                    </tr>
                    <tr>
                        <td style="height:25px;font-weight:bolder">
                            2. ที่ตั้ง (Site Address)<font color="red">*</font>
                        </td>
                        <td>
                            <label>{{LIST_GMP.CER.ADDRESS_NUMBER}}</label>
                        </td>
                    </tr>
                    <tr>
                        <td style="height:25px;font-weight:bolder">
                            3. เมือง (City / Province / State)<font color="red">*</font>
                        </td>
                        <td>
                            <label>{{LIST_GMP.CER.ADDRESS_CITY}}</label>
                        </td>
                    </tr>
                    <tr>
                        <td style="height:25px;font-weight:bolder">
                            4. ประเทศ (Country)<font color="red">*</font>
                        </td>
                        <td>
                            <label>{{LIST_GMP.COUNTRY_NAME}}</label>
                        </td>
                    </tr>
                    <tr>
                        <td style="height:25px;font-weight:bolder">
                            <span style="padding-left:1em">รหัสไปรษณีย์ (Postal Code / Zip Code)</span>
                        </td>
                        <td>
                            <label>{{LIST_GMP.CER_DETAIL_MANUFACTURE.ZIPCODE}}</label>
                        </td>
                    </tr>
                    <tr>
                        <td style="height:25px;font-weight:bolder">
                            5. วันที่ขายที่ระบุในหลักฐานการขาย (Sale Date on Purchase Order)<font color="red">*</font>
                        </td>
                        <td>
                            <label>{{LIST_GMP.CER.SALE_DATE}}</label>
                        </td>
                    </tr>
                    <tr>
                        <td style="height:25px;font-weight:bolder">
                            6. มาตรฐานสถานที่ผลิตเภสัชเคมีภัณฑ์ (Standard of Drug Substance Manufacturer)
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
                        <td style="height:25px;font-weight:bolder">
                            7. ชื่อผู้ผลิตยาสำเร็จรูปในต่างประเทศที่เป็นผู้ซื้อ (Foreign Drug Product Manufacturer as Purchaser)<font color="red">*</font>
                        </td>
                        <td>
                            <input class="form-control inline" ng-model="LIST_GMP.CER.BUYER_NAME" style="font-family:'Taviraj';font-size:20px;" type="text" />
                            <label>{{LIST_GMP.CER.BUYER_NAME}}</label>
                        </td>
                    </tr>

                    <tr>
                        <td style="height: 25px;font-weight:bolder">
                            8. ประเทศผู้ซื้อ (Country of Purchaser)<font color="red">*</font>
                        </td>
                        <td>
                            <label>{{LIST_GMP.BUYER_COUNTRY_NAME}}</label>
                        </td>
                    </tr>
                    <tr>
                        <td style="height:25px;font-weight:bolder">
                            9. มาตรฐาน GMP ของสถานที่ผลิตยาสำเร็จรูปของผู้ซื้อ (GMP Standard of Drug Product manufacturer as Purchaser)<font color="red">*</font>
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
                <h2 style="font-family:'Taviraj';font-size:24px;">
                    <b>รายละเอียดเภสัชเคมีภัณฑ์ที่ได้รับการรับรอง (Information of Drug Substances under Certification)</b>
                </h2>
                <table width="100%">
                    <tr>
                        <td style="height:25px;width:35%;font-weight:bolder">
                            10. ขอบเขตของเภสัชเคมีภัณฑ์ที่ได้รับการรับรอง (Scope of Inspection / Certification)
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
                    <table class="table" style="width:100%">
                        <tr>
                            <td>ชื่อไฟล์</td>
                            <td></td>
                        </tr>
                        <tr ng-repeat="datas in LIST_File.FILE_LISTs" style="background-color:#FDFCE3">
                            <td>{{datas.FILENAME}}</td>
                            <td>
                                <a ng-show="datas.PATH != null && datas.PATH != ''" ng-click="OPEN_DOC_PATH(datas.PATH,datas.FILENAME)">ดูเอกสาร</a>
                            </td>
                        </tr>
                    </table>
                </div>
            </div>
                @*-------------PICS------------------*@
                @*-------------OTHER------------------*@
            <div class="ic" ng-show="LIST_GMP.CER.CER_TYPE == '36'">
                <h2 style="font-family:'Taviraj';font-size:24px;">
                    <b>รายละเอียดใบรับรองสถานที่ผลิตเภสัชเคมีภัณฑ์</b>
                </h2>
                <h2 style="font-family:'Taviraj';font-size:24px;">
                    <b>(Information of Certificate of Drug Substance Manufacturer)</b>
                </h2>
                <table width="100%" style="font-family:'Taviraj';font-size:20px;">
                    <tr>
                        <td style="font-weight:bolder">
                            1. เลข สธ หนังสือ อย. ให้ความเห็นชอบ ตย. 1009.4.3/123 (Reference No. of FDA Approval Letter e.g. 1009.4.3/123)<font color="red">*</font>
                        </td>
                        <td>
                            <label>{{LIST_GMP.CER.DEPARTMENT_REGIST_CER_DOCNO}}</label>
                        </td>
                    </tr>
                    <tr>
                        <td style="height:25px;width:35%;font-weight:bolder">
                            2. เลขที่ใบรับรอง (Certificate Number / Registration Number)<font color="red">*</font>
                        </td>
                        <td>
                            <label>{{LIST_GMP.CER.CERTIFICATION_NUMBER_ALL}}</label>
                        </td>
                    </tr>
                    <tr>
                        <td style="font-weight:bolder">
                            3. ชื่อผู้ผลิต (Manufacturer)<font color="red">*</font>
                        </td>
                        <td>

                            <label>{{LIST_GMP.CER_DETAIL_MANUFACTURE.NAME_ADDRESS}}</label>
                        </td>
                    </tr>
                    <tr>
                        <td style="height:25px;font-weight:bolder">
                            4. เลขที่ใบอนุญาตผลิต (Manufacturing License Number)<font color="red">*</font>
                        </td>
                        <td>

                            <label>{{LIST_GMP.CER.MANUFACTURER_LICENCE_NUMBER}}</label>
                        </td>
                    </tr>
                    <tr>
                        <td style="height:25px;font-weight:bolder">
                            5. ที่ตั้ง (Site Address)<font color="red">*</font>
                        </td>
                        <td>

                            <label>{{LIST_GMP.CER_DETAIL_MANUFACTURE.ADDRESS_NUMBER}}</label>
                        </td>
                    </tr>
                    <tr>
                        <td style="height:25px;font-weight:bolder">
                            6. เมือง (City / Province / State)<font color="red">*</font>
                        </td>
                        <td>

                            <label>{{LIST_GMP.CER_DETAIL_MANUFACTURE.ADDRESS_CITY}}</label>
                        </td>
                    </tr>
                    <tr>
                        <td style="height:25px;font-weight:bolder">
                            7. ประเทศ (Country)<font color="red">*</font>
                        </td>
                        <td>
                            <label>{{LIST_GMP.COUNTRY_NAME}}</label>
                        </td>
                    </tr>
                    <tr>
                        <td style="height:25px;font-weight:bolder">
                            <span style="padding-left:1em">รหัสไปรษณีย์ (Postal Code / Zip Code)</span>
                        </td>
                        <td>
                            <label>{{LIST_GMP.CER_DETAIL_MANUFACTURE.ZIPCODE}}</label>
                        </td>
                    </tr>
                    <tr>
                        <td style="height:25px;font-weight:bolder">
                            8. วันที่ออกใบรับรอง (Issue Date)<font color="red">*</font>
                        </td>
                        <td>
                            <label>{{LIST_GMP.CER.DOCUMENT_DATE}}</label>
                        </td>
                    </tr>
                    <tr>
                        <td style="height:25px;font-weight:bolder">
                            <span style="padding-left:1em">วันที่หมดอายุใบรับรอง (Expiry Date / Valid Until)<font color="red">*</font></span>
                        </td>
                        <td>
                            <label>{{LIST_GMP.CER.EXP_DOCUMENT_DATE}}</label>
                        </td>
                    </tr>
                    <tr>
                        <td style="height:25px;font-weight:bolder">
                            9. หน่วยงานที่ออกใบรับรอง (Certification Agency)<font color="red">*</font>
                        </td>
                        <td>
                            <label>{{LIST_GMP.CER.DEPARTMENT_REGIST_CER_NAME}}</label>
                        </td>
                    </tr>
                    <tr>
                        <td style="height:25px;font-weight:bolder">
                            <span style="padding-left:1em">ประเทศของหน่วยงานที่ออกใบรับรอง (Country of Certification Agency)</span>
                        </td>
                        <td>
                            <label>{{LIST_GMP.COUNTRY_OF_DEPARTMENT_NAME}}</label>
                        </td>
                    </tr>
                </table>
                <br />
                <h2 style="font-family:'Taviraj';font-size:24px;">
                    รายละเอียดเภสัชเคมีภัณฑ์ที่ได้รับการรับรอง (Information of Drug Substance under the Certification)
                </h2>
                <table width="100%">
                    <tr>
                        <td style="height:25px;width:35%;font-weight:bolder">
                            10. ขอบเขตของเภสัชเคมีภัณฑ์ที่ได้รับการรับรอง (Scope of Inspection / Certification)
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
                    <table class="table" style="width:100%">
                        <tr>
                            <td>ชื่อไฟล์</td>
                            <td></td>
                        </tr>
                        <tr ng-repeat="datas in LIST_File.FILE_LISTs" style="background-color:#FDFCE3">
                            <td>{{datas.FILENAME}}</td>
                            <td>
                                <a ng-show="datas.PATH != null && datas.PATH != ''" ng-click="OPEN_DOC_PATH(datas.PATH,datas.FILENAME)">ดูเอกสาร</a>
                            </td>
                        </tr>
                    </table>
                </div>
            </div>
                @*-------------OTHER------------------*@
                <br />
                @*<div class="col-sm-12">
                    <div class="row">
                        <div class="col-sm-3" style="text-align:center">
                            รายละเอืยด :
                        </div>
                        <div class="col-sm-9">
                            {{REMARK}}
                        </div>
                    </div>
                    <br />
                    <table class="table" style="width:100%">
                        <tr>
                            <td>ชื่อไฟล์</td>
                            <td></td>
                        </tr>
                        <tr ng-repeat="datas in LIST_File.FILE_LISTs" style="background-color:#FDFCE3">
                            <td>{{datas.FILENAME}}</td>
                            <td>
                                <a ng-show="datas.PATH != null && datas.PATH != ''" ng-click="OPEN_DOC_PATH(datas.PATH,datas.FILENAME)">ดูเอกสาร</a>
                            </td>
                        </tr>
                    </table>
                    <br />
                </div>*@
                <br />

            </div>
            <div class="part part-1-3 ic">
                <div class="card"  >
                    <table class="table">
                        <tr>
                            <td>
                                สถานะ
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <select class="form-control" ng-model="STATUS_ID" >
                                    @*<option value="5">คืนให้แก้ไขคำขอ</option>*@
                                    <option value="8">อนุมัติ</option>
                                    <option value="7">ไม่อนุมัติ</option>
                                </select>
                            </td>  
                        </tr>
                    </table>

                    <br />
                    <div align="center">
                        <input type="button" style="width:80%" class="btn btn-lg " ng-click="BTN_CERT_CONFIRM(STATUS_ID)" value="บันทึก" />
                    </div>
                    <br />
                    <br />
                    <div align="center">
                        <input type="button" style="width:80%" class="btn btn-lg " ng-click="BTN_BACK()" value="ย้อนกลับ" />
                    </div>
                    <br />
                    <div>

                    </div>
                </div>
            </div>
        </div>

    </div>
</div>