@Code
    ViewData("Title") = "INPUT_DL"
End Code

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
                <td>
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

                    <form name="myForm" ng-controller="ExampleController">
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
            <tr>
                <td colspan="2" align="center">
                    <button id="btn_save" onclick="return confirm('โปรดตรวจสอบชื่อการค้าให้ถูกต้องก่อนกดบึนทึก');">บันทึก</button>
                    <button id="btn_back">ปิดหน้าต่าง</button>
                </td>
            </tr>
        </table>
    </div>
