@Code
    ViewData("Title") = "POPUP_ADD_DR_STAFF"
End Code

<div>
    <div class="ic">
        <div style="margin-left:10px">
            <h3>โปรดระบุเจ้าหน้าที่รับผิดชอบคำขอดำเนินการที่</h3>
        </div>
        <table width="100%" style="font-size:20px">
            <tr>
                <td width="30%" style="text-align:right">ชื่อผู้เชียวชาญ</td>
                <td width="45%"><input type="text" class="form-control inline" style="width:100%" /></td>
                <td width="1%"></td>
                <td width="10%"><button class="btn btn-lg" style="width:100%">ค้นหา</button></td>
                <td width="1%"></td>
                <td><button class="btn btn-lg" style="width:70%">เพิ่ม/ลบ</button></td>
            </tr>
        </table>
        <table width="100%" style="font-size:20px">
            <tr>
                <td width="30%" style="text-align:right">ระบุด้านที่ประเมิน</td>
                <td width="1%"></td>
                <td width="10%"><input type="radio" />&nbsp;&nbsp;ด้านคุณภาพ</td>
                <td width="10%"><input type="radio" />&nbsp;&nbsp;ด้านการผลิต</td>
                <td width="45%"><input type="text" class="form-control" /></td>
                <td></td>
            </tr>
        </table>
        <br />
        <br />
        <div style="text-align:center">
            <button class="btn btn-lg" style="background-color:#38A86B;color:white">บันทึก</button>
        </div>
    </div>
</div>