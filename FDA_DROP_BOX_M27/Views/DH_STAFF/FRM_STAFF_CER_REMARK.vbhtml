
@Code
    Layout = Nothing
End Code

<div style="width:100%">
    <div>
        <h1>หมายเหตุการคืนคำขอ</h1>
    </div>
    <div class="panel-body">
        <input type="text" ng-model="LIST_GMP.CER.REMARK" style="width:100%;height:311px;" />

    </div>
    <div class="panel-footer">

        <input type="button" class="btn btn-lg " ng-click="BTN_SAVE_REMARK_CERT()" value="บันทึกยกเลิก" />

        <input type="button" class="btn btn-lg " ng-click="BTN_BACK_DH()" value="ย้อนกลับ" />
    </div>
</div>