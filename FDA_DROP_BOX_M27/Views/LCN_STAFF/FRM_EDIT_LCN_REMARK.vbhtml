@Code
    ViewData("Title") = "FRM_EDIT_LCN_REMARK"
End Code

<div style="width:100%">
    <div>
        <h1>หมายเหตุการคืนคำขอ</h1>
    </div>
    <div class="panel-body">
        <input type="text" ng-model="LIST_DH.DALCN_EDIT_REQUEST.REMARK" style="width:100%;height:311px;" />

    </div>
    <div class="panel-footer">

        <input type="button" class="btn btn-lg " ng-click="BTN_UPDATE_LCN_EDIT_REMARK()" value="บันทึกยกเลิก" />

        <input type="button" class="btn btn-lg " ng-click="" value="ย้อนกลับ" />
    </div>
</div>