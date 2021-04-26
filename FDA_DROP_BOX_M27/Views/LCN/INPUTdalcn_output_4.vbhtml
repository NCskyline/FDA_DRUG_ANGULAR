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
    <strong>แบบ ข.ย.๔</strong>
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
        <td style="font-size:20px" width="5%">
            ข้าพเจ้า
        </td>
        <td style="text-align:center; font-size:20px">
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
        <td>
            ซึ่งมีผู้ดำเนินกิจการ ชื่อ
        </td>
        <td style="text-align:left;width:2000px">
            text
        </td>
        <td colspan="4">
            (เฉพาะกรณีนิติบุคคล)
        </td>
    </tr>
    <tr>
        <td style="width:600px;">
            เลขบัญประจำตัวประชาชน
        </td>
        <td style="text-align:left;width:2000px">
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
    </tr>
    <tr>
        <td>
            โทรศัพท์มือถือ
        </td>
        <td style="text-align:left">
            text
        </td>
    </tr>
    <tr>
        <td>
            E-mail
        </td>
        <td>
            <input />
        </td>
    </tr>
</table>
<br />
<br />
<table style=" font-size:20px;width:100%" @*border="1"*@ ;>
    <tr style="text-align:center">
        <td style="width:50%">
            ขอรับใบอนุญาตขายยาแผนปัจจุบันโดยมีสถานที่ขายยาชื่อ
        </td>
        <td style="text-align:left">
            text
        </td>
    </tr>
    <tr>
        <td style="width:50%">
            อยู่เลขที่
        </td>
        <td>
            text
        </td>
    </tr>
    <tr>
        <td style="width:50%">
            โทรศัพท์
        </td>
        <td>
            text
        </td>
    </tr>
    <tr>
        <td style="width:50%">
            โทรศัพท์มือถือ
        </td>
        <td>
            text
        </td>
    </tr>
</table>
<br />
<br />

<div style=" font-size:20px;margin-left:10%"> ลักษณะการประกอบการ (๑)</div>

<table style=" font-size:20px;width:100%;margin-left:10%">

    <tr>
        <td>
            <input class="checkbox" type="checkbox" />
        </td>
        <td>
            ขายส่งยาสำเร็จรูป
        </td>
    </tr>
    <tr>
        <td>
            <input class="checkbox" type="checkbox" />
        </td>
        <td>
            ขายส่งเภสัชเคมีภัณฑ์
        </td>
    </tr>

</table>
<br />
<br />
<hr class="hr" />
<br />
<div style=" font-size:20px;margin-left:5%">๑) ให้ตอบมากกว่า ๑ ข้อ ในกรณีมีลักษณะการประกอบการมากกว่าหนึ่งลักษณะโดยการตอบจะมีผลต่อการประเมินความพร้อมของสถานที่ </div>
<div style=" font-size:20px">อุปกรณ์ และการดำเนินการตามหลักวิธีปฏิบัติทางเภสัชกรรมชุมชน เพื่อประกอบการอนุญาต</div>
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
<br />
<br />
<table style="font-size:20px;width:100%" @*border="1"*@>
    <tr>
        <td style="width:20%">
            โดยมีเภสัชกรชั้น
        </td>
        <td style="width:10%">
            <input style="width:100%" />
        </td>
        <td style="text-align:center">
            ชื่อ
        </td>
        <td style="width:10%">
            <input style="width:100%" />
        </td>
        <td>
            <input style="width:100%" />
        </td>
    </tr>
    <tr>
        <td style="width:20%">
            เลขบัตรประจำตัวประชาชน
        </td>
        <td colspan="4">
            <input style="width:100%" />
        </td>
    </tr>
    <tr>
        <td>
            ใบอนุญาตประกอบวิชาชีพ
        </td>
        <td colspan="4">
            <input style="width:100%" />
        </td>
    </tr>
    <tr>
        <td>
            เภสัชกรรมเลขที่
        </td>
    </tr>
</table>
<br />
<input type="button" style="font-size:20px;width:100px" value="เพิ่ม" />
<input type="button" style="font-size:20px;width:100px;margin-left:10px" value="ลบ" />
<hr />

<table style="font-size:16px;width:100%" @*border="1"*@>
    <tr>
        <td style="text-align:center" colspan="2">
            <strong>(ถ้ามีมากกว่าหนึ่งคนให้แจ้งเพิ่มเติมท้ายคำขอนี้จน)</strong>
        </td>
    </tr>
    <tr>
        <td colspan="2">
            เป็นผู้มีหน้าที่ปฏิบัติการตามมาตรา ๓๙ หรือมาตรา ๔๐ แห่งรพระราชบัญญัติยา พ.ศ. ๒๕๑๐
        </td>
    </tr>
    <tr>
        <td style="width:30%">
            <strong>เวลาทำการ (เวลาปฏิบัติการ ของผู้มีหน้าที่ปฏิบัติการ)</strong>
        </td>
        <td>
            <input style="width:100%" />
        </td>
    </tr>
</table>
<br />

<div style="font-size:20px">
    ข้าพเจ้าขอรับรองว่าในระยะเวลาสองปีก่อนยื่นคำขอนี้ ข้าพเจ้าไม่เคยได้รับโทษจำำคุกโดยคำำพิพากษาถึงที่สุดหรือคำสั่งที่ชอบด้วยกฎหมายให้จำคุกในความผิดที่
    กฎหมายบัญญัติ ให้ถือเอาการกระทำโดยทุจริตเป็นองค์ประกอบหรือในความผิดตามกฎหมายว่าด้วยยาเสพติดให้โทษ กฎหมายว่าด้วยวัตถุที่ออกฤทธิ์ต่อจิตและ
    ประสาท กฎหมายว่าด้วยการขายยาหรือพระราชบัญญัตินี้
    ข้าพเจ้าได้แนบหลักฐานมาด้วย คือ
</div>
<br />
<div style="margin-left:10%;font-size:20px">(๑) รูปถ่ายของผู้ขออนุญาต ขนาด ๓ x ๔ เซนติเมตร จำำนวน ๓ รูป</div>
<div style="margin-left:10%;font-size:20px">(๒) เอกสารแสดงการเป็นเจ้าของกิจการและหลักทรัพย์</div>
<div style="margin-left:10%;font-size:20px">(๓) สำเนาทะเบียนบ้านของผู้ขออนุญาต (กรณีบุคคลธรรมดาเป็นผู้ขออนุญาต) หรือ ผู้ดำเนินกิจการ (กรณีนิติบุคคลเป็นผู้ขออนุญาต)</div>
<div style="margin-left:10%;font-size:20px">(๔) ใบรับรองของผู้ประกอบวิชาชีพเวชกรรมซึ่งรับรองว่าผู้ขออนุญาตไม่เป็นโรคตามมาตรา ๑๔ (๖) แห่งพระราชบัญญัติยา พ.ศ. ๒๕๑๐</div>
<div style="margin-left:10%;font-size:20px">(๕) สัญญาระหว่างผู้ขออนุญาตและเภสัชกร ซึ่งรับจะเป็นผู้มีหน้าที่ปฏิบัติการของผู้ขออนุญาต</div>
<div style="margin-left:10%;font-size:20px">(๖) สำเนาหรือรูปถ่ายใบอนุญาตประกอบวิชาชีพเภสัชกรรมของเภสัชกรทุกคน ซึ่งรับจะเป็นผู้มีหน้าที่ปฏิบัติการของผู้ขออนุญาต</div>
<div style="margin-left:10%;font-size:20px">(๗) เอกสารแสดงว่าเป็นผู้ดำำเนินกิจการ (กรณีนิติบุคคลเป็นผู้ขออนุญาต)</div>
<br />
<br />
<br />
<table style="font-size:20px;width:40%;float:right" @*border="1"*@>
    <tr>
        <td>
            (ลายมือชื่อ)
        </td>
        <td style="width:50%;text-align:center">
            text
        </td>
        <td style="text-align:left">
            ผู้ขออนุญาต
        </td>
    </tr>
    <tr>
        <td>
            (
        </td>
        <td style="width:50%;text-align:center">
            text
        </td>
        <td style="text-align:left">
            ตัวบรรจง)
        </td>
    </tr>
</table>

