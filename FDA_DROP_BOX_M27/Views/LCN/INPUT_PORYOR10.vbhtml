@Code
    ViewData("Title") = "INPUT_PORYOR10"
End Code

<div>
    <p style="text-align: right;">แบบ ผ.ย.๑๐</p>
</div>
<table style="width:100%">
    <tr>
        <td style="width:35%"></td>
        <td style="width:35%"></td>
        <td style="width:5%;text-align:right">เลขที่:</td>
        <td style=" width:25%;text-align:center"></td>
    </tr>
</table>
<table style="width:100%">
    <tr>
        <td style="width:35%"></td>
        <td style="width:35%"></td>
        <td style="width:5%;text-align:right">วันที่:</td>
        <td style=" width:25%;text-align:center"></td>
    </tr>
</table>
<table style="width:100%">
    <tr>
        <td style="width:35%"></td>
        <td style="width:35%"></td>
        <td style="width:5%;text-align:right"> ลงชื่อ:</td>
        <td style=" width:15%;text-align:center"></td>
        <td style="width:10%">ผู้รับคำขอ</td>
    </tr>
</table>
<br />
<table style="width:100%">
    <tr>
        <td style="text-align:center"> คำขอ</td>
    </tr>
</table>
<table style="width:100%">
    <tr>
        <td style="text-align:center"> ผลิตยาแผนปัจจุบัน</td>
    </tr>
</table>
<table>
    <tr>
        <td><input type="checkbox" /> ใบแทนใบอนุญาต</td>
    </tr>
</table>
<table>
    <tr>
        <td><input type="checkbox" /> ย้ายสถานที่</td>
    </tr>
</table>
<hr />
<table style="width:100%">
    <tr>
        <td style="width:70%"></td>
        <td style="width:5%;text-align:right">เขียนที่</td>
        <td style="width:25%"></td>
    </tr>
</table>
<table>
    <tr>
        <md-datepicker ng-model="datas.MFD_DATE" md-placeholder="Enter date"
                       input-aria-describedby="datepicker-description"
                       input-aria-labelledby="datepicker-header "></md-datepicker>
    </tr>
</table>
<br />
<table style="width:100%">
    <tr>
        <td style="width:10%;text-align:right">ข้าพเข้า :</td>
        <td style="width:90%;text-align:center"></td>
    </tr>
</table>
<table style="width:100%">
    <tr>
        <td style="width:10%;"></td>
        <td style="width:90%;text-align:center">(ชื่อผู้รับอนุญาต)</td>
    </tr>
</table>
<table style="width:100%">
    <tr>
        <td style="width:15%;">ซึ่งมีผู้ดำเนินกิจการ ชื่อ</td>
        <td style="width:60%;text-align:center"></td>
        <td style="width:25%;text-align:right">ได้รับอนุญาตให้ผลิตยาแผยปัจจุบัน</td>
    </tr>
</table>
<table style="width:100%">
    <tr>
        <td style="width:15%;">ตามใบอนุญาตที่</td>
        <td style="width:35%;text-align:center"></td>
        <td style="width:15%;">ณ สถานที่นำหรือสั่งยาชื่อ</td>
        <td style="width:35%;text-align:center"></td>
    </tr>
</table>
<table style="width:100%">
    <tr>
        <td style="width:5%;">อยู่เลขที่</td>
        <td style="width:95%;text-align:center"></td>
    </tr>
</table>
<table style="width:100%">
    <tr>
        <td style="width:18%;">โทรศัพท์/โทรศัพท์มือถือ</td>
        <td style="width:82%;text-align:center"></td>
    </tr>
</table>
<br />
<div>ขอ</div>
<table>
    <tr>
        <td><input type="checkbox" />ใบแทนใบอนุญาตผลิตนาแผนปัจจุบันเนื่องจาก</td>
    <tr>
        <td> <input type="text" style="width:100%"> </td>
    </tr>
    <tr>
        <td style="width:100%;text-align:center">(เหตุที่ขอรับใบแทน)</td>
    <tr>
        <td><input type="checkbox" />ย้ายสถานที่ผลิตยาแผนปัจจุบัน</td>
    <tr>
        <td> <input type="text" style="width:100%"> </td>
    </tr>
</table>
<br />
<table style="width:100%">
    <tr>
        <td>ไปอยู่เลขที่	</td>
        <td style="width:90%"> <input type="text" /></td>
    </tr>
</table>
<table style="width:100%">
    <tr>
        <td>โทรศัพท์	</td>
        <td style="width:90%"> <input type="text" /></td>
    </tr>
</table>
<table>
    <tr>
        <td>ข้าพเจ้าได้แนบหลักฐานมาด้วย คือ</td>
    <tr>
        <td>&nbsp;&nbsp;<input type="checkbox" /> หลักฐานประกอบคำขอใบแทนใบอนุญาต</td>
    <tr>
        <td>&nbsp;&nbsp;&nbsp;&nbsp; (๑) รูปถ่ายของผู้ดำเนินกิจการ ขนาด ๓ x ๔ เซนติเมตร จำำนวน ๒ รูป</td>
    <tr>
        <td>&nbsp;&nbsp;&nbsp;&nbsp; (๒) ใบอนุญาตนำหรือสั่งยาแผนปัจจุบันเข้ามาในราชอาณาจักร ถ้ามี</td>
    <tr>
        <td>&nbsp;&nbsp;<input type="checkbox" /> หลักฐานประกอบคำขอย้ายสถานที่</td>
    <tr>
        <td>&nbsp;&nbsp;&nbsp;&nbsp; (๑) ใบอนุญาตผลิตแผนปัจจุบันหรือใบแทน</td>
    <tr>
        <td>&nbsp;&nbsp;&nbsp;&nbsp; (๒) แบบแปลนแผนผังสิ่งปลูกสร้างของสถานที่ผลิตแห่งใหม่ จำำนวน ๒ ชุด</td>
    <tr>
        <td>&nbsp;&nbsp;&nbsp;&nbsp; (๓) เอกสารแสดงว่าเป็นผู้ได้รับอนุญาต</td>
    </tr>
</table>
<table style="width:100%">
    <tr>
        <td style="width:50%;text-align:center"></td>
        <td style="width:10%;text-align:right">(ลายมือชื่อ)</td>
        <td style="width:20%;text-align:center"></td>
        <td style="width:20%;text-align:start">ผู้ยื่นคำขอ</td>
    </tr>
</table>
<hr />
<div>หมายเหตุ : &nbsp;(๑) ในกรณีที่ใบอนุญาตสูญหาย ให้นำใบรับแจ้งความของสถานีตำรวจแห่งท้องที่ที่ใบอนุญาตอนุญาตนั้นสูญหายมาด้วย</div>
<div>&nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;(๒) ในกรณีที่ใบอนุญาตถูกทำลายในสาระสำคัญ ให้นับใบอนุญาตนั้น มาด้วย</div>
<div>&nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;(๓) ใส่เครื่องหมาย &#10004 ในช่อง[  ] หน้าข้อความที่ต้องการ</div>