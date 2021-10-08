@Code
    Layout = ""
End Code


<div class="panel" style="width:100%">
    <div class="panel-heading panel-title">
        <h1>อนุญาตคำขอ</h1>
    </div>
    <div class="panel-body">

        <table class="table">

            <tr>
                <td width="30%">ชื่อผู้ลงนาม <font color="red">*</font></td>
                <td>
                    <input type="text" ng-model="LIST_APP_LCN.TABLET_CAPSULE" />

                </td>
            </tr>

            <tr>
                <td>ตำแหน่ง <font color="red">*</font></td>
                <td>
                    <input type="text" ng-model="LIST_APP_LCN.PHARMACEUTICAL_CHEMICALS" />
                </td>
            </tr>

            <tr>
                <td>วันที่อนุมัติ</td>
                <td>
                    {{LIST_APP_LCN.APPDATE_STR}}
                </td>
            </tr>

        </table>
    </div>
    <div class="panel-footer " style="text-align:center;">

        <input type="button" class="btn btn-lg " ng-click="BTN_SAVE_APP()" value="บันทึก" />

        <input type="button" class="btn btn-lg " ng-click="" value="ย้อนกลับ" />
    </div>
</div>
