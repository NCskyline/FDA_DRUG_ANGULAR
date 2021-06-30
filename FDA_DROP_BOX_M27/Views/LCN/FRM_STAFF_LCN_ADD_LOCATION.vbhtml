
@*<script src="../Scripts_angular/CENTER_SV.js"></script>
<script src="~/Scripts_angular/LCN_CTRL.js"></script>*@
<div ng-controller="LCN_CTRL" ng-app="ANGULAR_APP">
    <h1>เลือกที่ตั้ง</h1>
    <table style="width:100%">
        <tr>
            <td colspan="2">
                <input type="radio" name="radio" ng-model="checked" value="1" style="margin-left:20%" /> เลือกสถานที่
                <input type="radio" name="radio" value="2" />อ้างอิงสถานที่
            </td>
        </tr>
    </table>
    <table style="width:100%">
        <tr>
            <td style="width:20%;padding-left:5%">
                ชื่อที่ตั้ง
            </td>
            <td>
                <select class="dropdown" ng-model="LIST_EDIT_LCN.LOCATION_SELECT">
                    <option value="0">--กรุณาเลือก--</option>
                    <option ng-repeat="x in REF_LOCATION" value="{{x.IDA}}">{{x.thanameplace}}</option>
                </select>
            </td>
        </tr>
        <tr>
            <td style="padding-left:5%">
                ที่ตั้ง (ใหม่)
            </td>
            <td>
                <label>{{LIST_EDIT_LCN.fulladdr4}}</label>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <input type="button" value="เลือกข้อมูล" style="margin-left:20%" />
            </td>
        </tr>
    </table>
    </div>
    @*<br />
    <div ng-switch="checked">
        <div ng-switch-when="1">
            <table style="width:100%">
                <tr>
                    <td style="width:20%;padding-left:5%">
                        เลือกสถานที่
                    </td>
                    <td>
                        <select style="width:70%">
                            <option>
                                1
                            </option>
                        </select>
                    </td>
                </tr>
                <tr>
                    <td style="padding-left:5%">
                        ชื่อสถานที่ (ภาษาไทย)
                    </td>
                    <td>
                        <input style="width:70%" />
                    </td>
                </tr>
                <tr>
                    <td style="padding-left:5%">
                        ชื่อสถานที่ (ภาษาอังกฤษ)
                    </td>
                    <td>
                        <input style="width:70%" />
                    </td>
                </tr>
            </table>
        </div>
    </div>
    <br />

    <div ng-switch="checked">
        <div ng-switch-when="2">
            <h1>ที่ตั้งสถานที่</h1>
            <table style="width:100%">
                <tr>
                    <td style="width:20%;padding-left:5%">
                        รหัสประจำบ้าน
                    </td>
                    <td>
                        <input style="width:70%" />
                    </td>
                </tr>
                <tr>
                    <td style="padding-left:5%">
                        เลขที่
                    </td>
                    <td>
                        <input style="width:70%" />
                    </td>
                </tr>
                <tr>
                    <td style="padding-left:5%">
                        อาคาร/ตึก
                    </td>
                    <td>
                        <input style="width:70%" />
                    </td>
                </tr>
                <tr>
                    <td style="padding-left:5%">
                        ชั้น
                    </td>
                    <td>
                        <input style="width:70%" />*กรุณากรอกคำว่า "ชั้น" เช่น ชั้น 3
                    </td>
                </tr>
                <tr>
                    <td style="padding-left:5%">
                        ห้อง
                    </td>
                    <td>
                        <input style="width:70%" />*กรุณากรอกคำว่า "ห้อง" เช่น ห้อง 241
                    </td>
                </tr>
                <tr>
                    <td style="padding-left:5%">
                        หมู่
                    </td>
                    <td>
                        <input style="width:70%" />*กรุณากรอกคำว่า "อาคาร" เช่น อาคาร 1
                    </td>
                </tr>
                <tr>
                    <td style="padding-left:5%">
                        ซอย
                    </td>
                    <td>
                        <input style="width:70%" />
                    </td>
                </tr>
                <tr>
                    <td style="padding-left:5%">
                        ถนน
                    </td>
                    <td>
                        <input style="width:70%" />
                    </td>
                </tr>
                <tr>
                    <td style="width:20%;padding-left:5%">
                        จังหวัด
                    </td>
                    <td>
                        <select style="width:70%">
                            <option>
                                1
                            </option>
                        </select>
                    </td>
                </tr>
                <tr>
                    <td style="width:20%;padding-left:5%">
                        เขต/อำเภอ
                    </td>
                    <td>
                        <select style="width:70%">
                            <option>
                                1
                            </option>
                        </select>
                    </td>
                </tr>
                <tr>
                    <td style="width:20%;padding-left:5%">
                        แขวง/ตำบล
                    </td>
                    <td>
                        <select style="width:70%">
                            <option>
                                1
                            </option>
                        </select>
                    </td>
                </tr>
                <tr>
                    <td style="padding-left:5%">
                        รหัสไปรษณีย์
                    </td>
                    <td>
                        <input style="width:70%" />
                    </td>
                </tr>
                <tr>
                    <td style="padding-left:5%">
                        โทรศัพท์
                    </td>
                    <td>
                        <input style="width:70%" />
                    </td>
                </tr>
                <tr>
                    <td style="padding-left:5%">
                        โทรศัพท์มือถือ
                    </td>
                    <td>
                        <input style="width:70%" />
                    </td>
                </tr>
                <tr>
                    <td style="padding-left:5%">
                        โทรสาร
                    </td>
                    <td>
                        <input style="width:70%" />
                    </td>
                </tr>
                <tr>
                    <td style="padding-left:5%">
                        latitude(ถ้าไม่มีใส่ 0)
                    </td>
                    <td>
                        <input style="width:70%" />
                    </td>
                </tr>
                <tr>
                    <td style="padding-left:5%">
                        longitude(ถ้าไม่มีใส่ 0)
                    </td>
                    <td>
                        <input style="width:70%" />
                    </td>
                </tr>
            </table>

            <input type="button" value="บันทึกเเละใช้สถานที่" style="margin-left:20%" />
        </div>
    </div>
</div>*@