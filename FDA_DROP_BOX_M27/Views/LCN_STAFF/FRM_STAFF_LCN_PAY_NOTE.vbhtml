@Code
    ViewData("Title") = "FRM_STAFF_LCN_PAY_NOTE"
End Code

<div class="panel" style="width:100%">
    <div class="panel-heading panel-title">
        <h1>รายละเอียดใบเสร็จรับเงิน</h1>
    </div>
    <div class="panel-body">
        <asp:TextBox ID="TextBox1" runat="server" Width="100%" TextMode="MultiLine" Height="311px"></asp:TextBox>
        <input type="text" ng-model="" />

    </div>
    <div class="panel-footer " style="text-align:center;">
        <input type="button" class="btn btn-lg " ng-click="BTN_SAVE_PAYNOTE()" value="บันทึก" />

        <input type="button" class="btn btn-lg " ng-click="" value="ย้อนกลับ" />
    </div>
</div>