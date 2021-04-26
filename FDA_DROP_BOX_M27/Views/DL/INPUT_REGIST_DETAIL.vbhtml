@Code
    ViewData("Title") = "INPUT_REGIST_DETAIL"
End Code

<h2>ข้อมูลทั่วไป</h2>
<table>
    <tr>
        <td>
            หมวดยา
        </td>
        <td style="padding:0px 0px 0px 50px;">
            <label id="lbl_dactg"></label>
        </td>
        <td style="padding:0px 0px 0px 50px;">
            แก้ไขเป็น
        </td>
        <td style="padding:0px 0px 0px 50px;">
            <select id="ddl_dactg">
                <option>กรุณาเลือก</option>
            </select>
        </td>
        <td style="color:red;padding:0px 0px 0px 10px;">
            *
        </td>
    </tr>
    <tr>
        <td>
            ประเภทของยา
        </td>
        <td style="padding:0px 0px 0px 50px;">
            <label id="lbl_drclass"></label>
        </td>
        <td style="padding:0px 0px 0px 50px;">
            แก้ไขเป็น
        </td>
        <td style="padding:0px 0px 0px 50px;">
            <select id="ddl_drclass">
                <option>กรุณาเลือก</option>
            </select>
        </td>
        <td style="color:red;padding:0px 0px 0px 10px;">
            *
        </td>
    </tr>
    <tr>
        <td>
            รูปแบบของยา
        </td>
        <td style="padding:0px 0px 0px 50px;">
            <label id="lbl_drdosage"></label>
        </td>
        <td style="padding: 0px 0px 0px 50px;">
            แก้ไขเป็น
        </td>
        <td style="padding:0px 0px 0px 50px;">
            <select id="ddl_drdosage">
                <option>กรุณาเลือก</option>
            </select>
        </td>
        <td style="color:red;padding:0px 0px 0px 10px;">
            *
        </td>
    </tr>
    <tr>
        <td>
            หน่วยนับตามรูปของแบบยา
        </td>
        <td style="padding:0px 0px 0px 50px;">
            <label id="lbl_small_unit"></label>
        </td>
        <td style="padding:0px 0px 0px 50px;">
            แก้ไขเป็น
        </td>
        <td style="padding:0px 0px 0px 50px;">
            <select id="ddl_small_unit">
                <option>กรุณาเลือก</option>
            </select>
        </td>
        <td style="color:red;padding:0px 0px 0px 10px;">
            *
        </td>
    </tr>
    <tr>
        <td>
            หน่วยนับทางชีวภาพ
        </td>
        <td style="padding:0px 0px 0px 50px;">
            <label id="lbl_bio_pack"></label>
        </td>
        <td style="padding:0px 0px 0px 50px;">
            แก้ไขเป็น
        </td>
        <td style="padding:0px 0px 0px 50px;">
            <select id="ddl_bio_pack">
                <option>กรุณาเลือก</option>
            </select>
        </td>
    </tr>
    <tr>
        <td>
            หน่วยนับตามบรรจุภัณฑ์
        </td>
        <td style="padding:0px 0px 0px 50px;">
            <label id="lbl_packaging"></label>

        </td>
        <td style="padding:0px 0px 0px 50px;">
            แก้ไขเป็น
        </td>
        <td style="padding:0px 0px 0px 50px;">
            <select id="ddl_packaging">
                <option>กรุณาเลือก</option>
            </select>
        </td>
    </tr>
    <tr>
        <td>
            รูปทรง
        </td>
        <td style="padding:0px 0px 0px 50px;">
            <label id="lbl_shape"></label>
        </td>
        <td style="padding:0px 0px 0px 50px;">
            แก้ไขเป็น
        </td>
        <td style="padding:0px 0px 0px 50px;">
            <select id="ddl_shape">
                <option>กรุณาเลือก</option>
            </select>
        </td>
    </tr>
    <tr>
        <td>
            ชนิดของยาตามกฎหมาย
        </td>
        <td style="padding:0px 0px 0px 50px;">
            <label id="lbl_drug_type"></label>
        </td>
        <td style="padding:0px 0px 0px 50px;">
            แก้ไขเป็น
        </td>
        <td style="padding:0px 0px 0px 50px;">
        </td>
    </tr>
    <tr>
        <td>
            ความแรง
        </td>
        <td style="padding:0px 0px 0px 50px;">
            &nbsp;
        </td>
        <td style="padding:0px 0px 0px 50px;">
            &nbsp;
        </td>
        <td style="padding:0px 0px 0px 50px;">
            <text id="txt_drug_str">

            </text>
        </td>
    </tr>
    <tr>
        <td>
            &nbsp;
        </td>
        <td style="padding:0px 0px 0px 50px;">

            &nbsp;
        </td>
        <td style="padding:0px 0px 0px 50px;">

            &nbsp;
        </td>
        <td style="padding:0px 0px 0px 50px;">
            <button ID="btn_save" class="input-lg" >บันทึกข้อมูล</button>
        </td>
    </tr>
</table>
