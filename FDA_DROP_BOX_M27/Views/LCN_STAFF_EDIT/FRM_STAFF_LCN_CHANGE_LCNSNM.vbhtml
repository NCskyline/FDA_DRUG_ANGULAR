<script src="../Scripts_angular/ANGULAR_APP.js"></script>
<script src="../Scripts_angular/CENTER_SV.js"></script>
<script src="../Scripts_angular/LCN_STAFF_EDIT_CTRL.js"></script>
<div ng-controller="LCN_STAFF_EDIT_CTRL" ng-app="ANGULAR_APP" class="ic" ng-init="pageload()">
    <div style="font-family:'Taviraj';font-size:20px;">
        <table style="width:100%" @*border="1"*@>
            <tr>
                <td style="width:45%;padding-left:20%">
                    ชื่อผู้รับอนุญาต (เดิม)
                </td>
                <td>
                    :
                </td>
                <td>
                    <label>{{INFO_LIST.LCNNAME}}</label>
                </td>
            </tr>
            <tr>
                <td style="padding-left:20%">
                    เลขนิติฯ/เลขประจำตัวประชาชน (ใหม่)
                </td>
                <td>
                    :
                </td>
                <td>
                    <input type="text" ng-model="txt_ctzid_lcn" /><input type="button" value="ค้นหา" ng-click="Search_lcns(txt_ctzid_lcn)" />
                </td>
            </tr>
            <tr>
                <td style="padding-left:46.5%" colspan="3">
                    <label>{{LIST_LCNS.NEW_LCNNM}}</label>
                </td>
            </tr>
        </table>
        <br />
        <center><input type="button" value="เปลี่ยนผู้รับอนุญาติ" /></center>
</div>
</div>