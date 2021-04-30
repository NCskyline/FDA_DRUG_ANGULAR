@Code
    ViewData("Title") = "INPUT_KEEP"
End Code

<table width="100%">
    <tr>
        <td>สภาวะการเก็บรักษา</td>
        <td width="75%">
            <input type="text" id="txt_keep" style="width:100%;height:200px;" />
        </td>
    </tr>
    <tr>
        <td colspan="2">
            <table>
                <tr>
                    <td>อายุการใช้งาน :</td>
                    <td width="25%">
                        <input type="text" id="txt_AGE_MONTH" />
                               เดือน
                    </td>
                    <td class="auto-style1">&nbsp;</td>
                    <td>
                        <input type="text" id="txt_AGE_DAY" />
                        วัน
                    </td>
                    <td>&nbsp;</td>
                    <td>
                        <input type="text" id="txt_AGE_HOUR" />ชั่วโมง
                    </td>
                    <td>&nbsp;</td>

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
            </table>
        </td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td width="75%">
            <input type="button" id="btn_insert" value="บันทึกข้อมูล" />
        </td>
    </tr>
</table>