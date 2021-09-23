@Code
    ViewData("Title") = "INPUT_ATC"
End Code

<table width="100%">
    <tr>
        <td>
            <table>
                <tr>
                    <td>
                        รหัส atc
                    </td>
                    <td>
                        <input type="text" id="txt_search" />
                    </td>
                    <td>
                        ชื่อกลุ่มตำรับ
                    </td>
                    <td>
                        <input type="text" class="form-control" id="txt_atc_name" />
                    </td>
                    <td>
                        <input type="button" id="btn_search" value="ค้นหากลุ่มตำรับ" />
                    </td>
                </tr>
            </table>


        </td>
        <td>

        </td>
        <td>
            &nbsp;
        </td>
    </tr>
    <tr>
        <td colspan="3">
            //ตาราง ATC ที่ค้นหามาได้
            @*<telerik:RadGrid ID="rg_atc_search" runat="server" AllowPaging="true" PageSize="10">
                <MasterTableView autogeneratecolumns="False">
                    <Columns>
                        <telerik:GridClientSelectColumn HeaderText="เลือก" UniqueName="chk">
                        </telerik:GridClientSelectColumn>
                        <telerik:GridBoundColumn DataField="IDA" FilterControlAltText="Filter IDA column" HeaderText="IDA" SortExpression="IDA" UniqueName="IDA" Display="false">
                        </telerik:GridBoundColumn>
                        <telerik:GridBoundColumn DataField="atc_code" FilterControlAltText="Filter atc_code column" HeaderText="ATC Code" SortExpression="atc_code" UniqueName="atc_code" Display="false">
                        </telerik:GridBoundColumn>
                        <telerik:GridBoundColumn DataField="atcnm" FilterControlAltText="Filter atcnm column" HeaderText="ชื่อกลุ่มตำรับ" SortExpression="atcnm" UniqueName="atcnm">
                        </telerik:GridBoundColumn>
                    </Columns>
                </MasterTableView>
                <ClientSettings EnableRowHoverStyle="true">
                    <Selecting AllowRowSelect="true" />
                </ClientSettings>
            </telerik:RadGrid>*@
        </td>
    </tr>
    <tr>
        <td colspan="3" style="text-align: center">
            <input type="button" id="btn_atc" value="เพิ่มกลุ่มตำรับ" />
        </td>
    </tr>
    <tr>
        <td colspan="3">
            //ตาราง atc ที่เพิ่ม
            @*<telerik:RadGrid ID="RadGrid2" runat="server" AutoGenerateColumns="false" GridLines="None" ShowFooter="true" Width="100%">
                <MasterTableView>
                    <Columns>
                        <telerik:GridBoundColumn DataField="RowNumber" HeaderText="ลำดับ" UniqueName="RowNumber">
                        </telerik:GridBoundColumn>
                        <telerik:GridBoundColumn DataField="IDA" Display="false" HeaderText="IDA" UniqueName="IDA">
                        </telerik:GridBoundColumn>
                        <telerik:GridBoundColumn DataField="FK_IDA" Display="false" HeaderText="FK_IDA" UniqueName="FK_IDA">
                        </telerik:GridBoundColumn>
                        <telerik:GridBoundColumn DataField="atccd" HeaderText="รหัส" UniqueName="atccd">
                        </telerik:GridBoundColumn>
                        <telerik:GridBoundColumn DataField="atcnm" HeaderText="กลุ่มตำรับ" UniqueName="atcnm">
                        </telerik:GridBoundColumn>
                        <telerik:GridButtonColumn ButtonType="LinkButton" CommandName="del" Text="ลบข้อมูล" UniqueName="del" ConfirmText="ต้องการลบข้อมูลหรือไม่?">
                        </telerik:GridButtonColumn>
                    </Columns>
                </MasterTableView>
            </telerik:RadGrid>*@
        </td>
    </tr>
</table>
