
<script src="~/Scripts_angular/ANGULAR_APP.js"></script>
<script src="~/Scripts_angular/CENTER_SV.js"></script>
<script src="~/Scripts_angular/DH_CTRL.js"></script>


<div class="ic" ng-controller="DH_CTRL" ng-app="ANGULAR_APP" ng-init="loadmodel()">
    <h2>เพิ่มสาร</h2>
    <table class="table" style="font-family:'Taviraj';font-size:20px">
        <tr>
            <td width="30%">วันที่ (Date)</td>
            <td>
                {{DATA_CHEM.REQUEST_DATE}}
            </td>
        </tr>
        <tr>
            <td>ชื่อสาร (Substance Name)</td>
            <td>
                @*<input class="form-control inline" ng-model="DATA_CHEM.iowanm" style="font-family:'Taviraj';font-size:20px;" type="text" />*@
                {{DATA_CHEM.iowanm}}
            </td>
        </tr>
        <tr>
            <td>รายละเอียดเพิ่มเติม (Additional Information)</td>
            <td>
                @*<input class="form-control inline" ng-model="DATA_CHEM.DESCRIPTION_OTHER" style="font-family:'Taviraj';font-size:20px;" type="text" />*@
                {{DATA_CHEM.DESCRIPTION_OTHER}}
            </td>
        </tr>
        <tr>
            <td>CAS NUMBER</td>
            <td>
                @*<input class="form-control inline" ng-model="DATA_CHEM.cas_number" style="font-family:'Taviraj';font-size:20px;" type="text" />*@
                {{DATA_CHEM.cas_number}}
            </td>
        </tr>
        <tr>
            <td>INN</td>
            <td>
                @*<input class="form-control inline" ng-model="DATA_CHEM.INN" style="font-family:'Taviraj';font-size:20px;" type="text" />*@
                {{DATA_CHEM.INN}}
            </td>
        </tr>
        <tr>
            <td>INN TH</td>
            <td>
                @*<input class="form-control inline" ng-model="DATA_CHEM.INN_TH" style="font-family:'Taviraj';font-size:20px;" type="text" />*@
                {{DATA_CHEM.INN_TH}}
            </td>
        </tr>
        <tr>
            <td>Email สำหรับติดต่อ (Email Address)</td>
            <td>
                @*<input class="form-control inline" ng-model="DATA_CHEM.EMAIL" style="font-family:'Taviraj';font-size:20px;" type="text" />*@
                {{DATA_CHEM.EMAIL}}
            </td>
        </tr>
        <tr>
            <td>เบอร์โทรศัพท์ติดต่อ (Phone Number)</td>
            <td>
                @*<input class="form-control inline" ng-model="DATA_CHEM.TEL" style="font-family:'Taviraj';font-size:20px;" type="text" />*@
                {{DATA_CHEM.TEL}}
            </td>
        </tr>
        <tr>
            <td>แนบเอกสารเพิ่มเติม (Attached Files)</td>
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
    </table>
    <br />
    <br />
    <div>
        <div class="col-sm-12" style="text-align:center">
            <input type="button" ID="btn_save" class="btn btn-lg" style="background-color:#38A86B;color:white" value="บันทึก (Save)" ng-click="" />
            <input type="button" ID="btn_edit" class="btn btn-lg" value="แก้ไข (Edit)" ng-click="" />
            <input type="button" ID="btn_close" class="btn btn-lg" style="background-color:#FFD700" value="ปิดหน้าต่าง (Close)" ng-click="" />
        </div>
    </div>
</div>
