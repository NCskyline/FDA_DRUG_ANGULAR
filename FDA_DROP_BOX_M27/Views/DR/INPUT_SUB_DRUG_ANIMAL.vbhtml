@Code
    ViewData("Title") = "INPUT_SUB_DRUG_ANIMAL"
End Code

<table>
    <tr>
        <td>ส่วนบริโภค :&nbsp;</td>
        <td colspan="4">
            <select ID="ddl_dramlpart">
                <option>กรุณาเเลือก</option>
            </select>
        </td>

    </tr>
    <tr>
        <td>ระยะหยุดยา :</td>
        <td>
            <input type="text" id="txt_STOP_VALUE1" />
        </td>

        <td>
            <select ID="ddl_STOP_UNIT1">
                <option value="1">ชั่วโมง</option>
                <option value="2">วัน</option>
            </select>
        </td>

        <td>
           
        </td>

        <td>
           
        </td>

    </tr>
    
    <tr>
        <td>ขนาดและวิธีการใช้ :</td>
        <td colspan="4">
            <input type="text" id="txt_packuse" />
            <label ID="lbl_sunit_ida"></label>
        </td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td colspan="4">
            <input type="button" ID="btn_save" value="บันทึก" />
            <input type="button" ID="btn_edit" value="แก้ไข" />
            <input type="button" ID="btn_cancel" value="ยกเลิกแก้ไข" />
        </td>
    </tr>
</table>
<br />
<table width="100%">
    <tr>
        <td>
            //ตารางสัตว์
            @*<telerik:RadGrid ID="rgAnimals" runat="server" Width="100%">
                <MasterTableView AutoGenerateColumns="False" DataKeyNames="IDA" NoMasterRecordsText="ไม่พบข้อมูล">
                    <Columns>
                        <telerik:GridBoundColumn DataField="IDA" DataType="System.Int32" FilterControlAltText="Filter IDA column" HeaderText="IDA"
                                                 SortExpression="IDA" UniqueName="IDA" Display="false">
                        </telerik:GridBoundColumn>
                        <telerik:GridBoundColumn DataField="ampartnm" FilterControlAltText="Filter ampartnm column" HeaderText="ส่วนบริโภค"
                                                 SortExpression="ampartnm" UniqueName="ampartnm">
                        </telerik:GridBoundColumn>
                        <telerik:GridBoundColumn DataField="stpdrg" FilterControlAltText="Filter stpdrg column"
                                                 HeaderText="ระยะหยุดยา" SortExpression="stpdrg" UniqueName="stpdrg">
                        </telerik:GridBoundColumn>
                        <telerik:GridBoundColumn DataField="packuse" FilterControlAltText="Filter packuse column" HeaderText="ขนาดและวิธีการใช้" SortExpression="packuse" UniqueName="packuse">
                        </telerik:GridBoundColumn>
                        <telerik:GridButtonColumn UniqueName="edt" ButtonType="LinkButton" Text="แก้ไขข้อมูล" CommandName="edt">
                        </telerik:GridButtonColumn>
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
        </td>
    </tr>
</table>