@Code
    ViewData("Title") = "INPUT_YOR_3"
End Code

<div >
    <div class="ic" style="font-family:'Taviraj';width:100%">
        <div>
            <p style="text-align: right;">แบบ ย.๓</p>
            <p style="text-align: right;">FORM MA-3</p>
        </div>
        <table style="width:100%">
            <tr>
                <td style="width:35%"></td>
                <td style="width:35%"></td>
                <td style="width:5%;text-align:right">เลขที่:</td>
                <td style="width:25%;text-align:center;border-bottom:dotted;border-bottom-width:thin"></td>
            </tr>
        </table>
        <table style="width:100%">
            <tr>
                <td style="width:35%"></td>
                <td style="width:35%"></td>
                <td style="width:5%;text-align:right">วันที่:</td>
                <td style="width:25%;text-align:center;border-bottom:dotted;border-bottom-width:thin"></td>
            </tr>
        </table>
        <table style="width:100%">
            <tr>
                <td style="width:35%"></td>
                <td style="width:35%"></td>
                <td style="width:5%;text-align:right"> ลงชื่อ:</td>
                <td style="width:20%;text-align:center;border-bottom:dotted;border-bottom-width:thin"></td>
                <td style="width:10%">ผู้รับคำขอ</td>
            </tr>
        </table>
        <br />
        <h1 style="text-align:center">คำขอใบแทนใบสำคัญการขึ้นทะเบียนตำรับยา</h1>
        <hr style="width:30%;border-color:black;text-align:center" />
        <div>
            <p style="text-align:center;font-size:20px">
                ประเภท <span style="padding-left:2em"><input type="checkbox" checked />&nbsp;ยาแผนปัจจุบัน</span><span style="padding-left:2em"><input type="checkbox" />&nbsp;ยาแผนโบราณ</span>
            </p>
            <p style="text-align:center;font-size:20px">
                <span style="padding-left:2em"><input type="checkbox" />&nbsp;ผลิต</span><span style="padding-left:2em"><input type="checkbox" />&nbsp;แบ่งบรรจุ</span><span style="padding-left:2em"><input type="checkbox" checked />&nbsp;นำหรือสั่งเข้ามาในราชอาณาจักร</span>
            </p>
        </div>
        <br />
        <table width="100%" style="font-size:20px">
            <tr>
                <td width="30%">
                    <label>(๑) ขอรับใบแทนใบสำคัญการขึ้นทะเบียนตำรับยาชื่อ</label>
                </td>
                <td><input type="text" class="form-control inline" style="font-size:20px;width:100%" /></td>
            </tr>
            <tr>
                <td width="30%">
                    <label style="padding-left:1.5em">ใบสำคัญการขึ้นทะเบียนตำรับยาเลขที่</label>
                </td>
                <td><input type="text" class="form-control inline" style="font-size:20px;width:100%" /></td>
            </tr>
        </table>
        <table width="100%" style="font-size:20px">
            <tr>
                <td width="15%">(๒) ชื่อผู้รับอนุญาต</td>
                <td><input type="text" class="form-control inline" style="font-size:20px;width:100%" /></td>
                <td width="2%"></td>
                <td width="10%">ใบอนุญาตเลขที่</td>
                <td><input type="text" class="form-control inline" style="font-size:20px;width:100%" /></td>
            </tr>
        </table>
        <table width="100%" style="font-size:20px">
            <tr>
                <td width="15%">
                    <label style="padding-left:1.5em">ชื่อผู้ดำเนินกิจการ</label>
                </td>
                <td><input type="text" class="form-control inline" style="font-size:20px;width:100%" /></td>
            </tr>
        </table>
        <table width="100%" style="font-size:20px">
            <tr>
                <td width="30%">
                    <label>(๓) เหตุผลที่ขอใบแทนใบสำคัญการขึ้นทะเบียนตำรับยา</label>
                </td>
                <td><input type="text" class="form-control inline" style="font-size:20px;width:100%" /></td>
            </tr>
        </table>
        <br />
        <br />
        <div style="font-size:20px;margin-left:2em">ข้าพเจ้าได้แนบหลักฐานมาด้วยคือ</div>
        <div style="font-size:20px;margin-left:2em">(๑) กรณีที่ใบสำคัญการขึ้นทะเบียนตำรับยาสูยหาย ให้นำใบรับแจ้งความสถานีตำรวจท้องที่ที่ใบสำคัญการขึ้นทะเบียนตำรับยานั้นสูญหายมาด้วย</div>
        <div style="font-size:20px;margin-left:2em">(๒) กรณีที่ใบสำคัญการขึ้นทะเบียนตำรับยาถูกทำลายในสาระสำคัญให้แนบใบสำคัญการขึ้นทะเบียนตำรับยานั้นมาด้วย</div>
        <div style="font-size:20px;margin-left:2em">(๓) สำเนาใบอนุญาตผลิต หรือนำหรือสั่งเข้ามาในราชอาณาจักร</div>
        <br />
        <table width="50%" style="font-size:20px;float:right">
            <tr>
                <td width="15%">(ลายมือชื่อ)</td>
                <td width="50%" style="border-bottom:dotted;border-bottom-width:thin"></td>
                <td>ผู้รับอนุญาต</td>
            </tr>
            <tr>
                <td width="15%">(</td>
                <td width="50%" style="border-bottom:dotted;border-bottom-width:thin"></td>
                <td>) (ตัวบรรจง)</td>
            </tr>
        </table>
        <br />
        <br />
        <br />
        <br />
        <div style="text-align:center">
            <button class="btn btn-lg" style="background-color:#38A86B;color:white">บันทึก</button>
            <button class="btn btn-lg" style="background-color:#FFD700">ย้อนกับ</button>
        </div>
        <br />
    </div>
</div>