@Code

End Code
<script src="~/Scripts_angular/ANGULAR_APP.js"></script>
<script src="~/Scripts_angular/CENTER_SV.js"></script>
<script src="~/Scripts_angular/DH_STAFF_CTRL.js"></script>


<div ng-controller="DH_STAFF_CTRL" ng-app="ANGULAR_APP" ng-init="PREVIEW_DH()">
    <div ng-show="PROCESS_ID == '15'">
        <div>
            <p style="text-align:right;font-size:20px">แบบ ภค.1</p>
            <p style="text-align:right;font-size:20px">Form API-1</p>
        </div>
    </div>
    <div>
        <div class="content-part">
            <div class="part part-2-3 ic">
                <div style="font-family:'Taviraj';width:100%">
                    <center>
                        <h2>คำขอจดแจ้งเภสัชเคมีภัณฑ์</h2>
                        <h2>
                            {{HEADER_PROCESS}}
                        </h2>
                        <h2>
                            {{HEADER_PROCESS1}}
                        </h2>
                    </center>
                    <br />
                    <table width="100%" style="font-family:'Taviraj';font-size:20px;">
                        <tr>
                            <td width="20%" align="right">
                                ข้าพเจ้า
                            </td>
                            <td width="60%" style="border-bottom:dotted;border-bottom-width:thin;" align="center">
                                <label>{{LIST_LCN.NAME}}</label>
                            </td>
                            <td>
                                ผู้รับอนุญาต
                            </td>
                        </tr>
                    </table>
                    <br />
                    <table width="100%" style="font-family:'Taviraj';font-size:20px;">
                        <tr>
                            <td align="center">
                                <form name="myForm">
                                    <label>
                                        <input type="radio" ng-model="LIST_LCN.CHK_TYPE_LCN" value="1" disabled>
                                        ผลิต
                                    </label>
                                    <label>&nbsp;</label>
                                    <label>
                                        <input type="radio" ng-model="LIST_LCN.CHK_TYPE_LCN" value="2" disabled>
                                        นำหรือสั่ง เข้ามาในราชอาณาจักร ซึ่งยาแผนปัจจุบัน
                                    </label>
                                </form>
                            </td>
                        </tr>
                    </table>
                    <table width="100%" style="font-family:'Taviraj';font-size:20px;">
                        <tr>
                            <td width="15%">
                                ใบอนุญาตเลขที่
                            </td>
                            <td style="border-bottom:dotted;border-bottom-width:thin;">
                                <label>{{LIST_LCN.LCN_NO_DISPLAY}}</label>
                            </td>
                        </tr>
                        <tr>
                            <td width="15%">อยู่เลขที่ </td>
                            <td colspan="2" style="border-bottom:dotted;border-bottom-width:thin;">
                                <label>{{LIST_LCN.FULL_ADDR}}</label>
                            </td>
                            <td></td>
                        </tr>
                        <tr>
                            <td>หมายเลขโทรศัพท์ </td>
                            <td colspan="2" style="border-bottom:dotted;border-bottom-width:thin;">
                                <label>{{LIST_LCN.TEL}}</label>
                            </td>
                            <td width="20%">มีความประสงค์ขอ</td>
                        </tr>
                    </table>
                    <br />
                    <table width="100%" style="font-family:'Taviraj';font-size:20px;">
                        <tr>
                            <td align="center">
                                <form name="myForm">
                                    <label>
                                        <input type="radio" ng-model="LIST_LCN.CHK_TYPE_LCN" value="1" disabled>
                                        ผลิต
                                    </label>
                                    <label>&nbsp;&nbsp;&nbsp;</label>
                                    <label>
                                        <input type="radio" ng-model="LIST_LCN.CHK_TYPE_LCN" value="2" disabled>
                                        นำหรือสั่งเข้ามาในราชอาณาจักร
                                    </label>
                                </form>

                            </td>
                        </tr>
                    </table>
                    <table width="100%" style="font-family:'Taviraj';font-size:20px;">
                        <tr>
                            <td align="center">
                                <form name="myForm">
                                    ซึ่ง<font color="red">*</font>
                                    <label>&nbsp;</label>
                                    <label>
                                        <input type="radio" ng-model="LIST_DH.dh15rqt.CHK_TYPE_CHEMICAL" value="1" disabled>
                                        เภสัชเคมีภัณฑ์เดี่ยว
                                    </label>
                                    <label>&nbsp;&nbsp;&nbsp;</label>
                                    <label>
                                        <input type="radio" ng-model="LIST_DH.dh15rqt.CHK_TYPE_CHEMICAL" value="2" disabled>
                                        เภสัชเคมีภัณฑ์กึ่งสำเร็จรูป
                                    </label>
                                </form>
                            </td>
                        </tr>
                    </table>
                    <div style="font-family:'Taviraj';font-size:20px;">มีรายละเอียดดังนี้</div>
                    <br />
                    @*-------------AR------------------*@
                    <div class="ic" ng-show="LIST_DH.dh15rqt.PROCESS_ID == '14'">
                        <table width="100%" style="font-size:20px">
                            <tr>
                                <td width="35%">
                                    เลขที่อ้างอิงสถานที่ผลิต (ThFDA-D Ref)
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin">
                                    {{LIST_DH.REF_CER_NO}}
                                </td>
                            </tr>
                        </table>
                        <table width="100%" style="font-size:20px">
                            <tr>
                                <td width="45%">
                                    ชื่อผู้ผลิตเภสัชเคมีภัณฑ์ (Drug Substance Manufacturer)
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin">
                                    <label>
                                        {{LIST_DH.DH15_DETAIL_CER.FOREIGN_LOCATION_NAME}}
                                    </label>
                                </td>
                                <td width="15%">
                                    ประเทศ (Country)
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin">
                                    {{LIST_DH.DH15_DETAIL_CER.COUNTRY_NAME}}
                                </td>
                            </tr>
                        </table>
                        <table width="100%" style="font-size:20px">
                            <tr>
                                <td width="20%">
                                    ที่ตั้ง (Site Address)
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin"></td>
                            </tr>
                        </table>
                        <table width="100%" style="font-size:20px">
                            <tr>
                                <td width="25%">
                                    เมือง (City / Province / State)
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin"></td>
                            </tr>
                            <tr>
                                <td width="25%">
                                    วันที่ออกใบรับรอง (Issue Date)
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin">
                                    {{LIST_DH.DH15_DETAIL_CER.DOCUMENT_DATE}}
                                </td>
                            </tr>
                        </table>
                        <table width="100%" style="font-size:20px">
                            <tr>
                                <td width="30%">
                                    วันที่ใบรับรองหมดอายุ (Valid Until)
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin">
                                    {{LIST_DH.DH15_DETAIL_CER.EXP_DOCUMENT_DATE}}
                                </td>
                            </tr>
                        </table>
                        <table width="100%" style="font-size:20px">
                            <tr>
                                <td width="50%">
                                    ชื่อผู้แทนจำหน่ายในต่างประเทศ (ซื้อผ่าน) (Foreign Distributor (Purchasing through))
                                </td>
                                <td width="20%" style="border-bottom:dotted;border-bottom-width:thin">
                                    {{LIST_DH.dh15rqt.AGENT_NAME}}
                                </td>
                                <td width="15%">
                                    ประเทศ (Country)
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin">
                                    {{LIST_DH.DH15_DETAIL_CER.COUNTRY_NAME}}
                                </td>
                            </tr>
                        </table>
                        <table width="100%" style="font-size:20px">
                            <tr>
                                <td width="20%">
                                    ชื่อการค้า (Trade Name)<font color="red">*</font>
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin">
                                    <label>{{LIST_DH.dh15rqt.TRADING_NAME}}</label>
                                </td>
                            </tr>
                        </table>
                        <table width="100%" style="font-size:20px">
                            <tr>
                                <td width="55%">
                                    มาตรฐานตามตำรายา (Phamacopoeia Standard of Drug Substance)
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin">
                                    <label>{{LIST_DH.dh15rqt.PHARMACOPOEIA_STANDARDS}}</label>
                                </td>
                            </tr>
                        </table>
                    </div>
                    @*-------------AR------------------*@
                    @*-------------AN------------------*@
                    <div class="ic" ng-show="LIST_DH.dh15rqt.PROCESS_ID == '15'">
                        <table width="100%" style="font-size:20px">
                            <tr>
                                <td width="35%">
                                    เลขที่อ้างอิงสถานที่ผลิต (ThFDA-D Ref)
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin">
                                    {{LIST_DH.REF_CER_NO}}
                                </td>
                            </tr>
                        </table>
                        <table width="100%" style="font-size:20px">
                            <tr>
                                <td width="20%">
                                    ชื่อผู้ผลิต (Manufacturer)
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin">
                                    {{LIST_DH.DH15_DETAIL_CER.FOREIGN_LOCATION_NAME}}
                                </td>
                                <td width="15%">
                                    ประเทศ (Country)
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin">
                                    {{LIST_DH.DH15_DETAIL_CER.COUNTRY_NAME}}
                                </td>
                            </tr>
                        </table>
                        <table width="100%" style="font-size:20px">
                            <tr>
                                <td width="20%">
                                    ที่ตั้ง (Site Address)
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin"></td>
                            </tr>
                        </table>
                        <table width="100%" style="font-size:20px">
                            <tr>
                                <td width="25%">
                                    เมือง (City / Province / State)
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin"></td>
                            </tr>
                            <tr>
                                <td width="25%">
                                    วันที่ออกใบรับรอง (Issue Date)
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin">
                                    <label>
                                        {{LIST_DH.DH15_DETAIL_CER.DOCUMENT_DATE}}
                                    </label>
                                </td>
                            </tr>
                        </table>
                        <table width="100%" style="font-size:20px">
                            <tr>
                                <td width="30%">
                                    วันที่หมดอายุใบรับรอง (Valid Until)
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin">
                                    <label>
                                        {{LIST_DH.DH15_DETAIL_CER.EXP_DOCUMENT_DATE}}
                                    </label>
                                </td>
                            </tr>
                        </table>
                        <table width="100%" style="font-size:20px">
                            <tr>
                                <td width="50%">
                                    ชื่อผู้แทนจำหน่ายในต่างประเทศ (ซื้อผ่าน) (Foreign Distributor (Purchasing through))
                                </td>
                                <td width="20%" style="border-bottom:dotted;border-bottom-width:thin">
                                    @*<input class="form-control inline" ng-model="LIST_DH.dh15rqt.AGENT_NAME" style="font-family:'Taviraj';font-size:20px;" type="text" />*@
                                    {{LIST_DH.dh15rqt.AGENT_NAME}}
                                </td>
                                <td width="15%">
                                    ประเทศ (Country)
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin">
                                    @*<select style="font-family:'Taviraj';font-size:20px;" ng-model="LIST_DH.dh15rqt.AGENT_COUNTRY_ID">
                            <option value="0">--กรุณาเลือก--</option>
                            <option ng-repeat="x in CNT_LIST" value="{{x.IDA}}">{{x.engcntnm}}</option>
                            </select>*@
                                    {{LIST_DH.dh15rqt.AGENT_COUNTRY_ID}}
                                </td>
                            </tr>
                        </table>
                        <table width="100%" style="font-size:20px">
                            <tr>
                                <td width="25%">
                                    ชื่อการค้า (Trade Name) <font color="red">*</font>
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin">
                                    <label>
                                        {{LIST_DH.dh15rqt.TRADING_NAME}}
                                    </label>
                                </td>
                            </tr>
                        </table>
                        <table width="100%" style="font-size:20px">
                            <tr>
                                <td width="55%">
                                    มาตรฐานตามตำรายา (Phamacopoeia Standard of Drug Substance)
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin">
                                    <label>
                                        {{LIST_DH.dh15rqt.PHARMACOPOEIA_STANDARDS}}
                                    </label>
                                </td>
                            </tr>
                        </table>
                        <table width="100%" style="font-size:20px">
                            <tr>
                                <td width="30%">
                                    จำนวนภาชนะบรรจุ (ต.ย. 2 ถุง)<font color="red">*</font><br />
                                    (Number of Packages e.g. 2 bags))
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin">
                                    <label>
                                        {{LIST_DH.dh15rqt.unit_alpha3}}
                                    </label>
                                </td>
                            <tr>
                        </table>
                        <br />
                        <table width="100%" style="font-size:20px">
                            <tr>
                                <td width="60%">
                                    น้ำหนัก / ปริมาตรรวม (ต.ย. 10 กิโลกรัม โดยมาจาก 2 ถุง x 5 กิโลกรัมต่อถุง)<br />
                                    (Total Weight / Volume e.g. 10 kg. which comes from 2 bags x 5 kg/bag)
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin">
                                    <label>
                                        {{LIST_DH.dh15rqt.amount}}
                                    </label>
                                </td>
                                <td width="5%">
                                    Unit
                                </td>
                                <td width="18%" style="border-bottom:dotted;border-bottom-width:thin">
                                    <label>
                                    </label>
                                </td>
                            </tr>
                        </table>
                        <br />
                        <div style="font-size:20px">เหตุผลในการผลิต/นำเข้าฯ</div>
                        <table width="100%" style="font-size:20px">
                            <tr>
                                <td>
                                    <form name="myForm">
                                        <label>
                                            <span style="padding-left:2em;"><input type="radio" id="rdl_PURPOSE1" ng-model="LIST_DH.dh15rqt.PURPOSE1" value="1"></span>
                                            ใช้ในการผลิตยาตัวอย่างเพื่อขอขึ้นทะเบียนตำรับยา
                                        </label> <br />
                                        <label>
                                            <span style="padding-left:2em;"><input type="radio" id="rdl_PURPOSE1" ng-model="LIST_DH.dh15rqt.PURPOSE1" value="2"></span>
                                            ใช้ในการพัฒนาตำรับยาที่ได้เลขทะเบียนแล้ว
                                        </label> <br />
                                        <table width="100%">
                                            <tr>
                                                <td width="15%">
                                                    <span style="padding-left:2em;"><input type="radio" id="rdl_PURPOSE1" ng-model="LIST_DH.dh15rqt.PURPOSE1" value="3"></span>
                                                    อื่น ๆ (ระบุ)<font color="red">*</font>
                                                </td>
                                                <td style="border-bottom:dotted;border-bottom-width:thin"></td>
                                            </tr>
                                        </table>
                                    </form>
                                </td>
                            </tr>
                        </table> <br />
                        <div style="font-size:20px">พร้อมนี้ได้แนบหลักฐานประกอบการพิจารณา ดังนี้</div>
                        <table width="100%" style="font-size:20px">
                            <tr>
                                <td>
                                    <form name="myForm">
                                        <label>
                                            <span style="padding-left:2em"><input type="radio" ng-model="LIST_DH.dh15rqt.ATTACH1" value="1"></span>
                                            สำเนา ผ.ย. ๘ ที่ได้รับอนุมัติแล้ว พร้อมหนังสือสั่งซื้อจากผู้รับอนุญาตผลิตยา
                                        </label> <br />
                                        <label>
                                            <span style="padding-left:2em"><input type="radio" ng-model="LIST_DH.dh15rqt.ATTACH2" value="1"></span>
                                            สำเนาใบอนุญาตผลิตในต่างประเทศ และรับรองสำเนาโดยผู้รับอนุญาตที่ขอจดแจ้งเภสัชเคมีภัณฑ์
                                        </label> <br />
                                        <label>
                                            <span style="padding-left:2em"><input type="radio" ng-model="LIST_DH.dh15rqt.ATTACH3" value="1"></span>
                                            สำเนาใบสำคัญการขึ้นทะเบียนตำรับยา และสำเนา ท.ย.๑ หน้า๑ และหน้า๒/แบบ ย.๑ หน้า๓
                                        </label> <br />
                                        <label>
                                            <span style="padding-left:2em"><input type="radio" ng-model="LIST_DH.dh15rqt.ATTACH4" value="1"></span>
                                            สำเนารายงานผลการตรวจวิเคราะห์คุณภาพ (Certification of Analysis) ซึ่งระบุข้อกำหนดมาตราฐาน
                                            (Specifications)
                                        </label> <br />
                                        <label>
                                            <span style="padding-left:2em"><input type="radio" ng-model="LIST_DH.dh15rqt.ATTACH5" value="1"></span>
                                            สำเนาหนังสือรับรองมาตราฐานหลักเกณฑ์วิธีการที่ดีในการผลิตเภสัชเคมีภัณฑ์
                                            (GoodManufacturing Practice) ตามมาตราฐานองค์การอนามัยโลกหรือเทียบเท่า (กรณีนำเข้า)
                                            (Specifications)
                                        </label> <br />
                                        <table width="100%">
                                            <tr>
                                                <td width="15%">
                                                    <label>
                                                        <span style="padding-left:2em;"><input type="radio" ng-model="LIST_DH.dh15rqt.ATTACH6" value="1"></span>
                                                        อื่น ๆ (ระบุ)<font color="red">*</font>
                                                    </label>
                                                </td>
                                                <td style="border-bottom:dotted;border-bottom-width:thin">
                                                    {{LIST_DH.dh15rqt.OTHER_ATTACH}}
                                                </td>
                                            </tr>
                                        </table>
                                    </form>
                                </td>
                            </tr>
                        </table>
                        <br />
                        <div style="color:red;font-size:20px">*ภค.1 หมายถึง การนำเข้าสาร / ครั้ง ตามจำนวนที่ระบุหรือปริมาณรวม (นำเข้าหลายครั้ง) แต่ไม่เกินปริมาณที่ขอ</div>
                    </div>
                    @*-------------AN------------------*@
                    @*-------------IR------------------*@
                    <div class="ic" ng-show="LIST_DH.dh15rqt.PROCESS_ID == '16'">
                        <table width="100%" style="font-size:20px">
                            <tr>
                                <td width="20%">
                                    ชื่อผู้ผลิต (Manufacturer)
                                </td>
                                <td width="45%" style="border-bottom:dotted;border-bottom-width:thin">
                                    {{LIST_DH.DH15_DETAIL_CER.FOREIGN_LOCATION_NAME}}
                                </td>
                                <td width="15%">
                                    ประเทศ (Country)
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin">
                                    {{LIST_DH.COUNTRY_NAME}}
                                </td>
                            </tr>
                        </table>
                        <table width="100%" style="font-size:20px">
                            <tr>
                                <td width="50%">
                                    ชื่อผู้แทนจำหน่ายในต่างประเทศ (ซื้อผ่าน) (Foreign Distributor (Purchasing through))
                                </td>
                                <td width="20%" style="border-bottom:dotted;border-bottom-width:thin">
                                    {{LIST_DH.dh15rqt.AGENT_NAME}}
                                </td>
                                <td width="15%">
                                    ประเทศ (Country)
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin">
                                    {{LIST_DH.AGENT_COUNTRY_NAME}}
                                </td>
                            </tr>
                        </table>
                        <table width="100%" style="font-size:20px">
                            <tr>
                                <td width="20%">
                                    ชื่อการค้า (Trade Name)<font color="red">*</font>
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin" colspan="3">
                                    <label>
                                        {{LIST_DH.dh15rqt.TRADING_NAME}}
                                    </label>
                                </td>
                            </tr>
                        </table>
                        <table width="100%" style="font-size:20px">
                            <tr>
                                <td width="55%">
                                    มาตรฐานตามตำรายา (Phamacopoeia Standard of Drug Substance)
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin">
                                    <label>
                                        {{LIST_DH.dh15rqt.PHARMACOPOEIA_STANDARDS}}
                                    </label>
                                </td>
                            </tr>
                        </table>
                        <table width="100%" style="font-size:20px">
                            <tr>
                                <td width="5%">
                                    เกรด
                                </td>
                                <td style="border-bottom:dotted;border-bottom-width:thin">
                                    {{LIST_DH.dh15rqt.GRADE}}
                                </td>
                            </tr>
                        </table>
                    </div>
                    @*-------------IR------------------*@
                    @*-------------IN------------------*@
                    @*<div class="ic" ng-show="LIST_DH.dh15rqt.PROCESS_ID == '17'">
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
                            <select style="font-family:'Taviraj';font-size:20px;" ng-model="LIST_DH.dh15rqt.AGENT_COUNTRY_ID">
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

            </div>*@


                </div>
                <br />
                <div ng-include="INPUT_CHEM_DH">

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
            <div class="part part-1-3 ic">
                <div class="card">
                    <table class="table">
                        <tr>
                            <td>
                                สถานะ
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <select style="font-family:'Taviraj';font-size:20px;" ng-model="STATUS_ID" class="form-control">
                                    <option ng-repeat="x in STAT_LIST" value="{{x.STATUS_ID}}">{{x.STATUS_NAME}}</option>
                                </select>
                            </td>
                        </tr>
                    </table>

                    <br />
                    <div align="center">
                        <input type="button" style="width:50%;background-color:#38A86B;color:white" class="btn btn-lg " ng-click="BTN_DH_CONFIRM(STATUS_ID)" value="บันทึก" />
                    </div>
                    <br />
                    <div align="center">
                        <input type="button" style="width:50%;background-color:#FFD700" class="btn btn-lg " ng-click="BTN_BACK()" value="ย้อนกลับ" />
                    </div>
                    <br />
                    <div>

                    </div>
                </div>
            </div>
        </div>
    </div>
</div>