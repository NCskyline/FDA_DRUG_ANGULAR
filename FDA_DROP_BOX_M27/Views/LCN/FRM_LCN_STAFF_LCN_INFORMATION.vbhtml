<script>

</script>
<style>
</style>
<div ng-controller="LCN_CTRL" ng-app="ANGULAR_APP" >
    <h1>รายละเอียดใบอนุญาต</h1>
    <table style="width:100%" ng-repeat="datas in LIST_LCN" >
            <tr>
                <td style="width:10%">
                    เลขอนุญาต :
                </td>
                <td style="width:20%">
                    {{datas.lcnno_no}}
                </td>
                <td>
                    เลขบัตรปชช.ผู้รับอนุญาต :
                </td>
                <td>
                    {{datas.CITIZEN_ID_AUTHORIZE}}
                </td>
            </tr>
            <tr>
                <td>
                    ชื่อสถานที่ :
                </td>
                <td>
                    {{datas.thanm}}
                </td>
                <td style="width:20%">
                    ชื่อผู้ดำเนินกิจการ :
                </td>
                <td>
                    {{datas.grannm_lo}}
                </td>
            </tr>
        </table>
    <br />

    <h1>สถานะใบอนุญาต</h1>
    <table style="width:100%" @*border="1"*@>
        <tr>
            <td style="width:20%">
                สถานะปัจจุบัน :
            </td>
            <td>
                <asp:Label ID="lbl_statname" runat="server" Text=""></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                วันที่มีผล :
            </td>
            <td>
                <asp:Label ID="lbl_date_cancel" runat="server" Text="-">
            </td>
        </tr>
        <tr>
            <td>
                วันที่ออกให้ครั้งแรก :
            </td>
            <td>
                <asp:Label ID="lbl_first_appdate" runat="server" Text="-"></asp:Label>
            </td>
        </tr>
    </table>
    <br />

    <h1>การขอเปลี่ยนแปลงสถานะ </h1>
    <table style="width:100%" @*border="1"*@>
        <tr>
            <td style="width:20%">
                เลือกสถานะใหม่ :
            </td>
            <td>
                <asp:DropDownList ID="ddl_stat" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>
                เลือกวันที่มีผล :
            </td>
            <td>
                <md-datepicker ng-model="datas.MFD_DATE" md-placeholder="Enter date"
                               input-aria-describedby="datepicker-description"
                               input-aria-labelledby="datepicker-header ">
                </md-datepicker>
            </td>
        </tr>
    </table>
    <input type="button" value="เปลี่ยนสถานะ" style="margin-left:20%" />
    <br />

    <h1>เวลาทำการ</h1>
    <table style="width:100%" @*border="1"*@>
        <tr>
            <td style="width:20%">
                เวลาทำการ :
            </td>
            <td>
                <input style="width:30%" /><input type="button" value="เปลี่ยนเวลาการทำงาน" style="margin-left:.5%;width:17%" />
            </td>
        </tr>
        <tr>
            <td>
                รูปแบบบ้านเลขที่ในไฟล์ pdf:
            </td>
            <td>
                <select style="width:30%">
                    <option>
                        เเบบปกติ
                    </option>
                    <option>
                        เเบบบ้านเลขที่ยาว
                    </option>
                </select>
                <input type="button" value="เปลี่ยนรูปแบบ pdf" style="width:17%" />
            </td>
        </tr>
    </table>
    <br />

    <h1>แก้ไขวันที่ให้ไว้ ณ และปีที่หมดอายุ</h1>
    <table style="width:100%" @*border="1"*@>
        <tr>
            <td style="width:20%">
                วันที่ให้ไว้ ณ :
            </td>
            <td>
                <input style="width:30%" /><input type="button" value="เปลี่ยนวันที่ให้ไว้ ณ" style="margin-left:.5%;width:17%" />
            </td>
        </tr>
        <tr>
            <td>
                ปีที่หมดอายุ :
            </td>
            <td>
                <input style="width:30%" /><input type="button" value="เปลี่ยนปีที่หมดอายุ" style="margin-left:.5%;width:17%" />
            </td>
        </tr>
    </table>
    <br />

    <h1>รูปถ่ายที่แนบในใบอนุญาต</h1>
    <div><a href=" URL ของเว็บไซต์ "><img src=" ที่อยู่ของรูปภาพ " width="150" height="180"></a></div>
    <table>
        <tr>
            <td>
                <input type="button" value="Chosse File" />
            </td>
            <td>
                <span>No file choses</span>
            </td>
            <td>
                <input type="button" value="Upload Photo" />
            </td>
        </tr>


    </table>
    <br />

    <h1>รายละเอียดสถานที่ตั้ง</h1>
    <div>
        <input type="button" value="เลือกสถานที่ตั้ง" style="float:right">
        <table style="width:100%" border="1">
            <tr style="background-color:#8CB340">
                <td style="width:15%">
                    <span style="margin-left:5%">ชื่อสถานที่</span>
                </td>
                <td>
                    <span style="margin-left:2%">ที่อยู่ตามทะเบียนราษฎร์</span>
                </td>
            </tr>
            <tr>
                <td>
                    <span style="margin-left:5%"> text</span>
                </td>
                <td>
                    <span style="margin-left:2%"> text</span>
                </td>
            </tr>
        </table>
        <p>*หมายเหตุ หากมีการเพิ่มสถานที่ตั้งใหม่ ระบบจะทำการผูกกับใบอนุญาตให้อัติโนมัติ</p>
        <br />

        <h1>รายละเอียดสถานที่เก็บ(ถ้ามี)</h1>
        <div style="float:right"><input type="button" value="เลือกสถานที่เก็บ" /><input type="button" value="เพิ่มสถานที่เก็บใหม่" /></div>
        <table style="width:100%" border="1">
        </table>
        <p>*หมายเหตุ เมื่อเพิ่มสถานที่เก็บใหม่ จะต้องทำการเลือกสถานที่เก็บทุกครั้ง ข้อมูลถึงจะเปลี่ยนตามที่เพิ่มเข้าไปใหม่</p>
        <br />

        <h1>รายละเอียดผู้ดำเนินกิจการ</h1>
        <div style="float:right"><input type="button" value="เปลี่ยนผู้ดำเนินกิจการ" /></div>
        <table style="width:100%" border="1">
            <tr style="background-color:#8CB340">
                <td style="width:20%">
                    <span style="margin-left:5%">ชื่อผู้ดำเนินกิจการ</span>
                </td>
                <td colspan="4">
                    <span style="margin-left:1%">ที่อยู่</span>
                </td>
            </tr>
            <tr>
                <td>
                    <span style="margin-left:5%"> text</span>
                </td>
                <td>
                    <span style="margin-left:2%"> text</span>
                </td>
                <td style="width:10%">
                    <span style="margin-left:2%"><a href=""><u>อัพเดทข้อมูล</u></a></span>
                </td>
                <td style="width:15%">
                    <span style="margin-left:2%"><a href=""><u>แก้ไขข้อมูลชื่อ-ที่อยู่เอง</u></a></span>
                </td>
            </tr>
        </table>
        <br />

        <h1>รายละเอียดผู้รับอนุญาต</h1>
        <div style="float:right"><input type="button" value="เปลี่ยนผู้ดำเนินกิจการ" /></div>
        <table style="width:100%" border="1">
            <tr style="background-color:#8CB340">
                <td style="width:20%">
                    <span style="margin-left:5%">เลขนิติบุคคล</span>
                </td>
                <td colspan="4">
                    <span style="margin-left:1%">ชื่อผู้รับอนุญาต</span>
                </td>
            </tr>
            <tr>
                <td>
                    <span style="margin-left:5%"> text</span>
                </td>
                <td>
                    <span style="margin-left:2%"> text</span>
                </td>
                <td style="width:10%">
                    <span style="margin-left:2%"><a href=""><u>อัพเดทข้อมูล</u></a></span>
                </td>
            </tr>
        </table>
        <br />

        <h1>รายละเอียดผู้มีหน้าที่ปฏิบัติการ</h1>
        <div style="float:right"><input type="button" value="เพิ่มผู้ที่มีหน้าที่ปฏิบัติ" /></div>
        <table style="width:100%" border="1">
            <tr style="background-color:#8CB340">
                <td style="width:20%">
                    <span style="margin-left:5%">เลขบัตรปชช.</span>
                </td>
                <td>
                    <span style="margin-left:1%">ชื่อผู้มีหน้าที่ปฏิบัติการ</span>
                </td>
                <td style="width:10%">
                    <span style="margin-left:1%">เวลาทำการ</span>
                </td>
                <td colspan="6">
                    <span style="margin-left:1%">หน้าที่</span>
                </td>
            </tr>
            <tr>
                <td>
                    <span style="margin-left:5%"> text</span>
                </td>
                <td>
                    <span style="margin-left:2%"> text</span>
                </td>
                <td>
                    <span style="margin-left:5%"> text</span>
                </td>
                <td style="width:15%">
                    <span style="margin-left:5%"> text</span>
                </td>
                <td style="width:10%">
                    <span style="margin-left:2%"><a href=""><u>เเก้ไข</u></a></span>
                </td>
                <td style="width:10%">
                    <span style="margin-left:2%"><a href=""><u>ลบข้อมูลถาวร</u></a></span>
                </td>
            </tr>
        </table>
        <br />

    </div>
</div>