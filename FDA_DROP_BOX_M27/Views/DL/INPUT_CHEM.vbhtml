@Code
    ViewData("Title") = "INPUT_CHEM"
End Code

<script src="~/Scripts_angular/CENTER_SV.js"></script>
<script src="~/Scripts_angular/DL_CTRL.js"></script>
<div class="ic" ng-controller="DL_CTRL" ng-app="ANGULAR_APP">

    <table width="70%">
        <tr>
            <td style="background-color:#FFCE33">1.1 โปรดระบุ unit of formular composition</td>
        </tr>
        <tr>
            <td>
                ระบุปริมาณที่ใช้เป็น 1 หน่วย
            </td>
        </tr>

        <tr>
            <td>
                <table>
                    <tr>

                        <td>สูตรที่</td>
                        <td>
                            <select ID="ddl_each_no">
                                <option>1</option>
                                <option>2</option>
                                <option>3</option>
                                <option>4</option>
                                <option>5</option>
                                <option>6</option>
                                <option>7</option>
                                <option>8</option>
                                <option>9</option>
                                <option>10</option>
                            </select>

                        </td>
                        <td>
                            Each
                        </td>
                        <td>

                            <input type="text" ID="txt_each" />
                        </td>
                        <td>
                            <select class="dropdown" id="ddl_unit">
                                <option ng-repeat="x in UNIT_PHYSIC" value="{{x.sunitcd}}">{{x.unit_name}}</option>
                            </select>
                        </td>
                        <td>Contains</td>
                    </tr>
                    <tr>
                        <td>
                            &nbsp;
                        </td>
                        <td>
                            <input type="text" ID="txt_each_txt" />
                        </td>
                        <td>
                            (หมายเหตุประกอบสูตร)
                        </td>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                        <td>
                            &nbsp;
                        </td>
                        <td>
                            &nbsp;
                        </td>
                    </tr>
                    <tr></tr>
                </table>
            </td>
        </tr>

        <tr>
            <td>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <input type="button" ID="btn_save" value="บันทึก" />
        </tr>
        <tr>
            <td></td>
        </tr>

        <tr>
            <td style="background-color:#FFCE33">1.2  ระบุส่วนประกอบของตำรับ</td>
        </tr>
        <tr>
            <td></td>
        </tr>

        <tr>
            <td>
                <input type="text" ID="txt_search" />&nbsp;&nbsp;&nbsp;<input type="button" ID="btn_search" value="ค้นหาสาร" /> &nbsp;
                <input type="button" ID="btn_rqt" value="การขอเพิ่มสาร" onclick="alert('ส่งเมลไปที่ drug-smarthelp@fda.moph.go.th หรือ แนบ cpp');" />
            </td>
        </tr>

        <tr>
            <td></td>
        </tr>
        <tr>
            //ตารางสาร
            </td>
        </tr>

        <tr>
            <td align="center">
                <table width="800px">
                    <tr>
                        <td colspan="4" align="left">&nbsp;</td>
                    </tr>
                    <tr>
                        <td colspan="4" align="left">กรุณาเลือกสารจากตารางด้านบนก่อนคลิกปุ่มเพิ่มสาร</td>
                    </tr>
                    <tr>
                        <td>ปริมาณยา/ปริมาณชีววัตถุ</td>
                        <td>
                            <select ID="ddl_CAS_TYPE">
                                <option value="1">ปริมาณยา</option>
                                <option value="2">ปริมาณชีววัตถุ</option>
                            </select>
                        </td>
                        <td>&nbsp;</td>
                        <td>
                            &nbsp;
                        </td>


                    </tr>
                    <tr>
                        <td>เงื่อนไข</td>
                        <td colspan="3" align="left">

                            <select ID="ddl_remark1">
                                <option>กรุณาเเลือก</option>
                                <option value="1">&lt;=</option>
                                <option value="2">&lt;</option>
                                <option value="3">=</option>
                                <option value="4">&gt;=</option>
                                <option value="5">&gt;</option>
                            </select>
                        </td>
                    </tr>
                    <tr>
                        <td>ปริมาณสาร (ตั้งต้น) : </td>
                        <td>
                            <input type="text" ID="txt_QTY" style="width:100px;" />
                        </td>
                        <td>หน่วย :</td>
                        <td>
                            @*<telerik:RadComboBox ID="rcb_unit" Runat="server" Filter="Contains">
        </telerik:RadComboBox>*@
                            <select class="dropdown" id="rcb_unit">
                                <option ng-repeat="x in UNIT_PHYSIC" value="{{x.sunitcd}}">{{x.unit_name}}</option>
                            </select>
                        </td>


                    </tr>
                    <tr>
                        <td>ปริมาณสาร (สุดท้าย) : </td>
                        <td>
                            <input type="text" ID="txt_QTY2" style="width:100px;" />
                        </td>
                        <td>หน่วย :</td>
                        <td>
                            <select class="dropdown" id="rcb_unit2">
                                <option ng-repeat="x in UNIT_PHYSIC" value="{{x.sunitcd}}">{{x.unit_name}}</option>
                            </select>
                            @*<telerik:RadComboBox ID="rcb_unit2" Runat="server" Filter="Contains">
        </telerik:RadComboBox>*@
                        </td>


                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                        <td>
                            &nbsp;
                        </td>
                        <td>
                            &nbsp;
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td>ปริมาณชีววัตถุ</td>
                        <td>
                            &nbsp;
                        </td>
                        <td>
                            &nbsp;
                        </td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>ปริมาณตั้งต้น</td>
                        <td>
                            <input type="text" ID="txt_sbioqty" />
                        </td>
                        <td>
                            หน่วยตั้งต้น :
                        </td>
                        <td>
                            <select class="dropdown" id="ddl_unit2">
                                <option ng-repeat="x in UNIT_PHYSIC" value="{{x.sunitcd}}">{{x.unit_name}}</option>
                            </select>
                        </td>
                    </tr>
                    <tr>
                        <td>เลขยกกำลัง(ตั้งต้น)</td>
                        <td>
                            <input type="text" ID="txt_sbiosqno" style="width:100px;" />
                        </td>
                        <td>
                            &nbsp;
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td>ปริมาณสุดท้าย</td>
                        <td>
                            <input type="text" ID="txt_ebioqty" style="width:100px;" />
                        </td>
                        <td>
                            หน่วยสุดท้าย :
                        </td>
                        <td>
                            <select class="dropdown" id="ddl_unit3">
                                <option ng-repeat="x in UNIT_PHYSIC" value="{{x.sunitcd}}">{{x.unit_name}}</option>
                            </select>
                        </td>
                    </tr>
                    <tr>
                        <td>เลขยกกำลัง(สุดท้าย)</td>
                        <td>
                            <input type="text" ID="txt_ebiosqno" style="width:100px" />
                        </td>
                        <td>
                            &nbsp;
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                        <td>
                            &nbsp;
                        </td>
                        <td>
                            &nbsp;
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td>เอกสารอ้างอิง</td>
                        <td align="left" colspan="3">
                            <input type="text" ID="txt_ref" style="width:100%" />
                        </td>
                    </tr>
                    <tr>
                        <td>หมายเหตุ</td>
                        <td align="left" colspan="3">
                            <input type="text" ID="txt_remark" style="width:100%" />
                        </td>
                    </tr>
                    <tr>
                        <td>สูตรที่</td>
                        <td>
                            <select ID="ddl_set" style="width:90px;">
                                <option>1</option>
                                <option>2</option>
                                <option>3</option>
                                <option>4</option>
                                <option>5</option>
                                <option>6</option>
                                <option>7</option>
                                <option>8</option>
                                <option>9</option>
                                <option>10</option>
                            </select>

                            @*<asp:DropDownList ID="ddl_set" runat="server" AutoPostBack="True" Width="90px">
                                    <asp:ListItem>1</asp:ListItem>
                                    <asp:ListItem>2</asp:ListItem>
                                    <asp:ListItem>3</asp:ListItem>
                                    <asp:ListItem>4</asp:ListItem>
                                    <asp:ListItem>5</asp:ListItem>
                                    <asp:ListItem>6</asp:ListItem>
                                    <asp:ListItem>7</asp:ListItem>
                                    <asp:ListItem>8</asp:ListItem>
                                    <asp:ListItem>9</asp:ListItem>
                                    <asp:ListItem>10</asp:ListItem>
                                </asp:DropDownList>*@
                        </td>
                        <td>
                            &nbsp;
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td>
                            ประเภทสาร A/I :
                        </td>
                        <td>

                            <select ID="ddl_aori">
                                <option>A</option>
                                <option>I</option>
                            </select>
                        </td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>ลำดับสาร</td>
                        <td>
                            <input type="number" ID="txt_ROWS" />
                        </td>
                        <td>

                            <input type="button" ID="btn_select" value="เพิ่มสาร" />
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                </table>



            </td>
        </tr>
        <tr>
            <td></td>
        </tr>
        <tr>
            <td></td>
        </tr>
        <tr>
            <td style="background-color:#FFCE33">
                1.3  รายละเอียดสูตร/ส่วนประกอบที่บันทึกข้อมูล
            </td>
        </tr>
        <tr>
            <td></td>
        </tr>
        <tr>
            <td>

                <asp:Label ID="lbl_each" runat="server" Text="-"></asp:Label>

            </td>
        </tr>
        <tr>

            <td>
                //ตารางสาร
            </td>
        </tr>
        <tr>
            <td align="center" >
                <table width="100%">
                    <tr>
                        <td><asp:Button ID="btn_save_cas" runat="server" Text="บันทึกสารที่เลือก" Style="display:none;" /></td>
                        <td> <asp:Button ID="btn_save_qty" runat="server" Text="บันทึกปริมาณสาร" /></td>
                    </tr>
                </table>



            </td>
        </tr>
    </table>
</div>