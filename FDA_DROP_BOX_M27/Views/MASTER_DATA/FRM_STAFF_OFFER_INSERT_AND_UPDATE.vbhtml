@Code
    Layout = ""
End Code


<div class="panel" style="width:100%">
    <div class="panel-heading panel-title">
        <h1>
            เสนอลงนาม
        </h1>
    </div>
    <div class="panel-body">

        <table class="table">
            <tr>
                <td>ชื่อ - นามสกุล</td>
                <td>
      
                    <input type="text" ng-model="LIST_LCN.dalcn.STAFF_OFFER_NAME" style="width:300px;" />
                </td>
            </tr>

            <tr>
                <td>ตำแหน่ง</td>
                <td>

                    <input type="text" ng-model="LIST_LCN.dalcn.POSITION_NAME" style="width:300px;" />
                </td>
            </tr>

        </table>
    </div>
    <div class="panel-footer " style="text-align:center;">
        <input type="button" class="btn btn-lg " ng-click="BTN_SAVE_STAFF_OFFER()" value="บันทึก" />

        <input type="button" class="btn btn-lg " ng-click="" value="ย้อนกลับ" />
    </div>
</div>