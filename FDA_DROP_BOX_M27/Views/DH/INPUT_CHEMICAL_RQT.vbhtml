@*@Code
    Layout = ""
End Code*@

    <script src="~/Scripts_angular/ANGULAR_APP.js"></script>
    <script src="~/Scripts_angular/CENTER_SV.js"></script>
    <script src="~/Scripts_angular/DH_CTRL.js"></script>


    <div class="ic" ng-controller="DH_CTRL" ng-app="ANGULAR_APP" ng-init="loadmodel()">
        <h2>เพิ่มสาร</h2>
        <table class="table">
            <tr>
                <td width="30%">วันที่</td>
                <td>
                    <md-datepicker ng-model="LIST_CHEM.CHEMICAL_REQUEST.REQUEST_DATE" md-placeholder="Enter date"
                    input-aria-describedby="datepicker-description"
                    input-aria-labelledby="datepicker-header "></md-datepicker>
                </td>
            </tr>
            <tr>
                <td>ชื่อสาร</td>
                <td>
                    <input class="form-control inline"  ng-model="LIST_CHEM.CHEMICAL_REQUEST.iowanm" style="font-family:'TH SarabunPSK';font-size:20px;" type="text" />
                </td>
            </tr>
            <tr>
                <td>รายละเอียดเพิ่มเติม</td>
                <td>
                    <input class="form-control inline" style="font-family:'TH SarabunPSK';font-size:20px;" type="text"  ng-model="LIST_CHEM.CHEMICAL_REQUEST.DESCRIPTION_OTHER" />
                </td>
            </tr>
            <tr>
                <td>CAS NUMBER</td>
                <td>
                    <input class="form-control inline" style="font-family:'TH SarabunPSK';font-size:20px;" type="text" ng-model="LIST_CHEM.CHEMICAL_REQUEST.cas_number"/>
                </td>
            </tr>
            <tr>
                <td>INN</td>
                <td>
                    <input class="form-control inline" style="font-family:'TH SarabunPSK';font-size:20px;" type="text" ng-model="LIST_CHEM.CHEMICAL_REQUEST.INN"/>
                </td>
            </tr>
            <tr>
                <td>INN TH</td>
                <td>
                    <input class="form-control inline" style="font-family:'TH SarabunPSK';font-size:20px;" type="text" ng-model="LIST_CHEM.CHEMICAL_REQUEST.INN_TH"/>
                </td>
            </tr>
            <tr>
                <td>Email สำหรับติดต่อ</td>
                <td>
                    <input class="form-control inline" style="font-family:'TH SarabunPSK';font-size:20px;" type="text" ng-model="LIST_CHEM.CHEMICAL_REQUEST.EMAIL"/>
                </td>
            </tr>
            <tr>
                <td>เบอร์โทรศัพท์ติดต่อ</td>
                <td>
                    <input class="form-control inline" style="font-family:'TH SarabunPSK';font-size:20px;" type="text" ng-model="LIST_CHEM.CHEMICAL_REQUEST.TEL"/>
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
                                <td><asp:Button ID="btn_save" runat="server" Text="บันทึก" CssClass="btn-lg" /></td>
                                <td><asp:Button ID="btn_edit" runat="server" Text="แก้ไข" CssClass="btn-lg" /></td>
                                <td><asp:Button ID="btn_close" runat="server" Text="ปิดหน้าต่าง" CssClass="btn-lg" /></td>
                            </tr>
                        </table>

             

                    </div>



                </td>
            </tr>

        </table>
    </div>
<div>

</div>