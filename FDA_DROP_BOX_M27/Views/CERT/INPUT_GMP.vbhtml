@Code
    ViewData("Title") = "INPUT_GMP"
End Code

<h2 style="font-family:'TH SarabunPSK';font-size:24px;">
    <b> แบบกรอกรายละเอียดใบรับรองสถานที่ผลิตในต่างประเทศ</b>
</h2>
<table width="100%" style="font-family:'TH SarabunPSK';font-size:20px;">
    <tr>
        <td style="height:25px;width:35%;">
            1. เลขที่ใบรับรอง (Certificate Number)<font color="red">*</font>  :
        </td>
        <td >
           <input class="form-control inline" style="font-family:'TH SarabunPSK';font-size:20px;" type="text" />
        </td>
    </tr>
    <tr>
        <td style="height:25px">
            2. ชื่อสถานที่ผลิตในต่างประเทศ (Manufacturer)<font color="red">*</font> :
        </td>
        <td >
            <input class="form-control inline" style="font-family:'TH SarabunPSK';font-size:20px;" type="text" />
        </td>
    </tr>
    <tr>
        <td style="height:25px">
            3. ที่อยู่ (Address)<font color="red">*</font> :
        </td>
        <td >
            <input class="form-control inline" style="font-family:'TH SarabunPSK';font-size:20px;" type="text" />
        </td>
    </tr>
    <tr>
        <td style="height:25px">
            4. เมือง (City / Province/ State)<font color="red">*</font> :
        </td>
        <td >
            <input class="form-control inline" style="font-family:'TH SarabunPSK';font-size:20px;" type="text" />
        </td>
    </tr>
    <tr>
        <td style="height:25px">
            5. ประเทศ (Country<font color="red">*</font> :
        </td>
        <td >
            <input class="form-control inline" style="font-family:'TH SarabunPSK';font-size:20px;" type="text" />
        </td>
    </tr>
    <tr>
        <td style="height:25px">
            รหัสไปรษณีย์ (Post code/Zip code) :
        </td>
        <td >
            <input class="form-control inline" style="font-family:'TH SarabunPSK';font-size:20px;" type="text" />
        </td>
    </tr>
    <tr>
        <td style="height:25px">
            6. Manufacturer&quot;s License Number :
        </td>
        <td >
            <input class="form-control inline" style="font-family:'TH SarabunPSK';font-size:20px;" type="text" />
        </td>
    </tr>
    <tr>
        <td style="height:25px">
            Global Location Number (GLN) :
        </td>
        <td >
            <input class="form-control inline" style="font-family:'TH SarabunPSK';font-size:20px;" type="text" />
        </td>
    </tr>
    <tr>
        <td style="height:25px">
            7. วันเดือนปีที่ออกหนังสือ GMP (Issue Date)<font color="red">*</font> :
        </td>
        <td >
            <input class="form-control inline" style="font-family:'TH SarabunPSK';font-size:20px;" type="text" />
        </td>
    </tr>
    <tr>
        <td style="height:25px">
            วันเดือนปีที่หมดอายุ (Expiry Date)<font color="red">*</font> :
        </td>
        <td >
            <input class="form-control inline" style="font-family:'TH SarabunPSK';font-size:20px;" type="text" />
        </td>
    </tr>
    <tr>
        <td style="height:25px">
            8. หน่วยงานที่ออกใบรับรอง<font color="red">*</font>
        </td>
        <td>
            &nbsp;
        </td>
    </tr>
    <tr>
        <td class="auto-style1">
            <asp:CheckBox ID="cb_DEPARTMENT_REGIST_CER_TYPE" runat="server" Text="ชื่อหน่วยงานรัฐของประเทศผู้ผลิต" />
        </td>
        <td  class="auto-style1">
            <asp:Label ID="lbl_DEPARTMENT_REGIST_CER_NAME" runat="server" Text="-"></asp:Label>
        </td>
    </tr>
    <tr>
        <td style="height:25px">
            <asp:CheckBox ID="cb_DEPARTMENT_REGIST_CER_TYPE2" runat="server" Text="ชื่อหน่วยงานอื่นที่ได้รับการรับรองจากหน่วยงานรัฐของประเทศผู้ผลิต" />
        </td>
        <td >
            <asp:Label ID="lbl_DEPARTMENT_REGIST_CER_NAME2" runat="server" Text="-"></asp:Label>
        </td>
    </tr>
    <tr>
        <td style="height:25px">
            9. สถานที่ผลิตได้มาตรฐาน GMP ตาม<font color="red">*</font> :

        </td>
        <td >
            <table>
                <tr>
                    <td style="height:25px">
                        <asp:RadioButtonList ID="rdl_gmp" runat="server" RepeatDirection="Horizontal">
                            <asp:ListItem Value="1">PIC / S GMP</asp:ListItem>
                            <asp:ListItem Value="2">WHO GMP</asp:ListItem>
                            <asp:ListItem Value="3">National GMP</asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                    <td>
                        &nbsp; ประเทศ<font color="red">*</font>
                    </td>
                    <td>
                        &nbsp;
                        <asp:Label ID="lbl_iso_gmp" runat="server" Text="-"></asp:Label> &nbsp;
                    </td>
                </tr>
            </table>


        </td>
    </tr>
</table>
<br />
<h2 style="font-family:'TH SarabunPSK';font-size:24px;">
    <b> รายละเอียดผลิตภัณฑ์ที่ได้รับการรับรอง </b>
</h2>
<table style="font-family:'TH SarabunPSK';font-size:20px;">
    <tr>
        <td style="height:25px">
            10. ขอบเขตของประเภทยาที่รับรอง
        </td>
        <td >
            <asp:Label ID="lbl_CER_SCOPE" runat="server" Text="-"></asp:Label>
        </td>
    </tr>
</table>