@Code
    ViewData("Title") = "INPUT_EQTO"
End Code


<div>
    <div class="ic">
        <table width="70%">

            <tr>
                <td>
                    สูตร :
                    <label ID="lbl_cas"></label>
                </td>
            </tr>

            <tr>
                <td>
                    <input type="text" id="txt_search" /><input type="button" ID="btn_search" value="ค้นหาสาร" />
                </td>
            </tr>
            <tr>
                <td>
                    //ตารางค้นหาสาร
                    @*<telerik:RadGrid ID="rg_search_iowa" runat="server" AllowPaging="true" PageSize="10">
                        <MasterTableView autogeneratecolumns="False">
                            <Columns>
                                <telerik:GridClientSelectColumn UniqueName="chk" HeaderText="เลือก">
                                </telerik:GridClientSelectColumn>
                                <telerik:GridBoundColumn DataField="iowacd" FilterControlAltText="Filter iowacd column" HeaderText="iowacd" SortExpression="iowacd" UniqueName="iowacd">
                                </telerik:GridBoundColumn>
                                <telerik:GridBoundColumn DataField="iowanm" FilterControlAltText="Filter iowanm column" HeaderText="ชื่อสาร" SortExpression="iowanm" UniqueName="iowanm">
                                </telerik:GridBoundColumn>
                                <%--                        <telerik:GridBoundColumn DataField="aori" FilterControlAltText="Filter aori column" HeaderText="aori" SortExpression="aori" UniqueName="aori">
                                </telerik:GridBoundColumn>--%>
                            </Columns>
                        </MasterTableView>
                        <ClientSettings EnableRowHoverStyle="true">
                            <Selecting AllowRowSelect="true" />
                        </ClientSettings>
                    </telerik:RadGrid>*@

                </td>
            </tr>

            <tr>
                <td align="center">
                    <table width="800px">
                        <tr>
                            <td align="left" colspan="4">&nbsp;</td>
                        </tr>
                        <tr>
                            <td align="left" colspan="4">กรุณาเลือกสารจากตารางด้านบนก่อนคลิกปุ่มเพิ่มสาร</td>
                        </tr>
                        <tr>
                            <td>ปริมาณยา: </td>
                            <td>
                                <input type="text" id="txt_QTY" style="width:100px;" />
                            </td>
                            <td>หน่วย :</td>
                            <td>
                                <select id="ddl_unit">
                                    <option>กรุณาเลือก</option>
                                </select>
                            </td>


                        </tr>
                        <tr>
                            <td>ปริมาณสุดท้าย :</td>
                            <td>
                                <input type="text" id="txt_QTY_END" />
                            </td>
                            <td>หน่วย :</td>
                            <td>
                                <select id="ddl_unit_end">
                                    <option>กรุณาเลือก</option>
                                </select>
                            </td>


                        </tr>
                        <tr>
                            <td>
                                ตัวคูณ :
                            </td>
                            <td>
                                <input type="text" id="txt_mulyiply" />
                            </td>
                            <td>
                                ค่าความแรง :
                            </td>
                            <td>
                                <input type="text" id="txt_str" />
                            </td>
                        </tr>
                        <tr>
                            <td>เอกสารอ้างอิง</td>
                            <td align="left" colspan="3">
                                <input type="text" id="txt_ref" style="width:100%;" />
                            </td>
                        </tr>
                        <tr>
                            <td>หมายเหตุ</td>
                            <td align="left" colspan="3">
                                <input type="text" id="txt_remark" style="width:100%;" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                ประเภทสาร A/I :
                            </td>
                            <td>
                                <select id="ddl_aori">
                                    <option>A</option>
                                    <option>I</option>
                                </select>
                            </td>
                            <td>
                                &nbsp;
                            </td>
                            <td>

                                &nbsp;
                            </td>
                        </tr>
                        <tr>
                            <td colspan="4">
                                <input type="button" ID="btn_select" value="เพิ่มสาร" />
                            </td>
                        </tr>
                    </table>



                </td>
            </tr>

            <tr>
                <td>
                    //ตารางสาร
                    @*<telerik:RadGrid ID="rg_chem" runat="server" Width="100%">
                        <MasterTableView AutoGenerateColumns="False" DataKeyNames="IDA" NoMasterRecordsText="ไม่พบข้อมูล">
                            <Columns>
                                <telerik:GridBoundColumn DataField="IDA" DataType="System.Int32" FilterControlAltText="Filter IDA column" HeaderText="IDA"
                                                         SortExpression="IDA" UniqueName="IDA" Display="false">
                                </telerik:GridBoundColumn>
                                <telerik:GridBoundColumn DataField="ROWS" FilterControlAltText="Filter ROWS column" HeaderText="ลำดับ"
                                                         SortExpression="ROWS" UniqueName="ROWS" Display="false">
                                </telerik:GridBoundColumn>
                                <telerik:GridTemplateColumn UniqueName="ROWS" HeaderText="ลำดับ">
                                    <ItemTemplate>
                                        <asp:TextBox ID="txt_rows" runat="server" Width="20px"></asp:TextBox>
                                        <asp:Label ID="lbl_rows" runat="server" Text="" style="display:none;"></asp:Label>
                                    </ItemTemplate>
                                </telerik:GridTemplateColumn>
                                <telerik:GridBoundColumn DataField="iowanm" FilterControlAltText="Filter iowanm column"
                                                         HeaderText="ชื่อสาร" SortExpression="iowanm" UniqueName="iowanm">
                                </telerik:GridBoundColumn>
                                <telerik:GridBoundColumn DataField="QTY" FilterControlAltText="Filter QTY column" HeaderText="ปริมาณ" DataType="System.Decimal" SortExpression="QTY" UniqueName="QTY">
                                </telerik:GridBoundColumn>
                                <telerik:GridBoundColumn DataField="REF" FilterControlAltText="Filter REF column" HeaderText="เอกสารอ้างอิง" SortExpression="REF" UniqueName="REF">
                                </telerik:GridBoundColumn>
                                <telerik:GridBoundColumn DataField="AORI" FilterControlAltText="Filter AORI column" HeaderText="A/I" SortExpression="AORI" UniqueName="AORI">
                                </telerik:GridBoundColumn>
                                <telerik:GridBoundColumn DataField="REMARK" FilterControlAltText="Filter REMARK column" HeaderText="หมายเหตุ" SortExpression="REMARK" UniqueName="REMARK">
                                </telerik:GridBoundColumn>
                                <telerik:GridBoundColumn DataField="sunitengnm" FilterControlAltText="Filter sunitengnm column" HeaderText="หน่วย" SortExpression="sunitengnm" UniqueName="AORI">
                                </telerik:GridBoundColumn>

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
                    <input type="button" ID="btn_back" value="ย้อนกลับ" />
                    <input type="button" ID="btn_rows_save" value="บันทึกลำดับ" />
                </td>
            </tr>

        </table>
    </div>
</div>
