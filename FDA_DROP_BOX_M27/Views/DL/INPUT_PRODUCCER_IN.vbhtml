@Code
    ViewData("Title") = "INPUT_PRODUCCER_IN"
End Code

<table>
    <tr>
        <td></td>
        <td>เลขใบอนุญาต</td>
        <td>
            <input type="text" id="txt_NUM" />
        </td>
        <td style="width:25%;color:red">
            ตัวอย่าง กท 1/2563 และสามารถตรวจสอบเลขที่ใบอนุญาตจากหน้าเว็บ อย. ได้เลย (สำหรับ ผย8 ,ยบ8 และสำหรับทะเบียน 1A ,2A ,1B ,2B ,1D ,2D ,L และ M )
        </td>
    </tr>
    <tr>
        <td></td>
    </tr>
    <tr>
        <td colspan="4" style="text-align:center;">
            @*<asp:Button ID="btn_SEARCH" runat="server" Text="ค้นหา" CssClass="input-lg" />*@
            <input type="button" id="btn_search" value="ค้นหา" class="input-lg" />
        </td>

    </tr>
    <tr>
        <td colspan="4">


            <br />
            <p class="h3">ใบอนุญาต</p>
            <hr />
            //ตารางค้นหา
            @*<telerik:RadGrid ID="RadGrid1" runat="server" AllowPaging="true" PageSize="15" AllowFilteringByColumn="True">
                <MasterTableView AutoGenerateColumns="False">
                    <Columns>
                        <telerik:GridClientSelectColumn UniqueName="chk" HeaderText="เลือก">
                        </telerik:GridClientSelectColumn>
                        <telerik:GridBoundColumn DataField="IDA" DataType="System.Int32" FilterControlAltText="Filter IDA column" HeaderText="IDA"
                                                 SortExpression="IDA" UniqueName="IDA" Display="false" AllowFiltering="true">
                        </telerik:GridBoundColumn>
                        <telerik:GridBoundColumn DataField="lcnno_no" FilterControlAltText="Filter lcnno_no column"
                                                 HeaderText="เลขที่ใบอนุญาต" SortExpression="lcnno_no" UniqueName="lcnno_no">
                        </telerik:GridBoundColumn>
                        <telerik:GridBoundColumn DataField="lcntpcd" FilterControlAltText="Filter lcntpcd column"
                                                 HeaderText="ประเภท" SortExpression="lcntpcd" UniqueName="lcntpcd">
                        </telerik:GridBoundColumn>
                        <telerik:GridBoundColumn DataField="thanm" FilterControlAltText="Filter thanm column"
                                                 HeaderText="ชื่อสถานที่" SortExpression="thanm" UniqueName="thanm">
                        </telerik:GridBoundColumn>
                        <telerik:GridBoundColumn DataField="thanm_addr" FilterControlAltText="Filter thanm_addr column"
                                                 HeaderText="ที่อยู่" SortExpression="thanm_addr" UniqueName="thanm_addr">
                        </telerik:GridBoundColumn>

                    </Columns>
                </MasterTableView>
                <ClientSettings EnableRowHoverStyle="true">
                    <Selecting AllowRowSelect="true" />
                </ClientSettings>
            </telerik:RadGrid>*@
            <table style="width:100%;" class="table">
                <tr>
                    <td align="center">
                        &nbsp;<input type="button" id="btn_select" value="เลือก" class="input-lg" />
                    </td>
                </tr>
                <tr>
                    <td>
                        รายการผู้ผลิตที่เลือก
                    </td>
                </tr>
                <tr>
                    <td align="center">
                        //ตารางผู้ผลิต
                        @*<telerik:RadGrid ID="RadGrid2" runat="server" AllowPaging="true" PageSize="15" AllowFilteringByColumn="True">
                            <MasterTableView AutoGenerateColumns="False">
                                <Columns>
                                    <telerik:GridBoundColumn DataField="IDA" DataType="System.Int32" FilterControlAltText="Filter IDA column" HeaderText="IDA"
                                                             SortExpression="IDA" UniqueName="IDA" Display="false" AllowFiltering="true">
                                    </telerik:GridBoundColumn>
                                    <telerik:GridBoundColumn DataField="LCNNO_MANUAL" FilterControlAltText="Filter LCNNO_MANUAL column"
                                                             HeaderText="เลขที่ใบอนุญาต" SortExpression="LCNNO_MANUAL" UniqueName="LCNNO_MANUAL">
                                    </telerik:GridBoundColumn>
                                    <telerik:GridBoundColumn DataField="lcntpcd" FilterControlAltText="Filter lcntpcd column"
                                                             HeaderText="ประเภท" SortExpression="lcntpcd" UniqueName="lcntpcd">
                                    </telerik:GridBoundColumn>
                                    <telerik:GridBoundColumn DataField="fulladdr" FilterControlAltText="Filter fulladdr column"
                                                             HeaderText="ที่อยู่" SortExpression="fulladdr" UniqueName="fulladdr">
                                    </telerik:GridBoundColumn>
                                    <%--<telerik:GridBoundColumn DataField="PRODUCER_WORK_NAME" FilterControlAltText="Filter PRODUCER_WORK_NAME column"
                                                                 HeaderText="หน้าที่" SortExpression="PRODUCER_WORK_NAME" UniqueName="PRODUCER_WORK_NAME">
                                    </telerik:GridBoundColumn>--%>
                                    <telerik:GridTemplateColumn UniqueName="work_type" HeaderText="หน้าที่">
                                        <ItemTemplate>
                                            <telerik:RadComboBox ID="rcb_work_type" runat="server" Filter="Contains" Label="กรุณาเลือก" Width="200px">
                                                <Items>
                                                    <telerik:RadComboBoxItem runat="server" Text="ผลิตยาสำเร็จรูป" Value="1" />
                                                    <telerik:RadComboBoxItem runat="server" Text="แบ่งบรรจุ" Value="2" />
                                                    <telerik:RadComboBoxItem runat="server" Text="ตรวจปล่อยหรือผ่านเพื่อจำหน่าย" Value="3" />
                                                    <telerik:RadComboBoxItem runat="server" Text="อื่นๆ" Value="9" />
                                                    <telerik:RadComboBoxItem runat="server" Text="ผู้แบ่งบรรจุผลิตภัณฑ์ยาที่ไม่สัมผัสยา" Value="10" />
                                                    <telerik:RadComboBoxItem runat="server" Text="ผลิตยาสำเร็จรูป (แห่งที่ 2)" Value="11" />
                                                    <telerik:RadComboBoxItem runat="server" Text="แบ่งบรรจุผลิตภัณฑ์ยาที่ไม่สัมผัสยา (แห่งที่ 2)" Value="12" />
                                                    <telerik:RadComboBoxItem runat="server" Text="แบ่งบรรจุ (แห่งที่ 2)" Value="13" />
                                                    <telerik:RadComboBoxItem runat="server" Text="ตรวจปล่อยหรือผ่านเพื่อจำหน่าย (แห่งที่ 2)" Value="14" />
                                                </Items>
                                            </telerik:RadComboBox>
                                            <asp:Label ID="lbl_work_type" runat="server" Text="" style="display:none;"></asp:Label>
                                        </ItemTemplate>
                                    </telerik:GridTemplateColumn>
                                    <telerik:GridButtonColumn ButtonType="LinkButton" UniqueName="_del" HeaderText="ลบรายการ" ConfirmText="ต้องการลบหรือไม่?"
                                                              CommandName="_del" Text="ลบ">
                                        <HeaderStyle Width="70px" />
                                    </telerik:GridButtonColumn>
                                </Columns>
                            </MasterTableView>
                        </telerik:RadGrid>*@
                    </td>
                </tr>
                <tr>
                    <td align="center">
                        @*<asp:Button ID="btn_save_work_type" runat="server" Text="บันทึกหน้าที่ในตาราง" />*@
                        <input type="button" id="btn_save_work_type" value="บันทึกหน้าที่ในตาราง" class="input-lg" />
                    </td>
                </tr>
            </table>
</table>