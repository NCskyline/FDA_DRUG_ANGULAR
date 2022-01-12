@Code
    ViewData("Title") = "INPUT_PACKAGE_DETAIL2"
End Code

<div class="box ic">
    <div style="font-family:'Taviraj'">
        <h1>
            <asp:Label ID="lbl_head" runat="server" Text="-" Font-Size="X-Large"></asp:Label>
        </h1>
        <h1>เพิ่ม/ลบขนาดบรรจุสำหรับยาตัวอย่าง</h1>
        <table class="table" style="width: 100%;">
            <tr>
                <td>
                    <table width="100%" style="font-size:20px">
                        <tr>
                            <td>
                                ชื่อขนาดบรรจุ
                            </td>
                            <td>
                                <input type="text" class="form-control" id="txt_packagename" />
                            </td>
                            <td width="5%"></td>
                            <td style="color:red">ตัวอย่าง 10 เม็ด x 4 แผง x กล่อง</td>
                        </tr>
                        <tr>
                            <td>Primary package จำนวน</td>
                            <td>
                                <input type="text" class="form-control" id="txt_sunit" />
                            </td>
                            <td>
                                <label ID="lbl_sunit"></label>
                            </td>
                            <td>ต่อ</td>
                            <td>
                                <label ID="lbl_small_unit" style="display:none;"></label>
                            </td>
                            <td>
                                <select id="ddl_munit" class="form-control selectpicker" data-live-search="true" title="-- Please select --">
                                    <option>
                                    </option>
                                </select>
                            </td>
                        </tr>
                        <tr>
                            <td>Secondary package จำนวน</td>
                            <td>
                                <input type="text" class="form-control" id="txt_mamount" />
                            </td>
                            <td>
                                <label ID="lbl_munit"></label>
                            </td>
                            <td>ต่อ</td>
                            <td>
                                <select id="ddl_bunit" class="form-control selectpicker" data-live-search="true" title="-- Please select --">
                                    <option></option>
                                </select>
                            </td>
                        </tr>
                        <tr>
                            <td>GTIN (กรณีไม่มีให้ใส่0)</td>
                            <td>
                                <input type="text" class="form-control" id="txt_barcode" />
                            </td>
                            <td>
                                &nbsp;
                            </td>
                            <td>
                                <label ID="lbl_sunit_ida" style="display:none;"></label>
                            </td>
                            <td></td>
                        </tr>
                    </table>
                    <div style="text-align:center;margin-bottom:40px">
                        <button ID="btn_add" class="form-control">บันทึกขนาดบรรจุ</button>
                        <button ID="btn_eddt" style="height:53px;width:180px;">แก้ไขขนาดบรรจุ</button>
                        <button ID="btn_edre" style="height:53px;width:180px;">ยกเลิกการแก้ไข</button>
                    </div>
                </td>
            </tr>
        </table>
    </div>
    <br />
    <div class="row">
        <div class="col-sm-12" style="width:100%">
            <div class="card" style="border-top:10px solid #F9D027">
                <table width="100%" class="table">
                    <thead>
                        <tr>
                            <td style="text-align:center">ลำดับ</td>
                            <td style="text-align:center">ชื่อขนาดบรรจุ</td>
                            <td style="text-align:center">จำนวน</td>
                            <td style="text-align:center">หน่วย</td>
                            <td style="text-align:center">ต่อ</td>
                            <td style="text-align:center">จำนวน</td>
                            <td style="text-align:center">หน่วย</td>
                            <td style="text-align:center">ต่อ</td>
                            <td style="text-align:center">จำนวน</td>
                            <td style="text-align:center">หน่วย</td>
                            <td style="text-align:center">หมายเลขบาร์โค้ด</td>
                            <td></td>
                            <td></td>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <td></td>
                            <td></td>
                            <td></td>
                            <td></td>
                            <td></td>
                            <td></td>
                            <td></td>
                            <td></td>
                            <td></td>
                            <td></td>
                            <td></td>
                            <td>
                                <span class="fa fa-pen"></span>
                                <a ng-click="">
                                    แก้ไขข้อมูล
                                </a>
                            </td>
                            <td>
                                <a ng-click="">
                                    ลบข้อมูล
                                </a>
                            </td>
                        </tr>
                    </tbody>
                </table>
            </div>
        </div>
    </div>
    <br />
    <center>
        <br />
        <asp:Button ID="btn_back" runat="server" Text="ย้อนกลับ" CssClass="auto-style11" Height="53px" Width="180px"></asp:Button>
    </center>
</div>