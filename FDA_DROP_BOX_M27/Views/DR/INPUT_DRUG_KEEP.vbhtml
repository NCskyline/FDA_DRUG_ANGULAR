@Code
    ViewData("Title") = "INPUT_DRUG_KEEP"
End Code

<table class="table">
    <tr>
        <td>
            อายุการใช้งาน :
        </td>
        <td width="25%">
            <input type="text" id="txt_AGE_MONTH" />
            เดือน
        </td>
        <td class="auto-style1">
            &nbsp;
        </td>
        <td>
            <input type="text" id="txt_AGE_DAY" />
            วัน
        </td>
        <td>
            &nbsp;
        </td>
        <td>
            <input type="text" id="txt_AGE_HOUR" />ชั่วโมง
        </td>
        <td>
            &nbsp;
        </td>

    </tr>
    <tr>
        <td>ช่วงอุณหภูมิการเก็บรักษา ระหว่าง</td>
        <td>
            <input type="text" id="txt_TEMPERATE1" />
            &nbsp;องศาเซลเซียส
        </td>
        <td class="auto-style1">ถึง</td>
        <td>
            <input type="text" id="txt_TEMPERATE2" />
            &nbsp;องศาเซลเซียส
        </td>
        <td></td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td>
            สภาวะการเก็บรักษา :
        </td>
        <td colspan="6">
            <input type="text" id="txt_KEEP_DESCRIPTION" style="width:70%;height:100px;" />
        </td>
    </tr>
    <tr>
        <td>
            ลักษณะยา :
        </td>
        <td colspan="6">
            <input type="text" id="txt_DRUG_DETAIL" style="width:70%;height:100px;" />
        </td>
    </tr>
    <tr>
        <td colspan="7" align="center">
            <input type="button" ID="btn_save" value="บันทึก" />
        </td>
    </tr>
    <tr>
        <td colspan="7">
            //ตาราง
        </td>
    </tr>
</table>