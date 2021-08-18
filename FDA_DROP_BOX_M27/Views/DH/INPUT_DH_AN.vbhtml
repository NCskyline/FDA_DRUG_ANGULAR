@Code
    Layout = ""
End Code
<script src="../Scripts_angular/CENTER_SV.js"></script>
<script src="../Scripts_angular/DH_CTRL.js"></script>
<div class="ic" style="font-family:'Taviraj';font-size:20px;">

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
                <select class="form-control" ng-model="LIST_DH.DH15_DETAIL_CER.CER_DETAIL_CHEMICAL_IDA" ng-change="Getdetails_REF_CER(LIST_DH.DH15_DETAIL_CER.CER_DETAIL_CHEMICAL_IDA)">
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
            <td width="30%"  style="border-bottom:dotted;border-bottom-width:thin;">
                <label>
                    {{LIST_REF_CERT.CER.FOREIGN_LOCATION_NAME}}
                </label>
            </td>
            <td>
                ประเทศ
            </td>
            <td width="20%"  style="border-bottom:dotted;border-bottom-width:thin;">
                <label>
                    {{LIST_REF_CERT.COUNTRY_NAME}}
                </label>
            </td>
        </tr>
        <tr>
            <td>
                ชื่อผู้แทนจำหน่ายในต่างประเทศ (ซื้อผ่าน)
            </td>
            <td>
                <input class="form-control inline" ng-model="LIST_DH.dh15rqt.AGENT_NAME" style="font-family:'Taviraj';font-size:20px;" type="text" />
            </td>
            <td>
                ประเทศ
            </td>
            <td>
                <select style="font-family:'Taviraj';font-size:20px;" ng-model="LIST_DH.dh15rqt.AGENT_COUNTRY_ID">
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
                    {{LIST_REF_CERT.CER.DOCUMENT_DATE}}
                </label>
            </td>
        </tr>
        <tr>
            <td>
                วันเดือนปีที่หมดอายุ
            </td>
            <td>
                <label>
                    {{LIST_REF_CERT.CER.EXP_DOCUMENT_DATE}}
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
                <input class="form-control inline" ng-model="LIST_DH.dh15rqt.TRADING_NAME" style="font-family:'Taviraj';font-size:20px;" type="text" />
            </td>

        </tr>
        <tr>
            <td>
                มาตรฐาน (ตำรายา)
            </td>
            <td>
                <input class="form-control inline" ng-model="LIST_DH.dh15rqt.PHARMACOPOEIA_STANDARDS" style="font-family:'Taviraj';font-size:20px;" type="text" />
            </td>
        </tr>
        <tr>
            <td>
                จำนวน
            </td>
            <td>
                <input class="form-control inline" ng-model="LIST_DH.dh15rqt.unit_alpha3" style="font-family:'Taviraj';font-size:20px;" type="text" />
            </td>
            <td>
                ปริมาณ
            </td>
            <td>
                <input class="form-control inline" ng-model="LIST_DH.dh15rqt.amount" style="font-family:'Taviraj';font-size:20px;" type="text" />
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
                    <input class="form-control inline" ng-model="LIST_DH.dh15rqt.OTHER_ATTACH" style="font-family:'Taviraj';font-size:20px;" type="text" />
                </form>
            </td>
        </tr>
    </table>
</div>