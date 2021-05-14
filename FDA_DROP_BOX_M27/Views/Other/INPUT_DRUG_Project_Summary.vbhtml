
<script type="text/javascript">

</script>

<style>
    .title1 {
        width: 500px;
        height: 170px;
        /*background-color: aqua;*/
        text-align: center;
        border: solid;
        float: right;
    }

    .title2 {
        width: 400px;
        height: 130px;
        /*background-color:antiquewhite;*/
        text-align: center;
        border: solid;
        float: left;
    }

    .checkbox {
        width: 20px;
        height: 20px;
        margin-top: 1%;
        margin-right: 2%
    }

    .hr {
        width: 95%;
        height: 10px;
        background-color: black;
    }
</style>

<h2 style="text-align:center;font-size:24px;">
    สรุปย่อโครงการวิจัย (ภาษาไทย)
</h2>
<div style="text-align:right;font-size:20px">
    <strong>สำหรับเจ้าหน้าที่</strong>
</div>
<table style="width:100%; font-size:20px">
    <tr>
        <td style="text-align:right;width:90%">
            TFDA CT No
        </td>
        <td style="width:40%">
            <input style="text-align:center; width:100%">
        </td>
    </tr>
    <tr>
        <td style="text-align:right;width:100px">
            วันที่
        </td>
        <td>
            <input style="text-align:center; width:100%">
        </td>
    </tr>

</table>
<br />
<div style="font-size:20px">
    ประเภท
</div>
<table style="font-size:20px">
    <tr>
        <td>
            <input type="radio" name="gender" checked /> ยาแผนปัจจุบัน
        </td>
        <td>
            <input type="radio" name="gender" checked /> ยาแผนโบราณ
        </td>
    </tr>
</table>

<table style="font-size:20px;width:100%" @*border="1"*@>
    <tr>
        <td style="width:55%">
            1. ชื่อโครงการวิจัยภาษาไทย
        </td>
        <td>
            <input style="font-size:20px;width:100%" />
        </td>
    </tr>
    <tr>
        <td>
            2. ชื่อโครงการวิจัยภาษาอังกฤษ
        </td>
        <td>
            <input style="font-size:20px;width:100%" />
    </tr>
    <tr>
        <td>
            3. รหัสโครงการ และ ชื่อเรียกอื่น ได้แก่ รหัสที่ตั้ง โดยผู้ให้ทุนวิจัย ชื่อย่อ IND no. EudraCT no.
        </td>
        <td>
            <input style="font-size:20px;width:100%" />
    </tr>
</table>

<table style="font-size:20px;width:60%">
    <tr>
        <td style="width:50%">
            4. ประเภทของโครงการวิจัย ระยะของการวิจัย:
        </td>
        <td>
            <input type="radio" name="gender" checked /> 1
        </td>
        <td>
            <input type="radio" name="gender" checked /> 2
        </td>
        <td>
            <input type="radio" name="gender" checked /> 3
        </td>
        <td>
            <input type="radio" name="gender" checked /> 4
        </td>
        <td>
            <input type="radio" name="gender" checked /> BE
        </td>
    </tr>
</table>

<table style="font-size:20px;width:60%" @*border="1"*@>
    <tr>
        <td style="width:50%">
            5. ประเทศที่ทำการวิจัย
        </td>
        <td>
            <input type="radio" name="gender" checked /> เฉพาะในประเทศไทย
        </td>
        <td>
            <input type="radio" name="gender" checked /> วิจัยในหลายประเทศ
        </td>
    </tr>
</table>

<table style="font-size:20px;width:100%" @*border="1"*@>
    <tr>
        <td style="width:30%">
            6. จำนวนสถาบันที่ร่วมวิจัยทั้งหมดทั่วโลก
        </td>
        <td>
            <input style="width:100%" />
        </td>
        <td style="width:5%;text-align:center">
            แห่ง
        </td>
    </tr>
    <tr>
        <td>
            7. จำนวนสถาบันที่ร่วมวิจัยในประเทศไทย
        </td>
        <td>
            <input style="width:100%" />
        </td>
        <td style="width:5%;text-align:center">
            แห่ง
        </td>
    </tr>
    <tr>
        <td>
            8. ข้อมูลของแต่ละสถานที่วิจัยในประเทศไทย
        </td>
    </tr>
</table>
<br />
<table style="font-size:20px;width:100%" border="1">
    <tr>
        <td style="width:5%">
        </td>
        <td style="text-align:center">
            ชื่อสถานที่วิจัย
        </td>
        <td style="text-align:center">
            จำนวนอาสาสมัครแต่ละสถานที่วิจัย
        </td>
        <td style="text-align:center">
            ชื่อนักวิจัย ที่อยู่ เบอร์โทรติดต่อ อีเมล์
        </td>
        <td style="width:5%">
        </td>
        <td style="width:5%">
        </td>
    </tr>
    <tr>
        <td style="text-align:center;width:5%">
            1
        </td>
        <td style="text-align:center">
            <input style="width:100%" />
        </td>
        <td style="text-align:center">
            <input style="width:100%" />
        </td>
        <td style="text-align:center">
            <input style="width:100%" />
        </td>
        <td style="width:5%">
            <input type="button" value="+" style="width:100%" />
        </td>
        <td style="width:5%">
            <input type="button" value="-" style="width:100%" />
        </td>
    </tr>
    <tr>
        <td style="text-align:center;width:5%">
            .
        </td>
        <td style="text-align:center">
        </td>
        <td style="text-align:center">
        </td>
        <td style="text-align:center">
        </td>
        <td style="width:5%">
        </td>
        <td style="width:5%">
        </td>
    </tr>


</table>
<br />
<table style="font-size:20px;width:100%" @*border="1"*@>
    <tr>
        <td style="width:55%">
            9. ผู้ให้ทุนวิจัยในประเทศไทย (Thai Sponsor)(ชื่อหน่วยงาน ที่อยู่ เบอร์โทร อีเมล์)
        </td>
        <td>
            <input style="width:100%" />
        </td>
    </tr>
    <tr>
        <td>
            10. ผู้ให้ทุนวิจัยในต่างประเทศ (Foreign Sponsor) (ชื่อหน่วยงาน ที่อยู่ เบอร์โทร อีเมล์)
        </td>
        <td>
            <input style="width:100%" />
        </td>
    </tr>
    <tr>
        <td>
            11. ผู้กำกับดูแลการวิจัย (Monitor) (ชื่อ ตำำแหน่ง หน่วยงาน ที่อยู่ เบอร์โทร อีเมล์)
        </td>
        <td>
            <input style="width:100%" />
        </td>
    </tr>
    <tr>
        <td colspan="2">
            12. รายการยาที่ใช้โครงการ (ให้ระบุยาทุกตัวที่ใช้ในโครงการ รวมทั้ง ยาวิจัย ยาเปรียบเทียบ/ยาหลอก และยาที่ใช้ร่วม)
        </td>
    </tr>
</table> 
<input type="button" value="+" style="width:5%"/>
<input type="button" value="-" style="width:5%"/>
<div style="font-size:20px">1</div>
<table style="font-size:20px;width:30%">
    <tr>
        <td>
            <input type="radio" name="gender" checked /> ยาวิจัย
        </td>
        <td>
            <input type="radio" name="gender" checked /> ยาเปรียบเทียบ 
        </td>
        <td>
            <input type="radio" name="gender" checked />ยาที่ใช้ร่วม
        </td>
    </tr>
</table>

<table style="font-size:20px;width:100%" @*border="1"*@>
    <tr>
        <td style="width:30%">
            ชื่อสามัญ
        </td>
        <td colspan="3">
            <input style="width:100%" />
        </td>
    </tr>
    <tr>
        <td>
            ชื่อการค้า
        </td>
        <td colspan="3">
            <input style="width:100%" />
        </td>
    </tr>
    <tr>
        <td>
            ชื่อ อื่น
        </td>
        <td colspan="3">
            <input style="width:100%" />
        </td>
    </tr>
    <tr>
        <td>
            ขนาดยาที่ให้ และ Washout Period(ถ้ามี)
        </td>
        <td colspan="3">
            <input style="width:100%" />
        </td>
    </tr>
    <tr>
        <td>
            รูปแบบยา
        </td>
        <td colspan="3">
            <input style="width:100%" />
        </td>
    </tr>
    <tr>
        <td>
            ความแรง
        </td>
        <td>
            <input style="width:100%" />
        </td>
        <td style="width:5%">
            <select>
                <option>
                    1
                </option>
            </select>
        </td>
    </tr>
    <tr>
        <td>
            ขนาดบรรจุ
        </td>
        <td>
            <input style="width:100%" />
        </td>
        <td style="width:5%">
            <select>
                <option>
                    1
                </option>
            </select>
        </td>
    </tr>
    <tr>
        <td>
            จำนวนนำเข้าทั้งโครงการ
        </td>
        <td>
            <input style="width:100%" />
        </td>
        <td style="width:5%">
            <select>
                <option>
                    1
                </option>
            </select>
        </td>
    </tr>
</table>
<br />
<table style="font-size:20px;width:100%">
    <tr>
        <td style="width:30%">
            13. ใช้ยาหลอกหรือไม่
        </td>
        <td style="width:10%">
            <input type="radio" name="gender"/>ไม่
        </td>
        <td>
            <input type="radio" name="gender" />ไม่ใช้
        </td>
    </tr>
    <tr>
        <td style="width:30%">
            14. วันที่เริ่มการวิจัยในประเทศไทย (โดยประมาณ)
        </td>
        <td colspan="3">
            <input style="width:100%" />
        </td>
    </tr>
    <tr>
        <td>
            15. วันที่สิ้นสุดการวิจัยในประเทศไทย (โดยประมาณ)
        </td>
        <td colspan="3">
            <input style="width:100%" />
        </td>
    </tr>
</table>














