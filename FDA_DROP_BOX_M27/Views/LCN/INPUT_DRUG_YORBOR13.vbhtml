@Code
    ViewData("Title") = "PDF_DRUG_KORYOR16"
    Layout = ""
End Code


<div>
    <p style="text-align: right;">แบบ ย.บ.๑๓</p>
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
<hr />
<div> <h3 style="text-align:left">คำขอต่ออายุใบอนุญาต</h3></div>
<table style="width:100%">
    <tr>
        <td> <input type="checkbox" /> ผลิตยาแผนโบราณ</td>
    <tr>
        <td> <input type="checkbox" /> ขายยาแผนโบราณ</td>
    <tr>
        <td> <input type="checkbox" /> นำหรือสั่งยาแผนโบราณเข้ามาในราชอาณาจักร</td>
    </tr>
</table>
<hr />
<table style="width:100%" border="1">
    <tr>
        <td style="width:70%"></td>
        <td>เขียนที่ <input style="width:100%;text-align:right" /></td>
    </tr>
</table>
<table style="width:100%">
    <tr>
        <md-datepicker ng-model="datas.MFD_DATE" md-placeholder="Enter date"
                       input-aria-describedby="datepicker-description"
                       input-aria-labelledby="datepicker-header "></md-datepicker>
    </tr>
</table>
<br />
<table style="width:100%">
    <tr>
        <td style="width:10%;text-align:right">ข้าพเข้า </td>
        <td style="width:40%;text-align:center"></td>
        <td style="width:10%;text-align:right">ซึ่งมีผู้ดำเนินกิจการ ชื่อ </td>
        <td style="width:40%;text-align:center"></td>
    </tr>
</table>
<table style="width:100%">
    <tr>
        <td style="width:10%;text-align:right"></td>
        <td style="width:40%;text-align:center">(ชื่อผู้ขออนุญาต)</td>
        <td style="width:10%;text-align:right"></td>
        <td style="width:40%;text-align:center"></td>
    </tr>
</table>
<table style="width:100%">
    <tr>
        <td style="width:13%;">ได้รับอนุญาตให้</td>
        <td> <input type="checkbox" /> ผลิตยาแผนโบราณ</td>
        <td> <input type="checkbox" /> ขายยาแผนโบราณ</td>
        <td> <input type="checkbox" /> นำหรือสั่งยาแผนโบราณเข้ามา</td>
    </tr>
</table>
<table style="width:100%">
    <tr>
        <td style="width:20%;">ในราชอาณาจักรตามใบอนุญาตที่</td>
        <td style="width:35%;text-align:center"></td>
        <td style="width:15%;">ณ สถานที่ประกอบธุรกิจ ชื่อ</td>
        <td style="width:35%;text-align:center"></td>
    </tr>
</table>
<table style="width:100%">
    <tr>
        <td style="width:10%;">อยู่เลขที่</td>
        <td style="width:90%;text-align:center"></td>
    </tr>
</table>
<table style="width:100%">
    <tr>
        <td style="width:13%;">โทรศัพท์/โทรศัพท์มือถือ</td>
        <td style="width:37%;text-align:center"></td>
        <td style="width:10%;">เวลาทำการ</td>
        <td style="width:40%;text-align:center"></td>
    </tr>
</table>
<table style="width:100%">
    <tr>
        <td style="width:30%">ขอต่ออายุใบอนุญาตดังกล่าว เพื่อใช้ต่อไปในปี พ.ศ.</td>
        <td style="width:20%"> </td>
    </tr>
</table>
<br />
<table style="width:100%">
    <tr>
        <td style="width:5%">
        <td style="width:95%">ข้าพเจ้าได้ส่งมอบหลักฐานต่างๆ มาด้วย คือ</td>
    </tr>
</table>
<table style="width:100%">
    <tr>
        <td style="width:5%"></td>
        <td style="width:95%">(๑) ใบรับรองของผู้ประกอบวิชาชีพเวชกรรม ซึ่งรับรองว่าผู้ดำเนินกิจการไม่เป็นโรคตามมาตรา ๔๘ (๖)แห่งพระราชบัญญัติยา พ.ศ. ๒๕๑๐ ซึ่งแก้ไขเพิ่มเติมโดยพระราชบัญญัติยา (ฉบับที่ ๓) พ.ศ. ๒๕๒๒</td>
    </tr>
</table>
<table style="width:100%">
    <tr>
        <td style="width:5%"></td>
        <td style="width:95%">(๒) ใบอนุญาตประกอบธุรกิจเกี่ยวกับยาแผนโบราณหรือใบแทน</td>
    </tr>
</table>
<table style="width:100%">
    <tr>
        <td style="width:5%"></td>
        <td style="width:95%">(๓) เอกสารแสดงว่าเป็นผู้จัดการหรือผู้แทน ซึ่งเป็นผู้ดำเนินกิจการของนิติบุคคล (กรณีนิติบุคคลเป็นผู้ขออนุญาต)</td>
    </tr>
</table>
<table style="width:100%">
    <tr>
        <td style="width:5%"></td>
        <td style="width:95%">(๔) เอกสารอื่น ๆ ถ้ามี</td>
    </tr>
</table>
<br />
<table style="width:100%">
    <tr>
        <td style="width:50%;text-align:center"></td>
        <td style="width:10%;text-align:right">(ลายมือชื่อ)</td>
        <td style="width:20%;text-align:center"></td>
        <td style="width:20%;text-align:start">ผู้ยื่นคำขอ</td>
    </tr>
</table>
<br />
<hr />
<div>หมายเหตุ :- &nbsp; ใส่เครื่องหมาย &#10004; ในช่อง [  ] หน้าข้อความที่ต้องการ</div>
