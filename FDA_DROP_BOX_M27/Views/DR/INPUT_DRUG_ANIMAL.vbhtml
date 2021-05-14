@Code
    ViewData("Title") = "INPUT_DRUG_ANIMAL"
End Code

<h2>INPUT_DRUG_ANIMAL</h2>

<table>
    <tr>
        <td>ประเภทสัตว์ :</td>
        <td>
            <select id="ddl_dramltype">
                <option>กรุณาเลือก</option>
            </select>
        </td>
        <td>
            ชนิดสัตว์ :
        </td>
        <td>
            <select id="ddl_dramlsubtp">
                <option>กรุณาเลือก</option>
            </select>
        </td>
        <td>การใช้ :</td>
        <td>
            <select id="ddl_dramlusetp">
                <option>กรุณาเลือก</option>
            </select>
        </td>
        <td>
            <input type="button" ID="btn_save" value="บันทึก" />
            <input type="button" ID="Button1" value="ยกเลิกแก้ไข" />
        </td>
    </tr>
</table>
<label id="HiddenField1" style="display:none;"></label>
<label id="HiddenField2" style="display:none;"></label>
<br />
<table width="100%">
    <tr>
        <td>
            //ตารางเพิ่มชนิดสัตว์
            @*<telerik:RadGrid ID="rgAnimals" runat="server" Width="100%">
                <MasterTableView AutoGenerateColumns="False" DataKeyNames="H_IDA" NoMasterRecordsText="ไม่พบข้อมูล">
                    <Columns>
                        <telerik:GridBoundColumn DataField="H_IDA" DataType="System.Int32" FilterControlAltText="Filter H_IDA column" HeaderText="H_IDA"
                                                 SortExpression="H_IDA" UniqueName="H_IDA" Display="false">
                        </telerik:GridBoundColumn>
                        <telerik:GridBoundColumn DataField="SUB_IDA" DataType="System.Int32" FilterControlAltText="Filter SUB_IDA column" HeaderText="SUB_IDA"
                                                 SortExpression="SUB_IDA" UniqueName="SUB_IDA" Display="false">
                        </telerik:GridBoundColumn>
                        <%--<telerik:GridBoundColumn DataField="amltpnm" FilterControlAltText="Filter amltpnm column" HeaderText="ชนิดสัตว์"
                                                     SortExpression="amltpnm" UniqueName="amltpnm" Display="false">
                        </telerik:GridBoundColumn>--%>
                        <telerik:GridBoundColumn DataField="amltpnm" FilterControlAltText="Filter amltpnm column" HeaderText="ประเภทสัตว์"
                                                 SortExpression="amltpnm" UniqueName="amltpnm">
                        </telerik:GridBoundColumn>
                        <telerik:GridBoundColumn DataField="amlsubnm" FilterControlAltText="Filter amlsubnm column"
                                                 HeaderText="ชนิดสัตว์" SortExpression="amlsubnm" UniqueName="amlsubnm">
                        </telerik:GridBoundColumn>
                        <telerik:GridBoundColumn DataField="usetpnm" FilterControlAltText="Filter usetpnm column" HeaderText="การใช้" SortExpression="usetpnm" UniqueName="usetpnm">
                        </telerik:GridBoundColumn>
                        <telerik:GridBoundColumn DataField="stpdrgnm" FilterControlAltText="Filter stpdrgnm column" HeaderText="ระยะหยุดยา" SortExpression="stpdrgnm" UniqueName="stpdrgnm">
                        </telerik:GridBoundColumn>
                        <telerik:GridBoundColumn DataField="ampartnm" FilterControlAltText="Filter ampartnm column" HeaderText="ส่วนบริโภค" SortExpression="ampartnm" UniqueName="ampartnm">
                        </telerik:GridBoundColumn>
                        <telerik:GridBoundColumn DataField="packuse" FilterControlAltText="Filter packuse column" HeaderText="ขนาดและวิธีใช้" SortExpression="packuse" UniqueName="packuse">
                        </telerik:GridBoundColumn>

                        <telerik:GridButtonColumn ButtonType="LinkButton" UniqueName="_edt" HeaderText="แก้ไข"
                                                  CommandName="_edt" Text="แก้ไข">
                            <HeaderStyle Width="70px" />
                        </telerik:GridButtonColumn>
                        <telerik:GridButtonColumn ButtonType="LinkButton" UniqueName="_del" HeaderText="ลบรายการ" ConfirmText="ต้องการลบหรือไม่?"
                                                  CommandName="_del" Text="ลบ">
                            <HeaderStyle Width="70px" />
                        </telerik:GridButtonColumn>
                        <telerik:GridButtonColumn ButtonType="LinkButton" UniqueName="_sel" HeaderText="ส่วนบริโภค"
                                                  CommandName="_sel" Text="ส่วนบริโภค">
                            <HeaderStyle Width="70px" />
                        </telerik:GridButtonColumn>
                    </Columns>
                </MasterTableView>
            </telerik:RadGrid>*@
        </td>
    </tr>
</table>