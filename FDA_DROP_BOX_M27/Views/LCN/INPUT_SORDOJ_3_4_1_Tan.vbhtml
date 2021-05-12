﻿<script type="text/javascript">

</script>

<style>
    .title1 {
        width: 150px;
        height: 170px;
        /*background-color: aqua;*/
        text-align: center;
        border: solid;
        float: right;
    }

    .title2 {
        width: 400px;
        height: 120px;
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


<h1 style="text-align:left;font-size:24px;">
    <strong>แบบ ส.ว.จ. ๓/๔-๑</strong>
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
    <strong>คำขอรับใบอนุญาต คำขอต่ออายุใบอนุญาต คำขอรับใบแทน</strong><br />
    <strong>ใบอนุญาตนำเข้าวัตถุออกฤทธิ์ในประเภท ๓ หรือประเภท ๔</strong>
</h2>
<table style="width:70%; font-size:20px;margin:auto;text-align:center" @*border="1"*@>
    <tr>
        <td>
            <strong>สำหรับผลิต</strong>
        </td>
        <td>
            <input type="radio" name="gender" checked /> <strong>วัตถุออกฤทธิ์ในประเภท ๓</strong>
        </td>
        <td>
            <input type="radio" name="gender" /> <strong>วัตถุออกฤทธิ์ในประเภท ๔</strong>
        </td>
    </tr>
    <tr>
        <td style="font-size:16px" colspan="3">
            <strong>(คำขอ ๑ ฉบับ ให้ยื่นขอได้เพียงหนึ่งประเภทเท่านั้น)</strong>
        </td>
    </tr>
</table>

<table style="width:100%; font-size:20px">
    <tr>
        <td style="width:20%">
            <input type="radio" name="gender" checked /> <strong>ขอรับใบอนุญาต</strong>
        </td>
    </tr>
    <tr>
        <td>
            <input type="radio" name="gender" /> <strong>ขอต่ออายุใบอนุญาตเลขที่</strong>
        </td>
        <td>
            text
        </td>
        <td style="width:10%">
            <strong>ประจำปี พ.ศ.</strong>
        </td>
        <td>
            text
        </td>
    </tr>
    <tr>
        <td>
            <input type="radio" name="gender" /> <strong>ขอรับใบแทนใบอนุญาต</strong>
        </td>
        <td>
            เนื่องจากใบอนุญาต
        </td>
        <td>
            <input class="checkbox" type="checkbox" /> <strong>สูญหาย</strong>
        </td>
        <td>
            <input class="checkbox" type="checkbox" /> <strong>ถูกทำลายหรือลบเลือนในสาระสำคัญ</strong>
        </td>
    </tr>
</table>
<br />

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

<h2 style="font-size:24px;">
    <strong>๑. ข้อมูลผู้ขอรับใบอนุญาต</strong>
</h2>
<table style="width:90%;margin-left:5%" @*border="1"*@>
    <tr>
        <td style="font-size:20px" width="40%">
            ข้าพเจ้า (ชื่อบุคคล/นิติบุคคล)
        </td>
        <td style="font-size:20px" colspan="6">
            text
        </td>
    </tr>
    <tr>
        <td style="font-size:20px">
            เลขประจำตัวประชาชน
        </td>

        <td style="font-size:20px" colspan="6">
            text
        </td>
    </tr>
    <tr>
        <td style="font-size:20px">
            หรือบัตรประจำตัวอื่นที่ทางราชการออกให้ คือ
        </td>
        <td style="font-size:20px;width:20%">
            text
        </td>
        <td style="font-size:20px;width:5%">
            เลขที่
        </td>
        <td style="font-size:20px ;width:15%;text-align:center">
            text
        </td>
        <td style="font-size:20px">
            (กรณีไม่ใช่ผู้มีสัญชาติไทย)
        </td>
    </tr>
    <tr>
        <td style="font-size:20px">
            หรือทะเบียนนิติบุคคล/บัตรประจำตัวผู้เสียภาษี เลขที่
        </td>
        <td style="font-size:20px" colspan="6">
            text
        </td>
    </tr>
    <tr>
        <td style="font-size:20px">
            เลขรหัสประจำบ้าน
        </td>
        <td style="font-size:20px" colspan="6">
            text
        </td>
    </tr>
    <tr>
        <td style="font-size:20px">
            อยู่เลขที่
        </td>
        <td style="font-size:20px" colspan="6">
            text
        </td>
    </tr>
    <tr>
        <td style="font-size:20px">
            โทรศัพท์/มือถือ
        </td>
        <td style="font-size:20px" colspan="6">
            text
        </td>
    </tr>
    <tr>
        <td style="font-size:20px">
            E-mail
        </td>
        <td style="font-size:20px" colspan="6">
            text
        </td>
    </tr>

</table>

<h2 style="font-size:24px;">
    <strong>๒. ข้อมูลผู้ได้รับมอบหมายหรือแต่งตั้งให้ดำำเนินกิจการเกี่ยวกับใบอนุญาต</strong>
</h2>
<table style="width:90%;margin-left:5%" @*border="1"*@>
    <tr>
        <td style="font-size:20px" width="40%">
            ข้าพเจ้า
        </td>
        <td style="font-size:20px" colspan="6">
            text
        </td>
    </tr>
    <tr>
        <td style="font-size:20px">
            เลขประจำตัวประชาชน
        </td>

        <td style="font-size:20px" colspan="6">
            text
        </td>
    </tr>
    <tr>
        <td style="font-size:20px">
            หรือบัตรประจำตัวอื่นที่ทางราชการออกให้ คือ
        </td>
        <td style="font-size:20px;width:20%">
            text
        </td>
        <td style="font-size:20px;width:5%">
            เลขที่
        </td>
        <td style="font-size:20px ;width:15%;text-align:center">
            text
        </td>
        <td style="font-size:20px">
            (กรณีไม่ใช่ผู้มีสัญชาติไทย)
        </td>
    </tr>
    <tr>
        <td style="font-size:20px">
            หรือทะเบียนนิติบุคคล/บัตรประจำตัวผู้เสียภาษี เลขที่
        </td>
        <td style="font-size:20px" colspan="6">
            text
        </td>
    </tr>
    <tr>
        <td style="font-size:20px">
            เลขรหัสประจำบ้าน
        </td>
        <td style="font-size:20px" colspan="6">
            text
        </td>
    </tr>
    <tr>
        <td style="font-size:20px">
            อยู่เลขที่
        </td>
        <td style="font-size:20px" colspan="6">
            text
        </td>
    </tr>
    <tr>
        <td style="font-size:20px">
            โทรศัพท์/มือถือ
        </td>
        <td style="font-size:20px" colspan="6">
            text
        </td>
    </tr>
    <tr>
        <td style="font-size:20px">
            E-mail
        </td>
        <td style="font-size:20px" colspan="6">
            text
        </td>
    </tr>

</table>

<br />

<table style="width:100%;font-size:20px" @*border="1"*@>
    <tr>
        <td colspan="4">
            <p><strong>๓. ข้อมูลสถานที่นำเข้า</strong></p>
        </td>
    </tr>
    <tr>
        <td>
            ณ สถานที่ชื่อ
        </td>
        <td>
            text
        </td>
        <td>
            เลขรหัสประจำบ้าน
        </td>
        <td>
            text
        </td>
    </tr>
    <tr>
        <td>
            ตั้งอยู่เลขที่
        <td colspan="4">
            text
        </td>
    </tr>
    <tr>
        <td>
            โทรศัพท์/มือถือ
        </td>
        <td colspan="4">
            text
        </td>
    </tr>
</table>

<table style="width:100%;font-size:20px" @*border="1"*@>
    <tr>
        <td style="font-size:20px;width:70%">
            โดยได้รับอนุญาตให้ผลิต/ขาย/นำเข้าวัตถุออกฤทธิ์ในประเภท ๓ หรือประเภท ๔ ตามใบอนุญาตเลขที่
        </td>
        <td style="font-size:20px">
            text
        </td>
    </tr>
</table>

<table style="width:100%;font-size:20px" @*border="1"*@>
    <tr>
        <td style="width:15%">
            โดยมีเภสัชกรชื่อ  1.
        </td>
        <td>
            text
        </td>
        <td style="width:30%">
            ใบอนุญาตประกอบวิชาชีพเภสัชกรรมเลขที่
        </td>
        <td>
            text
        </td>
    </tr>
</table>
<div style="font-size:20px">เป็นผู้ควบคุมตามมาตรา ๕๓ แห่งพระราชบัญญัติวัตถุที่ออกฤทธิ์ต่อจิตและประสาท พ.ศ. ๒๕๕๙</div>
<br />



<div style=";font-size:20px"><strong>๔. พร้อมกับคำขอนี้ข้าพเจ้าได้แนบเอกสารหรือหลักฐานต่างๆ มาด้วย คือ</strong></div>
<div style="margin-left:5%;font-size:20px"><strong>๔.๑ กรณีขอรับใบอนุญาต (กรณีรายใหม่)</strong></div>
<table style="width:90%;font-size:20px ;margin-left:10%" @*border="1"*@>
    <tr>
        <td>
            (๑) คำรับรองของผู้รับอนุญาตและเภสัชกรผู้ควบคุมกิจการ
        </td>
    </tr>
    <tr>
        <td>
            (๒) รูปถ่ายหน้าตรง ไม่สวมหมวกและแว่นตาสีเข้ม ของผู้ขอรับใบอนุญาตหรือผู้ได้รับมอบหมายหรือแต่งตั้งให้ดำเนินกิจการ
            เกี่ยวกับใบอนุญาต ขนาด ๑ นิ้ว จำนวน ๓ รูป ซึ่งถ่ายไว้ไม่เกิน ๖ เดือนก่อนวันยื่นคำขอ
        </td>
    </tr>
    <tr>
        <td>
            (๓) สำเนาใบอนุญาตประกอบวิชาชีพเภสัชกรรม
        </td>
    </tr>
    <tr>
        <td>
            (๔) หนังสือแต่งตั้งผู้ดำเนินกิจการ กรณีผู้ขอรับใบอนุญาตเป็นนิติบุคคล
        </td>
    </tr>
    <tr>
        <td>
            (๕) แผนที่แสดงที่ตั้งและแผนผังแสดงที่นำเข้าหรือเก็บซึ่งวัตถุออกฤทธิ์ในประเภท ๓ หรือประเภท ๔ ของสถานประกอบการ
        </td>
    </tr>
    <tr>
        <td>
            (๖) รูปถ่ายแสดงที่นำำเข้าหรือเก็บซึ่งวัตถุออกฤทธิ์ในประเภท ๓ หรือประเภท ๔ ของสถานประกอบการจำำนวน ๑ รูป
        </td>
    </tr>
</table>
<div style="margin-left:5%;font-size:20px"><strong>๔.๒ กรณีขอต่ออายุใบอนุญาต</strong></div>
<table style="width:90%;font-size:20px ;margin-left:10%" @*border="1"*@>
    <tr>
        <td>
            (๑) ใบอนุญาตฉบับเดิม
        </td>
    </tr>
    <tr>
        <td>
            (๒) รูปถ่ายหน้าตรง ไม่สวมหมวกและแว่นตาสีเข้ม ของผู้ขอรับใบอนุญาตหรือผู้ได้รับมอบหมายหรือแต่งตั้งให้ดำเนินกิจการ
            เกี่ยวกับใบอนุญาต ขนาด ๑ นิ้ว จำนวน ๓ รูป ซึ่งถ่ายไว้ไม่เกิน ๖ เดือนก่อนวันยื่นคำขอ
        </td>
    </tr>

</table>
<div style="margin-left:5%;font-size:20px"><strong>๔.๓ กรณีขอรับใบแทนใบอนุญาต</strong></div>
<table style="width:90%;font-size:20px ;margin-left:10%" @*border="1"*@>
    <tr>
        <td>
            (๑) ใบแจ้งความ กรณีใบอนุญาตสูญหาย
        </td>
    </tr>
    <tr>
        <td>
            (๒) ใบอนุญาต กรณีใบอนุญาตดังกล่าวถูกทำลายบางส่วนหรือลบเลือนในสาระสำคัญ
        </td>
    </tr>
    <tr>
        <td>
            (๓) รูปถ่ายหน้าตรง ไม่สวมหมวกและแว่นตาสีเข้ม ของผู้ขอรับใบอนุญาตหรือผู้ได้รับมอบหมายหรือแต่งตั้งให้ดำเนินกิจการเกี่ยวกับ
            ใบอนุญาต ขนาด ๑ นิ้ว จำนวน ๓ รูป ซึ่งถ่ายไว้ไม่เกิน ๖ เดือนก่อนวันยื่นคำขอ
        </td>
    </tr>

</table>
<div style="margin-left:5%;font-size:20px;text-align:center"><strong>ข้าพเจ้าขอรับรองว่า ข้อความและเอกสารหรือหลักฐานทั้งหมดที่ยื่นเพื่อประกอบคำขอรับใบอนุญาตเป็นความจริงทุกประการ</strong></div>
<br />
<br />

<table style="width:85%;font-size:20px ;margin-left:12.5%" @*border="1"*@>
    <tr>
        <td style="text-align:right">
            (ลายมือชื่อ)
        </td>
        <td style="text-align:center;width:40%">
            text
        </td>
        <td>
            ผู้ขอรับใบอนุญาต/ผู้ได้รับมอบหมายหรือแต่งตั้งให้ดำเนินกิจการ
        </td>
    </tr>
    <tr>
        <td style="text-align:right">
            (
        </td>
        <td style="text-align:center">
            text
        </td>
        <td style="text-align:left">
            )
        </td>
    </tr>

</table>
<br />
<br />

<div style="margin-left:5%;font-size:20px"> หมายเหตุ : (๑) ให้ขีดเลือกข้อความในช่อง ☐/〇 ให้ตรงตามที่ประสงค์จะดำเนินการ</div>
<table style="width:90%;font-size:20px ;margin-left:12.5%" @*border="1"*@>
    <tr>
        <td>
            (๒) รับรองสำเนาถูกต้องในเอกสารที่เป็นสำเนาทุกฉบับ
        </td>
    </tr>
    <tr>
        <td>
            (๓) กรณีเอกสารหรือหลักฐานที่ออกโดยสำนักงานคณะกรรมการอาหารและยา ผู้อนุญาตอาจไม่ขอเอกสารหรือหลักฐานดังกล่าวได้
        </td>
    </tr>

</table>

















