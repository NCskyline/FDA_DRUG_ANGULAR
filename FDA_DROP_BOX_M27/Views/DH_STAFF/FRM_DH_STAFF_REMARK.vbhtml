@Code
    ViewData("Title") = "FRM_DH_STAFF_REMARK"
    Layout = ""
End Code

<div style="width:100%">
    <div>
        <h1>หมายเหตุการคืนคำขอ</h1>
    </div>
    <div class="panel-body">
        <input type="text" ng-model="LIST_DH.dh15rqt.REMARK" style="width:100%;height:311px;" />

    </div>
    <div class="panel-footer">

        <input type="button" class="btn btn-lg " ng-click="BTN_UPDATE_DH_REMARK()" value="บันทึกยกเลิก" />

        <input type="button" class="btn btn-lg " ng-click="" value="ย้อนกลับ" />
    </div>
</div>