@Code
    ViewData("Title") = "FRM_DR_STAFF_CHECK_RQT"
End Code



<div>
    <div class="ic">
        <h2>ตรวจสอบคำขอขึ้นทะเบียนฯ</h2>
        <div>
            <table class="table" width="100%">
                <tr>
                    <td width="30%">ชื่อกระบวนงาน</td>
                    <td>
                        <select class="form-control"> 
                            <option></option>
                        </select>
                    </td>
                </tr>
                <tr>
                    <td>เลขตรวจคำขอ (A) (ถ้ามี)</td>
                    <td>
                        <input type="text" />
                    </td>
                    <td>
                        <input type="button" value="ดึงข้อมูล" />
                    </td>
                </tr>
                <tr>
                    <td>จำนวนเงิน</td>
                    <td>
                        <select>
                            <option></option>
                        </select>
                    </td>
                </tr>
                <tr>
                    <td>ส่วนลด (%)</td>
                    <td>
                        <input type="text" />
                    </td>
                </tr>
                <tr>
                    <td>จำนวนสุทธิ</td>
                    <td>
                        <input type="text" />
                    </td>
                </tr>
                <tr>
                    <td>ประเภททะเบียน</td>
                    <td>
                        <select>
                            <option></option>
                        </select>
                    </td>
                </tr>
                <tr>
                    <td>วงเล็บ(ถ้ามี)</td>
                    <td>
                        <select>
                            <option></option>
                        </select>
                    </td>
                </tr>
                <tr>
                    <td>การแสดงรหัสจังหวัดที่เลขใบอนุญาต</td>
                    <td><input type="radio" />แสดงรหัสจังหวัด<input type="radio" />แสดงเป็น จ.</td>
                </tr>
                <tr>
                    <td>เลขรับ</td>
                    <td>
                        <input type="text" />
                    </td>
                </tr>
                <tr>
                    <td>วันที่ตรวจคำขอ</td>
                    <td>
                        <input type="text" />
                    </td>
                </tr>
                <tr>
                    <td>จนท.ผู้รับผิดชอบคำขอ (กรอกเลขบัตรประชาชน)</td>
                    <td>
                        <input type="text" />
                    </td>
                    <td>
                        <input type="button" value="ค้นหา จนท." />
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

