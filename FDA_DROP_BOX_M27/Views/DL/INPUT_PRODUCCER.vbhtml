@Code
    ViewData("Title") = "INPUT_PRODUCCER"
End Code
<script src="~/Scripts_angular/ANGULAR_APP.js"></script>
<script src="~/Scripts_angular/CENTER_SV.js"></script>
<script src="~/Scripts_angular/DL_CTRL.js"></script>

<script type="text/javascript">
    $(document).ready(function () {
        $('select').selectpicker('refresh');
    })
</script>

<div class="ic" ng-controller="DL_CTRL" ng-app="ANGULAR_APP">
    <table style="width:100%;" class="table">
        <tr>
            <td>
                ชื่อผู้ผลิตต่างประเทศ :
                <input type="text" class="form-control" id="txt_search" style="width:300px;" />
                &nbsp;
                ประเทศ
                @*<select id="ddl_national">
                        <option>กรุณาเลือก</option>
                    </select>*@
                <select id="ddl_national" style="width:100px;" class="form-control selectpicker" data-live-search="true" title="-- Please select --">
                    <option ng-repeat="x in CNT_LIST" value="{{x.alpha3}}">{{x.engcntnm}}</option>
                </select>
                &nbsp;
                <input type="button" id="btn_search" value="ค้นหา" class="input-lg" />
                <input type="button" id="btn_rqt" value="การขอเพิ่มชื่อผู้ผลิต ฯ" class="input-lg" onclick="alert('ส่งเมลไปที่ drug-Smarthelp@fda.moph.go.th หรือ แนบ cpp \nหรือ gmp เพื่อประกอบการเพิ่มชื่อ/ที่อยู่ผู้ผลิตต่างประเทศ ');" />
            </td>

        </tr>
        <tr>
            <td style="color:red">หมายเหตุ ท่านสามารถพิมพ์บางส่วนของคำ หรือบางส่วนของชื่อ เพื่อช่วยในการค้นหา (สำหรับ นย8 ยบ8 และทะเบียน 1C ,2C ,1F ,2F ,N)</td>
        </tr>
        <tr>
            <td>
                //ตารางค้นหาผู้ผลิต
                @*<telerik:RadGrid ID="rg_search_fore" runat="server" AllowPaging="true" PageSize="10">
                        <MasterTableView autogeneratecolumns="False">
                            <Columns>
                                <telerik:GridClientSelectColumn UniqueName="chk" HeaderText="เลือก">
                                </telerik:GridClientSelectColumn>
                                <telerik:GridBoundColumn DataField="IDA" FilterControlAltText="Filter IDA column" HeaderText="IDA" SortExpression="IDA" UniqueName="IDA" Display="false">
                                </telerik:GridBoundColumn>
                                <telerik:GridBoundColumn DataField="alpha3" FilterControlAltText="Filter alpha3 column" HeaderText="alpha3" SortExpression="alpha3" UniqueName="alpha3" Display="false">
                                </telerik:GridBoundColumn>
                                <telerik:GridBoundColumn DataField="engfrgnnm" FilterControlAltText="Filter engfrgnnm column" HeaderText="ชื่อผู้ผลิต" SortExpression="engfrgnnm" UniqueName="engfrgnnm">
                                </telerik:GridBoundColumn>
                                <telerik:GridBoundColumn DataField="fulladdr2" FilterControlAltText="Filter fulladdr2 column" HeaderText="ที่อยู่" SortExpression="fulladdr2" UniqueName="fulladdr2">
                                </telerik:GridBoundColumn>
                                <telerik:GridBoundColumn DataField="frgnlctcd" FilterControlAltText="Filter frgnlctcd column" HeaderText="frgnlctcd" SortExpression="frgnlctcd" UniqueName="frgnlctcd" Display="false">
                                </telerik:GridBoundColumn>
                                <telerik:GridBoundColumn DataField="frgncd" FilterControlAltText="Filter frgncd column" HeaderText="frgncd" SortExpression="frgncd" UniqueName="frgncd" Display="false">
                                </telerik:GridBoundColumn>
                                <telerik:GridBoundColumn DataField="addr_ida" FilterControlAltText="Filter addr_ida column" HeaderText="addr_ida" SortExpression="addr_ida" UniqueName="addr_ida" Display="false">
                                </telerik:GridBoundColumn>

                                <telerik:GridBoundColumn DataField="fulladdr2" FilterControlAltText="Filter fulladdr2 column" HeaderText="ที่อยู่" SortExpression="fulladdr2" UniqueName="fulladdr2" Display="false">
                                </telerik:GridBoundColumn>


                            </Columns>
                        </MasterTableView>
                        <ClientSettings EnableRowHoverStyle="true">
                            <Selecting AllowRowSelect="true" />
                        </ClientSettings>
                    </telerik:RadGrid>*@
            </td>
        </tr>
    </table>

    <table style="width:100%;" class="table">
        <tr>
            <td align="center">
                <input type="button" id="btn_select" value="เลือก" class="input-lg" />
            </td>
        </tr>
    </table>

    <table style="width:100%;" class="table">
        <tr>
            <td>
                //ตารางที่เพิ่มผู้ผลิตแล้ว
                @*<telerik:RadGrid ID="rg_produccer" runat="server" Width="100%">
                        <MasterTableView AutoGenerateColumns="False" DataKeyNames="IDA" NoMasterRecordsText="ไม่พบข้อมูล">
                            <Columns>
                                <telerik:GridBoundColumn DataField="IDA" FilterControlAltText="Filter IDA column" HeaderText="IDA" SortExpression="IDA" UniqueName="IDA" Display="false">
                                </telerik:GridBoundColumn>
                                <telerik:GridBoundColumn DataField="P_IDA" FilterControlAltText="Filter P_IDA column" HeaderText="P_IDA" SortExpression="P_IDA" UniqueName="P_IDA" Display="false">
                                </telerik:GridBoundColumn>

                                <telerik:GridBoundColumn DataField="engfrgnnm" FilterControlAltText="Filter engfrgnnm column" HeaderText="ชื่อผู้ผลิต" SortExpression="engfrgnnm" UniqueName="engfrgnnm">
                                </telerik:GridBoundColumn>
                                <telerik:GridBoundColumn DataField="frgnlctcd" FilterControlAltText="Filter frgnlctcd column" HeaderText="frgnlctcd" SortExpression="frgnlctcd" UniqueName="frgnlctcd" Display="false">
                                </telerik:GridBoundColumn>
                                <telerik:GridBoundColumn DataField="addr_ida" FilterControlAltText="Filter addr_ida column" HeaderText="addr_ida" SortExpression="addr_ida" UniqueName="addr_ida" Display="false">
                                </telerik:GridBoundColumn>

                                <telerik:GridBoundColumn DataField="fulladdr" FilterControlAltText="Filter fulladdr column" HeaderText="ที่อยู่" SortExpression="fulladdr" UniqueName="fulladdr">
                                </telerik:GridBoundColumn>
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
                <input type="button" id="btn_save_work_type" value="บันทึกหน้าที่ในตาราง" class="input-lg" />
            </td>
        </tr>
    </table>
</div>
