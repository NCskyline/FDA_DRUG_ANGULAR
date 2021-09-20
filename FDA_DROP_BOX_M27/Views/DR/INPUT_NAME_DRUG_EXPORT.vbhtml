@Code
    ViewData("Title") = "INPUT_NAME_DRUG_EXPORT"
End Code


<div>
    <div class="ic">
        <table class="table" style="width: 100%;">
            <tr>
                <td>


                    <table style="width: 100%;" class="table">
                        <tr>
                            <td align="right" width="20%">
                                ชื่อยาเพื่อการส่งออก&nbsp;
                            </td>
                            <td width="20%">
                                <input type="text" ID="TextBox1" style="width:100%" />
                            </td>
                            <td align="right" width="20%">ประเทศ</td>
                            <td width="20%">
                                <select ID="DropDownList1">
                                    <option>กรุณาเเลือก</option>
                                </select>
                            </td>
                            <td width="20%">
                                <input type="button" ID="btn_save" value="บันทึก" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="5">รายการผู้ผลิตที่เลือก</td>
                        </tr>
                        <tr>
                            <td align="center" colspan="5">
                                //ตาราง
                                @*<telerik:RadGrid ID="RadGrid2" runat="server" AllowPaging="true" PageSize="15" AllowFilteringByColumn="True">
                                    <MasterTableView AutoGenerateColumns="False">
                                        <Columns>
                                            <telerik:GridBoundColumn DataField="IDA" DataType="System.Int32" FilterControlAltText="Filter IDA column" HeaderText="IDA"
                                                                     SortExpression="IDA" UniqueName="IDA" Display="false" AllowFiltering="true">
                                            </telerik:GridBoundColumn>
                                            <telerik:GridBoundColumn DataField="DRUG_NAME" FilterControlAltText="Filter DRUG_NAME column"
                                                                     HeaderText="ชื่อยาเพื่อการส่งออก" SortExpression="DRUG_NAME" UniqueName="DRUG_NAME">
                                            </telerik:GridBoundColumn>
                                            <telerik:GridBoundColumn DataField="engcntnm" FilterControlAltText="Filter engcntnm column"
                                                                     HeaderText="ประเทศ" SortExpression="engcntnm" UniqueName="engcntnm">
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
                    </table>
        </table>
    </div>
</div>
