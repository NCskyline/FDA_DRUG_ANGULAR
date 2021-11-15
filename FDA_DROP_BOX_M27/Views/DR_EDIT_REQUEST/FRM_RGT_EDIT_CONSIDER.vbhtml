@Code
    ViewData("Title") = "FRM_RGT_EDIT_CONSIDER"
End Code

<div>
    <div class="ic">
        <h3><b>เสนอลงนาม</b></h3>
        <br />
        <table class="table" width="100%">
            <tr>
                <td>หมายเหตุ</td>
                <td>
                    <input type="text" class="form-control" />
                </td>
                <td></td>
            </tr>
            <tr>
                <td>ชื่อผู้ลงนาม</td>
                <td>
                    <select class="form-control">
                        <option></option>
                    </select>
                </td>
                <td></td>
            </tr>
            <tr>
                <td>ตำแหน่ง  </td>
                <td>
                    <input type="text" class="form-control" />
                </td>
                <td></td>
            </tr>
            <tr>
                <td>วันที่เสนอลงนาม</td>
                <td>
                    <md-datepicker ng-model="CONSIDER_DATE" md-placeholder="Enter date"
                                   input-aria-describedby="datepicker-description"
                                   input-aria-labelledby="datepicker-header ">
                    </md-datepicker>
                </td>
                <td></td>
            </tr>
            <tr>
                <td>วันที่คาดว่าจะอนุมัติ</td>
                <td>
                    <md-datepicker ng-model="APP_DATE" md-placeholder="Enter date"
                                   input-aria-describedby="datepicker-description"
                                   input-aria-labelledby="datepicker-header ">
                    </md-datepicker>
                </td>
                <td></td>
            </tr>
        </table>
        <div style="text-align:center">
            <button class="btn btn-lg">บันทึก</button>
            <button class="btn btn-lg">ย้อนกลับ</button>
        </div>
    </div>
</div>
