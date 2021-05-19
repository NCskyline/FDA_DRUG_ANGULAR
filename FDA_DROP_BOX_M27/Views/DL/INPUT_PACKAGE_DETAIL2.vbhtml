@Code
    ViewData("Title") = "INPUT_PACKAGE_DETAIL2"
End Code
<script src="~/Scripts_angular/CENTER_SV.js"></script>
<script src="~/Scripts_angular/DL_CTRL.js"></script>
<div class="ic" ng-controller="DL_CTRL" ng-app="ANGULAR_APP">
    <h2>INPUT_PACKAGE_DETAIL2</h2>
    <div class="box">
        <div>
            <h1>
                <asp:Label ID="lbl_head" runat="server" Text="-" Font-Size="X-Large"></asp:Label>
            </h1>
            <table class="table" style="width: 100%;">
                <tr>
                    <td>
                        <table>
                            <tr>
                                <td>
                                    ชื่อขนาดบรรจุ
                                </td>
                                <td>
                                    <input type="text" id="txt_packagename" />
                                </td>
                                <td></td>
                                <td style="color:red">ตัวอย่าง 10 เม็ด x 4 แผง x กล่อง</td>
                            </tr>
                            <tr>
                                <td>Primary package จำนวน</td>
                                <td>
                                    <input type="text" id="txt_sunit" style="height:22px;" />
                                </td>
                                <td>
                                    <label ID="lbl_sunit"></label>
                                    &nbsp;ต่อ
                                </td>
                                <td>
                                    <table>
                                        <tr>
                                            <td>
                                                <label ID="lbl_small_unit" style="display:none;"></label>
                                            </td>
                                            <td>
                                                @*<select id="ddl_munit">
                                                    <option>
                                                        กรุณาเลือก
                                                    </option>
                                                </select>*@
                                                <select class="dropdown" id="ddl_munit">
                                                    <option ng-repeat="x in UNIT_PHYSIC" value="{{x.sunitcd}}">{{x.unit_name}}</option>
                                                </select>
                                            </td>
                                        </tr>
                                    </table>


                                </td>
                            </tr>
                            <tr>
                                <td>Secondary package จำนวน</td>
                                <td>
                                    <input type="text" id="txt_mamount" />
                                </td>
                                <td>
                                    <label ID="lbl_munit"></label>
                                    &nbsp;ต่อ
                                </td>
                                <td>
                                    @*<select id="ddl_bunit">
                                        <option>
                                            กรุณาเลือก
                                        </option>
                                    </select>*@

                                    <select class="dropdown" id="ddl_bunit">
                                        <option ng-repeat="x in UNIT_PHYSIC" value="{{x.sunitcd}}">{{x.unit_name}}</option>
                                    </select>
                                </td>
                            </tr>
                            <tr>
                                <td>GTIN (กรณีไม่มีให้ใส่0)</td>
                                <td>
                                    <input type="text" id="txt_barcode" />
                                </td>
                                <td>
                                    &nbsp;
                                </td>
                                <td>

                                    <label ID="lbl_sunit_ida" style="display:none;"></label>
                                </td>
                            </tr>
                        </table>


                        <br />
                        <button ID="btn_add" style="height:53px;width:180px;">บันทึกขนาดบรรจุ</button>
                        <button ID="btn_eddt" style="height:53px;width:180px;">แก้ไขขนาดบรรจุ</button>
                        <button ID="btn_edre" style="height:53px;width:180px;">ยกเลิกการแก้ไข</button>
                        <br />
                    </td>
                </tr>
            </table>
        </div>

        //ตารางสาร

        <center>
            <br />
            <asp:Button ID="btn_back" runat="server" Text="ย้อนกลับ" CssClass="auto-style11" Height="53px" Width="180px"></asp:Button>
        </center>
        </p>
    </div>
</div>