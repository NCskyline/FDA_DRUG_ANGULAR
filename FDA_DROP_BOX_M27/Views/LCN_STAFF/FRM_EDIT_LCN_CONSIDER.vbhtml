@Code
    ViewData("Title") = "FRM_EDIT_LCN_CONSIDER"
    Layout = ""
End Code
<div class="panel" style="width:100%">
    <div>
        <h1>เสนอลงนาม</h1>
    </div>
    <div>
        <table class="table">
            <tr>
                <td>หมายเหตุ</td>
                <td>
                    <input type="text" ng-model="LIST_LCN.DALCN_EDIT_REQUEST.REMARK" />
                </td>
            </tr>

            <tr>
                <td>ชื่อผู้ลงนาม </td>
                <td>

                    <select class="form-control selectpicker" data-live-search="true" title="-- Please select --" ng-model="LIST_LCN.DALCN_EDIT_REQUEST.FK_STAFF_OFFER_IDA">
                        <option ng-repeat="x in LIST_STAFF_OFFER" value="{{x.IDA}}">{{x.STAFF_OFFER_NAME}}</option>
                    </select>
                </td>
            </tr>

            @*<tr>
                <td>ตำแหน่ง</td>
                <td>
                    <input type="text" ng-model="LIST_LCN.DALCN_EDIT_REQUEST.PHARMACEUTICAL_CHEMICALS" />
                </td>
            </tr>*@

            <tr>
                <td>วันที่เสนอลงนาม</td>
                <td>
                    <md-datepicker ng-model="LIST_LCN.DALCN_EDIT_REQUEST.CONSIDER_DATE" md-placeholder="Enter date"
                                   input-aria-describedby="datepicker-description"
                                   input-aria-labelledby="datepicker-header ">
                    </md-datepicker>
                </td>
            </tr>

            <tr>
                <td>วันที่คาดว่าจะอนุมัติ</td>
                <td>
                    <md-datepicker ng-model="LIST_LCN.DALCN_EDIT_REQUEST.appdate" md-placeholder="Enter date"
                                   input-aria-describedby="datepicker-description"
                                   input-aria-labelledby="datepicker-header ">
                    </md-datepicker>
                </td>
            </tr>

        </table>
    </div>
    <div class="panel-footer">

        <input type="button" class="btn btn-lg " ng-click="BTN_UPDATE_LCN_EDIT_CONS()" value="บันทึก" />

        <input type="button" class="btn btn-lg " ng-click="" value="ย้อนกลับ" />
    </div>
</div>