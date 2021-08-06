@Code
    Layout = ""
End Code
@*<script src="../Scripts_angular/CENTER_SV.js"></script>
<script src="../Scripts_angular/DH_CTRL.js"></script>*@
<div class="ic" style="font-family:'Taviraj';font-size:20px;">
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
                <select class="form-control" ng-model="LIST_DH.DH15_DETAIL_CER.CER_DETAIL_CHEMICAL_IDA">
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
    </table>

    //Table เพิ่มสาร
</div>