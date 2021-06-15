@Code
    ViewData("Title") = "PREVIEW_DH"
End Code
<script src="~/Scripts_angular/ANGULAR_APP.js"></script>
<script src="~/Scripts_angular/CENTER_SV.js"></script>
<script src="~/Scripts_angular/DH_CTRL.js"></script>
<div class="ic" ng-controller="DH_CTRL" ng-app="ANGULAR_APP">
    @*-------------AR------------------*@
    <div class="ic">
        <center>
            <h2>คำขอจดแจ้งเภสัชเคมีภัณฑ์</h2> <br />
            <h2>
                เป็นสารออกฤทธิ์ตามทะเบียนตำรับยาผลิตในประเทศ
            </h2>
        </center>
        <table>
            <tr>
                <td>

                    <div ng-include src="'Views/DH/HEADER_DH'"></div>
                </td>
            </tr>
        </table>

        <table>
            <tr>
                <td>
                    Ref Cer
                </td>
                <td>
                    @*<select class="dropdown" ng-model="LIST_DH.DH15_DETAIL_CER.CER_DETAIL_CHEMICAL_IDA">
                            <option value="0">--กรุณาเลือก--</option>
                            <option ng-repeat="x in REF_CERT" value="{{x.IDA}}">{{x.CER_NUMBER}}</option>
                        </select>*@

                    <label>{{LIST_DH.REF_CER_NO}}</label>
                </td>
            </tr>
        </table>
        <table width="100%">
            <tr>
                <td>
                    ชื่อผู้ผลิต
                </td>
                <td width="30%">
                    <label>
                        {{LIST_DH.DH15_DETAIL_CER.FOREIGN_LOCATION_NAME}}
                    </label>
                </td>
                <td>
                    ประเทศ
                </td>
                <td width="10%">
                    <label>{{LIST_DH.DH15_DETAIL_CER.COUNTRY_NAME}}</label>
                </td>
            </tr>
            <tr>
                <td>
                    ชื่อผู้แทนจำหน่ายในต่างประเทศ (ซื้อผ่าน)
                </td>
                <td>
                    <input class="form-control inline" ng-model="LIST_DH.dh15rqt.AGENT_NAME" style="font-family:'TH SarabunPSK';font-size:20px;" type="text" />
                    <label>{{LIST_DH.dh15rqt.AGENT_NAME}}</label>

                </td>
                <td>
                    ประเทศ
                </td>
                <td>
                    @*<select style="font-family:'TH SarabunPSK';font-size:20px;" ng-model="LIST_DH.dh15rqt.AGENT_COUNTRY_ID">
                            <option value="0">--กรุณาเลือก--</option>
                            <option ng-repeat="x in CNT_LIST" value="{{x.IDA}}">{{x.engcntnm}}</option>
                        </select>*@
                    <label>{{LIST_DH.COUNTRY_NAME}}</label>

                </td>
            </tr>
        </table>
        <br />
        <table>
            <tr>
                <td>
                    วันเดือนปีที่ออกใบรับรอง
                </td>
                <td>
                    <label>
                        {{LIST_DH.DH15_DETAIL_CER.DOCUMENT_DATE}}
                    </label>
                </td>
            </tr>
            <tr>
                <td>
                    วันเดือนปีที่หมดอายุ
                </td>
                <td>
                    <label>
                        {{LIST_DH.DH15_DETAIL_CER.EXP_DOCUMENT_DATE}}
                    </label>
                </td>
            </tr>
        </table>
        <table width="100%">
            <tr>
                <td>
                    ชื่อการค้า <font color="red">*</font>
                </td>
                <td>
                    <label>{{LIST_DH.dh15rqt.TRADING_NAME}}</label>
                </td>

            </tr>
            <tr>
                <td>
                    มาตรฐาน (ตำรายา)
                </td>
                <td>

                    <label>{{LIST_DH.dh15rqt.PHARMACOPOEIA_STANDARDS}}</label>

                </td>
            </tr>
        </table>

        //Table เพิ่มสาร
    </div>
    @*-------------AR------------------*@
    @*-------------AN------------------*@
    <div class="ic">

        <center>
            <h2>คำขอจดแจ้งเภสัชเคมีภัณฑ์</h2> <br />
            <h2>
                เป็นสารออกฤทธิ์ที่ไม่มีในทะเบียนตำรับยาผลิตในประเทศ
            </h2>
        </center>
        <table>
            <tr>
                <td>

                    <div ng-include src="'Views/DH/HEADER_DH'"></div>
                </td>
            </tr>
        </table>

        <table>
            <tr>
                <td>
                    Ref Cer
                </td>
                <td>
                    <select class="dropdown" ng-model="LIST_DH.DH15_DETAIL_CER.CER_DETAIL_CHEMICAL_IDA">
                        <option value="0">--กรุณาเลือก--</option>
                        <option ng-repeat="x in REF_CERT" value="{{x.IDA}}">{{x.CER_NUMBER}}</option>
                    </select>
                </td>
            </tr>
        </table>
        <table width="100%">
            <tr>
                <td>
                    ชื่อผู้ผลิต
                </td>
                <td width="30%">
                    <label>
                        {{LIST_DH.DH15_DETAIL_CER.FOREIGN_LOCATION_NAME}}
                    </label>
                </td>
                <td>
                    ประเทศ
                </td>
                <td width="10%">
                    <label>
                        {{LIST_DH.DH15_DETAIL_CER.COUNTRY_NAME}}
                    </label>
                </td>
            </tr>
            <tr>
                <td>
                    ชื่อผู้แทนจำหน่ายในต่างประเทศ (ซื้อผ่าน)
                </td>
                <td>
                    <input class="form-control inline" ng-model="LIST_DH.dh15rqt.AGENT_NAME" style="font-family:'TH SarabunPSK';font-size:20px;" type="text" />
                </td>
                <td>
                    ประเทศ
                </td>
                <td>
                    <select style="font-family:'TH SarabunPSK';font-size:20px;" ng-model="LIST_DH.dh15rqt.AGENT_COUNTRY_ID">
                        <option value="0">--กรุณาเลือก--</option>
                        <option ng-repeat="x in CNT_LIST" value="{{x.IDA}}">{{x.engcntnm}}</option>
                    </select>
                </td>
            </tr>
        </table>
        <br />
        <table>
            <tr>
                <td>
                    วันเดือนปีที่ออกใบรับรอง
                </td>
                <td>
                    <label>
                        {{LIST_DH.DH15_DETAIL_CER.DOCUMENT_DATE}}
                    </label>
                </td>
            </tr>
            <tr>
                <td>
                    วันเดือนปีที่หมดอายุ
                </td>
                <td>
                    <label>
                        {{LIST_DH.DH15_DETAIL_CER.EXP_DOCUMENT_DATE}}
                    </label>
                </td>
            </tr>
        </table>
        <table width="100%">
            <tr>
                <td>
                    ชื่อการค้า <font color="red">*</font>
                </td>
                <td>
                    <label>
                        {{LIST_DH.dh15rqt.TRADING_NAME}}
                    </label>
                </td>

            </tr>
            <tr>
                <td>
                    มาตรฐาน (ตำรายา)
                </td>
                <td>

                    <label>
                        {{LIST_DH.dh15rqt.PHARMACOPOEIA_STANDARDS}}
                    </label>
                </td>
            </tr>
            <tr>
                <td>
                    จำนวน
                </td>
                <td>
                    <label>
                        {{LIST_DH.dh15rqt.unit_alpha3}}
                    </label>
                </td>
                <td>
                    ปริมาณ
                </td>
                <td>
                    <label>
                        {{LIST_DH.dh15rqt.amount}}
                    </label>
                </td>
            </tr>
        </table>

        //Table เพิ่มสาร <br />

        เหตุผลในการผลิต/นำเข้าฯ
        <table>
            <tr>
                <td>
                    <form name="myForm">
                        <label>
                            <input type="radio" id="rdl_PURPOSE1" ng-model="LIST_DH.dh15rqt.PURPOSE1" value="1">
                            ใช้ในการผลิตยาตัวอย่างเพื่อขอขึ้นทะเบียนตำรับยา
                        </label> <br />
                        <label>
                            <input type="radio" id="rdl_PURPOSE1" ng-model="LIST_DH.dh15rqt.PURPOSE1" value="2">
                            ใช้ในการพัฒนาตำรับยาที่ได้เลขทะเบียนแล้ว
                        </label> <br />
                        <label>
                            <input type="radio" id="rdl_PURPOSE1" ng-model="LIST_DH.dh15rqt.PURPOSE1" value="3">
                            อื่น ๆ (ระบุ)
                        </label>
                        <input />
                    </form>
                </td>
            </tr>
        </table> <br />
        พร้อมนี้ได้แนบหลักฐานประกอบการพิจารณา ดังนี้
        <table>
            <tr>
                <td>
                    <form name="myForm">
                        <label>
                            <input type="checkbox" ng-model="LIST_DH.dh15rqt.ATTACH1" value="1">
                            สำเนา ผ.ย. ๘ ที่ได้รับอนุมัติแล้ว พร้อมหนังสือสั่งซื้อจากผู้รับอนุญาตผลิตยา
                        </label> <br />
                        <label>
                            <input type="checkbox" ng-model="LIST_DH.dh15rqt.ATTACH2" value="1">
                            สำเนาใบอนุญาตผลิตในต่างประเทศ และรับรองสำเนาโดยผู้รับอนุญาตที่ขอจดแจ้งเภสัชเคมีภัณฑ์
                        </label> <br />
                        <label>
                            <input type="checkbox" ng-model="LIST_DH.dh15rqt.ATTACH3" value="1">
                            สำเนาใบสำคัญการขึ้นทะเบียนตำรับยา และสำเนา ท.ย.๑ หน้า๑ และหน้า๒/แบบ ย.๑ หน้า๓
                        </label> <br />
                        <label>
                            <input type="checkbox" ng-model="LIST_DH.dh15rqt.ATTACH4" value="1">
                            สำเนารายงานผลการตรวจวิเคราะห์คุณภาพ (Certification of Analysis) ซึ่งระบุข้อกำหนดมาตราฐาน
                            (Specifications)
                        </label> <br />
                        <label>
                            <input type="checkbox" ng-model="LIST_DH.dh15rqt.ATTACH5" value="1">
                            สำเนาหนังสือรับรองมาตราฐานหลักเกณฑ์วิธีการที่ดีในการผลิตเภสัชเคมีภัณฑ์
                            (GoodManufacturing Practice) ตามมาตราฐานองค์การอนามัยโลกหรือเทียบเท่า (กรณีนำเข้า)
                            (Specifications)
                        </label> <br />
                        <label>
                            <input type="checkbox" ng-model="LIST_DH.dh15rqt.ATTACH6" value="1">
                            อื่น ๆ (ระบุ)
                        </label>
                        &nbsp;
                        <label>
                            {{LIST_DH.dh15rqt.OTHER_ATTACH}}
                        </label>
                    </form>
                </td>
            </tr>
        </table>
    </div>
    @*-------------AN------------------*@
    @*-------------IR------------------*@
    <div class="ic">
        <center>
            <h2>คำขอจดแจ้งเภสัชเคมีภัณฑ์</h2> <br />
            <h2>
                ไม่เป็นสารออกฤทธิ์ตามทะเบียนตำรับยาผลิตในประเทศ
            </h2>
        </center>

        <table width="100%">
            <tr>
                <td>
                    ชื่อผู้ผลิต
                </td>
                <td width="30%">
                    <label>
                        {{LIST_DH.DH15_DETAIL_CER.FOREIGN_LOCATION_NAME}}
                    </label>
                </td>
                <td>
                    ประเทศ
                </td>
                <td width="10%">
                    <label>
                        {{LIST_DH.COUNTRY_NAME}}
                    </label>
                </td>
            </tr>
            <tr>
                <td>
                    ชื่อผู้แทนจำหน่ายในต่างประเทศ (ซื้อผ่าน)
                </td>
                <td>
                    <label>
                        {{LIST_DH.dh15rqt.AGENT_NAME}}
                    </label>
                </td>
                <td>
                    ประเทศ
                </td>
                <td>
                    <label>
                        {{LIST_DH.AGENT_COUNTRY_NAME}}
                    </label>
                </td>
            </tr>
            <tr>
                <td>
                    ชื่อการค้า<font color="red">*</font>
                </td>
                <td colspan="3">
                    <label>
                        {{LIST_DH.dh15rqt.TRADING_NAME}}
                    </label>
                </td>
            </tr>
        </table>
        <br />
        //Table เพิ่มสาร <br />
        <br />
        <table>
            <tr>
                <td>
                    มาตรฐาน (ตำรายา)
                </td>
                <td>
                    <label>
                        {{LIST_DH.dh15rqt.PHARMACOPOEIA_STANDARDS}}
                    </label>
                </td>
            </tr>
            <tr>
                <td>
                    เกรด
                </td>
                <td>
                    <label>
                        {{LIST_DH.dh15rqt.GRADE}}
                    </label>
                </td>
            </tr>
        </table>
    </div>
    @*-------------IR------------------*@
    @*-------------IN------------------*@
    <div class="ic">
        <center>
            <h2>คำขอจดแจ้งเภสัชเคมีภัณฑ์</h2> <br />
            <h2>
                ไม่เป็นสารออกฤทธิ์ตามทะเบียนตำรับยาผลิตในประเทศ
            </h2>
        </center>

        <table width="100%">
            <tr>
                <td>
                    ชื่อผู้ผลิต
                </td>
                <td width="30%">
                    <label>
                        {{LIST_DH.DH15_DETAIL_CER.FOREIGN_LOCATION_NAME}}
                    </label>
                </td>
                <td>
                    ประเทศ
                </td>
                <td width="10%">
                    <label>
                        {{LIST_DH.COUNTRY_NAME}}
                    </label>
                </td>
            </tr>
            <tr>
                <td>
                    ชื่อผู้แทนจำหน่ายในต่างประเทศ (ซื้อผ่าน)
                </td>
                <td>
                    <label>
                        {{LIST_DH.dh15rqt.AGENT_NAME}}
                    </label>
                </td>
                <td>
                    ประเทศ
                </td>
                <td>
                    <select style="font-family:'TH SarabunPSK';font-size:20px;" ng-model="LIST_DH.dh15rqt.AGENT_COUNTRY_ID">
                        <option value="0">--กรุณาเลือก--</option>
                        <option ng-repeat="x in CNT_LIST" value="{{x.IDA}}">{{x.engcntnm}}</option>
                    </select>
                    <label>
                        {{LIST_DH.AGENT_COUNTRY_NAME}}
                    </label>
                </td>
            </tr>
            <tr>
                <td>
                    ชื่อการค้า<font color="red">*</font>
                </td>
                <td colspan="3">
                    <label>
                        {{LIST_DH.dh15rqt.TRADING_NAME}}
                    </label>
                </td>
            </tr>
        </table>
        <br />
        //Table เพิ่มสาร <br />
        <br />
        <table>
            <tr>
                <td>
                    มาตรฐาน (ตำรายา)
                </td>
                <td>
                    <label>
                        {{LIST_DH.dh15rqt.PHARMACOPOEIA_STANDARDS}}
                    </label>
                </td>
            </tr>
            <tr>
                <td>
                    เกรด
                </td>
                <td>
                    <label>
                        {{LIST_DH.dh15rqt.GRADE}}
                    </label>
                </td>
            </tr>
        </table>
        <table>
            <tr>
                <td>
                    จำนวน
                </td>
                <td>
                    <label>
                        {{LIST_DH.dh15rqt.amount}}
                    </label>
                </td>
                <td>
                    ปริมาณ
                </td>
                <td>
                    <label>
                        {{LIST_DH.dh15rqt.quantity}}
                    </label>
                </td>
            </tr>
        </table>
        เหตุผลในการผลิต/นำเข้าฯ
        <table>
            <tr>
                <td>
                    <form name="myForm">
                        <label>
                            <input type="radio" id="rdl_PURPOSE1" ng-model="LIST_DH.dh15rqt.PURPOSE1" value="1">
                            ใช้ในการผลิตยาตัวอย่างเพื่อขอขึ้นทะเบียนตำรับยา
                        </label> <br />
                        <label>
                            <input type="radio" id="rdl_PURPOSE1" ng-model="LIST_DH.dh15rqt.PURPOSE1" value="2">
                            ใช้ในการพัฒนาตำรับยาที่ได้เลขทะเบียนแล้ว
                        </label> <br />
                        <label>
                            <input type="radio" id="rdl_PURPOSE1" ng-model="LIST_DH.dh15rqt.PURPOSE1" value="3">
                            อื่น ๆ (ระบุ)
                        </label>
                        <label>
                            {{LIST_DH.dh15rqt.OTHER_PURPOSE}}
                        </label>
                    </form>
                </td>
            </tr>
        </table>

    </div>
    @*-------------IN------------------*@


</div>