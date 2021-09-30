
<script src="../Scripts_angular/ANGULAR_APP.js"></script>
<script src="../Scripts_angular/CENTER_SV.js"></script>
<script src="../Scripts_angular/LCN_STAFF_EDIT_CTRL.js"></script>

<script type="text/javascript">
    $(document).ready(function () {
        $('select').selectpicker('refresh');
    })
</script>

<div ng-controller="LCN_STAFF_EDIT_CTRL" ng-app="ANGULAR_APP" ng-init="pageload()">
    <h1>เลือกสถานที่เก็บ </h1>
    <table style="width:100%">
        <tr>
            <td style="width:20%;padding-left:5%">
                ชื่อสถานที่เก็บ
            </td>
            <td>

                <select class="form-control selectpicker" data-live-search="true" title="-- Please select --" ng-model="LIST_EDIT_LCN.LOCATION_SELECT" ng-change="getdetails_1(LIST_EDIT_LCN.LOCATION_SELECT)">
                    <option ng-repeat="x in REF_LOCATION_KEEP" value="{{x.IDA}}">{{x.thanameplace}}</option>
                </select>
            </td>
        </tr>
        <tr>
            <td style="padding-left:5%">
                ที่เก็บ (ใหม่)
            </td>
            <td>
                <label>{{LIST_LABEL.fulladdr}}</label>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <input type="hidden" ng-model="LIST_EDIT_LCN.LOCATION_SELECT" id="txt_hidden" />
                <input type="button" value="เพิ่มข้อมูล" style="margin-left:20%" ng-click="BTN_SAVE_KEEP(LIST_EDIT_LCN.LOCATION_SELECT)" />
            </td>
        </tr>
    </table>
</div>

@*<h1>ประเภทสถานที่<span style="margin-left:5%">สถานที่เก็บ</span></h1>
    <br />
    <h1>ชื่อสถานที่</h1>
    <div>
        <table style="width:100%">
            <tr>
                <td style="width:20%;padding-left:5%" ">
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
        <br />

        <h1>ที่ตั้งสถานที่</h1>
        <table style="width:100%">
            <tr>
                <td style="width:20%;padding-left:5%">
                    รหัสประจำบ้าน
                </td>
                <td>
                    <input style="width:70%" /><input type="button" value="ดึงข้อมูล" />(หมายเหตุ สามารถดึงได้ทีละเลข)
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
    </div>
    <input type="button" value="บันทึกข้อมูล" style="margin-left:20%" />*@