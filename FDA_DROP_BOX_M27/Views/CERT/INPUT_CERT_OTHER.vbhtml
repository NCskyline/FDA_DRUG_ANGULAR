@Code
    ViewData("Title") = "INPUT_CERT_OTHER"

End Code

<script type="text/javascript">

</script>

<style type="text/css">
        .auto-style1 {
            height: 23px;
        }


</style>


<h2 style="font-family:'TH SarabunPSK';font-size:24px;">
    แบบกรอกรายละเอียดใบรับรองสถานที่ผลิตในต่างประเทศ
</h2>
<table width="100%" style="font-family:'TH SarabunPSK';font-size:20px;" >
    <tr>
        <td style="height:25px;width:35%;">
            1. Reference Number<font color="red">*</font> :
        </td>
        <td>
            <input class="form-control inline" style="font-family:'TH SarabunPSK';font-size:20px;" type="text" />
        </td>
    </tr>
    <tr>
        <td style="height:25px">
            2. ชื่อสถานที่ผลิตในต่างประเทศ (Manufacturer)<font color="red">*</font> :
        </td>
        <td>
            <input class="form-control inline" style="font-family:'TH SarabunPSK';font-size:20px;" type="text" />
        </td>
    </tr>
    <tr>
        <td style="height:25px">
            3. ที่อยู่ (Address)<font color="red">*</font> :
        </td>
        <td>
            <input class="form-control inline" style="font-family:'TH SarabunPSK';font-size:20px;" type="text" />
        </td>
    </tr>
    <tr>
        <td style="height:25px">
            4. เมือง (City / Province/ State)<font color="red">*</font> :
        </td>
        <td>
            <input class="form-control inline" style="font-family:'TH SarabunPSK';font-size:20px;" type="text" />
        </td>
    </tr>
    <tr>
        <td style="height:25px">
            5. ประเทศ (Country)<font color="red">*</font> :
        </td>
        <td>
            <input class="form-control inline" style="font-family:'TH SarabunPSK';font-size:20px;" type="text" />
        </td>
    </tr>
    <tr>
        <td style="height:25px">
            รหัสไปรษณีย์ (Post code/Zip code) :
        </td>
        <td>
            <input class="form-control inline" style="font-family:'TH SarabunPSK';font-size:20px;" type="text" />
        </td>
    </tr>
    <tr>
        <td style="height:25px">
            6. Manufactur&#39;s License Number<font color="red">*</font> :
        </td>
        <td>
            <input class="form-control inline" style="font-family:'TH SarabunPSK';font-size:20px;" type="text" />
        </td>
    </tr>
    <tr>
        <td style="height:25px">
            Global Location Number (GLN) :
        </td>
        <td>
            <input class="form-control inline" style="font-family:'TH SarabunPSK';font-size:20px;" type="text" />
        </td>
    </tr>
    <tr>
        <td style="height:25px">
            7. หน่วยงานที่ออกเอกสาร<font color="red">*</font> :
        </td>
        <td>
            <input class="form-control inline" style="font-family:'TH SarabunPSK';font-size:20px;" type="text" />
        </td>
    </tr>
    <tr>
        <td style="height:25px">
            ประเทศ (Country)<font color="red">*</font> :
        </td>
        <td>
            <input class="form-control inline" style="font-family:'TH SarabunPSK';font-size:20px;" type="text" />
        </td>
    </tr>
    <tr>
        <td>
            8. เลขหนังสือให้ความเห็นชอบ<font color="red">*</font> :
        </td>
        <td>
            <input class="form-control inline" style="font-family:'TH SarabunPSK';font-size:20px;" type="text" />
        </td>
    </tr>
    <tr>
        <td style="height:25px">
            9. วันเดือนปีที่ออกหนังสือ (Issue Date)<font color="red">*</font> :
        </td>
        <td>
      
                <md-datepicker ng-model="datas.MFD_DATE" md-placeholder="Enter date"
        input-aria-describedby="datepicker-description"
        input-aria-labelledby="datepicker-header "></md-datepicker>
                
        </td>
    </tr>
    <tr>
        <td style="height:25px">
            วันเดือนปีที่หมดอายุ (Expiry Date)<font color="red">*</font> :
        </td>
        <td>
            <md-datepicker ng-model="datas.MFD_DATE" md-placeholder="Enter date"
                           input-aria-describedby="datepicker-description"
                           input-aria-labelledby="datepicker-header "></md-datepicker>
        </td>
    </tr>
    <tr>
        <td style="height:25px">
            ประเทศของหน่วยงานที่ออกใบรับรอง :
        </td>
        <td>
            <input class="form-control inline" style="font-family:'TH SarabunPSK';font-size:20px;" type="text" />

        </td>
    </tr>
</table>
<br />
<h2 style="font-family:'TH SarabunPSK';font-size:24px;">
    รายละเอียดผลิตภัณฑ์
</h2>
<table>
    <tr>
        <td style="height:25px">
            10. ขอบข่าย
        </td>
        <td>
            <input class="form-control inline" style="font-family:'TH SarabunPSK';font-size:20px;" type="text" />
        </td>
    </tr>
</table>


