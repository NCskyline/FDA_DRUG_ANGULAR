﻿@Code
    ViewData("Title") = "INPUT_DTB"
End Code

<div>
    <div class="ic">
        <table class="table" style="width:100%;">
            <tr>
                <td style="width:25%;"></td>
                <td style="width:25%;">เลขใบอนุญาต</td>
                <td style="width:25%;">
                    <input type="text" id="txt_NUM" />
                </td>
                <td style="width:25%;"></td>
            </tr>
            <tr>
                <td colspan="4" style="text-align:center;">
                    <input type="button" ID="btn_SEARCH" value="ค้นหา" />
                </td>

            </tr>
            <tr>
                <td colspan="4">


                    <br />
                    <p class="h3">ใบอนุญาต</p>
                    <hr />
                    //ตาราง
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
                                <telerik:GridBoundColumn DataField="thanm_addr" FilterControlAltText="Filter thanm_addr column"
                                                         HeaderText="ที่อยู่" SortExpression="thanm_addr" UniqueName="thanm_addr">
                                </telerik:GridBoundColumn>
                                <telerik:GridBoundColumn DataField="lcnsid" FilterControlAltText="Filter lcnsid column"
                                                         HeaderText="รหัสผู้ประกอบการ" SortExpression="lcnsid" UniqueName="lcnsid">
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
                                <input type="button" ID="btn_select" value="เลือก" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                รายการผู้แทนจำหน่าย
                            </td>
                        </tr>
                        <tr>
                            <td align="center">
                                //ตาราง
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
