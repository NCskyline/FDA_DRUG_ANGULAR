<script>

</script>
<style>

</style>
<table style="width:100%;margin:0 auto" @*border="1"*@>
    <tr >
        <td style="width:30%;padding-left:7%">
            ชื่อผู้ดำเนินกิจการเดิม
        </td>
        <td>
            :
        </td>
        <td>
            <label>{{LIST_EDIT_LCN.OLD_BSN_THAIFULLNAME}}</label>
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
            <label>{{LIST_EDIT_LCN.OLD_fulladdr}}</label>
        </td>
    </tr>
    <tr>
        <td style="width:30%;padding-left:7%">
            กรอกเลข 13 หลัก เพื่อดึงข้อมูลผู้ดำเนิน
        </td>
        <td>
            :
        </td>
        <td >
            <input type="text" ng-model="LIST_EDIT_LCN.txt_ctzid" />  <input type="button" value="ค้นหา"/>
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
            <label>{{LIST_EDIT_LCN.NEW_BSN_THAIFULLNAME}}</label>
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
            <label>{{LIST_EDIT_LCN.NEW_fulladdr}}</label>
        </td>
    </tr>
</table>
<center><input type="button" value="เปลี่ยนชื่อดำเนินการ" /></center>
