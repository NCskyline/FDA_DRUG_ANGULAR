@Code
    ViewData("Title") = "FRM_TABEAN_YA_CHANGE_STATUS"
End Code

<table>
    <tr>
        <td>
            <h2>ข้ามสถานะชำระเงิน</h2>
        </td>
        <td>
            <form name="rdl_gmp">


                <label><input type="radio" ng-model="CHK_TYPE" id="Rdl_gmpt" value="1" checked> ทะเบียน</label><br />
                <label><input type="radio" ng-model="CHK_TYPE" id="Rdl_gmpt" value="2"> แก้ไขเปลี่ยนแปลงทะเบียน</label><br />

            </form>
        </td>
    </tr>
</table>
<table>
    <tr>
        <td>
            เลขดำเนินการที่ 1
        </td>
        <td>
            <input type="text" ng-model="txt_no_1" />
        </td>
    </tr>
    <tr>
        <td>
            เลขดำเนินการที่ 2
        </td>
        <td>
            <input type="text" ng-model="txt_no_2" />
        </td>
    </tr>
    <tr>
        <td>
            เลขดำเนินการที่ 3
        </td>
        <td>
            <input type="text" ng-model="txt_no_3" />
        </td>
    </tr>
    <tr>
        <td>
            เลขดำเนินการที่ 4
        </td>
        <td>
            <input type="text" ng-model="txt_no_4" />
        </td>
    </tr>
    <tr>
        <td>
            เลขดำเนินการที่ 5
        </td>
        <td>
            <input type="text" ng-model="txt_no_4" />
        </td>
    </tr>
    <tr>
        <td>
            &nbsp;
        </td>
        <td>
            <input type="button" value="ข้ามสถานะ" ng-click="BTN_SEND_STATUS(CHK_TYPE,txt_no_1,txt_no_2,txt_no_3,txt_no_4,txt_no_5)" />
        </td>
    </tr>
</table>
