@Code
    Layout = ""
End Code
<script src="../Scripts_angular/CENTER_SV.js"></script>
<script src="../Scripts_angular/DH_CTRL.js"></script>
<div class="ic" >
    <center>
        <h2>คำขอจดแจ้งเภสัชเคมีภัณฑ์</h2> <br />
        <h2>
            ไม่เป็นสารออกฤทธิ์ตามทะเบียนตำรับยาผลิตในประเทศ
        </h2>
    </center>
    <table>
        <tr>
            <td>

                <div ng-include src="'Views/DH/HEADER_DH'"></div>
            </td>
        </tr>
    </table>

    <table width="100%">
        <tr>
            <td>
                ชื่อผู้ผลิต <font color="red">*</font>
            </td>
            <td width="30%">
                <label>

                </label>
            </td>
            <td>
                ประเทศ <font color="red">*</font>
            </td>
            <td width="10%">
                <select>
                    <option ng-repeat="x in CNT_LIST" value="{{x.IDA}}">{{x.engcntnm}}</option>
                </select>
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
                    <option ng-repeat="x in CNT_LIST" value="{{x.IDA}}">{{x.engcntnm}}</option>
                </select>
            </td>
        </tr>
        <tr>
            <td>
                ชื่อการค้า<font color="red">*</font>
            </td>
            <td colspan="3">
                <input />
            </td>
        </tr>
    </table>
    <br />
    //Table เพิ่มสาร <br />
    <br />
    <table>
        <tr>
            <td>
                มาตรฐาน (ตำรายา)
            </td>
            <td>
                <input />
            </td>
        </tr>
        <tr>
            <td>
                เกรด
            </td>
            <td>
                <input />
            </td>
        </tr>
    </table>
</div>