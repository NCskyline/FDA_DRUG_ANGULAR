﻿<script type="text/javascript">

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
</style>


<h1 style="text-align:right;font-size:24px;">
    <strong>เเบบ</strong>
</h1>
<br />
<div class="title1">
    <label style="font-size:16px;margin-top:25px">
        ที่ปิดรูปถ่าย<br />
        ผู้ขออนุญาติ<br />
        หรือ<br />
        ผู้ดำเนินกิจการ<br />
        ขนาด 3 x 4 ซม.<br />
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
    <strong>คำขออนุญาตนำเข้าหรือสั่งยาเเผนปัจจุบันเข้ามาในราชอาณาจักร</strong>
</h2>

<div style="text-align:center">
    <hr style="width:20%" />
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
<table style="width:100%;">
    <tr>
        <td style="text-align:center;font-size:20px">
            text
        </td>
    </tr>
    <tr>
        <td style="text-align:center;font-size:16px">
            (ชื่อผู้ขออนุญาต)
        </td>
    </tr>
</table>
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
        <td style="text-align:left;width:2000px">
            text
        </td>
    </tr>
    <tr>
        <td>
            โทรศัพท์
        </td>
        <td style="text-align:left;width:2000px">
            text
        </td>
    </tr>
</table>
<div style="font-size:20px">
    ขอรับใบอนุญาตนำหรือสั่งยาแผนปัจจุบันเข้ามาในราชอาณาจักร
</div>

<table style="font-size:20px;width:100%" @*border="1"*@>
    <tr>
        <td style="width:500px">
            โดยมีสถานที่นำหรือสั่งยาชื่อ
        </td>
        <td style="text-align:left;width:2000px">
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
            <input style="width:100%" />
        </td>
    </tr>
</table>
<div margin-bottom: 10px;></div>
<table style="font-size:20px;width:100%" @*border="1"*@>
    <tr>
        <td style="width:150px">
            โดยมีเภสัชกรชั้น
        </td>
        <td style="text-align:left" width="100">
            <input style="width:100%" />
        </td>
        <td style="text-align:center; width:80px">
            ชื่อ
        </td>
        <td style="text-align:left" width="70">
            <input style="width:100%" />
        </td>
        <td style="text-align:left">
            <input style="width:548px" />
        </td>
    </tr>
</table>
<table style="width:100%">
    <tr>
        <td style="font-size:20px;width:400px">
            เลขที่บัตรประชาชนใบอนุญาตประชาชน
        </td>
        <td>
            <input style="font-size:20px;width:50%" />
        </td>
    </tr>
    <tr>
        <td style="font-size:20px">
            ใบอนุญาตประกอบวิชาชีพเภสัชกรรมเลขที่
        </td>
        <td>
            <input style="font-size:20px;width:50%" />
        </td>
    </tr>
</table>
<hr />
<input type="button" style="font-size:20px;width:100px" value="เพิ่ม" />
<input type="button" style="font-size:20px;width:100px;margin-left:10px" value="ลบ" />

<div style="font-size:16px;text-align:center">(ถ้ามีมากกว่าหนึ่งคนให้แจ้งเพิ่มเติมไว้ท้ายคำขอนี้จนครบ)</div>
<br />
<center>
    <table style="font-size:20px" @*border="1"*@>
        <tr>
            <td style="text-align:left;">
                เป็นผู้มีหน้าที่ปฏิบัติการตามมาตรา 44 แห่งพระราชบัญญัติยา พ.ศ. 2510
            </td>
        </tr>
        <tr>
            <td style="text-align:right;">
                ข้าพเจ้าขอรับรองว่า ในระยะเวลาสองปีก่อนยื่นคำขอนี้ ข้าพเจ้าไม่เคยได้รับโทษจำคุกโดย
            </td>
        </tr>
        <tr>
            <td>
                คำพิพากษาถึงที่สุดหรือคำสั่งที่ชอบด้วยกฎหมายให้จำคุกในความผิดที่กฎหมายบัญญัติให้ถือเอาการกระทำ
            </td>
        </tr>
        <tr>
            <td>
                โดยทุจริตเป็นองค์ประกอบหรือในความผิดตามกฎหมายว่าด้วยยาเสพติดให้โทษกฎหมายว่าด้วยวัตถุที่ออก
            </td>
        </tr>
        <tr>
            <td>
                ฤทธิ์ต่อจิตและประสาทกฎหมายว่าด้วยการขายยาหรือพระราชบัญญัตินี้
            </td>
        </tr>
    </table>
</center>
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