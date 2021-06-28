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
    <strong>แบบ ผ.ว.จ. ๓/๔-๑</strong>
</h1>
<br />
<div class="title1">
    <label style="font-size:16px;margin-top:25px">
        ที่ปิดรูปถ่าย<br />
        ผู้ขออนุญาติ<br />
        หรือ<br />
        ผู้ดำเนินกิจการ<br />
        ขนาด ๓ นิ้ว<br />
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
    <strong>ใบอนุญาตผลิตวัตถุออกฤทธิ์ในประเภท ๓ หรือประเภท ๔</strong>
</h2>
@*process =127,128 *@
<table style="width:70%; font-size:20px;margin:auto;text-align:center" @*border="1"*@>
    <tr>
        <td>
            <strong>สำหรับผลิต</strong>
        </td>
        <td>
            <input type="radio" name="gender" ng-model="LIST_LCN.dalcn.CHK_SELL_TYPE" id="rdl_CHK_SELL_TYPE" /> <strong>วัตถุออกฤทธิ์ในประเภท ๓</strong>
        </td>
        <td>
            <input type="radio" name="gender" ng-model="LIST_LCN.dalcn.CHK_SELL_TYPE" id="rdl_CHK_SELL_TYPE" /> <strong>วัตถุออกฤทธิ์ในประเภท ๔</strong>
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
            <input class="form-control inline" ng-model="LIST_LCN.dalcn.WRITE_AT" style="font-family:'TH SarabunPSK';font-size:20px;" type="text" />
        </td>
    </tr>
    <tr>
        <td style="text-align:right;width:100px">
            วันที่
        </td>
        <td>
            <md-datepicker ng-model="LIST_LCN.dalcn.WRITE_DATE" md-placeholder="Enter date"
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
<table style="width:90%" @*border="1"*@>
    <tr>
        <td style="font-size:20px" width="40%">
            ข้าพเจ้า (ชื่อบุคคล/นิติบุคคล)
        </td>
        <td style="font-size:20px" colspan="6">
            <label>{{LIST_LCN.thanm}}</label>
        </td>
    </tr>
    <tr>
        <td style="font-size:20px">
            เลขประจำตัวประชาชน
        </td>

        <td style="font-size:20px" colspan="6">
            <label>{{LIST_LCN.CITIZEN_AUTHORIZE}}</label>
        </td>
    </tr>
    <tr>
        <td style="font-size:20px">
            หรือบัตรประจำตัวอื่นที่ทางราชการออกให้ คือ
        </td>
        <td style="font-size:20px;width:20%"></td>
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
            <label>{{LIST_LCN.identify}}</label>
        </td>
    </tr>
    <tr>
        <td style="font-size:20px">
            เลขรหัสประจำบ้าน
        </td>
        <td style="font-size:20px" colspan="6">
            <label>{{LIST_LCN.HOUSENO}}</label>
        </td>
    </tr>
    <tr>
        <td style="font-size:20px">
            อยู่เลขที่
        </td>
        <td style="font-size:20px" colspan="6">
            <label>{{LIST_LCN.fulladdr2}}</label>
        </td>
    </tr>
    <tr>
        <td style="font-size:20px">
            โทรศัพท์/มือถือ
        </td>
        <td style="font-size:20px" colspan="6">
            <label>{{LIST_LCN.tel}}</label>
        </td>
    </tr>
    <tr>
        <td style="font-size:20px">
            E-mail
        </td>
        <td style="font-size:20px" colspan="6">
            <label>{{LIST_LCN.Email}}</label>
        </td>
    </tr>
</table>

<h2 style="font-size:24px;">
    <strong>๒. ข้อมูลผู้ได้รับมอบหมายหรือแต่งตั้งให้ดำเนินกิจการเกี่ยวกับใบอนุญาต</strong>
</h2>
<table style="width:90%" @*border="1"*@>
    <tr>
        <td style="font-size:20px" width="40%">
            ข้าพเจ้า
        </td>
        <td style="font-size:20px" colspan="6">
            <label>{{LIST_LCN.BSN_THAIFULLNAME}}</label>
        </td>
    </tr>
    <tr>
        <td style="font-size:20px">
            เลขประจำตัวประชาชน
        </td>

        <td style="font-size:20px" colspan="6">
            <label>{{LIST_LCN.BSN_IDENTIFY}}</label>
        </td>
    </tr>
    <tr>
        <td style="font-size:20px">
            หรือบัตรประจำตัวอื่นที่ทางราชการออกให้ คือ
        </td>
        <td style="font-size:20px;width:20%">
            <label>{{LIST_LCN.BSN_THAIFULLNAME}}</label>
        </td>
        <td style="font-size:20px;width:5%">
            เลขที่
        </td>
        <td style="font-size:20px ;width:15%;text-align:center">
            <label>{{LIST_LCN.BSN_THAIFULLNAME}}</label>
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
            <label>{{LIST_LCN.BSN_IDENTIFY}}</label>
        </td>
    </tr>
    <tr>
        <td style="font-size:20px">
            เลขรหัสประจำบ้าน
        </td>
        <td style="font-size:20px" colspan="6">
            <label>{{LIST_LCN.BSN_HOUSENO}}</label>
        </td>
    </tr>
    <tr>
        <td style="font-size:20px">
            อยู่เลขที่
        </td>
        <td style="font-size:20px" colspan="6">
            <label>{{LIST_LCN.fulladdr2}}</label>
        </td>
    </tr>
    <tr>
        <td style="font-size:20px">
            โทรศัพท์/มือถือ
        </td>
        <td style="font-size:20px" colspan="6">
            <label>{{LIST_LCN.BSN_TEL}}</label>
        </td>
    </tr>
    <tr>
        <td style="font-size:20px">
            E-mail
        </td>
        <td style="font-size:20px" colspan="6">
            <label>{{LIST_LCN.dalcn.Email}}</label>
        </td>
    </tr>
    <tr>
        <td style="font-size:20px" colspan="2">
            โดยได้รับอนุญาตนำสั่งยาแผนปัจจุบันเข้ามาในราชอาณาจักร เลขที่
        </td>
        <td style="font-size:20px" colspan="2">
            <label>{{LIST_LCN.HEAD_LCNNO_NCT}}</label>
        </td>
        <td style="font-size:20px">
            ตามกฎหมายว่าด้วยยา
        </td>
    </tr>
</table>

<div style="font-size:20px"><strong>๓. ข้อมูลสถานที่ผลิต</strong></div>
<table style="width:100%;font-size:20px" @*border="1"*@>
    <tr>
        <td>
            ณ สถานที่ชื่อ
        </td>
        <td>
            <label>{{LIST_LCN.thanameplace}}</label>
        </td>
        <td>
            เลขรหัสประจำบ้าน
        </td>
        <td>
            <label>{{LIST_LCN.HOUSENO}}</label>
        </td>
    </tr>
    <tr>
        <td>
            ตั้งอยู่เลขที่
        </td>
        <td colspan="3">
            <label>{{LIST_LCN.fulladdr2}}</label>
        </td>
    </tr>
    <tr>
        <td>
            โทรศัพท์/มือถือ
        </td>
        <td colspan="3">
            <label>{{LIST_LCN.tel}}</label>
        </td>
    </tr>
</table>

<table style="width:100%;font-size:20px" @*border="1"*@>
    <tr>
        <td style="width:25%">
            มีความประสงค์ขอรับอนุญาตผลิตวัตถุออกฤทธิ์ในหมวด
        </td>
        <td colspan="3">
            <input class="form-control inline" ng-model="LIST_LCN.dalcn.CATEGORY_DRUG" style="font-family:'TH SarabunPSK';font-size:20px;" type="text" />
        </td>
    </tr>
    <tr>
        <td>
            โดยได้รับอนุญาตให้ผลิตยาแผนปัจจุบันเลขที่
        </td>
        <td>
            <label>{{LIST_LCN.HEAD_LCNNO_NCT}}</label>
        </td>
        <td style="width:25%">
            ตามกฎหมายว่าด้วยยา ในหมวดที่ตรงกับคำขออนุญาต
        </td>
    </tr>
    <tr>
        <td colspan="3">
            ผลิตวัตถุออกฤทธิ์ตามคำขอนี้
        </td>
    </tr>
</table>


<table style="width:100%;font-size:20px" @*border="1"*@>
    <tr>
        <td>
            โดยมีเภสัชกรชื่อ  1.
        </td>
        <td>
            <input style="width:100%" />
        </td>
        <td style="width:30%;text-align:center">
            ใบอนุญาตประกอบวิชาชีพเภสัชกรรมเลขที่
        </td>
        <td>
            <input style="width:100%" />
        </td>
    </tr>
</table>
<input type="button" style="font-size:20px;width:100px" value="เพิ่ม" />
<input type="button" style="font-size:20px;width:100px;margin-left:10px" value="ลบ" />
<div style="font-size:20px">เป็นผู้ควบคุมตามมาตรา ๕๓ แห่งพระราชบัญญัติวัตถุที่ออกฤทธิ์ต่อจิตและประสาท พ.ศ. ๒๕๕๙</div>
<br />
<table style="width:100%;font-size:20px" @*border="1"*@>
    <tr>
        <td colspan="7">
            <strong>
                ๔. ข้อมูลสถานที่เก็บ (กรณีเป็นสถานที่คนละแห่งกับสถานที่ตาม ๓)
            </strong>
        </td>
    </tr>
    <tr>
        <td style="width:17%">
            ณ สถานที่ชื่อ
        </td>
        <td colspan="3">
            <select style="width:100%">
                <option>
                    1
                </option>
            </select>
        </td>
        <td style="width:15%;text-align:center">
            เลขรหัสประจำบ้าน
        </td>
        <td style="width:30%">
            text
        </td>
    </tr>
    <tr>
        <td>
            ตั้งอยู่เลขที่
        <td colspan="7">
            text
        </td>
    </tr>
    <tr>
        <td>
            โทรศัพท์ / มือถือ
        </td>
        <td colspan="7">
            text
        </td>
    </tr>

</table>
<input type="button" style="font-size:20px;width:100px" value="เพิ่ม" />
<input type="button" style="font-size:20px;width:100px;margin-left:10px" value="ลบ" />
<br />
<br />

<div style=";font-size:20px"><strong>๕. พร้อมกับคำขอนี้ข้าพเจ้าได้แนบเอกสารหรือหลักฐานต่างๆ มาด้วย คือ</strong></div>
<div style="margin-left:5%;font-size:20px"><strong>๕.๑ <u>กรณีขอรับใบอนุญาต (กรณีรายใหม่)</u></strong></div>
<table style="width:90%;font-size:20px ;margin-left:10%" @*border="1"*@>
    <tr>
        <td>
            (๑) สำเนาใบอนุญาตขายยาแผนปัจจุบันตามกฎหมายว่าด้วยยา
        </td>
    </tr>
    <tr>
        <td>
            (๒) คำรับรองของผู้รับอนุญาตและเภสัชกรผู้ควบคุมกิจการ
        </td>
    </tr>
    <tr>
        <td>
            (๓) รูปถ่ายหน้าตรง ไม่สวมหมวกและแว่นตาสีเข้ม ของผู้ขอรับใบอนุญาตหรือผู้ได้รับมอบหมายหรือแต่งตั้ง
        </td>
    </tr>
    <tr>
        <td>
            ให้ดำเนินกิจการเกี่ยวกับใบอนุญาต ขนาด ๑ นิ้ว จำนวน ๓ รูป ซึ่งถ่ายไว้ไม่เกิน ๖ เดือนก่อนวันยื่นคำขอ
        </td>
    </tr>
    <tr>
        <td>
            (๔) สำเนาใบอนุญาตประกอบวิชาชีพเภสัชกรรม
        </td>
    </tr>
    <tr>
        <td>
            (๕) หนังสือแต่งตั้งผู้ดำเนินกิจการ กรณีผู้ขอรับใบอนุญาตเป็นนิติบุคคล
        </td>
    </tr>
    <tr>
        <td>
            (๖) แผนที่แสดงที่ตั้งและแผนผังแสดงที่ผลิตหรือเก็บซึ่งวัตถุออกฤทธิ์ในประเภท ๓ หรือประเภท ๔ ของสถานประกอบการ
        </td>
    </tr>
    <tr>
        <td>
            (๗) รูปถ่ายแสดงที่ผลิตหรือเก็บซึ่งวัตถุออกฤทธิ์ในประเภท ๓ หรือประเภท ๔ ของสถานประกอบการจำำนวน ๑ รูป
        </td>
    </tr>
</table>

<div style="margin-left:5%;font-size:20px"><strong>๕.๒ <u>กรณีขอต่ออายุใบอนุญาต</u></strong></div>
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
<div style="margin-left:5%;font-size:20px"><strong>๕.๓ <u>กรณีขอรับใบแทนใบอนุญาต</u></strong></div>
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

















