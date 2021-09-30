@Code
    ViewData("Title") = "INPUT_ANIMAL"
End Code
<script src="~/Scripts_angular/CENTER_SV.js"></script>
<script src="~/Scripts_angular/DL_CTRL.js"></script>
<h2>INPUT_ANIMAL</h2>
<div class="ic" ng-controller="DL_CTRL" ng-app="ANGULAR_APP">
    <table>
        <tr>
            <td>ประเภทสัตว์ :</td>
            <td>
                <select class="form-control selectpicker" data-live-search="true" title="-- Please select --" style="font-family:'Taviraj';font-size:20px;" id="ddl_dramltype">
                    @*<option value="0">--กรุณาเลือก--</option>*@
                    <option ng-repeat="x in DRAMLTYPE_ALL" value="{{x.amltpcd}}">{{x.amltpnm}}</option>
                </select>
            </td>
            <td>
                ชนิดสัตว์ :
            </td>
            <td>
                <asp:DropDownList ID="ddl_dramlsubtp" runat="server"></asp:DropDownList>
            </td>
            <td>การใช้ :</td>
            <td>
                <asp:DropDownList ID="ddl_dramlusetp" runat="server"></asp:DropDownList>
            </td>
            <td>
                <asp:Button ID="btn_save" runat="server" Text="บันทึก" />
                <asp:Button ID="Button1" runat="server" Text="ยกเลิกแก้ไข" />
            </td>
        </tr>
    </table>
    <asp:HiddenField ID="HiddenField1" runat="server" />
    <br />
    <table width="100%">
        <tr>
            <td>
                <telerik:RadGrid ID="rgAnimals" runat="server" Width="100%">
                    <MasterTableView AutoGenerateColumns="False" DataKeyNames="IDA" NoMasterRecordsText="ไม่พบข้อมูล">
                        <Columns>
                            <telerik:GridBoundColumn DataField="H_IDA" DataType="System.Int32" FilterControlAltText="Filter H_IDA column" HeaderText="H_IDA"
                                                     SortExpression="H_IDA" UniqueName="H_IDA" Display="false">
                            </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="amltpnm" FilterControlAltText="Filter amltpnm column" HeaderText="ประเภทสัตว์"
                                                     SortExpression="amltpnm" UniqueName="amltpnm" Display="false">
                            </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="amlsubnm" FilterControlAltText="Filter amlsubnm column"
                                                     HeaderText="ชนิดสัตว์" SortExpression="amlsubnm" UniqueName="amlsubnm">
                            </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="usetpnm" FilterControlAltText="Filter usetpnm column" HeaderText="การใช้" SortExpression="usetpnm" UniqueName="usetpnm">
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
                </telerik:RadGrid>
            </td>
        </tr>
    </table>
    </div>