@Code
    Layout = ""
End Code

<h2>เพิ่มสาร</h2>
<table class="table">
    <tr>
        <td width="30%">วันที่</td>
        <td>
            <label>11-11-2000</label>
        </td>
    </tr>
    <tr>
        <td>ชื่อสาร</td>
        <td>
            <input class="form-control inline" style="font-family:'TH SarabunPSK';font-size:20px;" type="text" />
        </td>
    </tr>
    <tr>
        <td>รายละเอียดเพิ่มเติม</td>
        <td>
            <input class="form-control inline" style="font-family:'TH SarabunPSK';font-size:20px;" type="text" />
        </td>
    </tr>
    <tr>
        <td>CAS NUMBER</td>
        <td>
            <input class="form-control inline" style="font-family:'TH SarabunPSK';font-size:20px;" type="text" />
        </td>
    </tr>
    <tr>
        <td>INN</td>
        <td>
            <input class="form-control inline" style="font-family:'TH SarabunPSK';font-size:20px;" type="text" />
        </td>
    </tr>
    <tr>
        <td>INN TH</td>
        <td>
            <input class="form-control inline" style="font-family:'TH SarabunPSK';font-size:20px;" type="text" />
        </td>
    </tr>
    <tr>
        <td>Email สำหรับติดต่อ</td>
        <td>
            <input class="form-control inline" style="font-family:'TH SarabunPSK';font-size:20px;" type="text" />
        </td>
    </tr>
    <tr>
        <td>เบอร์โทรศัพท์ติดต่อ</td>
        <td>
            <input class="form-control inline" style="font-family:'TH SarabunPSK';font-size:20px;" type="text" />
        </td>
    </tr>
    <tr>
        <td>แนบเอกสารเพิ่มเติม</td>
        <td>
            @*<table style="width:100%;">
                    <tr>
                        <td colspan="2"><asp:FileUpload ID="FileUpload1" runat="server" />
                        </td>

                    </tr>
                    <tr>
                        <td>

                            <asp:HyperLink ID="hp_file_name" runat="server" style="display:none;" Target="_blank"></asp:HyperLink>
                        </td>

                        <td>
                            <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/Images/file_delete.png" Width="28px" Height="28px"
                                             ToolTip="ลบข้อมูล" style="display:none;" OnClientClick="return confirm('ต้องการลบหรือไม่');" />
                        </td>

                    </tr>
                </table>*@

        </td>
    </tr>
    <tr>
        <td colspan="2">
            <div style="text-align: center;">
                <table>
                    <tr>
                        <td><input type="button" ID="btn_save" value="บันทึก" />
                        </td>
                        <td>
                            <input type="button" ID="btn_edit" value="แก้ไข" />
                        </td>
                        <td>
                            <input type="button" ID="btn_close" value="ปิดหน้าต่าง" />
                        </td>
                    </tr>
                </table>

                &nbsp;&nbsp;
                &nbsp;&nbsp;

            </div>



        </td>
    </tr>

</table>