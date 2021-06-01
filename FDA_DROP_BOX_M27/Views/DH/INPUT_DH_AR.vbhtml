@Code
    Layout = ""
End Code
<script src="../Scripts_angular/CENTER_SV.js"></script>
<script src="../Scripts_angular/DH_CTRL.js"></script>
<div class="ic">
    <center>
        <h2>คำขอจดแจ้งเภสัชเคมีภัณฑ์</h2> <br />
        <h2>
            เป็นสารออกฤทธิ์ตามทะเบียนตำรับยาผลิตในประเทศ
        </h2>
    </center>
    <table>
        <tr>
            <td>

                <div ng-include src="'Views/DH/HEADER_DH'"></div>
            </td>
        </tr>
    </table>

    <table>
        <tr>
            <td>
                Ref Cer
            </td>
            <td>
                <select class="dropdown">
                    <option ng-repeat="x in REF_CERT" value="{{x.IDA}}">{{x.CER_NUMBER}}</option>
                </select>
            </td>
        </tr>
    </table>
    <table width="100%">
        <tr>
            <td>
                ชื่อผู้ผลิต
            </td>
            <td width="30%">
                <label>

                </label>
            </td>
            <td>
                ประเทศ
            </td>
            <td width="10%">
                <label>

                </label>
            </td>
        </tr>
        <tr>
            <td>
                ชื่อผู้แทนจำหน่ายในต่างประเทศ (ซื้อผ่าน)
            </td>
            <td>
                <label>

                </label>
            </td>
            <td>
                ประเทศ
            </td>
            <td>
                <select>
                    <option ng-repeat="x in CNT_LIST" value="{{x.engcntnm}}">{{x.engcntnm}}</option>
                </select>
            </td>
        </tr>
    </table>
    <br />
    <table>
        <tr>
            <td>
                วันเดือนปีที่ออกใบรับรอง
            </td>
            <td>
                <label>

                </label>
            </td>
        </tr>
        <tr>
            <td>
                วันเดือนปีที่หมดอายุ
            </td>
            <td>
                <label>

                </label>
            </td>
        </tr>
    </table>
    <table width="100%">
        <tr>
            <td>
                ชื่อการค้า <font color="red">*</font>
            </td>
            <td>
                <input />
            </td>

        </tr>
        <tr>
            <td>
                มาตรฐาน (ตำำรายา)
            </td>
            <td>
                <input />
            </td>
        </tr>
    </table>

    //Table เพิ่มสาร
</div>