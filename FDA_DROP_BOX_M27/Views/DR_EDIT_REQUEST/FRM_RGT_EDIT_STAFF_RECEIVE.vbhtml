@Code
    ViewData("Title") = "FRM_RGT_EDIT_STAFF_RECEIVE"
End Code

<div>
    <div>
        <div class="ic">
            <h3><b>รับคำขอ</b></h3>
            <br />
            <table class="table" width="100%">
                <tr>
                    <td>กระบวนงาน</td>
                    <td>
                        <select class="form-control">
                            <option></option>
                        </select>
                    </td>
                    <td></td>
                </tr>
                <tr>
                    <td>เลขตรวจคำขอ (A) (ถ้ามี)</td>
                    <td>
                        <input type="text" class="form-control" />
                    </td>
                    <td>
                        <button class="btn btn-lg">ดึงข้อมูล</button>
                    </td>
                </tr>
                <tr>
                    <td>วันที่รับคำขอ</td>
                    <td>
                        <md-datepicker ng-model="LIST_GMP.CER.EXP_DOCUMENT_DATE" md-placeholder="Enter date"
                                       input-aria-describedby="datepicker-description"
                                       input-aria-labelledby="datepicker-header ">
                        </md-datepicker>
                    </td>
                    <td></td>
                </tr>
                <tr>
                    <td>จนท.ผู้รับคำขอ (กรอกเลขบัตรประชาชน)</td>
                    <td>
                        <input type="text" class="form-control" />
                    </td>
                    <td>
                        <button class="btn btn-lg" value="ค้นหา จนท.">ค้นหา จนท.</button>
                    </td>
                </tr>
            </table>
            <br />
            <br />
            <div style="text-align:center">
                <button class="btn btn-lg">บันทึก</button>
                <button class="btn btn-lg">ย้อนกลับ</button>
            </div>
        </div>
    </div>
</div>
