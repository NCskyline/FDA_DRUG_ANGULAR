@Code
    ViewData("Title") = "FRM_DR_TRANSFER_DL"
End Code

<div class="ic">
    <div align="center">
        <h3><b>ดาวน์โหลดคำขอขึ้นทะเบียน (Transfer)</b></h3>
    </div>
    <hr />
    <table class="table">
        <tr>
            <td width="20%">ประเภท :</td>
            <td>
                <select class="form-control">
                    <option>Referred</option> 
                    <option>Transferred</option>
                    <option>Copy</option>
                    <option>ปลด SMP</option>
                </select>
            </td>
            <td></td>
        </tr>
        <tr>
            <td>เลขทะเบียน :</td>
            <td>
                <input type="text" class="form-control" />
            </td>
            <td style="color:red">( ตัวอย่าง 1C 1/26 (N) )</td>
        </tr>
        <tr>
            <td></td>
            <td>
                <button class="form-control" style="width:50%;text-align:center">ค้นหาทะเบียน</button>
            </td>
            <td></td>
        </tr>
    </table>
</div>
