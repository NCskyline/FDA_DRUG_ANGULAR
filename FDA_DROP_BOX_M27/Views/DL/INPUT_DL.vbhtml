@Code
    ViewData("Title") = "INPUT_DL"
End Code
    <script src="~/Scripts_angular/ANGULAR_APP.js"></script>
    <script src="~/Scripts_angular/CENTER_SV.js"></script>
    <script src="~/Scripts_angular/DL_CTRL.js"></script>

    <div ng-app="ANGULAR_APP" ng-controller="DL_CTRL">
        <div class="in">
            <table width="100%">
                <tr>
                    <td align="center">
                        <h2>
                            สร้างตำรับ<br />
                        </h2>
                    </td>
                </tr>
            </table>
            <table width="100%" class="auto-style1">
                <tr>
                    <td width="30%">
                        1.1 ชื่อการค้า (ภาษาไทย)
                    </td>
                    <td>
                        <input type="text" class="form-control" id="txt_namethai" />
                    </td>
                </tr>
                <tr>
                    <td>
                        1.2 ชื่อการค้า (ภาษาอังกฤษ)
                    </td>
                    <td>
                        <input type="text" class="form-control" id="txt_nameeng" />
                    </td>
                </tr>
                <tr>
                    <td>
                        2. ยาใหม่
                    </td>
                    <td>

                        <form name="myForm">
                            <label>
                                <input type="radio" ng-model="LCN.TYPE" value="1">
                                ยาใหม่
                            </label>
                            <label>
                                <input type="radio" ng-model="LCN.TYPE" value="2">
                                ไม่ใช่ยาใหม่
                            </label>
                        </form>
                    </td>
                </tr>
                <tr>
                    <td>
                        3. คำบรรยายลักษณะของยา
                    </td>
                    <td>
                        <textarea class="form-control" id="txt_DRUG_COLOR" style="width:100%;"></textarea>

                    </td>
                </tr>
            </table>
            <br />
            <div>
                <button id="btn_save" onclick="return confirm('โปรดตรวจสอบชื่อการค้าให้ถูกต้องก่อนกดบึนทึก');">บันทึก</button>
                <button id="btn_back">ปิดหน้าต่าง</button>
            </div>
        </div>
        
    </div>

