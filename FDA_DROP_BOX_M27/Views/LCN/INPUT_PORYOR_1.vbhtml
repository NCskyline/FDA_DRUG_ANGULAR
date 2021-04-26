<script type="text/javascript">

</script>

<style>
    .title1 {
        width: 150px;
        height: 170px;
        /*background-color: aqua;*/
        text-align: center;
        border: solid;
        float: left;
    }

    .title2 {
        width: 400px;
        height: 120px;
        /*background-color:antiquewhite;*/
        text-align: center;
        border: solid;
        float: right;
    }

    .checkbox {
        width: 20px;
        height: 20px;
        margin-left: 45%;
        margin-top: 5%;
    }
</style>


<h1 style="text-align:right;font-size:24px;">
    <strong>แบบ ผ.ย.๑</strong>
</h1>
<br />

<div class="title1">
    <label style="font-size:16px;margin-top:25px">
        ที่ปิดรูปถ่าย<br />
        ผู้ขออนุญาติ<br />
        หรือ<br />
        ผู้ดำเนินกิจการ<br />
        ขนาด ๓ x ๔ ซม.<br />
    </label>
</div>

<div class="title2">
    <table style="font-size:20px;width:95%;margin-top:10px;margin-left:10px" @*border="1"*@>
        <tr>
            <td style="text-align:left;width:20%">
                เลขรับที่
            </td>

            <td colspan="3">
                text
            </td>
        </tr>
        <tr>
            <td style="text-align:left">
                วันที่
            </td>

            <td colspan="3">
                text
            </td>
        </tr>
        <tr>
            <td style="text-align:left">
                ลงชื่่อ

            </td>

            <td>
                text
            </td>
            <td style="text-align:right;width:25%">
                ผู้รับคำขอ
            </td>
        </tr>
    </table>
</div>
<div style="clear:both"></div>
<br />
<br />

<h2 style="text-align:center;font-size:24px;">
    <strong>คำขออนุญาตผลิตยาแผนปัจจุบัน</strong>
</h2>



<div style="text-align:center">
    <hr style=" border-top:2px dotted ;width:17%" />
</div>

<table style="width:100%; font-size:20px">
    <tr>
        <td style="text-align:right;width:90%">
            เขียนที่
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
            <md-datepicker ng-model="datas.MFD_DATE" md-placeholder="Enter date"
                           input-aria-describedby="datepicker-description"
                           input-aria-labelledby="datepicker-header ">
            </md-datepicker>
        </td>
    </tr>

</table>
<br />
<table style="width:100%;" @*border="1"*@>
    <tr>
        <td style="font-size:20px;" width="200px">
            ข้าพเจ้า
        </td>
        <td style="text-align:left; font-size:20px">
            text
        </td>
    </tr>
</table>

<div style="text-align:center;font-size:16px">
    (ชื่อผู้ขออนุญาต)
</div>
<br />

<table style=" font-size:20px;width:100%" @*border="1"*@ ;>
    <tr>
        <td style="width:600px;">
            ซึ่งมีผู้ดำเนินกิจการ ชื่อ
        </td>
        <td style="text-align:center;width:2000px">
            text
        </td>
        <td>
            อายุ
        </td>
        <td>
            <input style="width:70px">
        </td>
        <td>
            ปี
        </td>
        <td>
            สัญชาติ
        </td>
        <td>
            <input style="width:100px" />
        </td>

    </tr>
</table>

<table style="font-size:20px;width:100%" @*border="1"*@>
    <tr>
        <td style="width:200px">
            อยู่เลขที่
        </td>
        <td style="text-align:left" colspan="3">
            text
        </td>

    </tr>
    <tr>
        <td>
            โทรศัพท์
        </td>
        <td style="text-align:left">
            text
        </td>
        <td style="text-align:left">
            ขอรับใบอนุญาต
        </td>
    </tr>
</table>
<div style="font-size:20px">
    ขอรับใบอนุญาตนำหรือสั่งยาแผนปัจจุบันเข้ามาในราชอาณาจักร
</div>

<table style="font-size:20px;width:100%" @*border="1"*@>
    <tr>
        <td style="text-align:left;width:700px">
            ผลิตยาแผนปัจจุบันโดยมีสถานที่ผลิตยาชื่อ
        </td>
        <td style="text-align:left;width:2000px">
            text
        </td>
    </tr>
    <tr>
        <td style="width:200px">
            อยู่เลขที่
        </td>
        <td style="text-align:left" colspan="3">
            text
        </td>
    </tr>
</table>

<table style="font-size:20px;width:100%">
    <tr>
        <td style="width:155px">
            โทรศัพท์
        </td>
        <td style="text-align:left" width="500">
            text
        </td>
        <td style="width:100px">
            เวลาทำการ
        </td>
        <td style="text-align:left">
            <input style="width:50%" />
        </td>
    </tr>
</table>
<br />
<div style="font-size:20px;margin-left:5%">สำหรับผลิตยาแผนปัจจุบันในหมวดยาต่อไปนี้</div>

<div>
    <table style=" width:60% ;font-size:20px;margin:auto" @*border="1"*@>
        <tr style="text-align:center">
            <th style="width:60%">
                หมวดยา
            </th>
            <th>
                ผลิต
            </th>
            <th>
                บรรจุ
            </th>
        </tr>
        <tr>
            <td>
                ยาปราศจากเชื้อ
            </td>
            <td>
                <input class="checkbox" type="checkbox" />
            </td>
            <td>
                <input class="checkbox" type="checkbox" />
            </td>
        </tr>
        <tr>
            <td>
                ยาที่ไม่ใช่ยาปราศจากเชื้อ
            </td>
            <td>
                <input class="checkbox" type="checkbox" />
            </td>
            <td>
                <input class="checkbox" type="checkbox" />
            </td>
        </tr>
        <tr>
            <td>
                ยาชีววัตถุ
            </td>
            <td>
                <input class="checkbox" type="checkbox" />
            </td>
            <td>
                <input class="checkbox" type="checkbox" />
            </td>
        </tr>
        <tr>
            <td>
                เภสัชเคมีภัณฑ์
            </td>
            <td>
                <input class="checkbox" type="checkbox" />
            </td>
            <td>
                <input class="checkbox" type="checkbox" />
            </td>
        </tr>
        <tr>
            <td>
                เภสัชชีววัตถุ
            </td>
            <td>
                <input class="checkbox" type="checkbox" />
            </td>
            <td>
                <input class="checkbox" type="checkbox" />
            </td>
        </tr>
        <tr>
            <td>
                เภสัชภัณฑ์รังสี
            </td>

            <td>
                <input class="checkbox" type="checkbox" />
            </td>
            <td>
                <input class="checkbox" type="checkbox" />
            </td>
        </tr>
        <tr>
            <td>
                ยาเตรียมแอโรโซลสำหรับสูดดมแบบกำหนดขนาดใช้
            </td>
            <td>
                <input class="checkbox" type="checkbox" />
            </td>
            <td>
                <input class="checkbox" type="checkbox" />
            </td>
        </tr>
        <tr>
            <td>
                ผลิตภัณฑ์ยาสัตว์ที่ไม่ใช่ยากระตุ้นภูมิคุ้มกัน
            </td>
            <td>
                <input class="checkbox" type="checkbox" />
            </td>
            <td>
                <input class="checkbox" type="checkbox" />
            </td>
        </tr>
        <tr>
            <td>
                ยาสกัด
            </td>
            <td>
                <input class="checkbox" type="checkbox" />
            </td>
            <td>
                <input class="checkbox" type="checkbox" />
            </td>
        </tr>
        <tr>
            <td>
                ยาอื่นๆ
            </td>
            <td>
                <input class="checkbox" type="checkbox" />
            </td>
            <td>
                <input class="checkbox" type="checkbox" />
            </td>
        </tr>
    </table>
</div>
<br />
<div style="font-size:20px">(ทั้งนี้ ให้ระบุรายละเอียดรายการหมวดยาที่ขออนุญาตผลิดในเอกสารแนบ ๑)</div>
<br />
<div style="font-size:20px;margin-left:10%">
    โดยมีเภสัชกรชั้นหนึ่ง ตามรายการชื่อผู้มีหน้าที่ปฏิบัติการที่แนบท้าย (เอกสารแนบ ๒) เป็นผู้มีหน้าที่ปฏิบัติการ
    
</div>
<div style="font-size:20px">
    ตามมาตรา ๓๘ แห่งพระราชบัญญัติยา พ.ศ.๒๕๑๐
</div>
<br />




<table style="width:50%">
    <tr>
        <td style="font-size:20px">
            ชื่อสถานที่เก็บ ( 1 ) :
        </td>
        <td style="font-size:20px">
            <input style="width:100%" />
        </td>
    </tr>
    <tr style="font-size:20px">
        <td>
            อยู่เลขที่
        </td>
        <td>
            <input style="width:100%" />
        </td>
    </tr>
    <tr style="font-size:20px">
        <td>
            โทรศัพท์
        </td>
        <td>
            <input style="width:100%" />
        </td>
    </tr>
    <tr style="font-size:20px">
        <td>
            โทรศัพท์มือถือ
        </td>
        <td>
            <input style="width:100%" />
        </td>
    </tr>
</table>
<br />
<input type="button" style="font-size:20px;width:100px" value="เพิ่ม" />
<input type="button" style="font-size:20px;width:100px;margin-left:10px" value="ลบ" />
