@Code
    Layout = ""
End Code
@*<script src="../Scripts_angular/CENTER_SV.js"></script>
<script src="../Scripts_angular/DH_CTRL.js"></script>*@
<script type="text/javascript">
    $(document).ready(function () {
        $('select').selectpicker('refresh');
    })
</script>
<div class="ic" style="font-family:'Taviraj';font-size:20px">
    @*<center>
        <h2>คำขอจดแจ้งเภสัชเคมีภัณฑ์</h2> <br />
        <h2>
            เป็นสารไม่ออกฤทธิ์ในทะเบียนตำรับยาผลิตในประเทศ
        </h2>
    </center>*@
    <table>
        <tr>
            <td>

                <div ng-include src="'Views/DH/HEADER_DH'"></div>
            </td>
        </tr>
    </table>

    <table width="100%">
        <tr>
            <td width="15%">
                ชื่อผู้ผลิต (Manufacturer)
            </td>
            <td width="50%">
                <input class="form-control inline" ng-model="LIST_DH.DH15_DETAIL_CER.FOREIGN_LOCATION_NAME" style="font-family:'Taviraj';font-size:20px;" type="text" />
            </td>
            <td width="12%">
                ประเทศ (Country)
            </td>
            <td width="20%">
                <select class="form-control selectpicker" data-live-search="true" title="-- Please select --" style="font-family:'Taviraj';font-size:20px;" ng-model="LIST_DH.DH15_DETAIL_CER.COUNTRY_NAME">
                    @*<option value="0">--กรุณาเลือก--</option>*@
                    <option ng-repeat="x in CNT_LIST" value="{{x.IDA}}">{{x.engcntnm}}</option>
                </select>
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
                <select class="form-control selectpicker" data-live-search="true" title="-- Please select --" style="font-family:'Taviraj';font-size:20px;" ng-model="LIST_DH.dh15rqt.AGENT_COUNTRY_ID">
                    @*<option value="0">--กรุณาเลือก--</option>*@
                    <option ng-repeat="x in CNT_LIST" value="{{x.IDA}}">{{x.engcntnm}}</option>
                </select>
            </td>
        </tr>
    </table>
    <table width="100%">
        <tr>
            <td width="15%">
                ชื่อการค้า (Trade Name)<font color="red">*</font>
            </td>
            <td colspan="3">
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
    <table width="100%">
        <tr>
            <td width="5%">
                เกรด
            </td>
            <td>
                <input class="form-control inline" ng-model="LIST_DH.dh15rqt.GRADE" style="font-family:'Taviraj';font-size:20px;width:100%" type="text" />
            </td>
        </tr>
    </table>
</div>