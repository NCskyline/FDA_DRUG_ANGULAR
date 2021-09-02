<script>

</script>
<style>

</style>
<table style="width:100%" @*border="1"*@>
    <tr>
        <td style="width:45%;padding-left:20%">
            ชื่อผู้รับอนุญาต (เดิม)
        </td>
        <td>
            :
        </td>
        <td>
            <label>{{LIST_EDIT_LCN.OLD_LCNNM}}</label>
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
            <input type="text" ng-model="LIST_EDIT_LCN.txt_ctzid_lcn" /><input type="button" value="ค้นหา" />
        </td>
    </tr>
    <tr>
        <td style="padding-left:46.5%" colspan="3">
            <label>{{LIST_EDIT_LCN.NEW_LCNNM}}</label>
        </td>
    </tr>
</table> 
<br />
<center><input type="button" value="เปลี่ยนผู้รับอนุญาติ" /></center>
