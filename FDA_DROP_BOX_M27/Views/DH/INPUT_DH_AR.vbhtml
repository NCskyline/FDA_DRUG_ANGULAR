@Code Layout = "" End Code
@*<script src="../Scripts_angular/CENTER_SV.js"></script>
    <script src="../Scripts_angular/DH_CTRL.js"></script>*@

<script type="text/javascript">
    $(document).ready(function () {
        $('#REF_CERT').selectpicker('refresh');
    });
    $(document).ready(function () {
        $('#country').selectpicker('refresh');
    });
</script>

<div class="ic" style="font-family:'Taviraj';font-size:20px">
    @*<center>
        <h2>คำขอจดแจ้งเภสัชเคมีภัณฑ์</h2> <br />
        <h2>
            เป็นสารออกฤทธิ์ในทะเบียนตำรับยาผลิตในประเทศ
        </h2>
    </center>
    <br />*@
    <table width="40%">
        <tr>
            <td>
                เลขที่อ้างอิงสถานที่ผลิต (ThFDA-D Ref)
            </td>
            <td>
                <select id="REF_CERT" class="selectpicker" data-live-search="true" title="-- Please select --" ng-model="LIST_DH.DH15_DETAIL_CER.CER_DETAIL_CHEMICAL_IDA" ng-change="Getdetails_REF_CER(LIST_DH.DH15_DETAIL_CER.CER_DETAIL_CHEMICAL_IDA)">
                    <option ng-repeat="ref in REF_CERT" value="{{ref.IDA}}">{{ref.CER_NUMBER}}</option>
                </select>
            </td>
        </tr>
    </table>
    <table width="100%">
        <tr>
            <td width="33%">
                ชื่อผู้ผลิตเภสัชเคมีภัณฑ์ (Drug Substance Manufacturer)
            </td>
            <td width="35%" style="border-bottom:dotted;border-bottom-width:thin">
                <label>
                    {{LIST_REF_CERT.DH15_DETAIL_CER.FOREIGN_LOCATION_NAME}}
                </label>
            </td>
            <td width="12%">
                ประเทศ (Country)
            </td>
            <td style="border-bottom:dotted;border-bottom-width:thin">
                <label>
                    {{LIST_REF_CERT.COUNTRY_NAME}}
                </label>
            </td>
        </tr>
    </table>
    <table width="100%">
        <tr>
            <td width="15%">
                ที่ตั้ง (Site Address)
            </td>
            <td style="border-bottom:dotted;border-bottom-width:thin"></td>
        </tr>
    </table>
    <table width="100%">
        <tr>
            <td width="20%">
                เมือง (City / Province / State)
            </td>
            <td style="border-bottom:dotted;border-bottom-width:thin"></td>
        </tr>
        <tr>
            <td width="20%">
                วันที่ออกใบรับรอง (Issue Date)
            </td>
            <td style="border-bottom:dotted;border-bottom-width:thin;">
                <label>
                    {{LIST_REF_CERT.CER.DOCUMENT_DATE}}
                </label>
            </td>
        </tr>
        <tr>
            <td width="20%">
                วันที่ใบรับรองหมดอายุ (Valid Until)
            </td>
            <td style="border-bottom:dotted;border-bottom-width:thin">
                <label>
                    {{LIST_REF_CERT.CER.EXP_DOCUMENT_DATE}}
                </label>
            </td>
        </tr>
    </table>
    <table width="100%">
        <tr>
            <td width="50%">
                ชื่อผู้แทนจำหน่ายในต่างประเทศ (ซื้อผ่าน) (Foreign Distributor (Purchasing through))
            </td>
            <td>
                <input class="form-control inline" ng-model="LIST_DH.dh15rqt.AGENT_NAME" style="font-family:'Taviraj';font-size:20px;width:100%" type="text" />
            </td>
            <td>
                ประเทศ (Country)
            </td>
            <td width="15%">
                <select id="country" class="form-control selectpicker" data-live-search="true" title="-- Please select --" style="font-family:'Taviraj';font-size:20px;" ng-model="LIST_DH.dh15rqt.AGENT_COUNTRY_ID">
                    @*<option value="0">--กรุณาเลือก--</option>*@
                    <option ng-repeat="x in CNT_LIST" value="{{x.IDA}}">{{x.engcntnm}}</option>
                </select>
            </td>
        </tr>
    </table>
    <table width="100%">
        <tr>
            <td width="15%">
                ชื่อการค้า (Trade Name) <font color="red">*</font>
            </td>
            <td>
                <input class="form-control inline" ng-model="LIST_DH.dh15rqt.TRADING_NAME" style="font-family:'Taviraj';font-size:20px;width:100%" type="text" />
            </td>
        </tr>
    </table>
    <table width="100%">
        <tr>
            <td width="40%">
                มาตรฐานตามตำรายา (Phamacopoeia Standard of Drug Substance)
            </td>
            <td>
                <input class="form-control inline" ng-model="LIST_DH.dh15rqt.PHARMACOPOEIA_STANDARDS" style="font-family:'Taviraj';font-size:20px;width:100%" type="text" />
            </td>
        </tr>
    </table>
</div>