@Code
    ViewData("Title") = "TABEAN_YA_STAFF_APPROVE"
End Code

    <div>
        <div class="ic">
            <h2>อนุมัติคำขอ</h2>
            <div>
                <table class="table" width="100%">
                    <tr>
                        <td width="25%">เลขทะเบียน</td>
                        <td></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>ชื่อผู้ลงนาม</td>
                        <td>
                            <input type="text" />
                        </td>
                        <td>
                            <input type="button" value="ค้นหา จนท." />
                        </td>
                    </tr>
                    <tr>
                        <td>วันที่ขึ้นทะเบียน</td>
                        <td>
                            <md-datepicker ng-model="LIST_GMP.CER.EXP_DOCUMENT_DATE" md-placeholder="Enter date"
                                           input-aria-describedby="datepicker-description"
                                           input-aria-labelledby="datepicker-header ">
                            </md-datepicker>
                        </td>
                    </tr>
                </table>
            </div>
            <br />
            <div style="text-align:center">
                <button class="btn btn-lg">บันทึก</button>
                <button class="btn btn-lg">ปิดหน้าต่าง</button>
            </div>
        </div>
    </div>
