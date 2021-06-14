@Code
    Layout = ""
End Code
<script src="../Scripts_angular/CENTER_SV.js"></script>
<script src="../Scripts_angular/DH_CTRL.js"></script>
<div class="ic">
    <center>
        <h2>คำขอจดแจ้งเภสัชเคมีภัณฑ์</h2> <br />
        <h2>
            ไม่เป็นสารออกฤทธิ์ตามทะเบียนตำรับยาผลิตในประเทศ
        </h2>
    </center>
    <table>
        <tr>
            <td>

                <div ng-include src="'Views/DH/HEADER_DH'"></div>
            </td>
        </tr>
    </table>

    <table width="100%">
        <tr>
            <td>
                ชื่อผู้ผลิต
            </td>
            <td width="30%">
                <input class="form-control inline" ng-model="LIST_DH.DH15_DETAIL_CER.FOREIGN_LOCATION_NAME" style="font-family:'TH SarabunPSK';font-size:20px;" type="text" />
            </td>
            <td>
                ประเทศ
            </td>
            <td width="10%">
                <select style="font-family:'TH SarabunPSK';font-size:20px;" ng-model="LIST_DH.DH15_DETAIL_CER.COUNTRY_NAME">
                    <option value="0">--กรุณาเลือก--</option>
                    <option ng-repeat="x in CNT_LIST" value="{{x.IDA}}">{{x.engcntnm}}</option>
                </select>
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
        <tr>
            <td>
                ชื่อการค้า<font color="red">*</font>
            </td>
            <td colspan="3">
                <input class="form-control inline" ng-model="LIST_DH.dh15rqt.TRADING_NAME" style="font-family:'TH SarabunPSK';font-size:20px;" type="text" />
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
                <input class="form-control inline" ng-model="LIST_DH.dh15rqt.PHARMACOPOEIA_STANDARDS" style="font-family:'TH SarabunPSK';font-size:20px;" type="text" />
            </td>
        </tr>
        <tr>
            <td>
                เกรด
            </td>
            <td>
                <input class="form-control inline" ng-model="LIST_DH.dh15rqt.GRADE" style="font-family:'TH SarabunPSK';font-size:20px;" type="text" />
            </td>
        </tr>
    </table>
    <table>
        <tr>
            <td>
                จำนวน
            </td>
            <td>
                <input class="form-control inline" ng-model="LIST_DH.dh15rqt.amount" style="font-family:'TH SarabunPSK';font-size:20px;" type="text" />
            </td>
            <td>
                ปริมาณ
            </td>
            <td>
                <input class="form-control inline" ng-model="LIST_DH.dh15rqt.quantity" style="font-family:'TH SarabunPSK';font-size:20px;" type="text" />
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
                    <input class="form-control inline" ng-model="LIST_DH.dh15rqt.OTHER_PURPOSE" style="font-family:'TH SarabunPSK';font-size:20px;" type="text" />
                </form>
            </td>
        </tr>
    </table>

</div>