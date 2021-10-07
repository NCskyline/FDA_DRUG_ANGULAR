@Code
    ViewData("Title") = "FRM_STAFF_LCN_APPROVE"
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
                    <input type="text" ng-model="txt_name" />

                </td>
            </tr>

            <tr>
                <td>ตำแหน่ง <font color="red">*</font></td>
                <td>
                    <input type="text" ng-model="txt_position" />
                </td>
            </tr>

            <tr>
                <td>วันที่อนุมัติ</td>
                <td>
                    {{LIST_LCN.appdate}}
                </td>
            </tr>

        </table>
    </div>
    <div class="panel-footer " style="text-align:center;">

        <input type="button" class="btn btn-lg " ng-click="BLABLA()" value="บันทึก" />

        <input type="button" class="btn btn-lg " ng-click="BLABLA()" value="ย้อนกลับ" />
    </div>
</div>
