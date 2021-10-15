﻿@Code

End Code
<script src="~/Scripts_angular/ANGULAR_APP.js"></script>
<script src="~/Scripts_angular/CENTER_SV.js"></script>
<script src="~/Scripts_angular/DH_STAFF_CTRL.js"></script>


<div ng-controller="DH_STAFF_CTRL" ng-app="ANGULAR_APP" ng-init="PREVIEW_DH()">
    <div>
        <div class="content-part">
            <div class="part part-2-3 ic">
                <div style="font-family:'Taviraj';width:100%">
                    <center>
                        <h2>คำขอจดแจ้งเภสัชเคมีภัณฑ์</h2> <br />
                        <h2>
                            {{HEADER_PROCESS}}
                        </h2>
                    </center>
                    <table width="100%" style="font-family:'Taviraj';font-size:20px;">
                        <tr>
                            <td width="20%" align="right">
                                ข้าพเจ้า
                            </td>
                            <td style="border-bottom:dotted;border-bottom-width:thin;" align="center">
                                <label>{{LIST_LCN.NAME}}</label>
                            </td>
                            <td>
                                ผู้รับอนุญาต
                            </td>

                        </tr>
                    </table>
                    <table width="100%" style="font-family:'Taviraj';font-size:20px;">
                        <tr>
                            <td width="30%">
                                <form name="myForm">
                                    <label>
                                        <input type="radio" ng-model="LIST_LCN.CHK_TYPE_LCN" value="1">
                                        ผลิต
                                    </label>
                                    <label>
                                        <input type="radio" ng-model="LIST_LCN.CHK_TYPE_LCN" value="2">
                                        นำหรือสั่ง เข้ามาในราชอาณาจักร ซึ่งยาแผนปัจจุบัน
                                    </label>
                                </form>
                            </td>
                            <td align="right" width="10%">
                                ใบอนุญาต เลขที่
                            </td>
                            <td style="border-bottom:dotted;border-bottom-width:thin;">
                                <span style="padding-left:5px;" />  <label>{{LIST_LCN.LCN_NO_DISPLAY}}</label>
                            </td>

                        </tr>

                    </table>
                    <table width="100%" style="font-family:'Taviraj';font-size:20px;">
                        <tr>
                            <td width="10%">อยู่เลขที่ </td>
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
                            <td>มีความประสงค์ขอ</td>
                        </tr>
                    </table>
                    <table width="100%" style="font-family:'Taviraj';font-size:20px;">
                        <tr>
                            <td width="25%">
                                <form name="myForm">
                                    <label>
                                        <input type="radio" ng-model="LIST_LCN.CHK_TYPE_LCN" value="1">
                                        ผลิต
                                    </label>
                                    <label>
                                        <input type="radio" ng-model="LIST_LCN.CHK_TYPE_LCN" value="2">
                                        นำหรือสั่งเข้ามาในราชอาณาจักร
                                    </label>
                                </form>

                            </td>
                            <td>

                                <form name="myForm">
                                    ซึ่ง
                                    <label>
                                        <input type="radio" ng-model="LIST_LCN.dh15rqt.CHK_TYPE_CHEMICAL" value="1">
                                        เภสัชเคมีภัณฑ์เดี่ยว
                                    </label>
                                    <label>
                                        <input type="radio" ng-model="LIST_LCN.dh15rqt.CHK_TYPE_CHEMICAL" value="2">
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

                        <table width="100%">
                            <tr>
                                <td width="20%">
                                    Ref Cer
                                </td>
                                <td>
                                    {{LIST_DH.REF_CER_NO}}
                                </td>
                            </tr>
                        </table>
                        <table width="100%">
                            <tr>
                                <td width="20%">
                                    ชื่อผู้ผลิต
                                </td>
                                <td>
                                    <label>
                                        {{LIST_DH.DH15_DETAIL_CER.FOREIGN_LOCATION_NAME}}
                                    </label>
                                </td>
                                <td>
                                    ประเทศ
                                </td>
                                <td width="15%">
                                    {{LIST_DH.DH15_DETAIL_CER.COUNTRY_NAME}}
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    ชื่อผู้แทนจำหน่ายในต่างประเทศ (ซื้อผ่าน)
                                </td>
                                <td>
                                    {{LIST_DH.dh15rqt.AGENT_NAME}}
                                </td>
                                <td>
                                    ประเทศ
                                </td>
                                <td>
                                    {{LIST_DH.DH15_DETAIL_CER.COUNTRY_NAME}}
                                </td>
                            </tr>
                        </table>
                        <br />
                        <table width="100%">
                            <tr>
                                <td width="20%">
                                    วันเดือนปีที่ออกใบรับรอง
                                </td>
                                <td>
                                    {{LIST_DH.DH15_DETAIL_CER.DOCUMENT_DATE}}
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    วันเดือนปีที่หมดอายุ
                                </td>
                                <td>
                                    {{LIST_DH.DH15_DETAIL_CER.EXP_DOCUMENT_DATE}}
                                </td>
                            </tr>
                        </table>
                        <table width="100%">
                            <tr>
                                <td width="20%">
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
                    <div class="ic" ng-show="LIST_DH.dh15rqt.PROCESS_ID == '15'">

                        <table width="100%">
                            <tr>
                                <td width="20%">
                                    Ref Cer
                                </td>
                                <td>
                                    {{LIST_DH.REF_CER_NO}}
                                </td>
                            </tr>
                        </table>
                        <table width="100%">
                            <tr>
                                <td width="20%">
                                    ชื่อผู้ผลิต
                                </td>
                                <td>
                                    {{LIST_DH.DH15_DETAIL_CER.FOREIGN_LOCATION_NAME}}
                                </td>
                                <td>
                                    ประเทศ
                                </td>
                                <td width="15%">

                                    {{LIST_DH.DH15_DETAIL_CER.COUNTRY_NAME}}

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
                        <table width="100%">
                            <tr>
                                <td width="20%">
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
                                <td width="20%">
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
                    <div class="ic" ng-show="LIST_DH.dh15rqt.PROCESS_ID == '16'">

                        <table width="100%">
                            <tr>
                                <td width="20%">
                                    ชื่อผู้ผลิต
                                </td>
                                <td>

                                    {{LIST_DH.DH15_DETAIL_CER.FOREIGN_LOCATION_NAME}}

                                </td>
                                <td>
                                    ประเทศ
                                </td>
                                <td width="15%">

                                    {{LIST_DH.COUNTRY_NAME}}

                                </td>
                            </tr>
                            <tr>
                                <td>
                                    ชื่อผู้แทนจำหน่ายในต่างประเทศ (ซื้อผ่าน)
                                </td>
                                <td>

                                    {{LIST_DH.dh15rqt.AGENT_NAME}}

                                </td>
                                <td>
                                    ประเทศ
                                </td>
                                <td>

                                    {{LIST_DH.AGENT_COUNTRY_NAME}}

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
                        <table width="100%">
                            <tr>
                                <td width="20%">
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

                                    {{LIST_DH.dh15rqt.GRADE}}

                                </td>
                            </tr>
                        </table>
                    </div>
                    @*-------------IR------------------*@
                    @*-------------IN------------------*@
                    <div class="ic" ng-show="LIST_DH.dh15rqt.PROCESS_ID == '17'">
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

                    </div>


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
                                <select class="form-control">
                                    <option>อนุมัติ</option>
                                    <option>ไม่อนุมัติ</option>
                                </select>
                            </td>
                        </tr>
                    </table>

                    <br />
                    <div align="center">
                        <input type="button" style="width:50%" class="btn btn-lg " ng-click="BTN_DH_CONFIRM()" value="บันทึก" />
                    </div>
                    <br />
                    <div align="center">
                        <input type="button" style="width:50%" class="btn btn-lg " ng-click="BTN_BACK()" value="ย้อนกลับ" />
                    </div>
                    <br />
                    <div>

                    </div>
                </div>
            </div>
        </div>
    </div>
</div>