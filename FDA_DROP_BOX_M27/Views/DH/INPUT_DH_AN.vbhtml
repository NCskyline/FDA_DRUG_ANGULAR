@Code
    ViewData("Title") = "INPUT_DH_AN"
End Code

<center>
    <h2>คำขอจดแจ้งเภสัชเคมีภัณฑ์</h2> <br />
    <h2>
        เป็นสารออกฤทธิ์ที่ไม่มีในทะเบียนตำำรับยาผลิตในประเทศ
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
                <option>Default</option>
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
            <select class="dropdown">
                <option>Country</option>
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
        <td colspan="3">
            <input />
        </td>

    </tr>
    <tr>
        <td>
            มาตรฐาน (ตำรายา)
        </td>
        <td colspan="3">
            <input />
        </td>
    </tr>
    <tr>
        <td>
            จำนวน
        </td>
        <td>
            <input />
        </td>
        <td>
            ปริมาณ
        </td>
        <td>
            <input />
        </td>
    </tr>
</table>

//Table เพิ่มสาร <br />

เหตุผลในการผลิต/นำเข้าฯ
<table>
    <tr>
        <td>
            <form name="myForm" ng-controller="ExampleController">
                <label>
                    <input type="radio" ng-model="LCN.TYPE" value="1">
                    ใช้ในการผลิตยาตัวอย่างเพื่อขอขึ้นทะเบียนตำรับยา
                </label> <br />
                <label>
                    <input type="radio" ng-model="LCN.TYPE" value="2">
                    ใช้ในการพัฒนาตำรับยาที่ได้เลขทะเบียนแล้ว
                </label> <br />
                <label>
                    <input type="radio" ng-model="LCN.TYPE" value="2">
                    อื่น ๆ (ระบุ)
                </label>
                <input />
            </form>
        </td>
    </tr>
</table>