@Code
    Layout = ""
End Code

<div class="panel" style="width:100%">
    <div class="panel-heading panel-title">
        <h1>ระบุเลขรับ</h1>
    </div>
    <div class="panel-body">

        <table class="table">
            <tr>
                <td>เลขรับคำขอ/เลขตรวจคำขอ</td>
                <td>
               
                    <input type="text" ng-model="LIST_LCN.dalcn.TEMPORARY_RCVNO" />
                </td>
            </tr>

            <tr>
                <td>เลขรับ</td>
                <td>
                    <asp:TextBox ID="Txt_rcvno" runat="server" CssClass="input-lg"></asp:TextBox>
                    <input type="text" ng-model="LIST_LCN.dalcn.RCVNO_MANUAL" />
                </td>
            </tr>

            <tr>
                <td>วันที่</td>
                <td>
                    <md-datepicker ng-model="LIST_LCN.dalcn.rcvdate" md-placeholder="Enter date"
                                   input-aria-describedby="datepicker-description"
                                   input-aria-labelledby="datepicker-header "></md-datepicker>
                </td>
            </tr>


            <tr>
                <td>จนท.ผู้รับคำขอ</td>
                <td>
   
                    {{LIST_LCN.NAMESTAFF}}
                </td>
            </tr>

            @*<tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="รูปแบบเอกสาร" style="display:none;"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddl_template" runat="server" Width="80%" style="display:none;">
                        <asp:ListItem Value="1">แบบปกติ</asp:ListItem>
                        <asp:ListItem Value="2">แบบยาว</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>*@
        </table>
    </div>
    <div class="panel-footer " style="text-align:center;">
        <div class="panel-footer">

            <input type="button" class="btn btn-lg " ng-click="BTN_SAVE_LCN_RCV_TEMP()" value="บันทึก" />

            <input type="button" class="btn btn-lg " ng-click="" value="ย้อนกลับ" />
        </div>
    </div>
</div>