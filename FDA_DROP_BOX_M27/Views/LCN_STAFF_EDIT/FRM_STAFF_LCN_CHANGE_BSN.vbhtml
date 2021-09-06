<script src="~/Scripts_angular/CENTER_SV.js"></script>
@*<script src="~/Scripts_angular/LCN_EDIT_CTRL.js"></script>*@
<script src="~/Scripts_angular/LCN_STAFF_EDIT_CTRL.js"></script>


<div ng-controller="LCN_STAFF_EDIT_CTRL" ng-app="ANGULAR_APP" ng-init="pageload()" class="ic">
    
    <div style="font-family:'Taviraj';font-size:20px;">
        <div style="text-align:center;">
            <h1>เปลี่ยนผู้ดำเนินกิจการ</h1>
        </div>
        <table style="width:100%;margin:0 auto">
            <tr>
                <td style="width:30%;padding-left:7%">
                    ชื่อผู้ดำเนินกิจการเดิม
                </td>
                <td>
                    :
                </td>
                <td>
                    {{INFO_LIST.OLD_BSN_THAIFULLNAME}}
                </td>
            </tr>
            <tr>
                <td style="width:30%;padding-left:7%">
                    ที่อยู่เดิม
                </td>
                <td>
                    :
                </td>
                <td>
                    {{INFO_LIST.OLD_BSN_fulladdr}}
                </td>
            </tr>
            <tr>
                <td style="width:30%;padding-left:7%">
                    กรอกเลข 13 หลัก เพื่อดึงข้อมูลผู้ดำเนิน
                </td>
                <td>
                    :
                </td>
                <td>
                    <input type="text" ng-model="txt_ctzid" style="width:30%;" />  <input type="button" value="ค้นหา" ng-click="Search_Bsn(txt_ctzid)" />
                </td>
            </tr>
            <tr>
                <td style="width:30%;padding-left:7%">
                    ชื่อผู้ดำเนินใหม่
                </td>
                <td>
                    :
                </td>
                <td>
                    <label>{{LIST_BSN.NEW_BSN_THAIFULLNAME}}</label>
                </td>
            </tr>
            <tr>
                <td style="width:30%;padding-left:7%">
                    ที่อยู่ใหม่
                </td>
                <td>
                    :
                </td>
                <td>
                    <label>{{LIST_BSN.NEW_BSN_fulladdr}}</label>
                </td>
            </tr>
        </table>
        <center><input type="button" value="เปลี่ยนชื่อดำเนินการ" /></center>
    </div>
</div>