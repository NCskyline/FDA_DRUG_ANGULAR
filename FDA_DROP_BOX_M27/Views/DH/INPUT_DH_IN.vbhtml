﻿@Code
    ViewData("Title") = "INPUT_DH_IN"
End Code

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
            <select class="dropdown">
                <option>Country</option>
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
            <select class="dropdown">
                <option>Country</option>
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
<table>
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