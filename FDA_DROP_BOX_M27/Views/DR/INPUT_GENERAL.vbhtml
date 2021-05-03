@Code
    ViewData("Title") = "INPUT_GENERAL"
End Code

<table>



    <tr>
        <td bgcolor="Lavender" width="197px" height="28px" align="right">ชื่อการค้า (ภาษาไทย):</td>
        <td>
            &nbsp;
        </td>
        <td>
            &nbsp;
        </td>
        <td>
            <input type="text" id="txt_thaname" style="width:100%;" />
        </td>
    </tr>



    <tr>
        <td bgcolor="Lavender" width="197px" height="28px" align="right">ชื่อการค้า (ภาษาอังกฤษ):</td>
        <td>
            &nbsp;
        </td>
        <td>
            &nbsp;
        </td>
        <td>
            <input type="text" id="txt_engname" style="width:100%;" />
        </td>
    </tr>



    <tr>
        <td bgcolor="Lavender" width="197px" align="right" class="auto-style1">หมวดยา : </td>
        <td style="padding:0px 0px 0px 50px;" class="auto-style1">
            <label ID="lbl_dactg"></label>
        </td>
        <td style="padding:0px 0px 0px 50px;" class="auto-style1">
            แก้ไขเป็น
        </td>
        <td class="auto-style1">
            <select id="rcb_dactg">
                <option>กรุณาเลือก</option>
            </select>
        </td>
    </tr>



    <tr>
        <td bgcolor="Lavender" align="right">รูปแบบยา : </td>
        <td style="padding:0px 0px 0px 50px;">
            <label ID="lbl_drdosage"></label>
        </td>
        <td style="padding:0px 0px 0px 50px;">
            แก้ไขเป็น
        </td>
        <td>
            <select id="rcb_drdosage">
                <option>กรุณาเลือก</option>
            </select>
        </td>
    </tr>




    <tr>
        <td bgcolor="Lavender" bgcolor="Wheat" align="right">ประเภทของยา :</td>
        <td style="padding:0px 0px 0px 50px;">
            <label ID="lbl_drclass"></label>
        </td>
        <td style="padding:0px 0px 0px 50px;">
            แก้ไขเป็น
        </td>
        <td>
            <select id="rcb_drclass">
                <option>กรุณาเลือก</option>
            </select>
        </td>
    </tr>

   
    <tr>
        <td bgcolor="Lavender" bgcolor="Wheat" align="right">ชนิดยา :</td>
        <td style="padding:0px 0px 0px 50px;">
            <label ID="lbl_drug_type"></label>
        </td>
        <td style="padding:0px 0px 0px 50px;">
            แก้ไขเป็น
        </td>
        <td>
            <select id="rcb_drug_type">
                <option>กรุณาเลือก</option>
            </select>
        </td>
    </tr>




    <tr>
        <td bgcolor="Lavender" bgcolor="Wheat" align="right">รูปทรง :</td>
        <td style="padding:0px 0px 0px 50px;">
            <label ID="lbl_shape"></label>
        </td>
        <td style="padding:0px 0px 0px 50px;">
            แก้ไขเป็น
        </td>
        <td>
            <select id="rcb_shape">
                <option>กรุณาเลือก</option>
            </select>
        </td>
    </tr>
    <tr>
        <td bgcolor="Lavender" bgcolor="Wheat" align="right">
            หน่วยนับตามรูปของแบบยา :
        </td>
        <td style="padding:0px 0px 0px 50px;">
            <label ID="lbl_small_unit"></label>
        </td>
        <td style="padding:0px 0px 0px 50px;">
            แก้ไขเป็น
        </td>
        <td>
            <select id="rcb_small_unit">
                <option>กรุณาเลือก</option>
            </select>
        </td>
    </tr>



    <tr>
        <td bgcolor="Lavender" bgcolor="Wheat" align="right">
            หน่วยนับทางชีวภาพ :
        </td>
        <td style="padding:0px 0px 0px 50px;">
            <label ID="lbl_bio_pack"></label>
        </td>
        <td style="padding:0px 0px 0px 50px;">
            แก้ไขเป็น
        </td>
        <td>
            <select id="rcb_bio_pack">
                <option>กรุณาเลือก</option>
            </select>
        </td>
    </tr>



    <tr>
        <td bgcolor="Lavender" bgcolor="Wheat" align="right">
            หน่วยนับตามบรรจุภัณฑ์ :
        </td>
        <td style="padding:0px 0px 0px 50px;">
            <label ID="lbl_packaging"></label>

        </td>
        <td style="padding:0px 0px 0px 50px;">
            แก้ไขเป็น
        </td>
        <td>
            <select id="rcb_packaging">
                <option>กรุณาเลือก</option>
            </select>
        </td>
    </tr>



    <tr>
        <td bgcolor="Lavender" bgcolor="Wheat" align="right">ความแรงของตำรับยา</td>
        <td>
            &nbsp;
        </td>
        <td>
            &nbsp;
        </td>
        <td>
            <input type="text" id="txt_drug_str" style="width:100px;" />
        </td>
    </tr>

</table>
